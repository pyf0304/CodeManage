
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerVerBL
 表名:qa_AnswerVer(01120756)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsqa_AnswerVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngAnswerVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_AnswerVerEN GetObj(this K_AnswerVId_qa_AnswerVer myKey)
{
clsqa_AnswerVerEN objqa_AnswerVerEN = clsqa_AnswerVerBL.qa_AnswerVerDA.GetObjByAnswerVId(myKey.Value);
return objqa_AnswerVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsqa_AnswerVerEN objqa_AnswerVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_AnswerVerEN) == false)
{
var strMsg = string.Format("记录已经存在!问答历史主键 = [{0}]的数据已经存在!(in clsqa_AnswerVerBL.AddNewRecord)", objqa_AnswerVerEN.AnswerVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsqa_AnswerVerBL.qa_AnswerVerDA.AddNewRecordBySQL2(objqa_AnswerVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
public static bool AddRecordEx(this clsqa_AnswerVerEN objqa_AnswerVerEN, bool bolIsNeedCheckUniqueness = true)
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
objqa_AnswerVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objqa_AnswerVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(问答历史主键(AnswerVId)=[{0}])已经存在,不能重复!", objqa_AnswerVerEN.AnswerVId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objqa_AnswerVerEN.AddNewRecord();
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
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsqa_AnswerVerEN objqa_AnswerVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_AnswerVerEN) == false)
{
var strMsg = string.Format("记录已经存在!问答历史主键 = [{0}]的数据已经存在!(in clsqa_AnswerVerBL.AddNewRecordWithReturnKey)", objqa_AnswerVerEN.AnswerVId);
throw new Exception(strMsg);
}
try
{
string strKey = clsqa_AnswerVerBL.qa_AnswerVerDA.AddNewRecordBySQL2WithReturnKey(objqa_AnswerVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetAnswerVId(this clsqa_AnswerVerEN objqa_AnswerVerEN, long lngAnswerVId, string strComparisonOp="")
	{
objqa_AnswerVerEN.AnswerVId = lngAnswerVId; //问答历史主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.AnswerVId) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.AnswerVId, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.AnswerVId] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetAnswerId(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strAnswerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAnswerId, conqa_AnswerVer.AnswerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerId, 10, conqa_AnswerVer.AnswerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerId, 10, conqa_AnswerVer.AnswerId);
}
objqa_AnswerVerEN.AnswerId = strAnswerId; //回答Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.AnswerId) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.AnswerId, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.AnswerId] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetQuestionsId(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsId, conqa_AnswerVer.QuestionsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsId, 8, conqa_AnswerVer.QuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, conqa_AnswerVer.QuestionsId);
}
objqa_AnswerVerEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.QuestionsId) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.QuestionsId, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.QuestionsId] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetAnswerContent(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strAnswerContent, string strComparisonOp="")
	{
objqa_AnswerVerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.AnswerContent) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.AnswerContent, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.AnswerContent] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetScore(this clsqa_AnswerVerEN objqa_AnswerVerEN, float? fltScore, string strComparisonOp="")
	{
objqa_AnswerVerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.Score) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.Score, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.Score] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetScoreType(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, conqa_AnswerVer.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, conqa_AnswerVer.ScoreType);
}
objqa_AnswerVerEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.ScoreType) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.ScoreType, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.ScoreType] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetIsRight(this clsqa_AnswerVerEN objqa_AnswerVerEN, bool bolIsRight, string strComparisonOp="")
	{
objqa_AnswerVerEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.IsRight) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.IsRight, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.IsRight] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetParentId(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, conqa_AnswerVer.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, conqa_AnswerVer.ParentId);
}
objqa_AnswerVerEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.ParentId) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.ParentId, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.ParentId] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetVoteCount(this clsqa_AnswerVerEN objqa_AnswerVerEN, int? intVoteCount, string strComparisonOp="")
	{
objqa_AnswerVerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.VoteCount) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.VoteCount, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.VoteCount] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetIsRecommend(this clsqa_AnswerVerEN objqa_AnswerVerEN, bool bolIsRecommend, string strComparisonOp="")
	{
objqa_AnswerVerEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.IsRecommend) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.IsRecommend, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.IsRecommend] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetTopicId(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, conqa_AnswerVer.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conqa_AnswerVer.TopicId);
}
objqa_AnswerVerEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.TopicId) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.TopicId, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.TopicId] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetAnswerTypeId(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conqa_AnswerVer.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conqa_AnswerVer.AnswerTypeId);
}
objqa_AnswerVerEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.AnswerTypeId) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.AnswerTypeId, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.AnswerTypeId] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetIsSubmit(this clsqa_AnswerVerEN objqa_AnswerVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objqa_AnswerVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.IsSubmit) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.IsSubmit, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.IsSubmit] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetUpdUser(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conqa_AnswerVer.UpdUser);
}
objqa_AnswerVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.UpdUser) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.UpdUser, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.UpdUser] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetUpdDate(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conqa_AnswerVer.UpdDate);
}
objqa_AnswerVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.UpdDate) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.UpdDate, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.UpdDate] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerVerEN SetMemo(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conqa_AnswerVer.Memo);
}
objqa_AnswerVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVerEN.dicFldComparisonOp.ContainsKey(conqa_AnswerVer.Memo) == false)
{
objqa_AnswerVerEN.dicFldComparisonOp.Add(conqa_AnswerVer.Memo, strComparisonOp);
}
else
{
objqa_AnswerVerEN.dicFldComparisonOp[conqa_AnswerVer.Memo] = strComparisonOp;
}
}
return objqa_AnswerVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsqa_AnswerVerEN objqa_AnswerVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objqa_AnswerVerEN.CheckPropertyNew();
clsqa_AnswerVerEN objqa_AnswerVerCond = new clsqa_AnswerVerEN();
string strCondition = objqa_AnswerVerCond
.SetAnswerVId(objqa_AnswerVerEN.AnswerVId, "<>")
.SetAnswerVId(objqa_AnswerVerEN.AnswerVId, "=")
.GetCombineCondition();
objqa_AnswerVerEN._IsCheckProperty = true;
bool bolIsExist = clsqa_AnswerVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(AnswerVId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objqa_AnswerVerEN.Update();
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
 /// <param name = "objqa_AnswerVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsqa_AnswerVerEN objqa_AnswerVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsqa_AnswerVerEN objqa_AnswerVerCond = new clsqa_AnswerVerEN();
string strCondition = objqa_AnswerVerCond
.SetAnswerVId(objqa_AnswerVer.AnswerVId, "=")
.GetCombineCondition();
objqa_AnswerVer._IsCheckProperty = true;
bool bolIsExist = clsqa_AnswerVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objqa_AnswerVer.AnswerVId = clsqa_AnswerVerBL.GetFirstID_S(strCondition);
objqa_AnswerVer.UpdateWithCondition(strCondition);
}
else
{
objqa_AnswerVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 if (objqa_AnswerVerEN.AnswerVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsqa_AnswerVerBL.qa_AnswerVerDA.UpdateBySql2(objqa_AnswerVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_AnswerVerEN objqa_AnswerVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objqa_AnswerVerEN.AnswerVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsqa_AnswerVerBL.qa_AnswerVerDA.UpdateBySql2(objqa_AnswerVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strWhereCond)
{
try
{
bool bolResult = clsqa_AnswerVerBL.qa_AnswerVerDA.UpdateBySqlWithCondition(objqa_AnswerVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_AnswerVerEN objqa_AnswerVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsqa_AnswerVerBL.qa_AnswerVerDA.UpdateBySqlWithConditionTransaction(objqa_AnswerVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "lngAnswerVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsqa_AnswerVerEN objqa_AnswerVerEN)
{
try
{
int intRecNum = clsqa_AnswerVerBL.qa_AnswerVerDA.DelRecord(objqa_AnswerVerEN.AnswerVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerVerENS">源对象</param>
 /// <param name = "objqa_AnswerVerENT">目标对象</param>
 public static void CopyTo(this clsqa_AnswerVerEN objqa_AnswerVerENS, clsqa_AnswerVerEN objqa_AnswerVerENT)
{
try
{
objqa_AnswerVerENT.AnswerVId = objqa_AnswerVerENS.AnswerVId; //问答历史主键
objqa_AnswerVerENT.AnswerId = objqa_AnswerVerENS.AnswerId; //回答Id
objqa_AnswerVerENT.QuestionsId = objqa_AnswerVerENS.QuestionsId; //提问Id
objqa_AnswerVerENT.AnswerContent = objqa_AnswerVerENS.AnswerContent; //答案内容
objqa_AnswerVerENT.Score = objqa_AnswerVerENS.Score; //评分
objqa_AnswerVerENT.ScoreType = objqa_AnswerVerENS.ScoreType; //评分类型
objqa_AnswerVerENT.IsRight = objqa_AnswerVerENS.IsRight; //是否正确
objqa_AnswerVerENT.ParentId = objqa_AnswerVerENS.ParentId; //父节点Id
objqa_AnswerVerENT.VoteCount = objqa_AnswerVerENS.VoteCount; //点赞计数
objqa_AnswerVerENT.IsRecommend = objqa_AnswerVerENS.IsRecommend; //是否推荐
objqa_AnswerVerENT.TopicId = objqa_AnswerVerENS.TopicId; //主题Id
objqa_AnswerVerENT.AnswerTypeId = objqa_AnswerVerENS.AnswerTypeId; //答案类型ID
objqa_AnswerVerENT.IsSubmit = objqa_AnswerVerENS.IsSubmit; //是否提交
objqa_AnswerVerENT.UpdUser = objqa_AnswerVerENS.UpdUser; //修改人
objqa_AnswerVerENT.UpdDate = objqa_AnswerVerENS.UpdDate; //修改日期
objqa_AnswerVerENT.Memo = objqa_AnswerVerENS.Memo; //备注
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
 /// <param name = "objqa_AnswerVerENS">源对象</param>
 /// <returns>目标对象=>clsqa_AnswerVerEN:objqa_AnswerVerENT</returns>
 public static clsqa_AnswerVerEN CopyTo(this clsqa_AnswerVerEN objqa_AnswerVerENS)
{
try
{
 clsqa_AnswerVerEN objqa_AnswerVerENT = new clsqa_AnswerVerEN()
{
AnswerVId = objqa_AnswerVerENS.AnswerVId, //问答历史主键
AnswerId = objqa_AnswerVerENS.AnswerId, //回答Id
QuestionsId = objqa_AnswerVerENS.QuestionsId, //提问Id
AnswerContent = objqa_AnswerVerENS.AnswerContent, //答案内容
Score = objqa_AnswerVerENS.Score, //评分
ScoreType = objqa_AnswerVerENS.ScoreType, //评分类型
IsRight = objqa_AnswerVerENS.IsRight, //是否正确
ParentId = objqa_AnswerVerENS.ParentId, //父节点Id
VoteCount = objqa_AnswerVerENS.VoteCount, //点赞计数
IsRecommend = objqa_AnswerVerENS.IsRecommend, //是否推荐
TopicId = objqa_AnswerVerENS.TopicId, //主题Id
AnswerTypeId = objqa_AnswerVerENS.AnswerTypeId, //答案类型ID
IsSubmit = objqa_AnswerVerENS.IsSubmit, //是否提交
UpdUser = objqa_AnswerVerENS.UpdUser, //修改人
UpdDate = objqa_AnswerVerENS.UpdDate, //修改日期
Memo = objqa_AnswerVerENS.Memo, //备注
};
 return objqa_AnswerVerENT;
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
public static void CheckPropertyNew(this clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 clsqa_AnswerVerBL.qa_AnswerVerDA.CheckPropertyNew(objqa_AnswerVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 clsqa_AnswerVerBL.qa_AnswerVerDA.CheckProperty4Condition(objqa_AnswerVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsqa_AnswerVerEN objqa_AnswerVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.AnswerVId) == true)
{
string strComparisonOpAnswerVId = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.AnswerVId];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_AnswerVer.AnswerVId, objqa_AnswerVerCond.AnswerVId, strComparisonOpAnswerVId);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.AnswerId) == true)
{
string strComparisonOpAnswerId = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.AnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerVer.AnswerId, objqa_AnswerVerCond.AnswerId, strComparisonOpAnswerId);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.QuestionsId) == true)
{
string strComparisonOpQuestionsId = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerVer.QuestionsId, objqa_AnswerVerCond.QuestionsId, strComparisonOpQuestionsId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.Score) == true)
{
string strComparisonOpScore = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_AnswerVer.Score, objqa_AnswerVerCond.Score, strComparisonOpScore);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.ScoreType) == true)
{
string strComparisonOpScoreType = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerVer.ScoreType, objqa_AnswerVerCond.ScoreType, strComparisonOpScoreType);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.IsRight) == true)
{
if (objqa_AnswerVerCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_AnswerVer.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_AnswerVer.IsRight);
}
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.ParentId) == true)
{
string strComparisonOpParentId = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerVer.ParentId, objqa_AnswerVerCond.ParentId, strComparisonOpParentId);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.VoteCount) == true)
{
string strComparisonOpVoteCount = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_AnswerVer.VoteCount, objqa_AnswerVerCond.VoteCount, strComparisonOpVoteCount);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.IsRecommend) == true)
{
if (objqa_AnswerVerCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_AnswerVer.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_AnswerVer.IsRecommend);
}
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.TopicId) == true)
{
string strComparisonOpTopicId = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerVer.TopicId, objqa_AnswerVerCond.TopicId, strComparisonOpTopicId);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerVer.AnswerTypeId, objqa_AnswerVerCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.IsSubmit) == true)
{
if (objqa_AnswerVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_AnswerVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_AnswerVer.IsSubmit);
}
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerVer.UpdUser, objqa_AnswerVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerVer.UpdDate, objqa_AnswerVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objqa_AnswerVerCond.IsUpdated(conqa_AnswerVer.Memo) == true)
{
string strComparisonOpMemo = objqa_AnswerVerCond.dicFldComparisonOp[conqa_AnswerVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerVer.Memo, objqa_AnswerVerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--qa_AnswerVer(答疑回答历史V), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:AnswerVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsqa_AnswerVerEN objqa_AnswerVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objqa_AnswerVerEN == null) return true;
if (objqa_AnswerVerEN.AnswerVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerVId = '{0}'", objqa_AnswerVerEN.AnswerVId);
if (clsqa_AnswerVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("AnswerVId !=  {0}", objqa_AnswerVerEN.AnswerVId);
 sbCondition.AppendFormat(" and AnswerVId = '{0}'", objqa_AnswerVerEN.AnswerVId);
if (clsqa_AnswerVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--qa_AnswerVer(答疑回答历史V), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:AnswerVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsqa_AnswerVerEN objqa_AnswerVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objqa_AnswerVerEN == null) return "";
if (objqa_AnswerVerEN.AnswerVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerVId = '{0}'", objqa_AnswerVerEN.AnswerVId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AnswerVId !=  {0}", objqa_AnswerVerEN.AnswerVId);
 sbCondition.AppendFormat(" and AnswerVId = '{0}'", objqa_AnswerVerEN.AnswerVId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_qa_AnswerVer
{
public virtual bool UpdRelaTabDate(long lngAnswerVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 答疑回答历史V(qa_AnswerVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsqa_AnswerVerBL
{
public static RelatedActions_qa_AnswerVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsqa_AnswerVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsqa_AnswerVerDA qa_AnswerVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsqa_AnswerVerDA();
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
 public clsqa_AnswerVerBL()
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
if (string.IsNullOrEmpty(clsqa_AnswerVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsqa_AnswerVerEN._ConnectString);
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
public static DataTable GetDataTable_qa_AnswerVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = qa_AnswerVerDA.GetDataTable_qa_AnswerVer(strWhereCond);
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
objDT = qa_AnswerVerDA.GetDataTable(strWhereCond);
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
objDT = qa_AnswerVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = qa_AnswerVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = qa_AnswerVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = qa_AnswerVerDA.GetDataTable_Top(objTopPara);
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
objDT = qa_AnswerVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = qa_AnswerVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = qa_AnswerVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrAnswerVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsqa_AnswerVerEN> GetObjLstByAnswerVIdLst(List<long> arrAnswerVIdLst)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrAnswerVIdLst);
 string strWhereCond = string.Format("AnswerVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAnswerVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsqa_AnswerVerEN> GetObjLstByAnswerVIdLstCache(List<long> arrAnswerVIdLst)
{
string strKey = string.Format("{0}", clsqa_AnswerVerEN._CurrTabName);
List<clsqa_AnswerVerEN> arrqa_AnswerVerObjLstCache = GetObjLstCache();
IEnumerable <clsqa_AnswerVerEN> arrqa_AnswerVerObjLst_Sel =
arrqa_AnswerVerObjLstCache
.Where(x => arrAnswerVIdLst.Contains(x.AnswerVId));
return arrqa_AnswerVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerVerEN> GetObjLst(string strWhereCond)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
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
public static List<clsqa_AnswerVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objqa_AnswerVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsqa_AnswerVerEN> GetSubObjLstCache(clsqa_AnswerVerEN objqa_AnswerVerCond)
{
List<clsqa_AnswerVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsqa_AnswerVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conqa_AnswerVer.AttributeName)
{
if (objqa_AnswerVerCond.IsUpdated(strFldName) == false) continue;
if (objqa_AnswerVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_AnswerVerCond[strFldName].ToString());
}
else
{
if (objqa_AnswerVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objqa_AnswerVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_AnswerVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objqa_AnswerVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objqa_AnswerVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objqa_AnswerVerCond[strFldName]));
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
public static List<clsqa_AnswerVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
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
public static List<clsqa_AnswerVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
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
List<clsqa_AnswerVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsqa_AnswerVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsqa_AnswerVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
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
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
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
public static List<clsqa_AnswerVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsqa_AnswerVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsqa_AnswerVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
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
public static List<clsqa_AnswerVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsqa_AnswerVerEN> arrObjLst = new List<clsqa_AnswerVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerVerEN objqa_AnswerVerEN = new clsqa_AnswerVerEN();
try
{
objqa_AnswerVerEN.AnswerVId = Int32.Parse(objRow[conqa_AnswerVer.AnswerVId].ToString().Trim()); //问答历史主键
objqa_AnswerVerEN.AnswerId = objRow[conqa_AnswerVer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerVerEN.QuestionsId = objRow[conqa_AnswerVer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerVerEN.AnswerContent = objRow[conqa_AnswerVer.AnswerContent] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerVerEN.Score = objRow[conqa_AnswerVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_AnswerVer.Score].ToString().Trim()); //评分
objqa_AnswerVerEN.ScoreType = objRow[conqa_AnswerVer.ScoreType] == DBNull.Value ? null : objRow[conqa_AnswerVer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerVerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerVerEN.ParentId = objRow[conqa_AnswerVer.ParentId] == DBNull.Value ? null : objRow[conqa_AnswerVer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerVerEN.VoteCount = objRow[conqa_AnswerVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_AnswerVer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerVerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerVerEN.TopicId = objRow[conqa_AnswerVer.TopicId] == DBNull.Value ? null : objRow[conqa_AnswerVer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerVerEN.AnswerTypeId = objRow[conqa_AnswerVer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_AnswerVer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_AnswerVer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerVerEN.UpdUser = objRow[conqa_AnswerVer.UpdUser] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerVerEN.UpdDate = objRow[conqa_AnswerVer.UpdDate] == DBNull.Value ? null : objRow[conqa_AnswerVer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerVerEN.Memo = objRow[conqa_AnswerVer.Memo] == DBNull.Value ? null : objRow[conqa_AnswerVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerVerEN.AnswerVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getqa_AnswerVer(ref clsqa_AnswerVerEN objqa_AnswerVerEN)
{
bool bolResult = qa_AnswerVerDA.Getqa_AnswerVer(ref objqa_AnswerVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngAnswerVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_AnswerVerEN GetObjByAnswerVId(long lngAnswerVId)
{
clsqa_AnswerVerEN objqa_AnswerVerEN = qa_AnswerVerDA.GetObjByAnswerVId(lngAnswerVId);
return objqa_AnswerVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsqa_AnswerVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsqa_AnswerVerEN objqa_AnswerVerEN = qa_AnswerVerDA.GetFirstObj(strWhereCond);
 return objqa_AnswerVerEN;
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
public static clsqa_AnswerVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsqa_AnswerVerEN objqa_AnswerVerEN = qa_AnswerVerDA.GetObjByDataRow(objRow);
 return objqa_AnswerVerEN;
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
public static clsqa_AnswerVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsqa_AnswerVerEN objqa_AnswerVerEN = qa_AnswerVerDA.GetObjByDataRow(objRow);
 return objqa_AnswerVerEN;
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
 /// <param name = "lngAnswerVId">所给的关键字</param>
 /// <param name = "lstqa_AnswerVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_AnswerVerEN GetObjByAnswerVIdFromList(long lngAnswerVId, List<clsqa_AnswerVerEN> lstqa_AnswerVerObjLst)
{
foreach (clsqa_AnswerVerEN objqa_AnswerVerEN in lstqa_AnswerVerObjLst)
{
if (objqa_AnswerVerEN.AnswerVId == lngAnswerVId)
{
return objqa_AnswerVerEN;
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
 long lngAnswerVId;
 try
 {
 lngAnswerVId = new clsqa_AnswerVerDA().GetFirstID(strWhereCond);
 return lngAnswerVId;
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
 arrList = qa_AnswerVerDA.GetID(strWhereCond);
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
bool bolIsExist = qa_AnswerVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngAnswerVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngAnswerVId)
{
//检测记录是否存在
bool bolIsExist = qa_AnswerVerDA.IsExist(lngAnswerVId);
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
 bolIsExist = clsqa_AnswerVerDA.IsExistTable();
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
 bolIsExist = qa_AnswerVerDA.IsExistTable(strTabName);
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
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsqa_AnswerVerEN objqa_AnswerVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objqa_AnswerVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问答历史主键 = [{0}]的数据已经存在!(in clsqa_AnswerVerBL.AddNewRecordBySql2)", objqa_AnswerVerEN.AnswerVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = qa_AnswerVerDA.AddNewRecordBySQL2(objqa_AnswerVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsqa_AnswerVerEN objqa_AnswerVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objqa_AnswerVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问答历史主键 = [{0}]的数据已经存在!(in clsqa_AnswerVerBL.AddNewRecordBySql2WithReturnKey)", objqa_AnswerVerEN.AnswerVId);
throw new Exception(strMsg);
}
try
{
string strKey = qa_AnswerVerDA.AddNewRecordBySQL2WithReturnKey(objqa_AnswerVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
try
{
bool bolResult = qa_AnswerVerDA.Update(objqa_AnswerVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 if (objqa_AnswerVerEN.AnswerVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = qa_AnswerVerDA.UpdateBySql2(objqa_AnswerVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVerBL.ReFreshCache();

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
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
 /// <param name = "lngAnswerVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngAnswerVId)
{
try
{
 clsqa_AnswerVerEN objqa_AnswerVerEN = clsqa_AnswerVerBL.GetObjByAnswerVId(lngAnswerVId);

if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(objqa_AnswerVerEN.AnswerVId, "SetUpdDate");
}
if (objqa_AnswerVerEN != null)
{
int intRecNum = qa_AnswerVerDA.DelRecord(lngAnswerVId);
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
/// <param name="lngAnswerVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngAnswerVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
//删除与表:[qa_AnswerVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conqa_AnswerVer.AnswerVId,
//lngAnswerVId);
//        clsqa_AnswerVerBL.Delqa_AnswerVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsqa_AnswerVerBL.DelRecord(lngAnswerVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsqa_AnswerVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngAnswerVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngAnswerVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngAnswerVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsqa_AnswerVerBL.relatedActions != null)
{
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(lngAnswerVId, "UpdRelaTabDate");
}
bool bolResult = qa_AnswerVerDA.DelRecord(lngAnswerVId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrAnswerVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delqa_AnswerVers(List<string> arrAnswerVIdLst)
{
if (arrAnswerVIdLst.Count == 0) return 0;
try
{
if (clsqa_AnswerVerBL.relatedActions != null)
{
foreach (var strAnswerVId in arrAnswerVIdLst)
{
long lngAnswerVId = long.Parse(strAnswerVId);
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(lngAnswerVId, "UpdRelaTabDate");
}
}
int intDelRecNum = qa_AnswerVerDA.Delqa_AnswerVer(arrAnswerVIdLst);
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
public static int Delqa_AnswerVersByCond(string strWhereCond)
{
try
{
if (clsqa_AnswerVerBL.relatedActions != null)
{
List<string> arrAnswerVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strAnswerVId in arrAnswerVId)
{
long lngAnswerVId = long.Parse(strAnswerVId);
clsqa_AnswerVerBL.relatedActions.UpdRelaTabDate(lngAnswerVId, "UpdRelaTabDate");
}
}
int intRecNum = qa_AnswerVerDA.Delqa_AnswerVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[qa_AnswerVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngAnswerVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngAnswerVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsqa_AnswerVerDA.GetSpecSQLObj();
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
//删除与表:[qa_AnswerVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsqa_AnswerVerBL.DelRecord(lngAnswerVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsqa_AnswerVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngAnswerVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objqa_AnswerVerENS">源对象</param>
 /// <param name = "objqa_AnswerVerENT">目标对象</param>
 public static void CopyTo(clsqa_AnswerVerEN objqa_AnswerVerENS, clsqa_AnswerVerEN objqa_AnswerVerENT)
{
try
{
objqa_AnswerVerENT.AnswerVId = objqa_AnswerVerENS.AnswerVId; //问答历史主键
objqa_AnswerVerENT.AnswerId = objqa_AnswerVerENS.AnswerId; //回答Id
objqa_AnswerVerENT.QuestionsId = objqa_AnswerVerENS.QuestionsId; //提问Id
objqa_AnswerVerENT.AnswerContent = objqa_AnswerVerENS.AnswerContent; //答案内容
objqa_AnswerVerENT.Score = objqa_AnswerVerENS.Score; //评分
objqa_AnswerVerENT.ScoreType = objqa_AnswerVerENS.ScoreType; //评分类型
objqa_AnswerVerENT.IsRight = objqa_AnswerVerENS.IsRight; //是否正确
objqa_AnswerVerENT.ParentId = objqa_AnswerVerENS.ParentId; //父节点Id
objqa_AnswerVerENT.VoteCount = objqa_AnswerVerENS.VoteCount; //点赞计数
objqa_AnswerVerENT.IsRecommend = objqa_AnswerVerENS.IsRecommend; //是否推荐
objqa_AnswerVerENT.TopicId = objqa_AnswerVerENS.TopicId; //主题Id
objqa_AnswerVerENT.AnswerTypeId = objqa_AnswerVerENS.AnswerTypeId; //答案类型ID
objqa_AnswerVerENT.IsSubmit = objqa_AnswerVerENS.IsSubmit; //是否提交
objqa_AnswerVerENT.UpdUser = objqa_AnswerVerENS.UpdUser; //修改人
objqa_AnswerVerENT.UpdDate = objqa_AnswerVerENS.UpdDate; //修改日期
objqa_AnswerVerENT.Memo = objqa_AnswerVerENS.Memo; //备注
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
 /// <param name = "objqa_AnswerVerEN">源简化对象</param>
 public static void SetUpdFlag(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
try
{
objqa_AnswerVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objqa_AnswerVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conqa_AnswerVer.AnswerVId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.AnswerVId = objqa_AnswerVerEN.AnswerVId; //问答历史主键
}
if (arrFldSet.Contains(conqa_AnswerVer.AnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.AnswerId = objqa_AnswerVerEN.AnswerId; //回答Id
}
if (arrFldSet.Contains(conqa_AnswerVer.QuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.QuestionsId = objqa_AnswerVerEN.QuestionsId; //提问Id
}
if (arrFldSet.Contains(conqa_AnswerVer.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.AnswerContent = objqa_AnswerVerEN.AnswerContent == "[null]" ? null :  objqa_AnswerVerEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(conqa_AnswerVer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.Score = objqa_AnswerVerEN.Score; //评分
}
if (arrFldSet.Contains(conqa_AnswerVer.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.ScoreType = objqa_AnswerVerEN.ScoreType == "[null]" ? null :  objqa_AnswerVerEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(conqa_AnswerVer.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.IsRight = objqa_AnswerVerEN.IsRight; //是否正确
}
if (arrFldSet.Contains(conqa_AnswerVer.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.ParentId = objqa_AnswerVerEN.ParentId == "[null]" ? null :  objqa_AnswerVerEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(conqa_AnswerVer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.VoteCount = objqa_AnswerVerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conqa_AnswerVer.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.IsRecommend = objqa_AnswerVerEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(conqa_AnswerVer.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.TopicId = objqa_AnswerVerEN.TopicId == "[null]" ? null :  objqa_AnswerVerEN.TopicId; //主题Id
}
if (arrFldSet.Contains(conqa_AnswerVer.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.AnswerTypeId = objqa_AnswerVerEN.AnswerTypeId == "[null]" ? null :  objqa_AnswerVerEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(conqa_AnswerVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.IsSubmit = objqa_AnswerVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conqa_AnswerVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.UpdUser = objqa_AnswerVerEN.UpdUser == "[null]" ? null :  objqa_AnswerVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conqa_AnswerVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.UpdDate = objqa_AnswerVerEN.UpdDate == "[null]" ? null :  objqa_AnswerVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conqa_AnswerVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerVerEN.Memo = objqa_AnswerVerEN.Memo == "[null]" ? null :  objqa_AnswerVerEN.Memo; //备注
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
 /// <param name = "objqa_AnswerVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
try
{
if (objqa_AnswerVerEN.AnswerContent == "[null]") objqa_AnswerVerEN.AnswerContent = null; //答案内容
if (objqa_AnswerVerEN.ScoreType == "[null]") objqa_AnswerVerEN.ScoreType = null; //评分类型
if (objqa_AnswerVerEN.ParentId == "[null]") objqa_AnswerVerEN.ParentId = null; //父节点Id
if (objqa_AnswerVerEN.TopicId == "[null]") objqa_AnswerVerEN.TopicId = null; //主题Id
if (objqa_AnswerVerEN.AnswerTypeId == "[null]") objqa_AnswerVerEN.AnswerTypeId = null; //答案类型ID
if (objqa_AnswerVerEN.UpdUser == "[null]") objqa_AnswerVerEN.UpdUser = null; //修改人
if (objqa_AnswerVerEN.UpdDate == "[null]") objqa_AnswerVerEN.UpdDate = null; //修改日期
if (objqa_AnswerVerEN.Memo == "[null]") objqa_AnswerVerEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 qa_AnswerVerDA.CheckPropertyNew(objqa_AnswerVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
 qa_AnswerVerDA.CheckProperty4Condition(objqa_AnswerVerEN);
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
if (clsqa_AnswerVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_AnswerVerBL没有刷新缓存机制(clsqa_AnswerVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerVId");
//if (arrqa_AnswerVerObjLstCache == null)
//{
//arrqa_AnswerVerObjLstCache = qa_AnswerVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngAnswerVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_AnswerVerEN GetObjByAnswerVIdCache(long lngAnswerVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsqa_AnswerVerEN._CurrTabName);
List<clsqa_AnswerVerEN> arrqa_AnswerVerObjLstCache = GetObjLstCache();
IEnumerable <clsqa_AnswerVerEN> arrqa_AnswerVerObjLst_Sel =
arrqa_AnswerVerObjLstCache
.Where(x=> x.AnswerVId == lngAnswerVId 
);
if (arrqa_AnswerVerObjLst_Sel.Count() == 0)
{
   clsqa_AnswerVerEN obj = clsqa_AnswerVerBL.GetObjByAnswerVId(lngAnswerVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrqa_AnswerVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_AnswerVerEN> GetAllqa_AnswerVerObjLstCache()
{
//获取缓存中的对象列表
List<clsqa_AnswerVerEN> arrqa_AnswerVerObjLstCache = GetObjLstCache(); 
return arrqa_AnswerVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_AnswerVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsqa_AnswerVerEN._CurrTabName);
List<clsqa_AnswerVerEN> arrqa_AnswerVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrqa_AnswerVerObjLstCache;
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
string strKey = string.Format("{0}", clsqa_AnswerVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsqa_AnswerVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsqa_AnswerVerEN._RefreshTimeLst.Count == 0) return "";
return clsqa_AnswerVerEN._RefreshTimeLst[clsqa_AnswerVerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsqa_AnswerVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsqa_AnswerVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsqa_AnswerVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsqa_AnswerVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--qa_AnswerVer(答疑回答历史V)
 /// 唯一性条件:AnswerVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objqa_AnswerVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsqa_AnswerVerEN objqa_AnswerVerEN)
{
//检测记录是否存在
string strResult = qa_AnswerVerDA.GetUniCondStr(objqa_AnswerVerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngAnswerVId)
{
if (strInFldName != conqa_AnswerVer.AnswerVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conqa_AnswerVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conqa_AnswerVer.AttributeName));
throw new Exception(strMsg);
}
var objqa_AnswerVer = clsqa_AnswerVerBL.GetObjByAnswerVIdCache(lngAnswerVId);
if (objqa_AnswerVer == null) return "";
return objqa_AnswerVer[strOutFldName].ToString();
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
int intRecCount = clsqa_AnswerVerDA.GetRecCount(strTabName);
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
int intRecCount = clsqa_AnswerVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsqa_AnswerVerDA.GetRecCount();
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
int intRecCount = clsqa_AnswerVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objqa_AnswerVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsqa_AnswerVerEN objqa_AnswerVerCond)
{
List<clsqa_AnswerVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsqa_AnswerVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conqa_AnswerVer.AttributeName)
{
if (objqa_AnswerVerCond.IsUpdated(strFldName) == false) continue;
if (objqa_AnswerVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_AnswerVerCond[strFldName].ToString());
}
else
{
if (objqa_AnswerVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objqa_AnswerVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_AnswerVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objqa_AnswerVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objqa_AnswerVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objqa_AnswerVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objqa_AnswerVerCond[strFldName]));
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
 List<string> arrList = clsqa_AnswerVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = qa_AnswerVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = qa_AnswerVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = qa_AnswerVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsqa_AnswerVerDA.SetFldValue(clsqa_AnswerVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = qa_AnswerVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsqa_AnswerVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsqa_AnswerVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsqa_AnswerVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[qa_AnswerVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**问答历史主键*/ 
 strCreateTabCode.Append(" AnswerVId bigint primary key identity, "); 
 // /**回答Id*/ 
 strCreateTabCode.Append(" AnswerId char(10) not Null, "); 
 // /**提问Id*/ 
 strCreateTabCode.Append(" QuestionsId char(8) not Null, "); 
 // /**答案内容*/ 
 strCreateTabCode.Append(" AnswerContent text Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**评分类型*/ 
 strCreateTabCode.Append(" ScoreType char(1) Null, "); 
 // /**是否正确*/ 
 strCreateTabCode.Append(" IsRight bit Null, "); 
 // /**父节点Id*/ 
 strCreateTabCode.Append(" ParentId char(10) Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**是否推荐*/ 
 strCreateTabCode.Append(" IsRecommend bit Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**答案类型ID*/ 
 strCreateTabCode.Append(" AnswerTypeId char(2) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 答疑回答历史V(qa_AnswerVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4qa_AnswerVer : clsCommFun4BL
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
clsqa_AnswerVerBL.ReFreshThisCache();
}
}

}