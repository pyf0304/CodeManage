
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResearchTopicBL
 表名:ResearchTopic(01120546)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:31
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
public static class  clsResearchTopicBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsResearchTopicEN GetObj(this K_TopicId_ResearchTopic myKey)
{
clsResearchTopicEN objResearchTopicEN = clsResearchTopicBL.ResearchTopicDA.GetObjByTopicId(myKey.Value);
return objResearchTopicEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsResearchTopicEN objResearchTopicEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objResearchTopicEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}]的数据已经存在!(in clsResearchTopicBL.AddNewRecord)", objResearchTopicEN.TopicId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResearchTopicEN.TopicId) == true || clsResearchTopicBL.IsExist(objResearchTopicEN.TopicId) == true)
 {
     objResearchTopicEN.TopicId = clsResearchTopicBL.GetMaxStrId_S();
 }
bool bolResult = clsResearchTopicBL.ResearchTopicDA.AddNewRecordBySQL2(objResearchTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
public static bool AddRecordEx(this clsResearchTopicEN objResearchTopicEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsResearchTopicBL.IsExist(objResearchTopicEN.TopicId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objResearchTopicEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objResearchTopicEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主题Id(TopicId)=[{0}])已经存在,不能重复!", objResearchTopicEN.TopicId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objResearchTopicEN.TopicId) == true || clsResearchTopicBL.IsExist(objResearchTopicEN.TopicId) == true)
 {
     objResearchTopicEN.TopicId = clsResearchTopicBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objResearchTopicEN.AddNewRecord();
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsResearchTopicEN objResearchTopicEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objResearchTopicEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}]的数据已经存在!(in clsResearchTopicBL.AddNewRecordWithMaxId)", objResearchTopicEN.TopicId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResearchTopicEN.TopicId) == true || clsResearchTopicBL.IsExist(objResearchTopicEN.TopicId) == true)
 {
     objResearchTopicEN.TopicId = clsResearchTopicBL.GetMaxStrId_S();
 }
string strTopicId = clsResearchTopicBL.ResearchTopicDA.AddNewRecordBySQL2WithReturnKey(objResearchTopicEN);
     objResearchTopicEN.TopicId = strTopicId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
}
return strTopicId;
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsResearchTopicEN objResearchTopicEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objResearchTopicEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}]的数据已经存在!(in clsResearchTopicBL.AddNewRecordWithReturnKey)", objResearchTopicEN.TopicId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResearchTopicEN.TopicId) == true || clsResearchTopicBL.IsExist(objResearchTopicEN.TopicId) == true)
 {
     objResearchTopicEN.TopicId = clsResearchTopicBL.GetMaxStrId_S();
 }
string strKey = clsResearchTopicBL.ResearchTopicDA.AddNewRecordBySQL2WithReturnKey(objResearchTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetTopicId(this clsResearchTopicEN objResearchTopicEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, conResearchTopic.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conResearchTopic.TopicId);
}
objResearchTopicEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.TopicId) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.TopicId, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.TopicId] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetTopicName(this clsResearchTopicEN objResearchTopicEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, conResearchTopic.TopicName);
}
objResearchTopicEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.TopicName) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.TopicName, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.TopicName] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetTopicContent(this clsResearchTopicEN objResearchTopicEN, string strTopicContent, string strComparisonOp="")
	{
objResearchTopicEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.TopicContent) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.TopicContent, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.TopicContent] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetTopicProposePeople(this clsResearchTopicEN objResearchTopicEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, conResearchTopic.TopicProposePeople);
}
objResearchTopicEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.TopicProposePeople) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.TopicProposePeople, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.TopicProposePeople] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetOrderNum(this clsResearchTopicEN objResearchTopicEN, int? intOrderNum, string strComparisonOp="")
	{
objResearchTopicEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.OrderNum) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.OrderNum, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.OrderNum] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetIsSubmit(this clsResearchTopicEN objResearchTopicEN, bool bolIsSubmit, string strComparisonOp="")
	{
objResearchTopicEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.IsSubmit) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.IsSubmit, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.IsSubmit] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetIdCurrEduCls(this clsResearchTopicEN objResearchTopicEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conResearchTopic.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conResearchTopic.IdCurrEduCls);
}
objResearchTopicEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.IdCurrEduCls) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.IdCurrEduCls, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.IdCurrEduCls] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetUpdDate(this clsResearchTopicEN objResearchTopicEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conResearchTopic.UpdDate);
}
objResearchTopicEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.UpdDate) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.UpdDate, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.UpdDate] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetShareId(this clsResearchTopicEN objResearchTopicEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShareId, conResearchTopic.ShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, conResearchTopic.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, conResearchTopic.ShareId);
}
objResearchTopicEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.ShareId) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.ShareId, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.ShareId] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetUpdUser(this clsResearchTopicEN objResearchTopicEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conResearchTopic.UpdUser);
}
objResearchTopicEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.UpdUser) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.UpdUser, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.UpdUser] = strComparisonOp;
}
}
return objResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResearchTopicEN SetMemo(this clsResearchTopicEN objResearchTopicEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conResearchTopic.Memo);
}
objResearchTopicEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResearchTopicEN.dicFldComparisonOp.ContainsKey(conResearchTopic.Memo) == false)
{
objResearchTopicEN.dicFldComparisonOp.Add(conResearchTopic.Memo, strComparisonOp);
}
else
{
objResearchTopicEN.dicFldComparisonOp[conResearchTopic.Memo] = strComparisonOp;
}
}
return objResearchTopicEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsResearchTopicEN objResearchTopicEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objResearchTopicEN.CheckPropertyNew();
clsResearchTopicEN objResearchTopicCond = new clsResearchTopicEN();
string strCondition = objResearchTopicCond
.SetTopicId(objResearchTopicEN.TopicId, "<>")
.SetTopicId(objResearchTopicEN.TopicId, "=")
.GetCombineCondition();
objResearchTopicEN._IsCheckProperty = true;
bool bolIsExist = clsResearchTopicBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TopicId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objResearchTopicEN.Update();
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
 /// <param name = "objResearchTopic">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsResearchTopicEN objResearchTopic)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsResearchTopicEN objResearchTopicCond = new clsResearchTopicEN();
string strCondition = objResearchTopicCond
.SetTopicId(objResearchTopic.TopicId, "=")
.GetCombineCondition();
objResearchTopic._IsCheckProperty = true;
bool bolIsExist = clsResearchTopicBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objResearchTopic.TopicId = clsResearchTopicBL.GetFirstID_S(strCondition);
objResearchTopic.UpdateWithCondition(strCondition);
}
else
{
objResearchTopic.TopicId = clsResearchTopicBL.GetMaxStrId_S();
objResearchTopic.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsResearchTopicEN objResearchTopicEN)
{
 if (string.IsNullOrEmpty(objResearchTopicEN.TopicId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsResearchTopicBL.ResearchTopicDA.UpdateBySql2(objResearchTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsResearchTopicEN objResearchTopicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objResearchTopicEN.TopicId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsResearchTopicBL.ResearchTopicDA.UpdateBySql2(objResearchTopicEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "objResearchTopicEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsResearchTopicEN objResearchTopicEN, string strWhereCond)
{
try
{
bool bolResult = clsResearchTopicBL.ResearchTopicDA.UpdateBySqlWithCondition(objResearchTopicEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "objResearchTopicEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsResearchTopicEN objResearchTopicEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsResearchTopicBL.ResearchTopicDA.UpdateBySqlWithConditionTransaction(objResearchTopicEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsResearchTopicEN objResearchTopicEN)
{
try
{
int intRecNum = clsResearchTopicBL.ResearchTopicDA.DelRecord(objResearchTopicEN.TopicId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "objResearchTopicENS">源对象</param>
 /// <param name = "objResearchTopicENT">目标对象</param>
 public static void CopyTo(this clsResearchTopicEN objResearchTopicENS, clsResearchTopicEN objResearchTopicENT)
{
try
{
objResearchTopicENT.TopicId = objResearchTopicENS.TopicId; //主题Id
objResearchTopicENT.TopicName = objResearchTopicENS.TopicName; //栏目主题
objResearchTopicENT.TopicContent = objResearchTopicENS.TopicContent; //主题内容
objResearchTopicENT.TopicProposePeople = objResearchTopicENS.TopicProposePeople; //主题提出人
objResearchTopicENT.OrderNum = objResearchTopicENS.OrderNum; //序号
objResearchTopicENT.IsSubmit = objResearchTopicENS.IsSubmit; //是否提交
objResearchTopicENT.IdCurrEduCls = objResearchTopicENS.IdCurrEduCls; //教学班流水号
objResearchTopicENT.UpdDate = objResearchTopicENS.UpdDate; //修改日期
objResearchTopicENT.ShareId = objResearchTopicENS.ShareId; //分享Id
objResearchTopicENT.UpdUser = objResearchTopicENS.UpdUser; //修改人
objResearchTopicENT.Memo = objResearchTopicENS.Memo; //备注
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
 /// <param name = "objResearchTopicENS">源对象</param>
 /// <returns>目标对象=>clsResearchTopicEN:objResearchTopicENT</returns>
 public static clsResearchTopicEN CopyTo(this clsResearchTopicEN objResearchTopicENS)
{
try
{
 clsResearchTopicEN objResearchTopicENT = new clsResearchTopicEN()
{
TopicId = objResearchTopicENS.TopicId, //主题Id
TopicName = objResearchTopicENS.TopicName, //栏目主题
TopicContent = objResearchTopicENS.TopicContent, //主题内容
TopicProposePeople = objResearchTopicENS.TopicProposePeople, //主题提出人
OrderNum = objResearchTopicENS.OrderNum, //序号
IsSubmit = objResearchTopicENS.IsSubmit, //是否提交
IdCurrEduCls = objResearchTopicENS.IdCurrEduCls, //教学班流水号
UpdDate = objResearchTopicENS.UpdDate, //修改日期
ShareId = objResearchTopicENS.ShareId, //分享Id
UpdUser = objResearchTopicENS.UpdUser, //修改人
Memo = objResearchTopicENS.Memo, //备注
};
 return objResearchTopicENT;
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
public static void CheckPropertyNew(this clsResearchTopicEN objResearchTopicEN)
{
 clsResearchTopicBL.ResearchTopicDA.CheckPropertyNew(objResearchTopicEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsResearchTopicEN objResearchTopicEN)
{
 clsResearchTopicBL.ResearchTopicDA.CheckProperty4Condition(objResearchTopicEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsResearchTopicEN objResearchTopicCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objResearchTopicCond.IsUpdated(conResearchTopic.TopicId) == true)
{
string strComparisonOpTopicId = objResearchTopicCond.dicFldComparisonOp[conResearchTopic.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResearchTopic.TopicId, objResearchTopicCond.TopicId, strComparisonOpTopicId);
}
if (objResearchTopicCond.IsUpdated(conResearchTopic.TopicName) == true)
{
string strComparisonOpTopicName = objResearchTopicCond.dicFldComparisonOp[conResearchTopic.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResearchTopic.TopicName, objResearchTopicCond.TopicName, strComparisonOpTopicName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objResearchTopicCond.IsUpdated(conResearchTopic.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objResearchTopicCond.dicFldComparisonOp[conResearchTopic.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResearchTopic.TopicProposePeople, objResearchTopicCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
if (objResearchTopicCond.IsUpdated(conResearchTopic.OrderNum) == true)
{
string strComparisonOpOrderNum = objResearchTopicCond.dicFldComparisonOp[conResearchTopic.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conResearchTopic.OrderNum, objResearchTopicCond.OrderNum, strComparisonOpOrderNum);
}
if (objResearchTopicCond.IsUpdated(conResearchTopic.IsSubmit) == true)
{
if (objResearchTopicCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conResearchTopic.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conResearchTopic.IsSubmit);
}
}
if (objResearchTopicCond.IsUpdated(conResearchTopic.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objResearchTopicCond.dicFldComparisonOp[conResearchTopic.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResearchTopic.IdCurrEduCls, objResearchTopicCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objResearchTopicCond.IsUpdated(conResearchTopic.UpdDate) == true)
{
string strComparisonOpUpdDate = objResearchTopicCond.dicFldComparisonOp[conResearchTopic.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResearchTopic.UpdDate, objResearchTopicCond.UpdDate, strComparisonOpUpdDate);
}
if (objResearchTopicCond.IsUpdated(conResearchTopic.ShareId) == true)
{
string strComparisonOpShareId = objResearchTopicCond.dicFldComparisonOp[conResearchTopic.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResearchTopic.ShareId, objResearchTopicCond.ShareId, strComparisonOpShareId);
}
if (objResearchTopicCond.IsUpdated(conResearchTopic.UpdUser) == true)
{
string strComparisonOpUpdUser = objResearchTopicCond.dicFldComparisonOp[conResearchTopic.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResearchTopic.UpdUser, objResearchTopicCond.UpdUser, strComparisonOpUpdUser);
}
if (objResearchTopicCond.IsUpdated(conResearchTopic.Memo) == true)
{
string strComparisonOpMemo = objResearchTopicCond.dicFldComparisonOp[conResearchTopic.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResearchTopic.Memo, objResearchTopicCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ResearchTopic(研究主题), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TopicId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objResearchTopicEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsResearchTopicEN objResearchTopicEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objResearchTopicEN == null) return true;
if (objResearchTopicEN.TopicId == null || objResearchTopicEN.TopicId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicId = '{0}'", objResearchTopicEN.TopicId);
if (clsResearchTopicBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TopicId !=  '{0}'", objResearchTopicEN.TopicId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objResearchTopicEN.TopicId);
if (clsResearchTopicBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ResearchTopic(研究主题), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TopicId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objResearchTopicEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsResearchTopicEN objResearchTopicEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objResearchTopicEN == null) return "";
if (objResearchTopicEN.TopicId == null || objResearchTopicEN.TopicId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicId = '{0}'", objResearchTopicEN.TopicId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TopicId !=  '{0}'", objResearchTopicEN.TopicId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objResearchTopicEN.TopicId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ResearchTopic
{
public virtual bool UpdRelaTabDate(string strTopicId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 研究主题(ResearchTopic)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsResearchTopicBL
{
public static RelatedActions_ResearchTopic relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsResearchTopicDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsResearchTopicDA ResearchTopicDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsResearchTopicDA();
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
 public clsResearchTopicBL()
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
if (string.IsNullOrEmpty(clsResearchTopicEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsResearchTopicEN._ConnectString);
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
public static DataTable GetDataTable_ResearchTopic(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ResearchTopicDA.GetDataTable_ResearchTopic(strWhereCond);
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
objDT = ResearchTopicDA.GetDataTable(strWhereCond);
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
objDT = ResearchTopicDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ResearchTopicDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ResearchTopicDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ResearchTopicDA.GetDataTable_Top(objTopPara);
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
objDT = ResearchTopicDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ResearchTopicDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ResearchTopicDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTopicIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsResearchTopicEN> GetObjLstByTopicIdLst(List<string> arrTopicIdLst)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTopicIdLst, true);
 string strWhereCond = string.Format("TopicId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTopicIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsResearchTopicEN> GetObjLstByTopicIdLstCache(List<string> arrTopicIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsResearchTopicEN._CurrTabName, strIdCurrEduCls);
List<clsResearchTopicEN> arrResearchTopicObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsResearchTopicEN> arrResearchTopicObjLst_Sel =
arrResearchTopicObjLstCache
.Where(x => arrTopicIdLst.Contains(x.TopicId));
return arrResearchTopicObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsResearchTopicEN> GetObjLst(string strWhereCond)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
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
public static List<clsResearchTopicEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objResearchTopicCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsResearchTopicEN> GetSubObjLstCache(clsResearchTopicEN objResearchTopicCond)
{
 string strIdCurrEduCls = objResearchTopicCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsResearchTopicBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsResearchTopicEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsResearchTopicEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conResearchTopic.AttributeName)
{
if (objResearchTopicCond.IsUpdated(strFldName) == false) continue;
if (objResearchTopicCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResearchTopicCond[strFldName].ToString());
}
else
{
if (objResearchTopicCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objResearchTopicCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResearchTopicCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objResearchTopicCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objResearchTopicCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objResearchTopicCond[strFldName]));
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
public static List<clsResearchTopicEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
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
public static List<clsResearchTopicEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
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
List<clsResearchTopicEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsResearchTopicEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsResearchTopicEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsResearchTopicEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
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
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
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
public static List<clsResearchTopicEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsResearchTopicEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsResearchTopicEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
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
public static List<clsResearchTopicEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsResearchTopicEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsResearchTopicEN> arrObjLst = new List<clsResearchTopicEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResearchTopicEN objResearchTopicEN = new clsResearchTopicEN();
try
{
objResearchTopicEN.TopicId = objRow[conResearchTopic.TopicId].ToString().Trim(); //主题Id
objResearchTopicEN.TopicName = objRow[conResearchTopic.TopicName] == DBNull.Value ? null : objRow[conResearchTopic.TopicName].ToString().Trim(); //栏目主题
objResearchTopicEN.TopicContent = objRow[conResearchTopic.TopicContent] == DBNull.Value ? null : objRow[conResearchTopic.TopicContent].ToString().Trim(); //主题内容
objResearchTopicEN.TopicProposePeople = objRow[conResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[conResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objResearchTopicEN.OrderNum = objRow[conResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResearchTopic.OrderNum].ToString().Trim()); //序号
objResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objResearchTopicEN.IdCurrEduCls = objRow[conResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[conResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objResearchTopicEN.UpdDate = objRow[conResearchTopic.UpdDate] == DBNull.Value ? null : objRow[conResearchTopic.UpdDate].ToString().Trim(); //修改日期
objResearchTopicEN.ShareId = objRow[conResearchTopic.ShareId].ToString().Trim(); //分享Id
objResearchTopicEN.UpdUser = objRow[conResearchTopic.UpdUser] == DBNull.Value ? null : objRow[conResearchTopic.UpdUser].ToString().Trim(); //修改人
objResearchTopicEN.Memo = objRow[conResearchTopic.Memo] == DBNull.Value ? null : objRow[conResearchTopic.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResearchTopicEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objResearchTopicEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetResearchTopic(ref clsResearchTopicEN objResearchTopicEN)
{
bool bolResult = ResearchTopicDA.GetResearchTopic(ref objResearchTopicEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsResearchTopicEN GetObjByTopicId(string strTopicId)
{
if (strTopicId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTopicId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTopicId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsResearchTopicEN objResearchTopicEN = ResearchTopicDA.GetObjByTopicId(strTopicId);
return objResearchTopicEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsResearchTopicEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsResearchTopicEN objResearchTopicEN = ResearchTopicDA.GetFirstObj(strWhereCond);
 return objResearchTopicEN;
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
public static clsResearchTopicEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsResearchTopicEN objResearchTopicEN = ResearchTopicDA.GetObjByDataRow(objRow);
 return objResearchTopicEN;
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
public static clsResearchTopicEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsResearchTopicEN objResearchTopicEN = ResearchTopicDA.GetObjByDataRow(objRow);
 return objResearchTopicEN;
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
 /// <param name = "strTopicId">所给的关键字</param>
 /// <param name = "lstResearchTopicObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsResearchTopicEN GetObjByTopicIdFromList(string strTopicId, List<clsResearchTopicEN> lstResearchTopicObjLst)
{
foreach (clsResearchTopicEN objResearchTopicEN in lstResearchTopicObjLst)
{
if (objResearchTopicEN.TopicId == strTopicId)
{
return objResearchTopicEN;
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
 string strMaxTopicId;
 try
 {
 strMaxTopicId = clsResearchTopicDA.GetMaxStrId();
 return strMaxTopicId;
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
 string strTopicId;
 try
 {
 strTopicId = new clsResearchTopicDA().GetFirstID(strWhereCond);
 return strTopicId;
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
 arrList = ResearchTopicDA.GetID(strWhereCond);
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
bool bolIsExist = ResearchTopicDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTopicId)
{
if (string.IsNullOrEmpty(strTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTopicId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ResearchTopicDA.IsExist(strTopicId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strTopicId">主题Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strTopicId, string strOpUser)
{
clsResearchTopicEN objResearchTopicEN = clsResearchTopicBL.GetObjByTopicId(strTopicId);
objResearchTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objResearchTopicEN.UpdUser = strOpUser;
return clsResearchTopicBL.UpdateBySql2(objResearchTopicEN);
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
 bolIsExist = clsResearchTopicDA.IsExistTable();
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
 bolIsExist = ResearchTopicDA.IsExistTable(strTabName);
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsResearchTopicEN objResearchTopicEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objResearchTopicEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}]的数据已经存在!(in clsResearchTopicBL.AddNewRecordBySql2)", objResearchTopicEN.TopicId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResearchTopicEN.TopicId) == true || clsResearchTopicBL.IsExist(objResearchTopicEN.TopicId) == true)
 {
     objResearchTopicEN.TopicId = clsResearchTopicBL.GetMaxStrId_S();
 }
bool bolResult = ResearchTopicDA.AddNewRecordBySQL2(objResearchTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsResearchTopicEN objResearchTopicEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objResearchTopicEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}]的数据已经存在!(in clsResearchTopicBL.AddNewRecordBySql2WithReturnKey)", objResearchTopicEN.TopicId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objResearchTopicEN.TopicId) == true || clsResearchTopicBL.IsExist(objResearchTopicEN.TopicId) == true)
 {
     objResearchTopicEN.TopicId = clsResearchTopicBL.GetMaxStrId_S();
 }
string strKey = ResearchTopicDA.AddNewRecordBySQL2WithReturnKey(objResearchTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsResearchTopicEN objResearchTopicEN)
{
try
{
bool bolResult = ResearchTopicDA.Update(objResearchTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "objResearchTopicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsResearchTopicEN objResearchTopicEN)
{
 if (string.IsNullOrEmpty(objResearchTopicEN.TopicId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ResearchTopicDA.UpdateBySql2(objResearchTopicEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResearchTopicBL.ReFreshCache(objResearchTopicEN.IdCurrEduCls);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
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
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTopicId)
{
try
{
 clsResearchTopicEN objResearchTopicEN = clsResearchTopicBL.GetObjByTopicId(strTopicId);

if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopicEN.TopicId, objResearchTopicEN.UpdUser);
}
if (objResearchTopicEN != null)
{
int intRecNum = ResearchTopicDA.DelRecord(strTopicId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objResearchTopicEN.IdCurrEduCls);
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
/// <param name="strTopicId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strTopicId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
//删除与表:[ResearchTopic]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conResearchTopic.TopicId,
//strTopicId);
//        clsResearchTopicBL.DelResearchTopicsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsResearchTopicBL.DelRecord(strTopicId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsResearchTopicBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTopicId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTopicId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(strTopicId, "UpdRelaTabDate");
}
bool bolResult = ResearchTopicDA.DelRecord(strTopicId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTopicIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelResearchTopics(List<string> arrTopicIdLst)
{
if (arrTopicIdLst.Count == 0) return 0;
try
{
if (clsResearchTopicBL.relatedActions != null)
{
foreach (var strTopicId in arrTopicIdLst)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(strTopicId, "UpdRelaTabDate");
}
}
 clsResearchTopicEN objResearchTopicEN = clsResearchTopicBL.GetObjByTopicId(arrTopicIdLst[0]);
int intDelRecNum = ResearchTopicDA.DelResearchTopic(arrTopicIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objResearchTopicEN.IdCurrEduCls);
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
public static int DelResearchTopicsByCond(string strWhereCond)
{
try
{
if (clsResearchTopicBL.relatedActions != null)
{
List<string> arrTopicId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTopicId in arrTopicId)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(strTopicId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conResearchTopic.IdCurrEduCls, strWhereCond);
int intRecNum = ResearchTopicDA.DelResearchTopic(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ResearchTopic]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTopicId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTopicId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsResearchTopicDA.GetSpecSQLObj();
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
//删除与表:[ResearchTopic]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsResearchTopicBL.DelRecord(strTopicId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsResearchTopicBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTopicId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objResearchTopicENS">源对象</param>
 /// <param name = "objResearchTopicENT">目标对象</param>
 public static void CopyTo(clsResearchTopicEN objResearchTopicENS, clsResearchTopicEN objResearchTopicENT)
{
try
{
objResearchTopicENT.TopicId = objResearchTopicENS.TopicId; //主题Id
objResearchTopicENT.TopicName = objResearchTopicENS.TopicName; //栏目主题
objResearchTopicENT.TopicContent = objResearchTopicENS.TopicContent; //主题内容
objResearchTopicENT.TopicProposePeople = objResearchTopicENS.TopicProposePeople; //主题提出人
objResearchTopicENT.OrderNum = objResearchTopicENS.OrderNum; //序号
objResearchTopicENT.IsSubmit = objResearchTopicENS.IsSubmit; //是否提交
objResearchTopicENT.IdCurrEduCls = objResearchTopicENS.IdCurrEduCls; //教学班流水号
objResearchTopicENT.UpdDate = objResearchTopicENS.UpdDate; //修改日期
objResearchTopicENT.ShareId = objResearchTopicENS.ShareId; //分享Id
objResearchTopicENT.UpdUser = objResearchTopicENS.UpdUser; //修改人
objResearchTopicENT.Memo = objResearchTopicENS.Memo; //备注
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
 /// <param name = "objResearchTopicEN">源简化对象</param>
 public static void SetUpdFlag(clsResearchTopicEN objResearchTopicEN)
{
try
{
objResearchTopicEN.ClearUpdateState();
   string strsfUpdFldSetStr = objResearchTopicEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conResearchTopic.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.TopicId = objResearchTopicEN.TopicId; //主题Id
}
if (arrFldSet.Contains(conResearchTopic.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.TopicName = objResearchTopicEN.TopicName == "[null]" ? null :  objResearchTopicEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(conResearchTopic.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.TopicContent = objResearchTopicEN.TopicContent == "[null]" ? null :  objResearchTopicEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(conResearchTopic.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.TopicProposePeople = objResearchTopicEN.TopicProposePeople == "[null]" ? null :  objResearchTopicEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(conResearchTopic.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.OrderNum = objResearchTopicEN.OrderNum; //序号
}
if (arrFldSet.Contains(conResearchTopic.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.IsSubmit = objResearchTopicEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conResearchTopic.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.IdCurrEduCls = objResearchTopicEN.IdCurrEduCls == "[null]" ? null :  objResearchTopicEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conResearchTopic.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.UpdDate = objResearchTopicEN.UpdDate == "[null]" ? null :  objResearchTopicEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conResearchTopic.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.ShareId = objResearchTopicEN.ShareId; //分享Id
}
if (arrFldSet.Contains(conResearchTopic.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.UpdUser = objResearchTopicEN.UpdUser == "[null]" ? null :  objResearchTopicEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conResearchTopic.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objResearchTopicEN.Memo = objResearchTopicEN.Memo == "[null]" ? null :  objResearchTopicEN.Memo; //备注
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
 /// <param name = "objResearchTopicEN">源简化对象</param>
 public static void AccessFldValueNull(clsResearchTopicEN objResearchTopicEN)
{
try
{
if (objResearchTopicEN.TopicName == "[null]") objResearchTopicEN.TopicName = null; //栏目主题
if (objResearchTopicEN.TopicContent == "[null]") objResearchTopicEN.TopicContent = null; //主题内容
if (objResearchTopicEN.TopicProposePeople == "[null]") objResearchTopicEN.TopicProposePeople = null; //主题提出人
if (objResearchTopicEN.IdCurrEduCls == "[null]") objResearchTopicEN.IdCurrEduCls = null; //教学班流水号
if (objResearchTopicEN.UpdDate == "[null]") objResearchTopicEN.UpdDate = null; //修改日期
if (objResearchTopicEN.UpdUser == "[null]") objResearchTopicEN.UpdUser = null; //修改人
if (objResearchTopicEN.Memo == "[null]") objResearchTopicEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsResearchTopicEN objResearchTopicEN)
{
 ResearchTopicDA.CheckPropertyNew(objResearchTopicEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsResearchTopicEN objResearchTopicEN)
{
 ResearchTopicDA.CheckProperty4Condition(objResearchTopicEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TopicIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[研究主题]...","0");
List<clsResearchTopicEN> arrResearchTopicObjLst = GetAllResearchTopicObjLstCache(strIdCurrEduCls); 
arrResearchTopicObjLst = arrResearchTopicObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conResearchTopic.TopicId;
objDDL.DataTextField = conResearchTopic.TopicName;
objDDL.DataSource = arrResearchTopicObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TopicId");
//if (arrResearchTopicObjLstCache == null)
//{
//arrResearchTopicObjLstCache = ResearchTopicDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTopicId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsResearchTopicEN GetObjByTopicIdCache(string strTopicId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsResearchTopicEN._CurrTabName, strIdCurrEduCls);
List<clsResearchTopicEN> arrResearchTopicObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsResearchTopicEN> arrResearchTopicObjLst_Sel =
arrResearchTopicObjLstCache
.Where(x=> x.TopicId == strTopicId 
);
if (arrResearchTopicObjLst_Sel.Count() == 0)
{
   clsResearchTopicEN obj = clsResearchTopicBL.GetObjByTopicId(strTopicId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTopicId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrResearchTopicObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTopicNameByTopicIdCache(string strTopicId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strTopicId) == true) return "";
//获取缓存中的对象列表
clsResearchTopicEN objResearchTopic = GetObjByTopicIdCache(strTopicId, strIdCurrEduCls);
if (objResearchTopic == null) return "";
return objResearchTopic.TopicName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTopicId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTopicIdCache(string strTopicId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strTopicId) == true) return "";
//获取缓存中的对象列表
clsResearchTopicEN objResearchTopic = GetObjByTopicIdCache(strTopicId, strIdCurrEduCls);
if (objResearchTopic == null) return "";
return objResearchTopic.TopicName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsResearchTopicEN> GetAllResearchTopicObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsResearchTopicEN> arrResearchTopicObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrResearchTopicObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsResearchTopicEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsResearchTopicEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsResearchTopicEN> arrResearchTopicObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrResearchTopicObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsResearchTopicEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsResearchTopicEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsResearchTopicEN._RefreshTimeLst.Count == 0) return "";
return clsResearchTopicEN._RefreshTimeLst[clsResearchTopicEN._RefreshTimeLst.Count - 1];
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
if (clsResearchTopicBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsResearchTopicEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsResearchTopicEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsResearchTopicBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ResearchTopic(研究主题)
 /// 唯一性条件:TopicId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objResearchTopicEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsResearchTopicEN objResearchTopicEN)
{
//检测记录是否存在
string strResult = ResearchTopicDA.GetUniCondStr(objResearchTopicEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTopicId, string strIdCurrEduCls)
{
if (strInFldName != conResearchTopic.TopicId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conResearchTopic.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conResearchTopic.AttributeName));
throw new Exception(strMsg);
}
var objResearchTopic = clsResearchTopicBL.GetObjByTopicIdCache(strTopicId, strIdCurrEduCls);
if (objResearchTopic == null) return "";
return objResearchTopic[strOutFldName].ToString();
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
int intRecCount = clsResearchTopicDA.GetRecCount(strTabName);
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
int intRecCount = clsResearchTopicDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsResearchTopicDA.GetRecCount();
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
int intRecCount = clsResearchTopicDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objResearchTopicCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsResearchTopicEN objResearchTopicCond)
{
 string strIdCurrEduCls = objResearchTopicCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsResearchTopicBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsResearchTopicEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsResearchTopicEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conResearchTopic.AttributeName)
{
if (objResearchTopicCond.IsUpdated(strFldName) == false) continue;
if (objResearchTopicCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResearchTopicCond[strFldName].ToString());
}
else
{
if (objResearchTopicCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objResearchTopicCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResearchTopicCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objResearchTopicCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objResearchTopicCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objResearchTopicCond[strFldName]));
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
 List<string> arrList = clsResearchTopicDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ResearchTopicDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ResearchTopicDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ResearchTopicDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsResearchTopicDA.SetFldValue(clsResearchTopicEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ResearchTopicDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsResearchTopicDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsResearchTopicDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsResearchTopicDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ResearchTopic] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) primary key, "); 
 // /**栏目主题*/ 
 strCreateTabCode.Append(" TopicName varchar(200) Null, "); 
 // /**主题内容*/ 
 strCreateTabCode.Append(" TopicContent text Null, "); 
 // /**主题提出人*/ 
 strCreateTabCode.Append(" TopicProposePeople varchar(50) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" ShareId char(2) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**最后访问时间*/ 
 strCreateTabCode.Append(" LastVisitedDate varchar(14) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conResearchTopic.OrderNum); 
List<clsResearchTopicEN> arrResearchTopicObjList = new clsResearchTopicDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsResearchTopicEN objResearchTopic in arrResearchTopicObjList)
{
objResearchTopic.OrderNum = intIndex;
UpdateBySql2(objResearchTopic);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strTopicId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strTopicId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[TopicId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字TopicId
//5、把当前关键字TopicId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字TopicId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevTopicId = "";    //上一条序号的关键字TopicId
string strNextTopicId = "";    //下一条序号的关键字TopicId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[TopicId],获取相应的序号[OrderNum]。

clsResearchTopicEN objResearchTopic = clsResearchTopicBL.GetObjByTopicId(strTopicId);

intOrderNum = objResearchTopic.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsResearchTopicBL.GetRecCountByCond(clsResearchTopicEN._CurrTabName, "1 = 1");    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
strCondition.AppendFormat(" {0} = {1}", conResearchTopic.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字TopicId
strPrevTopicId = clsResearchTopicBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevTopicId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字TopicId所对应记录的序号减1
//6、把下(上)一个序号关键字TopicId所对应的记录序号加1
clsResearchTopicBL.SetFldValue(clsResearchTopicEN._CurrTabName, conResearchTopic.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conResearchTopic.TopicId, strTopicId));
clsResearchTopicBL.SetFldValue(clsResearchTopicEN._CurrTabName, conResearchTopic.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conResearchTopic.TopicId, strPrevTopicId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字TopicId
strCondition.AppendFormat(" {0} = {1}", conResearchTopic.OrderNum, intOrderNum + 1);

strNextTopicId = clsResearchTopicBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextTopicId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字TopicId所对应记录的序号加1
//6、把下(上)一个序号关键字TopicId所对应的记录序号减1
clsResearchTopicBL.SetFldValue(clsResearchTopicEN._CurrTabName, conResearchTopic.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conResearchTopic.TopicId, strTopicId));
clsResearchTopicBL.SetFldValue(clsResearchTopicEN._CurrTabName, conResearchTopic.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conResearchTopic.TopicId, strNextTopicId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsResearchTopicBL.ReFreshCache(objResearchTopic.IdCurrEduCls);
if (clsResearchTopicBL.relatedActions != null)
{
clsResearchTopicBL.relatedActions.UpdRelaTabDate(objResearchTopic.TopicId, "UpdRelaTabDate");
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
objException.Message,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conResearchTopic.TopicId, strKeyList);
List<clsResearchTopicEN> arrResearchTopicLst = GetObjLst(strCondition);
foreach (clsResearchTopicEN objResearchTopic in arrResearchTopicLst)
{
objResearchTopic.OrderNum = objResearchTopic.OrderNum + 10000;
UpdateBySql2(objResearchTopic);
}
strCondition = string.Format("1 = 1 order by {0} ", conResearchTopic.OrderNum); 
List<clsResearchTopicEN> arrResearchTopicObjList = new clsResearchTopicDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsResearchTopicEN objResearchTopic in arrResearchTopicObjList)
{
objResearchTopic.OrderNum = intIndex;
UpdateBySql2(objResearchTopic);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conResearchTopic.TopicId, strKeyList);
List<clsResearchTopicEN> arrResearchTopicLst = GetObjLst(strCondition);
foreach (clsResearchTopicEN objResearchTopic in arrResearchTopicLst)
{
objResearchTopic.OrderNum = objResearchTopic.OrderNum - 10000;
UpdateBySql2(objResearchTopic);
}
strCondition = string.Format("1 = 1 order by {0} ", conResearchTopic.OrderNum); 
List<clsResearchTopicEN> arrResearchTopicObjList = new clsResearchTopicDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsResearchTopicEN objResearchTopic in arrResearchTopicObjList)
{
objResearchTopic.OrderNum = intIndex;
UpdateBySql2(objResearchTopic);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 研究主题(ResearchTopic)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ResearchTopic : clsCommFun4BLV2
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
clsResearchTopicBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}