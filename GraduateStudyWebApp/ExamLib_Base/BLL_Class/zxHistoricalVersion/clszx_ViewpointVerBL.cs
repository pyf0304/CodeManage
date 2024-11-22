
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointVerBL
 表名:zx_ViewpointVer(01120742)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
public static class  clszx_ViewpointVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewpointVerEN GetObj(this K_ViewpointVId_zx_ViewpointVer myKey)
{
clszx_ViewpointVerEN objzx_ViewpointVerEN = clszx_ViewpointVerBL.zx_ViewpointVerDA.GetObjByViewpointVId(myKey.Value);
return objzx_ViewpointVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
if (CheckUniqueness(objzx_ViewpointVerEN) == false)
{
var strMsg = string.Format("记录已经存在!观点Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ViewpointVerBL.AddNewRecord)", objzx_ViewpointVerEN.zxViewpointId,objzx_ViewpointVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_ViewpointVerBL.zx_ViewpointVerDA.AddNewRecordBySQL2(objzx_ViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
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
objzx_ViewpointVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ViewpointVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(观点Id(zxViewpointId)=[{0}],小组Id(GroupTextId)=[{1}])已经存在,不能重复!", objzx_ViewpointVerEN.zxViewpointId, objzx_ViewpointVerEN.GroupTextId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_ViewpointVerEN.AddNewRecord();
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
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
if (CheckUniqueness(objzx_ViewpointVerEN) == false)
{
var strMsg = string.Format("记录已经存在!观点Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ViewpointVerBL.AddNewRecordWithReturnKey)", objzx_ViewpointVerEN.zxViewpointId,objzx_ViewpointVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_ViewpointVerBL.zx_ViewpointVerDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetViewpointVId(this clszx_ViewpointVerEN objzx_ViewpointVerEN, long lngViewpointVId, string strComparisonOp="")
	{
objzx_ViewpointVerEN.ViewpointVId = lngViewpointVId; //ViewpointVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.ViewpointVId) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.ViewpointVId, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.ViewpointVId] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetzxViewpointId(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strzxViewpointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxViewpointId, conzx_ViewpointVer.zxViewpointId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxViewpointId, 8, conzx_ViewpointVer.zxViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxViewpointId, 8, conzx_ViewpointVer.zxViewpointId);
}
objzx_ViewpointVerEN.zxViewpointId = strzxViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.zxViewpointId) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.zxViewpointId, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.zxViewpointId] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetViewpointName(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, conzx_ViewpointVer.ViewpointName);
}
objzx_ViewpointVerEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.ViewpointName) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.ViewpointName, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.ViewpointName] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetViewpointContent(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strViewpointContent, string strComparisonOp="")
	{
objzx_ViewpointVerEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.ViewpointContent) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.ViewpointContent, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.ViewpointContent] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetzxViewpointTypeId(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strzxViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxViewpointTypeId, 4, conzx_ViewpointVer.zxViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxViewpointTypeId, 4, conzx_ViewpointVer.zxViewpointTypeId);
}
objzx_ViewpointVerEN.zxViewpointTypeId = strzxViewpointTypeId; //观点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.zxViewpointTypeId) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.zxViewpointTypeId, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.zxViewpointTypeId] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetReason(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strReason, string strComparisonOp="")
	{
objzx_ViewpointVerEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.Reason) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.Reason, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.Reason] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetSource(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 500, conzx_ViewpointVer.Source);
}
objzx_ViewpointVerEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.Source) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.Source, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.Source] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetVPProposePeople(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strVPProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVPProposePeople, 50, conzx_ViewpointVer.VPProposePeople);
}
objzx_ViewpointVerEN.VPProposePeople = strVPProposePeople; //观点提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.VPProposePeople) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.VPProposePeople, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.VPProposePeople] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetIsSubmit(this clszx_ViewpointVerEN objzx_ViewpointVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_ViewpointVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.IsSubmit) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.IsSubmit, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.IsSubmit] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetUserTypeId(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conzx_ViewpointVer.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conzx_ViewpointVer.UserTypeId);
}
objzx_ViewpointVerEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.UserTypeId) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.UserTypeId, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.UserTypeId] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetTextId(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_ViewpointVer.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_ViewpointVer.TextId);
}
objzx_ViewpointVerEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.TextId) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.TextId, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.TextId] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetVoteCount(this clszx_ViewpointVerEN objzx_ViewpointVerEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_ViewpointVerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.VoteCount) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.VoteCount, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.VoteCount] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetAppraiseCount(this clszx_ViewpointVerEN objzx_ViewpointVerEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_ViewpointVerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.AppraiseCount) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.AppraiseCount, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.AppraiseCount] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetScore(this clszx_ViewpointVerEN objzx_ViewpointVerEN, float? fltScore, string strComparisonOp="")
	{
objzx_ViewpointVerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.Score) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.Score, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.Score] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetStuScore(this clszx_ViewpointVerEN objzx_ViewpointVerEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_ViewpointVerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.StuScore) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.StuScore, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.StuScore] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetTeaScore(this clszx_ViewpointVerEN objzx_ViewpointVerEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_ViewpointVerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.TeaScore) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.TeaScore, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.TeaScore] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetUpdDate(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_ViewpointVer.UpdDate);
}
objzx_ViewpointVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.UpdDate) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.UpdDate, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.UpdDate] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetUpdUser(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_ViewpointVer.UpdUser);
}
objzx_ViewpointVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.UpdUser) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.UpdUser, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.UpdUser] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetIdCurrEduCls(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_ViewpointVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_ViewpointVer.IdCurrEduCls);
}
objzx_ViewpointVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.IdCurrEduCls) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetPdfContent(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_ViewpointVer.PdfContent);
}
objzx_ViewpointVerEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.PdfContent) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.PdfContent, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.PdfContent] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetPdfPageNum(this clszx_ViewpointVerEN objzx_ViewpointVerEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_ViewpointVerEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.PdfPageNum) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.PdfPageNum, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.PdfPageNum] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetCitationCount(this clszx_ViewpointVerEN objzx_ViewpointVerEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_ViewpointVerEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.CitationCount) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.CitationCount, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.CitationCount] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetVersionCount(this clszx_ViewpointVerEN objzx_ViewpointVerEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_ViewpointVerEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.VersionCount) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.VersionCount, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.VersionCount] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetCreateDate(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_ViewpointVer.CreateDate);
}
objzx_ViewpointVerEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.CreateDate) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.CreateDate, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.CreateDate] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetzxShareId(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_ViewpointVer.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_ViewpointVer.zxShareId);
}
objzx_ViewpointVerEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.zxShareId) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.zxShareId, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.zxShareId] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetMemo(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_ViewpointVer.Memo);
}
objzx_ViewpointVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.Memo) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.Memo, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.Memo] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetTeammenberId(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strTeammenberId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeammenberId, 8, conzx_ViewpointVer.TeammenberId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeammenberId, 8, conzx_ViewpointVer.TeammenberId);
}
objzx_ViewpointVerEN.TeammenberId = strTeammenberId; //主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.TeammenberId) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.TeammenberId, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.TeammenberId] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetPdfDivLet(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_ViewpointVer.PdfDivLet);
}
objzx_ViewpointVerEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.PdfDivLet) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.PdfDivLet, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.PdfDivLet] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetPdfDivTop(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_ViewpointVer.PdfDivTop);
}
objzx_ViewpointVerEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.PdfDivTop) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.PdfDivTop, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.PdfDivTop] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetPdfPageNumIn(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_ViewpointVer.PdfPageNumIn);
}
objzx_ViewpointVerEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.PdfPageNumIn) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetPdfPageTop(this clszx_ViewpointVerEN objzx_ViewpointVerEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_ViewpointVerEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.PdfPageTop) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.PdfPageTop, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.PdfPageTop] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetPdfZoom(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_ViewpointVer.PdfZoom);
}
objzx_ViewpointVerEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.PdfZoom) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.PdfZoom, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.PdfZoom] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ViewpointVerEN SetGroupTextId(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_ViewpointVer.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_ViewpointVer.GroupTextId);
}
objzx_ViewpointVerEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ViewpointVerEN.dicFldComparisonOp.ContainsKey(conzx_ViewpointVer.GroupTextId) == false)
{
objzx_ViewpointVerEN.dicFldComparisonOp.Add(conzx_ViewpointVer.GroupTextId, strComparisonOp);
}
else
{
objzx_ViewpointVerEN.dicFldComparisonOp[conzx_ViewpointVer.GroupTextId] = strComparisonOp;
}
}
return objzx_ViewpointVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ViewpointVerEN.CheckPropertyNew();
clszx_ViewpointVerEN objzx_ViewpointVerCond = new clszx_ViewpointVerEN();
string strCondition = objzx_ViewpointVerCond
.SetViewpointVId(objzx_ViewpointVerEN.ViewpointVId, "<>")
.SetzxViewpointId(objzx_ViewpointVerEN.zxViewpointId, "=")
.SetGroupTextId(objzx_ViewpointVerEN.GroupTextId, "=")
.GetCombineCondition();
objzx_ViewpointVerEN._IsCheckProperty = true;
bool bolIsExist = clszx_ViewpointVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxViewpointId_GroupTextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ViewpointVerEN.Update();
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
 /// <param name = "objzx_ViewpointVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ViewpointVerEN objzx_ViewpointVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ViewpointVerEN objzx_ViewpointVerCond = new clszx_ViewpointVerEN();
string strCondition = objzx_ViewpointVerCond
.SetzxViewpointId(objzx_ViewpointVer.zxViewpointId, "=")
.SetGroupTextId(objzx_ViewpointVer.GroupTextId, "=")
.GetCombineCondition();
objzx_ViewpointVer._IsCheckProperty = true;
bool bolIsExist = clszx_ViewpointVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_ViewpointVer.ViewpointVId = clszx_ViewpointVerBL.GetFirstID_S(strCondition);
objzx_ViewpointVer.UpdateWithCondition(strCondition);
}
else
{
objzx_ViewpointVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 if (objzx_ViewpointVerEN.ViewpointVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewpointVerBL.zx_ViewpointVerDA.UpdateBySql2(objzx_ViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ViewpointVerEN objzx_ViewpointVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ViewpointVerEN.ViewpointVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ViewpointVerBL.zx_ViewpointVerDA.UpdateBySql2(objzx_ViewpointVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ViewpointVerBL.zx_ViewpointVerDA.UpdateBySqlWithCondition(objzx_ViewpointVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ViewpointVerEN objzx_ViewpointVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ViewpointVerBL.zx_ViewpointVerDA.UpdateBySqlWithConditionTransaction(objzx_ViewpointVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
public static int Delete(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
try
{
int intRecNum = clszx_ViewpointVerBL.zx_ViewpointVerDA.DelRecord(objzx_ViewpointVerEN.ViewpointVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointVerENS">源对象</param>
 /// <param name = "objzx_ViewpointVerENT">目标对象</param>
 public static void CopyTo(this clszx_ViewpointVerEN objzx_ViewpointVerENS, clszx_ViewpointVerEN objzx_ViewpointVerENT)
{
try
{
objzx_ViewpointVerENT.ViewpointVId = objzx_ViewpointVerENS.ViewpointVId; //ViewpointVId
objzx_ViewpointVerENT.zxViewpointId = objzx_ViewpointVerENS.zxViewpointId; //观点Id
objzx_ViewpointVerENT.ViewpointName = objzx_ViewpointVerENS.ViewpointName; //观点名称
objzx_ViewpointVerENT.ViewpointContent = objzx_ViewpointVerENS.ViewpointContent; //观点内容
objzx_ViewpointVerENT.zxViewpointTypeId = objzx_ViewpointVerENS.zxViewpointTypeId; //观点类型Id
objzx_ViewpointVerENT.Reason = objzx_ViewpointVerENS.Reason; //理由
objzx_ViewpointVerENT.Source = objzx_ViewpointVerENS.Source; //来源
objzx_ViewpointVerENT.VPProposePeople = objzx_ViewpointVerENS.VPProposePeople; //观点提出人
objzx_ViewpointVerENT.IsSubmit = objzx_ViewpointVerENS.IsSubmit; //是否提交
objzx_ViewpointVerENT.UserTypeId = objzx_ViewpointVerENS.UserTypeId; //用户类型Id
objzx_ViewpointVerENT.TextId = objzx_ViewpointVerENS.TextId; //课件Id
objzx_ViewpointVerENT.VoteCount = objzx_ViewpointVerENS.VoteCount; //点赞计数
objzx_ViewpointVerENT.AppraiseCount = objzx_ViewpointVerENS.AppraiseCount; //评论数
objzx_ViewpointVerENT.Score = objzx_ViewpointVerENS.Score; //评分
objzx_ViewpointVerENT.StuScore = objzx_ViewpointVerENS.StuScore; //学生平均分
objzx_ViewpointVerENT.TeaScore = objzx_ViewpointVerENS.TeaScore; //教师评分
objzx_ViewpointVerENT.UpdDate = objzx_ViewpointVerENS.UpdDate; //修改日期
objzx_ViewpointVerENT.UpdUser = objzx_ViewpointVerENS.UpdUser; //修改人
objzx_ViewpointVerENT.IdCurrEduCls = objzx_ViewpointVerENS.IdCurrEduCls; //教学班流水号
objzx_ViewpointVerENT.PdfContent = objzx_ViewpointVerENS.PdfContent; //Pdf内容
objzx_ViewpointVerENT.PdfPageNum = objzx_ViewpointVerENS.PdfPageNum; //Pdf页码
objzx_ViewpointVerENT.CitationCount = objzx_ViewpointVerENS.CitationCount; //引用统计
objzx_ViewpointVerENT.VersionCount = objzx_ViewpointVerENS.VersionCount; //版本统计
objzx_ViewpointVerENT.CreateDate = objzx_ViewpointVerENS.CreateDate; //建立日期
objzx_ViewpointVerENT.zxShareId = objzx_ViewpointVerENS.zxShareId; //分享Id
objzx_ViewpointVerENT.Memo = objzx_ViewpointVerENS.Memo; //备注
objzx_ViewpointVerENT.TeammenberId = objzx_ViewpointVerENS.TeammenberId; //主键
objzx_ViewpointVerENT.PdfDivLet = objzx_ViewpointVerENS.PdfDivLet; //PdfDivLet
objzx_ViewpointVerENT.PdfDivTop = objzx_ViewpointVerENS.PdfDivTop; //PdfDivTop
objzx_ViewpointVerENT.PdfPageNumIn = objzx_ViewpointVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_ViewpointVerENT.PdfPageTop = objzx_ViewpointVerENS.PdfPageTop; //pdf页面顶部位置
objzx_ViewpointVerENT.PdfZoom = objzx_ViewpointVerENS.PdfZoom; //PdfZoom
objzx_ViewpointVerENT.GroupTextId = objzx_ViewpointVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ViewpointVerENS">源对象</param>
 /// <returns>目标对象=>clszx_ViewpointVerEN:objzx_ViewpointVerENT</returns>
 public static clszx_ViewpointVerEN CopyTo(this clszx_ViewpointVerEN objzx_ViewpointVerENS)
{
try
{
 clszx_ViewpointVerEN objzx_ViewpointVerENT = new clszx_ViewpointVerEN()
{
ViewpointVId = objzx_ViewpointVerENS.ViewpointVId, //ViewpointVId
zxViewpointId = objzx_ViewpointVerENS.zxViewpointId, //观点Id
ViewpointName = objzx_ViewpointVerENS.ViewpointName, //观点名称
ViewpointContent = objzx_ViewpointVerENS.ViewpointContent, //观点内容
zxViewpointTypeId = objzx_ViewpointVerENS.zxViewpointTypeId, //观点类型Id
Reason = objzx_ViewpointVerENS.Reason, //理由
Source = objzx_ViewpointVerENS.Source, //来源
VPProposePeople = objzx_ViewpointVerENS.VPProposePeople, //观点提出人
IsSubmit = objzx_ViewpointVerENS.IsSubmit, //是否提交
UserTypeId = objzx_ViewpointVerENS.UserTypeId, //用户类型Id
TextId = objzx_ViewpointVerENS.TextId, //课件Id
VoteCount = objzx_ViewpointVerENS.VoteCount, //点赞计数
AppraiseCount = objzx_ViewpointVerENS.AppraiseCount, //评论数
Score = objzx_ViewpointVerENS.Score, //评分
StuScore = objzx_ViewpointVerENS.StuScore, //学生平均分
TeaScore = objzx_ViewpointVerENS.TeaScore, //教师评分
UpdDate = objzx_ViewpointVerENS.UpdDate, //修改日期
UpdUser = objzx_ViewpointVerENS.UpdUser, //修改人
IdCurrEduCls = objzx_ViewpointVerENS.IdCurrEduCls, //教学班流水号
PdfContent = objzx_ViewpointVerENS.PdfContent, //Pdf内容
PdfPageNum = objzx_ViewpointVerENS.PdfPageNum, //Pdf页码
CitationCount = objzx_ViewpointVerENS.CitationCount, //引用统计
VersionCount = objzx_ViewpointVerENS.VersionCount, //版本统计
CreateDate = objzx_ViewpointVerENS.CreateDate, //建立日期
zxShareId = objzx_ViewpointVerENS.zxShareId, //分享Id
Memo = objzx_ViewpointVerENS.Memo, //备注
TeammenberId = objzx_ViewpointVerENS.TeammenberId, //主键
PdfDivLet = objzx_ViewpointVerENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_ViewpointVerENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_ViewpointVerENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_ViewpointVerENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_ViewpointVerENS.PdfZoom, //PdfZoom
GroupTextId = objzx_ViewpointVerENS.GroupTextId, //小组Id
};
 return objzx_ViewpointVerENT;
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
public static void CheckPropertyNew(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 clszx_ViewpointVerBL.zx_ViewpointVerDA.CheckPropertyNew(objzx_ViewpointVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 clszx_ViewpointVerBL.zx_ViewpointVerDA.CheckProperty4Condition(objzx_ViewpointVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ViewpointVerEN objzx_ViewpointVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.ViewpointVId) == true)
{
string strComparisonOpViewpointVId = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.ViewpointVId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.ViewpointVId, objzx_ViewpointVerCond.ViewpointVId, strComparisonOpViewpointVId);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.zxViewpointId) == true)
{
string strComparisonOpzxViewpointId = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.zxViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.zxViewpointId, objzx_ViewpointVerCond.zxViewpointId, strComparisonOpzxViewpointId);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.ViewpointName) == true)
{
string strComparisonOpViewpointName = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.ViewpointName, objzx_ViewpointVerCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.zxViewpointTypeId) == true)
{
string strComparisonOpzxViewpointTypeId = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.zxViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.zxViewpointTypeId, objzx_ViewpointVerCond.zxViewpointTypeId, strComparisonOpzxViewpointTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.Source) == true)
{
string strComparisonOpSource = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.Source, objzx_ViewpointVerCond.Source, strComparisonOpSource);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.VPProposePeople) == true)
{
string strComparisonOpVPProposePeople = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.VPProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.VPProposePeople, objzx_ViewpointVerCond.VPProposePeople, strComparisonOpVPProposePeople);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.IsSubmit) == true)
{
if (objzx_ViewpointVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_ViewpointVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_ViewpointVer.IsSubmit);
}
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.UserTypeId, objzx_ViewpointVerCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.TextId) == true)
{
string strComparisonOpTextId = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.TextId, objzx_ViewpointVerCond.TextId, strComparisonOpTextId);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.VoteCount, objzx_ViewpointVerCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.AppraiseCount, objzx_ViewpointVerCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.Score) == true)
{
string strComparisonOpScore = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.Score, objzx_ViewpointVerCond.Score, strComparisonOpScore);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.StuScore) == true)
{
string strComparisonOpStuScore = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.StuScore, objzx_ViewpointVerCond.StuScore, strComparisonOpStuScore);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.TeaScore, objzx_ViewpointVerCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.UpdDate, objzx_ViewpointVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.UpdUser, objzx_ViewpointVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.IdCurrEduCls, objzx_ViewpointVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.PdfContent, objzx_ViewpointVerCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.PdfPageNum, objzx_ViewpointVerCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.CitationCount, objzx_ViewpointVerCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.VersionCount, objzx_ViewpointVerCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.CreateDate, objzx_ViewpointVerCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.zxShareId, objzx_ViewpointVerCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.Memo) == true)
{
string strComparisonOpMemo = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.Memo, objzx_ViewpointVerCond.Memo, strComparisonOpMemo);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.TeammenberId) == true)
{
string strComparisonOpTeammenberId = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.TeammenberId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.TeammenberId, objzx_ViewpointVerCond.TeammenberId, strComparisonOpTeammenberId);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.PdfDivLet, objzx_ViewpointVerCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.PdfDivTop, objzx_ViewpointVerCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.PdfPageNumIn, objzx_ViewpointVerCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ViewpointVer.PdfPageTop, objzx_ViewpointVerCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.PdfZoom, objzx_ViewpointVerCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_ViewpointVerCond.IsUpdated(conzx_ViewpointVer.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_ViewpointVerCond.dicFldComparisonOp[conzx_ViewpointVer.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ViewpointVer.GroupTextId, objzx_ViewpointVerCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_ViewpointVer(观点历史版本), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxViewpointId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewpointVerEN == null) return true;
if (objzx_ViewpointVerEN.ViewpointVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointVerEN.zxViewpointId);
 if (objzx_ViewpointVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_ViewpointVerEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ViewpointVerEN.GroupTextId);
}
if (clszx_ViewpointVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ViewpointVId !=  {0}", objzx_ViewpointVerEN.ViewpointVId);
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointVerEN.zxViewpointId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ViewpointVerEN.GroupTextId);
if (clszx_ViewpointVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_ViewpointVer(观点历史版本), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxViewpointId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ViewpointVerEN == null) return "";
if (objzx_ViewpointVerEN.ViewpointVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointVerEN.zxViewpointId);
 if (objzx_ViewpointVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_ViewpointVerEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ViewpointVerEN.GroupTextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointVId !=  {0}", objzx_ViewpointVerEN.ViewpointVId);
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointVerEN.zxViewpointId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ViewpointVerEN.GroupTextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_ViewpointVer
{
public virtual bool UpdRelaTabDate(long lngViewpointVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 观点历史版本(zx_ViewpointVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ViewpointVerBL
{
public static RelatedActions_zx_ViewpointVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ViewpointVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ViewpointVerDA zx_ViewpointVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ViewpointVerDA();
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
 public clszx_ViewpointVerBL()
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
if (string.IsNullOrEmpty(clszx_ViewpointVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ViewpointVerEN._ConnectString);
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
public static DataTable GetDataTable_zx_ViewpointVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ViewpointVerDA.GetDataTable_zx_ViewpointVer(strWhereCond);
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
objDT = zx_ViewpointVerDA.GetDataTable(strWhereCond);
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
objDT = zx_ViewpointVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ViewpointVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ViewpointVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ViewpointVerDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ViewpointVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ViewpointVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ViewpointVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clszx_ViewpointVerEN> GetObjLstByViewpointVIdLst(List<long> arrViewpointVIdLst)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
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
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ViewpointVerEN> GetObjLstByViewpointVIdLstCache(List<long> arrViewpointVIdLst)
{
string strKey = string.Format("{0}", clszx_ViewpointVerEN._CurrTabName);
List<clszx_ViewpointVerEN> arrzx_ViewpointVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointVerEN> arrzx_ViewpointVerObjLst_Sel =
arrzx_ViewpointVerObjLstCache
.Where(x => arrViewpointVIdLst.Contains(x.ViewpointVId));
return arrzx_ViewpointVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointVerEN> GetObjLst(string strWhereCond)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
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
public static List<clszx_ViewpointVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ViewpointVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ViewpointVerEN> GetSubObjLstCache(clszx_ViewpointVerEN objzx_ViewpointVerCond)
{
List<clszx_ViewpointVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ViewpointVer.AttributeName)
{
if (objzx_ViewpointVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewpointVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointVerCond[strFldName].ToString());
}
else
{
if (objzx_ViewpointVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewpointVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewpointVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointVerCond[strFldName]));
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
public static List<clszx_ViewpointVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
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
public static List<clszx_ViewpointVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
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
List<clszx_ViewpointVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ViewpointVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ViewpointVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
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
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
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
public static List<clszx_ViewpointVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ViewpointVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ViewpointVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
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
public static List<clszx_ViewpointVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ViewpointVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ViewpointVerEN> arrObjLst = new List<clszx_ViewpointVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointVerEN objzx_ViewpointVerEN = new clszx_ViewpointVerEN();
try
{
objzx_ViewpointVerEN.ViewpointVId = Int32.Parse(objRow[conzx_ViewpointVer.ViewpointVId].ToString().Trim()); //ViewpointVId
objzx_ViewpointVerEN.zxViewpointId = objRow[conzx_ViewpointVer.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointVerEN.ViewpointName = objRow[conzx_ViewpointVer.ViewpointName] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointVerEN.ViewpointContent = objRow[conzx_ViewpointVer.ViewpointContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointVerEN.zxViewpointTypeId = objRow[conzx_ViewpointVer.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointVerEN.Reason = objRow[conzx_ViewpointVer.Reason] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Reason].ToString().Trim(); //理由
objzx_ViewpointVerEN.Source = objRow[conzx_ViewpointVer.Source] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Source].ToString().Trim(); //来源
objzx_ViewpointVerEN.VPProposePeople = objRow[conzx_ViewpointVer.VPProposePeople] == DBNull.Value ? null : objRow[conzx_ViewpointVer.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ViewpointVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointVerEN.UserTypeId = objRow[conzx_ViewpointVer.UserTypeId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointVerEN.TextId = objRow[conzx_ViewpointVer.TextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TextId].ToString().Trim(); //课件Id
objzx_ViewpointVerEN.VoteCount = objRow[conzx_ViewpointVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointVerEN.AppraiseCount = objRow[conzx_ViewpointVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointVerEN.Score = objRow[conzx_ViewpointVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.Score].ToString().Trim()); //评分
objzx_ViewpointVerEN.StuScore = objRow[conzx_ViewpointVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointVerEN.TeaScore = objRow[conzx_ViewpointVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ViewpointVer.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointVerEN.UpdDate = objRow[conzx_ViewpointVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointVerEN.UpdUser = objRow[conzx_ViewpointVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ViewpointVer.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointVerEN.IdCurrEduCls = objRow[conzx_ViewpointVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ViewpointVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointVerEN.PdfContent = objRow[conzx_ViewpointVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointVerEN.PdfPageNum = objRow[conzx_ViewpointVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointVerEN.CitationCount = objRow[conzx_ViewpointVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointVerEN.VersionCount = objRow[conzx_ViewpointVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointVerEN.CreateDate = objRow[conzx_ViewpointVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ViewpointVer.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointVerEN.zxShareId = objRow[conzx_ViewpointVer.zxShareId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointVerEN.Memo = objRow[conzx_ViewpointVer.Memo] == DBNull.Value ? null : objRow[conzx_ViewpointVer.Memo].ToString().Trim(); //备注
objzx_ViewpointVerEN.TeammenberId = objRow[conzx_ViewpointVer.TeammenberId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointVerEN.PdfDivLet = objRow[conzx_ViewpointVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointVerEN.PdfDivTop = objRow[conzx_ViewpointVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointVerEN.PdfPageNumIn = objRow[conzx_ViewpointVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointVerEN.PdfPageTop = objRow[conzx_ViewpointVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ViewpointVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointVerEN.PdfZoom = objRow[conzx_ViewpointVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ViewpointVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointVerEN.GroupTextId = objRow[conzx_ViewpointVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ViewpointVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ViewpointVerEN.ViewpointVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ViewpointVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_ViewpointVer(ref clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
bool bolResult = zx_ViewpointVerDA.Getzx_ViewpointVer(ref objzx_ViewpointVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngViewpointVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ViewpointVerEN GetObjByViewpointVId(long lngViewpointVId)
{
clszx_ViewpointVerEN objzx_ViewpointVerEN = zx_ViewpointVerDA.GetObjByViewpointVId(lngViewpointVId);
return objzx_ViewpointVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ViewpointVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ViewpointVerEN objzx_ViewpointVerEN = zx_ViewpointVerDA.GetFirstObj(strWhereCond);
 return objzx_ViewpointVerEN;
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
public static clszx_ViewpointVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ViewpointVerEN objzx_ViewpointVerEN = zx_ViewpointVerDA.GetObjByDataRow(objRow);
 return objzx_ViewpointVerEN;
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
public static clszx_ViewpointVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ViewpointVerEN objzx_ViewpointVerEN = zx_ViewpointVerDA.GetObjByDataRow(objRow);
 return objzx_ViewpointVerEN;
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
 /// <param name = "lstzx_ViewpointVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewpointVerEN GetObjByViewpointVIdFromList(long lngViewpointVId, List<clszx_ViewpointVerEN> lstzx_ViewpointVerObjLst)
{
foreach (clszx_ViewpointVerEN objzx_ViewpointVerEN in lstzx_ViewpointVerObjLst)
{
if (objzx_ViewpointVerEN.ViewpointVId == lngViewpointVId)
{
return objzx_ViewpointVerEN;
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
 lngViewpointVId = new clszx_ViewpointVerDA().GetFirstID(strWhereCond);
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
 arrList = zx_ViewpointVerDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ViewpointVerDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = zx_ViewpointVerDA.IsExist(lngViewpointVId);
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
 bolIsExist = clszx_ViewpointVerDA.IsExistTable();
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
 bolIsExist = zx_ViewpointVerDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
if (objzx_ViewpointVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!观点Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ViewpointVerBL.AddNewRecordBySql2)", objzx_ViewpointVerEN.zxViewpointId,objzx_ViewpointVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_ViewpointVerDA.AddNewRecordBySQL2(objzx_ViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
if (objzx_ViewpointVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!观点Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ViewpointVerBL.AddNewRecordBySql2WithReturnKey)", objzx_ViewpointVerEN.zxViewpointId,objzx_ViewpointVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_ViewpointVerDA.AddNewRecordBySQL2WithReturnKey(objzx_ViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
try
{
bool bolResult = zx_ViewpointVerDA.Update(objzx_ViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 /// <param name = "objzx_ViewpointVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 if (objzx_ViewpointVerEN.ViewpointVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ViewpointVerDA.UpdateBySql2(objzx_ViewpointVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ViewpointVerBL.ReFreshCache();

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
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
 clszx_ViewpointVerEN objzx_ViewpointVerEN = clszx_ViewpointVerBL.GetObjByViewpointVId(lngViewpointVId);

if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(objzx_ViewpointVerEN.ViewpointVId, "SetUpdDate");
}
if (objzx_ViewpointVerEN != null)
{
int intRecNum = zx_ViewpointVerDA.DelRecord(lngViewpointVId);
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
objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
//删除与表:[zx_ViewpointVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_ViewpointVer.ViewpointVId,
//lngViewpointVId);
//        clszx_ViewpointVerBL.Delzx_ViewpointVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewpointVerBL.DelRecord(lngViewpointVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewpointVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clszx_ViewpointVerBL.relatedActions != null)
{
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(lngViewpointVId, "UpdRelaTabDate");
}
bool bolResult = zx_ViewpointVerDA.DelRecord(lngViewpointVId,objSqlConnection,objSqlTransaction);
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
public static int Delzx_ViewpointVers(List<string> arrViewpointVIdLst)
{
if (arrViewpointVIdLst.Count == 0) return 0;
try
{
if (clszx_ViewpointVerBL.relatedActions != null)
{
foreach (var strViewpointVId in arrViewpointVIdLst)
{
long lngViewpointVId = long.Parse(strViewpointVId);
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(lngViewpointVId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_ViewpointVerDA.Delzx_ViewpointVer(arrViewpointVIdLst);
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
public static int Delzx_ViewpointVersByCond(string strWhereCond)
{
try
{
if (clszx_ViewpointVerBL.relatedActions != null)
{
List<string> arrViewpointVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strViewpointVId in arrViewpointVId)
{
long lngViewpointVId = long.Parse(strViewpointVId);
clszx_ViewpointVerBL.relatedActions.UpdRelaTabDate(lngViewpointVId, "UpdRelaTabDate");
}
}
int intRecNum = zx_ViewpointVerDA.Delzx_ViewpointVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_ViewpointVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngViewpointVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngViewpointVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointVerDA.GetSpecSQLObj();
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
//删除与表:[zx_ViewpointVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ViewpointVerBL.DelRecord(lngViewpointVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ViewpointVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objzx_ViewpointVerENS">源对象</param>
 /// <param name = "objzx_ViewpointVerENT">目标对象</param>
 public static void CopyTo(clszx_ViewpointVerEN objzx_ViewpointVerENS, clszx_ViewpointVerEN objzx_ViewpointVerENT)
{
try
{
objzx_ViewpointVerENT.ViewpointVId = objzx_ViewpointVerENS.ViewpointVId; //ViewpointVId
objzx_ViewpointVerENT.zxViewpointId = objzx_ViewpointVerENS.zxViewpointId; //观点Id
objzx_ViewpointVerENT.ViewpointName = objzx_ViewpointVerENS.ViewpointName; //观点名称
objzx_ViewpointVerENT.ViewpointContent = objzx_ViewpointVerENS.ViewpointContent; //观点内容
objzx_ViewpointVerENT.zxViewpointTypeId = objzx_ViewpointVerENS.zxViewpointTypeId; //观点类型Id
objzx_ViewpointVerENT.Reason = objzx_ViewpointVerENS.Reason; //理由
objzx_ViewpointVerENT.Source = objzx_ViewpointVerENS.Source; //来源
objzx_ViewpointVerENT.VPProposePeople = objzx_ViewpointVerENS.VPProposePeople; //观点提出人
objzx_ViewpointVerENT.IsSubmit = objzx_ViewpointVerENS.IsSubmit; //是否提交
objzx_ViewpointVerENT.UserTypeId = objzx_ViewpointVerENS.UserTypeId; //用户类型Id
objzx_ViewpointVerENT.TextId = objzx_ViewpointVerENS.TextId; //课件Id
objzx_ViewpointVerENT.VoteCount = objzx_ViewpointVerENS.VoteCount; //点赞计数
objzx_ViewpointVerENT.AppraiseCount = objzx_ViewpointVerENS.AppraiseCount; //评论数
objzx_ViewpointVerENT.Score = objzx_ViewpointVerENS.Score; //评分
objzx_ViewpointVerENT.StuScore = objzx_ViewpointVerENS.StuScore; //学生平均分
objzx_ViewpointVerENT.TeaScore = objzx_ViewpointVerENS.TeaScore; //教师评分
objzx_ViewpointVerENT.UpdDate = objzx_ViewpointVerENS.UpdDate; //修改日期
objzx_ViewpointVerENT.UpdUser = objzx_ViewpointVerENS.UpdUser; //修改人
objzx_ViewpointVerENT.IdCurrEduCls = objzx_ViewpointVerENS.IdCurrEduCls; //教学班流水号
objzx_ViewpointVerENT.PdfContent = objzx_ViewpointVerENS.PdfContent; //Pdf内容
objzx_ViewpointVerENT.PdfPageNum = objzx_ViewpointVerENS.PdfPageNum; //Pdf页码
objzx_ViewpointVerENT.CitationCount = objzx_ViewpointVerENS.CitationCount; //引用统计
objzx_ViewpointVerENT.VersionCount = objzx_ViewpointVerENS.VersionCount; //版本统计
objzx_ViewpointVerENT.CreateDate = objzx_ViewpointVerENS.CreateDate; //建立日期
objzx_ViewpointVerENT.zxShareId = objzx_ViewpointVerENS.zxShareId; //分享Id
objzx_ViewpointVerENT.Memo = objzx_ViewpointVerENS.Memo; //备注
objzx_ViewpointVerENT.TeammenberId = objzx_ViewpointVerENS.TeammenberId; //主键
objzx_ViewpointVerENT.PdfDivLet = objzx_ViewpointVerENS.PdfDivLet; //PdfDivLet
objzx_ViewpointVerENT.PdfDivTop = objzx_ViewpointVerENS.PdfDivTop; //PdfDivTop
objzx_ViewpointVerENT.PdfPageNumIn = objzx_ViewpointVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_ViewpointVerENT.PdfPageTop = objzx_ViewpointVerENS.PdfPageTop; //pdf页面顶部位置
objzx_ViewpointVerENT.PdfZoom = objzx_ViewpointVerENS.PdfZoom; //PdfZoom
objzx_ViewpointVerENT.GroupTextId = objzx_ViewpointVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ViewpointVerEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
try
{
objzx_ViewpointVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ViewpointVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_ViewpointVer.ViewpointVId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.ViewpointVId = objzx_ViewpointVerEN.ViewpointVId; //ViewpointVId
}
if (arrFldSet.Contains(conzx_ViewpointVer.zxViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.zxViewpointId = objzx_ViewpointVerEN.zxViewpointId; //观点Id
}
if (arrFldSet.Contains(conzx_ViewpointVer.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.ViewpointName = objzx_ViewpointVerEN.ViewpointName == "[null]" ? null :  objzx_ViewpointVerEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(conzx_ViewpointVer.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.ViewpointContent = objzx_ViewpointVerEN.ViewpointContent == "[null]" ? null :  objzx_ViewpointVerEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(conzx_ViewpointVer.zxViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.zxViewpointTypeId = objzx_ViewpointVerEN.zxViewpointTypeId == "[null]" ? null :  objzx_ViewpointVerEN.zxViewpointTypeId; //观点类型Id
}
if (arrFldSet.Contains(conzx_ViewpointVer.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.Reason = objzx_ViewpointVerEN.Reason == "[null]" ? null :  objzx_ViewpointVerEN.Reason; //理由
}
if (arrFldSet.Contains(conzx_ViewpointVer.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.Source = objzx_ViewpointVerEN.Source == "[null]" ? null :  objzx_ViewpointVerEN.Source; //来源
}
if (arrFldSet.Contains(conzx_ViewpointVer.VPProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.VPProposePeople = objzx_ViewpointVerEN.VPProposePeople == "[null]" ? null :  objzx_ViewpointVerEN.VPProposePeople; //观点提出人
}
if (arrFldSet.Contains(conzx_ViewpointVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.IsSubmit = objzx_ViewpointVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_ViewpointVer.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.UserTypeId = objzx_ViewpointVerEN.UserTypeId == "[null]" ? null :  objzx_ViewpointVerEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(conzx_ViewpointVer.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.TextId = objzx_ViewpointVerEN.TextId == "[null]" ? null :  objzx_ViewpointVerEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_ViewpointVer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.VoteCount = objzx_ViewpointVerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_ViewpointVer.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.AppraiseCount = objzx_ViewpointVerEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_ViewpointVer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.Score = objzx_ViewpointVerEN.Score; //评分
}
if (arrFldSet.Contains(conzx_ViewpointVer.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.StuScore = objzx_ViewpointVerEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_ViewpointVer.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.TeaScore = objzx_ViewpointVerEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_ViewpointVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.UpdDate = objzx_ViewpointVerEN.UpdDate == "[null]" ? null :  objzx_ViewpointVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_ViewpointVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.UpdUser = objzx_ViewpointVerEN.UpdUser == "[null]" ? null :  objzx_ViewpointVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_ViewpointVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.IdCurrEduCls = objzx_ViewpointVerEN.IdCurrEduCls == "[null]" ? null :  objzx_ViewpointVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_ViewpointVer.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.PdfContent = objzx_ViewpointVerEN.PdfContent == "[null]" ? null :  objzx_ViewpointVerEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_ViewpointVer.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.PdfPageNum = objzx_ViewpointVerEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_ViewpointVer.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.CitationCount = objzx_ViewpointVerEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_ViewpointVer.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.VersionCount = objzx_ViewpointVerEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_ViewpointVer.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.CreateDate = objzx_ViewpointVerEN.CreateDate == "[null]" ? null :  objzx_ViewpointVerEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_ViewpointVer.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.zxShareId = objzx_ViewpointVerEN.zxShareId == "[null]" ? null :  objzx_ViewpointVerEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_ViewpointVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.Memo = objzx_ViewpointVerEN.Memo == "[null]" ? null :  objzx_ViewpointVerEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_ViewpointVer.TeammenberId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.TeammenberId = objzx_ViewpointVerEN.TeammenberId == "[null]" ? null :  objzx_ViewpointVerEN.TeammenberId; //主键
}
if (arrFldSet.Contains(conzx_ViewpointVer.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.PdfDivLet = objzx_ViewpointVerEN.PdfDivLet == "[null]" ? null :  objzx_ViewpointVerEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_ViewpointVer.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.PdfDivTop = objzx_ViewpointVerEN.PdfDivTop == "[null]" ? null :  objzx_ViewpointVerEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_ViewpointVer.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.PdfPageNumIn = objzx_ViewpointVerEN.PdfPageNumIn == "[null]" ? null :  objzx_ViewpointVerEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_ViewpointVer.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.PdfPageTop = objzx_ViewpointVerEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_ViewpointVer.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.PdfZoom = objzx_ViewpointVerEN.PdfZoom == "[null]" ? null :  objzx_ViewpointVerEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_ViewpointVer.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ViewpointVerEN.GroupTextId = objzx_ViewpointVerEN.GroupTextId == "[null]" ? null :  objzx_ViewpointVerEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_ViewpointVerEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
try
{
if (objzx_ViewpointVerEN.ViewpointName == "[null]") objzx_ViewpointVerEN.ViewpointName = null; //观点名称
if (objzx_ViewpointVerEN.ViewpointContent == "[null]") objzx_ViewpointVerEN.ViewpointContent = null; //观点内容
if (objzx_ViewpointVerEN.zxViewpointTypeId == "[null]") objzx_ViewpointVerEN.zxViewpointTypeId = null; //观点类型Id
if (objzx_ViewpointVerEN.Reason == "[null]") objzx_ViewpointVerEN.Reason = null; //理由
if (objzx_ViewpointVerEN.Source == "[null]") objzx_ViewpointVerEN.Source = null; //来源
if (objzx_ViewpointVerEN.VPProposePeople == "[null]") objzx_ViewpointVerEN.VPProposePeople = null; //观点提出人
if (objzx_ViewpointVerEN.UserTypeId == "[null]") objzx_ViewpointVerEN.UserTypeId = null; //用户类型Id
if (objzx_ViewpointVerEN.TextId == "[null]") objzx_ViewpointVerEN.TextId = null; //课件Id
if (objzx_ViewpointVerEN.UpdDate == "[null]") objzx_ViewpointVerEN.UpdDate = null; //修改日期
if (objzx_ViewpointVerEN.UpdUser == "[null]") objzx_ViewpointVerEN.UpdUser = null; //修改人
if (objzx_ViewpointVerEN.IdCurrEduCls == "[null]") objzx_ViewpointVerEN.IdCurrEduCls = null; //教学班流水号
if (objzx_ViewpointVerEN.PdfContent == "[null]") objzx_ViewpointVerEN.PdfContent = null; //Pdf内容
if (objzx_ViewpointVerEN.CreateDate == "[null]") objzx_ViewpointVerEN.CreateDate = null; //建立日期
if (objzx_ViewpointVerEN.zxShareId == "[null]") objzx_ViewpointVerEN.zxShareId = null; //分享Id
if (objzx_ViewpointVerEN.Memo == "[null]") objzx_ViewpointVerEN.Memo = null; //备注
if (objzx_ViewpointVerEN.TeammenberId == "[null]") objzx_ViewpointVerEN.TeammenberId = null; //主键
if (objzx_ViewpointVerEN.PdfDivLet == "[null]") objzx_ViewpointVerEN.PdfDivLet = null; //PdfDivLet
if (objzx_ViewpointVerEN.PdfDivTop == "[null]") objzx_ViewpointVerEN.PdfDivTop = null; //PdfDivTop
if (objzx_ViewpointVerEN.PdfPageNumIn == "[null]") objzx_ViewpointVerEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_ViewpointVerEN.PdfZoom == "[null]") objzx_ViewpointVerEN.PdfZoom = null; //PdfZoom
if (objzx_ViewpointVerEN.GroupTextId == "[null]") objzx_ViewpointVerEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 zx_ViewpointVerDA.CheckPropertyNew(objzx_ViewpointVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
 zx_ViewpointVerDA.CheckProperty4Condition(objzx_ViewpointVerEN);
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
if (clszx_ViewpointVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ViewpointVerBL没有刷新缓存机制(clszx_ViewpointVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointVId");
//if (arrzx_ViewpointVerObjLstCache == null)
//{
//arrzx_ViewpointVerObjLstCache = zx_ViewpointVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngViewpointVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ViewpointVerEN GetObjByViewpointVIdCache(long lngViewpointVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_ViewpointVerEN._CurrTabName);
List<clszx_ViewpointVerEN> arrzx_ViewpointVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointVerEN> arrzx_ViewpointVerObjLst_Sel =
arrzx_ViewpointVerObjLstCache
.Where(x=> x.ViewpointVId == lngViewpointVId 
);
if (arrzx_ViewpointVerObjLst_Sel.Count() == 0)
{
   clszx_ViewpointVerEN obj = clszx_ViewpointVerBL.GetObjByViewpointVId(lngViewpointVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_ViewpointVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewpointVerEN> GetAllzx_ViewpointVerObjLstCache()
{
//获取缓存中的对象列表
List<clszx_ViewpointVerEN> arrzx_ViewpointVerObjLstCache = GetObjLstCache(); 
return arrzx_ViewpointVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ViewpointVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_ViewpointVerEN._CurrTabName);
List<clszx_ViewpointVerEN> arrzx_ViewpointVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_ViewpointVerObjLstCache;
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
string strKey = string.Format("{0}", clszx_ViewpointVerEN._CurrTabName);
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
if (clszx_ViewpointVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_ViewpointVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_ViewpointVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_ViewpointVer(观点历史版本)
 /// 唯一性条件:zxViewpointId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ViewpointVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ViewpointVerEN objzx_ViewpointVerEN)
{
//检测记录是否存在
string strResult = zx_ViewpointVerDA.GetUniCondStr(objzx_ViewpointVerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngViewpointVId)
{
if (strInFldName != conzx_ViewpointVer.ViewpointVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_ViewpointVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_ViewpointVer.AttributeName));
throw new Exception(strMsg);
}
var objzx_ViewpointVer = clszx_ViewpointVerBL.GetObjByViewpointVIdCache(lngViewpointVId);
if (objzx_ViewpointVer == null) return "";
return objzx_ViewpointVer[strOutFldName].ToString();
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
int intRecCount = clszx_ViewpointVerDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ViewpointVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ViewpointVerDA.GetRecCount();
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
int intRecCount = clszx_ViewpointVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ViewpointVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ViewpointVerEN objzx_ViewpointVerCond)
{
List<clszx_ViewpointVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ViewpointVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ViewpointVer.AttributeName)
{
if (objzx_ViewpointVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_ViewpointVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointVerCond[strFldName].ToString());
}
else
{
if (objzx_ViewpointVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ViewpointVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ViewpointVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ViewpointVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ViewpointVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ViewpointVerCond[strFldName]));
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
 List<string> arrList = clszx_ViewpointVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewpointVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ViewpointVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ViewpointVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewpointVerDA.SetFldValue(clszx_ViewpointVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ViewpointVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewpointVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ViewpointVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ViewpointVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_ViewpointVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**ViewpointVId*/ 
 strCreateTabCode.Append(" ViewpointVId bigint primary key identity, "); 
 // /**观点Id*/ 
 strCreateTabCode.Append(" zxViewpointId char(8) not Null, "); 
 // /**观点名称*/ 
 strCreateTabCode.Append(" ViewpointName varchar(500) Null, "); 
 // /**观点内容*/ 
 strCreateTabCode.Append(" ViewpointContent text Null, "); 
 // /**观点类型Id*/ 
 strCreateTabCode.Append(" zxViewpointTypeId char(4) Null, "); 
 // /**理由*/ 
 strCreateTabCode.Append(" Reason text Null, "); 
 // /**来源*/ 
 strCreateTabCode.Append(" Source varchar(500) Null, "); 
 // /**观点提出人*/ 
 strCreateTabCode.Append(" VPProposePeople varchar(50) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**用户类型Id*/ 
 strCreateTabCode.Append(" UserTypeId char(2) Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
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
 // /**引用统计*/ 
 strCreateTabCode.Append(" CitationCount int Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**主键*/ 
 strCreateTabCode.Append(" TeammenberId char(8) Null, "); 
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
 /// 观点历史版本(zx_ViewpointVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_ViewpointVer : clsCommFun4BL
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
clszx_ViewpointVerBL.ReFreshThisCache();
}
}

}