
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SkillVerBL
 表名:zx_SkillVer(01120738)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:01
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
public static class  clszx_SkillVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngSkillVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SkillVerEN GetObj(this K_SkillVId_zx_SkillVer myKey)
{
clszx_SkillVerEN objzx_SkillVerEN = clszx_SkillVerBL.zx_SkillVerDA.GetObjBySkillVId(myKey.Value);
return objzx_SkillVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_SkillVerEN objzx_SkillVerEN)
{
if (CheckUniqueness(objzx_SkillVerEN) == false)
{
var strMsg = string.Format("记录已经存在!技能Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_SkillVerBL.AddNewRecord)", objzx_SkillVerEN.zxSkillId,objzx_SkillVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_SkillVerBL.zx_SkillVerDA.AddNewRecordBySQL2(objzx_SkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_SkillVerEN objzx_SkillVerEN)
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
objzx_SkillVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_SkillVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(技能Id(zxSkillId)=[{0}],小组Id(GroupTextId)=[{1}])已经存在,不能重复!", objzx_SkillVerEN.zxSkillId, objzx_SkillVerEN.GroupTextId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_SkillVerEN.AddNewRecord();
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
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_SkillVerEN objzx_SkillVerEN)
{
if (CheckUniqueness(objzx_SkillVerEN) == false)
{
var strMsg = string.Format("记录已经存在!技能Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_SkillVerBL.AddNewRecordWithReturnKey)", objzx_SkillVerEN.zxSkillId,objzx_SkillVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_SkillVerBL.zx_SkillVerDA.AddNewRecordBySQL2WithReturnKey(objzx_SkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetSkillVId(this clszx_SkillVerEN objzx_SkillVerEN, long lngSkillVId, string strComparisonOp="")
	{
objzx_SkillVerEN.SkillVId = lngSkillVId; //SkillVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.SkillVId) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.SkillVId, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.SkillVId] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetzxSkillId(this clszx_SkillVerEN objzx_SkillVerEN, string strzxSkillId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxSkillId, conzx_SkillVer.zxSkillId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxSkillId, 10, conzx_SkillVer.zxSkillId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxSkillId, 10, conzx_SkillVer.zxSkillId);
}
objzx_SkillVerEN.zxSkillId = strzxSkillId; //技能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.zxSkillId) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.zxSkillId, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.zxSkillId] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetSkillName(this clszx_SkillVerEN objzx_SkillVerEN, string strSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillName, 200, conzx_SkillVer.SkillName);
}
objzx_SkillVerEN.SkillName = strSkillName; //技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.SkillName) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.SkillName, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.SkillName] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetzxOperationTypeId(this clszx_SkillVerEN objzx_SkillVerEN, string strzxOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxOperationTypeId, 2, conzx_SkillVer.zxOperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxOperationTypeId, 2, conzx_SkillVer.zxOperationTypeId);
}
objzx_SkillVerEN.zxOperationTypeId = strzxOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.zxOperationTypeId) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.zxOperationTypeId, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.zxOperationTypeId] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetProcess(this clszx_SkillVerEN objzx_SkillVerEN, string strProcess, string strComparisonOp="")
	{
objzx_SkillVerEN.Process = strProcess; //实施过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.Process) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.Process, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.Process] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetzxLevelId(this clszx_SkillVerEN objzx_SkillVerEN, string strzxLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxLevelId, 2, conzx_SkillVer.zxLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxLevelId, 2, conzx_SkillVer.zxLevelId);
}
objzx_SkillVerEN.zxLevelId = strzxLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.zxLevelId) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.zxLevelId, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.zxLevelId] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetUpdUser(this clszx_SkillVerEN objzx_SkillVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_SkillVer.UpdUser);
}
objzx_SkillVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.UpdUser) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.UpdUser, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.UpdUser] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetCreateDate(this clszx_SkillVerEN objzx_SkillVerEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_SkillVer.CreateDate);
}
objzx_SkillVerEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.CreateDate) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.CreateDate, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.CreateDate] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetUpdDate(this clszx_SkillVerEN objzx_SkillVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_SkillVer.UpdDate);
}
objzx_SkillVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.UpdDate) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.UpdDate, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.UpdDate] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetIsSubmit(this clszx_SkillVerEN objzx_SkillVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_SkillVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.IsSubmit) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.IsSubmit, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.IsSubmit] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetTextId(this clszx_SkillVerEN objzx_SkillVerEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_SkillVer.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_SkillVer.TextId);
}
objzx_SkillVerEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.TextId) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.TextId, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.TextId] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetVoteCount(this clszx_SkillVerEN objzx_SkillVerEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_SkillVerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.VoteCount) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.VoteCount, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.VoteCount] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetAppraiseCount(this clszx_SkillVerEN objzx_SkillVerEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_SkillVerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.AppraiseCount) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.AppraiseCount, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.AppraiseCount] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetScore(this clszx_SkillVerEN objzx_SkillVerEN, float? fltScore, string strComparisonOp="")
	{
objzx_SkillVerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.Score) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.Score, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.Score] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetStuScore(this clszx_SkillVerEN objzx_SkillVerEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_SkillVerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.StuScore) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.StuScore, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.StuScore] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetTeaScore(this clszx_SkillVerEN objzx_SkillVerEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_SkillVerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.TeaScore) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.TeaScore, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.TeaScore] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetIdCurrEduCls(this clszx_SkillVerEN objzx_SkillVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_SkillVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_SkillVer.IdCurrEduCls);
}
objzx_SkillVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.IdCurrEduCls) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetPdfContent(this clszx_SkillVerEN objzx_SkillVerEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_SkillVer.PdfContent);
}
objzx_SkillVerEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.PdfContent) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.PdfContent, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.PdfContent] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetPdfPageNum(this clszx_SkillVerEN objzx_SkillVerEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_SkillVerEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.PdfPageNum) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.PdfPageNum, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.PdfPageNum] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetCitationCount(this clszx_SkillVerEN objzx_SkillVerEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_SkillVerEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.CitationCount) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.CitationCount, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.CitationCount] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetVersionCount(this clszx_SkillVerEN objzx_SkillVerEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_SkillVerEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.VersionCount) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.VersionCount, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.VersionCount] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetzxShareId(this clszx_SkillVerEN objzx_SkillVerEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_SkillVer.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_SkillVer.zxShareId);
}
objzx_SkillVerEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.zxShareId) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.zxShareId, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.zxShareId] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetMemo(this clszx_SkillVerEN objzx_SkillVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_SkillVer.Memo);
}
objzx_SkillVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.Memo) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.Memo, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.Memo] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetPdfDivLet(this clszx_SkillVerEN objzx_SkillVerEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_SkillVer.PdfDivLet);
}
objzx_SkillVerEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.PdfDivLet) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.PdfDivLet, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.PdfDivLet] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetPdfDivTop(this clszx_SkillVerEN objzx_SkillVerEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_SkillVer.PdfDivTop);
}
objzx_SkillVerEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.PdfDivTop) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.PdfDivTop, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.PdfDivTop] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetPdfPageNumIn(this clszx_SkillVerEN objzx_SkillVerEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_SkillVer.PdfPageNumIn);
}
objzx_SkillVerEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.PdfPageNumIn) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetPdfPageTop(this clszx_SkillVerEN objzx_SkillVerEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_SkillVerEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.PdfPageTop) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.PdfPageTop, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.PdfPageTop] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetPdfZoom(this clszx_SkillVerEN objzx_SkillVerEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_SkillVer.PdfZoom);
}
objzx_SkillVerEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.PdfZoom) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.PdfZoom, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.PdfZoom] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillVerEN SetGroupTextId(this clszx_SkillVerEN objzx_SkillVerEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_SkillVer.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_SkillVer.GroupTextId);
}
objzx_SkillVerEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillVerEN.dicFldComparisonOp.ContainsKey(conzx_SkillVer.GroupTextId) == false)
{
objzx_SkillVerEN.dicFldComparisonOp.Add(conzx_SkillVer.GroupTextId, strComparisonOp);
}
else
{
objzx_SkillVerEN.dicFldComparisonOp[conzx_SkillVer.GroupTextId] = strComparisonOp;
}
}
return objzx_SkillVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_SkillVerEN objzx_SkillVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_SkillVerEN.CheckPropertyNew();
clszx_SkillVerEN objzx_SkillVerCond = new clszx_SkillVerEN();
string strCondition = objzx_SkillVerCond
.SetSkillVId(objzx_SkillVerEN.SkillVId, "<>")
.SetzxSkillId(objzx_SkillVerEN.zxSkillId, "=")
.SetGroupTextId(objzx_SkillVerEN.GroupTextId, "=")
.GetCombineCondition();
objzx_SkillVerEN._IsCheckProperty = true;
bool bolIsExist = clszx_SkillVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxSkillId_GroupTextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_SkillVerEN.Update();
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
 /// <param name = "objzx_SkillVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_SkillVerEN objzx_SkillVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_SkillVerEN objzx_SkillVerCond = new clszx_SkillVerEN();
string strCondition = objzx_SkillVerCond
.SetzxSkillId(objzx_SkillVer.zxSkillId, "=")
.SetGroupTextId(objzx_SkillVer.GroupTextId, "=")
.GetCombineCondition();
objzx_SkillVer._IsCheckProperty = true;
bool bolIsExist = clszx_SkillVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_SkillVer.SkillVId = clszx_SkillVerBL.GetFirstID_S(strCondition);
objzx_SkillVer.UpdateWithCondition(strCondition);
}
else
{
objzx_SkillVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SkillVerEN objzx_SkillVerEN)
{
 if (objzx_SkillVerEN.SkillVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SkillVerBL.zx_SkillVerDA.UpdateBySql2(objzx_SkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SkillVerEN objzx_SkillVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SkillVerEN.SkillVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SkillVerBL.zx_SkillVerDA.UpdateBySql2(objzx_SkillVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objzx_SkillVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SkillVerEN objzx_SkillVerEN, string strWhereCond)
{
try
{
bool bolResult = clszx_SkillVerBL.zx_SkillVerDA.UpdateBySqlWithCondition(objzx_SkillVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objzx_SkillVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SkillVerEN objzx_SkillVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_SkillVerBL.zx_SkillVerDA.UpdateBySqlWithConditionTransaction(objzx_SkillVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
public static int Delete(this clszx_SkillVerEN objzx_SkillVerEN)
{
try
{
int intRecNum = clszx_SkillVerBL.zx_SkillVerDA.DelRecord(objzx_SkillVerEN.SkillVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objzx_SkillVerENS">源对象</param>
 /// <param name = "objzx_SkillVerENT">目标对象</param>
 public static void CopyTo(this clszx_SkillVerEN objzx_SkillVerENS, clszx_SkillVerEN objzx_SkillVerENT)
{
try
{
objzx_SkillVerENT.SkillVId = objzx_SkillVerENS.SkillVId; //SkillVId
objzx_SkillVerENT.zxSkillId = objzx_SkillVerENS.zxSkillId; //技能Id
objzx_SkillVerENT.SkillName = objzx_SkillVerENS.SkillName; //技能名称
objzx_SkillVerENT.zxOperationTypeId = objzx_SkillVerENS.zxOperationTypeId; //操作类型ID
objzx_SkillVerENT.Process = objzx_SkillVerENS.Process; //实施过程
objzx_SkillVerENT.zxLevelId = objzx_SkillVerENS.zxLevelId; //级别Id
objzx_SkillVerENT.UpdUser = objzx_SkillVerENS.UpdUser; //修改人
objzx_SkillVerENT.CreateDate = objzx_SkillVerENS.CreateDate; //建立日期
objzx_SkillVerENT.UpdDate = objzx_SkillVerENS.UpdDate; //修改日期
objzx_SkillVerENT.IsSubmit = objzx_SkillVerENS.IsSubmit; //是否提交
objzx_SkillVerENT.TextId = objzx_SkillVerENS.TextId; //课件Id
objzx_SkillVerENT.VoteCount = objzx_SkillVerENS.VoteCount; //点赞计数
objzx_SkillVerENT.AppraiseCount = objzx_SkillVerENS.AppraiseCount; //评论数
objzx_SkillVerENT.Score = objzx_SkillVerENS.Score; //评分
objzx_SkillVerENT.StuScore = objzx_SkillVerENS.StuScore; //学生平均分
objzx_SkillVerENT.TeaScore = objzx_SkillVerENS.TeaScore; //教师评分
objzx_SkillVerENT.IdCurrEduCls = objzx_SkillVerENS.IdCurrEduCls; //教学班流水号
objzx_SkillVerENT.PdfContent = objzx_SkillVerENS.PdfContent; //Pdf内容
objzx_SkillVerENT.PdfPageNum = objzx_SkillVerENS.PdfPageNum; //Pdf页码
objzx_SkillVerENT.CitationCount = objzx_SkillVerENS.CitationCount; //引用统计
objzx_SkillVerENT.VersionCount = objzx_SkillVerENS.VersionCount; //版本统计
objzx_SkillVerENT.zxShareId = objzx_SkillVerENS.zxShareId; //分享Id
objzx_SkillVerENT.Memo = objzx_SkillVerENS.Memo; //备注
objzx_SkillVerENT.PdfDivLet = objzx_SkillVerENS.PdfDivLet; //PdfDivLet
objzx_SkillVerENT.PdfDivTop = objzx_SkillVerENS.PdfDivTop; //PdfDivTop
objzx_SkillVerENT.PdfPageNumIn = objzx_SkillVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_SkillVerENT.PdfPageTop = objzx_SkillVerENS.PdfPageTop; //pdf页面顶部位置
objzx_SkillVerENT.PdfZoom = objzx_SkillVerENS.PdfZoom; //PdfZoom
objzx_SkillVerENT.GroupTextId = objzx_SkillVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_SkillVerENS">源对象</param>
 /// <returns>目标对象=>clszx_SkillVerEN:objzx_SkillVerENT</returns>
 public static clszx_SkillVerEN CopyTo(this clszx_SkillVerEN objzx_SkillVerENS)
{
try
{
 clszx_SkillVerEN objzx_SkillVerENT = new clszx_SkillVerEN()
{
SkillVId = objzx_SkillVerENS.SkillVId, //SkillVId
zxSkillId = objzx_SkillVerENS.zxSkillId, //技能Id
SkillName = objzx_SkillVerENS.SkillName, //技能名称
zxOperationTypeId = objzx_SkillVerENS.zxOperationTypeId, //操作类型ID
Process = objzx_SkillVerENS.Process, //实施过程
zxLevelId = objzx_SkillVerENS.zxLevelId, //级别Id
UpdUser = objzx_SkillVerENS.UpdUser, //修改人
CreateDate = objzx_SkillVerENS.CreateDate, //建立日期
UpdDate = objzx_SkillVerENS.UpdDate, //修改日期
IsSubmit = objzx_SkillVerENS.IsSubmit, //是否提交
TextId = objzx_SkillVerENS.TextId, //课件Id
VoteCount = objzx_SkillVerENS.VoteCount, //点赞计数
AppraiseCount = objzx_SkillVerENS.AppraiseCount, //评论数
Score = objzx_SkillVerENS.Score, //评分
StuScore = objzx_SkillVerENS.StuScore, //学生平均分
TeaScore = objzx_SkillVerENS.TeaScore, //教师评分
IdCurrEduCls = objzx_SkillVerENS.IdCurrEduCls, //教学班流水号
PdfContent = objzx_SkillVerENS.PdfContent, //Pdf内容
PdfPageNum = objzx_SkillVerENS.PdfPageNum, //Pdf页码
CitationCount = objzx_SkillVerENS.CitationCount, //引用统计
VersionCount = objzx_SkillVerENS.VersionCount, //版本统计
zxShareId = objzx_SkillVerENS.zxShareId, //分享Id
Memo = objzx_SkillVerENS.Memo, //备注
PdfDivLet = objzx_SkillVerENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_SkillVerENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_SkillVerENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_SkillVerENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_SkillVerENS.PdfZoom, //PdfZoom
GroupTextId = objzx_SkillVerENS.GroupTextId, //小组Id
};
 return objzx_SkillVerENT;
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
public static void CheckPropertyNew(this clszx_SkillVerEN objzx_SkillVerEN)
{
 clszx_SkillVerBL.zx_SkillVerDA.CheckPropertyNew(objzx_SkillVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_SkillVerEN objzx_SkillVerEN)
{
 clszx_SkillVerBL.zx_SkillVerDA.CheckProperty4Condition(objzx_SkillVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_SkillVerEN objzx_SkillVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.SkillVId) == true)
{
string strComparisonOpSkillVId = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.SkillVId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.SkillVId, objzx_SkillVerCond.SkillVId, strComparisonOpSkillVId);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.zxSkillId) == true)
{
string strComparisonOpzxSkillId = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.zxSkillId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.zxSkillId, objzx_SkillVerCond.zxSkillId, strComparisonOpzxSkillId);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.SkillName) == true)
{
string strComparisonOpSkillName = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.SkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.SkillName, objzx_SkillVerCond.SkillName, strComparisonOpSkillName);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.zxOperationTypeId) == true)
{
string strComparisonOpzxOperationTypeId = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.zxOperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.zxOperationTypeId, objzx_SkillVerCond.zxOperationTypeId, strComparisonOpzxOperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.zxLevelId) == true)
{
string strComparisonOpzxLevelId = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.zxLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.zxLevelId, objzx_SkillVerCond.zxLevelId, strComparisonOpzxLevelId);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.UpdUser, objzx_SkillVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.CreateDate, objzx_SkillVerCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.UpdDate, objzx_SkillVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.IsSubmit) == true)
{
if (objzx_SkillVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_SkillVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_SkillVer.IsSubmit);
}
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.TextId) == true)
{
string strComparisonOpTextId = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.TextId, objzx_SkillVerCond.TextId, strComparisonOpTextId);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.VoteCount, objzx_SkillVerCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.AppraiseCount, objzx_SkillVerCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.Score) == true)
{
string strComparisonOpScore = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.Score, objzx_SkillVerCond.Score, strComparisonOpScore);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.StuScore) == true)
{
string strComparisonOpStuScore = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.StuScore, objzx_SkillVerCond.StuScore, strComparisonOpStuScore);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.TeaScore, objzx_SkillVerCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.IdCurrEduCls, objzx_SkillVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.PdfContent, objzx_SkillVerCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.PdfPageNum, objzx_SkillVerCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.CitationCount, objzx_SkillVerCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.VersionCount, objzx_SkillVerCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.zxShareId, objzx_SkillVerCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.Memo) == true)
{
string strComparisonOpMemo = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.Memo, objzx_SkillVerCond.Memo, strComparisonOpMemo);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.PdfDivLet, objzx_SkillVerCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.PdfDivTop, objzx_SkillVerCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.PdfPageNumIn, objzx_SkillVerCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SkillVer.PdfPageTop, objzx_SkillVerCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.PdfZoom, objzx_SkillVerCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_SkillVerCond.IsUpdated(conzx_SkillVer.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_SkillVerCond.dicFldComparisonOp[conzx_SkillVer.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SkillVer.GroupTextId, objzx_SkillVerCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_SkillVer(技能历史版本), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxSkillId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_SkillVerEN objzx_SkillVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_SkillVerEN == null) return true;
if (objzx_SkillVerEN.SkillVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxSkillId = '{0}'", objzx_SkillVerEN.zxSkillId);
 if (objzx_SkillVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_SkillVerEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SkillVerEN.GroupTextId);
}
if (clszx_SkillVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SkillVId !=  {0}", objzx_SkillVerEN.SkillVId);
 sbCondition.AppendFormat(" and zxSkillId = '{0}'", objzx_SkillVerEN.zxSkillId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SkillVerEN.GroupTextId);
if (clszx_SkillVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_SkillVer(技能历史版本), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxSkillId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_SkillVerEN objzx_SkillVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_SkillVerEN == null) return "";
if (objzx_SkillVerEN.SkillVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxSkillId = '{0}'", objzx_SkillVerEN.zxSkillId);
 if (objzx_SkillVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_SkillVerEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SkillVerEN.GroupTextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SkillVId !=  {0}", objzx_SkillVerEN.SkillVId);
 sbCondition.AppendFormat(" and zxSkillId = '{0}'", objzx_SkillVerEN.zxSkillId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SkillVerEN.GroupTextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_SkillVer
{
public virtual bool UpdRelaTabDate(long lngSkillVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 技能历史版本(zx_SkillVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_SkillVerBL
{
public static RelatedActions_zx_SkillVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_SkillVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_SkillVerDA zx_SkillVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_SkillVerDA();
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
 public clszx_SkillVerBL()
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
if (string.IsNullOrEmpty(clszx_SkillVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SkillVerEN._ConnectString);
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
public static DataTable GetDataTable_zx_SkillVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_SkillVerDA.GetDataTable_zx_SkillVer(strWhereCond);
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
objDT = zx_SkillVerDA.GetDataTable(strWhereCond);
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
objDT = zx_SkillVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_SkillVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_SkillVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_SkillVerDA.GetDataTable_Top(objTopPara);
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
objDT = zx_SkillVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_SkillVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_SkillVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clszx_SkillVerEN> GetObjLstBySkillVIdLst(List<long> arrSkillVIdLst)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
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
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSkillVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_SkillVerEN> GetObjLstBySkillVIdLstCache(List<long> arrSkillVIdLst)
{
string strKey = string.Format("{0}", clszx_SkillVerEN._CurrTabName);
List<clszx_SkillVerEN> arrzx_SkillVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_SkillVerEN> arrzx_SkillVerObjLst_Sel =
arrzx_SkillVerObjLstCache
.Where(x => arrSkillVIdLst.Contains(x.SkillVId));
return arrzx_SkillVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SkillVerEN> GetObjLst(string strWhereCond)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
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
public static List<clszx_SkillVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_SkillVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_SkillVerEN> GetSubObjLstCache(clszx_SkillVerEN objzx_SkillVerCond)
{
List<clszx_SkillVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SkillVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SkillVer.AttributeName)
{
if (objzx_SkillVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_SkillVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SkillVerCond[strFldName].ToString());
}
else
{
if (objzx_SkillVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SkillVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SkillVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SkillVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SkillVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SkillVerCond[strFldName]));
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
public static List<clszx_SkillVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
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
public static List<clszx_SkillVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
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
List<clszx_SkillVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_SkillVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SkillVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_SkillVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
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
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
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
public static List<clszx_SkillVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_SkillVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_SkillVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
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
public static List<clszx_SkillVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SkillVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_SkillVerEN> arrObjLst = new List<clszx_SkillVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN();
try
{
objzx_SkillVerEN.SkillVId = Int32.Parse(objRow[conzx_SkillVer.SkillVId].ToString().Trim()); //SkillVId
objzx_SkillVerEN.zxSkillId = objRow[conzx_SkillVer.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillVerEN.SkillName = objRow[conzx_SkillVer.SkillName] == DBNull.Value ? null : objRow[conzx_SkillVer.SkillName].ToString().Trim(); //技能名称
objzx_SkillVerEN.zxOperationTypeId = objRow[conzx_SkillVer.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillVerEN.Process = objRow[conzx_SkillVer.Process] == DBNull.Value ? null : objRow[conzx_SkillVer.Process].ToString().Trim(); //实施过程
objzx_SkillVerEN.zxLevelId = objRow[conzx_SkillVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillVerEN.UpdUser = objRow[conzx_SkillVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdUser].ToString().Trim(); //修改人
objzx_SkillVerEN.CreateDate = objRow[conzx_SkillVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SkillVer.CreateDate].ToString().Trim(); //建立日期
objzx_SkillVerEN.UpdDate = objRow[conzx_SkillVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SkillVer.UpdDate].ToString().Trim(); //修改日期
objzx_SkillVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SkillVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillVerEN.TextId = objRow[conzx_SkillVer.TextId] == DBNull.Value ? null : objRow[conzx_SkillVer.TextId].ToString().Trim(); //课件Id
objzx_SkillVerEN.VoteCount = objRow[conzx_SkillVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillVerEN.AppraiseCount = objRow[conzx_SkillVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillVerEN.Score = objRow[conzx_SkillVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.Score].ToString().Trim()); //评分
objzx_SkillVerEN.StuScore = objRow[conzx_SkillVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.StuScore].ToString().Trim()); //学生平均分
objzx_SkillVerEN.TeaScore = objRow[conzx_SkillVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SkillVer.TeaScore].ToString().Trim()); //教师评分
objzx_SkillVerEN.IdCurrEduCls = objRow[conzx_SkillVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SkillVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillVerEN.PdfContent = objRow[conzx_SkillVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillVerEN.PdfPageNum = objRow[conzx_SkillVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillVerEN.CitationCount = objRow[conzx_SkillVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.CitationCount].ToString().Trim()); //引用统计
objzx_SkillVerEN.VersionCount = objRow[conzx_SkillVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.VersionCount].ToString().Trim()); //版本统计
objzx_SkillVerEN.zxShareId = objRow[conzx_SkillVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SkillVer.zxShareId].ToString().Trim(); //分享Id
objzx_SkillVerEN.Memo = objRow[conzx_SkillVer.Memo] == DBNull.Value ? null : objRow[conzx_SkillVer.Memo].ToString().Trim(); //备注
objzx_SkillVerEN.PdfDivLet = objRow[conzx_SkillVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillVerEN.PdfDivTop = objRow[conzx_SkillVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillVerEN.PdfPageNumIn = objRow[conzx_SkillVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillVerEN.PdfPageTop = objRow[conzx_SkillVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SkillVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillVerEN.PdfZoom = objRow[conzx_SkillVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SkillVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillVerEN.GroupTextId = objRow[conzx_SkillVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SkillVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillVerEN.SkillVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_SkillVer(ref clszx_SkillVerEN objzx_SkillVerEN)
{
bool bolResult = zx_SkillVerDA.Getzx_SkillVer(ref objzx_SkillVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngSkillVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SkillVerEN GetObjBySkillVId(long lngSkillVId)
{
clszx_SkillVerEN objzx_SkillVerEN = zx_SkillVerDA.GetObjBySkillVId(lngSkillVId);
return objzx_SkillVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_SkillVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_SkillVerEN objzx_SkillVerEN = zx_SkillVerDA.GetFirstObj(strWhereCond);
 return objzx_SkillVerEN;
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
public static clszx_SkillVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_SkillVerEN objzx_SkillVerEN = zx_SkillVerDA.GetObjByDataRow(objRow);
 return objzx_SkillVerEN;
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
public static clszx_SkillVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_SkillVerEN objzx_SkillVerEN = zx_SkillVerDA.GetObjByDataRow(objRow);
 return objzx_SkillVerEN;
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
 /// <param name = "lstzx_SkillVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SkillVerEN GetObjBySkillVIdFromList(long lngSkillVId, List<clszx_SkillVerEN> lstzx_SkillVerObjLst)
{
foreach (clszx_SkillVerEN objzx_SkillVerEN in lstzx_SkillVerObjLst)
{
if (objzx_SkillVerEN.SkillVId == lngSkillVId)
{
return objzx_SkillVerEN;
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
 lngSkillVId = new clszx_SkillVerDA().GetFirstID(strWhereCond);
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
 arrList = zx_SkillVerDA.GetID(strWhereCond);
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
bool bolIsExist = zx_SkillVerDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = zx_SkillVerDA.IsExist(lngSkillVId);
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
 bolIsExist = clszx_SkillVerDA.IsExistTable();
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
 bolIsExist = zx_SkillVerDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_SkillVerEN objzx_SkillVerEN)
{
if (objzx_SkillVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!技能Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_SkillVerBL.AddNewRecordBySql2)", objzx_SkillVerEN.zxSkillId,objzx_SkillVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_SkillVerDA.AddNewRecordBySQL2(objzx_SkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_SkillVerEN objzx_SkillVerEN)
{
if (objzx_SkillVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!技能Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_SkillVerBL.AddNewRecordBySql2WithReturnKey)", objzx_SkillVerEN.zxSkillId,objzx_SkillVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_SkillVerDA.AddNewRecordBySQL2WithReturnKey(objzx_SkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_SkillVerEN objzx_SkillVerEN)
{
try
{
bool bolResult = zx_SkillVerDA.Update(objzx_SkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
 /// <param name = "objzx_SkillVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_SkillVerEN objzx_SkillVerEN)
{
 if (objzx_SkillVerEN.SkillVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_SkillVerDA.UpdateBySql2(objzx_SkillVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillVerBL.ReFreshCache();

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
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
 clszx_SkillVerEN objzx_SkillVerEN = clszx_SkillVerBL.GetObjBySkillVId(lngSkillVId);

if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(objzx_SkillVerEN.SkillVId, "SetUpdDate");
}
if (objzx_SkillVerEN != null)
{
int intRecNum = zx_SkillVerDA.DelRecord(lngSkillVId);
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
objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
//删除与表:[zx_SkillVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_SkillVer.SkillVId,
//lngSkillVId);
//        clszx_SkillVerBL.Delzx_SkillVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SkillVerBL.DelRecord(lngSkillVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SkillVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clszx_SkillVerBL.relatedActions != null)
{
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(lngSkillVId, "UpdRelaTabDate");
}
bool bolResult = zx_SkillVerDA.DelRecord(lngSkillVId,objSqlConnection,objSqlTransaction);
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
public static int Delzx_SkillVers(List<string> arrSkillVIdLst)
{
if (arrSkillVIdLst.Count == 0) return 0;
try
{
if (clszx_SkillVerBL.relatedActions != null)
{
foreach (var strSkillVId in arrSkillVIdLst)
{
long lngSkillVId = long.Parse(strSkillVId);
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(lngSkillVId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_SkillVerDA.Delzx_SkillVer(arrSkillVIdLst);
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
public static int Delzx_SkillVersByCond(string strWhereCond)
{
try
{
if (clszx_SkillVerBL.relatedActions != null)
{
List<string> arrSkillVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSkillVId in arrSkillVId)
{
long lngSkillVId = long.Parse(strSkillVId);
clszx_SkillVerBL.relatedActions.UpdRelaTabDate(lngSkillVId, "UpdRelaTabDate");
}
}
int intRecNum = zx_SkillVerDA.Delzx_SkillVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_SkillVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngSkillVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngSkillVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SkillVerDA.GetSpecSQLObj();
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
//删除与表:[zx_SkillVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SkillVerBL.DelRecord(lngSkillVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SkillVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objzx_SkillVerENS">源对象</param>
 /// <param name = "objzx_SkillVerENT">目标对象</param>
 public static void CopyTo(clszx_SkillVerEN objzx_SkillVerENS, clszx_SkillVerEN objzx_SkillVerENT)
{
try
{
objzx_SkillVerENT.SkillVId = objzx_SkillVerENS.SkillVId; //SkillVId
objzx_SkillVerENT.zxSkillId = objzx_SkillVerENS.zxSkillId; //技能Id
objzx_SkillVerENT.SkillName = objzx_SkillVerENS.SkillName; //技能名称
objzx_SkillVerENT.zxOperationTypeId = objzx_SkillVerENS.zxOperationTypeId; //操作类型ID
objzx_SkillVerENT.Process = objzx_SkillVerENS.Process; //实施过程
objzx_SkillVerENT.zxLevelId = objzx_SkillVerENS.zxLevelId; //级别Id
objzx_SkillVerENT.UpdUser = objzx_SkillVerENS.UpdUser; //修改人
objzx_SkillVerENT.CreateDate = objzx_SkillVerENS.CreateDate; //建立日期
objzx_SkillVerENT.UpdDate = objzx_SkillVerENS.UpdDate; //修改日期
objzx_SkillVerENT.IsSubmit = objzx_SkillVerENS.IsSubmit; //是否提交
objzx_SkillVerENT.TextId = objzx_SkillVerENS.TextId; //课件Id
objzx_SkillVerENT.VoteCount = objzx_SkillVerENS.VoteCount; //点赞计数
objzx_SkillVerENT.AppraiseCount = objzx_SkillVerENS.AppraiseCount; //评论数
objzx_SkillVerENT.Score = objzx_SkillVerENS.Score; //评分
objzx_SkillVerENT.StuScore = objzx_SkillVerENS.StuScore; //学生平均分
objzx_SkillVerENT.TeaScore = objzx_SkillVerENS.TeaScore; //教师评分
objzx_SkillVerENT.IdCurrEduCls = objzx_SkillVerENS.IdCurrEduCls; //教学班流水号
objzx_SkillVerENT.PdfContent = objzx_SkillVerENS.PdfContent; //Pdf内容
objzx_SkillVerENT.PdfPageNum = objzx_SkillVerENS.PdfPageNum; //Pdf页码
objzx_SkillVerENT.CitationCount = objzx_SkillVerENS.CitationCount; //引用统计
objzx_SkillVerENT.VersionCount = objzx_SkillVerENS.VersionCount; //版本统计
objzx_SkillVerENT.zxShareId = objzx_SkillVerENS.zxShareId; //分享Id
objzx_SkillVerENT.Memo = objzx_SkillVerENS.Memo; //备注
objzx_SkillVerENT.PdfDivLet = objzx_SkillVerENS.PdfDivLet; //PdfDivLet
objzx_SkillVerENT.PdfDivTop = objzx_SkillVerENS.PdfDivTop; //PdfDivTop
objzx_SkillVerENT.PdfPageNumIn = objzx_SkillVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_SkillVerENT.PdfPageTop = objzx_SkillVerENS.PdfPageTop; //pdf页面顶部位置
objzx_SkillVerENT.PdfZoom = objzx_SkillVerENS.PdfZoom; //PdfZoom
objzx_SkillVerENT.GroupTextId = objzx_SkillVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_SkillVerEN">源简化对象</param>
 public static void SetUpdFlag(clszx_SkillVerEN objzx_SkillVerEN)
{
try
{
objzx_SkillVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_SkillVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_SkillVer.SkillVId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.SkillVId = objzx_SkillVerEN.SkillVId; //SkillVId
}
if (arrFldSet.Contains(conzx_SkillVer.zxSkillId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.zxSkillId = objzx_SkillVerEN.zxSkillId; //技能Id
}
if (arrFldSet.Contains(conzx_SkillVer.SkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.SkillName = objzx_SkillVerEN.SkillName == "[null]" ? null :  objzx_SkillVerEN.SkillName; //技能名称
}
if (arrFldSet.Contains(conzx_SkillVer.zxOperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.zxOperationTypeId = objzx_SkillVerEN.zxOperationTypeId == "[null]" ? null :  objzx_SkillVerEN.zxOperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(conzx_SkillVer.Process, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.Process = objzx_SkillVerEN.Process == "[null]" ? null :  objzx_SkillVerEN.Process; //实施过程
}
if (arrFldSet.Contains(conzx_SkillVer.zxLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.zxLevelId = objzx_SkillVerEN.zxLevelId == "[null]" ? null :  objzx_SkillVerEN.zxLevelId; //级别Id
}
if (arrFldSet.Contains(conzx_SkillVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.UpdUser = objzx_SkillVerEN.UpdUser == "[null]" ? null :  objzx_SkillVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_SkillVer.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.CreateDate = objzx_SkillVerEN.CreateDate == "[null]" ? null :  objzx_SkillVerEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_SkillVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.UpdDate = objzx_SkillVerEN.UpdDate == "[null]" ? null :  objzx_SkillVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_SkillVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.IsSubmit = objzx_SkillVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_SkillVer.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.TextId = objzx_SkillVerEN.TextId == "[null]" ? null :  objzx_SkillVerEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_SkillVer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.VoteCount = objzx_SkillVerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_SkillVer.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.AppraiseCount = objzx_SkillVerEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_SkillVer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.Score = objzx_SkillVerEN.Score; //评分
}
if (arrFldSet.Contains(conzx_SkillVer.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.StuScore = objzx_SkillVerEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_SkillVer.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.TeaScore = objzx_SkillVerEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_SkillVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.IdCurrEduCls = objzx_SkillVerEN.IdCurrEduCls == "[null]" ? null :  objzx_SkillVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_SkillVer.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.PdfContent = objzx_SkillVerEN.PdfContent == "[null]" ? null :  objzx_SkillVerEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_SkillVer.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.PdfPageNum = objzx_SkillVerEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_SkillVer.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.CitationCount = objzx_SkillVerEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_SkillVer.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.VersionCount = objzx_SkillVerEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_SkillVer.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.zxShareId = objzx_SkillVerEN.zxShareId == "[null]" ? null :  objzx_SkillVerEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_SkillVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.Memo = objzx_SkillVerEN.Memo == "[null]" ? null :  objzx_SkillVerEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_SkillVer.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.PdfDivLet = objzx_SkillVerEN.PdfDivLet == "[null]" ? null :  objzx_SkillVerEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_SkillVer.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.PdfDivTop = objzx_SkillVerEN.PdfDivTop == "[null]" ? null :  objzx_SkillVerEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_SkillVer.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.PdfPageNumIn = objzx_SkillVerEN.PdfPageNumIn == "[null]" ? null :  objzx_SkillVerEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_SkillVer.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.PdfPageTop = objzx_SkillVerEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_SkillVer.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.PdfZoom = objzx_SkillVerEN.PdfZoom == "[null]" ? null :  objzx_SkillVerEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_SkillVer.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillVerEN.GroupTextId = objzx_SkillVerEN.GroupTextId == "[null]" ? null :  objzx_SkillVerEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_SkillVerEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_SkillVerEN objzx_SkillVerEN)
{
try
{
if (objzx_SkillVerEN.SkillName == "[null]") objzx_SkillVerEN.SkillName = null; //技能名称
if (objzx_SkillVerEN.zxOperationTypeId == "[null]") objzx_SkillVerEN.zxOperationTypeId = null; //操作类型ID
if (objzx_SkillVerEN.Process == "[null]") objzx_SkillVerEN.Process = null; //实施过程
if (objzx_SkillVerEN.zxLevelId == "[null]") objzx_SkillVerEN.zxLevelId = null; //级别Id
if (objzx_SkillVerEN.UpdUser == "[null]") objzx_SkillVerEN.UpdUser = null; //修改人
if (objzx_SkillVerEN.CreateDate == "[null]") objzx_SkillVerEN.CreateDate = null; //建立日期
if (objzx_SkillVerEN.UpdDate == "[null]") objzx_SkillVerEN.UpdDate = null; //修改日期
if (objzx_SkillVerEN.TextId == "[null]") objzx_SkillVerEN.TextId = null; //课件Id
if (objzx_SkillVerEN.IdCurrEduCls == "[null]") objzx_SkillVerEN.IdCurrEduCls = null; //教学班流水号
if (objzx_SkillVerEN.PdfContent == "[null]") objzx_SkillVerEN.PdfContent = null; //Pdf内容
if (objzx_SkillVerEN.zxShareId == "[null]") objzx_SkillVerEN.zxShareId = null; //分享Id
if (objzx_SkillVerEN.Memo == "[null]") objzx_SkillVerEN.Memo = null; //备注
if (objzx_SkillVerEN.PdfDivLet == "[null]") objzx_SkillVerEN.PdfDivLet = null; //PdfDivLet
if (objzx_SkillVerEN.PdfDivTop == "[null]") objzx_SkillVerEN.PdfDivTop = null; //PdfDivTop
if (objzx_SkillVerEN.PdfPageNumIn == "[null]") objzx_SkillVerEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_SkillVerEN.PdfZoom == "[null]") objzx_SkillVerEN.PdfZoom = null; //PdfZoom
if (objzx_SkillVerEN.GroupTextId == "[null]") objzx_SkillVerEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_SkillVerEN objzx_SkillVerEN)
{
 zx_SkillVerDA.CheckPropertyNew(objzx_SkillVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_SkillVerEN objzx_SkillVerEN)
{
 zx_SkillVerDA.CheckProperty4Condition(objzx_SkillVerEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_SkillVId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conzx_SkillVer.SkillVId); 
List<clszx_SkillVerEN> arrObjLst = clszx_SkillVerBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clszx_SkillVerEN objzx_SkillVerEN = new clszx_SkillVerEN()
{
SkillVId = 0,
zxOperationTypeId = "选[技能历史版本]..."
};
arrObjLst.Insert(0, objzx_SkillVerEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conzx_SkillVer.SkillVId;
objComboBox.DisplayMember = conzx_SkillVer.zxOperationTypeId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_SkillVId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[技能历史版本]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conzx_SkillVer.SkillVId); 
IEnumerable<clszx_SkillVerEN> arrObjLst = clszx_SkillVerBL.GetObjLst(strCondition);
objDDL.DataValueField = conzx_SkillVer.SkillVId;
objDDL.DataTextField = conzx_SkillVer.zxOperationTypeId;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SkillVIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[技能历史版本]...","0");
List<clszx_SkillVerEN> arrzx_SkillVerObjLst = GetAllzx_SkillVerObjLstCache(); 
objDDL.DataValueField = conzx_SkillVer.SkillVId;
objDDL.DataTextField = conzx_SkillVer.zxOperationTypeId;
objDDL.DataSource = arrzx_SkillVerObjLst;
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
if (clszx_SkillVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SkillVerBL没有刷新缓存机制(clszx_SkillVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SkillVId");
//if (arrzx_SkillVerObjLstCache == null)
//{
//arrzx_SkillVerObjLstCache = zx_SkillVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngSkillVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SkillVerEN GetObjBySkillVIdCache(long lngSkillVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_SkillVerEN._CurrTabName);
List<clszx_SkillVerEN> arrzx_SkillVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_SkillVerEN> arrzx_SkillVerObjLst_Sel =
arrzx_SkillVerObjLstCache
.Where(x=> x.SkillVId == lngSkillVId 
);
if (arrzx_SkillVerObjLst_Sel.Count() == 0)
{
   clszx_SkillVerEN obj = clszx_SkillVerBL.GetObjBySkillVId(lngSkillVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_SkillVerObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngSkillVId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetzxLevelIdBySkillVIdCache(long lngSkillVId)
{
//获取缓存中的对象列表
clszx_SkillVerEN objzx_SkillVer = GetObjBySkillVIdCache(lngSkillVId);
if (objzx_SkillVer == null) return "";
return objzx_SkillVer.zxLevelId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngSkillVId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySkillVIdCache(long lngSkillVId)
{
//获取缓存中的对象列表
clszx_SkillVerEN objzx_SkillVer = GetObjBySkillVIdCache(lngSkillVId);
if (objzx_SkillVer == null) return "";
return objzx_SkillVer.zxLevelId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SkillVerEN> GetAllzx_SkillVerObjLstCache()
{
//获取缓存中的对象列表
List<clszx_SkillVerEN> arrzx_SkillVerObjLstCache = GetObjLstCache(); 
return arrzx_SkillVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SkillVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_SkillVerEN._CurrTabName);
List<clszx_SkillVerEN> arrzx_SkillVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_SkillVerObjLstCache;
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
string strKey = string.Format("{0}", clszx_SkillVerEN._CurrTabName);
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
if (clszx_SkillVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_SkillVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_SkillVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_SkillVer(技能历史版本)
 /// 唯一性条件:zxSkillId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SkillVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_SkillVerEN objzx_SkillVerEN)
{
//检测记录是否存在
string strResult = zx_SkillVerDA.GetUniCondStr(objzx_SkillVerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngSkillVId)
{
if (strInFldName != conzx_SkillVer.SkillVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_SkillVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_SkillVer.AttributeName));
throw new Exception(strMsg);
}
var objzx_SkillVer = clszx_SkillVerBL.GetObjBySkillVIdCache(lngSkillVId);
if (objzx_SkillVer == null) return "";
return objzx_SkillVer[strOutFldName].ToString();
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
int intRecCount = clszx_SkillVerDA.GetRecCount(strTabName);
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
int intRecCount = clszx_SkillVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_SkillVerDA.GetRecCount();
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
int intRecCount = clszx_SkillVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_SkillVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_SkillVerEN objzx_SkillVerCond)
{
List<clszx_SkillVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SkillVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SkillVer.AttributeName)
{
if (objzx_SkillVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_SkillVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SkillVerCond[strFldName].ToString());
}
else
{
if (objzx_SkillVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SkillVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SkillVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SkillVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SkillVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SkillVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SkillVerCond[strFldName]));
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
 List<string> arrList = clszx_SkillVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_SkillVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_SkillVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_SkillVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SkillVerDA.SetFldValue(clszx_SkillVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_SkillVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SkillVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SkillVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SkillVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_SkillVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**SkillVId*/ 
 strCreateTabCode.Append(" SkillVId bigint primary key identity, "); 
 // /**技能Id*/ 
 strCreateTabCode.Append(" zxSkillId char(10) not Null, "); 
 // /**技能名称*/ 
 strCreateTabCode.Append(" SkillName varchar(200) Null, "); 
 // /**操作类型ID*/ 
 strCreateTabCode.Append(" zxOperationTypeId char(2) Null, "); 
 // /**实施过程*/ 
 strCreateTabCode.Append(" Process text Null, "); 
 // /**级别Id*/ 
 strCreateTabCode.Append(" zxLevelId char(2) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
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
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
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
 /// 技能历史版本(zx_SkillVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_SkillVer : clsCommFun4BL
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
clszx_SkillVerBL.ReFreshThisCache();
}
}

}