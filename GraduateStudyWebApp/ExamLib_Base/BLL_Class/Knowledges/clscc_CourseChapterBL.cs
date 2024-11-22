
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseChapterBL
 表名:cc_CourseChapter(01120060)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:58
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
public static class  clscc_CourseChapterBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseChapterEN GetObj(this K_CourseChapterId_cc_CourseChapter myKey)
{
clscc_CourseChapterEN objcc_CourseChapterEN = clscc_CourseChapterBL.cc_CourseChapterDA.GetObjByCourseChapterId(myKey.Value);
return objcc_CourseChapterEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseChapterEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],课程章节名称 = [{1}]的数据已经存在!(in clscc_CourseChapterBL.AddNewRecord)", objcc_CourseChapterEN.CourseId,objcc_CourseChapterEN.CourseChapterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true || clscc_CourseChapterBL.IsExist(objcc_CourseChapterEN.CourseChapterId) == true)
 {
     objcc_CourseChapterEN.CourseChapterId = clscc_CourseChapterBL.GetMaxStrId_S();
 }
bool bolResult = clscc_CourseChapterBL.cc_CourseChapterDA.AddNewRecordBySQL2(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
public static bool AddRecordEx(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscc_CourseChapterBL.IsExist(objcc_CourseChapterEN.CourseChapterId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcc_CourseChapterEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_CourseChapterEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课程Id(CourseId)=[{0}],课程章节名称(CourseChapterName)=[{1}])已经存在,不能重复!", objcc_CourseChapterEN.CourseId, objcc_CourseChapterEN.CourseChapterName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true || clscc_CourseChapterBL.IsExist(objcc_CourseChapterEN.CourseChapterId) == true)
 {
     objcc_CourseChapterEN.CourseChapterId = clscc_CourseChapterBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcc_CourseChapterEN.AddNewRecord();
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
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseChapterEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],课程章节名称 = [{1}]的数据已经存在!(in clscc_CourseChapterBL.AddNewRecordWithMaxId)", objcc_CourseChapterEN.CourseId,objcc_CourseChapterEN.CourseChapterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true || clscc_CourseChapterBL.IsExist(objcc_CourseChapterEN.CourseChapterId) == true)
 {
     objcc_CourseChapterEN.CourseChapterId = clscc_CourseChapterBL.GetMaxStrId_S();
 }
string strCourseChapterId = clscc_CourseChapterBL.cc_CourseChapterDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseChapterEN);
     objcc_CourseChapterEN.CourseChapterId = strCourseChapterId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
}
return strCourseChapterId;
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
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseChapterEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],课程章节名称 = [{1}]的数据已经存在!(in clscc_CourseChapterBL.AddNewRecordWithReturnKey)", objcc_CourseChapterEN.CourseId,objcc_CourseChapterEN.CourseChapterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true || clscc_CourseChapterBL.IsExist(objcc_CourseChapterEN.CourseChapterId) == true)
 {
     objcc_CourseChapterEN.CourseChapterId = clscc_CourseChapterBL.GetMaxStrId_S();
 }
string strKey = clscc_CourseChapterBL.cc_CourseChapterDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetCourseChapterId(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_CourseChapter.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_CourseChapter.CourseChapterId);
}
objcc_CourseChapterEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CourseChapterId) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CourseChapterId, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CourseChapterId] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetCourseChapterName(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCourseChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterName, concc_CourseChapter.CourseChapterName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterName, 100, concc_CourseChapter.CourseChapterName);
}
objcc_CourseChapterEN.CourseChapterName = strCourseChapterName; //课程章节名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CourseChapterName) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CourseChapterName, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CourseChapterName] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetChapterId(this clscc_CourseChapterEN objcc_CourseChapterEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, concc_CourseChapter.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, concc_CourseChapter.ChapterId);
}
objcc_CourseChapterEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ChapterId) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ChapterId, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ChapterId] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetSectionId(this clscc_CourseChapterEN objcc_CourseChapterEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, concc_CourseChapter.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, concc_CourseChapter.SectionId);
}
objcc_CourseChapterEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.SectionId) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.SectionId, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.SectionId] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetChapterName(this clscc_CourseChapterEN objcc_CourseChapterEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, concc_CourseChapter.ChapterName);
}
objcc_CourseChapterEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ChapterName) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ChapterName, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ChapterName] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetSectionName(this clscc_CourseChapterEN objcc_CourseChapterEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, concc_CourseChapter.SectionName);
}
objcc_CourseChapterEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.SectionName) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.SectionName, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.SectionName] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetChapterNameSim(this clscc_CourseChapterEN objcc_CourseChapterEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, concc_CourseChapter.ChapterNameSim);
}
objcc_CourseChapterEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ChapterNameSim) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ChapterNameSim, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ChapterNameSim] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetSectionNameSim(this clscc_CourseChapterEN objcc_CourseChapterEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, concc_CourseChapter.SectionNameSim);
}
objcc_CourseChapterEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.SectionNameSim) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.SectionNameSim, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.SectionNameSim] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetChapterContent(this clscc_CourseChapterEN objcc_CourseChapterEN, string strChapterContent, string strComparisonOp="")
	{
objcc_CourseChapterEN.ChapterContent = strChapterContent; //章节内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ChapterContent) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ChapterContent, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ChapterContent] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetCourseId(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_CourseChapter.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseChapter.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseChapter.CourseId);
}
objcc_CourseChapterEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CourseId) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CourseId, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CourseId] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetParentNodeId(this clscc_CourseChapterEN objcc_CourseChapterEN, string strParentNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentNodeId, concc_CourseChapter.ParentNodeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentNodeId, 8, concc_CourseChapter.ParentNodeId);
}
objcc_CourseChapterEN.ParentNodeId = strParentNodeId; //父节点编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ParentNodeId) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ParentNodeId, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ParentNodeId] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetIsOpenToAllStu(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsOpenToAllStu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToAllStu, concc_CourseChapter.IsOpenToAllStu);
objcc_CourseChapterEN.IsOpenToAllStu = bolIsOpenToAllStu; //全校师生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsOpenToAllStu) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsOpenToAllStu, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsOpenToAllStu] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetIsOpenToSchool(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsOpenToSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToSchool, concc_CourseChapter.IsOpenToSchool);
objcc_CourseChapterEN.IsOpenToSchool = bolIsOpenToSchool; //全校师生公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsOpenToSchool) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsOpenToSchool, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsOpenToSchool] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetIsOpenToSocial(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsOpenToSocial, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOpenToSocial, concc_CourseChapter.IsOpenToSocial);
objcc_CourseChapterEN.IsOpenToSocial = bolIsOpenToSocial; //社会公众
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsOpenToSocial) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsOpenToSocial, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsOpenToSocial] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetIsMustMenu(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsMustMenu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMustMenu, concc_CourseChapter.IsMustMenu);
objcc_CourseChapterEN.IsMustMenu = bolIsMustMenu; //是否必建栏目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsMustMenu) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsMustMenu, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsMustMenu] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetThemeName(this clscc_CourseChapterEN objcc_CourseChapterEN, string strThemeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeName, 200, concc_CourseChapter.ThemeName);
}
objcc_CourseChapterEN.ThemeName = strThemeName; //主题名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ThemeName) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ThemeName, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ThemeName] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetIsFile(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsFile, concc_CourseChapter.IsFile);
objcc_CourseChapterEN.IsFile = bolIsFile; //项目或文件夹
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsFile) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsFile, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsFile] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetIsUse(this clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsUse, string strComparisonOp="")
	{
objcc_CourseChapterEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.IsUse) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.IsUse, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.IsUse] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetViewCount(this clscc_CourseChapterEN objcc_CourseChapterEN, int? intViewCount, string strComparisonOp="")
	{
objcc_CourseChapterEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.ViewCount) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.ViewCount, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.ViewCount] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetCourseChapterReferred(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCourseChapterReferred, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterReferred, 10, concc_CourseChapter.CourseChapterReferred);
}
objcc_CourseChapterEN.CourseChapterReferred = strCourseChapterReferred; //节简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CourseChapterReferred) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CourseChapterReferred, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CourseChapterReferred] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetOrderNum(this clscc_CourseChapterEN objcc_CourseChapterEN, int? intOrderNum, string strComparisonOp="")
	{
objcc_CourseChapterEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.OrderNum) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.OrderNum, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.OrderNum] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetCreateDate(this clscc_CourseChapterEN objcc_CourseChapterEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_CourseChapter.CreateDate);
}
objcc_CourseChapterEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.CreateDate) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.CreateDate, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.CreateDate] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetEditPeople(this clscc_CourseChapterEN objcc_CourseChapterEN, string strEditPeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEditPeople, 50, concc_CourseChapter.EditPeople);
}
objcc_CourseChapterEN.EditPeople = strEditPeople; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.EditPeople) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.EditPeople, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.EditPeople] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetUpdDate(this clscc_CourseChapterEN objcc_CourseChapterEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_CourseChapter.UpdDate);
}
objcc_CourseChapterEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.UpdDate) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.UpdDate, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.UpdDate] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseChapterEN SetMemo(this clscc_CourseChapterEN objcc_CourseChapterEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_CourseChapter.Memo);
}
objcc_CourseChapterEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseChapterEN.dicFldComparisonOp.ContainsKey(concc_CourseChapter.Memo) == false)
{
objcc_CourseChapterEN.dicFldComparisonOp.Add(concc_CourseChapter.Memo, strComparisonOp);
}
else
{
objcc_CourseChapterEN.dicFldComparisonOp[concc_CourseChapter.Memo] = strComparisonOp;
}
}
return objcc_CourseChapterEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_CourseChapterEN.CheckPropertyNew();
clscc_CourseChapterEN objcc_CourseChapterCond = new clscc_CourseChapterEN();
string strCondition = objcc_CourseChapterCond
.SetCourseChapterId(objcc_CourseChapterEN.CourseChapterId, "<>")
.SetCourseId(objcc_CourseChapterEN.CourseId, "=")
.SetCourseChapterName(objcc_CourseChapterEN.CourseChapterName, "=")
.GetCombineCondition();
objcc_CourseChapterEN._IsCheckProperty = true;
bool bolIsExist = clscc_CourseChapterBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CourseId_CourseChapterName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_CourseChapterEN.Update();
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
 /// <param name = "objcc_CourseChapter">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_CourseChapterEN objcc_CourseChapter)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_CourseChapterEN objcc_CourseChapterCond = new clscc_CourseChapterEN();
string strCondition = objcc_CourseChapterCond
.SetCourseId(objcc_CourseChapter.CourseId, "=")
.SetCourseChapterName(objcc_CourseChapter.CourseChapterName, "=")
.GetCombineCondition();
objcc_CourseChapter._IsCheckProperty = true;
bool bolIsExist = clscc_CourseChapterBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_CourseChapter.CourseChapterId = clscc_CourseChapterBL.GetFirstID_S(strCondition);
objcc_CourseChapter.UpdateWithCondition(strCondition);
}
else
{
objcc_CourseChapter.CourseChapterId = clscc_CourseChapterBL.GetMaxStrId_S();
objcc_CourseChapter.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseChapterBL.cc_CourseChapterDA.UpdateBySql2(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseChapterEN objcc_CourseChapterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseChapterBL.cc_CourseChapterDA.UpdateBySql2(objcc_CourseChapterEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "objcc_CourseChapterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseChapterEN objcc_CourseChapterEN, string strWhereCond)
{
try
{
bool bolResult = clscc_CourseChapterBL.cc_CourseChapterDA.UpdateBySqlWithCondition(objcc_CourseChapterEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "objcc_CourseChapterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseChapterEN objcc_CourseChapterEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_CourseChapterBL.cc_CourseChapterDA.UpdateBySqlWithConditionTransaction(objcc_CourseChapterEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "strCourseChapterId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
try
{
int intRecNum = clscc_CourseChapterBL.cc_CourseChapterDA.DelRecord(objcc_CourseChapterEN.CourseChapterId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "objcc_CourseChapterENS">源对象</param>
 /// <param name = "objcc_CourseChapterENT">目标对象</param>
 public static void CopyTo(this clscc_CourseChapterEN objcc_CourseChapterENS, clscc_CourseChapterEN objcc_CourseChapterENT)
{
try
{
objcc_CourseChapterENT.CourseChapterId = objcc_CourseChapterENS.CourseChapterId; //课程章节ID
objcc_CourseChapterENT.CourseChapterName = objcc_CourseChapterENS.CourseChapterName; //课程章节名称
objcc_CourseChapterENT.ChapterId = objcc_CourseChapterENS.ChapterId; //章Id
objcc_CourseChapterENT.SectionId = objcc_CourseChapterENS.SectionId; //节Id
objcc_CourseChapterENT.ChapterName = objcc_CourseChapterENS.ChapterName; //章名
objcc_CourseChapterENT.SectionName = objcc_CourseChapterENS.SectionName; //节名
objcc_CourseChapterENT.ChapterNameSim = objcc_CourseChapterENS.ChapterNameSim; //章名简称
objcc_CourseChapterENT.SectionNameSim = objcc_CourseChapterENS.SectionNameSim; //节名简称
objcc_CourseChapterENT.ChapterContent = objcc_CourseChapterENS.ChapterContent; //章节内容
objcc_CourseChapterENT.CourseId = objcc_CourseChapterENS.CourseId; //课程Id
objcc_CourseChapterENT.ParentNodeId = objcc_CourseChapterENS.ParentNodeId; //父节点编号
objcc_CourseChapterENT.IsOpenToAllStu = objcc_CourseChapterENS.IsOpenToAllStu; //全校师生
objcc_CourseChapterENT.IsOpenToSchool = objcc_CourseChapterENS.IsOpenToSchool; //全校师生公开
objcc_CourseChapterENT.IsOpenToSocial = objcc_CourseChapterENS.IsOpenToSocial; //社会公众
objcc_CourseChapterENT.IsMustMenu = objcc_CourseChapterENS.IsMustMenu; //是否必建栏目
objcc_CourseChapterENT.ThemeName = objcc_CourseChapterENS.ThemeName; //主题名
objcc_CourseChapterENT.IsFile = objcc_CourseChapterENS.IsFile; //项目或文件夹
objcc_CourseChapterENT.IsUse = objcc_CourseChapterENS.IsUse; //是否使用
objcc_CourseChapterENT.ViewCount = objcc_CourseChapterENS.ViewCount; //浏览量
objcc_CourseChapterENT.CourseChapterReferred = objcc_CourseChapterENS.CourseChapterReferred; //节简称
objcc_CourseChapterENT.OrderNum = objcc_CourseChapterENS.OrderNum; //序号
objcc_CourseChapterENT.CreateDate = objcc_CourseChapterENS.CreateDate; //建立日期
objcc_CourseChapterENT.EditPeople = objcc_CourseChapterENS.EditPeople; //修改人
objcc_CourseChapterENT.UpdDate = objcc_CourseChapterENS.UpdDate; //修改日期
objcc_CourseChapterENT.Memo = objcc_CourseChapterENS.Memo; //备注
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
 /// <param name = "objcc_CourseChapterENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseChapterEN:objcc_CourseChapterENT</returns>
 public static clscc_CourseChapterEN CopyTo(this clscc_CourseChapterEN objcc_CourseChapterENS)
{
try
{
 clscc_CourseChapterEN objcc_CourseChapterENT = new clscc_CourseChapterEN()
{
CourseChapterId = objcc_CourseChapterENS.CourseChapterId, //课程章节ID
CourseChapterName = objcc_CourseChapterENS.CourseChapterName, //课程章节名称
ChapterId = objcc_CourseChapterENS.ChapterId, //章Id
SectionId = objcc_CourseChapterENS.SectionId, //节Id
ChapterName = objcc_CourseChapterENS.ChapterName, //章名
SectionName = objcc_CourseChapterENS.SectionName, //节名
ChapterNameSim = objcc_CourseChapterENS.ChapterNameSim, //章名简称
SectionNameSim = objcc_CourseChapterENS.SectionNameSim, //节名简称
ChapterContent = objcc_CourseChapterENS.ChapterContent, //章节内容
CourseId = objcc_CourseChapterENS.CourseId, //课程Id
ParentNodeId = objcc_CourseChapterENS.ParentNodeId, //父节点编号
IsOpenToAllStu = objcc_CourseChapterENS.IsOpenToAllStu, //全校师生
IsOpenToSchool = objcc_CourseChapterENS.IsOpenToSchool, //全校师生公开
IsOpenToSocial = objcc_CourseChapterENS.IsOpenToSocial, //社会公众
IsMustMenu = objcc_CourseChapterENS.IsMustMenu, //是否必建栏目
ThemeName = objcc_CourseChapterENS.ThemeName, //主题名
IsFile = objcc_CourseChapterENS.IsFile, //项目或文件夹
IsUse = objcc_CourseChapterENS.IsUse, //是否使用
ViewCount = objcc_CourseChapterENS.ViewCount, //浏览量
CourseChapterReferred = objcc_CourseChapterENS.CourseChapterReferred, //节简称
OrderNum = objcc_CourseChapterENS.OrderNum, //序号
CreateDate = objcc_CourseChapterENS.CreateDate, //建立日期
EditPeople = objcc_CourseChapterENS.EditPeople, //修改人
UpdDate = objcc_CourseChapterENS.UpdDate, //修改日期
Memo = objcc_CourseChapterENS.Memo, //备注
};
 return objcc_CourseChapterENT;
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
public static void CheckPropertyNew(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
 clscc_CourseChapterBL.cc_CourseChapterDA.CheckPropertyNew(objcc_CourseChapterEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
 clscc_CourseChapterBL.cc_CourseChapterDA.CheckProperty4Condition(objcc_CourseChapterEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseChapterEN objcc_CourseChapterCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CourseChapterId, objcc_CourseChapterCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.CourseChapterName) == true)
{
string strComparisonOpCourseChapterName = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.CourseChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CourseChapterName, objcc_CourseChapterCond.CourseChapterName, strComparisonOpCourseChapterName);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.ChapterId) == true)
{
string strComparisonOpChapterId = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ChapterId, objcc_CourseChapterCond.ChapterId, strComparisonOpChapterId);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.SectionId) == true)
{
string strComparisonOpSectionId = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.SectionId, objcc_CourseChapterCond.SectionId, strComparisonOpSectionId);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.ChapterName) == true)
{
string strComparisonOpChapterName = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ChapterName, objcc_CourseChapterCond.ChapterName, strComparisonOpChapterName);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.SectionName) == true)
{
string strComparisonOpSectionName = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.SectionName, objcc_CourseChapterCond.SectionName, strComparisonOpSectionName);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ChapterNameSim, objcc_CourseChapterCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.SectionNameSim, objcc_CourseChapterCond.SectionNameSim, strComparisonOpSectionNameSim);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.CourseId) == true)
{
string strComparisonOpCourseId = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CourseId, objcc_CourseChapterCond.CourseId, strComparisonOpCourseId);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.ParentNodeId) == true)
{
string strComparisonOpParentNodeId = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.ParentNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ParentNodeId, objcc_CourseChapterCond.ParentNodeId, strComparisonOpParentNodeId);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.IsOpenToAllStu) == true)
{
if (objcc_CourseChapterCond.IsOpenToAllStu == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsOpenToAllStu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsOpenToAllStu);
}
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.IsOpenToSchool) == true)
{
if (objcc_CourseChapterCond.IsOpenToSchool == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsOpenToSchool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsOpenToSchool);
}
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.IsOpenToSocial) == true)
{
if (objcc_CourseChapterCond.IsOpenToSocial == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsOpenToSocial);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsOpenToSocial);
}
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.IsMustMenu) == true)
{
if (objcc_CourseChapterCond.IsMustMenu == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsMustMenu);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsMustMenu);
}
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.ThemeName) == true)
{
string strComparisonOpThemeName = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.ThemeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.ThemeName, objcc_CourseChapterCond.ThemeName, strComparisonOpThemeName);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.IsFile) == true)
{
if (objcc_CourseChapterCond.IsFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsFile);
}
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.IsUse) == true)
{
if (objcc_CourseChapterCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseChapter.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseChapter.IsUse);
}
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.ViewCount) == true)
{
string strComparisonOpViewCount = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseChapter.ViewCount, objcc_CourseChapterCond.ViewCount, strComparisonOpViewCount);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.CourseChapterReferred) == true)
{
string strComparisonOpCourseChapterReferred = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.CourseChapterReferred];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CourseChapterReferred, objcc_CourseChapterCond.CourseChapterReferred, strComparisonOpCourseChapterReferred);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.OrderNum) == true)
{
string strComparisonOpOrderNum = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseChapter.OrderNum, objcc_CourseChapterCond.OrderNum, strComparisonOpOrderNum);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.CreateDate) == true)
{
string strComparisonOpCreateDate = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.CreateDate, objcc_CourseChapterCond.CreateDate, strComparisonOpCreateDate);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.EditPeople) == true)
{
string strComparisonOpEditPeople = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.EditPeople, objcc_CourseChapterCond.EditPeople, strComparisonOpEditPeople);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.UpdDate, objcc_CourseChapterCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_CourseChapterCond.IsUpdated(concc_CourseChapter.Memo) == true)
{
string strComparisonOpMemo = objcc_CourseChapterCond.dicFldComparisonOp[concc_CourseChapter.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseChapter.Memo, objcc_CourseChapterCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_CourseChapter(课程章节), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseId_CourseChapterName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseChapterEN == null) return true;
if (objcc_CourseChapterEN.CourseChapterId == null || objcc_CourseChapterEN.CourseChapterId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseChapterEN.CourseId);
 sbCondition.AppendFormat(" and CourseChapterName = '{0}'", objcc_CourseChapterEN.CourseChapterName);
if (clscc_CourseChapterBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CourseChapterId !=  '{0}'", objcc_CourseChapterEN.CourseChapterId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseChapterEN.CourseId);
 sbCondition.AppendFormat(" and CourseChapterName = '{0}'", objcc_CourseChapterEN.CourseChapterName);
if (clscc_CourseChapterBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_CourseChapter(课程章节), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseId_CourseChapterName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_CourseChapterEN objcc_CourseChapterEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseChapterEN == null) return "";
if (objcc_CourseChapterEN.CourseChapterId == null || objcc_CourseChapterEN.CourseChapterId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseChapterEN.CourseId);
 sbCondition.AppendFormat(" and CourseChapterName = '{0}'", objcc_CourseChapterEN.CourseChapterName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CourseChapterId !=  '{0}'", objcc_CourseChapterEN.CourseChapterId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseChapterEN.CourseId);
 sbCondition.AppendFormat(" and CourseChapterName = '{0}'", objcc_CourseChapterEN.CourseChapterName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_CourseChapter
{
public virtual bool UpdRelaTabDate(string strCourseChapterId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 课程章节(cc_CourseChapter)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseChapterBL
{
public static RelatedActions_cc_CourseChapter relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_CourseChapterDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_CourseChapterDA cc_CourseChapterDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_CourseChapterDA();
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
 public clscc_CourseChapterBL()
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
if (string.IsNullOrEmpty(clscc_CourseChapterEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseChapterEN._ConnectString);
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
public static DataTable GetDataTable_cc_CourseChapter(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_CourseChapterDA.GetDataTable_cc_CourseChapter(strWhereCond);
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
objDT = cc_CourseChapterDA.GetDataTable(strWhereCond);
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
objDT = cc_CourseChapterDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_CourseChapterDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_CourseChapterDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_CourseChapterDA.GetDataTable_Top(objTopPara);
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
objDT = cc_CourseChapterDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_CourseChapterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_CourseChapterDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseChapterIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_CourseChapterEN> GetObjLstByCourseChapterIdLst(List<string> arrCourseChapterIdLst)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseChapterIdLst, true);
 string strWhereCond = string.Format("CourseChapterId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseChapterIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_CourseChapterEN> GetObjLstByCourseChapterIdLstCache(List<string> arrCourseChapterIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName, strCourseId);
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Sel =
arrcc_CourseChapterObjLstCache
.Where(x => arrCourseChapterIdLst.Contains(x.CourseChapterId));
return arrcc_CourseChapterObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseChapterEN> GetObjLst(string strWhereCond)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
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
public static List<clscc_CourseChapterEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_CourseChapterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_CourseChapterEN> GetSubObjLstCache(clscc_CourseChapterEN objcc_CourseChapterCond)
{
 string strCourseId = objcc_CourseChapterCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clscc_CourseChapterBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clscc_CourseChapterEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseChapterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseChapter.AttributeName)
{
if (objcc_CourseChapterCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseChapterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseChapterCond[strFldName].ToString());
}
else
{
if (objcc_CourseChapterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseChapterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseChapterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseChapterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseChapterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseChapterCond[strFldName]));
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
public static List<clscc_CourseChapterEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
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
public static List<clscc_CourseChapterEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
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
List<clscc_CourseChapterEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_CourseChapterEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseChapterEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_CourseChapterEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
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
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
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
public static List<clscc_CourseChapterEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_CourseChapterEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_CourseChapterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
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
public static List<clscc_CourseChapterEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseChapterEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_CourseChapterEN> arrObjLst = new List<clscc_CourseChapterEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseChapterEN objcc_CourseChapterEN = new clscc_CourseChapterEN();
try
{
objcc_CourseChapterEN.CourseChapterId = objRow[concc_CourseChapter.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseChapterEN.CourseChapterName = objRow[concc_CourseChapter.CourseChapterName].ToString().Trim(); //课程章节名称
objcc_CourseChapterEN.ChapterId = objRow[concc_CourseChapter.ChapterId] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterId].ToString().Trim(); //章Id
objcc_CourseChapterEN.SectionId = objRow[concc_CourseChapter.SectionId] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionId].ToString().Trim(); //节Id
objcc_CourseChapterEN.ChapterName = objRow[concc_CourseChapter.ChapterName] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterName].ToString().Trim(); //章名
objcc_CourseChapterEN.SectionName = objRow[concc_CourseChapter.SectionName] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionName].ToString().Trim(); //节名
objcc_CourseChapterEN.ChapterNameSim = objRow[concc_CourseChapter.ChapterNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterNameSim].ToString().Trim(); //章名简称
objcc_CourseChapterEN.SectionNameSim = objRow[concc_CourseChapter.SectionNameSim] == DBNull.Value ? null : objRow[concc_CourseChapter.SectionNameSim].ToString().Trim(); //节名简称
objcc_CourseChapterEN.ChapterContent = objRow[concc_CourseChapter.ChapterContent] == DBNull.Value ? null : objRow[concc_CourseChapter.ChapterContent].ToString().Trim(); //章节内容
objcc_CourseChapterEN.CourseId = objRow[concc_CourseChapter.CourseId].ToString().Trim(); //课程Id
objcc_CourseChapterEN.ParentNodeId = objRow[concc_CourseChapter.ParentNodeId].ToString().Trim(); //父节点编号
objcc_CourseChapterEN.IsOpenToAllStu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToAllStu].ToString().Trim()); //全校师生
objcc_CourseChapterEN.IsOpenToSchool = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSchool].ToString().Trim()); //全校师生公开
objcc_CourseChapterEN.IsOpenToSocial = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsOpenToSocial].ToString().Trim()); //社会公众
objcc_CourseChapterEN.IsMustMenu = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsMustMenu].ToString().Trim()); //是否必建栏目
objcc_CourseChapterEN.ThemeName = objRow[concc_CourseChapter.ThemeName] == DBNull.Value ? null : objRow[concc_CourseChapter.ThemeName].ToString().Trim(); //主题名
objcc_CourseChapterEN.IsFile = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsFile].ToString().Trim()); //项目或文件夹
objcc_CourseChapterEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseChapter.IsUse].ToString().Trim()); //是否使用
objcc_CourseChapterEN.ViewCount = objRow[concc_CourseChapter.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.ViewCount].ToString().Trim()); //浏览量
objcc_CourseChapterEN.CourseChapterReferred = objRow[concc_CourseChapter.CourseChapterReferred] == DBNull.Value ? null : objRow[concc_CourseChapter.CourseChapterReferred].ToString().Trim(); //节简称
objcc_CourseChapterEN.OrderNum = objRow[concc_CourseChapter.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseChapter.OrderNum].ToString().Trim()); //序号
objcc_CourseChapterEN.CreateDate = objRow[concc_CourseChapter.CreateDate] == DBNull.Value ? null : objRow[concc_CourseChapter.CreateDate].ToString().Trim(); //建立日期
objcc_CourseChapterEN.EditPeople = objRow[concc_CourseChapter.EditPeople] == DBNull.Value ? null : objRow[concc_CourseChapter.EditPeople].ToString().Trim(); //修改人
objcc_CourseChapterEN.UpdDate = objRow[concc_CourseChapter.UpdDate] == DBNull.Value ? null : objRow[concc_CourseChapter.UpdDate].ToString().Trim(); //修改日期
objcc_CourseChapterEN.Memo = objRow[concc_CourseChapter.Memo] == DBNull.Value ? null : objRow[concc_CourseChapter.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseChapterEN.CourseChapterId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseChapterEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_CourseChapter(ref clscc_CourseChapterEN objcc_CourseChapterEN)
{
bool bolResult = cc_CourseChapterDA.Getcc_CourseChapter(ref objcc_CourseChapterEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseChapterId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseChapterEN GetObjByCourseChapterId(string strCourseChapterId)
{
if (strCourseChapterId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseChapterId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseChapterId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseChapterId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_CourseChapterEN objcc_CourseChapterEN = cc_CourseChapterDA.GetObjByCourseChapterId(strCourseChapterId);
return objcc_CourseChapterEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_CourseChapterEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_CourseChapterEN objcc_CourseChapterEN = cc_CourseChapterDA.GetFirstObj(strWhereCond);
 return objcc_CourseChapterEN;
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
public static clscc_CourseChapterEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_CourseChapterEN objcc_CourseChapterEN = cc_CourseChapterDA.GetObjByDataRow(objRow);
 return objcc_CourseChapterEN;
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
public static clscc_CourseChapterEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_CourseChapterEN objcc_CourseChapterEN = cc_CourseChapterDA.GetObjByDataRow(objRow);
 return objcc_CourseChapterEN;
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
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <param name = "lstcc_CourseChapterObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseChapterEN GetObjByCourseChapterIdFromList(string strCourseChapterId, List<clscc_CourseChapterEN> lstcc_CourseChapterObjLst)
{
foreach (clscc_CourseChapterEN objcc_CourseChapterEN in lstcc_CourseChapterObjLst)
{
if (objcc_CourseChapterEN.CourseChapterId == strCourseChapterId)
{
return objcc_CourseChapterEN;
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
 string strMaxCourseChapterId;
 try
 {
 strMaxCourseChapterId = clscc_CourseChapterDA.GetMaxStrId();
 return strMaxCourseChapterId;
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
 string strCourseChapterId;
 try
 {
 strCourseChapterId = new clscc_CourseChapterDA().GetFirstID(strWhereCond);
 return strCourseChapterId;
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
 arrList = cc_CourseChapterDA.GetID(strWhereCond);
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
bool bolIsExist = cc_CourseChapterDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseChapterId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseChapterId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseChapterId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_CourseChapterDA.IsExist(strCourseChapterId);
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
 bolIsExist = clscc_CourseChapterDA.IsExistTable();
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
 bolIsExist = cc_CourseChapterDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseChapterEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],课程章节名称 = [{1}]的数据已经存在!(in clscc_CourseChapterBL.AddNewRecordBySql2)", objcc_CourseChapterEN.CourseId,objcc_CourseChapterEN.CourseChapterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true || clscc_CourseChapterBL.IsExist(objcc_CourseChapterEN.CourseChapterId) == true)
 {
     objcc_CourseChapterEN.CourseChapterId = clscc_CourseChapterBL.GetMaxStrId_S();
 }
bool bolResult = cc_CourseChapterDA.AddNewRecordBySQL2(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_CourseChapterEN objcc_CourseChapterEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseChapterEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}],课程章节名称 = [{1}]的数据已经存在!(in clscc_CourseChapterBL.AddNewRecordBySql2WithReturnKey)", objcc_CourseChapterEN.CourseId,objcc_CourseChapterEN.CourseChapterName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true || clscc_CourseChapterBL.IsExist(objcc_CourseChapterEN.CourseChapterId) == true)
 {
     objcc_CourseChapterEN.CourseChapterId = clscc_CourseChapterBL.GetMaxStrId_S();
 }
string strKey = cc_CourseChapterDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_CourseChapterEN objcc_CourseChapterEN)
{
try
{
bool bolResult = cc_CourseChapterDA.Update(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "objcc_CourseChapterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_CourseChapterEN objcc_CourseChapterEN)
{
 if (string.IsNullOrEmpty(objcc_CourseChapterEN.CourseChapterId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_CourseChapterDA.UpdateBySql2(objcc_CourseChapterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseChapterBL.ReFreshCache(objcc_CourseChapterEN.CourseId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
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
 /// <param name = "strCourseChapterId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCourseChapterId)
{
try
{
 clscc_CourseChapterEN objcc_CourseChapterEN = clscc_CourseChapterBL.GetObjByCourseChapterId(strCourseChapterId);

if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(objcc_CourseChapterEN.CourseChapterId, "SetUpdDate");
}
if (objcc_CourseChapterEN != null)
{
int intRecNum = cc_CourseChapterDA.DelRecord(strCourseChapterId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseChapterEN.CourseId);
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
/// <param name="strCourseChapterId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strCourseChapterId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseChapter]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_CourseChapter.CourseChapterId,
//strCourseChapterId);
//        clscc_CourseChapterBL.Delcc_CourseChaptersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseChapterBL.DelRecord(strCourseChapterId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseChapterBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseChapterId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCourseChapterId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCourseChapterId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_CourseChapterBL.relatedActions != null)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(strCourseChapterId, "UpdRelaTabDate");
}
bool bolResult = cc_CourseChapterDA.DelRecord(strCourseChapterId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCourseChapterIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_CourseChapters(List<string> arrCourseChapterIdLst)
{
if (arrCourseChapterIdLst.Count == 0) return 0;
try
{
if (clscc_CourseChapterBL.relatedActions != null)
{
foreach (var strCourseChapterId in arrCourseChapterIdLst)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(strCourseChapterId, "UpdRelaTabDate");
}
}
 clscc_CourseChapterEN objcc_CourseChapterEN = clscc_CourseChapterBL.GetObjByCourseChapterId(arrCourseChapterIdLst[0]);
int intDelRecNum = cc_CourseChapterDA.Delcc_CourseChapter(arrCourseChapterIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_CourseChapterEN.CourseId);
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
public static int Delcc_CourseChaptersByCond(string strWhereCond)
{
try
{
if (clscc_CourseChapterBL.relatedActions != null)
{
List<string> arrCourseChapterId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCourseChapterId in arrCourseChapterId)
{
clscc_CourseChapterBL.relatedActions.UpdRelaTabDate(strCourseChapterId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(concc_CourseChapter.CourseId, strWhereCond);
int intRecNum = cc_CourseChapterDA.Delcc_CourseChapter(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_CourseChapter]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCourseChapterId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCourseChapterId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseChapterDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseChapter]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseChapterBL.DelRecord(strCourseChapterId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseChapterBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseChapterId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_CourseChapterENS">源对象</param>
 /// <param name = "objcc_CourseChapterENT">目标对象</param>
 public static void CopyTo(clscc_CourseChapterEN objcc_CourseChapterENS, clscc_CourseChapterEN objcc_CourseChapterENT)
{
try
{
objcc_CourseChapterENT.CourseChapterId = objcc_CourseChapterENS.CourseChapterId; //课程章节ID
objcc_CourseChapterENT.CourseChapterName = objcc_CourseChapterENS.CourseChapterName; //课程章节名称
objcc_CourseChapterENT.ChapterId = objcc_CourseChapterENS.ChapterId; //章Id
objcc_CourseChapterENT.SectionId = objcc_CourseChapterENS.SectionId; //节Id
objcc_CourseChapterENT.ChapterName = objcc_CourseChapterENS.ChapterName; //章名
objcc_CourseChapterENT.SectionName = objcc_CourseChapterENS.SectionName; //节名
objcc_CourseChapterENT.ChapterNameSim = objcc_CourseChapterENS.ChapterNameSim; //章名简称
objcc_CourseChapterENT.SectionNameSim = objcc_CourseChapterENS.SectionNameSim; //节名简称
objcc_CourseChapterENT.ChapterContent = objcc_CourseChapterENS.ChapterContent; //章节内容
objcc_CourseChapterENT.CourseId = objcc_CourseChapterENS.CourseId; //课程Id
objcc_CourseChapterENT.ParentNodeId = objcc_CourseChapterENS.ParentNodeId; //父节点编号
objcc_CourseChapterENT.IsOpenToAllStu = objcc_CourseChapterENS.IsOpenToAllStu; //全校师生
objcc_CourseChapterENT.IsOpenToSchool = objcc_CourseChapterENS.IsOpenToSchool; //全校师生公开
objcc_CourseChapterENT.IsOpenToSocial = objcc_CourseChapterENS.IsOpenToSocial; //社会公众
objcc_CourseChapterENT.IsMustMenu = objcc_CourseChapterENS.IsMustMenu; //是否必建栏目
objcc_CourseChapterENT.ThemeName = objcc_CourseChapterENS.ThemeName; //主题名
objcc_CourseChapterENT.IsFile = objcc_CourseChapterENS.IsFile; //项目或文件夹
objcc_CourseChapterENT.IsUse = objcc_CourseChapterENS.IsUse; //是否使用
objcc_CourseChapterENT.ViewCount = objcc_CourseChapterENS.ViewCount; //浏览量
objcc_CourseChapterENT.CourseChapterReferred = objcc_CourseChapterENS.CourseChapterReferred; //节简称
objcc_CourseChapterENT.OrderNum = objcc_CourseChapterENS.OrderNum; //序号
objcc_CourseChapterENT.CreateDate = objcc_CourseChapterENS.CreateDate; //建立日期
objcc_CourseChapterENT.EditPeople = objcc_CourseChapterENS.EditPeople; //修改人
objcc_CourseChapterENT.UpdDate = objcc_CourseChapterENS.UpdDate; //修改日期
objcc_CourseChapterENT.Memo = objcc_CourseChapterENS.Memo; //备注
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
 /// <param name = "objcc_CourseChapterEN">源简化对象</param>
 public static void SetUpdFlag(clscc_CourseChapterEN objcc_CourseChapterEN)
{
try
{
objcc_CourseChapterEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_CourseChapterEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_CourseChapter.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.CourseChapterId = objcc_CourseChapterEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(concc_CourseChapter.CourseChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.CourseChapterName = objcc_CourseChapterEN.CourseChapterName; //课程章节名称
}
if (arrFldSet.Contains(concc_CourseChapter.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.ChapterId = objcc_CourseChapterEN.ChapterId == "[null]" ? null :  objcc_CourseChapterEN.ChapterId; //章Id
}
if (arrFldSet.Contains(concc_CourseChapter.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.SectionId = objcc_CourseChapterEN.SectionId == "[null]" ? null :  objcc_CourseChapterEN.SectionId; //节Id
}
if (arrFldSet.Contains(concc_CourseChapter.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.ChapterName = objcc_CourseChapterEN.ChapterName == "[null]" ? null :  objcc_CourseChapterEN.ChapterName; //章名
}
if (arrFldSet.Contains(concc_CourseChapter.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.SectionName = objcc_CourseChapterEN.SectionName == "[null]" ? null :  objcc_CourseChapterEN.SectionName; //节名
}
if (arrFldSet.Contains(concc_CourseChapter.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.ChapterNameSim = objcc_CourseChapterEN.ChapterNameSim == "[null]" ? null :  objcc_CourseChapterEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(concc_CourseChapter.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.SectionNameSim = objcc_CourseChapterEN.SectionNameSim == "[null]" ? null :  objcc_CourseChapterEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(concc_CourseChapter.ChapterContent, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.ChapterContent = objcc_CourseChapterEN.ChapterContent == "[null]" ? null :  objcc_CourseChapterEN.ChapterContent; //章节内容
}
if (arrFldSet.Contains(concc_CourseChapter.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.CourseId = objcc_CourseChapterEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_CourseChapter.ParentNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.ParentNodeId = objcc_CourseChapterEN.ParentNodeId; //父节点编号
}
if (arrFldSet.Contains(concc_CourseChapter.IsOpenToAllStu, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.IsOpenToAllStu = objcc_CourseChapterEN.IsOpenToAllStu; //全校师生
}
if (arrFldSet.Contains(concc_CourseChapter.IsOpenToSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.IsOpenToSchool = objcc_CourseChapterEN.IsOpenToSchool; //全校师生公开
}
if (arrFldSet.Contains(concc_CourseChapter.IsOpenToSocial, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.IsOpenToSocial = objcc_CourseChapterEN.IsOpenToSocial; //社会公众
}
if (arrFldSet.Contains(concc_CourseChapter.IsMustMenu, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.IsMustMenu = objcc_CourseChapterEN.IsMustMenu; //是否必建栏目
}
if (arrFldSet.Contains(concc_CourseChapter.ThemeName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.ThemeName = objcc_CourseChapterEN.ThemeName == "[null]" ? null :  objcc_CourseChapterEN.ThemeName; //主题名
}
if (arrFldSet.Contains(concc_CourseChapter.IsFile, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.IsFile = objcc_CourseChapterEN.IsFile; //项目或文件夹
}
if (arrFldSet.Contains(concc_CourseChapter.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.IsUse = objcc_CourseChapterEN.IsUse; //是否使用
}
if (arrFldSet.Contains(concc_CourseChapter.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.ViewCount = objcc_CourseChapterEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(concc_CourseChapter.CourseChapterReferred, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.CourseChapterReferred = objcc_CourseChapterEN.CourseChapterReferred == "[null]" ? null :  objcc_CourseChapterEN.CourseChapterReferred; //节简称
}
if (arrFldSet.Contains(concc_CourseChapter.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.OrderNum = objcc_CourseChapterEN.OrderNum; //序号
}
if (arrFldSet.Contains(concc_CourseChapter.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.CreateDate = objcc_CourseChapterEN.CreateDate == "[null]" ? null :  objcc_CourseChapterEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(concc_CourseChapter.EditPeople, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.EditPeople = objcc_CourseChapterEN.EditPeople == "[null]" ? null :  objcc_CourseChapterEN.EditPeople; //修改人
}
if (arrFldSet.Contains(concc_CourseChapter.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.UpdDate = objcc_CourseChapterEN.UpdDate == "[null]" ? null :  objcc_CourseChapterEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_CourseChapter.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseChapterEN.Memo = objcc_CourseChapterEN.Memo == "[null]" ? null :  objcc_CourseChapterEN.Memo; //备注
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
 /// <param name = "objcc_CourseChapterEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_CourseChapterEN objcc_CourseChapterEN)
{
try
{
if (objcc_CourseChapterEN.ChapterId == "[null]") objcc_CourseChapterEN.ChapterId = null; //章Id
if (objcc_CourseChapterEN.SectionId == "[null]") objcc_CourseChapterEN.SectionId = null; //节Id
if (objcc_CourseChapterEN.ChapterName == "[null]") objcc_CourseChapterEN.ChapterName = null; //章名
if (objcc_CourseChapterEN.SectionName == "[null]") objcc_CourseChapterEN.SectionName = null; //节名
if (objcc_CourseChapterEN.ChapterNameSim == "[null]") objcc_CourseChapterEN.ChapterNameSim = null; //章名简称
if (objcc_CourseChapterEN.SectionNameSim == "[null]") objcc_CourseChapterEN.SectionNameSim = null; //节名简称
if (objcc_CourseChapterEN.ChapterContent == "[null]") objcc_CourseChapterEN.ChapterContent = null; //章节内容
if (objcc_CourseChapterEN.ThemeName == "[null]") objcc_CourseChapterEN.ThemeName = null; //主题名
if (objcc_CourseChapterEN.CourseChapterReferred == "[null]") objcc_CourseChapterEN.CourseChapterReferred = null; //节简称
if (objcc_CourseChapterEN.CreateDate == "[null]") objcc_CourseChapterEN.CreateDate = null; //建立日期
if (objcc_CourseChapterEN.EditPeople == "[null]") objcc_CourseChapterEN.EditPeople = null; //修改人
if (objcc_CourseChapterEN.UpdDate == "[null]") objcc_CourseChapterEN.UpdDate = null; //修改日期
if (objcc_CourseChapterEN.Memo == "[null]") objcc_CourseChapterEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_CourseChapterEN objcc_CourseChapterEN)
{
 cc_CourseChapterDA.CheckPropertyNew(objcc_CourseChapterEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_CourseChapterEN objcc_CourseChapterEN)
{
 cc_CourseChapterDA.CheckProperty4Condition(objcc_CourseChapterEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CourseChapterIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程章节]...","0");
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLst = GetAllcc_CourseChapterObjLstCache(strCourseId); 
arrcc_CourseChapterObjLst = arrcc_CourseChapterObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = concc_CourseChapter.CourseChapterId;
objDDL.DataTextField = concc_CourseChapter.CourseChapterName;
objDDL.DataSource = arrcc_CourseChapterObjLst;
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
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseChapterId");
//if (arrcc_CourseChapterObjLstCache == null)
//{
//arrcc_CourseChapterObjLstCache = cc_CourseChapterDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseChapterEN GetObjByCourseChapterIdCache(string strCourseChapterId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName, strCourseId);
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseChapterEN> arrcc_CourseChapterObjLst_Sel =
arrcc_CourseChapterObjLstCache
.Where(x=> x.CourseChapterId == strCourseChapterId 
);
if (arrcc_CourseChapterObjLst_Sel.Count() == 0)
{
   clscc_CourseChapterEN obj = clscc_CourseChapterBL.GetObjByCourseChapterId(strCourseChapterId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCourseChapterId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrcc_CourseChapterObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseChapterNameByCourseChapterIdCache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return "";
//获取缓存中的对象列表
clscc_CourseChapterEN objcc_CourseChapter = GetObjByCourseChapterIdCache(strCourseChapterId, strCourseId);
if (objcc_CourseChapter == null) return "";
return objcc_CourseChapter.CourseChapterName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseChapterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseChapterIdCache(string strCourseChapterId, string strCourseId)
{
if (string.IsNullOrEmpty(strCourseChapterId) == true) return "";
//获取缓存中的对象列表
clscc_CourseChapterEN objcc_CourseChapter = GetObjByCourseChapterIdCache(strCourseChapterId, strCourseId);
if (objcc_CourseChapter == null) return "";
return objcc_CourseChapter.CourseChapterName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseChapterEN> GetAllcc_CourseChapterObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLstCache = GetObjLstCache(strCourseId); 
return arrcc_CourseChapterObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseChapterEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clscc_CourseChapterEN> arrcc_CourseChapterObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrcc_CourseChapterObjLstCache;
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
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseChapterEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_CourseChapterEN._RefreshTimeLst.Count == 0) return "";
return clscc_CourseChapterEN._RefreshTimeLst[clscc_CourseChapterEN._RefreshTimeLst.Count - 1];
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
if (clscc_CourseChapterBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseChapterEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseChapterEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_CourseChapterBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_CourseChapter(课程章节)
 /// 唯一性条件:CourseId_CourseChapterName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseChapterEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_CourseChapterEN objcc_CourseChapterEN)
{
//检测记录是否存在
string strResult = cc_CourseChapterDA.GetUniCondStr(objcc_CourseChapterEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCourseChapterId, string strCourseId)
{
if (strInFldName != concc_CourseChapter.CourseChapterId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_CourseChapter.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_CourseChapter.AttributeName));
throw new Exception(strMsg);
}
var objcc_CourseChapter = clscc_CourseChapterBL.GetObjByCourseChapterIdCache(strCourseChapterId, strCourseId);
if (objcc_CourseChapter == null) return "";
return objcc_CourseChapter[strOutFldName].ToString();
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
int intRecCount = clscc_CourseChapterDA.GetRecCount(strTabName);
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
int intRecCount = clscc_CourseChapterDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_CourseChapterDA.GetRecCount();
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
int intRecCount = clscc_CourseChapterDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_CourseChapterCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_CourseChapterEN objcc_CourseChapterCond)
{
 string strCourseId = objcc_CourseChapterCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clscc_CourseChapterBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clscc_CourseChapterEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_CourseChapterEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseChapter.AttributeName)
{
if (objcc_CourseChapterCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseChapterCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseChapterCond[strFldName].ToString());
}
else
{
if (objcc_CourseChapterCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseChapterCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseChapterCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseChapterCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseChapterCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseChapterCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseChapterCond[strFldName]));
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
 List<string> arrList = clscc_CourseChapterDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseChapterDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseChapterDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_CourseChapterDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseChapterDA.SetFldValue(clscc_CourseChapterEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_CourseChapterDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseChapterDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseChapterDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseChapterDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_CourseChapter] "); 
 strCreateTabCode.Append(" ( "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) primary key, "); 
 // /**课程章节名称*/ 
 strCreateTabCode.Append(" CourseChapterName varchar(100) not Null, "); 
 // /**章Id*/ 
 strCreateTabCode.Append(" ChapterId char(8) Null, "); 
 // /**节Id*/ 
 strCreateTabCode.Append(" SectionId char(8) Null, "); 
 // /**章名*/ 
 strCreateTabCode.Append(" ChapterName varchar(100) Null, "); 
 // /**节名*/ 
 strCreateTabCode.Append(" SectionName varchar(100) Null, "); 
 // /**章名简称*/ 
 strCreateTabCode.Append(" ChapterNameSim varchar(10) Null, "); 
 // /**节名简称*/ 
 strCreateTabCode.Append(" SectionNameSim varchar(10) Null, "); 
 // /**章节内容*/ 
 strCreateTabCode.Append(" ChapterContent text Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**父节点编号*/ 
 strCreateTabCode.Append(" ParentNodeId varchar(8) not Null, "); 
 // /**全校师生*/ 
 strCreateTabCode.Append(" IsOpenToAllStu bit not Null, "); 
 // /**全校师生公开*/ 
 strCreateTabCode.Append(" IsOpenToSchool bit not Null, "); 
 // /**社会公众*/ 
 strCreateTabCode.Append(" IsOpenToSocial bit not Null, "); 
 // /**是否必建栏目*/ 
 strCreateTabCode.Append(" IsMustMenu bit not Null, "); 
 // /**主题名*/ 
 strCreateTabCode.Append(" ThemeName varchar(200) Null, "); 
 // /**项目或文件夹*/ 
 strCreateTabCode.Append(" IsFile bit not Null, "); 
 // /**是否使用*/ 
 strCreateTabCode.Append(" IsUse bit Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" ViewCount int Null, "); 
 // /**节简称*/ 
 strCreateTabCode.Append(" CourseChapterReferred varchar(10) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" EditPeople varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**题目数*/ 
 strCreateTabCode.Append(" QuestionNum int Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：CourseId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strCourseId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strCourseId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concc_CourseChapter.CourseId, strCourseId);
 strCondition += string.Format(" order by OrderNum ");
List<clscc_CourseChapterEN> arrcc_CourseChapterObjList = new clscc_CourseChapterDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscc_CourseChapterEN objcc_CourseChapter in arrcc_CourseChapterObjList)
{
objcc_CourseChapter.OrderNum = intIndex;
UpdateBySql2(objcc_CourseChapter);
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
/// 调整所给关键字记录的序号。根据分类字段：CourseId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strCourseChapterId">所给的关键字</param>
/// <param name="strCourseId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strCourseChapterId ,string strCourseId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[CourseChapterId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字CourseChapterId
//5、把当前关键字CourseChapterId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字CourseChapterId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevCourseChapterId = "";    //上一条序号的关键字CourseChapterId
string strNextCourseChapterId = "";    //下一条序号的关键字CourseChapterId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[CourseChapterId],获取相应的序号[OrderNum]。

clscc_CourseChapterEN objcc_CourseChapter = clscc_CourseChapterBL.GetObjByCourseChapterId(strCourseChapterId);

intOrderNum = objcc_CourseChapter.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concc_CourseChapter.CourseId, strCourseId);
intTabRecNum = clscc_CourseChapterBL.GetRecCountByCond(clscc_CourseChapterEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", concc_CourseChapter.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", concc_CourseChapter.CourseId, strCourseId);
//4、获取上一个序号字段的关键字CourseChapterId
strPrevCourseChapterId = clscc_CourseChapterBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevCourseChapterId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字CourseChapterId所对应记录的序号减1
//6、把下(上)一个序号关键字CourseChapterId所对应的记录序号加1
clscc_CourseChapterBL.SetFldValue(clscc_CourseChapterEN._CurrTabName, concc_CourseChapter.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", concc_CourseChapter.CourseChapterId, strCourseChapterId));
clscc_CourseChapterBL.SetFldValue(clscc_CourseChapterEN._CurrTabName, concc_CourseChapter.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", concc_CourseChapter.CourseChapterId, strPrevCourseChapterId));
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

//4、获取下一个序号字段的关键字CourseChapterId
sbCondition.AppendFormat(" {0} = {1} ", concc_CourseChapter.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", concc_CourseChapter.CourseId, strCourseId);

strNextCourseChapterId = clscc_CourseChapterBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextCourseChapterId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字CourseChapterId所对应记录的序号加1
//6、把下(上)一个序号关键字CourseChapterId所对应的记录序号减1
clscc_CourseChapterBL.SetFldValue(clscc_CourseChapterEN._CurrTabName, concc_CourseChapter.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", concc_CourseChapter.CourseChapterId, strCourseChapterId));
clscc_CourseChapterBL.SetFldValue(clscc_CourseChapterEN._CurrTabName, concc_CourseChapter.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", concc_CourseChapter.CourseChapterId, strNextCourseChapterId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CourseId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId ,string strCourseId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", concc_CourseChapter.CourseChapterId, strKeyList);
List<clscc_CourseChapterEN> arrcc_CourseChapterLst = GetObjLst(strCondition);
foreach (clscc_CourseChapterEN objcc_CourseChapter in arrcc_CourseChapterLst)
{
objcc_CourseChapter.OrderNum = objcc_CourseChapter.OrderNum + 10000;
UpdateBySql2(objcc_CourseChapter);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concc_CourseChapter.CourseId, strCourseId);
 strCondition += string.Format(" order by OrderNum ");
List<clscc_CourseChapterEN> arrcc_CourseChapterObjList = new clscc_CourseChapterDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscc_CourseChapterEN objcc_CourseChapter in arrcc_CourseChapterObjList)
{
objcc_CourseChapter.OrderNum = intIndex;
UpdateBySql2(objcc_CourseChapter);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CourseId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strCourseId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId ,string strCourseId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", concc_CourseChapter.CourseChapterId, strKeyList);
List<clscc_CourseChapterEN> arrcc_CourseChapterLst = GetObjLst(strCondition);
foreach (clscc_CourseChapterEN objcc_CourseChapter in arrcc_CourseChapterLst)
{
objcc_CourseChapter.OrderNum = objcc_CourseChapter.OrderNum - 10000;
UpdateBySql2(objcc_CourseChapter);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", concc_CourseChapter.CourseId, strCourseId);
 strCondition += string.Format(" order by OrderNum ");
List<clscc_CourseChapterEN> arrcc_CourseChapterObjList = new clscc_CourseChapterDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clscc_CourseChapterEN objcc_CourseChapter in arrcc_CourseChapterObjList)
{
objcc_CourseChapter.OrderNum = intIndex;
UpdateBySql2(objcc_CourseChapter);
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
 /// 课程章节(cc_CourseChapter)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_CourseChapter : clsCommFun4BLV2
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
clscc_CourseChapterBL.ReFreshThisCache(strCourseId);
}
}

}