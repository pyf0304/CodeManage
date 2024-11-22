
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDiscussionTopicsBL
 表名:vDiscussionTopics(01120586)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:00:40
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
public static class  clsvDiscussionTopicsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDiscussionTopicsEN GetObj(this K_TopicsId_vDiscussionTopics myKey)
{
clsvDiscussionTopicsEN objvDiscussionTopicsEN = clsvDiscussionTopicsBL.vDiscussionTopicsDA.GetObjByTopicsId(myKey.Value);
return objvDiscussionTopicsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetTopicsId(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strTopicsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicsId, 8, convDiscussionTopics.TopicsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicsId, 8, convDiscussionTopics.TopicsId);
}
objvDiscussionTopicsEN.TopicsId = strTopicsId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.TopicsId) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.TopicsId, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.TopicsId] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetDiscussionTypeId(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strDiscussionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDiscussionTypeId, convDiscussionTopics.DiscussionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDiscussionTypeId, 8, convDiscussionTopics.DiscussionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDiscussionTypeId, 8, convDiscussionTopics.DiscussionTypeId);
}
objvDiscussionTopicsEN.DiscussionTypeId = strDiscussionTypeId; //讨论类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.DiscussionTypeId) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.DiscussionTypeId, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.DiscussionTypeId] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetDiscussionTypeName(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strDiscussionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDiscussionTypeName, 200, convDiscussionTopics.DiscussionTypeName);
}
objvDiscussionTopicsEN.DiscussionTypeName = strDiscussionTypeName; //讨论类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.DiscussionTypeName) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.DiscussionTypeName, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.DiscussionTypeName] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetTopicsTitle(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strTopicsTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicsTitle, 200, convDiscussionTopics.TopicsTitle);
}
objvDiscussionTopicsEN.TopicsTitle = strTopicsTitle; //主题标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.TopicsTitle) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.TopicsTitle, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.TopicsTitle] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetTopicsContent(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strTopicsContent, string strComparisonOp="")
	{
objvDiscussionTopicsEN.TopicsContent = strTopicsContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.TopicsContent) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.TopicsContent, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.TopicsContent] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetIsAudit(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, bool bolIsAudit, string strComparisonOp="")
	{
objvDiscussionTopicsEN.IsAudit = bolIsAudit; //是否审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.IsAudit) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.IsAudit, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.IsAudit] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetIsTop(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, bool bolIsTop, string strComparisonOp="")
	{
objvDiscussionTopicsEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.IsTop) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.IsTop, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.IsTop] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetBrowseNumber(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvDiscussionTopicsEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.BrowseNumber) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.BrowseNumber, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.BrowseNumber] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetUpdDate(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDiscussionTopics.UpdDate);
}
objvDiscussionTopicsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.UpdDate) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.UpdDate, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.UpdDate] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetUpdUser(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDiscussionTopics.UpdUser);
}
objvDiscussionTopicsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.UpdUser) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.UpdUser, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.UpdUser] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetMemo(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDiscussionTopics.Memo);
}
objvDiscussionTopicsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.Memo) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.Memo, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.Memo] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetCollegeName(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convDiscussionTopics.CollegeName);
}
objvDiscussionTopicsEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.CollegeName) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.CollegeName, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.CollegeName] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetIdXzCollege(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convDiscussionTopics.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convDiscussionTopics.IdXzCollege);
}
objvDiscussionTopicsEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.IdXzCollege) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.IdXzCollege, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.IdXzCollege] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetIdXzMajor(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convDiscussionTopics.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convDiscussionTopics.IdXzMajor);
}
objvDiscussionTopicsEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.IdXzMajor) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.IdXzMajor, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.IdXzMajor] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetMajorName(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convDiscussionTopics.MajorName);
}
objvDiscussionTopicsEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.MajorName) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.MajorName, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.MajorName] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetUserName(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convDiscussionTopics.UserName);
}
objvDiscussionTopicsEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.UserName) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.UserName, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.UserName] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetSubCount(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, int? intSubCount, string strComparisonOp="")
	{
objvDiscussionTopicsEN.SubCount = intSubCount; //SubCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.SubCount) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.SubCount, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.SubCount] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDiscussionTopicsEN SetIdCurrEduCls(this clsvDiscussionTopicsEN objvDiscussionTopicsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convDiscussionTopics.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convDiscussionTopics.IdCurrEduCls);
}
objvDiscussionTopicsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDiscussionTopicsEN.dicFldComparisonOp.ContainsKey(convDiscussionTopics.IdCurrEduCls) == false)
{
objvDiscussionTopicsEN.dicFldComparisonOp.Add(convDiscussionTopics.IdCurrEduCls, strComparisonOp);
}
else
{
objvDiscussionTopicsEN.dicFldComparisonOp[convDiscussionTopics.IdCurrEduCls] = strComparisonOp;
}
}
return objvDiscussionTopicsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDiscussionTopicsENS">源对象</param>
 /// <param name = "objvDiscussionTopicsENT">目标对象</param>
 public static void CopyTo(this clsvDiscussionTopicsEN objvDiscussionTopicsENS, clsvDiscussionTopicsEN objvDiscussionTopicsENT)
{
try
{
objvDiscussionTopicsENT.TopicsId = objvDiscussionTopicsENS.TopicsId; //主题Id
objvDiscussionTopicsENT.DiscussionTypeId = objvDiscussionTopicsENS.DiscussionTypeId; //讨论类型Id
objvDiscussionTopicsENT.DiscussionTypeName = objvDiscussionTopicsENS.DiscussionTypeName; //讨论类型名称
objvDiscussionTopicsENT.TopicsTitle = objvDiscussionTopicsENS.TopicsTitle; //主题标题
objvDiscussionTopicsENT.TopicsContent = objvDiscussionTopicsENS.TopicsContent; //主题内容
objvDiscussionTopicsENT.IsAudit = objvDiscussionTopicsENS.IsAudit; //是否审核
objvDiscussionTopicsENT.IsTop = objvDiscussionTopicsENS.IsTop; //是否置顶
objvDiscussionTopicsENT.BrowseNumber = objvDiscussionTopicsENS.BrowseNumber; //浏览量
objvDiscussionTopicsENT.UpdDate = objvDiscussionTopicsENS.UpdDate; //修改日期
objvDiscussionTopicsENT.UpdUser = objvDiscussionTopicsENS.UpdUser; //修改人
objvDiscussionTopicsENT.Memo = objvDiscussionTopicsENS.Memo; //备注
objvDiscussionTopicsENT.CollegeName = objvDiscussionTopicsENS.CollegeName; //学院名称
objvDiscussionTopicsENT.IdXzCollege = objvDiscussionTopicsENS.IdXzCollege; //学院流水号
objvDiscussionTopicsENT.IdXzMajor = objvDiscussionTopicsENS.IdXzMajor; //专业流水号
objvDiscussionTopicsENT.MajorName = objvDiscussionTopicsENS.MajorName; //专业名称
objvDiscussionTopicsENT.UserName = objvDiscussionTopicsENS.UserName; //用户名
objvDiscussionTopicsENT.SubCount = objvDiscussionTopicsENS.SubCount; //SubCount
objvDiscussionTopicsENT.IdCurrEduCls = objvDiscussionTopicsENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvDiscussionTopicsENS">源对象</param>
 /// <returns>目标对象=>clsvDiscussionTopicsEN:objvDiscussionTopicsENT</returns>
 public static clsvDiscussionTopicsEN CopyTo(this clsvDiscussionTopicsEN objvDiscussionTopicsENS)
{
try
{
 clsvDiscussionTopicsEN objvDiscussionTopicsENT = new clsvDiscussionTopicsEN()
{
TopicsId = objvDiscussionTopicsENS.TopicsId, //主题Id
DiscussionTypeId = objvDiscussionTopicsENS.DiscussionTypeId, //讨论类型Id
DiscussionTypeName = objvDiscussionTopicsENS.DiscussionTypeName, //讨论类型名称
TopicsTitle = objvDiscussionTopicsENS.TopicsTitle, //主题标题
TopicsContent = objvDiscussionTopicsENS.TopicsContent, //主题内容
IsAudit = objvDiscussionTopicsENS.IsAudit, //是否审核
IsTop = objvDiscussionTopicsENS.IsTop, //是否置顶
BrowseNumber = objvDiscussionTopicsENS.BrowseNumber, //浏览量
UpdDate = objvDiscussionTopicsENS.UpdDate, //修改日期
UpdUser = objvDiscussionTopicsENS.UpdUser, //修改人
Memo = objvDiscussionTopicsENS.Memo, //备注
CollegeName = objvDiscussionTopicsENS.CollegeName, //学院名称
IdXzCollege = objvDiscussionTopicsENS.IdXzCollege, //学院流水号
IdXzMajor = objvDiscussionTopicsENS.IdXzMajor, //专业流水号
MajorName = objvDiscussionTopicsENS.MajorName, //专业名称
UserName = objvDiscussionTopicsENS.UserName, //用户名
SubCount = objvDiscussionTopicsENS.SubCount, //SubCount
IdCurrEduCls = objvDiscussionTopicsENS.IdCurrEduCls, //教学班流水号
};
 return objvDiscussionTopicsENT;
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
public static void CheckProperty4Condition(this clsvDiscussionTopicsEN objvDiscussionTopicsEN)
{
 clsvDiscussionTopicsBL.vDiscussionTopicsDA.CheckProperty4Condition(objvDiscussionTopicsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDiscussionTopicsEN objvDiscussionTopicsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.TopicsId) == true)
{
string strComparisonOpTopicsId = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.TopicsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.TopicsId, objvDiscussionTopicsCond.TopicsId, strComparisonOpTopicsId);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.DiscussionTypeId) == true)
{
string strComparisonOpDiscussionTypeId = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.DiscussionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.DiscussionTypeId, objvDiscussionTopicsCond.DiscussionTypeId, strComparisonOpDiscussionTypeId);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.DiscussionTypeName) == true)
{
string strComparisonOpDiscussionTypeName = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.DiscussionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.DiscussionTypeName, objvDiscussionTopicsCond.DiscussionTypeName, strComparisonOpDiscussionTypeName);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.TopicsTitle) == true)
{
string strComparisonOpTopicsTitle = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.TopicsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.TopicsTitle, objvDiscussionTopicsCond.TopicsTitle, strComparisonOpTopicsTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.IsAudit) == true)
{
if (objvDiscussionTopicsCond.IsAudit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDiscussionTopics.IsAudit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDiscussionTopics.IsAudit);
}
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.IsTop) == true)
{
if (objvDiscussionTopicsCond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDiscussionTopics.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDiscussionTopics.IsTop);
}
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convDiscussionTopics.BrowseNumber, objvDiscussionTopicsCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.UpdDate, objvDiscussionTopicsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.UpdUser, objvDiscussionTopicsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.Memo) == true)
{
string strComparisonOpMemo = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.Memo, objvDiscussionTopicsCond.Memo, strComparisonOpMemo);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.CollegeName) == true)
{
string strComparisonOpCollegeName = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.CollegeName, objvDiscussionTopicsCond.CollegeName, strComparisonOpCollegeName);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.IdXzCollege, objvDiscussionTopicsCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.IdXzMajor, objvDiscussionTopicsCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.MajorName) == true)
{
string strComparisonOpMajorName = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.MajorName, objvDiscussionTopicsCond.MajorName, strComparisonOpMajorName);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.UserName) == true)
{
string strComparisonOpUserName = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.UserName, objvDiscussionTopicsCond.UserName, strComparisonOpUserName);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.SubCount) == true)
{
string strComparisonOpSubCount = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.SubCount];
strWhereCond += string.Format(" And {0} {2} {1}", convDiscussionTopics.SubCount, objvDiscussionTopicsCond.SubCount, strComparisonOpSubCount);
}
if (objvDiscussionTopicsCond.IsUpdated(convDiscussionTopics.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvDiscussionTopicsCond.dicFldComparisonOp[convDiscussionTopics.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDiscussionTopics.IdCurrEduCls, objvDiscussionTopicsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDiscussionTopics
{
public virtual bool UpdRelaTabDate(string strTopicsId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v讨论主题视图(vDiscussionTopics)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDiscussionTopicsBL
{
public static RelatedActions_vDiscussionTopics relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDiscussionTopicsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDiscussionTopicsDA vDiscussionTopicsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDiscussionTopicsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDiscussionTopicsBL()
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
if (string.IsNullOrEmpty(clsvDiscussionTopicsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDiscussionTopicsEN._ConnectString);
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
public static DataTable GetDataTable_vDiscussionTopics(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDiscussionTopicsDA.GetDataTable_vDiscussionTopics(strWhereCond);
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
objDT = vDiscussionTopicsDA.GetDataTable(strWhereCond);
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
objDT = vDiscussionTopicsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDiscussionTopicsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDiscussionTopicsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDiscussionTopicsDA.GetDataTable_Top(objTopPara);
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
objDT = vDiscussionTopicsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDiscussionTopicsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDiscussionTopicsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTopicsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvDiscussionTopicsEN> GetObjLstByTopicsIdLst(List<string> arrTopicsIdLst)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTopicsIdLst, true);
 string strWhereCond = string.Format("TopicsId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTopicsIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDiscussionTopicsEN> GetObjLstByTopicsIdLstCache(List<string> arrTopicsIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strIdCurrEduCls);
List<clsvDiscussionTopicsEN> arrvDiscussionTopicsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvDiscussionTopicsEN> arrvDiscussionTopicsObjLst_Sel =
arrvDiscussionTopicsObjLstCache
.Where(x => arrTopicsIdLst.Contains(x.TopicsId));
return arrvDiscussionTopicsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDiscussionTopicsEN> GetObjLst(string strWhereCond)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
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
public static List<clsvDiscussionTopicsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDiscussionTopicsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDiscussionTopicsEN> GetSubObjLstCache(clsvDiscussionTopicsEN objvDiscussionTopicsCond)
{
 string strIdCurrEduCls = objvDiscussionTopicsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvDiscussionTopicsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvDiscussionTopicsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvDiscussionTopicsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDiscussionTopics.AttributeName)
{
if (objvDiscussionTopicsCond.IsUpdated(strFldName) == false) continue;
if (objvDiscussionTopicsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDiscussionTopicsCond[strFldName].ToString());
}
else
{
if (objvDiscussionTopicsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDiscussionTopicsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDiscussionTopicsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDiscussionTopicsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDiscussionTopicsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDiscussionTopicsCond[strFldName]));
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
public static List<clsvDiscussionTopicsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
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
public static List<clsvDiscussionTopicsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
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
List<clsvDiscussionTopicsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDiscussionTopicsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDiscussionTopicsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDiscussionTopicsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
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
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
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
public static List<clsvDiscussionTopicsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDiscussionTopicsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDiscussionTopicsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
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
public static List<clsvDiscussionTopicsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDiscussionTopicsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDiscussionTopicsEN> arrObjLst = new List<clsvDiscussionTopicsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDiscussionTopicsEN objvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
try
{
objvDiscussionTopicsEN.TopicsId = objRow[convDiscussionTopics.TopicsId].ToString().Trim(); //主题Id
objvDiscussionTopicsEN.DiscussionTypeId = objRow[convDiscussionTopics.DiscussionTypeId].ToString().Trim(); //讨论类型Id
objvDiscussionTopicsEN.DiscussionTypeName = objRow[convDiscussionTopics.DiscussionTypeName] == DBNull.Value ? null : objRow[convDiscussionTopics.DiscussionTypeName].ToString().Trim(); //讨论类型名称
objvDiscussionTopicsEN.TopicsTitle = objRow[convDiscussionTopics.TopicsTitle] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsTitle].ToString().Trim(); //主题标题
objvDiscussionTopicsEN.TopicsContent = objRow[convDiscussionTopics.TopicsContent] == DBNull.Value ? null : objRow[convDiscussionTopics.TopicsContent].ToString().Trim(); //主题内容
objvDiscussionTopicsEN.IsAudit = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsAudit].ToString().Trim()); //是否审核
objvDiscussionTopicsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convDiscussionTopics.IsTop].ToString().Trim()); //是否置顶
objvDiscussionTopicsEN.BrowseNumber = objRow[convDiscussionTopics.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.BrowseNumber].ToString().Trim()); //浏览量
objvDiscussionTopicsEN.UpdDate = objRow[convDiscussionTopics.UpdDate] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdDate].ToString().Trim(); //修改日期
objvDiscussionTopicsEN.UpdUser = objRow[convDiscussionTopics.UpdUser] == DBNull.Value ? null : objRow[convDiscussionTopics.UpdUser].ToString().Trim(); //修改人
objvDiscussionTopicsEN.Memo = objRow[convDiscussionTopics.Memo] == DBNull.Value ? null : objRow[convDiscussionTopics.Memo].ToString().Trim(); //备注
objvDiscussionTopicsEN.CollegeName = objRow[convDiscussionTopics.CollegeName] == DBNull.Value ? null : objRow[convDiscussionTopics.CollegeName].ToString().Trim(); //学院名称
objvDiscussionTopicsEN.IdXzCollege = objRow[convDiscussionTopics.IdXzCollege] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzCollege].ToString().Trim(); //学院流水号
objvDiscussionTopicsEN.IdXzMajor = objRow[convDiscussionTopics.IdXzMajor] == DBNull.Value ? null : objRow[convDiscussionTopics.IdXzMajor].ToString().Trim(); //专业流水号
objvDiscussionTopicsEN.MajorName = objRow[convDiscussionTopics.MajorName] == DBNull.Value ? null : objRow[convDiscussionTopics.MajorName].ToString().Trim(); //专业名称
objvDiscussionTopicsEN.UserName = objRow[convDiscussionTopics.UserName] == DBNull.Value ? null : objRow[convDiscussionTopics.UserName].ToString().Trim(); //用户名
objvDiscussionTopicsEN.SubCount = objRow[convDiscussionTopics.SubCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDiscussionTopics.SubCount].ToString().Trim()); //SubCount
objvDiscussionTopicsEN.IdCurrEduCls = objRow[convDiscussionTopics.IdCurrEduCls] == DBNull.Value ? null : objRow[convDiscussionTopics.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDiscussionTopicsEN.TopicsId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDiscussionTopicsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDiscussionTopicsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDiscussionTopics(ref clsvDiscussionTopicsEN objvDiscussionTopicsEN)
{
bool bolResult = vDiscussionTopicsDA.GetvDiscussionTopics(ref objvDiscussionTopicsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicsId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDiscussionTopicsEN GetObjByTopicsId(string strTopicsId)
{
if (strTopicsId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTopicsId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTopicsId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTopicsId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvDiscussionTopicsEN objvDiscussionTopicsEN = vDiscussionTopicsDA.GetObjByTopicsId(strTopicsId);
return objvDiscussionTopicsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDiscussionTopicsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDiscussionTopicsEN objvDiscussionTopicsEN = vDiscussionTopicsDA.GetFirstObj(strWhereCond);
 return objvDiscussionTopicsEN;
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
public static clsvDiscussionTopicsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDiscussionTopicsEN objvDiscussionTopicsEN = vDiscussionTopicsDA.GetObjByDataRow(objRow);
 return objvDiscussionTopicsEN;
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
public static clsvDiscussionTopicsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDiscussionTopicsEN objvDiscussionTopicsEN = vDiscussionTopicsDA.GetObjByDataRow(objRow);
 return objvDiscussionTopicsEN;
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
 /// <param name = "strTopicsId">所给的关键字</param>
 /// <param name = "lstvDiscussionTopicsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDiscussionTopicsEN GetObjByTopicsIdFromList(string strTopicsId, List<clsvDiscussionTopicsEN> lstvDiscussionTopicsObjLst)
{
foreach (clsvDiscussionTopicsEN objvDiscussionTopicsEN in lstvDiscussionTopicsObjLst)
{
if (objvDiscussionTopicsEN.TopicsId == strTopicsId)
{
return objvDiscussionTopicsEN;
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
 string strTopicsId;
 try
 {
 strTopicsId = new clsvDiscussionTopicsDA().GetFirstID(strWhereCond);
 return strTopicsId;
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
 arrList = vDiscussionTopicsDA.GetID(strWhereCond);
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
bool bolIsExist = vDiscussionTopicsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTopicsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTopicsId)
{
if (string.IsNullOrEmpty(strTopicsId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTopicsId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vDiscussionTopicsDA.IsExist(strTopicsId);
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
 bolIsExist = clsvDiscussionTopicsDA.IsExistTable();
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
 bolIsExist = vDiscussionTopicsDA.IsExistTable(strTabName);
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
 /// <param name = "objvDiscussionTopicsENS">源对象</param>
 /// <param name = "objvDiscussionTopicsENT">目标对象</param>
 public static void CopyTo(clsvDiscussionTopicsEN objvDiscussionTopicsENS, clsvDiscussionTopicsEN objvDiscussionTopicsENT)
{
try
{
objvDiscussionTopicsENT.TopicsId = objvDiscussionTopicsENS.TopicsId; //主题Id
objvDiscussionTopicsENT.DiscussionTypeId = objvDiscussionTopicsENS.DiscussionTypeId; //讨论类型Id
objvDiscussionTopicsENT.DiscussionTypeName = objvDiscussionTopicsENS.DiscussionTypeName; //讨论类型名称
objvDiscussionTopicsENT.TopicsTitle = objvDiscussionTopicsENS.TopicsTitle; //主题标题
objvDiscussionTopicsENT.TopicsContent = objvDiscussionTopicsENS.TopicsContent; //主题内容
objvDiscussionTopicsENT.IsAudit = objvDiscussionTopicsENS.IsAudit; //是否审核
objvDiscussionTopicsENT.IsTop = objvDiscussionTopicsENS.IsTop; //是否置顶
objvDiscussionTopicsENT.BrowseNumber = objvDiscussionTopicsENS.BrowseNumber; //浏览量
objvDiscussionTopicsENT.UpdDate = objvDiscussionTopicsENS.UpdDate; //修改日期
objvDiscussionTopicsENT.UpdUser = objvDiscussionTopicsENS.UpdUser; //修改人
objvDiscussionTopicsENT.Memo = objvDiscussionTopicsENS.Memo; //备注
objvDiscussionTopicsENT.CollegeName = objvDiscussionTopicsENS.CollegeName; //学院名称
objvDiscussionTopicsENT.IdXzCollege = objvDiscussionTopicsENS.IdXzCollege; //学院流水号
objvDiscussionTopicsENT.IdXzMajor = objvDiscussionTopicsENS.IdXzMajor; //专业流水号
objvDiscussionTopicsENT.MajorName = objvDiscussionTopicsENS.MajorName; //专业名称
objvDiscussionTopicsENT.UserName = objvDiscussionTopicsENS.UserName; //用户名
objvDiscussionTopicsENT.SubCount = objvDiscussionTopicsENS.SubCount; //SubCount
objvDiscussionTopicsENT.IdCurrEduCls = objvDiscussionTopicsENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvDiscussionTopicsEN">源简化对象</param>
 public static void SetUpdFlag(clsvDiscussionTopicsEN objvDiscussionTopicsEN)
{
try
{
objvDiscussionTopicsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDiscussionTopicsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDiscussionTopics.TopicsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.TopicsId = objvDiscussionTopicsEN.TopicsId; //主题Id
}
if (arrFldSet.Contains(convDiscussionTopics.DiscussionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.DiscussionTypeId = objvDiscussionTopicsEN.DiscussionTypeId; //讨论类型Id
}
if (arrFldSet.Contains(convDiscussionTopics.DiscussionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.DiscussionTypeName = objvDiscussionTopicsEN.DiscussionTypeName == "[null]" ? null :  objvDiscussionTopicsEN.DiscussionTypeName; //讨论类型名称
}
if (arrFldSet.Contains(convDiscussionTopics.TopicsTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.TopicsTitle = objvDiscussionTopicsEN.TopicsTitle == "[null]" ? null :  objvDiscussionTopicsEN.TopicsTitle; //主题标题
}
if (arrFldSet.Contains(convDiscussionTopics.TopicsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.TopicsContent = objvDiscussionTopicsEN.TopicsContent == "[null]" ? null :  objvDiscussionTopicsEN.TopicsContent; //主题内容
}
if (arrFldSet.Contains(convDiscussionTopics.IsAudit, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.IsAudit = objvDiscussionTopicsEN.IsAudit; //是否审核
}
if (arrFldSet.Contains(convDiscussionTopics.IsTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.IsTop = objvDiscussionTopicsEN.IsTop; //是否置顶
}
if (arrFldSet.Contains(convDiscussionTopics.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.BrowseNumber = objvDiscussionTopicsEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convDiscussionTopics.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.UpdDate = objvDiscussionTopicsEN.UpdDate == "[null]" ? null :  objvDiscussionTopicsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convDiscussionTopics.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.UpdUser = objvDiscussionTopicsEN.UpdUser == "[null]" ? null :  objvDiscussionTopicsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convDiscussionTopics.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.Memo = objvDiscussionTopicsEN.Memo == "[null]" ? null :  objvDiscussionTopicsEN.Memo; //备注
}
if (arrFldSet.Contains(convDiscussionTopics.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.CollegeName = objvDiscussionTopicsEN.CollegeName == "[null]" ? null :  objvDiscussionTopicsEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convDiscussionTopics.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.IdXzCollege = objvDiscussionTopicsEN.IdXzCollege == "[null]" ? null :  objvDiscussionTopicsEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convDiscussionTopics.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.IdXzMajor = objvDiscussionTopicsEN.IdXzMajor == "[null]" ? null :  objvDiscussionTopicsEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convDiscussionTopics.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.MajorName = objvDiscussionTopicsEN.MajorName == "[null]" ? null :  objvDiscussionTopicsEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convDiscussionTopics.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.UserName = objvDiscussionTopicsEN.UserName == "[null]" ? null :  objvDiscussionTopicsEN.UserName; //用户名
}
if (arrFldSet.Contains(convDiscussionTopics.SubCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.SubCount = objvDiscussionTopicsEN.SubCount; //SubCount
}
if (arrFldSet.Contains(convDiscussionTopics.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvDiscussionTopicsEN.IdCurrEduCls = objvDiscussionTopicsEN.IdCurrEduCls == "[null]" ? null :  objvDiscussionTopicsEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvDiscussionTopicsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDiscussionTopicsEN objvDiscussionTopicsEN)
{
try
{
if (objvDiscussionTopicsEN.DiscussionTypeName == "[null]") objvDiscussionTopicsEN.DiscussionTypeName = null; //讨论类型名称
if (objvDiscussionTopicsEN.TopicsTitle == "[null]") objvDiscussionTopicsEN.TopicsTitle = null; //主题标题
if (objvDiscussionTopicsEN.TopicsContent == "[null]") objvDiscussionTopicsEN.TopicsContent = null; //主题内容
if (objvDiscussionTopicsEN.UpdDate == "[null]") objvDiscussionTopicsEN.UpdDate = null; //修改日期
if (objvDiscussionTopicsEN.UpdUser == "[null]") objvDiscussionTopicsEN.UpdUser = null; //修改人
if (objvDiscussionTopicsEN.Memo == "[null]") objvDiscussionTopicsEN.Memo = null; //备注
if (objvDiscussionTopicsEN.CollegeName == "[null]") objvDiscussionTopicsEN.CollegeName = null; //学院名称
if (objvDiscussionTopicsEN.IdXzCollege == "[null]") objvDiscussionTopicsEN.IdXzCollege = null; //学院流水号
if (objvDiscussionTopicsEN.IdXzMajor == "[null]") objvDiscussionTopicsEN.IdXzMajor = null; //专业流水号
if (objvDiscussionTopicsEN.MajorName == "[null]") objvDiscussionTopicsEN.MajorName = null; //专业名称
if (objvDiscussionTopicsEN.UserName == "[null]") objvDiscussionTopicsEN.UserName = null; //用户名
if (objvDiscussionTopicsEN.IdCurrEduCls == "[null]") objvDiscussionTopicsEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckProperty4Condition(clsvDiscussionTopicsEN objvDiscussionTopicsEN)
{
 vDiscussionTopicsDA.CheckProperty4Condition(objvDiscussionTopicsEN);
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
if (clsDiscussionTopicsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscussionTopicsBL没有刷新缓存机制(clsDiscussionTopicsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscussionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscussionTypeBL没有刷新缓存机制(clsDiscussionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by TopicsId");
//if (arrvDiscussionTopicsObjLstCache == null)
//{
//arrvDiscussionTopicsObjLstCache = vDiscussionTopicsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTopicsId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDiscussionTopicsEN GetObjByTopicsIdCache(string strTopicsId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strIdCurrEduCls);
List<clsvDiscussionTopicsEN> arrvDiscussionTopicsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvDiscussionTopicsEN> arrvDiscussionTopicsObjLst_Sel =
arrvDiscussionTopicsObjLstCache
.Where(x=> x.TopicsId == strTopicsId 
);
if (arrvDiscussionTopicsObjLst_Sel.Count() == 0)
{
   clsvDiscussionTopicsEN obj = clsvDiscussionTopicsBL.GetObjByTopicsId(strTopicsId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTopicsId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvDiscussionTopicsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDiscussionTopicsEN> GetAllvDiscussionTopicsObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvDiscussionTopicsEN> arrvDiscussionTopicsObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvDiscussionTopicsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDiscussionTopicsEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvDiscussionTopicsEN> arrvDiscussionTopicsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvDiscussionTopicsObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTopicsId, string strIdCurrEduCls)
{
if (strInFldName != convDiscussionTopics.TopicsId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDiscussionTopics.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDiscussionTopics.AttributeName));
throw new Exception(strMsg);
}
var objvDiscussionTopics = clsvDiscussionTopicsBL.GetObjByTopicsIdCache(strTopicsId, strIdCurrEduCls);
if (objvDiscussionTopics == null) return "";
return objvDiscussionTopics[strOutFldName].ToString();
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
int intRecCount = clsvDiscussionTopicsDA.GetRecCount(strTabName);
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
int intRecCount = clsvDiscussionTopicsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDiscussionTopicsDA.GetRecCount();
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
int intRecCount = clsvDiscussionTopicsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDiscussionTopicsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDiscussionTopicsEN objvDiscussionTopicsCond)
{
 string strIdCurrEduCls = objvDiscussionTopicsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvDiscussionTopicsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvDiscussionTopicsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvDiscussionTopicsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDiscussionTopics.AttributeName)
{
if (objvDiscussionTopicsCond.IsUpdated(strFldName) == false) continue;
if (objvDiscussionTopicsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDiscussionTopicsCond[strFldName].ToString());
}
else
{
if (objvDiscussionTopicsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDiscussionTopicsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDiscussionTopicsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDiscussionTopicsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDiscussionTopicsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDiscussionTopicsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDiscussionTopicsCond[strFldName]));
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
 List<string> arrList = clsvDiscussionTopicsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDiscussionTopicsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDiscussionTopicsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}