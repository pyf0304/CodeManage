
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointCitationBL
 表名:vViewpointCitation(01120594)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:41
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
public static class  clsvViewpointCitationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointCitationEN GetObj(this K_mId_vViewpointCitation myKey)
{
clsvViewpointCitationEN objvViewpointCitationEN = clsvViewpointCitationBL.vViewpointCitationDA.GetObjBymId(myKey.Value);
return objvViewpointCitationEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsvViewpointCitationEN objvViewpointCitationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objvViewpointCitationEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],论文Id = [{1}],观点Id = [{2}]的数据已经存在!(in clsvViewpointCitationBL.AddNewRecord)", objvViewpointCitationEN.mId,objvViewpointCitationEN.PaperId,objvViewpointCitationEN.ViewpointId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsvViewpointCitationBL.vViewpointCitationDA.AddNewRecordBySQL2(objvViewpointCitationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsvViewpointCitationEN objvViewpointCitationEN, bool bolIsNeedCheckUniqueness = true)
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
objvViewpointCitationEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objvViewpointCitationEN.CheckUniqueness() == false)
{
strMsg = string.Format("(mId(mId)=[{0}],论文Id(PaperId)=[{1}],观点Id(ViewpointId)=[{2}])已经存在,不能重复!", objvViewpointCitationEN.mId, objvViewpointCitationEN.PaperId, objvViewpointCitationEN.ViewpointId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objvViewpointCitationEN.AddNewRecord();
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
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsvViewpointCitationEN objvViewpointCitationEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objvViewpointCitationEN) == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],论文Id = [{1}],观点Id = [{2}]的数据已经存在!(in clsvViewpointCitationBL.AddNewRecordWithReturnKey)", objvViewpointCitationEN.mId,objvViewpointCitationEN.PaperId,objvViewpointCitationEN.ViewpointId);
throw new Exception(strMsg);
}
try
{
string strKey = clsvViewpointCitationBL.vViewpointCitationDA.AddNewRecordBySQL2WithReturnKey(objvViewpointCitationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetMemo(this clsvViewpointCitationEN objvViewpointCitationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewpointCitation.Memo);
}
objvViewpointCitationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.Memo) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.Memo, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.Memo] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetmId(this clsvViewpointCitationEN objvViewpointCitationEN, long lngmId, string strComparisonOp="")
	{
objvViewpointCitationEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.mId) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.mId, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.mId] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetPaperContent(this clsvViewpointCitationEN objvViewpointCitationEN, string strPaperContent, string strComparisonOp="")
	{
objvViewpointCitationEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.PaperContent) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.PaperContent, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.PaperContent] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetPaperId(this clsvViewpointCitationEN objvViewpointCitationEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convViewpointCitation.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convViewpointCitation.PaperId);
}
objvViewpointCitationEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.PaperId) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.PaperId, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.PaperId] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetPaperTitle(this clsvViewpointCitationEN objvViewpointCitationEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convViewpointCitation.PaperTitle);
}
objvViewpointCitationEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.PaperTitle) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.PaperTitle, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.PaperTitle] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetReason(this clsvViewpointCitationEN objvViewpointCitationEN, string strReason, string strComparisonOp="")
	{
objvViewpointCitationEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.Reason) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.Reason, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.Reason] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetUpdUserId(this clsvViewpointCitationEN objvViewpointCitationEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convViewpointCitation.UpdUserId);
}
objvViewpointCitationEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.UpdUserId) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.UpdUserId, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.UpdUserId] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetUserName(this clsvViewpointCitationEN objvViewpointCitationEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convViewpointCitation.UserName);
}
objvViewpointCitationEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.UserName) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.UserName, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.UserName] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetViewpointId(this clsvViewpointCitationEN objvViewpointCitationEN, string strViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convViewpointCitation.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convViewpointCitation.ViewpointId);
}
objvViewpointCitationEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.ViewpointId) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.ViewpointId, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.ViewpointId] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetViewpointName(this clsvViewpointCitationEN objvViewpointCitationEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convViewpointCitation.ViewpointName);
}
objvViewpointCitationEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.ViewpointName) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.ViewpointName, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.ViewpointName] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetViewpointTypeId(this clsvViewpointCitationEN objvViewpointCitationEN, string strViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeId, 4, convViewpointCitation.ViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointTypeId, 4, convViewpointCitation.ViewpointTypeId);
}
objvViewpointCitationEN.ViewpointTypeId = strViewpointTypeId; //观点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.ViewpointTypeId) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.ViewpointTypeId, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.ViewpointTypeId] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetViewpointTypeName(this clsvViewpointCitationEN objvViewpointCitationEN, string strViewpointTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeName, 50, convViewpointCitation.ViewpointTypeName);
}
objvViewpointCitationEN.ViewpointTypeName = strViewpointTypeName; //观点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.ViewpointTypeName) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.ViewpointTypeName, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.ViewpointTypeName] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetUpdDate(this clsvViewpointCitationEN objvViewpointCitationEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewpointCitation.UpdDate);
}
objvViewpointCitationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.UpdDate) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.UpdDate, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.UpdDate] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetProposePeople(this clsvViewpointCitationEN objvViewpointCitationEN, string strProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProposePeople, 50, convViewpointCitation.ProposePeople);
}
objvViewpointCitationEN.ProposePeople = strProposePeople; //提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.ProposePeople) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.ProposePeople, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.ProposePeople] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetSource(this clsvViewpointCitationEN objvViewpointCitationEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 500, convViewpointCitation.Source);
}
objvViewpointCitationEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.Source) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.Source, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.Source] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetTopicId(this clsvViewpointCitationEN objvViewpointCitationEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convViewpointCitation.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convViewpointCitation.TopicId);
}
objvViewpointCitationEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.TopicId) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.TopicId, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.TopicId] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointCitationEN SetTopicName(this clsvViewpointCitationEN objvViewpointCitationEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convViewpointCitation.TopicName);
}
objvViewpointCitationEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointCitationEN.dicFldComparisonOp.ContainsKey(convViewpointCitation.TopicName) == false)
{
objvViewpointCitationEN.dicFldComparisonOp.Add(convViewpointCitation.TopicName, strComparisonOp);
}
else
{
objvViewpointCitationEN.dicFldComparisonOp[convViewpointCitation.TopicName] = strComparisonOp;
}
}
return objvViewpointCitationEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsvViewpointCitationEN objvViewpointCitationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objvViewpointCitationEN.CheckPropertyNew();
clsvViewpointCitationEN objvViewpointCitationCond = new clsvViewpointCitationEN();
string strCondition = objvViewpointCitationCond
.SetmId(objvViewpointCitationEN.mId, "<>")
.SetmId(objvViewpointCitationEN.mId, "=")
.SetPaperId(objvViewpointCitationEN.PaperId, "=")
.SetViewpointId(objvViewpointCitationEN.ViewpointId, "=")
.GetCombineCondition();
objvViewpointCitationEN._IsCheckProperty = true;
bool bolIsExist = clsvViewpointCitationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mId_PaperId_ViewpointId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objvViewpointCitationEN.Update();
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
 /// <param name = "objvViewpointCitation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsvViewpointCitationEN objvViewpointCitation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsvViewpointCitationEN objvViewpointCitationCond = new clsvViewpointCitationEN();
string strCondition = objvViewpointCitationCond
.SetmId(objvViewpointCitation.mId, "=")
.SetPaperId(objvViewpointCitation.PaperId, "=")
.SetViewpointId(objvViewpointCitation.ViewpointId, "=")
.GetCombineCondition();
objvViewpointCitation._IsCheckProperty = true;
bool bolIsExist = clsvViewpointCitationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objvViewpointCitation.mId = clsvViewpointCitationBL.GetFirstID_S(strCondition);
objvViewpointCitation.UpdateWithCondition(strCondition);
}
else
{
objvViewpointCitation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsvViewpointCitationEN objvViewpointCitationEN)
{
 if (objvViewpointCitationEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsvViewpointCitationBL.vViewpointCitationDA.UpdateBySql2(objvViewpointCitationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsvViewpointCitationEN objvViewpointCitationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objvViewpointCitationEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsvViewpointCitationBL.vViewpointCitationDA.UpdateBySql2(objvViewpointCitationEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "objvViewpointCitationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsvViewpointCitationEN objvViewpointCitationEN, string strWhereCond)
{
try
{
bool bolResult = clsvViewpointCitationBL.vViewpointCitationDA.UpdateBySqlWithCondition(objvViewpointCitationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "objvViewpointCitationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsvViewpointCitationEN objvViewpointCitationEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsvViewpointCitationBL.vViewpointCitationDA.UpdateBySqlWithConditionTransaction(objvViewpointCitationEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsvViewpointCitationEN objvViewpointCitationEN)
{
try
{
int intRecNum = clsvViewpointCitationBL.vViewpointCitationDA.DelRecord(objvViewpointCitationEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "objvViewpointCitationENS">源对象</param>
 /// <param name = "objvViewpointCitationENT">目标对象</param>
 public static void CopyTo(this clsvViewpointCitationEN objvViewpointCitationENS, clsvViewpointCitationEN objvViewpointCitationENT)
{
try
{
objvViewpointCitationENT.Memo = objvViewpointCitationENS.Memo; //备注
objvViewpointCitationENT.mId = objvViewpointCitationENS.mId; //mId
objvViewpointCitationENT.PaperContent = objvViewpointCitationENS.PaperContent; //主题内容
objvViewpointCitationENT.PaperId = objvViewpointCitationENS.PaperId; //论文Id
objvViewpointCitationENT.PaperTitle = objvViewpointCitationENS.PaperTitle; //论文标题
objvViewpointCitationENT.Reason = objvViewpointCitationENS.Reason; //理由
objvViewpointCitationENT.UpdUserId = objvViewpointCitationENS.UpdUserId; //修改用户Id
objvViewpointCitationENT.UserName = objvViewpointCitationENS.UserName; //用户名
objvViewpointCitationENT.ViewpointId = objvViewpointCitationENS.ViewpointId; //观点Id
objvViewpointCitationENT.ViewpointName = objvViewpointCitationENS.ViewpointName; //观点名称
objvViewpointCitationENT.ViewpointTypeId = objvViewpointCitationENS.ViewpointTypeId; //观点类型Id
objvViewpointCitationENT.ViewpointTypeName = objvViewpointCitationENS.ViewpointTypeName; //观点类型名
objvViewpointCitationENT.UpdDate = objvViewpointCitationENS.UpdDate; //修改日期
objvViewpointCitationENT.ProposePeople = objvViewpointCitationENS.ProposePeople; //提出人
objvViewpointCitationENT.Source = objvViewpointCitationENS.Source; //来源
objvViewpointCitationENT.TopicId = objvViewpointCitationENS.TopicId; //主题Id
objvViewpointCitationENT.TopicName = objvViewpointCitationENS.TopicName; //栏目主题
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
 /// <param name = "objvViewpointCitationENS">源对象</param>
 /// <returns>目标对象=>clsvViewpointCitationEN:objvViewpointCitationENT</returns>
 public static clsvViewpointCitationEN CopyTo(this clsvViewpointCitationEN objvViewpointCitationENS)
{
try
{
 clsvViewpointCitationEN objvViewpointCitationENT = new clsvViewpointCitationEN()
{
Memo = objvViewpointCitationENS.Memo, //备注
mId = objvViewpointCitationENS.mId, //mId
PaperContent = objvViewpointCitationENS.PaperContent, //主题内容
PaperId = objvViewpointCitationENS.PaperId, //论文Id
PaperTitle = objvViewpointCitationENS.PaperTitle, //论文标题
Reason = objvViewpointCitationENS.Reason, //理由
UpdUserId = objvViewpointCitationENS.UpdUserId, //修改用户Id
UserName = objvViewpointCitationENS.UserName, //用户名
ViewpointId = objvViewpointCitationENS.ViewpointId, //观点Id
ViewpointName = objvViewpointCitationENS.ViewpointName, //观点名称
ViewpointTypeId = objvViewpointCitationENS.ViewpointTypeId, //观点类型Id
ViewpointTypeName = objvViewpointCitationENS.ViewpointTypeName, //观点类型名
UpdDate = objvViewpointCitationENS.UpdDate, //修改日期
ProposePeople = objvViewpointCitationENS.ProposePeople, //提出人
Source = objvViewpointCitationENS.Source, //来源
TopicId = objvViewpointCitationENS.TopicId, //主题Id
TopicName = objvViewpointCitationENS.TopicName, //栏目主题
};
 return objvViewpointCitationENT;
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
public static void CheckPropertyNew(this clsvViewpointCitationEN objvViewpointCitationEN)
{
 clsvViewpointCitationBL.vViewpointCitationDA.CheckPropertyNew(objvViewpointCitationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvViewpointCitationEN objvViewpointCitationEN)
{
 clsvViewpointCitationBL.vViewpointCitationDA.CheckProperty4Condition(objvViewpointCitationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewpointCitationEN objvViewpointCitationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.Memo) == true)
{
string strComparisonOpMemo = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.Memo, objvViewpointCitationCond.Memo, strComparisonOpMemo);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.mId) == true)
{
string strComparisonOpmId = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpointCitation.mId, objvViewpointCitationCond.mId, strComparisonOpmId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.PaperId) == true)
{
string strComparisonOpPaperId = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.PaperId, objvViewpointCitationCond.PaperId, strComparisonOpPaperId);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.PaperTitle, objvViewpointCitationCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.UpdUserId, objvViewpointCitationCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.UserName) == true)
{
string strComparisonOpUserName = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.UserName, objvViewpointCitationCond.UserName, strComparisonOpUserName);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.ViewpointId) == true)
{
string strComparisonOpViewpointId = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.ViewpointId, objvViewpointCitationCond.ViewpointId, strComparisonOpViewpointId);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.ViewpointName) == true)
{
string strComparisonOpViewpointName = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.ViewpointName, objvViewpointCitationCond.ViewpointName, strComparisonOpViewpointName);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.ViewpointTypeId) == true)
{
string strComparisonOpViewpointTypeId = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.ViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.ViewpointTypeId, objvViewpointCitationCond.ViewpointTypeId, strComparisonOpViewpointTypeId);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.ViewpointTypeName) == true)
{
string strComparisonOpViewpointTypeName = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.ViewpointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.ViewpointTypeName, objvViewpointCitationCond.ViewpointTypeName, strComparisonOpViewpointTypeName);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.UpdDate, objvViewpointCitationCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.ProposePeople) == true)
{
string strComparisonOpProposePeople = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.ProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.ProposePeople, objvViewpointCitationCond.ProposePeople, strComparisonOpProposePeople);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.Source) == true)
{
string strComparisonOpSource = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.Source, objvViewpointCitationCond.Source, strComparisonOpSource);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.TopicId) == true)
{
string strComparisonOpTopicId = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.TopicId, objvViewpointCitationCond.TopicId, strComparisonOpTopicId);
}
if (objvViewpointCitationCond.IsUpdated(convViewpointCitation.TopicName) == true)
{
string strComparisonOpTopicName = objvViewpointCitationCond.dicFldComparisonOp[convViewpointCitation.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointCitation.TopicName, objvViewpointCitationCond.TopicName, strComparisonOpTopicName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vViewpointCitation(v观点引用), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId_PaperId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvViewpointCitationEN objvViewpointCitationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointCitationEN == null) return true;
if (objvViewpointCitationEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvViewpointCitationEN.mId);
 if (objvViewpointCitationEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objvViewpointCitationEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objvViewpointCitationEN.PaperId);
}
 if (objvViewpointCitationEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objvViewpointCitationEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointCitationEN.ViewpointId);
}
if (clsvViewpointCitationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvViewpointCitationEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvViewpointCitationEN.mId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objvViewpointCitationEN.PaperId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointCitationEN.ViewpointId);
if (clsvViewpointCitationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vViewpointCitation(v观点引用), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId_PaperId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvViewpointCitationEN objvViewpointCitationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointCitationEN == null) return "";
if (objvViewpointCitationEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvViewpointCitationEN.mId);
 if (objvViewpointCitationEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objvViewpointCitationEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objvViewpointCitationEN.PaperId);
}
 if (objvViewpointCitationEN.ViewpointId == null)
{
 sbCondition.AppendFormat(" and ViewpointId is null", objvViewpointCitationEN.ViewpointId);
}
else
{
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointCitationEN.ViewpointId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvViewpointCitationEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvViewpointCitationEN.mId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objvViewpointCitationEN.PaperId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointCitationEN.ViewpointId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewpointCitation
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v观点引用(vViewpointCitation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewpointCitationBL
{
public static RelatedActions_vViewpointCitation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewpointCitationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewpointCitationDA vViewpointCitationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewpointCitationDA();
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
 public clsvViewpointCitationBL()
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
if (string.IsNullOrEmpty(clsvViewpointCitationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewpointCitationEN._ConnectString);
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
public static DataTable GetDataTable_vViewpointCitation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewpointCitationDA.GetDataTable_vViewpointCitation(strWhereCond);
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
objDT = vViewpointCitationDA.GetDataTable(strWhereCond);
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
objDT = vViewpointCitationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewpointCitationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewpointCitationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewpointCitationDA.GetDataTable_Top(objTopPara);
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
objDT = vViewpointCitationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewpointCitationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewpointCitationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewpointCitationEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewpointCitationEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvViewpointCitationEN._CurrTabName);
List<clsvViewpointCitationEN> arrvViewpointCitationObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointCitationEN> arrvViewpointCitationObjLst_Sel =
arrvViewpointCitationObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvViewpointCitationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointCitationEN> GetObjLst(string strWhereCond)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
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
public static List<clsvViewpointCitationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewpointCitationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewpointCitationEN> GetSubObjLstCache(clsvViewpointCitationEN objvViewpointCitationCond)
{
List<clsvViewpointCitationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointCitationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointCitation.AttributeName)
{
if (objvViewpointCitationCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointCitationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointCitationCond[strFldName].ToString());
}
else
{
if (objvViewpointCitationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointCitationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointCitationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointCitationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointCitationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointCitationCond[strFldName]));
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
public static List<clsvViewpointCitationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
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
public static List<clsvViewpointCitationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
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
List<clsvViewpointCitationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewpointCitationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointCitationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewpointCitationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
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
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
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
public static List<clsvViewpointCitationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewpointCitationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewpointCitationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
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
public static List<clsvViewpointCitationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointCitationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewpointCitationEN> arrObjLst = new List<clsvViewpointCitationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointCitationEN objvViewpointCitationEN = new clsvViewpointCitationEN();
try
{
objvViewpointCitationEN.Memo = objRow[convViewpointCitation.Memo] == DBNull.Value ? null : objRow[convViewpointCitation.Memo].ToString().Trim(); //备注
objvViewpointCitationEN.mId = Int32.Parse(objRow[convViewpointCitation.mId].ToString().Trim()); //mId
objvViewpointCitationEN.PaperContent = objRow[convViewpointCitation.PaperContent] == DBNull.Value ? null : objRow[convViewpointCitation.PaperContent].ToString().Trim(); //主题内容
objvViewpointCitationEN.PaperId = objRow[convViewpointCitation.PaperId] == DBNull.Value ? null : objRow[convViewpointCitation.PaperId].ToString().Trim(); //论文Id
objvViewpointCitationEN.PaperTitle = objRow[convViewpointCitation.PaperTitle] == DBNull.Value ? null : objRow[convViewpointCitation.PaperTitle].ToString().Trim(); //论文标题
objvViewpointCitationEN.Reason = objRow[convViewpointCitation.Reason] == DBNull.Value ? null : objRow[convViewpointCitation.Reason].ToString().Trim(); //理由
objvViewpointCitationEN.UpdUserId = objRow[convViewpointCitation.UpdUserId] == DBNull.Value ? null : objRow[convViewpointCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvViewpointCitationEN.UserName = objRow[convViewpointCitation.UserName] == DBNull.Value ? null : objRow[convViewpointCitation.UserName].ToString().Trim(); //用户名
objvViewpointCitationEN.ViewpointId = objRow[convViewpointCitation.ViewpointId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointId].ToString().Trim(); //观点Id
objvViewpointCitationEN.ViewpointName = objRow[convViewpointCitation.ViewpointName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointName].ToString().Trim(); //观点名称
objvViewpointCitationEN.ViewpointTypeId = objRow[convViewpointCitation.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointCitationEN.ViewpointTypeName = objRow[convViewpointCitation.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpointCitation.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointCitationEN.UpdDate = objRow[convViewpointCitation.UpdDate] == DBNull.Value ? null : objRow[convViewpointCitation.UpdDate].ToString().Trim(); //修改日期
objvViewpointCitationEN.ProposePeople = objRow[convViewpointCitation.ProposePeople] == DBNull.Value ? null : objRow[convViewpointCitation.ProposePeople].ToString().Trim(); //提出人
objvViewpointCitationEN.Source = objRow[convViewpointCitation.Source] == DBNull.Value ? null : objRow[convViewpointCitation.Source].ToString().Trim(); //来源
objvViewpointCitationEN.TopicId = objRow[convViewpointCitation.TopicId] == DBNull.Value ? null : objRow[convViewpointCitation.TopicId].ToString().Trim(); //主题Id
objvViewpointCitationEN.TopicName = objRow[convViewpointCitation.TopicName] == DBNull.Value ? null : objRow[convViewpointCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointCitationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewpointCitation(ref clsvViewpointCitationEN objvViewpointCitationEN)
{
bool bolResult = vViewpointCitationDA.GetvViewpointCitation(ref objvViewpointCitationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointCitationEN GetObjBymId(long lngmId)
{
clsvViewpointCitationEN objvViewpointCitationEN = vViewpointCitationDA.GetObjBymId(lngmId);
return objvViewpointCitationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewpointCitationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewpointCitationEN objvViewpointCitationEN = vViewpointCitationDA.GetFirstObj(strWhereCond);
 return objvViewpointCitationEN;
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
public static clsvViewpointCitationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewpointCitationEN objvViewpointCitationEN = vViewpointCitationDA.GetObjByDataRow(objRow);
 return objvViewpointCitationEN;
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
public static clsvViewpointCitationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewpointCitationEN objvViewpointCitationEN = vViewpointCitationDA.GetObjByDataRow(objRow);
 return objvViewpointCitationEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvViewpointCitationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointCitationEN GetObjBymIdFromList(long lngmId, List<clsvViewpointCitationEN> lstvViewpointCitationObjLst)
{
foreach (clsvViewpointCitationEN objvViewpointCitationEN in lstvViewpointCitationObjLst)
{
if (objvViewpointCitationEN.mId == lngmId)
{
return objvViewpointCitationEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvViewpointCitationDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vViewpointCitationDA.GetID(strWhereCond);
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
bool bolIsExist = vViewpointCitationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vViewpointCitationDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsvViewpointCitationEN objvViewpointCitationEN = clsvViewpointCitationBL.GetObjBymId(lngmId);
objvViewpointCitationEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsvViewpointCitationBL.UpdateBySql2(objvViewpointCitationEN);
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
 bolIsExist = clsvViewpointCitationDA.IsExistTable();
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
 bolIsExist = vViewpointCitationDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsvViewpointCitationEN objvViewpointCitationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objvViewpointCitationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],论文Id = [{1}],观点Id = [{2}]的数据已经存在!(in clsvViewpointCitationBL.AddNewRecordBySql2)", objvViewpointCitationEN.mId,objvViewpointCitationEN.PaperId,objvViewpointCitationEN.ViewpointId);
throw new Exception(strMsg);
}
try
{
bool bolResult = vViewpointCitationDA.AddNewRecordBySQL2(objvViewpointCitationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsvViewpointCitationEN objvViewpointCitationEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objvViewpointCitationEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!mId = [{0}],论文Id = [{1}],观点Id = [{2}]的数据已经存在!(in clsvViewpointCitationBL.AddNewRecordBySql2WithReturnKey)", objvViewpointCitationEN.mId,objvViewpointCitationEN.PaperId,objvViewpointCitationEN.ViewpointId);
throw new Exception(strMsg);
}
try
{
string strKey = vViewpointCitationDA.AddNewRecordBySQL2WithReturnKey(objvViewpointCitationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsvViewpointCitationEN objvViewpointCitationEN)
{
try
{
bool bolResult = vViewpointCitationDA.Update(objvViewpointCitationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "objvViewpointCitationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsvViewpointCitationEN objvViewpointCitationEN)
{
 if (objvViewpointCitationEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = vViewpointCitationDA.UpdateBySql2(objvViewpointCitationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvViewpointCitationBL.ReFreshCache();

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsvViewpointCitationEN objvViewpointCitationEN = clsvViewpointCitationBL.GetObjBymId(lngmId);

if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(objvViewpointCitationEN.mId, "SetUpdDate");
}
if (objvViewpointCitationEN != null)
{
int intRecNum = vViewpointCitationDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
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
//删除与表:[vViewpointCitation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//convViewpointCitation.mId,
//lngmId);
//        clsvViewpointCitationBL.DelvViewpointCitationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsvViewpointCitationBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsvViewpointCitationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsvViewpointCitationBL.relatedActions != null)
{
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = vViewpointCitationDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelvViewpointCitations(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsvViewpointCitationBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = vViewpointCitationDA.DelvViewpointCitation(arrmIdLst);
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
public static int DelvViewpointCitationsByCond(string strWhereCond)
{
try
{
if (clsvViewpointCitationBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsvViewpointCitationBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = vViewpointCitationDA.DelvViewpointCitation(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[vViewpointCitation]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvViewpointCitationDA.GetSpecSQLObj();
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
//删除与表:[vViewpointCitation]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsvViewpointCitationBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsvViewpointCitationBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objvViewpointCitationENS">源对象</param>
 /// <param name = "objvViewpointCitationENT">目标对象</param>
 public static void CopyTo(clsvViewpointCitationEN objvViewpointCitationENS, clsvViewpointCitationEN objvViewpointCitationENT)
{
try
{
objvViewpointCitationENT.Memo = objvViewpointCitationENS.Memo; //备注
objvViewpointCitationENT.mId = objvViewpointCitationENS.mId; //mId
objvViewpointCitationENT.PaperContent = objvViewpointCitationENS.PaperContent; //主题内容
objvViewpointCitationENT.PaperId = objvViewpointCitationENS.PaperId; //论文Id
objvViewpointCitationENT.PaperTitle = objvViewpointCitationENS.PaperTitle; //论文标题
objvViewpointCitationENT.Reason = objvViewpointCitationENS.Reason; //理由
objvViewpointCitationENT.UpdUserId = objvViewpointCitationENS.UpdUserId; //修改用户Id
objvViewpointCitationENT.UserName = objvViewpointCitationENS.UserName; //用户名
objvViewpointCitationENT.ViewpointId = objvViewpointCitationENS.ViewpointId; //观点Id
objvViewpointCitationENT.ViewpointName = objvViewpointCitationENS.ViewpointName; //观点名称
objvViewpointCitationENT.ViewpointTypeId = objvViewpointCitationENS.ViewpointTypeId; //观点类型Id
objvViewpointCitationENT.ViewpointTypeName = objvViewpointCitationENS.ViewpointTypeName; //观点类型名
objvViewpointCitationENT.UpdDate = objvViewpointCitationENS.UpdDate; //修改日期
objvViewpointCitationENT.ProposePeople = objvViewpointCitationENS.ProposePeople; //提出人
objvViewpointCitationENT.Source = objvViewpointCitationENS.Source; //来源
objvViewpointCitationENT.TopicId = objvViewpointCitationENS.TopicId; //主题Id
objvViewpointCitationENT.TopicName = objvViewpointCitationENS.TopicName; //栏目主题
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
 /// <param name = "objvViewpointCitationEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewpointCitationEN objvViewpointCitationEN)
{
try
{
objvViewpointCitationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewpointCitationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewpointCitation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.Memo = objvViewpointCitationEN.Memo == "[null]" ? null :  objvViewpointCitationEN.Memo; //备注
}
if (arrFldSet.Contains(convViewpointCitation.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.mId = objvViewpointCitationEN.mId; //mId
}
if (arrFldSet.Contains(convViewpointCitation.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.PaperContent = objvViewpointCitationEN.PaperContent == "[null]" ? null :  objvViewpointCitationEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convViewpointCitation.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.PaperId = objvViewpointCitationEN.PaperId == "[null]" ? null :  objvViewpointCitationEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convViewpointCitation.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.PaperTitle = objvViewpointCitationEN.PaperTitle == "[null]" ? null :  objvViewpointCitationEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convViewpointCitation.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.Reason = objvViewpointCitationEN.Reason == "[null]" ? null :  objvViewpointCitationEN.Reason; //理由
}
if (arrFldSet.Contains(convViewpointCitation.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.UpdUserId = objvViewpointCitationEN.UpdUserId == "[null]" ? null :  objvViewpointCitationEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convViewpointCitation.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.UserName = objvViewpointCitationEN.UserName == "[null]" ? null :  objvViewpointCitationEN.UserName; //用户名
}
if (arrFldSet.Contains(convViewpointCitation.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.ViewpointId = objvViewpointCitationEN.ViewpointId == "[null]" ? null :  objvViewpointCitationEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(convViewpointCitation.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.ViewpointName = objvViewpointCitationEN.ViewpointName == "[null]" ? null :  objvViewpointCitationEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(convViewpointCitation.ViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.ViewpointTypeId = objvViewpointCitationEN.ViewpointTypeId == "[null]" ? null :  objvViewpointCitationEN.ViewpointTypeId; //观点类型Id
}
if (arrFldSet.Contains(convViewpointCitation.ViewpointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.ViewpointTypeName = objvViewpointCitationEN.ViewpointTypeName == "[null]" ? null :  objvViewpointCitationEN.ViewpointTypeName; //观点类型名
}
if (arrFldSet.Contains(convViewpointCitation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.UpdDate = objvViewpointCitationEN.UpdDate == "[null]" ? null :  objvViewpointCitationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewpointCitation.ProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.ProposePeople = objvViewpointCitationEN.ProposePeople == "[null]" ? null :  objvViewpointCitationEN.ProposePeople; //提出人
}
if (arrFldSet.Contains(convViewpointCitation.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.Source = objvViewpointCitationEN.Source == "[null]" ? null :  objvViewpointCitationEN.Source; //来源
}
if (arrFldSet.Contains(convViewpointCitation.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.TopicId = objvViewpointCitationEN.TopicId == "[null]" ? null :  objvViewpointCitationEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convViewpointCitation.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointCitationEN.TopicName = objvViewpointCitationEN.TopicName == "[null]" ? null :  objvViewpointCitationEN.TopicName; //栏目主题
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
 /// <param name = "objvViewpointCitationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewpointCitationEN objvViewpointCitationEN)
{
try
{
if (objvViewpointCitationEN.Memo == "[null]") objvViewpointCitationEN.Memo = null; //备注
if (objvViewpointCitationEN.PaperContent == "[null]") objvViewpointCitationEN.PaperContent = null; //主题内容
if (objvViewpointCitationEN.PaperId == "[null]") objvViewpointCitationEN.PaperId = null; //论文Id
if (objvViewpointCitationEN.PaperTitle == "[null]") objvViewpointCitationEN.PaperTitle = null; //论文标题
if (objvViewpointCitationEN.Reason == "[null]") objvViewpointCitationEN.Reason = null; //理由
if (objvViewpointCitationEN.UpdUserId == "[null]") objvViewpointCitationEN.UpdUserId = null; //修改用户Id
if (objvViewpointCitationEN.UserName == "[null]") objvViewpointCitationEN.UserName = null; //用户名
if (objvViewpointCitationEN.ViewpointId == "[null]") objvViewpointCitationEN.ViewpointId = null; //观点Id
if (objvViewpointCitationEN.ViewpointName == "[null]") objvViewpointCitationEN.ViewpointName = null; //观点名称
if (objvViewpointCitationEN.ViewpointTypeId == "[null]") objvViewpointCitationEN.ViewpointTypeId = null; //观点类型Id
if (objvViewpointCitationEN.ViewpointTypeName == "[null]") objvViewpointCitationEN.ViewpointTypeName = null; //观点类型名
if (objvViewpointCitationEN.UpdDate == "[null]") objvViewpointCitationEN.UpdDate = null; //修改日期
if (objvViewpointCitationEN.ProposePeople == "[null]") objvViewpointCitationEN.ProposePeople = null; //提出人
if (objvViewpointCitationEN.Source == "[null]") objvViewpointCitationEN.Source = null; //来源
if (objvViewpointCitationEN.TopicId == "[null]") objvViewpointCitationEN.TopicId = null; //主题Id
if (objvViewpointCitationEN.TopicName == "[null]") objvViewpointCitationEN.TopicName = null; //栏目主题
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
public static void CheckPropertyNew(clsvViewpointCitationEN objvViewpointCitationEN)
{
 vViewpointCitationDA.CheckPropertyNew(objvViewpointCitationEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvViewpointCitationEN objvViewpointCitationEN)
{
 vViewpointCitationDA.CheckProperty4Condition(objvViewpointCitationEN);
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
if (clsvViewpointCitationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsvViewpointCitationBL没有刷新缓存机制(clsvViewpointCitationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvViewpointCitationObjLstCache == null)
//{
//arrvViewpointCitationObjLstCache = vViewpointCitationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointCitationEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvViewpointCitationEN._CurrTabName);
List<clsvViewpointCitationEN> arrvViewpointCitationObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointCitationEN> arrvViewpointCitationObjLst_Sel =
arrvViewpointCitationObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvViewpointCitationObjLst_Sel.Count() == 0)
{
   clsvViewpointCitationEN obj = clsvViewpointCitationBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvViewpointCitationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointCitationEN> GetAllvViewpointCitationObjLstCache()
{
//获取缓存中的对象列表
List<clsvViewpointCitationEN> arrvViewpointCitationObjLstCache = GetObjLstCache(); 
return arrvViewpointCitationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointCitationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvViewpointCitationEN._CurrTabName);
List<clsvViewpointCitationEN> arrvViewpointCitationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvViewpointCitationObjLstCache;
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
string strKey = string.Format("{0}", clsvViewpointCitationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvViewpointCitationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvViewpointCitationEN._RefreshTimeLst.Count == 0) return "";
return clsvViewpointCitationEN._RefreshTimeLst[clsvViewpointCitationEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsvViewpointCitationBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsvViewpointCitationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvViewpointCitationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsvViewpointCitationBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vViewpointCitation(v观点引用)
 /// 唯一性条件:mId_PaperId_ViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvViewpointCitationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvViewpointCitationEN objvViewpointCitationEN)
{
//检测记录是否存在
string strResult = vViewpointCitationDA.GetUniCondStr(objvViewpointCitationEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convViewpointCitation.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewpointCitation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewpointCitation.AttributeName));
throw new Exception(strMsg);
}
var objvViewpointCitation = clsvViewpointCitationBL.GetObjBymIdCache(lngmId);
if (objvViewpointCitation == null) return "";
return objvViewpointCitation[strOutFldName].ToString();
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
int intRecCount = clsvViewpointCitationDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewpointCitationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewpointCitationDA.GetRecCount();
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
int intRecCount = clsvViewpointCitationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewpointCitationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewpointCitationEN objvViewpointCitationCond)
{
List<clsvViewpointCitationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvViewpointCitationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpointCitation.AttributeName)
{
if (objvViewpointCitationCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointCitationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointCitationCond[strFldName].ToString());
}
else
{
if (objvViewpointCitationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointCitationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointCitationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointCitationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointCitationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointCitationCond[strFldName]));
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
 List<string> arrList = clsvViewpointCitationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewpointCitationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewpointCitationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = vViewpointCitationDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsvViewpointCitationDA.SetFldValue(clsvViewpointCitationEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = vViewpointCitationDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsvViewpointCitationDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsvViewpointCitationDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsvViewpointCitationDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[vViewpointCitation] "); 
 strCreateTabCode.Append(" ( "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**主题内容*/ 
 strCreateTabCode.Append(" PaperContent text Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**论文标题*/ 
 strCreateTabCode.Append(" PaperTitle varchar(500) Null, "); 
 // /**理由*/ 
 strCreateTabCode.Append(" Reason text Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null, "); 
 // /**观点Id*/ 
 strCreateTabCode.Append(" ViewpointId char(8) Null, "); 
 // /**观点名称*/ 
 strCreateTabCode.Append(" ViewpointName varchar(500) Null, "); 
 // /**观点类型Id*/ 
 strCreateTabCode.Append(" ViewpointTypeId char(4) Null, "); 
 // /**观点类型名*/ 
 strCreateTabCode.Append(" ViewpointTypeName varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**提出人*/ 
 strCreateTabCode.Append(" ProposePeople varchar(50) Null, "); 
 // /**来源*/ 
 strCreateTabCode.Append(" Source varchar(500) Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**栏目主题*/ 
 strCreateTabCode.Append(" TopicName varchar(200) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// v观点引用(vViewpointCitation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4vViewpointCitation : clsCommFun4BL
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
clsvViewpointCitationBL.ReFreshThisCache();
}
}

}