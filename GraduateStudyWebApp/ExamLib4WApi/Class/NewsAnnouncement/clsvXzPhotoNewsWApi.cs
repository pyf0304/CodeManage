
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzPhotoNewsWApi
 表名:vXzPhotoNews(01120420)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:44
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告
 模块英文名:NewsAnnouncement
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
public static class clsvXzPhotoNewsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetPhotoNewsId(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, long lngPhotoNewsId, string strComparisonOp="")
	{
objvXzPhotoNewsEN.PhotoNewsId = lngPhotoNewsId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.PhotoNewsId) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.PhotoNewsId, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.PhotoNewsId] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetDepartmentID(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strDepartmentID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentID, convXzPhotoNews.DepartmentID);
clsCheckSql.CheckFieldLen(strDepartmentID, 8, convXzPhotoNews.DepartmentID);
clsCheckSql.CheckFieldForeignKey(strDepartmentID, 8, convXzPhotoNews.DepartmentID);
objvXzPhotoNewsEN.DepartmentID = strDepartmentID; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.DepartmentID) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.DepartmentID, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.DepartmentID] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetViews(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, int intViews, string strComparisonOp="")
	{
objvXzPhotoNewsEN.Views = intViews; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.Views) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.Views, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.Views] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetIsTop(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, bool bolIsTop, string strComparisonOp="")
	{
objvXzPhotoNewsEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.IsTop) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.IsTop, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.IsTop] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetIsUrgent(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, bool bolIsUrgent, string strComparisonOp="")
	{
objvXzPhotoNewsEN.IsUrgent = bolIsUrgent; //是否紧急
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.IsUrgent) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.IsUrgent, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.IsUrgent] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetAudit(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strAudit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAudit, 1, convXzPhotoNews.Audit);
clsCheckSql.CheckFieldForeignKey(strAudit, 1, convXzPhotoNews.Audit);
objvXzPhotoNewsEN.Audit = strAudit; //审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.Audit) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.Audit, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.Audit] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetPhotoNewsTitle(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strPhotoNewsTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPhotoNewsTitle, convXzPhotoNews.PhotoNewsTitle);
clsCheckSql.CheckFieldLen(strPhotoNewsTitle, 100, convXzPhotoNews.PhotoNewsTitle);
objvXzPhotoNewsEN.PhotoNewsTitle = strPhotoNewsTitle; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.PhotoNewsTitle) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.PhotoNewsTitle, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.PhotoNewsTitle] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetImageUrl(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 50, convXzPhotoNews.ImageUrl);
objvXzPhotoNewsEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.ImageUrl) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.ImageUrl, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.ImageUrl] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetPhotoNewsContent(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strPhotoNewsContent, string strComparisonOp="")
	{
objvXzPhotoNewsEN.PhotoNewsContent = strPhotoNewsContent; //内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.PhotoNewsContent) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.PhotoNewsContent, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.PhotoNewsContent] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetPhotoNewsDate(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strPhotoNewsDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPhotoNewsDate, convXzPhotoNews.PhotoNewsDate);
clsCheckSql.CheckFieldLen(strPhotoNewsDate, 16, convXzPhotoNews.PhotoNewsDate);
clsCheckSql.CheckFieldForeignKey(strPhotoNewsDate, 16, convXzPhotoNews.PhotoNewsDate);
objvXzPhotoNewsEN.PhotoNewsDate = strPhotoNewsDate; //日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.PhotoNewsDate) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.PhotoNewsDate, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.PhotoNewsDate] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetPhotoNewsUser(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strPhotoNewsUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPhotoNewsUser, convXzPhotoNews.PhotoNewsUser);
clsCheckSql.CheckFieldLen(strPhotoNewsUser, 50, convXzPhotoNews.PhotoNewsUser);
objvXzPhotoNewsEN.PhotoNewsUser = strPhotoNewsUser; //用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.PhotoNewsUser) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.PhotoNewsUser, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.PhotoNewsUser] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetMemo(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzPhotoNews.Memo);
objvXzPhotoNewsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.Memo) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.Memo, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.Memo] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetCollegeName(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convXzPhotoNews.CollegeName);
objvXzPhotoNewsEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.CollegeName) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.CollegeName, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.CollegeName] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN Setid_XzCollege(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convXzPhotoNews.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convXzPhotoNews.id_XzCollege);
objvXzPhotoNewsEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.id_XzCollege) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.id_XzCollege, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.id_XzCollege] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN Setid_XzMajor(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convXzPhotoNews.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convXzPhotoNews.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convXzPhotoNews.id_XzMajor);
objvXzPhotoNewsEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.id_XzMajor) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.id_XzMajor, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.id_XzMajor] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetMajorID(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convXzPhotoNews.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convXzPhotoNews.MajorID);
objvXzPhotoNewsEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.MajorID) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.MajorID, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.MajorID] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzPhotoNewsEN SetMajorName(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convXzPhotoNews.MajorName);
objvXzPhotoNewsEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.MajorName) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.MajorName, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.MajorName] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzPhotoNewsEN objvXzPhotoNews_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.PhotoNewsId) == true)
{
string strComparisonOp_PhotoNewsId = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.PhotoNewsId];
strWhereCond += string.Format(" And {0} {2} {1}", convXzPhotoNews.PhotoNewsId, objvXzPhotoNews_Cond.PhotoNewsId, strComparisonOp_PhotoNewsId);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.DepartmentID) == true)
{
string strComparisonOp_DepartmentID = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.DepartmentID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.DepartmentID, objvXzPhotoNews_Cond.DepartmentID, strComparisonOp_DepartmentID);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.Views) == true)
{
string strComparisonOp_Views = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.Views];
strWhereCond += string.Format(" And {0} {2} {1}", convXzPhotoNews.Views, objvXzPhotoNews_Cond.Views, strComparisonOp_Views);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.IsTop) == true)
{
if (objvXzPhotoNews_Cond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzPhotoNews.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzPhotoNews.IsTop);
}
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.IsUrgent) == true)
{
if (objvXzPhotoNews_Cond.IsUrgent == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzPhotoNews.IsUrgent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzPhotoNews.IsUrgent);
}
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.Audit) == true)
{
string strComparisonOp_Audit = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.Audit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.Audit, objvXzPhotoNews_Cond.Audit, strComparisonOp_Audit);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.PhotoNewsTitle) == true)
{
string strComparisonOp_PhotoNewsTitle = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.PhotoNewsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.PhotoNewsTitle, objvXzPhotoNews_Cond.PhotoNewsTitle, strComparisonOp_PhotoNewsTitle);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.ImageUrl) == true)
{
string strComparisonOp_ImageUrl = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.ImageUrl, objvXzPhotoNews_Cond.ImageUrl, strComparisonOp_ImageUrl);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.PhotoNewsDate) == true)
{
string strComparisonOp_PhotoNewsDate = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.PhotoNewsDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.PhotoNewsDate, objvXzPhotoNews_Cond.PhotoNewsDate, strComparisonOp_PhotoNewsDate);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.PhotoNewsUser) == true)
{
string strComparisonOp_PhotoNewsUser = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.PhotoNewsUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.PhotoNewsUser, objvXzPhotoNews_Cond.PhotoNewsUser, strComparisonOp_PhotoNewsUser);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.Memo) == true)
{
string strComparisonOp_Memo = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.Memo, objvXzPhotoNews_Cond.Memo, strComparisonOp_Memo);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.CollegeName, objvXzPhotoNews_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.id_XzCollege, objvXzPhotoNews_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.id_XzMajor, objvXzPhotoNews_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.MajorID) == true)
{
string strComparisonOp_MajorID = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.MajorID, objvXzPhotoNews_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvXzPhotoNews_Cond.IsUpdated(convXzPhotoNews.MajorName) == true)
{
string strComparisonOp_MajorName = objvXzPhotoNews_Cond.dicFldComparisonOp[convXzPhotoNews.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.MajorName, objvXzPhotoNews_Cond.MajorName, strComparisonOp_MajorName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v图片新闻(vXzPhotoNews)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzPhotoNewsWApi
{
private static readonly string mstrApiControllerName = "vXzPhotoNewsApi";

 public clsvXzPhotoNewsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPhotoNewsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzPhotoNewsEN GetObjByPhotoNewsId(long lngPhotoNewsId)
{
string strAction = "GetObjByPhotoNewsId";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzPhotoNewsEN objvXzPhotoNewsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PhotoNewsId"] = lngPhotoNewsId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzPhotoNewsEN = JsonConvert.DeserializeObject<clsvXzPhotoNewsEN>((string)jobjReturn["ReturnObj"]);
return objvXzPhotoNewsEN;
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
 /// <param name = "lngPhotoNewsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzPhotoNewsEN GetObjByPhotoNewsId_WA_Cache(long lngPhotoNewsId)
{
string strAction = "GetObjByPhotoNewsId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzPhotoNewsEN objvXzPhotoNewsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PhotoNewsId"] = lngPhotoNewsId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzPhotoNewsEN = JsonConvert.DeserializeObject<clsvXzPhotoNewsEN>((string)jobjReturn["ReturnObj"]);
return objvXzPhotoNewsEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvXzPhotoNewsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzPhotoNewsEN objvXzPhotoNewsEN = null;
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
objvXzPhotoNewsEN = JsonConvert.DeserializeObject<clsvXzPhotoNewsEN>((string)jobjReturn["ReturnObj"]);
return objvXzPhotoNewsEN;
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
 /// <param name = "lngPhotoNewsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzPhotoNewsEN GetObjByPhotoNewsId_Cache(long lngPhotoNewsId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzPhotoNewsEN._CurrTabName_S);
List<clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLst_Sel =
from objvXzPhotoNewsEN in arrvXzPhotoNewsObjLst_Cache
where objvXzPhotoNewsEN.PhotoNewsId == lngPhotoNewsId
select objvXzPhotoNewsEN;
if (arrvXzPhotoNewsObjLst_Sel.Count() == 0)
{
   clsvXzPhotoNewsEN obj = clsvXzPhotoNewsWApi.GetObjByPhotoNewsId(lngPhotoNewsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzPhotoNewsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetObjLst(string strWhereCond)
{
 List<clsvXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzPhotoNewsEN> GetObjLstByPhotoNewsIdLst(List<long> arrPhotoNewsId)
{
 List<clsvXzPhotoNewsEN> arrObjLst = null; 
string strAction = "GetObjLstByPhotoNewsIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPhotoNewsId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPhotoNewsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvXzPhotoNewsEN> GetObjLstByPhotoNewsIdLst_Cache(List<long> arrPhotoNewsId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzPhotoNewsEN._CurrTabName_S);
List<clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLst_Sel =
from objvXzPhotoNewsEN in arrvXzPhotoNewsObjLst_Cache
where arrPhotoNewsId.Contains(objvXzPhotoNewsEN.PhotoNewsId)
select objvXzPhotoNewsEN;
return arrvXzPhotoNewsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetObjLstByPhotoNewsIdLst_WA_Cache(List<long> arrPhotoNewsId)
{
 List<clsvXzPhotoNewsEN> arrObjLst = null; 
string strAction = "GetObjLstByPhotoNewsIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPhotoNewsId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzPhotoNewsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzPhotoNewsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzPhotoNewsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzPhotoNewsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngPhotoNewsId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PhotoNewsId"] = lngPhotoNewsId.ToString()
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvXzPhotoNewsENS">源对象</param>
 /// <param name = "objvXzPhotoNewsENT">目标对象</param>
 public static void CopyTo(clsvXzPhotoNewsEN objvXzPhotoNewsENS, clsvXzPhotoNewsEN objvXzPhotoNewsENT)
{
try
{
objvXzPhotoNewsENT.PhotoNewsId = objvXzPhotoNewsENS.PhotoNewsId; //流水号
objvXzPhotoNewsENT.DepartmentID = objvXzPhotoNewsENS.DepartmentID; //部门ID
objvXzPhotoNewsENT.Views = objvXzPhotoNewsENS.Views; //浏览量
objvXzPhotoNewsENT.IsTop = objvXzPhotoNewsENS.IsTop; //是否置顶
objvXzPhotoNewsENT.IsUrgent = objvXzPhotoNewsENS.IsUrgent; //是否紧急
objvXzPhotoNewsENT.Audit = objvXzPhotoNewsENS.Audit; //审核
objvXzPhotoNewsENT.PhotoNewsTitle = objvXzPhotoNewsENS.PhotoNewsTitle; //标题
objvXzPhotoNewsENT.ImageUrl = objvXzPhotoNewsENS.ImageUrl; //ImageUrl
objvXzPhotoNewsENT.PhotoNewsContent = objvXzPhotoNewsENS.PhotoNewsContent; //内容
objvXzPhotoNewsENT.PhotoNewsDate = objvXzPhotoNewsENS.PhotoNewsDate; //日期
objvXzPhotoNewsENT.PhotoNewsUser = objvXzPhotoNewsENS.PhotoNewsUser; //用户
objvXzPhotoNewsENT.Memo = objvXzPhotoNewsENS.Memo; //备注
objvXzPhotoNewsENT.CollegeName = objvXzPhotoNewsENS.CollegeName; //学院名称
objvXzPhotoNewsENT.id_XzCollege = objvXzPhotoNewsENS.id_XzCollege; //学院流水号
objvXzPhotoNewsENT.id_XzMajor = objvXzPhotoNewsENS.id_XzMajor; //专业流水号
objvXzPhotoNewsENT.MajorID = objvXzPhotoNewsENS.MajorID; //专业ID
objvXzPhotoNewsENT.MajorName = objvXzPhotoNewsENS.MajorName; //专业名称
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
public static DataTable ToDataTable(List<clsvXzPhotoNewsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzPhotoNewsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzPhotoNewsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzPhotoNewsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzPhotoNewsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzPhotoNewsEN.AttributeName)
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
if (clsXzPhotoNewsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzPhotoNewsWApi没有刷新缓存机制(clsXzPhotoNewsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PhotoNewsId");
//if (arrvXzPhotoNewsObjLst_Cache == null)
//{
//arrvXzPhotoNewsObjLst_Cache = await clsvXzPhotoNewsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzPhotoNewsEN._CurrTabName_S);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzPhotoNewsEN._CurrTabName_S);
List<clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzPhotoNewsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzPhotoNewsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzPhotoNews.PhotoNewsId, Type.GetType("System.Int64"));
objDT.Columns.Add(convXzPhotoNews.DepartmentID, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.Views, Type.GetType("System.Int32"));
objDT.Columns.Add(convXzPhotoNews.IsTop, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzPhotoNews.IsUrgent, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzPhotoNews.Audit, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.PhotoNewsTitle, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.PhotoNewsContent, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.PhotoNewsDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.PhotoNewsUser, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convXzPhotoNews.MajorName, Type.GetType("System.String"));
foreach (clsvXzPhotoNewsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzPhotoNews.PhotoNewsId] = objInFor[convXzPhotoNews.PhotoNewsId];
objDR[convXzPhotoNews.DepartmentID] = objInFor[convXzPhotoNews.DepartmentID];
objDR[convXzPhotoNews.Views] = objInFor[convXzPhotoNews.Views];
objDR[convXzPhotoNews.IsTop] = objInFor[convXzPhotoNews.IsTop];
objDR[convXzPhotoNews.IsUrgent] = objInFor[convXzPhotoNews.IsUrgent];
objDR[convXzPhotoNews.Audit] = objInFor[convXzPhotoNews.Audit];
objDR[convXzPhotoNews.PhotoNewsTitle] = objInFor[convXzPhotoNews.PhotoNewsTitle];
objDR[convXzPhotoNews.ImageUrl] = objInFor[convXzPhotoNews.ImageUrl];
objDR[convXzPhotoNews.PhotoNewsContent] = objInFor[convXzPhotoNews.PhotoNewsContent];
objDR[convXzPhotoNews.PhotoNewsDate] = objInFor[convXzPhotoNews.PhotoNewsDate];
objDR[convXzPhotoNews.PhotoNewsUser] = objInFor[convXzPhotoNews.PhotoNewsUser];
objDR[convXzPhotoNews.Memo] = objInFor[convXzPhotoNews.Memo];
objDR[convXzPhotoNews.CollegeName] = objInFor[convXzPhotoNews.CollegeName];
objDR[convXzPhotoNews.id_XzCollege] = objInFor[convXzPhotoNews.id_XzCollege];
objDR[convXzPhotoNews.id_XzMajor] = objInFor[convXzPhotoNews.id_XzMajor];
objDR[convXzPhotoNews.MajorID] = objInFor[convXzPhotoNews.MajorID];
objDR[convXzPhotoNews.MajorName] = objInFor[convXzPhotoNews.MajorName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}