
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TobeStudiedProblemBL
 表名:gs_TobeStudiedProblem(01120776)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:39
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
public static class  clsgs_TobeStudiedProblemBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TobeStudiedProblemEN GetObj(this K_ProblemId_gs_TobeStudiedProblem myKey)
{
clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.GetObjByProblemId(myKey.Value);
return objgs_TobeStudiedProblemEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TobeStudiedProblemEN) == false)
{
var strMsg = string.Format("记录已经存在!问题Id = [{0}]的数据已经存在!(in clsgs_TobeStudiedProblemBL.AddNewRecord)", objgs_TobeStudiedProblemEN.ProblemId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TobeStudiedProblemEN.ProblemId) == true || clsgs_TobeStudiedProblemBL.IsExist(objgs_TobeStudiedProblemEN.ProblemId) == true)
 {
     objgs_TobeStudiedProblemEN.ProblemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.AddNewRecordBySQL2(objgs_TobeStudiedProblemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_TobeStudiedProblemBL.IsExist(objgs_TobeStudiedProblemEN.ProblemId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_TobeStudiedProblemEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_TobeStudiedProblemEN.CheckUniqueness() == false)
{
strMsg = string.Format("(问题Id(ProblemId)=[{0}])已经存在,不能重复!", objgs_TobeStudiedProblemEN.ProblemId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_TobeStudiedProblemEN.ProblemId) == true || clsgs_TobeStudiedProblemBL.IsExist(objgs_TobeStudiedProblemEN.ProblemId) == true)
 {
     objgs_TobeStudiedProblemEN.ProblemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_TobeStudiedProblemEN.AddNewRecord();
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TobeStudiedProblemEN) == false)
{
var strMsg = string.Format("记录已经存在!问题Id = [{0}]的数据已经存在!(in clsgs_TobeStudiedProblemBL.AddNewRecordWithMaxId)", objgs_TobeStudiedProblemEN.ProblemId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TobeStudiedProblemEN.ProblemId) == true || clsgs_TobeStudiedProblemBL.IsExist(objgs_TobeStudiedProblemEN.ProblemId) == true)
 {
     objgs_TobeStudiedProblemEN.ProblemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
 }
string strProblemId = clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.AddNewRecordBySQL2WithReturnKey(objgs_TobeStudiedProblemEN);
     objgs_TobeStudiedProblemEN.ProblemId = strProblemId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
}
return strProblemId;
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_TobeStudiedProblemEN) == false)
{
var strMsg = string.Format("记录已经存在!问题Id = [{0}]的数据已经存在!(in clsgs_TobeStudiedProblemBL.AddNewRecordWithReturnKey)", objgs_TobeStudiedProblemEN.ProblemId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TobeStudiedProblemEN.ProblemId) == true || clsgs_TobeStudiedProblemBL.IsExist(objgs_TobeStudiedProblemEN.ProblemId) == true)
 {
     objgs_TobeStudiedProblemEN.ProblemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
 }
string strKey = clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.AddNewRecordBySQL2WithReturnKey(objgs_TobeStudiedProblemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetProblemId(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strProblemId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemId, 10, congs_TobeStudiedProblem.ProblemId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProblemId, 10, congs_TobeStudiedProblem.ProblemId);
}
objgs_TobeStudiedProblemEN.ProblemId = strProblemId; //问题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.ProblemId) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.ProblemId, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.ProblemId] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetProblemTitle(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strProblemTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemTitle, 1000, congs_TobeStudiedProblem.ProblemTitle);
}
objgs_TobeStudiedProblemEN.ProblemTitle = strProblemTitle; //问题标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.ProblemTitle) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.ProblemTitle, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.ProblemTitle] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetProblemContent(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strProblemContent, string strComparisonOp="")
	{
objgs_TobeStudiedProblemEN.ProblemContent = strProblemContent; //问题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.ProblemContent) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.ProblemContent, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.ProblemContent] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetTopicId(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_TobeStudiedProblem.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_TobeStudiedProblem.TopicId);
}
objgs_TobeStudiedProblemEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.TopicId) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.TopicId, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.TopicId] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetIsSubmit(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, bool bolIsSubmit, string strComparisonOp="")
	{
objgs_TobeStudiedProblemEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.IsSubmit) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.IsSubmit, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.IsSubmit] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetProblemDate(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strProblemDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemDate, 20, congs_TobeStudiedProblem.ProblemDate);
}
objgs_TobeStudiedProblemEN.ProblemDate = strProblemDate; //问题日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.ProblemDate) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.ProblemDate, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.ProblemDate] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetUpdDate(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_TobeStudiedProblem.UpdDate);
}
objgs_TobeStudiedProblemEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.UpdDate) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.UpdDate, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.UpdDate] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetUpdUser(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_TobeStudiedProblem.UpdUser);
}
objgs_TobeStudiedProblemEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.UpdUser) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.UpdUser, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.UpdUser] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetYear(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, congs_TobeStudiedProblem.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, congs_TobeStudiedProblem.Year);
}
objgs_TobeStudiedProblemEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.Year) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.Year, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.Year] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetMonth(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, congs_TobeStudiedProblem.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, congs_TobeStudiedProblem.Month);
}
objgs_TobeStudiedProblemEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.Month) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.Month, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.Month] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetVersionCount(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, int? intVersionCount, string strComparisonOp="")
	{
objgs_TobeStudiedProblemEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.VersionCount) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.VersionCount, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.VersionCount] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetParticipant(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strParticipant, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParticipant, 500, congs_TobeStudiedProblem.Participant);
}
objgs_TobeStudiedProblemEN.Participant = strParticipant; //参与者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.Participant) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.Participant, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.Participant] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetMemo(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_TobeStudiedProblem.Memo);
}
objgs_TobeStudiedProblemEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.Memo) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.Memo, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.Memo] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_TobeStudiedProblemEN SetIdCurrEduCls(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_TobeStudiedProblem.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_TobeStudiedProblem.IdCurrEduCls);
}
objgs_TobeStudiedProblemEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(congs_TobeStudiedProblem.IdCurrEduCls) == false)
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(congs_TobeStudiedProblem.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_TobeStudiedProblemEN.dicFldComparisonOp[congs_TobeStudiedProblem.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_TobeStudiedProblemEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_TobeStudiedProblemEN.CheckPropertyNew();
clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemCond = new clsgs_TobeStudiedProblemEN();
string strCondition = objgs_TobeStudiedProblemCond
.SetProblemId(objgs_TobeStudiedProblemEN.ProblemId, "<>")
.SetProblemId(objgs_TobeStudiedProblemEN.ProblemId, "=")
.GetCombineCondition();
objgs_TobeStudiedProblemEN._IsCheckProperty = true;
bool bolIsExist = clsgs_TobeStudiedProblemBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ProblemId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_TobeStudiedProblemEN.Update();
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
 /// <param name = "objgs_TobeStudiedProblem">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblem)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemCond = new clsgs_TobeStudiedProblemEN();
string strCondition = objgs_TobeStudiedProblemCond
.SetProblemId(objgs_TobeStudiedProblem.ProblemId, "=")
.GetCombineCondition();
objgs_TobeStudiedProblem._IsCheckProperty = true;
bool bolIsExist = clsgs_TobeStudiedProblemBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_TobeStudiedProblem.ProblemId = clsgs_TobeStudiedProblemBL.GetFirstID_S(strCondition);
objgs_TobeStudiedProblem.UpdateWithCondition(strCondition);
}
else
{
objgs_TobeStudiedProblem.ProblemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
objgs_TobeStudiedProblem.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 if (string.IsNullOrEmpty(objgs_TobeStudiedProblemEN.ProblemId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.UpdateBySql2(objgs_TobeStudiedProblemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_TobeStudiedProblemEN.ProblemId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.UpdateBySql2(objgs_TobeStudiedProblemEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.UpdateBySqlWithCondition(objgs_TobeStudiedProblemEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.UpdateBySqlWithConditionTransaction(objgs_TobeStudiedProblemEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
try
{
int intRecNum = clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.DelRecord(objgs_TobeStudiedProblemEN.ProblemId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "objgs_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objgs_TobeStudiedProblemENT">目标对象</param>
 public static void CopyTo(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENS, clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENT)
{
try
{
objgs_TobeStudiedProblemENT.ProblemId = objgs_TobeStudiedProblemENS.ProblemId; //问题Id
objgs_TobeStudiedProblemENT.ProblemTitle = objgs_TobeStudiedProblemENS.ProblemTitle; //问题标题
objgs_TobeStudiedProblemENT.ProblemContent = objgs_TobeStudiedProblemENS.ProblemContent; //问题内容
objgs_TobeStudiedProblemENT.TopicId = objgs_TobeStudiedProblemENS.TopicId; //主题Id
objgs_TobeStudiedProblemENT.IsSubmit = objgs_TobeStudiedProblemENS.IsSubmit; //是否提交
objgs_TobeStudiedProblemENT.ProblemDate = objgs_TobeStudiedProblemENS.ProblemDate; //问题日期
objgs_TobeStudiedProblemENT.UpdDate = objgs_TobeStudiedProblemENS.UpdDate; //修改日期
objgs_TobeStudiedProblemENT.UpdUser = objgs_TobeStudiedProblemENS.UpdUser; //修改人
objgs_TobeStudiedProblemENT.Year = objgs_TobeStudiedProblemENS.Year; //年
objgs_TobeStudiedProblemENT.Month = objgs_TobeStudiedProblemENS.Month; //月
objgs_TobeStudiedProblemENT.VersionCount = objgs_TobeStudiedProblemENS.VersionCount; //版本统计
objgs_TobeStudiedProblemENT.Participant = objgs_TobeStudiedProblemENS.Participant; //参与者
objgs_TobeStudiedProblemENT.Memo = objgs_TobeStudiedProblemENS.Memo; //备注
objgs_TobeStudiedProblemENT.IdCurrEduCls = objgs_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objgs_TobeStudiedProblemENS">源对象</param>
 /// <returns>目标对象=>clsgs_TobeStudiedProblemEN:objgs_TobeStudiedProblemENT</returns>
 public static clsgs_TobeStudiedProblemEN CopyTo(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENS)
{
try
{
 clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENT = new clsgs_TobeStudiedProblemEN()
{
ProblemId = objgs_TobeStudiedProblemENS.ProblemId, //问题Id
ProblemTitle = objgs_TobeStudiedProblemENS.ProblemTitle, //问题标题
ProblemContent = objgs_TobeStudiedProblemENS.ProblemContent, //问题内容
TopicId = objgs_TobeStudiedProblemENS.TopicId, //主题Id
IsSubmit = objgs_TobeStudiedProblemENS.IsSubmit, //是否提交
ProblemDate = objgs_TobeStudiedProblemENS.ProblemDate, //问题日期
UpdDate = objgs_TobeStudiedProblemENS.UpdDate, //修改日期
UpdUser = objgs_TobeStudiedProblemENS.UpdUser, //修改人
Year = objgs_TobeStudiedProblemENS.Year, //年
Month = objgs_TobeStudiedProblemENS.Month, //月
VersionCount = objgs_TobeStudiedProblemENS.VersionCount, //版本统计
Participant = objgs_TobeStudiedProblemENS.Participant, //参与者
Memo = objgs_TobeStudiedProblemENS.Memo, //备注
IdCurrEduCls = objgs_TobeStudiedProblemENS.IdCurrEduCls, //教学班流水号
};
 return objgs_TobeStudiedProblemENT;
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
public static void CheckPropertyNew(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.CheckPropertyNew(objgs_TobeStudiedProblemEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 clsgs_TobeStudiedProblemBL.gs_TobeStudiedProblemDA.CheckProperty4Condition(objgs_TobeStudiedProblemEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.ProblemId) == true)
{
string strComparisonOpProblemId = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.ProblemId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.ProblemId, objgs_TobeStudiedProblemCond.ProblemId, strComparisonOpProblemId);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.ProblemTitle) == true)
{
string strComparisonOpProblemTitle = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.ProblemTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.ProblemTitle, objgs_TobeStudiedProblemCond.ProblemTitle, strComparisonOpProblemTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.TopicId) == true)
{
string strComparisonOpTopicId = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.TopicId, objgs_TobeStudiedProblemCond.TopicId, strComparisonOpTopicId);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.IsSubmit) == true)
{
if (objgs_TobeStudiedProblemCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_TobeStudiedProblem.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_TobeStudiedProblem.IsSubmit);
}
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.ProblemDate) == true)
{
string strComparisonOpProblemDate = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.ProblemDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.ProblemDate, objgs_TobeStudiedProblemCond.ProblemDate, strComparisonOpProblemDate);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.UpdDate, objgs_TobeStudiedProblemCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.UpdUser, objgs_TobeStudiedProblemCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.Year) == true)
{
string strComparisonOpYear = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.Year, objgs_TobeStudiedProblemCond.Year, strComparisonOpYear);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.Month) == true)
{
string strComparisonOpMonth = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.Month, objgs_TobeStudiedProblemCond.Month, strComparisonOpMonth);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.VersionCount) == true)
{
string strComparisonOpVersionCount = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", congs_TobeStudiedProblem.VersionCount, objgs_TobeStudiedProblemCond.VersionCount, strComparisonOpVersionCount);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.Participant) == true)
{
string strComparisonOpParticipant = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.Participant];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.Participant, objgs_TobeStudiedProblemCond.Participant, strComparisonOpParticipant);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.Memo) == true)
{
string strComparisonOpMemo = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.Memo, objgs_TobeStudiedProblemCond.Memo, strComparisonOpMemo);
}
if (objgs_TobeStudiedProblemCond.IsUpdated(congs_TobeStudiedProblem.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_TobeStudiedProblemCond.dicFldComparisonOp[congs_TobeStudiedProblem.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_TobeStudiedProblem.IdCurrEduCls, objgs_TobeStudiedProblemCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_TobeStudiedProblem(待研究问题), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ProblemId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_TobeStudiedProblemEN == null) return true;
if (objgs_TobeStudiedProblemEN.ProblemId == null || objgs_TobeStudiedProblemEN.ProblemId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objgs_TobeStudiedProblemEN.ProblemId);
if (clsgs_TobeStudiedProblemBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ProblemId !=  '{0}'", objgs_TobeStudiedProblemEN.ProblemId);
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objgs_TobeStudiedProblemEN.ProblemId);
if (clsgs_TobeStudiedProblemBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_TobeStudiedProblem(待研究问题), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ProblemId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_TobeStudiedProblemEN == null) return "";
if (objgs_TobeStudiedProblemEN.ProblemId == null || objgs_TobeStudiedProblemEN.ProblemId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objgs_TobeStudiedProblemEN.ProblemId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ProblemId !=  '{0}'", objgs_TobeStudiedProblemEN.ProblemId);
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objgs_TobeStudiedProblemEN.ProblemId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_TobeStudiedProblem
{
public virtual bool UpdRelaTabDate(string strProblemId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 待研究问题(gs_TobeStudiedProblem)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_TobeStudiedProblemBL
{
public static RelatedActions_gs_TobeStudiedProblem relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_TobeStudiedProblemDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_TobeStudiedProblemDA gs_TobeStudiedProblemDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_TobeStudiedProblemDA();
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
 public clsgs_TobeStudiedProblemBL()
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
if (string.IsNullOrEmpty(clsgs_TobeStudiedProblemEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_TobeStudiedProblemEN._ConnectString);
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
public static DataTable GetDataTable_gs_TobeStudiedProblem(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_TobeStudiedProblemDA.GetDataTable_gs_TobeStudiedProblem(strWhereCond);
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
objDT = gs_TobeStudiedProblemDA.GetDataTable(strWhereCond);
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
objDT = gs_TobeStudiedProblemDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_TobeStudiedProblemDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_TobeStudiedProblemDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_TobeStudiedProblemDA.GetDataTable_Top(objTopPara);
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
objDT = gs_TobeStudiedProblemDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_TobeStudiedProblemDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_TobeStudiedProblemDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrProblemIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_TobeStudiedProblemEN> GetObjLstByProblemIdLst(List<string> arrProblemIdLst)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrProblemIdLst, true);
 string strWhereCond = string.Format("ProblemId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrProblemIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_TobeStudiedProblemEN> GetObjLstByProblemIdLstCache(List<string> arrProblemIdLst)
{
string strKey = string.Format("{0}", clsgs_TobeStudiedProblemEN._CurrTabName);
List<clsgs_TobeStudiedProblemEN> arrgs_TobeStudiedProblemObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TobeStudiedProblemEN> arrgs_TobeStudiedProblemObjLst_Sel =
arrgs_TobeStudiedProblemObjLstCache
.Where(x => arrProblemIdLst.Contains(x.ProblemId));
return arrgs_TobeStudiedProblemObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TobeStudiedProblemEN> GetObjLst(string strWhereCond)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
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
public static List<clsgs_TobeStudiedProblemEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_TobeStudiedProblemEN> GetSubObjLstCache(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemCond)
{
List<clsgs_TobeStudiedProblemEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TobeStudiedProblemEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_TobeStudiedProblem.AttributeName)
{
if (objgs_TobeStudiedProblemCond.IsUpdated(strFldName) == false) continue;
if (objgs_TobeStudiedProblemCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TobeStudiedProblemCond[strFldName].ToString());
}
else
{
if (objgs_TobeStudiedProblemCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TobeStudiedProblemCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TobeStudiedProblemCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TobeStudiedProblemCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TobeStudiedProblemCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TobeStudiedProblemCond[strFldName]));
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
public static List<clsgs_TobeStudiedProblemEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
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
public static List<clsgs_TobeStudiedProblemEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
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
List<clsgs_TobeStudiedProblemEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_TobeStudiedProblemEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TobeStudiedProblemEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_TobeStudiedProblemEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
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
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
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
public static List<clsgs_TobeStudiedProblemEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_TobeStudiedProblemEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_TobeStudiedProblemEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
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
public static List<clsgs_TobeStudiedProblemEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_TobeStudiedProblemEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_TobeStudiedProblemEN> arrObjLst = new List<clsgs_TobeStudiedProblemEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = new clsgs_TobeStudiedProblemEN();
try
{
objgs_TobeStudiedProblemEN.ProblemId = objRow[congs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objgs_TobeStudiedProblemEN.ProblemTitle = objRow[congs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objgs_TobeStudiedProblemEN.ProblemContent = objRow[congs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objgs_TobeStudiedProblemEN.TopicId = objRow[congs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objgs_TobeStudiedProblemEN.ProblemDate = objRow[congs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objgs_TobeStudiedProblemEN.UpdDate = objRow[congs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objgs_TobeStudiedProblemEN.UpdUser = objRow[congs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objgs_TobeStudiedProblemEN.Year = objRow[congs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Year].ToString().Trim(); //年
objgs_TobeStudiedProblemEN.Month = objRow[congs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Month].ToString().Trim(); //月
objgs_TobeStudiedProblemEN.VersionCount = objRow[congs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objgs_TobeStudiedProblemEN.Participant = objRow[congs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objgs_TobeStudiedProblemEN.Memo = objRow[congs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[congs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_TobeStudiedProblem(ref clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
bool bolResult = gs_TobeStudiedProblemDA.Getgs_TobeStudiedProblem(ref objgs_TobeStudiedProblemEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_TobeStudiedProblemEN GetObjByProblemId(string strProblemId)
{
if (strProblemId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strProblemId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strProblemId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strProblemId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = gs_TobeStudiedProblemDA.GetObjByProblemId(strProblemId);
return objgs_TobeStudiedProblemEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_TobeStudiedProblemEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = gs_TobeStudiedProblemDA.GetFirstObj(strWhereCond);
 return objgs_TobeStudiedProblemEN;
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
public static clsgs_TobeStudiedProblemEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = gs_TobeStudiedProblemDA.GetObjByDataRow(objRow);
 return objgs_TobeStudiedProblemEN;
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
public static clsgs_TobeStudiedProblemEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = gs_TobeStudiedProblemDA.GetObjByDataRow(objRow);
 return objgs_TobeStudiedProblemEN;
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
 /// <param name = "strProblemId">所给的关键字</param>
 /// <param name = "lstgs_TobeStudiedProblemObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TobeStudiedProblemEN GetObjByProblemIdFromList(string strProblemId, List<clsgs_TobeStudiedProblemEN> lstgs_TobeStudiedProblemObjLst)
{
foreach (clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN in lstgs_TobeStudiedProblemObjLst)
{
if (objgs_TobeStudiedProblemEN.ProblemId == strProblemId)
{
return objgs_TobeStudiedProblemEN;
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
 string strMaxProblemId;
 try
 {
 strMaxProblemId = clsgs_TobeStudiedProblemDA.GetMaxStrId();
 return strMaxProblemId;
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
 string strProblemId;
 try
 {
 strProblemId = new clsgs_TobeStudiedProblemDA().GetFirstID(strWhereCond);
 return strProblemId;
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
 arrList = gs_TobeStudiedProblemDA.GetID(strWhereCond);
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
bool bolIsExist = gs_TobeStudiedProblemDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strProblemId)
{
if (string.IsNullOrEmpty(strProblemId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strProblemId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_TobeStudiedProblemDA.IsExist(strProblemId);
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
 bolIsExist = clsgs_TobeStudiedProblemDA.IsExistTable();
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
 bolIsExist = gs_TobeStudiedProblemDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TobeStudiedProblemEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问题Id = [{0}]的数据已经存在!(in clsgs_TobeStudiedProblemBL.AddNewRecordBySql2)", objgs_TobeStudiedProblemEN.ProblemId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TobeStudiedProblemEN.ProblemId) == true || clsgs_TobeStudiedProblemBL.IsExist(objgs_TobeStudiedProblemEN.ProblemId) == true)
 {
     objgs_TobeStudiedProblemEN.ProblemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
 }
bool bolResult = gs_TobeStudiedProblemDA.AddNewRecordBySQL2(objgs_TobeStudiedProblemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_TobeStudiedProblemEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问题Id = [{0}]的数据已经存在!(in clsgs_TobeStudiedProblemBL.AddNewRecordBySql2WithReturnKey)", objgs_TobeStudiedProblemEN.ProblemId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_TobeStudiedProblemEN.ProblemId) == true || clsgs_TobeStudiedProblemBL.IsExist(objgs_TobeStudiedProblemEN.ProblemId) == true)
 {
     objgs_TobeStudiedProblemEN.ProblemId = clsgs_TobeStudiedProblemBL.GetMaxStrId_S();
 }
string strKey = gs_TobeStudiedProblemDA.AddNewRecordBySQL2WithReturnKey(objgs_TobeStudiedProblemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
try
{
bool bolResult = gs_TobeStudiedProblemDA.Update(objgs_TobeStudiedProblemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "objgs_TobeStudiedProblemEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 if (string.IsNullOrEmpty(objgs_TobeStudiedProblemEN.ProblemId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_TobeStudiedProblemDA.UpdateBySql2(objgs_TobeStudiedProblemEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_TobeStudiedProblemBL.ReFreshCache();

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
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
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strProblemId)
{
try
{
 clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN = clsgs_TobeStudiedProblemBL.GetObjByProblemId(strProblemId);

if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(objgs_TobeStudiedProblemEN.ProblemId, "SetUpdDate");
}
if (objgs_TobeStudiedProblemEN != null)
{
int intRecNum = gs_TobeStudiedProblemDA.DelRecord(strProblemId);
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
/// <param name="strProblemId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strProblemId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
//删除与表:[gs_TobeStudiedProblem]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_TobeStudiedProblem.ProblemId,
//strProblemId);
//        clsgs_TobeStudiedProblemBL.Delgs_TobeStudiedProblemsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TobeStudiedProblemBL.DelRecord(strProblemId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TobeStudiedProblemBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strProblemId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strProblemId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(strProblemId, "UpdRelaTabDate");
}
bool bolResult = gs_TobeStudiedProblemDA.DelRecord(strProblemId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrProblemIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_TobeStudiedProblems(List<string> arrProblemIdLst)
{
if (arrProblemIdLst.Count == 0) return 0;
try
{
if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
foreach (var strProblemId in arrProblemIdLst)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(strProblemId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_TobeStudiedProblemDA.Delgs_TobeStudiedProblem(arrProblemIdLst);
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
public static int Delgs_TobeStudiedProblemsByCond(string strWhereCond)
{
try
{
if (clsgs_TobeStudiedProblemBL.relatedActions != null)
{
List<string> arrProblemId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strProblemId in arrProblemId)
{
clsgs_TobeStudiedProblemBL.relatedActions.UpdRelaTabDate(strProblemId, "UpdRelaTabDate");
}
}
int intRecNum = gs_TobeStudiedProblemDA.Delgs_TobeStudiedProblem(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_TobeStudiedProblem]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strProblemId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strProblemId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_TobeStudiedProblemDA.GetSpecSQLObj();
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
//删除与表:[gs_TobeStudiedProblem]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_TobeStudiedProblemBL.DelRecord(strProblemId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_TobeStudiedProblemBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strProblemId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objgs_TobeStudiedProblemENT">目标对象</param>
 public static void CopyTo(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENS, clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemENT)
{
try
{
objgs_TobeStudiedProblemENT.ProblemId = objgs_TobeStudiedProblemENS.ProblemId; //问题Id
objgs_TobeStudiedProblemENT.ProblemTitle = objgs_TobeStudiedProblemENS.ProblemTitle; //问题标题
objgs_TobeStudiedProblemENT.ProblemContent = objgs_TobeStudiedProblemENS.ProblemContent; //问题内容
objgs_TobeStudiedProblemENT.TopicId = objgs_TobeStudiedProblemENS.TopicId; //主题Id
objgs_TobeStudiedProblemENT.IsSubmit = objgs_TobeStudiedProblemENS.IsSubmit; //是否提交
objgs_TobeStudiedProblemENT.ProblemDate = objgs_TobeStudiedProblemENS.ProblemDate; //问题日期
objgs_TobeStudiedProblemENT.UpdDate = objgs_TobeStudiedProblemENS.UpdDate; //修改日期
objgs_TobeStudiedProblemENT.UpdUser = objgs_TobeStudiedProblemENS.UpdUser; //修改人
objgs_TobeStudiedProblemENT.Year = objgs_TobeStudiedProblemENS.Year; //年
objgs_TobeStudiedProblemENT.Month = objgs_TobeStudiedProblemENS.Month; //月
objgs_TobeStudiedProblemENT.VersionCount = objgs_TobeStudiedProblemENS.VersionCount; //版本统计
objgs_TobeStudiedProblemENT.Participant = objgs_TobeStudiedProblemENS.Participant; //参与者
objgs_TobeStudiedProblemENT.Memo = objgs_TobeStudiedProblemENS.Memo; //备注
objgs_TobeStudiedProblemENT.IdCurrEduCls = objgs_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objgs_TobeStudiedProblemEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
try
{
objgs_TobeStudiedProblemEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_TobeStudiedProblemEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_TobeStudiedProblem.ProblemId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.ProblemId = objgs_TobeStudiedProblemEN.ProblemId; //问题Id
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.ProblemTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.ProblemTitle = objgs_TobeStudiedProblemEN.ProblemTitle == "[null]" ? null :  objgs_TobeStudiedProblemEN.ProblemTitle; //问题标题
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.ProblemContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.ProblemContent = objgs_TobeStudiedProblemEN.ProblemContent == "[null]" ? null :  objgs_TobeStudiedProblemEN.ProblemContent; //问题内容
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.TopicId = objgs_TobeStudiedProblemEN.TopicId == "[null]" ? null :  objgs_TobeStudiedProblemEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.IsSubmit = objgs_TobeStudiedProblemEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.ProblemDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.ProblemDate = objgs_TobeStudiedProblemEN.ProblemDate == "[null]" ? null :  objgs_TobeStudiedProblemEN.ProblemDate; //问题日期
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.UpdDate = objgs_TobeStudiedProblemEN.UpdDate == "[null]" ? null :  objgs_TobeStudiedProblemEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.UpdUser = objgs_TobeStudiedProblemEN.UpdUser == "[null]" ? null :  objgs_TobeStudiedProblemEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.Year = objgs_TobeStudiedProblemEN.Year == "[null]" ? null :  objgs_TobeStudiedProblemEN.Year; //年
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.Month = objgs_TobeStudiedProblemEN.Month == "[null]" ? null :  objgs_TobeStudiedProblemEN.Month; //月
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.VersionCount = objgs_TobeStudiedProblemEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.Participant, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.Participant = objgs_TobeStudiedProblemEN.Participant == "[null]" ? null :  objgs_TobeStudiedProblemEN.Participant; //参与者
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.Memo = objgs_TobeStudiedProblemEN.Memo == "[null]" ? null :  objgs_TobeStudiedProblemEN.Memo; //备注
}
if (arrFldSet.Contains(congs_TobeStudiedProblem.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_TobeStudiedProblemEN.IdCurrEduCls = objgs_TobeStudiedProblemEN.IdCurrEduCls == "[null]" ? null :  objgs_TobeStudiedProblemEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objgs_TobeStudiedProblemEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
try
{
if (objgs_TobeStudiedProblemEN.ProblemTitle == "[null]") objgs_TobeStudiedProblemEN.ProblemTitle = null; //问题标题
if (objgs_TobeStudiedProblemEN.ProblemContent == "[null]") objgs_TobeStudiedProblemEN.ProblemContent = null; //问题内容
if (objgs_TobeStudiedProblemEN.TopicId == "[null]") objgs_TobeStudiedProblemEN.TopicId = null; //主题Id
if (objgs_TobeStudiedProblemEN.ProblemDate == "[null]") objgs_TobeStudiedProblemEN.ProblemDate = null; //问题日期
if (objgs_TobeStudiedProblemEN.UpdDate == "[null]") objgs_TobeStudiedProblemEN.UpdDate = null; //修改日期
if (objgs_TobeStudiedProblemEN.UpdUser == "[null]") objgs_TobeStudiedProblemEN.UpdUser = null; //修改人
if (objgs_TobeStudiedProblemEN.Year == "[null]") objgs_TobeStudiedProblemEN.Year = null; //年
if (objgs_TobeStudiedProblemEN.Month == "[null]") objgs_TobeStudiedProblemEN.Month = null; //月
if (objgs_TobeStudiedProblemEN.Participant == "[null]") objgs_TobeStudiedProblemEN.Participant = null; //参与者
if (objgs_TobeStudiedProblemEN.Memo == "[null]") objgs_TobeStudiedProblemEN.Memo = null; //备注
if (objgs_TobeStudiedProblemEN.IdCurrEduCls == "[null]") objgs_TobeStudiedProblemEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 gs_TobeStudiedProblemDA.CheckPropertyNew(objgs_TobeStudiedProblemEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
 gs_TobeStudiedProblemDA.CheckProperty4Condition(objgs_TobeStudiedProblemEN);
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
if (clsgs_TobeStudiedProblemBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TobeStudiedProblemBL没有刷新缓存机制(clsgs_TobeStudiedProblemBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ProblemId");
//if (arrgs_TobeStudiedProblemObjLstCache == null)
//{
//arrgs_TobeStudiedProblemObjLstCache = gs_TobeStudiedProblemDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strProblemId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_TobeStudiedProblemEN GetObjByProblemIdCache(string strProblemId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_TobeStudiedProblemEN._CurrTabName);
List<clsgs_TobeStudiedProblemEN> arrgs_TobeStudiedProblemObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TobeStudiedProblemEN> arrgs_TobeStudiedProblemObjLst_Sel =
arrgs_TobeStudiedProblemObjLstCache
.Where(x=> x.ProblemId == strProblemId 
);
if (arrgs_TobeStudiedProblemObjLst_Sel.Count() == 0)
{
   clsgs_TobeStudiedProblemEN obj = clsgs_TobeStudiedProblemBL.GetObjByProblemId(strProblemId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_TobeStudiedProblemObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TobeStudiedProblemEN> GetAllgs_TobeStudiedProblemObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_TobeStudiedProblemEN> arrgs_TobeStudiedProblemObjLstCache = GetObjLstCache(); 
return arrgs_TobeStudiedProblemObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_TobeStudiedProblemEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_TobeStudiedProblemEN._CurrTabName);
List<clsgs_TobeStudiedProblemEN> arrgs_TobeStudiedProblemObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_TobeStudiedProblemObjLstCache;
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
string strKey = string.Format("{0}", clsgs_TobeStudiedProblemEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_TobeStudiedProblemEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_TobeStudiedProblemEN._RefreshTimeLst.Count == 0) return "";
return clsgs_TobeStudiedProblemEN._RefreshTimeLst[clsgs_TobeStudiedProblemEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_TobeStudiedProblemBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_TobeStudiedProblemEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_TobeStudiedProblemEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_TobeStudiedProblemBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_TobeStudiedProblem(待研究问题)
 /// 唯一性条件:ProblemId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemEN)
{
//检测记录是否存在
string strResult = gs_TobeStudiedProblemDA.GetUniCondStr(objgs_TobeStudiedProblemEN);
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
public static string Func(string strInFldName, string strOutFldName, string strProblemId)
{
if (strInFldName != congs_TobeStudiedProblem.ProblemId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_TobeStudiedProblem.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_TobeStudiedProblem.AttributeName));
throw new Exception(strMsg);
}
var objgs_TobeStudiedProblem = clsgs_TobeStudiedProblemBL.GetObjByProblemIdCache(strProblemId);
if (objgs_TobeStudiedProblem == null) return "";
return objgs_TobeStudiedProblem[strOutFldName].ToString();
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
int intRecCount = clsgs_TobeStudiedProblemDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_TobeStudiedProblemDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_TobeStudiedProblemDA.GetRecCount();
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
int intRecCount = clsgs_TobeStudiedProblemDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_TobeStudiedProblemCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_TobeStudiedProblemEN objgs_TobeStudiedProblemCond)
{
List<clsgs_TobeStudiedProblemEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_TobeStudiedProblemEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_TobeStudiedProblem.AttributeName)
{
if (objgs_TobeStudiedProblemCond.IsUpdated(strFldName) == false) continue;
if (objgs_TobeStudiedProblemCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TobeStudiedProblemCond[strFldName].ToString());
}
else
{
if (objgs_TobeStudiedProblemCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_TobeStudiedProblemCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_TobeStudiedProblemCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_TobeStudiedProblemCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_TobeStudiedProblemCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_TobeStudiedProblemCond[strFldName]));
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
 List<string> arrList = clsgs_TobeStudiedProblemDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_TobeStudiedProblemDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_TobeStudiedProblemDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_TobeStudiedProblemDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TobeStudiedProblemDA.SetFldValue(clsgs_TobeStudiedProblemEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_TobeStudiedProblemDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TobeStudiedProblemDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_TobeStudiedProblemDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_TobeStudiedProblemDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_TobeStudiedProblem] "); 
 strCreateTabCode.Append(" ( "); 
 // /**问题Id*/ 
 strCreateTabCode.Append(" ProblemId char(10) primary key, "); 
 // /**问题标题*/ 
 strCreateTabCode.Append(" ProblemTitle varchar(1000) Null, "); 
 // /**问题内容*/ 
 strCreateTabCode.Append(" ProblemContent text Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**问题日期*/ 
 strCreateTabCode.Append(" ProblemDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**年*/ 
 strCreateTabCode.Append(" Year char(4) Null, "); 
 // /**月*/ 
 strCreateTabCode.Append(" Month char(2) Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**参与者*/ 
 strCreateTabCode.Append(" Participant varchar(500) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 待研究问题(gs_TobeStudiedProblem)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_TobeStudiedProblem : clsCommFun4BL
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
clsgs_TobeStudiedProblemBL.ReFreshThisCache();
}
}

}