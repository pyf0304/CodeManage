
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSkillBL
 表名:SysSkill(01120646)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:54
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
public static class  clsSysSkillBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSkillId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSkillEN GetObj(this K_SkillId_SysSkill myKey)
{
clsSysSkillEN objSysSkillEN = clsSysSkillBL.SysSkillDA.GetObjBySkillId(myKey.Value);
return objSysSkillEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysSkillEN objSysSkillEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSkillEN) == false)
{
var strMsg = string.Format("记录已经存在!技能Id = [{0}]的数据已经存在!(in clsSysSkillBL.AddNewRecord)", objSysSkillEN.SkillId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSkillEN.SkillId) == true || clsSysSkillBL.IsExist(objSysSkillEN.SkillId) == true)
 {
     objSysSkillEN.SkillId = clsSysSkillBL.GetMaxStrId_S();
 }
bool bolResult = clsSysSkillBL.SysSkillDA.AddNewRecordBySQL2(objSysSkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysSkillEN objSysSkillEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSysSkillBL.IsExist(objSysSkillEN.SkillId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSysSkillEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysSkillEN.CheckUniqueness() == false)
{
strMsg = string.Format("(技能Id(SkillId)=[{0}])已经存在,不能重复!", objSysSkillEN.SkillId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSysSkillEN.SkillId) == true || clsSysSkillBL.IsExist(objSysSkillEN.SkillId) == true)
 {
     objSysSkillEN.SkillId = clsSysSkillBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSysSkillEN.AddNewRecord();
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSysSkillEN objSysSkillEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSkillEN) == false)
{
var strMsg = string.Format("记录已经存在!技能Id = [{0}]的数据已经存在!(in clsSysSkillBL.AddNewRecordWithMaxId)", objSysSkillEN.SkillId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSkillEN.SkillId) == true || clsSysSkillBL.IsExist(objSysSkillEN.SkillId) == true)
 {
     objSysSkillEN.SkillId = clsSysSkillBL.GetMaxStrId_S();
 }
string strSkillId = clsSysSkillBL.SysSkillDA.AddNewRecordBySQL2WithReturnKey(objSysSkillEN);
     objSysSkillEN.SkillId = strSkillId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
}
return strSkillId;
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysSkillEN objSysSkillEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSkillEN) == false)
{
var strMsg = string.Format("记录已经存在!技能Id = [{0}]的数据已经存在!(in clsSysSkillBL.AddNewRecordWithReturnKey)", objSysSkillEN.SkillId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSkillEN.SkillId) == true || clsSysSkillBL.IsExist(objSysSkillEN.SkillId) == true)
 {
     objSysSkillEN.SkillId = clsSysSkillBL.GetMaxStrId_S();
 }
string strKey = clsSysSkillBL.SysSkillDA.AddNewRecordBySQL2WithReturnKey(objSysSkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetSkillId(this clsSysSkillEN objSysSkillEN, string strSkillId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillId, 10, conSysSkill.SkillId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillId, 10, conSysSkill.SkillId);
}
objSysSkillEN.SkillId = strSkillId; //技能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.SkillId) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.SkillId, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.SkillId] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetSkillName(this clsSysSkillEN objSysSkillEN, string strSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillName, 200, conSysSkill.SkillName);
}
objSysSkillEN.SkillName = strSkillName; //技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.SkillName) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.SkillName, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.SkillName] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetOperationTypeId(this clsSysSkillEN objSysSkillEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, conSysSkill.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, conSysSkill.OperationTypeId);
}
objSysSkillEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.OperationTypeId) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.OperationTypeId, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.OperationTypeId] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetProcess(this clsSysSkillEN objSysSkillEN, string strProcess, string strComparisonOp="")
	{
objSysSkillEN.Process = strProcess; //实施过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.Process) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.Process, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.Process] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetLevelId(this clsSysSkillEN objSysSkillEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, conSysSkill.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, conSysSkill.LevelId);
}
objSysSkillEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.LevelId) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.LevelId, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.LevelId] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetUpdUser(this clsSysSkillEN objSysSkillEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSysSkill.UpdUser);
}
objSysSkillEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.UpdUser) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.UpdUser, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.UpdUser] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetUpdDate(this clsSysSkillEN objSysSkillEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSysSkill.UpdDate);
}
objSysSkillEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.UpdDate) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.UpdDate, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.UpdDate] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetIsSubmit(this clsSysSkillEN objSysSkillEN, bool bolIsSubmit, string strComparisonOp="")
	{
objSysSkillEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.IsSubmit) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.IsSubmit, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.IsSubmit] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetCitationId(this clsSysSkillEN objSysSkillEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, conSysSkill.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, conSysSkill.CitationId);
}
objSysSkillEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.CitationId) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.CitationId, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.CitationId] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetOkCount(this clsSysSkillEN objSysSkillEN, int? intOkCount, string strComparisonOp="")
	{
objSysSkillEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.OkCount) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.OkCount, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.OkCount] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetAppraiseCount(this clsSysSkillEN objSysSkillEN, int? intAppraiseCount, string strComparisonOp="")
	{
objSysSkillEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.AppraiseCount) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.AppraiseCount, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.AppraiseCount] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetScore(this clsSysSkillEN objSysSkillEN, float? fltScore, string strComparisonOp="")
	{
objSysSkillEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.Score) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.Score, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.Score] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetStuScore(this clsSysSkillEN objSysSkillEN, float? fltStuScore, string strComparisonOp="")
	{
objSysSkillEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.StuScore) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.StuScore, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.StuScore] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetTeaScore(this clsSysSkillEN objSysSkillEN, float? fltTeaScore, string strComparisonOp="")
	{
objSysSkillEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.TeaScore) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.TeaScore, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.TeaScore] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetIdCurrEduCls(this clsSysSkillEN objSysSkillEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conSysSkill.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conSysSkill.IdCurrEduCls);
}
objSysSkillEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.IdCurrEduCls) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.IdCurrEduCls, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.IdCurrEduCls] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetPdfContent(this clsSysSkillEN objSysSkillEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conSysSkill.PdfContent);
}
objSysSkillEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.PdfContent) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.PdfContent, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.PdfContent] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetPdfPageNum(this clsSysSkillEN objSysSkillEN, int? intPdfPageNum, string strComparisonOp="")
	{
objSysSkillEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.PdfPageNum) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.PdfPageNum, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.PdfPageNum] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetCitationCount(this clsSysSkillEN objSysSkillEN, int? intCitationCount, string strComparisonOp="")
	{
objSysSkillEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.CitationCount) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.CitationCount, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.CitationCount] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetVersionCount(this clsSysSkillEN objSysSkillEN, int? intVersionCount, string strComparisonOp="")
	{
objSysSkillEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.VersionCount) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.VersionCount, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.VersionCount] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetMemo(this clsSysSkillEN objSysSkillEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysSkill.Memo);
}
objSysSkillEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.Memo) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.Memo, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.Memo] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetCreateDate(this clsSysSkillEN objSysSkillEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conSysSkill.CreateDate);
}
objSysSkillEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.CreateDate) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.CreateDate, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.CreateDate] = strComparisonOp;
}
}
return objSysSkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSkillEN SetShareId(this clsSysSkillEN objSysSkillEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, conSysSkill.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, conSysSkill.ShareId);
}
objSysSkillEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSkillEN.dicFldComparisonOp.ContainsKey(conSysSkill.ShareId) == false)
{
objSysSkillEN.dicFldComparisonOp.Add(conSysSkill.ShareId, strComparisonOp);
}
else
{
objSysSkillEN.dicFldComparisonOp[conSysSkill.ShareId] = strComparisonOp;
}
}
return objSysSkillEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysSkillEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysSkillEN objSysSkillEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysSkillEN.CheckPropertyNew();
clsSysSkillEN objSysSkillCond = new clsSysSkillEN();
string strCondition = objSysSkillCond
.SetSkillId(objSysSkillEN.SkillId, "<>")
.SetSkillId(objSysSkillEN.SkillId, "=")
.GetCombineCondition();
objSysSkillEN._IsCheckProperty = true;
bool bolIsExist = clsSysSkillBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SkillId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysSkillEN.Update();
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
 /// <param name = "objSysSkill">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysSkillEN objSysSkill)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysSkillEN objSysSkillCond = new clsSysSkillEN();
string strCondition = objSysSkillCond
.SetSkillId(objSysSkill.SkillId, "=")
.GetCombineCondition();
objSysSkill._IsCheckProperty = true;
bool bolIsExist = clsSysSkillBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysSkill.SkillId = clsSysSkillBL.GetFirstID_S(strCondition);
objSysSkill.UpdateWithCondition(strCondition);
}
else
{
objSysSkill.SkillId = clsSysSkillBL.GetMaxStrId_S();
objSysSkill.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSkillEN objSysSkillEN)
{
 if (string.IsNullOrEmpty(objSysSkillEN.SkillId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSkillBL.SysSkillDA.UpdateBySql2(objSysSkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSkillEN objSysSkillEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSysSkillEN.SkillId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSkillBL.SysSkillDA.UpdateBySql2(objSysSkillEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "objSysSkillEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSkillEN objSysSkillEN, string strWhereCond)
{
try
{
bool bolResult = clsSysSkillBL.SysSkillDA.UpdateBySqlWithCondition(objSysSkillEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "objSysSkillEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSkillEN objSysSkillEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysSkillBL.SysSkillDA.UpdateBySqlWithConditionTransaction(objSysSkillEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "strSkillId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysSkillEN objSysSkillEN)
{
try
{
int intRecNum = clsSysSkillBL.SysSkillDA.DelRecord(objSysSkillEN.SkillId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "objSysSkillENS">源对象</param>
 /// <param name = "objSysSkillENT">目标对象</param>
 public static void CopyTo(this clsSysSkillEN objSysSkillENS, clsSysSkillEN objSysSkillENT)
{
try
{
objSysSkillENT.SkillId = objSysSkillENS.SkillId; //技能Id
objSysSkillENT.SkillName = objSysSkillENS.SkillName; //技能名称
objSysSkillENT.OperationTypeId = objSysSkillENS.OperationTypeId; //操作类型ID
objSysSkillENT.Process = objSysSkillENS.Process; //实施过程
objSysSkillENT.LevelId = objSysSkillENS.LevelId; //级别Id
objSysSkillENT.UpdUser = objSysSkillENS.UpdUser; //修改人
objSysSkillENT.UpdDate = objSysSkillENS.UpdDate; //修改日期
objSysSkillENT.IsSubmit = objSysSkillENS.IsSubmit; //是否提交
objSysSkillENT.CitationId = objSysSkillENS.CitationId; //引用Id
objSysSkillENT.OkCount = objSysSkillENS.OkCount; //点赞统计
objSysSkillENT.AppraiseCount = objSysSkillENS.AppraiseCount; //评论数
objSysSkillENT.Score = objSysSkillENS.Score; //评分
objSysSkillENT.StuScore = objSysSkillENS.StuScore; //学生平均分
objSysSkillENT.TeaScore = objSysSkillENS.TeaScore; //教师评分
objSysSkillENT.IdCurrEduCls = objSysSkillENS.IdCurrEduCls; //教学班流水号
objSysSkillENT.PdfContent = objSysSkillENS.PdfContent; //Pdf内容
objSysSkillENT.PdfPageNum = objSysSkillENS.PdfPageNum; //Pdf页码
objSysSkillENT.CitationCount = objSysSkillENS.CitationCount; //引用统计
objSysSkillENT.VersionCount = objSysSkillENS.VersionCount; //版本统计
objSysSkillENT.Memo = objSysSkillENS.Memo; //备注
objSysSkillENT.CreateDate = objSysSkillENS.CreateDate; //建立日期
objSysSkillENT.ShareId = objSysSkillENS.ShareId; //分享Id
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
 /// <param name = "objSysSkillENS">源对象</param>
 /// <returns>目标对象=>clsSysSkillEN:objSysSkillENT</returns>
 public static clsSysSkillEN CopyTo(this clsSysSkillEN objSysSkillENS)
{
try
{
 clsSysSkillEN objSysSkillENT = new clsSysSkillEN()
{
SkillId = objSysSkillENS.SkillId, //技能Id
SkillName = objSysSkillENS.SkillName, //技能名称
OperationTypeId = objSysSkillENS.OperationTypeId, //操作类型ID
Process = objSysSkillENS.Process, //实施过程
LevelId = objSysSkillENS.LevelId, //级别Id
UpdUser = objSysSkillENS.UpdUser, //修改人
UpdDate = objSysSkillENS.UpdDate, //修改日期
IsSubmit = objSysSkillENS.IsSubmit, //是否提交
CitationId = objSysSkillENS.CitationId, //引用Id
OkCount = objSysSkillENS.OkCount, //点赞统计
AppraiseCount = objSysSkillENS.AppraiseCount, //评论数
Score = objSysSkillENS.Score, //评分
StuScore = objSysSkillENS.StuScore, //学生平均分
TeaScore = objSysSkillENS.TeaScore, //教师评分
IdCurrEduCls = objSysSkillENS.IdCurrEduCls, //教学班流水号
PdfContent = objSysSkillENS.PdfContent, //Pdf内容
PdfPageNum = objSysSkillENS.PdfPageNum, //Pdf页码
CitationCount = objSysSkillENS.CitationCount, //引用统计
VersionCount = objSysSkillENS.VersionCount, //版本统计
Memo = objSysSkillENS.Memo, //备注
CreateDate = objSysSkillENS.CreateDate, //建立日期
ShareId = objSysSkillENS.ShareId, //分享Id
};
 return objSysSkillENT;
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
public static void CheckPropertyNew(this clsSysSkillEN objSysSkillEN)
{
 clsSysSkillBL.SysSkillDA.CheckPropertyNew(objSysSkillEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysSkillEN objSysSkillEN)
{
 clsSysSkillBL.SysSkillDA.CheckProperty4Condition(objSysSkillEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysSkillEN objSysSkillCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysSkillCond.IsUpdated(conSysSkill.SkillId) == true)
{
string strComparisonOpSkillId = objSysSkillCond.dicFldComparisonOp[conSysSkill.SkillId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.SkillId, objSysSkillCond.SkillId, strComparisonOpSkillId);
}
if (objSysSkillCond.IsUpdated(conSysSkill.SkillName) == true)
{
string strComparisonOpSkillName = objSysSkillCond.dicFldComparisonOp[conSysSkill.SkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.SkillName, objSysSkillCond.SkillName, strComparisonOpSkillName);
}
if (objSysSkillCond.IsUpdated(conSysSkill.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objSysSkillCond.dicFldComparisonOp[conSysSkill.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.OperationTypeId, objSysSkillCond.OperationTypeId, strComparisonOpOperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objSysSkillCond.IsUpdated(conSysSkill.LevelId) == true)
{
string strComparisonOpLevelId = objSysSkillCond.dicFldComparisonOp[conSysSkill.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.LevelId, objSysSkillCond.LevelId, strComparisonOpLevelId);
}
if (objSysSkillCond.IsUpdated(conSysSkill.UpdUser) == true)
{
string strComparisonOpUpdUser = objSysSkillCond.dicFldComparisonOp[conSysSkill.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.UpdUser, objSysSkillCond.UpdUser, strComparisonOpUpdUser);
}
if (objSysSkillCond.IsUpdated(conSysSkill.UpdDate) == true)
{
string strComparisonOpUpdDate = objSysSkillCond.dicFldComparisonOp[conSysSkill.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.UpdDate, objSysSkillCond.UpdDate, strComparisonOpUpdDate);
}
if (objSysSkillCond.IsUpdated(conSysSkill.IsSubmit) == true)
{
if (objSysSkillCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSysSkill.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSysSkill.IsSubmit);
}
}
if (objSysSkillCond.IsUpdated(conSysSkill.CitationId) == true)
{
string strComparisonOpCitationId = objSysSkillCond.dicFldComparisonOp[conSysSkill.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.CitationId, objSysSkillCond.CitationId, strComparisonOpCitationId);
}
if (objSysSkillCond.IsUpdated(conSysSkill.OkCount) == true)
{
string strComparisonOpOkCount = objSysSkillCond.dicFldComparisonOp[conSysSkill.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkill.OkCount, objSysSkillCond.OkCount, strComparisonOpOkCount);
}
if (objSysSkillCond.IsUpdated(conSysSkill.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objSysSkillCond.dicFldComparisonOp[conSysSkill.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkill.AppraiseCount, objSysSkillCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objSysSkillCond.IsUpdated(conSysSkill.Score) == true)
{
string strComparisonOpScore = objSysSkillCond.dicFldComparisonOp[conSysSkill.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkill.Score, objSysSkillCond.Score, strComparisonOpScore);
}
if (objSysSkillCond.IsUpdated(conSysSkill.StuScore) == true)
{
string strComparisonOpStuScore = objSysSkillCond.dicFldComparisonOp[conSysSkill.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkill.StuScore, objSysSkillCond.StuScore, strComparisonOpStuScore);
}
if (objSysSkillCond.IsUpdated(conSysSkill.TeaScore) == true)
{
string strComparisonOpTeaScore = objSysSkillCond.dicFldComparisonOp[conSysSkill.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkill.TeaScore, objSysSkillCond.TeaScore, strComparisonOpTeaScore);
}
if (objSysSkillCond.IsUpdated(conSysSkill.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objSysSkillCond.dicFldComparisonOp[conSysSkill.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.IdCurrEduCls, objSysSkillCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objSysSkillCond.IsUpdated(conSysSkill.PdfContent) == true)
{
string strComparisonOpPdfContent = objSysSkillCond.dicFldComparisonOp[conSysSkill.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.PdfContent, objSysSkillCond.PdfContent, strComparisonOpPdfContent);
}
if (objSysSkillCond.IsUpdated(conSysSkill.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objSysSkillCond.dicFldComparisonOp[conSysSkill.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkill.PdfPageNum, objSysSkillCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objSysSkillCond.IsUpdated(conSysSkill.CitationCount) == true)
{
string strComparisonOpCitationCount = objSysSkillCond.dicFldComparisonOp[conSysSkill.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkill.CitationCount, objSysSkillCond.CitationCount, strComparisonOpCitationCount);
}
if (objSysSkillCond.IsUpdated(conSysSkill.VersionCount) == true)
{
string strComparisonOpVersionCount = objSysSkillCond.dicFldComparisonOp[conSysSkill.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSkill.VersionCount, objSysSkillCond.VersionCount, strComparisonOpVersionCount);
}
if (objSysSkillCond.IsUpdated(conSysSkill.Memo) == true)
{
string strComparisonOpMemo = objSysSkillCond.dicFldComparisonOp[conSysSkill.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.Memo, objSysSkillCond.Memo, strComparisonOpMemo);
}
if (objSysSkillCond.IsUpdated(conSysSkill.CreateDate) == true)
{
string strComparisonOpCreateDate = objSysSkillCond.dicFldComparisonOp[conSysSkill.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.CreateDate, objSysSkillCond.CreateDate, strComparisonOpCreateDate);
}
if (objSysSkillCond.IsUpdated(conSysSkill.ShareId) == true)
{
string strComparisonOpShareId = objSysSkillCond.dicFldComparisonOp[conSysSkill.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSkill.ShareId, objSysSkillCond.ShareId, strComparisonOpShareId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysSkill(技能表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SkillId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysSkillEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysSkillEN objSysSkillEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysSkillEN == null) return true;
if (objSysSkillEN.SkillId == null || objSysSkillEN.SkillId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SkillId = '{0}'", objSysSkillEN.SkillId);
if (clsSysSkillBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SkillId !=  '{0}'", objSysSkillEN.SkillId);
 sbCondition.AppendFormat(" and SkillId = '{0}'", objSysSkillEN.SkillId);
if (clsSysSkillBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysSkill(技能表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SkillId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysSkillEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysSkillEN objSysSkillEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysSkillEN == null) return "";
if (objSysSkillEN.SkillId == null || objSysSkillEN.SkillId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SkillId = '{0}'", objSysSkillEN.SkillId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SkillId !=  '{0}'", objSysSkillEN.SkillId);
 sbCondition.AppendFormat(" and SkillId = '{0}'", objSysSkillEN.SkillId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysSkill
{
public virtual bool UpdRelaTabDate(string strSkillId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 技能表(SysSkill)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysSkillBL
{
public static RelatedActions_SysSkill relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysSkillDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysSkillDA SysSkillDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysSkillDA();
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
 public clsSysSkillBL()
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
if (string.IsNullOrEmpty(clsSysSkillEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysSkillEN._ConnectString);
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
public static DataTable GetDataTable_SysSkill(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysSkillDA.GetDataTable_SysSkill(strWhereCond);
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
objDT = SysSkillDA.GetDataTable(strWhereCond);
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
objDT = SysSkillDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysSkillDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysSkillDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysSkillDA.GetDataTable_Top(objTopPara);
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
objDT = SysSkillDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysSkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysSkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSkillIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysSkillEN> GetObjLstBySkillIdLst(List<string> arrSkillIdLst)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSkillIdLst, true);
 string strWhereCond = string.Format("SkillId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSkillIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysSkillEN> GetObjLstBySkillIdLstCache(List<string> arrSkillIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsSysSkillEN._CurrTabName, strIdCurrEduCls);
List<clsSysSkillEN> arrSysSkillObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysSkillEN> arrSysSkillObjLst_Sel =
arrSysSkillObjLstCache
.Where(x => arrSkillIdLst.Contains(x.SkillId));
return arrSysSkillObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSkillEN> GetObjLst(string strWhereCond)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
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
public static List<clsSysSkillEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysSkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysSkillEN> GetSubObjLstCache(clsSysSkillEN objSysSkillCond)
{
 string strIdCurrEduCls = objSysSkillCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsSysSkillBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsSysSkillEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysSkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSkill.AttributeName)
{
if (objSysSkillCond.IsUpdated(strFldName) == false) continue;
if (objSysSkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSkillCond[strFldName].ToString());
}
else
{
if (objSysSkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSkillCond[strFldName]));
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
public static List<clsSysSkillEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
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
public static List<clsSysSkillEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
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
List<clsSysSkillEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysSkillEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSkillEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysSkillEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
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
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
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
public static List<clsSysSkillEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysSkillEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysSkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
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
public static List<clsSysSkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSkillEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysSkillEN> arrObjLst = new List<clsSysSkillEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSkillEN objSysSkillEN = new clsSysSkillEN();
try
{
objSysSkillEN.SkillId = objRow[conSysSkill.SkillId].ToString().Trim(); //技能Id
objSysSkillEN.SkillName = objRow[conSysSkill.SkillName] == DBNull.Value ? null : objRow[conSysSkill.SkillName].ToString().Trim(); //技能名称
objSysSkillEN.OperationTypeId = objRow[conSysSkill.OperationTypeId] == DBNull.Value ? null : objRow[conSysSkill.OperationTypeId].ToString().Trim(); //操作类型ID
objSysSkillEN.Process = objRow[conSysSkill.Process] == DBNull.Value ? null : objRow[conSysSkill.Process].ToString().Trim(); //实施过程
objSysSkillEN.LevelId = objRow[conSysSkill.LevelId] == DBNull.Value ? null : objRow[conSysSkill.LevelId].ToString().Trim(); //级别Id
objSysSkillEN.UpdUser = objRow[conSysSkill.UpdUser] == DBNull.Value ? null : objRow[conSysSkill.UpdUser].ToString().Trim(); //修改人
objSysSkillEN.UpdDate = objRow[conSysSkill.UpdDate] == DBNull.Value ? null : objRow[conSysSkill.UpdDate].ToString().Trim(); //修改日期
objSysSkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSkill.IsSubmit].ToString().Trim()); //是否提交
objSysSkillEN.CitationId = objRow[conSysSkill.CitationId] == DBNull.Value ? null : objRow[conSysSkill.CitationId].ToString().Trim(); //引用Id
objSysSkillEN.OkCount = objRow[conSysSkill.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.OkCount].ToString().Trim()); //点赞统计
objSysSkillEN.AppraiseCount = objRow[conSysSkill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.AppraiseCount].ToString().Trim()); //评论数
objSysSkillEN.Score = objRow[conSysSkill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.Score].ToString().Trim()); //评分
objSysSkillEN.StuScore = objRow[conSysSkill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.StuScore].ToString().Trim()); //学生平均分
objSysSkillEN.TeaScore = objRow[conSysSkill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSkill.TeaScore].ToString().Trim()); //教师评分
objSysSkillEN.IdCurrEduCls = objRow[conSysSkill.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSkill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSkillEN.PdfContent = objRow[conSysSkill.PdfContent] == DBNull.Value ? null : objRow[conSysSkill.PdfContent].ToString().Trim(); //Pdf内容
objSysSkillEN.PdfPageNum = objRow[conSysSkill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.PdfPageNum].ToString().Trim()); //Pdf页码
objSysSkillEN.CitationCount = objRow[conSysSkill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.CitationCount].ToString().Trim()); //引用统计
objSysSkillEN.VersionCount = objRow[conSysSkill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSkill.VersionCount].ToString().Trim()); //版本统计
objSysSkillEN.Memo = objRow[conSysSkill.Memo] == DBNull.Value ? null : objRow[conSysSkill.Memo].ToString().Trim(); //备注
objSysSkillEN.CreateDate = objRow[conSysSkill.CreateDate] == DBNull.Value ? null : objRow[conSysSkill.CreateDate].ToString().Trim(); //建立日期
objSysSkillEN.ShareId = objRow[conSysSkill.ShareId] == DBNull.Value ? null : objRow[conSysSkill.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSkillEN.SkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSkillEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysSkillEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysSkill(ref clsSysSkillEN objSysSkillEN)
{
bool bolResult = SysSkillDA.GetSysSkill(ref objSysSkillEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSkillId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSkillEN GetObjBySkillId(string strSkillId)
{
if (strSkillId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSkillId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSkillId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSkillId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSysSkillEN objSysSkillEN = SysSkillDA.GetObjBySkillId(strSkillId);
return objSysSkillEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysSkillEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysSkillEN objSysSkillEN = SysSkillDA.GetFirstObj(strWhereCond);
 return objSysSkillEN;
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
public static clsSysSkillEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysSkillEN objSysSkillEN = SysSkillDA.GetObjByDataRow(objRow);
 return objSysSkillEN;
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
public static clsSysSkillEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysSkillEN objSysSkillEN = SysSkillDA.GetObjByDataRow(objRow);
 return objSysSkillEN;
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
 /// <param name = "strSkillId">所给的关键字</param>
 /// <param name = "lstSysSkillObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSkillEN GetObjBySkillIdFromList(string strSkillId, List<clsSysSkillEN> lstSysSkillObjLst)
{
foreach (clsSysSkillEN objSysSkillEN in lstSysSkillObjLst)
{
if (objSysSkillEN.SkillId == strSkillId)
{
return objSysSkillEN;
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
 string strMaxSkillId;
 try
 {
 strMaxSkillId = clsSysSkillDA.GetMaxStrId();
 return strMaxSkillId;
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
 string strSkillId;
 try
 {
 strSkillId = new clsSysSkillDA().GetFirstID(strWhereCond);
 return strSkillId;
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
 arrList = SysSkillDA.GetID(strWhereCond);
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
bool bolIsExist = SysSkillDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSkillId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSkillId)
{
if (string.IsNullOrEmpty(strSkillId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSkillId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SysSkillDA.IsExist(strSkillId);
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
 bolIsExist = clsSysSkillDA.IsExistTable();
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
 bolIsExist = SysSkillDA.IsExistTable(strTabName);
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysSkillEN objSysSkillEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSkillEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!技能Id = [{0}]的数据已经存在!(in clsSysSkillBL.AddNewRecordBySql2)", objSysSkillEN.SkillId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSkillEN.SkillId) == true || clsSysSkillBL.IsExist(objSysSkillEN.SkillId) == true)
 {
     objSysSkillEN.SkillId = clsSysSkillBL.GetMaxStrId_S();
 }
bool bolResult = SysSkillDA.AddNewRecordBySQL2(objSysSkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysSkillEN objSysSkillEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSkillEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!技能Id = [{0}]的数据已经存在!(in clsSysSkillBL.AddNewRecordBySql2WithReturnKey)", objSysSkillEN.SkillId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSkillEN.SkillId) == true || clsSysSkillBL.IsExist(objSysSkillEN.SkillId) == true)
 {
     objSysSkillEN.SkillId = clsSysSkillBL.GetMaxStrId_S();
 }
string strKey = SysSkillDA.AddNewRecordBySQL2WithReturnKey(objSysSkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysSkillEN objSysSkillEN)
{
try
{
bool bolResult = SysSkillDA.Update(objSysSkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "objSysSkillEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysSkillEN objSysSkillEN)
{
 if (string.IsNullOrEmpty(objSysSkillEN.SkillId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysSkillDA.UpdateBySql2(objSysSkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSkillBL.ReFreshCache(objSysSkillEN.IdCurrEduCls);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
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
 /// <param name = "strSkillId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSkillId)
{
try
{
 clsSysSkillEN objSysSkillEN = clsSysSkillBL.GetObjBySkillId(strSkillId);

if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(objSysSkillEN.SkillId, "SetUpdDate");
}
if (objSysSkillEN != null)
{
int intRecNum = SysSkillDA.DelRecord(strSkillId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSysSkillEN.IdCurrEduCls);
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
/// <param name="strSkillId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strSkillId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSkillDA.GetSpecSQLObj();
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
//删除与表:[SysSkill]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysSkill.SkillId,
//strSkillId);
//        clsSysSkillBL.DelSysSkillsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSkillBL.DelRecord(strSkillId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSkillBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSkillId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSkillId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSkillId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysSkillBL.relatedActions != null)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(strSkillId, "UpdRelaTabDate");
}
bool bolResult = SysSkillDA.DelRecord(strSkillId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSkillIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysSkills(List<string> arrSkillIdLst)
{
if (arrSkillIdLst.Count == 0) return 0;
try
{
if (clsSysSkillBL.relatedActions != null)
{
foreach (var strSkillId in arrSkillIdLst)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(strSkillId, "UpdRelaTabDate");
}
}
 clsSysSkillEN objSysSkillEN = clsSysSkillBL.GetObjBySkillId(arrSkillIdLst[0]);
int intDelRecNum = SysSkillDA.DelSysSkill(arrSkillIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSysSkillEN.IdCurrEduCls);
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
public static int DelSysSkillsByCond(string strWhereCond)
{
try
{
if (clsSysSkillBL.relatedActions != null)
{
List<string> arrSkillId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSkillId in arrSkillId)
{
clsSysSkillBL.relatedActions.UpdRelaTabDate(strSkillId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conSysSkill.IdCurrEduCls, strWhereCond);
int intRecNum = SysSkillDA.DelSysSkill(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysSkill]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSkillId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSkillId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSkillDA.GetSpecSQLObj();
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
//删除与表:[SysSkill]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSkillBL.DelRecord(strSkillId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSkillBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSkillId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysSkillENS">源对象</param>
 /// <param name = "objSysSkillENT">目标对象</param>
 public static void CopyTo(clsSysSkillEN objSysSkillENS, clsSysSkillEN objSysSkillENT)
{
try
{
objSysSkillENT.SkillId = objSysSkillENS.SkillId; //技能Id
objSysSkillENT.SkillName = objSysSkillENS.SkillName; //技能名称
objSysSkillENT.OperationTypeId = objSysSkillENS.OperationTypeId; //操作类型ID
objSysSkillENT.Process = objSysSkillENS.Process; //实施过程
objSysSkillENT.LevelId = objSysSkillENS.LevelId; //级别Id
objSysSkillENT.UpdUser = objSysSkillENS.UpdUser; //修改人
objSysSkillENT.UpdDate = objSysSkillENS.UpdDate; //修改日期
objSysSkillENT.IsSubmit = objSysSkillENS.IsSubmit; //是否提交
objSysSkillENT.CitationId = objSysSkillENS.CitationId; //引用Id
objSysSkillENT.OkCount = objSysSkillENS.OkCount; //点赞统计
objSysSkillENT.AppraiseCount = objSysSkillENS.AppraiseCount; //评论数
objSysSkillENT.Score = objSysSkillENS.Score; //评分
objSysSkillENT.StuScore = objSysSkillENS.StuScore; //学生平均分
objSysSkillENT.TeaScore = objSysSkillENS.TeaScore; //教师评分
objSysSkillENT.IdCurrEduCls = objSysSkillENS.IdCurrEduCls; //教学班流水号
objSysSkillENT.PdfContent = objSysSkillENS.PdfContent; //Pdf内容
objSysSkillENT.PdfPageNum = objSysSkillENS.PdfPageNum; //Pdf页码
objSysSkillENT.CitationCount = objSysSkillENS.CitationCount; //引用统计
objSysSkillENT.VersionCount = objSysSkillENS.VersionCount; //版本统计
objSysSkillENT.Memo = objSysSkillENS.Memo; //备注
objSysSkillENT.CreateDate = objSysSkillENS.CreateDate; //建立日期
objSysSkillENT.ShareId = objSysSkillENS.ShareId; //分享Id
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
 /// <param name = "objSysSkillEN">源简化对象</param>
 public static void SetUpdFlag(clsSysSkillEN objSysSkillEN)
{
try
{
objSysSkillEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysSkillEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysSkill.SkillId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.SkillId = objSysSkillEN.SkillId; //技能Id
}
if (arrFldSet.Contains(conSysSkill.SkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.SkillName = objSysSkillEN.SkillName == "[null]" ? null :  objSysSkillEN.SkillName; //技能名称
}
if (arrFldSet.Contains(conSysSkill.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.OperationTypeId = objSysSkillEN.OperationTypeId == "[null]" ? null :  objSysSkillEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(conSysSkill.Process, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.Process = objSysSkillEN.Process == "[null]" ? null :  objSysSkillEN.Process; //实施过程
}
if (arrFldSet.Contains(conSysSkill.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.LevelId = objSysSkillEN.LevelId == "[null]" ? null :  objSysSkillEN.LevelId; //级别Id
}
if (arrFldSet.Contains(conSysSkill.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.UpdUser = objSysSkillEN.UpdUser == "[null]" ? null :  objSysSkillEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conSysSkill.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.UpdDate = objSysSkillEN.UpdDate == "[null]" ? null :  objSysSkillEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSysSkill.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.IsSubmit = objSysSkillEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conSysSkill.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.CitationId = objSysSkillEN.CitationId == "[null]" ? null :  objSysSkillEN.CitationId; //引用Id
}
if (arrFldSet.Contains(conSysSkill.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.OkCount = objSysSkillEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conSysSkill.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.AppraiseCount = objSysSkillEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conSysSkill.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.Score = objSysSkillEN.Score; //评分
}
if (arrFldSet.Contains(conSysSkill.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.StuScore = objSysSkillEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conSysSkill.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.TeaScore = objSysSkillEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conSysSkill.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.IdCurrEduCls = objSysSkillEN.IdCurrEduCls == "[null]" ? null :  objSysSkillEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conSysSkill.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.PdfContent = objSysSkillEN.PdfContent == "[null]" ? null :  objSysSkillEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conSysSkill.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.PdfPageNum = objSysSkillEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conSysSkill.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.CitationCount = objSysSkillEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conSysSkill.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.VersionCount = objSysSkillEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conSysSkill.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.Memo = objSysSkillEN.Memo == "[null]" ? null :  objSysSkillEN.Memo; //备注
}
if (arrFldSet.Contains(conSysSkill.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.CreateDate = objSysSkillEN.CreateDate == "[null]" ? null :  objSysSkillEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conSysSkill.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSkillEN.ShareId = objSysSkillEN.ShareId == "[null]" ? null :  objSysSkillEN.ShareId; //分享Id
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
 /// <param name = "objSysSkillEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysSkillEN objSysSkillEN)
{
try
{
if (objSysSkillEN.SkillName == "[null]") objSysSkillEN.SkillName = null; //技能名称
if (objSysSkillEN.OperationTypeId == "[null]") objSysSkillEN.OperationTypeId = null; //操作类型ID
if (objSysSkillEN.Process == "[null]") objSysSkillEN.Process = null; //实施过程
if (objSysSkillEN.LevelId == "[null]") objSysSkillEN.LevelId = null; //级别Id
if (objSysSkillEN.UpdUser == "[null]") objSysSkillEN.UpdUser = null; //修改人
if (objSysSkillEN.UpdDate == "[null]") objSysSkillEN.UpdDate = null; //修改日期
if (objSysSkillEN.CitationId == "[null]") objSysSkillEN.CitationId = null; //引用Id
if (objSysSkillEN.IdCurrEduCls == "[null]") objSysSkillEN.IdCurrEduCls = null; //教学班流水号
if (objSysSkillEN.PdfContent == "[null]") objSysSkillEN.PdfContent = null; //Pdf内容
if (objSysSkillEN.Memo == "[null]") objSysSkillEN.Memo = null; //备注
if (objSysSkillEN.CreateDate == "[null]") objSysSkillEN.CreateDate = null; //建立日期
if (objSysSkillEN.ShareId == "[null]") objSysSkillEN.ShareId = null; //分享Id
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
public static void CheckPropertyNew(clsSysSkillEN objSysSkillEN)
{
 SysSkillDA.CheckPropertyNew(objSysSkillEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysSkillEN objSysSkillEN)
{
 SysSkillDA.CheckProperty4Condition(objSysSkillEN);
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
if (clsSysSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSkillBL没有刷新缓存机制(clsSysSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SkillId");
//if (arrSysSkillObjLstCache == null)
//{
//arrSysSkillObjLstCache = SysSkillDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSkillId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSkillEN GetObjBySkillIdCache(string strSkillId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsSysSkillEN._CurrTabName, strIdCurrEduCls);
List<clsSysSkillEN> arrSysSkillObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysSkillEN> arrSysSkillObjLst_Sel =
arrSysSkillObjLstCache
.Where(x=> x.SkillId == strSkillId 
);
if (arrSysSkillObjLst_Sel.Count() == 0)
{
   clsSysSkillEN obj = clsSysSkillBL.GetObjBySkillId(strSkillId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strSkillId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrSysSkillObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSkillEN> GetAllSysSkillObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsSysSkillEN> arrSysSkillObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrSysSkillObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSkillEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsSysSkillEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsSysSkillEN> arrSysSkillObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrSysSkillObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsSysSkillEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsSysSkillEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysSkillEN._RefreshTimeLst.Count == 0) return "";
return clsSysSkillEN._RefreshTimeLst[clsSysSkillEN._RefreshTimeLst.Count - 1];
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
if (clsSysSkillBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSysSkillEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsSysSkillEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysSkillBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysSkill(技能表)
 /// 唯一性条件:SkillId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysSkillEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysSkillEN objSysSkillEN)
{
//检测记录是否存在
string strResult = SysSkillDA.GetUniCondStr(objSysSkillEN);
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
public static string Func(string strInFldName, string strOutFldName, string strSkillId, string strIdCurrEduCls)
{
if (strInFldName != conSysSkill.SkillId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysSkill.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysSkill.AttributeName));
throw new Exception(strMsg);
}
var objSysSkill = clsSysSkillBL.GetObjBySkillIdCache(strSkillId, strIdCurrEduCls);
if (objSysSkill == null) return "";
return objSysSkill[strOutFldName].ToString();
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
int intRecCount = clsSysSkillDA.GetRecCount(strTabName);
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
int intRecCount = clsSysSkillDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysSkillDA.GetRecCount();
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
int intRecCount = clsSysSkillDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysSkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysSkillEN objSysSkillCond)
{
 string strIdCurrEduCls = objSysSkillCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsSysSkillBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsSysSkillEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysSkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSkill.AttributeName)
{
if (objSysSkillCond.IsUpdated(strFldName) == false) continue;
if (objSysSkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSkillCond[strFldName].ToString());
}
else
{
if (objSysSkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSkillCond[strFldName]));
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
 List<string> arrList = clsSysSkillDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysSkillDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysSkillDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysSkillDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysSkillDA.SetFldValue(clsSysSkillEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysSkillDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysSkillDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysSkillDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysSkillDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysSkill] "); 
 strCreateTabCode.Append(" ( "); 
 // /**技能Id*/ 
 strCreateTabCode.Append(" SkillId char(10) primary key, "); 
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
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**引用Id*/ 
 strCreateTabCode.Append(" CitationId char(8) Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
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
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" ShareId char(2) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 技能表(SysSkill)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysSkill : clsCommFun4BLV2
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
clsSysSkillBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}