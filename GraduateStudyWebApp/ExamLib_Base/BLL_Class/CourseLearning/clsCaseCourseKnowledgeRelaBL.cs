
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseKnowledgeRelaBL
 表名:CaseCourseKnowledgeRela(01120392)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:02
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
public static class  clsCaseCourseKnowledgeRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseKnowledgeRelaEN GetObj(this K_IdCaseCourseKnowledgeRela_CaseCourseKnowledgeRela myKey)
{
clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.GetObjByIdCaseCourseKnowledgeRela(myKey.Value);
return objCaseCourseKnowledgeRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCaseCourseKnowledgeRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],知识点Id = [{1}]的数据已经存在!(in clsCaseCourseKnowledgeRelaBL.AddNewRecord)", objCaseCourseKnowledgeRelaEN.CaseId,objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.AddNewRecordBySQL2(objCaseCourseKnowledgeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
public static bool AddRecordEx(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objCaseCourseKnowledgeRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCaseCourseKnowledgeRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例Id(CaseId)=[{0}],知识点Id(CourseKnowledgeId)=[{1}])已经存在,不能重复!", objCaseCourseKnowledgeRelaEN.CaseId, objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCaseCourseKnowledgeRelaEN.AddNewRecord();
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCaseCourseKnowledgeRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],知识点Id = [{1}]的数据已经存在!(in clsCaseCourseKnowledgeRelaBL.AddNewRecordWithReturnKey)", objCaseCourseKnowledgeRelaEN.CaseId,objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.AddNewRecordBySQL2WithReturnKey(objCaseCourseKnowledgeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetIdCaseCourseKnowledgeRela(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, long lngIdCaseCourseKnowledgeRela, string strComparisonOp="")
	{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = lngIdCaseCourseKnowledgeRela; //案例知识点关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetFuncModuleId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseCourseKnowledgeRela.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseCourseKnowledgeRela.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseCourseKnowledgeRela.FuncModuleId);
}
objCaseCourseKnowledgeRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.FuncModuleId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.FuncModuleId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.FuncModuleId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetCaseId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseCourseKnowledgeRela.CaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseCourseKnowledgeRela.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseCourseKnowledgeRela.CaseId);
}
objCaseCourseKnowledgeRelaEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.CaseId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.CaseId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.CaseId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetCaseName(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, conCaseCourseKnowledgeRela.CaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseCourseKnowledgeRela.CaseName);
}
objCaseCourseKnowledgeRelaEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.CaseName) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.CaseName, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.CaseName] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetOwnerId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseCourseKnowledgeRela.OwnerId);
}
objCaseCourseKnowledgeRelaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.OwnerId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.OwnerId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.OwnerId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetCourseKnowledgeId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, conCaseCourseKnowledgeRela.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, conCaseCourseKnowledgeRela.CourseKnowledgeId);
}
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.CourseKnowledgeId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.CourseKnowledgeId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.CourseKnowledgeId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetIdCaseCourseKnowledgeRelaType(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strIdCaseCourseKnowledgeRelaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseCourseKnowledgeRelaType, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseCourseKnowledgeRelaType, 4, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseCourseKnowledgeRelaType, 4, conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType);
}
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = strIdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetRelationsDegree(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, int intRelationsDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intRelationsDegree, conCaseCourseKnowledgeRela.RelationsDegree);
objCaseCourseKnowledgeRelaEN.RelationsDegree = intRelationsDegree; //关系度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.RelationsDegree) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.RelationsDegree, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.RelationsDegree] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetBrowseCount(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, int intBrowseCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intBrowseCount, conCaseCourseKnowledgeRela.BrowseCount);
objCaseCourseKnowledgeRelaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.BrowseCount) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.BrowseCount, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.BrowseCount] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetOrderNum(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objCaseCourseKnowledgeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.OrderNum) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.OrderNum, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.OrderNum] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetUpdDate(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseCourseKnowledgeRela.UpdDate);
}
objCaseCourseKnowledgeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.UpdDate) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.UpdDate, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.UpdDate] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetUpdUserId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseCourseKnowledgeRela.UpdUserId);
}
objCaseCourseKnowledgeRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.UpdUserId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.UpdUserId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.UpdUserId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetMemo(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseCourseKnowledgeRela.Memo);
}
objCaseCourseKnowledgeRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.Memo) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.Memo, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.Memo] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCaseCourseKnowledgeRelaEN.CheckPropertyNew();
clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaCond = new clsCaseCourseKnowledgeRelaEN();
string strCondition = objCaseCourseKnowledgeRelaCond
.SetIdCaseCourseKnowledgeRela(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, "<>")
.SetCaseId(objCaseCourseKnowledgeRelaEN.CaseId, "=")
.SetCourseKnowledgeId(objCaseCourseKnowledgeRelaEN.CourseKnowledgeId, "=")
.GetCombineCondition();
objCaseCourseKnowledgeRelaEN._IsCheckProperty = true;
bool bolIsExist = clsCaseCourseKnowledgeRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CaseId_CourseKnowledgeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCaseCourseKnowledgeRelaEN.Update();
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
 /// <param name = "objCaseCourseKnowledgeRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaCond = new clsCaseCourseKnowledgeRelaEN();
string strCondition = objCaseCourseKnowledgeRelaCond
.SetCaseId(objCaseCourseKnowledgeRela.CaseId, "=")
.SetCourseKnowledgeId(objCaseCourseKnowledgeRela.CourseKnowledgeId, "=")
.GetCombineCondition();
objCaseCourseKnowledgeRela._IsCheckProperty = true;
bool bolIsExist = clsCaseCourseKnowledgeRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela = clsCaseCourseKnowledgeRelaBL.GetFirstID_S(strCondition);
objCaseCourseKnowledgeRela.UpdateWithCondition(strCondition);
}
else
{
objCaseCourseKnowledgeRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.UpdateBySql2(objCaseCourseKnowledgeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.UpdateBySql2(objCaseCourseKnowledgeRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.UpdateBySqlWithCondition(objCaseCourseKnowledgeRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.UpdateBySqlWithConditionTransaction(objCaseCourseKnowledgeRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "lngIdCaseCourseKnowledgeRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
try
{
int intRecNum = clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.DelRecord(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseKnowledgeRelaENS">源对象</param>
 /// <param name = "objCaseCourseKnowledgeRelaENT">目标对象</param>
 public static void CopyTo(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENS, clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENT)
{
try
{
objCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRela = objCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRela; //案例知识点关系流水号
objCaseCourseKnowledgeRelaENT.FuncModuleId = objCaseCourseKnowledgeRelaENS.FuncModuleId; //功能模块Id
objCaseCourseKnowledgeRelaENT.CaseId = objCaseCourseKnowledgeRelaENS.CaseId; //案例Id
objCaseCourseKnowledgeRelaENT.CaseName = objCaseCourseKnowledgeRelaENS.CaseName; //案例名称
objCaseCourseKnowledgeRelaENT.OwnerId = objCaseCourseKnowledgeRelaENS.OwnerId; //拥有者Id
objCaseCourseKnowledgeRelaENT.CourseKnowledgeId = objCaseCourseKnowledgeRelaENS.CourseKnowledgeId; //知识点Id
objCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaENT.RelationsDegree = objCaseCourseKnowledgeRelaENS.RelationsDegree; //关系度
objCaseCourseKnowledgeRelaENT.BrowseCount = objCaseCourseKnowledgeRelaENS.BrowseCount; //浏览次数
objCaseCourseKnowledgeRelaENT.OrderNum = objCaseCourseKnowledgeRelaENS.OrderNum; //序号
objCaseCourseKnowledgeRelaENT.UpdDate = objCaseCourseKnowledgeRelaENS.UpdDate; //修改日期
objCaseCourseKnowledgeRelaENT.UpdUserId = objCaseCourseKnowledgeRelaENS.UpdUserId; //修改用户Id
objCaseCourseKnowledgeRelaENT.Memo = objCaseCourseKnowledgeRelaENS.Memo; //备注
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
 /// <param name = "objCaseCourseKnowledgeRelaENS">源对象</param>
 /// <returns>目标对象=>clsCaseCourseKnowledgeRelaEN:objCaseCourseKnowledgeRelaENT</returns>
 public static clsCaseCourseKnowledgeRelaEN CopyTo(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENS)
{
try
{
 clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENT = new clsCaseCourseKnowledgeRelaEN()
{
IdCaseCourseKnowledgeRela = objCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRela, //案例知识点关系流水号
FuncModuleId = objCaseCourseKnowledgeRelaENS.FuncModuleId, //功能模块Id
CaseId = objCaseCourseKnowledgeRelaENS.CaseId, //案例Id
CaseName = objCaseCourseKnowledgeRelaENS.CaseName, //案例名称
OwnerId = objCaseCourseKnowledgeRelaENS.OwnerId, //拥有者Id
CourseKnowledgeId = objCaseCourseKnowledgeRelaENS.CourseKnowledgeId, //知识点Id
IdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRelaType, //案例知识点关系类型流水号
RelationsDegree = objCaseCourseKnowledgeRelaENS.RelationsDegree, //关系度
BrowseCount = objCaseCourseKnowledgeRelaENS.BrowseCount, //浏览次数
OrderNum = objCaseCourseKnowledgeRelaENS.OrderNum, //序号
UpdDate = objCaseCourseKnowledgeRelaENS.UpdDate, //修改日期
UpdUserId = objCaseCourseKnowledgeRelaENS.UpdUserId, //修改用户Id
Memo = objCaseCourseKnowledgeRelaENS.Memo, //备注
};
 return objCaseCourseKnowledgeRelaENT;
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
public static void CheckPropertyNew(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.CheckPropertyNew(objCaseCourseKnowledgeRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 clsCaseCourseKnowledgeRelaBL.CaseCourseKnowledgeRelaDA.CheckProperty4Condition(objCaseCourseKnowledgeRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela) == true)
{
string strComparisonOpIdCaseCourseKnowledgeRela = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaCond.IdCaseCourseKnowledgeRela, strComparisonOpIdCaseCourseKnowledgeRela);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.FuncModuleId, objCaseCourseKnowledgeRelaCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.CaseId) == true)
{
string strComparisonOpCaseId = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.CaseId, objCaseCourseKnowledgeRelaCond.CaseId, strComparisonOpCaseId);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.CaseName) == true)
{
string strComparisonOpCaseName = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.CaseName, objCaseCourseKnowledgeRelaCond.CaseName, strComparisonOpCaseName);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.OwnerId) == true)
{
string strComparisonOpOwnerId = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.OwnerId, objCaseCourseKnowledgeRelaCond.OwnerId, strComparisonOpOwnerId);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.CourseKnowledgeId, objCaseCourseKnowledgeRelaCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType) == true)
{
string strComparisonOpIdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType, objCaseCourseKnowledgeRelaCond.IdCaseCourseKnowledgeRelaType, strComparisonOpIdCaseCourseKnowledgeRelaType);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.RelationsDegree) == true)
{
string strComparisonOpRelationsDegree = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.RelationsDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseKnowledgeRela.RelationsDegree, objCaseCourseKnowledgeRelaCond.RelationsDegree, strComparisonOpRelationsDegree);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseKnowledgeRela.BrowseCount, objCaseCourseKnowledgeRelaCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseKnowledgeRela.OrderNum, objCaseCourseKnowledgeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.UpdDate, objCaseCourseKnowledgeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.UpdUserId, objCaseCourseKnowledgeRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objCaseCourseKnowledgeRelaCond.IsUpdated(conCaseCourseKnowledgeRela.Memo) == true)
{
string strComparisonOpMemo = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[conCaseCourseKnowledgeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.Memo, objCaseCourseKnowledgeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CaseCourseKnowledgeRela(案例知识点关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CaseId_CourseKnowledgeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCaseCourseKnowledgeRelaEN == null) return true;
if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseKnowledgeRelaEN.CaseId);
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId == null)
{
 sbCondition.AppendFormat(" and CourseKnowledgeId is null", objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
}
else
{
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
}
if (clsCaseCourseKnowledgeRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdCaseCourseKnowledgeRela !=  {0}", objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseKnowledgeRelaEN.CaseId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
if (clsCaseCourseKnowledgeRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CaseCourseKnowledgeRela(案例知识点关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CaseId_CourseKnowledgeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseCourseKnowledgeRelaEN == null) return "";
if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseKnowledgeRelaEN.CaseId);
 if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId == null)
{
 sbCondition.AppendFormat(" and CourseKnowledgeId is null", objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
}
else
{
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdCaseCourseKnowledgeRela !=  {0}", objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseKnowledgeRelaEN.CaseId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CaseCourseKnowledgeRela
{
public virtual bool UpdRelaTabDate(long lngIdCaseCourseKnowledgeRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例知识点关系(CaseCourseKnowledgeRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCaseCourseKnowledgeRelaBL
{
public static RelatedActions_CaseCourseKnowledgeRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCaseCourseKnowledgeRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCaseCourseKnowledgeRelaDA CaseCourseKnowledgeRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCaseCourseKnowledgeRelaDA();
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
 public clsCaseCourseKnowledgeRelaBL()
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
if (string.IsNullOrEmpty(clsCaseCourseKnowledgeRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseCourseKnowledgeRelaEN._ConnectString);
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
public static DataTable GetDataTable_CaseCourseKnowledgeRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CaseCourseKnowledgeRelaDA.GetDataTable_CaseCourseKnowledgeRela(strWhereCond);
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
objDT = CaseCourseKnowledgeRelaDA.GetDataTable(strWhereCond);
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
objDT = CaseCourseKnowledgeRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CaseCourseKnowledgeRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CaseCourseKnowledgeRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CaseCourseKnowledgeRelaDA.GetDataTable_Top(objTopPara);
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
objDT = CaseCourseKnowledgeRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CaseCourseKnowledgeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CaseCourseKnowledgeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseCourseKnowledgeRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstByIdCaseCourseKnowledgeRelaLst(List<long> arrIdCaseCourseKnowledgeRelaLst)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseCourseKnowledgeRelaLst);
 string strWhereCond = string.Format("IdCaseCourseKnowledgeRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseCourseKnowledgeRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCaseCourseKnowledgeRelaEN> GetObjLstByIdCaseCourseKnowledgeRelaLstCache(List<long> arrIdCaseCourseKnowledgeRelaLst)
{
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName);
List<clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLst_Sel =
arrCaseCourseKnowledgeRelaObjLstCache
.Where(x => arrIdCaseCourseKnowledgeRelaLst.Contains(x.IdCaseCourseKnowledgeRela));
return arrCaseCourseKnowledgeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLst(string strWhereCond)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
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
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCaseCourseKnowledgeRelaEN> GetSubObjLstCache(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaCond)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCourseKnowledgeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseCourseKnowledgeRela.AttributeName)
{
if (objCaseCourseKnowledgeRelaCond.IsUpdated(strFldName) == false) continue;
if (objCaseCourseKnowledgeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCourseKnowledgeRelaCond[strFldName].ToString());
}
else
{
if (objCaseCourseKnowledgeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCourseKnowledgeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseCourseKnowledgeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseCourseKnowledgeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseCourseKnowledgeRelaCond[strFldName]));
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
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
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
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
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
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCaseCourseKnowledgeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
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
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
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
public static List<clsCaseCourseKnowledgeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
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
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLst = new List<clsCaseCourseKnowledgeRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = new clsCaseCourseKnowledgeRelaEN();
try
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = Int32.Parse(objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela].ToString().Trim()); //案例知识点关系流水号
objCaseCourseKnowledgeRelaEN.FuncModuleId = objRow[conCaseCourseKnowledgeRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCourseKnowledgeRelaEN.CaseId = objRow[conCaseCourseKnowledgeRela.CaseId].ToString().Trim(); //案例Id
objCaseCourseKnowledgeRelaEN.CaseName = objRow[conCaseCourseKnowledgeRela.CaseName].ToString().Trim(); //案例名称
objCaseCourseKnowledgeRelaEN.OwnerId = objRow[conCaseCourseKnowledgeRela.OwnerId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objRow[conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType].ToString().Trim(); //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaEN.RelationsDegree = Int32.Parse(objRow[conCaseCourseKnowledgeRela.RelationsDegree].ToString().Trim()); //关系度
objCaseCourseKnowledgeRelaEN.BrowseCount = Int32.Parse(objRow[conCaseCourseKnowledgeRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseCourseKnowledgeRelaEN.OrderNum = objRow[conCaseCourseKnowledgeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCourseKnowledgeRela.OrderNum].ToString().Trim()); //序号
objCaseCourseKnowledgeRelaEN.UpdDate = objRow[conCaseCourseKnowledgeRela.UpdDate] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdDate].ToString().Trim(); //修改日期
objCaseCourseKnowledgeRelaEN.UpdUserId = objRow[conCaseCourseKnowledgeRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCourseKnowledgeRelaEN.Memo = objRow[conCaseCourseKnowledgeRela.Memo] == DBNull.Value ? null : objRow[conCaseCourseKnowledgeRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCourseKnowledgeRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCaseCourseKnowledgeRela(ref clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
bool bolResult = CaseCourseKnowledgeRelaDA.GetCaseCourseKnowledgeRela(ref objCaseCourseKnowledgeRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseKnowledgeRelaEN GetObjByIdCaseCourseKnowledgeRela(long lngIdCaseCourseKnowledgeRela)
{
clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = CaseCourseKnowledgeRelaDA.GetObjByIdCaseCourseKnowledgeRela(lngIdCaseCourseKnowledgeRela);
return objCaseCourseKnowledgeRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCaseCourseKnowledgeRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = CaseCourseKnowledgeRelaDA.GetFirstObj(strWhereCond);
 return objCaseCourseKnowledgeRelaEN;
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
public static clsCaseCourseKnowledgeRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = CaseCourseKnowledgeRelaDA.GetObjByDataRow(objRow);
 return objCaseCourseKnowledgeRelaEN;
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
public static clsCaseCourseKnowledgeRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = CaseCourseKnowledgeRelaDA.GetObjByDataRow(objRow);
 return objCaseCourseKnowledgeRelaEN;
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
 /// <param name = "lngIdCaseCourseKnowledgeRela">所给的关键字</param>
 /// <param name = "lstCaseCourseKnowledgeRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCourseKnowledgeRelaEN GetObjByIdCaseCourseKnowledgeRelaFromList(long lngIdCaseCourseKnowledgeRela, List<clsCaseCourseKnowledgeRelaEN> lstCaseCourseKnowledgeRelaObjLst)
{
foreach (clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN in lstCaseCourseKnowledgeRelaObjLst)
{
if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela == lngIdCaseCourseKnowledgeRela)
{
return objCaseCourseKnowledgeRelaEN;
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
 long lngIdCaseCourseKnowledgeRela;
 try
 {
 lngIdCaseCourseKnowledgeRela = new clsCaseCourseKnowledgeRelaDA().GetFirstID(strWhereCond);
 return lngIdCaseCourseKnowledgeRela;
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
 arrList = CaseCourseKnowledgeRelaDA.GetID(strWhereCond);
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
bool bolIsExist = CaseCourseKnowledgeRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdCaseCourseKnowledgeRela)
{
//检测记录是否存在
bool bolIsExist = CaseCourseKnowledgeRelaDA.IsExist(lngIdCaseCourseKnowledgeRela);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdCaseCourseKnowledgeRela">案例知识点关系流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdCaseCourseKnowledgeRela, string strOpUser)
{
clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = clsCaseCourseKnowledgeRelaBL.GetObjByIdCaseCourseKnowledgeRela(lngIdCaseCourseKnowledgeRela);
objCaseCourseKnowledgeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCaseCourseKnowledgeRelaEN.UpdUserId = strOpUser;
return clsCaseCourseKnowledgeRelaBL.UpdateBySql2(objCaseCourseKnowledgeRelaEN);
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
 bolIsExist = clsCaseCourseKnowledgeRelaDA.IsExistTable();
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
 bolIsExist = CaseCourseKnowledgeRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCaseCourseKnowledgeRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],知识点Id = [{1}]的数据已经存在!(in clsCaseCourseKnowledgeRelaBL.AddNewRecordBySql2)", objCaseCourseKnowledgeRelaEN.CaseId,objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CaseCourseKnowledgeRelaDA.AddNewRecordBySQL2(objCaseCourseKnowledgeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCaseCourseKnowledgeRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],知识点Id = [{1}]的数据已经存在!(in clsCaseCourseKnowledgeRelaBL.AddNewRecordBySql2WithReturnKey)", objCaseCourseKnowledgeRelaEN.CaseId,objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
throw new Exception(strMsg);
}
try
{
string strKey = CaseCourseKnowledgeRelaDA.AddNewRecordBySQL2WithReturnKey(objCaseCourseKnowledgeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
try
{
bool bolResult = CaseCourseKnowledgeRelaDA.Update(objCaseCourseKnowledgeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 if (objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CaseCourseKnowledgeRelaDA.UpdateBySql2(objCaseCourseKnowledgeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaBL.ReFreshCache();

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
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
 /// <param name = "lngIdCaseCourseKnowledgeRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdCaseCourseKnowledgeRela)
{
try
{
 clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = clsCaseCourseKnowledgeRelaBL.GetObjByIdCaseCourseKnowledgeRela(lngIdCaseCourseKnowledgeRela);

if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela, objCaseCourseKnowledgeRelaEN.UpdUserId);
}
if (objCaseCourseKnowledgeRelaEN != null)
{
int intRecNum = CaseCourseKnowledgeRelaDA.DelRecord(lngIdCaseCourseKnowledgeRela);
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
/// <param name="lngIdCaseCourseKnowledgeRela">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdCaseCourseKnowledgeRela )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
//删除与表:[CaseCourseKnowledgeRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela,
//lngIdCaseCourseKnowledgeRela);
//        clsCaseCourseKnowledgeRelaBL.DelCaseCourseKnowledgeRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseCourseKnowledgeRelaBL.DelRecord(lngIdCaseCourseKnowledgeRela, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseCourseKnowledgeRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCaseCourseKnowledgeRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdCaseCourseKnowledgeRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdCaseCourseKnowledgeRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(lngIdCaseCourseKnowledgeRela, "UpdRelaTabDate");
}
bool bolResult = CaseCourseKnowledgeRelaDA.DelRecord(lngIdCaseCourseKnowledgeRela,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCaseCourseKnowledgeRelaLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCaseCourseKnowledgeRelas(List<string> arrIdCaseCourseKnowledgeRelaLst)
{
if (arrIdCaseCourseKnowledgeRelaLst.Count == 0) return 0;
try
{
if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
foreach (var strIdCaseCourseKnowledgeRela in arrIdCaseCourseKnowledgeRelaLst)
{
long lngIdCaseCourseKnowledgeRela = long.Parse(strIdCaseCourseKnowledgeRela);
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(lngIdCaseCourseKnowledgeRela, "UpdRelaTabDate");
}
}
int intDelRecNum = CaseCourseKnowledgeRelaDA.DelCaseCourseKnowledgeRela(arrIdCaseCourseKnowledgeRelaLst);
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
public static int DelCaseCourseKnowledgeRelasByCond(string strWhereCond)
{
try
{
if (clsCaseCourseKnowledgeRelaBL.relatedActions != null)
{
List<string> arrIdCaseCourseKnowledgeRela = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCaseCourseKnowledgeRela in arrIdCaseCourseKnowledgeRela)
{
long lngIdCaseCourseKnowledgeRela = long.Parse(strIdCaseCourseKnowledgeRela);
clsCaseCourseKnowledgeRelaBL.relatedActions.UpdRelaTabDate(lngIdCaseCourseKnowledgeRela, "UpdRelaTabDate");
}
}
int intRecNum = CaseCourseKnowledgeRelaDA.DelCaseCourseKnowledgeRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CaseCourseKnowledgeRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdCaseCourseKnowledgeRela">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdCaseCourseKnowledgeRela)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseCourseKnowledgeRelaDA.GetSpecSQLObj();
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
//删除与表:[CaseCourseKnowledgeRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseCourseKnowledgeRelaBL.DelRecord(lngIdCaseCourseKnowledgeRela, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseCourseKnowledgeRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCaseCourseKnowledgeRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCaseCourseKnowledgeRelaENS">源对象</param>
 /// <param name = "objCaseCourseKnowledgeRelaENT">目标对象</param>
 public static void CopyTo(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENS, clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENT)
{
try
{
objCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRela = objCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRela; //案例知识点关系流水号
objCaseCourseKnowledgeRelaENT.FuncModuleId = objCaseCourseKnowledgeRelaENS.FuncModuleId; //功能模块Id
objCaseCourseKnowledgeRelaENT.CaseId = objCaseCourseKnowledgeRelaENS.CaseId; //案例Id
objCaseCourseKnowledgeRelaENT.CaseName = objCaseCourseKnowledgeRelaENS.CaseName; //案例名称
objCaseCourseKnowledgeRelaENT.OwnerId = objCaseCourseKnowledgeRelaENS.OwnerId; //拥有者Id
objCaseCourseKnowledgeRelaENT.CourseKnowledgeId = objCaseCourseKnowledgeRelaENS.CourseKnowledgeId; //知识点Id
objCaseCourseKnowledgeRelaENT.IdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaENS.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaENT.RelationsDegree = objCaseCourseKnowledgeRelaENS.RelationsDegree; //关系度
objCaseCourseKnowledgeRelaENT.BrowseCount = objCaseCourseKnowledgeRelaENS.BrowseCount; //浏览次数
objCaseCourseKnowledgeRelaENT.OrderNum = objCaseCourseKnowledgeRelaENS.OrderNum; //序号
objCaseCourseKnowledgeRelaENT.UpdDate = objCaseCourseKnowledgeRelaENS.UpdDate; //修改日期
objCaseCourseKnowledgeRelaENT.UpdUserId = objCaseCourseKnowledgeRelaENS.UpdUserId; //修改用户Id
objCaseCourseKnowledgeRelaENT.Memo = objCaseCourseKnowledgeRelaENS.Memo; //备注
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
try
{
objCaseCourseKnowledgeRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCaseCourseKnowledgeRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRela; //案例知识点关系流水号
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.FuncModuleId = objCaseCourseKnowledgeRelaEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.CaseId = objCaseCourseKnowledgeRelaEN.CaseId; //案例Id
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.CaseName = objCaseCourseKnowledgeRelaEN.CaseName; //案例名称
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.OwnerId = objCaseCourseKnowledgeRelaEN.OwnerId == "[null]" ? null :  objCaseCourseKnowledgeRelaEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = objCaseCourseKnowledgeRelaEN.CourseKnowledgeId == "[null]" ? null :  objCaseCourseKnowledgeRelaEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRelaType, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaEN.IdCaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.RelationsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.RelationsDegree = objCaseCourseKnowledgeRelaEN.RelationsDegree; //关系度
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.BrowseCount = objCaseCourseKnowledgeRelaEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.OrderNum = objCaseCourseKnowledgeRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.UpdDate = objCaseCourseKnowledgeRelaEN.UpdDate == "[null]" ? null :  objCaseCourseKnowledgeRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.UpdUserId = objCaseCourseKnowledgeRelaEN.UpdUserId == "[null]" ? null :  objCaseCourseKnowledgeRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conCaseCourseKnowledgeRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCourseKnowledgeRelaEN.Memo = objCaseCourseKnowledgeRelaEN.Memo == "[null]" ? null :  objCaseCourseKnowledgeRelaEN.Memo; //备注
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
try
{
if (objCaseCourseKnowledgeRelaEN.OwnerId == "[null]") objCaseCourseKnowledgeRelaEN.OwnerId = null; //拥有者Id
if (objCaseCourseKnowledgeRelaEN.CourseKnowledgeId == "[null]") objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = null; //知识点Id
if (objCaseCourseKnowledgeRelaEN.UpdDate == "[null]") objCaseCourseKnowledgeRelaEN.UpdDate = null; //修改日期
if (objCaseCourseKnowledgeRelaEN.UpdUserId == "[null]") objCaseCourseKnowledgeRelaEN.UpdUserId = null; //修改用户Id
if (objCaseCourseKnowledgeRelaEN.Memo == "[null]") objCaseCourseKnowledgeRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 CaseCourseKnowledgeRelaDA.CheckPropertyNew(objCaseCourseKnowledgeRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 CaseCourseKnowledgeRelaDA.CheckProperty4Condition(objCaseCourseKnowledgeRelaEN);
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
if (clsCaseCourseKnowledgeRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseKnowledgeRelaBL没有刷新缓存机制(clsCaseCourseKnowledgeRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCaseCourseKnowledgeRela");
//if (arrCaseCourseKnowledgeRelaObjLstCache == null)
//{
//arrCaseCourseKnowledgeRelaObjLstCache = CaseCourseKnowledgeRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdCaseCourseKnowledgeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCourseKnowledgeRelaEN GetObjByIdCaseCourseKnowledgeRelaCache(long lngIdCaseCourseKnowledgeRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName);
List<clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLst_Sel =
arrCaseCourseKnowledgeRelaObjLstCache
.Where(x=> x.IdCaseCourseKnowledgeRela == lngIdCaseCourseKnowledgeRela 
);
if (arrCaseCourseKnowledgeRelaObjLst_Sel.Count() == 0)
{
   clsCaseCourseKnowledgeRelaEN obj = clsCaseCourseKnowledgeRelaBL.GetObjByIdCaseCourseKnowledgeRela(lngIdCaseCourseKnowledgeRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCaseCourseKnowledgeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetAllCaseCourseKnowledgeRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLstCache = GetObjLstCache(); 
return arrCaseCourseKnowledgeRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName);
List<clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseCourseKnowledgeRelaObjLstCache;
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
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseCourseKnowledgeRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCaseCourseKnowledgeRelaEN._RefreshTimeLst.Count == 0) return "";
return clsCaseCourseKnowledgeRelaEN._RefreshTimeLst[clsCaseCourseKnowledgeRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCaseCourseKnowledgeRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseCourseKnowledgeRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCaseCourseKnowledgeRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CaseCourseKnowledgeRela(案例知识点关系)
 /// 唯一性条件:CaseId_CourseKnowledgeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
//检测记录是否存在
string strResult = CaseCourseKnowledgeRelaDA.GetUniCondStr(objCaseCourseKnowledgeRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdCaseCourseKnowledgeRela)
{
if (strInFldName != conCaseCourseKnowledgeRela.IdCaseCourseKnowledgeRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCaseCourseKnowledgeRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCaseCourseKnowledgeRela.AttributeName));
throw new Exception(strMsg);
}
var objCaseCourseKnowledgeRela = clsCaseCourseKnowledgeRelaBL.GetObjByIdCaseCourseKnowledgeRelaCache(lngIdCaseCourseKnowledgeRela);
if (objCaseCourseKnowledgeRela == null) return "";
return objCaseCourseKnowledgeRela[strOutFldName].ToString();
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
int intRecCount = clsCaseCourseKnowledgeRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsCaseCourseKnowledgeRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCaseCourseKnowledgeRelaDA.GetRecCount();
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
int intRecCount = clsCaseCourseKnowledgeRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaCond)
{
List<clsCaseCourseKnowledgeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCourseKnowledgeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseCourseKnowledgeRela.AttributeName)
{
if (objCaseCourseKnowledgeRelaCond.IsUpdated(strFldName) == false) continue;
if (objCaseCourseKnowledgeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCourseKnowledgeRelaCond[strFldName].ToString());
}
else
{
if (objCaseCourseKnowledgeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseCourseKnowledgeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCourseKnowledgeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseCourseKnowledgeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseCourseKnowledgeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseCourseKnowledgeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseCourseKnowledgeRelaCond[strFldName]));
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
 List<string> arrList = clsCaseCourseKnowledgeRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CaseCourseKnowledgeRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CaseCourseKnowledgeRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CaseCourseKnowledgeRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseCourseKnowledgeRelaDA.SetFldValue(clsCaseCourseKnowledgeRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CaseCourseKnowledgeRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseCourseKnowledgeRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseCourseKnowledgeRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseCourseKnowledgeRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CaseCourseKnowledgeRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例知识点关系流水号*/ 
 strCreateTabCode.Append(" IdCaseCourseKnowledgeRela bigint primary key identity, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**案例Id*/ 
 strCreateTabCode.Append(" CaseId char(8) not Null, "); 
 // /**案例名称*/ 
 strCreateTabCode.Append(" CaseName varchar(100) not Null, "); 
 // /**拥有者Id*/ 
 strCreateTabCode.Append(" OwnerId varchar(20) Null, "); 
 // /**知识点Id*/ 
 strCreateTabCode.Append(" CourseKnowledgeId char(8) Null, "); 
 // /**案例知识点关系类型流水号*/ 
 strCreateTabCode.Append(" IdCaseCourseKnowledgeRelaType char(4) not Null, "); 
 // /**关系度*/ 
 strCreateTabCode.Append(" RelationsDegree int not Null, "); 
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
 /// 案例知识点关系(CaseCourseKnowledgeRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CaseCourseKnowledgeRela : clsCommFun4BL
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
clsCaseCourseKnowledgeRelaBL.ReFreshThisCache();
}
}

}