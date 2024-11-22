
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ResearchResultBL
 表名:gs_ResearchResult(01120780)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:42
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
public static class  clsgs_ResearchResultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strResultId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_ResearchResultEN GetObj(this K_ResultId_gs_ResearchResult myKey)
{
clsgs_ResearchResultEN objgs_ResearchResultEN = clsgs_ResearchResultBL.gs_ResearchResultDA.GetObjByResultId(myKey.Value);
return objgs_ResearchResultEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_ResearchResultEN objgs_ResearchResultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ResearchResultEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],成果类型Id = [{1}],成果名称 = [{2}]的数据已经存在!(in clsgs_ResearchResultBL.AddNewRecord)", objgs_ResearchResultEN.TopicId,objgs_ResearchResultEN.ResultTypeId,objgs_ResearchResultEN.ResultName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchResultEN.ResultId) == true || clsgs_ResearchResultBL.IsExist(objgs_ResearchResultEN.ResultId) == true)
 {
     objgs_ResearchResultEN.ResultId = clsgs_ResearchResultBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_ResearchResultBL.gs_ResearchResultDA.AddNewRecordBySQL2(objgs_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_ResearchResultEN objgs_ResearchResultEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_ResearchResultBL.IsExist(objgs_ResearchResultEN.ResultId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_ResearchResultEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_ResearchResultEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主题Id(TopicId)=[{0}],成果类型Id(ResultTypeId)=[{1}],成果名称(ResultName)=[{2}])已经存在,不能重复!", objgs_ResearchResultEN.TopicId, objgs_ResearchResultEN.ResultTypeId, objgs_ResearchResultEN.ResultName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_ResearchResultEN.ResultId) == true || clsgs_ResearchResultBL.IsExist(objgs_ResearchResultEN.ResultId) == true)
 {
     objgs_ResearchResultEN.ResultId = clsgs_ResearchResultBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_ResearchResultEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_ResearchResultEN objgs_ResearchResultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ResearchResultEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],成果类型Id = [{1}],成果名称 = [{2}]的数据已经存在!(in clsgs_ResearchResultBL.AddNewRecordWithMaxId)", objgs_ResearchResultEN.TopicId,objgs_ResearchResultEN.ResultTypeId,objgs_ResearchResultEN.ResultName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchResultEN.ResultId) == true || clsgs_ResearchResultBL.IsExist(objgs_ResearchResultEN.ResultId) == true)
 {
     objgs_ResearchResultEN.ResultId = clsgs_ResearchResultBL.GetMaxStrId_S();
 }
string strResultId = clsgs_ResearchResultBL.gs_ResearchResultDA.AddNewRecordBySQL2WithReturnKey(objgs_ResearchResultEN);
     objgs_ResearchResultEN.ResultId = strResultId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
}
return strResultId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_ResearchResultEN objgs_ResearchResultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ResearchResultEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],成果类型Id = [{1}],成果名称 = [{2}]的数据已经存在!(in clsgs_ResearchResultBL.AddNewRecordWithReturnKey)", objgs_ResearchResultEN.TopicId,objgs_ResearchResultEN.ResultTypeId,objgs_ResearchResultEN.ResultName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchResultEN.ResultId) == true || clsgs_ResearchResultBL.IsExist(objgs_ResearchResultEN.ResultId) == true)
 {
     objgs_ResearchResultEN.ResultId = clsgs_ResearchResultBL.GetMaxStrId_S();
 }
string strKey = clsgs_ResearchResultBL.gs_ResearchResultDA.AddNewRecordBySQL2WithReturnKey(objgs_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetResultId(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strResultId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultId, 10, congs_ResearchResult.ResultId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResultId, 10, congs_ResearchResult.ResultId);
}
objgs_ResearchResultEN.ResultId = strResultId; //成果Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.ResultId) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.ResultId, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.ResultId] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetTopicId(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_ResearchResult.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_ResearchResult.TopicId);
}
objgs_ResearchResultEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.TopicId) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.TopicId, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.TopicId] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetPaperId(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, congs_ResearchResult.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, congs_ResearchResult.PaperId);
}
objgs_ResearchResultEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.PaperId) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.PaperId, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.PaperId] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetResultTypeId(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strResultTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultTypeId, 2, congs_ResearchResult.ResultTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResultTypeId, 2, congs_ResearchResult.ResultTypeId);
}
objgs_ResearchResultEN.ResultTypeId = strResultTypeId; //成果类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.ResultTypeId) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.ResultTypeId, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.ResultTypeId] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetResultName(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strResultName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultName, 500, congs_ResearchResult.ResultName);
}
objgs_ResearchResultEN.ResultName = strResultName; //成果名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.ResultName) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.ResultName, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.ResultName] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetResultContent(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strResultContent, string strComparisonOp="")
	{
objgs_ResearchResultEN.ResultContent = strResultContent; //成果内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.ResultContent) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.ResultContent, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.ResultContent] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetAuthor(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, congs_ResearchResult.Author);
}
objgs_ResearchResultEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.Author) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.Author, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.Author] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetDivision(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strDivision, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDivision, 500, congs_ResearchResult.Division);
}
objgs_ResearchResultEN.Division = strDivision; //分工
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.Division) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.Division, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.Division] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetVersionCount(this clsgs_ResearchResultEN objgs_ResearchResultEN, int? intVersionCount, string strComparisonOp="")
	{
objgs_ResearchResultEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.VersionCount) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.VersionCount, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.VersionCount] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetOkCount(this clsgs_ResearchResultEN objgs_ResearchResultEN, int? intOkCount, string strComparisonOp="")
	{
objgs_ResearchResultEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.OkCount) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.OkCount, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.OkCount] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetAppraiseCount(this clsgs_ResearchResultEN objgs_ResearchResultEN, int? intAppraiseCount, string strComparisonOp="")
	{
objgs_ResearchResultEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.AppraiseCount) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.AppraiseCount, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.AppraiseCount] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetScore(this clsgs_ResearchResultEN objgs_ResearchResultEN, float? fltScore, string strComparisonOp="")
	{
objgs_ResearchResultEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.Score) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.Score, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.Score] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetStuScore(this clsgs_ResearchResultEN objgs_ResearchResultEN, float? fltStuScore, string strComparisonOp="")
	{
objgs_ResearchResultEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.StuScore) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.StuScore, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.StuScore] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetTeaScore(this clsgs_ResearchResultEN objgs_ResearchResultEN, float? fltTeaScore, string strComparisonOp="")
	{
objgs_ResearchResultEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.TeaScore) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.TeaScore, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.TeaScore] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetIdCurrEduCls(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_ResearchResult.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_ResearchResult.IdCurrEduCls);
}
objgs_ResearchResultEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.IdCurrEduCls) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetUpdDate(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_ResearchResult.UpdDate);
}
objgs_ResearchResultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.UpdDate) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.UpdDate, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.UpdDate] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetUpdUser(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_ResearchResult.UpdUser);
}
objgs_ResearchResultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.UpdUser) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.UpdUser, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.UpdUser] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchResultEN SetMemo(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_ResearchResult.Memo);
}
objgs_ResearchResultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(congs_ResearchResult.Memo) == false)
{
objgs_ResearchResultEN.dicFldComparisonOp.Add(congs_ResearchResult.Memo, strComparisonOp);
}
else
{
objgs_ResearchResultEN.dicFldComparisonOp[congs_ResearchResult.Memo] = strComparisonOp;
}
}
return objgs_ResearchResultEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_ResearchResultEN objgs_ResearchResultEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_ResearchResultEN.CheckPropertyNew();
clsgs_ResearchResultEN objgs_ResearchResultCond = new clsgs_ResearchResultEN();
string strCondition = objgs_ResearchResultCond
.SetResultId(objgs_ResearchResultEN.ResultId, "<>")
.SetTopicId(objgs_ResearchResultEN.TopicId, "=")
.SetResultTypeId(objgs_ResearchResultEN.ResultTypeId, "=")
.SetResultName(objgs_ResearchResultEN.ResultName, "=")
.GetCombineCondition();
objgs_ResearchResultEN._IsCheckProperty = true;
bool bolIsExist = clsgs_ResearchResultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TopicId_ResultTypeId_ResultName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_ResearchResultEN.Update();
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
 /// <param name = "objgs_ResearchResult">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_ResearchResultEN objgs_ResearchResult)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_ResearchResultEN objgs_ResearchResultCond = new clsgs_ResearchResultEN();
string strCondition = objgs_ResearchResultCond
.SetTopicId(objgs_ResearchResult.TopicId, "=")
.SetResultTypeId(objgs_ResearchResult.ResultTypeId, "=")
.SetResultName(objgs_ResearchResult.ResultName, "=")
.GetCombineCondition();
objgs_ResearchResult._IsCheckProperty = true;
bool bolIsExist = clsgs_ResearchResultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_ResearchResult.ResultId = clsgs_ResearchResultBL.GetFirstID_S(strCondition);
objgs_ResearchResult.UpdateWithCondition(strCondition);
}
else
{
objgs_ResearchResult.ResultId = clsgs_ResearchResultBL.GetMaxStrId_S();
objgs_ResearchResult.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 if (string.IsNullOrEmpty(objgs_ResearchResultEN.ResultId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_ResearchResultBL.gs_ResearchResultDA.UpdateBySql2(objgs_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_ResearchResultEN objgs_ResearchResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_ResearchResultEN.ResultId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_ResearchResultBL.gs_ResearchResultDA.UpdateBySql2(objgs_ResearchResultEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_ResearchResultBL.gs_ResearchResultDA.UpdateBySqlWithCondition(objgs_ResearchResultEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_ResearchResultEN objgs_ResearchResultEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_ResearchResultBL.gs_ResearchResultDA.UpdateBySqlWithConditionTransaction(objgs_ResearchResultEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "strResultId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_ResearchResultEN objgs_ResearchResultEN)
{
try
{
int intRecNum = clsgs_ResearchResultBL.gs_ResearchResultDA.DelRecord(objgs_ResearchResultEN.ResultId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultENS">源对象</param>
 /// <param name = "objgs_ResearchResultENT">目标对象</param>
 public static void CopyTo(this clsgs_ResearchResultEN objgs_ResearchResultENS, clsgs_ResearchResultEN objgs_ResearchResultENT)
{
try
{
objgs_ResearchResultENT.ResultId = objgs_ResearchResultENS.ResultId; //成果Id
objgs_ResearchResultENT.TopicId = objgs_ResearchResultENS.TopicId; //主题Id
objgs_ResearchResultENT.PaperId = objgs_ResearchResultENS.PaperId; //论文Id
objgs_ResearchResultENT.ResultTypeId = objgs_ResearchResultENS.ResultTypeId; //成果类型Id
objgs_ResearchResultENT.ResultName = objgs_ResearchResultENS.ResultName; //成果名称
objgs_ResearchResultENT.ResultContent = objgs_ResearchResultENS.ResultContent; //成果内容
objgs_ResearchResultENT.Author = objgs_ResearchResultENS.Author; //作者
objgs_ResearchResultENT.Division = objgs_ResearchResultENS.Division; //分工
objgs_ResearchResultENT.VersionCount = objgs_ResearchResultENS.VersionCount; //版本统计
objgs_ResearchResultENT.OkCount = objgs_ResearchResultENS.OkCount; //点赞统计
objgs_ResearchResultENT.AppraiseCount = objgs_ResearchResultENS.AppraiseCount; //评论数
objgs_ResearchResultENT.Score = objgs_ResearchResultENS.Score; //评分
objgs_ResearchResultENT.StuScore = objgs_ResearchResultENS.StuScore; //学生平均分
objgs_ResearchResultENT.TeaScore = objgs_ResearchResultENS.TeaScore; //教师评分
objgs_ResearchResultENT.IdCurrEduCls = objgs_ResearchResultENS.IdCurrEduCls; //教学班流水号
objgs_ResearchResultENT.UpdDate = objgs_ResearchResultENS.UpdDate; //修改日期
objgs_ResearchResultENT.UpdUser = objgs_ResearchResultENS.UpdUser; //修改人
objgs_ResearchResultENT.Memo = objgs_ResearchResultENS.Memo; //备注
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
 /// <param name = "objgs_ResearchResultENS">源对象</param>
 /// <returns>目标对象=>clsgs_ResearchResultEN:objgs_ResearchResultENT</returns>
 public static clsgs_ResearchResultEN CopyTo(this clsgs_ResearchResultEN objgs_ResearchResultENS)
{
try
{
 clsgs_ResearchResultEN objgs_ResearchResultENT = new clsgs_ResearchResultEN()
{
ResultId = objgs_ResearchResultENS.ResultId, //成果Id
TopicId = objgs_ResearchResultENS.TopicId, //主题Id
PaperId = objgs_ResearchResultENS.PaperId, //论文Id
ResultTypeId = objgs_ResearchResultENS.ResultTypeId, //成果类型Id
ResultName = objgs_ResearchResultENS.ResultName, //成果名称
ResultContent = objgs_ResearchResultENS.ResultContent, //成果内容
Author = objgs_ResearchResultENS.Author, //作者
Division = objgs_ResearchResultENS.Division, //分工
VersionCount = objgs_ResearchResultENS.VersionCount, //版本统计
OkCount = objgs_ResearchResultENS.OkCount, //点赞统计
AppraiseCount = objgs_ResearchResultENS.AppraiseCount, //评论数
Score = objgs_ResearchResultENS.Score, //评分
StuScore = objgs_ResearchResultENS.StuScore, //学生平均分
TeaScore = objgs_ResearchResultENS.TeaScore, //教师评分
IdCurrEduCls = objgs_ResearchResultENS.IdCurrEduCls, //教学班流水号
UpdDate = objgs_ResearchResultENS.UpdDate, //修改日期
UpdUser = objgs_ResearchResultENS.UpdUser, //修改人
Memo = objgs_ResearchResultENS.Memo, //备注
};
 return objgs_ResearchResultENT;
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
public static void CheckPropertyNew(this clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 clsgs_ResearchResultBL.gs_ResearchResultDA.CheckPropertyNew(objgs_ResearchResultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 clsgs_ResearchResultBL.gs_ResearchResultDA.CheckProperty4Condition(objgs_ResearchResultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_ResearchResultEN objgs_ResearchResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.ResultId) == true)
{
string strComparisonOpResultId = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.ResultId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.ResultId, objgs_ResearchResultCond.ResultId, strComparisonOpResultId);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.TopicId) == true)
{
string strComparisonOpTopicId = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.TopicId, objgs_ResearchResultCond.TopicId, strComparisonOpTopicId);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.PaperId) == true)
{
string strComparisonOpPaperId = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.PaperId, objgs_ResearchResultCond.PaperId, strComparisonOpPaperId);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.ResultTypeId) == true)
{
string strComparisonOpResultTypeId = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.ResultTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.ResultTypeId, objgs_ResearchResultCond.ResultTypeId, strComparisonOpResultTypeId);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.ResultName) == true)
{
string strComparisonOpResultName = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.ResultName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.ResultName, objgs_ResearchResultCond.ResultName, strComparisonOpResultName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.Author) == true)
{
string strComparisonOpAuthor = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.Author, objgs_ResearchResultCond.Author, strComparisonOpAuthor);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.Division) == true)
{
string strComparisonOpDivision = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.Division];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.Division, objgs_ResearchResultCond.Division, strComparisonOpDivision);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.VersionCount) == true)
{
string strComparisonOpVersionCount = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", congs_ResearchResult.VersionCount, objgs_ResearchResultCond.VersionCount, strComparisonOpVersionCount);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.OkCount) == true)
{
string strComparisonOpOkCount = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", congs_ResearchResult.OkCount, objgs_ResearchResultCond.OkCount, strComparisonOpOkCount);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", congs_ResearchResult.AppraiseCount, objgs_ResearchResultCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.Score) == true)
{
string strComparisonOpScore = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.Score];
strWhereCond += string.Format(" And {0} {2} {1}", congs_ResearchResult.Score, objgs_ResearchResultCond.Score, strComparisonOpScore);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.StuScore) == true)
{
string strComparisonOpStuScore = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", congs_ResearchResult.StuScore, objgs_ResearchResultCond.StuScore, strComparisonOpStuScore);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.TeaScore) == true)
{
string strComparisonOpTeaScore = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", congs_ResearchResult.TeaScore, objgs_ResearchResultCond.TeaScore, strComparisonOpTeaScore);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.IdCurrEduCls, objgs_ResearchResultCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.UpdDate, objgs_ResearchResultCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.UpdUser, objgs_ResearchResultCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_ResearchResultCond.IsUpdated(congs_ResearchResult.Memo) == true)
{
string strComparisonOpMemo = objgs_ResearchResultCond.dicFldComparisonOp[congs_ResearchResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchResult.Memo, objgs_ResearchResultCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_ResearchResult(研究成果), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TopicId_ResultTypeId_ResultName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_ResearchResultEN objgs_ResearchResultEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_ResearchResultEN == null) return true;
if (objgs_ResearchResultEN.ResultId == null || objgs_ResearchResultEN.ResultId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_ResearchResultEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objgs_ResearchResultEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_ResearchResultEN.TopicId);
}
 if (objgs_ResearchResultEN.ResultTypeId == null)
{
 sbCondition.AppendFormat(" and ResultTypeId is null", objgs_ResearchResultEN.ResultTypeId);
}
else
{
 sbCondition.AppendFormat(" and ResultTypeId = '{0}'", objgs_ResearchResultEN.ResultTypeId);
}
 if (objgs_ResearchResultEN.ResultName == null)
{
 sbCondition.AppendFormat(" and ResultName is null", objgs_ResearchResultEN.ResultName);
}
else
{
 sbCondition.AppendFormat(" and ResultName = '{0}'", objgs_ResearchResultEN.ResultName);
}
if (clsgs_ResearchResultBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ResultId !=  '{0}'", objgs_ResearchResultEN.ResultId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_ResearchResultEN.TopicId);
 sbCondition.AppendFormat(" and ResultTypeId = '{0}'", objgs_ResearchResultEN.ResultTypeId);
 sbCondition.AppendFormat(" and ResultName = '{0}'", objgs_ResearchResultEN.ResultName);
if (clsgs_ResearchResultBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_ResearchResult(研究成果), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TopicId_ResultTypeId_ResultName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_ResearchResultEN objgs_ResearchResultEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_ResearchResultEN == null) return "";
if (objgs_ResearchResultEN.ResultId == null || objgs_ResearchResultEN.ResultId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_ResearchResultEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objgs_ResearchResultEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_ResearchResultEN.TopicId);
}
 if (objgs_ResearchResultEN.ResultTypeId == null)
{
 sbCondition.AppendFormat(" and ResultTypeId is null", objgs_ResearchResultEN.ResultTypeId);
}
else
{
 sbCondition.AppendFormat(" and ResultTypeId = '{0}'", objgs_ResearchResultEN.ResultTypeId);
}
 if (objgs_ResearchResultEN.ResultName == null)
{
 sbCondition.AppendFormat(" and ResultName is null", objgs_ResearchResultEN.ResultName);
}
else
{
 sbCondition.AppendFormat(" and ResultName = '{0}'", objgs_ResearchResultEN.ResultName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ResultId !=  '{0}'", objgs_ResearchResultEN.ResultId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_ResearchResultEN.TopicId);
 sbCondition.AppendFormat(" and ResultTypeId = '{0}'", objgs_ResearchResultEN.ResultTypeId);
 sbCondition.AppendFormat(" and ResultName = '{0}'", objgs_ResearchResultEN.ResultName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_ResearchResult
{
public virtual bool UpdRelaTabDate(string strResultId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 研究成果(gs_ResearchResult)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_ResearchResultBL
{
public static RelatedActions_gs_ResearchResult relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_ResearchResultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_ResearchResultDA gs_ResearchResultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_ResearchResultDA();
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
 public clsgs_ResearchResultBL()
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
if (string.IsNullOrEmpty(clsgs_ResearchResultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_ResearchResultEN._ConnectString);
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
public static DataTable GetDataTable_gs_ResearchResult(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_ResearchResultDA.GetDataTable_gs_ResearchResult(strWhereCond);
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
objDT = gs_ResearchResultDA.GetDataTable(strWhereCond);
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
objDT = gs_ResearchResultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_ResearchResultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_ResearchResultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_ResearchResultDA.GetDataTable_Top(objTopPara);
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
objDT = gs_ResearchResultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_ResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_ResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrResultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_ResearchResultEN> GetObjLstByResultIdLst(List<string> arrResultIdLst)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrResultIdLst, true);
 string strWhereCond = string.Format("ResultId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrResultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_ResearchResultEN> GetObjLstByResultIdLstCache(List<string> arrResultIdLst)
{
string strKey = string.Format("{0}", clsgs_ResearchResultEN._CurrTabName);
List<clsgs_ResearchResultEN> arrgs_ResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ResearchResultEN> arrgs_ResearchResultObjLst_Sel =
arrgs_ResearchResultObjLstCache
.Where(x => arrResultIdLst.Contains(x.ResultId));
return arrgs_ResearchResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ResearchResultEN> GetObjLst(string strWhereCond)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
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
public static List<clsgs_ResearchResultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_ResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_ResearchResultEN> GetSubObjLstCache(clsgs_ResearchResultEN objgs_ResearchResultCond)
{
List<clsgs_ResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_ResearchResult.AttributeName)
{
if (objgs_ResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objgs_ResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchResultCond[strFldName].ToString());
}
else
{
if (objgs_ResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_ResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_ResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_ResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_ResearchResultCond[strFldName]));
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
public static List<clsgs_ResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
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
public static List<clsgs_ResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
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
List<clsgs_ResearchResultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_ResearchResultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ResearchResultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_ResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
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
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
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
public static List<clsgs_ResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_ResearchResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_ResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
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
public static List<clsgs_ResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ResearchResultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_ResearchResultEN> arrObjLst = new List<clsgs_ResearchResultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchResultEN objgs_ResearchResultEN = new clsgs_ResearchResultEN();
try
{
objgs_ResearchResultEN.ResultId = objRow[congs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objgs_ResearchResultEN.TopicId = objRow[congs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[congs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objgs_ResearchResultEN.PaperId = objRow[congs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[congs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objgs_ResearchResultEN.ResultTypeId = objRow[congs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objgs_ResearchResultEN.ResultName = objRow[congs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objgs_ResearchResultEN.ResultContent = objRow[congs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[congs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objgs_ResearchResultEN.Author = objRow[congs_ResearchResult.Author] == DBNull.Value ? null : objRow[congs_ResearchResult.Author].ToString().Trim(); //作者
objgs_ResearchResultEN.Division = objRow[congs_ResearchResult.Division] == DBNull.Value ? null : objRow[congs_ResearchResult.Division].ToString().Trim(); //分工
objgs_ResearchResultEN.VersionCount = objRow[congs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objgs_ResearchResultEN.OkCount = objRow[congs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objgs_ResearchResultEN.AppraiseCount = objRow[congs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objgs_ResearchResultEN.Score = objRow[congs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.Score].ToString().Trim()); //评分
objgs_ResearchResultEN.StuScore = objRow[congs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objgs_ResearchResultEN.TeaScore = objRow[congs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objgs_ResearchResultEN.IdCurrEduCls = objRow[congs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_ResearchResultEN.UpdDate = objRow[congs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchResultEN.UpdUser = objRow[congs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objgs_ResearchResultEN.Memo = objRow[congs_ResearchResult.Memo] == DBNull.Value ? null : objRow[congs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchResultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_ResearchResult(ref clsgs_ResearchResultEN objgs_ResearchResultEN)
{
bool bolResult = gs_ResearchResultDA.Getgs_ResearchResult(ref objgs_ResearchResultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strResultId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_ResearchResultEN GetObjByResultId(string strResultId)
{
if (strResultId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strResultId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strResultId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strResultId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_ResearchResultEN objgs_ResearchResultEN = gs_ResearchResultDA.GetObjByResultId(strResultId);
return objgs_ResearchResultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_ResearchResultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_ResearchResultEN objgs_ResearchResultEN = gs_ResearchResultDA.GetFirstObj(strWhereCond);
 return objgs_ResearchResultEN;
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
public static clsgs_ResearchResultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_ResearchResultEN objgs_ResearchResultEN = gs_ResearchResultDA.GetObjByDataRow(objRow);
 return objgs_ResearchResultEN;
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
public static clsgs_ResearchResultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_ResearchResultEN objgs_ResearchResultEN = gs_ResearchResultDA.GetObjByDataRow(objRow);
 return objgs_ResearchResultEN;
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
 /// <param name = "strResultId">所给的关键字</param>
 /// <param name = "lstgs_ResearchResultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_ResearchResultEN GetObjByResultIdFromList(string strResultId, List<clsgs_ResearchResultEN> lstgs_ResearchResultObjLst)
{
foreach (clsgs_ResearchResultEN objgs_ResearchResultEN in lstgs_ResearchResultObjLst)
{
if (objgs_ResearchResultEN.ResultId == strResultId)
{
return objgs_ResearchResultEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxResultId;
 try
 {
 strMaxResultId = clsgs_ResearchResultDA.GetMaxStrId();
 return strMaxResultId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strResultId;
 try
 {
 strResultId = new clsgs_ResearchResultDA().GetFirstID(strWhereCond);
 return strResultId;
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
 arrList = gs_ResearchResultDA.GetID(strWhereCond);
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
bool bolIsExist = gs_ResearchResultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strResultId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strResultId)
{
if (string.IsNullOrEmpty(strResultId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strResultId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_ResearchResultDA.IsExist(strResultId);
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
 bolIsExist = clsgs_ResearchResultDA.IsExistTable();
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
 bolIsExist = gs_ResearchResultDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_ResearchResultEN objgs_ResearchResultEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_ResearchResultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],成果类型Id = [{1}],成果名称 = [{2}]的数据已经存在!(in clsgs_ResearchResultBL.AddNewRecordBySql2)", objgs_ResearchResultEN.TopicId,objgs_ResearchResultEN.ResultTypeId,objgs_ResearchResultEN.ResultName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchResultEN.ResultId) == true || clsgs_ResearchResultBL.IsExist(objgs_ResearchResultEN.ResultId) == true)
 {
     objgs_ResearchResultEN.ResultId = clsgs_ResearchResultBL.GetMaxStrId_S();
 }
bool bolResult = gs_ResearchResultDA.AddNewRecordBySQL2(objgs_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_ResearchResultEN objgs_ResearchResultEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_ResearchResultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],成果类型Id = [{1}],成果名称 = [{2}]的数据已经存在!(in clsgs_ResearchResultBL.AddNewRecordBySql2WithReturnKey)", objgs_ResearchResultEN.TopicId,objgs_ResearchResultEN.ResultTypeId,objgs_ResearchResultEN.ResultName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchResultEN.ResultId) == true || clsgs_ResearchResultBL.IsExist(objgs_ResearchResultEN.ResultId) == true)
 {
     objgs_ResearchResultEN.ResultId = clsgs_ResearchResultBL.GetMaxStrId_S();
 }
string strKey = gs_ResearchResultDA.AddNewRecordBySQL2WithReturnKey(objgs_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
try
{
bool bolResult = gs_ResearchResultDA.Update(objgs_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "objgs_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 if (string.IsNullOrEmpty(objgs_ResearchResultEN.ResultId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_ResearchResultDA.UpdateBySql2(objgs_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchResultBL.ReFreshCache();

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
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
 /// <param name = "strResultId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strResultId)
{
try
{
 clsgs_ResearchResultEN objgs_ResearchResultEN = clsgs_ResearchResultBL.GetObjByResultId(strResultId);

if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(objgs_ResearchResultEN.ResultId, "SetUpdDate");
}
if (objgs_ResearchResultEN != null)
{
int intRecNum = gs_ResearchResultDA.DelRecord(strResultId);
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
/// <param name="strResultId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strResultId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
//删除与表:[gs_ResearchResult]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_ResearchResult.ResultId,
//strResultId);
//        clsgs_ResearchResultBL.Delgs_ResearchResultsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_ResearchResultBL.DelRecord(strResultId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_ResearchResultBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strResultId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strResultId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strResultId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_ResearchResultBL.relatedActions != null)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(strResultId, "UpdRelaTabDate");
}
bool bolResult = gs_ResearchResultDA.DelRecord(strResultId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrResultIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_ResearchResults(List<string> arrResultIdLst)
{
if (arrResultIdLst.Count == 0) return 0;
try
{
if (clsgs_ResearchResultBL.relatedActions != null)
{
foreach (var strResultId in arrResultIdLst)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(strResultId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_ResearchResultDA.Delgs_ResearchResult(arrResultIdLst);
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
public static int Delgs_ResearchResultsByCond(string strWhereCond)
{
try
{
if (clsgs_ResearchResultBL.relatedActions != null)
{
List<string> arrResultId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strResultId in arrResultId)
{
clsgs_ResearchResultBL.relatedActions.UpdRelaTabDate(strResultId, "UpdRelaTabDate");
}
}
int intRecNum = gs_ResearchResultDA.Delgs_ResearchResult(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_ResearchResult]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strResultId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strResultId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_ResearchResultDA.GetSpecSQLObj();
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
//删除与表:[gs_ResearchResult]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_ResearchResultBL.DelRecord(strResultId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_ResearchResultBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strResultId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_ResearchResultENS">源对象</param>
 /// <param name = "objgs_ResearchResultENT">目标对象</param>
 public static void CopyTo(clsgs_ResearchResultEN objgs_ResearchResultENS, clsgs_ResearchResultEN objgs_ResearchResultENT)
{
try
{
objgs_ResearchResultENT.ResultId = objgs_ResearchResultENS.ResultId; //成果Id
objgs_ResearchResultENT.TopicId = objgs_ResearchResultENS.TopicId; //主题Id
objgs_ResearchResultENT.PaperId = objgs_ResearchResultENS.PaperId; //论文Id
objgs_ResearchResultENT.ResultTypeId = objgs_ResearchResultENS.ResultTypeId; //成果类型Id
objgs_ResearchResultENT.ResultName = objgs_ResearchResultENS.ResultName; //成果名称
objgs_ResearchResultENT.ResultContent = objgs_ResearchResultENS.ResultContent; //成果内容
objgs_ResearchResultENT.Author = objgs_ResearchResultENS.Author; //作者
objgs_ResearchResultENT.Division = objgs_ResearchResultENS.Division; //分工
objgs_ResearchResultENT.VersionCount = objgs_ResearchResultENS.VersionCount; //版本统计
objgs_ResearchResultENT.OkCount = objgs_ResearchResultENS.OkCount; //点赞统计
objgs_ResearchResultENT.AppraiseCount = objgs_ResearchResultENS.AppraiseCount; //评论数
objgs_ResearchResultENT.Score = objgs_ResearchResultENS.Score; //评分
objgs_ResearchResultENT.StuScore = objgs_ResearchResultENS.StuScore; //学生平均分
objgs_ResearchResultENT.TeaScore = objgs_ResearchResultENS.TeaScore; //教师评分
objgs_ResearchResultENT.IdCurrEduCls = objgs_ResearchResultENS.IdCurrEduCls; //教学班流水号
objgs_ResearchResultENT.UpdDate = objgs_ResearchResultENS.UpdDate; //修改日期
objgs_ResearchResultENT.UpdUser = objgs_ResearchResultENS.UpdUser; //修改人
objgs_ResearchResultENT.Memo = objgs_ResearchResultENS.Memo; //备注
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
 /// <param name = "objgs_ResearchResultEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
try
{
objgs_ResearchResultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_ResearchResultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_ResearchResult.ResultId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.ResultId = objgs_ResearchResultEN.ResultId; //成果Id
}
if (arrFldSet.Contains(congs_ResearchResult.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.TopicId = objgs_ResearchResultEN.TopicId == "[null]" ? null :  objgs_ResearchResultEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_ResearchResult.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.PaperId = objgs_ResearchResultEN.PaperId == "[null]" ? null :  objgs_ResearchResultEN.PaperId; //论文Id
}
if (arrFldSet.Contains(congs_ResearchResult.ResultTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.ResultTypeId = objgs_ResearchResultEN.ResultTypeId == "[null]" ? null :  objgs_ResearchResultEN.ResultTypeId; //成果类型Id
}
if (arrFldSet.Contains(congs_ResearchResult.ResultName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.ResultName = objgs_ResearchResultEN.ResultName == "[null]" ? null :  objgs_ResearchResultEN.ResultName; //成果名称
}
if (arrFldSet.Contains(congs_ResearchResult.ResultContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.ResultContent = objgs_ResearchResultEN.ResultContent == "[null]" ? null :  objgs_ResearchResultEN.ResultContent; //成果内容
}
if (arrFldSet.Contains(congs_ResearchResult.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.Author = objgs_ResearchResultEN.Author == "[null]" ? null :  objgs_ResearchResultEN.Author; //作者
}
if (arrFldSet.Contains(congs_ResearchResult.Division, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.Division = objgs_ResearchResultEN.Division == "[null]" ? null :  objgs_ResearchResultEN.Division; //分工
}
if (arrFldSet.Contains(congs_ResearchResult.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.VersionCount = objgs_ResearchResultEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(congs_ResearchResult.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.OkCount = objgs_ResearchResultEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(congs_ResearchResult.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.AppraiseCount = objgs_ResearchResultEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(congs_ResearchResult.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.Score = objgs_ResearchResultEN.Score; //评分
}
if (arrFldSet.Contains(congs_ResearchResult.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.StuScore = objgs_ResearchResultEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(congs_ResearchResult.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.TeaScore = objgs_ResearchResultEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(congs_ResearchResult.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.IdCurrEduCls = objgs_ResearchResultEN.IdCurrEduCls == "[null]" ? null :  objgs_ResearchResultEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_ResearchResult.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.UpdDate = objgs_ResearchResultEN.UpdDate == "[null]" ? null :  objgs_ResearchResultEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_ResearchResult.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.UpdUser = objgs_ResearchResultEN.UpdUser == "[null]" ? null :  objgs_ResearchResultEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_ResearchResult.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchResultEN.Memo = objgs_ResearchResultEN.Memo == "[null]" ? null :  objgs_ResearchResultEN.Memo; //备注
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
 /// <param name = "objgs_ResearchResultEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
try
{
if (objgs_ResearchResultEN.TopicId == "[null]") objgs_ResearchResultEN.TopicId = null; //主题Id
if (objgs_ResearchResultEN.PaperId == "[null]") objgs_ResearchResultEN.PaperId = null; //论文Id
if (objgs_ResearchResultEN.ResultTypeId == "[null]") objgs_ResearchResultEN.ResultTypeId = null; //成果类型Id
if (objgs_ResearchResultEN.ResultName == "[null]") objgs_ResearchResultEN.ResultName = null; //成果名称
if (objgs_ResearchResultEN.ResultContent == "[null]") objgs_ResearchResultEN.ResultContent = null; //成果内容
if (objgs_ResearchResultEN.Author == "[null]") objgs_ResearchResultEN.Author = null; //作者
if (objgs_ResearchResultEN.Division == "[null]") objgs_ResearchResultEN.Division = null; //分工
if (objgs_ResearchResultEN.IdCurrEduCls == "[null]") objgs_ResearchResultEN.IdCurrEduCls = null; //教学班流水号
if (objgs_ResearchResultEN.UpdDate == "[null]") objgs_ResearchResultEN.UpdDate = null; //修改日期
if (objgs_ResearchResultEN.UpdUser == "[null]") objgs_ResearchResultEN.UpdUser = null; //修改人
if (objgs_ResearchResultEN.Memo == "[null]") objgs_ResearchResultEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 gs_ResearchResultDA.CheckPropertyNew(objgs_ResearchResultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
 gs_ResearchResultDA.CheckProperty4Condition(objgs_ResearchResultEN);
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
if (clsgs_ResearchResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ResearchResultBL没有刷新缓存机制(clsgs_ResearchResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ResultId");
//if (arrgs_ResearchResultObjLstCache == null)
//{
//arrgs_ResearchResultObjLstCache = gs_ResearchResultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strResultId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_ResearchResultEN GetObjByResultIdCache(string strResultId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_ResearchResultEN._CurrTabName);
List<clsgs_ResearchResultEN> arrgs_ResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ResearchResultEN> arrgs_ResearchResultObjLst_Sel =
arrgs_ResearchResultObjLstCache
.Where(x=> x.ResultId == strResultId 
);
if (arrgs_ResearchResultObjLst_Sel.Count() == 0)
{
   clsgs_ResearchResultEN obj = clsgs_ResearchResultBL.GetObjByResultId(strResultId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_ResearchResultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_ResearchResultEN> GetAllgs_ResearchResultObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_ResearchResultEN> arrgs_ResearchResultObjLstCache = GetObjLstCache(); 
return arrgs_ResearchResultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_ResearchResultEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_ResearchResultEN._CurrTabName);
List<clsgs_ResearchResultEN> arrgs_ResearchResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_ResearchResultObjLstCache;
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
string strKey = string.Format("{0}", clsgs_ResearchResultEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_ResearchResultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_ResearchResultEN._RefreshTimeLst.Count == 0) return "";
return clsgs_ResearchResultEN._RefreshTimeLst[clsgs_ResearchResultEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_ResearchResultBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_ResearchResultEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_ResearchResultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_ResearchResultBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_ResearchResult(研究成果)
 /// 唯一性条件:TopicId_ResultTypeId_ResultName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_ResearchResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_ResearchResultEN objgs_ResearchResultEN)
{
//检测记录是否存在
string strResult = gs_ResearchResultDA.GetUniCondStr(objgs_ResearchResultEN);
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
public static string Func(string strInFldName, string strOutFldName, string strResultId)
{
if (strInFldName != congs_ResearchResult.ResultId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_ResearchResult.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_ResearchResult.AttributeName));
throw new Exception(strMsg);
}
var objgs_ResearchResult = clsgs_ResearchResultBL.GetObjByResultIdCache(strResultId);
if (objgs_ResearchResult == null) return "";
return objgs_ResearchResult[strOutFldName].ToString();
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
int intRecCount = clsgs_ResearchResultDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_ResearchResultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_ResearchResultDA.GetRecCount();
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
int intRecCount = clsgs_ResearchResultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_ResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_ResearchResultEN objgs_ResearchResultCond)
{
List<clsgs_ResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_ResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_ResearchResult.AttributeName)
{
if (objgs_ResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objgs_ResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchResultCond[strFldName].ToString());
}
else
{
if (objgs_ResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_ResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_ResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_ResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_ResearchResultCond[strFldName]));
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
 List<string> arrList = clsgs_ResearchResultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_ResearchResultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_ResearchResultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_ResearchResultDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_ResearchResultDA.SetFldValue(clsgs_ResearchResultEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_ResearchResultDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_ResearchResultDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_ResearchResultDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_ResearchResultDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_ResearchResult] "); 
 strCreateTabCode.Append(" ( "); 
 // /**成果Id*/ 
 strCreateTabCode.Append(" ResultId char(10) primary key, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**成果类型Id*/ 
 strCreateTabCode.Append(" ResultTypeId char(2) Null, "); 
 // /**成果名称*/ 
 strCreateTabCode.Append(" ResultName varchar(500) Null, "); 
 // /**成果内容*/ 
 strCreateTabCode.Append(" ResultContent text Null, "); 
 // /**作者*/ 
 strCreateTabCode.Append(" Author varchar(200) Null, "); 
 // /**分工*/ 
 strCreateTabCode.Append(" Division varchar(500) Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
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
 /// 研究成果(gs_ResearchResult)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_ResearchResult : clsCommFun4BL
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
clsgs_ResearchResultBL.ReFreshThisCache();
}
}

}