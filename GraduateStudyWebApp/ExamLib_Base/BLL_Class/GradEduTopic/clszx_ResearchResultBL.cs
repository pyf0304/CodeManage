
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ResearchResultBL
 表名:zx_ResearchResult(01120803)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class  clszx_ResearchResultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxResultId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ResearchResultEN GetObj(this K_zxResultId_zx_ResearchResult myKey)
{
clszx_ResearchResultEN objzx_ResearchResultEN = clszx_ResearchResultBL.zx_ResearchResultDA.GetObjByzxResultId(myKey.Value);
return objzx_ResearchResultEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
if (CheckUniqueness(objzx_ResearchResultEN) == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_ResearchResultBL.AddNewRecord)", objzx_ResearchResultEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchResultEN.zxResultId) == true || clszx_ResearchResultBL.IsExist(objzx_ResearchResultEN.zxResultId) == true)
 {
     objzx_ResearchResultEN.zxResultId = clszx_ResearchResultBL.GetMaxStrId_S();
 }
bool bolResult = clszx_ResearchResultBL.zx_ResearchResultDA.AddNewRecordBySQL2(objzx_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_ResearchResultBL.IsExist(objzx_ResearchResultEN.zxResultId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_ResearchResultEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ResearchResultEN.CheckUniqueness() == false)
{
strMsg = string.Format("(小组Id(GroupTextId)=[{0}])已经存在,不能重复!", objzx_ResearchResultEN.GroupTextId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_ResearchResultEN.zxResultId) == true || clszx_ResearchResultBL.IsExist(objzx_ResearchResultEN.zxResultId) == true)
 {
     objzx_ResearchResultEN.zxResultId = clszx_ResearchResultBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_ResearchResultEN.AddNewRecord();
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
if (CheckUniqueness(objzx_ResearchResultEN) == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_ResearchResultBL.AddNewRecordWithMaxId)", objzx_ResearchResultEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchResultEN.zxResultId) == true || clszx_ResearchResultBL.IsExist(objzx_ResearchResultEN.zxResultId) == true)
 {
     objzx_ResearchResultEN.zxResultId = clszx_ResearchResultBL.GetMaxStrId_S();
 }
string strzxResultId = clszx_ResearchResultBL.zx_ResearchResultDA.AddNewRecordBySQL2WithReturnKey(objzx_ResearchResultEN);
     objzx_ResearchResultEN.zxResultId = strzxResultId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
}
return strzxResultId;
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
if (CheckUniqueness(objzx_ResearchResultEN) == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_ResearchResultBL.AddNewRecordWithReturnKey)", objzx_ResearchResultEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchResultEN.zxResultId) == true || clszx_ResearchResultBL.IsExist(objzx_ResearchResultEN.zxResultId) == true)
 {
     objzx_ResearchResultEN.zxResultId = clszx_ResearchResultBL.GetMaxStrId_S();
 }
string strKey = clszx_ResearchResultBL.zx_ResearchResultDA.AddNewRecordBySQL2WithReturnKey(objzx_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetzxResultId(this clszx_ResearchResultEN objzx_ResearchResultEN, string strzxResultId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxResultId, 10, conzx_ResearchResult.zxResultId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxResultId, 10, conzx_ResearchResult.zxResultId);
}
objzx_ResearchResultEN.zxResultId = strzxResultId; //成果Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.zxResultId) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.zxResultId, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.zxResultId] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetGroupTextId(this clszx_ResearchResultEN objzx_ResearchResultEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_ResearchResult.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_ResearchResult.GroupTextId);
}
objzx_ResearchResultEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.GroupTextId) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.GroupTextId, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.GroupTextId] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetTextId(this clszx_ResearchResultEN objzx_ResearchResultEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_ResearchResult.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_ResearchResult.TextId);
}
objzx_ResearchResultEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.TextId) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.TextId, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.TextId] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetResultTypeId(this clszx_ResearchResultEN objzx_ResearchResultEN, string strResultTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultTypeId, 2, conzx_ResearchResult.ResultTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResultTypeId, 2, conzx_ResearchResult.ResultTypeId);
}
objzx_ResearchResultEN.ResultTypeId = strResultTypeId; //成果类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.ResultTypeId) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.ResultTypeId, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.ResultTypeId] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetResultName(this clszx_ResearchResultEN objzx_ResearchResultEN, string strResultName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultName, 500, conzx_ResearchResult.ResultName);
}
objzx_ResearchResultEN.ResultName = strResultName; //成果名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.ResultName) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.ResultName, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.ResultName] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetResultContent(this clszx_ResearchResultEN objzx_ResearchResultEN, string strResultContent, string strComparisonOp="")
	{
objzx_ResearchResultEN.ResultContent = strResultContent; //成果内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.ResultContent) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.ResultContent, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.ResultContent] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetAuthor(this clszx_ResearchResultEN objzx_ResearchResultEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, conzx_ResearchResult.Author);
}
objzx_ResearchResultEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.Author) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.Author, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.Author] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetDivision(this clszx_ResearchResultEN objzx_ResearchResultEN, string strDivision, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDivision, 500, conzx_ResearchResult.Division);
}
objzx_ResearchResultEN.Division = strDivision; //分工
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.Division) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.Division, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.Division] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetVersionCount(this clszx_ResearchResultEN objzx_ResearchResultEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_ResearchResultEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.VersionCount) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.VersionCount, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.VersionCount] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetOkCount(this clszx_ResearchResultEN objzx_ResearchResultEN, int? intOkCount, string strComparisonOp="")
	{
objzx_ResearchResultEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.OkCount) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.OkCount, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.OkCount] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetAppraiseCount(this clszx_ResearchResultEN objzx_ResearchResultEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_ResearchResultEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.AppraiseCount) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.AppraiseCount, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.AppraiseCount] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetScore(this clszx_ResearchResultEN objzx_ResearchResultEN, float? fltScore, string strComparisonOp="")
	{
objzx_ResearchResultEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.Score) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.Score, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.Score] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetStuScore(this clszx_ResearchResultEN objzx_ResearchResultEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_ResearchResultEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.StuScore) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.StuScore, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.StuScore] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetTeaScore(this clszx_ResearchResultEN objzx_ResearchResultEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_ResearchResultEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.TeaScore) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.TeaScore, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.TeaScore] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetUpdDate(this clszx_ResearchResultEN objzx_ResearchResultEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_ResearchResult.UpdDate);
}
objzx_ResearchResultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.UpdDate) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.UpdDate, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.UpdDate] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetUpdUser(this clszx_ResearchResultEN objzx_ResearchResultEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_ResearchResult.UpdUser);
}
objzx_ResearchResultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.UpdUser) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.UpdUser, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.UpdUser] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetMemo(this clszx_ResearchResultEN objzx_ResearchResultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_ResearchResult.Memo);
}
objzx_ResearchResultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.Memo) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.Memo, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.Memo] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchResultEN SetIdCurrEduCls(this clszx_ResearchResultEN objzx_ResearchResultEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, conzx_ResearchResult.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_ResearchResult.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_ResearchResult.IdCurrEduCls);
}
objzx_ResearchResultEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(conzx_ResearchResult.IdCurrEduCls) == false)
{
objzx_ResearchResultEN.dicFldComparisonOp.Add(conzx_ResearchResult.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_ResearchResultEN.dicFldComparisonOp[conzx_ResearchResult.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_ResearchResultEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ResearchResultEN.CheckPropertyNew();
clszx_ResearchResultEN objzx_ResearchResultCond = new clszx_ResearchResultEN();
string strCondition = objzx_ResearchResultCond
.SetzxResultId(objzx_ResearchResultEN.zxResultId, "<>")
.SetGroupTextId(objzx_ResearchResultEN.GroupTextId, "=")
.GetCombineCondition();
objzx_ResearchResultEN._IsCheckProperty = true;
bool bolIsExist = clszx_ResearchResultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(GroupTextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ResearchResultEN.Update();
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
 /// <param name = "objzx_ResearchResult">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ResearchResultEN objzx_ResearchResult)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ResearchResultEN objzx_ResearchResultCond = new clszx_ResearchResultEN();
string strCondition = objzx_ResearchResultCond
.SetGroupTextId(objzx_ResearchResult.GroupTextId, "=")
.GetCombineCondition();
objzx_ResearchResult._IsCheckProperty = true;
bool bolIsExist = clszx_ResearchResultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_ResearchResult.zxResultId = clszx_ResearchResultBL.GetFirstID_S(strCondition);
objzx_ResearchResult.UpdateWithCondition(strCondition);
}
else
{
objzx_ResearchResult.zxResultId = clszx_ResearchResultBL.GetMaxStrId_S();
objzx_ResearchResult.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
 if (string.IsNullOrEmpty(objzx_ResearchResultEN.zxResultId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ResearchResultBL.zx_ResearchResultDA.UpdateBySql2(objzx_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ResearchResultEN objzx_ResearchResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_ResearchResultEN.zxResultId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ResearchResultBL.zx_ResearchResultDA.UpdateBySql2(objzx_ResearchResultEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ResearchResultEN objzx_ResearchResultEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ResearchResultBL.zx_ResearchResultDA.UpdateBySqlWithCondition(objzx_ResearchResultEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ResearchResultEN objzx_ResearchResultEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ResearchResultBL.zx_ResearchResultDA.UpdateBySqlWithConditionTransaction(objzx_ResearchResultEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "strzxResultId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
try
{
int intRecNum = clszx_ResearchResultBL.zx_ResearchResultDA.DelRecord(objzx_ResearchResultEN.zxResultId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchResultENS">源对象</param>
 /// <param name = "objzx_ResearchResultENT">目标对象</param>
 public static void CopyTo(this clszx_ResearchResultEN objzx_ResearchResultENS, clszx_ResearchResultEN objzx_ResearchResultENT)
{
try
{
objzx_ResearchResultENT.zxResultId = objzx_ResearchResultENS.zxResultId; //成果Id
objzx_ResearchResultENT.GroupTextId = objzx_ResearchResultENS.GroupTextId; //小组Id
objzx_ResearchResultENT.TextId = objzx_ResearchResultENS.TextId; //课件Id
objzx_ResearchResultENT.ResultTypeId = objzx_ResearchResultENS.ResultTypeId; //成果类型Id
objzx_ResearchResultENT.ResultName = objzx_ResearchResultENS.ResultName; //成果名称
objzx_ResearchResultENT.ResultContent = objzx_ResearchResultENS.ResultContent; //成果内容
objzx_ResearchResultENT.Author = objzx_ResearchResultENS.Author; //作者
objzx_ResearchResultENT.Division = objzx_ResearchResultENS.Division; //分工
objzx_ResearchResultENT.VersionCount = objzx_ResearchResultENS.VersionCount; //版本统计
objzx_ResearchResultENT.OkCount = objzx_ResearchResultENS.OkCount; //点赞统计
objzx_ResearchResultENT.AppraiseCount = objzx_ResearchResultENS.AppraiseCount; //评论数
objzx_ResearchResultENT.Score = objzx_ResearchResultENS.Score; //评分
objzx_ResearchResultENT.StuScore = objzx_ResearchResultENS.StuScore; //学生平均分
objzx_ResearchResultENT.TeaScore = objzx_ResearchResultENS.TeaScore; //教师评分
objzx_ResearchResultENT.UpdDate = objzx_ResearchResultENS.UpdDate; //修改日期
objzx_ResearchResultENT.UpdUser = objzx_ResearchResultENS.UpdUser; //修改人
objzx_ResearchResultENT.Memo = objzx_ResearchResultENS.Memo; //备注
objzx_ResearchResultENT.IdCurrEduCls = objzx_ResearchResultENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_ResearchResultENS">源对象</param>
 /// <returns>目标对象=>clszx_ResearchResultEN:objzx_ResearchResultENT</returns>
 public static clszx_ResearchResultEN CopyTo(this clszx_ResearchResultEN objzx_ResearchResultENS)
{
try
{
 clszx_ResearchResultEN objzx_ResearchResultENT = new clszx_ResearchResultEN()
{
zxResultId = objzx_ResearchResultENS.zxResultId, //成果Id
GroupTextId = objzx_ResearchResultENS.GroupTextId, //小组Id
TextId = objzx_ResearchResultENS.TextId, //课件Id
ResultTypeId = objzx_ResearchResultENS.ResultTypeId, //成果类型Id
ResultName = objzx_ResearchResultENS.ResultName, //成果名称
ResultContent = objzx_ResearchResultENS.ResultContent, //成果内容
Author = objzx_ResearchResultENS.Author, //作者
Division = objzx_ResearchResultENS.Division, //分工
VersionCount = objzx_ResearchResultENS.VersionCount, //版本统计
OkCount = objzx_ResearchResultENS.OkCount, //点赞统计
AppraiseCount = objzx_ResearchResultENS.AppraiseCount, //评论数
Score = objzx_ResearchResultENS.Score, //评分
StuScore = objzx_ResearchResultENS.StuScore, //学生平均分
TeaScore = objzx_ResearchResultENS.TeaScore, //教师评分
UpdDate = objzx_ResearchResultENS.UpdDate, //修改日期
UpdUser = objzx_ResearchResultENS.UpdUser, //修改人
Memo = objzx_ResearchResultENS.Memo, //备注
IdCurrEduCls = objzx_ResearchResultENS.IdCurrEduCls, //教学班流水号
};
 return objzx_ResearchResultENT;
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
public static void CheckPropertyNew(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
 clszx_ResearchResultBL.zx_ResearchResultDA.CheckPropertyNew(objzx_ResearchResultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
 clszx_ResearchResultBL.zx_ResearchResultDA.CheckProperty4Condition(objzx_ResearchResultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ResearchResultEN objzx_ResearchResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.zxResultId) == true)
{
string strComparisonOpzxResultId = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.zxResultId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.zxResultId, objzx_ResearchResultCond.zxResultId, strComparisonOpzxResultId);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.GroupTextId, objzx_ResearchResultCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.TextId) == true)
{
string strComparisonOpTextId = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.TextId, objzx_ResearchResultCond.TextId, strComparisonOpTextId);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.ResultTypeId) == true)
{
string strComparisonOpResultTypeId = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.ResultTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.ResultTypeId, objzx_ResearchResultCond.ResultTypeId, strComparisonOpResultTypeId);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.ResultName) == true)
{
string strComparisonOpResultName = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.ResultName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.ResultName, objzx_ResearchResultCond.ResultName, strComparisonOpResultName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.Author) == true)
{
string strComparisonOpAuthor = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.Author, objzx_ResearchResultCond.Author, strComparisonOpAuthor);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.Division) == true)
{
string strComparisonOpDivision = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.Division];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.Division, objzx_ResearchResultCond.Division, strComparisonOpDivision);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ResearchResult.VersionCount, objzx_ResearchResultCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.OkCount) == true)
{
string strComparisonOpOkCount = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ResearchResult.OkCount, objzx_ResearchResultCond.OkCount, strComparisonOpOkCount);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ResearchResult.AppraiseCount, objzx_ResearchResultCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.Score) == true)
{
string strComparisonOpScore = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ResearchResult.Score, objzx_ResearchResultCond.Score, strComparisonOpScore);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.StuScore) == true)
{
string strComparisonOpStuScore = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ResearchResult.StuScore, objzx_ResearchResultCond.StuScore, strComparisonOpStuScore);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ResearchResult.TeaScore, objzx_ResearchResultCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.UpdDate, objzx_ResearchResultCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.UpdUser, objzx_ResearchResultCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.Memo) == true)
{
string strComparisonOpMemo = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.Memo, objzx_ResearchResultCond.Memo, strComparisonOpMemo);
}
if (objzx_ResearchResultCond.IsUpdated(conzx_ResearchResult.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_ResearchResultCond.dicFldComparisonOp[conzx_ResearchResult.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchResult.IdCurrEduCls, objzx_ResearchResultCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_ResearchResult(中学研究成果), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ResearchResultEN == null) return true;
if (objzx_ResearchResultEN.zxResultId == null || objzx_ResearchResultEN.zxResultId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_ResearchResultEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_ResearchResultEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchResultEN.GroupTextId);
}
if (clszx_ResearchResultBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxResultId !=  '{0}'", objzx_ResearchResultEN.zxResultId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchResultEN.GroupTextId);
if (clszx_ResearchResultBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_ResearchResult(中学研究成果), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ResearchResultEN objzx_ResearchResultEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ResearchResultEN == null) return "";
if (objzx_ResearchResultEN.zxResultId == null || objzx_ResearchResultEN.zxResultId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_ResearchResultEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_ResearchResultEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchResultEN.GroupTextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxResultId !=  '{0}'", objzx_ResearchResultEN.zxResultId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchResultEN.GroupTextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_ResearchResult
{
public virtual bool UpdRelaTabDate(string strzxResultId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学研究成果(zx_ResearchResult)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ResearchResultBL
{
public static RelatedActions_zx_ResearchResult relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ResearchResultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ResearchResultDA zx_ResearchResultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ResearchResultDA();
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
 public clszx_ResearchResultBL()
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
if (string.IsNullOrEmpty(clszx_ResearchResultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ResearchResultEN._ConnectString);
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
public static DataTable GetDataTable_zx_ResearchResult(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ResearchResultDA.GetDataTable_zx_ResearchResult(strWhereCond);
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
objDT = zx_ResearchResultDA.GetDataTable(strWhereCond);
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
objDT = zx_ResearchResultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ResearchResultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ResearchResultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ResearchResultDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ResearchResultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxResultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ResearchResultEN> GetObjLstByZxResultIdLst(List<string> arrZxResultIdLst)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxResultIdLst, true);
 string strWhereCond = string.Format("zxResultId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxResultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ResearchResultEN> GetObjLstByZxResultIdLstCache(List<string> arrZxResultIdLst)
{
string strKey = string.Format("{0}", clszx_ResearchResultEN._CurrTabName);
List<clszx_ResearchResultEN> arrzx_ResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clszx_ResearchResultEN> arrzx_ResearchResultObjLst_Sel =
arrzx_ResearchResultObjLstCache
.Where(x => arrZxResultIdLst.Contains(x.zxResultId));
return arrzx_ResearchResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ResearchResultEN> GetObjLst(string strWhereCond)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
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
public static List<clszx_ResearchResultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ResearchResultEN> GetSubObjLstCache(clszx_ResearchResultEN objzx_ResearchResultCond)
{
List<clszx_ResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ResearchResult.AttributeName)
{
if (objzx_ResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objzx_ResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ResearchResultCond[strFldName].ToString());
}
else
{
if (objzx_ResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ResearchResultCond[strFldName]));
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
public static List<clszx_ResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
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
public static List<clszx_ResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
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
List<clszx_ResearchResultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ResearchResultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ResearchResultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
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
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
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
public static List<clszx_ResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ResearchResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
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
public static List<clszx_ResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ResearchResultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ResearchResultEN> arrObjLst = new List<clszx_ResearchResultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchResultEN objzx_ResearchResultEN = new clszx_ResearchResultEN();
try
{
objzx_ResearchResultEN.zxResultId = objRow[conzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objzx_ResearchResultEN.GroupTextId = objRow[conzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objzx_ResearchResultEN.TextId = objRow[conzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[conzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objzx_ResearchResultEN.ResultTypeId = objRow[conzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objzx_ResearchResultEN.ResultName = objRow[conzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objzx_ResearchResultEN.ResultContent = objRow[conzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[conzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objzx_ResearchResultEN.Author = objRow[conzx_ResearchResult.Author] == DBNull.Value ? null : objRow[conzx_ResearchResult.Author].ToString().Trim(); //作者
objzx_ResearchResultEN.Division = objRow[conzx_ResearchResult.Division] == DBNull.Value ? null : objRow[conzx_ResearchResult.Division].ToString().Trim(); //分工
objzx_ResearchResultEN.VersionCount = objRow[conzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objzx_ResearchResultEN.OkCount = objRow[conzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objzx_ResearchResultEN.AppraiseCount = objRow[conzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objzx_ResearchResultEN.Score = objRow[conzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.Score].ToString().Trim()); //评分
objzx_ResearchResultEN.StuScore = objRow[conzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objzx_ResearchResultEN.TeaScore = objRow[conzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objzx_ResearchResultEN.UpdDate = objRow[conzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchResultEN.UpdUser = objRow[conzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objzx_ResearchResultEN.Memo = objRow[conzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[conzx_ResearchResult.Memo].ToString().Trim(); //备注
objzx_ResearchResultEN.IdCurrEduCls = objRow[conzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchResultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_ResearchResult(ref clszx_ResearchResultEN objzx_ResearchResultEN)
{
bool bolResult = zx_ResearchResultDA.Getzx_ResearchResult(ref objzx_ResearchResultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxResultId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ResearchResultEN GetObjByzxResultId(string strzxResultId)
{
if (strzxResultId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxResultId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxResultId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxResultId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_ResearchResultEN objzx_ResearchResultEN = zx_ResearchResultDA.GetObjByzxResultId(strzxResultId);
return objzx_ResearchResultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ResearchResultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ResearchResultEN objzx_ResearchResultEN = zx_ResearchResultDA.GetFirstObj(strWhereCond);
 return objzx_ResearchResultEN;
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
public static clszx_ResearchResultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ResearchResultEN objzx_ResearchResultEN = zx_ResearchResultDA.GetObjByDataRow(objRow);
 return objzx_ResearchResultEN;
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
public static clszx_ResearchResultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ResearchResultEN objzx_ResearchResultEN = zx_ResearchResultDA.GetObjByDataRow(objRow);
 return objzx_ResearchResultEN;
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
 /// <param name = "strzxResultId">所给的关键字</param>
 /// <param name = "lstzx_ResearchResultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ResearchResultEN GetObjByzxResultIdFromList(string strzxResultId, List<clszx_ResearchResultEN> lstzx_ResearchResultObjLst)
{
foreach (clszx_ResearchResultEN objzx_ResearchResultEN in lstzx_ResearchResultObjLst)
{
if (objzx_ResearchResultEN.zxResultId == strzxResultId)
{
return objzx_ResearchResultEN;
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
 string strMaxZxResultId;
 try
 {
 strMaxZxResultId = clszx_ResearchResultDA.GetMaxStrId();
 return strMaxZxResultId;
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
 string strzxResultId;
 try
 {
 strzxResultId = new clszx_ResearchResultDA().GetFirstID(strWhereCond);
 return strzxResultId;
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
 arrList = zx_ResearchResultDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ResearchResultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxResultId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxResultId)
{
if (string.IsNullOrEmpty(strzxResultId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxResultId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_ResearchResultDA.IsExist(strzxResultId);
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
 bolIsExist = clszx_ResearchResultDA.IsExistTable();
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
 bolIsExist = zx_ResearchResultDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ResearchResultEN objzx_ResearchResultEN)
{
if (objzx_ResearchResultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_ResearchResultBL.AddNewRecordBySql2)", objzx_ResearchResultEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchResultEN.zxResultId) == true || clszx_ResearchResultBL.IsExist(objzx_ResearchResultEN.zxResultId) == true)
 {
     objzx_ResearchResultEN.zxResultId = clszx_ResearchResultBL.GetMaxStrId_S();
 }
bool bolResult = zx_ResearchResultDA.AddNewRecordBySQL2(objzx_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ResearchResultEN objzx_ResearchResultEN)
{
if (objzx_ResearchResultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_ResearchResultBL.AddNewRecordBySql2WithReturnKey)", objzx_ResearchResultEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchResultEN.zxResultId) == true || clszx_ResearchResultBL.IsExist(objzx_ResearchResultEN.zxResultId) == true)
 {
     objzx_ResearchResultEN.zxResultId = clszx_ResearchResultBL.GetMaxStrId_S();
 }
string strKey = zx_ResearchResultDA.AddNewRecordBySQL2WithReturnKey(objzx_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ResearchResultEN objzx_ResearchResultEN)
{
try
{
bool bolResult = zx_ResearchResultDA.Update(objzx_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ResearchResultEN objzx_ResearchResultEN)
{
 if (string.IsNullOrEmpty(objzx_ResearchResultEN.zxResultId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ResearchResultDA.UpdateBySql2(objzx_ResearchResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchResultBL.ReFreshCache();

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
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
 /// <param name = "strzxResultId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxResultId)
{
try
{
 clszx_ResearchResultEN objzx_ResearchResultEN = clszx_ResearchResultBL.GetObjByzxResultId(strzxResultId);

if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(objzx_ResearchResultEN.zxResultId, "SetUpdDate");
}
if (objzx_ResearchResultEN != null)
{
int intRecNum = zx_ResearchResultDA.DelRecord(strzxResultId);
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
/// <param name="strzxResultId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxResultId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
//删除与表:[zx_ResearchResult]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_ResearchResult.zxResultId,
//strzxResultId);
//        clszx_ResearchResultBL.Delzx_ResearchResultsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ResearchResultBL.DelRecord(strzxResultId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ResearchResultBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxResultId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxResultId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxResultId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ResearchResultBL.relatedActions != null)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(strzxResultId, "UpdRelaTabDate");
}
bool bolResult = zx_ResearchResultDA.DelRecord(strzxResultId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxResultIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_ResearchResults(List<string> arrzxResultIdLst)
{
if (arrzxResultIdLst.Count == 0) return 0;
try
{
if (clszx_ResearchResultBL.relatedActions != null)
{
foreach (var strzxResultId in arrzxResultIdLst)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(strzxResultId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_ResearchResultDA.Delzx_ResearchResult(arrzxResultIdLst);
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
public static int Delzx_ResearchResultsByCond(string strWhereCond)
{
try
{
if (clszx_ResearchResultBL.relatedActions != null)
{
List<string> arrzxResultId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxResultId in arrzxResultId)
{
clszx_ResearchResultBL.relatedActions.UpdRelaTabDate(strzxResultId, "UpdRelaTabDate");
}
}
int intRecNum = zx_ResearchResultDA.Delzx_ResearchResult(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_ResearchResult]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxResultId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxResultId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ResearchResultDA.GetSpecSQLObj();
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
//删除与表:[zx_ResearchResult]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ResearchResultBL.DelRecord(strzxResultId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ResearchResultBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxResultId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ResearchResultENS">源对象</param>
 /// <param name = "objzx_ResearchResultENT">目标对象</param>
 public static void CopyTo(clszx_ResearchResultEN objzx_ResearchResultENS, clszx_ResearchResultEN objzx_ResearchResultENT)
{
try
{
objzx_ResearchResultENT.zxResultId = objzx_ResearchResultENS.zxResultId; //成果Id
objzx_ResearchResultENT.GroupTextId = objzx_ResearchResultENS.GroupTextId; //小组Id
objzx_ResearchResultENT.TextId = objzx_ResearchResultENS.TextId; //课件Id
objzx_ResearchResultENT.ResultTypeId = objzx_ResearchResultENS.ResultTypeId; //成果类型Id
objzx_ResearchResultENT.ResultName = objzx_ResearchResultENS.ResultName; //成果名称
objzx_ResearchResultENT.ResultContent = objzx_ResearchResultENS.ResultContent; //成果内容
objzx_ResearchResultENT.Author = objzx_ResearchResultENS.Author; //作者
objzx_ResearchResultENT.Division = objzx_ResearchResultENS.Division; //分工
objzx_ResearchResultENT.VersionCount = objzx_ResearchResultENS.VersionCount; //版本统计
objzx_ResearchResultENT.OkCount = objzx_ResearchResultENS.OkCount; //点赞统计
objzx_ResearchResultENT.AppraiseCount = objzx_ResearchResultENS.AppraiseCount; //评论数
objzx_ResearchResultENT.Score = objzx_ResearchResultENS.Score; //评分
objzx_ResearchResultENT.StuScore = objzx_ResearchResultENS.StuScore; //学生平均分
objzx_ResearchResultENT.TeaScore = objzx_ResearchResultENS.TeaScore; //教师评分
objzx_ResearchResultENT.UpdDate = objzx_ResearchResultENS.UpdDate; //修改日期
objzx_ResearchResultENT.UpdUser = objzx_ResearchResultENS.UpdUser; //修改人
objzx_ResearchResultENT.Memo = objzx_ResearchResultENS.Memo; //备注
objzx_ResearchResultENT.IdCurrEduCls = objzx_ResearchResultENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_ResearchResultEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ResearchResultEN objzx_ResearchResultEN)
{
try
{
objzx_ResearchResultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ResearchResultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_ResearchResult.zxResultId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.zxResultId = objzx_ResearchResultEN.zxResultId; //成果Id
}
if (arrFldSet.Contains(conzx_ResearchResult.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.GroupTextId = objzx_ResearchResultEN.GroupTextId == "[null]" ? null :  objzx_ResearchResultEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(conzx_ResearchResult.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.TextId = objzx_ResearchResultEN.TextId == "[null]" ? null :  objzx_ResearchResultEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_ResearchResult.ResultTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.ResultTypeId = objzx_ResearchResultEN.ResultTypeId == "[null]" ? null :  objzx_ResearchResultEN.ResultTypeId; //成果类型Id
}
if (arrFldSet.Contains(conzx_ResearchResult.ResultName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.ResultName = objzx_ResearchResultEN.ResultName == "[null]" ? null :  objzx_ResearchResultEN.ResultName; //成果名称
}
if (arrFldSet.Contains(conzx_ResearchResult.ResultContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.ResultContent = objzx_ResearchResultEN.ResultContent == "[null]" ? null :  objzx_ResearchResultEN.ResultContent; //成果内容
}
if (arrFldSet.Contains(conzx_ResearchResult.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.Author = objzx_ResearchResultEN.Author == "[null]" ? null :  objzx_ResearchResultEN.Author; //作者
}
if (arrFldSet.Contains(conzx_ResearchResult.Division, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.Division = objzx_ResearchResultEN.Division == "[null]" ? null :  objzx_ResearchResultEN.Division; //分工
}
if (arrFldSet.Contains(conzx_ResearchResult.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.VersionCount = objzx_ResearchResultEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_ResearchResult.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.OkCount = objzx_ResearchResultEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conzx_ResearchResult.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.AppraiseCount = objzx_ResearchResultEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_ResearchResult.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.Score = objzx_ResearchResultEN.Score; //评分
}
if (arrFldSet.Contains(conzx_ResearchResult.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.StuScore = objzx_ResearchResultEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_ResearchResult.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.TeaScore = objzx_ResearchResultEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_ResearchResult.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.UpdDate = objzx_ResearchResultEN.UpdDate == "[null]" ? null :  objzx_ResearchResultEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_ResearchResult.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.UpdUser = objzx_ResearchResultEN.UpdUser == "[null]" ? null :  objzx_ResearchResultEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_ResearchResult.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.Memo = objzx_ResearchResultEN.Memo == "[null]" ? null :  objzx_ResearchResultEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_ResearchResult.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchResultEN.IdCurrEduCls = objzx_ResearchResultEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_ResearchResultEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ResearchResultEN objzx_ResearchResultEN)
{
try
{
if (objzx_ResearchResultEN.GroupTextId == "[null]") objzx_ResearchResultEN.GroupTextId = null; //小组Id
if (objzx_ResearchResultEN.TextId == "[null]") objzx_ResearchResultEN.TextId = null; //课件Id
if (objzx_ResearchResultEN.ResultTypeId == "[null]") objzx_ResearchResultEN.ResultTypeId = null; //成果类型Id
if (objzx_ResearchResultEN.ResultName == "[null]") objzx_ResearchResultEN.ResultName = null; //成果名称
if (objzx_ResearchResultEN.ResultContent == "[null]") objzx_ResearchResultEN.ResultContent = null; //成果内容
if (objzx_ResearchResultEN.Author == "[null]") objzx_ResearchResultEN.Author = null; //作者
if (objzx_ResearchResultEN.Division == "[null]") objzx_ResearchResultEN.Division = null; //分工
if (objzx_ResearchResultEN.UpdDate == "[null]") objzx_ResearchResultEN.UpdDate = null; //修改日期
if (objzx_ResearchResultEN.UpdUser == "[null]") objzx_ResearchResultEN.UpdUser = null; //修改人
if (objzx_ResearchResultEN.Memo == "[null]") objzx_ResearchResultEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_ResearchResultEN objzx_ResearchResultEN)
{
 zx_ResearchResultDA.CheckPropertyNew(objzx_ResearchResultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ResearchResultEN objzx_ResearchResultEN)
{
 zx_ResearchResultDA.CheckProperty4Condition(objzx_ResearchResultEN);
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
if (clszx_ResearchResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ResearchResultBL没有刷新缓存机制(clszx_ResearchResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxResultId");
//if (arrzx_ResearchResultObjLstCache == null)
//{
//arrzx_ResearchResultObjLstCache = zx_ResearchResultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxResultId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ResearchResultEN GetObjByzxResultIdCache(string strzxResultId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_ResearchResultEN._CurrTabName);
List<clszx_ResearchResultEN> arrzx_ResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clszx_ResearchResultEN> arrzx_ResearchResultObjLst_Sel =
arrzx_ResearchResultObjLstCache
.Where(x=> x.zxResultId == strzxResultId 
);
if (arrzx_ResearchResultObjLst_Sel.Count() == 0)
{
   clszx_ResearchResultEN obj = clszx_ResearchResultBL.GetObjByzxResultId(strzxResultId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_ResearchResultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ResearchResultEN> GetAllzx_ResearchResultObjLstCache()
{
//获取缓存中的对象列表
List<clszx_ResearchResultEN> arrzx_ResearchResultObjLstCache = GetObjLstCache(); 
return arrzx_ResearchResultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ResearchResultEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_ResearchResultEN._CurrTabName);
List<clszx_ResearchResultEN> arrzx_ResearchResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_ResearchResultObjLstCache;
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
string strKey = string.Format("{0}", clszx_ResearchResultEN._CurrTabName);
CacheHelper.Remove(strKey);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clszx_ResearchResultBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_ResearchResultEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_ResearchResultBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_ResearchResult(中学研究成果)
 /// 唯一性条件:GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ResearchResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ResearchResultEN objzx_ResearchResultEN)
{
//检测记录是否存在
string strResult = zx_ResearchResultDA.GetUniCondStr(objzx_ResearchResultEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxResultId)
{
if (strInFldName != conzx_ResearchResult.zxResultId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_ResearchResult.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_ResearchResult.AttributeName));
throw new Exception(strMsg);
}
var objzx_ResearchResult = clszx_ResearchResultBL.GetObjByzxResultIdCache(strzxResultId);
if (objzx_ResearchResult == null) return "";
return objzx_ResearchResult[strOutFldName].ToString();
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
int intRecCount = clszx_ResearchResultDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ResearchResultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ResearchResultDA.GetRecCount();
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
int intRecCount = clszx_ResearchResultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ResearchResultEN objzx_ResearchResultCond)
{
List<clszx_ResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ResearchResult.AttributeName)
{
if (objzx_ResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objzx_ResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ResearchResultCond[strFldName].ToString());
}
else
{
if (objzx_ResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ResearchResultCond[strFldName]));
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
 List<string> arrList = clszx_ResearchResultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ResearchResultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ResearchResultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ResearchResultDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ResearchResultDA.SetFldValue(clszx_ResearchResultEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ResearchResultDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ResearchResultDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ResearchResultDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ResearchResultDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_ResearchResult] "); 
 strCreateTabCode.Append(" ( "); 
 // /**成果Id*/ 
 strCreateTabCode.Append(" zxResultId char(10) primary key, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
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
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学研究成果(zx_ResearchResult)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_ResearchResult : clsCommFun4BL
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
clszx_ResearchResultBL.ReFreshThisCache();
}
}

}