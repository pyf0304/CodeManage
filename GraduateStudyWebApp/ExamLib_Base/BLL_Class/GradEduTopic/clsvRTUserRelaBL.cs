
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTUserRelaBL
 表名:vRTUserRela(01120584)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:22:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsvRTUserRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTUserRelaEN GetObj(this K_mId_vRTUserRela myKey)
{
clsvRTUserRelaEN objvRTUserRelaEN = clsvRTUserRelaBL.vRTUserRelaDA.GetObjBymId(myKey.Value);
return objvRTUserRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetmId(this clsvRTUserRelaEN objvRTUserRelaEN, long lngmId, string strComparisonOp="")
	{
objvRTUserRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.mId) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.mId, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.mId] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetTopicId(this clsvRTUserRelaEN objvRTUserRelaEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convRTUserRela.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convRTUserRela.TopicId);
}
objvRTUserRelaEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.TopicId) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.TopicId, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.TopicId] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetUserId(this clsvRTUserRelaEN objvRTUserRelaEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convRTUserRela.UserId);
}
objvRTUserRelaEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.UserId) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.UserId, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.UserId] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetUpdUserName(this clsvRTUserRelaEN objvRTUserRelaEN, string strUpdUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convRTUserRela.UpdUserName);
}
objvRTUserRelaEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.UpdUserName) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.UpdUserName, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.UpdUserName] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetTopicName(this clsvRTUserRelaEN objvRTUserRelaEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convRTUserRela.TopicName);
}
objvRTUserRelaEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.TopicName) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.TopicName, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.TopicName] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetTopicContent(this clsvRTUserRelaEN objvRTUserRelaEN, string strTopicContent, string strComparisonOp="")
	{
objvRTUserRelaEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.TopicContent) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.TopicContent, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.TopicContent] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetTopicProposePeople(this clsvRTUserRelaEN objvRTUserRelaEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convRTUserRela.TopicProposePeople);
}
objvRTUserRelaEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.TopicProposePeople) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.TopicProposePeople, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.TopicProposePeople] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetUserName(this clsvRTUserRelaEN objvRTUserRelaEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convRTUserRela.UserName);
}
objvRTUserRelaEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.UserName) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.UserName, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.UserName] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetIdXzCollege(this clsvRTUserRelaEN objvRTUserRelaEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convRTUserRela.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convRTUserRela.IdXzCollege);
}
objvRTUserRelaEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.IdXzCollege) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.IdXzCollege, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.IdXzCollege] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetCollegeName(this clsvRTUserRelaEN objvRTUserRelaEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convRTUserRela.CollegeName);
}
objvRTUserRelaEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.CollegeName) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.CollegeName, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.CollegeName] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetIdXzMajor(this clsvRTUserRelaEN objvRTUserRelaEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convRTUserRela.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convRTUserRela.IdXzMajor);
}
objvRTUserRelaEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.IdXzMajor) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.IdXzMajor, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.IdXzMajor] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetMajorName(this clsvRTUserRelaEN objvRTUserRelaEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convRTUserRela.MajorName);
}
objvRTUserRelaEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.MajorName) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.MajorName, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.MajorName] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetTopicUserRoleId(this clsvRTUserRelaEN objvRTUserRelaEN, string strTopicUserRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicUserRoleId, convRTUserRela.TopicUserRoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicUserRoleId, 4, convRTUserRela.TopicUserRoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicUserRoleId, 4, convRTUserRela.TopicUserRoleId);
}
objvRTUserRelaEN.TopicUserRoleId = strTopicUserRoleId; //主键Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.TopicUserRoleId) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.TopicUserRoleId, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.TopicUserRoleId] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetTopicUserRoleName(this clsvRTUserRelaEN objvRTUserRelaEN, string strTopicUserRoleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicUserRoleName, 100, convRTUserRela.TopicUserRoleName);
}
objvRTUserRelaEN.TopicUserRoleName = strTopicUserRoleName; //主题用户角色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.TopicUserRoleName) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.TopicUserRoleName, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.TopicUserRoleName] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetOrderNum(this clsvRTUserRelaEN objvRTUserRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvRTUserRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.OrderNum) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.OrderNum, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.OrderNum] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetColorId(this clsvRTUserRelaEN objvRTUserRelaEN, string strColorId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strColorId, 2, convRTUserRela.ColorId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strColorId, 2, convRTUserRela.ColorId);
}
objvRTUserRelaEN.ColorId = strColorId; //颜色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.ColorId) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.ColorId, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.ColorId] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetColorCode(this clsvRTUserRelaEN objvRTUserRelaEN, string strColorCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strColorCode, 200, convRTUserRela.ColorCode);
}
objvRTUserRelaEN.ColorCode = strColorCode; //颜色码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.ColorCode) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.ColorCode, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.ColorCode] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetUserBgColor(this clsvRTUserRelaEN objvRTUserRelaEN, string strUserBgColor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserBgColor, 200, convRTUserRela.UserBgColor);
}
objvRTUserRelaEN.UserBgColor = strUserBgColor; //用户段落背景
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.UserBgColor) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.UserBgColor, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.UserBgColor] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetIdCurrEduCls(this clsvRTUserRelaEN objvRTUserRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convRTUserRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convRTUserRela.IdCurrEduCls);
}
objvRTUserRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.IdCurrEduCls) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.IdCurrEduCls, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.IdCurrEduCls] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetTeaScore(this clsvRTUserRelaEN objvRTUserRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvRTUserRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.TeaScore) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.TeaScore, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.TeaScore] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetStuScore(this clsvRTUserRelaEN objvRTUserRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvRTUserRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.StuScore) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.StuScore, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.StuScore] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetScore(this clsvRTUserRelaEN objvRTUserRelaEN, float? fltScore, string strComparisonOp="")
	{
objvRTUserRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.Score) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.Score, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.Score] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetAppraiseCount(this clsvRTUserRelaEN objvRTUserRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvRTUserRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.AppraiseCount) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.AppraiseCount, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.AppraiseCount] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetOkCount(this clsvRTUserRelaEN objvRTUserRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvRTUserRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.OkCount) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.OkCount, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.OkCount] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetIsSubmit(this clsvRTUserRelaEN objvRTUserRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvRTUserRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.IsSubmit) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.IsSubmit, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.IsSubmit] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetUpdDate(this clsvRTUserRelaEN objvRTUserRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convRTUserRela.UpdDate);
}
objvRTUserRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.UpdDate) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.UpdDate, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.UpdDate] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetUpdUser(this clsvRTUserRelaEN objvRTUserRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convRTUserRela.UpdUser);
}
objvRTUserRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.UpdUser) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.UpdUser, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.UpdUser] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvRTUserRelaEN SetMemo(this clsvRTUserRelaEN objvRTUserRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convRTUserRela.Memo);
}
objvRTUserRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvRTUserRelaEN.dicFldComparisonOp.ContainsKey(convRTUserRela.Memo) == false)
{
objvRTUserRelaEN.dicFldComparisonOp.Add(convRTUserRela.Memo, strComparisonOp);
}
else
{
objvRTUserRelaEN.dicFldComparisonOp[convRTUserRela.Memo] = strComparisonOp;
}
}
return objvRTUserRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvRTUserRelaENS">源对象</param>
 /// <param name = "objvRTUserRelaENT">目标对象</param>
 public static void CopyTo(this clsvRTUserRelaEN objvRTUserRelaENS, clsvRTUserRelaEN objvRTUserRelaENT)
{
try
{
objvRTUserRelaENT.mId = objvRTUserRelaENS.mId; //mId
objvRTUserRelaENT.TopicId = objvRTUserRelaENS.TopicId; //主题Id
objvRTUserRelaENT.UserId = objvRTUserRelaENS.UserId; //用户ID
objvRTUserRelaENT.UpdUserName = objvRTUserRelaENS.UpdUserName; //UpdUserName
objvRTUserRelaENT.TopicName = objvRTUserRelaENS.TopicName; //栏目主题
objvRTUserRelaENT.TopicContent = objvRTUserRelaENS.TopicContent; //主题内容
objvRTUserRelaENT.TopicProposePeople = objvRTUserRelaENS.TopicProposePeople; //主题提出人
objvRTUserRelaENT.UserName = objvRTUserRelaENS.UserName; //用户名
objvRTUserRelaENT.IdXzCollege = objvRTUserRelaENS.IdXzCollege; //学院流水号
objvRTUserRelaENT.CollegeName = objvRTUserRelaENS.CollegeName; //学院名称
objvRTUserRelaENT.IdXzMajor = objvRTUserRelaENS.IdXzMajor; //专业流水号
objvRTUserRelaENT.MajorName = objvRTUserRelaENS.MajorName; //专业名称
objvRTUserRelaENT.TopicUserRoleId = objvRTUserRelaENS.TopicUserRoleId; //主键Id
objvRTUserRelaENT.TopicUserRoleName = objvRTUserRelaENS.TopicUserRoleName; //主题用户角色
objvRTUserRelaENT.OrderNum = objvRTUserRelaENS.OrderNum; //序号
objvRTUserRelaENT.ColorId = objvRTUserRelaENS.ColorId; //颜色Id
objvRTUserRelaENT.ColorCode = objvRTUserRelaENS.ColorCode; //颜色码
objvRTUserRelaENT.UserBgColor = objvRTUserRelaENS.UserBgColor; //用户段落背景
objvRTUserRelaENT.IdCurrEduCls = objvRTUserRelaENS.IdCurrEduCls; //教学班流水号
objvRTUserRelaENT.TeaScore = objvRTUserRelaENS.TeaScore; //教师评分
objvRTUserRelaENT.StuScore = objvRTUserRelaENS.StuScore; //学生平均分
objvRTUserRelaENT.Score = objvRTUserRelaENS.Score; //评分
objvRTUserRelaENT.AppraiseCount = objvRTUserRelaENS.AppraiseCount; //评论数
objvRTUserRelaENT.OkCount = objvRTUserRelaENS.OkCount; //点赞统计
objvRTUserRelaENT.IsSubmit = objvRTUserRelaENS.IsSubmit; //是否提交
objvRTUserRelaENT.UpdDate = objvRTUserRelaENS.UpdDate; //修改日期
objvRTUserRelaENT.UpdUser = objvRTUserRelaENS.UpdUser; //修改人
objvRTUserRelaENT.Memo = objvRTUserRelaENS.Memo; //备注
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
 /// <param name = "objvRTUserRelaENS">源对象</param>
 /// <returns>目标对象=>clsvRTUserRelaEN:objvRTUserRelaENT</returns>
 public static clsvRTUserRelaEN CopyTo(this clsvRTUserRelaEN objvRTUserRelaENS)
{
try
{
 clsvRTUserRelaEN objvRTUserRelaENT = new clsvRTUserRelaEN()
{
mId = objvRTUserRelaENS.mId, //mId
TopicId = objvRTUserRelaENS.TopicId, //主题Id
UserId = objvRTUserRelaENS.UserId, //用户ID
UpdUserName = objvRTUserRelaENS.UpdUserName, //UpdUserName
TopicName = objvRTUserRelaENS.TopicName, //栏目主题
TopicContent = objvRTUserRelaENS.TopicContent, //主题内容
TopicProposePeople = objvRTUserRelaENS.TopicProposePeople, //主题提出人
UserName = objvRTUserRelaENS.UserName, //用户名
IdXzCollege = objvRTUserRelaENS.IdXzCollege, //学院流水号
CollegeName = objvRTUserRelaENS.CollegeName, //学院名称
IdXzMajor = objvRTUserRelaENS.IdXzMajor, //专业流水号
MajorName = objvRTUserRelaENS.MajorName, //专业名称
TopicUserRoleId = objvRTUserRelaENS.TopicUserRoleId, //主键Id
TopicUserRoleName = objvRTUserRelaENS.TopicUserRoleName, //主题用户角色
OrderNum = objvRTUserRelaENS.OrderNum, //序号
ColorId = objvRTUserRelaENS.ColorId, //颜色Id
ColorCode = objvRTUserRelaENS.ColorCode, //颜色码
UserBgColor = objvRTUserRelaENS.UserBgColor, //用户段落背景
IdCurrEduCls = objvRTUserRelaENS.IdCurrEduCls, //教学班流水号
TeaScore = objvRTUserRelaENS.TeaScore, //教师评分
StuScore = objvRTUserRelaENS.StuScore, //学生平均分
Score = objvRTUserRelaENS.Score, //评分
AppraiseCount = objvRTUserRelaENS.AppraiseCount, //评论数
OkCount = objvRTUserRelaENS.OkCount, //点赞统计
IsSubmit = objvRTUserRelaENS.IsSubmit, //是否提交
UpdDate = objvRTUserRelaENS.UpdDate, //修改日期
UpdUser = objvRTUserRelaENS.UpdUser, //修改人
Memo = objvRTUserRelaENS.Memo, //备注
};
 return objvRTUserRelaENT;
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
public static void CheckProperty4Condition(this clsvRTUserRelaEN objvRTUserRelaEN)
{
 clsvRTUserRelaBL.vRTUserRelaDA.CheckProperty4Condition(objvRTUserRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvRTUserRelaEN objvRTUserRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.mId) == true)
{
string strComparisonOpmId = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convRTUserRela.mId, objvRTUserRelaCond.mId, strComparisonOpmId);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.TopicId) == true)
{
string strComparisonOpTopicId = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.TopicId, objvRTUserRelaCond.TopicId, strComparisonOpTopicId);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.UserId) == true)
{
string strComparisonOpUserId = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.UserId, objvRTUserRelaCond.UserId, strComparisonOpUserId);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.UpdUserName) == true)
{
string strComparisonOpUpdUserName = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.UpdUserName, objvRTUserRelaCond.UpdUserName, strComparisonOpUpdUserName);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.TopicName) == true)
{
string strComparisonOpTopicName = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.TopicName, objvRTUserRelaCond.TopicName, strComparisonOpTopicName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.TopicProposePeople, objvRTUserRelaCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.UserName) == true)
{
string strComparisonOpUserName = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.UserName, objvRTUserRelaCond.UserName, strComparisonOpUserName);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.IdXzCollege, objvRTUserRelaCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.CollegeName) == true)
{
string strComparisonOpCollegeName = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.CollegeName, objvRTUserRelaCond.CollegeName, strComparisonOpCollegeName);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.IdXzMajor, objvRTUserRelaCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.MajorName) == true)
{
string strComparisonOpMajorName = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.MajorName, objvRTUserRelaCond.MajorName, strComparisonOpMajorName);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.TopicUserRoleId) == true)
{
string strComparisonOpTopicUserRoleId = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.TopicUserRoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.TopicUserRoleId, objvRTUserRelaCond.TopicUserRoleId, strComparisonOpTopicUserRoleId);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.TopicUserRoleName) == true)
{
string strComparisonOpTopicUserRoleName = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.TopicUserRoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.TopicUserRoleName, objvRTUserRelaCond.TopicUserRoleName, strComparisonOpTopicUserRoleName);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convRTUserRela.OrderNum, objvRTUserRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.ColorId) == true)
{
string strComparisonOpColorId = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.ColorId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.ColorId, objvRTUserRelaCond.ColorId, strComparisonOpColorId);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.ColorCode) == true)
{
string strComparisonOpColorCode = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.ColorCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.ColorCode, objvRTUserRelaCond.ColorCode, strComparisonOpColorCode);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.UserBgColor) == true)
{
string strComparisonOpUserBgColor = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.UserBgColor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.UserBgColor, objvRTUserRelaCond.UserBgColor, strComparisonOpUserBgColor);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.IdCurrEduCls, objvRTUserRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTUserRela.TeaScore, objvRTUserRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.StuScore) == true)
{
string strComparisonOpStuScore = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convRTUserRela.StuScore, objvRTUserRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.Score) == true)
{
string strComparisonOpScore = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convRTUserRela.Score, objvRTUserRelaCond.Score, strComparisonOpScore);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTUserRela.AppraiseCount, objvRTUserRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.OkCount) == true)
{
string strComparisonOpOkCount = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convRTUserRela.OkCount, objvRTUserRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.IsSubmit) == true)
{
if (objvRTUserRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convRTUserRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convRTUserRela.IsSubmit);
}
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.UpdDate, objvRTUserRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.UpdUser, objvRTUserRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvRTUserRelaCond.IsUpdated(convRTUserRela.Memo) == true)
{
string strComparisonOpMemo = objvRTUserRelaCond.dicFldComparisonOp[convRTUserRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convRTUserRela.Memo, objvRTUserRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vRTUserRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 主题用户关系视图(vRTUserRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvRTUserRelaBL
{
public static RelatedActions_vRTUserRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvRTUserRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvRTUserRelaDA vRTUserRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvRTUserRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvRTUserRelaBL()
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
if (string.IsNullOrEmpty(clsvRTUserRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTUserRelaEN._ConnectString);
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
public static DataTable GetDataTable_vRTUserRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vRTUserRelaDA.GetDataTable_vRTUserRela(strWhereCond);
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
objDT = vRTUserRelaDA.GetDataTable(strWhereCond);
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
objDT = vRTUserRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vRTUserRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vRTUserRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vRTUserRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vRTUserRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vRTUserRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vRTUserRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvRTUserRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvRTUserRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strUserId)
{
string strKey = string.Format("{0}_{1}", clsvRTUserRelaEN._CurrTabName, strUserId);
List<clsvRTUserRelaEN> arrvRTUserRelaObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvRTUserRelaEN> arrvRTUserRelaObjLst_Sel =
arrvRTUserRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvRTUserRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTUserRelaEN> GetObjLst(string strWhereCond)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
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
public static List<clsvRTUserRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvRTUserRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvRTUserRelaEN> GetSubObjLstCache(clsvRTUserRelaEN objvRTUserRelaCond)
{
 string strUserId = objvRTUserRelaCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvRTUserRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvRTUserRelaEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvRTUserRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTUserRela.AttributeName)
{
if (objvRTUserRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTUserRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTUserRelaCond[strFldName].ToString());
}
else
{
if (objvRTUserRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTUserRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTUserRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTUserRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTUserRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTUserRelaCond[strFldName]));
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
public static List<clsvRTUserRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
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
public static List<clsvRTUserRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
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
List<clsvRTUserRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvRTUserRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTUserRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvRTUserRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
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
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
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
public static List<clsvRTUserRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvRTUserRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvRTUserRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
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
public static List<clsvRTUserRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvRTUserRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvRTUserRelaEN> arrObjLst = new List<clsvRTUserRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTUserRelaEN objvRTUserRelaEN = new clsvRTUserRelaEN();
try
{
objvRTUserRelaEN.mId = Int32.Parse(objRow[convRTUserRela.mId].ToString().Trim()); //mId
objvRTUserRelaEN.TopicId = objRow[convRTUserRela.TopicId] == DBNull.Value ? null : objRow[convRTUserRela.TopicId].ToString().Trim(); //主题Id
objvRTUserRelaEN.UserId = objRow[convRTUserRela.UserId] == DBNull.Value ? null : objRow[convRTUserRela.UserId].ToString().Trim(); //用户ID
objvRTUserRelaEN.UpdUserName = objRow[convRTUserRela.UpdUserName] == DBNull.Value ? null : objRow[convRTUserRela.UpdUserName].ToString().Trim(); //UpdUserName
objvRTUserRelaEN.TopicName = objRow[convRTUserRela.TopicName] == DBNull.Value ? null : objRow[convRTUserRela.TopicName].ToString().Trim(); //栏目主题
objvRTUserRelaEN.TopicContent = objRow[convRTUserRela.TopicContent] == DBNull.Value ? null : objRow[convRTUserRela.TopicContent].ToString().Trim(); //主题内容
objvRTUserRelaEN.TopicProposePeople = objRow[convRTUserRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTUserRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTUserRelaEN.UserName = objRow[convRTUserRela.UserName] == DBNull.Value ? null : objRow[convRTUserRela.UserName].ToString().Trim(); //用户名
objvRTUserRelaEN.IdXzCollege = objRow[convRTUserRela.IdXzCollege] == DBNull.Value ? null : objRow[convRTUserRela.IdXzCollege].ToString().Trim(); //学院流水号
objvRTUserRelaEN.CollegeName = objRow[convRTUserRela.CollegeName] == DBNull.Value ? null : objRow[convRTUserRela.CollegeName].ToString().Trim(); //学院名称
objvRTUserRelaEN.IdXzMajor = objRow[convRTUserRela.IdXzMajor] == DBNull.Value ? null : objRow[convRTUserRela.IdXzMajor].ToString().Trim(); //专业流水号
objvRTUserRelaEN.MajorName = objRow[convRTUserRela.MajorName] == DBNull.Value ? null : objRow[convRTUserRela.MajorName].ToString().Trim(); //专业名称
objvRTUserRelaEN.TopicUserRoleId = objRow[convRTUserRela.TopicUserRoleId].ToString().Trim(); //主键Id
objvRTUserRelaEN.TopicUserRoleName = objRow[convRTUserRela.TopicUserRoleName] == DBNull.Value ? null : objRow[convRTUserRela.TopicUserRoleName].ToString().Trim(); //主题用户角色
objvRTUserRelaEN.OrderNum = objRow[convRTUserRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OrderNum].ToString().Trim()); //序号
objvRTUserRelaEN.ColorId = objRow[convRTUserRela.ColorId] == DBNull.Value ? null : objRow[convRTUserRela.ColorId].ToString().Trim(); //颜色Id
objvRTUserRelaEN.ColorCode = objRow[convRTUserRela.ColorCode] == DBNull.Value ? null : objRow[convRTUserRela.ColorCode].ToString().Trim(); //颜色码
objvRTUserRelaEN.UserBgColor = objRow[convRTUserRela.UserBgColor] == DBNull.Value ? null : objRow[convRTUserRela.UserBgColor].ToString().Trim(); //用户段落背景
objvRTUserRelaEN.IdCurrEduCls = objRow[convRTUserRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTUserRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTUserRelaEN.TeaScore = objRow[convRTUserRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.TeaScore].ToString().Trim()); //教师评分
objvRTUserRelaEN.StuScore = objRow[convRTUserRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.StuScore].ToString().Trim()); //学生平均分
objvRTUserRelaEN.Score = objRow[convRTUserRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTUserRela.Score].ToString().Trim()); //评分
objvRTUserRelaEN.AppraiseCount = objRow[convRTUserRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.AppraiseCount].ToString().Trim()); //评论数
objvRTUserRelaEN.OkCount = objRow[convRTUserRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTUserRela.OkCount].ToString().Trim()); //点赞统计
objvRTUserRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTUserRela.IsSubmit].ToString().Trim()); //是否提交
objvRTUserRelaEN.UpdDate = objRow[convRTUserRela.UpdDate] == DBNull.Value ? null : objRow[convRTUserRela.UpdDate].ToString().Trim(); //修改日期
objvRTUserRelaEN.UpdUser = objRow[convRTUserRela.UpdUser] == DBNull.Value ? null : objRow[convRTUserRela.UpdUser].ToString().Trim(); //修改人
objvRTUserRelaEN.Memo = objRow[convRTUserRela.Memo] == DBNull.Value ? null : objRow[convRTUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvRTUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvRTUserRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvRTUserRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvRTUserRela(ref clsvRTUserRelaEN objvRTUserRelaEN)
{
bool bolResult = vRTUserRelaDA.GetvRTUserRela(ref objvRTUserRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvRTUserRelaEN GetObjBymId(long lngmId)
{
clsvRTUserRelaEN objvRTUserRelaEN = vRTUserRelaDA.GetObjBymId(lngmId);
return objvRTUserRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvRTUserRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvRTUserRelaEN objvRTUserRelaEN = vRTUserRelaDA.GetFirstObj(strWhereCond);
 return objvRTUserRelaEN;
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
public static clsvRTUserRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvRTUserRelaEN objvRTUserRelaEN = vRTUserRelaDA.GetObjByDataRow(objRow);
 return objvRTUserRelaEN;
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
public static clsvRTUserRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvRTUserRelaEN objvRTUserRelaEN = vRTUserRelaDA.GetObjByDataRow(objRow);
 return objvRTUserRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvRTUserRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTUserRelaEN GetObjBymIdFromList(long lngmId, List<clsvRTUserRelaEN> lstvRTUserRelaObjLst)
{
foreach (clsvRTUserRelaEN objvRTUserRelaEN in lstvRTUserRelaObjLst)
{
if (objvRTUserRelaEN.mId == lngmId)
{
return objvRTUserRelaEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvRTUserRelaDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vRTUserRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vRTUserRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vRTUserRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvRTUserRelaDA.IsExistTable();
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
 bolIsExist = vRTUserRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvRTUserRelaENS">源对象</param>
 /// <param name = "objvRTUserRelaENT">目标对象</param>
 public static void CopyTo(clsvRTUserRelaEN objvRTUserRelaENS, clsvRTUserRelaEN objvRTUserRelaENT)
{
try
{
objvRTUserRelaENT.mId = objvRTUserRelaENS.mId; //mId
objvRTUserRelaENT.TopicId = objvRTUserRelaENS.TopicId; //主题Id
objvRTUserRelaENT.UserId = objvRTUserRelaENS.UserId; //用户ID
objvRTUserRelaENT.UpdUserName = objvRTUserRelaENS.UpdUserName; //UpdUserName
objvRTUserRelaENT.TopicName = objvRTUserRelaENS.TopicName; //栏目主题
objvRTUserRelaENT.TopicContent = objvRTUserRelaENS.TopicContent; //主题内容
objvRTUserRelaENT.TopicProposePeople = objvRTUserRelaENS.TopicProposePeople; //主题提出人
objvRTUserRelaENT.UserName = objvRTUserRelaENS.UserName; //用户名
objvRTUserRelaENT.IdXzCollege = objvRTUserRelaENS.IdXzCollege; //学院流水号
objvRTUserRelaENT.CollegeName = objvRTUserRelaENS.CollegeName; //学院名称
objvRTUserRelaENT.IdXzMajor = objvRTUserRelaENS.IdXzMajor; //专业流水号
objvRTUserRelaENT.MajorName = objvRTUserRelaENS.MajorName; //专业名称
objvRTUserRelaENT.TopicUserRoleId = objvRTUserRelaENS.TopicUserRoleId; //主键Id
objvRTUserRelaENT.TopicUserRoleName = objvRTUserRelaENS.TopicUserRoleName; //主题用户角色
objvRTUserRelaENT.OrderNum = objvRTUserRelaENS.OrderNum; //序号
objvRTUserRelaENT.ColorId = objvRTUserRelaENS.ColorId; //颜色Id
objvRTUserRelaENT.ColorCode = objvRTUserRelaENS.ColorCode; //颜色码
objvRTUserRelaENT.UserBgColor = objvRTUserRelaENS.UserBgColor; //用户段落背景
objvRTUserRelaENT.IdCurrEduCls = objvRTUserRelaENS.IdCurrEduCls; //教学班流水号
objvRTUserRelaENT.TeaScore = objvRTUserRelaENS.TeaScore; //教师评分
objvRTUserRelaENT.StuScore = objvRTUserRelaENS.StuScore; //学生平均分
objvRTUserRelaENT.Score = objvRTUserRelaENS.Score; //评分
objvRTUserRelaENT.AppraiseCount = objvRTUserRelaENS.AppraiseCount; //评论数
objvRTUserRelaENT.OkCount = objvRTUserRelaENS.OkCount; //点赞统计
objvRTUserRelaENT.IsSubmit = objvRTUserRelaENS.IsSubmit; //是否提交
objvRTUserRelaENT.UpdDate = objvRTUserRelaENS.UpdDate; //修改日期
objvRTUserRelaENT.UpdUser = objvRTUserRelaENS.UpdUser; //修改人
objvRTUserRelaENT.Memo = objvRTUserRelaENS.Memo; //备注
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
 /// <param name = "objvRTUserRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvRTUserRelaEN objvRTUserRelaEN)
{
try
{
objvRTUserRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvRTUserRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convRTUserRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.mId = objvRTUserRelaEN.mId; //mId
}
if (arrFldSet.Contains(convRTUserRela.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.TopicId = objvRTUserRelaEN.TopicId == "[null]" ? null :  objvRTUserRelaEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convRTUserRela.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.UserId = objvRTUserRelaEN.UserId == "[null]" ? null :  objvRTUserRelaEN.UserId; //用户ID
}
if (arrFldSet.Contains(convRTUserRela.UpdUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.UpdUserName = objvRTUserRelaEN.UpdUserName == "[null]" ? null :  objvRTUserRelaEN.UpdUserName; //UpdUserName
}
if (arrFldSet.Contains(convRTUserRela.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.TopicName = objvRTUserRelaEN.TopicName == "[null]" ? null :  objvRTUserRelaEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convRTUserRela.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.TopicContent = objvRTUserRelaEN.TopicContent == "[null]" ? null :  objvRTUserRelaEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convRTUserRela.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.TopicProposePeople = objvRTUserRelaEN.TopicProposePeople == "[null]" ? null :  objvRTUserRelaEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convRTUserRela.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.UserName = objvRTUserRelaEN.UserName == "[null]" ? null :  objvRTUserRelaEN.UserName; //用户名
}
if (arrFldSet.Contains(convRTUserRela.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.IdXzCollege = objvRTUserRelaEN.IdXzCollege == "[null]" ? null :  objvRTUserRelaEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convRTUserRela.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.CollegeName = objvRTUserRelaEN.CollegeName == "[null]" ? null :  objvRTUserRelaEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convRTUserRela.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.IdXzMajor = objvRTUserRelaEN.IdXzMajor == "[null]" ? null :  objvRTUserRelaEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convRTUserRela.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.MajorName = objvRTUserRelaEN.MajorName == "[null]" ? null :  objvRTUserRelaEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convRTUserRela.TopicUserRoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.TopicUserRoleId = objvRTUserRelaEN.TopicUserRoleId; //主键Id
}
if (arrFldSet.Contains(convRTUserRela.TopicUserRoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.TopicUserRoleName = objvRTUserRelaEN.TopicUserRoleName == "[null]" ? null :  objvRTUserRelaEN.TopicUserRoleName; //主题用户角色
}
if (arrFldSet.Contains(convRTUserRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.OrderNum = objvRTUserRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convRTUserRela.ColorId, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.ColorId = objvRTUserRelaEN.ColorId == "[null]" ? null :  objvRTUserRelaEN.ColorId; //颜色Id
}
if (arrFldSet.Contains(convRTUserRela.ColorCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.ColorCode = objvRTUserRelaEN.ColorCode == "[null]" ? null :  objvRTUserRelaEN.ColorCode; //颜色码
}
if (arrFldSet.Contains(convRTUserRela.UserBgColor, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.UserBgColor = objvRTUserRelaEN.UserBgColor == "[null]" ? null :  objvRTUserRelaEN.UserBgColor; //用户段落背景
}
if (arrFldSet.Contains(convRTUserRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.IdCurrEduCls = objvRTUserRelaEN.IdCurrEduCls == "[null]" ? null :  objvRTUserRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convRTUserRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.TeaScore = objvRTUserRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convRTUserRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.StuScore = objvRTUserRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convRTUserRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.Score = objvRTUserRelaEN.Score; //评分
}
if (arrFldSet.Contains(convRTUserRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.AppraiseCount = objvRTUserRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convRTUserRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.OkCount = objvRTUserRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convRTUserRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.IsSubmit = objvRTUserRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convRTUserRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.UpdDate = objvRTUserRelaEN.UpdDate == "[null]" ? null :  objvRTUserRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convRTUserRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.UpdUser = objvRTUserRelaEN.UpdUser == "[null]" ? null :  objvRTUserRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convRTUserRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvRTUserRelaEN.Memo = objvRTUserRelaEN.Memo == "[null]" ? null :  objvRTUserRelaEN.Memo; //备注
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
 /// <param name = "objvRTUserRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvRTUserRelaEN objvRTUserRelaEN)
{
try
{
if (objvRTUserRelaEN.TopicId == "[null]") objvRTUserRelaEN.TopicId = null; //主题Id
if (objvRTUserRelaEN.UserId == "[null]") objvRTUserRelaEN.UserId = null; //用户ID
if (objvRTUserRelaEN.UpdUserName == "[null]") objvRTUserRelaEN.UpdUserName = null; //UpdUserName
if (objvRTUserRelaEN.TopicName == "[null]") objvRTUserRelaEN.TopicName = null; //栏目主题
if (objvRTUserRelaEN.TopicContent == "[null]") objvRTUserRelaEN.TopicContent = null; //主题内容
if (objvRTUserRelaEN.TopicProposePeople == "[null]") objvRTUserRelaEN.TopicProposePeople = null; //主题提出人
if (objvRTUserRelaEN.UserName == "[null]") objvRTUserRelaEN.UserName = null; //用户名
if (objvRTUserRelaEN.IdXzCollege == "[null]") objvRTUserRelaEN.IdXzCollege = null; //学院流水号
if (objvRTUserRelaEN.CollegeName == "[null]") objvRTUserRelaEN.CollegeName = null; //学院名称
if (objvRTUserRelaEN.IdXzMajor == "[null]") objvRTUserRelaEN.IdXzMajor = null; //专业流水号
if (objvRTUserRelaEN.MajorName == "[null]") objvRTUserRelaEN.MajorName = null; //专业名称
if (objvRTUserRelaEN.TopicUserRoleName == "[null]") objvRTUserRelaEN.TopicUserRoleName = null; //主题用户角色
if (objvRTUserRelaEN.ColorId == "[null]") objvRTUserRelaEN.ColorId = null; //颜色Id
if (objvRTUserRelaEN.ColorCode == "[null]") objvRTUserRelaEN.ColorCode = null; //颜色码
if (objvRTUserRelaEN.UserBgColor == "[null]") objvRTUserRelaEN.UserBgColor = null; //用户段落背景
if (objvRTUserRelaEN.IdCurrEduCls == "[null]") objvRTUserRelaEN.IdCurrEduCls = null; //教学班流水号
if (objvRTUserRelaEN.UpdDate == "[null]") objvRTUserRelaEN.UpdDate = null; //修改日期
if (objvRTUserRelaEN.UpdUser == "[null]") objvRTUserRelaEN.UpdUser = null; //修改人
if (objvRTUserRelaEN.Memo == "[null]") objvRTUserRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvRTUserRelaEN objvRTUserRelaEN)
{
 vRTUserRelaDA.CheckProperty4Condition(objvRTUserRelaEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRTUserRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTUserRelaBL没有刷新缓存机制(clsRTUserRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTopicUserRoleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTopicUserRoleBL没有刷新缓存机制(clsTopicUserRoleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_ColorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ColorBL没有刷新缓存机制(clsgs_ColorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvRTUserRelaObjLstCache == null)
//{
//arrvRTUserRelaObjLstCache = vRTUserRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvRTUserRelaEN GetObjBymIdCache(long lngmId, string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strUserId.Length != 18)
{
var strMsg = string.Format("缓存分类变量:[strUserId]的长度:[{0}]不正确!(In {1})", strUserId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvRTUserRelaEN._CurrTabName, strUserId);
List<clsvRTUserRelaEN> arrvRTUserRelaObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvRTUserRelaEN> arrvRTUserRelaObjLst_Sel =
arrvRTUserRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvRTUserRelaObjLst_Sel.Count() == 0)
{
   clsvRTUserRelaEN obj = clsvRTUserRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.UserId == strUserId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strUserId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvRTUserRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTUserRelaEN> GetAllvRTUserRelaObjLstCache(string strUserId)
{
//获取缓存中的对象列表
List<clsvRTUserRelaEN> arrvRTUserRelaObjLstCache = GetObjLstCache(strUserId); 
return arrvRTUserRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvRTUserRelaEN> GetObjLstCache(string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strUserId.Length != 18)
{
var strMsg = string.Format("缓存分类变量:[strUserId]的长度:[{0}]不正确!(In {1})", strUserId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvRTUserRelaEN._CurrTabName, strUserId);
string strCondition = string.Format("UserId='{0}'", strUserId);
List<clsvRTUserRelaEN> arrvRTUserRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvRTUserRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUserId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvRTUserRelaEN._CurrTabName, strUserId);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strUserId)
{
if (strInFldName != convRTUserRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convRTUserRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convRTUserRela.AttributeName));
throw new Exception(strMsg);
}
var objvRTUserRela = clsvRTUserRelaBL.GetObjBymIdCache(lngmId, strUserId);
if (objvRTUserRela == null) return "";
return objvRTUserRela[strOutFldName].ToString();
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
int intRecCount = clsvRTUserRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvRTUserRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvRTUserRelaDA.GetRecCount();
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
int intRecCount = clsvRTUserRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvRTUserRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvRTUserRelaEN objvRTUserRelaCond)
{
 string strUserId = objvRTUserRelaCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvRTUserRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvRTUserRelaEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvRTUserRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convRTUserRela.AttributeName)
{
if (objvRTUserRelaCond.IsUpdated(strFldName) == false) continue;
if (objvRTUserRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTUserRelaCond[strFldName].ToString());
}
else
{
if (objvRTUserRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvRTUserRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvRTUserRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvRTUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvRTUserRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvRTUserRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvRTUserRelaCond[strFldName]));
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
 List<string> arrList = clsvRTUserRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vRTUserRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vRTUserRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}