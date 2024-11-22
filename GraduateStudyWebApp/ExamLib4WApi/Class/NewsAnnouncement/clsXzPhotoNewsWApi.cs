
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzPhotoNewsWApi
 表名:XzPhotoNews(01120421)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:53
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
public static class clsXzPhotoNewsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsId(this clsXzPhotoNewsEN objXzPhotoNewsEN, long lngPhotoNewsId, string strComparisonOp="")
	{
objXzPhotoNewsEN.PhotoNewsId = lngPhotoNewsId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsId) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsId, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsId] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsTitle(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strPhotoNewsTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPhotoNewsTitle, conXzPhotoNews.PhotoNewsTitle);
clsCheckSql.CheckFieldLen(strPhotoNewsTitle, 100, conXzPhotoNews.PhotoNewsTitle);
objXzPhotoNewsEN.PhotoNewsTitle = strPhotoNewsTitle; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsTitle) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsTitle, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsTitle] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetImageUrl(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 50, conXzPhotoNews.ImageUrl);
objXzPhotoNewsEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.ImageUrl) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.ImageUrl, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.ImageUrl] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsContent(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strPhotoNewsContent, string strComparisonOp="")
	{
objXzPhotoNewsEN.PhotoNewsContent = strPhotoNewsContent; //内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsContent) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsContent, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsContent] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsDate(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strPhotoNewsDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhotoNewsDate, 16, conXzPhotoNews.PhotoNewsDate);
clsCheckSql.CheckFieldForeignKey(strPhotoNewsDate, 16, conXzPhotoNews.PhotoNewsDate);
objXzPhotoNewsEN.PhotoNewsDate = strPhotoNewsDate; //日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsDate) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsDate, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsDate] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetPhotoNewsUser(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strPhotoNewsUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhotoNewsUser, 50, conXzPhotoNews.PhotoNewsUser);
objXzPhotoNewsEN.PhotoNewsUser = strPhotoNewsUser; //用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.PhotoNewsUser) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.PhotoNewsUser, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.PhotoNewsUser] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetDepartmentID(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strDepartmentID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentID, conXzPhotoNews.DepartmentID);
clsCheckSql.CheckFieldLen(strDepartmentID, 8, conXzPhotoNews.DepartmentID);
clsCheckSql.CheckFieldForeignKey(strDepartmentID, 8, conXzPhotoNews.DepartmentID);
objXzPhotoNewsEN.DepartmentID = strDepartmentID; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.DepartmentID) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.DepartmentID, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.DepartmentID] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN Setid_XzMajor(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conXzPhotoNews.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conXzPhotoNews.id_XzMajor);
objXzPhotoNewsEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.id_XzMajor) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.id_XzMajor, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.id_XzMajor] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetViews(this clsXzPhotoNewsEN objXzPhotoNewsEN, int intViews, string strComparisonOp="")
	{
objXzPhotoNewsEN.Views = intViews; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.Views) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.Views, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.Views] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetIsTop(this clsXzPhotoNewsEN objXzPhotoNewsEN, bool bolIsTop, string strComparisonOp="")
	{
objXzPhotoNewsEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.IsTop) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.IsTop, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.IsTop] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetIsUrgent(this clsXzPhotoNewsEN objXzPhotoNewsEN, bool bolIsUrgent, string strComparisonOp="")
	{
objXzPhotoNewsEN.IsUrgent = bolIsUrgent; //是否紧急
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.IsUrgent) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.IsUrgent, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.IsUrgent] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetAudit(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strAudit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAudit, 1, conXzPhotoNews.Audit);
clsCheckSql.CheckFieldForeignKey(strAudit, 1, conXzPhotoNews.Audit);
objXzPhotoNewsEN.Audit = strAudit; //审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.Audit) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.Audit, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.Audit] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzPhotoNewsEN SetMemo(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzPhotoNews.Memo);
objXzPhotoNewsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzPhotoNewsEN.dicFldComparisonOp.ContainsKey(conXzPhotoNews.Memo) == false)
{
objXzPhotoNewsEN.dicFldComparisonOp.Add(conXzPhotoNews.Memo, strComparisonOp);
}
else
{
objXzPhotoNewsEN.dicFldComparisonOp[conXzPhotoNews.Memo] = strComparisonOp;
}
}
return objXzPhotoNewsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzPhotoNewsEN objXzPhotoNews_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.PhotoNewsId) == true)
{
string strComparisonOp_PhotoNewsId = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.PhotoNewsId];
strWhereCond += string.Format(" And {0} {2} {1}", conXzPhotoNews.PhotoNewsId, objXzPhotoNews_Cond.PhotoNewsId, strComparisonOp_PhotoNewsId);
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.PhotoNewsTitle) == true)
{
string strComparisonOp_PhotoNewsTitle = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.PhotoNewsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.PhotoNewsTitle, objXzPhotoNews_Cond.PhotoNewsTitle, strComparisonOp_PhotoNewsTitle);
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.ImageUrl) == true)
{
string strComparisonOp_ImageUrl = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.ImageUrl, objXzPhotoNews_Cond.ImageUrl, strComparisonOp_ImageUrl);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.PhotoNewsDate) == true)
{
string strComparisonOp_PhotoNewsDate = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.PhotoNewsDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.PhotoNewsDate, objXzPhotoNews_Cond.PhotoNewsDate, strComparisonOp_PhotoNewsDate);
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.PhotoNewsUser) == true)
{
string strComparisonOp_PhotoNewsUser = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.PhotoNewsUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.PhotoNewsUser, objXzPhotoNews_Cond.PhotoNewsUser, strComparisonOp_PhotoNewsUser);
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.DepartmentID) == true)
{
string strComparisonOp_DepartmentID = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.DepartmentID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.DepartmentID, objXzPhotoNews_Cond.DepartmentID, strComparisonOp_DepartmentID);
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.id_XzMajor, objXzPhotoNews_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.Views) == true)
{
string strComparisonOp_Views = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.Views];
strWhereCond += string.Format(" And {0} {2} {1}", conXzPhotoNews.Views, objXzPhotoNews_Cond.Views, strComparisonOp_Views);
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.IsTop) == true)
{
if (objXzPhotoNews_Cond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzPhotoNews.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzPhotoNews.IsTop);
}
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.IsUrgent) == true)
{
if (objXzPhotoNews_Cond.IsUrgent == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzPhotoNews.IsUrgent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzPhotoNews.IsUrgent);
}
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.Audit) == true)
{
string strComparisonOp_Audit = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.Audit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.Audit, objXzPhotoNews_Cond.Audit, strComparisonOp_Audit);
}
if (objXzPhotoNews_Cond.IsUpdated(conXzPhotoNews.Memo) == true)
{
string strComparisonOp_Memo = objXzPhotoNews_Cond.dicFldComparisonOp[conXzPhotoNews.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzPhotoNews.Memo, objXzPhotoNews_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
 if (objXzPhotoNewsEN.PhotoNewsId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objXzPhotoNewsEN.sf_UpdFldSetStr = objXzPhotoNewsEN.getsf_UpdFldSetStr();
clsXzPhotoNewsWApi.CheckPropertyNew(objXzPhotoNewsEN); 
bool bolResult = clsXzPhotoNewsWApi.UpdateRecord(objXzPhotoNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--XzPhotoNews(图片新闻), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_PhotoNewsTitle_PhotoNewsUser(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objXzPhotoNewsEN == null) return "";
if (objXzPhotoNewsEN.PhotoNewsId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PhotoNewsTitle = '{0}'", objXzPhotoNewsEN.PhotoNewsTitle);
 sbCondition.AppendFormat(" and PhotoNewsUser = '{0}'", objXzPhotoNewsEN.PhotoNewsUser);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PhotoNewsId !=  {0}", objXzPhotoNewsEN.PhotoNewsId);
 sbCondition.AppendFormat(" and PhotoNewsTitle = '{0}'", objXzPhotoNewsEN.PhotoNewsTitle);
 sbCondition.AppendFormat(" and PhotoNewsUser = '{0}'", objXzPhotoNewsEN.PhotoNewsUser);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzPhotoNewsEN objXzPhotoNewsEN)
{
try
{
clsXzPhotoNewsWApi.CheckPropertyNew(objXzPhotoNewsEN); 
bool bolResult = clsXzPhotoNewsWApi.AddNewRecord(objXzPhotoNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzPhotoNewsEN objXzPhotoNewsEN, string strWhereCond)
{
try
{
clsXzPhotoNewsWApi.CheckPropertyNew(objXzPhotoNewsEN); 
bool bolResult = clsXzPhotoNewsWApi.UpdateWithCondition(objXzPhotoNewsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsWApi.ReFreshCache();
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
 /// 图片新闻(XzPhotoNews)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzPhotoNewsWApi
{
private static readonly string mstrApiControllerName = "XzPhotoNewsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsXzPhotoNewsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
if (!Object.Equals(null, objXzPhotoNewsEN.PhotoNewsTitle) && GetStrLen(objXzPhotoNewsEN.PhotoNewsTitle) > 100)
{
 throw new Exception("字段[标题]的长度不能超过100!");
}
if (!Object.Equals(null, objXzPhotoNewsEN.ImageUrl) && GetStrLen(objXzPhotoNewsEN.ImageUrl) > 50)
{
 throw new Exception("字段[ImageUrl]的长度不能超过50!");
}
if (!Object.Equals(null, objXzPhotoNewsEN.PhotoNewsDate) && GetStrLen(objXzPhotoNewsEN.PhotoNewsDate) > 16)
{
 throw new Exception("字段[日期]的长度不能超过16!");
}
if (!Object.Equals(null, objXzPhotoNewsEN.PhotoNewsUser) && GetStrLen(objXzPhotoNewsEN.PhotoNewsUser) > 50)
{
 throw new Exception("字段[用户]的长度不能超过50!");
}
if (!Object.Equals(null, objXzPhotoNewsEN.DepartmentID) && GetStrLen(objXzPhotoNewsEN.DepartmentID) > 8)
{
 throw new Exception("字段[部门ID]的长度不能超过8!");
}
if (!Object.Equals(null, objXzPhotoNewsEN.id_XzMajor) && GetStrLen(objXzPhotoNewsEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objXzPhotoNewsEN.Audit) && GetStrLen(objXzPhotoNewsEN.Audit) > 1)
{
 throw new Exception("字段[审核]的长度不能超过1!");
}
if (!Object.Equals(null, objXzPhotoNewsEN.Memo) && GetStrLen(objXzPhotoNewsEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objXzPhotoNewsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPhotoNewsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzPhotoNewsEN GetObjByPhotoNewsId(long lngPhotoNewsId)
{
string strAction = "GetObjByPhotoNewsId";
string strErrMsg = string.Empty;
string strResult = "";
clsXzPhotoNewsEN objXzPhotoNewsEN = null;
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
objXzPhotoNewsEN = JsonConvert.DeserializeObject<clsXzPhotoNewsEN>((string)jobjReturn["ReturnObj"]);
return objXzPhotoNewsEN;
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
public static clsXzPhotoNewsEN GetObjByPhotoNewsId_WA_Cache(long lngPhotoNewsId)
{
string strAction = "GetObjByPhotoNewsId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsXzPhotoNewsEN objXzPhotoNewsEN = null;
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
objXzPhotoNewsEN = JsonConvert.DeserializeObject<clsXzPhotoNewsEN>((string)jobjReturn["ReturnObj"]);
return objXzPhotoNewsEN;
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
public static clsXzPhotoNewsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsXzPhotoNewsEN objXzPhotoNewsEN = null;
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
objXzPhotoNewsEN = JsonConvert.DeserializeObject<clsXzPhotoNewsEN>((string)jobjReturn["ReturnObj"]);
return objXzPhotoNewsEN;
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
public static clsXzPhotoNewsEN GetObjByPhotoNewsId_Cache(long lngPhotoNewsId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName_S);
List<clsXzPhotoNewsEN> arrXzPhotoNewsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzPhotoNewsEN> arrXzPhotoNewsObjLst_Sel =
from objXzPhotoNewsEN in arrXzPhotoNewsObjLst_Cache
where objXzPhotoNewsEN.PhotoNewsId == lngPhotoNewsId
select objXzPhotoNewsEN;
if (arrXzPhotoNewsObjLst_Sel.Count() == 0)
{
   clsXzPhotoNewsEN obj = clsXzPhotoNewsWApi.GetObjByPhotoNewsId(lngPhotoNewsId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrXzPhotoNewsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzPhotoNewsEN> GetObjLst(string strWhereCond)
{
 List<clsXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzPhotoNewsEN> GetObjLstByPhotoNewsIdLst(List<long> arrPhotoNewsId)
{
 List<clsXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsXzPhotoNewsEN> GetObjLstByPhotoNewsIdLst_Cache(List<long> arrPhotoNewsId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName_S);
List<clsXzPhotoNewsEN> arrXzPhotoNewsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzPhotoNewsEN> arrXzPhotoNewsObjLst_Sel =
from objXzPhotoNewsEN in arrXzPhotoNewsObjLst_Cache
where arrPhotoNewsId.Contains(objXzPhotoNewsEN.PhotoNewsId)
select objXzPhotoNewsEN;
return arrXzPhotoNewsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzPhotoNewsEN> GetObjLstByPhotoNewsIdLst_WA_Cache(List<long> arrPhotoNewsId)
{
 List<clsXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzPhotoNewsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzPhotoNewsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzPhotoNewsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzPhotoNewsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsXzPhotoNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzPhotoNewsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngPhotoNewsId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsXzPhotoNewsEN objXzPhotoNewsEN = clsXzPhotoNewsWApi.GetObjByPhotoNewsId(lngPhotoNewsId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngPhotoNewsId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzPhotoNewsWApi.ReFreshCache();
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
public static int DelXzPhotoNewss(List<string> arrPhotoNewsId)
{
string strAction = "DelXzPhotoNewss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPhotoNewsId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzPhotoNewsWApi.ReFreshCache();
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
public static int DelXzPhotoNewssByCond(string strWhereCond)
{
string strAction = "DelXzPhotoNewssByCond";
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
public static bool AddNewRecord(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzPhotoNewsEN>(objXzPhotoNewsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objXzPhotoNewsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzPhotoNewsEN>(objXzPhotoNewsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzPhotoNewsWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsXzPhotoNewsEN objXzPhotoNewsEN)
{
if (string.IsNullOrEmpty(objXzPhotoNewsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzPhotoNewsEN.PhotoNewsId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzPhotoNewsEN>(objXzPhotoNewsEN);
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
 /// <param name = "objXzPhotoNewsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsXzPhotoNewsEN objXzPhotoNewsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objXzPhotoNewsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzPhotoNewsEN.PhotoNewsId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzPhotoNewsEN.PhotoNewsId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzPhotoNewsEN>(objXzPhotoNewsEN);
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
 /// <param name = "objXzPhotoNewsENS">源对象</param>
 /// <param name = "objXzPhotoNewsENT">目标对象</param>
 public static void CopyTo(clsXzPhotoNewsEN objXzPhotoNewsENS, clsXzPhotoNewsEN objXzPhotoNewsENT)
{
try
{
objXzPhotoNewsENT.PhotoNewsId = objXzPhotoNewsENS.PhotoNewsId; //流水号
objXzPhotoNewsENT.PhotoNewsTitle = objXzPhotoNewsENS.PhotoNewsTitle; //标题
objXzPhotoNewsENT.ImageUrl = objXzPhotoNewsENS.ImageUrl; //ImageUrl
objXzPhotoNewsENT.PhotoNewsContent = objXzPhotoNewsENS.PhotoNewsContent; //内容
objXzPhotoNewsENT.PhotoNewsDate = objXzPhotoNewsENS.PhotoNewsDate; //日期
objXzPhotoNewsENT.PhotoNewsUser = objXzPhotoNewsENS.PhotoNewsUser; //用户
objXzPhotoNewsENT.DepartmentID = objXzPhotoNewsENS.DepartmentID; //部门ID
objXzPhotoNewsENT.id_XzMajor = objXzPhotoNewsENS.id_XzMajor; //专业流水号
objXzPhotoNewsENT.Views = objXzPhotoNewsENS.Views; //浏览量
objXzPhotoNewsENT.IsTop = objXzPhotoNewsENS.IsTop; //是否置顶
objXzPhotoNewsENT.IsUrgent = objXzPhotoNewsENS.IsUrgent; //是否紧急
objXzPhotoNewsENT.Audit = objXzPhotoNewsENS.Audit; //审核
objXzPhotoNewsENT.Memo = objXzPhotoNewsENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsXzPhotoNewsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsXzPhotoNewsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsXzPhotoNewsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsXzPhotoNewsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsXzPhotoNewsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsXzPhotoNewsEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PhotoNewsId");
//if (arrXzPhotoNewsObjLst_Cache == null)
//{
//arrXzPhotoNewsObjLst_Cache = await clsXzPhotoNewsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName_S);
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
if (clsXzPhotoNewsWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsXzPhotoNewsWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzPhotoNewsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsXzPhotoNewsEN._CurrTabName_S);
List<clsXzPhotoNewsEN> arrXzPhotoNewsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzPhotoNewsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsXzPhotoNewsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conXzPhotoNews.PhotoNewsId, Type.GetType("System.Int64"));
objDT.Columns.Add(conXzPhotoNews.PhotoNewsTitle, Type.GetType("System.String"));
objDT.Columns.Add(conXzPhotoNews.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(conXzPhotoNews.PhotoNewsContent, Type.GetType("System.String"));
objDT.Columns.Add(conXzPhotoNews.PhotoNewsDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzPhotoNews.PhotoNewsUser, Type.GetType("System.String"));
objDT.Columns.Add(conXzPhotoNews.DepartmentID, Type.GetType("System.String"));
objDT.Columns.Add(conXzPhotoNews.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conXzPhotoNews.Views, Type.GetType("System.Int32"));
objDT.Columns.Add(conXzPhotoNews.IsTop, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzPhotoNews.IsUrgent, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzPhotoNews.Audit, Type.GetType("System.String"));
objDT.Columns.Add(conXzPhotoNews.Memo, Type.GetType("System.String"));
foreach (clsXzPhotoNewsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conXzPhotoNews.PhotoNewsId] = objInFor[conXzPhotoNews.PhotoNewsId];
objDR[conXzPhotoNews.PhotoNewsTitle] = objInFor[conXzPhotoNews.PhotoNewsTitle];
objDR[conXzPhotoNews.ImageUrl] = objInFor[conXzPhotoNews.ImageUrl];
objDR[conXzPhotoNews.PhotoNewsContent] = objInFor[conXzPhotoNews.PhotoNewsContent];
objDR[conXzPhotoNews.PhotoNewsDate] = objInFor[conXzPhotoNews.PhotoNewsDate];
objDR[conXzPhotoNews.PhotoNewsUser] = objInFor[conXzPhotoNews.PhotoNewsUser];
objDR[conXzPhotoNews.DepartmentID] = objInFor[conXzPhotoNews.DepartmentID];
objDR[conXzPhotoNews.id_XzMajor] = objInFor[conXzPhotoNews.id_XzMajor];
objDR[conXzPhotoNews.Views] = objInFor[conXzPhotoNews.Views];
objDR[conXzPhotoNews.IsTop] = objInFor[conXzPhotoNews.IsTop];
objDR[conXzPhotoNews.IsUrgent] = objInFor[conXzPhotoNews.IsUrgent];
objDR[conXzPhotoNews.Audit] = objInFor[conXzPhotoNews.Audit];
objDR[conXzPhotoNews.Memo] = objInFor[conXzPhotoNews.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 图片新闻(XzPhotoNews)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4XzPhotoNews : clsCommFun4BL
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
clsXzPhotoNewsWApi.ReFreshThisCache();
}
}

}