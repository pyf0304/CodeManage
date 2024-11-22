
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzPhotoNewsBL
 表名:vXzPhotoNews(01120420)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
public static class  clsvXzPhotoNewsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPhotoNewsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzPhotoNewsEN GetObj(this K_PhotoNewsId_vXzPhotoNews myKey)
{
clsvXzPhotoNewsEN objvXzPhotoNewsEN = clsvXzPhotoNewsBL.vXzPhotoNewsDA.GetObjByPhotoNewsId(myKey.Value);
return objvXzPhotoNewsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetDepartmentID(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strDepartmentID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentID, convXzPhotoNews.DepartmentID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentID, 8, convXzPhotoNews.DepartmentID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentID, 8, convXzPhotoNews.DepartmentID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetViews(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, int? intViews, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetAudit(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strAudit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAudit, 1, convXzPhotoNews.Audit);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAudit, 1, convXzPhotoNews.Audit);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetPhotoNewsTitle(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strPhotoNewsTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPhotoNewsTitle, convXzPhotoNews.PhotoNewsTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhotoNewsTitle, 100, convXzPhotoNews.PhotoNewsTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetImageUrl(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, convXzPhotoNews.ImageUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetPhotoNewsDate(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strPhotoNewsDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPhotoNewsDate, convXzPhotoNews.PhotoNewsDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhotoNewsDate, 16, convXzPhotoNews.PhotoNewsDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPhotoNewsDate, 16, convXzPhotoNews.PhotoNewsDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetPhotoNewsUser(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strPhotoNewsUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPhotoNewsUser, convXzPhotoNews.PhotoNewsUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhotoNewsUser, 50, convXzPhotoNews.PhotoNewsUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetMemo(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzPhotoNews.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetCollegeName(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convXzPhotoNews.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetIdXzCollege(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convXzPhotoNews.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convXzPhotoNews.IdXzCollege);
}
objvXzPhotoNewsEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.IdXzCollege) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.IdXzCollege, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.IdXzCollege] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetIdXzMajor(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convXzPhotoNews.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convXzPhotoNews.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convXzPhotoNews.IdXzMajor);
}
objvXzPhotoNewsEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(convXzPhotoNews.IdXzMajor) == false)
{
objvXzPhotoNewsEN.dicFldComparisonOp.Add(convXzPhotoNews.IdXzMajor, strComparisonOp);
}
else
{
objvXzPhotoNewsEN.dicFldComparisonOp[convXzPhotoNews.IdXzMajor] = strComparisonOp;
}
}
return objvXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetMajorID(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convXzPhotoNews.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convXzPhotoNews.MajorID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzPhotoNewsEN SetMajorName(this clsvXzPhotoNewsEN objvXzPhotoNewsEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convXzPhotoNews.MajorName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzPhotoNewsENS">源对象</param>
 /// <param name = "objvXzPhotoNewsENT">目标对象</param>
 public static void CopyTo(this clsvXzPhotoNewsEN objvXzPhotoNewsENS, clsvXzPhotoNewsEN objvXzPhotoNewsENT)
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
objvXzPhotoNewsENT.IdXzCollege = objvXzPhotoNewsENS.IdXzCollege; //学院流水号
objvXzPhotoNewsENT.IdXzMajor = objvXzPhotoNewsENS.IdXzMajor; //专业流水号
objvXzPhotoNewsENT.MajorID = objvXzPhotoNewsENS.MajorID; //专业ID
objvXzPhotoNewsENT.MajorName = objvXzPhotoNewsENS.MajorName; //专业名称
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
 /// <param name = "objvXzPhotoNewsENS">源对象</param>
 /// <returns>目标对象=>clsvXzPhotoNewsEN:objvXzPhotoNewsENT</returns>
 public static clsvXzPhotoNewsEN CopyTo(this clsvXzPhotoNewsEN objvXzPhotoNewsENS)
{
try
{
 clsvXzPhotoNewsEN objvXzPhotoNewsENT = new clsvXzPhotoNewsEN()
{
PhotoNewsId = objvXzPhotoNewsENS.PhotoNewsId, //流水号
DepartmentID = objvXzPhotoNewsENS.DepartmentID, //部门ID
Views = objvXzPhotoNewsENS.Views, //浏览量
IsTop = objvXzPhotoNewsENS.IsTop, //是否置顶
IsUrgent = objvXzPhotoNewsENS.IsUrgent, //是否紧急
Audit = objvXzPhotoNewsENS.Audit, //审核
PhotoNewsTitle = objvXzPhotoNewsENS.PhotoNewsTitle, //标题
ImageUrl = objvXzPhotoNewsENS.ImageUrl, //ImageUrl
PhotoNewsContent = objvXzPhotoNewsENS.PhotoNewsContent, //内容
PhotoNewsDate = objvXzPhotoNewsENS.PhotoNewsDate, //日期
PhotoNewsUser = objvXzPhotoNewsENS.PhotoNewsUser, //用户
Memo = objvXzPhotoNewsENS.Memo, //备注
CollegeName = objvXzPhotoNewsENS.CollegeName, //学院名称
IdXzCollege = objvXzPhotoNewsENS.IdXzCollege, //学院流水号
IdXzMajor = objvXzPhotoNewsENS.IdXzMajor, //专业流水号
MajorID = objvXzPhotoNewsENS.MajorID, //专业ID
MajorName = objvXzPhotoNewsENS.MajorName, //专业名称
};
 return objvXzPhotoNewsENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvXzPhotoNewsEN objvXzPhotoNewsEN)
{
 clsvXzPhotoNewsBL.vXzPhotoNewsDA.CheckProperty4Condition(objvXzPhotoNewsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzPhotoNewsEN objvXzPhotoNewsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.PhotoNewsId) == true)
{
string strComparisonOpPhotoNewsId = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.PhotoNewsId];
strWhereCond += string.Format(" And {0} {2} {1}", convXzPhotoNews.PhotoNewsId, objvXzPhotoNewsCond.PhotoNewsId, strComparisonOpPhotoNewsId);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.DepartmentID) == true)
{
string strComparisonOpDepartmentID = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.DepartmentID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.DepartmentID, objvXzPhotoNewsCond.DepartmentID, strComparisonOpDepartmentID);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.Views) == true)
{
string strComparisonOpViews = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.Views];
strWhereCond += string.Format(" And {0} {2} {1}", convXzPhotoNews.Views, objvXzPhotoNewsCond.Views, strComparisonOpViews);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.IsTop) == true)
{
if (objvXzPhotoNewsCond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzPhotoNews.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzPhotoNews.IsTop);
}
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.IsUrgent) == true)
{
if (objvXzPhotoNewsCond.IsUrgent == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzPhotoNews.IsUrgent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzPhotoNews.IsUrgent);
}
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.Audit) == true)
{
string strComparisonOpAudit = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.Audit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.Audit, objvXzPhotoNewsCond.Audit, strComparisonOpAudit);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.PhotoNewsTitle) == true)
{
string strComparisonOpPhotoNewsTitle = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.PhotoNewsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.PhotoNewsTitle, objvXzPhotoNewsCond.PhotoNewsTitle, strComparisonOpPhotoNewsTitle);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.ImageUrl) == true)
{
string strComparisonOpImageUrl = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.ImageUrl, objvXzPhotoNewsCond.ImageUrl, strComparisonOpImageUrl);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.PhotoNewsDate) == true)
{
string strComparisonOpPhotoNewsDate = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.PhotoNewsDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.PhotoNewsDate, objvXzPhotoNewsCond.PhotoNewsDate, strComparisonOpPhotoNewsDate);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.PhotoNewsUser) == true)
{
string strComparisonOpPhotoNewsUser = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.PhotoNewsUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.PhotoNewsUser, objvXzPhotoNewsCond.PhotoNewsUser, strComparisonOpPhotoNewsUser);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.Memo) == true)
{
string strComparisonOpMemo = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.Memo, objvXzPhotoNewsCond.Memo, strComparisonOpMemo);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.CollegeName) == true)
{
string strComparisonOpCollegeName = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.CollegeName, objvXzPhotoNewsCond.CollegeName, strComparisonOpCollegeName);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.IdXzCollege, objvXzPhotoNewsCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.IdXzMajor, objvXzPhotoNewsCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.MajorID) == true)
{
string strComparisonOpMajorID = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.MajorID, objvXzPhotoNewsCond.MajorID, strComparisonOpMajorID);
}
if (objvXzPhotoNewsCond.IsUpdated(convXzPhotoNews.MajorName) == true)
{
string strComparisonOpMajorName = objvXzPhotoNewsCond.dicFldComparisonOp[convXzPhotoNews.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzPhotoNews.MajorName, objvXzPhotoNewsCond.MajorName, strComparisonOpMajorName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzPhotoNews
{
public virtual bool UpdRelaTabDate(long lngPhotoNewsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v图片新闻(vXzPhotoNews)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzPhotoNewsBL
{
public static RelatedActions_vXzPhotoNews relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzPhotoNewsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzPhotoNewsDA vXzPhotoNewsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzPhotoNewsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzPhotoNewsBL()
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
if (string.IsNullOrEmpty(clsvXzPhotoNewsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzPhotoNewsEN._ConnectString);
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
public static DataTable GetDataTable_vXzPhotoNews(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzPhotoNewsDA.GetDataTable_vXzPhotoNews(strWhereCond);
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
objDT = vXzPhotoNewsDA.GetDataTable(strWhereCond);
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
objDT = vXzPhotoNewsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vXzPhotoNewsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vXzPhotoNewsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vXzPhotoNewsDA.GetDataTable_Top(objTopPara);
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
objDT = vXzPhotoNewsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vXzPhotoNewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vXzPhotoNewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPhotoNewsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetObjLstByPhotoNewsIdLst(List<long> arrPhotoNewsIdLst)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPhotoNewsIdLst);
 string strWhereCond = string.Format("PhotoNewsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPhotoNewsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzPhotoNewsEN> GetObjLstByPhotoNewsIdLstCache(List<long> arrPhotoNewsIdLst)
{
string strKey = string.Format("{0}", clsvXzPhotoNewsEN._CurrTabName);
List<clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLstCache = GetObjLstCache();
IEnumerable <clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLst_Sel =
arrvXzPhotoNewsObjLstCache
.Where(x => arrPhotoNewsIdLst.Contains(x.PhotoNewsId));
return arrvXzPhotoNewsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetObjLst(string strWhereCond)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
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
public static List<clsvXzPhotoNewsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvXzPhotoNewsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzPhotoNewsEN> GetSubObjLstCache(clsvXzPhotoNewsEN objvXzPhotoNewsCond)
{
List<clsvXzPhotoNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzPhotoNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzPhotoNews.AttributeName)
{
if (objvXzPhotoNewsCond.IsUpdated(strFldName) == false) continue;
if (objvXzPhotoNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzPhotoNewsCond[strFldName].ToString());
}
else
{
if (objvXzPhotoNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzPhotoNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzPhotoNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzPhotoNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzPhotoNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzPhotoNewsCond[strFldName]));
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
public static List<clsvXzPhotoNewsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
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
public static List<clsvXzPhotoNewsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
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
List<clsvXzPhotoNewsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvXzPhotoNewsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvXzPhotoNewsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
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
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
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
public static List<clsvXzPhotoNewsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvXzPhotoNewsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
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
public static List<clsvXzPhotoNewsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzPhotoNewsEN> arrObjLst = new List<clsvXzPhotoNewsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzPhotoNewsEN objvXzPhotoNewsEN = new clsvXzPhotoNewsEN();
try
{
objvXzPhotoNewsEN.PhotoNewsId = Int32.Parse(objRow[convXzPhotoNews.PhotoNewsId].ToString().Trim()); //流水号
objvXzPhotoNewsEN.DepartmentID = objRow[convXzPhotoNews.DepartmentID].ToString().Trim(); //部门ID
objvXzPhotoNewsEN.Views = objRow[convXzPhotoNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzPhotoNews.Views].ToString().Trim()); //浏览量
objvXzPhotoNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsTop].ToString().Trim()); //是否置顶
objvXzPhotoNewsEN.IsUrgent = clsEntityBase2.TransNullToBool_S(objRow[convXzPhotoNews.IsUrgent].ToString().Trim()); //是否紧急
objvXzPhotoNewsEN.Audit = objRow[convXzPhotoNews.Audit] == DBNull.Value ? null : objRow[convXzPhotoNews.Audit].ToString().Trim(); //审核
objvXzPhotoNewsEN.PhotoNewsTitle = objRow[convXzPhotoNews.PhotoNewsTitle].ToString().Trim(); //标题
objvXzPhotoNewsEN.ImageUrl = objRow[convXzPhotoNews.ImageUrl] == DBNull.Value ? null : objRow[convXzPhotoNews.ImageUrl].ToString().Trim(); //ImageUrl
objvXzPhotoNewsEN.PhotoNewsContent = objRow[convXzPhotoNews.PhotoNewsContent] == DBNull.Value ? null : objRow[convXzPhotoNews.PhotoNewsContent].ToString().Trim(); //内容
objvXzPhotoNewsEN.PhotoNewsDate = objRow[convXzPhotoNews.PhotoNewsDate].ToString().Trim(); //日期
objvXzPhotoNewsEN.PhotoNewsUser = objRow[convXzPhotoNews.PhotoNewsUser].ToString().Trim(); //用户
objvXzPhotoNewsEN.Memo = objRow[convXzPhotoNews.Memo] == DBNull.Value ? null : objRow[convXzPhotoNews.Memo].ToString().Trim(); //备注
objvXzPhotoNewsEN.CollegeName = objRow[convXzPhotoNews.CollegeName] == DBNull.Value ? null : objRow[convXzPhotoNews.CollegeName].ToString().Trim(); //学院名称
objvXzPhotoNewsEN.IdXzCollege = objRow[convXzPhotoNews.IdXzCollege] == DBNull.Value ? null : objRow[convXzPhotoNews.IdXzCollege].ToString().Trim(); //学院流水号
objvXzPhotoNewsEN.IdXzMajor = objRow[convXzPhotoNews.IdXzMajor].ToString().Trim(); //专业流水号
objvXzPhotoNewsEN.MajorID = objRow[convXzPhotoNews.MajorID] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorID].ToString().Trim(); //专业ID
objvXzPhotoNewsEN.MajorName = objRow[convXzPhotoNews.MajorName] == DBNull.Value ? null : objRow[convXzPhotoNews.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzPhotoNewsEN.PhotoNewsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzPhotoNewsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzPhotoNewsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzPhotoNews(ref clsvXzPhotoNewsEN objvXzPhotoNewsEN)
{
bool bolResult = vXzPhotoNewsDA.GetvXzPhotoNews(ref objvXzPhotoNewsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPhotoNewsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzPhotoNewsEN GetObjByPhotoNewsId(long lngPhotoNewsId)
{
clsvXzPhotoNewsEN objvXzPhotoNewsEN = vXzPhotoNewsDA.GetObjByPhotoNewsId(lngPhotoNewsId);
return objvXzPhotoNewsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzPhotoNewsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzPhotoNewsEN objvXzPhotoNewsEN = vXzPhotoNewsDA.GetFirstObj(strWhereCond);
 return objvXzPhotoNewsEN;
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
public static clsvXzPhotoNewsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzPhotoNewsEN objvXzPhotoNewsEN = vXzPhotoNewsDA.GetObjByDataRow(objRow);
 return objvXzPhotoNewsEN;
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
public static clsvXzPhotoNewsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzPhotoNewsEN objvXzPhotoNewsEN = vXzPhotoNewsDA.GetObjByDataRow(objRow);
 return objvXzPhotoNewsEN;
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
 /// <param name = "lngPhotoNewsId">所给的关键字</param>
 /// <param name = "lstvXzPhotoNewsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzPhotoNewsEN GetObjByPhotoNewsIdFromList(long lngPhotoNewsId, List<clsvXzPhotoNewsEN> lstvXzPhotoNewsObjLst)
{
foreach (clsvXzPhotoNewsEN objvXzPhotoNewsEN in lstvXzPhotoNewsObjLst)
{
if (objvXzPhotoNewsEN.PhotoNewsId == lngPhotoNewsId)
{
return objvXzPhotoNewsEN;
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
 long lngPhotoNewsId;
 try
 {
 lngPhotoNewsId = new clsvXzPhotoNewsDA().GetFirstID(strWhereCond);
 return lngPhotoNewsId;
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
 arrList = vXzPhotoNewsDA.GetID(strWhereCond);
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
bool bolIsExist = vXzPhotoNewsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPhotoNewsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPhotoNewsId)
{
//检测记录是否存在
bool bolIsExist = vXzPhotoNewsDA.IsExist(lngPhotoNewsId);
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
 bolIsExist = clsvXzPhotoNewsDA.IsExistTable();
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
 bolIsExist = vXzPhotoNewsDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
objvXzPhotoNewsENT.IdXzCollege = objvXzPhotoNewsENS.IdXzCollege; //学院流水号
objvXzPhotoNewsENT.IdXzMajor = objvXzPhotoNewsENS.IdXzMajor; //专业流水号
objvXzPhotoNewsENT.MajorID = objvXzPhotoNewsENS.MajorID; //专业ID
objvXzPhotoNewsENT.MajorName = objvXzPhotoNewsENS.MajorName; //专业名称
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
 /// <param name = "objvXzPhotoNewsEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzPhotoNewsEN objvXzPhotoNewsEN)
{
try
{
objvXzPhotoNewsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvXzPhotoNewsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzPhotoNews.PhotoNewsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.PhotoNewsId = objvXzPhotoNewsEN.PhotoNewsId; //流水号
}
if (arrFldSet.Contains(convXzPhotoNews.DepartmentID, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.DepartmentID = objvXzPhotoNewsEN.DepartmentID; //部门ID
}
if (arrFldSet.Contains(convXzPhotoNews.Views, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.Views = objvXzPhotoNewsEN.Views; //浏览量
}
if (arrFldSet.Contains(convXzPhotoNews.IsTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.IsTop = objvXzPhotoNewsEN.IsTop; //是否置顶
}
if (arrFldSet.Contains(convXzPhotoNews.IsUrgent, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.IsUrgent = objvXzPhotoNewsEN.IsUrgent; //是否紧急
}
if (arrFldSet.Contains(convXzPhotoNews.Audit, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.Audit = objvXzPhotoNewsEN.Audit == "[null]" ? null :  objvXzPhotoNewsEN.Audit; //审核
}
if (arrFldSet.Contains(convXzPhotoNews.PhotoNewsTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.PhotoNewsTitle = objvXzPhotoNewsEN.PhotoNewsTitle; //标题
}
if (arrFldSet.Contains(convXzPhotoNews.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.ImageUrl = objvXzPhotoNewsEN.ImageUrl == "[null]" ? null :  objvXzPhotoNewsEN.ImageUrl; //ImageUrl
}
if (arrFldSet.Contains(convXzPhotoNews.PhotoNewsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.PhotoNewsContent = objvXzPhotoNewsEN.PhotoNewsContent == "[null]" ? null :  objvXzPhotoNewsEN.PhotoNewsContent; //内容
}
if (arrFldSet.Contains(convXzPhotoNews.PhotoNewsDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.PhotoNewsDate = objvXzPhotoNewsEN.PhotoNewsDate; //日期
}
if (arrFldSet.Contains(convXzPhotoNews.PhotoNewsUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.PhotoNewsUser = objvXzPhotoNewsEN.PhotoNewsUser; //用户
}
if (arrFldSet.Contains(convXzPhotoNews.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.Memo = objvXzPhotoNewsEN.Memo == "[null]" ? null :  objvXzPhotoNewsEN.Memo; //备注
}
if (arrFldSet.Contains(convXzPhotoNews.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.CollegeName = objvXzPhotoNewsEN.CollegeName == "[null]" ? null :  objvXzPhotoNewsEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convXzPhotoNews.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.IdXzCollege = objvXzPhotoNewsEN.IdXzCollege == "[null]" ? null :  objvXzPhotoNewsEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convXzPhotoNews.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.IdXzMajor = objvXzPhotoNewsEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convXzPhotoNews.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.MajorID = objvXzPhotoNewsEN.MajorID == "[null]" ? null :  objvXzPhotoNewsEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convXzPhotoNews.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzPhotoNewsEN.MajorName = objvXzPhotoNewsEN.MajorName == "[null]" ? null :  objvXzPhotoNewsEN.MajorName; //专业名称
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
 /// <param name = "objvXzPhotoNewsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvXzPhotoNewsEN objvXzPhotoNewsEN)
{
try
{
if (objvXzPhotoNewsEN.Audit == "[null]") objvXzPhotoNewsEN.Audit = null; //审核
if (objvXzPhotoNewsEN.ImageUrl == "[null]") objvXzPhotoNewsEN.ImageUrl = null; //ImageUrl
if (objvXzPhotoNewsEN.PhotoNewsContent == "[null]") objvXzPhotoNewsEN.PhotoNewsContent = null; //内容
if (objvXzPhotoNewsEN.Memo == "[null]") objvXzPhotoNewsEN.Memo = null; //备注
if (objvXzPhotoNewsEN.CollegeName == "[null]") objvXzPhotoNewsEN.CollegeName = null; //学院名称
if (objvXzPhotoNewsEN.IdXzCollege == "[null]") objvXzPhotoNewsEN.IdXzCollege = null; //学院流水号
if (objvXzPhotoNewsEN.MajorID == "[null]") objvXzPhotoNewsEN.MajorID = null; //专业ID
if (objvXzPhotoNewsEN.MajorName == "[null]") objvXzPhotoNewsEN.MajorName = null; //专业名称
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvXzPhotoNewsEN objvXzPhotoNewsEN)
{
 vXzPhotoNewsDA.CheckProperty4Condition(objvXzPhotoNewsEN);
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
if (clsXzPhotoNewsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzPhotoNewsBL没有刷新缓存机制(clsXzPhotoNewsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeBL没有刷新缓存机制(clsXzDegreeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeBL没有刷新缓存机制(clsXzMajorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeBL没有刷新缓存机制(clsXzMajorShoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PhotoNewsId");
//if (arrvXzPhotoNewsObjLstCache == null)
//{
//arrvXzPhotoNewsObjLstCache = vXzPhotoNewsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPhotoNewsId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzPhotoNewsEN GetObjByPhotoNewsIdCache(long lngPhotoNewsId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzPhotoNewsEN._CurrTabName);
List<clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLstCache = GetObjLstCache();
IEnumerable <clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLst_Sel =
arrvXzPhotoNewsObjLstCache
.Where(x=> x.PhotoNewsId == lngPhotoNewsId 
);
if (arrvXzPhotoNewsObjLst_Sel.Count() == 0)
{
   clsvXzPhotoNewsEN obj = clsvXzPhotoNewsBL.GetObjByPhotoNewsId(lngPhotoNewsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvXzPhotoNewsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetAllvXzPhotoNewsObjLstCache()
{
//获取缓存中的对象列表
List<clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLstCache = GetObjLstCache(); 
return arrvXzPhotoNewsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzPhotoNewsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzPhotoNewsEN._CurrTabName);
List<clsvXzPhotoNewsEN> arrvXzPhotoNewsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzPhotoNewsObjLstCache;
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
string strKey = string.Format("{0}", clsvXzPhotoNewsEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngPhotoNewsId)
{
if (strInFldName != convXzPhotoNews.PhotoNewsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzPhotoNews.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzPhotoNews.AttributeName));
throw new Exception(strMsg);
}
var objvXzPhotoNews = clsvXzPhotoNewsBL.GetObjByPhotoNewsIdCache(lngPhotoNewsId);
if (objvXzPhotoNews == null) return "";
return objvXzPhotoNews[strOutFldName].ToString();
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
int intRecCount = clsvXzPhotoNewsDA.GetRecCount(strTabName);
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
int intRecCount = clsvXzPhotoNewsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzPhotoNewsDA.GetRecCount();
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
int intRecCount = clsvXzPhotoNewsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvXzPhotoNewsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvXzPhotoNewsEN objvXzPhotoNewsCond)
{
List<clsvXzPhotoNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzPhotoNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzPhotoNews.AttributeName)
{
if (objvXzPhotoNewsCond.IsUpdated(strFldName) == false) continue;
if (objvXzPhotoNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzPhotoNewsCond[strFldName].ToString());
}
else
{
if (objvXzPhotoNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzPhotoNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzPhotoNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzPhotoNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzPhotoNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzPhotoNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzPhotoNewsCond[strFldName]));
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
 List<string> arrList = clsvXzPhotoNewsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vXzPhotoNewsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vXzPhotoNewsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}