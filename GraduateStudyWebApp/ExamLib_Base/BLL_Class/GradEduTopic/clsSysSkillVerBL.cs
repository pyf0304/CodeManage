
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSkillVerBL
 表名:SysSkillVer(01120647)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:23
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
public static class  clsSysSkillVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngSkillVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSkillVerEN GetObj(this K_SkillVId_SysSkillVer myKey)
{
clsSysSkillVerEN objSysSkillVerEN = clsSysSkillVerBL.SysSkillVerDA.GetObjBySkillVId(myKey.Value);
return objSysSkillVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysSkillVerEN objSysSkillVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSkillVerEN) == false)
{
var strMsg = string.Format("记录已经存在!SkillVId = [{0}]的数据已经存在!(in clsSysSkillVerBL.AddNewRecord)", objSysSkillVerEN.SkillVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsSysSkillVerBL.SysSkillVerDA.AddNewRecordBySQL2(objSysSkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysSkillVerEN objSysSkillVerEN, bool bolIsNeedCheckUniqueness = true)
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
objSysSkillVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysSkillVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(SkillVId(SkillVId)=[{0}])已经存在,不能重复!", objSysSkillVerEN.SkillVId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objSysSkillVerEN.AddNewRecord();
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
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysSkillVerEN objSysSkillVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSkillVerEN) == false)
{
var strMsg = string.Format("记录已经存在!SkillVId = [{0}]的数据已经存在!(in clsSysSkillVerBL.AddNewRecordWithReturnKey)", objSysSkillVerEN.SkillVId);
throw new Exception(strMsg);
}
try
{
string strKey = clsSysSkillVerBL.SysSkillVerDA.AddNewRecordBySQL2WithReturnKey(objSysSkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetSkillVId(this clsSysSkillVerEN objSysSkillVerEN, long lngSkillVId, string strComparisonOp="")
	{
objSysSkillVerEN.SkillVId = lngSkillVId; //SkillVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.SkillVId) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.SkillVId, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.SkillVId] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetSkillId(this clsSysSkillVerEN objSysSkillVerEN, string strSkillId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillId, conSysSkillVer.SkillId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillId, 10, conSysSkillVer.SkillId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillId, 10, conSysSkillVer.SkillId);
}
objSysSkillVerEN.SkillId = strSkillId; //技能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.SkillId) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.SkillId, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.SkillId] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetSkillName(this clsSysSkillVerEN objSysSkillVerEN, string strSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillName, 200, conSysSkillVer.SkillName);
}
objSysSkillVerEN.SkillName = strSkillName; //技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.SkillName) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.SkillName, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.SkillName] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetOperationTypeId(this clsSysSkillVerEN objSysSkillVerEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, conSysSkillVer.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, conSysSkillVer.OperationTypeId);
}
objSysSkillVerEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.OperationTypeId) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.OperationTypeId, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.OperationTypeId] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetProcess(this clsSysSkillVerEN objSysSkillVerEN, string strProcess, string strComparisonOp="")
	{
objSysSkillVerEN.Process = strProcess; //实施过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.Process) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.Process, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.Process] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetLevelId(this clsSysSkillVerEN objSysSkillVerEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, conSysSkillVer.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, conSysSkillVer.LevelId);
}
objSysSkillVerEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.LevelId) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.LevelId, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.LevelId] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetUpdUser(this clsSysSkillVerEN objSysSkillVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSysSkillVer.UpdUser);
}
objSysSkillVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.UpdUser) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.UpdUser, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.UpdUser] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetUpdDate(this clsSysSkillVerEN objSysSkillVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSysSkillVer.UpdDate);
}
objSysSkillVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.UpdDate) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.UpdDate, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.UpdDate] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetCitationId(this clsSysSkillVerEN objSysSkillVerEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, conSysSkillVer.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, conSysSkillVer.CitationId);
}
objSysSkillVerEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.CitationId) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.CitationId, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.CitationId] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetIdCurrEduCls(this clsSysSkillVerEN objSysSkillVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conSysSkillVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conSysSkillVer.IdCurrEduCls);
}
objSysSkillVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.IdCurrEduCls) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.IdCurrEduCls, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.IdCurrEduCls] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetPdfContent(this clsSysSkillVerEN objSysSkillVerEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conSysSkillVer.PdfContent);
}
objSysSkillVerEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.PdfContent) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.PdfContent, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.PdfContent] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetPdfPageNum(this clsSysSkillVerEN objSysSkillVerEN, int? intPdfPageNum, string strComparisonOp="")
	{
objSysSkillVerEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.PdfPageNum) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.PdfPageNum, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.PdfPageNum] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillVerEN SetMemo(this clsSysSkillVerEN objSysSkillVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysSkillVer.Memo);
}
objSysSkillVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillVerEN.dicFldComparisonOp.ContainsKey(conSysSkillVer.Memo) == false)
{
objSysSkillVerEN.dicFldComparisonOp.Add(conSysSkillVer.Memo, strComparisonOp);
}
else
{
objSysSkillVerEN.dicFldComparisonOp[conSysSkillVer.Memo] = strComparisonOp;
}
}
return objSysSkillVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysSkillVerEN objSysSkillVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysSkillVerEN.CheckPropertyNew();
clsSysSkillVerEN objSysSkillVerCond = new clsSysSkillVerEN();
string strCondition = objSysSkillVerCond
.SetSkillVId(objSysSkillVerEN.SkillVId, "<>")
.SetSkillVId(objSysSkillVerEN.SkillVId, "=")
.GetCombineCondition();
objSysSkillVerEN._IsCheckProperty = true;
bool bolIsExist = clsSysSkillVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SkillVId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysSkillVerEN.Update();
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
 /// <param name = "objSysSkillVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysSkillVerEN objSysSkillVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysSkillVerEN objSysSkillVerCond = new clsSysSkillVerEN();
string strCondition = objSysSkillVerCond
.SetSkillVId(objSysSkillVer.SkillVId, "=")
.GetCombineCondition();
objSysSkillVer._IsCheckProperty = true;
bool bolIsExist = clsSysSkillVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysSkillVer.SkillVId = clsSysSkillVerBL.GetFirstID_S(strCondition);
objSysSkillVer.UpdateWithCondition(strCondition);
}
else
{
objSysSkillVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSkillVerEN objSysSkillVerEN)
{
 if (objSysSkillVerEN.SkillVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSkillVerBL.SysSkillVerDA.UpdateBySql2(objSysSkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSkillVerEN objSysSkillVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSkillVerEN.SkillVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSkillVerBL.SysSkillVerDA.UpdateBySql2(objSysSkillVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objSysSkillVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSkillVerEN objSysSkillVerEN, string strWhereCond)
{
try
{
bool bolResult = clsSysSkillVerBL.SysSkillVerDA.UpdateBySqlWithCondition(objSysSkillVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objSysSkillVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSkillVerEN objSysSkillVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysSkillVerBL.SysSkillVerDA.UpdateBySqlWithConditionTransaction(objSysSkillVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "lngSkillVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysSkillVerEN objSysSkillVerEN)
{
try
{
int intRecNum = clsSysSkillVerBL.SysSkillVerDA.DelRecord(objSysSkillVerEN.SkillVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objSysSkillVerENS">源对象</param>
 /// <param name = "objSysSkillVerENT">目标对象</param>
 public static void CopyTo(this clsSysSkillVerEN objSysSkillVerENS, clsSysSkillVerEN objSysSkillVerENT)
{
try
{
objSysSkillVerENT.SkillVId = objSysSkillVerENS.SkillVId; //SkillVId
objSysSkillVerENT.SkillId = objSysSkillVerENS.SkillId; //技能Id
objSysSkillVerENT.SkillName = objSysSkillVerENS.SkillName; //技能名称
objSysSkillVerENT.OperationTypeId = objSysSkillVerENS.OperationTypeId; //操作类型ID
objSysSkillVerENT.Process = objSysSkillVerENS.Process; //实施过程
objSysSkillVerENT.LevelId = objSysSkillVerENS.LevelId; //级别Id
objSysSkillVerENT.UpdUser = objSysSkillVerENS.UpdUser; //修改人
objSysSkillVerENT.UpdDate = objSysSkillVerENS.UpdDate; //修改日期
objSysSkillVerENT.CitationId = objSysSkillVerENS.CitationId; //引用Id
objSysSkillVerENT.IdCurrEduCls = objSysSkillVerENS.IdCurrEduCls; //教学班流水号
objSysSkillVerENT.PdfContent = objSysSkillVerENS.PdfContent; //Pdf内容
objSysSkillVerENT.PdfPageNum = objSysSkillVerENS.PdfPageNum; //Pdf页码
objSysSkillVerENT.Memo = objSysSkillVerENS.Memo; //备注
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
 /// <param name = "objSysSkillVerENS">源对象</param>
 /// <returns>目标对象=>clsSysSkillVerEN:objSysSkillVerENT</returns>
 public static clsSysSkillVerEN CopyTo(this clsSysSkillVerEN objSysSkillVerENS)
{
try
{
 clsSysSkillVerEN objSysSkillVerENT = new clsSysSkillVerEN()
{
SkillVId = objSysSkillVerENS.SkillVId, //SkillVId
SkillId = objSysSkillVerENS.SkillId, //技能Id
SkillName = objSysSkillVerENS.SkillName, //技能名称
OperationTypeId = objSysSkillVerENS.OperationTypeId, //操作类型ID
Process = objSysSkillVerENS.Process, //实施过程
LevelId = objSysSkillVerENS.LevelId, //级别Id
UpdUser = objSysSkillVerENS.UpdUser, //修改人
UpdDate = objSysSkillVerENS.UpdDate, //修改日期
CitationId = objSysSkillVerENS.CitationId, //引用Id
IdCurrEduCls = objSysSkillVerENS.IdCurrEduCls, //教学班流水号
PdfContent = objSysSkillVerENS.PdfContent, //Pdf内容
PdfPageNum = objSysSkillVerENS.PdfPageNum, //Pdf页码
Memo = objSysSkillVerENS.Memo, //备注
};
 return objSysSkillVerENT;
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
public static void CheckPropertyNew(this clsSysSkillVerEN objSysSkillVerEN)
{
 clsSysSkillVerBL.SysSkillVerDA.CheckPropertyNew(objSysSkillVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysSkillVerEN objSysSkillVerEN)
{
 clsSysSkillVerBL.SysSkillVerDA.CheckProperty4Condition(objSysSkillVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysSkillVerEN objSysSkillVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.SkillVId) == true)
{
string strComparisonOpSkillVId = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.SkillVId];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkillVer.SkillVId, objSysSkillVerCond.SkillVId, strComparisonOpSkillVId);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.SkillId) == true)
{
string strComparisonOpSkillId = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.SkillId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.SkillId, objSysSkillVerCond.SkillId, strComparisonOpSkillId);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.SkillName) == true)
{
string strComparisonOpSkillName = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.SkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.SkillName, objSysSkillVerCond.SkillName, strComparisonOpSkillName);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.OperationTypeId, objSysSkillVerCond.OperationTypeId, strComparisonOpOperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.LevelId) == true)
{
string strComparisonOpLevelId = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.LevelId, objSysSkillVerCond.LevelId, strComparisonOpLevelId);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.UpdUser, objSysSkillVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.UpdDate, objSysSkillVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.CitationId) == true)
{
string strComparisonOpCitationId = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.CitationId, objSysSkillVerCond.CitationId, strComparisonOpCitationId);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.IdCurrEduCls, objSysSkillVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.PdfContent) == true)
{
string strComparisonOpPdfContent = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.PdfContent, objSysSkillVerCond.PdfContent, strComparisonOpPdfContent);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkillVer.PdfPageNum, objSysSkillVerCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objSysSkillVerCond.IsUpdated(conSysSkillVer.Memo) == true)
{
string strComparisonOpMemo = objSysSkillVerCond.dicFldComparisonOp[conSysSkillVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkillVer.Memo, objSysSkillVerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysSkillVer(系统技能版本), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SkillVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysSkillVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysSkillVerEN objSysSkillVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysSkillVerEN == null) return true;
if (objSysSkillVerEN.SkillVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SkillVId = '{0}'", objSysSkillVerEN.SkillVId);
if (clsSysSkillVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SkillVId !=  {0}", objSysSkillVerEN.SkillVId);
 sbCondition.AppendFormat(" and SkillVId = '{0}'", objSysSkillVerEN.SkillVId);
if (clsSysSkillVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysSkillVer(系统技能版本), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SkillVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysSkillVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysSkillVerEN objSysSkillVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysSkillVerEN == null) return "";
if (objSysSkillVerEN.SkillVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SkillVId = '{0}'", objSysSkillVerEN.SkillVId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SkillVId !=  {0}", objSysSkillVerEN.SkillVId);
 sbCondition.AppendFormat(" and SkillVId = '{0}'", objSysSkillVerEN.SkillVId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysSkillVer
{
public virtual bool UpdRelaTabDate(long lngSkillVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 系统技能版本(SysSkillVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysSkillVerBL
{
public static RelatedActions_SysSkillVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysSkillVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysSkillVerDA SysSkillVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysSkillVerDA();
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
 public clsSysSkillVerBL()
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
if (string.IsNullOrEmpty(clsSysSkillVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysSkillVerEN._ConnectString);
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
public static DataTable GetDataTable_SysSkillVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysSkillVerDA.GetDataTable_SysSkillVer(strWhereCond);
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
objDT = SysSkillVerDA.GetDataTable(strWhereCond);
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
objDT = SysSkillVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysSkillVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysSkillVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysSkillVerDA.GetDataTable_Top(objTopPara);
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
objDT = SysSkillVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysSkillVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysSkillVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSkillVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysSkillVerEN> GetObjLstBySkillVIdLst(List<long> arrSkillVIdLst)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSkillVIdLst);
 string strWhereCond = string.Format("SkillVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSkillVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysSkillVerEN> GetObjLstBySkillVIdLstCache(List<long> arrSkillVIdLst)
{
string strKey = string.Format("{0}", clsSysSkillVerEN._CurrTabName);
List<clsSysSkillVerEN> arrSysSkillVerObjLstCache = GetObjLstCache();
IEnumerable <clsSysSkillVerEN> arrSysSkillVerObjLst_Sel =
arrSysSkillVerObjLstCache
.Where(x => arrSkillVIdLst.Contains(x.SkillVId));
return arrSysSkillVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSkillVerEN> GetObjLst(string strWhereCond)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
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
public static List<clsSysSkillVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysSkillVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysSkillVerEN> GetSubObjLstCache(clsSysSkillVerEN objSysSkillVerCond)
{
List<clsSysSkillVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysSkillVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSkillVer.AttributeName)
{
if (objSysSkillVerCond.IsUpdated(strFldName) == false) continue;
if (objSysSkillVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSkillVerCond[strFldName].ToString());
}
else
{
if (objSysSkillVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSkillVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSkillVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSkillVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSkillVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSkillVerCond[strFldName]));
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
public static List<clsSysSkillVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
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
public static List<clsSysSkillVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
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
List<clsSysSkillVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysSkillVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSkillVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysSkillVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
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
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
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
public static List<clsSysSkillVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysSkillVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysSkillVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
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
public static List<clsSysSkillVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSkillVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysSkillVerEN> arrObjLst = new List<clsSysSkillVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillVerEN objSysSkillVerEN = new clsSysSkillVerEN();
try
{
objSysSkillVerEN.SkillVId = Int32.Parse(objRow[conSysSkillVer.SkillVId].ToString().Trim()); //SkillVId
objSysSkillVerEN.SkillId = objRow[conSysSkillVer.SkillId].ToString().Trim(); //技能Id
objSysSkillVerEN.SkillName = objRow[conSysSkillVer.SkillName] == DBNull.Value ? null : objRow[conSysSkillVer.SkillName].ToString().Trim(); //技能名称
objSysSkillVerEN.OperationTypeId = objRow[conSysSkillVer.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkillVer.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillVerEN.Process = objRow[conSysSkillVer.Process] == DBNull.Value ? null : objRow[conSysSkillVer.Process].ToString().Trim(); //实施过程
objSysSkillVerEN.LevelId = objRow[conSysSkillVer.LevelId] == DBNull.Value ? null : objRow[conSysSkillVer.LevelId].ToString().Trim(); //级别Id
objSysSkillVerEN.UpdUser = objRow[conSysSkillVer.UpdUser] == DBNull.Value ? null : objRow[conSysSkillVer.UpdUser].ToString().Trim(); //修改人
objSysSkillVerEN.UpdDate = objRow[conSysSkillVer.UpdDate] == DBNull.Value ? null : objRow[conSysSkillVer.UpdDate].ToString().Trim(); //修改日期
objSysSkillVerEN.CitationId = objRow[conSysSkillVer.CitationId] == DBNull.Value ? null : objRow[conSysSkillVer.CitationId].ToString().Trim(); //引用Id
objSysSkillVerEN.IdCurrEduCls = objRow[conSysSkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillVerEN.PdfContent = objRow[conSysSkillVer.PdfContent] == DBNull.Value ? null : objRow[conSysSkillVer.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillVerEN.PdfPageNum = objRow[conSysSkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillVerEN.Memo = objRow[conSysSkillVer.Memo] == DBNull.Value ? null : objRow[conSysSkillVer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysSkillVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysSkillVer(ref clsSysSkillVerEN objSysSkillVerEN)
{
bool bolResult = SysSkillVerDA.GetSysSkillVer(ref objSysSkillVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngSkillVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSkillVerEN GetObjBySkillVId(long lngSkillVId)
{
clsSysSkillVerEN objSysSkillVerEN = SysSkillVerDA.GetObjBySkillVId(lngSkillVId);
return objSysSkillVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysSkillVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysSkillVerEN objSysSkillVerEN = SysSkillVerDA.GetFirstObj(strWhereCond);
 return objSysSkillVerEN;
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
public static clsSysSkillVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysSkillVerEN objSysSkillVerEN = SysSkillVerDA.GetObjByDataRow(objRow);
 return objSysSkillVerEN;
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
public static clsSysSkillVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysSkillVerEN objSysSkillVerEN = SysSkillVerDA.GetObjByDataRow(objRow);
 return objSysSkillVerEN;
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
 /// <param name = "lngSkillVId">所给的关键字</param>
 /// <param name = "lstSysSkillVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSkillVerEN GetObjBySkillVIdFromList(long lngSkillVId, List<clsSysSkillVerEN> lstSysSkillVerObjLst)
{
foreach (clsSysSkillVerEN objSysSkillVerEN in lstSysSkillVerObjLst)
{
if (objSysSkillVerEN.SkillVId == lngSkillVId)
{
return objSysSkillVerEN;
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
 long lngSkillVId;
 try
 {
 lngSkillVId = new clsSysSkillVerDA().GetFirstID(strWhereCond);
 return lngSkillVId;
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
 arrList = SysSkillVerDA.GetID(strWhereCond);
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
bool bolIsExist = SysSkillVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngSkillVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngSkillVId)
{
//检测记录是否存在
bool bolIsExist = SysSkillVerDA.IsExist(lngSkillVId);
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
 bolIsExist = clsSysSkillVerDA.IsExistTable();
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
 bolIsExist = SysSkillVerDA.IsExistTable(strTabName);
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
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysSkillVerEN objSysSkillVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSkillVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!SkillVId = [{0}]的数据已经存在!(in clsSysSkillVerBL.AddNewRecordBySql2)", objSysSkillVerEN.SkillVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = SysSkillVerDA.AddNewRecordBySQL2(objSysSkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysSkillVerEN objSysSkillVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSkillVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!SkillVId = [{0}]的数据已经存在!(in clsSysSkillVerBL.AddNewRecordBySql2WithReturnKey)", objSysSkillVerEN.SkillVId);
throw new Exception(strMsg);
}
try
{
string strKey = SysSkillVerDA.AddNewRecordBySQL2WithReturnKey(objSysSkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysSkillVerEN objSysSkillVerEN)
{
try
{
bool bolResult = SysSkillVerDA.Update(objSysSkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objSysSkillVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysSkillVerEN objSysSkillVerEN)
{
 if (objSysSkillVerEN.SkillVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysSkillVerDA.UpdateBySql2(objSysSkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillVerBL.ReFreshCache();

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "lngSkillVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngSkillVId)
{
try
{
 clsSysSkillVerEN objSysSkillVerEN = clsSysSkillVerBL.GetObjBySkillVId(lngSkillVId);

if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(objSysSkillVerEN.SkillVId, "SetUpdDate");
}
if (objSysSkillVerEN != null)
{
int intRecNum = SysSkillVerDA.DelRecord(lngSkillVId);
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
/// <param name="lngSkillVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngSkillVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
//删除与表:[SysSkillVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysSkillVer.SkillVId,
//lngSkillVId);
//        clsSysSkillVerBL.DelSysSkillVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSkillVerBL.DelRecord(lngSkillVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSkillVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngSkillVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngSkillVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngSkillVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysSkillVerBL.relatedActions != null)
{
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(lngSkillVId, "UpdRelaTabDate");
}
bool bolResult = SysSkillVerDA.DelRecord(lngSkillVId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSkillVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysSkillVers(List<string> arrSkillVIdLst)
{
if (arrSkillVIdLst.Count == 0) return 0;
try
{
if (clsSysSkillVerBL.relatedActions != null)
{
foreach (var strSkillVId in arrSkillVIdLst)
{
long lngSkillVId = long.Parse(strSkillVId);
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(lngSkillVId, "UpdRelaTabDate");
}
}
int intDelRecNum = SysSkillVerDA.DelSysSkillVer(arrSkillVIdLst);
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
public static int DelSysSkillVersByCond(string strWhereCond)
{
try
{
if (clsSysSkillVerBL.relatedActions != null)
{
List<string> arrSkillVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSkillVId in arrSkillVId)
{
long lngSkillVId = long.Parse(strSkillVId);
clsSysSkillVerBL.relatedActions.UpdRelaTabDate(lngSkillVId, "UpdRelaTabDate");
}
}
int intRecNum = SysSkillVerDA.DelSysSkillVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysSkillVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngSkillVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngSkillVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSkillVerDA.GetSpecSQLObj();
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
//删除与表:[SysSkillVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSkillVerBL.DelRecord(lngSkillVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSkillVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngSkillVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysSkillVerENS">源对象</param>
 /// <param name = "objSysSkillVerENT">目标对象</param>
 public static void CopyTo(clsSysSkillVerEN objSysSkillVerENS, clsSysSkillVerEN objSysSkillVerENT)
{
try
{
objSysSkillVerENT.SkillVId = objSysSkillVerENS.SkillVId; //SkillVId
objSysSkillVerENT.SkillId = objSysSkillVerENS.SkillId; //技能Id
objSysSkillVerENT.SkillName = objSysSkillVerENS.SkillName; //技能名称
objSysSkillVerENT.OperationTypeId = objSysSkillVerENS.OperationTypeId; //操作类型ID
objSysSkillVerENT.Process = objSysSkillVerENS.Process; //实施过程
objSysSkillVerENT.LevelId = objSysSkillVerENS.LevelId; //级别Id
objSysSkillVerENT.UpdUser = objSysSkillVerENS.UpdUser; //修改人
objSysSkillVerENT.UpdDate = objSysSkillVerENS.UpdDate; //修改日期
objSysSkillVerENT.CitationId = objSysSkillVerENS.CitationId; //引用Id
objSysSkillVerENT.IdCurrEduCls = objSysSkillVerENS.IdCurrEduCls; //教学班流水号
objSysSkillVerENT.PdfContent = objSysSkillVerENS.PdfContent; //Pdf内容
objSysSkillVerENT.PdfPageNum = objSysSkillVerENS.PdfPageNum; //Pdf页码
objSysSkillVerENT.Memo = objSysSkillVerENS.Memo; //备注
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
 /// <param name = "objSysSkillVerEN">源简化对象</param>
 public static void SetUpdFlag(clsSysSkillVerEN objSysSkillVerEN)
{
try
{
objSysSkillVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysSkillVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysSkillVer.SkillVId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.SkillVId = objSysSkillVerEN.SkillVId; //SkillVId
}
if (arrFldSet.Contains(conSysSkillVer.SkillId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.SkillId = objSysSkillVerEN.SkillId; //技能Id
}
if (arrFldSet.Contains(conSysSkillVer.SkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.SkillName = objSysSkillVerEN.SkillName == "[null]" ? null :  objSysSkillVerEN.SkillName; //技能名称
}
if (arrFldSet.Contains(conSysSkillVer.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.OperationTypeId = objSysSkillVerEN.OperationTypeId == "[null]" ? null :  objSysSkillVerEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(conSysSkillVer.Process, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.Process = objSysSkillVerEN.Process == "[null]" ? null :  objSysSkillVerEN.Process; //实施过程
}
if (arrFldSet.Contains(conSysSkillVer.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.LevelId = objSysSkillVerEN.LevelId == "[null]" ? null :  objSysSkillVerEN.LevelId; //级别Id
}
if (arrFldSet.Contains(conSysSkillVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.UpdUser = objSysSkillVerEN.UpdUser == "[null]" ? null :  objSysSkillVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conSysSkillVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.UpdDate = objSysSkillVerEN.UpdDate == "[null]" ? null :  objSysSkillVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSysSkillVer.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.CitationId = objSysSkillVerEN.CitationId == "[null]" ? null :  objSysSkillVerEN.CitationId; //引用Id
}
if (arrFldSet.Contains(conSysSkillVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.IdCurrEduCls = objSysSkillVerEN.IdCurrEduCls == "[null]" ? null :  objSysSkillVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conSysSkillVer.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.PdfContent = objSysSkillVerEN.PdfContent == "[null]" ? null :  objSysSkillVerEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conSysSkillVer.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.PdfPageNum = objSysSkillVerEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conSysSkillVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillVerEN.Memo = objSysSkillVerEN.Memo == "[null]" ? null :  objSysSkillVerEN.Memo; //备注
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
 /// <param name = "objSysSkillVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysSkillVerEN objSysSkillVerEN)
{
try
{
if (objSysSkillVerEN.SkillName == "[null]") objSysSkillVerEN.SkillName = null; //技能名称
if (objSysSkillVerEN.OperationTypeId == "[null]") objSysSkillVerEN.OperationTypeId = null; //操作类型ID
if (objSysSkillVerEN.Process == "[null]") objSysSkillVerEN.Process = null; //实施过程
if (objSysSkillVerEN.LevelId == "[null]") objSysSkillVerEN.LevelId = null; //级别Id
if (objSysSkillVerEN.UpdUser == "[null]") objSysSkillVerEN.UpdUser = null; //修改人
if (objSysSkillVerEN.UpdDate == "[null]") objSysSkillVerEN.UpdDate = null; //修改日期
if (objSysSkillVerEN.CitationId == "[null]") objSysSkillVerEN.CitationId = null; //引用Id
if (objSysSkillVerEN.IdCurrEduCls == "[null]") objSysSkillVerEN.IdCurrEduCls = null; //教学班流水号
if (objSysSkillVerEN.PdfContent == "[null]") objSysSkillVerEN.PdfContent = null; //Pdf内容
if (objSysSkillVerEN.Memo == "[null]") objSysSkillVerEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsSysSkillVerEN objSysSkillVerEN)
{
 SysSkillVerDA.CheckPropertyNew(objSysSkillVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysSkillVerEN objSysSkillVerEN)
{
 SysSkillVerDA.CheckProperty4Condition(objSysSkillVerEN);
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
if (clsSysSkillVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSkillVerBL没有刷新缓存机制(clsSysSkillVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SkillVId");
//if (arrSysSkillVerObjLstCache == null)
//{
//arrSysSkillVerObjLstCache = SysSkillVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngSkillVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSkillVerEN GetObjBySkillVIdCache(long lngSkillVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSysSkillVerEN._CurrTabName);
List<clsSysSkillVerEN> arrSysSkillVerObjLstCache = GetObjLstCache();
IEnumerable <clsSysSkillVerEN> arrSysSkillVerObjLst_Sel =
arrSysSkillVerObjLstCache
.Where(x=> x.SkillVId == lngSkillVId 
);
if (arrSysSkillVerObjLst_Sel.Count() == 0)
{
   clsSysSkillVerEN obj = clsSysSkillVerBL.GetObjBySkillVId(lngSkillVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSysSkillVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSkillVerEN> GetAllSysSkillVerObjLstCache()
{
//获取缓存中的对象列表
List<clsSysSkillVerEN> arrSysSkillVerObjLstCache = GetObjLstCache(); 
return arrSysSkillVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSkillVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSysSkillVerEN._CurrTabName);
List<clsSysSkillVerEN> arrSysSkillVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSysSkillVerObjLstCache;
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
string strKey = string.Format("{0}", clsSysSkillVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysSkillVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysSkillVerEN._RefreshTimeLst.Count == 0) return "";
return clsSysSkillVerEN._RefreshTimeLst[clsSysSkillVerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSysSkillVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysSkillVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysSkillVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysSkillVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysSkillVer(系统技能版本)
 /// 唯一性条件:SkillVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysSkillVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysSkillVerEN objSysSkillVerEN)
{
//检测记录是否存在
string strResult = SysSkillVerDA.GetUniCondStr(objSysSkillVerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngSkillVId)
{
if (strInFldName != conSysSkillVer.SkillVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysSkillVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysSkillVer.AttributeName));
throw new Exception(strMsg);
}
var objSysSkillVer = clsSysSkillVerBL.GetObjBySkillVIdCache(lngSkillVId);
if (objSysSkillVer == null) return "";
return objSysSkillVer[strOutFldName].ToString();
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
int intRecCount = clsSysSkillVerDA.GetRecCount(strTabName);
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
int intRecCount = clsSysSkillVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysSkillVerDA.GetRecCount();
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
int intRecCount = clsSysSkillVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysSkillVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysSkillVerEN objSysSkillVerCond)
{
List<clsSysSkillVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysSkillVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSkillVer.AttributeName)
{
if (objSysSkillVerCond.IsUpdated(strFldName) == false) continue;
if (objSysSkillVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSkillVerCond[strFldName].ToString());
}
else
{
if (objSysSkillVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSkillVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSkillVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSkillVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSkillVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSkillVerCond[strFldName]));
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
 List<string> arrList = clsSysSkillVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysSkillVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysSkillVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysSkillVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysSkillVerDA.SetFldValue(clsSysSkillVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysSkillVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysSkillVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysSkillVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysSkillVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysSkillVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**SkillVId*/ 
 strCreateTabCode.Append(" SkillVId bigint primary key identity, "); 
 // /**技能Id*/ 
 strCreateTabCode.Append(" SkillId char(10) not Null, "); 
 // /**技能名称*/ 
 strCreateTabCode.Append(" SkillName varchar(200) Null, "); 
 // /**操作类型ID*/ 
 strCreateTabCode.Append(" OperationTypeId char(4) Null, "); 
 // /**实施过程*/ 
 strCreateTabCode.Append(" Process text Null, "); 
 // /**级别Id*/ 
 strCreateTabCode.Append(" LevelId char(2) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**引用Id*/ 
 strCreateTabCode.Append(" CitationId char(8) Null, "); 
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
 /// 系统技能版本(SysSkillVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysSkillVer : clsCommFun4BL
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
clsSysSkillVerBL.ReFreshThisCache();
}
}

}