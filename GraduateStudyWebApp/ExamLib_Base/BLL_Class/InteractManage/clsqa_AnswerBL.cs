
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerBL
 表名:qa_Answer(01120641)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:11
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
public static class  clsqa_AnswerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_AnswerEN GetObj(this K_AnswerId_qa_Answer myKey)
{
clsqa_AnswerEN objqa_AnswerEN = clsqa_AnswerBL.qa_AnswerDA.GetObjByAnswerId(myKey.Value);
return objqa_AnswerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_AnswerEN) == false)
{
var strMsg = string.Format("记录已经存在!答案内容 = [{0}],提问Id = [{1}],修改人 = [{2}]的数据已经存在!(in clsqa_AnswerBL.AddNewRecord)", objqa_AnswerEN.AnswerContent,objqa_AnswerEN.QuestionsId,objqa_AnswerEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true || clsqa_AnswerBL.IsExist(objqa_AnswerEN.AnswerId) == true)
 {
     objqa_AnswerEN.AnswerId = clsqa_AnswerBL.GetMaxStrId_S();
 }
bool bolResult = clsqa_AnswerBL.qa_AnswerDA.AddNewRecordBySQL2(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
public static bool AddRecordEx(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsqa_AnswerBL.IsExist(objqa_AnswerEN.AnswerId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objqa_AnswerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objqa_AnswerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(答案内容(AnswerContent)=[{0}],提问Id(QuestionsId)=[{1}],修改人(UpdUser)=[{2}])已经存在,不能重复!", objqa_AnswerEN.AnswerContent, objqa_AnswerEN.QuestionsId, objqa_AnswerEN.UpdUser);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true || clsqa_AnswerBL.IsExist(objqa_AnswerEN.AnswerId) == true)
 {
     objqa_AnswerEN.AnswerId = clsqa_AnswerBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objqa_AnswerEN.AddNewRecord();
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_AnswerEN) == false)
{
var strMsg = string.Format("记录已经存在!答案内容 = [{0}],提问Id = [{1}],修改人 = [{2}]的数据已经存在!(in clsqa_AnswerBL.AddNewRecordWithMaxId)", objqa_AnswerEN.AnswerContent,objqa_AnswerEN.QuestionsId,objqa_AnswerEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true || clsqa_AnswerBL.IsExist(objqa_AnswerEN.AnswerId) == true)
 {
     objqa_AnswerEN.AnswerId = clsqa_AnswerBL.GetMaxStrId_S();
 }
string strAnswerId = clsqa_AnswerBL.qa_AnswerDA.AddNewRecordBySQL2WithReturnKey(objqa_AnswerEN);
     objqa_AnswerEN.AnswerId = strAnswerId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
}
return strAnswerId;
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objqa_AnswerEN) == false)
{
var strMsg = string.Format("记录已经存在!答案内容 = [{0}],提问Id = [{1}],修改人 = [{2}]的数据已经存在!(in clsqa_AnswerBL.AddNewRecordWithReturnKey)", objqa_AnswerEN.AnswerContent,objqa_AnswerEN.QuestionsId,objqa_AnswerEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true || clsqa_AnswerBL.IsExist(objqa_AnswerEN.AnswerId) == true)
 {
     objqa_AnswerEN.AnswerId = clsqa_AnswerBL.GetMaxStrId_S();
 }
string strKey = clsqa_AnswerBL.qa_AnswerDA.AddNewRecordBySQL2WithReturnKey(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetAnswerId(this clsqa_AnswerEN objqa_AnswerEN, string strAnswerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerId, 10, conqa_Answer.AnswerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerId, 10, conqa_Answer.AnswerId);
}
objqa_AnswerEN.AnswerId = strAnswerId; //回答Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.AnswerId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.AnswerId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.AnswerId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetQuestionsId(this clsqa_AnswerEN objqa_AnswerEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsId, conqa_Answer.QuestionsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsId, 8, conqa_Answer.QuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, conqa_Answer.QuestionsId);
}
objqa_AnswerEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.QuestionsId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.QuestionsId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.QuestionsId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetAnswerContent(this clsqa_AnswerEN objqa_AnswerEN, string strAnswerContent, string strComparisonOp="")
	{
objqa_AnswerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.AnswerContent) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.AnswerContent, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.AnswerContent] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetScore(this clsqa_AnswerEN objqa_AnswerEN, float? fltScore, string strComparisonOp="")
	{
objqa_AnswerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.Score) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.Score, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.Score] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetScoreType(this clsqa_AnswerEN objqa_AnswerEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, conqa_Answer.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, conqa_Answer.ScoreType);
}
objqa_AnswerEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.ScoreType) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.ScoreType, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.ScoreType] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetIsRight(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsRight, string strComparisonOp="")
	{
objqa_AnswerEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.IsRight) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.IsRight, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.IsRight] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetParentId(this clsqa_AnswerEN objqa_AnswerEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, conqa_Answer.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, conqa_Answer.ParentId);
}
objqa_AnswerEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.ParentId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.ParentId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.ParentId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetVoteCount(this clsqa_AnswerEN objqa_AnswerEN, int? intVoteCount, string strComparisonOp="")
	{
objqa_AnswerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.VoteCount) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.VoteCount, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.VoteCount] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetIsRecommend(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsRecommend, string strComparisonOp="")
	{
objqa_AnswerEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.IsRecommend) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.IsRecommend, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.IsRecommend] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetTopicId(this clsqa_AnswerEN objqa_AnswerEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, conqa_Answer.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conqa_Answer.TopicId);
}
objqa_AnswerEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.TopicId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.TopicId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.TopicId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetAnswerTypeId(this clsqa_AnswerEN objqa_AnswerEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conqa_Answer.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conqa_Answer.AnswerTypeId);
}
objqa_AnswerEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.AnswerTypeId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.AnswerTypeId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.AnswerTypeId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetIsSubmit(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objqa_AnswerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.IsSubmit) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.IsSubmit, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.IsSubmit] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetAppraiseCount(this clsqa_AnswerEN objqa_AnswerEN, int? intAppraiseCount, string strComparisonOp="")
	{
objqa_AnswerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.AppraiseCount) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.AppraiseCount, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.AppraiseCount] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetStuScore(this clsqa_AnswerEN objqa_AnswerEN, float? fltStuScore, string strComparisonOp="")
	{
objqa_AnswerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.StuScore) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.StuScore, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.StuScore] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetTeaScore(this clsqa_AnswerEN objqa_AnswerEN, float? fltTeaScore, string strComparisonOp="")
	{
objqa_AnswerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.TeaScore) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.TeaScore, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.TeaScore] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetCreateDate(this clsqa_AnswerEN objqa_AnswerEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conqa_Answer.CreateDate);
}
objqa_AnswerEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.CreateDate) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.CreateDate, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.CreateDate] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetIdCurrEduCls(this clsqa_AnswerEN objqa_AnswerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conqa_Answer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conqa_Answer.IdCurrEduCls);
}
objqa_AnswerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.IdCurrEduCls) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.IdCurrEduCls, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.IdCurrEduCls] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetUpdUser(this clsqa_AnswerEN objqa_AnswerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conqa_Answer.UpdUser);
}
objqa_AnswerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.UpdUser) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.UpdUser, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.UpdUser] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetUpdDate(this clsqa_AnswerEN objqa_AnswerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conqa_Answer.UpdDate);
}
objqa_AnswerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.UpdDate) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.UpdDate, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.UpdDate] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsqa_AnswerEN SetMemo(this clsqa_AnswerEN objqa_AnswerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conqa_Answer.Memo);
}
objqa_AnswerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.Memo) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.Memo, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.Memo] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsqa_AnswerEN objqa_AnswerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objqa_AnswerEN.CheckPropertyNew();
clsqa_AnswerEN objqa_AnswerCond = new clsqa_AnswerEN();
string strCondition = objqa_AnswerCond
.SetAnswerId(objqa_AnswerEN.AnswerId, "<>")
.SetAnswerContent(objqa_AnswerEN.AnswerContent, "=")
.SetQuestionsId(objqa_AnswerEN.QuestionsId, "=")
.SetUpdUser(objqa_AnswerEN.UpdUser, "=")
.GetCombineCondition();
objqa_AnswerEN._IsCheckProperty = true;
bool bolIsExist = clsqa_AnswerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(AnswerContent_QuestionsId_UpdUser)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objqa_AnswerEN.Update();
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
 /// <param name = "objqa_Answer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsqa_AnswerEN objqa_Answer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsqa_AnswerEN objqa_AnswerCond = new clsqa_AnswerEN();
string strCondition = objqa_AnswerCond
.SetAnswerContent(objqa_Answer.AnswerContent, "=")
.SetQuestionsId(objqa_Answer.QuestionsId, "=")
.SetUpdUser(objqa_Answer.UpdUser, "=")
.GetCombineCondition();
objqa_Answer._IsCheckProperty = true;
bool bolIsExist = clsqa_AnswerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objqa_Answer.AnswerId = clsqa_AnswerBL.GetFirstID_S(strCondition);
objqa_Answer.UpdateWithCondition(strCondition);
}
else
{
objqa_Answer.AnswerId = clsqa_AnswerBL.GetMaxStrId_S();
objqa_Answer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_AnswerEN objqa_AnswerEN)
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsqa_AnswerBL.qa_AnswerDA.UpdateBySql2(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_AnswerEN objqa_AnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsqa_AnswerBL.qa_AnswerDA.UpdateBySql2(objqa_AnswerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_AnswerEN objqa_AnswerEN, string strWhereCond)
{
try
{
bool bolResult = clsqa_AnswerBL.qa_AnswerDA.UpdateBySqlWithCondition(objqa_AnswerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_AnswerEN objqa_AnswerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsqa_AnswerBL.qa_AnswerDA.UpdateBySqlWithConditionTransaction(objqa_AnswerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "strAnswerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsqa_AnswerEN objqa_AnswerEN)
{
try
{
int intRecNum = clsqa_AnswerBL.qa_AnswerDA.DelRecord(objqa_AnswerEN.AnswerId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerENS">源对象</param>
 /// <param name = "objqa_AnswerENT">目标对象</param>
 public static void CopyTo(this clsqa_AnswerEN objqa_AnswerENS, clsqa_AnswerEN objqa_AnswerENT)
{
try
{
objqa_AnswerENT.AnswerId = objqa_AnswerENS.AnswerId; //回答Id
objqa_AnswerENT.QuestionsId = objqa_AnswerENS.QuestionsId; //提问Id
objqa_AnswerENT.AnswerContent = objqa_AnswerENS.AnswerContent; //答案内容
objqa_AnswerENT.Score = objqa_AnswerENS.Score; //评分
objqa_AnswerENT.ScoreType = objqa_AnswerENS.ScoreType; //评分类型
objqa_AnswerENT.IsRight = objqa_AnswerENS.IsRight; //是否正确
objqa_AnswerENT.ParentId = objqa_AnswerENS.ParentId; //父节点Id
objqa_AnswerENT.VoteCount = objqa_AnswerENS.VoteCount; //点赞计数
objqa_AnswerENT.IsRecommend = objqa_AnswerENS.IsRecommend; //是否推荐
objqa_AnswerENT.TopicId = objqa_AnswerENS.TopicId; //主题Id
objqa_AnswerENT.AnswerTypeId = objqa_AnswerENS.AnswerTypeId; //答案类型ID
objqa_AnswerENT.IsSubmit = objqa_AnswerENS.IsSubmit; //是否提交
objqa_AnswerENT.AppraiseCount = objqa_AnswerENS.AppraiseCount; //评论数
objqa_AnswerENT.StuScore = objqa_AnswerENS.StuScore; //学生平均分
objqa_AnswerENT.TeaScore = objqa_AnswerENS.TeaScore; //教师评分
objqa_AnswerENT.CreateDate = objqa_AnswerENS.CreateDate; //建立日期
objqa_AnswerENT.IdCurrEduCls = objqa_AnswerENS.IdCurrEduCls; //教学班流水号
objqa_AnswerENT.UpdUser = objqa_AnswerENS.UpdUser; //修改人
objqa_AnswerENT.UpdDate = objqa_AnswerENS.UpdDate; //修改日期
objqa_AnswerENT.Memo = objqa_AnswerENS.Memo; //备注
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
 /// <param name = "objqa_AnswerENS">源对象</param>
 /// <returns>目标对象=>clsqa_AnswerEN:objqa_AnswerENT</returns>
 public static clsqa_AnswerEN CopyTo(this clsqa_AnswerEN objqa_AnswerENS)
{
try
{
 clsqa_AnswerEN objqa_AnswerENT = new clsqa_AnswerEN()
{
AnswerId = objqa_AnswerENS.AnswerId, //回答Id
QuestionsId = objqa_AnswerENS.QuestionsId, //提问Id
AnswerContent = objqa_AnswerENS.AnswerContent, //答案内容
Score = objqa_AnswerENS.Score, //评分
ScoreType = objqa_AnswerENS.ScoreType, //评分类型
IsRight = objqa_AnswerENS.IsRight, //是否正确
ParentId = objqa_AnswerENS.ParentId, //父节点Id
VoteCount = objqa_AnswerENS.VoteCount, //点赞计数
IsRecommend = objqa_AnswerENS.IsRecommend, //是否推荐
TopicId = objqa_AnswerENS.TopicId, //主题Id
AnswerTypeId = objqa_AnswerENS.AnswerTypeId, //答案类型ID
IsSubmit = objqa_AnswerENS.IsSubmit, //是否提交
AppraiseCount = objqa_AnswerENS.AppraiseCount, //评论数
StuScore = objqa_AnswerENS.StuScore, //学生平均分
TeaScore = objqa_AnswerENS.TeaScore, //教师评分
CreateDate = objqa_AnswerENS.CreateDate, //建立日期
IdCurrEduCls = objqa_AnswerENS.IdCurrEduCls, //教学班流水号
UpdUser = objqa_AnswerENS.UpdUser, //修改人
UpdDate = objqa_AnswerENS.UpdDate, //修改日期
Memo = objqa_AnswerENS.Memo, //备注
};
 return objqa_AnswerENT;
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
public static void CheckPropertyNew(this clsqa_AnswerEN objqa_AnswerEN)
{
 clsqa_AnswerBL.qa_AnswerDA.CheckPropertyNew(objqa_AnswerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsqa_AnswerEN objqa_AnswerEN)
{
 clsqa_AnswerBL.qa_AnswerDA.CheckProperty4Condition(objqa_AnswerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsqa_AnswerEN objqa_AnswerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objqa_AnswerCond.IsUpdated(conqa_Answer.AnswerId) == true)
{
string strComparisonOpAnswerId = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.AnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.AnswerId, objqa_AnswerCond.AnswerId, strComparisonOpAnswerId);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.QuestionsId) == true)
{
string strComparisonOpQuestionsId = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.QuestionsId, objqa_AnswerCond.QuestionsId, strComparisonOpQuestionsId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objqa_AnswerCond.IsUpdated(conqa_Answer.Score) == true)
{
string strComparisonOpScore = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.Score, objqa_AnswerCond.Score, strComparisonOpScore);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.ScoreType) == true)
{
string strComparisonOpScoreType = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.ScoreType, objqa_AnswerCond.ScoreType, strComparisonOpScoreType);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.IsRight) == true)
{
if (objqa_AnswerCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Answer.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Answer.IsRight);
}
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.ParentId) == true)
{
string strComparisonOpParentId = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.ParentId, objqa_AnswerCond.ParentId, strComparisonOpParentId);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.VoteCount) == true)
{
string strComparisonOpVoteCount = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.VoteCount, objqa_AnswerCond.VoteCount, strComparisonOpVoteCount);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.IsRecommend) == true)
{
if (objqa_AnswerCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Answer.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Answer.IsRecommend);
}
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.TopicId) == true)
{
string strComparisonOpTopicId = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.TopicId, objqa_AnswerCond.TopicId, strComparisonOpTopicId);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.AnswerTypeId, objqa_AnswerCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.IsSubmit) == true)
{
if (objqa_AnswerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Answer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Answer.IsSubmit);
}
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.AppraiseCount, objqa_AnswerCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.StuScore) == true)
{
string strComparisonOpStuScore = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.StuScore, objqa_AnswerCond.StuScore, strComparisonOpStuScore);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.TeaScore) == true)
{
string strComparisonOpTeaScore = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.TeaScore, objqa_AnswerCond.TeaScore, strComparisonOpTeaScore);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.CreateDate) == true)
{
string strComparisonOpCreateDate = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.CreateDate, objqa_AnswerCond.CreateDate, strComparisonOpCreateDate);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.IdCurrEduCls, objqa_AnswerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.UpdUser) == true)
{
string strComparisonOpUpdUser = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.UpdUser, objqa_AnswerCond.UpdUser, strComparisonOpUpdUser);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.UpdDate) == true)
{
string strComparisonOpUpdDate = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.UpdDate, objqa_AnswerCond.UpdDate, strComparisonOpUpdDate);
}
if (objqa_AnswerCond.IsUpdated(conqa_Answer.Memo) == true)
{
string strComparisonOpMemo = objqa_AnswerCond.dicFldComparisonOp[conqa_Answer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.Memo, objqa_AnswerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--qa_Answer(答疑回答), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:AnswerContent_QuestionsId_UpdUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objqa_AnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsqa_AnswerEN objqa_AnswerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objqa_AnswerEN == null) return true;
if (objqa_AnswerEN.AnswerId == null || objqa_AnswerEN.AnswerId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objqa_AnswerEN.AnswerContent == null)
{
 sbCondition.AppendFormat(" and AnswerContent is null", objqa_AnswerEN.AnswerContent);
}
else
{
 sbCondition.AppendFormat(" and AnswerContent = '{0}'", objqa_AnswerEN.AnswerContent);
}
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objqa_AnswerEN.QuestionsId);
 if (objqa_AnswerEN.UpdUser == null)
{
 sbCondition.AppendFormat(" and UpdUser is null", objqa_AnswerEN.UpdUser);
}
else
{
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objqa_AnswerEN.UpdUser);
}
if (clsqa_AnswerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("AnswerId !=  '{0}'", objqa_AnswerEN.AnswerId);
 sbCondition.AppendFormat(" and AnswerContent = '{0}'", objqa_AnswerEN.AnswerContent);
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objqa_AnswerEN.QuestionsId);
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objqa_AnswerEN.UpdUser);
if (clsqa_AnswerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--qa_Answer(答疑回答), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:AnswerContent_QuestionsId_UpdUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objqa_AnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsqa_AnswerEN objqa_AnswerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objqa_AnswerEN == null) return "";
if (objqa_AnswerEN.AnswerId == null || objqa_AnswerEN.AnswerId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objqa_AnswerEN.AnswerContent == null)
{
 sbCondition.AppendFormat(" and AnswerContent is null", objqa_AnswerEN.AnswerContent);
}
else
{
 sbCondition.AppendFormat(" and AnswerContent = '{0}'", objqa_AnswerEN.AnswerContent);
}
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objqa_AnswerEN.QuestionsId);
 if (objqa_AnswerEN.UpdUser == null)
{
 sbCondition.AppendFormat(" and UpdUser is null", objqa_AnswerEN.UpdUser);
}
else
{
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objqa_AnswerEN.UpdUser);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AnswerId !=  '{0}'", objqa_AnswerEN.AnswerId);
 sbCondition.AppendFormat(" and AnswerContent = '{0}'", objqa_AnswerEN.AnswerContent);
 sbCondition.AppendFormat(" and QuestionsId = '{0}'", objqa_AnswerEN.QuestionsId);
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objqa_AnswerEN.UpdUser);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_qa_Answer
{
public virtual bool UpdRelaTabDate(string strAnswerId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 答疑回答(qa_Answer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsqa_AnswerBL
{
public static RelatedActions_qa_Answer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsqa_AnswerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsqa_AnswerDA qa_AnswerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsqa_AnswerDA();
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
 public clsqa_AnswerBL()
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
if (string.IsNullOrEmpty(clsqa_AnswerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsqa_AnswerEN._ConnectString);
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
public static DataTable GetDataTable_qa_Answer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = qa_AnswerDA.GetDataTable_qa_Answer(strWhereCond);
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
objDT = qa_AnswerDA.GetDataTable(strWhereCond);
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
objDT = qa_AnswerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = qa_AnswerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = qa_AnswerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = qa_AnswerDA.GetDataTable_Top(objTopPara);
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
objDT = qa_AnswerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = qa_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = qa_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsqa_AnswerEN> GetObjLstByAnswerIdLst(List<string> arrAnswerIdLst)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrAnswerIdLst, true);
 string strWhereCond = string.Format("AnswerId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsqa_AnswerEN> GetObjLstByAnswerIdLstCache(List<string> arrAnswerIdLst, string strTopicId)
{
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName, strTopicId);
List<clsqa_AnswerEN> arrqa_AnswerObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsqa_AnswerEN> arrqa_AnswerObjLst_Sel =
arrqa_AnswerObjLstCache
.Where(x => arrAnswerIdLst.Contains(x.AnswerId));
return arrqa_AnswerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerEN> GetObjLst(string strWhereCond)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
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
public static List<clsqa_AnswerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objqa_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsqa_AnswerEN> GetSubObjLstCache(clsqa_AnswerEN objqa_AnswerCond)
{
 string strTopicId = objqa_AnswerCond.TopicId;
 if (string.IsNullOrEmpty(strTopicId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsqa_AnswerBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsqa_AnswerEN> arrObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsqa_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conqa_Answer.AttributeName)
{
if (objqa_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objqa_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_AnswerCond[strFldName].ToString());
}
else
{
if (objqa_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objqa_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objqa_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objqa_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objqa_AnswerCond[strFldName]));
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
public static List<clsqa_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
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
public static List<clsqa_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
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
List<clsqa_AnswerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsqa_AnswerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsqa_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
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
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
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
public static List<clsqa_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsqa_AnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsqa_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
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
public static List<clsqa_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsqa_AnswerEN> arrObjLst = new List<clsqa_AnswerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsqa_AnswerEN objqa_AnswerEN = new clsqa_AnswerEN();
try
{
objqa_AnswerEN.AnswerId = objRow[conqa_Answer.AnswerId].ToString().Trim(); //回答Id
objqa_AnswerEN.QuestionsId = objRow[conqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objqa_AnswerEN.AnswerContent = objRow[conqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[conqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objqa_AnswerEN.Score = objRow[conqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.Score].ToString().Trim()); //评分
objqa_AnswerEN.ScoreType = objRow[conqa_Answer.ScoreType] == DBNull.Value ? null : objRow[conqa_Answer.ScoreType].ToString().Trim(); //评分类型
objqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRight].ToString().Trim()); //是否正确
objqa_AnswerEN.ParentId = objRow[conqa_Answer.ParentId] == DBNull.Value ? null : objRow[conqa_Answer.ParentId].ToString().Trim(); //父节点Id
objqa_AnswerEN.VoteCount = objRow[conqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objqa_AnswerEN.TopicId = objRow[conqa_Answer.TopicId] == DBNull.Value ? null : objRow[conqa_Answer.TopicId].ToString().Trim(); //主题Id
objqa_AnswerEN.AnswerTypeId = objRow[conqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objqa_AnswerEN.AppraiseCount = objRow[conqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objqa_AnswerEN.StuScore = objRow[conqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.StuScore].ToString().Trim()); //学生平均分
objqa_AnswerEN.TeaScore = objRow[conqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conqa_Answer.TeaScore].ToString().Trim()); //教师评分
objqa_AnswerEN.CreateDate = objRow[conqa_Answer.CreateDate] == DBNull.Value ? null : objRow[conqa_Answer.CreateDate].ToString().Trim(); //建立日期
objqa_AnswerEN.IdCurrEduCls = objRow[conqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[conqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objqa_AnswerEN.UpdUser = objRow[conqa_Answer.UpdUser] == DBNull.Value ? null : objRow[conqa_Answer.UpdUser].ToString().Trim(); //修改人
objqa_AnswerEN.UpdDate = objRow[conqa_Answer.UpdDate] == DBNull.Value ? null : objRow[conqa_Answer.UpdDate].ToString().Trim(); //修改日期
objqa_AnswerEN.Memo = objRow[conqa_Answer.Memo] == DBNull.Value ? null : objRow[conqa_Answer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objqa_AnswerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objqa_AnswerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getqa_Answer(ref clsqa_AnswerEN objqa_AnswerEN)
{
bool bolResult = qa_AnswerDA.Getqa_Answer(ref objqa_AnswerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_AnswerEN GetObjByAnswerId(string strAnswerId)
{
if (strAnswerId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strAnswerId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strAnswerId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strAnswerId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsqa_AnswerEN objqa_AnswerEN = qa_AnswerDA.GetObjByAnswerId(strAnswerId);
return objqa_AnswerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsqa_AnswerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsqa_AnswerEN objqa_AnswerEN = qa_AnswerDA.GetFirstObj(strWhereCond);
 return objqa_AnswerEN;
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
public static clsqa_AnswerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsqa_AnswerEN objqa_AnswerEN = qa_AnswerDA.GetObjByDataRow(objRow);
 return objqa_AnswerEN;
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
public static clsqa_AnswerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsqa_AnswerEN objqa_AnswerEN = qa_AnswerDA.GetObjByDataRow(objRow);
 return objqa_AnswerEN;
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
 /// <param name = "strAnswerId">所给的关键字</param>
 /// <param name = "lstqa_AnswerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_AnswerEN GetObjByAnswerIdFromList(string strAnswerId, List<clsqa_AnswerEN> lstqa_AnswerObjLst)
{
foreach (clsqa_AnswerEN objqa_AnswerEN in lstqa_AnswerObjLst)
{
if (objqa_AnswerEN.AnswerId == strAnswerId)
{
return objqa_AnswerEN;
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
 string strMaxAnswerId;
 try
 {
 strMaxAnswerId = clsqa_AnswerDA.GetMaxStrId();
 return strMaxAnswerId;
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
 string strAnswerId;
 try
 {
 strAnswerId = new clsqa_AnswerDA().GetFirstID(strWhereCond);
 return strAnswerId;
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
 arrList = qa_AnswerDA.GetID(strWhereCond);
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
bool bolIsExist = qa_AnswerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strAnswerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strAnswerId)
{
if (string.IsNullOrEmpty(strAnswerId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strAnswerId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = qa_AnswerDA.IsExist(strAnswerId);
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
 bolIsExist = clsqa_AnswerDA.IsExistTable();
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
 bolIsExist = qa_AnswerDA.IsExistTable(strTabName);
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsqa_AnswerEN objqa_AnswerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objqa_AnswerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!答案内容 = [{0}],提问Id = [{1}],修改人 = [{2}]的数据已经存在!(in clsqa_AnswerBL.AddNewRecordBySql2)", objqa_AnswerEN.AnswerContent,objqa_AnswerEN.QuestionsId,objqa_AnswerEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true || clsqa_AnswerBL.IsExist(objqa_AnswerEN.AnswerId) == true)
 {
     objqa_AnswerEN.AnswerId = clsqa_AnswerBL.GetMaxStrId_S();
 }
bool bolResult = qa_AnswerDA.AddNewRecordBySQL2(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsqa_AnswerEN objqa_AnswerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objqa_AnswerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!答案内容 = [{0}],提问Id = [{1}],修改人 = [{2}]的数据已经存在!(in clsqa_AnswerBL.AddNewRecordBySql2WithReturnKey)", objqa_AnswerEN.AnswerContent,objqa_AnswerEN.QuestionsId,objqa_AnswerEN.UpdUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true || clsqa_AnswerBL.IsExist(objqa_AnswerEN.AnswerId) == true)
 {
     objqa_AnswerEN.AnswerId = clsqa_AnswerBL.GetMaxStrId_S();
 }
string strKey = qa_AnswerDA.AddNewRecordBySQL2WithReturnKey(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsqa_AnswerEN objqa_AnswerEN)
{
try
{
bool bolResult = qa_AnswerDA.Update(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsqa_AnswerEN objqa_AnswerEN)
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = qa_AnswerDA.UpdateBySql2(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerBL.ReFreshCache(objqa_AnswerEN.TopicId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "strAnswerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strAnswerId)
{
try
{
 clsqa_AnswerEN objqa_AnswerEN = clsqa_AnswerBL.GetObjByAnswerId(strAnswerId);

if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(objqa_AnswerEN.AnswerId, "SetUpdDate");
}
if (objqa_AnswerEN != null)
{
int intRecNum = qa_AnswerDA.DelRecord(strAnswerId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objqa_AnswerEN.TopicId);
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
/// <param name="strAnswerId">表关键字</param>
 /// <param name = "strTopicId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strAnswerId , string strTopicId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsqa_AnswerDA.GetSpecSQLObj();
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
//删除与表:[qa_Answer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conqa_Answer.AnswerId,
//strAnswerId);
//        clsqa_AnswerBL.Delqa_AnswersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsqa_AnswerBL.DelRecord(strAnswerId, strTopicId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsqa_AnswerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strAnswerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strAnswerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strAnswerId, string strTopicId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsqa_AnswerBL.relatedActions != null)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(strAnswerId, "UpdRelaTabDate");
}
bool bolResult = qa_AnswerDA.DelRecord(strAnswerId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strTopicId);
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
 /// <param name = "arrAnswerIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delqa_Answers(List<string> arrAnswerIdLst)
{
if (arrAnswerIdLst.Count == 0) return 0;
try
{
if (clsqa_AnswerBL.relatedActions != null)
{
foreach (var strAnswerId in arrAnswerIdLst)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(strAnswerId, "UpdRelaTabDate");
}
}
 clsqa_AnswerEN objqa_AnswerEN = clsqa_AnswerBL.GetObjByAnswerId(arrAnswerIdLst[0]);
int intDelRecNum = qa_AnswerDA.Delqa_Answer(arrAnswerIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objqa_AnswerEN.TopicId);
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
public static int Delqa_AnswersByCond(string strWhereCond)
{
try
{
if (clsqa_AnswerBL.relatedActions != null)
{
List<string> arrAnswerId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strAnswerId in arrAnswerId)
{
clsqa_AnswerBL.relatedActions.UpdRelaTabDate(strAnswerId, "UpdRelaTabDate");
}
}
List<string> arrTopicId = GetFldValue(conqa_Answer.TopicId, strWhereCond);
int intRecNum = qa_AnswerDA.Delqa_Answer(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrTopicId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[qa_Answer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strAnswerId">表关键字</param>
 /// <param name = "strTopicId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strAnswerId, string strTopicId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsqa_AnswerDA.GetSpecSQLObj();
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
//删除与表:[qa_Answer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsqa_AnswerBL.DelRecord(strAnswerId, strTopicId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsqa_AnswerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strAnswerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objqa_AnswerENS">源对象</param>
 /// <param name = "objqa_AnswerENT">目标对象</param>
 public static void CopyTo(clsqa_AnswerEN objqa_AnswerENS, clsqa_AnswerEN objqa_AnswerENT)
{
try
{
objqa_AnswerENT.AnswerId = objqa_AnswerENS.AnswerId; //回答Id
objqa_AnswerENT.QuestionsId = objqa_AnswerENS.QuestionsId; //提问Id
objqa_AnswerENT.AnswerContent = objqa_AnswerENS.AnswerContent; //答案内容
objqa_AnswerENT.Score = objqa_AnswerENS.Score; //评分
objqa_AnswerENT.ScoreType = objqa_AnswerENS.ScoreType; //评分类型
objqa_AnswerENT.IsRight = objqa_AnswerENS.IsRight; //是否正确
objqa_AnswerENT.ParentId = objqa_AnswerENS.ParentId; //父节点Id
objqa_AnswerENT.VoteCount = objqa_AnswerENS.VoteCount; //点赞计数
objqa_AnswerENT.IsRecommend = objqa_AnswerENS.IsRecommend; //是否推荐
objqa_AnswerENT.TopicId = objqa_AnswerENS.TopicId; //主题Id
objqa_AnswerENT.AnswerTypeId = objqa_AnswerENS.AnswerTypeId; //答案类型ID
objqa_AnswerENT.IsSubmit = objqa_AnswerENS.IsSubmit; //是否提交
objqa_AnswerENT.AppraiseCount = objqa_AnswerENS.AppraiseCount; //评论数
objqa_AnswerENT.StuScore = objqa_AnswerENS.StuScore; //学生平均分
objqa_AnswerENT.TeaScore = objqa_AnswerENS.TeaScore; //教师评分
objqa_AnswerENT.CreateDate = objqa_AnswerENS.CreateDate; //建立日期
objqa_AnswerENT.IdCurrEduCls = objqa_AnswerENS.IdCurrEduCls; //教学班流水号
objqa_AnswerENT.UpdUser = objqa_AnswerENS.UpdUser; //修改人
objqa_AnswerENT.UpdDate = objqa_AnswerENS.UpdDate; //修改日期
objqa_AnswerENT.Memo = objqa_AnswerENS.Memo; //备注
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
 /// <param name = "objqa_AnswerEN">源简化对象</param>
 public static void SetUpdFlag(clsqa_AnswerEN objqa_AnswerEN)
{
try
{
objqa_AnswerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objqa_AnswerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conqa_Answer.AnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.AnswerId = objqa_AnswerEN.AnswerId; //回答Id
}
if (arrFldSet.Contains(conqa_Answer.QuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.QuestionsId = objqa_AnswerEN.QuestionsId; //提问Id
}
if (arrFldSet.Contains(conqa_Answer.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.AnswerContent = objqa_AnswerEN.AnswerContent == "[null]" ? null :  objqa_AnswerEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(conqa_Answer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.Score = objqa_AnswerEN.Score; //评分
}
if (arrFldSet.Contains(conqa_Answer.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.ScoreType = objqa_AnswerEN.ScoreType == "[null]" ? null :  objqa_AnswerEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(conqa_Answer.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.IsRight = objqa_AnswerEN.IsRight; //是否正确
}
if (arrFldSet.Contains(conqa_Answer.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.ParentId = objqa_AnswerEN.ParentId == "[null]" ? null :  objqa_AnswerEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(conqa_Answer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.VoteCount = objqa_AnswerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conqa_Answer.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.IsRecommend = objqa_AnswerEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(conqa_Answer.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.TopicId = objqa_AnswerEN.TopicId == "[null]" ? null :  objqa_AnswerEN.TopicId; //主题Id
}
if (arrFldSet.Contains(conqa_Answer.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.AnswerTypeId = objqa_AnswerEN.AnswerTypeId == "[null]" ? null :  objqa_AnswerEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(conqa_Answer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.IsSubmit = objqa_AnswerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conqa_Answer.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.AppraiseCount = objqa_AnswerEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conqa_Answer.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.StuScore = objqa_AnswerEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conqa_Answer.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.TeaScore = objqa_AnswerEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conqa_Answer.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.CreateDate = objqa_AnswerEN.CreateDate == "[null]" ? null :  objqa_AnswerEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conqa_Answer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.IdCurrEduCls = objqa_AnswerEN.IdCurrEduCls == "[null]" ? null :  objqa_AnswerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conqa_Answer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.UpdUser = objqa_AnswerEN.UpdUser == "[null]" ? null :  objqa_AnswerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conqa_Answer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.UpdDate = objqa_AnswerEN.UpdDate == "[null]" ? null :  objqa_AnswerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conqa_Answer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objqa_AnswerEN.Memo = objqa_AnswerEN.Memo == "[null]" ? null :  objqa_AnswerEN.Memo; //备注
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
 /// <param name = "objqa_AnswerEN">源简化对象</param>
 public static void AccessFldValueNull(clsqa_AnswerEN objqa_AnswerEN)
{
try
{
if (objqa_AnswerEN.AnswerContent == "[null]") objqa_AnswerEN.AnswerContent = null; //答案内容
if (objqa_AnswerEN.ScoreType == "[null]") objqa_AnswerEN.ScoreType = null; //评分类型
if (objqa_AnswerEN.ParentId == "[null]") objqa_AnswerEN.ParentId = null; //父节点Id
if (objqa_AnswerEN.TopicId == "[null]") objqa_AnswerEN.TopicId = null; //主题Id
if (objqa_AnswerEN.AnswerTypeId == "[null]") objqa_AnswerEN.AnswerTypeId = null; //答案类型ID
if (objqa_AnswerEN.CreateDate == "[null]") objqa_AnswerEN.CreateDate = null; //建立日期
if (objqa_AnswerEN.IdCurrEduCls == "[null]") objqa_AnswerEN.IdCurrEduCls = null; //教学班流水号
if (objqa_AnswerEN.UpdUser == "[null]") objqa_AnswerEN.UpdUser = null; //修改人
if (objqa_AnswerEN.UpdDate == "[null]") objqa_AnswerEN.UpdDate = null; //修改日期
if (objqa_AnswerEN.Memo == "[null]") objqa_AnswerEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsqa_AnswerEN objqa_AnswerEN)
{
 qa_AnswerDA.CheckPropertyNew(objqa_AnswerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsqa_AnswerEN objqa_AnswerEN)
{
 qa_AnswerDA.CheckProperty4Condition(objqa_AnswerEN);
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
if (clsqa_AnswerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_AnswerBL没有刷新缓存机制(clsqa_AnswerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerId");
//if (arrqa_AnswerObjLstCache == null)
//{
//arrqa_AnswerObjLstCache = qa_AnswerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strAnswerId">所给的关键字</param>
 /// <param name = "strTopicId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_AnswerEN GetObjByAnswerIdCache(string strAnswerId, string strTopicId)
{

if (string.IsNullOrEmpty(strTopicId) == true)
{
  var strMsg = string.Format("参数:[strTopicId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strTopicId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确!(In {1})", strTopicId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName, strTopicId);
List<clsqa_AnswerEN> arrqa_AnswerObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsqa_AnswerEN> arrqa_AnswerObjLst_Sel =
arrqa_AnswerObjLstCache
.Where(x=> x.AnswerId == strAnswerId 
);
if (arrqa_AnswerObjLst_Sel.Count() == 0)
{
   clsqa_AnswerEN obj = clsqa_AnswerBL.GetObjByAnswerId(strAnswerId);
   if (obj != null)
 {
if (obj.TopicId == strTopicId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strAnswerId, strTopicId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrqa_AnswerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_AnswerEN> GetAllqa_AnswerObjLstCache(string strTopicId)
{
//获取缓存中的对象列表
List<clsqa_AnswerEN> arrqa_AnswerObjLstCache = GetObjLstCache(strTopicId); 
return arrqa_AnswerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_AnswerEN> GetObjLstCache(string strTopicId)
{

if (string.IsNullOrEmpty(strTopicId) == true)
{
  var strMsg = string.Format("参数:[strTopicId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strTopicId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确!(In {1})", strTopicId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName, strTopicId);
string strCondition = string.Format("TopicId='{0}'", strTopicId);
List<clsqa_AnswerEN> arrqa_AnswerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrqa_AnswerObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strTopicId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName, strTopicId);
CacheHelper.Remove(strKey);
clsqa_AnswerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsqa_AnswerEN._RefreshTimeLst.Count == 0) return "";
return clsqa_AnswerEN._RefreshTimeLst[clsqa_AnswerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strTopicId)
{
if (string.IsNullOrEmpty(strTopicId) == true)
{
string strMsg = string.Format("缓存分类字段:[TopicId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_AnswerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName, strTopicId);
CacheHelper.Remove(strKey);
clsqa_AnswerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsqa_AnswerBL.objCommFun4BL.ReFreshCache(strTopicId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--qa_Answer(答疑回答)
 /// 唯一性条件:AnswerContent_QuestionsId_UpdUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objqa_AnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsqa_AnswerEN objqa_AnswerEN)
{
//检测记录是否存在
string strResult = qa_AnswerDA.GetUniCondStr(objqa_AnswerEN);
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
 /// <param name = "strTopicId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strAnswerId, string strTopicId)
{
if (strInFldName != conqa_Answer.AnswerId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conqa_Answer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conqa_Answer.AttributeName));
throw new Exception(strMsg);
}
var objqa_Answer = clsqa_AnswerBL.GetObjByAnswerIdCache(strAnswerId, strTopicId);
if (objqa_Answer == null) return "";
return objqa_Answer[strOutFldName].ToString();
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
int intRecCount = clsqa_AnswerDA.GetRecCount(strTabName);
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
int intRecCount = clsqa_AnswerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsqa_AnswerDA.GetRecCount();
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
int intRecCount = clsqa_AnswerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objqa_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsqa_AnswerEN objqa_AnswerCond)
{
 string strTopicId = objqa_AnswerCond.TopicId;
 if (string.IsNullOrEmpty(strTopicId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsqa_AnswerBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsqa_AnswerEN> arrObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsqa_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conqa_Answer.AttributeName)
{
if (objqa_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objqa_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_AnswerCond[strFldName].ToString());
}
else
{
if (objqa_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objqa_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objqa_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objqa_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objqa_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objqa_AnswerCond[strFldName]));
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
 List<string> arrList = clsqa_AnswerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = qa_AnswerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = qa_AnswerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = qa_AnswerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsqa_AnswerDA.SetFldValue(clsqa_AnswerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = qa_AnswerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsqa_AnswerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsqa_AnswerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsqa_AnswerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[qa_Answer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**回答Id*/ 
 strCreateTabCode.Append(" AnswerId char(10) primary key, "); 
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
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
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
 /// 答疑回答(qa_Answer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4qa_Answer : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strTopicId)
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
clsqa_AnswerBL.ReFreshThisCache(strTopicId);
}
}

}