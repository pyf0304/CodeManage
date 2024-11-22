
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseBL
 表名:cc_Course(01120056)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clscc_CourseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseEN GetObj(this K_CourseId_cc_Course myKey)
{
clscc_CourseEN objcc_CourseEN = clscc_CourseBL.cc_CourseDA.GetObjByCourseId(myKey.Value);
return objcc_CourseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseEN objcc_CourseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}]的数据已经存在!(in clscc_CourseBL.AddNewRecord)", objcc_CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true || clscc_CourseBL.IsExist(objcc_CourseEN.CourseId) == true)
 {
     objcc_CourseEN.CourseId = clscc_CourseBL.GetMaxStrId_S();
 }
bool bolResult = clscc_CourseBL.cc_CourseDA.AddNewRecordBySQL2(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_CourseEN objcc_CourseEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscc_CourseBL.IsExist(objcc_CourseEN.CourseId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcc_CourseEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_CourseEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课程Id(CourseId)=[{0}])已经存在,不能重复!", objcc_CourseEN.CourseId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true || clscc_CourseBL.IsExist(objcc_CourseEN.CourseId) == true)
 {
     objcc_CourseEN.CourseId = clscc_CourseBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcc_CourseEN.AddNewRecord();
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_CourseEN objcc_CourseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}]的数据已经存在!(in clscc_CourseBL.AddNewRecordWithMaxId)", objcc_CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true || clscc_CourseBL.IsExist(objcc_CourseEN.CourseId) == true)
 {
     objcc_CourseEN.CourseId = clscc_CourseBL.GetMaxStrId_S();
 }
string strCourseId = clscc_CourseBL.cc_CourseDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseEN);
     objcc_CourseEN.CourseId = strCourseId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
}
return strCourseId;
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_CourseEN objcc_CourseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_CourseEN) == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}]的数据已经存在!(in clscc_CourseBL.AddNewRecordWithReturnKey)", objcc_CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true || clscc_CourseBL.IsExist(objcc_CourseEN.CourseId) == true)
 {
     objcc_CourseEN.CourseId = clscc_CourseBL.GetMaxStrId_S();
 }
string strKey = clscc_CourseBL.cc_CourseDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetCourseId(this clscc_CourseEN objcc_CourseEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_Course.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_Course.CourseId);
}
objcc_CourseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseId) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseId, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseId] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetCourseCode(this clscc_CourseEN objcc_CourseEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, concc_Course.CourseCode);
}
objcc_CourseEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseCode) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseCode, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseCode] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetCourseDescription(this clscc_CourseEN objcc_CourseEN, string strCourseDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, concc_Course.CourseDescription);
}
objcc_CourseEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseDescription) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseDescription, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseDescription] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetCourseName(this clscc_CourseEN objcc_CourseEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseName, concc_Course.CourseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, concc_Course.CourseName);
}
objcc_CourseEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseName) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseName, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseName] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetCourseTypeId(this clscc_CourseEN objcc_CourseEN, string strCourseTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeId, 4, concc_Course.CourseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeId, 4, concc_Course.CourseTypeId);
}
objcc_CourseEN.CourseTypeId = strCourseTypeId; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CourseTypeId) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CourseTypeId, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CourseTypeId] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetCreateDate(this clscc_CourseEN objcc_CourseEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_Course.CreateDate);
}
objcc_CourseEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.CreateDate) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.CreateDate, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.CreateDate] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetExcellentTypeId(this clscc_CourseEN objcc_CourseEN, string strExcellentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExcellentTypeId, 4, concc_Course.ExcellentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExcellentTypeId, 4, concc_Course.ExcellentTypeId);
}
objcc_CourseEN.ExcellentTypeId = strExcellentTypeId; //精品课程类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.ExcellentTypeId) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.ExcellentTypeId, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.ExcellentTypeId] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetExcellentYear(this clscc_CourseEN objcc_CourseEN, int? intExcellentYear, string strComparisonOp="")
	{
objcc_CourseEN.ExcellentYear = intExcellentYear; //课程年份
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.ExcellentYear) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.ExcellentYear, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.ExcellentYear] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetIsBuildingCourse(this clscc_CourseEN objcc_CourseEN, bool bolIsBuildingCourse, string strComparisonOp="")
	{
objcc_CourseEN.IsBuildingCourse = bolIsBuildingCourse; //是否已建设课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsBuildingCourse) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsBuildingCourse, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsBuildingCourse] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetIsDoubleLanguageCourse(this clscc_CourseEN objcc_CourseEN, bool bolIsDoubleLanguageCourse, string strComparisonOp="")
	{
objcc_CourseEN.IsDoubleLanguageCourse = bolIsDoubleLanguageCourse; //是否双语课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsDoubleLanguageCourse) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsDoubleLanguageCourse, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsDoubleLanguageCourse] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetIsOpen(this clscc_CourseEN objcc_CourseEN, bool bolIsOpen, string strComparisonOp="")
	{
objcc_CourseEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsOpen) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsOpen, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsOpen] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetIsRecommendedCourse(this clscc_CourseEN objcc_CourseEN, bool bolIsRecommendedCourse, string strComparisonOp="")
	{
objcc_CourseEN.IsRecommendedCourse = bolIsRecommendedCourse; //是否推荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsRecommendedCourse) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsRecommendedCourse, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsRecommendedCourse] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetIsSelfPropelledCourse(this clscc_CourseEN objcc_CourseEN, bool bolIsSelfPropelledCourse, string strComparisonOp="")
	{
objcc_CourseEN.IsSelfPropelledCourse = bolIsSelfPropelledCourse; //是否自荐课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsSelfPropelledCourse) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsSelfPropelledCourse, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsSelfPropelledCourse] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetOperationDate(this clscc_CourseEN objcc_CourseEN, string strOperationDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationDate, 20, concc_Course.OperationDate);
}
objcc_CourseEN.OperationDate = strOperationDate; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.OperationDate) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.OperationDate, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.OperationDate] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetOrderNum(this clscc_CourseEN objcc_CourseEN, int? intOrderNum, string strComparisonOp="")
	{
objcc_CourseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.OrderNum) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.OrderNum, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.OrderNum] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetOuterLink(this clscc_CourseEN objcc_CourseEN, string strOuterLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOuterLink, 500, concc_Course.OuterLink);
}
objcc_CourseEN.OuterLink = strOuterLink; //外链地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.OuterLink) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.OuterLink, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.OuterLink] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetViewCount(this clscc_CourseEN objcc_CourseEN, int? intViewCount, string strComparisonOp="")
	{
objcc_CourseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.ViewCount) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.ViewCount, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.ViewCount] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetThemeId(this clscc_CourseEN objcc_CourseEN, string strThemeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThemeId, 4, concc_Course.ThemeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strThemeId, 4, concc_Course.ThemeId);
}
objcc_CourseEN.ThemeId = strThemeId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.ThemeId) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.ThemeId, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.ThemeId] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetIdSchool(this clscc_CourseEN objcc_CourseEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, concc_Course.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, concc_Course.IdSchool);
}
objcc_CourseEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IdSchool) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IdSchool, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IdSchool] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetIdXzMajor(this clscc_CourseEN objcc_CourseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, concc_Course.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, concc_Course.IdXzMajor);
}
objcc_CourseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IdXzMajor) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IdXzMajor, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IdXzMajor] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetIdXzCollege(this clscc_CourseEN objcc_CourseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, concc_Course.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, concc_Course.IdXzCollege);
}
objcc_CourseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IdXzCollege) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IdXzCollege, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IdXzCollege] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetIsHasOpQues(this clscc_CourseEN objcc_CourseEN, bool bolIsHasOpQues, string strComparisonOp="")
	{
objcc_CourseEN.IsHasOpQues = bolIsHasOpQues; //是否有操作题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.IsHasOpQues) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.IsHasOpQues, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.IsHasOpQues] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetUpdDate(this clscc_CourseEN objcc_CourseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_Course.UpdDate);
}
objcc_CourseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.UpdDate) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.UpdDate, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.UpdDate] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetUpdUserId(this clscc_CourseEN objcc_CourseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_Course.UpdUserId);
}
objcc_CourseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.UpdUserId) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.UpdUserId, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.UpdUserId] = strComparisonOp;
}
}
return objcc_CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseEN SetMemo(this clscc_CourseEN objcc_CourseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_Course.Memo);
}
objcc_CourseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseEN.dicFldComparisonOp.ContainsKey(concc_Course.Memo) == false)
{
objcc_CourseEN.dicFldComparisonOp.Add(concc_Course.Memo, strComparisonOp);
}
else
{
objcc_CourseEN.dicFldComparisonOp[concc_Course.Memo] = strComparisonOp;
}
}
return objcc_CourseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_CourseEN objcc_CourseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_CourseEN.CheckPropertyNew();
clscc_CourseEN objcc_CourseCond = new clscc_CourseEN();
string strCondition = objcc_CourseCond
.SetCourseId(objcc_CourseEN.CourseId, "<>")
.SetCourseId(objcc_CourseEN.CourseId, "=")
.GetCombineCondition();
objcc_CourseEN._IsCheckProperty = true;
bool bolIsExist = clscc_CourseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CourseId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_CourseEN.Update();
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
 /// <param name = "objcc_Course">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_CourseEN objcc_Course)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_CourseEN objcc_CourseCond = new clscc_CourseEN();
string strCondition = objcc_CourseCond
.SetCourseId(objcc_Course.CourseId, "=")
.GetCombineCondition();
objcc_Course._IsCheckProperty = true;
bool bolIsExist = clscc_CourseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_Course.CourseId = clscc_CourseBL.GetFirstID_S(strCondition);
objcc_Course.UpdateWithCondition(strCondition);
}
else
{
objcc_Course.CourseId = clscc_CourseBL.GetMaxStrId_S();
objcc_Course.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseEN objcc_CourseEN)
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseBL.cc_CourseDA.UpdateBySql2(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseEN objcc_CourseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseBL.cc_CourseDA.UpdateBySql2(objcc_CourseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "objcc_CourseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseEN objcc_CourseEN, string strWhereCond)
{
try
{
bool bolResult = clscc_CourseBL.cc_CourseDA.UpdateBySqlWithCondition(objcc_CourseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "objcc_CourseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseEN objcc_CourseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_CourseBL.cc_CourseDA.UpdateBySqlWithConditionTransaction(objcc_CourseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_CourseEN objcc_CourseEN)
{
try
{
int intRecNum = clscc_CourseBL.cc_CourseDA.DelRecord(objcc_CourseEN.CourseId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "objcc_CourseENS">源对象</param>
 /// <param name = "objcc_CourseENT">目标对象</param>
 public static void CopyTo(this clscc_CourseEN objcc_CourseENS, clscc_CourseEN objcc_CourseENT)
{
try
{
objcc_CourseENT.CourseId = objcc_CourseENS.CourseId; //课程Id
objcc_CourseENT.CourseCode = objcc_CourseENS.CourseCode; //课程代码
objcc_CourseENT.CourseDescription = objcc_CourseENS.CourseDescription; //课程描述
objcc_CourseENT.CourseName = objcc_CourseENS.CourseName; //课程名称
objcc_CourseENT.CourseTypeId = objcc_CourseENS.CourseTypeId; //课程类型ID
objcc_CourseENT.CreateDate = objcc_CourseENS.CreateDate; //建立日期
objcc_CourseENT.ExcellentTypeId = objcc_CourseENS.ExcellentTypeId; //精品课程类型Id
objcc_CourseENT.ExcellentYear = objcc_CourseENS.ExcellentYear; //课程年份
objcc_CourseENT.IsBuildingCourse = objcc_CourseENS.IsBuildingCourse; //是否已建设课程
objcc_CourseENT.IsDoubleLanguageCourse = objcc_CourseENS.IsDoubleLanguageCourse; //是否双语课程
objcc_CourseENT.IsOpen = objcc_CourseENS.IsOpen; //是否公开
objcc_CourseENT.IsRecommendedCourse = objcc_CourseENS.IsRecommendedCourse; //是否推荐课程
objcc_CourseENT.IsSelfPropelledCourse = objcc_CourseENS.IsSelfPropelledCourse; //是否自荐课程
objcc_CourseENT.OperationDate = objcc_CourseENS.OperationDate; //操作时间
objcc_CourseENT.OrderNum = objcc_CourseENS.OrderNum; //序号
objcc_CourseENT.OuterLink = objcc_CourseENS.OuterLink; //外链地址
objcc_CourseENT.ViewCount = objcc_CourseENS.ViewCount; //浏览量
objcc_CourseENT.ThemeId = objcc_CourseENS.ThemeId; //主题Id
objcc_CourseENT.IdSchool = objcc_CourseENS.IdSchool; //学校流水号
objcc_CourseENT.IdXzMajor = objcc_CourseENS.IdXzMajor; //专业流水号
objcc_CourseENT.IdXzCollege = objcc_CourseENS.IdXzCollege; //学院流水号
objcc_CourseENT.IsHasOpQues = objcc_CourseENS.IsHasOpQues; //是否有操作题
objcc_CourseENT.UpdDate = objcc_CourseENS.UpdDate; //修改日期
objcc_CourseENT.UpdUserId = objcc_CourseENS.UpdUserId; //修改用户Id
objcc_CourseENT.Memo = objcc_CourseENS.Memo; //备注
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
 /// <param name = "objcc_CourseENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseEN:objcc_CourseENT</returns>
 public static clscc_CourseEN CopyTo(this clscc_CourseEN objcc_CourseENS)
{
try
{
 clscc_CourseEN objcc_CourseENT = new clscc_CourseEN()
{
CourseId = objcc_CourseENS.CourseId, //课程Id
CourseCode = objcc_CourseENS.CourseCode, //课程代码
CourseDescription = objcc_CourseENS.CourseDescription, //课程描述
CourseName = objcc_CourseENS.CourseName, //课程名称
CourseTypeId = objcc_CourseENS.CourseTypeId, //课程类型ID
CreateDate = objcc_CourseENS.CreateDate, //建立日期
ExcellentTypeId = objcc_CourseENS.ExcellentTypeId, //精品课程类型Id
ExcellentYear = objcc_CourseENS.ExcellentYear, //课程年份
IsBuildingCourse = objcc_CourseENS.IsBuildingCourse, //是否已建设课程
IsDoubleLanguageCourse = objcc_CourseENS.IsDoubleLanguageCourse, //是否双语课程
IsOpen = objcc_CourseENS.IsOpen, //是否公开
IsRecommendedCourse = objcc_CourseENS.IsRecommendedCourse, //是否推荐课程
IsSelfPropelledCourse = objcc_CourseENS.IsSelfPropelledCourse, //是否自荐课程
OperationDate = objcc_CourseENS.OperationDate, //操作时间
OrderNum = objcc_CourseENS.OrderNum, //序号
OuterLink = objcc_CourseENS.OuterLink, //外链地址
ViewCount = objcc_CourseENS.ViewCount, //浏览量
ThemeId = objcc_CourseENS.ThemeId, //主题Id
IdSchool = objcc_CourseENS.IdSchool, //学校流水号
IdXzMajor = objcc_CourseENS.IdXzMajor, //专业流水号
IdXzCollege = objcc_CourseENS.IdXzCollege, //学院流水号
IsHasOpQues = objcc_CourseENS.IsHasOpQues, //是否有操作题
UpdDate = objcc_CourseENS.UpdDate, //修改日期
UpdUserId = objcc_CourseENS.UpdUserId, //修改用户Id
Memo = objcc_CourseENS.Memo, //备注
};
 return objcc_CourseENT;
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
public static void CheckPropertyNew(this clscc_CourseEN objcc_CourseEN)
{
 clscc_CourseBL.cc_CourseDA.CheckPropertyNew(objcc_CourseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_CourseEN objcc_CourseEN)
{
 clscc_CourseBL.cc_CourseDA.CheckProperty4Condition(objcc_CourseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseEN objcc_CourseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseCond.IsUpdated(concc_Course.CourseId) == true)
{
string strComparisonOpCourseId = objcc_CourseCond.dicFldComparisonOp[concc_Course.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseId, objcc_CourseCond.CourseId, strComparisonOpCourseId);
}
if (objcc_CourseCond.IsUpdated(concc_Course.CourseCode) == true)
{
string strComparisonOpCourseCode = objcc_CourseCond.dicFldComparisonOp[concc_Course.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseCode, objcc_CourseCond.CourseCode, strComparisonOpCourseCode);
}
if (objcc_CourseCond.IsUpdated(concc_Course.CourseDescription) == true)
{
string strComparisonOpCourseDescription = objcc_CourseCond.dicFldComparisonOp[concc_Course.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseDescription, objcc_CourseCond.CourseDescription, strComparisonOpCourseDescription);
}
if (objcc_CourseCond.IsUpdated(concc_Course.CourseName) == true)
{
string strComparisonOpCourseName = objcc_CourseCond.dicFldComparisonOp[concc_Course.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseName, objcc_CourseCond.CourseName, strComparisonOpCourseName);
}
if (objcc_CourseCond.IsUpdated(concc_Course.CourseTypeId) == true)
{
string strComparisonOpCourseTypeId = objcc_CourseCond.dicFldComparisonOp[concc_Course.CourseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CourseTypeId, objcc_CourseCond.CourseTypeId, strComparisonOpCourseTypeId);
}
if (objcc_CourseCond.IsUpdated(concc_Course.CreateDate) == true)
{
string strComparisonOpCreateDate = objcc_CourseCond.dicFldComparisonOp[concc_Course.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.CreateDate, objcc_CourseCond.CreateDate, strComparisonOpCreateDate);
}
if (objcc_CourseCond.IsUpdated(concc_Course.ExcellentTypeId) == true)
{
string strComparisonOpExcellentTypeId = objcc_CourseCond.dicFldComparisonOp[concc_Course.ExcellentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.ExcellentTypeId, objcc_CourseCond.ExcellentTypeId, strComparisonOpExcellentTypeId);
}
if (objcc_CourseCond.IsUpdated(concc_Course.ExcellentYear) == true)
{
string strComparisonOpExcellentYear = objcc_CourseCond.dicFldComparisonOp[concc_Course.ExcellentYear];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Course.ExcellentYear, objcc_CourseCond.ExcellentYear, strComparisonOpExcellentYear);
}
if (objcc_CourseCond.IsUpdated(concc_Course.IsBuildingCourse) == true)
{
if (objcc_CourseCond.IsBuildingCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsBuildingCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsBuildingCourse);
}
}
if (objcc_CourseCond.IsUpdated(concc_Course.IsDoubleLanguageCourse) == true)
{
if (objcc_CourseCond.IsDoubleLanguageCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsDoubleLanguageCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsDoubleLanguageCourse);
}
}
if (objcc_CourseCond.IsUpdated(concc_Course.IsOpen) == true)
{
if (objcc_CourseCond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsOpen);
}
}
if (objcc_CourseCond.IsUpdated(concc_Course.IsRecommendedCourse) == true)
{
if (objcc_CourseCond.IsRecommendedCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsRecommendedCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsRecommendedCourse);
}
}
if (objcc_CourseCond.IsUpdated(concc_Course.IsSelfPropelledCourse) == true)
{
if (objcc_CourseCond.IsSelfPropelledCourse == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsSelfPropelledCourse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsSelfPropelledCourse);
}
}
if (objcc_CourseCond.IsUpdated(concc_Course.OperationDate) == true)
{
string strComparisonOpOperationDate = objcc_CourseCond.dicFldComparisonOp[concc_Course.OperationDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.OperationDate, objcc_CourseCond.OperationDate, strComparisonOpOperationDate);
}
if (objcc_CourseCond.IsUpdated(concc_Course.OrderNum) == true)
{
string strComparisonOpOrderNum = objcc_CourseCond.dicFldComparisonOp[concc_Course.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Course.OrderNum, objcc_CourseCond.OrderNum, strComparisonOpOrderNum);
}
if (objcc_CourseCond.IsUpdated(concc_Course.OuterLink) == true)
{
string strComparisonOpOuterLink = objcc_CourseCond.dicFldComparisonOp[concc_Course.OuterLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.OuterLink, objcc_CourseCond.OuterLink, strComparisonOpOuterLink);
}
if (objcc_CourseCond.IsUpdated(concc_Course.ViewCount) == true)
{
string strComparisonOpViewCount = objcc_CourseCond.dicFldComparisonOp[concc_Course.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Course.ViewCount, objcc_CourseCond.ViewCount, strComparisonOpViewCount);
}
if (objcc_CourseCond.IsUpdated(concc_Course.ThemeId) == true)
{
string strComparisonOpThemeId = objcc_CourseCond.dicFldComparisonOp[concc_Course.ThemeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.ThemeId, objcc_CourseCond.ThemeId, strComparisonOpThemeId);
}
if (objcc_CourseCond.IsUpdated(concc_Course.IdSchool) == true)
{
string strComparisonOpIdSchool = objcc_CourseCond.dicFldComparisonOp[concc_Course.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.IdSchool, objcc_CourseCond.IdSchool, strComparisonOpIdSchool);
}
if (objcc_CourseCond.IsUpdated(concc_Course.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objcc_CourseCond.dicFldComparisonOp[concc_Course.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.IdXzMajor, objcc_CourseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objcc_CourseCond.IsUpdated(concc_Course.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objcc_CourseCond.dicFldComparisonOp[concc_Course.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.IdXzCollege, objcc_CourseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objcc_CourseCond.IsUpdated(concc_Course.IsHasOpQues) == true)
{
if (objcc_CourseCond.IsHasOpQues == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_Course.IsHasOpQues);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_Course.IsHasOpQues);
}
}
if (objcc_CourseCond.IsUpdated(concc_Course.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_CourseCond.dicFldComparisonOp[concc_Course.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.UpdDate, objcc_CourseCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_CourseCond.IsUpdated(concc_Course.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_CourseCond.dicFldComparisonOp[concc_Course.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.UpdUserId, objcc_CourseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_CourseCond.IsUpdated(concc_Course.Memo) == true)
{
string strComparisonOpMemo = objcc_CourseCond.dicFldComparisonOp[concc_Course.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Course.Memo, objcc_CourseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_Course(课程), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_CourseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_CourseEN objcc_CourseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseEN == null) return true;
if (objcc_CourseEN.CourseId == null || objcc_CourseEN.CourseId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseEN.CourseId);
if (clscc_CourseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CourseId !=  '{0}'", objcc_CourseEN.CourseId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseEN.CourseId);
if (clscc_CourseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_Course(课程), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_CourseEN objcc_CourseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseEN == null) return "";
if (objcc_CourseEN.CourseId == null || objcc_CourseEN.CourseId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseEN.CourseId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CourseId !=  '{0}'", objcc_CourseEN.CourseId);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseEN.CourseId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_Course
{
public virtual bool UpdRelaTabDate(string strCourseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 课程(cc_Course)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseBL
{
public static RelatedActions_cc_Course relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_CourseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_CourseDA cc_CourseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_CourseDA();
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
 public clscc_CourseBL()
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
if (string.IsNullOrEmpty(clscc_CourseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseEN._ConnectString);
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
public static DataTable GetDataTable_cc_Course(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_CourseDA.GetDataTable_cc_Course(strWhereCond);
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
objDT = cc_CourseDA.GetDataTable(strWhereCond);
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
objDT = cc_CourseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_CourseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_CourseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_CourseDA.GetDataTable_Top(objTopPara);
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
objDT = cc_CourseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_CourseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_CourseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_CourseEN> GetObjLstByCourseIdLst(List<string> arrCourseIdLst)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseIdLst, true);
 string strWhereCond = string.Format("CourseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_CourseEN> GetObjLstByCourseIdLstCache(List<string> arrCourseIdLst)
{
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName);
List<clscc_CourseEN> arrcc_CourseObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseEN> arrcc_CourseObjLst_Sel =
arrcc_CourseObjLstCache
.Where(x => arrCourseIdLst.Contains(x.CourseId));
return arrcc_CourseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseEN> GetObjLst(string strWhereCond)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
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
public static List<clscc_CourseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_CourseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_CourseEN> GetSubObjLstCache(clscc_CourseEN objcc_CourseCond)
{
List<clscc_CourseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_Course.AttributeName)
{
if (objcc_CourseCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseCond[strFldName].ToString());
}
else
{
if (objcc_CourseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseCond[strFldName]));
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
public static List<clscc_CourseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
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
public static List<clscc_CourseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
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
List<clscc_CourseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_CourseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_CourseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
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
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
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
public static List<clscc_CourseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_CourseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_CourseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
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
public static List<clscc_CourseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseEN.CourseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_CourseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_Course(ref clscc_CourseEN objcc_CourseEN)
{
bool bolResult = cc_CourseDA.Getcc_Course(ref objcc_CourseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseEN GetObjByCourseId(string strCourseId)
{
if (strCourseId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_CourseEN objcc_CourseEN = cc_CourseDA.GetObjByCourseId(strCourseId);
return objcc_CourseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_CourseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_CourseEN objcc_CourseEN = cc_CourseDA.GetFirstObj(strWhereCond);
 return objcc_CourseEN;
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
public static clscc_CourseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_CourseEN objcc_CourseEN = cc_CourseDA.GetObjByDataRow(objRow);
 return objcc_CourseEN;
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
public static clscc_CourseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_CourseEN objcc_CourseEN = cc_CourseDA.GetObjByDataRow(objRow);
 return objcc_CourseEN;
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
 /// <param name = "strCourseId">所给的关键字</param>
 /// <param name = "lstcc_CourseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseEN GetObjByCourseIdFromList(string strCourseId, List<clscc_CourseEN> lstcc_CourseObjLst)
{
foreach (clscc_CourseEN objcc_CourseEN in lstcc_CourseObjLst)
{
if (objcc_CourseEN.CourseId == strCourseId)
{
return objcc_CourseEN;
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
 string strMaxCourseId;
 try
 {
 strMaxCourseId = clscc_CourseDA.GetMaxStrId();
 return strMaxCourseId;
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
 string strCourseId;
 try
 {
 strCourseId = new clscc_CourseDA().GetFirstID(strWhereCond);
 return strCourseId;
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
 arrList = cc_CourseDA.GetID(strWhereCond);
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
bool bolIsExist = cc_CourseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_CourseDA.IsExist(strCourseId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCourseId">课程Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCourseId, string strOpUser)
{
clscc_CourseEN objcc_CourseEN = clscc_CourseBL.GetObjByCourseId(strCourseId);
objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_CourseEN.UpdUserId = strOpUser;
return clscc_CourseBL.UpdateBySql2(objcc_CourseEN);
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
 bolIsExist = clscc_CourseDA.IsExistTable();
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
 bolIsExist = cc_CourseDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_CourseEN objcc_CourseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}]的数据已经存在!(in clscc_CourseBL.AddNewRecordBySql2)", objcc_CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true || clscc_CourseBL.IsExist(objcc_CourseEN.CourseId) == true)
 {
     objcc_CourseEN.CourseId = clscc_CourseBL.GetMaxStrId_S();
 }
bool bolResult = cc_CourseDA.AddNewRecordBySQL2(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_CourseEN objcc_CourseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_CourseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程Id = [{0}]的数据已经存在!(in clscc_CourseBL.AddNewRecordBySql2WithReturnKey)", objcc_CourseEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true || clscc_CourseBL.IsExist(objcc_CourseEN.CourseId) == true)
 {
     objcc_CourseEN.CourseId = clscc_CourseBL.GetMaxStrId_S();
 }
string strKey = cc_CourseDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_CourseEN objcc_CourseEN)
{
try
{
bool bolResult = cc_CourseDA.Update(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_CourseEN objcc_CourseEN)
{
 if (string.IsNullOrEmpty(objcc_CourseEN.CourseId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_CourseDA.UpdateBySql2(objcc_CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseBL.ReFreshCache();

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
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
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCourseId)
{
try
{
 clscc_CourseEN objcc_CourseEN = clscc_CourseBL.GetObjByCourseId(strCourseId);

if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(objcc_CourseEN.CourseId, objcc_CourseEN.UpdUserId);
}
if (objcc_CourseEN != null)
{
int intRecNum = cc_CourseDA.DelRecord(strCourseId);
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
/// <param name="strCourseId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCourseId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseDA.GetSpecSQLObj();
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
//删除与表:[cc_Course]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_Course.CourseId,
//strCourseId);
//        clscc_CourseBL.Delcc_CoursesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseBL.DelRecord(strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_CourseBL.relatedActions != null)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(strCourseId, "UpdRelaTabDate");
}
bool bolResult = cc_CourseDA.DelRecord(strCourseId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCourseIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_Courses(List<string> arrCourseIdLst)
{
if (arrCourseIdLst.Count == 0) return 0;
try
{
if (clscc_CourseBL.relatedActions != null)
{
foreach (var strCourseId in arrCourseIdLst)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(strCourseId, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_CourseDA.Delcc_Course(arrCourseIdLst);
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
public static int Delcc_CoursesByCond(string strWhereCond)
{
try
{
if (clscc_CourseBL.relatedActions != null)
{
List<string> arrCourseId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCourseId in arrCourseId)
{
clscc_CourseBL.relatedActions.UpdRelaTabDate(strCourseId, "UpdRelaTabDate");
}
}
int intRecNum = cc_CourseDA.Delcc_Course(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_Course]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCourseId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseDA.GetSpecSQLObj();
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
//删除与表:[cc_Course]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseBL.DelRecord(strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_CourseENS">源对象</param>
 /// <param name = "objcc_CourseENT">目标对象</param>
 public static void CopyTo(clscc_CourseEN objcc_CourseENS, clscc_CourseEN objcc_CourseENT)
{
try
{
objcc_CourseENT.CourseId = objcc_CourseENS.CourseId; //课程Id
objcc_CourseENT.CourseCode = objcc_CourseENS.CourseCode; //课程代码
objcc_CourseENT.CourseDescription = objcc_CourseENS.CourseDescription; //课程描述
objcc_CourseENT.CourseName = objcc_CourseENS.CourseName; //课程名称
objcc_CourseENT.CourseTypeId = objcc_CourseENS.CourseTypeId; //课程类型ID
objcc_CourseENT.CreateDate = objcc_CourseENS.CreateDate; //建立日期
objcc_CourseENT.ExcellentTypeId = objcc_CourseENS.ExcellentTypeId; //精品课程类型Id
objcc_CourseENT.ExcellentYear = objcc_CourseENS.ExcellentYear; //课程年份
objcc_CourseENT.IsBuildingCourse = objcc_CourseENS.IsBuildingCourse; //是否已建设课程
objcc_CourseENT.IsDoubleLanguageCourse = objcc_CourseENS.IsDoubleLanguageCourse; //是否双语课程
objcc_CourseENT.IsOpen = objcc_CourseENS.IsOpen; //是否公开
objcc_CourseENT.IsRecommendedCourse = objcc_CourseENS.IsRecommendedCourse; //是否推荐课程
objcc_CourseENT.IsSelfPropelledCourse = objcc_CourseENS.IsSelfPropelledCourse; //是否自荐课程
objcc_CourseENT.OperationDate = objcc_CourseENS.OperationDate; //操作时间
objcc_CourseENT.OrderNum = objcc_CourseENS.OrderNum; //序号
objcc_CourseENT.OuterLink = objcc_CourseENS.OuterLink; //外链地址
objcc_CourseENT.ViewCount = objcc_CourseENS.ViewCount; //浏览量
objcc_CourseENT.ThemeId = objcc_CourseENS.ThemeId; //主题Id
objcc_CourseENT.IdSchool = objcc_CourseENS.IdSchool; //学校流水号
objcc_CourseENT.IdXzMajor = objcc_CourseENS.IdXzMajor; //专业流水号
objcc_CourseENT.IdXzCollege = objcc_CourseENS.IdXzCollege; //学院流水号
objcc_CourseENT.IsHasOpQues = objcc_CourseENS.IsHasOpQues; //是否有操作题
objcc_CourseENT.UpdDate = objcc_CourseENS.UpdDate; //修改日期
objcc_CourseENT.UpdUserId = objcc_CourseENS.UpdUserId; //修改用户Id
objcc_CourseENT.Memo = objcc_CourseENS.Memo; //备注
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
 /// <param name = "objcc_CourseEN">源简化对象</param>
 public static void SetUpdFlag(clscc_CourseEN objcc_CourseEN)
{
try
{
objcc_CourseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_CourseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_Course.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.CourseId = objcc_CourseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_Course.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.CourseCode = objcc_CourseEN.CourseCode == "[null]" ? null :  objcc_CourseEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(concc_Course.CourseDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.CourseDescription = objcc_CourseEN.CourseDescription == "[null]" ? null :  objcc_CourseEN.CourseDescription; //课程描述
}
if (arrFldSet.Contains(concc_Course.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.CourseName = objcc_CourseEN.CourseName; //课程名称
}
if (arrFldSet.Contains(concc_Course.CourseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.CourseTypeId = objcc_CourseEN.CourseTypeId == "[null]" ? null :  objcc_CourseEN.CourseTypeId; //课程类型ID
}
if (arrFldSet.Contains(concc_Course.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.CreateDate = objcc_CourseEN.CreateDate == "[null]" ? null :  objcc_CourseEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(concc_Course.ExcellentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.ExcellentTypeId = objcc_CourseEN.ExcellentTypeId == "[null]" ? null :  objcc_CourseEN.ExcellentTypeId; //精品课程类型Id
}
if (arrFldSet.Contains(concc_Course.ExcellentYear, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.ExcellentYear = objcc_CourseEN.ExcellentYear; //课程年份
}
if (arrFldSet.Contains(concc_Course.IsBuildingCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.IsBuildingCourse = objcc_CourseEN.IsBuildingCourse; //是否已建设课程
}
if (arrFldSet.Contains(concc_Course.IsDoubleLanguageCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.IsDoubleLanguageCourse = objcc_CourseEN.IsDoubleLanguageCourse; //是否双语课程
}
if (arrFldSet.Contains(concc_Course.IsOpen, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.IsOpen = objcc_CourseEN.IsOpen; //是否公开
}
if (arrFldSet.Contains(concc_Course.IsRecommendedCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.IsRecommendedCourse = objcc_CourseEN.IsRecommendedCourse; //是否推荐课程
}
if (arrFldSet.Contains(concc_Course.IsSelfPropelledCourse, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.IsSelfPropelledCourse = objcc_CourseEN.IsSelfPropelledCourse; //是否自荐课程
}
if (arrFldSet.Contains(concc_Course.OperationDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.OperationDate = objcc_CourseEN.OperationDate == "[null]" ? null :  objcc_CourseEN.OperationDate; //操作时间
}
if (arrFldSet.Contains(concc_Course.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.OrderNum = objcc_CourseEN.OrderNum; //序号
}
if (arrFldSet.Contains(concc_Course.OuterLink, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.OuterLink = objcc_CourseEN.OuterLink == "[null]" ? null :  objcc_CourseEN.OuterLink; //外链地址
}
if (arrFldSet.Contains(concc_Course.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.ViewCount = objcc_CourseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(concc_Course.ThemeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.ThemeId = objcc_CourseEN.ThemeId == "[null]" ? null :  objcc_CourseEN.ThemeId; //主题Id
}
if (arrFldSet.Contains(concc_Course.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.IdSchool = objcc_CourseEN.IdSchool == "[null]" ? null :  objcc_CourseEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(concc_Course.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.IdXzMajor = objcc_CourseEN.IdXzMajor == "[null]" ? null :  objcc_CourseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(concc_Course.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.IdXzCollege = objcc_CourseEN.IdXzCollege == "[null]" ? null :  objcc_CourseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(concc_Course.IsHasOpQues, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.IsHasOpQues = objcc_CourseEN.IsHasOpQues; //是否有操作题
}
if (arrFldSet.Contains(concc_Course.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.UpdDate = objcc_CourseEN.UpdDate == "[null]" ? null :  objcc_CourseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_Course.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.UpdUserId = objcc_CourseEN.UpdUserId == "[null]" ? null :  objcc_CourseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_Course.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseEN.Memo = objcc_CourseEN.Memo == "[null]" ? null :  objcc_CourseEN.Memo; //备注
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
 /// <param name = "objcc_CourseEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_CourseEN objcc_CourseEN)
{
try
{
if (objcc_CourseEN.CourseCode == "[null]") objcc_CourseEN.CourseCode = null; //课程代码
if (objcc_CourseEN.CourseDescription == "[null]") objcc_CourseEN.CourseDescription = null; //课程描述
if (objcc_CourseEN.CourseTypeId == "[null]") objcc_CourseEN.CourseTypeId = null; //课程类型ID
if (objcc_CourseEN.CreateDate == "[null]") objcc_CourseEN.CreateDate = null; //建立日期
if (objcc_CourseEN.ExcellentTypeId == "[null]") objcc_CourseEN.ExcellentTypeId = null; //精品课程类型Id
if (objcc_CourseEN.OperationDate == "[null]") objcc_CourseEN.OperationDate = null; //操作时间
if (objcc_CourseEN.OuterLink == "[null]") objcc_CourseEN.OuterLink = null; //外链地址
if (objcc_CourseEN.ThemeId == "[null]") objcc_CourseEN.ThemeId = null; //主题Id
if (objcc_CourseEN.IdSchool == "[null]") objcc_CourseEN.IdSchool = null; //学校流水号
if (objcc_CourseEN.IdXzMajor == "[null]") objcc_CourseEN.IdXzMajor = null; //专业流水号
if (objcc_CourseEN.IdXzCollege == "[null]") objcc_CourseEN.IdXzCollege = null; //学院流水号
if (objcc_CourseEN.UpdDate == "[null]") objcc_CourseEN.UpdDate = null; //修改日期
if (objcc_CourseEN.UpdUserId == "[null]") objcc_CourseEN.UpdUserId = null; //修改用户Id
if (objcc_CourseEN.Memo == "[null]") objcc_CourseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_CourseEN objcc_CourseEN)
{
 cc_CourseDA.CheckPropertyNew(objcc_CourseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_CourseEN objcc_CourseEN)
{
 cc_CourseDA.CheckProperty4Condition(objcc_CourseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CourseIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程]...","0");
List<clscc_CourseEN> arrcc_CourseObjLst = GetAllcc_CourseObjLstCache(); 
objDDL.DataValueField = concc_Course.CourseId;
objDDL.DataTextField = concc_Course.CourseName;
objDDL.DataSource = arrcc_CourseObjLst;
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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseId");
//if (arrcc_CourseObjLstCache == null)
//{
//arrcc_CourseObjLstCache = cc_CourseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseEN GetObjByCourseIdCache(string strCourseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName);
List<clscc_CourseEN> arrcc_CourseObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseEN> arrcc_CourseObjLst_Sel =
arrcc_CourseObjLstCache
.Where(x=> x.CourseId == strCourseId 
);
if (arrcc_CourseObjLst_Sel.Count() == 0)
{
   clscc_CourseEN obj = clscc_CourseBL.GetObjByCourseId(strCourseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_CourseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseNameByCourseIdCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return "";
//获取缓存中的对象列表
clscc_CourseEN objcc_Course = GetObjByCourseIdCache(strCourseId);
if (objcc_Course == null) return "";
return objcc_Course.CourseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCourseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCourseIdCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true) return "";
//获取缓存中的对象列表
clscc_CourseEN objcc_Course = GetObjByCourseIdCache(strCourseId);
if (objcc_Course == null) return "";
return objcc_Course.CourseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseEN> GetAllcc_CourseObjLstCache()
{
//获取缓存中的对象列表
List<clscc_CourseEN> arrcc_CourseObjLstCache = GetObjLstCache(); 
return arrcc_CourseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName);
List<clscc_CourseEN> arrcc_CourseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_CourseObjLstCache;
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
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_CourseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_CourseEN._RefreshTimeLst.Count == 0) return "";
return clscc_CourseEN._RefreshTimeLst[clscc_CourseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_CourseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_CourseEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_CourseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_CourseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_Course(课程)
 /// 唯一性条件:CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_CourseEN objcc_CourseEN)
{
//检测记录是否存在
string strResult = cc_CourseDA.GetUniCondStr(objcc_CourseEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCourseId)
{
if (strInFldName != concc_Course.CourseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_Course.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_Course.AttributeName));
throw new Exception(strMsg);
}
var objcc_Course = clscc_CourseBL.GetObjByCourseIdCache(strCourseId);
if (objcc_Course == null) return "";
return objcc_Course[strOutFldName].ToString();
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
int intRecCount = clscc_CourseDA.GetRecCount(strTabName);
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
int intRecCount = clscc_CourseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_CourseDA.GetRecCount();
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
int intRecCount = clscc_CourseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_CourseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_CourseEN objcc_CourseCond)
{
List<clscc_CourseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_Course.AttributeName)
{
if (objcc_CourseCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseCond[strFldName].ToString());
}
else
{
if (objcc_CourseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseCond[strFldName]));
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
 List<string> arrList = clscc_CourseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_CourseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseDA.SetFldValue(clscc_CourseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_CourseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_Course] "); 
 strCreateTabCode.Append(" ( "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) primary key, "); 
 // /**课程代码*/ 
 strCreateTabCode.Append(" CourseCode varchar(20) Null, "); 
 // /**课程描述*/ 
 strCreateTabCode.Append(" CourseDescription varchar(8000) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) not Null, "); 
 // /**课程类型ID*/ 
 strCreateTabCode.Append(" CourseTypeId char(4) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**精品课程类型Id*/ 
 strCreateTabCode.Append(" ExcellentTypeId char(4) Null, "); 
 // /**课程年份*/ 
 strCreateTabCode.Append(" ExcellentYear int Null, "); 
 // /**是否已建设课程*/ 
 strCreateTabCode.Append(" IsBuildingCourse bit Null, "); 
 // /**是否双语课程*/ 
 strCreateTabCode.Append(" IsDoubleLanguageCourse bit Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsOpen bit Null, "); 
 // /**是否推荐课程*/ 
 strCreateTabCode.Append(" IsRecommendedCourse bit Null, "); 
 // /**是否自荐课程*/ 
 strCreateTabCode.Append(" IsSelfPropelledCourse bit Null, "); 
 // /**操作时间*/ 
 strCreateTabCode.Append(" OperationDate varchar(20) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**外链地址*/ 
 strCreateTabCode.Append(" OuterLink varchar(500) Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" ViewCount int Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" ThemeId char(4) Null, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**是否有操作题*/ 
 strCreateTabCode.Append(" IsHasOpQues bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**学校名称*/ 
 strCreateTabCode.Append(" SchoolName varchar(50) Null, "); 
 // /**课程类型名称*/ 
 strCreateTabCode.Append(" CourseTypeName varchar(30) Null, "); 
 // /**精品课程类型名称*/ 
 strCreateTabCode.Append(" ExcellentTypeName varchar(30) Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 课程(cc_Course)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_Course : clsCommFun4BL
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
clscc_CourseBL.ReFreshThisCache();
}
}

}