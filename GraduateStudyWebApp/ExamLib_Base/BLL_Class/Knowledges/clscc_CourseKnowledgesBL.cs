
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseKnowledgesBL
 表名:cc_CourseKnowledges(01120082)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:52
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
public static class  clscc_CourseKnowledgesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseKnowledgesEN GetObj(this K_CourseKnowledgeId_cc_CourseKnowledges myKey)
{
clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.GetObjByCourseKnowledgeId(myKey.Value);
return objcc_CourseKnowledgesEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseKnowledgesEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点名称 = [{1}]的数据已经存在!(in clscc_CourseKnowledgesBL.AddNewRecord)", objcc_CourseKnowledgesEN.CourseId,objcc_CourseKnowledgesEN.KnowledgeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true || clscc_CourseKnowledgesBL.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
     objcc_CourseKnowledgesEN.CourseKnowledgeId = clscc_CourseKnowledgesBL.GetMaxStrId_S();
 }
bool bolResult = clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.AddNewRecordBySQL2(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
public static bool AddRecordEx(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscc_CourseKnowledgesBL.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcc_CourseKnowledgesEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_CourseKnowledgesEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课程Id(CourseId)=[{0}],知识点名称(KnowledgeName)=[{1}])已经存在,不能重复!", objcc_CourseKnowledgesEN.CourseId, objcc_CourseKnowledgesEN.KnowledgeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true || clscc_CourseKnowledgesBL.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
     objcc_CourseKnowledgesEN.CourseKnowledgeId = clscc_CourseKnowledgesBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcc_CourseKnowledgesEN.AddNewRecord();
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseKnowledgesEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点名称 = [{1}]的数据已经存在!(in clscc_CourseKnowledgesBL.AddNewRecordWithMaxId)", objcc_CourseKnowledgesEN.CourseId,objcc_CourseKnowledgesEN.KnowledgeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true || clscc_CourseKnowledgesBL.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
     objcc_CourseKnowledgesEN.CourseKnowledgeId = clscc_CourseKnowledgesBL.GetMaxStrId_S();
 }
string strCourseKnowledgeId = clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseKnowledgesEN);
     objcc_CourseKnowledgesEN.CourseKnowledgeId = strCourseKnowledgeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
}
return strCourseKnowledgeId;
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseKnowledgesEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点名称 = [{1}]的数据已经存在!(in clscc_CourseKnowledgesBL.AddNewRecordWithReturnKey)", objcc_CourseKnowledgesEN.CourseId,objcc_CourseKnowledgesEN.KnowledgeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true || clscc_CourseKnowledgesBL.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
     objcc_CourseKnowledgesEN.CourseKnowledgeId = clscc_CourseKnowledgesBL.GetMaxStrId_S();
 }
string strKey = clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetCourseKnowledgeId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, concc_CourseKnowledges.CourseKnowledgeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, concc_CourseKnowledges.CourseKnowledgeId);
}
objcc_CourseKnowledgesEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.CourseKnowledgeId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.CourseKnowledgeId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.CourseKnowledgeId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetKnowledgeName(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strKnowledgeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeName, concc_CourseKnowledges.KnowledgeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeName, 100, concc_CourseKnowledges.KnowledgeName);
}
objcc_CourseKnowledgesEN.KnowledgeName = strKnowledgeName; //知识点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.KnowledgeName) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.KnowledgeName, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeName] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetKnowledgeTitle(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strKnowledgeTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTitle, 100, concc_CourseKnowledges.KnowledgeTitle);
}
objcc_CourseKnowledgesEN.KnowledgeTitle = strKnowledgeTitle; //知识点标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.KnowledgeTitle) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.KnowledgeTitle, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeTitle] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetKnowledgeContent(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strKnowledgeContent, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.KnowledgeContent = strKnowledgeContent; //知识点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.KnowledgeContent) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.KnowledgeContent, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeContent] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetKnowledgeModuleId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strKnowledgeModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeModuleId, 8, concc_CourseKnowledges.KnowledgeModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeModuleId, 8, concc_CourseKnowledges.KnowledgeModuleId);
}
objcc_CourseKnowledgesEN.KnowledgeModuleId = strKnowledgeModuleId; //知识点模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.KnowledgeModuleId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.KnowledgeModuleId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeModuleId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetCourseId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_CourseKnowledges.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseKnowledges.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseKnowledges.CourseId);
}
objcc_CourseKnowledgesEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.CourseId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.CourseId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.CourseId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetKnowledgeTypeId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strKnowledgeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTypeId, 4, concc_CourseKnowledges.KnowledgeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeTypeId, 4, concc_CourseKnowledges.KnowledgeTypeId);
}
objcc_CourseKnowledgesEN.KnowledgeTypeId = strKnowledgeTypeId; //知识点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.KnowledgeTypeId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.KnowledgeTypeId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeTypeId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetCourseChapterId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, concc_CourseKnowledges.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
}
objcc_CourseKnowledgesEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.CourseChapterId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.CourseChapterId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.CourseChapterId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetModuleWeight(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, double? dblModuleWeight, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.ModuleWeight = dblModuleWeight; //模块权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.ModuleWeight) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.ModuleWeight, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.ModuleWeight] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetUserId(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, concc_CourseKnowledges.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, concc_CourseKnowledges.UserId);
}
objcc_CourseKnowledgesEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.UserId) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.UserId, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.UserId] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetUploadDate(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strUploadDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadDate, 20, concc_CourseKnowledges.UploadDate);
}
objcc_CourseKnowledgesEN.UploadDate = strUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.UploadDate) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.UploadDate, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.UploadDate] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetIsShow(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsShow, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.IsShow) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.IsShow, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.IsShow] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetIsCast(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsCast, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.IsCast) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.IsCast, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.IsCast] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetLikeCount(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, long? lngLikeCount, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.LikeCount) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.LikeCount, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.LikeCount] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetOrderNum(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, int? intOrderNum, string strComparisonOp="")
	{
objcc_CourseKnowledgesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.OrderNum) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.OrderNum, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.OrderNum] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetUpdDate(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_CourseKnowledges.UpdDate);
}
objcc_CourseKnowledgesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.UpdDate) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.UpdDate, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.UpdDate] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetUpdUser(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_CourseKnowledges.UpdUser);
}
objcc_CourseKnowledgesEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.UpdUser) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.UpdUser, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.UpdUser] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseKnowledgesEN SetMemo(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_CourseKnowledges.Memo);
}
objcc_CourseKnowledgesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseKnowledgesEN.dicFldComparisonOp.ContainsKey(concc_CourseKnowledges.Memo) == false)
{
objcc_CourseKnowledgesEN.dicFldComparisonOp.Add(concc_CourseKnowledges.Memo, strComparisonOp);
}
else
{
objcc_CourseKnowledgesEN.dicFldComparisonOp[concc_CourseKnowledges.Memo] = strComparisonOp;
}
}
return objcc_CourseKnowledgesEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_CourseKnowledgesEN.CheckPropertyNew();
clscc_CourseKnowledgesEN objcc_CourseKnowledgesCond = new clscc_CourseKnowledgesEN();
string strCondition = objcc_CourseKnowledgesCond
.SetCourseKnowledgeId(objcc_CourseKnowledgesEN.CourseKnowledgeId, "<>")
.SetCourseId(objcc_CourseKnowledgesEN.CourseId, "=")
.SetKnowledgeName(objcc_CourseKnowledgesEN.KnowledgeName, "=")
.GetCombineCondition();
objcc_CourseKnowledgesEN._IsCheckProperty = true;
bool bolIsExist = clscc_CourseKnowledgesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CourseId_KnowledgeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_CourseKnowledgesEN.Update();
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
 /// <param name = "objcc_CourseKnowledges">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_CourseKnowledgesEN objcc_CourseKnowledges)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_CourseKnowledgesEN objcc_CourseKnowledgesCond = new clscc_CourseKnowledgesEN();
string strCondition = objcc_CourseKnowledgesCond
.SetCourseId(objcc_CourseKnowledges.CourseId, "=")
.SetKnowledgeName(objcc_CourseKnowledges.KnowledgeName, "=")
.GetCombineCondition();
objcc_CourseKnowledges._IsCheckProperty = true;
bool bolIsExist = clscc_CourseKnowledgesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_CourseKnowledges.CourseKnowledgeId = clscc_CourseKnowledgesBL.GetFirstID_S(strCondition);
objcc_CourseKnowledges.UpdateWithCondition(strCondition);
}
else
{
objcc_CourseKnowledges.CourseKnowledgeId = clscc_CourseKnowledgesBL.GetMaxStrId_S();
objcc_CourseKnowledges.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.UpdateBySql2(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.UpdateBySql2(objcc_CourseKnowledgesEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strWhereCond)
{
try
{
bool bolResult = clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.UpdateBySqlWithCondition(objcc_CourseKnowledgesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.UpdateBySqlWithConditionTransaction(objcc_CourseKnowledgesEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
try
{
int intRecNum = clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.DelRecord(objcc_CourseKnowledgesEN.CourseKnowledgeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "objcc_CourseKnowledgesENS">源对象</param>
 /// <param name = "objcc_CourseKnowledgesENT">目标对象</param>
 public static void CopyTo(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesENS, clscc_CourseKnowledgesEN objcc_CourseKnowledgesENT)
{
try
{
objcc_CourseKnowledgesENT.CourseKnowledgeId = objcc_CourseKnowledgesENS.CourseKnowledgeId; //知识点Id
objcc_CourseKnowledgesENT.KnowledgeName = objcc_CourseKnowledgesENS.KnowledgeName; //知识点名称
objcc_CourseKnowledgesENT.KnowledgeTitle = objcc_CourseKnowledgesENS.KnowledgeTitle; //知识点标题
objcc_CourseKnowledgesENT.KnowledgeContent = objcc_CourseKnowledgesENS.KnowledgeContent; //知识点内容
objcc_CourseKnowledgesENT.KnowledgeModuleId = objcc_CourseKnowledgesENS.KnowledgeModuleId; //知识点模块Id
objcc_CourseKnowledgesENT.CourseId = objcc_CourseKnowledgesENS.CourseId; //课程Id
objcc_CourseKnowledgesENT.KnowledgeTypeId = objcc_CourseKnowledgesENS.KnowledgeTypeId; //知识点类型Id
objcc_CourseKnowledgesENT.CourseChapterId = objcc_CourseKnowledgesENS.CourseChapterId; //课程章节ID
objcc_CourseKnowledgesENT.ModuleWeight = objcc_CourseKnowledgesENS.ModuleWeight; //模块权重
objcc_CourseKnowledgesENT.UserId = objcc_CourseKnowledgesENS.UserId; //用户ID
objcc_CourseKnowledgesENT.UploadDate = objcc_CourseKnowledgesENS.UploadDate; //上传时间
objcc_CourseKnowledgesENT.IsShow = objcc_CourseKnowledgesENS.IsShow; //是否启用
objcc_CourseKnowledgesENT.IsCast = objcc_CourseKnowledgesENS.IsCast; //是否播放
objcc_CourseKnowledgesENT.LikeCount = objcc_CourseKnowledgesENS.LikeCount; //资源喜欢数量
objcc_CourseKnowledgesENT.OrderNum = objcc_CourseKnowledgesENS.OrderNum; //序号
objcc_CourseKnowledgesENT.UpdDate = objcc_CourseKnowledgesENS.UpdDate; //修改日期
objcc_CourseKnowledgesENT.UpdUser = objcc_CourseKnowledgesENS.UpdUser; //修改人
objcc_CourseKnowledgesENT.Memo = objcc_CourseKnowledgesENS.Memo; //备注
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
 /// <param name = "objcc_CourseKnowledgesENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseKnowledgesEN:objcc_CourseKnowledgesENT</returns>
 public static clscc_CourseKnowledgesEN CopyTo(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesENS)
{
try
{
 clscc_CourseKnowledgesEN objcc_CourseKnowledgesENT = new clscc_CourseKnowledgesEN()
{
CourseKnowledgeId = objcc_CourseKnowledgesENS.CourseKnowledgeId, //知识点Id
KnowledgeName = objcc_CourseKnowledgesENS.KnowledgeName, //知识点名称
KnowledgeTitle = objcc_CourseKnowledgesENS.KnowledgeTitle, //知识点标题
KnowledgeContent = objcc_CourseKnowledgesENS.KnowledgeContent, //知识点内容
KnowledgeModuleId = objcc_CourseKnowledgesENS.KnowledgeModuleId, //知识点模块Id
CourseId = objcc_CourseKnowledgesENS.CourseId, //课程Id
KnowledgeTypeId = objcc_CourseKnowledgesENS.KnowledgeTypeId, //知识点类型Id
CourseChapterId = objcc_CourseKnowledgesENS.CourseChapterId, //课程章节ID
ModuleWeight = objcc_CourseKnowledgesENS.ModuleWeight, //模块权重
UserId = objcc_CourseKnowledgesENS.UserId, //用户ID
UploadDate = objcc_CourseKnowledgesENS.UploadDate, //上传时间
IsShow = objcc_CourseKnowledgesENS.IsShow, //是否启用
IsCast = objcc_CourseKnowledgesENS.IsCast, //是否播放
LikeCount = objcc_CourseKnowledgesENS.LikeCount, //资源喜欢数量
OrderNum = objcc_CourseKnowledgesENS.OrderNum, //序号
UpdDate = objcc_CourseKnowledgesENS.UpdDate, //修改日期
UpdUser = objcc_CourseKnowledgesENS.UpdUser, //修改人
Memo = objcc_CourseKnowledgesENS.Memo, //备注
};
 return objcc_CourseKnowledgesENT;
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
public static void CheckPropertyNew(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.CheckPropertyNew(objcc_CourseKnowledgesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 clscc_CourseKnowledgesBL.cc_CourseKnowledgesDA.CheckProperty4Condition(objcc_CourseKnowledgesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.CourseKnowledgeId) == true)
{
string strComparisonOpCourseKnowledgeId = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.CourseKnowledgeId, objcc_CourseKnowledgesCond.CourseKnowledgeId, strComparisonOpCourseKnowledgeId);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.KnowledgeName) == true)
{
string strComparisonOpKnowledgeName = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.KnowledgeName, objcc_CourseKnowledgesCond.KnowledgeName, strComparisonOpKnowledgeName);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.KnowledgeTitle) == true)
{
string strComparisonOpKnowledgeTitle = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.KnowledgeTitle, objcc_CourseKnowledgesCond.KnowledgeTitle, strComparisonOpKnowledgeTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.KnowledgeModuleId) == true)
{
string strComparisonOpKnowledgeModuleId = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.KnowledgeModuleId, objcc_CourseKnowledgesCond.KnowledgeModuleId, strComparisonOpKnowledgeModuleId);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.CourseId) == true)
{
string strComparisonOpCourseId = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.CourseId, objcc_CourseKnowledgesCond.CourseId, strComparisonOpCourseId);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.KnowledgeTypeId) == true)
{
string strComparisonOpKnowledgeTypeId = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.KnowledgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.KnowledgeTypeId, objcc_CourseKnowledgesCond.KnowledgeTypeId, strComparisonOpKnowledgeTypeId);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.CourseChapterId, objcc_CourseKnowledgesCond.CourseChapterId, strComparisonOpCourseChapterId);
}
//数据类型double(numeric)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.UserId) == true)
{
string strComparisonOpUserId = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.UserId, objcc_CourseKnowledgesCond.UserId, strComparisonOpUserId);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.UploadDate) == true)
{
string strComparisonOpUploadDate = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.UploadDate, objcc_CourseKnowledgesCond.UploadDate, strComparisonOpUploadDate);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.IsShow) == true)
{
if (objcc_CourseKnowledgesCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseKnowledges.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseKnowledges.IsShow);
}
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.IsCast) == true)
{
if (objcc_CourseKnowledgesCond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseKnowledges.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseKnowledges.IsCast);
}
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.LikeCount) == true)
{
string strComparisonOpLikeCount = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseKnowledges.LikeCount, objcc_CourseKnowledgesCond.LikeCount, strComparisonOpLikeCount);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.OrderNum) == true)
{
string strComparisonOpOrderNum = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseKnowledges.OrderNum, objcc_CourseKnowledgesCond.OrderNum, strComparisonOpOrderNum);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.UpdDate, objcc_CourseKnowledgesCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.UpdUser) == true)
{
string strComparisonOpUpdUser = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.UpdUser, objcc_CourseKnowledgesCond.UpdUser, strComparisonOpUpdUser);
}
if (objcc_CourseKnowledgesCond.IsUpdated(concc_CourseKnowledges.Memo) == true)
{
string strComparisonOpMemo = objcc_CourseKnowledgesCond.dicFldComparisonOp[concc_CourseKnowledges.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseKnowledges.Memo, objcc_CourseKnowledgesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_CourseKnowledges(知识点), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseId_KnowledgeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseKnowledgesEN == null) return true;
if (objcc_CourseKnowledgesEN.CourseKnowledgeId == null || objcc_CourseKnowledgesEN.CourseKnowledgeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseKnowledgesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeName = '{0}'", objcc_CourseKnowledgesEN.KnowledgeName);
if (clscc_CourseKnowledgesBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CourseKnowledgeId !=  '{0}'", objcc_CourseKnowledgesEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseKnowledgesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeName = '{0}'", objcc_CourseKnowledgesEN.KnowledgeName);
if (clscc_CourseKnowledgesBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_CourseKnowledges(知识点), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseId_KnowledgeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseKnowledgesEN == null) return "";
if (objcc_CourseKnowledgesEN.CourseKnowledgeId == null || objcc_CourseKnowledgesEN.CourseKnowledgeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseKnowledgesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeName = '{0}'", objcc_CourseKnowledgesEN.KnowledgeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CourseKnowledgeId !=  '{0}'", objcc_CourseKnowledgesEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseKnowledgesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeName = '{0}'", objcc_CourseKnowledgesEN.KnowledgeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_CourseKnowledges
{
public virtual bool UpdRelaTabDate(string strCourseKnowledgeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点(cc_CourseKnowledges)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseKnowledgesBL
{
public static RelatedActions_cc_CourseKnowledges relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_CourseKnowledgesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_CourseKnowledgesDA cc_CourseKnowledgesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_CourseKnowledgesDA();
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
 public clscc_CourseKnowledgesBL()
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
if (string.IsNullOrEmpty(clscc_CourseKnowledgesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseKnowledgesEN._ConnectString);
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
public static DataTable GetDataTable_cc_CourseKnowledges(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_CourseKnowledgesDA.GetDataTable_cc_CourseKnowledges(strWhereCond);
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
objDT = cc_CourseKnowledgesDA.GetDataTable(strWhereCond);
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
objDT = cc_CourseKnowledgesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_CourseKnowledgesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_CourseKnowledgesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_CourseKnowledgesDA.GetDataTable_Top(objTopPara);
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
objDT = cc_CourseKnowledgesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_CourseKnowledgesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_CourseKnowledgesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseKnowledgeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLst(List<string> arrCourseKnowledgeIdLst)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseKnowledgeIdLst, true);
 string strWhereCond = string.Format("CourseKnowledgeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseKnowledgeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_CourseKnowledgesEN> GetObjLstByCourseKnowledgeIdLstCache(List<string> arrCourseKnowledgeIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Sel =
arrcc_CourseKnowledgesObjLstCache
.Where(x => arrCourseKnowledgeIdLst.Contains(x.CourseKnowledgeId));
return arrcc_CourseKnowledgesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLst(string strWhereCond)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
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
public static List<clscc_CourseKnowledgesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_CourseKnowledgesEN> GetSubObjLstCache(clscc_CourseKnowledgesEN objcc_CourseKnowledgesCond)
{
 string strCourseId = objcc_CourseKnowledgesCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clscc_CourseKnowledgesBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clscc_CourseKnowledgesEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseKnowledgesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseKnowledges.AttributeName)
{
if (objcc_CourseKnowledgesCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseKnowledgesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseKnowledgesCond[strFldName].ToString());
}
else
{
if (objcc_CourseKnowledgesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseKnowledgesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseKnowledgesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseKnowledgesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseKnowledgesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseKnowledgesCond[strFldName]));
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
public static List<clscc_CourseKnowledgesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
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
public static List<clscc_CourseKnowledgesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
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
List<clscc_CourseKnowledgesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_CourseKnowledgesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_CourseKnowledgesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
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
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
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
public static List<clscc_CourseKnowledgesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_CourseKnowledgesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
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
public static List<clscc_CourseKnowledgesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseKnowledgesEN.CourseKnowledgeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseKnowledgesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_CourseKnowledges(ref clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
bool bolResult = cc_CourseKnowledgesDA.Getcc_CourseKnowledges(ref objcc_CourseKnowledgesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseKnowledgesEN GetObjByCourseKnowledgeId(string strCourseKnowledgeId)
{
if (strCourseKnowledgeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseKnowledgeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseKnowledgeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = cc_CourseKnowledgesDA.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
return objcc_CourseKnowledgesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_CourseKnowledgesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = cc_CourseKnowledgesDA.GetFirstObj(strWhereCond);
 return objcc_CourseKnowledgesEN;
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
public static clscc_CourseKnowledgesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = cc_CourseKnowledgesDA.GetObjByDataRow(objRow);
 return objcc_CourseKnowledgesEN;
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
public static clscc_CourseKnowledgesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = cc_CourseKnowledgesDA.GetObjByDataRow(objRow);
 return objcc_CourseKnowledgesEN;
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
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <param name = "lstcc_CourseKnowledgesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseKnowledgesEN GetObjByCourseKnowledgeIdFromList(string strCourseKnowledgeId, List<clscc_CourseKnowledgesEN> lstcc_CourseKnowledgesObjLst)
{
foreach (clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN in lstcc_CourseKnowledgesObjLst)
{
if (objcc_CourseKnowledgesEN.CourseKnowledgeId == strCourseKnowledgeId)
{
return objcc_CourseKnowledgesEN;
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
 string strMaxCourseKnowledgeId;
 try
 {
 strMaxCourseKnowledgeId = clscc_CourseKnowledgesDA.GetMaxStrId();
 return strMaxCourseKnowledgeId;
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
 string strCourseKnowledgeId;
 try
 {
 strCourseKnowledgeId = new clscc_CourseKnowledgesDA().GetFirstID(strWhereCond);
 return strCourseKnowledgeId;
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
 arrList = cc_CourseKnowledgesDA.GetID(strWhereCond);
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
bool bolIsExist = cc_CourseKnowledgesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseKnowledgeId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseKnowledgeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_CourseKnowledgesDA.IsExist(strCourseKnowledgeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCourseKnowledgeId">知识点Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCourseKnowledgeId, string strOpUser)
{
clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = clscc_CourseKnowledgesBL.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_CourseKnowledgesEN.UpdUser = strOpUser;
return clscc_CourseKnowledgesBL.UpdateBySql2(objcc_CourseKnowledgesEN);
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
 bolIsExist = clscc_CourseKnowledgesDA.IsExistTable();
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
 bolIsExist = cc_CourseKnowledgesDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseKnowledgesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点名称 = [{1}]的数据已经存在!(in clscc_CourseKnowledgesBL.AddNewRecordBySql2)", objcc_CourseKnowledgesEN.CourseId,objcc_CourseKnowledgesEN.KnowledgeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true || clscc_CourseKnowledgesBL.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
     objcc_CourseKnowledgesEN.CourseKnowledgeId = clscc_CourseKnowledgesBL.GetMaxStrId_S();
 }
bool bolResult = cc_CourseKnowledgesDA.AddNewRecordBySQL2(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseKnowledgesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],知识点名称 = [{1}]的数据已经存在!(in clscc_CourseKnowledgesBL.AddNewRecordBySql2WithReturnKey)", objcc_CourseKnowledgesEN.CourseId,objcc_CourseKnowledgesEN.KnowledgeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true || clscc_CourseKnowledgesBL.IsExist(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
     objcc_CourseKnowledgesEN.CourseKnowledgeId = clscc_CourseKnowledgesBL.GetMaxStrId_S();
 }
string strKey = cc_CourseKnowledgesDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
try
{
bool bolResult = cc_CourseKnowledgesDA.Update(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 if (string.IsNullOrEmpty(objcc_CourseKnowledgesEN.CourseKnowledgeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_CourseKnowledgesDA.UpdateBySql2(objcc_CourseKnowledgesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseKnowledgesBL.ReFreshCache(objcc_CourseKnowledgesEN.CourseId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
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
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCourseKnowledgeId)
{
try
{
 clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = clscc_CourseKnowledgesBL.GetObjByCourseKnowledgeId(strCourseKnowledgeId);

if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(objcc_CourseKnowledgesEN.CourseKnowledgeId, objcc_CourseKnowledgesEN.UpdUser);
}
if (objcc_CourseKnowledgesEN != null)
{
int intRecNum = cc_CourseKnowledgesDA.DelRecord(strCourseKnowledgeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
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
/// <param name="strCourseKnowledgeId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strCourseKnowledgeId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseKnowledges]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_CourseKnowledges.CourseKnowledgeId,
//strCourseKnowledgeId);
//        clscc_CourseKnowledgesBL.Delcc_CourseKnowledgessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseKnowledgesBL.DelRecord(strCourseKnowledgeId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseKnowledgesBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseKnowledgeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCourseKnowledgeId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_CourseKnowledgesBL.relatedActions != null)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(strCourseKnowledgeId, "UpdRelaTabDate");
}
bool bolResult = cc_CourseKnowledgesDA.DelRecord(strCourseKnowledgeId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
 /// <param name = "arrCourseKnowledgeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_CourseKnowledgess(List<string> arrCourseKnowledgeIdLst)
{
if (arrCourseKnowledgeIdLst.Count == 0) return 0;
try
{
if (clscc_CourseKnowledgesBL.relatedActions != null)
{
foreach (var strCourseKnowledgeId in arrCourseKnowledgeIdLst)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(strCourseKnowledgeId, "UpdRelaTabDate");
}
}
 clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = clscc_CourseKnowledgesBL.GetObjByCourseKnowledgeId(arrCourseKnowledgeIdLst[0]);
int intDelRecNum = cc_CourseKnowledgesDA.Delcc_CourseKnowledges(arrCourseKnowledgeIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseKnowledgesEN.CourseId);
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
public static int Delcc_CourseKnowledgessByCond(string strWhereCond)
{
try
{
if (clscc_CourseKnowledgesBL.relatedActions != null)
{
List<string> arrCourseKnowledgeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCourseKnowledgeId in arrCourseKnowledgeId)
{
clscc_CourseKnowledgesBL.relatedActions.UpdRelaTabDate(strCourseKnowledgeId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(concc_CourseKnowledges.CourseId, strWhereCond);
int intRecNum = cc_CourseKnowledgesDA.Delcc_CourseKnowledges(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_CourseKnowledges]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCourseKnowledgeId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCourseKnowledgeId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseKnowledges]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseKnowledgesBL.DelRecord(strCourseKnowledgeId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseKnowledgesBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseKnowledgeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_CourseKnowledgesENS">源对象</param>
 /// <param name = "objcc_CourseKnowledgesENT">目标对象</param>
 public static void CopyTo(clscc_CourseKnowledgesEN objcc_CourseKnowledgesENS, clscc_CourseKnowledgesEN objcc_CourseKnowledgesENT)
{
try
{
objcc_CourseKnowledgesENT.CourseKnowledgeId = objcc_CourseKnowledgesENS.CourseKnowledgeId; //知识点Id
objcc_CourseKnowledgesENT.KnowledgeName = objcc_CourseKnowledgesENS.KnowledgeName; //知识点名称
objcc_CourseKnowledgesENT.KnowledgeTitle = objcc_CourseKnowledgesENS.KnowledgeTitle; //知识点标题
objcc_CourseKnowledgesENT.KnowledgeContent = objcc_CourseKnowledgesENS.KnowledgeContent; //知识点内容
objcc_CourseKnowledgesENT.KnowledgeModuleId = objcc_CourseKnowledgesENS.KnowledgeModuleId; //知识点模块Id
objcc_CourseKnowledgesENT.CourseId = objcc_CourseKnowledgesENS.CourseId; //课程Id
objcc_CourseKnowledgesENT.KnowledgeTypeId = objcc_CourseKnowledgesENS.KnowledgeTypeId; //知识点类型Id
objcc_CourseKnowledgesENT.CourseChapterId = objcc_CourseKnowledgesENS.CourseChapterId; //课程章节ID
objcc_CourseKnowledgesENT.ModuleWeight = objcc_CourseKnowledgesENS.ModuleWeight; //模块权重
objcc_CourseKnowledgesENT.UserId = objcc_CourseKnowledgesENS.UserId; //用户ID
objcc_CourseKnowledgesENT.UploadDate = objcc_CourseKnowledgesENS.UploadDate; //上传时间
objcc_CourseKnowledgesENT.IsShow = objcc_CourseKnowledgesENS.IsShow; //是否启用
objcc_CourseKnowledgesENT.IsCast = objcc_CourseKnowledgesENS.IsCast; //是否播放
objcc_CourseKnowledgesENT.LikeCount = objcc_CourseKnowledgesENS.LikeCount; //资源喜欢数量
objcc_CourseKnowledgesENT.OrderNum = objcc_CourseKnowledgesENS.OrderNum; //序号
objcc_CourseKnowledgesENT.UpdDate = objcc_CourseKnowledgesENS.UpdDate; //修改日期
objcc_CourseKnowledgesENT.UpdUser = objcc_CourseKnowledgesENS.UpdUser; //修改人
objcc_CourseKnowledgesENT.Memo = objcc_CourseKnowledgesENS.Memo; //备注
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
 /// <param name = "objcc_CourseKnowledgesEN">源简化对象</param>
 public static void SetUpdFlag(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
try
{
objcc_CourseKnowledgesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_CourseKnowledgesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_CourseKnowledges.CourseKnowledgeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objcc_CourseKnowledgesEN.CourseKnowledgeId; //知识点Id
}
if (arrFldSet.Contains(concc_CourseKnowledges.KnowledgeName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.KnowledgeName = objcc_CourseKnowledgesEN.KnowledgeName; //知识点名称
}
if (arrFldSet.Contains(concc_CourseKnowledges.KnowledgeTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.KnowledgeTitle = objcc_CourseKnowledgesEN.KnowledgeTitle == "[null]" ? null :  objcc_CourseKnowledgesEN.KnowledgeTitle; //知识点标题
}
if (arrFldSet.Contains(concc_CourseKnowledges.KnowledgeContent, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.KnowledgeContent = objcc_CourseKnowledgesEN.KnowledgeContent == "[null]" ? null :  objcc_CourseKnowledgesEN.KnowledgeContent; //知识点内容
}
if (arrFldSet.Contains(concc_CourseKnowledges.KnowledgeModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.KnowledgeModuleId = objcc_CourseKnowledgesEN.KnowledgeModuleId == "[null]" ? null :  objcc_CourseKnowledgesEN.KnowledgeModuleId; //知识点模块Id
}
if (arrFldSet.Contains(concc_CourseKnowledges.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.CourseId = objcc_CourseKnowledgesEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_CourseKnowledges.KnowledgeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.KnowledgeTypeId = objcc_CourseKnowledgesEN.KnowledgeTypeId == "[null]" ? null :  objcc_CourseKnowledgesEN.KnowledgeTypeId; //知识点类型Id
}
if (arrFldSet.Contains(concc_CourseKnowledges.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.CourseChapterId = objcc_CourseKnowledgesEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(concc_CourseKnowledges.ModuleWeight, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.ModuleWeight = objcc_CourseKnowledgesEN.ModuleWeight; //模块权重
}
if (arrFldSet.Contains(concc_CourseKnowledges.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.UserId = objcc_CourseKnowledgesEN.UserId; //用户ID
}
if (arrFldSet.Contains(concc_CourseKnowledges.UploadDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.UploadDate = objcc_CourseKnowledgesEN.UploadDate == "[null]" ? null :  objcc_CourseKnowledgesEN.UploadDate; //上传时间
}
if (arrFldSet.Contains(concc_CourseKnowledges.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.IsShow = objcc_CourseKnowledgesEN.IsShow; //是否启用
}
if (arrFldSet.Contains(concc_CourseKnowledges.IsCast, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.IsCast = objcc_CourseKnowledgesEN.IsCast; //是否播放
}
if (arrFldSet.Contains(concc_CourseKnowledges.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.LikeCount = objcc_CourseKnowledgesEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(concc_CourseKnowledges.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.OrderNum = objcc_CourseKnowledgesEN.OrderNum; //序号
}
if (arrFldSet.Contains(concc_CourseKnowledges.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.UpdDate = objcc_CourseKnowledgesEN.UpdDate == "[null]" ? null :  objcc_CourseKnowledgesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_CourseKnowledges.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.UpdUser = objcc_CourseKnowledgesEN.UpdUser == "[null]" ? null :  objcc_CourseKnowledgesEN.UpdUser; //修改人
}
if (arrFldSet.Contains(concc_CourseKnowledges.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseKnowledgesEN.Memo = objcc_CourseKnowledgesEN.Memo == "[null]" ? null :  objcc_CourseKnowledgesEN.Memo; //备注
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
 /// <param name = "objcc_CourseKnowledgesEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
try
{
if (objcc_CourseKnowledgesEN.KnowledgeTitle == "[null]") objcc_CourseKnowledgesEN.KnowledgeTitle = null; //知识点标题
if (objcc_CourseKnowledgesEN.KnowledgeContent == "[null]") objcc_CourseKnowledgesEN.KnowledgeContent = null; //知识点内容
if (objcc_CourseKnowledgesEN.KnowledgeModuleId == "[null]") objcc_CourseKnowledgesEN.KnowledgeModuleId = null; //知识点模块Id
if (objcc_CourseKnowledgesEN.KnowledgeTypeId == "[null]") objcc_CourseKnowledgesEN.KnowledgeTypeId = null; //知识点类型Id
if (objcc_CourseKnowledgesEN.UploadDate == "[null]") objcc_CourseKnowledgesEN.UploadDate = null; //上传时间
if (objcc_CourseKnowledgesEN.UpdDate == "[null]") objcc_CourseKnowledgesEN.UpdDate = null; //修改日期
if (objcc_CourseKnowledgesEN.UpdUser == "[null]") objcc_CourseKnowledgesEN.UpdUser = null; //修改人
if (objcc_CourseKnowledgesEN.Memo == "[null]") objcc_CourseKnowledgesEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 cc_CourseKnowledgesDA.CheckPropertyNew(objcc_CourseKnowledgesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 cc_CourseKnowledgesDA.CheckProperty4Condition(objcc_CourseKnowledgesEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CourseKnowledgeIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识点]...","0");
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst = GetAllcc_CourseKnowledgesObjLstCache(strCourseId); 
arrcc_CourseKnowledgesObjLst = arrcc_CourseKnowledgesObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = concc_CourseKnowledges.CourseKnowledgeId;
objDDL.DataTextField = concc_CourseKnowledges.KnowledgeName;
objDDL.DataSource = arrcc_CourseKnowledgesObjLst;
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
if (clscc_CourseKnowledgesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseKnowledgesBL没有刷新缓存机制(clscc_CourseKnowledgesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseKnowledgeId");
//if (arrcc_CourseKnowledgesObjLstCache == null)
//{
//arrcc_CourseKnowledgesObjLstCache = cc_CourseKnowledgesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseKnowledgesEN GetObjByCourseKnowledgeIdCache(string strCourseKnowledgeId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLst_Sel =
arrcc_CourseKnowledgesObjLstCache
.Where(x=> x.CourseKnowledgeId == strCourseKnowledgeId 
);
if (arrcc_CourseKnowledgesObjLst_Sel.Count() == 0)
{
   clscc_CourseKnowledgesEN obj = clscc_CourseKnowledgesBL.GetObjByCourseKnowledgeId(strCourseKnowledgeId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCourseKnowledgeId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrcc_CourseKnowledgesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetKnowledgeNameByCourseKnowledgeIdCache(string strCourseKnowledgeId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true) return "";
//获取缓存中的对象列表
clscc_CourseKnowledgesEN objcc_CourseKnowledges = GetObjByCourseKnowledgeIdCache(strCourseKnowledgeId, strCourseId);
if (objcc_CourseKnowledges == null) return "";
return objcc_CourseKnowledges.KnowledgeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseKnowledgeIdCache(string strCourseKnowledgeId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true) return "";
//获取缓存中的对象列表
clscc_CourseKnowledgesEN objcc_CourseKnowledges = GetObjByCourseKnowledgeIdCache(strCourseKnowledgeId, strCourseId);
if (objcc_CourseKnowledges == null) return "";
return objcc_CourseKnowledges.KnowledgeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetAllcc_CourseKnowledgesObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLstCache = GetObjLstCache(strCourseId); 
return arrcc_CourseKnowledgesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseKnowledgesEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrcc_CourseKnowledgesObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseKnowledgesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_CourseKnowledgesEN._RefreshTimeLst.Count == 0) return "";
return clscc_CourseKnowledgesEN._RefreshTimeLst[clscc_CourseKnowledgesEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseKnowledgesBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseKnowledgesEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseKnowledgesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_CourseKnowledgesBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_CourseKnowledges(知识点)
 /// 唯一性条件:CourseId_KnowledgeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
//检测记录是否存在
string strResult = cc_CourseKnowledgesDA.GetUniCondStr(objcc_CourseKnowledgesEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strCourseKnowledgeId, string strCourseId)
{
if (strInFldName != concc_CourseKnowledges.CourseKnowledgeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_CourseKnowledges.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_CourseKnowledges.AttributeName));
throw new Exception(strMsg);
}
var objcc_CourseKnowledges = clscc_CourseKnowledgesBL.GetObjByCourseKnowledgeIdCache(strCourseKnowledgeId, strCourseId);
if (objcc_CourseKnowledges == null) return "";
return objcc_CourseKnowledges[strOutFldName].ToString();
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
int intRecCount = clscc_CourseKnowledgesDA.GetRecCount(strTabName);
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
int intRecCount = clscc_CourseKnowledgesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_CourseKnowledgesDA.GetRecCount();
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
int intRecCount = clscc_CourseKnowledgesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_CourseKnowledgesEN objcc_CourseKnowledgesCond)
{
 string strCourseId = objcc_CourseKnowledgesCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clscc_CourseKnowledgesBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clscc_CourseKnowledgesEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseKnowledgesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseKnowledges.AttributeName)
{
if (objcc_CourseKnowledgesCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseKnowledgesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseKnowledgesCond[strFldName].ToString());
}
else
{
if (objcc_CourseKnowledgesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseKnowledgesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseKnowledgesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseKnowledgesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseKnowledgesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseKnowledgesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseKnowledgesCond[strFldName]));
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
 List<string> arrList = clscc_CourseKnowledgesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseKnowledgesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseKnowledgesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_CourseKnowledgesDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseKnowledgesDA.SetFldValue(clscc_CourseKnowledgesEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_CourseKnowledgesDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseKnowledgesDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseKnowledgesDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseKnowledgesDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_CourseKnowledges] "); 
 strCreateTabCode.Append(" ( "); 
 // /**知识点Id*/ 
 strCreateTabCode.Append(" CourseKnowledgeId char(8) primary key, "); 
 // /**知识点名称*/ 
 strCreateTabCode.Append(" KnowledgeName varchar(100) not Null, "); 
 // /**知识点标题*/ 
 strCreateTabCode.Append(" KnowledgeTitle varchar(100) Null, "); 
 // /**知识点内容*/ 
 strCreateTabCode.Append(" KnowledgeContent text Null, "); 
 // /**知识点模块Id*/ 
 strCreateTabCode.Append(" KnowledgeModuleId char(8) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**知识点类型Id*/ 
 strCreateTabCode.Append(" KnowledgeTypeId char(4) Null, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) not Null, "); 
 // /**模块权重*/ 
 strCreateTabCode.Append(" ModuleWeight numeric(6,2) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**上传时间*/ 
 strCreateTabCode.Append(" UploadDate varchar(20) Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit Null, "); 
 // /**是否播放*/ 
 strCreateTabCode.Append(" IsCast bit Null, "); 
 // /**资源喜欢数量*/ 
 strCreateTabCode.Append(" LikeCount bigint Null, "); 
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
 // /**课程章节名称*/ 
 strCreateTabCode.Append(" CourseChapterName varchar(100) Null, "); 
 // /**知识点类型名*/ 
 strCreateTabCode.Append(" KnowledgeTypeName varchar(50) Null, "); 
 // /**题目数*/ 
 strCreateTabCode.Append(" QuestionNum int Null, "); 
 // /**章名*/ 
 strCreateTabCode.Append(" ChapterName varchar(100) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null, "); 
 // /**课程代码*/ 
 strCreateTabCode.Append(" CourseCode varchar(20) Null, "); 
 // /**节名简称*/ 
 strCreateTabCode.Append(" SectionNameSim varchar(10) Null, "); 
 // /**章名简称*/ 
 strCreateTabCode.Append(" ChapterNameSim varchar(10) Null, "); 
 // /**节名*/ 
 strCreateTabCode.Append(" SectionName varchar(100) Null, "); 
 // /**知识点模块名称*/ 
 strCreateTabCode.Append(" KnowledgeModuleName varchar(100) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：CourseChapterId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strCourseChapterId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strCourseChapterId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concc_CourseKnowledges.CourseChapterId, strCourseChapterId);
 strCondition += string.Format(" order by OrderNum ");
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjList = new clscc_CourseKnowledgesDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscc_CourseKnowledgesEN objcc_CourseKnowledges in arrcc_CourseKnowledgesObjList)
{
objcc_CourseKnowledges.OrderNum = intIndex;
UpdateBySql2(objcc_CourseKnowledges);
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
/// 调整所给关键字记录的序号。根据分类字段：CourseChapterId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strCourseKnowledgeId">所给的关键字</param>
/// <param name="strCourseChapterId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strCourseKnowledgeId ,string strCourseChapterId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[CourseKnowledgeId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字CourseKnowledgeId
//5、把当前关键字CourseKnowledgeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字CourseKnowledgeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevCourseKnowledgeId = "";    //上一条序号的关键字CourseKnowledgeId
string strNextCourseKnowledgeId = "";    //下一条序号的关键字CourseKnowledgeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[CourseKnowledgeId],获取相应的序号[OrderNum]。

clscc_CourseKnowledgesEN objcc_CourseKnowledges = clscc_CourseKnowledgesBL.GetObjByCourseKnowledgeId(strCourseKnowledgeId);

intOrderNum = objcc_CourseKnowledges.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concc_CourseKnowledges.CourseChapterId, strCourseChapterId);
intTabRecNum = clscc_CourseKnowledgesBL.GetRecCountByCond(clscc_CourseKnowledgesEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", concc_CourseKnowledges.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", concc_CourseKnowledges.CourseChapterId, strCourseChapterId);
//4、获取上一个序号字段的关键字CourseKnowledgeId
strPrevCourseKnowledgeId = clscc_CourseKnowledgesBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevCourseKnowledgeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字CourseKnowledgeId所对应记录的序号减1
//6、把下(上)一个序号关键字CourseKnowledgeId所对应的记录序号加1
clscc_CourseKnowledgesBL.SetFldValue(clscc_CourseKnowledgesEN._CurrTabName, concc_CourseKnowledges.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", concc_CourseKnowledges.CourseKnowledgeId, strCourseKnowledgeId));
clscc_CourseKnowledgesBL.SetFldValue(clscc_CourseKnowledgesEN._CurrTabName, concc_CourseKnowledges.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", concc_CourseKnowledges.CourseKnowledgeId, strPrevCourseKnowledgeId));
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

//4、获取下一个序号字段的关键字CourseKnowledgeId
sbCondition.AppendFormat(" {0} = {1} ", concc_CourseKnowledges.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", concc_CourseKnowledges.CourseChapterId, strCourseChapterId);

strNextCourseKnowledgeId = clscc_CourseKnowledgesBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextCourseKnowledgeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字CourseKnowledgeId所对应记录的序号加1
//6、把下(上)一个序号关键字CourseKnowledgeId所对应的记录序号减1
clscc_CourseKnowledgesBL.SetFldValue(clscc_CourseKnowledgesEN._CurrTabName, concc_CourseKnowledges.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", concc_CourseKnowledges.CourseKnowledgeId, strCourseKnowledgeId));
clscc_CourseKnowledgesBL.SetFldValue(clscc_CourseKnowledgesEN._CurrTabName, concc_CourseKnowledges.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", concc_CourseKnowledges.CourseKnowledgeId, strNextCourseKnowledgeId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CourseChapterId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strCourseChapterId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", concc_CourseKnowledges.CourseKnowledgeId, strKeyList);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesLst = GetObjLst(strCondition);
foreach (clscc_CourseKnowledgesEN objcc_CourseKnowledges in arrcc_CourseKnowledgesLst)
{
objcc_CourseKnowledges.OrderNum = objcc_CourseKnowledges.OrderNum + 10000;
UpdateBySql2(objcc_CourseKnowledges);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concc_CourseKnowledges.CourseChapterId, strCourseChapterId);
 strCondition += string.Format(" order by OrderNum ");
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjList = new clscc_CourseKnowledgesDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscc_CourseKnowledgesEN objcc_CourseKnowledges in arrcc_CourseKnowledgesObjList)
{
objcc_CourseKnowledges.OrderNum = intIndex;
UpdateBySql2(objcc_CourseKnowledges);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CourseChapterId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strCourseChapterId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strCourseChapterId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", concc_CourseKnowledges.CourseKnowledgeId, strKeyList);
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesLst = GetObjLst(strCondition);
foreach (clscc_CourseKnowledgesEN objcc_CourseKnowledges in arrcc_CourseKnowledgesLst)
{
objcc_CourseKnowledges.OrderNum = objcc_CourseKnowledges.OrderNum - 10000;
UpdateBySql2(objcc_CourseKnowledges);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concc_CourseKnowledges.CourseChapterId, strCourseChapterId);
 strCondition += string.Format(" order by OrderNum ");
List<clscc_CourseKnowledgesEN> arrcc_CourseKnowledgesObjList = new clscc_CourseKnowledgesDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscc_CourseKnowledgesEN objcc_CourseKnowledges in arrcc_CourseKnowledgesObjList)
{
objcc_CourseKnowledges.OrderNum = intIndex;
UpdateBySql2(objcc_CourseKnowledges);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 知识点(cc_CourseKnowledges)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_CourseKnowledges : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clscc_CourseKnowledgesBL.ReFreshThisCache(strCourseId);
}
}

}