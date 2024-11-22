
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicObjectiveBL
 表名:zx_TopicObjective(01120708)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clszx_TopicObjectiveBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TopicObjectiveEN GetObj(this K_zxTopicObjectiveId_zx_TopicObjective myKey)
{
clszx_TopicObjectiveEN objzx_TopicObjectiveEN = clszx_TopicObjectiveBL.zx_TopicObjectiveDA.GetObjByzxTopicObjectiveId(myKey.Value);
return objzx_TopicObjectiveEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
if (CheckUniqueness(objzx_TopicObjectiveEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_TopicObjectiveBL.AddNewRecord)", objzx_TopicObjectiveEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true || clszx_TopicObjectiveBL.IsExist(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true)
 {
     objzx_TopicObjectiveEN.zxTopicObjectiveId = clszx_TopicObjectiveBL.GetMaxStrId_S();
 }
bool bolResult = clszx_TopicObjectiveBL.zx_TopicObjectiveDA.AddNewRecordBySQL2(objzx_TopicObjectiveEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_TopicObjectiveBL.IsExist(objzx_TopicObjectiveEN.zxTopicObjectiveId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_TopicObjectiveEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_TopicObjectiveEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课件Id(TextId)=[{0}])已经存在,不能重复!", objzx_TopicObjectiveEN.TextId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true || clszx_TopicObjectiveBL.IsExist(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true)
 {
     objzx_TopicObjectiveEN.zxTopicObjectiveId = clszx_TopicObjectiveBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_TopicObjectiveEN.AddNewRecord();
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
if (CheckUniqueness(objzx_TopicObjectiveEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_TopicObjectiveBL.AddNewRecordWithMaxId)", objzx_TopicObjectiveEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true || clszx_TopicObjectiveBL.IsExist(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true)
 {
     objzx_TopicObjectiveEN.zxTopicObjectiveId = clszx_TopicObjectiveBL.GetMaxStrId_S();
 }
string strzxTopicObjectiveId = clszx_TopicObjectiveBL.zx_TopicObjectiveDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicObjectiveEN);
     objzx_TopicObjectiveEN.zxTopicObjectiveId = strzxTopicObjectiveId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
}
return strzxTopicObjectiveId;
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
if (CheckUniqueness(objzx_TopicObjectiveEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_TopicObjectiveBL.AddNewRecordWithReturnKey)", objzx_TopicObjectiveEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true || clszx_TopicObjectiveBL.IsExist(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true)
 {
     objzx_TopicObjectiveEN.zxTopicObjectiveId = clszx_TopicObjectiveBL.GetMaxStrId_S();
 }
string strKey = clszx_TopicObjectiveBL.zx_TopicObjectiveDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicObjectiveEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetzxTopicObjectiveId(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strzxTopicObjectiveId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTopicObjectiveId, 8, conzx_TopicObjective.zxTopicObjectiveId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTopicObjectiveId, 8, conzx_TopicObjective.zxTopicObjectiveId);
}
objzx_TopicObjectiveEN.zxTopicObjectiveId = strzxTopicObjectiveId; //客观Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.zxTopicObjectiveId) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.zxTopicObjectiveId, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.zxTopicObjectiveId] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetObjectiveName(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strObjectiveName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveName, 500, conzx_TopicObjective.ObjectiveName);
}
objzx_TopicObjectiveEN.ObjectiveName = strObjectiveName; //客观名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.ObjectiveName) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.ObjectiveName, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.ObjectiveName] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetObjectiveContent(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strObjectiveContent, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.ObjectiveContent = strObjectiveContent; //客观内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.ObjectiveContent) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.ObjectiveContent, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.ObjectiveContent] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetObjectiveType(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strObjectiveType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveType, 2, conzx_TopicObjective.ObjectiveType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strObjectiveType, 2, conzx_TopicObjective.ObjectiveType);
}
objzx_TopicObjectiveEN.ObjectiveType = strObjectiveType; //客观类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.ObjectiveType) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.ObjectiveType, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.ObjectiveType] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetConclusion(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strConclusion, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.Conclusion) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.Conclusion, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.Conclusion] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetTextId(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_TopicObjective.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_TopicObjective.TextId);
}
objzx_TopicObjectiveEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.TextId) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.TextId, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.TextId] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetIsSubmit(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.IsSubmit) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.IsSubmit, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.IsSubmit] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetVoteCount(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.VoteCount) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.VoteCount, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.VoteCount] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetAppraiseCount(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.AppraiseCount) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.AppraiseCount, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.AppraiseCount] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetScore(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, float? fltScore, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.Score) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.Score, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.Score] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetStuScore(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.StuScore) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.StuScore, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.StuScore] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetTeaScore(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.TeaScore) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.TeaScore, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.TeaScore] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetIdCurrEduCls(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_TopicObjective.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_TopicObjective.IdCurrEduCls);
}
objzx_TopicObjectiveEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.IdCurrEduCls) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetPdfContent(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_TopicObjective.PdfContent);
}
objzx_TopicObjectiveEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.PdfContent) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.PdfContent, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.PdfContent] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetPdfPageNum(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.PdfPageNum) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.PdfPageNum, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.PdfPageNum] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetCitationCount(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.CitationCount) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.CitationCount, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.CitationCount] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetVersionCount(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.VersionCount) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.VersionCount, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.VersionCount] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetzxShareId(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_TopicObjective.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_TopicObjective.zxShareId);
}
objzx_TopicObjectiveEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.zxShareId) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.zxShareId, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.zxShareId] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetCreateDate(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_TopicObjective.CreateDate);
}
objzx_TopicObjectiveEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.CreateDate) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.CreateDate, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.CreateDate] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetUpdDate(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_TopicObjective.UpdDate);
}
objzx_TopicObjectiveEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.UpdDate) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.UpdDate, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.UpdDate] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetUpdUser(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_TopicObjective.UpdUser);
}
objzx_TopicObjectiveEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.UpdUser) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.UpdUser, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.UpdUser] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetMemo(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_TopicObjective.Memo);
}
objzx_TopicObjectiveEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.Memo) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.Memo, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.Memo] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetPdfDivLet(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_TopicObjective.PdfDivLet);
}
objzx_TopicObjectiveEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.PdfDivLet) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.PdfDivLet, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.PdfDivLet] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetPdfDivTop(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_TopicObjective.PdfDivTop);
}
objzx_TopicObjectiveEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.PdfDivTop) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.PdfDivTop, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.PdfDivTop] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetPdfPageNumIn(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_TopicObjective.PdfPageNumIn);
}
objzx_TopicObjectiveEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.PdfPageNumIn) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetPdfPageTop(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_TopicObjectiveEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.PdfPageTop) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.PdfPageTop, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.PdfPageTop] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetPdfZoom(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_TopicObjective.PdfZoom);
}
objzx_TopicObjectiveEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.PdfZoom) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.PdfZoom, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.PdfZoom] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TopicObjectiveEN SetGroupTextId(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_TopicObjective.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_TopicObjective.GroupTextId);
}
objzx_TopicObjectiveEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(conzx_TopicObjective.GroupTextId) == false)
{
objzx_TopicObjectiveEN.dicFldComparisonOp.Add(conzx_TopicObjective.GroupTextId, strComparisonOp);
}
else
{
objzx_TopicObjectiveEN.dicFldComparisonOp[conzx_TopicObjective.GroupTextId] = strComparisonOp;
}
}
return objzx_TopicObjectiveEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TopicObjectiveEN.CheckPropertyNew();
clszx_TopicObjectiveEN objzx_TopicObjectiveCond = new clszx_TopicObjectiveEN();
string strCondition = objzx_TopicObjectiveCond
.SetzxTopicObjectiveId(objzx_TopicObjectiveEN.zxTopicObjectiveId, "<>")
.SetTextId(objzx_TopicObjectiveEN.TextId, "=")
.GetCombineCondition();
objzx_TopicObjectiveEN._IsCheckProperty = true;
bool bolIsExist = clszx_TopicObjectiveBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TopicObjectiveEN.Update();
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
 /// <param name = "objzx_TopicObjective">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_TopicObjectiveEN objzx_TopicObjective)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_TopicObjectiveEN objzx_TopicObjectiveCond = new clszx_TopicObjectiveEN();
string strCondition = objzx_TopicObjectiveCond
.SetTextId(objzx_TopicObjective.TextId, "=")
.GetCombineCondition();
objzx_TopicObjective._IsCheckProperty = true;
bool bolIsExist = clszx_TopicObjectiveBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_TopicObjective.zxTopicObjectiveId = clszx_TopicObjectiveBL.GetFirstID_S(strCondition);
objzx_TopicObjective.UpdateWithCondition(strCondition);
}
else
{
objzx_TopicObjective.zxTopicObjectiveId = clszx_TopicObjectiveBL.GetMaxStrId_S();
objzx_TopicObjective.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 if (string.IsNullOrEmpty(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TopicObjectiveBL.zx_TopicObjectiveDA.UpdateBySql2(objzx_TopicObjectiveEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TopicObjectiveBL.zx_TopicObjectiveDA.UpdateBySql2(objzx_TopicObjectiveEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TopicObjectiveBL.zx_TopicObjectiveDA.UpdateBySqlWithCondition(objzx_TopicObjectiveEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TopicObjectiveBL.zx_TopicObjectiveDA.UpdateBySqlWithConditionTransaction(objzx_TopicObjectiveEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "strzxTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
try
{
int intRecNum = clszx_TopicObjectiveBL.zx_TopicObjectiveDA.DelRecord(objzx_TopicObjectiveEN.zxTopicObjectiveId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveENS">源对象</param>
 /// <param name = "objzx_TopicObjectiveENT">目标对象</param>
 public static void CopyTo(this clszx_TopicObjectiveEN objzx_TopicObjectiveENS, clszx_TopicObjectiveEN objzx_TopicObjectiveENT)
{
try
{
objzx_TopicObjectiveENT.zxTopicObjectiveId = objzx_TopicObjectiveENS.zxTopicObjectiveId; //客观Id
objzx_TopicObjectiveENT.ObjectiveName = objzx_TopicObjectiveENS.ObjectiveName; //客观名称
objzx_TopicObjectiveENT.ObjectiveContent = objzx_TopicObjectiveENS.ObjectiveContent; //客观内容
objzx_TopicObjectiveENT.ObjectiveType = objzx_TopicObjectiveENS.ObjectiveType; //客观类型
objzx_TopicObjectiveENT.Conclusion = objzx_TopicObjectiveENS.Conclusion; //结论
objzx_TopicObjectiveENT.TextId = objzx_TopicObjectiveENS.TextId; //课件Id
objzx_TopicObjectiveENT.IsSubmit = objzx_TopicObjectiveENS.IsSubmit; //是否提交
objzx_TopicObjectiveENT.VoteCount = objzx_TopicObjectiveENS.VoteCount; //点赞计数
objzx_TopicObjectiveENT.AppraiseCount = objzx_TopicObjectiveENS.AppraiseCount; //评论数
objzx_TopicObjectiveENT.Score = objzx_TopicObjectiveENS.Score; //评分
objzx_TopicObjectiveENT.StuScore = objzx_TopicObjectiveENS.StuScore; //学生平均分
objzx_TopicObjectiveENT.TeaScore = objzx_TopicObjectiveENS.TeaScore; //教师评分
objzx_TopicObjectiveENT.IdCurrEduCls = objzx_TopicObjectiveENS.IdCurrEduCls; //教学班流水号
objzx_TopicObjectiveENT.PdfContent = objzx_TopicObjectiveENS.PdfContent; //Pdf内容
objzx_TopicObjectiveENT.PdfPageNum = objzx_TopicObjectiveENS.PdfPageNum; //Pdf页码
objzx_TopicObjectiveENT.CitationCount = objzx_TopicObjectiveENS.CitationCount; //引用统计
objzx_TopicObjectiveENT.VersionCount = objzx_TopicObjectiveENS.VersionCount; //版本统计
objzx_TopicObjectiveENT.zxShareId = objzx_TopicObjectiveENS.zxShareId; //分享Id
objzx_TopicObjectiveENT.CreateDate = objzx_TopicObjectiveENS.CreateDate; //建立日期
objzx_TopicObjectiveENT.UpdDate = objzx_TopicObjectiveENS.UpdDate; //修改日期
objzx_TopicObjectiveENT.UpdUser = objzx_TopicObjectiveENS.UpdUser; //修改人
objzx_TopicObjectiveENT.Memo = objzx_TopicObjectiveENS.Memo; //备注
objzx_TopicObjectiveENT.PdfDivLet = objzx_TopicObjectiveENS.PdfDivLet; //PdfDivLet
objzx_TopicObjectiveENT.PdfDivTop = objzx_TopicObjectiveENS.PdfDivTop; //PdfDivTop
objzx_TopicObjectiveENT.PdfPageNumIn = objzx_TopicObjectiveENS.PdfPageNumIn; //PdfPageNumIn
objzx_TopicObjectiveENT.PdfPageTop = objzx_TopicObjectiveENS.PdfPageTop; //pdf页面顶部位置
objzx_TopicObjectiveENT.PdfZoom = objzx_TopicObjectiveENS.PdfZoom; //PdfZoom
objzx_TopicObjectiveENT.GroupTextId = objzx_TopicObjectiveENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_TopicObjectiveENS">源对象</param>
 /// <returns>目标对象=>clszx_TopicObjectiveEN:objzx_TopicObjectiveENT</returns>
 public static clszx_TopicObjectiveEN CopyTo(this clszx_TopicObjectiveEN objzx_TopicObjectiveENS)
{
try
{
 clszx_TopicObjectiveEN objzx_TopicObjectiveENT = new clszx_TopicObjectiveEN()
{
zxTopicObjectiveId = objzx_TopicObjectiveENS.zxTopicObjectiveId, //客观Id
ObjectiveName = objzx_TopicObjectiveENS.ObjectiveName, //客观名称
ObjectiveContent = objzx_TopicObjectiveENS.ObjectiveContent, //客观内容
ObjectiveType = objzx_TopicObjectiveENS.ObjectiveType, //客观类型
Conclusion = objzx_TopicObjectiveENS.Conclusion, //结论
TextId = objzx_TopicObjectiveENS.TextId, //课件Id
IsSubmit = objzx_TopicObjectiveENS.IsSubmit, //是否提交
VoteCount = objzx_TopicObjectiveENS.VoteCount, //点赞计数
AppraiseCount = objzx_TopicObjectiveENS.AppraiseCount, //评论数
Score = objzx_TopicObjectiveENS.Score, //评分
StuScore = objzx_TopicObjectiveENS.StuScore, //学生平均分
TeaScore = objzx_TopicObjectiveENS.TeaScore, //教师评分
IdCurrEduCls = objzx_TopicObjectiveENS.IdCurrEduCls, //教学班流水号
PdfContent = objzx_TopicObjectiveENS.PdfContent, //Pdf内容
PdfPageNum = objzx_TopicObjectiveENS.PdfPageNum, //Pdf页码
CitationCount = objzx_TopicObjectiveENS.CitationCount, //引用统计
VersionCount = objzx_TopicObjectiveENS.VersionCount, //版本统计
zxShareId = objzx_TopicObjectiveENS.zxShareId, //分享Id
CreateDate = objzx_TopicObjectiveENS.CreateDate, //建立日期
UpdDate = objzx_TopicObjectiveENS.UpdDate, //修改日期
UpdUser = objzx_TopicObjectiveENS.UpdUser, //修改人
Memo = objzx_TopicObjectiveENS.Memo, //备注
PdfDivLet = objzx_TopicObjectiveENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_TopicObjectiveENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_TopicObjectiveENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_TopicObjectiveENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_TopicObjectiveENS.PdfZoom, //PdfZoom
GroupTextId = objzx_TopicObjectiveENS.GroupTextId, //小组Id
};
 return objzx_TopicObjectiveENT;
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
public static void CheckPropertyNew(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 clszx_TopicObjectiveBL.zx_TopicObjectiveDA.CheckPropertyNew(objzx_TopicObjectiveEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 clszx_TopicObjectiveBL.zx_TopicObjectiveDA.CheckProperty4Condition(objzx_TopicObjectiveEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TopicObjectiveEN objzx_TopicObjectiveCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.zxTopicObjectiveId) == true)
{
string strComparisonOpzxTopicObjectiveId = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.zxTopicObjectiveId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.zxTopicObjectiveId, objzx_TopicObjectiveCond.zxTopicObjectiveId, strComparisonOpzxTopicObjectiveId);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.ObjectiveName) == true)
{
string strComparisonOpObjectiveName = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.ObjectiveName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.ObjectiveName, objzx_TopicObjectiveCond.ObjectiveName, strComparisonOpObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.ObjectiveType) == true)
{
string strComparisonOpObjectiveType = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.ObjectiveType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.ObjectiveType, objzx_TopicObjectiveCond.ObjectiveType, strComparisonOpObjectiveType);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.TextId) == true)
{
string strComparisonOpTextId = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.TextId, objzx_TopicObjectiveCond.TextId, strComparisonOpTextId);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.IsSubmit) == true)
{
if (objzx_TopicObjectiveCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_TopicObjective.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_TopicObjective.IsSubmit);
}
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjective.VoteCount, objzx_TopicObjectiveCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjective.AppraiseCount, objzx_TopicObjectiveCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.Score) == true)
{
string strComparisonOpScore = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjective.Score, objzx_TopicObjectiveCond.Score, strComparisonOpScore);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.StuScore) == true)
{
string strComparisonOpStuScore = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjective.StuScore, objzx_TopicObjectiveCond.StuScore, strComparisonOpStuScore);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjective.TeaScore, objzx_TopicObjectiveCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.IdCurrEduCls, objzx_TopicObjectiveCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.PdfContent, objzx_TopicObjectiveCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjective.PdfPageNum, objzx_TopicObjectiveCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjective.CitationCount, objzx_TopicObjectiveCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjective.VersionCount, objzx_TopicObjectiveCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.zxShareId, objzx_TopicObjectiveCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.CreateDate, objzx_TopicObjectiveCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.UpdDate, objzx_TopicObjectiveCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.UpdUser, objzx_TopicObjectiveCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.Memo) == true)
{
string strComparisonOpMemo = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.Memo, objzx_TopicObjectiveCond.Memo, strComparisonOpMemo);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.PdfDivLet, objzx_TopicObjectiveCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.PdfDivTop, objzx_TopicObjectiveCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.PdfPageNumIn, objzx_TopicObjectiveCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TopicObjective.PdfPageTop, objzx_TopicObjectiveCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.PdfZoom, objzx_TopicObjectiveCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_TopicObjectiveCond.IsUpdated(conzx_TopicObjective.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_TopicObjectiveCond.dicFldComparisonOp[conzx_TopicObjective.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TopicObjective.GroupTextId, objzx_TopicObjectiveCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_TopicObjective(中学客观事实数据), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_TopicObjectiveEN == null) return true;
if (objzx_TopicObjectiveEN.zxTopicObjectiveId == null || objzx_TopicObjectiveEN.zxTopicObjectiveId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_TopicObjectiveEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_TopicObjectiveEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TopicObjectiveEN.TextId);
}
if (clszx_TopicObjectiveBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxTopicObjectiveId !=  '{0}'", objzx_TopicObjectiveEN.zxTopicObjectiveId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TopicObjectiveEN.TextId);
if (clszx_TopicObjectiveBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_TopicObjective(中学客观事实数据), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_TopicObjectiveEN == null) return "";
if (objzx_TopicObjectiveEN.zxTopicObjectiveId == null || objzx_TopicObjectiveEN.zxTopicObjectiveId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_TopicObjectiveEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_TopicObjectiveEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TopicObjectiveEN.TextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxTopicObjectiveId !=  '{0}'", objzx_TopicObjectiveEN.zxTopicObjectiveId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TopicObjectiveEN.TextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_TopicObjective
{
public virtual bool UpdRelaTabDate(string strzxTopicObjectiveId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学客观事实数据(zx_TopicObjective)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TopicObjectiveBL
{
public static RelatedActions_zx_TopicObjective relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TopicObjectiveDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TopicObjectiveDA zx_TopicObjectiveDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TopicObjectiveDA();
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
 public clszx_TopicObjectiveBL()
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
if (string.IsNullOrEmpty(clszx_TopicObjectiveEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TopicObjectiveEN._ConnectString);
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
public static DataTable GetDataTable_zx_TopicObjective(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TopicObjectiveDA.GetDataTable_zx_TopicObjective(strWhereCond);
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
objDT = zx_TopicObjectiveDA.GetDataTable(strWhereCond);
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
objDT = zx_TopicObjectiveDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TopicObjectiveDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TopicObjectiveDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TopicObjectiveDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TopicObjectiveDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TopicObjectiveDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TopicObjectiveDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxTopicObjectiveIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TopicObjectiveEN> GetObjLstByZxTopicObjectiveIdLst(List<string> arrZxTopicObjectiveIdLst)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxTopicObjectiveIdLst, true);
 string strWhereCond = string.Format("zxTopicObjectiveId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxTopicObjectiveIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TopicObjectiveEN> GetObjLstByZxTopicObjectiveIdLstCache(List<string> arrZxTopicObjectiveIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_TopicObjectiveEN._CurrTabName, strIdCurrEduCls);
List<clszx_TopicObjectiveEN> arrzx_TopicObjectiveObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TopicObjectiveEN> arrzx_TopicObjectiveObjLst_Sel =
arrzx_TopicObjectiveObjLstCache
.Where(x => arrZxTopicObjectiveIdLst.Contains(x.zxTopicObjectiveId));
return arrzx_TopicObjectiveObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicObjectiveEN> GetObjLst(string strWhereCond)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
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
public static List<clszx_TopicObjectiveEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TopicObjectiveEN> GetSubObjLstCache(clszx_TopicObjectiveEN objzx_TopicObjectiveCond)
{
 string strIdCurrEduCls = objzx_TopicObjectiveCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_TopicObjectiveBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_TopicObjectiveEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TopicObjectiveEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TopicObjective.AttributeName)
{
if (objzx_TopicObjectiveCond.IsUpdated(strFldName) == false) continue;
if (objzx_TopicObjectiveCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicObjectiveCond[strFldName].ToString());
}
else
{
if (objzx_TopicObjectiveCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TopicObjectiveCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicObjectiveCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TopicObjectiveCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TopicObjectiveCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TopicObjectiveCond[strFldName]));
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
public static List<clszx_TopicObjectiveEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
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
public static List<clszx_TopicObjectiveEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
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
List<clszx_TopicObjectiveEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TopicObjectiveEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicObjectiveEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TopicObjectiveEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
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
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
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
public static List<clszx_TopicObjectiveEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TopicObjectiveEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TopicObjectiveEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
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
public static List<clszx_TopicObjectiveEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TopicObjectiveEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TopicObjectiveEN> arrObjLst = new List<clszx_TopicObjectiveEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TopicObjectiveEN objzx_TopicObjectiveEN = new clszx_TopicObjectiveEN();
try
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[conzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objzx_TopicObjectiveEN.ObjectiveName = objRow[conzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objzx_TopicObjectiveEN.ObjectiveContent = objRow[conzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objzx_TopicObjectiveEN.ObjectiveType = objRow[conzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[conzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objzx_TopicObjectiveEN.Conclusion = objRow[conzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[conzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objzx_TopicObjectiveEN.TextId = objRow[conzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objzx_TopicObjectiveEN.VoteCount = objRow[conzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objzx_TopicObjectiveEN.AppraiseCount = objRow[conzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objzx_TopicObjectiveEN.Score = objRow[conzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.Score].ToString().Trim()); //评分
objzx_TopicObjectiveEN.StuScore = objRow[conzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objzx_TopicObjectiveEN.TeaScore = objRow[conzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objzx_TopicObjectiveEN.IdCurrEduCls = objRow[conzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TopicObjectiveEN.PdfContent = objRow[conzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objzx_TopicObjectiveEN.PdfPageNum = objRow[conzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_TopicObjectiveEN.CitationCount = objRow[conzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objzx_TopicObjectiveEN.VersionCount = objRow[conzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objzx_TopicObjectiveEN.zxShareId = objRow[conzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[conzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objzx_TopicObjectiveEN.CreateDate = objRow[conzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objzx_TopicObjectiveEN.UpdDate = objRow[conzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objzx_TopicObjectiveEN.UpdUser = objRow[conzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[conzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objzx_TopicObjectiveEN.Memo = objRow[conzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[conzx_TopicObjective.Memo].ToString().Trim(); //备注
objzx_TopicObjectiveEN.PdfDivLet = objRow[conzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_TopicObjectiveEN.PdfDivTop = objRow[conzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_TopicObjectiveEN.PdfPageNumIn = objRow[conzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_TopicObjectiveEN.PdfPageTop = objRow[conzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_TopicObjectiveEN.PdfZoom = objRow[conzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[conzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objzx_TopicObjectiveEN.GroupTextId = objRow[conzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[conzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TopicObjectiveEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_TopicObjective(ref clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
bool bolResult = zx_TopicObjectiveDA.Getzx_TopicObjective(ref objzx_TopicObjectiveEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TopicObjectiveEN GetObjByzxTopicObjectiveId(string strzxTopicObjectiveId)
{
if (strzxTopicObjectiveId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxTopicObjectiveId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxTopicObjectiveId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxTopicObjectiveId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_TopicObjectiveEN objzx_TopicObjectiveEN = zx_TopicObjectiveDA.GetObjByzxTopicObjectiveId(strzxTopicObjectiveId);
return objzx_TopicObjectiveEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TopicObjectiveEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TopicObjectiveEN objzx_TopicObjectiveEN = zx_TopicObjectiveDA.GetFirstObj(strWhereCond);
 return objzx_TopicObjectiveEN;
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
public static clszx_TopicObjectiveEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TopicObjectiveEN objzx_TopicObjectiveEN = zx_TopicObjectiveDA.GetObjByDataRow(objRow);
 return objzx_TopicObjectiveEN;
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
public static clszx_TopicObjectiveEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TopicObjectiveEN objzx_TopicObjectiveEN = zx_TopicObjectiveDA.GetObjByDataRow(objRow);
 return objzx_TopicObjectiveEN;
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
 /// <param name = "strzxTopicObjectiveId">所给的关键字</param>
 /// <param name = "lstzx_TopicObjectiveObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TopicObjectiveEN GetObjByzxTopicObjectiveIdFromList(string strzxTopicObjectiveId, List<clszx_TopicObjectiveEN> lstzx_TopicObjectiveObjLst)
{
foreach (clszx_TopicObjectiveEN objzx_TopicObjectiveEN in lstzx_TopicObjectiveObjLst)
{
if (objzx_TopicObjectiveEN.zxTopicObjectiveId == strzxTopicObjectiveId)
{
return objzx_TopicObjectiveEN;
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
 string strMaxZxTopicObjectiveId;
 try
 {
 strMaxZxTopicObjectiveId = clszx_TopicObjectiveDA.GetMaxStrId();
 return strMaxZxTopicObjectiveId;
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
 string strzxTopicObjectiveId;
 try
 {
 strzxTopicObjectiveId = new clszx_TopicObjectiveDA().GetFirstID(strWhereCond);
 return strzxTopicObjectiveId;
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
 arrList = zx_TopicObjectiveDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TopicObjectiveDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxTopicObjectiveId)
{
if (string.IsNullOrEmpty(strzxTopicObjectiveId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxTopicObjectiveId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_TopicObjectiveDA.IsExist(strzxTopicObjectiveId);
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
 bolIsExist = clszx_TopicObjectiveDA.IsExistTable();
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
 bolIsExist = zx_TopicObjectiveDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
if (objzx_TopicObjectiveEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_TopicObjectiveBL.AddNewRecordBySql2)", objzx_TopicObjectiveEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true || clszx_TopicObjectiveBL.IsExist(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true)
 {
     objzx_TopicObjectiveEN.zxTopicObjectiveId = clszx_TopicObjectiveBL.GetMaxStrId_S();
 }
bool bolResult = zx_TopicObjectiveDA.AddNewRecordBySQL2(objzx_TopicObjectiveEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
if (objzx_TopicObjectiveEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_TopicObjectiveBL.AddNewRecordBySql2WithReturnKey)", objzx_TopicObjectiveEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true || clszx_TopicObjectiveBL.IsExist(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true)
 {
     objzx_TopicObjectiveEN.zxTopicObjectiveId = clszx_TopicObjectiveBL.GetMaxStrId_S();
 }
string strKey = zx_TopicObjectiveDA.AddNewRecordBySQL2WithReturnKey(objzx_TopicObjectiveEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
try
{
bool bolResult = zx_TopicObjectiveDA.Update(objzx_TopicObjectiveEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "objzx_TopicObjectiveEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 if (string.IsNullOrEmpty(objzx_TopicObjectiveEN.zxTopicObjectiveId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TopicObjectiveDA.UpdateBySql2(objzx_TopicObjectiveEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TopicObjectiveBL.ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
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
 /// <param name = "strzxTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxTopicObjectiveId)
{
try
{
 clszx_TopicObjectiveEN objzx_TopicObjectiveEN = clszx_TopicObjectiveBL.GetObjByzxTopicObjectiveId(strzxTopicObjectiveId);

if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(objzx_TopicObjectiveEN.zxTopicObjectiveId, "SetUpdDate");
}
if (objzx_TopicObjectiveEN != null)
{
int intRecNum = zx_TopicObjectiveDA.DelRecord(strzxTopicObjectiveId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);
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
/// <param name="strzxTopicObjectiveId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxTopicObjectiveId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
//删除与表:[zx_TopicObjective]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_TopicObjective.zxTopicObjectiveId,
//strzxTopicObjectiveId);
//        clszx_TopicObjectiveBL.Delzx_TopicObjectivesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TopicObjectiveBL.DelRecord(strzxTopicObjectiveId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TopicObjectiveBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxTopicObjectiveId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxTopicObjectiveId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxTopicObjectiveId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TopicObjectiveBL.relatedActions != null)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(strzxTopicObjectiveId, "UpdRelaTabDate");
}
bool bolResult = zx_TopicObjectiveDA.DelRecord(strzxTopicObjectiveId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxTopicObjectiveIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_TopicObjectives(List<string> arrzxTopicObjectiveIdLst)
{
if (arrzxTopicObjectiveIdLst.Count == 0) return 0;
try
{
if (clszx_TopicObjectiveBL.relatedActions != null)
{
foreach (var strzxTopicObjectiveId in arrzxTopicObjectiveIdLst)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(strzxTopicObjectiveId, "UpdRelaTabDate");
}
}
 clszx_TopicObjectiveEN objzx_TopicObjectiveEN = clszx_TopicObjectiveBL.GetObjByzxTopicObjectiveId(arrzxTopicObjectiveIdLst[0]);
int intDelRecNum = zx_TopicObjectiveDA.Delzx_TopicObjective(arrzxTopicObjectiveIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_TopicObjectiveEN.IdCurrEduCls);
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
public static int Delzx_TopicObjectivesByCond(string strWhereCond)
{
try
{
if (clszx_TopicObjectiveBL.relatedActions != null)
{
List<string> arrzxTopicObjectiveId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxTopicObjectiveId in arrzxTopicObjectiveId)
{
clszx_TopicObjectiveBL.relatedActions.UpdRelaTabDate(strzxTopicObjectiveId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_TopicObjective.IdCurrEduCls, strWhereCond);
int intRecNum = zx_TopicObjectiveDA.Delzx_TopicObjective(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_TopicObjective]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxTopicObjectiveId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxTopicObjectiveId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TopicObjectiveDA.GetSpecSQLObj();
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
//删除与表:[zx_TopicObjective]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TopicObjectiveBL.DelRecord(strzxTopicObjectiveId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TopicObjectiveBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxTopicObjectiveId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TopicObjectiveENS">源对象</param>
 /// <param name = "objzx_TopicObjectiveENT">目标对象</param>
 public static void CopyTo(clszx_TopicObjectiveEN objzx_TopicObjectiveENS, clszx_TopicObjectiveEN objzx_TopicObjectiveENT)
{
try
{
objzx_TopicObjectiveENT.zxTopicObjectiveId = objzx_TopicObjectiveENS.zxTopicObjectiveId; //客观Id
objzx_TopicObjectiveENT.ObjectiveName = objzx_TopicObjectiveENS.ObjectiveName; //客观名称
objzx_TopicObjectiveENT.ObjectiveContent = objzx_TopicObjectiveENS.ObjectiveContent; //客观内容
objzx_TopicObjectiveENT.ObjectiveType = objzx_TopicObjectiveENS.ObjectiveType; //客观类型
objzx_TopicObjectiveENT.Conclusion = objzx_TopicObjectiveENS.Conclusion; //结论
objzx_TopicObjectiveENT.TextId = objzx_TopicObjectiveENS.TextId; //课件Id
objzx_TopicObjectiveENT.IsSubmit = objzx_TopicObjectiveENS.IsSubmit; //是否提交
objzx_TopicObjectiveENT.VoteCount = objzx_TopicObjectiveENS.VoteCount; //点赞计数
objzx_TopicObjectiveENT.AppraiseCount = objzx_TopicObjectiveENS.AppraiseCount; //评论数
objzx_TopicObjectiveENT.Score = objzx_TopicObjectiveENS.Score; //评分
objzx_TopicObjectiveENT.StuScore = objzx_TopicObjectiveENS.StuScore; //学生平均分
objzx_TopicObjectiveENT.TeaScore = objzx_TopicObjectiveENS.TeaScore; //教师评分
objzx_TopicObjectiveENT.IdCurrEduCls = objzx_TopicObjectiveENS.IdCurrEduCls; //教学班流水号
objzx_TopicObjectiveENT.PdfContent = objzx_TopicObjectiveENS.PdfContent; //Pdf内容
objzx_TopicObjectiveENT.PdfPageNum = objzx_TopicObjectiveENS.PdfPageNum; //Pdf页码
objzx_TopicObjectiveENT.CitationCount = objzx_TopicObjectiveENS.CitationCount; //引用统计
objzx_TopicObjectiveENT.VersionCount = objzx_TopicObjectiveENS.VersionCount; //版本统计
objzx_TopicObjectiveENT.zxShareId = objzx_TopicObjectiveENS.zxShareId; //分享Id
objzx_TopicObjectiveENT.CreateDate = objzx_TopicObjectiveENS.CreateDate; //建立日期
objzx_TopicObjectiveENT.UpdDate = objzx_TopicObjectiveENS.UpdDate; //修改日期
objzx_TopicObjectiveENT.UpdUser = objzx_TopicObjectiveENS.UpdUser; //修改人
objzx_TopicObjectiveENT.Memo = objzx_TopicObjectiveENS.Memo; //备注
objzx_TopicObjectiveENT.PdfDivLet = objzx_TopicObjectiveENS.PdfDivLet; //PdfDivLet
objzx_TopicObjectiveENT.PdfDivTop = objzx_TopicObjectiveENS.PdfDivTop; //PdfDivTop
objzx_TopicObjectiveENT.PdfPageNumIn = objzx_TopicObjectiveENS.PdfPageNumIn; //PdfPageNumIn
objzx_TopicObjectiveENT.PdfPageTop = objzx_TopicObjectiveENS.PdfPageTop; //pdf页面顶部位置
objzx_TopicObjectiveENT.PdfZoom = objzx_TopicObjectiveENS.PdfZoom; //PdfZoom
objzx_TopicObjectiveENT.GroupTextId = objzx_TopicObjectiveENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_TopicObjectiveEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
try
{
objzx_TopicObjectiveEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TopicObjectiveEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_TopicObjective.zxTopicObjectiveId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.zxTopicObjectiveId = objzx_TopicObjectiveEN.zxTopicObjectiveId; //客观Id
}
if (arrFldSet.Contains(conzx_TopicObjective.ObjectiveName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.ObjectiveName = objzx_TopicObjectiveEN.ObjectiveName == "[null]" ? null :  objzx_TopicObjectiveEN.ObjectiveName; //客观名称
}
if (arrFldSet.Contains(conzx_TopicObjective.ObjectiveContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.ObjectiveContent = objzx_TopicObjectiveEN.ObjectiveContent == "[null]" ? null :  objzx_TopicObjectiveEN.ObjectiveContent; //客观内容
}
if (arrFldSet.Contains(conzx_TopicObjective.ObjectiveType, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.ObjectiveType = objzx_TopicObjectiveEN.ObjectiveType == "[null]" ? null :  objzx_TopicObjectiveEN.ObjectiveType; //客观类型
}
if (arrFldSet.Contains(conzx_TopicObjective.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.Conclusion = objzx_TopicObjectiveEN.Conclusion == "[null]" ? null :  objzx_TopicObjectiveEN.Conclusion; //结论
}
if (arrFldSet.Contains(conzx_TopicObjective.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.TextId = objzx_TopicObjectiveEN.TextId == "[null]" ? null :  objzx_TopicObjectiveEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_TopicObjective.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.IsSubmit = objzx_TopicObjectiveEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_TopicObjective.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.VoteCount = objzx_TopicObjectiveEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_TopicObjective.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.AppraiseCount = objzx_TopicObjectiveEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_TopicObjective.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.Score = objzx_TopicObjectiveEN.Score; //评分
}
if (arrFldSet.Contains(conzx_TopicObjective.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.StuScore = objzx_TopicObjectiveEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_TopicObjective.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.TeaScore = objzx_TopicObjectiveEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_TopicObjective.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.IdCurrEduCls = objzx_TopicObjectiveEN.IdCurrEduCls == "[null]" ? null :  objzx_TopicObjectiveEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_TopicObjective.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.PdfContent = objzx_TopicObjectiveEN.PdfContent == "[null]" ? null :  objzx_TopicObjectiveEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_TopicObjective.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.PdfPageNum = objzx_TopicObjectiveEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_TopicObjective.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.CitationCount = objzx_TopicObjectiveEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_TopicObjective.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.VersionCount = objzx_TopicObjectiveEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_TopicObjective.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.zxShareId = objzx_TopicObjectiveEN.zxShareId == "[null]" ? null :  objzx_TopicObjectiveEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_TopicObjective.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.CreateDate = objzx_TopicObjectiveEN.CreateDate == "[null]" ? null :  objzx_TopicObjectiveEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_TopicObjective.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.UpdDate = objzx_TopicObjectiveEN.UpdDate == "[null]" ? null :  objzx_TopicObjectiveEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_TopicObjective.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.UpdUser = objzx_TopicObjectiveEN.UpdUser == "[null]" ? null :  objzx_TopicObjectiveEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_TopicObjective.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.Memo = objzx_TopicObjectiveEN.Memo == "[null]" ? null :  objzx_TopicObjectiveEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_TopicObjective.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.PdfDivLet = objzx_TopicObjectiveEN.PdfDivLet == "[null]" ? null :  objzx_TopicObjectiveEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_TopicObjective.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.PdfDivTop = objzx_TopicObjectiveEN.PdfDivTop == "[null]" ? null :  objzx_TopicObjectiveEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_TopicObjective.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.PdfPageNumIn = objzx_TopicObjectiveEN.PdfPageNumIn == "[null]" ? null :  objzx_TopicObjectiveEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_TopicObjective.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.PdfPageTop = objzx_TopicObjectiveEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_TopicObjective.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.PdfZoom = objzx_TopicObjectiveEN.PdfZoom == "[null]" ? null :  objzx_TopicObjectiveEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_TopicObjective.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TopicObjectiveEN.GroupTextId = objzx_TopicObjectiveEN.GroupTextId == "[null]" ? null :  objzx_TopicObjectiveEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_TopicObjectiveEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
try
{
if (objzx_TopicObjectiveEN.ObjectiveName == "[null]") objzx_TopicObjectiveEN.ObjectiveName = null; //客观名称
if (objzx_TopicObjectiveEN.ObjectiveContent == "[null]") objzx_TopicObjectiveEN.ObjectiveContent = null; //客观内容
if (objzx_TopicObjectiveEN.ObjectiveType == "[null]") objzx_TopicObjectiveEN.ObjectiveType = null; //客观类型
if (objzx_TopicObjectiveEN.Conclusion == "[null]") objzx_TopicObjectiveEN.Conclusion = null; //结论
if (objzx_TopicObjectiveEN.TextId == "[null]") objzx_TopicObjectiveEN.TextId = null; //课件Id
if (objzx_TopicObjectiveEN.IdCurrEduCls == "[null]") objzx_TopicObjectiveEN.IdCurrEduCls = null; //教学班流水号
if (objzx_TopicObjectiveEN.PdfContent == "[null]") objzx_TopicObjectiveEN.PdfContent = null; //Pdf内容
if (objzx_TopicObjectiveEN.zxShareId == "[null]") objzx_TopicObjectiveEN.zxShareId = null; //分享Id
if (objzx_TopicObjectiveEN.CreateDate == "[null]") objzx_TopicObjectiveEN.CreateDate = null; //建立日期
if (objzx_TopicObjectiveEN.UpdDate == "[null]") objzx_TopicObjectiveEN.UpdDate = null; //修改日期
if (objzx_TopicObjectiveEN.UpdUser == "[null]") objzx_TopicObjectiveEN.UpdUser = null; //修改人
if (objzx_TopicObjectiveEN.Memo == "[null]") objzx_TopicObjectiveEN.Memo = null; //备注
if (objzx_TopicObjectiveEN.PdfDivLet == "[null]") objzx_TopicObjectiveEN.PdfDivLet = null; //PdfDivLet
if (objzx_TopicObjectiveEN.PdfDivTop == "[null]") objzx_TopicObjectiveEN.PdfDivTop = null; //PdfDivTop
if (objzx_TopicObjectiveEN.PdfPageNumIn == "[null]") objzx_TopicObjectiveEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_TopicObjectiveEN.PdfZoom == "[null]") objzx_TopicObjectiveEN.PdfZoom = null; //PdfZoom
if (objzx_TopicObjectiveEN.GroupTextId == "[null]") objzx_TopicObjectiveEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 zx_TopicObjectiveDA.CheckPropertyNew(objzx_TopicObjectiveEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
 zx_TopicObjectiveDA.CheckProperty4Condition(objzx_TopicObjectiveEN);
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
if (clszx_TopicObjectiveBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TopicObjectiveBL没有刷新缓存机制(clszx_TopicObjectiveBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxTopicObjectiveId");
//if (arrzx_TopicObjectiveObjLstCache == null)
//{
//arrzx_TopicObjectiveObjLstCache = zx_TopicObjectiveDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TopicObjectiveEN GetObjByzxTopicObjectiveIdCache(string strzxTopicObjectiveId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_TopicObjectiveEN._CurrTabName, strIdCurrEduCls);
List<clszx_TopicObjectiveEN> arrzx_TopicObjectiveObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TopicObjectiveEN> arrzx_TopicObjectiveObjLst_Sel =
arrzx_TopicObjectiveObjLstCache
.Where(x=> x.zxTopicObjectiveId == strzxTopicObjectiveId 
);
if (arrzx_TopicObjectiveObjLst_Sel.Count() == 0)
{
   clszx_TopicObjectiveEN obj = clszx_TopicObjectiveBL.GetObjByzxTopicObjectiveId(strzxTopicObjectiveId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxTopicObjectiveId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_TopicObjectiveObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TopicObjectiveEN> GetAllzx_TopicObjectiveObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_TopicObjectiveEN> arrzx_TopicObjectiveObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_TopicObjectiveObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TopicObjectiveEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_TopicObjectiveEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_TopicObjectiveEN> arrzx_TopicObjectiveObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_TopicObjectiveObjLstCache;
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
string strKey = string.Format("{0}_{1}", clszx_TopicObjectiveEN._CurrTabName, strIdCurrEduCls);
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
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TopicObjectiveBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_TopicObjectiveEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_TopicObjectiveBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_TopicObjective(中学客观事实数据)
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_TopicObjectiveEN objzx_TopicObjectiveEN)
{
//检测记录是否存在
string strResult = zx_TopicObjectiveDA.GetUniCondStr(objzx_TopicObjectiveEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxTopicObjectiveId, string strIdCurrEduCls)
{
if (strInFldName != conzx_TopicObjective.zxTopicObjectiveId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_TopicObjective.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_TopicObjective.AttributeName));
throw new Exception(strMsg);
}
var objzx_TopicObjective = clszx_TopicObjectiveBL.GetObjByzxTopicObjectiveIdCache(strzxTopicObjectiveId, strIdCurrEduCls);
if (objzx_TopicObjective == null) return "";
return objzx_TopicObjective[strOutFldName].ToString();
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
int intRecCount = clszx_TopicObjectiveDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TopicObjectiveDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TopicObjectiveDA.GetRecCount();
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
int intRecCount = clszx_TopicObjectiveDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TopicObjectiveCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TopicObjectiveEN objzx_TopicObjectiveCond)
{
 string strIdCurrEduCls = objzx_TopicObjectiveCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_TopicObjectiveBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_TopicObjectiveEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TopicObjectiveEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TopicObjective.AttributeName)
{
if (objzx_TopicObjectiveCond.IsUpdated(strFldName) == false) continue;
if (objzx_TopicObjectiveCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicObjectiveCond[strFldName].ToString());
}
else
{
if (objzx_TopicObjectiveCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TopicObjectiveCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TopicObjectiveCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TopicObjectiveCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TopicObjectiveCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TopicObjectiveCond[strFldName]));
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
 List<string> arrList = clszx_TopicObjectiveDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TopicObjectiveDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TopicObjectiveDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TopicObjectiveDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TopicObjectiveDA.SetFldValue(clszx_TopicObjectiveEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TopicObjectiveDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TopicObjectiveDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TopicObjectiveDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TopicObjectiveDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_TopicObjective] "); 
 strCreateTabCode.Append(" ( "); 
 // /**客观Id*/ 
 strCreateTabCode.Append(" zxTopicObjectiveId char(8) primary key, "); 
 // /**客观名称*/ 
 strCreateTabCode.Append(" ObjectiveName varchar(500) Null, "); 
 // /**客观内容*/ 
 strCreateTabCode.Append(" ObjectiveContent text Null, "); 
 // /**客观类型*/ 
 strCreateTabCode.Append(" ObjectiveType char(2) Null, "); 
 // /**结论*/ 
 strCreateTabCode.Append(" Conclusion text Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
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
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**引用统计*/ 
 strCreateTabCode.Append(" CitationCount int Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**PdfDivLet*/ 
 strCreateTabCode.Append(" PdfDivLet varchar(50) Null, "); 
 // /**PdfDivTop*/ 
 strCreateTabCode.Append(" PdfDivTop varchar(50) Null, "); 
 // /**PdfPageNumIn*/ 
 strCreateTabCode.Append(" PdfPageNumIn varchar(50) Null, "); 
 // /**pdf页面顶部位置*/ 
 strCreateTabCode.Append(" PdfPageTop int Null, "); 
 // /**PdfZoom*/ 
 strCreateTabCode.Append(" PdfZoom varchar(50) Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学客观事实数据(zx_TopicObjective)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_TopicObjective : clsCommFun4BLV2
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
clszx_TopicObjectiveBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}