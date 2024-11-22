
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubAttachmentBL
 表名:vPaperSubAttachment(01120598)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsvPaperSubAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubAttachmentEN GetObj(this K_PaperSubAttachmentId_vPaperSubAttachment myKey)
{
clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.GetObjByPaperSubAttachmentId(myKey.Value);
return objvPaperSubAttachmentEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
if (CheckUniqueness(objvPaperSubAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!子观点附件Id = [{0}]的数据已经存在!(in clsvPaperSubAttachmentBL.AddNewRecord)", objvPaperSubAttachmentEN.PaperSubAttachmentId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.AddNewRecordBySQL2(objvPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
public static bool AddRecordEx(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
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
objvPaperSubAttachmentEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objvPaperSubAttachmentEN.CheckUniqueness() == false)
{
strMsg = string.Format("(子观点附件Id(PaperSubAttachmentId)=[{0}])已经存在,不能重复!", objvPaperSubAttachmentEN.PaperSubAttachmentId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objvPaperSubAttachmentEN.AddNewRecord();
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
 /// <param name = "objvPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
if (CheckUniqueness(objvPaperSubAttachmentEN) == false)
{
var strMsg = string.Format("记录已经存在!子观点附件Id = [{0}]的数据已经存在!(in clsvPaperSubAttachmentBL.AddNewRecordWithReturnKey)", objvPaperSubAttachmentEN.PaperSubAttachmentId);
throw new Exception(strMsg);
}
try
{
string strKey = clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.AddNewRecordBySQL2WithReturnKey(objvPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetExplainContent(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strExplainContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainContent, 5000, convPaperSubAttachment.ExplainContent);
}
objvPaperSubAttachmentEN.ExplainContent = strExplainContent; //说明内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.ExplainContent) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.ExplainContent, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.ExplainContent] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetSubViewpointId(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strSubViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointId, 8, convPaperSubAttachment.SubViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSubViewpointId, 8, convPaperSubAttachment.SubViewpointId);
}
objvPaperSubAttachmentEN.SubViewpointId = strSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.SubViewpointId) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.SubViewpointId, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.SubViewpointId] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetFilePath(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convPaperSubAttachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convPaperSubAttachment.FilePath);
}
objvPaperSubAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.FilePath) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.FilePath, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.FilePath] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetMemo(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperSubAttachment.Memo);
}
objvPaperSubAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.Memo) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.Memo, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.Memo] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetPaperRWId(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strPaperRWId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, convPaperSubAttachment.PaperRWId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, convPaperSubAttachment.PaperRWId);
}
objvPaperSubAttachmentEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.PaperRWId) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.PaperRWId, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.PaperRWId] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetPaperSubAttachmentName(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strPaperSubAttachmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperSubAttachmentName, 200, convPaperSubAttachment.PaperSubAttachmentName);
}
objvPaperSubAttachmentEN.PaperSubAttachmentName = strPaperSubAttachmentName; //附件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.PaperSubAttachmentName) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.PaperSubAttachmentName, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.PaperSubAttachmentName] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetRWTitle(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strRWTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRWTitle, 50, convPaperSubAttachment.RWTitle);
}
objvPaperSubAttachmentEN.RWTitle = strRWTitle; //读写标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.RWTitle) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.RWTitle, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.RWTitle] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetSubViewpointContent(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strSubViewpointContent, string strComparisonOp="")
	{
objvPaperSubAttachmentEN.SubViewpointContent = strSubViewpointContent; //详情内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.SubViewpointContent) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.SubViewpointContent, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.SubViewpointContent] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetUpdDate(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperSubAttachment.UpdDate);
}
objvPaperSubAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.UpdDate) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.UpdDate, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.UpdDate] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetUpdUserId(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convPaperSubAttachment.UpdUserId);
}
objvPaperSubAttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.UpdUserId) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.UpdUserId, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.UpdUserId] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubAttachmentEN SetPaperSubAttachmentId(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, long lngPaperSubAttachmentId, string strComparisonOp="")
	{
objvPaperSubAttachmentEN.PaperSubAttachmentId = lngPaperSubAttachmentId; //子观点附件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubAttachmentEN.dicFldComparisonOp.ContainsKey(convPaperSubAttachment.PaperSubAttachmentId) == false)
{
objvPaperSubAttachmentEN.dicFldComparisonOp.Add(convPaperSubAttachment.PaperSubAttachmentId, strComparisonOp);
}
else
{
objvPaperSubAttachmentEN.dicFldComparisonOp[convPaperSubAttachment.PaperSubAttachmentId] = strComparisonOp;
}
}
return objvPaperSubAttachmentEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objvPaperSubAttachmentEN.CheckPropertyNew();
clsvPaperSubAttachmentEN objvPaperSubAttachmentCond = new clsvPaperSubAttachmentEN();
string strCondition = objvPaperSubAttachmentCond
.SetPaperSubAttachmentId(objvPaperSubAttachmentEN.PaperSubAttachmentId, "<>")
.SetPaperSubAttachmentId(objvPaperSubAttachmentEN.PaperSubAttachmentId, "=")
.GetCombineCondition();
objvPaperSubAttachmentEN._IsCheckProperty = true;
bool bolIsExist = clsvPaperSubAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PaperSubAttachmentId_SubViewpointId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objvPaperSubAttachmentEN.Update();
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
 /// <param name = "objvPaperSubAttachment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsvPaperSubAttachmentEN objvPaperSubAttachment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsvPaperSubAttachmentEN objvPaperSubAttachmentCond = new clsvPaperSubAttachmentEN();
string strCondition = objvPaperSubAttachmentCond
.SetPaperSubAttachmentId(objvPaperSubAttachment.PaperSubAttachmentId, "=")
.GetCombineCondition();
objvPaperSubAttachment._IsCheckProperty = true;
bool bolIsExist = clsvPaperSubAttachmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objvPaperSubAttachment.PaperSubAttachmentId = clsvPaperSubAttachmentBL.GetFirstID_S(strCondition);
objvPaperSubAttachment.UpdateWithCondition(strCondition);
}
else
{
objvPaperSubAttachment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
 if (objvPaperSubAttachmentEN.PaperSubAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.UpdateBySql2(objvPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "objvPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objvPaperSubAttachmentEN.PaperSubAttachmentId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.UpdateBySql2(objvPaperSubAttachmentEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "objvPaperSubAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strWhereCond)
{
try
{
bool bolResult = clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.UpdateBySqlWithCondition(objvPaperSubAttachmentEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "objvPaperSubAttachmentEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.UpdateBySqlWithConditionTransaction(objvPaperSubAttachmentEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "lngPaperSubAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
try
{
int intRecNum = clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.DelRecord(objvPaperSubAttachmentEN.PaperSubAttachmentId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "objvPaperSubAttachmentENS">源对象</param>
 /// <param name = "objvPaperSubAttachmentENT">目标对象</param>
 public static void CopyTo(this clsvPaperSubAttachmentEN objvPaperSubAttachmentENS, clsvPaperSubAttachmentEN objvPaperSubAttachmentENT)
{
try
{
objvPaperSubAttachmentENT.ExplainContent = objvPaperSubAttachmentENS.ExplainContent; //说明内容
objvPaperSubAttachmentENT.SubViewpointId = objvPaperSubAttachmentENS.SubViewpointId; //子观点Id
objvPaperSubAttachmentENT.FilePath = objvPaperSubAttachmentENS.FilePath; //文件路径
objvPaperSubAttachmentENT.Memo = objvPaperSubAttachmentENS.Memo; //备注
objvPaperSubAttachmentENT.PaperRWId = objvPaperSubAttachmentENS.PaperRWId; //课文阅读
objvPaperSubAttachmentENT.PaperSubAttachmentName = objvPaperSubAttachmentENS.PaperSubAttachmentName; //附件名称
objvPaperSubAttachmentENT.RWTitle = objvPaperSubAttachmentENS.RWTitle; //读写标题
objvPaperSubAttachmentENT.SubViewpointContent = objvPaperSubAttachmentENS.SubViewpointContent; //详情内容
objvPaperSubAttachmentENT.UpdDate = objvPaperSubAttachmentENS.UpdDate; //修改日期
objvPaperSubAttachmentENT.UpdUserId = objvPaperSubAttachmentENS.UpdUserId; //修改用户Id
objvPaperSubAttachmentENT.PaperSubAttachmentId = objvPaperSubAttachmentENS.PaperSubAttachmentId; //子观点附件Id
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
 /// <param name = "objvPaperSubAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsvPaperSubAttachmentEN:objvPaperSubAttachmentENT</returns>
 public static clsvPaperSubAttachmentEN CopyTo(this clsvPaperSubAttachmentEN objvPaperSubAttachmentENS)
{
try
{
 clsvPaperSubAttachmentEN objvPaperSubAttachmentENT = new clsvPaperSubAttachmentEN()
{
ExplainContent = objvPaperSubAttachmentENS.ExplainContent, //说明内容
SubViewpointId = objvPaperSubAttachmentENS.SubViewpointId, //子观点Id
FilePath = objvPaperSubAttachmentENS.FilePath, //文件路径
Memo = objvPaperSubAttachmentENS.Memo, //备注
PaperRWId = objvPaperSubAttachmentENS.PaperRWId, //课文阅读
PaperSubAttachmentName = objvPaperSubAttachmentENS.PaperSubAttachmentName, //附件名称
RWTitle = objvPaperSubAttachmentENS.RWTitle, //读写标题
SubViewpointContent = objvPaperSubAttachmentENS.SubViewpointContent, //详情内容
UpdDate = objvPaperSubAttachmentENS.UpdDate, //修改日期
UpdUserId = objvPaperSubAttachmentENS.UpdUserId, //修改用户Id
PaperSubAttachmentId = objvPaperSubAttachmentENS.PaperSubAttachmentId, //子观点附件Id
};
 return objvPaperSubAttachmentENT;
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
public static void CheckPropertyNew(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
 clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.CheckPropertyNew(objvPaperSubAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
 clsvPaperSubAttachmentBL.vPaperSubAttachmentDA.CheckProperty4Condition(objvPaperSubAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperSubAttachmentEN objvPaperSubAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.ExplainContent) == true)
{
string strComparisonOpExplainContent = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.ExplainContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubAttachment.ExplainContent, objvPaperSubAttachmentCond.ExplainContent, strComparisonOpExplainContent);
}
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.SubViewpointId) == true)
{
string strComparisonOpSubViewpointId = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubAttachment.SubViewpointId, objvPaperSubAttachmentCond.SubViewpointId, strComparisonOpSubViewpointId);
}
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubAttachment.FilePath, objvPaperSubAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.Memo) == true)
{
string strComparisonOpMemo = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubAttachment.Memo, objvPaperSubAttachmentCond.Memo, strComparisonOpMemo);
}
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.PaperRWId) == true)
{
string strComparisonOpPaperRWId = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubAttachment.PaperRWId, objvPaperSubAttachmentCond.PaperRWId, strComparisonOpPaperRWId);
}
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.PaperSubAttachmentName) == true)
{
string strComparisonOpPaperSubAttachmentName = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.PaperSubAttachmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubAttachment.PaperSubAttachmentName, objvPaperSubAttachmentCond.PaperSubAttachmentName, strComparisonOpPaperSubAttachmentName);
}
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.RWTitle) == true)
{
string strComparisonOpRWTitle = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.RWTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubAttachment.RWTitle, objvPaperSubAttachmentCond.RWTitle, strComparisonOpRWTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubAttachment.UpdDate, objvPaperSubAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubAttachment.UpdUserId, objvPaperSubAttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvPaperSubAttachmentCond.IsUpdated(convPaperSubAttachment.PaperSubAttachmentId) == true)
{
string strComparisonOpPaperSubAttachmentId = objvPaperSubAttachmentCond.dicFldComparisonOp[convPaperSubAttachment.PaperSubAttachmentId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubAttachment.PaperSubAttachmentId, objvPaperSubAttachmentCond.PaperSubAttachmentId, strComparisonOpPaperSubAttachmentId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vPaperSubAttachment(子观点附件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PaperSubAttachmentId_SubViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvPaperSubAttachmentEN == null) return true;
if (objvPaperSubAttachmentEN.PaperSubAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperSubAttachmentId = '{0}'", objvPaperSubAttachmentEN.PaperSubAttachmentId);
if (clsvPaperSubAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PaperSubAttachmentId !=  {0}", objvPaperSubAttachmentEN.PaperSubAttachmentId);
 sbCondition.AppendFormat(" and PaperSubAttachmentId = '{0}'", objvPaperSubAttachmentEN.PaperSubAttachmentId);
if (clsvPaperSubAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vPaperSubAttachment(子观点附件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PaperSubAttachmentId_SubViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvPaperSubAttachmentEN == null) return "";
if (objvPaperSubAttachmentEN.PaperSubAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperSubAttachmentId = '{0}'", objvPaperSubAttachmentEN.PaperSubAttachmentId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperSubAttachmentId !=  {0}", objvPaperSubAttachmentEN.PaperSubAttachmentId);
 sbCondition.AppendFormat(" and PaperSubAttachmentId = '{0}'", objvPaperSubAttachmentEN.PaperSubAttachmentId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperSubAttachment
{
public virtual bool UpdRelaTabDate(long lngPaperSubAttachmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 子观点附件(vPaperSubAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperSubAttachmentBL
{
public static RelatedActions_vPaperSubAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperSubAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperSubAttachmentDA vPaperSubAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperSubAttachmentDA();
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
 public clsvPaperSubAttachmentBL()
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
if (string.IsNullOrEmpty(clsvPaperSubAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperSubAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_vPaperSubAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperSubAttachmentDA.GetDataTable_vPaperSubAttachment(strWhereCond);
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
objDT = vPaperSubAttachmentDA.GetDataTable(strWhereCond);
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
objDT = vPaperSubAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperSubAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperSubAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperSubAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperSubAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperSubAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperSubAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperSubAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperSubAttachmentEN> GetObjLstByPaperSubAttachmentIdLst(List<long> arrPaperSubAttachmentIdLst)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperSubAttachmentIdLst);
 string strWhereCond = string.Format("PaperSubAttachmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperSubAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperSubAttachmentEN> GetObjLstByPaperSubAttachmentIdLstCache(List<long> arrPaperSubAttachmentIdLst)
{
string strKey = string.Format("{0}", clsvPaperSubAttachmentEN._CurrTabName);
List<clsvPaperSubAttachmentEN> arrvPaperSubAttachmentObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubAttachmentEN> arrvPaperSubAttachmentObjLst_Sel =
arrvPaperSubAttachmentObjLstCache
.Where(x => arrPaperSubAttachmentIdLst.Contains(x.PaperSubAttachmentId));
return arrvPaperSubAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubAttachmentEN> GetObjLst(string strWhereCond)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
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
public static List<clsvPaperSubAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperSubAttachmentEN> GetSubObjLstCache(clsvPaperSubAttachmentEN objvPaperSubAttachmentCond)
{
List<clsvPaperSubAttachmentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSubAttachment.AttributeName)
{
if (objvPaperSubAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSubAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubAttachmentCond[strFldName].ToString());
}
else
{
if (objvPaperSubAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSubAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSubAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSubAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSubAttachmentCond[strFldName]));
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
public static List<clsvPaperSubAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
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
public static List<clsvPaperSubAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
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
List<clsvPaperSubAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperSubAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperSubAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
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
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
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
public static List<clsvPaperSubAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperSubAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperSubAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
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
public static List<clsvPaperSubAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperSubAttachmentEN> arrObjLst = new List<clsvPaperSubAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = new clsvPaperSubAttachmentEN();
try
{
objvPaperSubAttachmentEN.ExplainContent = objRow[convPaperSubAttachment.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubAttachmentEN.SubViewpointId = objRow[convPaperSubAttachment.SubViewpointId] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointId].ToString().Trim(); //子观点Id
objvPaperSubAttachmentEN.FilePath = objRow[convPaperSubAttachment.FilePath].ToString().Trim(); //文件路径
objvPaperSubAttachmentEN.Memo = objRow[convPaperSubAttachment.Memo] == DBNull.Value ? null : objRow[convPaperSubAttachment.Memo].ToString().Trim(); //备注
objvPaperSubAttachmentEN.PaperRWId = objRow[convPaperSubAttachment.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubAttachmentEN.PaperSubAttachmentName = objRow[convPaperSubAttachment.PaperSubAttachmentName] == DBNull.Value ? null : objRow[convPaperSubAttachment.PaperSubAttachmentName].ToString().Trim(); //附件名称
objvPaperSubAttachmentEN.RWTitle = objRow[convPaperSubAttachment.RWTitle] == DBNull.Value ? null : objRow[convPaperSubAttachment.RWTitle].ToString().Trim(); //读写标题
objvPaperSubAttachmentEN.SubViewpointContent = objRow[convPaperSubAttachment.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubAttachment.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubAttachmentEN.UpdDate = objRow[convPaperSubAttachment.UpdDate] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdDate].ToString().Trim(); //修改日期
objvPaperSubAttachmentEN.UpdUserId = objRow[convPaperSubAttachment.UpdUserId] == DBNull.Value ? null : objRow[convPaperSubAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvPaperSubAttachmentEN.PaperSubAttachmentId = Int32.Parse(objRow[convPaperSubAttachment.PaperSubAttachmentId].ToString().Trim()); //子观点附件Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubAttachmentEN.PaperSubAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperSubAttachment(ref clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
bool bolResult = vPaperSubAttachmentDA.GetvPaperSubAttachment(ref objvPaperSubAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubAttachmentEN GetObjByPaperSubAttachmentId(long lngPaperSubAttachmentId)
{
clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = vPaperSubAttachmentDA.GetObjByPaperSubAttachmentId(lngPaperSubAttachmentId);
return objvPaperSubAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperSubAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = vPaperSubAttachmentDA.GetFirstObj(strWhereCond);
 return objvPaperSubAttachmentEN;
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
public static clsvPaperSubAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = vPaperSubAttachmentDA.GetObjByDataRow(objRow);
 return objvPaperSubAttachmentEN;
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
public static clsvPaperSubAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = vPaperSubAttachmentDA.GetObjByDataRow(objRow);
 return objvPaperSubAttachmentEN;
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
 /// <param name = "lngPaperSubAttachmentId">所给的关键字</param>
 /// <param name = "lstvPaperSubAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubAttachmentEN GetObjByPaperSubAttachmentIdFromList(long lngPaperSubAttachmentId, List<clsvPaperSubAttachmentEN> lstvPaperSubAttachmentObjLst)
{
foreach (clsvPaperSubAttachmentEN objvPaperSubAttachmentEN in lstvPaperSubAttachmentObjLst)
{
if (objvPaperSubAttachmentEN.PaperSubAttachmentId == lngPaperSubAttachmentId)
{
return objvPaperSubAttachmentEN;
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
 long lngPaperSubAttachmentId;
 try
 {
 lngPaperSubAttachmentId = new clsvPaperSubAttachmentDA().GetFirstID(strWhereCond);
 return lngPaperSubAttachmentId;
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
 arrList = vPaperSubAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperSubAttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperSubAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperSubAttachmentId)
{
//检测记录是否存在
bool bolIsExist = vPaperSubAttachmentDA.IsExist(lngPaperSubAttachmentId);
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
 bolIsExist = clsvPaperSubAttachmentDA.IsExistTable();
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
 bolIsExist = vPaperSubAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
if (objvPaperSubAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!子观点附件Id = [{0}]的数据已经存在!(in clsvPaperSubAttachmentBL.AddNewRecordBySql2)", objvPaperSubAttachmentEN.PaperSubAttachmentId);
throw new Exception(strMsg);
}
try
{
bool bolResult = vPaperSubAttachmentDA.AddNewRecordBySQL2(objvPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "objvPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
if (objvPaperSubAttachmentEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!子观点附件Id = [{0}]的数据已经存在!(in clsvPaperSubAttachmentBL.AddNewRecordBySql2WithReturnKey)", objvPaperSubAttachmentEN.PaperSubAttachmentId);
throw new Exception(strMsg);
}
try
{
string strKey = vPaperSubAttachmentDA.AddNewRecordBySQL2WithReturnKey(objvPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "objvPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
try
{
bool bolResult = vPaperSubAttachmentDA.Update(objvPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "objvPaperSubAttachmentEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
 if (objvPaperSubAttachmentEN.PaperSubAttachmentId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = vPaperSubAttachmentDA.UpdateBySql2(objvPaperSubAttachmentEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsvPaperSubAttachmentBL.ReFreshCache();

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
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
 /// <param name = "lngPaperSubAttachmentId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngPaperSubAttachmentId)
{
try
{
 clsvPaperSubAttachmentEN objvPaperSubAttachmentEN = clsvPaperSubAttachmentBL.GetObjByPaperSubAttachmentId(lngPaperSubAttachmentId);

if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(objvPaperSubAttachmentEN.PaperSubAttachmentId, "SetUpdDate");
}
if (objvPaperSubAttachmentEN != null)
{
int intRecNum = vPaperSubAttachmentDA.DelRecord(lngPaperSubAttachmentId);
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
/// <param name="lngPaperSubAttachmentId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngPaperSubAttachmentId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvPaperSubAttachmentDA.GetSpecSQLObj();
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
//删除与表:[vPaperSubAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//convPaperSubAttachment.PaperSubAttachmentId,
//lngPaperSubAttachmentId);
//        clsvPaperSubAttachmentBL.DelvPaperSubAttachmentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsvPaperSubAttachmentBL.DelRecord(lngPaperSubAttachmentId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsvPaperSubAttachmentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperSubAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngPaperSubAttachmentId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngPaperSubAttachmentId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsvPaperSubAttachmentBL.relatedActions != null)
{
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(lngPaperSubAttachmentId, "UpdRelaTabDate");
}
bool bolResult = vPaperSubAttachmentDA.DelRecord(lngPaperSubAttachmentId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrPaperSubAttachmentIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelvPaperSubAttachments(List<string> arrPaperSubAttachmentIdLst)
{
if (arrPaperSubAttachmentIdLst.Count == 0) return 0;
try
{
if (clsvPaperSubAttachmentBL.relatedActions != null)
{
foreach (var strPaperSubAttachmentId in arrPaperSubAttachmentIdLst)
{
long lngPaperSubAttachmentId = long.Parse(strPaperSubAttachmentId);
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(lngPaperSubAttachmentId, "UpdRelaTabDate");
}
}
int intDelRecNum = vPaperSubAttachmentDA.DelvPaperSubAttachment(arrPaperSubAttachmentIdLst);
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
public static int DelvPaperSubAttachmentsByCond(string strWhereCond)
{
try
{
if (clsvPaperSubAttachmentBL.relatedActions != null)
{
List<string> arrPaperSubAttachmentId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPaperSubAttachmentId in arrPaperSubAttachmentId)
{
long lngPaperSubAttachmentId = long.Parse(strPaperSubAttachmentId);
clsvPaperSubAttachmentBL.relatedActions.UpdRelaTabDate(lngPaperSubAttachmentId, "UpdRelaTabDate");
}
}
int intRecNum = vPaperSubAttachmentDA.DelvPaperSubAttachment(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[vPaperSubAttachment]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngPaperSubAttachmentId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngPaperSubAttachmentId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvPaperSubAttachmentDA.GetSpecSQLObj();
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
//删除与表:[vPaperSubAttachment]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsvPaperSubAttachmentBL.DelRecord(lngPaperSubAttachmentId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsvPaperSubAttachmentBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngPaperSubAttachmentId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objvPaperSubAttachmentENS">源对象</param>
 /// <param name = "objvPaperSubAttachmentENT">目标对象</param>
 public static void CopyTo(clsvPaperSubAttachmentEN objvPaperSubAttachmentENS, clsvPaperSubAttachmentEN objvPaperSubAttachmentENT)
{
try
{
objvPaperSubAttachmentENT.ExplainContent = objvPaperSubAttachmentENS.ExplainContent; //说明内容
objvPaperSubAttachmentENT.SubViewpointId = objvPaperSubAttachmentENS.SubViewpointId; //子观点Id
objvPaperSubAttachmentENT.FilePath = objvPaperSubAttachmentENS.FilePath; //文件路径
objvPaperSubAttachmentENT.Memo = objvPaperSubAttachmentENS.Memo; //备注
objvPaperSubAttachmentENT.PaperRWId = objvPaperSubAttachmentENS.PaperRWId; //课文阅读
objvPaperSubAttachmentENT.PaperSubAttachmentName = objvPaperSubAttachmentENS.PaperSubAttachmentName; //附件名称
objvPaperSubAttachmentENT.RWTitle = objvPaperSubAttachmentENS.RWTitle; //读写标题
objvPaperSubAttachmentENT.SubViewpointContent = objvPaperSubAttachmentENS.SubViewpointContent; //详情内容
objvPaperSubAttachmentENT.UpdDate = objvPaperSubAttachmentENS.UpdDate; //修改日期
objvPaperSubAttachmentENT.UpdUserId = objvPaperSubAttachmentENS.UpdUserId; //修改用户Id
objvPaperSubAttachmentENT.PaperSubAttachmentId = objvPaperSubAttachmentENS.PaperSubAttachmentId; //子观点附件Id
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
 /// <param name = "objvPaperSubAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
try
{
objvPaperSubAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperSubAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperSubAttachment.ExplainContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.ExplainContent = objvPaperSubAttachmentEN.ExplainContent == "[null]" ? null :  objvPaperSubAttachmentEN.ExplainContent; //说明内容
}
if (arrFldSet.Contains(convPaperSubAttachment.SubViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.SubViewpointId = objvPaperSubAttachmentEN.SubViewpointId == "[null]" ? null :  objvPaperSubAttachmentEN.SubViewpointId; //子观点Id
}
if (arrFldSet.Contains(convPaperSubAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.FilePath = objvPaperSubAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convPaperSubAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.Memo = objvPaperSubAttachmentEN.Memo == "[null]" ? null :  objvPaperSubAttachmentEN.Memo; //备注
}
if (arrFldSet.Contains(convPaperSubAttachment.PaperRWId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.PaperRWId = objvPaperSubAttachmentEN.PaperRWId == "[null]" ? null :  objvPaperSubAttachmentEN.PaperRWId; //课文阅读
}
if (arrFldSet.Contains(convPaperSubAttachment.PaperSubAttachmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.PaperSubAttachmentName = objvPaperSubAttachmentEN.PaperSubAttachmentName == "[null]" ? null :  objvPaperSubAttachmentEN.PaperSubAttachmentName; //附件名称
}
if (arrFldSet.Contains(convPaperSubAttachment.RWTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.RWTitle = objvPaperSubAttachmentEN.RWTitle == "[null]" ? null :  objvPaperSubAttachmentEN.RWTitle; //读写标题
}
if (arrFldSet.Contains(convPaperSubAttachment.SubViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.SubViewpointContent = objvPaperSubAttachmentEN.SubViewpointContent == "[null]" ? null :  objvPaperSubAttachmentEN.SubViewpointContent; //详情内容
}
if (arrFldSet.Contains(convPaperSubAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.UpdDate = objvPaperSubAttachmentEN.UpdDate == "[null]" ? null :  objvPaperSubAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperSubAttachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.UpdUserId = objvPaperSubAttachmentEN.UpdUserId == "[null]" ? null :  objvPaperSubAttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convPaperSubAttachment.PaperSubAttachmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubAttachmentEN.PaperSubAttachmentId = objvPaperSubAttachmentEN.PaperSubAttachmentId; //子观点附件Id
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
 /// <param name = "objvPaperSubAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
try
{
if (objvPaperSubAttachmentEN.ExplainContent == "[null]") objvPaperSubAttachmentEN.ExplainContent = null; //说明内容
if (objvPaperSubAttachmentEN.SubViewpointId == "[null]") objvPaperSubAttachmentEN.SubViewpointId = null; //子观点Id
if (objvPaperSubAttachmentEN.Memo == "[null]") objvPaperSubAttachmentEN.Memo = null; //备注
if (objvPaperSubAttachmentEN.PaperRWId == "[null]") objvPaperSubAttachmentEN.PaperRWId = null; //课文阅读
if (objvPaperSubAttachmentEN.PaperSubAttachmentName == "[null]") objvPaperSubAttachmentEN.PaperSubAttachmentName = null; //附件名称
if (objvPaperSubAttachmentEN.RWTitle == "[null]") objvPaperSubAttachmentEN.RWTitle = null; //读写标题
if (objvPaperSubAttachmentEN.SubViewpointContent == "[null]") objvPaperSubAttachmentEN.SubViewpointContent = null; //详情内容
if (objvPaperSubAttachmentEN.UpdDate == "[null]") objvPaperSubAttachmentEN.UpdDate = null; //修改日期
if (objvPaperSubAttachmentEN.UpdUserId == "[null]") objvPaperSubAttachmentEN.UpdUserId = null; //修改用户Id
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
public static void CheckPropertyNew(clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
 vPaperSubAttachmentDA.CheckPropertyNew(objvPaperSubAttachmentEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
 vPaperSubAttachmentDA.CheckProperty4Condition(objvPaperSubAttachmentEN);
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
if (clsvPaperSubAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsvPaperSubAttachmentBL没有刷新缓存机制(clsvPaperSubAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubAttachmentId");
//if (arrvPaperSubAttachmentObjLstCache == null)
//{
//arrvPaperSubAttachmentObjLstCache = vPaperSubAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperSubAttachmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubAttachmentEN GetObjByPaperSubAttachmentIdCache(long lngPaperSubAttachmentId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperSubAttachmentEN._CurrTabName);
List<clsvPaperSubAttachmentEN> arrvPaperSubAttachmentObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubAttachmentEN> arrvPaperSubAttachmentObjLst_Sel =
arrvPaperSubAttachmentObjLstCache
.Where(x=> x.PaperSubAttachmentId == lngPaperSubAttachmentId 
);
if (arrvPaperSubAttachmentObjLst_Sel.Count() == 0)
{
   clsvPaperSubAttachmentEN obj = clsvPaperSubAttachmentBL.GetObjByPaperSubAttachmentId(lngPaperSubAttachmentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperSubAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSubAttachmentEN> GetAllvPaperSubAttachmentObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperSubAttachmentEN> arrvPaperSubAttachmentObjLstCache = GetObjLstCache(); 
return arrvPaperSubAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSubAttachmentEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperSubAttachmentEN._CurrTabName);
List<clsvPaperSubAttachmentEN> arrvPaperSubAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperSubAttachmentObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperSubAttachmentEN._CurrTabName);
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
if (clsvPaperSubAttachmentBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsvPaperSubAttachmentEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvPaperSubAttachmentBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vPaperSubAttachment(子观点附件)
 /// 唯一性条件:PaperSubAttachmentId_SubViewpointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvPaperSubAttachmentEN objvPaperSubAttachmentEN)
{
//检测记录是否存在
string strResult = vPaperSubAttachmentDA.GetUniCondStr(objvPaperSubAttachmentEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngPaperSubAttachmentId)
{
if (strInFldName != convPaperSubAttachment.PaperSubAttachmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperSubAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperSubAttachment.AttributeName));
throw new Exception(strMsg);
}
var objvPaperSubAttachment = clsvPaperSubAttachmentBL.GetObjByPaperSubAttachmentIdCache(lngPaperSubAttachmentId);
if (objvPaperSubAttachment == null) return "";
return objvPaperSubAttachment[strOutFldName].ToString();
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
int intRecCount = clsvPaperSubAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperSubAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperSubAttachmentDA.GetRecCount();
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
int intRecCount = clsvPaperSubAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperSubAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperSubAttachmentEN objvPaperSubAttachmentCond)
{
List<clsvPaperSubAttachmentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSubAttachment.AttributeName)
{
if (objvPaperSubAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSubAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubAttachmentCond[strFldName].ToString());
}
else
{
if (objvPaperSubAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSubAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSubAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSubAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSubAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSubAttachmentCond[strFldName]));
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
 List<string> arrList = clsvPaperSubAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperSubAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperSubAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = vPaperSubAttachmentDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsvPaperSubAttachmentDA.SetFldValue(clsvPaperSubAttachmentEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = vPaperSubAttachmentDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsvPaperSubAttachmentDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsvPaperSubAttachmentDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsvPaperSubAttachmentDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[vPaperSubAttachment] "); 
 strCreateTabCode.Append(" ( "); 
 // /**说明内容*/ 
 strCreateTabCode.Append(" ExplainContent varchar(5000) Null, "); 
 // /**子观点Id*/ 
 strCreateTabCode.Append(" SubViewpointId char(8) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课文阅读*/ 
 strCreateTabCode.Append(" PaperRWId char(8) Null, "); 
 // /**附件名称*/ 
 strCreateTabCode.Append(" PaperSubAttachmentName varchar(200) Null, "); 
 // /**读写标题*/ 
 strCreateTabCode.Append(" RWTitle varchar(50) Null, "); 
 // /**详情内容*/ 
 strCreateTabCode.Append(" SubViewpointContent text Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**子观点附件Id*/ 
 strCreateTabCode.Append(" PaperSubAttachmentId bigint primary key identity ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 子观点附件(vPaperSubAttachment)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4vPaperSubAttachment : clsCommFun4BL
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
clsvPaperSubAttachmentBL.ReFreshThisCache();
}
}

}