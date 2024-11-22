
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDiscussionSubContentBL
 表名:vDiscussionSubContent(01120585)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:53:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsvDiscussionSubContentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSubContentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDiscussionSubContentEN GetObj(this K_SubContentId_vDiscussionSubContent myKey)
{
clsvDiscussionSubContentEN objvDiscussionSubContentEN = clsvDiscussionSubContentBL.vDiscussionSubContentDA.GetObjBySubContentId(myKey.Value);
return objvDiscussionSubContentEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetSubContent(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strSubContent, string strComparisonOp="")
	{
objvDiscussionSubContentEN.SubContent = strSubContent; //子内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.SubContent) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.SubContent, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.SubContent] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetTopicsId(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strTopicsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicsId, 8, convDiscussionSubContent.TopicsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicsId, 8, convDiscussionSubContent.TopicsId);
}
objvDiscussionSubContentEN.TopicsId = strTopicsId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.TopicsId) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.TopicsId, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.TopicsId] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetTopicsTitle(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strTopicsTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicsTitle, 200, convDiscussionSubContent.TopicsTitle);
}
objvDiscussionSubContentEN.TopicsTitle = strTopicsTitle; //主题标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.TopicsTitle) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.TopicsTitle, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.TopicsTitle] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetIsTop(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, bool bolIsTop, string strComparisonOp="")
	{
objvDiscussionSubContentEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.IsTop) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.IsTop, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.IsTop] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetUpdDate(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDiscussionSubContent.UpdDate);
}
objvDiscussionSubContentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.UpdDate) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.UpdDate, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.UpdDate] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetUpdUser(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDiscussionSubContent.UpdUser);
}
objvDiscussionSubContentEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.UpdUser) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.UpdUser, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.UpdUser] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetMemo(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDiscussionSubContent.Memo);
}
objvDiscussionSubContentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.Memo) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.Memo, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.Memo] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetCollegeName(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convDiscussionSubContent.CollegeName);
}
objvDiscussionSubContentEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.CollegeName) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.CollegeName, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.CollegeName] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetIdXzCollege(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convDiscussionSubContent.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convDiscussionSubContent.IdXzCollege);
}
objvDiscussionSubContentEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.IdXzCollege) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.IdXzCollege, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.IdXzCollege] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetIdXzMajor(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convDiscussionSubContent.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convDiscussionSubContent.IdXzMajor);
}
objvDiscussionSubContentEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.IdXzMajor) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.IdXzMajor, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.IdXzMajor] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetMajorName(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convDiscussionSubContent.MajorName);
}
objvDiscussionSubContentEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.MajorName) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.MajorName, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.MajorName] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetUserName(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convDiscussionSubContent.UserName);
}
objvDiscussionSubContentEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.UserName) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.UserName, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.UserName] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetBrowseNumber(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvDiscussionSubContentEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.BrowseNumber) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.BrowseNumber, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.BrowseNumber] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetIdCurrEduCls(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convDiscussionSubContent.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convDiscussionSubContent.IdCurrEduCls);
}
objvDiscussionSubContentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.IdCurrEduCls) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.IdCurrEduCls, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.IdCurrEduCls] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetParentId(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, convDiscussionSubContent.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, convDiscussionSubContent.ParentId);
}
objvDiscussionSubContentEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.ParentId) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.ParentId, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.ParentId] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetTopicsContent(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strTopicsContent, string strComparisonOp="")
	{
objvDiscussionSubContentEN.TopicsContent = strTopicsContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.TopicsContent) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.TopicsContent, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.TopicsContent] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetUserId(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convDiscussionSubContent.UserId);
}
objvDiscussionSubContentEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.UserId) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.UserId, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.UserId] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetvUpdDate(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strvUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strvUpdDate, 20, convDiscussionSubContent.vUpdDate);
}
objvDiscussionSubContentEN.vUpdDate = strvUpdDate; //vUpdDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.vUpdDate) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.vUpdDate, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.vUpdDate] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetvUpdUser(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strvUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strvUpdUser, 50, convDiscussionSubContent.vUpdUser);
}
objvDiscussionSubContentEN.vUpdUser = strvUpdUser; //vUpdUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.vUpdUser) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.vUpdUser, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.vUpdUser] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionSubContentEN SetSubContentId(this clsvDiscussionSubContentEN objvDiscussionSubContentEN, string strSubContentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubContentId, 10, convDiscussionSubContent.SubContentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSubContentId, 10, convDiscussionSubContent.SubContentId);
}
objvDiscussionSubContentEN.SubContentId = strSubContentId; //子内容Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionSubContentEN.dicFldComparisonOp.ContainsKey(convDiscussionSubContent.SubContentId) == false)
{
objvDiscussionSubContentEN.dicFldComparisonOp.Add(convDiscussionSubContent.SubContentId, strComparisonOp);
}
else
{
objvDiscussionSubContentEN.dicFldComparisonOp[convDiscussionSubContent.SubContentId] = strComparisonOp;
}
}
return objvDiscussionSubContentEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDiscussionSubContentENS">源对象</param>
 /// <param name = "objvDiscussionSubContentENT">目标对象</param>
 public static void CopyTo(this clsvDiscussionSubContentEN objvDiscussionSubContentENS, clsvDiscussionSubContentEN objvDiscussionSubContentENT)
{
try
{
objvDiscussionSubContentENT.SubContent = objvDiscussionSubContentENS.SubContent; //子内容
objvDiscussionSubContentENT.TopicsId = objvDiscussionSubContentENS.TopicsId; //主题Id
objvDiscussionSubContentENT.TopicsTitle = objvDiscussionSubContentENS.TopicsTitle; //主题标题
objvDiscussionSubContentENT.IsTop = objvDiscussionSubContentENS.IsTop; //是否置顶
objvDiscussionSubContentENT.UpdDate = objvDiscussionSubContentENS.UpdDate; //修改日期
objvDiscussionSubContentENT.UpdUser = objvDiscussionSubContentENS.UpdUser; //修改人
objvDiscussionSubContentENT.Memo = objvDiscussionSubContentENS.Memo; //备注
objvDiscussionSubContentENT.CollegeName = objvDiscussionSubContentENS.CollegeName; //学院名称
objvDiscussionSubContentENT.IdXzCollege = objvDiscussionSubContentENS.IdXzCollege; //学院流水号
objvDiscussionSubContentENT.IdXzMajor = objvDiscussionSubContentENS.IdXzMajor; //专业流水号
objvDiscussionSubContentENT.MajorName = objvDiscussionSubContentENS.MajorName; //专业名称
objvDiscussionSubContentENT.UserName = objvDiscussionSubContentENS.UserName; //用户名
objvDiscussionSubContentENT.BrowseNumber = objvDiscussionSubContentENS.BrowseNumber; //浏览量
objvDiscussionSubContentENT.IdCurrEduCls = objvDiscussionSubContentENS.IdCurrEduCls; //教学班流水号
objvDiscussionSubContentENT.ParentId = objvDiscussionSubContentENS.ParentId; //父节点Id
objvDiscussionSubContentENT.TopicsContent = objvDiscussionSubContentENS.TopicsContent; //主题内容
objvDiscussionSubContentENT.UserId = objvDiscussionSubContentENS.UserId; //用户ID
objvDiscussionSubContentENT.vUpdDate = objvDiscussionSubContentENS.vUpdDate; //vUpdDate
objvDiscussionSubContentENT.vUpdUser = objvDiscussionSubContentENS.vUpdUser; //vUpdUser
objvDiscussionSubContentENT.SubContentId = objvDiscussionSubContentENS.SubContentId; //子内容Id
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
 /// <param name = "objvDiscussionSubContentENS">源对象</param>
 /// <returns>目标对象=>clsvDiscussionSubContentEN:objvDiscussionSubContentENT</returns>
 public static clsvDiscussionSubContentEN CopyTo(this clsvDiscussionSubContentEN objvDiscussionSubContentENS)
{
try
{
 clsvDiscussionSubContentEN objvDiscussionSubContentENT = new clsvDiscussionSubContentEN()
{
SubContent = objvDiscussionSubContentENS.SubContent, //子内容
TopicsId = objvDiscussionSubContentENS.TopicsId, //主题Id
TopicsTitle = objvDiscussionSubContentENS.TopicsTitle, //主题标题
IsTop = objvDiscussionSubContentENS.IsTop, //是否置顶
UpdDate = objvDiscussionSubContentENS.UpdDate, //修改日期
UpdUser = objvDiscussionSubContentENS.UpdUser, //修改人
Memo = objvDiscussionSubContentENS.Memo, //备注
CollegeName = objvDiscussionSubContentENS.CollegeName, //学院名称
IdXzCollege = objvDiscussionSubContentENS.IdXzCollege, //学院流水号
IdXzMajor = objvDiscussionSubContentENS.IdXzMajor, //专业流水号
MajorName = objvDiscussionSubContentENS.MajorName, //专业名称
UserName = objvDiscussionSubContentENS.UserName, //用户名
BrowseNumber = objvDiscussionSubContentENS.BrowseNumber, //浏览量
IdCurrEduCls = objvDiscussionSubContentENS.IdCurrEduCls, //教学班流水号
ParentId = objvDiscussionSubContentENS.ParentId, //父节点Id
TopicsContent = objvDiscussionSubContentENS.TopicsContent, //主题内容
UserId = objvDiscussionSubContentENS.UserId, //用户ID
vUpdDate = objvDiscussionSubContentENS.vUpdDate, //vUpdDate
vUpdUser = objvDiscussionSubContentENS.vUpdUser, //vUpdUser
SubContentId = objvDiscussionSubContentENS.SubContentId, //子内容Id
};
 return objvDiscussionSubContentENT;
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
public static void CheckProperty4Condition(this clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
 clsvDiscussionSubContentBL.vDiscussionSubContentDA.CheckProperty4Condition(objvDiscussionSubContentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDiscussionSubContentEN objvDiscussionSubContentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.TopicsId) == true)
{
string strComparisonOpTopicsId = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.TopicsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.TopicsId, objvDiscussionSubContentCond.TopicsId, strComparisonOpTopicsId);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.TopicsTitle) == true)
{
string strComparisonOpTopicsTitle = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.TopicsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.TopicsTitle, objvDiscussionSubContentCond.TopicsTitle, strComparisonOpTopicsTitle);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.IsTop) == true)
{
if (objvDiscussionSubContentCond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDiscussionSubContent.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDiscussionSubContent.IsTop);
}
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.UpdDate, objvDiscussionSubContentCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.UpdUser, objvDiscussionSubContentCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.Memo) == true)
{
string strComparisonOpMemo = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.Memo, objvDiscussionSubContentCond.Memo, strComparisonOpMemo);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.CollegeName) == true)
{
string strComparisonOpCollegeName = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.CollegeName, objvDiscussionSubContentCond.CollegeName, strComparisonOpCollegeName);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.IdXzCollege, objvDiscussionSubContentCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.IdXzMajor, objvDiscussionSubContentCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.MajorName) == true)
{
string strComparisonOpMajorName = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.MajorName, objvDiscussionSubContentCond.MajorName, strComparisonOpMajorName);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.UserName) == true)
{
string strComparisonOpUserName = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.UserName, objvDiscussionSubContentCond.UserName, strComparisonOpUserName);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convDiscussionSubContent.BrowseNumber, objvDiscussionSubContentCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.IdCurrEduCls, objvDiscussionSubContentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.ParentId) == true)
{
string strComparisonOpParentId = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.ParentId, objvDiscussionSubContentCond.ParentId, strComparisonOpParentId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.UserId) == true)
{
string strComparisonOpUserId = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.UserId, objvDiscussionSubContentCond.UserId, strComparisonOpUserId);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.vUpdDate) == true)
{
string strComparisonOpvUpdDate = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.vUpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.vUpdDate, objvDiscussionSubContentCond.vUpdDate, strComparisonOpvUpdDate);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.vUpdUser) == true)
{
string strComparisonOpvUpdUser = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.vUpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.vUpdUser, objvDiscussionSubContentCond.vUpdUser, strComparisonOpvUpdUser);
}
if (objvDiscussionSubContentCond.IsUpdated(convDiscussionSubContent.SubContentId) == true)
{
string strComparisonOpSubContentId = objvDiscussionSubContentCond.dicFldComparisonOp[convDiscussionSubContent.SubContentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionSubContent.SubContentId, objvDiscussionSubContentCond.SubContentId, strComparisonOpSubContentId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vDiscussionSubContent(v讨论子内容视图), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SubContentId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvDiscussionSubContentEN == null) return true;
if (objvDiscussionSubContentEN.SubContentId == null || objvDiscussionSubContentEN.SubContentId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SubContentId = '{0}'", objvDiscussionSubContentEN.SubContentId);
if (clsvDiscussionSubContentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SubContentId !=  '{0}'", objvDiscussionSubContentEN.SubContentId);
 sbCondition.AppendFormat(" and SubContentId = '{0}'", objvDiscussionSubContentEN.SubContentId);
if (clsvDiscussionSubContentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vDiscussionSubContent(v讨论子内容视图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SubContentId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvDiscussionSubContentEN == null) return "";
if (objvDiscussionSubContentEN.SubContentId == null || objvDiscussionSubContentEN.SubContentId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SubContentId = '{0}'", objvDiscussionSubContentEN.SubContentId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SubContentId !=  '{0}'", objvDiscussionSubContentEN.SubContentId);
 sbCondition.AppendFormat(" and SubContentId = '{0}'", objvDiscussionSubContentEN.SubContentId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDiscussionSubContent
{
public virtual bool UpdRelaTabDate(string strSubContentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v讨论子内容视图(vDiscussionSubContent)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDiscussionSubContentBL
{
public static RelatedActions_vDiscussionSubContent relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDiscussionSubContentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDiscussionSubContentDA vDiscussionSubContentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDiscussionSubContentDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDiscussionSubContentBL()
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
if (string.IsNullOrEmpty(clsvDiscussionSubContentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDiscussionSubContentEN._ConnectString);
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
public static DataTable GetDataTable_vDiscussionSubContent(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDiscussionSubContentDA.GetDataTable_vDiscussionSubContent(strWhereCond);
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
objDT = vDiscussionSubContentDA.GetDataTable(strWhereCond);
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
objDT = vDiscussionSubContentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDiscussionSubContentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDiscussionSubContentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDiscussionSubContentDA.GetDataTable_Top(objTopPara);
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
objDT = vDiscussionSubContentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDiscussionSubContentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDiscussionSubContentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSubContentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvDiscussionSubContentEN> GetObjLstBySubContentIdLst(List<string> arrSubContentIdLst)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSubContentIdLst, true);
 string strWhereCond = string.Format("SubContentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSubContentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDiscussionSubContentEN> GetObjLstBySubContentIdLstCache(List<string> arrSubContentIdLst)
{
string strKey = string.Format("{0}", clsvDiscussionSubContentEN._CurrTabName);
List<clsvDiscussionSubContentEN> arrvDiscussionSubContentObjLstCache = GetObjLstCache();
IEnumerable <clsvDiscussionSubContentEN> arrvDiscussionSubContentObjLst_Sel =
arrvDiscussionSubContentObjLstCache
.Where(x => arrSubContentIdLst.Contains(x.SubContentId));
return arrvDiscussionSubContentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDiscussionSubContentEN> GetObjLst(string strWhereCond)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
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
public static List<clsvDiscussionSubContentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDiscussionSubContentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDiscussionSubContentEN> GetSubObjLstCache(clsvDiscussionSubContentEN objvDiscussionSubContentCond)
{
List<clsvDiscussionSubContentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDiscussionSubContentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDiscussionSubContent.AttributeName)
{
if (objvDiscussionSubContentCond.IsUpdated(strFldName) == false) continue;
if (objvDiscussionSubContentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDiscussionSubContentCond[strFldName].ToString());
}
else
{
if (objvDiscussionSubContentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDiscussionSubContentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDiscussionSubContentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDiscussionSubContentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDiscussionSubContentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDiscussionSubContentCond[strFldName]));
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
public static List<clsvDiscussionSubContentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
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
public static List<clsvDiscussionSubContentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
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
List<clsvDiscussionSubContentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDiscussionSubContentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDiscussionSubContentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDiscussionSubContentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
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
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
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
public static List<clsvDiscussionSubContentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDiscussionSubContentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDiscussionSubContentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
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
public static List<clsvDiscussionSubContentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDiscussionSubContentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDiscussionSubContentEN> arrObjLst = new List<clsvDiscussionSubContentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionSubContentEN objvDiscussionSubContentEN = new clsvDiscussionSubContentEN();
try
{
objvDiscussionSubContentEN.SubContent = objRow[convDiscussionSubContent.SubContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.SubContent].ToString().Trim(); //子内容
objvDiscussionSubContentEN.TopicsId = objRow[convDiscussionSubContent.TopicsId] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsId].ToString().Trim(); //主题Id
objvDiscussionSubContentEN.TopicsTitle = objRow[convDiscussionSubContent.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionSubContentEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionSubContent.IsTop].ToString().Trim()); //是否置顶
objvDiscussionSubContentEN.UpdDate = objRow[convDiscussionSubContent.UpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdDate].ToString().Trim(); //修改日期
objvDiscussionSubContentEN.UpdUser = objRow[convDiscussionSubContent.UpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.UpdUser].ToString().Trim(); //修改人
objvDiscussionSubContentEN.Memo = objRow[convDiscussionSubContent.Memo] == DBNull.Value ? null : objRow[convDiscussionSubContent.Memo].ToString().Trim(); //备注
objvDiscussionSubContentEN.CollegeName = objRow[convDiscussionSubContent.CollegeName] == DBNull.Value ? null : objRow[convDiscussionSubContent.CollegeName].ToString().Trim(); //学院名称
objvDiscussionSubContentEN.IdXzCollege = objRow[convDiscussionSubContent.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionSubContentEN.IdXzMajor = objRow[convDiscussionSubContent.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionSubContentEN.MajorName = objRow[convDiscussionSubContent.MajorName] == DBNull.Value ? null : objRow[convDiscussionSubContent.MajorName].ToString().Trim(); //专业名称
objvDiscussionSubContentEN.UserName = objRow[convDiscussionSubContent.UserName] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserName].ToString().Trim(); //用户名
objvDiscussionSubContentEN.BrowseNumber = objRow[convDiscussionSubContent.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionSubContent.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionSubContentEN.IdCurrEduCls = objRow[convDiscussionSubContent.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionSubContent.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvDiscussionSubContentEN.ParentId = objRow[convDiscussionSubContent.ParentId] == DBNull.Value ? null : objRow[convDiscussionSubContent.ParentId].ToString().Trim(); //父节点Id
objvDiscussionSubContentEN.TopicsContent = objRow[convDiscussionSubContent.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionSubContent.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionSubContentEN.UserId = objRow[convDiscussionSubContent.UserId] == DBNull.Value ? null : objRow[convDiscussionSubContent.UserId].ToString().Trim(); //用户ID
objvDiscussionSubContentEN.vUpdDate = objRow[convDiscussionSubContent.vUpdDate] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdDate].ToString().Trim(); //vUpdDate
objvDiscussionSubContentEN.vUpdUser = objRow[convDiscussionSubContent.vUpdUser] == DBNull.Value ? null : objRow[convDiscussionSubContent.vUpdUser].ToString().Trim(); //vUpdUser
objvDiscussionSubContentEN.SubContentId = objRow[convDiscussionSubContent.SubContentId].ToString().Trim(); //子内容Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionSubContentEN.SubContentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionSubContentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDiscussionSubContent(ref clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
bool bolResult = vDiscussionSubContentDA.GetvDiscussionSubContent(ref objvDiscussionSubContentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSubContentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDiscussionSubContentEN GetObjBySubContentId(string strSubContentId)
{
if (strSubContentId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSubContentId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSubContentId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSubContentId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvDiscussionSubContentEN objvDiscussionSubContentEN = vDiscussionSubContentDA.GetObjBySubContentId(strSubContentId);
return objvDiscussionSubContentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDiscussionSubContentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDiscussionSubContentEN objvDiscussionSubContentEN = vDiscussionSubContentDA.GetFirstObj(strWhereCond);
 return objvDiscussionSubContentEN;
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
public static clsvDiscussionSubContentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDiscussionSubContentEN objvDiscussionSubContentEN = vDiscussionSubContentDA.GetObjByDataRow(objRow);
 return objvDiscussionSubContentEN;
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
public static clsvDiscussionSubContentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDiscussionSubContentEN objvDiscussionSubContentEN = vDiscussionSubContentDA.GetObjByDataRow(objRow);
 return objvDiscussionSubContentEN;
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
 /// <param name = "strSubContentId">所给的关键字</param>
 /// <param name = "lstvDiscussionSubContentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDiscussionSubContentEN GetObjBySubContentIdFromList(string strSubContentId, List<clsvDiscussionSubContentEN> lstvDiscussionSubContentObjLst)
{
foreach (clsvDiscussionSubContentEN objvDiscussionSubContentEN in lstvDiscussionSubContentObjLst)
{
if (objvDiscussionSubContentEN.SubContentId == strSubContentId)
{
return objvDiscussionSubContentEN;
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
 string strMaxSubContentId;
 try
 {
 strMaxSubContentId = clsvDiscussionSubContentDA.GetMaxStrId();
 return strMaxSubContentId;
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
 string strSubContentId;
 try
 {
 strSubContentId = new clsvDiscussionSubContentDA().GetFirstID(strWhereCond);
 return strSubContentId;
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
 arrList = vDiscussionSubContentDA.GetID(strWhereCond);
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
bool bolIsExist = vDiscussionSubContentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSubContentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSubContentId)
{
if (string.IsNullOrEmpty(strSubContentId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSubContentId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vDiscussionSubContentDA.IsExist(strSubContentId);
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
 bolIsExist = clsvDiscussionSubContentDA.IsExistTable();
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
 bolIsExist = vDiscussionSubContentDA.IsExistTable(strTabName);
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
 /// <param name = "objvDiscussionSubContentENS">源对象</param>
 /// <param name = "objvDiscussionSubContentENT">目标对象</param>
 public static void CopyTo(clsvDiscussionSubContentEN objvDiscussionSubContentENS, clsvDiscussionSubContentEN objvDiscussionSubContentENT)
{
try
{
objvDiscussionSubContentENT.SubContent = objvDiscussionSubContentENS.SubContent; //子内容
objvDiscussionSubContentENT.TopicsId = objvDiscussionSubContentENS.TopicsId; //主题Id
objvDiscussionSubContentENT.TopicsTitle = objvDiscussionSubContentENS.TopicsTitle; //主题标题
objvDiscussionSubContentENT.IsTop = objvDiscussionSubContentENS.IsTop; //是否置顶
objvDiscussionSubContentENT.UpdDate = objvDiscussionSubContentENS.UpdDate; //修改日期
objvDiscussionSubContentENT.UpdUser = objvDiscussionSubContentENS.UpdUser; //修改人
objvDiscussionSubContentENT.Memo = objvDiscussionSubContentENS.Memo; //备注
objvDiscussionSubContentENT.CollegeName = objvDiscussionSubContentENS.CollegeName; //学院名称
objvDiscussionSubContentENT.IdXzCollege = objvDiscussionSubContentENS.IdXzCollege; //学院流水号
objvDiscussionSubContentENT.IdXzMajor = objvDiscussionSubContentENS.IdXzMajor; //专业流水号
objvDiscussionSubContentENT.MajorName = objvDiscussionSubContentENS.MajorName; //专业名称
objvDiscussionSubContentENT.UserName = objvDiscussionSubContentENS.UserName; //用户名
objvDiscussionSubContentENT.BrowseNumber = objvDiscussionSubContentENS.BrowseNumber; //浏览量
objvDiscussionSubContentENT.IdCurrEduCls = objvDiscussionSubContentENS.IdCurrEduCls; //教学班流水号
objvDiscussionSubContentENT.ParentId = objvDiscussionSubContentENS.ParentId; //父节点Id
objvDiscussionSubContentENT.TopicsContent = objvDiscussionSubContentENS.TopicsContent; //主题内容
objvDiscussionSubContentENT.UserId = objvDiscussionSubContentENS.UserId; //用户ID
objvDiscussionSubContentENT.vUpdDate = objvDiscussionSubContentENS.vUpdDate; //vUpdDate
objvDiscussionSubContentENT.vUpdUser = objvDiscussionSubContentENS.vUpdUser; //vUpdUser
objvDiscussionSubContentENT.SubContentId = objvDiscussionSubContentENS.SubContentId; //子内容Id
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
 /// <param name = "objvDiscussionSubContentEN">源简化对象</param>
 public static void SetUpdFlag(clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
try
{
objvDiscussionSubContentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDiscussionSubContentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDiscussionSubContent.SubContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.SubContent = objvDiscussionSubContentEN.SubContent == "[null]" ? null :  objvDiscussionSubContentEN.SubContent; //子内容
}
if (arrFldSet.Contains(convDiscussionSubContent.TopicsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.TopicsId = objvDiscussionSubContentEN.TopicsId == "[null]" ? null :  objvDiscussionSubContentEN.TopicsId; //主题Id
}
if (arrFldSet.Contains(convDiscussionSubContent.TopicsTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.TopicsTitle = objvDiscussionSubContentEN.TopicsTitle == "[null]" ? null :  objvDiscussionSubContentEN.TopicsTitle; //主题标题
}
if (arrFldSet.Contains(convDiscussionSubContent.IsTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.IsTop = objvDiscussionSubContentEN.IsTop; //是否置顶
}
if (arrFldSet.Contains(convDiscussionSubContent.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.UpdDate = objvDiscussionSubContentEN.UpdDate == "[null]" ? null :  objvDiscussionSubContentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convDiscussionSubContent.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.UpdUser = objvDiscussionSubContentEN.UpdUser == "[null]" ? null :  objvDiscussionSubContentEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convDiscussionSubContent.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.Memo = objvDiscussionSubContentEN.Memo == "[null]" ? null :  objvDiscussionSubContentEN.Memo; //备注
}
if (arrFldSet.Contains(convDiscussionSubContent.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.CollegeName = objvDiscussionSubContentEN.CollegeName == "[null]" ? null :  objvDiscussionSubContentEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convDiscussionSubContent.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.IdXzCollege = objvDiscussionSubContentEN.IdXzCollege == "[null]" ? null :  objvDiscussionSubContentEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convDiscussionSubContent.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.IdXzMajor = objvDiscussionSubContentEN.IdXzMajor == "[null]" ? null :  objvDiscussionSubContentEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convDiscussionSubContent.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.MajorName = objvDiscussionSubContentEN.MajorName == "[null]" ? null :  objvDiscussionSubContentEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convDiscussionSubContent.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.UserName = objvDiscussionSubContentEN.UserName == "[null]" ? null :  objvDiscussionSubContentEN.UserName; //用户名
}
if (arrFldSet.Contains(convDiscussionSubContent.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.BrowseNumber = objvDiscussionSubContentEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convDiscussionSubContent.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.IdCurrEduCls = objvDiscussionSubContentEN.IdCurrEduCls == "[null]" ? null :  objvDiscussionSubContentEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convDiscussionSubContent.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.ParentId = objvDiscussionSubContentEN.ParentId == "[null]" ? null :  objvDiscussionSubContentEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(convDiscussionSubContent.TopicsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.TopicsContent = objvDiscussionSubContentEN.TopicsContent == "[null]" ? null :  objvDiscussionSubContentEN.TopicsContent; //主题内容
}
if (arrFldSet.Contains(convDiscussionSubContent.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.UserId = objvDiscussionSubContentEN.UserId == "[null]" ? null :  objvDiscussionSubContentEN.UserId; //用户ID
}
if (arrFldSet.Contains(convDiscussionSubContent.vUpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.vUpdDate = objvDiscussionSubContentEN.vUpdDate == "[null]" ? null :  objvDiscussionSubContentEN.vUpdDate; //vUpdDate
}
if (arrFldSet.Contains(convDiscussionSubContent.vUpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.vUpdUser = objvDiscussionSubContentEN.vUpdUser == "[null]" ? null :  objvDiscussionSubContentEN.vUpdUser; //vUpdUser
}
if (arrFldSet.Contains(convDiscussionSubContent.SubContentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionSubContentEN.SubContentId = objvDiscussionSubContentEN.SubContentId; //子内容Id
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
 /// <param name = "objvDiscussionSubContentEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
try
{
if (objvDiscussionSubContentEN.SubContent == "[null]") objvDiscussionSubContentEN.SubContent = null; //子内容
if (objvDiscussionSubContentEN.TopicsId == "[null]") objvDiscussionSubContentEN.TopicsId = null; //主题Id
if (objvDiscussionSubContentEN.TopicsTitle == "[null]") objvDiscussionSubContentEN.TopicsTitle = null; //主题标题
if (objvDiscussionSubContentEN.UpdDate == "[null]") objvDiscussionSubContentEN.UpdDate = null; //修改日期
if (objvDiscussionSubContentEN.UpdUser == "[null]") objvDiscussionSubContentEN.UpdUser = null; //修改人
if (objvDiscussionSubContentEN.Memo == "[null]") objvDiscussionSubContentEN.Memo = null; //备注
if (objvDiscussionSubContentEN.CollegeName == "[null]") objvDiscussionSubContentEN.CollegeName = null; //学院名称
if (objvDiscussionSubContentEN.IdXzCollege == "[null]") objvDiscussionSubContentEN.IdXzCollege = null; //学院流水号
if (objvDiscussionSubContentEN.IdXzMajor == "[null]") objvDiscussionSubContentEN.IdXzMajor = null; //专业流水号
if (objvDiscussionSubContentEN.MajorName == "[null]") objvDiscussionSubContentEN.MajorName = null; //专业名称
if (objvDiscussionSubContentEN.UserName == "[null]") objvDiscussionSubContentEN.UserName = null; //用户名
if (objvDiscussionSubContentEN.IdCurrEduCls == "[null]") objvDiscussionSubContentEN.IdCurrEduCls = null; //教学班流水号
if (objvDiscussionSubContentEN.ParentId == "[null]") objvDiscussionSubContentEN.ParentId = null; //父节点Id
if (objvDiscussionSubContentEN.TopicsContent == "[null]") objvDiscussionSubContentEN.TopicsContent = null; //主题内容
if (objvDiscussionSubContentEN.UserId == "[null]") objvDiscussionSubContentEN.UserId = null; //用户ID
if (objvDiscussionSubContentEN.vUpdDate == "[null]") objvDiscussionSubContentEN.vUpdDate = null; //vUpdDate
if (objvDiscussionSubContentEN.vUpdUser == "[null]") objvDiscussionSubContentEN.vUpdUser = null; //vUpdUser
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
public static void CheckProperty4Condition(clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
 vDiscussionSubContentDA.CheckProperty4Condition(objvDiscussionSubContentEN);
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
if (clsDiscussionSubContentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscussionSubContentBL没有刷新缓存机制(clsDiscussionSubContentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscussionTopicsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscussionTopicsBL没有刷新缓存机制(clsDiscussionTopicsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SubContentId");
//if (arrvDiscussionSubContentObjLstCache == null)
//{
//arrvDiscussionSubContentObjLstCache = vDiscussionSubContentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSubContentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDiscussionSubContentEN GetObjBySubContentIdCache(string strSubContentId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvDiscussionSubContentEN._CurrTabName);
List<clsvDiscussionSubContentEN> arrvDiscussionSubContentObjLstCache = GetObjLstCache();
IEnumerable <clsvDiscussionSubContentEN> arrvDiscussionSubContentObjLst_Sel =
arrvDiscussionSubContentObjLstCache
.Where(x=> x.SubContentId == strSubContentId 
);
if (arrvDiscussionSubContentObjLst_Sel.Count() == 0)
{
   clsvDiscussionSubContentEN obj = clsvDiscussionSubContentBL.GetObjBySubContentId(strSubContentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvDiscussionSubContentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDiscussionSubContentEN> GetAllvDiscussionSubContentObjLstCache()
{
//获取缓存中的对象列表
List<clsvDiscussionSubContentEN> arrvDiscussionSubContentObjLstCache = GetObjLstCache(); 
return arrvDiscussionSubContentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDiscussionSubContentEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvDiscussionSubContentEN._CurrTabName);
List<clsvDiscussionSubContentEN> arrvDiscussionSubContentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvDiscussionSubContentObjLstCache;
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
string strKey = string.Format("{0}", clsvDiscussionSubContentEN._CurrTabName);
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

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vDiscussionSubContent(v讨论子内容视图)
 /// 唯一性条件:SubContentId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvDiscussionSubContentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvDiscussionSubContentEN objvDiscussionSubContentEN)
{
//检测记录是否存在
string strResult = vDiscussionSubContentDA.GetUniCondStr(objvDiscussionSubContentEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, string strSubContentId)
{
if (strInFldName != convDiscussionSubContent.SubContentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDiscussionSubContent.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDiscussionSubContent.AttributeName));
throw new Exception(strMsg);
}
var objvDiscussionSubContent = clsvDiscussionSubContentBL.GetObjBySubContentIdCache(strSubContentId);
if (objvDiscussionSubContent == null) return "";
return objvDiscussionSubContent[strOutFldName].ToString();
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
int intRecCount = clsvDiscussionSubContentDA.GetRecCount(strTabName);
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
int intRecCount = clsvDiscussionSubContentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDiscussionSubContentDA.GetRecCount();
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
int intRecCount = clsvDiscussionSubContentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDiscussionSubContentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDiscussionSubContentEN objvDiscussionSubContentCond)
{
List<clsvDiscussionSubContentEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDiscussionSubContentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDiscussionSubContent.AttributeName)
{
if (objvDiscussionSubContentCond.IsUpdated(strFldName) == false) continue;
if (objvDiscussionSubContentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDiscussionSubContentCond[strFldName].ToString());
}
else
{
if (objvDiscussionSubContentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDiscussionSubContentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDiscussionSubContentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDiscussionSubContentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDiscussionSubContentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDiscussionSubContentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDiscussionSubContentCond[strFldName]));
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
 List<string> arrList = clsvDiscussionSubContentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDiscussionSubContentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDiscussionSubContentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}