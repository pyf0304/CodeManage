
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseVideoBL
 表名:cc_CourseVideo(01120081)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:12
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
public static class  clscc_CourseVideoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseVideoId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseVideoEN GetObj(this K_CourseVideoId_cc_CourseVideo myKey)
{
clscc_CourseVideoEN objcc_CourseVideoEN = clscc_CourseVideoBL.cc_CourseVideoDA.GetObjByCourseVideoId(myKey.Value);
return objcc_CourseVideoEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (string.IsNullOrEmpty(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_CourseVideoBL.IsExist(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_CourseVideoEN.CourseVideoId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clscc_CourseVideoBL.cc_CourseVideoDA.AddNewRecordBySQL2(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
public static bool AddRecordEx(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clscc_CourseVideoBL.IsExist(objcc_CourseVideoEN.CourseVideoId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objcc_CourseVideoEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objcc_CourseVideoEN.AddNewRecord();
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
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (string.IsNullOrEmpty(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_CourseVideoBL.IsExist(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_CourseVideoEN.CourseVideoId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clscc_CourseVideoBL.cc_CourseVideoDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetCourseVideoId(this clscc_CourseVideoEN objcc_CourseVideoEN, string strCourseVideoId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseVideoId, 8, concc_CourseVideo.CourseVideoId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseVideoId, 8, concc_CourseVideo.CourseVideoId);
}
objcc_CourseVideoEN.CourseVideoId = strCourseVideoId; //课程视频Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.CourseVideoId) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.CourseVideoId, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.CourseVideoId] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetUserId(this clscc_CourseVideoEN objcc_CourseVideoEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, concc_CourseVideo.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, concc_CourseVideo.UserId);
}
objcc_CourseVideoEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.UserId) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.UserId, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.UserId] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetFilePath(this clscc_CourseVideoEN objcc_CourseVideoEN, string strFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, concc_CourseVideo.FilePath);
}
objcc_CourseVideoEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.FilePath) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.FilePath, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.FilePath] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetFileSize(this clscc_CourseVideoEN objcc_CourseVideoEN, double? dblFileSize, string strComparisonOp="")
	{
objcc_CourseVideoEN.FileSize = dblFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.FileSize) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.FileSize, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.FileSize] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetFileSizeUnit(this clscc_CourseVideoEN objcc_CourseVideoEN, string strFileSizeUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, concc_CourseVideo.FileSizeUnit);
}
objcc_CourseVideoEN.FileSizeUnit = strFileSizeUnit; //文件大小单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.FileSizeUnit) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.FileSizeUnit, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.FileSizeUnit] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetUploadDate(this clscc_CourseVideoEN objcc_CourseVideoEN, string strUploadDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadDate, 20, concc_CourseVideo.UploadDate);
}
objcc_CourseVideoEN.UploadDate = strUploadDate; //上传时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.UploadDate) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.UploadDate, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.UploadDate] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetIsShow(this clscc_CourseVideoEN objcc_CourseVideoEN, bool bolIsShow, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsShow, concc_CourseVideo.IsShow);
objcc_CourseVideoEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.IsShow) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.IsShow, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.IsShow] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetCourseResourceName(this clscc_CourseVideoEN objcc_CourseVideoEN, string strCourseResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseResourceName, 200, concc_CourseVideo.CourseResourceName);
}
objcc_CourseVideoEN.CourseResourceName = strCourseResourceName; //教学视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.CourseResourceName) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.CourseResourceName, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.CourseResourceName] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetResourcePicPath(this clscc_CourseVideoEN objcc_CourseVideoEN, string strResourcePicPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourcePicPath, 500, concc_CourseVideo.ResourcePicPath);
}
objcc_CourseVideoEN.ResourcePicPath = strResourcePicPath; //图片位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.ResourcePicPath) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.ResourcePicPath, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.ResourcePicPath] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetIsCast(this clscc_CourseVideoEN objcc_CourseVideoEN, bool bolIsCast, string strComparisonOp="")
	{
objcc_CourseVideoEN.IsCast = bolIsCast; //是否播放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.IsCast) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.IsCast, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.IsCast] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetIsDown(this clscc_CourseVideoEN objcc_CourseVideoEN, bool bolIsDown, string strComparisonOp="")
	{
objcc_CourseVideoEN.IsDown = bolIsDown; //是否下载
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.IsDown) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.IsDown, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.IsDown] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetLikeCount(this clscc_CourseVideoEN objcc_CourseVideoEN, long? lngLikeCount, string strComparisonOp="")
	{
objcc_CourseVideoEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.LikeCount) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.LikeCount, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.LikeCount] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetCourseId(this clscc_CourseVideoEN objcc_CourseVideoEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseVideo.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseVideo.CourseId);
}
objcc_CourseVideoEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.CourseId) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.CourseId, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.CourseId] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetCourseChapterId(this clscc_CourseVideoEN objcc_CourseVideoEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_CourseVideo.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_CourseVideo.CourseChapterId);
}
objcc_CourseVideoEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.CourseChapterId) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.CourseChapterId, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.CourseChapterId] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_CourseVideoEN SetResourceType(this clscc_CourseVideoEN objcc_CourseVideoEN, string strResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceType, 50, concc_CourseVideo.ResourceType);
}
objcc_CourseVideoEN.ResourceType = strResourceType; //ResourceType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseVideoEN.dicFldComparisonOp.ContainsKey(concc_CourseVideo.ResourceType) == false)
{
objcc_CourseVideoEN.dicFldComparisonOp.Add(concc_CourseVideo.ResourceType, strComparisonOp);
}
else
{
objcc_CourseVideoEN.dicFldComparisonOp[concc_CourseVideo.ResourceType] = strComparisonOp;
}
}
return objcc_CourseVideoEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_CourseVideoEN.CheckPropertyNew();
clscc_CourseVideoEN objcc_CourseVideoCond = new clscc_CourseVideoEN();
string strCondition = objcc_CourseVideoCond
.SetCourseVideoId(objcc_CourseVideoEN.CourseVideoId, "=")
.GetCombineCondition();
objcc_CourseVideoEN._IsCheckProperty = true;
bool bolIsExist = clscc_CourseVideoBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_CourseVideoEN.Update();
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
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (string.IsNullOrEmpty(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseVideoBL.cc_CourseVideoDA.UpdateBySql2(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseVideoEN objcc_CourseVideoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_CourseVideoBL.cc_CourseVideoDA.UpdateBySql2(objcc_CourseVideoEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "objcc_CourseVideoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseVideoEN objcc_CourseVideoEN, string strWhereCond)
{
try
{
bool bolResult = clscc_CourseVideoBL.cc_CourseVideoDA.UpdateBySqlWithCondition(objcc_CourseVideoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "objcc_CourseVideoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseVideoEN objcc_CourseVideoEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_CourseVideoBL.cc_CourseVideoDA.UpdateBySqlWithConditionTransaction(objcc_CourseVideoEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "strCourseVideoId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
try
{
int intRecNum = clscc_CourseVideoBL.cc_CourseVideoDA.DelRecord(objcc_CourseVideoEN.CourseVideoId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "objcc_CourseVideoENS">源对象</param>
 /// <param name = "objcc_CourseVideoENT">目标对象</param>
 public static void CopyTo(this clscc_CourseVideoEN objcc_CourseVideoENS, clscc_CourseVideoEN objcc_CourseVideoENT)
{
try
{
objcc_CourseVideoENT.CourseVideoId = objcc_CourseVideoENS.CourseVideoId; //课程视频Id
objcc_CourseVideoENT.UserId = objcc_CourseVideoENS.UserId; //用户ID
objcc_CourseVideoENT.FilePath = objcc_CourseVideoENS.FilePath; //文件路径
objcc_CourseVideoENT.FileSize = objcc_CourseVideoENS.FileSize; //文件大小
objcc_CourseVideoENT.FileSizeUnit = objcc_CourseVideoENS.FileSizeUnit; //文件大小单位
objcc_CourseVideoENT.UploadDate = objcc_CourseVideoENS.UploadDate; //上传时间
objcc_CourseVideoENT.IsShow = objcc_CourseVideoENS.IsShow; //是否启用
objcc_CourseVideoENT.CourseResourceName = objcc_CourseVideoENS.CourseResourceName; //教学视频名称
objcc_CourseVideoENT.ResourcePicPath = objcc_CourseVideoENS.ResourcePicPath; //图片位置
objcc_CourseVideoENT.IsCast = objcc_CourseVideoENS.IsCast; //是否播放
objcc_CourseVideoENT.IsDown = objcc_CourseVideoENS.IsDown; //是否下载
objcc_CourseVideoENT.LikeCount = objcc_CourseVideoENS.LikeCount; //资源喜欢数量
objcc_CourseVideoENT.CourseId = objcc_CourseVideoENS.CourseId; //课程Id
objcc_CourseVideoENT.CourseChapterId = objcc_CourseVideoENS.CourseChapterId; //课程章节ID
objcc_CourseVideoENT.ResourceType = objcc_CourseVideoENS.ResourceType; //ResourceType
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
 /// <param name = "objcc_CourseVideoENS">源对象</param>
 /// <returns>目标对象=>clscc_CourseVideoEN:objcc_CourseVideoENT</returns>
 public static clscc_CourseVideoEN CopyTo(this clscc_CourseVideoEN objcc_CourseVideoENS)
{
try
{
 clscc_CourseVideoEN objcc_CourseVideoENT = new clscc_CourseVideoEN()
{
CourseVideoId = objcc_CourseVideoENS.CourseVideoId, //课程视频Id
UserId = objcc_CourseVideoENS.UserId, //用户ID
FilePath = objcc_CourseVideoENS.FilePath, //文件路径
FileSize = objcc_CourseVideoENS.FileSize, //文件大小
FileSizeUnit = objcc_CourseVideoENS.FileSizeUnit, //文件大小单位
UploadDate = objcc_CourseVideoENS.UploadDate, //上传时间
IsShow = objcc_CourseVideoENS.IsShow, //是否启用
CourseResourceName = objcc_CourseVideoENS.CourseResourceName, //教学视频名称
ResourcePicPath = objcc_CourseVideoENS.ResourcePicPath, //图片位置
IsCast = objcc_CourseVideoENS.IsCast, //是否播放
IsDown = objcc_CourseVideoENS.IsDown, //是否下载
LikeCount = objcc_CourseVideoENS.LikeCount, //资源喜欢数量
CourseId = objcc_CourseVideoENS.CourseId, //课程Id
CourseChapterId = objcc_CourseVideoENS.CourseChapterId, //课程章节ID
ResourceType = objcc_CourseVideoENS.ResourceType, //ResourceType
};
 return objcc_CourseVideoENT;
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
public static void CheckPropertyNew(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
 clscc_CourseVideoBL.cc_CourseVideoDA.CheckPropertyNew(objcc_CourseVideoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
 clscc_CourseVideoBL.cc_CourseVideoDA.CheckProperty4Condition(objcc_CourseVideoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseVideoEN objcc_CourseVideoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.CourseVideoId) == true)
{
string strComparisonOpCourseVideoId = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.CourseVideoId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.CourseVideoId, objcc_CourseVideoCond.CourseVideoId, strComparisonOpCourseVideoId);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.UserId) == true)
{
string strComparisonOpUserId = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.UserId, objcc_CourseVideoCond.UserId, strComparisonOpUserId);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.FilePath) == true)
{
string strComparisonOpFilePath = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.FilePath, objcc_CourseVideoCond.FilePath, strComparisonOpFilePath);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.FileSize) == true)
{
string strComparisonOpFileSize = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseVideo.FileSize, objcc_CourseVideoCond.FileSize, strComparisonOpFileSize);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.FileSizeUnit) == true)
{
string strComparisonOpFileSizeUnit = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.FileSizeUnit, objcc_CourseVideoCond.FileSizeUnit, strComparisonOpFileSizeUnit);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.UploadDate) == true)
{
string strComparisonOpUploadDate = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.UploadDate, objcc_CourseVideoCond.UploadDate, strComparisonOpUploadDate);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.IsShow) == true)
{
if (objcc_CourseVideoCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseVideo.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseVideo.IsShow);
}
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.CourseResourceName) == true)
{
string strComparisonOpCourseResourceName = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.CourseResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.CourseResourceName, objcc_CourseVideoCond.CourseResourceName, strComparisonOpCourseResourceName);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.ResourcePicPath) == true)
{
string strComparisonOpResourcePicPath = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.ResourcePicPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.ResourcePicPath, objcc_CourseVideoCond.ResourcePicPath, strComparisonOpResourcePicPath);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.IsCast) == true)
{
if (objcc_CourseVideoCond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseVideo.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseVideo.IsCast);
}
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.IsDown) == true)
{
if (objcc_CourseVideoCond.IsDown == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseVideo.IsDown);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseVideo.IsDown);
}
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.LikeCount) == true)
{
string strComparisonOpLikeCount = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseVideo.LikeCount, objcc_CourseVideoCond.LikeCount, strComparisonOpLikeCount);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.CourseId) == true)
{
string strComparisonOpCourseId = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.CourseId, objcc_CourseVideoCond.CourseId, strComparisonOpCourseId);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.CourseChapterId, objcc_CourseVideoCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objcc_CourseVideoCond.IsUpdated(concc_CourseVideo.ResourceType) == true)
{
string strComparisonOpResourceType = objcc_CourseVideoCond.dicFldComparisonOp[concc_CourseVideo.ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.ResourceType, objcc_CourseVideoCond.ResourceType, strComparisonOpResourceType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_CourseVideo
{
public virtual bool UpdRelaTabDate(string strCourseVideoId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 课程视频(cc_CourseVideo)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseVideoBL
{
public static RelatedActions_cc_CourseVideo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_CourseVideoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_CourseVideoDA cc_CourseVideoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_CourseVideoDA();
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
 public clscc_CourseVideoBL()
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
if (string.IsNullOrEmpty(clscc_CourseVideoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseVideoEN._ConnectString);
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
public static DataTable GetDataTable_cc_CourseVideo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_CourseVideoDA.GetDataTable_cc_CourseVideo(strWhereCond);
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
objDT = cc_CourseVideoDA.GetDataTable(strWhereCond);
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
objDT = cc_CourseVideoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_CourseVideoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_CourseVideoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_CourseVideoDA.GetDataTable_Top(objTopPara);
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
objDT = cc_CourseVideoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_CourseVideoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_CourseVideoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCourseVideoIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLstByCourseVideoIdLst(List<string> arrCourseVideoIdLst)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCourseVideoIdLst, true);
 string strWhereCond = string.Format("CourseVideoId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCourseVideoIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_CourseVideoEN> GetObjLstByCourseVideoIdLstCache(List<string> arrCourseVideoIdLst)
{
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName);
List<clscc_CourseVideoEN> arrcc_CourseVideoObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseVideoEN> arrcc_CourseVideoObjLst_Sel =
arrcc_CourseVideoObjLstCache
.Where(x => arrCourseVideoIdLst.Contains(x.CourseVideoId));
return arrcc_CourseVideoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLst(string strWhereCond)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
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
public static List<clscc_CourseVideoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_CourseVideoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_CourseVideoEN> GetSubObjLstCache(clscc_CourseVideoEN objcc_CourseVideoCond)
{
List<clscc_CourseVideoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseVideoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseVideo.AttributeName)
{
if (objcc_CourseVideoCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseVideoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseVideoCond[strFldName].ToString());
}
else
{
if (objcc_CourseVideoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseVideoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseVideoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseVideoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseVideoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseVideoCond[strFldName]));
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
public static List<clscc_CourseVideoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
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
public static List<clscc_CourseVideoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
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
List<clscc_CourseVideoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_CourseVideoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseVideoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_CourseVideoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
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
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
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
public static List<clscc_CourseVideoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_CourseVideoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
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
public static List<clscc_CourseVideoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_CourseVideoEN> arrObjLst = new List<clscc_CourseVideoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseVideoEN objcc_CourseVideoEN = new clscc_CourseVideoEN();
try
{
objcc_CourseVideoEN.CourseVideoId = objRow[concc_CourseVideo.CourseVideoId].ToString().Trim(); //课程视频Id
objcc_CourseVideoEN.UserId = objRow[concc_CourseVideo.UserId].ToString().Trim(); //用户ID
objcc_CourseVideoEN.FilePath = objRow[concc_CourseVideo.FilePath] == DBNull.Value ? null : objRow[concc_CourseVideo.FilePath].ToString().Trim(); //文件路径
objcc_CourseVideoEN.FileSize = objRow[concc_CourseVideo.FileSize] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseVideo.FileSize].ToString().Trim()); //文件大小
objcc_CourseVideoEN.FileSizeUnit = objRow[concc_CourseVideo.FileSizeUnit] == DBNull.Value ? null : objRow[concc_CourseVideo.FileSizeUnit].ToString().Trim(); //文件大小单位
objcc_CourseVideoEN.UploadDate = objRow[concc_CourseVideo.UploadDate] == DBNull.Value ? null : objRow[concc_CourseVideo.UploadDate].ToString().Trim(); //上传时间
objcc_CourseVideoEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsShow].ToString().Trim()); //是否启用
objcc_CourseVideoEN.CourseResourceName = objRow[concc_CourseVideo.CourseResourceName] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseResourceName].ToString().Trim(); //教学视频名称
objcc_CourseVideoEN.ResourcePicPath = objRow[concc_CourseVideo.ResourcePicPath] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourcePicPath].ToString().Trim(); //图片位置
objcc_CourseVideoEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsCast].ToString().Trim()); //是否播放
objcc_CourseVideoEN.IsDown = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseVideo.IsDown].ToString().Trim()); //是否下载
objcc_CourseVideoEN.LikeCount = objRow[concc_CourseVideo.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseVideo.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseVideoEN.CourseId = objRow[concc_CourseVideo.CourseId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseId].ToString().Trim(); //课程Id
objcc_CourseVideoEN.CourseChapterId = objRow[concc_CourseVideo.CourseChapterId] == DBNull.Value ? null : objRow[concc_CourseVideo.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseVideoEN.ResourceType = objRow[concc_CourseVideo.ResourceType] == DBNull.Value ? null : objRow[concc_CourseVideo.ResourceType].ToString().Trim(); //ResourceType
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_CourseVideoEN.CourseVideoId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_CourseVideoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_CourseVideo(ref clscc_CourseVideoEN objcc_CourseVideoEN)
{
bool bolResult = cc_CourseVideoDA.Getcc_CourseVideo(ref objcc_CourseVideoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCourseVideoId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseVideoEN GetObjByCourseVideoId(string strCourseVideoId)
{
if (strCourseVideoId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCourseVideoId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCourseVideoId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCourseVideoId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_CourseVideoEN objcc_CourseVideoEN = cc_CourseVideoDA.GetObjByCourseVideoId(strCourseVideoId);
return objcc_CourseVideoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_CourseVideoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_CourseVideoEN objcc_CourseVideoEN = cc_CourseVideoDA.GetFirstObj(strWhereCond);
 return objcc_CourseVideoEN;
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
public static clscc_CourseVideoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_CourseVideoEN objcc_CourseVideoEN = cc_CourseVideoDA.GetObjByDataRow(objRow);
 return objcc_CourseVideoEN;
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
public static clscc_CourseVideoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_CourseVideoEN objcc_CourseVideoEN = cc_CourseVideoDA.GetObjByDataRow(objRow);
 return objcc_CourseVideoEN;
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
 /// <param name = "strCourseVideoId">所给的关键字</param>
 /// <param name = "lstcc_CourseVideoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseVideoEN GetObjByCourseVideoIdFromList(string strCourseVideoId, List<clscc_CourseVideoEN> lstcc_CourseVideoObjLst)
{
foreach (clscc_CourseVideoEN objcc_CourseVideoEN in lstcc_CourseVideoObjLst)
{
if (objcc_CourseVideoEN.CourseVideoId == strCourseVideoId)
{
return objcc_CourseVideoEN;
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
 string strCourseVideoId;
 try
 {
 strCourseVideoId = new clscc_CourseVideoDA().GetFirstID(strWhereCond);
 return strCourseVideoId;
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
 arrList = cc_CourseVideoDA.GetID(strWhereCond);
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
bool bolIsExist = cc_CourseVideoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCourseVideoId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCourseVideoId)
{
if (string.IsNullOrEmpty(strCourseVideoId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCourseVideoId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_CourseVideoDA.IsExist(strCourseVideoId);
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
 bolIsExist = clscc_CourseVideoDA.IsExistTable();
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
 bolIsExist = cc_CourseVideoDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (string.IsNullOrEmpty(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_CourseVideoBL.IsExist(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_CourseVideoEN.CourseVideoId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = cc_CourseVideoDA.AddNewRecordBySQL2(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (string.IsNullOrEmpty(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_CourseVideoBL.IsExist(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objcc_CourseVideoEN.CourseVideoId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = cc_CourseVideoDA.AddNewRecordBySQL2WithReturnKey(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_CourseVideoEN objcc_CourseVideoEN)
{
try
{
bool bolResult = cc_CourseVideoDA.Update(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (string.IsNullOrEmpty(objcc_CourseVideoEN.CourseVideoId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_CourseVideoDA.UpdateBySql2(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoBL.ReFreshCache();

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
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
 /// <param name = "strCourseVideoId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCourseVideoId)
{
try
{
 clscc_CourseVideoEN objcc_CourseVideoEN = clscc_CourseVideoBL.GetObjByCourseVideoId(strCourseVideoId);

if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(objcc_CourseVideoEN.CourseVideoId, "SetUpdDate");
}
if (objcc_CourseVideoEN != null)
{
int intRecNum = cc_CourseVideoDA.DelRecord(strCourseVideoId);
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
/// <param name="strCourseVideoId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCourseVideoId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseVideo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_CourseVideo.CourseVideoId,
//strCourseVideoId);
//        clscc_CourseVideoBL.Delcc_CourseVideosByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseVideoBL.DelRecord(strCourseVideoId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseVideoBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseVideoId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCourseVideoId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCourseVideoId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_CourseVideoBL.relatedActions != null)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(strCourseVideoId, "UpdRelaTabDate");
}
bool bolResult = cc_CourseVideoDA.DelRecord(strCourseVideoId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCourseVideoIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_CourseVideos(List<string> arrCourseVideoIdLst)
{
if (arrCourseVideoIdLst.Count == 0) return 0;
try
{
if (clscc_CourseVideoBL.relatedActions != null)
{
foreach (var strCourseVideoId in arrCourseVideoIdLst)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(strCourseVideoId, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_CourseVideoDA.Delcc_CourseVideo(arrCourseVideoIdLst);
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
public static int Delcc_CourseVideosByCond(string strWhereCond)
{
try
{
if (clscc_CourseVideoBL.relatedActions != null)
{
List<string> arrCourseVideoId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCourseVideoId in arrCourseVideoId)
{
clscc_CourseVideoBL.relatedActions.UpdRelaTabDate(strCourseVideoId, "UpdRelaTabDate");
}
}
int intRecNum = cc_CourseVideoDA.Delcc_CourseVideo(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_CourseVideo]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCourseVideoId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCourseVideoId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_CourseVideoDA.GetSpecSQLObj();
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
//删除与表:[cc_CourseVideo]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_CourseVideoBL.DelRecord(strCourseVideoId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_CourseVideoBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCourseVideoId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_CourseVideoENS">源对象</param>
 /// <param name = "objcc_CourseVideoENT">目标对象</param>
 public static void CopyTo(clscc_CourseVideoEN objcc_CourseVideoENS, clscc_CourseVideoEN objcc_CourseVideoENT)
{
try
{
objcc_CourseVideoENT.CourseVideoId = objcc_CourseVideoENS.CourseVideoId; //课程视频Id
objcc_CourseVideoENT.UserId = objcc_CourseVideoENS.UserId; //用户ID
objcc_CourseVideoENT.FilePath = objcc_CourseVideoENS.FilePath; //文件路径
objcc_CourseVideoENT.FileSize = objcc_CourseVideoENS.FileSize; //文件大小
objcc_CourseVideoENT.FileSizeUnit = objcc_CourseVideoENS.FileSizeUnit; //文件大小单位
objcc_CourseVideoENT.UploadDate = objcc_CourseVideoENS.UploadDate; //上传时间
objcc_CourseVideoENT.IsShow = objcc_CourseVideoENS.IsShow; //是否启用
objcc_CourseVideoENT.CourseResourceName = objcc_CourseVideoENS.CourseResourceName; //教学视频名称
objcc_CourseVideoENT.ResourcePicPath = objcc_CourseVideoENS.ResourcePicPath; //图片位置
objcc_CourseVideoENT.IsCast = objcc_CourseVideoENS.IsCast; //是否播放
objcc_CourseVideoENT.IsDown = objcc_CourseVideoENS.IsDown; //是否下载
objcc_CourseVideoENT.LikeCount = objcc_CourseVideoENS.LikeCount; //资源喜欢数量
objcc_CourseVideoENT.CourseId = objcc_CourseVideoENS.CourseId; //课程Id
objcc_CourseVideoENT.CourseChapterId = objcc_CourseVideoENS.CourseChapterId; //课程章节ID
objcc_CourseVideoENT.ResourceType = objcc_CourseVideoENS.ResourceType; //ResourceType
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
 /// <param name = "objcc_CourseVideoEN">源简化对象</param>
 public static void SetUpdFlag(clscc_CourseVideoEN objcc_CourseVideoEN)
{
try
{
objcc_CourseVideoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_CourseVideoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_CourseVideo.CourseVideoId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.CourseVideoId = objcc_CourseVideoEN.CourseVideoId; //课程视频Id
}
if (arrFldSet.Contains(concc_CourseVideo.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.UserId = objcc_CourseVideoEN.UserId; //用户ID
}
if (arrFldSet.Contains(concc_CourseVideo.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.FilePath = objcc_CourseVideoEN.FilePath == "[null]" ? null :  objcc_CourseVideoEN.FilePath; //文件路径
}
if (arrFldSet.Contains(concc_CourseVideo.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.FileSize = objcc_CourseVideoEN.FileSize; //文件大小
}
if (arrFldSet.Contains(concc_CourseVideo.FileSizeUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.FileSizeUnit = objcc_CourseVideoEN.FileSizeUnit == "[null]" ? null :  objcc_CourseVideoEN.FileSizeUnit; //文件大小单位
}
if (arrFldSet.Contains(concc_CourseVideo.UploadDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.UploadDate = objcc_CourseVideoEN.UploadDate == "[null]" ? null :  objcc_CourseVideoEN.UploadDate; //上传时间
}
if (arrFldSet.Contains(concc_CourseVideo.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.IsShow = objcc_CourseVideoEN.IsShow; //是否启用
}
if (arrFldSet.Contains(concc_CourseVideo.CourseResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.CourseResourceName = objcc_CourseVideoEN.CourseResourceName == "[null]" ? null :  objcc_CourseVideoEN.CourseResourceName; //教学视频名称
}
if (arrFldSet.Contains(concc_CourseVideo.ResourcePicPath, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.ResourcePicPath = objcc_CourseVideoEN.ResourcePicPath == "[null]" ? null :  objcc_CourseVideoEN.ResourcePicPath; //图片位置
}
if (arrFldSet.Contains(concc_CourseVideo.IsCast, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.IsCast = objcc_CourseVideoEN.IsCast; //是否播放
}
if (arrFldSet.Contains(concc_CourseVideo.IsDown, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.IsDown = objcc_CourseVideoEN.IsDown; //是否下载
}
if (arrFldSet.Contains(concc_CourseVideo.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.LikeCount = objcc_CourseVideoEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(concc_CourseVideo.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.CourseId = objcc_CourseVideoEN.CourseId == "[null]" ? null :  objcc_CourseVideoEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_CourseVideo.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.CourseChapterId = objcc_CourseVideoEN.CourseChapterId == "[null]" ? null :  objcc_CourseVideoEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(concc_CourseVideo.ResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_CourseVideoEN.ResourceType = objcc_CourseVideoEN.ResourceType == "[null]" ? null :  objcc_CourseVideoEN.ResourceType; //ResourceType
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
 /// <param name = "objcc_CourseVideoEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_CourseVideoEN objcc_CourseVideoEN)
{
try
{
if (objcc_CourseVideoEN.FilePath == "[null]") objcc_CourseVideoEN.FilePath = null; //文件路径
if (objcc_CourseVideoEN.FileSizeUnit == "[null]") objcc_CourseVideoEN.FileSizeUnit = null; //文件大小单位
if (objcc_CourseVideoEN.UploadDate == "[null]") objcc_CourseVideoEN.UploadDate = null; //上传时间
if (objcc_CourseVideoEN.CourseResourceName == "[null]") objcc_CourseVideoEN.CourseResourceName = null; //教学视频名称
if (objcc_CourseVideoEN.ResourcePicPath == "[null]") objcc_CourseVideoEN.ResourcePicPath = null; //图片位置
if (objcc_CourseVideoEN.CourseId == "[null]") objcc_CourseVideoEN.CourseId = null; //课程Id
if (objcc_CourseVideoEN.CourseChapterId == "[null]") objcc_CourseVideoEN.CourseChapterId = null; //课程章节ID
if (objcc_CourseVideoEN.ResourceType == "[null]") objcc_CourseVideoEN.ResourceType = null; //ResourceType
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
public static void CheckPropertyNew(clscc_CourseVideoEN objcc_CourseVideoEN)
{
 cc_CourseVideoDA.CheckPropertyNew(objcc_CourseVideoEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_CourseVideoEN objcc_CourseVideoEN)
{
 cc_CourseVideoDA.CheckProperty4Condition(objcc_CourseVideoEN);
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
if (clscc_CourseVideoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseVideoBL没有刷新缓存机制(clscc_CourseVideoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseVideoId");
//if (arrcc_CourseVideoObjLstCache == null)
//{
//arrcc_CourseVideoObjLstCache = cc_CourseVideoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCourseVideoId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseVideoEN GetObjByCourseVideoIdCache(string strCourseVideoId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName);
List<clscc_CourseVideoEN> arrcc_CourseVideoObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseVideoEN> arrcc_CourseVideoObjLst_Sel =
arrcc_CourseVideoObjLstCache
.Where(x=> x.CourseVideoId == strCourseVideoId 
);
if (arrcc_CourseVideoObjLst_Sel.Count() == 0)
{
   clscc_CourseVideoEN obj = clscc_CourseVideoBL.GetObjByCourseVideoId(strCourseVideoId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_CourseVideoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseVideoEN> GetAllcc_CourseVideoObjLstCache()
{
//获取缓存中的对象列表
List<clscc_CourseVideoEN> arrcc_CourseVideoObjLstCache = GetObjLstCache(); 
return arrcc_CourseVideoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName);
List<clscc_CourseVideoEN> arrcc_CourseVideoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_CourseVideoObjLstCache;
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
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName);
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
if (clscc_CourseVideoBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_CourseVideoBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strCourseVideoId)
{
if (strInFldName != concc_CourseVideo.CourseVideoId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_CourseVideo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_CourseVideo.AttributeName));
throw new Exception(strMsg);
}
var objcc_CourseVideo = clscc_CourseVideoBL.GetObjByCourseVideoIdCache(strCourseVideoId);
if (objcc_CourseVideo == null) return "";
return objcc_CourseVideo[strOutFldName].ToString();
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
int intRecCount = clscc_CourseVideoDA.GetRecCount(strTabName);
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
int intRecCount = clscc_CourseVideoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_CourseVideoDA.GetRecCount();
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
int intRecCount = clscc_CourseVideoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_CourseVideoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_CourseVideoEN objcc_CourseVideoCond)
{
List<clscc_CourseVideoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_CourseVideoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_CourseVideo.AttributeName)
{
if (objcc_CourseVideoCond.IsUpdated(strFldName) == false) continue;
if (objcc_CourseVideoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseVideoCond[strFldName].ToString());
}
else
{
if (objcc_CourseVideoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_CourseVideoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_CourseVideoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_CourseVideoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_CourseVideoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_CourseVideoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_CourseVideoCond[strFldName]));
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
 List<string> arrList = clscc_CourseVideoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseVideoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_CourseVideoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_CourseVideoDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseVideoDA.SetFldValue(clscc_CourseVideoEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_CourseVideoDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseVideoDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_CourseVideoDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_CourseVideoDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_CourseVideo] "); 
 strCreateTabCode.Append(" ( "); 
 // /**课程视频Id*/ 
 strCreateTabCode.Append(" CourseVideoId char(8) primary key, "); 
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
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) Null, "); 
 // /**ResourceType*/ 
 strCreateTabCode.Append(" ResourceType varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 课程视频(cc_CourseVideo)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_CourseVideo : clsCommFun4BL
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
clscc_CourseVideoBL.ReFreshThisCache();
}
}

}