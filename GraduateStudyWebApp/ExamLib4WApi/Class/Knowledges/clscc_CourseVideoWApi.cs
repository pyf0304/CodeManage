
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseVideoWApi
 表名:cc_CourseVideo(01120081)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:23
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clscc_CourseVideoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetCourseVideoId(this clscc_CourseVideoEN objcc_CourseVideoEN, string strCourseVideoId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseVideoId, 8, concc_CourseVideo.CourseVideoId);
clsCheckSql.CheckFieldForeignKey(strCourseVideoId, 8, concc_CourseVideo.CourseVideoId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetUserId(this clscc_CourseVideoEN objcc_CourseVideoEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, concc_CourseVideo.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, concc_CourseVideo.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetFilePath(this clscc_CourseVideoEN objcc_CourseVideoEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFilePath, 500, concc_CourseVideo.FilePath);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetFileSize(this clscc_CourseVideoEN objcc_CourseVideoEN, double dblFileSize, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetFileSizeUnit(this clscc_CourseVideoEN objcc_CourseVideoEN, string strFileSizeUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSizeUnit, 10, concc_CourseVideo.FileSizeUnit);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetUploadDate(this clscc_CourseVideoEN objcc_CourseVideoEN, string strUploadDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUploadDate, 20, concc_CourseVideo.UploadDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetCourseResourceName(this clscc_CourseVideoEN objcc_CourseVideoEN, string strCourseResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseResourceName, 200, concc_CourseVideo.CourseResourceName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetResourcePicPath(this clscc_CourseVideoEN objcc_CourseVideoEN, string strResourcePicPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourcePicPath, 500, concc_CourseVideo.ResourcePicPath);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetLikeCount(this clscc_CourseVideoEN objcc_CourseVideoEN, long lngLikeCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetCourseId(this clscc_CourseVideoEN objcc_CourseVideoEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseVideo.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseVideo.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetCourseChapterId(this clscc_CourseVideoEN objcc_CourseVideoEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_CourseVideo.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_CourseVideo.CourseChapterId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseVideoEN SetResourceType(this clscc_CourseVideoEN objcc_CourseVideoEN, string strResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceType, 50, concc_CourseVideo.ResourceType);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseVideoEN objcc_CourseVideo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.CourseVideoId) == true)
{
string strComparisonOp_CourseVideoId = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.CourseVideoId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.CourseVideoId, objcc_CourseVideo_Cond.CourseVideoId, strComparisonOp_CourseVideoId);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.UserId) == true)
{
string strComparisonOp_UserId = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.UserId, objcc_CourseVideo_Cond.UserId, strComparisonOp_UserId);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.FilePath) == true)
{
string strComparisonOp_FilePath = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.FilePath, objcc_CourseVideo_Cond.FilePath, strComparisonOp_FilePath);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.FileSize) == true)
{
string strComparisonOp_FileSize = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseVideo.FileSize, objcc_CourseVideo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.FileSizeUnit) == true)
{
string strComparisonOp_FileSizeUnit = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.FileSizeUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.FileSizeUnit, objcc_CourseVideo_Cond.FileSizeUnit, strComparisonOp_FileSizeUnit);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.UploadDate) == true)
{
string strComparisonOp_UploadDate = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.UploadDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.UploadDate, objcc_CourseVideo_Cond.UploadDate, strComparisonOp_UploadDate);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.IsShow) == true)
{
if (objcc_CourseVideo_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseVideo.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseVideo.IsShow);
}
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.CourseResourceName) == true)
{
string strComparisonOp_CourseResourceName = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.CourseResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.CourseResourceName, objcc_CourseVideo_Cond.CourseResourceName, strComparisonOp_CourseResourceName);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.ResourcePicPath) == true)
{
string strComparisonOp_ResourcePicPath = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.ResourcePicPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.ResourcePicPath, objcc_CourseVideo_Cond.ResourcePicPath, strComparisonOp_ResourcePicPath);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.IsCast) == true)
{
if (objcc_CourseVideo_Cond.IsCast == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseVideo.IsCast);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseVideo.IsCast);
}
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.IsDown) == true)
{
if (objcc_CourseVideo_Cond.IsDown == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseVideo.IsDown);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseVideo.IsDown);
}
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.LikeCount) == true)
{
string strComparisonOp_LikeCount = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseVideo.LikeCount, objcc_CourseVideo_Cond.LikeCount, strComparisonOp_LikeCount);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.CourseId, objcc_CourseVideo_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.CourseChapterId, objcc_CourseVideo_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objcc_CourseVideo_Cond.IsUpdated(concc_CourseVideo.ResourceType) == true)
{
string strComparisonOp_ResourceType = objcc_CourseVideo_Cond.dicFldComparisonOp[concc_CourseVideo.ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseVideo.ResourceType, objcc_CourseVideo_Cond.ResourceType, strComparisonOp_ResourceType);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (string.IsNullOrEmpty(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_CourseVideoEN.sf_UpdFldSetStr = objcc_CourseVideoEN.getsf_UpdFldSetStr();
clscc_CourseVideoWApi.CheckPropertyNew(objcc_CourseVideoEN); 
bool bolResult = clscc_CourseVideoWApi.UpdateRecord(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
 if (string.IsNullOrEmpty(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_CourseVideoWApi.IsExist(objcc_CourseVideoEN.CourseVideoId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objcc_CourseVideoEN.CourseVideoId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clscc_CourseVideoWApi.CheckPropertyNew(objcc_CourseVideoEN); 
bool bolResult = clscc_CourseVideoWApi.AddNewRecord(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_CourseVideoEN objcc_CourseVideoEN)
{
try
{
clscc_CourseVideoWApi.CheckPropertyNew(objcc_CourseVideoEN); 
string strCourseVideoId = clscc_CourseVideoWApi.AddNewRecordWithMaxId(objcc_CourseVideoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoWApi.ReFreshCache();
return strCourseVideoId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseVideoEN objcc_CourseVideoEN, string strWhereCond)
{
try
{
clscc_CourseVideoWApi.CheckPropertyNew(objcc_CourseVideoEN); 
bool bolResult = clscc_CourseVideoWApi.UpdateWithCondition(objcc_CourseVideoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 课程视频(cc_CourseVideo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseVideoWApi
{
private static readonly string mstrApiControllerName = "cc_CourseVideoApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_CourseVideoWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_CourseVideoEN objcc_CourseVideoEN)
{
if (!Object.Equals(null, objcc_CourseVideoEN.CourseVideoId) && GetStrLen(objcc_CourseVideoEN.CourseVideoId) > 8)
{
 throw new Exception("字段[课程视频Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseVideoEN.UserId) && GetStrLen(objcc_CourseVideoEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseVideoEN.FilePath) && GetStrLen(objcc_CourseVideoEN.FilePath) > 500)
{
 throw new Exception("字段[文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objcc_CourseVideoEN.FileSizeUnit) && GetStrLen(objcc_CourseVideoEN.FileSizeUnit) > 10)
{
 throw new Exception("字段[文件大小单位]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_CourseVideoEN.UploadDate) && GetStrLen(objcc_CourseVideoEN.UploadDate) > 20)
{
 throw new Exception("字段[上传时间]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseVideoEN.CourseResourceName) && GetStrLen(objcc_CourseVideoEN.CourseResourceName) > 200)
{
 throw new Exception("字段[教学视频名称]的长度不能超过200!");
}
if (!Object.Equals(null, objcc_CourseVideoEN.ResourcePicPath) && GetStrLen(objcc_CourseVideoEN.ResourcePicPath) > 500)
{
 throw new Exception("字段[图片位置]的长度不能超过500!");
}
if (!Object.Equals(null, objcc_CourseVideoEN.CourseId) && GetStrLen(objcc_CourseVideoEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseVideoEN.CourseChapterId) && GetStrLen(objcc_CourseVideoEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseVideoEN.ResourceType) && GetStrLen(objcc_CourseVideoEN.ResourceType) > 50)
{
 throw new Exception("字段[ResourceType]的长度不能超过50!");
}
 objcc_CourseVideoEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseVideoId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseVideoEN GetObjByCourseVideoId(string strCourseVideoId)
{
string strAction = "GetObjByCourseVideoId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseVideoEN objcc_CourseVideoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseVideoId"] = strCourseVideoId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseVideoEN = JsonConvert.DeserializeObject<clscc_CourseVideoEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseVideoEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strCourseVideoId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseVideoEN GetObjByCourseVideoId_WA_Cache(string strCourseVideoId)
{
string strAction = "GetObjByCourseVideoId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseVideoEN objcc_CourseVideoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseVideoId"] = strCourseVideoId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseVideoEN = JsonConvert.DeserializeObject<clscc_CourseVideoEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseVideoEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clscc_CourseVideoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseVideoEN objcc_CourseVideoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseVideoEN = JsonConvert.DeserializeObject<clscc_CourseVideoEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseVideoEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strCourseVideoId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_CourseVideoEN GetObjByCourseVideoId_Cache(string strCourseVideoId)
{
if (string.IsNullOrEmpty(strCourseVideoId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName_S);
List<clscc_CourseVideoEN> arrcc_CourseVideoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_CourseVideoEN> arrcc_CourseVideoObjLst_Sel =
from objcc_CourseVideoEN in arrcc_CourseVideoObjLst_Cache
where objcc_CourseVideoEN.CourseVideoId == strCourseVideoId
select objcc_CourseVideoEN;
if (arrcc_CourseVideoObjLst_Sel.Count() == 0)
{
   clscc_CourseVideoEN obj = clscc_CourseVideoWApi.GetObjByCourseVideoId(strCourseVideoId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_CourseVideoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLst(string strWhereCond)
{
 List<clscc_CourseVideoEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseVideoEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLstByCourseVideoIdLst(List<string> arrCourseVideoId)
{
 List<clscc_CourseVideoEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseVideoIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseVideoId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseVideoEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strCourseVideoId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_CourseVideoEN> GetObjLstByCourseVideoIdLst_Cache(List<string> arrCourseVideoId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName_S);
List<clscc_CourseVideoEN> arrcc_CourseVideoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_CourseVideoEN> arrcc_CourseVideoObjLst_Sel =
from objcc_CourseVideoEN in arrcc_CourseVideoObjLst_Cache
where arrCourseVideoId.Contains(objcc_CourseVideoEN.CourseVideoId)
select objcc_CourseVideoEN;
return arrcc_CourseVideoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLstByCourseVideoIdLst_WA_Cache(List<string> arrCourseVideoId)
{
 List<clscc_CourseVideoEN> arrObjLst = null; 
string strAction = "GetObjLstByCourseVideoIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseVideoId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseVideoEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseVideoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_CourseVideoEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseVideoEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_CourseVideoEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseVideoEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_CourseVideoEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseVideoEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_CourseVideoEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseVideoEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strCourseVideoId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_CourseVideoEN objcc_CourseVideoEN = clscc_CourseVideoWApi.GetObjByCourseVideoId(strCourseVideoId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCourseVideoId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseVideoWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_CourseVideos(List<string> arrCourseVideoId)
{
string strAction = "Delcc_CourseVideos";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCourseVideoId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseVideoWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int Delcc_CourseVideosByCond(string strWhereCond)
{
string strAction = "Delcc_CourseVideosByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clscc_CourseVideoEN objcc_CourseVideoEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseVideoEN>(objcc_CourseVideoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clscc_CourseVideoEN objcc_CourseVideoEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseVideoEN>(objcc_CourseVideoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseVideoWApi.ReFreshCache();
var strCourseVideoId = (string)jobjReturn["ReturnStr"];
return strCourseVideoId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clscc_CourseVideoEN objcc_CourseVideoEN)
{
if (string.IsNullOrEmpty(objcc_CourseVideoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseVideoEN.CourseVideoId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseVideoEN>(objcc_CourseVideoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objcc_CourseVideoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_CourseVideoEN objcc_CourseVideoEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_CourseVideoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseVideoEN.CourseVideoId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseVideoEN.CourseVideoId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseVideoEN>(objcc_CourseVideoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strCourseVideoId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseVideoId"] = strCourseVideoId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clscc_CourseVideoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_CourseVideoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_CourseVideoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_CourseVideoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_CourseVideoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_CourseVideoEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clscc_CourseVideoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseVideoWApi没有刷新缓存机制(clscc_CourseVideoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CourseVideoId");
//if (arrcc_CourseVideoObjLst_Cache == null)
//{
//arrcc_CourseVideoObjLst_Cache = await clscc_CourseVideoWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName_S);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_CourseVideoWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_CourseVideoWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseVideoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_CourseVideoEN._CurrTabName_S);
List<clscc_CourseVideoEN> arrcc_CourseVideoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_CourseVideoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_CourseVideoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_CourseVideo.CourseVideoId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseVideo.UserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseVideo.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseVideo.FileSize, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_CourseVideo.FileSizeUnit, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseVideo.UploadDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseVideo.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseVideo.CourseResourceName, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseVideo.ResourcePicPath, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseVideo.IsCast, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseVideo.IsDown, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseVideo.LikeCount, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_CourseVideo.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseVideo.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseVideo.ResourceType, Type.GetType("System.String"));
foreach (clscc_CourseVideoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_CourseVideo.CourseVideoId] = objInFor[concc_CourseVideo.CourseVideoId];
objDR[concc_CourseVideo.UserId] = objInFor[concc_CourseVideo.UserId];
objDR[concc_CourseVideo.FilePath] = objInFor[concc_CourseVideo.FilePath];
objDR[concc_CourseVideo.FileSize] = objInFor[concc_CourseVideo.FileSize];
objDR[concc_CourseVideo.FileSizeUnit] = objInFor[concc_CourseVideo.FileSizeUnit];
objDR[concc_CourseVideo.UploadDate] = objInFor[concc_CourseVideo.UploadDate];
objDR[concc_CourseVideo.IsShow] = objInFor[concc_CourseVideo.IsShow];
objDR[concc_CourseVideo.CourseResourceName] = objInFor[concc_CourseVideo.CourseResourceName];
objDR[concc_CourseVideo.ResourcePicPath] = objInFor[concc_CourseVideo.ResourcePicPath];
objDR[concc_CourseVideo.IsCast] = objInFor[concc_CourseVideo.IsCast];
objDR[concc_CourseVideo.IsDown] = objInFor[concc_CourseVideo.IsDown];
objDR[concc_CourseVideo.LikeCount] = objInFor[concc_CourseVideo.LikeCount];
objDR[concc_CourseVideo.CourseId] = objInFor[concc_CourseVideo.CourseId];
objDR[concc_CourseVideo.CourseChapterId] = objInFor[concc_CourseVideo.CourseChapterId];
objDR[concc_CourseVideo.ResourceType] = objInFor[concc_CourseVideo.ResourceType];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 课程视频(cc_CourseVideo)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_CourseVideo : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clscc_CourseVideoWApi.ReFreshThisCache();
}
}

}