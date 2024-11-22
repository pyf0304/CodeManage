
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_KnowledgeModulesBL
 表名:cc_KnowledgeModules(01120959)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clscc_KnowledgeModulesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strKnowledgeModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_KnowledgeModulesEN GetObj(this K_KnowledgeModuleId_cc_KnowledgeModules myKey)
{
clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.GetObjByKnowledgeModuleId(myKey.Value);
return objcc_KnowledgeModulesEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_KnowledgeModulesEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点模块名称 = [{1}]的数据已经存在!(in clscc_KnowledgeModulesBL.AddNewRecord)", objcc_KnowledgeModulesEN.CourseId,objcc_KnowledgeModulesEN.KnowledgeModuleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true || clscc_KnowledgeModulesBL.IsExist(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true)
 {
     objcc_KnowledgeModulesEN.KnowledgeModuleId = clscc_KnowledgeModulesBL.GetMaxStrId_S();
 }
bool bolResult = clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.AddNewRecordBySQL2(objcc_KnowledgeModulesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
public static bool AddRecordEx(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscc_KnowledgeModulesBL.IsExist(objcc_KnowledgeModulesEN.KnowledgeModuleId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcc_KnowledgeModulesEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_KnowledgeModulesEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课程Id(CourseId)=[{0}],知识点模块名称(KnowledgeModuleName)=[{1}])已经存在,不能重复!", objcc_KnowledgeModulesEN.CourseId, objcc_KnowledgeModulesEN.KnowledgeModuleName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true || clscc_KnowledgeModulesBL.IsExist(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true)
 {
     objcc_KnowledgeModulesEN.KnowledgeModuleId = clscc_KnowledgeModulesBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcc_KnowledgeModulesEN.AddNewRecord();
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
 /// <param name = "objcc_KnowledgeModulesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_KnowledgeModulesEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点模块名称 = [{1}]的数据已经存在!(in clscc_KnowledgeModulesBL.AddNewRecordWithMaxId)", objcc_KnowledgeModulesEN.CourseId,objcc_KnowledgeModulesEN.KnowledgeModuleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true || clscc_KnowledgeModulesBL.IsExist(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true)
 {
     objcc_KnowledgeModulesEN.KnowledgeModuleId = clscc_KnowledgeModulesBL.GetMaxStrId_S();
 }
string strKnowledgeModuleId = clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.AddNewRecordBySQL2WithReturnKey(objcc_KnowledgeModulesEN);
     objcc_KnowledgeModulesEN.KnowledgeModuleId = strKnowledgeModuleId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
}
return strKnowledgeModuleId;
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
 /// <param name = "objcc_KnowledgeModulesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_KnowledgeModulesEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点模块名称 = [{1}]的数据已经存在!(in clscc_KnowledgeModulesBL.AddNewRecordWithReturnKey)", objcc_KnowledgeModulesEN.CourseId,objcc_KnowledgeModulesEN.KnowledgeModuleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true || clscc_KnowledgeModulesBL.IsExist(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true)
 {
     objcc_KnowledgeModulesEN.KnowledgeModuleId = clscc_KnowledgeModulesBL.GetMaxStrId_S();
 }
string strKey = clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.AddNewRecordBySQL2WithReturnKey(objcc_KnowledgeModulesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "objcc_KnowledgeModulesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeModulesEN SetKnowledgeModuleId(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, string strKnowledgeModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeModuleId, 8, concc_KnowledgeModules.KnowledgeModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeModuleId, 8, concc_KnowledgeModules.KnowledgeModuleId);
}
objcc_KnowledgeModulesEN.KnowledgeModuleId = strKnowledgeModuleId; //知识点模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeModulesEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeModules.KnowledgeModuleId) == false)
{
objcc_KnowledgeModulesEN.dicFldComparisonOp.Add(concc_KnowledgeModules.KnowledgeModuleId, strComparisonOp);
}
else
{
objcc_KnowledgeModulesEN.dicFldComparisonOp[concc_KnowledgeModules.KnowledgeModuleId] = strComparisonOp;
}
}
return objcc_KnowledgeModulesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeModulesEN SetKnowledgeModuleName(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, string strKnowledgeModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeModuleName, concc_KnowledgeModules.KnowledgeModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeModuleName, 100, concc_KnowledgeModules.KnowledgeModuleName);
}
objcc_KnowledgeModulesEN.KnowledgeModuleName = strKnowledgeModuleName; //知识点模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeModulesEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeModules.KnowledgeModuleName) == false)
{
objcc_KnowledgeModulesEN.dicFldComparisonOp.Add(concc_KnowledgeModules.KnowledgeModuleName, strComparisonOp);
}
else
{
objcc_KnowledgeModulesEN.dicFldComparisonOp[concc_KnowledgeModules.KnowledgeModuleName] = strComparisonOp;
}
}
return objcc_KnowledgeModulesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeModulesEN SetKnowledgeModuleContent(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, string strKnowledgeModuleContent, string strComparisonOp="")
	{
objcc_KnowledgeModulesEN.KnowledgeModuleContent = strKnowledgeModuleContent; //知识点模块内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeModulesEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeModules.KnowledgeModuleContent) == false)
{
objcc_KnowledgeModulesEN.dicFldComparisonOp.Add(concc_KnowledgeModules.KnowledgeModuleContent, strComparisonOp);
}
else
{
objcc_KnowledgeModulesEN.dicFldComparisonOp[concc_KnowledgeModules.KnowledgeModuleContent] = strComparisonOp;
}
}
return objcc_KnowledgeModulesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeModulesEN SetCourseId(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_KnowledgeModules.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_KnowledgeModules.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_KnowledgeModules.CourseId);
}
objcc_KnowledgeModulesEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeModulesEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeModules.CourseId) == false)
{
objcc_KnowledgeModulesEN.dicFldComparisonOp.Add(concc_KnowledgeModules.CourseId, strComparisonOp);
}
else
{
objcc_KnowledgeModulesEN.dicFldComparisonOp[concc_KnowledgeModules.CourseId] = strComparisonOp;
}
}
return objcc_KnowledgeModulesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeModulesEN SetOrderNum(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, int? intOrderNum, string strComparisonOp="")
	{
objcc_KnowledgeModulesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeModulesEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeModules.OrderNum) == false)
{
objcc_KnowledgeModulesEN.dicFldComparisonOp.Add(concc_KnowledgeModules.OrderNum, strComparisonOp);
}
else
{
objcc_KnowledgeModulesEN.dicFldComparisonOp[concc_KnowledgeModules.OrderNum] = strComparisonOp;
}
}
return objcc_KnowledgeModulesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeModulesEN SetUpdDate(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_KnowledgeModules.UpdDate);
}
objcc_KnowledgeModulesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeModulesEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeModules.UpdDate) == false)
{
objcc_KnowledgeModulesEN.dicFldComparisonOp.Add(concc_KnowledgeModules.UpdDate, strComparisonOp);
}
else
{
objcc_KnowledgeModulesEN.dicFldComparisonOp[concc_KnowledgeModules.UpdDate] = strComparisonOp;
}
}
return objcc_KnowledgeModulesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeModulesEN SetUpdUser(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_KnowledgeModules.UpdUser);
}
objcc_KnowledgeModulesEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeModulesEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeModules.UpdUser) == false)
{
objcc_KnowledgeModulesEN.dicFldComparisonOp.Add(concc_KnowledgeModules.UpdUser, strComparisonOp);
}
else
{
objcc_KnowledgeModulesEN.dicFldComparisonOp[concc_KnowledgeModules.UpdUser] = strComparisonOp;
}
}
return objcc_KnowledgeModulesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeModulesEN SetMemo(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_KnowledgeModules.Memo);
}
objcc_KnowledgeModulesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeModulesEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeModules.Memo) == false)
{
objcc_KnowledgeModulesEN.dicFldComparisonOp.Add(concc_KnowledgeModules.Memo, strComparisonOp);
}
else
{
objcc_KnowledgeModulesEN.dicFldComparisonOp[concc_KnowledgeModules.Memo] = strComparisonOp;
}
}
return objcc_KnowledgeModulesEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_KnowledgeModulesEN.CheckPropertyNew();
clscc_KnowledgeModulesEN objcc_KnowledgeModulesCond = new clscc_KnowledgeModulesEN();
string strCondition = objcc_KnowledgeModulesCond
.SetKnowledgeModuleId(objcc_KnowledgeModulesEN.KnowledgeModuleId, "<>")
.SetCourseId(objcc_KnowledgeModulesEN.CourseId, "=")
.SetKnowledgeModuleName(objcc_KnowledgeModulesEN.KnowledgeModuleName, "=")
.GetCombineCondition();
objcc_KnowledgeModulesEN._IsCheckProperty = true;
bool bolIsExist = clscc_KnowledgeModulesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(AA)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_KnowledgeModulesEN.Update();
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
 /// <param name = "objcc_KnowledgeModules">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_KnowledgeModulesEN objcc_KnowledgeModules)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_KnowledgeModulesEN objcc_KnowledgeModulesCond = new clscc_KnowledgeModulesEN();
string strCondition = objcc_KnowledgeModulesCond
.SetCourseId(objcc_KnowledgeModules.CourseId, "=")
.SetKnowledgeModuleName(objcc_KnowledgeModules.KnowledgeModuleName, "=")
.GetCombineCondition();
objcc_KnowledgeModules._IsCheckProperty = true;
bool bolIsExist = clscc_KnowledgeModulesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_KnowledgeModules.KnowledgeModuleId = clscc_KnowledgeModulesBL.GetFirstID_S(strCondition);
objcc_KnowledgeModules.UpdateWithCondition(strCondition);
}
else
{
objcc_KnowledgeModules.KnowledgeModuleId = clscc_KnowledgeModulesBL.GetMaxStrId_S();
objcc_KnowledgeModules.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
 if (string.IsNullOrEmpty(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.UpdateBySql2(objcc_KnowledgeModulesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "objcc_KnowledgeModulesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.UpdateBySql2(objcc_KnowledgeModulesEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "objcc_KnowledgeModulesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, string strWhereCond)
{
try
{
bool bolResult = clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.UpdateBySqlWithCondition(objcc_KnowledgeModulesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "objcc_KnowledgeModulesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.UpdateBySqlWithConditionTransaction(objcc_KnowledgeModulesEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "strKnowledgeModuleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
try
{
int intRecNum = clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.DelRecord(objcc_KnowledgeModulesEN.KnowledgeModuleId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "objcc_KnowledgeModulesENS">源对象</param>
 /// <param name = "objcc_KnowledgeModulesENT">目标对象</param>
 public static void CopyTo(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesENS, clscc_KnowledgeModulesEN objcc_KnowledgeModulesENT)
{
try
{
objcc_KnowledgeModulesENT.KnowledgeModuleId = objcc_KnowledgeModulesENS.KnowledgeModuleId; //知识点模块Id
objcc_KnowledgeModulesENT.KnowledgeModuleName = objcc_KnowledgeModulesENS.KnowledgeModuleName; //知识点模块名称
objcc_KnowledgeModulesENT.KnowledgeModuleContent = objcc_KnowledgeModulesENS.KnowledgeModuleContent; //知识点模块内容
objcc_KnowledgeModulesENT.CourseId = objcc_KnowledgeModulesENS.CourseId; //课程Id
objcc_KnowledgeModulesENT.OrderNum = objcc_KnowledgeModulesENS.OrderNum; //序号
objcc_KnowledgeModulesENT.UpdDate = objcc_KnowledgeModulesENS.UpdDate; //修改日期
objcc_KnowledgeModulesENT.UpdUser = objcc_KnowledgeModulesENS.UpdUser; //修改人
objcc_KnowledgeModulesENT.Memo = objcc_KnowledgeModulesENS.Memo; //备注
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
 /// <param name = "objcc_KnowledgeModulesENS">源对象</param>
 /// <returns>目标对象=>clscc_KnowledgeModulesEN:objcc_KnowledgeModulesENT</returns>
 public static clscc_KnowledgeModulesEN CopyTo(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesENS)
{
try
{
 clscc_KnowledgeModulesEN objcc_KnowledgeModulesENT = new clscc_KnowledgeModulesEN()
{
KnowledgeModuleId = objcc_KnowledgeModulesENS.KnowledgeModuleId, //知识点模块Id
KnowledgeModuleName = objcc_KnowledgeModulesENS.KnowledgeModuleName, //知识点模块名称
KnowledgeModuleContent = objcc_KnowledgeModulesENS.KnowledgeModuleContent, //知识点模块内容
CourseId = objcc_KnowledgeModulesENS.CourseId, //课程Id
OrderNum = objcc_KnowledgeModulesENS.OrderNum, //序号
UpdDate = objcc_KnowledgeModulesENS.UpdDate, //修改日期
UpdUser = objcc_KnowledgeModulesENS.UpdUser, //修改人
Memo = objcc_KnowledgeModulesENS.Memo, //备注
};
 return objcc_KnowledgeModulesENT;
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
public static void CheckPropertyNew(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
 clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.CheckPropertyNew(objcc_KnowledgeModulesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
 clscc_KnowledgeModulesBL.cc_KnowledgeModulesDA.CheckProperty4Condition(objcc_KnowledgeModulesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_KnowledgeModulesCond.IsUpdated(concc_KnowledgeModules.KnowledgeModuleId) == true)
{
string strComparisonOpKnowledgeModuleId = objcc_KnowledgeModulesCond.dicFldComparisonOp[concc_KnowledgeModules.KnowledgeModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeModules.KnowledgeModuleId, objcc_KnowledgeModulesCond.KnowledgeModuleId, strComparisonOpKnowledgeModuleId);
}
if (objcc_KnowledgeModulesCond.IsUpdated(concc_KnowledgeModules.KnowledgeModuleName) == true)
{
string strComparisonOpKnowledgeModuleName = objcc_KnowledgeModulesCond.dicFldComparisonOp[concc_KnowledgeModules.KnowledgeModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeModules.KnowledgeModuleName, objcc_KnowledgeModulesCond.KnowledgeModuleName, strComparisonOpKnowledgeModuleName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_KnowledgeModulesCond.IsUpdated(concc_KnowledgeModules.CourseId) == true)
{
string strComparisonOpCourseId = objcc_KnowledgeModulesCond.dicFldComparisonOp[concc_KnowledgeModules.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeModules.CourseId, objcc_KnowledgeModulesCond.CourseId, strComparisonOpCourseId);
}
if (objcc_KnowledgeModulesCond.IsUpdated(concc_KnowledgeModules.OrderNum) == true)
{
string strComparisonOpOrderNum = objcc_KnowledgeModulesCond.dicFldComparisonOp[concc_KnowledgeModules.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_KnowledgeModules.OrderNum, objcc_KnowledgeModulesCond.OrderNum, strComparisonOpOrderNum);
}
if (objcc_KnowledgeModulesCond.IsUpdated(concc_KnowledgeModules.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_KnowledgeModulesCond.dicFldComparisonOp[concc_KnowledgeModules.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeModules.UpdDate, objcc_KnowledgeModulesCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_KnowledgeModulesCond.IsUpdated(concc_KnowledgeModules.UpdUser) == true)
{
string strComparisonOpUpdUser = objcc_KnowledgeModulesCond.dicFldComparisonOp[concc_KnowledgeModules.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeModules.UpdUser, objcc_KnowledgeModulesCond.UpdUser, strComparisonOpUpdUser);
}
if (objcc_KnowledgeModulesCond.IsUpdated(concc_KnowledgeModules.Memo) == true)
{
string strComparisonOpMemo = objcc_KnowledgeModulesCond.dicFldComparisonOp[concc_KnowledgeModules.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeModules.Memo, objcc_KnowledgeModulesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_KnowledgeModules(知识点模块), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseId_KnowledgeModuleName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_KnowledgeModulesEN == null) return true;
if (objcc_KnowledgeModulesEN.KnowledgeModuleId == null || objcc_KnowledgeModulesEN.KnowledgeModuleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_KnowledgeModulesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeModuleName = '{0}'", objcc_KnowledgeModulesEN.KnowledgeModuleName);
if (clscc_KnowledgeModulesBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("KnowledgeModuleId !=  '{0}'", objcc_KnowledgeModulesEN.KnowledgeModuleId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_KnowledgeModulesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeModuleName = '{0}'", objcc_KnowledgeModulesEN.KnowledgeModuleName);
if (clscc_KnowledgeModulesBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_KnowledgeModules(知识点模块), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseId_KnowledgeModuleName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_KnowledgeModulesEN == null) return "";
if (objcc_KnowledgeModulesEN.KnowledgeModuleId == null || objcc_KnowledgeModulesEN.KnowledgeModuleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_KnowledgeModulesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeModuleName = '{0}'", objcc_KnowledgeModulesEN.KnowledgeModuleName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("KnowledgeModuleId !=  '{0}'", objcc_KnowledgeModulesEN.KnowledgeModuleId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_KnowledgeModulesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeModuleName = '{0}'", objcc_KnowledgeModulesEN.KnowledgeModuleName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_KnowledgeModules
{
public virtual bool UpdRelaTabDate(string strKnowledgeModuleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点模块(cc_KnowledgeModules)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_KnowledgeModulesBL
{
public static RelatedActions_cc_KnowledgeModules relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_KnowledgeModulesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_KnowledgeModulesDA cc_KnowledgeModulesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_KnowledgeModulesDA();
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
 public clscc_KnowledgeModulesBL()
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
if (string.IsNullOrEmpty(clscc_KnowledgeModulesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_KnowledgeModulesEN._ConnectString);
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
public static DataTable GetDataTable_cc_KnowledgeModules(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_KnowledgeModulesDA.GetDataTable_cc_KnowledgeModules(strWhereCond);
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
objDT = cc_KnowledgeModulesDA.GetDataTable(strWhereCond);
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
objDT = cc_KnowledgeModulesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_KnowledgeModulesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_KnowledgeModulesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_KnowledgeModulesDA.GetDataTable_Top(objTopPara);
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
objDT = cc_KnowledgeModulesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_KnowledgeModulesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_KnowledgeModulesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrKnowledgeModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_KnowledgeModulesEN> GetObjLstByKnowledgeModuleIdLst(List<string> arrKnowledgeModuleIdLst)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrKnowledgeModuleIdLst, true);
 string strWhereCond = string.Format("KnowledgeModuleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKnowledgeModuleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_KnowledgeModulesEN> GetObjLstByKnowledgeModuleIdLstCache(List<string> arrKnowledgeModuleIdLst)
{
string strKey = string.Format("{0}", clscc_KnowledgeModulesEN._CurrTabName);
List<clscc_KnowledgeModulesEN> arrcc_KnowledgeModulesObjLstCache = GetObjLstCache();
IEnumerable <clscc_KnowledgeModulesEN> arrcc_KnowledgeModulesObjLst_Sel =
arrcc_KnowledgeModulesObjLstCache
.Where(x => arrKnowledgeModuleIdLst.Contains(x.KnowledgeModuleId));
return arrcc_KnowledgeModulesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_KnowledgeModulesEN> GetObjLst(string strWhereCond)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
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
public static List<clscc_KnowledgeModulesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_KnowledgeModulesEN> GetSubObjLstCache(clscc_KnowledgeModulesEN objcc_KnowledgeModulesCond)
{
List<clscc_KnowledgeModulesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_KnowledgeModulesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_KnowledgeModules.AttributeName)
{
if (objcc_KnowledgeModulesCond.IsUpdated(strFldName) == false) continue;
if (objcc_KnowledgeModulesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_KnowledgeModulesCond[strFldName].ToString());
}
else
{
if (objcc_KnowledgeModulesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_KnowledgeModulesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_KnowledgeModulesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_KnowledgeModulesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_KnowledgeModulesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_KnowledgeModulesCond[strFldName]));
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
public static List<clscc_KnowledgeModulesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
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
public static List<clscc_KnowledgeModulesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
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
List<clscc_KnowledgeModulesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_KnowledgeModulesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_KnowledgeModulesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_KnowledgeModulesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
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
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
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
public static List<clscc_KnowledgeModulesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_KnowledgeModulesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_KnowledgeModulesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
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
public static List<clscc_KnowledgeModulesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_KnowledgeModulesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_KnowledgeModulesEN> arrObjLst = new List<clscc_KnowledgeModulesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = new clscc_KnowledgeModulesEN();
try
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objRow[concc_KnowledgeModules.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_KnowledgeModulesEN.KnowledgeModuleName = objRow[concc_KnowledgeModules.KnowledgeModuleName].ToString().Trim(); //知识点模块名称
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objRow[concc_KnowledgeModules.KnowledgeModuleContent] == DBNull.Value ? null : objRow[concc_KnowledgeModules.KnowledgeModuleContent].ToString().Trim(); //知识点模块内容
objcc_KnowledgeModulesEN.CourseId = objRow[concc_KnowledgeModules.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeModulesEN.OrderNum = objRow[concc_KnowledgeModules.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_KnowledgeModules.OrderNum].ToString().Trim()); //序号
objcc_KnowledgeModulesEN.UpdDate = objRow[concc_KnowledgeModules.UpdDate] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeModulesEN.UpdUser = objRow[concc_KnowledgeModules.UpdUser] == DBNull.Value ? null : objRow[concc_KnowledgeModules.UpdUser].ToString().Trim(); //修改人
objcc_KnowledgeModulesEN.Memo = objRow[concc_KnowledgeModules.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeModules.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeModulesEN.KnowledgeModuleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeModulesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_KnowledgeModules(ref clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
bool bolResult = cc_KnowledgeModulesDA.Getcc_KnowledgeModules(ref objcc_KnowledgeModulesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strKnowledgeModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_KnowledgeModulesEN GetObjByKnowledgeModuleId(string strKnowledgeModuleId)
{
if (strKnowledgeModuleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strKnowledgeModuleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strKnowledgeModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strKnowledgeModuleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = cc_KnowledgeModulesDA.GetObjByKnowledgeModuleId(strKnowledgeModuleId);
return objcc_KnowledgeModulesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_KnowledgeModulesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = cc_KnowledgeModulesDA.GetFirstObj(strWhereCond);
 return objcc_KnowledgeModulesEN;
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
public static clscc_KnowledgeModulesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = cc_KnowledgeModulesDA.GetObjByDataRow(objRow);
 return objcc_KnowledgeModulesEN;
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
public static clscc_KnowledgeModulesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = cc_KnowledgeModulesDA.GetObjByDataRow(objRow);
 return objcc_KnowledgeModulesEN;
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
 /// <param name = "strKnowledgeModuleId">所给的关键字</param>
 /// <param name = "lstcc_KnowledgeModulesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_KnowledgeModulesEN GetObjByKnowledgeModuleIdFromList(string strKnowledgeModuleId, List<clscc_KnowledgeModulesEN> lstcc_KnowledgeModulesObjLst)
{
foreach (clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN in lstcc_KnowledgeModulesObjLst)
{
if (objcc_KnowledgeModulesEN.KnowledgeModuleId == strKnowledgeModuleId)
{
return objcc_KnowledgeModulesEN;
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
 string strMaxKnowledgeModuleId;
 try
 {
 strMaxKnowledgeModuleId = clscc_KnowledgeModulesDA.GetMaxStrId();
 return strMaxKnowledgeModuleId;
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
 string strKnowledgeModuleId;
 try
 {
 strKnowledgeModuleId = new clscc_KnowledgeModulesDA().GetFirstID(strWhereCond);
 return strKnowledgeModuleId;
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
 arrList = cc_KnowledgeModulesDA.GetID(strWhereCond);
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
bool bolIsExist = cc_KnowledgeModulesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strKnowledgeModuleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strKnowledgeModuleId)
{
if (string.IsNullOrEmpty(strKnowledgeModuleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strKnowledgeModuleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_KnowledgeModulesDA.IsExist(strKnowledgeModuleId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strKnowledgeModuleId">知识点模块Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strKnowledgeModuleId, string strOpUser)
{
clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = clscc_KnowledgeModulesBL.GetObjByKnowledgeModuleId(strKnowledgeModuleId);
objcc_KnowledgeModulesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_KnowledgeModulesEN.UpdUser = strOpUser;
return clscc_KnowledgeModulesBL.UpdateBySql2(objcc_KnowledgeModulesEN);
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
 bolIsExist = clscc_KnowledgeModulesDA.IsExistTable();
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
 bolIsExist = cc_KnowledgeModulesDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_KnowledgeModulesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_KnowledgeModulesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点模块名称 = [{1}]的数据已经存在!(in clscc_KnowledgeModulesBL.AddNewRecordBySql2)", objcc_KnowledgeModulesEN.CourseId,objcc_KnowledgeModulesEN.KnowledgeModuleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true || clscc_KnowledgeModulesBL.IsExist(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true)
 {
     objcc_KnowledgeModulesEN.KnowledgeModuleId = clscc_KnowledgeModulesBL.GetMaxStrId_S();
 }
bool bolResult = cc_KnowledgeModulesDA.AddNewRecordBySQL2(objcc_KnowledgeModulesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "objcc_KnowledgeModulesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_KnowledgeModulesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点模块名称 = [{1}]的数据已经存在!(in clscc_KnowledgeModulesBL.AddNewRecordBySql2WithReturnKey)", objcc_KnowledgeModulesEN.CourseId,objcc_KnowledgeModulesEN.KnowledgeModuleName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true || clscc_KnowledgeModulesBL.IsExist(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true)
 {
     objcc_KnowledgeModulesEN.KnowledgeModuleId = clscc_KnowledgeModulesBL.GetMaxStrId_S();
 }
string strKey = cc_KnowledgeModulesDA.AddNewRecordBySQL2WithReturnKey(objcc_KnowledgeModulesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "objcc_KnowledgeModulesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
try
{
bool bolResult = cc_KnowledgeModulesDA.Update(objcc_KnowledgeModulesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "objcc_KnowledgeModulesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
 if (string.IsNullOrEmpty(objcc_KnowledgeModulesEN.KnowledgeModuleId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_KnowledgeModulesDA.UpdateBySql2(objcc_KnowledgeModulesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeModulesBL.ReFreshCache();

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
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
 /// <param name = "strKnowledgeModuleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strKnowledgeModuleId)
{
try
{
 clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN = clscc_KnowledgeModulesBL.GetObjByKnowledgeModuleId(strKnowledgeModuleId);

if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeModulesEN.KnowledgeModuleId, objcc_KnowledgeModulesEN.UpdUser);
}
if (objcc_KnowledgeModulesEN != null)
{
int intRecNum = cc_KnowledgeModulesDA.DelRecord(strKnowledgeModuleId);
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
/// <param name="strKnowledgeModuleId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strKnowledgeModuleId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_KnowledgeModulesDA.GetSpecSQLObj();
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
//删除与表:[cc_KnowledgeModules]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_KnowledgeModules.KnowledgeModuleId,
//strKnowledgeModuleId);
//        clscc_KnowledgeModulesBL.Delcc_KnowledgeModulessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_KnowledgeModulesBL.DelRecord(strKnowledgeModuleId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_KnowledgeModulesBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKnowledgeModuleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strKnowledgeModuleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strKnowledgeModuleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_KnowledgeModulesBL.relatedActions != null)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(strKnowledgeModuleId, "UpdRelaTabDate");
}
bool bolResult = cc_KnowledgeModulesDA.DelRecord(strKnowledgeModuleId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrKnowledgeModuleIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_KnowledgeModuless(List<string> arrKnowledgeModuleIdLst)
{
if (arrKnowledgeModuleIdLst.Count == 0) return 0;
try
{
if (clscc_KnowledgeModulesBL.relatedActions != null)
{
foreach (var strKnowledgeModuleId in arrKnowledgeModuleIdLst)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(strKnowledgeModuleId, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_KnowledgeModulesDA.Delcc_KnowledgeModules(arrKnowledgeModuleIdLst);
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
public static int Delcc_KnowledgeModulessByCond(string strWhereCond)
{
try
{
if (clscc_KnowledgeModulesBL.relatedActions != null)
{
List<string> arrKnowledgeModuleId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strKnowledgeModuleId in arrKnowledgeModuleId)
{
clscc_KnowledgeModulesBL.relatedActions.UpdRelaTabDate(strKnowledgeModuleId, "UpdRelaTabDate");
}
}
int intRecNum = cc_KnowledgeModulesDA.Delcc_KnowledgeModules(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_KnowledgeModules]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strKnowledgeModuleId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strKnowledgeModuleId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_KnowledgeModulesDA.GetSpecSQLObj();
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
//删除与表:[cc_KnowledgeModules]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_KnowledgeModulesBL.DelRecord(strKnowledgeModuleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_KnowledgeModulesBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKnowledgeModuleId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_KnowledgeModulesENS">源对象</param>
 /// <param name = "objcc_KnowledgeModulesENT">目标对象</param>
 public static void CopyTo(clscc_KnowledgeModulesEN objcc_KnowledgeModulesENS, clscc_KnowledgeModulesEN objcc_KnowledgeModulesENT)
{
try
{
objcc_KnowledgeModulesENT.KnowledgeModuleId = objcc_KnowledgeModulesENS.KnowledgeModuleId; //知识点模块Id
objcc_KnowledgeModulesENT.KnowledgeModuleName = objcc_KnowledgeModulesENS.KnowledgeModuleName; //知识点模块名称
objcc_KnowledgeModulesENT.KnowledgeModuleContent = objcc_KnowledgeModulesENS.KnowledgeModuleContent; //知识点模块内容
objcc_KnowledgeModulesENT.CourseId = objcc_KnowledgeModulesENS.CourseId; //课程Id
objcc_KnowledgeModulesENT.OrderNum = objcc_KnowledgeModulesENS.OrderNum; //序号
objcc_KnowledgeModulesENT.UpdDate = objcc_KnowledgeModulesENS.UpdDate; //修改日期
objcc_KnowledgeModulesENT.UpdUser = objcc_KnowledgeModulesENS.UpdUser; //修改人
objcc_KnowledgeModulesENT.Memo = objcc_KnowledgeModulesENS.Memo; //备注
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
 /// <param name = "objcc_KnowledgeModulesEN">源简化对象</param>
 public static void SetUpdFlag(clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
try
{
objcc_KnowledgeModulesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_KnowledgeModulesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_KnowledgeModules.KnowledgeModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeModulesEN.KnowledgeModuleId = objcc_KnowledgeModulesEN.KnowledgeModuleId; //知识点模块Id
}
if (arrFldSet.Contains(concc_KnowledgeModules.KnowledgeModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeModulesEN.KnowledgeModuleName = objcc_KnowledgeModulesEN.KnowledgeModuleName; //知识点模块名称
}
if (arrFldSet.Contains(concc_KnowledgeModules.KnowledgeModuleContent, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeModulesEN.KnowledgeModuleContent = objcc_KnowledgeModulesEN.KnowledgeModuleContent == "[null]" ? null :  objcc_KnowledgeModulesEN.KnowledgeModuleContent; //知识点模块内容
}
if (arrFldSet.Contains(concc_KnowledgeModules.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeModulesEN.CourseId = objcc_KnowledgeModulesEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_KnowledgeModules.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeModulesEN.OrderNum = objcc_KnowledgeModulesEN.OrderNum; //序号
}
if (arrFldSet.Contains(concc_KnowledgeModules.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeModulesEN.UpdDate = objcc_KnowledgeModulesEN.UpdDate == "[null]" ? null :  objcc_KnowledgeModulesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_KnowledgeModules.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeModulesEN.UpdUser = objcc_KnowledgeModulesEN.UpdUser == "[null]" ? null :  objcc_KnowledgeModulesEN.UpdUser; //修改人
}
if (arrFldSet.Contains(concc_KnowledgeModules.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeModulesEN.Memo = objcc_KnowledgeModulesEN.Memo == "[null]" ? null :  objcc_KnowledgeModulesEN.Memo; //备注
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
 /// <param name = "objcc_KnowledgeModulesEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
try
{
if (objcc_KnowledgeModulesEN.KnowledgeModuleContent == "[null]") objcc_KnowledgeModulesEN.KnowledgeModuleContent = null; //知识点模块内容
if (objcc_KnowledgeModulesEN.UpdDate == "[null]") objcc_KnowledgeModulesEN.UpdDate = null; //修改日期
if (objcc_KnowledgeModulesEN.UpdUser == "[null]") objcc_KnowledgeModulesEN.UpdUser = null; //修改人
if (objcc_KnowledgeModulesEN.Memo == "[null]") objcc_KnowledgeModulesEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
 cc_KnowledgeModulesDA.CheckPropertyNew(objcc_KnowledgeModulesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
 cc_KnowledgeModulesDA.CheckProperty4Condition(objcc_KnowledgeModulesEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_KnowledgeModuleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识点模块]...","0");
List<clscc_KnowledgeModulesEN> arrcc_KnowledgeModulesObjLst = GetAllcc_KnowledgeModulesObjLstCache(); 
arrcc_KnowledgeModulesObjLst = arrcc_KnowledgeModulesObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = concc_KnowledgeModules.KnowledgeModuleId;
objDDL.DataTextField = concc_KnowledgeModules.KnowledgeModuleName;
objDDL.DataSource = arrcc_KnowledgeModulesObjLst;
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
if (clscc_KnowledgeModulesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_KnowledgeModulesBL没有刷新缓存机制(clscc_KnowledgeModulesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by KnowledgeModuleId");
//if (arrcc_KnowledgeModulesObjLstCache == null)
//{
//arrcc_KnowledgeModulesObjLstCache = cc_KnowledgeModulesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strKnowledgeModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_KnowledgeModulesEN GetObjByKnowledgeModuleIdCache(string strKnowledgeModuleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_KnowledgeModulesEN._CurrTabName);
List<clscc_KnowledgeModulesEN> arrcc_KnowledgeModulesObjLstCache = GetObjLstCache();
IEnumerable <clscc_KnowledgeModulesEN> arrcc_KnowledgeModulesObjLst_Sel =
arrcc_KnowledgeModulesObjLstCache
.Where(x=> x.KnowledgeModuleId == strKnowledgeModuleId 
);
if (arrcc_KnowledgeModulesObjLst_Sel.Count() == 0)
{
   clscc_KnowledgeModulesEN obj = clscc_KnowledgeModulesBL.GetObjByKnowledgeModuleId(strKnowledgeModuleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_KnowledgeModulesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKnowledgeModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetKnowledgeModuleNameByKnowledgeModuleIdCache(string strKnowledgeModuleId)
{
if (string.IsNullOrEmpty(strKnowledgeModuleId) == true) return "";
//获取缓存中的对象列表
clscc_KnowledgeModulesEN objcc_KnowledgeModules = GetObjByKnowledgeModuleIdCache(strKnowledgeModuleId);
if (objcc_KnowledgeModules == null) return "";
return objcc_KnowledgeModules.KnowledgeModuleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKnowledgeModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByKnowledgeModuleIdCache(string strKnowledgeModuleId)
{
if (string.IsNullOrEmpty(strKnowledgeModuleId) == true) return "";
//获取缓存中的对象列表
clscc_KnowledgeModulesEN objcc_KnowledgeModules = GetObjByKnowledgeModuleIdCache(strKnowledgeModuleId);
if (objcc_KnowledgeModules == null) return "";
return objcc_KnowledgeModules.KnowledgeModuleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_KnowledgeModulesEN> GetAllcc_KnowledgeModulesObjLstCache()
{
//获取缓存中的对象列表
List<clscc_KnowledgeModulesEN> arrcc_KnowledgeModulesObjLstCache = GetObjLstCache(); 
return arrcc_KnowledgeModulesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_KnowledgeModulesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_KnowledgeModulesEN._CurrTabName);
List<clscc_KnowledgeModulesEN> arrcc_KnowledgeModulesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_KnowledgeModulesObjLstCache;
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
string strKey = string.Format("{0}", clscc_KnowledgeModulesEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_KnowledgeModulesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_KnowledgeModulesEN._RefreshTimeLst.Count == 0) return "";
return clscc_KnowledgeModulesEN._RefreshTimeLst[clscc_KnowledgeModulesEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_KnowledgeModulesBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_KnowledgeModulesEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_KnowledgeModulesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_KnowledgeModulesBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_KnowledgeModules(知识点模块)
 /// 唯一性条件:CourseId_KnowledgeModuleName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_KnowledgeModulesEN objcc_KnowledgeModulesEN)
{
//检测记录是否存在
string strResult = cc_KnowledgeModulesDA.GetUniCondStr(objcc_KnowledgeModulesEN);
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
public static string Func(string strInFldName, string strOutFldName, string strKnowledgeModuleId)
{
if (strInFldName != concc_KnowledgeModules.KnowledgeModuleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_KnowledgeModules.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_KnowledgeModules.AttributeName));
throw new Exception(strMsg);
}
var objcc_KnowledgeModules = clscc_KnowledgeModulesBL.GetObjByKnowledgeModuleIdCache(strKnowledgeModuleId);
if (objcc_KnowledgeModules == null) return "";
return objcc_KnowledgeModules[strOutFldName].ToString();
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
int intRecCount = clscc_KnowledgeModulesDA.GetRecCount(strTabName);
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
int intRecCount = clscc_KnowledgeModulesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_KnowledgeModulesDA.GetRecCount();
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
int intRecCount = clscc_KnowledgeModulesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_KnowledgeModulesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_KnowledgeModulesEN objcc_KnowledgeModulesCond)
{
List<clscc_KnowledgeModulesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_KnowledgeModulesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_KnowledgeModules.AttributeName)
{
if (objcc_KnowledgeModulesCond.IsUpdated(strFldName) == false) continue;
if (objcc_KnowledgeModulesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_KnowledgeModulesCond[strFldName].ToString());
}
else
{
if (objcc_KnowledgeModulesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_KnowledgeModulesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_KnowledgeModulesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_KnowledgeModulesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_KnowledgeModulesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_KnowledgeModulesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_KnowledgeModulesCond[strFldName]));
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
 List<string> arrList = clscc_KnowledgeModulesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_KnowledgeModulesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_KnowledgeModulesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_KnowledgeModulesDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_KnowledgeModulesDA.SetFldValue(clscc_KnowledgeModulesEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_KnowledgeModulesDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_KnowledgeModulesDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_KnowledgeModulesDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_KnowledgeModulesDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_KnowledgeModules] "); 
 strCreateTabCode.Append(" ( "); 
 // /**知识点模块Id*/ 
 strCreateTabCode.Append(" KnowledgeModuleId char(8) primary key, "); 
 // /**知识点模块名称*/ 
 strCreateTabCode.Append(" KnowledgeModuleName varchar(100) not Null, "); 
 // /**知识点模块内容*/ 
 strCreateTabCode.Append(" KnowledgeModuleContent text Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**题目数*/ 
 strCreateTabCode.Append(" QuestionNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 知识点模块(cc_KnowledgeModules)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_KnowledgeModules : clsCommFun4BL
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
clscc_KnowledgeModulesBL.ReFreshThisCache();
}
}

}