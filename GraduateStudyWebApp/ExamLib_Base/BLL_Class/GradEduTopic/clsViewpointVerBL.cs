
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewpointVerBL
 表名:ViewpointVer(01120650)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:33
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
public static class  clsViewpointVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewpointVerEN GetObj(this K_ViewpointVId_ViewpointVer myKey)
{
clsViewpointVerEN objViewpointVerEN = clsViewpointVerBL.ViewpointVerDA.GetObjByViewpointVId(myKey.Value);
return objViewpointVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewpointVerEN objViewpointVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewpointVerEN) == false)
{
var strMsg = string.Format("记录已经存在!ViewpointVId = [{0}]的数据已经存在!(in clsViewpointVerBL.AddNewRecord)", objViewpointVerEN.ViewpointVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsViewpointVerBL.ViewpointVerDA.AddNewRecordBySQL2(objViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
public static bool AddRecordEx(this clsViewpointVerEN objViewpointVerEN, bool bolIsNeedCheckUniqueness = true)
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
objViewpointVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objViewpointVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(ViewpointVId(ViewpointVId)=[{0}])已经存在,不能重复!", objViewpointVerEN.ViewpointVId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objViewpointVerEN.AddNewRecord();
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
 /// <param name = "objViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewpointVerEN objViewpointVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objViewpointVerEN) == false)
{
var strMsg = string.Format("记录已经存在!ViewpointVId = [{0}]的数据已经存在!(in clsViewpointVerBL.AddNewRecordWithReturnKey)", objViewpointVerEN.ViewpointVId);
throw new Exception(strMsg);
}
try
{
string strKey = clsViewpointVerBL.ViewpointVerDA.AddNewRecordBySQL2WithReturnKey(objViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetViewpointVId(this clsViewpointVerEN objViewpointVerEN, long lngViewpointVId, string strComparisonOp="")
	{
objViewpointVerEN.ViewpointVId = lngViewpointVId; //ViewpointVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.ViewpointVId) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.ViewpointVId, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.ViewpointVId] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetViewpointId(this clsViewpointVerEN objViewpointVerEN, string strViewpointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewpointId, conViewpointVer.ViewpointId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, conViewpointVer.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, conViewpointVer.ViewpointId);
}
objViewpointVerEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.ViewpointId) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.ViewpointId, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.ViewpointId] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetViewpointName(this clsViewpointVerEN objViewpointVerEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, conViewpointVer.ViewpointName);
}
objViewpointVerEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.ViewpointName) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.ViewpointName, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.ViewpointName] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetViewpointContent(this clsViewpointVerEN objViewpointVerEN, string strViewpointContent, string strComparisonOp="")
	{
objViewpointVerEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.ViewpointContent) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.ViewpointContent, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.ViewpointContent] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetViewpointTypeId(this clsViewpointVerEN objViewpointVerEN, string strViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeId, 4, conViewpointVer.ViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointTypeId, 4, conViewpointVer.ViewpointTypeId);
}
objViewpointVerEN.ViewpointTypeId = strViewpointTypeId; //观点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.ViewpointTypeId) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.ViewpointTypeId, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.ViewpointTypeId] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetReason(this clsViewpointVerEN objViewpointVerEN, string strReason, string strComparisonOp="")
	{
objViewpointVerEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.Reason) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.Reason, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.Reason] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetSource(this clsViewpointVerEN objViewpointVerEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 500, conViewpointVer.Source);
}
objViewpointVerEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.Source) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.Source, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.Source] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetVPProposePeople(this clsViewpointVerEN objViewpointVerEN, string strVPProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVPProposePeople, 50, conViewpointVer.VPProposePeople);
}
objViewpointVerEN.VPProposePeople = strVPProposePeople; //观点提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.VPProposePeople) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.VPProposePeople, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.VPProposePeople] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetUserTypeId(this clsViewpointVerEN objViewpointVerEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conViewpointVer.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conViewpointVer.UserTypeId);
}
objViewpointVerEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.UserTypeId) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.UserTypeId, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.UserTypeId] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetCitationId(this clsViewpointVerEN objViewpointVerEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, conViewpointVer.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, conViewpointVer.CitationId);
}
objViewpointVerEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.CitationId) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.CitationId, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.CitationId] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetUpdDate(this clsViewpointVerEN objViewpointVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewpointVer.UpdDate);
}
objViewpointVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.UpdDate) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.UpdDate, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.UpdDate] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetUpdUser(this clsViewpointVerEN objViewpointVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewpointVer.UpdUser);
}
objViewpointVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.UpdUser) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.UpdUser, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.UpdUser] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetPdfContent(this clsViewpointVerEN objViewpointVerEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conViewpointVer.PdfContent);
}
objViewpointVerEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.PdfContent) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.PdfContent, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.PdfContent] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetPdfPageNum(this clsViewpointVerEN objViewpointVerEN, int? intPdfPageNum, string strComparisonOp="")
	{
objViewpointVerEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.PdfPageNum) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.PdfPageNum, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.PdfPageNum] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetIdCurrEduCls(this clsViewpointVerEN objViewpointVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conViewpointVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conViewpointVer.IdCurrEduCls);
}
objViewpointVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.IdCurrEduCls) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.IdCurrEduCls, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.IdCurrEduCls] = strComparisonOp;
}
}
return objViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewpointVerEN SetMemo(this clsViewpointVerEN objViewpointVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewpointVer.Memo);
}
objViewpointVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewpointVerEN.dicFldComparisonOp.ContainsKey(conViewpointVer.Memo) == false)
{
objViewpointVerEN.dicFldComparisonOp.Add(conViewpointVer.Memo, strComparisonOp);
}
else
{
objViewpointVerEN.dicFldComparisonOp[conViewpointVer.Memo] = strComparisonOp;
}
}
return objViewpointVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewpointVerEN objViewpointVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewpointVerEN.CheckPropertyNew();
clsViewpointVerEN objViewpointVerCond = new clsViewpointVerEN();
string strCondition = objViewpointVerCond
.SetViewpointVId(objViewpointVerEN.ViewpointVId, "<>")
.SetViewpointVId(objViewpointVerEN.ViewpointVId, "=")
.GetCombineCondition();
objViewpointVerEN._IsCheckProperty = true;
bool bolIsExist = clsViewpointVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ViewpointVId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewpointVerEN.Update();
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
 /// <param name = "objViewpointVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsViewpointVerEN objViewpointVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsViewpointVerEN objViewpointVerCond = new clsViewpointVerEN();
string strCondition = objViewpointVerCond
.SetViewpointVId(objViewpointVer.ViewpointVId, "=")
.GetCombineCondition();
objViewpointVer._IsCheckProperty = true;
bool bolIsExist = clsViewpointVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objViewpointVer.ViewpointVId = clsViewpointVerBL.GetFirstID_S(strCondition);
objViewpointVer.UpdateWithCondition(strCondition);
}
else
{
objViewpointVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewpointVerEN objViewpointVerEN)
{
 if (objViewpointVerEN.ViewpointVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewpointVerBL.ViewpointVerDA.UpdateBySql2(objViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objViewpointVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewpointVerEN objViewpointVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objViewpointVerEN.ViewpointVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewpointVerBL.ViewpointVerDA.UpdateBySql2(objViewpointVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objViewpointVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewpointVerEN objViewpointVerEN, string strWhereCond)
{
try
{
bool bolResult = clsViewpointVerBL.ViewpointVerDA.UpdateBySqlWithCondition(objViewpointVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objViewpointVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewpointVerEN objViewpointVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewpointVerBL.ViewpointVerDA.UpdateBySqlWithConditionTransaction(objViewpointVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "lngViewpointVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewpointVerEN objViewpointVerEN)
{
try
{
int intRecNum = clsViewpointVerBL.ViewpointVerDA.DelRecord(objViewpointVerEN.ViewpointVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objViewpointVerENS">源对象</param>
 /// <param name = "objViewpointVerENT">目标对象</param>
 public static void CopyTo(this clsViewpointVerEN objViewpointVerENS, clsViewpointVerEN objViewpointVerENT)
{
try
{
objViewpointVerENT.ViewpointVId = objViewpointVerENS.ViewpointVId; //ViewpointVId
objViewpointVerENT.ViewpointId = objViewpointVerENS.ViewpointId; //观点Id
objViewpointVerENT.ViewpointName = objViewpointVerENS.ViewpointName; //观点名称
objViewpointVerENT.ViewpointContent = objViewpointVerENS.ViewpointContent; //观点内容
objViewpointVerENT.ViewpointTypeId = objViewpointVerENS.ViewpointTypeId; //观点类型Id
objViewpointVerENT.Reason = objViewpointVerENS.Reason; //理由
objViewpointVerENT.Source = objViewpointVerENS.Source; //来源
objViewpointVerENT.VPProposePeople = objViewpointVerENS.VPProposePeople; //观点提出人
objViewpointVerENT.UserTypeId = objViewpointVerENS.UserTypeId; //用户类型Id
objViewpointVerENT.CitationId = objViewpointVerENS.CitationId; //引用Id
objViewpointVerENT.UpdDate = objViewpointVerENS.UpdDate; //修改日期
objViewpointVerENT.UpdUser = objViewpointVerENS.UpdUser; //修改人
objViewpointVerENT.PdfContent = objViewpointVerENS.PdfContent; //Pdf内容
objViewpointVerENT.PdfPageNum = objViewpointVerENS.PdfPageNum; //Pdf页码
objViewpointVerENT.IdCurrEduCls = objViewpointVerENS.IdCurrEduCls; //教学班流水号
objViewpointVerENT.Memo = objViewpointVerENS.Memo; //备注
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
 /// <param name = "objViewpointVerENS">源对象</param>
 /// <returns>目标对象=>clsViewpointVerEN:objViewpointVerENT</returns>
 public static clsViewpointVerEN CopyTo(this clsViewpointVerEN objViewpointVerENS)
{
try
{
 clsViewpointVerEN objViewpointVerENT = new clsViewpointVerEN()
{
ViewpointVId = objViewpointVerENS.ViewpointVId, //ViewpointVId
ViewpointId = objViewpointVerENS.ViewpointId, //观点Id
ViewpointName = objViewpointVerENS.ViewpointName, //观点名称
ViewpointContent = objViewpointVerENS.ViewpointContent, //观点内容
ViewpointTypeId = objViewpointVerENS.ViewpointTypeId, //观点类型Id
Reason = objViewpointVerENS.Reason, //理由
Source = objViewpointVerENS.Source, //来源
VPProposePeople = objViewpointVerENS.VPProposePeople, //观点提出人
UserTypeId = objViewpointVerENS.UserTypeId, //用户类型Id
CitationId = objViewpointVerENS.CitationId, //引用Id
UpdDate = objViewpointVerENS.UpdDate, //修改日期
UpdUser = objViewpointVerENS.UpdUser, //修改人
PdfContent = objViewpointVerENS.PdfContent, //Pdf内容
PdfPageNum = objViewpointVerENS.PdfPageNum, //Pdf页码
IdCurrEduCls = objViewpointVerENS.IdCurrEduCls, //教学班流水号
Memo = objViewpointVerENS.Memo, //备注
};
 return objViewpointVerENT;
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
public static void CheckPropertyNew(this clsViewpointVerEN objViewpointVerEN)
{
 clsViewpointVerBL.ViewpointVerDA.CheckPropertyNew(objViewpointVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewpointVerEN objViewpointVerEN)
{
 clsViewpointVerBL.ViewpointVerDA.CheckProperty4Condition(objViewpointVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewpointVerEN objViewpointVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewpointVerCond.IsUpdated(conViewpointVer.ViewpointVId) == true)
{
string strComparisonOpViewpointVId = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.ViewpointVId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewpointVer.ViewpointVId, objViewpointVerCond.ViewpointVId, strComparisonOpViewpointVId);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.ViewpointId) == true)
{
string strComparisonOpViewpointId = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.ViewpointId, objViewpointVerCond.ViewpointId, strComparisonOpViewpointId);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.ViewpointName) == true)
{
string strComparisonOpViewpointName = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.ViewpointName, objViewpointVerCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objViewpointVerCond.IsUpdated(conViewpointVer.ViewpointTypeId) == true)
{
string strComparisonOpViewpointTypeId = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.ViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.ViewpointTypeId, objViewpointVerCond.ViewpointTypeId, strComparisonOpViewpointTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objViewpointVerCond.IsUpdated(conViewpointVer.Source) == true)
{
string strComparisonOpSource = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.Source, objViewpointVerCond.Source, strComparisonOpSource);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.VPProposePeople) == true)
{
string strComparisonOpVPProposePeople = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.VPProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.VPProposePeople, objViewpointVerCond.VPProposePeople, strComparisonOpVPProposePeople);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.UserTypeId, objViewpointVerCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.CitationId) == true)
{
string strComparisonOpCitationId = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.CitationId, objViewpointVerCond.CitationId, strComparisonOpCitationId);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.UpdDate, objViewpointVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.UpdUser, objViewpointVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.PdfContent) == true)
{
string strComparisonOpPdfContent = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.PdfContent, objViewpointVerCond.PdfContent, strComparisonOpPdfContent);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewpointVer.PdfPageNum, objViewpointVerCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.IdCurrEduCls, objViewpointVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objViewpointVerCond.IsUpdated(conViewpointVer.Memo) == true)
{
string strComparisonOpMemo = objViewpointVerCond.dicFldComparisonOp[conViewpointVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewpointVer.Memo, objViewpointVerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ViewpointVer(观点版本表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ViewpointVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objViewpointVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsViewpointVerEN objViewpointVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objViewpointVerEN == null) return true;
if (objViewpointVerEN.ViewpointVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointVId = '{0}'", objViewpointVerEN.ViewpointVId);
if (clsViewpointVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewpointVId !=  {0}", objViewpointVerEN.ViewpointVId);
 sbCondition.AppendFormat(" and ViewpointVId = '{0}'", objViewpointVerEN.ViewpointVId);
if (clsViewpointVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ViewpointVer(观点版本表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewpointVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewpointVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsViewpointVerEN objViewpointVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewpointVerEN == null) return "";
if (objViewpointVerEN.ViewpointVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointVId = '{0}'", objViewpointVerEN.ViewpointVId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointVId !=  {0}", objViewpointVerEN.ViewpointVId);
 sbCondition.AppendFormat(" and ViewpointVId = '{0}'", objViewpointVerEN.ViewpointVId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewpointVer
{
public virtual bool UpdRelaTabDate(long lngViewpointVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 观点版本表(ViewpointVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewpointVerBL
{
public static RelatedActions_ViewpointVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewpointVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewpointVerDA ViewpointVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewpointVerDA();
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
 public clsViewpointVerBL()
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
if (string.IsNullOrEmpty(clsViewpointVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewpointVerEN._ConnectString);
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
public static DataTable GetDataTable_ViewpointVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewpointVerDA.GetDataTable_ViewpointVer(strWhereCond);
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
objDT = ViewpointVerDA.GetDataTable(strWhereCond);
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
objDT = ViewpointVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewpointVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewpointVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewpointVerDA.GetDataTable_Top(objTopPara);
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
objDT = ViewpointVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewpointVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewpointVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewpointVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsViewpointVerEN> GetObjLstByViewpointVIdLst(List<long> arrViewpointVIdLst)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewpointVIdLst);
 string strWhereCond = string.Format("ViewpointVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewpointVerEN> GetObjLstByViewpointVIdLstCache(List<long> arrViewpointVIdLst)
{
string strKey = string.Format("{0}", clsViewpointVerEN._CurrTabName);
List<clsViewpointVerEN> arrViewpointVerObjLstCache = GetObjLstCache();
IEnumerable <clsViewpointVerEN> arrViewpointVerObjLst_Sel =
arrViewpointVerObjLstCache
.Where(x => arrViewpointVIdLst.Contains(x.ViewpointVId));
return arrViewpointVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewpointVerEN> GetObjLst(string strWhereCond)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
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
public static List<clsViewpointVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewpointVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewpointVerEN> GetSubObjLstCache(clsViewpointVerEN objViewpointVerCond)
{
List<clsViewpointVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewpointVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewpointVer.AttributeName)
{
if (objViewpointVerCond.IsUpdated(strFldName) == false) continue;
if (objViewpointVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewpointVerCond[strFldName].ToString());
}
else
{
if (objViewpointVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewpointVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewpointVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewpointVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewpointVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewpointVerCond[strFldName]));
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
public static List<clsViewpointVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
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
public static List<clsViewpointVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
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
List<clsViewpointVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewpointVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewpointVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewpointVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
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
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
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
public static List<clsViewpointVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewpointVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewpointVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
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
public static List<clsViewpointVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewpointVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewpointVerEN> arrObjLst = new List<clsViewpointVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewpointVerEN objViewpointVerEN = new clsViewpointVerEN();
try
{
objViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objViewpointVerEN.ViewpointId = objRow[conViewpointVer.ViewpointId].ToString().Trim(); //观点Id
objViewpointVerEN.ViewpointName = objRow[conViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objViewpointVerEN.ViewpointContent = objRow[conViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objViewpointVerEN.ViewpointTypeId = objRow[conViewpointVer.ViewpointTypeId] == DBNull.Value ? null : objRow[conViewpointVer.ViewpointTypeId].ToString().Trim(); //观点类型Id
objViewpointVerEN.Reason = objRow[conViewpointVer.Reason] == DBNull.Value ? null : objRow[conViewpointVer.Reason].ToString().Trim(); //理由
objViewpointVerEN.Source = objRow[conViewpointVer.Source] == DBNull.Value ? null : objRow[conViewpointVer.Source].ToString().Trim(); //来源
objViewpointVerEN.VPProposePeople = objRow[conViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objViewpointVerEN.UserTypeId = objRow[conViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objViewpointVerEN.CitationId = objRow[conViewpointVer.CitationId] == DBNull.Value ? null : objRow[conViewpointVer.CitationId].ToString().Trim(); //引用Id
objViewpointVerEN.UpdDate = objRow[conViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conViewpointVer.UpdDate].ToString().Trim(); //修改日期
objViewpointVerEN.UpdUser = objRow[conViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conViewpointVer.UpdUser].ToString().Trim(); //修改人
objViewpointVerEN.PdfContent = objRow[conViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objViewpointVerEN.PdfPageNum = objRow[conViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objViewpointVerEN.IdCurrEduCls = objRow[conViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objViewpointVerEN.Memo = objRow[conViewpointVer.Memo] == DBNull.Value ? null : objRow[conViewpointVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewpointVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewpointVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewpointVer(ref clsViewpointVerEN objViewpointVerEN)
{
bool bolResult = ViewpointVerDA.GetViewpointVer(ref objViewpointVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewpointVerEN GetObjByViewpointVId(long lngViewpointVId)
{
clsViewpointVerEN objViewpointVerEN = ViewpointVerDA.GetObjByViewpointVId(lngViewpointVId);
return objViewpointVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewpointVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewpointVerEN objViewpointVerEN = ViewpointVerDA.GetFirstObj(strWhereCond);
 return objViewpointVerEN;
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
public static clsViewpointVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewpointVerEN objViewpointVerEN = ViewpointVerDA.GetObjByDataRow(objRow);
 return objViewpointVerEN;
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
public static clsViewpointVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewpointVerEN objViewpointVerEN = ViewpointVerDA.GetObjByDataRow(objRow);
 return objViewpointVerEN;
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
 /// <param name = "lngViewpointVId">所给的关键字</param>
 /// <param name = "lstViewpointVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewpointVerEN GetObjByViewpointVIdFromList(long lngViewpointVId, List<clsViewpointVerEN> lstViewpointVerObjLst)
{
foreach (clsViewpointVerEN objViewpointVerEN in lstViewpointVerObjLst)
{
if (objViewpointVerEN.ViewpointVId == lngViewpointVId)
{
return objViewpointVerEN;
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
 long lngViewpointVId;
 try
 {
 lngViewpointVId = new clsViewpointVerDA().GetFirstID(strWhereCond);
 return lngViewpointVId;
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
 arrList = ViewpointVerDA.GetID(strWhereCond);
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
bool bolIsExist = ViewpointVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngViewpointVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngViewpointVId)
{
//检测记录是否存在
bool bolIsExist = ViewpointVerDA.IsExist(lngViewpointVId);
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
 bolIsExist = clsViewpointVerDA.IsExistTable();
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
 bolIsExist = ViewpointVerDA.IsExistTable(strTabName);
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
 /// <param name = "objViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewpointVerEN objViewpointVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewpointVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!ViewpointVId = [{0}]的数据已经存在!(in clsViewpointVerBL.AddNewRecordBySql2)", objViewpointVerEN.ViewpointVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ViewpointVerDA.AddNewRecordBySQL2(objViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewpointVerEN objViewpointVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objViewpointVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!ViewpointVId = [{0}]的数据已经存在!(in clsViewpointVerBL.AddNewRecordBySql2WithReturnKey)", objViewpointVerEN.ViewpointVId);
throw new Exception(strMsg);
}
try
{
string strKey = ViewpointVerDA.AddNewRecordBySQL2WithReturnKey(objViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewpointVerEN objViewpointVerEN)
{
try
{
bool bolResult = ViewpointVerDA.Update(objViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewpointVerEN objViewpointVerEN)
{
 if (objViewpointVerEN.ViewpointVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewpointVerDA.UpdateBySql2(objViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewpointVerBL.ReFreshCache();

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "lngViewpointVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngViewpointVId)
{
try
{
 clsViewpointVerEN objViewpointVerEN = clsViewpointVerBL.GetObjByViewpointVId(lngViewpointVId);

if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(objViewpointVerEN.ViewpointVId, "SetUpdDate");
}
if (objViewpointVerEN != null)
{
int intRecNum = ViewpointVerDA.DelRecord(lngViewpointVId);
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
/// <param name="lngViewpointVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngViewpointVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewpointVerDA.GetSpecSQLObj();
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
//删除与表:[ViewpointVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewpointVer.ViewpointVId,
//lngViewpointVId);
//        clsViewpointVerBL.DelViewpointVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewpointVerBL.DelRecord(lngViewpointVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewpointVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngViewpointVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngViewpointVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngViewpointVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewpointVerBL.relatedActions != null)
{
clsViewpointVerBL.relatedActions.UpdRelaTabDate(lngViewpointVId, "UpdRelaTabDate");
}
bool bolResult = ViewpointVerDA.DelRecord(lngViewpointVId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrViewpointVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelViewpointVers(List<string> arrViewpointVIdLst)
{
if (arrViewpointVIdLst.Count == 0) return 0;
try
{
if (clsViewpointVerBL.relatedActions != null)
{
foreach (var strViewpointVId in arrViewpointVIdLst)
{
long lngViewpointVId = long.Parse(strViewpointVId);
clsViewpointVerBL.relatedActions.UpdRelaTabDate(lngViewpointVId, "UpdRelaTabDate");
}
}
int intDelRecNum = ViewpointVerDA.DelViewpointVer(arrViewpointVIdLst);
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
public static int DelViewpointVersByCond(string strWhereCond)
{
try
{
if (clsViewpointVerBL.relatedActions != null)
{
List<string> arrViewpointVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewpointVId in arrViewpointVId)
{
long lngViewpointVId = long.Parse(strViewpointVId);
clsViewpointVerBL.relatedActions.UpdRelaTabDate(lngViewpointVId, "UpdRelaTabDate");
}
}
int intRecNum = ViewpointVerDA.DelViewpointVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewpointVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngViewpointVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngViewpointVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewpointVerDA.GetSpecSQLObj();
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
//删除与表:[ViewpointVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewpointVerBL.DelRecord(lngViewpointVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewpointVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngViewpointVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewpointVerENS">源对象</param>
 /// <param name = "objViewpointVerENT">目标对象</param>
 public static void CopyTo(clsViewpointVerEN objViewpointVerENS, clsViewpointVerEN objViewpointVerENT)
{
try
{
objViewpointVerENT.ViewpointVId = objViewpointVerENS.ViewpointVId; //ViewpointVId
objViewpointVerENT.ViewpointId = objViewpointVerENS.ViewpointId; //观点Id
objViewpointVerENT.ViewpointName = objViewpointVerENS.ViewpointName; //观点名称
objViewpointVerENT.ViewpointContent = objViewpointVerENS.ViewpointContent; //观点内容
objViewpointVerENT.ViewpointTypeId = objViewpointVerENS.ViewpointTypeId; //观点类型Id
objViewpointVerENT.Reason = objViewpointVerENS.Reason; //理由
objViewpointVerENT.Source = objViewpointVerENS.Source; //来源
objViewpointVerENT.VPProposePeople = objViewpointVerENS.VPProposePeople; //观点提出人
objViewpointVerENT.UserTypeId = objViewpointVerENS.UserTypeId; //用户类型Id
objViewpointVerENT.CitationId = objViewpointVerENS.CitationId; //引用Id
objViewpointVerENT.UpdDate = objViewpointVerENS.UpdDate; //修改日期
objViewpointVerENT.UpdUser = objViewpointVerENS.UpdUser; //修改人
objViewpointVerENT.PdfContent = objViewpointVerENS.PdfContent; //Pdf内容
objViewpointVerENT.PdfPageNum = objViewpointVerENS.PdfPageNum; //Pdf页码
objViewpointVerENT.IdCurrEduCls = objViewpointVerENS.IdCurrEduCls; //教学班流水号
objViewpointVerENT.Memo = objViewpointVerENS.Memo; //备注
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
 /// <param name = "objViewpointVerEN">源简化对象</param>
 public static void SetUpdFlag(clsViewpointVerEN objViewpointVerEN)
{
try
{
objViewpointVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewpointVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewpointVer.ViewpointVId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.ViewpointVId = objViewpointVerEN.ViewpointVId; //ViewpointVId
}
if (arrFldSet.Contains(conViewpointVer.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.ViewpointId = objViewpointVerEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(conViewpointVer.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.ViewpointName = objViewpointVerEN.ViewpointName == "[null]" ? null :  objViewpointVerEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(conViewpointVer.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.ViewpointContent = objViewpointVerEN.ViewpointContent == "[null]" ? null :  objViewpointVerEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(conViewpointVer.ViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.ViewpointTypeId = objViewpointVerEN.ViewpointTypeId == "[null]" ? null :  objViewpointVerEN.ViewpointTypeId; //观点类型Id
}
if (arrFldSet.Contains(conViewpointVer.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.Reason = objViewpointVerEN.Reason == "[null]" ? null :  objViewpointVerEN.Reason; //理由
}
if (arrFldSet.Contains(conViewpointVer.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.Source = objViewpointVerEN.Source == "[null]" ? null :  objViewpointVerEN.Source; //来源
}
if (arrFldSet.Contains(conViewpointVer.VPProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.VPProposePeople = objViewpointVerEN.VPProposePeople == "[null]" ? null :  objViewpointVerEN.VPProposePeople; //观点提出人
}
if (arrFldSet.Contains(conViewpointVer.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.UserTypeId = objViewpointVerEN.UserTypeId == "[null]" ? null :  objViewpointVerEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(conViewpointVer.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.CitationId = objViewpointVerEN.CitationId == "[null]" ? null :  objViewpointVerEN.CitationId; //引用Id
}
if (arrFldSet.Contains(conViewpointVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.UpdDate = objViewpointVerEN.UpdDate == "[null]" ? null :  objViewpointVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewpointVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.UpdUser = objViewpointVerEN.UpdUser == "[null]" ? null :  objViewpointVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conViewpointVer.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.PdfContent = objViewpointVerEN.PdfContent == "[null]" ? null :  objViewpointVerEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conViewpointVer.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.PdfPageNum = objViewpointVerEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conViewpointVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.IdCurrEduCls = objViewpointVerEN.IdCurrEduCls == "[null]" ? null :  objViewpointVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conViewpointVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewpointVerEN.Memo = objViewpointVerEN.Memo == "[null]" ? null :  objViewpointVerEN.Memo; //备注
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
 /// <param name = "objViewpointVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewpointVerEN objViewpointVerEN)
{
try
{
if (objViewpointVerEN.ViewpointName == "[null]") objViewpointVerEN.ViewpointName = null; //观点名称
if (objViewpointVerEN.ViewpointContent == "[null]") objViewpointVerEN.ViewpointContent = null; //观点内容
if (objViewpointVerEN.ViewpointTypeId == "[null]") objViewpointVerEN.ViewpointTypeId = null; //观点类型Id
if (objViewpointVerEN.Reason == "[null]") objViewpointVerEN.Reason = null; //理由
if (objViewpointVerEN.Source == "[null]") objViewpointVerEN.Source = null; //来源
if (objViewpointVerEN.VPProposePeople == "[null]") objViewpointVerEN.VPProposePeople = null; //观点提出人
if (objViewpointVerEN.UserTypeId == "[null]") objViewpointVerEN.UserTypeId = null; //用户类型Id
if (objViewpointVerEN.CitationId == "[null]") objViewpointVerEN.CitationId = null; //引用Id
if (objViewpointVerEN.UpdDate == "[null]") objViewpointVerEN.UpdDate = null; //修改日期
if (objViewpointVerEN.UpdUser == "[null]") objViewpointVerEN.UpdUser = null; //修改人
if (objViewpointVerEN.PdfContent == "[null]") objViewpointVerEN.PdfContent = null; //Pdf内容
if (objViewpointVerEN.IdCurrEduCls == "[null]") objViewpointVerEN.IdCurrEduCls = null; //教学班流水号
if (objViewpointVerEN.Memo == "[null]") objViewpointVerEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsViewpointVerEN objViewpointVerEN)
{
 ViewpointVerDA.CheckPropertyNew(objViewpointVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewpointVerEN objViewpointVerEN)
{
 ViewpointVerDA.CheckProperty4Condition(objViewpointVerEN);
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
if (clsViewpointVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointVerBL没有刷新缓存机制(clsViewpointVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointVId");
//if (arrViewpointVerObjLstCache == null)
//{
//arrViewpointVerObjLstCache = ViewpointVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngViewpointVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewpointVerEN GetObjByViewpointVIdCache(long lngViewpointVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsViewpointVerEN._CurrTabName);
List<clsViewpointVerEN> arrViewpointVerObjLstCache = GetObjLstCache();
IEnumerable <clsViewpointVerEN> arrViewpointVerObjLst_Sel =
arrViewpointVerObjLstCache
.Where(x=> x.ViewpointVId == lngViewpointVId 
);
if (arrViewpointVerObjLst_Sel.Count() == 0)
{
   clsViewpointVerEN obj = clsViewpointVerBL.GetObjByViewpointVId(lngViewpointVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrViewpointVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewpointVerEN> GetAllViewpointVerObjLstCache()
{
//获取缓存中的对象列表
List<clsViewpointVerEN> arrViewpointVerObjLstCache = GetObjLstCache(); 
return arrViewpointVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewpointVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsViewpointVerEN._CurrTabName);
List<clsViewpointVerEN> arrViewpointVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrViewpointVerObjLstCache;
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
string strKey = string.Format("{0}", clsViewpointVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewpointVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewpointVerEN._RefreshTimeLst.Count == 0) return "";
return clsViewpointVerEN._RefreshTimeLst[clsViewpointVerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsViewpointVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsViewpointVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsViewpointVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewpointVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ViewpointVer(观点版本表)
 /// 唯一性条件:ViewpointVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewpointVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsViewpointVerEN objViewpointVerEN)
{
//检测记录是否存在
string strResult = ViewpointVerDA.GetUniCondStr(objViewpointVerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngViewpointVId)
{
if (strInFldName != conViewpointVer.ViewpointVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewpointVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewpointVer.AttributeName));
throw new Exception(strMsg);
}
var objViewpointVer = clsViewpointVerBL.GetObjByViewpointVIdCache(lngViewpointVId);
if (objViewpointVer == null) return "";
return objViewpointVer[strOutFldName].ToString();
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
int intRecCount = clsViewpointVerDA.GetRecCount(strTabName);
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
int intRecCount = clsViewpointVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewpointVerDA.GetRecCount();
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
int intRecCount = clsViewpointVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewpointVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewpointVerEN objViewpointVerCond)
{
List<clsViewpointVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsViewpointVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewpointVer.AttributeName)
{
if (objViewpointVerCond.IsUpdated(strFldName) == false) continue;
if (objViewpointVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewpointVerCond[strFldName].ToString());
}
else
{
if (objViewpointVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewpointVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewpointVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewpointVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewpointVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewpointVerCond[strFldName]));
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
 List<string> arrList = clsViewpointVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewpointVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewpointVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewpointVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewpointVerDA.SetFldValue(clsViewpointVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewpointVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewpointVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewpointVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewpointVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewpointVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**ViewpointVId*/ 
 strCreateTabCode.Append(" ViewpointVId bigint primary key identity, "); 
 // /**观点Id*/ 
 strCreateTabCode.Append(" ViewpointId char(8) not Null, "); 
 // /**观点名称*/ 
 strCreateTabCode.Append(" ViewpointName varchar(500) Null, "); 
 // /**观点内容*/ 
 strCreateTabCode.Append(" ViewpointContent text Null, "); 
 // /**观点类型Id*/ 
 strCreateTabCode.Append(" ViewpointTypeId char(4) Null, "); 
 // /**理由*/ 
 strCreateTabCode.Append(" Reason text Null, "); 
 // /**来源*/ 
 strCreateTabCode.Append(" Source varchar(500) Null, "); 
 // /**观点提出人*/ 
 strCreateTabCode.Append(" VPProposePeople varchar(50) Null, "); 
 // /**用户类型Id*/ 
 strCreateTabCode.Append(" UserTypeId char(2) Null, "); 
 // /**引用Id*/ 
 strCreateTabCode.Append(" CitationId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 观点版本表(ViewpointVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewpointVer : clsCommFun4BL
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
clsViewpointVerBL.ReFreshThisCache();
}
}

}