
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTopicObjectiveVerBL
 表名:TopicObjectiveVer(01120648)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:26
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
public static class  clsTopicObjectiveVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTopicObjectiveVerEN GetObj(this K_TopicObjectiveVId_TopicObjectiveVer myKey)
{
clsTopicObjectiveVerEN objTopicObjectiveVerEN = clsTopicObjectiveVerBL.TopicObjectiveVerDA.GetObjByTopicObjectiveVId(myKey.Value);
return objTopicObjectiveVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTopicObjectiveVerEN) == false)
{
var strMsg = string.Format("记录已经存在!主题客观版本Id = [{0}]的数据已经存在!(in clsTopicObjectiveVerBL.AddNewRecord)", objTopicObjectiveVerEN.TopicObjectiveVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsTopicObjectiveVerBL.TopicObjectiveVerDA.AddNewRecordBySQL2(objTopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
public static bool AddRecordEx(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, bool bolIsNeedCheckUniqueness = true)
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
objTopicObjectiveVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTopicObjectiveVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主题客观版本Id(TopicObjectiveVId)=[{0}])已经存在,不能重复!", objTopicObjectiveVerEN.TopicObjectiveVId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objTopicObjectiveVerEN.AddNewRecord();
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
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTopicObjectiveVerEN) == false)
{
var strMsg = string.Format("记录已经存在!主题客观版本Id = [{0}]的数据已经存在!(in clsTopicObjectiveVerBL.AddNewRecordWithReturnKey)", objTopicObjectiveVerEN.TopicObjectiveVId);
throw new Exception(strMsg);
}
try
{
string strKey = clsTopicObjectiveVerBL.TopicObjectiveVerDA.AddNewRecordBySQL2WithReturnKey(objTopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetTopicObjectiveVId(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, long lngTopicObjectiveVId, string strComparisonOp="")
	{
objTopicObjectiveVerEN.TopicObjectiveVId = lngTopicObjectiveVId; //主题客观版本Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.TopicObjectiveVId) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.TopicObjectiveVId, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.TopicObjectiveVId] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetTopicObjectiveId(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strTopicObjectiveId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicObjectiveId, conTopicObjectiveVer.TopicObjectiveId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicObjectiveId, 8, conTopicObjectiveVer.TopicObjectiveId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicObjectiveId, 8, conTopicObjectiveVer.TopicObjectiveId);
}
objTopicObjectiveVerEN.TopicObjectiveId = strTopicObjectiveId; //客观Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.TopicObjectiveId) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.TopicObjectiveId, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.TopicObjectiveId] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetObjectiveName(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strObjectiveName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveName, 500, conTopicObjectiveVer.ObjectiveName);
}
objTopicObjectiveVerEN.ObjectiveName = strObjectiveName; //客观名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.ObjectiveName) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.ObjectiveName, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.ObjectiveName] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetObjectiveContent(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strObjectiveContent, string strComparisonOp="")
	{
objTopicObjectiveVerEN.ObjectiveContent = strObjectiveContent; //客观内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.ObjectiveContent) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.ObjectiveContent, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.ObjectiveContent] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetObjectiveType(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strObjectiveType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveType, 2, conTopicObjectiveVer.ObjectiveType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strObjectiveType, 2, conTopicObjectiveVer.ObjectiveType);
}
objTopicObjectiveVerEN.ObjectiveType = strObjectiveType; //客观类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.ObjectiveType) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.ObjectiveType, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.ObjectiveType] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetConclusion(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strConclusion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConclusion, 5000, conTopicObjectiveVer.Conclusion);
}
objTopicObjectiveVerEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.Conclusion) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.Conclusion, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.Conclusion] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetSourceId(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strSourceId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceId, 10, conTopicObjectiveVer.SourceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSourceId, 10, conTopicObjectiveVer.SourceId);
}
objTopicObjectiveVerEN.SourceId = strSourceId; //来源Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.SourceId) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.SourceId, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.SourceId] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetUpdDate(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTopicObjectiveVer.UpdDate);
}
objTopicObjectiveVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.UpdDate) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.UpdDate, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.UpdDate] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetUpdUser(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conTopicObjectiveVer.UpdUser);
}
objTopicObjectiveVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.UpdUser) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.UpdUser, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.UpdUser] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetIdCurrEduCls(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conTopicObjectiveVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conTopicObjectiveVer.IdCurrEduCls);
}
objTopicObjectiveVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.IdCurrEduCls) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.IdCurrEduCls, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.IdCurrEduCls] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetPdfContent(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conTopicObjectiveVer.PdfContent);
}
objTopicObjectiveVerEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.PdfContent) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.PdfContent, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.PdfContent] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetPdfPageNum(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, int? intPdfPageNum, string strComparisonOp="")
	{
objTopicObjectiveVerEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.PdfPageNum) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.PdfPageNum, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.PdfPageNum] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTopicObjectiveVerEN SetMemo(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTopicObjectiveVer.Memo);
}
objTopicObjectiveVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTopicObjectiveVerEN.dicFldComparisonOp.ContainsKey(conTopicObjectiveVer.Memo) == false)
{
objTopicObjectiveVerEN.dicFldComparisonOp.Add(conTopicObjectiveVer.Memo, strComparisonOp);
}
else
{
objTopicObjectiveVerEN.dicFldComparisonOp[conTopicObjectiveVer.Memo] = strComparisonOp;
}
}
return objTopicObjectiveVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTopicObjectiveVerEN.CheckPropertyNew();
clsTopicObjectiveVerEN objTopicObjectiveVerCond = new clsTopicObjectiveVerEN();
string strCondition = objTopicObjectiveVerCond
.SetTopicObjectiveVId(objTopicObjectiveVerEN.TopicObjectiveVId, "<>")
.SetTopicObjectiveVId(objTopicObjectiveVerEN.TopicObjectiveVId, "=")
.GetCombineCondition();
objTopicObjectiveVerEN._IsCheckProperty = true;
bool bolIsExist = clsTopicObjectiveVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TopicObjectiveVId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTopicObjectiveVerEN.Update();
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
 /// <param name = "objTopicObjectiveVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTopicObjectiveVerEN objTopicObjectiveVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTopicObjectiveVerEN objTopicObjectiveVerCond = new clsTopicObjectiveVerEN();
string strCondition = objTopicObjectiveVerCond
.SetTopicObjectiveVId(objTopicObjectiveVer.TopicObjectiveVId, "=")
.GetCombineCondition();
objTopicObjectiveVer._IsCheckProperty = true;
bool bolIsExist = clsTopicObjectiveVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTopicObjectiveVer.TopicObjectiveVId = clsTopicObjectiveVerBL.GetFirstID_S(strCondition);
objTopicObjectiveVer.UpdateWithCondition(strCondition);
}
else
{
objTopicObjectiveVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 if (objTopicObjectiveVerEN.TopicObjectiveVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTopicObjectiveVerBL.TopicObjectiveVerDA.UpdateBySql2(objTopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTopicObjectiveVerEN.TopicObjectiveVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTopicObjectiveVerBL.TopicObjectiveVerDA.UpdateBySql2(objTopicObjectiveVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objTopicObjectiveVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strWhereCond)
{
try
{
bool bolResult = clsTopicObjectiveVerBL.TopicObjectiveVerDA.UpdateBySqlWithCondition(objTopicObjectiveVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objTopicObjectiveVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTopicObjectiveVerBL.TopicObjectiveVerDA.UpdateBySqlWithConditionTransaction(objTopicObjectiveVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
try
{
int intRecNum = clsTopicObjectiveVerBL.TopicObjectiveVerDA.DelRecord(objTopicObjectiveVerEN.TopicObjectiveVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objTopicObjectiveVerENS">源对象</param>
 /// <param name = "objTopicObjectiveVerENT">目标对象</param>
 public static void CopyTo(this clsTopicObjectiveVerEN objTopicObjectiveVerENS, clsTopicObjectiveVerEN objTopicObjectiveVerENT)
{
try
{
objTopicObjectiveVerENT.TopicObjectiveVId = objTopicObjectiveVerENS.TopicObjectiveVId; //主题客观版本Id
objTopicObjectiveVerENT.TopicObjectiveId = objTopicObjectiveVerENS.TopicObjectiveId; //客观Id
objTopicObjectiveVerENT.ObjectiveName = objTopicObjectiveVerENS.ObjectiveName; //客观名称
objTopicObjectiveVerENT.ObjectiveContent = objTopicObjectiveVerENS.ObjectiveContent; //客观内容
objTopicObjectiveVerENT.ObjectiveType = objTopicObjectiveVerENS.ObjectiveType; //客观类型
objTopicObjectiveVerENT.Conclusion = objTopicObjectiveVerENS.Conclusion; //结论
objTopicObjectiveVerENT.SourceId = objTopicObjectiveVerENS.SourceId; //来源Id
objTopicObjectiveVerENT.UpdDate = objTopicObjectiveVerENS.UpdDate; //修改日期
objTopicObjectiveVerENT.UpdUser = objTopicObjectiveVerENS.UpdUser; //修改人
objTopicObjectiveVerENT.IdCurrEduCls = objTopicObjectiveVerENS.IdCurrEduCls; //教学班流水号
objTopicObjectiveVerENT.PdfContent = objTopicObjectiveVerENS.PdfContent; //Pdf内容
objTopicObjectiveVerENT.PdfPageNum = objTopicObjectiveVerENS.PdfPageNum; //Pdf页码
objTopicObjectiveVerENT.Memo = objTopicObjectiveVerENS.Memo; //备注
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
 /// <param name = "objTopicObjectiveVerENS">源对象</param>
 /// <returns>目标对象=>clsTopicObjectiveVerEN:objTopicObjectiveVerENT</returns>
 public static clsTopicObjectiveVerEN CopyTo(this clsTopicObjectiveVerEN objTopicObjectiveVerENS)
{
try
{
 clsTopicObjectiveVerEN objTopicObjectiveVerENT = new clsTopicObjectiveVerEN()
{
TopicObjectiveVId = objTopicObjectiveVerENS.TopicObjectiveVId, //主题客观版本Id
TopicObjectiveId = objTopicObjectiveVerENS.TopicObjectiveId, //客观Id
ObjectiveName = objTopicObjectiveVerENS.ObjectiveName, //客观名称
ObjectiveContent = objTopicObjectiveVerENS.ObjectiveContent, //客观内容
ObjectiveType = objTopicObjectiveVerENS.ObjectiveType, //客观类型
Conclusion = objTopicObjectiveVerENS.Conclusion, //结论
SourceId = objTopicObjectiveVerENS.SourceId, //来源Id
UpdDate = objTopicObjectiveVerENS.UpdDate, //修改日期
UpdUser = objTopicObjectiveVerENS.UpdUser, //修改人
IdCurrEduCls = objTopicObjectiveVerENS.IdCurrEduCls, //教学班流水号
PdfContent = objTopicObjectiveVerENS.PdfContent, //Pdf内容
PdfPageNum = objTopicObjectiveVerENS.PdfPageNum, //Pdf页码
Memo = objTopicObjectiveVerENS.Memo, //备注
};
 return objTopicObjectiveVerENT;
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
public static void CheckPropertyNew(this clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 clsTopicObjectiveVerBL.TopicObjectiveVerDA.CheckPropertyNew(objTopicObjectiveVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 clsTopicObjectiveVerBL.TopicObjectiveVerDA.CheckProperty4Condition(objTopicObjectiveVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTopicObjectiveVerEN objTopicObjectiveVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.TopicObjectiveVId) == true)
{
string strComparisonOpTopicObjectiveVId = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.TopicObjectiveVId];
strWhereCond += string.Format(" And {0} {2} {1}", conTopicObjectiveVer.TopicObjectiveVId, objTopicObjectiveVerCond.TopicObjectiveVId, strComparisonOpTopicObjectiveVId);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.TopicObjectiveId) == true)
{
string strComparisonOpTopicObjectiveId = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.TopicObjectiveId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.TopicObjectiveId, objTopicObjectiveVerCond.TopicObjectiveId, strComparisonOpTopicObjectiveId);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.ObjectiveName) == true)
{
string strComparisonOpObjectiveName = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.ObjectiveName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.ObjectiveName, objTopicObjectiveVerCond.ObjectiveName, strComparisonOpObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.ObjectiveType) == true)
{
string strComparisonOpObjectiveType = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.ObjectiveType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.ObjectiveType, objTopicObjectiveVerCond.ObjectiveType, strComparisonOpObjectiveType);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.Conclusion) == true)
{
string strComparisonOpConclusion = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.Conclusion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.Conclusion, objTopicObjectiveVerCond.Conclusion, strComparisonOpConclusion);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.SourceId) == true)
{
string strComparisonOpSourceId = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.SourceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.SourceId, objTopicObjectiveVerCond.SourceId, strComparisonOpSourceId);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.UpdDate, objTopicObjectiveVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.UpdUser, objTopicObjectiveVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.IdCurrEduCls, objTopicObjectiveVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.PdfContent) == true)
{
string strComparisonOpPdfContent = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.PdfContent, objTopicObjectiveVerCond.PdfContent, strComparisonOpPdfContent);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conTopicObjectiveVer.PdfPageNum, objTopicObjectiveVerCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objTopicObjectiveVerCond.IsUpdated(conTopicObjectiveVer.Memo) == true)
{
string strComparisonOpMemo = objTopicObjectiveVerCond.dicFldComparisonOp[conTopicObjectiveVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTopicObjectiveVer.Memo, objTopicObjectiveVerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TopicObjectiveVer(主题客观版本), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TopicObjectiveVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTopicObjectiveVerEN == null) return true;
if (objTopicObjectiveVerEN.TopicObjectiveVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVerEN.TopicObjectiveVId);
if (clsTopicObjectiveVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TopicObjectiveVId !=  {0}", objTopicObjectiveVerEN.TopicObjectiveVId);
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVerEN.TopicObjectiveVId);
if (clsTopicObjectiveVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--TopicObjectiveVer(主题客观版本), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TopicObjectiveVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTopicObjectiveVerEN == null) return "";
if (objTopicObjectiveVerEN.TopicObjectiveVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVerEN.TopicObjectiveVId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TopicObjectiveVId !=  {0}", objTopicObjectiveVerEN.TopicObjectiveVId);
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVerEN.TopicObjectiveVId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TopicObjectiveVer
{
public virtual bool UpdRelaTabDate(long lngTopicObjectiveVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 主题客观版本(TopicObjectiveVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTopicObjectiveVerBL
{
public static RelatedActions_TopicObjectiveVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTopicObjectiveVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTopicObjectiveVerDA TopicObjectiveVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTopicObjectiveVerDA();
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
 public clsTopicObjectiveVerBL()
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
if (string.IsNullOrEmpty(clsTopicObjectiveVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTopicObjectiveVerEN._ConnectString);
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
public static DataTable GetDataTable_TopicObjectiveVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TopicObjectiveVerDA.GetDataTable_TopicObjectiveVer(strWhereCond);
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
objDT = TopicObjectiveVerDA.GetDataTable(strWhereCond);
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
objDT = TopicObjectiveVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TopicObjectiveVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TopicObjectiveVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TopicObjectiveVerDA.GetDataTable_Top(objTopPara);
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
objDT = TopicObjectiveVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TopicObjectiveVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TopicObjectiveVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTopicObjectiveVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTopicObjectiveVerEN> GetObjLstByTopicObjectiveVIdLst(List<long> arrTopicObjectiveVIdLst)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTopicObjectiveVIdLst);
 string strWhereCond = string.Format("TopicObjectiveVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTopicObjectiveVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTopicObjectiveVerEN> GetObjLstByTopicObjectiveVIdLstCache(List<long> arrTopicObjectiveVIdLst)
{
string strKey = string.Format("{0}", clsTopicObjectiveVerEN._CurrTabName);
List<clsTopicObjectiveVerEN> arrTopicObjectiveVerObjLstCache = GetObjLstCache();
IEnumerable <clsTopicObjectiveVerEN> arrTopicObjectiveVerObjLst_Sel =
arrTopicObjectiveVerObjLstCache
.Where(x => arrTopicObjectiveVIdLst.Contains(x.TopicObjectiveVId));
return arrTopicObjectiveVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTopicObjectiveVerEN> GetObjLst(string strWhereCond)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
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
public static List<clsTopicObjectiveVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTopicObjectiveVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTopicObjectiveVerEN> GetSubObjLstCache(clsTopicObjectiveVerEN objTopicObjectiveVerCond)
{
List<clsTopicObjectiveVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTopicObjectiveVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTopicObjectiveVer.AttributeName)
{
if (objTopicObjectiveVerCond.IsUpdated(strFldName) == false) continue;
if (objTopicObjectiveVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTopicObjectiveVerCond[strFldName].ToString());
}
else
{
if (objTopicObjectiveVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTopicObjectiveVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTopicObjectiveVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTopicObjectiveVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTopicObjectiveVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTopicObjectiveVerCond[strFldName]));
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
public static List<clsTopicObjectiveVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
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
public static List<clsTopicObjectiveVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
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
List<clsTopicObjectiveVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTopicObjectiveVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTopicObjectiveVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTopicObjectiveVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
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
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
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
public static List<clsTopicObjectiveVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTopicObjectiveVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTopicObjectiveVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
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
public static List<clsTopicObjectiveVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTopicObjectiveVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTopicObjectiveVerEN.TopicObjectiveVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTopicObjectiveVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTopicObjectiveVer(ref clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
bool bolResult = TopicObjectiveVerDA.GetTopicObjectiveVer(ref objTopicObjectiveVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTopicObjectiveVerEN GetObjByTopicObjectiveVId(long lngTopicObjectiveVId)
{
clsTopicObjectiveVerEN objTopicObjectiveVerEN = TopicObjectiveVerDA.GetObjByTopicObjectiveVId(lngTopicObjectiveVId);
return objTopicObjectiveVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTopicObjectiveVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTopicObjectiveVerEN objTopicObjectiveVerEN = TopicObjectiveVerDA.GetFirstObj(strWhereCond);
 return objTopicObjectiveVerEN;
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
public static clsTopicObjectiveVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTopicObjectiveVerEN objTopicObjectiveVerEN = TopicObjectiveVerDA.GetObjByDataRow(objRow);
 return objTopicObjectiveVerEN;
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
public static clsTopicObjectiveVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTopicObjectiveVerEN objTopicObjectiveVerEN = TopicObjectiveVerDA.GetObjByDataRow(objRow);
 return objTopicObjectiveVerEN;
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
 /// <param name = "lngTopicObjectiveVId">所给的关键字</param>
 /// <param name = "lstTopicObjectiveVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTopicObjectiveVerEN GetObjByTopicObjectiveVIdFromList(long lngTopicObjectiveVId, List<clsTopicObjectiveVerEN> lstTopicObjectiveVerObjLst)
{
foreach (clsTopicObjectiveVerEN objTopicObjectiveVerEN in lstTopicObjectiveVerObjLst)
{
if (objTopicObjectiveVerEN.TopicObjectiveVId == lngTopicObjectiveVId)
{
return objTopicObjectiveVerEN;
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
 long lngTopicObjectiveVId;
 try
 {
 lngTopicObjectiveVId = new clsTopicObjectiveVerDA().GetFirstID(strWhereCond);
 return lngTopicObjectiveVId;
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
 arrList = TopicObjectiveVerDA.GetID(strWhereCond);
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
bool bolIsExist = TopicObjectiveVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngTopicObjectiveVId)
{
//检测记录是否存在
bool bolIsExist = TopicObjectiveVerDA.IsExist(lngTopicObjectiveVId);
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
 bolIsExist = clsTopicObjectiveVerDA.IsExistTable();
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
 bolIsExist = TopicObjectiveVerDA.IsExistTable(strTabName);
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
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTopicObjectiveVerEN objTopicObjectiveVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTopicObjectiveVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题客观版本Id = [{0}]的数据已经存在!(in clsTopicObjectiveVerBL.AddNewRecordBySql2)", objTopicObjectiveVerEN.TopicObjectiveVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = TopicObjectiveVerDA.AddNewRecordBySQL2(objTopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTopicObjectiveVerEN objTopicObjectiveVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTopicObjectiveVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题客观版本Id = [{0}]的数据已经存在!(in clsTopicObjectiveVerBL.AddNewRecordBySql2WithReturnKey)", objTopicObjectiveVerEN.TopicObjectiveVId);
throw new Exception(strMsg);
}
try
{
string strKey = TopicObjectiveVerDA.AddNewRecordBySQL2WithReturnKey(objTopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
try
{
bool bolResult = TopicObjectiveVerDA.Update(objTopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 if (objTopicObjectiveVerEN.TopicObjectiveVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TopicObjectiveVerDA.UpdateBySql2(objTopicObjectiveVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTopicObjectiveVerBL.ReFreshCache();

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngTopicObjectiveVId)
{
try
{
 clsTopicObjectiveVerEN objTopicObjectiveVerEN = clsTopicObjectiveVerBL.GetObjByTopicObjectiveVId(lngTopicObjectiveVId);

if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(objTopicObjectiveVerEN.TopicObjectiveVId, "SetUpdDate");
}
if (objTopicObjectiveVerEN != null)
{
int intRecNum = TopicObjectiveVerDA.DelRecord(lngTopicObjectiveVId);
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
/// <param name="lngTopicObjectiveVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngTopicObjectiveVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
//删除与表:[TopicObjectiveVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTopicObjectiveVer.TopicObjectiveVId,
//lngTopicObjectiveVId);
//        clsTopicObjectiveVerBL.DelTopicObjectiveVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTopicObjectiveVerBL.DelRecord(lngTopicObjectiveVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTopicObjectiveVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngTopicObjectiveVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngTopicObjectiveVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTopicObjectiveVerBL.relatedActions != null)
{
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(lngTopicObjectiveVId, "UpdRelaTabDate");
}
bool bolResult = TopicObjectiveVerDA.DelRecord(lngTopicObjectiveVId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTopicObjectiveVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTopicObjectiveVers(List<string> arrTopicObjectiveVIdLst)
{
if (arrTopicObjectiveVIdLst.Count == 0) return 0;
try
{
if (clsTopicObjectiveVerBL.relatedActions != null)
{
foreach (var strTopicObjectiveVId in arrTopicObjectiveVIdLst)
{
long lngTopicObjectiveVId = long.Parse(strTopicObjectiveVId);
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(lngTopicObjectiveVId, "UpdRelaTabDate");
}
}
int intDelRecNum = TopicObjectiveVerDA.DelTopicObjectiveVer(arrTopicObjectiveVIdLst);
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
public static int DelTopicObjectiveVersByCond(string strWhereCond)
{
try
{
if (clsTopicObjectiveVerBL.relatedActions != null)
{
List<string> arrTopicObjectiveVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTopicObjectiveVId in arrTopicObjectiveVId)
{
long lngTopicObjectiveVId = long.Parse(strTopicObjectiveVId);
clsTopicObjectiveVerBL.relatedActions.UpdRelaTabDate(lngTopicObjectiveVId, "UpdRelaTabDate");
}
}
int intRecNum = TopicObjectiveVerDA.DelTopicObjectiveVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TopicObjectiveVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngTopicObjectiveVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngTopicObjectiveVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
//删除与表:[TopicObjectiveVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTopicObjectiveVerBL.DelRecord(lngTopicObjectiveVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTopicObjectiveVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngTopicObjectiveVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTopicObjectiveVerENS">源对象</param>
 /// <param name = "objTopicObjectiveVerENT">目标对象</param>
 public static void CopyTo(clsTopicObjectiveVerEN objTopicObjectiveVerENS, clsTopicObjectiveVerEN objTopicObjectiveVerENT)
{
try
{
objTopicObjectiveVerENT.TopicObjectiveVId = objTopicObjectiveVerENS.TopicObjectiveVId; //主题客观版本Id
objTopicObjectiveVerENT.TopicObjectiveId = objTopicObjectiveVerENS.TopicObjectiveId; //客观Id
objTopicObjectiveVerENT.ObjectiveName = objTopicObjectiveVerENS.ObjectiveName; //客观名称
objTopicObjectiveVerENT.ObjectiveContent = objTopicObjectiveVerENS.ObjectiveContent; //客观内容
objTopicObjectiveVerENT.ObjectiveType = objTopicObjectiveVerENS.ObjectiveType; //客观类型
objTopicObjectiveVerENT.Conclusion = objTopicObjectiveVerENS.Conclusion; //结论
objTopicObjectiveVerENT.SourceId = objTopicObjectiveVerENS.SourceId; //来源Id
objTopicObjectiveVerENT.UpdDate = objTopicObjectiveVerENS.UpdDate; //修改日期
objTopicObjectiveVerENT.UpdUser = objTopicObjectiveVerENS.UpdUser; //修改人
objTopicObjectiveVerENT.IdCurrEduCls = objTopicObjectiveVerENS.IdCurrEduCls; //教学班流水号
objTopicObjectiveVerENT.PdfContent = objTopicObjectiveVerENS.PdfContent; //Pdf内容
objTopicObjectiveVerENT.PdfPageNum = objTopicObjectiveVerENS.PdfPageNum; //Pdf页码
objTopicObjectiveVerENT.Memo = objTopicObjectiveVerENS.Memo; //备注
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
 /// <param name = "objTopicObjectiveVerEN">源简化对象</param>
 public static void SetUpdFlag(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
try
{
objTopicObjectiveVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTopicObjectiveVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTopicObjectiveVer.TopicObjectiveVId, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.TopicObjectiveVId = objTopicObjectiveVerEN.TopicObjectiveVId; //主题客观版本Id
}
if (arrFldSet.Contains(conTopicObjectiveVer.TopicObjectiveId, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.TopicObjectiveId = objTopicObjectiveVerEN.TopicObjectiveId; //客观Id
}
if (arrFldSet.Contains(conTopicObjectiveVer.ObjectiveName, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.ObjectiveName = objTopicObjectiveVerEN.ObjectiveName == "[null]" ? null :  objTopicObjectiveVerEN.ObjectiveName; //客观名称
}
if (arrFldSet.Contains(conTopicObjectiveVer.ObjectiveContent, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.ObjectiveContent = objTopicObjectiveVerEN.ObjectiveContent == "[null]" ? null :  objTopicObjectiveVerEN.ObjectiveContent; //客观内容
}
if (arrFldSet.Contains(conTopicObjectiveVer.ObjectiveType, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.ObjectiveType = objTopicObjectiveVerEN.ObjectiveType == "[null]" ? null :  objTopicObjectiveVerEN.ObjectiveType; //客观类型
}
if (arrFldSet.Contains(conTopicObjectiveVer.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.Conclusion = objTopicObjectiveVerEN.Conclusion == "[null]" ? null :  objTopicObjectiveVerEN.Conclusion; //结论
}
if (arrFldSet.Contains(conTopicObjectiveVer.SourceId, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.SourceId = objTopicObjectiveVerEN.SourceId == "[null]" ? null :  objTopicObjectiveVerEN.SourceId; //来源Id
}
if (arrFldSet.Contains(conTopicObjectiveVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.UpdDate = objTopicObjectiveVerEN.UpdDate == "[null]" ? null :  objTopicObjectiveVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conTopicObjectiveVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.UpdUser = objTopicObjectiveVerEN.UpdUser == "[null]" ? null :  objTopicObjectiveVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conTopicObjectiveVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.IdCurrEduCls = objTopicObjectiveVerEN.IdCurrEduCls == "[null]" ? null :  objTopicObjectiveVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conTopicObjectiveVer.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.PdfContent = objTopicObjectiveVerEN.PdfContent == "[null]" ? null :  objTopicObjectiveVerEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conTopicObjectiveVer.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.PdfPageNum = objTopicObjectiveVerEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conTopicObjectiveVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTopicObjectiveVerEN.Memo = objTopicObjectiveVerEN.Memo == "[null]" ? null :  objTopicObjectiveVerEN.Memo; //备注
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
 /// <param name = "objTopicObjectiveVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
try
{
if (objTopicObjectiveVerEN.ObjectiveName == "[null]") objTopicObjectiveVerEN.ObjectiveName = null; //客观名称
if (objTopicObjectiveVerEN.ObjectiveContent == "[null]") objTopicObjectiveVerEN.ObjectiveContent = null; //客观内容
if (objTopicObjectiveVerEN.ObjectiveType == "[null]") objTopicObjectiveVerEN.ObjectiveType = null; //客观类型
if (objTopicObjectiveVerEN.Conclusion == "[null]") objTopicObjectiveVerEN.Conclusion = null; //结论
if (objTopicObjectiveVerEN.SourceId == "[null]") objTopicObjectiveVerEN.SourceId = null; //来源Id
if (objTopicObjectiveVerEN.UpdDate == "[null]") objTopicObjectiveVerEN.UpdDate = null; //修改日期
if (objTopicObjectiveVerEN.UpdUser == "[null]") objTopicObjectiveVerEN.UpdUser = null; //修改人
if (objTopicObjectiveVerEN.IdCurrEduCls == "[null]") objTopicObjectiveVerEN.IdCurrEduCls = null; //教学班流水号
if (objTopicObjectiveVerEN.PdfContent == "[null]") objTopicObjectiveVerEN.PdfContent = null; //Pdf内容
if (objTopicObjectiveVerEN.Memo == "[null]") objTopicObjectiveVerEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 TopicObjectiveVerDA.CheckPropertyNew(objTopicObjectiveVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 TopicObjectiveVerDA.CheckProperty4Condition(objTopicObjectiveVerEN);
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
if (clsTopicObjectiveVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTopicObjectiveVerBL没有刷新缓存机制(clsTopicObjectiveVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TopicObjectiveVId");
//if (arrTopicObjectiveVerObjLstCache == null)
//{
//arrTopicObjectiveVerObjLstCache = TopicObjectiveVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTopicObjectiveVerEN GetObjByTopicObjectiveVIdCache(long lngTopicObjectiveVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTopicObjectiveVerEN._CurrTabName);
List<clsTopicObjectiveVerEN> arrTopicObjectiveVerObjLstCache = GetObjLstCache();
IEnumerable <clsTopicObjectiveVerEN> arrTopicObjectiveVerObjLst_Sel =
arrTopicObjectiveVerObjLstCache
.Where(x=> x.TopicObjectiveVId == lngTopicObjectiveVId 
);
if (arrTopicObjectiveVerObjLst_Sel.Count() == 0)
{
   clsTopicObjectiveVerEN obj = clsTopicObjectiveVerBL.GetObjByTopicObjectiveVId(lngTopicObjectiveVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTopicObjectiveVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTopicObjectiveVerEN> GetAllTopicObjectiveVerObjLstCache()
{
//获取缓存中的对象列表
List<clsTopicObjectiveVerEN> arrTopicObjectiveVerObjLstCache = GetObjLstCache(); 
return arrTopicObjectiveVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTopicObjectiveVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTopicObjectiveVerEN._CurrTabName);
List<clsTopicObjectiveVerEN> arrTopicObjectiveVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTopicObjectiveVerObjLstCache;
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
string strKey = string.Format("{0}", clsTopicObjectiveVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTopicObjectiveVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTopicObjectiveVerEN._RefreshTimeLst.Count == 0) return "";
return clsTopicObjectiveVerEN._RefreshTimeLst[clsTopicObjectiveVerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsTopicObjectiveVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTopicObjectiveVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTopicObjectiveVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTopicObjectiveVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TopicObjectiveVer(主题客观版本)
 /// 唯一性条件:TopicObjectiveVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
//检测记录是否存在
string strResult = TopicObjectiveVerDA.GetUniCondStr(objTopicObjectiveVerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngTopicObjectiveVId)
{
if (strInFldName != conTopicObjectiveVer.TopicObjectiveVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTopicObjectiveVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTopicObjectiveVer.AttributeName));
throw new Exception(strMsg);
}
var objTopicObjectiveVer = clsTopicObjectiveVerBL.GetObjByTopicObjectiveVIdCache(lngTopicObjectiveVId);
if (objTopicObjectiveVer == null) return "";
return objTopicObjectiveVer[strOutFldName].ToString();
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
int intRecCount = clsTopicObjectiveVerDA.GetRecCount(strTabName);
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
int intRecCount = clsTopicObjectiveVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTopicObjectiveVerDA.GetRecCount();
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
int intRecCount = clsTopicObjectiveVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTopicObjectiveVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTopicObjectiveVerEN objTopicObjectiveVerCond)
{
List<clsTopicObjectiveVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTopicObjectiveVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTopicObjectiveVer.AttributeName)
{
if (objTopicObjectiveVerCond.IsUpdated(strFldName) == false) continue;
if (objTopicObjectiveVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTopicObjectiveVerCond[strFldName].ToString());
}
else
{
if (objTopicObjectiveVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTopicObjectiveVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTopicObjectiveVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTopicObjectiveVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTopicObjectiveVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTopicObjectiveVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTopicObjectiveVerCond[strFldName]));
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
 List<string> arrList = clsTopicObjectiveVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TopicObjectiveVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TopicObjectiveVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TopicObjectiveVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTopicObjectiveVerDA.SetFldValue(clsTopicObjectiveVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TopicObjectiveVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTopicObjectiveVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTopicObjectiveVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTopicObjectiveVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TopicObjectiveVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**主题客观版本Id*/ 
 strCreateTabCode.Append(" TopicObjectiveVId bigint primary key identity, "); 
 // /**客观Id*/ 
 strCreateTabCode.Append(" TopicObjectiveId char(8) not Null, "); 
 // /**客观名称*/ 
 strCreateTabCode.Append(" ObjectiveName varchar(500) Null, "); 
 // /**客观内容*/ 
 strCreateTabCode.Append(" ObjectiveContent text Null, "); 
 // /**客观类型*/ 
 strCreateTabCode.Append(" ObjectiveType char(2) Null, "); 
 // /**结论*/ 
 strCreateTabCode.Append(" Conclusion varchar(5000) Null, "); 
 // /**来源Id*/ 
 strCreateTabCode.Append(" SourceId char(10) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 主题客观版本(TopicObjectiveVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TopicObjectiveVer : clsCommFun4BL
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
clsTopicObjectiveVerBL.ReFreshThisCache();
}
}

}