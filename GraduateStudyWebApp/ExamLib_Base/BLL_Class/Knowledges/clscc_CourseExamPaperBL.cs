
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperBL
 表名:cc_CourseExamPaper(01120071)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:41
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
public static class  clscc_CourseExamPaperBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperEN GetObj(this K_CourseExamPaperId_cc_CourseExamPaper myKey)
{
clscc_CourseExamPaperEN objcc_CourseExamPaperEN = clscc_CourseExamPaperBL.cc_CourseExamPaperDA.GetObjByCourseExamPaperId(myKey.Value);
return objcc_CourseExamPaperEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseExamPaperEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷名称 = [{0}]的数据已经存在!(in clscc_CourseExamPaperBL.AddNewRecord)", objcc_CourseExamPaperEN.ExamPaperName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true || clscc_CourseExamPaperBL.IsExist(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
     objcc_CourseExamPaperEN.CourseExamPaperId = clscc_CourseExamPaperBL.GetMaxStrId_S();
 }
bool bolResult = clscc_CourseExamPaperBL.cc_CourseExamPaperDA.AddNewRecordBySQL2(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscc_CourseExamPaperBL.IsExist(objcc_CourseExamPaperEN.CourseExamPaperId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcc_CourseExamPaperEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_CourseExamPaperEN.CheckUniqueness() == false)
{
strMsg = string.Format("(考卷名称(ExamPaperName)=[{0}])已经存在,不能重复!", objcc_CourseExamPaperEN.ExamPaperName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true || clscc_CourseExamPaperBL.IsExist(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
     objcc_CourseExamPaperEN.CourseExamPaperId = clscc_CourseExamPaperBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcc_CourseExamPaperEN.AddNewRecord();
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseExamPaperEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷名称 = [{0}]的数据已经存在!(in clscc_CourseExamPaperBL.AddNewRecordWithMaxId)", objcc_CourseExamPaperEN.ExamPaperName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true || clscc_CourseExamPaperBL.IsExist(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
     objcc_CourseExamPaperEN.CourseExamPaperId = clscc_CourseExamPaperBL.GetMaxStrId_S();
 }
string strCourseExamPaperId = clscc_CourseExamPaperBL.cc_CourseExamPaperDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseExamPaperEN);
     objcc_CourseExamPaperEN.CourseExamPaperId = strCourseExamPaperId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
}
return strCourseExamPaperId;
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseExamPaperEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷名称 = [{0}]的数据已经存在!(in clscc_CourseExamPaperBL.AddNewRecordWithReturnKey)", objcc_CourseExamPaperEN.ExamPaperName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true || clscc_CourseExamPaperBL.IsExist(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
     objcc_CourseExamPaperEN.CourseExamPaperId = clscc_CourseExamPaperBL.GetMaxStrId_S();
 }
string strKey = clscc_CourseExamPaperBL.cc_CourseExamPaperDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCourseExamPaperId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_CourseExamPaper.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_CourseExamPaper.CourseExamPaperId);
}
objcc_CourseExamPaperEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CourseExamPaperId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCourseId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseExamPaper.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseExamPaper.CourseId);
}
objcc_CourseExamPaperEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CourseId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CourseId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CourseId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetExamPaperName(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strExamPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperName, 500, concc_CourseExamPaper.ExamPaperName);
}
objcc_CourseExamPaperEN.ExamPaperName = strExamPaperName; //考卷名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.ExamPaperName) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.ExamPaperName, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.ExamPaperName] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetPaperIndex(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int? intPaperIndex, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.PaperIndex = intPaperIndex; //试卷序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.PaperIndex) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.PaperIndex, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.PaperIndex] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetExamPaperTypeId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, concc_CourseExamPaper.ExamPaperTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, concc_CourseExamPaper.ExamPaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, concc_CourseExamPaper.ExamPaperTypeId);
}
objcc_CourseExamPaperEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.ExamPaperTypeId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.ExamPaperTypeId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.ExamPaperTypeId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsShow(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsShow, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsShow) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsShow, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsShow] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetTotalScore(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, double? dblTotalScore, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.TotalScore) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.TotalScore, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.TotalScore] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetViewCount(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int? intViewCount, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.ViewCount) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.ViewCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.ViewCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetDoneNumber(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int? intDoneNumber, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.DoneNumber = intDoneNumber; //已做人数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.DoneNumber) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.DoneNumber, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.DoneNumber] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetPaperTime(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int? intPaperTime, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.PaperTime = intPaperTime; //考试时间（分钟）
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.PaperTime) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.PaperTime, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.PaperTime] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetDownloadNumber(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, int? intDownloadNumber, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.DownloadNumber) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.DownloadNumber, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.DownloadNumber] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCollectionCount(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, long? lngCollectionCount, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CollectionCount) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CollectionCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CollectionCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetLikeCount(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, long? lngLikeCount, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.LikeCount) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.LikeCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.LikeCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIdXzMajor(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, concc_CourseExamPaper.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, concc_CourseExamPaper.IdXzMajor);
}
objcc_CourseExamPaperEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IdXzMajor) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IdXzMajor, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IdXzMajor] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetPaperDispModeId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strPaperDispModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperDispModeId, 4, concc_CourseExamPaper.PaperDispModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperDispModeId, 4, concc_CourseExamPaper.PaperDispModeId);
}
objcc_CourseExamPaperEN.PaperDispModeId = strPaperDispModeId; //试卷显示模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.PaperDispModeId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.PaperDispModeId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.PaperDispModeId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetExamCreateTime(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strExamCreateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamCreateTime, 14, concc_CourseExamPaper.ExamCreateTime);
}
objcc_CourseExamPaperEN.ExamCreateTime = strExamCreateTime; //考卷建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.ExamCreateTime) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.ExamCreateTime, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.ExamCreateTime] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCreateUserID(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCreateUserID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserID, 20, concc_CourseExamPaper.CreateUserID);
}
objcc_CourseExamPaperEN.CreateUserID = strCreateUserID; //建立用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CreateUserID) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CreateUserID, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CreateUserID] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsOpenToAllStu(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsOpenToAllStu, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsOpenToAllStu = bolIsOpenToAllStu; //全校师生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsOpenToAllStu) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsOpenToAllStu, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsOpenToAllStu] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsOpenToSchool(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsOpenToSchool, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsOpenToSchool = bolIsOpenToSchool; //全校师生公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsOpenToSchool) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsOpenToSchool, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsOpenToSchool] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsOpenToSocial(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsOpenToSocial, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsOpenToSocial = bolIsOpenToSocial; //社会公众
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsOpenToSocial) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsOpenToSocial, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsOpenToSocial] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetCourseChapterId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_CourseExamPaper.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_CourseExamPaper.CourseChapterId);
}
objcc_CourseExamPaperEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.CourseChapterId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.CourseChapterId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.CourseChapterId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsAutoGeneQuestion(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsAutoGeneQuestion, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsAutoGeneQuestion = bolIsAutoGeneQuestion; //是否自动生成题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsAutoGeneQuestion) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsAutoGeneQuestion, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsAutoGeneQuestion] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetIsCanMultiDo(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsCanMultiDo, string strComparisonOp="")
	{
objcc_CourseExamPaperEN.IsCanMultiDo = bolIsCanMultiDo; //是否可以做多次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.IsCanMultiDo) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.IsCanMultiDo, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.IsCanMultiDo] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetUpdDate(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_CourseExamPaper.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_CourseExamPaper.UpdDate);
}
objcc_CourseExamPaperEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.UpdDate) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.UpdDate, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.UpdDate] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetUpdUserId(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_CourseExamPaper.UpdUserId);
}
objcc_CourseExamPaperEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.UpdUserId) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.UpdUserId, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.UpdUserId] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseExamPaperEN SetMemo(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_CourseExamPaper.Memo);
}
objcc_CourseExamPaperEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaper.Memo) == false)
{
objcc_CourseExamPaperEN.dicFldComparisonOp.Add(concc_CourseExamPaper.Memo, strComparisonOp);
}
else
{
objcc_CourseExamPaperEN.dicFldComparisonOp[concc_CourseExamPaper.Memo] = strComparisonOp;
}
}
return objcc_CourseExamPaperEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_CourseExamPaperEN.CheckPropertyNew();
clscc_CourseExamPaperEN objcc_CourseExamPaperCond = new clscc_CourseExamPaperEN();
string strCondition = objcc_CourseExamPaperCond
.SetCourseExamPaperId(objcc_CourseExamPaperEN.CourseExamPaperId, "<>")
.SetExamPaperName(objcc_CourseExamPaperEN.ExamPaperName, "=")
.GetCombineCondition();
objcc_CourseExamPaperEN._IsCheckProperty = true;
bool bolIsExist = clscc_CourseExamPaperBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ExamPaperName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_CourseExamPaperEN.Update();
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
 /// <param name = "objcc_CourseExamPaper">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_CourseExamPaperEN objcc_CourseExamPaper)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_CourseExamPaperEN objcc_CourseExamPaperCond = new clscc_CourseExamPaperEN();
string strCondition = objcc_CourseExamPaperCond
.SetExamPaperName(objcc_CourseExamPaper.ExamPaperName, "=")
.GetCombineCondition();
objcc_CourseExamPaper._IsCheckProperty = true;
bool bolIsExist = clscc_CourseExamPaperBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_CourseExamPaper.CourseExamPaperId = clscc_CourseExamPaperBL.GetFirstID_S(strCondition);
objcc_CourseExamPaper.UpdateWithCondition(strCondition);
}
else
{
objcc_CourseExamPaper.CourseExamPaperId = clscc_CourseExamPaperBL.GetMaxStrId_S();
objcc_CourseExamPaper.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseExamPaperBL.cc_CourseExamPaperDA.UpdateBySql2(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseExamPaperBL.cc_CourseExamPaperDA.UpdateBySql2(objcc_CourseExamPaperEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "objcc_CourseExamPaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strWhereCond)
{
try
{
bool bolResult = clscc_CourseExamPaperBL.cc_CourseExamPaperDA.UpdateBySqlWithCondition(objcc_CourseExamPaperEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "objcc_CourseExamPaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_CourseExamPaperBL.cc_CourseExamPaperDA.UpdateBySqlWithConditionTransaction(objcc_CourseExamPaperEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
try
{
int intRecNum = clscc_CourseExamPaperBL.cc_CourseExamPaperDA.DelRecord(objcc_CourseExamPaperEN.CourseExamPaperId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "objcc_CourseExamPaperENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperENT">目标对象</param>
 public static void CopyTo(this clscc_CourseExamPaperEN objcc_CourseExamPaperENS, clscc_CourseExamPaperEN objcc_CourseExamPaperENT)
{
try
{
objcc_CourseExamPaperENT.CourseExamPaperId = objcc_CourseExamPaperENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperENT.CourseId = objcc_CourseExamPaperENS.CourseId; //课程Id
objcc_CourseExamPaperENT.ExamPaperName = objcc_CourseExamPaperENS.ExamPaperName; //考卷名称
objcc_CourseExamPaperENT.PaperIndex = objcc_CourseExamPaperENS.PaperIndex; //试卷序号
objcc_CourseExamPaperENT.ExamPaperTypeId = objcc_CourseExamPaperENS.ExamPaperTypeId; //试卷类型Id
objcc_CourseExamPaperENT.IsShow = objcc_CourseExamPaperENS.IsShow; //是否启用
objcc_CourseExamPaperENT.TotalScore = objcc_CourseExamPaperENS.TotalScore; //总得分
objcc_CourseExamPaperENT.ViewCount = objcc_CourseExamPaperENS.ViewCount; //浏览量
objcc_CourseExamPaperENT.DoneNumber = objcc_CourseExamPaperENS.DoneNumber; //已做人数
objcc_CourseExamPaperENT.PaperTime = objcc_CourseExamPaperENS.PaperTime; //考试时间（分钟）
objcc_CourseExamPaperENT.DownloadNumber = objcc_CourseExamPaperENS.DownloadNumber; //下载数目
objcc_CourseExamPaperENT.CollectionCount = objcc_CourseExamPaperENS.CollectionCount; //收藏数量
objcc_CourseExamPaperENT.LikeCount = objcc_CourseExamPaperENS.LikeCount; //资源喜欢数量
objcc_CourseExamPaperENT.IdXzMajor = objcc_CourseExamPaperENS.IdXzMajor; //专业流水号
objcc_CourseExamPaperENT.PaperDispModeId = objcc_CourseExamPaperENS.PaperDispModeId; //试卷显示模式Id
objcc_CourseExamPaperENT.ExamCreateTime = objcc_CourseExamPaperENS.ExamCreateTime; //考卷建立时间
objcc_CourseExamPaperENT.CreateUserID = objcc_CourseExamPaperENS.CreateUserID; //建立用户ID
objcc_CourseExamPaperENT.IsOpenToAllStu = objcc_CourseExamPaperENS.IsOpenToAllStu; //全校师生
objcc_CourseExamPaperENT.IsOpenToSchool = objcc_CourseExamPaperENS.IsOpenToSchool; //全校师生公开
objcc_CourseExamPaperENT.IsOpenToSocial = objcc_CourseExamPaperENS.IsOpenToSocial; //社会公众
objcc_CourseExamPaperENT.CourseChapterId = objcc_CourseExamPaperENS.CourseChapterId; //课程章节ID
objcc_CourseExamPaperENT.IsAutoGeneQuestion = objcc_CourseExamPaperENS.IsAutoGeneQuestion; //是否自动生成题目
objcc_CourseExamPaperENT.IsCanMultiDo = objcc_CourseExamPaperENS.IsCanMultiDo; //是否可以做多次
objcc_CourseExamPaperENT.UpdDate = objcc_CourseExamPaperENS.UpdDate; //修改日期
objcc_CourseExamPaperENT.UpdUserId = objcc_CourseExamPaperENS.UpdUserId; //修改用户Id
objcc_CourseExamPaperENT.Memo = objcc_CourseExamPaperENS.Memo; //备注
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
 /// <param name = "objcc_CourseExamPaperENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseExamPaperEN:objcc_CourseExamPaperENT</returns>
 public static clscc_CourseExamPaperEN CopyTo(this clscc_CourseExamPaperEN objcc_CourseExamPaperENS)
{
try
{
 clscc_CourseExamPaperEN objcc_CourseExamPaperENT = new clscc_CourseExamPaperEN()
{
CourseExamPaperId = objcc_CourseExamPaperENS.CourseExamPaperId, //考卷流水号
CourseId = objcc_CourseExamPaperENS.CourseId, //课程Id
ExamPaperName = objcc_CourseExamPaperENS.ExamPaperName, //考卷名称
PaperIndex = objcc_CourseExamPaperENS.PaperIndex, //试卷序号
ExamPaperTypeId = objcc_CourseExamPaperENS.ExamPaperTypeId, //试卷类型Id
IsShow = objcc_CourseExamPaperENS.IsShow, //是否启用
TotalScore = objcc_CourseExamPaperENS.TotalScore, //总得分
ViewCount = objcc_CourseExamPaperENS.ViewCount, //浏览量
DoneNumber = objcc_CourseExamPaperENS.DoneNumber, //已做人数
PaperTime = objcc_CourseExamPaperENS.PaperTime, //考试时间（分钟）
DownloadNumber = objcc_CourseExamPaperENS.DownloadNumber, //下载数目
CollectionCount = objcc_CourseExamPaperENS.CollectionCount, //收藏数量
LikeCount = objcc_CourseExamPaperENS.LikeCount, //资源喜欢数量
IdXzMajor = objcc_CourseExamPaperENS.IdXzMajor, //专业流水号
PaperDispModeId = objcc_CourseExamPaperENS.PaperDispModeId, //试卷显示模式Id
ExamCreateTime = objcc_CourseExamPaperENS.ExamCreateTime, //考卷建立时间
CreateUserID = objcc_CourseExamPaperENS.CreateUserID, //建立用户ID
IsOpenToAllStu = objcc_CourseExamPaperENS.IsOpenToAllStu, //全校师生
IsOpenToSchool = objcc_CourseExamPaperENS.IsOpenToSchool, //全校师生公开
IsOpenToSocial = objcc_CourseExamPaperENS.IsOpenToSocial, //社会公众
CourseChapterId = objcc_CourseExamPaperENS.CourseChapterId, //课程章节ID
IsAutoGeneQuestion = objcc_CourseExamPaperENS.IsAutoGeneQuestion, //是否自动生成题目
IsCanMultiDo = objcc_CourseExamPaperENS.IsCanMultiDo, //是否可以做多次
UpdDate = objcc_CourseExamPaperENS.UpdDate, //修改日期
UpdUserId = objcc_CourseExamPaperENS.UpdUserId, //修改用户Id
Memo = objcc_CourseExamPaperENS.Memo, //备注
};
 return objcc_CourseExamPaperENT;
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
public static void CheckPropertyNew(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 clscc_CourseExamPaperBL.cc_CourseExamPaperDA.CheckPropertyNew(objcc_CourseExamPaperEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 clscc_CourseExamPaperBL.cc_CourseExamPaperDA.CheckProperty4Condition(objcc_CourseExamPaperEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseExamPaperEN objcc_CourseExamPaperCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.CourseExamPaperId, objcc_CourseExamPaperCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.CourseId) == true)
{
string strComparisonOpCourseId = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.CourseId, objcc_CourseExamPaperCond.CourseId, strComparisonOpCourseId);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.ExamPaperName) == true)
{
string strComparisonOpExamPaperName = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.ExamPaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.ExamPaperName, objcc_CourseExamPaperCond.ExamPaperName, strComparisonOpExamPaperName);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.PaperIndex) == true)
{
string strComparisonOpPaperIndex = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.PaperIndex];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.PaperIndex, objcc_CourseExamPaperCond.PaperIndex, strComparisonOpPaperIndex);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.ExamPaperTypeId) == true)
{
string strComparisonOpExamPaperTypeId = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.ExamPaperTypeId, objcc_CourseExamPaperCond.ExamPaperTypeId, strComparisonOpExamPaperTypeId);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.IsShow) == true)
{
if (objcc_CourseExamPaperCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsShow);
}
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.TotalScore) == true)
{
string strComparisonOpTotalScore = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.TotalScore, objcc_CourseExamPaperCond.TotalScore, strComparisonOpTotalScore);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.ViewCount) == true)
{
string strComparisonOpViewCount = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.ViewCount, objcc_CourseExamPaperCond.ViewCount, strComparisonOpViewCount);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.DoneNumber) == true)
{
string strComparisonOpDoneNumber = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.DoneNumber];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.DoneNumber, objcc_CourseExamPaperCond.DoneNumber, strComparisonOpDoneNumber);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.PaperTime) == true)
{
string strComparisonOpPaperTime = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.PaperTime];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.PaperTime, objcc_CourseExamPaperCond.PaperTime, strComparisonOpPaperTime);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.DownloadNumber, objcc_CourseExamPaperCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.CollectionCount, objcc_CourseExamPaperCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.LikeCount) == true)
{
string strComparisonOpLikeCount = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaper.LikeCount, objcc_CourseExamPaperCond.LikeCount, strComparisonOpLikeCount);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.IdXzMajor, objcc_CourseExamPaperCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.PaperDispModeId) == true)
{
string strComparisonOpPaperDispModeId = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.PaperDispModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.PaperDispModeId, objcc_CourseExamPaperCond.PaperDispModeId, strComparisonOpPaperDispModeId);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.ExamCreateTime) == true)
{
string strComparisonOpExamCreateTime = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.ExamCreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.ExamCreateTime, objcc_CourseExamPaperCond.ExamCreateTime, strComparisonOpExamCreateTime);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.CreateUserID) == true)
{
string strComparisonOpCreateUserID = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.CreateUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.CreateUserID, objcc_CourseExamPaperCond.CreateUserID, strComparisonOpCreateUserID);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.IsOpenToAllStu) == true)
{
if (objcc_CourseExamPaperCond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsOpenToAllStu);
}
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.IsOpenToSchool) == true)
{
if (objcc_CourseExamPaperCond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsOpenToSchool);
}
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.IsOpenToSocial) == true)
{
if (objcc_CourseExamPaperCond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsOpenToSocial);
}
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.CourseChapterId, objcc_CourseExamPaperCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.IsAutoGeneQuestion) == true)
{
if (objcc_CourseExamPaperCond.IsAutoGeneQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsAutoGeneQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsAutoGeneQuestion);
}
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.IsCanMultiDo) == true)
{
if (objcc_CourseExamPaperCond.IsCanMultiDo == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaper.IsCanMultiDo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaper.IsCanMultiDo);
}
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.UpdDate, objcc_CourseExamPaperCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.UpdUserId, objcc_CourseExamPaperCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_CourseExamPaperCond.IsUpdated(concc_CourseExamPaper.Memo) == true)
{
string strComparisonOpMemo = objcc_CourseExamPaperCond.dicFldComparisonOp[concc_CourseExamPaper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaper.Memo, objcc_CourseExamPaperCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_CourseExamPaper(考卷), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ExamPaperName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseExamPaperEN == null) return true;
if (objcc_CourseExamPaperEN.CourseExamPaperId == null || objcc_CourseExamPaperEN.CourseExamPaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_CourseExamPaperEN.ExamPaperName == null)
{
 sbCondition.AppendFormat(" and ExamPaperName is null", objcc_CourseExamPaperEN.ExamPaperName);
}
else
{
 sbCondition.AppendFormat(" and ExamPaperName = '{0}'", objcc_CourseExamPaperEN.ExamPaperName);
}
if (clscc_CourseExamPaperBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CourseExamPaperId !=  '{0}'", objcc_CourseExamPaperEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and ExamPaperName = '{0}'", objcc_CourseExamPaperEN.ExamPaperName);
if (clscc_CourseExamPaperBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_CourseExamPaper(考卷), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ExamPaperName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseExamPaperEN == null) return "";
if (objcc_CourseExamPaperEN.CourseExamPaperId == null || objcc_CourseExamPaperEN.CourseExamPaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_CourseExamPaperEN.ExamPaperName == null)
{
 sbCondition.AppendFormat(" and ExamPaperName is null", objcc_CourseExamPaperEN.ExamPaperName);
}
else
{
 sbCondition.AppendFormat(" and ExamPaperName = '{0}'", objcc_CourseExamPaperEN.ExamPaperName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CourseExamPaperId !=  '{0}'", objcc_CourseExamPaperEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and ExamPaperName = '{0}'", objcc_CourseExamPaperEN.ExamPaperName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_CourseExamPaper
{
public virtual bool UpdRelaTabDate(string strCourseExamPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 考卷(cc_CourseExamPaper)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseExamPaperBL
{
public static RelatedActions_cc_CourseExamPaper relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_CourseExamPaperDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_CourseExamPaperDA cc_CourseExamPaperDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_CourseExamPaperDA();
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
 public clscc_CourseExamPaperBL()
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
if (string.IsNullOrEmpty(clscc_CourseExamPaperEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseExamPaperEN._ConnectString);
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
public static DataTable GetDataTable_cc_CourseExamPaper(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_CourseExamPaperDA.GetDataTable_cc_CourseExamPaper(strWhereCond);
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
objDT = cc_CourseExamPaperDA.GetDataTable(strWhereCond);
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
objDT = cc_CourseExamPaperDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_CourseExamPaperDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_CourseExamPaperDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_CourseExamPaperDA.GetDataTable_Top(objTopPara);
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
objDT = cc_CourseExamPaperDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_CourseExamPaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_CourseExamPaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseExamPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLst(List<string> arrCourseExamPaperIdLst)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseExamPaperIdLst, true);
 string strWhereCond = string.Format("CourseExamPaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseExamPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_CourseExamPaperEN> GetObjLstByCourseExamPaperIdLstCache(List<string> arrCourseExamPaperIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName, strCourseId);
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Sel =
arrcc_CourseExamPaperObjLstCache
.Where(x => arrCourseExamPaperIdLst.Contains(x.CourseExamPaperId));
return arrcc_CourseExamPaperObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLst(string strWhereCond)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
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
public static List<clscc_CourseExamPaperEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_CourseExamPaperEN> GetSubObjLstCache(clscc_CourseExamPaperEN objcc_CourseExamPaperCond)
{
 string strCourseId = objcc_CourseExamPaperCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clscc_CourseExamPaperBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clscc_CourseExamPaperEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseExamPaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseExamPaper.AttributeName)
{
if (objcc_CourseExamPaperCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseExamPaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseExamPaperCond[strFldName].ToString());
}
else
{
if (objcc_CourseExamPaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseExamPaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseExamPaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseExamPaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseExamPaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseExamPaperCond[strFldName]));
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
public static List<clscc_CourseExamPaperEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
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
public static List<clscc_CourseExamPaperEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
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
List<clscc_CourseExamPaperEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_CourseExamPaperEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_CourseExamPaperEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
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
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
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
public static List<clscc_CourseExamPaperEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_CourseExamPaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
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
public static List<clscc_CourseExamPaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_CourseExamPaperEN> arrObjLst = new List<clscc_CourseExamPaperEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseExamPaperEN objcc_CourseExamPaperEN = new clscc_CourseExamPaperEN();
try
{
objcc_CourseExamPaperEN.CourseExamPaperId = objRow[concc_CourseExamPaper.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_CourseExamPaperEN.CourseId = objRow[concc_CourseExamPaper.CourseId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseId].ToString().Trim(); //课程Id
objcc_CourseExamPaperEN.ExamPaperName = objRow[concc_CourseExamPaper.ExamPaperName] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamPaperName].ToString().Trim(); //考卷名称
objcc_CourseExamPaperEN.PaperIndex = objRow[concc_CourseExamPaper.PaperIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperIndex].ToString().Trim()); //试卷序号
objcc_CourseExamPaperEN.ExamPaperTypeId = objRow[concc_CourseExamPaper.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_CourseExamPaperEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsShow].ToString().Trim()); //是否启用
objcc_CourseExamPaperEN.TotalScore = objRow[concc_CourseExamPaper.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseExamPaper.TotalScore].ToString().Trim()); //总得分
objcc_CourseExamPaperEN.ViewCount = objRow[concc_CourseExamPaper.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.ViewCount].ToString().Trim()); //浏览量
objcc_CourseExamPaperEN.DoneNumber = objRow[concc_CourseExamPaper.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DoneNumber].ToString().Trim()); //已做人数
objcc_CourseExamPaperEN.PaperTime = objRow[concc_CourseExamPaper.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.PaperTime].ToString().Trim()); //考试时间（分钟）
objcc_CourseExamPaperEN.DownloadNumber = objRow[concc_CourseExamPaper.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.DownloadNumber].ToString().Trim()); //下载数目
objcc_CourseExamPaperEN.CollectionCount = objRow[concc_CourseExamPaper.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.CollectionCount].ToString().Trim()); //收藏数量
objcc_CourseExamPaperEN.LikeCount = objRow[concc_CourseExamPaper.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseExamPaper.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseExamPaperEN.IdXzMajor = objRow[concc_CourseExamPaper.IdXzMajor] == DBNull.Value ? null : objRow[concc_CourseExamPaper.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseExamPaperEN.PaperDispModeId = objRow[concc_CourseExamPaper.PaperDispModeId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.PaperDispModeId].ToString().Trim(); //试卷显示模式Id
objcc_CourseExamPaperEN.ExamCreateTime = objRow[concc_CourseExamPaper.ExamCreateTime] == DBNull.Value ? null : objRow[concc_CourseExamPaper.ExamCreateTime].ToString().Trim(); //考卷建立时间
objcc_CourseExamPaperEN.CreateUserID = objRow[concc_CourseExamPaper.CreateUserID] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CreateUserID].ToString().Trim(); //建立用户ID
objcc_CourseExamPaperEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseExamPaperEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseExamPaperEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseExamPaperEN.CourseChapterId = objRow[concc_CourseExamPaper.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseExamPaperEN.IsAutoGeneQuestion = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsAutoGeneQuestion].ToString().Trim()); //是否自动生成题目
objcc_CourseExamPaperEN.IsCanMultiDo = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseExamPaper.IsCanMultiDo].ToString().Trim()); //是否可以做多次
objcc_CourseExamPaperEN.UpdDate = objRow[concc_CourseExamPaper.UpdDate].ToString().Trim(); //修改日期
objcc_CourseExamPaperEN.UpdUserId = objRow[concc_CourseExamPaper.UpdUserId] == DBNull.Value ? null : objRow[concc_CourseExamPaper.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseExamPaperEN.Memo = objRow[concc_CourseExamPaper.Memo] == DBNull.Value ? null : objRow[concc_CourseExamPaper.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseExamPaperEN.CourseExamPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseExamPaperEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_CourseExamPaper(ref clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
bool bolResult = cc_CourseExamPaperDA.Getcc_CourseExamPaper(ref objcc_CourseExamPaperEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseExamPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperEN GetObjByCourseExamPaperId(string strCourseExamPaperId)
{
if (strCourseExamPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseExamPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseExamPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseExamPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_CourseExamPaperEN objcc_CourseExamPaperEN = cc_CourseExamPaperDA.GetObjByCourseExamPaperId(strCourseExamPaperId);
return objcc_CourseExamPaperEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_CourseExamPaperEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_CourseExamPaperEN objcc_CourseExamPaperEN = cc_CourseExamPaperDA.GetFirstObj(strWhereCond);
 return objcc_CourseExamPaperEN;
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
public static clscc_CourseExamPaperEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_CourseExamPaperEN objcc_CourseExamPaperEN = cc_CourseExamPaperDA.GetObjByDataRow(objRow);
 return objcc_CourseExamPaperEN;
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
public static clscc_CourseExamPaperEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_CourseExamPaperEN objcc_CourseExamPaperEN = cc_CourseExamPaperDA.GetObjByDataRow(objRow);
 return objcc_CourseExamPaperEN;
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
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <param name = "lstcc_CourseExamPaperObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseExamPaperEN GetObjByCourseExamPaperIdFromList(string strCourseExamPaperId, List<clscc_CourseExamPaperEN> lstcc_CourseExamPaperObjLst)
{
foreach (clscc_CourseExamPaperEN objcc_CourseExamPaperEN in lstcc_CourseExamPaperObjLst)
{
if (objcc_CourseExamPaperEN.CourseExamPaperId == strCourseExamPaperId)
{
return objcc_CourseExamPaperEN;
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
 string strMaxCourseExamPaperId;
 try
 {
 strMaxCourseExamPaperId = clscc_CourseExamPaperDA.GetMaxStrId();
 return strMaxCourseExamPaperId;
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
 string strCourseExamPaperId;
 try
 {
 strCourseExamPaperId = new clscc_CourseExamPaperDA().GetFirstID(strWhereCond);
 return strCourseExamPaperId;
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
 arrList = cc_CourseExamPaperDA.GetID(strWhereCond);
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
bool bolIsExist = cc_CourseExamPaperDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseExamPaperId)
{
if (string.IsNullOrEmpty(strCourseExamPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseExamPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_CourseExamPaperDA.IsExist(strCourseExamPaperId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCourseExamPaperId">考卷流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCourseExamPaperId, string strOpUser)
{
clscc_CourseExamPaperEN objcc_CourseExamPaperEN = clscc_CourseExamPaperBL.GetObjByCourseExamPaperId(strCourseExamPaperId);
objcc_CourseExamPaperEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_CourseExamPaperEN.UpdUserId = strOpUser;
return clscc_CourseExamPaperBL.UpdateBySql2(objcc_CourseExamPaperEN);
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
 bolIsExist = clscc_CourseExamPaperDA.IsExistTable();
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
 bolIsExist = cc_CourseExamPaperDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseExamPaperEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷名称 = [{0}]的数据已经存在!(in clscc_CourseExamPaperBL.AddNewRecordBySql2)", objcc_CourseExamPaperEN.ExamPaperName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true || clscc_CourseExamPaperBL.IsExist(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
     objcc_CourseExamPaperEN.CourseExamPaperId = clscc_CourseExamPaperBL.GetMaxStrId_S();
 }
bool bolResult = cc_CourseExamPaperDA.AddNewRecordBySQL2(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_CourseExamPaperEN objcc_CourseExamPaperEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseExamPaperEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷名称 = [{0}]的数据已经存在!(in clscc_CourseExamPaperBL.AddNewRecordBySql2WithReturnKey)", objcc_CourseExamPaperEN.ExamPaperName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true || clscc_CourseExamPaperBL.IsExist(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
     objcc_CourseExamPaperEN.CourseExamPaperId = clscc_CourseExamPaperBL.GetMaxStrId_S();
 }
string strKey = cc_CourseExamPaperDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
try
{
bool bolResult = cc_CourseExamPaperDA.Update(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "objcc_CourseExamPaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 if (string.IsNullOrEmpty(objcc_CourseExamPaperEN.CourseExamPaperId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_CourseExamPaperDA.UpdateBySql2(objcc_CourseExamPaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperBL.ReFreshCache(objcc_CourseExamPaperEN.CourseId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
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
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCourseExamPaperId)
{
try
{
 clscc_CourseExamPaperEN objcc_CourseExamPaperEN = clscc_CourseExamPaperBL.GetObjByCourseExamPaperId(strCourseExamPaperId);

if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(objcc_CourseExamPaperEN.CourseExamPaperId, objcc_CourseExamPaperEN.UpdUserId);
}
if (objcc_CourseExamPaperEN != null)
{
int intRecNum = cc_CourseExamPaperDA.DelRecord(strCourseExamPaperId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseExamPaperEN.CourseId);
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
/// <param name="strCourseExamPaperId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strCourseExamPaperId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseExamPaper]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_CourseExamPaper.CourseExamPaperId,
//strCourseExamPaperId);
//        clscc_CourseExamPaperBL.Delcc_CourseExamPapersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseExamPaperBL.DelRecord(strCourseExamPaperId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseExamPaperBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseExamPaperId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCourseExamPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCourseExamPaperId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_CourseExamPaperBL.relatedActions != null)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(strCourseExamPaperId, "UpdRelaTabDate");
}
bool bolResult = cc_CourseExamPaperDA.DelRecord(strCourseExamPaperId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCourseExamPaperIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_CourseExamPapers(List<string> arrCourseExamPaperIdLst)
{
if (arrCourseExamPaperIdLst.Count == 0) return 0;
try
{
if (clscc_CourseExamPaperBL.relatedActions != null)
{
foreach (var strCourseExamPaperId in arrCourseExamPaperIdLst)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(strCourseExamPaperId, "UpdRelaTabDate");
}
}
 clscc_CourseExamPaperEN objcc_CourseExamPaperEN = clscc_CourseExamPaperBL.GetObjByCourseExamPaperId(arrCourseExamPaperIdLst[0]);
int intDelRecNum = cc_CourseExamPaperDA.Delcc_CourseExamPaper(arrCourseExamPaperIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseExamPaperEN.CourseId);
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
public static int Delcc_CourseExamPapersByCond(string strWhereCond)
{
try
{
if (clscc_CourseExamPaperBL.relatedActions != null)
{
List<string> arrCourseExamPaperId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCourseExamPaperId in arrCourseExamPaperId)
{
clscc_CourseExamPaperBL.relatedActions.UpdRelaTabDate(strCourseExamPaperId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(concc_CourseExamPaper.CourseId, strWhereCond);
int intRecNum = cc_CourseExamPaperDA.Delcc_CourseExamPaper(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_CourseExamPaper]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCourseExamPaperId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCourseExamPaperId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseExamPaperDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseExamPaper]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseExamPaperBL.DelRecord(strCourseExamPaperId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseExamPaperBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseExamPaperId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_CourseExamPaperENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperENT">目标对象</param>
 public static void CopyTo(clscc_CourseExamPaperEN objcc_CourseExamPaperENS, clscc_CourseExamPaperEN objcc_CourseExamPaperENT)
{
try
{
objcc_CourseExamPaperENT.CourseExamPaperId = objcc_CourseExamPaperENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperENT.CourseId = objcc_CourseExamPaperENS.CourseId; //课程Id
objcc_CourseExamPaperENT.ExamPaperName = objcc_CourseExamPaperENS.ExamPaperName; //考卷名称
objcc_CourseExamPaperENT.PaperIndex = objcc_CourseExamPaperENS.PaperIndex; //试卷序号
objcc_CourseExamPaperENT.ExamPaperTypeId = objcc_CourseExamPaperENS.ExamPaperTypeId; //试卷类型Id
objcc_CourseExamPaperENT.IsShow = objcc_CourseExamPaperENS.IsShow; //是否启用
objcc_CourseExamPaperENT.TotalScore = objcc_CourseExamPaperENS.TotalScore; //总得分
objcc_CourseExamPaperENT.ViewCount = objcc_CourseExamPaperENS.ViewCount; //浏览量
objcc_CourseExamPaperENT.DoneNumber = objcc_CourseExamPaperENS.DoneNumber; //已做人数
objcc_CourseExamPaperENT.PaperTime = objcc_CourseExamPaperENS.PaperTime; //考试时间（分钟）
objcc_CourseExamPaperENT.DownloadNumber = objcc_CourseExamPaperENS.DownloadNumber; //下载数目
objcc_CourseExamPaperENT.CollectionCount = objcc_CourseExamPaperENS.CollectionCount; //收藏数量
objcc_CourseExamPaperENT.LikeCount = objcc_CourseExamPaperENS.LikeCount; //资源喜欢数量
objcc_CourseExamPaperENT.IdXzMajor = objcc_CourseExamPaperENS.IdXzMajor; //专业流水号
objcc_CourseExamPaperENT.PaperDispModeId = objcc_CourseExamPaperENS.PaperDispModeId; //试卷显示模式Id
objcc_CourseExamPaperENT.ExamCreateTime = objcc_CourseExamPaperENS.ExamCreateTime; //考卷建立时间
objcc_CourseExamPaperENT.CreateUserID = objcc_CourseExamPaperENS.CreateUserID; //建立用户ID
objcc_CourseExamPaperENT.IsOpenToAllStu = objcc_CourseExamPaperENS.IsOpenToAllStu; //全校师生
objcc_CourseExamPaperENT.IsOpenToSchool = objcc_CourseExamPaperENS.IsOpenToSchool; //全校师生公开
objcc_CourseExamPaperENT.IsOpenToSocial = objcc_CourseExamPaperENS.IsOpenToSocial; //社会公众
objcc_CourseExamPaperENT.CourseChapterId = objcc_CourseExamPaperENS.CourseChapterId; //课程章节ID
objcc_CourseExamPaperENT.IsAutoGeneQuestion = objcc_CourseExamPaperENS.IsAutoGeneQuestion; //是否自动生成题目
objcc_CourseExamPaperENT.IsCanMultiDo = objcc_CourseExamPaperENS.IsCanMultiDo; //是否可以做多次
objcc_CourseExamPaperENT.UpdDate = objcc_CourseExamPaperENS.UpdDate; //修改日期
objcc_CourseExamPaperENT.UpdUserId = objcc_CourseExamPaperENS.UpdUserId; //修改用户Id
objcc_CourseExamPaperENT.Memo = objcc_CourseExamPaperENS.Memo; //备注
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
 /// <param name = "objcc_CourseExamPaperEN">源简化对象</param>
 public static void SetUpdFlag(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
try
{
objcc_CourseExamPaperEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_CourseExamPaperEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_CourseExamPaper.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.CourseExamPaperId = objcc_CourseExamPaperEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(concc_CourseExamPaper.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.CourseId = objcc_CourseExamPaperEN.CourseId == "[null]" ? null :  objcc_CourseExamPaperEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_CourseExamPaper.ExamPaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.ExamPaperName = objcc_CourseExamPaperEN.ExamPaperName == "[null]" ? null :  objcc_CourseExamPaperEN.ExamPaperName; //考卷名称
}
if (arrFldSet.Contains(concc_CourseExamPaper.PaperIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.PaperIndex = objcc_CourseExamPaperEN.PaperIndex; //试卷序号
}
if (arrFldSet.Contains(concc_CourseExamPaper.ExamPaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.ExamPaperTypeId = objcc_CourseExamPaperEN.ExamPaperTypeId; //试卷类型Id
}
if (arrFldSet.Contains(concc_CourseExamPaper.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.IsShow = objcc_CourseExamPaperEN.IsShow; //是否启用
}
if (arrFldSet.Contains(concc_CourseExamPaper.TotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.TotalScore = objcc_CourseExamPaperEN.TotalScore; //总得分
}
if (arrFldSet.Contains(concc_CourseExamPaper.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.ViewCount = objcc_CourseExamPaperEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(concc_CourseExamPaper.DoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.DoneNumber = objcc_CourseExamPaperEN.DoneNumber; //已做人数
}
if (arrFldSet.Contains(concc_CourseExamPaper.PaperTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.PaperTime = objcc_CourseExamPaperEN.PaperTime; //考试时间（分钟）
}
if (arrFldSet.Contains(concc_CourseExamPaper.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.DownloadNumber = objcc_CourseExamPaperEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(concc_CourseExamPaper.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.CollectionCount = objcc_CourseExamPaperEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(concc_CourseExamPaper.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.LikeCount = objcc_CourseExamPaperEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(concc_CourseExamPaper.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.IdXzMajor = objcc_CourseExamPaperEN.IdXzMajor == "[null]" ? null :  objcc_CourseExamPaperEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(concc_CourseExamPaper.PaperDispModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.PaperDispModeId = objcc_CourseExamPaperEN.PaperDispModeId == "[null]" ? null :  objcc_CourseExamPaperEN.PaperDispModeId; //试卷显示模式Id
}
if (arrFldSet.Contains(concc_CourseExamPaper.ExamCreateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.ExamCreateTime = objcc_CourseExamPaperEN.ExamCreateTime == "[null]" ? null :  objcc_CourseExamPaperEN.ExamCreateTime; //考卷建立时间
}
if (arrFldSet.Contains(concc_CourseExamPaper.CreateUserID, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.CreateUserID = objcc_CourseExamPaperEN.CreateUserID == "[null]" ? null :  objcc_CourseExamPaperEN.CreateUserID; //建立用户ID
}
if (arrFldSet.Contains(concc_CourseExamPaper.IsOpenToAllStu, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.IsOpenToAllStu = objcc_CourseExamPaperEN.IsOpenToAllStu; //全校师生
}
if (arrFldSet.Contains(concc_CourseExamPaper.IsOpenToSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.IsOpenToSchool = objcc_CourseExamPaperEN.IsOpenToSchool; //全校师生公开
}
if (arrFldSet.Contains(concc_CourseExamPaper.IsOpenToSocial, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.IsOpenToSocial = objcc_CourseExamPaperEN.IsOpenToSocial; //社会公众
}
if (arrFldSet.Contains(concc_CourseExamPaper.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.CourseChapterId = objcc_CourseExamPaperEN.CourseChapterId == "[null]" ? null :  objcc_CourseExamPaperEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(concc_CourseExamPaper.IsAutoGeneQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.IsAutoGeneQuestion = objcc_CourseExamPaperEN.IsAutoGeneQuestion; //是否自动生成题目
}
if (arrFldSet.Contains(concc_CourseExamPaper.IsCanMultiDo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.IsCanMultiDo = objcc_CourseExamPaperEN.IsCanMultiDo; //是否可以做多次
}
if (arrFldSet.Contains(concc_CourseExamPaper.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.UpdDate = objcc_CourseExamPaperEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_CourseExamPaper.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.UpdUserId = objcc_CourseExamPaperEN.UpdUserId == "[null]" ? null :  objcc_CourseExamPaperEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_CourseExamPaper.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseExamPaperEN.Memo = objcc_CourseExamPaperEN.Memo == "[null]" ? null :  objcc_CourseExamPaperEN.Memo; //备注
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
 /// <param name = "objcc_CourseExamPaperEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
try
{
if (objcc_CourseExamPaperEN.CourseId == "[null]") objcc_CourseExamPaperEN.CourseId = null; //课程Id
if (objcc_CourseExamPaperEN.ExamPaperName == "[null]") objcc_CourseExamPaperEN.ExamPaperName = null; //考卷名称
if (objcc_CourseExamPaperEN.IdXzMajor == "[null]") objcc_CourseExamPaperEN.IdXzMajor = null; //专业流水号
if (objcc_CourseExamPaperEN.PaperDispModeId == "[null]") objcc_CourseExamPaperEN.PaperDispModeId = null; //试卷显示模式Id
if (objcc_CourseExamPaperEN.ExamCreateTime == "[null]") objcc_CourseExamPaperEN.ExamCreateTime = null; //考卷建立时间
if (objcc_CourseExamPaperEN.CreateUserID == "[null]") objcc_CourseExamPaperEN.CreateUserID = null; //建立用户ID
if (objcc_CourseExamPaperEN.CourseChapterId == "[null]") objcc_CourseExamPaperEN.CourseChapterId = null; //课程章节ID
if (objcc_CourseExamPaperEN.UpdUserId == "[null]") objcc_CourseExamPaperEN.UpdUserId = null; //修改用户Id
if (objcc_CourseExamPaperEN.Memo == "[null]") objcc_CourseExamPaperEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 cc_CourseExamPaperDA.CheckPropertyNew(objcc_CourseExamPaperEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
 cc_CourseExamPaperDA.CheckProperty4Condition(objcc_CourseExamPaperEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CourseExamPaperIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[考卷]...","0");
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst = GetAllcc_CourseExamPaperObjLstCache(strCourseId); 
objDDL.DataValueField = concc_CourseExamPaper.CourseExamPaperId;
objDDL.DataTextField = concc_CourseExamPaper.ExamPaperName;
objDDL.DataSource = arrcc_CourseExamPaperObjLst;
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
if (clscc_CourseExamPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperBL没有刷新缓存机制(clscc_CourseExamPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseExamPaperId");
//if (arrcc_CourseExamPaperObjLstCache == null)
//{
//arrcc_CourseExamPaperObjLstCache = cc_CourseExamPaperDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseExamPaperEN GetObjByCourseExamPaperIdCache(string strCourseExamPaperId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName, strCourseId);
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLst_Sel =
arrcc_CourseExamPaperObjLstCache
.Where(x=> x.CourseExamPaperId == strCourseExamPaperId 
);
if (arrcc_CourseExamPaperObjLst_Sel.Count() == 0)
{
   clscc_CourseExamPaperEN obj = clscc_CourseExamPaperBL.GetObjByCourseExamPaperId(strCourseExamPaperId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCourseExamPaperId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrcc_CourseExamPaperObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetExamPaperNameByCourseExamPaperIdCache(string strCourseExamPaperId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseExamPaperId) == true) return "";
//获取缓存中的对象列表
clscc_CourseExamPaperEN objcc_CourseExamPaper = GetObjByCourseExamPaperIdCache(strCourseExamPaperId, strCourseId);
if (objcc_CourseExamPaper == null) return "";
return objcc_CourseExamPaper.ExamPaperName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseExamPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseExamPaperIdCache(string strCourseExamPaperId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseExamPaperId) == true) return "";
//获取缓存中的对象列表
clscc_CourseExamPaperEN objcc_CourseExamPaper = GetObjByCourseExamPaperIdCache(strCourseExamPaperId, strCourseId);
if (objcc_CourseExamPaper == null) return "";
return objcc_CourseExamPaper.ExamPaperName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetAllcc_CourseExamPaperObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLstCache = GetObjLstCache(strCourseId); 
return arrcc_CourseExamPaperObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseExamPaperEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clscc_CourseExamPaperEN> arrcc_CourseExamPaperObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrcc_CourseExamPaperObjLstCache;
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
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseExamPaperEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_CourseExamPaperEN._RefreshTimeLst.Count == 0) return "";
return clscc_CourseExamPaperEN._RefreshTimeLst[clscc_CourseExamPaperEN._RefreshTimeLst.Count - 1];
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
if (clscc_CourseExamPaperBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseExamPaperEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_CourseExamPaperBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_CourseExamPaper(考卷)
 /// 唯一性条件:ExamPaperName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_CourseExamPaperEN objcc_CourseExamPaperEN)
{
//检测记录是否存在
string strResult = cc_CourseExamPaperDA.GetUniCondStr(objcc_CourseExamPaperEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCourseExamPaperId, string strCourseId)
{
if (strInFldName != concc_CourseExamPaper.CourseExamPaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_CourseExamPaper.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_CourseExamPaper.AttributeName));
throw new Exception(strMsg);
}
var objcc_CourseExamPaper = clscc_CourseExamPaperBL.GetObjByCourseExamPaperIdCache(strCourseExamPaperId, strCourseId);
if (objcc_CourseExamPaper == null) return "";
return objcc_CourseExamPaper[strOutFldName].ToString();
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
int intRecCount = clscc_CourseExamPaperDA.GetRecCount(strTabName);
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
int intRecCount = clscc_CourseExamPaperDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_CourseExamPaperDA.GetRecCount();
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
int intRecCount = clscc_CourseExamPaperDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_CourseExamPaperEN objcc_CourseExamPaperCond)
{
 string strCourseId = objcc_CourseExamPaperCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clscc_CourseExamPaperBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clscc_CourseExamPaperEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseExamPaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseExamPaper.AttributeName)
{
if (objcc_CourseExamPaperCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseExamPaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseExamPaperCond[strFldName].ToString());
}
else
{
if (objcc_CourseExamPaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseExamPaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseExamPaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseExamPaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseExamPaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseExamPaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseExamPaperCond[strFldName]));
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
 List<string> arrList = clscc_CourseExamPaperDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseExamPaperDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseExamPaperDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_CourseExamPaperDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseExamPaperDA.SetFldValue(clscc_CourseExamPaperEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_CourseExamPaperDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseExamPaperDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseExamPaperDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseExamPaperDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_CourseExamPaper] "); 
 strCreateTabCode.Append(" ( "); 
 // /**考卷流水号*/ 
 strCreateTabCode.Append(" CourseExamPaperId char(8) primary key, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**考卷名称*/ 
 strCreateTabCode.Append(" ExamPaperName varchar(500) Null, "); 
 // /**试卷序号*/ 
 strCreateTabCode.Append(" PaperIndex int Null, "); 
 // /**试卷类型Id*/ 
 strCreateTabCode.Append(" ExamPaperTypeId char(2) not Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit Null, "); 
 // /**总得分*/ 
 strCreateTabCode.Append(" TotalScore decimal(10,1) Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" ViewCount int Null, "); 
 // /**已做人数*/ 
 strCreateTabCode.Append(" DoneNumber int Null, "); 
 // /**考试时间（分钟）*/ 
 strCreateTabCode.Append(" PaperTime int Null, "); 
 // /**下载数目*/ 
 strCreateTabCode.Append(" DownloadNumber int Null, "); 
 // /**收藏数量*/ 
 strCreateTabCode.Append(" CollectionCount bigint Null, "); 
 // /**资源喜欢数量*/ 
 strCreateTabCode.Append(" LikeCount bigint Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) Null, "); 
 // /**试卷显示模式Id*/ 
 strCreateTabCode.Append(" PaperDispModeId char(4) Null, "); 
 // /**考卷建立时间*/ 
 strCreateTabCode.Append(" ExamCreateTime varchar(14) Null, "); 
 // /**建立用户ID*/ 
 strCreateTabCode.Append(" CreateUserID varchar(20) Null, "); 
 // /**全校师生*/ 
 strCreateTabCode.Append(" IsOpenToAllStu bit Null, "); 
 // /**全校师生公开*/ 
 strCreateTabCode.Append(" IsOpenToSchool bit Null, "); 
 // /**社会公众*/ 
 strCreateTabCode.Append(" IsOpenToSocial bit Null, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) Null, "); 
 // /**是否自动生成题目*/ 
 strCreateTabCode.Append(" IsAutoGeneQuestion bit Null, "); 
 // /**是否可以做多次*/ 
 strCreateTabCode.Append(" IsCanMultiDo bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) not Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) not Null, "); 
 // /**试卷类型名称*/ 
 strCreateTabCode.Append(" ExamPaperTypeName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 考卷(cc_CourseExamPaper)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_CourseExamPaper : clsCommFun4BLV2
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
clscc_CourseExamPaperBL.ReFreshThisCache(strCourseId);
}
}

}