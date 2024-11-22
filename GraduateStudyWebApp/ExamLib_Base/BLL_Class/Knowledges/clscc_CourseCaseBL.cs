
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseCaseBL
 表名:cc_CourseCase(01120080)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clscc_CourseCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseCaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseCaseEN GetObj(this K_CourseCaseId_cc_CourseCase myKey)
{
clscc_CourseCaseEN objcc_CourseCaseEN = clscc_CourseCaseBL.cc_CourseCaseDA.GetObjByCourseCaseId(myKey.Value);
return objcc_CourseCaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (string.IsNullOrEmpty(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_CourseCaseBL.IsExist(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_CourseCaseEN.CourseCaseId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clscc_CourseCaseBL.cc_CourseCaseDA.AddNewRecordBySQL2(objcc_CourseCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
public static bool AddRecordEx(this clscc_CourseCaseEN objcc_CourseCaseEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clscc_CourseCaseBL.IsExist(objcc_CourseCaseEN.CourseCaseId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objcc_CourseCaseEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objcc_CourseCaseEN.AddNewRecord();
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
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (string.IsNullOrEmpty(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_CourseCaseBL.IsExist(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_CourseCaseEN.CourseCaseId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clscc_CourseCaseBL.cc_CourseCaseDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetCourseCaseId(this clscc_CourseCaseEN objcc_CourseCaseEN, string strCourseCaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCaseId, 8, concc_CourseCase.CourseCaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseCaseId, 8, concc_CourseCase.CourseCaseId);
}
objcc_CourseCaseEN.CourseCaseId = strCourseCaseId; //课程教案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.CourseCaseId) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.CourseCaseId, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.CourseCaseId] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetCourseChapterId(this clscc_CourseCaseEN objcc_CourseCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_CourseCase.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_CourseCase.CourseChapterId);
}
objcc_CourseCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.CourseChapterId) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.CourseChapterId, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.CourseChapterId] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetUserId(this clscc_CourseCaseEN objcc_CourseCaseEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, concc_CourseCase.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, concc_CourseCase.UserId);
}
objcc_CourseCaseEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.UserId) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.UserId, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.UserId] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetFilePath(this clscc_CourseCaseEN objcc_CourseCaseEN, string strFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, concc_CourseCase.FilePath);
}
objcc_CourseCaseEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.FilePath) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.FilePath, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.FilePath] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetFileSize(this clscc_CourseCaseEN objcc_CourseCaseEN, double? dblFileSize, string strComparisonOp="")
	{
objcc_CourseCaseEN.FileSize = dblFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.FileSize) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.FileSize, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.FileSize] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetFileSizeUnit(this clscc_CourseCaseEN objcc_CourseCaseEN, string strFileSizeUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, concc_CourseCase.FileSizeUnit);
}
objcc_CourseCaseEN.FileSizeUnit = strFileSizeUnit; //文件大小单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.FileSizeUnit) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.FileSizeUnit, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.FileSizeUnit] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetUploadDate(this clscc_CourseCaseEN objcc_CourseCaseEN, string strUploadDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadDate, 20, concc_CourseCase.UploadDate);
}
objcc_CourseCaseEN.UploadDate = strUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.UploadDate) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.UploadDate, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.UploadDate] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetIsShow(this clscc_CourseCaseEN objcc_CourseCaseEN, bool bolIsShow, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsShow, concc_CourseCase.IsShow);
objcc_CourseCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.IsShow) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.IsShow, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.IsShow] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetCourseResourceName(this clscc_CourseCaseEN objcc_CourseCaseEN, string strCourseResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseResourceName, 200, concc_CourseCase.CourseResourceName);
}
objcc_CourseCaseEN.CourseResourceName = strCourseResourceName; //教学视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.CourseResourceName) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.CourseResourceName, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.CourseResourceName] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetResourcePicPath(this clscc_CourseCaseEN objcc_CourseCaseEN, string strResourcePicPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourcePicPath, 500, concc_CourseCase.ResourcePicPath);
}
objcc_CourseCaseEN.ResourcePicPath = strResourcePicPath; //图片位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.ResourcePicPath) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.ResourcePicPath, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.ResourcePicPath] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetIsCast(this clscc_CourseCaseEN objcc_CourseCaseEN, bool bolIsCast, string strComparisonOp="")
	{
objcc_CourseCaseEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.IsCast) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.IsCast, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.IsCast] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetIsDown(this clscc_CourseCaseEN objcc_CourseCaseEN, bool bolIsDown, string strComparisonOp="")
	{
objcc_CourseCaseEN.IsDown = bolIsDown; //是否下载
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.IsDown) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.IsDown, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.IsDown] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetLikeCount(this clscc_CourseCaseEN objcc_CourseCaseEN, long? lngLikeCount, string strComparisonOp="")
	{
objcc_CourseCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.LikeCount) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.LikeCount, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.LikeCount] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetCourseId(this clscc_CourseCaseEN objcc_CourseCaseEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseCase.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseCase.CourseId);
}
objcc_CourseCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.CourseId) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.CourseId, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.CourseId] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseCaseEN SetResourceType(this clscc_CourseCaseEN objcc_CourseCaseEN, string strResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceType, 50, concc_CourseCase.ResourceType);
}
objcc_CourseCaseEN.ResourceType = strResourceType; //ResourceType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseCaseEN.dicFldComparisonOp.ContainsKey(concc_CourseCase.ResourceType) == false)
{
objcc_CourseCaseEN.dicFldComparisonOp.Add(concc_CourseCase.ResourceType, strComparisonOp);
}
else
{
objcc_CourseCaseEN.dicFldComparisonOp[concc_CourseCase.ResourceType] = strComparisonOp;
}
}
return objcc_CourseCaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_CourseCaseEN objcc_CourseCaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_CourseCaseEN.CheckPropertyNew();
clscc_CourseCaseEN objcc_CourseCaseCond = new clscc_CourseCaseEN();
string strCondition = objcc_CourseCaseCond
.SetCourseCaseId(objcc_CourseCaseEN.CourseCaseId, "=")
.GetCombineCondition();
objcc_CourseCaseEN._IsCheckProperty = true;
bool bolIsExist = clscc_CourseCaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_CourseCaseEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (string.IsNullOrEmpty(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseCaseBL.cc_CourseCaseDA.UpdateBySql2(objcc_CourseCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseCaseEN objcc_CourseCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseCaseBL.cc_CourseCaseDA.UpdateBySql2(objcc_CourseCaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "objcc_CourseCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseCaseEN objcc_CourseCaseEN, string strWhereCond)
{
try
{
bool bolResult = clscc_CourseCaseBL.cc_CourseCaseDA.UpdateBySqlWithCondition(objcc_CourseCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "objcc_CourseCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseCaseEN objcc_CourseCaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_CourseCaseBL.cc_CourseCaseDA.UpdateBySqlWithConditionTransaction(objcc_CourseCaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "strCourseCaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_CourseCaseEN objcc_CourseCaseEN)
{
try
{
int intRecNum = clscc_CourseCaseBL.cc_CourseCaseDA.DelRecord(objcc_CourseCaseEN.CourseCaseId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "objcc_CourseCaseENS">源对象</param>
 /// <param name = "objcc_CourseCaseENT">目标对象</param>
 public static void CopyTo(this clscc_CourseCaseEN objcc_CourseCaseENS, clscc_CourseCaseEN objcc_CourseCaseENT)
{
try
{
objcc_CourseCaseENT.CourseCaseId = objcc_CourseCaseENS.CourseCaseId; //课程教案Id
objcc_CourseCaseENT.CourseChapterId = objcc_CourseCaseENS.CourseChapterId; //课程章节ID
objcc_CourseCaseENT.UserId = objcc_CourseCaseENS.UserId; //用户ID
objcc_CourseCaseENT.FilePath = objcc_CourseCaseENS.FilePath; //文件路径
objcc_CourseCaseENT.FileSize = objcc_CourseCaseENS.FileSize; //文件大小
objcc_CourseCaseENT.FileSizeUnit = objcc_CourseCaseENS.FileSizeUnit; //文件大小单位
objcc_CourseCaseENT.UploadDate = objcc_CourseCaseENS.UploadDate; //上传时间
objcc_CourseCaseENT.IsShow = objcc_CourseCaseENS.IsShow; //是否启用
objcc_CourseCaseENT.CourseResourceName = objcc_CourseCaseENS.CourseResourceName; //教学视频名称
objcc_CourseCaseENT.ResourcePicPath = objcc_CourseCaseENS.ResourcePicPath; //图片位置
objcc_CourseCaseENT.IsCast = objcc_CourseCaseENS.IsCast; //是否播放
objcc_CourseCaseENT.IsDown = objcc_CourseCaseENS.IsDown; //是否下载
objcc_CourseCaseENT.LikeCount = objcc_CourseCaseENS.LikeCount; //资源喜欢数量
objcc_CourseCaseENT.CourseId = objcc_CourseCaseENS.CourseId; //课程Id
objcc_CourseCaseENT.ResourceType = objcc_CourseCaseENS.ResourceType; //ResourceType
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
 /// <param name = "objcc_CourseCaseENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseCaseEN:objcc_CourseCaseENT</returns>
 public static clscc_CourseCaseEN CopyTo(this clscc_CourseCaseEN objcc_CourseCaseENS)
{
try
{
 clscc_CourseCaseEN objcc_CourseCaseENT = new clscc_CourseCaseEN()
{
CourseCaseId = objcc_CourseCaseENS.CourseCaseId, //课程教案Id
CourseChapterId = objcc_CourseCaseENS.CourseChapterId, //课程章节ID
UserId = objcc_CourseCaseENS.UserId, //用户ID
FilePath = objcc_CourseCaseENS.FilePath, //文件路径
FileSize = objcc_CourseCaseENS.FileSize, //文件大小
FileSizeUnit = objcc_CourseCaseENS.FileSizeUnit, //文件大小单位
UploadDate = objcc_CourseCaseENS.UploadDate, //上传时间
IsShow = objcc_CourseCaseENS.IsShow, //是否启用
CourseResourceName = objcc_CourseCaseENS.CourseResourceName, //教学视频名称
ResourcePicPath = objcc_CourseCaseENS.ResourcePicPath, //图片位置
IsCast = objcc_CourseCaseENS.IsCast, //是否播放
IsDown = objcc_CourseCaseENS.IsDown, //是否下载
LikeCount = objcc_CourseCaseENS.LikeCount, //资源喜欢数量
CourseId = objcc_CourseCaseENS.CourseId, //课程Id
ResourceType = objcc_CourseCaseENS.ResourceType, //ResourceType
};
 return objcc_CourseCaseENT;
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
public static void CheckPropertyNew(this clscc_CourseCaseEN objcc_CourseCaseEN)
{
 clscc_CourseCaseBL.cc_CourseCaseDA.CheckPropertyNew(objcc_CourseCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_CourseCaseEN objcc_CourseCaseEN)
{
 clscc_CourseCaseBL.cc_CourseCaseDA.CheckProperty4Condition(objcc_CourseCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseCaseEN objcc_CourseCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.CourseCaseId) == true)
{
string strComparisonOpCourseCaseId = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.CourseCaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.CourseCaseId, objcc_CourseCaseCond.CourseCaseId, strComparisonOpCourseCaseId);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.CourseChapterId, objcc_CourseCaseCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.UserId) == true)
{
string strComparisonOpUserId = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.UserId, objcc_CourseCaseCond.UserId, strComparisonOpUserId);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.FilePath) == true)
{
string strComparisonOpFilePath = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.FilePath, objcc_CourseCaseCond.FilePath, strComparisonOpFilePath);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.FileSize) == true)
{
string strComparisonOpFileSize = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseCase.FileSize, objcc_CourseCaseCond.FileSize, strComparisonOpFileSize);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.FileSizeUnit) == true)
{
string strComparisonOpFileSizeUnit = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.FileSizeUnit, objcc_CourseCaseCond.FileSizeUnit, strComparisonOpFileSizeUnit);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.UploadDate) == true)
{
string strComparisonOpUploadDate = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.UploadDate, objcc_CourseCaseCond.UploadDate, strComparisonOpUploadDate);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.IsShow) == true)
{
if (objcc_CourseCaseCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseCase.IsShow);
}
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.CourseResourceName) == true)
{
string strComparisonOpCourseResourceName = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.CourseResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.CourseResourceName, objcc_CourseCaseCond.CourseResourceName, strComparisonOpCourseResourceName);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.ResourcePicPath) == true)
{
string strComparisonOpResourcePicPath = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.ResourcePicPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.ResourcePicPath, objcc_CourseCaseCond.ResourcePicPath, strComparisonOpResourcePicPath);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.IsCast) == true)
{
if (objcc_CourseCaseCond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseCase.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseCase.IsCast);
}
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.IsDown) == true)
{
if (objcc_CourseCaseCond.IsDown == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseCase.IsDown);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseCase.IsDown);
}
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.LikeCount) == true)
{
string strComparisonOpLikeCount = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseCase.LikeCount, objcc_CourseCaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.CourseId) == true)
{
string strComparisonOpCourseId = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.CourseId, objcc_CourseCaseCond.CourseId, strComparisonOpCourseId);
}
if (objcc_CourseCaseCond.IsUpdated(concc_CourseCase.ResourceType) == true)
{
string strComparisonOpResourceType = objcc_CourseCaseCond.dicFldComparisonOp[concc_CourseCase.ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseCase.ResourceType, objcc_CourseCaseCond.ResourceType, strComparisonOpResourceType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_CourseCase
{
public virtual bool UpdRelaTabDate(string strCourseCaseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 课程教案(cc_CourseCase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseCaseBL
{
public static RelatedActions_cc_CourseCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_CourseCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_CourseCaseDA cc_CourseCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_CourseCaseDA();
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
 public clscc_CourseCaseBL()
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
if (string.IsNullOrEmpty(clscc_CourseCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseCaseEN._ConnectString);
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
public static DataTable GetDataTable_cc_CourseCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_CourseCaseDA.GetDataTable_cc_CourseCase(strWhereCond);
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
objDT = cc_CourseCaseDA.GetDataTable(strWhereCond);
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
objDT = cc_CourseCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_CourseCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_CourseCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_CourseCaseDA.GetDataTable_Top(objTopPara);
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
objDT = cc_CourseCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_CourseCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_CourseCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseCaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_CourseCaseEN> GetObjLstByCourseCaseIdLst(List<string> arrCourseCaseIdLst)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseCaseIdLst, true);
 string strWhereCond = string.Format("CourseCaseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseCaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_CourseCaseEN> GetObjLstByCourseCaseIdLstCache(List<string> arrCourseCaseIdLst)
{
string strKey = string.Format("{0}", clscc_CourseCaseEN._CurrTabName);
List<clscc_CourseCaseEN> arrcc_CourseCaseObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseCaseEN> arrcc_CourseCaseObjLst_Sel =
arrcc_CourseCaseObjLstCache
.Where(x => arrCourseCaseIdLst.Contains(x.CourseCaseId));
return arrcc_CourseCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseCaseEN> GetObjLst(string strWhereCond)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
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
public static List<clscc_CourseCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_CourseCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_CourseCaseEN> GetSubObjLstCache(clscc_CourseCaseEN objcc_CourseCaseCond)
{
List<clscc_CourseCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseCase.AttributeName)
{
if (objcc_CourseCaseCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseCaseCond[strFldName].ToString());
}
else
{
if (objcc_CourseCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseCaseCond[strFldName]));
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
public static List<clscc_CourseCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
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
public static List<clscc_CourseCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
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
List<clscc_CourseCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_CourseCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_CourseCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
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
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
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
public static List<clscc_CourseCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_CourseCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_CourseCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
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
public static List<clscc_CourseCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_CourseCaseEN> arrObjLst = new List<clscc_CourseCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseCaseEN objcc_CourseCaseEN = new clscc_CourseCaseEN();
try
{
objcc_CourseCaseEN.CourseCaseId = objRow[concc_CourseCase.CourseCaseId].ToString().Trim(); //课程教案Id
objcc_CourseCaseEN.CourseChapterId = objRow[concc_CourseCase.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseCaseEN.UserId = objRow[concc_CourseCase.UserId].ToString().Trim(); //用户ID
objcc_CourseCaseEN.FilePath = objRow[concc_CourseCase.FilePath] == DBNull.Value ? null : objRow[concc_CourseCase.FilePath].ToString().Trim(); //文件路径
objcc_CourseCaseEN.FileSize = objRow[concc_CourseCase.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseCase.FileSize].ToString().Trim()); //文件大小
objcc_CourseCaseEN.FileSizeUnit = objRow[concc_CourseCase.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseCase.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseCaseEN.UploadDate = objRow[concc_CourseCase.UploadDate] == DBNull.Value ? null : objRow[concc_CourseCase.UploadDate].ToString().Trim(); //上传时间
objcc_CourseCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsShow].ToString().Trim()); //是否启用
objcc_CourseCaseEN.CourseResourceName = objRow[concc_CourseCase.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseCase.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseCaseEN.ResourcePicPath = objRow[concc_CourseCase.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseCase.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseCaseEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsCast].ToString().Trim()); //是否播放
objcc_CourseCaseEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseCase.IsDown].ToString().Trim()); //是否下载
objcc_CourseCaseEN.LikeCount = objRow[concc_CourseCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseCase.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseCaseEN.CourseId = objRow[concc_CourseCase.CourseId] == DBNull.Value ? null : objRow[concc_CourseCase.CourseId].ToString().Trim(); //课程Id
objcc_CourseCaseEN.ResourceType = objRow[concc_CourseCase.ResourceType] == DBNull.Value ? null : objRow[concc_CourseCase.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseCaseEN.CourseCaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_CourseCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_CourseCase(ref clscc_CourseCaseEN objcc_CourseCaseEN)
{
bool bolResult = cc_CourseCaseDA.Getcc_CourseCase(ref objcc_CourseCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseCaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseCaseEN GetObjByCourseCaseId(string strCourseCaseId)
{
if (strCourseCaseId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseCaseId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseCaseId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseCaseId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_CourseCaseEN objcc_CourseCaseEN = cc_CourseCaseDA.GetObjByCourseCaseId(strCourseCaseId);
return objcc_CourseCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_CourseCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_CourseCaseEN objcc_CourseCaseEN = cc_CourseCaseDA.GetFirstObj(strWhereCond);
 return objcc_CourseCaseEN;
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
public static clscc_CourseCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_CourseCaseEN objcc_CourseCaseEN = cc_CourseCaseDA.GetObjByDataRow(objRow);
 return objcc_CourseCaseEN;
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
public static clscc_CourseCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_CourseCaseEN objcc_CourseCaseEN = cc_CourseCaseDA.GetObjByDataRow(objRow);
 return objcc_CourseCaseEN;
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
 /// <param name = "strCourseCaseId">所给的关键字</param>
 /// <param name = "lstcc_CourseCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseCaseEN GetObjByCourseCaseIdFromList(string strCourseCaseId, List<clscc_CourseCaseEN> lstcc_CourseCaseObjLst)
{
foreach (clscc_CourseCaseEN objcc_CourseCaseEN in lstcc_CourseCaseObjLst)
{
if (objcc_CourseCaseEN.CourseCaseId == strCourseCaseId)
{
return objcc_CourseCaseEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strCourseCaseId;
 try
 {
 strCourseCaseId = new clscc_CourseCaseDA().GetFirstID(strWhereCond);
 return strCourseCaseId;
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
 arrList = cc_CourseCaseDA.GetID(strWhereCond);
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
bool bolIsExist = cc_CourseCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseCaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseCaseId)
{
if (string.IsNullOrEmpty(strCourseCaseId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseCaseId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_CourseCaseDA.IsExist(strCourseCaseId);
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
 bolIsExist = clscc_CourseCaseDA.IsExistTable();
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
 bolIsExist = cc_CourseCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (string.IsNullOrEmpty(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_CourseCaseBL.IsExist(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_CourseCaseEN.CourseCaseId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = cc_CourseCaseDA.AddNewRecordBySQL2(objcc_CourseCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (string.IsNullOrEmpty(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_CourseCaseBL.IsExist(objcc_CourseCaseEN.CourseCaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_CourseCaseEN.CourseCaseId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = cc_CourseCaseDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_CourseCaseEN objcc_CourseCaseEN)
{
try
{
bool bolResult = cc_CourseCaseDA.Update(objcc_CourseCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "objcc_CourseCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_CourseCaseEN objcc_CourseCaseEN)
{
 if (string.IsNullOrEmpty(objcc_CourseCaseEN.CourseCaseId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_CourseCaseDA.UpdateBySql2(objcc_CourseCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseCaseBL.ReFreshCache();

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
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
 /// <param name = "strCourseCaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCourseCaseId)
{
try
{
 clscc_CourseCaseEN objcc_CourseCaseEN = clscc_CourseCaseBL.GetObjByCourseCaseId(strCourseCaseId);

if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(objcc_CourseCaseEN.CourseCaseId, "SetUpdDate");
}
if (objcc_CourseCaseEN != null)
{
int intRecNum = cc_CourseCaseDA.DelRecord(strCourseCaseId);
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
/// <param name="strCourseCaseId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCourseCaseId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_CourseCase.CourseCaseId,
//strCourseCaseId);
//        clscc_CourseCaseBL.Delcc_CourseCasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseCaseBL.DelRecord(strCourseCaseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseCaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseCaseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCourseCaseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCourseCaseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_CourseCaseBL.relatedActions != null)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(strCourseCaseId, "UpdRelaTabDate");
}
bool bolResult = cc_CourseCaseDA.DelRecord(strCourseCaseId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCourseCaseIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_CourseCases(List<string> arrCourseCaseIdLst)
{
if (arrCourseCaseIdLst.Count == 0) return 0;
try
{
if (clscc_CourseCaseBL.relatedActions != null)
{
foreach (var strCourseCaseId in arrCourseCaseIdLst)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(strCourseCaseId, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_CourseCaseDA.Delcc_CourseCase(arrCourseCaseIdLst);
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
public static int Delcc_CourseCasesByCond(string strWhereCond)
{
try
{
if (clscc_CourseCaseBL.relatedActions != null)
{
List<string> arrCourseCaseId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCourseCaseId in arrCourseCaseId)
{
clscc_CourseCaseBL.relatedActions.UpdRelaTabDate(strCourseCaseId, "UpdRelaTabDate");
}
}
int intRecNum = cc_CourseCaseDA.Delcc_CourseCase(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_CourseCase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCourseCaseId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCourseCaseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseCaseDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseCaseBL.DelRecord(strCourseCaseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseCaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseCaseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_CourseCaseENS">源对象</param>
 /// <param name = "objcc_CourseCaseENT">目标对象</param>
 public static void CopyTo(clscc_CourseCaseEN objcc_CourseCaseENS, clscc_CourseCaseEN objcc_CourseCaseENT)
{
try
{
objcc_CourseCaseENT.CourseCaseId = objcc_CourseCaseENS.CourseCaseId; //课程教案Id
objcc_CourseCaseENT.CourseChapterId = objcc_CourseCaseENS.CourseChapterId; //课程章节ID
objcc_CourseCaseENT.UserId = objcc_CourseCaseENS.UserId; //用户ID
objcc_CourseCaseENT.FilePath = objcc_CourseCaseENS.FilePath; //文件路径
objcc_CourseCaseENT.FileSize = objcc_CourseCaseENS.FileSize; //文件大小
objcc_CourseCaseENT.FileSizeUnit = objcc_CourseCaseENS.FileSizeUnit; //文件大小单位
objcc_CourseCaseENT.UploadDate = objcc_CourseCaseENS.UploadDate; //上传时间
objcc_CourseCaseENT.IsShow = objcc_CourseCaseENS.IsShow; //是否启用
objcc_CourseCaseENT.CourseResourceName = objcc_CourseCaseENS.CourseResourceName; //教学视频名称
objcc_CourseCaseENT.ResourcePicPath = objcc_CourseCaseENS.ResourcePicPath; //图片位置
objcc_CourseCaseENT.IsCast = objcc_CourseCaseENS.IsCast; //是否播放
objcc_CourseCaseENT.IsDown = objcc_CourseCaseENS.IsDown; //是否下载
objcc_CourseCaseENT.LikeCount = objcc_CourseCaseENS.LikeCount; //资源喜欢数量
objcc_CourseCaseENT.CourseId = objcc_CourseCaseENS.CourseId; //课程Id
objcc_CourseCaseENT.ResourceType = objcc_CourseCaseENS.ResourceType; //ResourceType
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
 /// <param name = "objcc_CourseCaseEN">源简化对象</param>
 public static void SetUpdFlag(clscc_CourseCaseEN objcc_CourseCaseEN)
{
try
{
objcc_CourseCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_CourseCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_CourseCase.CourseCaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.CourseCaseId = objcc_CourseCaseEN.CourseCaseId; //课程教案Id
}
if (arrFldSet.Contains(concc_CourseCase.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.CourseChapterId = objcc_CourseCaseEN.CourseChapterId == "[null]" ? null :  objcc_CourseCaseEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(concc_CourseCase.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.UserId = objcc_CourseCaseEN.UserId; //用户ID
}
if (arrFldSet.Contains(concc_CourseCase.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.FilePath = objcc_CourseCaseEN.FilePath == "[null]" ? null :  objcc_CourseCaseEN.FilePath; //文件路径
}
if (arrFldSet.Contains(concc_CourseCase.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.FileSize = objcc_CourseCaseEN.FileSize; //文件大小
}
if (arrFldSet.Contains(concc_CourseCase.FileSizeUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.FileSizeUnit = objcc_CourseCaseEN.FileSizeUnit == "[null]" ? null :  objcc_CourseCaseEN.FileSizeUnit; //文件大小单位
}
if (arrFldSet.Contains(concc_CourseCase.UploadDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.UploadDate = objcc_CourseCaseEN.UploadDate == "[null]" ? null :  objcc_CourseCaseEN.UploadDate; //上传时间
}
if (arrFldSet.Contains(concc_CourseCase.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.IsShow = objcc_CourseCaseEN.IsShow; //是否启用
}
if (arrFldSet.Contains(concc_CourseCase.CourseResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.CourseResourceName = objcc_CourseCaseEN.CourseResourceName == "[null]" ? null :  objcc_CourseCaseEN.CourseResourceName; //教学视频名称
}
if (arrFldSet.Contains(concc_CourseCase.ResourcePicPath, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.ResourcePicPath = objcc_CourseCaseEN.ResourcePicPath == "[null]" ? null :  objcc_CourseCaseEN.ResourcePicPath; //图片位置
}
if (arrFldSet.Contains(concc_CourseCase.IsCast, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.IsCast = objcc_CourseCaseEN.IsCast; //是否播放
}
if (arrFldSet.Contains(concc_CourseCase.IsDown, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.IsDown = objcc_CourseCaseEN.IsDown; //是否下载
}
if (arrFldSet.Contains(concc_CourseCase.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.LikeCount = objcc_CourseCaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(concc_CourseCase.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.CourseId = objcc_CourseCaseEN.CourseId == "[null]" ? null :  objcc_CourseCaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_CourseCase.ResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseCaseEN.ResourceType = objcc_CourseCaseEN.ResourceType == "[null]" ? null :  objcc_CourseCaseEN.ResourceType; //ResourceType
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
 /// <param name = "objcc_CourseCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_CourseCaseEN objcc_CourseCaseEN)
{
try
{
if (objcc_CourseCaseEN.CourseChapterId == "[null]") objcc_CourseCaseEN.CourseChapterId = null; //课程章节ID
if (objcc_CourseCaseEN.FilePath == "[null]") objcc_CourseCaseEN.FilePath = null; //文件路径
if (objcc_CourseCaseEN.FileSizeUnit == "[null]") objcc_CourseCaseEN.FileSizeUnit = null; //文件大小单位
if (objcc_CourseCaseEN.UploadDate == "[null]") objcc_CourseCaseEN.UploadDate = null; //上传时间
if (objcc_CourseCaseEN.CourseResourceName == "[null]") objcc_CourseCaseEN.CourseResourceName = null; //教学视频名称
if (objcc_CourseCaseEN.ResourcePicPath == "[null]") objcc_CourseCaseEN.ResourcePicPath = null; //图片位置
if (objcc_CourseCaseEN.CourseId == "[null]") objcc_CourseCaseEN.CourseId = null; //课程Id
if (objcc_CourseCaseEN.ResourceType == "[null]") objcc_CourseCaseEN.ResourceType = null; //ResourceType
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
public static void CheckPropertyNew(clscc_CourseCaseEN objcc_CourseCaseEN)
{
 cc_CourseCaseDA.CheckPropertyNew(objcc_CourseCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_CourseCaseEN objcc_CourseCaseEN)
{
 cc_CourseCaseDA.CheckProperty4Condition(objcc_CourseCaseEN);
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
if (clscc_CourseCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseCaseBL没有刷新缓存机制(clscc_CourseCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseCaseId");
//if (arrcc_CourseCaseObjLstCache == null)
//{
//arrcc_CourseCaseObjLstCache = cc_CourseCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseCaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseCaseEN GetObjByCourseCaseIdCache(string strCourseCaseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_CourseCaseEN._CurrTabName);
List<clscc_CourseCaseEN> arrcc_CourseCaseObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseCaseEN> arrcc_CourseCaseObjLst_Sel =
arrcc_CourseCaseObjLstCache
.Where(x=> x.CourseCaseId == strCourseCaseId 
);
if (arrcc_CourseCaseObjLst_Sel.Count() == 0)
{
   clscc_CourseCaseEN obj = clscc_CourseCaseBL.GetObjByCourseCaseId(strCourseCaseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_CourseCaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseCaseEN> GetAllcc_CourseCaseObjLstCache()
{
//获取缓存中的对象列表
List<clscc_CourseCaseEN> arrcc_CourseCaseObjLstCache = GetObjLstCache(); 
return arrcc_CourseCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_CourseCaseEN._CurrTabName);
List<clscc_CourseCaseEN> arrcc_CourseCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_CourseCaseObjLstCache;
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
string strKey = string.Format("{0}", clscc_CourseCaseEN._CurrTabName);
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
if (clscc_CourseCaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_CourseCaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_CourseCaseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strCourseCaseId)
{
if (strInFldName != concc_CourseCase.CourseCaseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_CourseCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_CourseCase.AttributeName));
throw new Exception(strMsg);
}
var objcc_CourseCase = clscc_CourseCaseBL.GetObjByCourseCaseIdCache(strCourseCaseId);
if (objcc_CourseCase == null) return "";
return objcc_CourseCase[strOutFldName].ToString();
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
int intRecCount = clscc_CourseCaseDA.GetRecCount(strTabName);
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
int intRecCount = clscc_CourseCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_CourseCaseDA.GetRecCount();
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
int intRecCount = clscc_CourseCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_CourseCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_CourseCaseEN objcc_CourseCaseCond)
{
List<clscc_CourseCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseCase.AttributeName)
{
if (objcc_CourseCaseCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseCaseCond[strFldName].ToString());
}
else
{
if (objcc_CourseCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseCaseCond[strFldName]));
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
 List<string> arrList = clscc_CourseCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_CourseCaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseCaseDA.SetFldValue(clscc_CourseCaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_CourseCaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseCaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseCaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseCaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_CourseCase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**课程教案Id*/ 
 strCreateTabCode.Append(" CourseCaseId char(8) primary key, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) Null, "); 
 // /**文件大小*/ 
 strCreateTabCode.Append(" FileSize decimal(22,0) Null, "); 
 // /**文件大小单位*/ 
 strCreateTabCode.Append(" FileSizeUnit varchar(10) Null, "); 
 // /**上传时间*/ 
 strCreateTabCode.Append(" UploadDate varchar(20) Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit not Null, "); 
 // /**教学视频名称*/ 
 strCreateTabCode.Append(" CourseResourceName varchar(200) Null, "); 
 // /**图片位置*/ 
 strCreateTabCode.Append(" ResourcePicPath varchar(500) Null, "); 
 // /**是否播放*/ 
 strCreateTabCode.Append(" IsCast bit Null, "); 
 // /**是否下载*/ 
 strCreateTabCode.Append(" IsDown bit Null, "); 
 // /**资源喜欢数量*/ 
 strCreateTabCode.Append(" LikeCount bigint Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**ResourceType*/ 
 strCreateTabCode.Append(" ResourceType varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 课程教案(cc_CourseCase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_CourseCase : clsCommFun4BL
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
clscc_CourseCaseBL.ReFreshThisCache();
}
}

}