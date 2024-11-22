
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointBL
 表名:vViewpoint(01120543)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:31
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
public static class  clsvViewpointBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointEN GetObj(this K_ViewpointId_vViewpoint myKey)
{
clsvViewpointEN objvViewpointEN = clsvViewpointBL.vViewpointDA.GetObjByViewpointId(myKey.Value);
return objvViewpointEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetViewpointId(this clsvViewpointEN objvViewpointEN, string strViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convViewpoint.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convViewpoint.ViewpointId);
}
objvViewpointEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.ViewpointId) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.ViewpointId, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.ViewpointId] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetViewpointName(this clsvViewpointEN objvViewpointEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convViewpoint.ViewpointName);
}
objvViewpointEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.ViewpointName) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.ViewpointName, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.ViewpointName] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetViewpointContent(this clsvViewpointEN objvViewpointEN, string strViewpointContent, string strComparisonOp="")
	{
objvViewpointEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.ViewpointContent) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.ViewpointContent, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.ViewpointContent] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetViewpointTypeId(this clsvViewpointEN objvViewpointEN, string strViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeId, 4, convViewpoint.ViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointTypeId, 4, convViewpoint.ViewpointTypeId);
}
objvViewpointEN.ViewpointTypeId = strViewpointTypeId; //观点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.ViewpointTypeId) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.ViewpointTypeId, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.ViewpointTypeId] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetViewpointTypeName(this clsvViewpointEN objvViewpointEN, string strViewpointTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeName, 50, convViewpoint.ViewpointTypeName);
}
objvViewpointEN.ViewpointTypeName = strViewpointTypeName; //观点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.ViewpointTypeName) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.ViewpointTypeName, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.ViewpointTypeName] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetReason(this clsvViewpointEN objvViewpointEN, string strReason, string strComparisonOp="")
	{
objvViewpointEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.Reason) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.Reason, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.Reason] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetSource(this clsvViewpointEN objvViewpointEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 500, convViewpoint.Source);
}
objvViewpointEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.Source) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.Source, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.Source] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetVPProposePeople(this clsvViewpointEN objvViewpointEN, string strVPProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVPProposePeople, 50, convViewpoint.VPProposePeople);
}
objvViewpointEN.VPProposePeople = strVPProposePeople; //观点提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.VPProposePeople) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.VPProposePeople, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.VPProposePeople] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetUpdDate(this clsvViewpointEN objvViewpointEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewpoint.UpdDate);
}
objvViewpointEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.UpdDate) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.UpdDate, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.UpdDate] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetUpdUser(this clsvViewpointEN objvViewpointEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewpoint.UpdUser);
}
objvViewpointEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.UpdUser) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.UpdUser, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.UpdUser] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetMemo(this clsvViewpointEN objvViewpointEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewpoint.Memo);
}
objvViewpointEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.Memo) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.Memo, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.Memo] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetIsSubmit(this clsvViewpointEN objvViewpointEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvViewpointEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.IsSubmit) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.IsSubmit, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.IsSubmit] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetAppraiseCount(this clsvViewpointEN objvViewpointEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvViewpointEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.AppraiseCount) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.AppraiseCount, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.AppraiseCount] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetScore(this clsvViewpointEN objvViewpointEN, float? fltScore, string strComparisonOp="")
	{
objvViewpointEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.Score) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.Score, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.Score] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetOkCount(this clsvViewpointEN objvViewpointEN, int? intOkCount, string strComparisonOp="")
	{
objvViewpointEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.OkCount) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.OkCount, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.OkCount] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetUserTypeId(this clsvViewpointEN objvViewpointEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convViewpoint.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convViewpoint.UserTypeId);
}
objvViewpointEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.UserTypeId) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.UserTypeId, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.UserTypeId] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetUserTypeName(this clsvViewpointEN objvViewpointEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convViewpoint.UserTypeName);
}
objvViewpointEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.UserTypeName) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.UserTypeName, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.UserTypeName] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetAuthor(this clsvViewpointEN objvViewpointEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convViewpoint.Author);
}
objvViewpointEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.Author) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.Author, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.Author] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetCitationId(this clsvViewpointEN objvViewpointEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, convViewpoint.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, convViewpoint.CitationId);
}
objvViewpointEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.CitationId) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.CitationId, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.CitationId] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetKeyword(this clsvViewpointEN objvViewpointEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convViewpoint.Keyword);
}
objvViewpointEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.Keyword) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.Keyword, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.Keyword] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetPaperTitle(this clsvViewpointEN objvViewpointEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convViewpoint.PaperTitle);
}
objvViewpointEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.PaperTitle) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.PaperTitle, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.PaperTitle] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetPeriodical(this clsvViewpointEN objvViewpointEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convViewpoint.Periodical);
}
objvViewpointEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.Periodical) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.Periodical, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.Periodical] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetResearchQuestion(this clsvViewpointEN objvViewpointEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convViewpoint.ResearchQuestion);
}
objvViewpointEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.ResearchQuestion) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.ResearchQuestion, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.ResearchQuestion] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetUploadfileUrl(this clsvViewpointEN objvViewpointEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convViewpoint.UploadfileUrl);
}
objvViewpointEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.UploadfileUrl) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.UploadfileUrl, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.UploadfileUrl] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetCitationCount(this clsvViewpointEN objvViewpointEN, int? intCitationCount, string strComparisonOp="")
	{
objvViewpointEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.CitationCount) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.CitationCount, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.CitationCount] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetStuScore(this clsvViewpointEN objvViewpointEN, float? fltStuScore, string strComparisonOp="")
	{
objvViewpointEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.StuScore) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.StuScore, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.StuScore] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetTeaScore(this clsvViewpointEN objvViewpointEN, float? fltTeaScore, string strComparisonOp="")
	{
objvViewpointEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.TeaScore) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.TeaScore, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.TeaScore] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetIdCurrEduCls(this clsvViewpointEN objvViewpointEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convViewpoint.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convViewpoint.IdCurrEduCls);
}
objvViewpointEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.IdCurrEduCls) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.IdCurrEduCls, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.IdCurrEduCls] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetPdfContent(this clsvViewpointEN objvViewpointEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convViewpoint.PdfContent);
}
objvViewpointEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.PdfContent) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.PdfContent, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.PdfContent] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetPdfPageNum(this clsvViewpointEN objvViewpointEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvViewpointEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.PdfPageNum) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.PdfPageNum, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.PdfPageNum] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetVersionCount(this clsvViewpointEN objvViewpointEN, int? intVersionCount, string strComparisonOp="")
	{
objvViewpointEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.VersionCount) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.VersionCount, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.VersionCount] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetCreateDate(this clsvViewpointEN objvViewpointEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convViewpoint.CreateDate);
}
objvViewpointEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.CreateDate) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.CreateDate, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.CreateDate] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetShareId(this clsvViewpointEN objvViewpointEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convViewpoint.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convViewpoint.ShareId);
}
objvViewpointEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.ShareId) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.ShareId, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.ShareId] = strComparisonOp;
}
}
return objvViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewpointEN SetIsRecommend(this clsvViewpointEN objvViewpointEN, bool bolIsRecommend, string strComparisonOp="")
	{
objvViewpointEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointEN.dicFldComparisonOp.ContainsKey(convViewpoint.IsRecommend) == false)
{
objvViewpointEN.dicFldComparisonOp.Add(convViewpoint.IsRecommend, strComparisonOp);
}
else
{
objvViewpointEN.dicFldComparisonOp[convViewpoint.IsRecommend] = strComparisonOp;
}
}
return objvViewpointEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvViewpointENS">源对象</param>
 /// <param name = "objvViewpointENT">目标对象</param>
 public static void CopyTo(this clsvViewpointEN objvViewpointENS, clsvViewpointEN objvViewpointENT)
{
try
{
objvViewpointENT.ViewpointId = objvViewpointENS.ViewpointId; //观点Id
objvViewpointENT.ViewpointName = objvViewpointENS.ViewpointName; //观点名称
objvViewpointENT.ViewpointContent = objvViewpointENS.ViewpointContent; //观点内容
objvViewpointENT.ViewpointTypeId = objvViewpointENS.ViewpointTypeId; //观点类型Id
objvViewpointENT.ViewpointTypeName = objvViewpointENS.ViewpointTypeName; //观点类型名
objvViewpointENT.Reason = objvViewpointENS.Reason; //理由
objvViewpointENT.Source = objvViewpointENS.Source; //来源
objvViewpointENT.VPProposePeople = objvViewpointENS.VPProposePeople; //观点提出人
objvViewpointENT.UpdDate = objvViewpointENS.UpdDate; //修改日期
objvViewpointENT.UpdUser = objvViewpointENS.UpdUser; //修改人
objvViewpointENT.Memo = objvViewpointENS.Memo; //备注
objvViewpointENT.IsSubmit = objvViewpointENS.IsSubmit; //是否提交
objvViewpointENT.AppraiseCount = objvViewpointENS.AppraiseCount; //评论数
objvViewpointENT.Score = objvViewpointENS.Score; //评分
objvViewpointENT.OkCount = objvViewpointENS.OkCount; //点赞统计
objvViewpointENT.UserTypeId = objvViewpointENS.UserTypeId; //用户类型Id
objvViewpointENT.UserTypeName = objvViewpointENS.UserTypeName; //用户类型名称
objvViewpointENT.Author = objvViewpointENS.Author; //作者
objvViewpointENT.CitationId = objvViewpointENS.CitationId; //引用Id
objvViewpointENT.Keyword = objvViewpointENS.Keyword; //关键字
objvViewpointENT.PaperTitle = objvViewpointENS.PaperTitle; //论文标题
objvViewpointENT.Periodical = objvViewpointENS.Periodical; //期刊
objvViewpointENT.ResearchQuestion = objvViewpointENS.ResearchQuestion; //研究问题
objvViewpointENT.UploadfileUrl = objvViewpointENS.UploadfileUrl; //文件地址
objvViewpointENT.CitationCount = objvViewpointENS.CitationCount; //引用统计
objvViewpointENT.StuScore = objvViewpointENS.StuScore; //学生平均分
objvViewpointENT.TeaScore = objvViewpointENS.TeaScore; //教师评分
objvViewpointENT.IdCurrEduCls = objvViewpointENS.IdCurrEduCls; //教学班流水号
objvViewpointENT.PdfContent = objvViewpointENS.PdfContent; //Pdf内容
objvViewpointENT.PdfPageNum = objvViewpointENS.PdfPageNum; //Pdf页码
objvViewpointENT.VersionCount = objvViewpointENS.VersionCount; //版本统计
objvViewpointENT.CreateDate = objvViewpointENS.CreateDate; //建立日期
objvViewpointENT.ShareId = objvViewpointENS.ShareId; //分享Id
objvViewpointENT.IsRecommend = objvViewpointENS.IsRecommend; //是否推荐
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
 /// <param name = "objvViewpointENS">源对象</param>
 /// <returns>目标对象=>clsvViewpointEN:objvViewpointENT</returns>
 public static clsvViewpointEN CopyTo(this clsvViewpointEN objvViewpointENS)
{
try
{
 clsvViewpointEN objvViewpointENT = new clsvViewpointEN()
{
ViewpointId = objvViewpointENS.ViewpointId, //观点Id
ViewpointName = objvViewpointENS.ViewpointName, //观点名称
ViewpointContent = objvViewpointENS.ViewpointContent, //观点内容
ViewpointTypeId = objvViewpointENS.ViewpointTypeId, //观点类型Id
ViewpointTypeName = objvViewpointENS.ViewpointTypeName, //观点类型名
Reason = objvViewpointENS.Reason, //理由
Source = objvViewpointENS.Source, //来源
VPProposePeople = objvViewpointENS.VPProposePeople, //观点提出人
UpdDate = objvViewpointENS.UpdDate, //修改日期
UpdUser = objvViewpointENS.UpdUser, //修改人
Memo = objvViewpointENS.Memo, //备注
IsSubmit = objvViewpointENS.IsSubmit, //是否提交
AppraiseCount = objvViewpointENS.AppraiseCount, //评论数
Score = objvViewpointENS.Score, //评分
OkCount = objvViewpointENS.OkCount, //点赞统计
UserTypeId = objvViewpointENS.UserTypeId, //用户类型Id
UserTypeName = objvViewpointENS.UserTypeName, //用户类型名称
Author = objvViewpointENS.Author, //作者
CitationId = objvViewpointENS.CitationId, //引用Id
Keyword = objvViewpointENS.Keyword, //关键字
PaperTitle = objvViewpointENS.PaperTitle, //论文标题
Periodical = objvViewpointENS.Periodical, //期刊
ResearchQuestion = objvViewpointENS.ResearchQuestion, //研究问题
UploadfileUrl = objvViewpointENS.UploadfileUrl, //文件地址
CitationCount = objvViewpointENS.CitationCount, //引用统计
StuScore = objvViewpointENS.StuScore, //学生平均分
TeaScore = objvViewpointENS.TeaScore, //教师评分
IdCurrEduCls = objvViewpointENS.IdCurrEduCls, //教学班流水号
PdfContent = objvViewpointENS.PdfContent, //Pdf内容
PdfPageNum = objvViewpointENS.PdfPageNum, //Pdf页码
VersionCount = objvViewpointENS.VersionCount, //版本统计
CreateDate = objvViewpointENS.CreateDate, //建立日期
ShareId = objvViewpointENS.ShareId, //分享Id
IsRecommend = objvViewpointENS.IsRecommend, //是否推荐
};
 return objvViewpointENT;
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
public static void CheckProperty4Condition(this clsvViewpointEN objvViewpointEN)
{
 clsvViewpointBL.vViewpointDA.CheckProperty4Condition(objvViewpointEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewpointEN objvViewpointCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewpointCond.IsUpdated(convViewpoint.ViewpointId) == true)
{
string strComparisonOpViewpointId = objvViewpointCond.dicFldComparisonOp[convViewpoint.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.ViewpointId, objvViewpointCond.ViewpointId, strComparisonOpViewpointId);
}
if (objvViewpointCond.IsUpdated(convViewpoint.ViewpointName) == true)
{
string strComparisonOpViewpointName = objvViewpointCond.dicFldComparisonOp[convViewpoint.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.ViewpointName, objvViewpointCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvViewpointCond.IsUpdated(convViewpoint.ViewpointTypeId) == true)
{
string strComparisonOpViewpointTypeId = objvViewpointCond.dicFldComparisonOp[convViewpoint.ViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.ViewpointTypeId, objvViewpointCond.ViewpointTypeId, strComparisonOpViewpointTypeId);
}
if (objvViewpointCond.IsUpdated(convViewpoint.ViewpointTypeName) == true)
{
string strComparisonOpViewpointTypeName = objvViewpointCond.dicFldComparisonOp[convViewpoint.ViewpointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.ViewpointTypeName, objvViewpointCond.ViewpointTypeName, strComparisonOpViewpointTypeName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvViewpointCond.IsUpdated(convViewpoint.Source) == true)
{
string strComparisonOpSource = objvViewpointCond.dicFldComparisonOp[convViewpoint.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.Source, objvViewpointCond.Source, strComparisonOpSource);
}
if (objvViewpointCond.IsUpdated(convViewpoint.VPProposePeople) == true)
{
string strComparisonOpVPProposePeople = objvViewpointCond.dicFldComparisonOp[convViewpoint.VPProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.VPProposePeople, objvViewpointCond.VPProposePeople, strComparisonOpVPProposePeople);
}
if (objvViewpointCond.IsUpdated(convViewpoint.UpdDate) == true)
{
string strComparisonOpUpdDate = objvViewpointCond.dicFldComparisonOp[convViewpoint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.UpdDate, objvViewpointCond.UpdDate, strComparisonOpUpdDate);
}
if (objvViewpointCond.IsUpdated(convViewpoint.UpdUser) == true)
{
string strComparisonOpUpdUser = objvViewpointCond.dicFldComparisonOp[convViewpoint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.UpdUser, objvViewpointCond.UpdUser, strComparisonOpUpdUser);
}
if (objvViewpointCond.IsUpdated(convViewpoint.Memo) == true)
{
string strComparisonOpMemo = objvViewpointCond.dicFldComparisonOp[convViewpoint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.Memo, objvViewpointCond.Memo, strComparisonOpMemo);
}
if (objvViewpointCond.IsUpdated(convViewpoint.IsSubmit) == true)
{
if (objvViewpointCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewpoint.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewpoint.IsSubmit);
}
}
if (objvViewpointCond.IsUpdated(convViewpoint.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvViewpointCond.dicFldComparisonOp[convViewpoint.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpoint.AppraiseCount, objvViewpointCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvViewpointCond.IsUpdated(convViewpoint.Score) == true)
{
string strComparisonOpScore = objvViewpointCond.dicFldComparisonOp[convViewpoint.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpoint.Score, objvViewpointCond.Score, strComparisonOpScore);
}
if (objvViewpointCond.IsUpdated(convViewpoint.OkCount) == true)
{
string strComparisonOpOkCount = objvViewpointCond.dicFldComparisonOp[convViewpoint.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpoint.OkCount, objvViewpointCond.OkCount, strComparisonOpOkCount);
}
if (objvViewpointCond.IsUpdated(convViewpoint.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvViewpointCond.dicFldComparisonOp[convViewpoint.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.UserTypeId, objvViewpointCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvViewpointCond.IsUpdated(convViewpoint.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvViewpointCond.dicFldComparisonOp[convViewpoint.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.UserTypeName, objvViewpointCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvViewpointCond.IsUpdated(convViewpoint.Author) == true)
{
string strComparisonOpAuthor = objvViewpointCond.dicFldComparisonOp[convViewpoint.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.Author, objvViewpointCond.Author, strComparisonOpAuthor);
}
if (objvViewpointCond.IsUpdated(convViewpoint.CitationId) == true)
{
string strComparisonOpCitationId = objvViewpointCond.dicFldComparisonOp[convViewpoint.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.CitationId, objvViewpointCond.CitationId, strComparisonOpCitationId);
}
if (objvViewpointCond.IsUpdated(convViewpoint.Keyword) == true)
{
string strComparisonOpKeyword = objvViewpointCond.dicFldComparisonOp[convViewpoint.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.Keyword, objvViewpointCond.Keyword, strComparisonOpKeyword);
}
if (objvViewpointCond.IsUpdated(convViewpoint.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvViewpointCond.dicFldComparisonOp[convViewpoint.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.PaperTitle, objvViewpointCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvViewpointCond.IsUpdated(convViewpoint.Periodical) == true)
{
string strComparisonOpPeriodical = objvViewpointCond.dicFldComparisonOp[convViewpoint.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.Periodical, objvViewpointCond.Periodical, strComparisonOpPeriodical);
}
if (objvViewpointCond.IsUpdated(convViewpoint.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvViewpointCond.dicFldComparisonOp[convViewpoint.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.ResearchQuestion, objvViewpointCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvViewpointCond.IsUpdated(convViewpoint.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvViewpointCond.dicFldComparisonOp[convViewpoint.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.UploadfileUrl, objvViewpointCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvViewpointCond.IsUpdated(convViewpoint.CitationCount) == true)
{
string strComparisonOpCitationCount = objvViewpointCond.dicFldComparisonOp[convViewpoint.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpoint.CitationCount, objvViewpointCond.CitationCount, strComparisonOpCitationCount);
}
if (objvViewpointCond.IsUpdated(convViewpoint.StuScore) == true)
{
string strComparisonOpStuScore = objvViewpointCond.dicFldComparisonOp[convViewpoint.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpoint.StuScore, objvViewpointCond.StuScore, strComparisonOpStuScore);
}
if (objvViewpointCond.IsUpdated(convViewpoint.TeaScore) == true)
{
string strComparisonOpTeaScore = objvViewpointCond.dicFldComparisonOp[convViewpoint.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpoint.TeaScore, objvViewpointCond.TeaScore, strComparisonOpTeaScore);
}
if (objvViewpointCond.IsUpdated(convViewpoint.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvViewpointCond.dicFldComparisonOp[convViewpoint.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.IdCurrEduCls, objvViewpointCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvViewpointCond.IsUpdated(convViewpoint.PdfContent) == true)
{
string strComparisonOpPdfContent = objvViewpointCond.dicFldComparisonOp[convViewpoint.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.PdfContent, objvViewpointCond.PdfContent, strComparisonOpPdfContent);
}
if (objvViewpointCond.IsUpdated(convViewpoint.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvViewpointCond.dicFldComparisonOp[convViewpoint.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpoint.PdfPageNum, objvViewpointCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvViewpointCond.IsUpdated(convViewpoint.VersionCount) == true)
{
string strComparisonOpVersionCount = objvViewpointCond.dicFldComparisonOp[convViewpoint.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpoint.VersionCount, objvViewpointCond.VersionCount, strComparisonOpVersionCount);
}
if (objvViewpointCond.IsUpdated(convViewpoint.CreateDate) == true)
{
string strComparisonOpCreateDate = objvViewpointCond.dicFldComparisonOp[convViewpoint.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.CreateDate, objvViewpointCond.CreateDate, strComparisonOpCreateDate);
}
if (objvViewpointCond.IsUpdated(convViewpoint.ShareId) == true)
{
string strComparisonOpShareId = objvViewpointCond.dicFldComparisonOp[convViewpoint.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpoint.ShareId, objvViewpointCond.ShareId, strComparisonOpShareId);
}
if (objvViewpointCond.IsUpdated(convViewpoint.IsRecommend) == true)
{
if (objvViewpointCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", convViewpoint.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convViewpoint.IsRecommend);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vViewpoint
{
public virtual bool UpdRelaTabDate(string strViewpointId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v观点表视图(vViewpoint)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvViewpointBL
{
public static RelatedActions_vViewpoint relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvViewpointDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvViewpointDA vViewpointDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvViewpointDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvViewpointBL()
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
if (string.IsNullOrEmpty(clsvViewpointEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewpointEN._ConnectString);
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
public static DataTable GetDataTable_vViewpoint(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vViewpointDA.GetDataTable_vViewpoint(strWhereCond);
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
objDT = vViewpointDA.GetDataTable(strWhereCond);
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
objDT = vViewpointDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vViewpointDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vViewpointDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vViewpointDA.GetDataTable_Top(objTopPara);
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
objDT = vViewpointDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvViewpointEN> GetObjLstByViewpointIdLst(List<string> arrViewpointIdLst)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrViewpointIdLst, true);
 string strWhereCond = string.Format("ViewpointId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvViewpointEN> GetObjLstByViewpointIdLstCache(List<string> arrViewpointIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvViewpointEN._CurrTabName, strIdCurrEduCls);
List<clsvViewpointEN> arrvViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvViewpointEN> arrvViewpointObjLst_Sel =
arrvViewpointObjLstCache
.Where(x => arrViewpointIdLst.Contains(x.ViewpointId));
return arrvViewpointObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointEN> GetObjLst(string strWhereCond)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
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
public static List<clsvViewpointEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvViewpointEN> GetSubObjLstCache(clsvViewpointEN objvViewpointCond)
{
 string strIdCurrEduCls = objvViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvViewpointBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpoint.AttributeName)
{
if (objvViewpointCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointCond[strFldName].ToString());
}
else
{
if (objvViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointCond[strFldName]));
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
public static List<clsvViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
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
public static List<clsvViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
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
List<clsvViewpointEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvViewpointEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
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
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
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
public static List<clsvViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvViewpointEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
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
public static List<clsvViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvViewpointEN> arrObjLst = new List<clsvViewpointEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewpointEN objvViewpointEN = new clsvViewpointEN();
try
{
objvViewpointEN.ViewpointId = objRow[convViewpoint.ViewpointId].ToString().Trim(); //观点Id
objvViewpointEN.ViewpointName = objRow[convViewpoint.ViewpointName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointName].ToString().Trim(); //观点名称
objvViewpointEN.ViewpointContent = objRow[convViewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convViewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvViewpointEN.ViewpointTypeId = objRow[convViewpoint.ViewpointTypeId] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvViewpointEN.ViewpointTypeName = objRow[convViewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convViewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvViewpointEN.Reason = objRow[convViewpoint.Reason] == DBNull.Value ? null : objRow[convViewpoint.Reason].ToString().Trim(); //理由
objvViewpointEN.Source = objRow[convViewpoint.Source] == DBNull.Value ? null : objRow[convViewpoint.Source].ToString().Trim(); //来源
objvViewpointEN.VPProposePeople = objRow[convViewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convViewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvViewpointEN.UpdDate = objRow[convViewpoint.UpdDate] == DBNull.Value ? null : objRow[convViewpoint.UpdDate].ToString().Trim(); //修改日期
objvViewpointEN.UpdUser = objRow[convViewpoint.UpdUser] == DBNull.Value ? null : objRow[convViewpoint.UpdUser].ToString().Trim(); //修改人
objvViewpointEN.Memo = objRow[convViewpoint.Memo] == DBNull.Value ? null : objRow[convViewpoint.Memo].ToString().Trim(); //备注
objvViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvViewpointEN.AppraiseCount = objRow[convViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvViewpointEN.Score = objRow[convViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.Score].ToString().Trim()); //评分
objvViewpointEN.OkCount = objRow[convViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.OkCount].ToString().Trim()); //点赞统计
objvViewpointEN.UserTypeId = objRow[convViewpoint.UserTypeId] == DBNull.Value ? null : objRow[convViewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvViewpointEN.UserTypeName = objRow[convViewpoint.UserTypeName] == DBNull.Value ? null : objRow[convViewpoint.UserTypeName].ToString().Trim(); //用户类型名称
objvViewpointEN.Author = objRow[convViewpoint.Author] == DBNull.Value ? null : objRow[convViewpoint.Author].ToString().Trim(); //作者
objvViewpointEN.CitationId = objRow[convViewpoint.CitationId] == DBNull.Value ? null : objRow[convViewpoint.CitationId].ToString().Trim(); //引用Id
objvViewpointEN.Keyword = objRow[convViewpoint.Keyword] == DBNull.Value ? null : objRow[convViewpoint.Keyword].ToString().Trim(); //关键字
objvViewpointEN.PaperTitle = objRow[convViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvViewpointEN.Periodical = objRow[convViewpoint.Periodical] == DBNull.Value ? null : objRow[convViewpoint.Periodical].ToString().Trim(); //期刊
objvViewpointEN.ResearchQuestion = objRow[convViewpoint.ResearchQuestion] == DBNull.Value ? null : objRow[convViewpoint.ResearchQuestion].ToString().Trim(); //研究问题
objvViewpointEN.UploadfileUrl = objRow[convViewpoint.UploadfileUrl] == DBNull.Value ? null : objRow[convViewpoint.UploadfileUrl].ToString().Trim(); //文件地址
objvViewpointEN.CitationCount = objRow[convViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.CitationCount].ToString().Trim()); //引用统计
objvViewpointEN.StuScore = objRow[convViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.StuScore].ToString().Trim()); //学生平均分
objvViewpointEN.TeaScore = objRow[convViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convViewpoint.TeaScore].ToString().Trim()); //教师评分
objvViewpointEN.IdCurrEduCls = objRow[convViewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvViewpointEN.PdfContent = objRow[convViewpoint.PdfContent] == DBNull.Value ? null : objRow[convViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvViewpointEN.PdfPageNum = objRow[convViewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvViewpointEN.VersionCount = objRow[convViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewpoint.VersionCount].ToString().Trim()); //版本统计
objvViewpointEN.CreateDate = objRow[convViewpoint.CreateDate] == DBNull.Value ? null : objRow[convViewpoint.CreateDate].ToString().Trim(); //建立日期
objvViewpointEN.ShareId = objRow[convViewpoint.ShareId] == DBNull.Value ? null : objRow[convViewpoint.ShareId].ToString().Trim(); //分享Id
objvViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvViewpointEN.ViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvViewpointEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvViewpointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvViewpoint(ref clsvViewpointEN objvViewpointEN)
{
bool bolResult = vViewpointDA.GetvViewpoint(ref objvViewpointEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointEN GetObjByViewpointId(string strViewpointId)
{
if (strViewpointId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strViewpointId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewpointId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strViewpointId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvViewpointEN objvViewpointEN = vViewpointDA.GetObjByViewpointId(strViewpointId);
return objvViewpointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvViewpointEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvViewpointEN objvViewpointEN = vViewpointDA.GetFirstObj(strWhereCond);
 return objvViewpointEN;
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
public static clsvViewpointEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvViewpointEN objvViewpointEN = vViewpointDA.GetObjByDataRow(objRow);
 return objvViewpointEN;
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
public static clsvViewpointEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvViewpointEN objvViewpointEN = vViewpointDA.GetObjByDataRow(objRow);
 return objvViewpointEN;
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
 /// <param name = "strViewpointId">所给的关键字</param>
 /// <param name = "lstvViewpointObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointEN GetObjByViewpointIdFromList(string strViewpointId, List<clsvViewpointEN> lstvViewpointObjLst)
{
foreach (clsvViewpointEN objvViewpointEN in lstvViewpointObjLst)
{
if (objvViewpointEN.ViewpointId == strViewpointId)
{
return objvViewpointEN;
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
 string strMaxViewpointId;
 try
 {
 strMaxViewpointId = clsvViewpointDA.GetMaxStrId();
 return strMaxViewpointId;
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
 string strViewpointId;
 try
 {
 strViewpointId = new clsvViewpointDA().GetFirstID(strWhereCond);
 return strViewpointId;
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
 arrList = vViewpointDA.GetID(strWhereCond);
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
bool bolIsExist = vViewpointDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strViewpointId)
{
if (string.IsNullOrEmpty(strViewpointId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strViewpointId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vViewpointDA.IsExist(strViewpointId);
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
 bolIsExist = clsvViewpointDA.IsExistTable();
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
 bolIsExist = vViewpointDA.IsExistTable(strTabName);
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
 /// <param name = "objvViewpointENS">源对象</param>
 /// <param name = "objvViewpointENT">目标对象</param>
 public static void CopyTo(clsvViewpointEN objvViewpointENS, clsvViewpointEN objvViewpointENT)
{
try
{
objvViewpointENT.ViewpointId = objvViewpointENS.ViewpointId; //观点Id
objvViewpointENT.ViewpointName = objvViewpointENS.ViewpointName; //观点名称
objvViewpointENT.ViewpointContent = objvViewpointENS.ViewpointContent; //观点内容
objvViewpointENT.ViewpointTypeId = objvViewpointENS.ViewpointTypeId; //观点类型Id
objvViewpointENT.ViewpointTypeName = objvViewpointENS.ViewpointTypeName; //观点类型名
objvViewpointENT.Reason = objvViewpointENS.Reason; //理由
objvViewpointENT.Source = objvViewpointENS.Source; //来源
objvViewpointENT.VPProposePeople = objvViewpointENS.VPProposePeople; //观点提出人
objvViewpointENT.UpdDate = objvViewpointENS.UpdDate; //修改日期
objvViewpointENT.UpdUser = objvViewpointENS.UpdUser; //修改人
objvViewpointENT.Memo = objvViewpointENS.Memo; //备注
objvViewpointENT.IsSubmit = objvViewpointENS.IsSubmit; //是否提交
objvViewpointENT.AppraiseCount = objvViewpointENS.AppraiseCount; //评论数
objvViewpointENT.Score = objvViewpointENS.Score; //评分
objvViewpointENT.OkCount = objvViewpointENS.OkCount; //点赞统计
objvViewpointENT.UserTypeId = objvViewpointENS.UserTypeId; //用户类型Id
objvViewpointENT.UserTypeName = objvViewpointENS.UserTypeName; //用户类型名称
objvViewpointENT.Author = objvViewpointENS.Author; //作者
objvViewpointENT.CitationId = objvViewpointENS.CitationId; //引用Id
objvViewpointENT.Keyword = objvViewpointENS.Keyword; //关键字
objvViewpointENT.PaperTitle = objvViewpointENS.PaperTitle; //论文标题
objvViewpointENT.Periodical = objvViewpointENS.Periodical; //期刊
objvViewpointENT.ResearchQuestion = objvViewpointENS.ResearchQuestion; //研究问题
objvViewpointENT.UploadfileUrl = objvViewpointENS.UploadfileUrl; //文件地址
objvViewpointENT.CitationCount = objvViewpointENS.CitationCount; //引用统计
objvViewpointENT.StuScore = objvViewpointENS.StuScore; //学生平均分
objvViewpointENT.TeaScore = objvViewpointENS.TeaScore; //教师评分
objvViewpointENT.IdCurrEduCls = objvViewpointENS.IdCurrEduCls; //教学班流水号
objvViewpointENT.PdfContent = objvViewpointENS.PdfContent; //Pdf内容
objvViewpointENT.PdfPageNum = objvViewpointENS.PdfPageNum; //Pdf页码
objvViewpointENT.VersionCount = objvViewpointENS.VersionCount; //版本统计
objvViewpointENT.CreateDate = objvViewpointENS.CreateDate; //建立日期
objvViewpointENT.ShareId = objvViewpointENS.ShareId; //分享Id
objvViewpointENT.IsRecommend = objvViewpointENS.IsRecommend; //是否推荐
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
 /// <param name = "objvViewpointEN">源简化对象</param>
 public static void SetUpdFlag(clsvViewpointEN objvViewpointEN)
{
try
{
objvViewpointEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvViewpointEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convViewpoint.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.ViewpointId = objvViewpointEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(convViewpoint.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.ViewpointName = objvViewpointEN.ViewpointName == "[null]" ? null :  objvViewpointEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(convViewpoint.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.ViewpointContent = objvViewpointEN.ViewpointContent == "[null]" ? null :  objvViewpointEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(convViewpoint.ViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.ViewpointTypeId = objvViewpointEN.ViewpointTypeId == "[null]" ? null :  objvViewpointEN.ViewpointTypeId; //观点类型Id
}
if (arrFldSet.Contains(convViewpoint.ViewpointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.ViewpointTypeName = objvViewpointEN.ViewpointTypeName == "[null]" ? null :  objvViewpointEN.ViewpointTypeName; //观点类型名
}
if (arrFldSet.Contains(convViewpoint.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.Reason = objvViewpointEN.Reason == "[null]" ? null :  objvViewpointEN.Reason; //理由
}
if (arrFldSet.Contains(convViewpoint.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.Source = objvViewpointEN.Source == "[null]" ? null :  objvViewpointEN.Source; //来源
}
if (arrFldSet.Contains(convViewpoint.VPProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.VPProposePeople = objvViewpointEN.VPProposePeople == "[null]" ? null :  objvViewpointEN.VPProposePeople; //观点提出人
}
if (arrFldSet.Contains(convViewpoint.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.UpdDate = objvViewpointEN.UpdDate == "[null]" ? null :  objvViewpointEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convViewpoint.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.UpdUser = objvViewpointEN.UpdUser == "[null]" ? null :  objvViewpointEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convViewpoint.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.Memo = objvViewpointEN.Memo == "[null]" ? null :  objvViewpointEN.Memo; //备注
}
if (arrFldSet.Contains(convViewpoint.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.IsSubmit = objvViewpointEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convViewpoint.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.AppraiseCount = objvViewpointEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convViewpoint.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.Score = objvViewpointEN.Score; //评分
}
if (arrFldSet.Contains(convViewpoint.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.OkCount = objvViewpointEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convViewpoint.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.UserTypeId = objvViewpointEN.UserTypeId == "[null]" ? null :  objvViewpointEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convViewpoint.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.UserTypeName = objvViewpointEN.UserTypeName == "[null]" ? null :  objvViewpointEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convViewpoint.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.Author = objvViewpointEN.Author == "[null]" ? null :  objvViewpointEN.Author; //作者
}
if (arrFldSet.Contains(convViewpoint.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.CitationId = objvViewpointEN.CitationId == "[null]" ? null :  objvViewpointEN.CitationId; //引用Id
}
if (arrFldSet.Contains(convViewpoint.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.Keyword = objvViewpointEN.Keyword == "[null]" ? null :  objvViewpointEN.Keyword; //关键字
}
if (arrFldSet.Contains(convViewpoint.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.PaperTitle = objvViewpointEN.PaperTitle == "[null]" ? null :  objvViewpointEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convViewpoint.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.Periodical = objvViewpointEN.Periodical == "[null]" ? null :  objvViewpointEN.Periodical; //期刊
}
if (arrFldSet.Contains(convViewpoint.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.ResearchQuestion = objvViewpointEN.ResearchQuestion == "[null]" ? null :  objvViewpointEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convViewpoint.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.UploadfileUrl = objvViewpointEN.UploadfileUrl == "[null]" ? null :  objvViewpointEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convViewpoint.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.CitationCount = objvViewpointEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convViewpoint.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.StuScore = objvViewpointEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convViewpoint.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.TeaScore = objvViewpointEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convViewpoint.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.IdCurrEduCls = objvViewpointEN.IdCurrEduCls == "[null]" ? null :  objvViewpointEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convViewpoint.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.PdfContent = objvViewpointEN.PdfContent == "[null]" ? null :  objvViewpointEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convViewpoint.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.PdfPageNum = objvViewpointEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convViewpoint.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.VersionCount = objvViewpointEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convViewpoint.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.CreateDate = objvViewpointEN.CreateDate == "[null]" ? null :  objvViewpointEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convViewpoint.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.ShareId = objvViewpointEN.ShareId == "[null]" ? null :  objvViewpointEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convViewpoint.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objvViewpointEN.IsRecommend = objvViewpointEN.IsRecommend; //是否推荐
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
 /// <param name = "objvViewpointEN">源简化对象</param>
 public static void AccessFldValueNull(clsvViewpointEN objvViewpointEN)
{
try
{
if (objvViewpointEN.ViewpointName == "[null]") objvViewpointEN.ViewpointName = null; //观点名称
if (objvViewpointEN.ViewpointContent == "[null]") objvViewpointEN.ViewpointContent = null; //观点内容
if (objvViewpointEN.ViewpointTypeId == "[null]") objvViewpointEN.ViewpointTypeId = null; //观点类型Id
if (objvViewpointEN.ViewpointTypeName == "[null]") objvViewpointEN.ViewpointTypeName = null; //观点类型名
if (objvViewpointEN.Reason == "[null]") objvViewpointEN.Reason = null; //理由
if (objvViewpointEN.Source == "[null]") objvViewpointEN.Source = null; //来源
if (objvViewpointEN.VPProposePeople == "[null]") objvViewpointEN.VPProposePeople = null; //观点提出人
if (objvViewpointEN.UpdDate == "[null]") objvViewpointEN.UpdDate = null; //修改日期
if (objvViewpointEN.UpdUser == "[null]") objvViewpointEN.UpdUser = null; //修改人
if (objvViewpointEN.Memo == "[null]") objvViewpointEN.Memo = null; //备注
if (objvViewpointEN.UserTypeId == "[null]") objvViewpointEN.UserTypeId = null; //用户类型Id
if (objvViewpointEN.UserTypeName == "[null]") objvViewpointEN.UserTypeName = null; //用户类型名称
if (objvViewpointEN.Author == "[null]") objvViewpointEN.Author = null; //作者
if (objvViewpointEN.CitationId == "[null]") objvViewpointEN.CitationId = null; //引用Id
if (objvViewpointEN.Keyword == "[null]") objvViewpointEN.Keyword = null; //关键字
if (objvViewpointEN.PaperTitle == "[null]") objvViewpointEN.PaperTitle = null; //论文标题
if (objvViewpointEN.Periodical == "[null]") objvViewpointEN.Periodical = null; //期刊
if (objvViewpointEN.ResearchQuestion == "[null]") objvViewpointEN.ResearchQuestion = null; //研究问题
if (objvViewpointEN.UploadfileUrl == "[null]") objvViewpointEN.UploadfileUrl = null; //文件地址
if (objvViewpointEN.IdCurrEduCls == "[null]") objvViewpointEN.IdCurrEduCls = null; //教学班流水号
if (objvViewpointEN.PdfContent == "[null]") objvViewpointEN.PdfContent = null; //Pdf内容
if (objvViewpointEN.CreateDate == "[null]") objvViewpointEN.CreateDate = null; //建立日期
if (objvViewpointEN.ShareId == "[null]") objvViewpointEN.ShareId = null; //分享Id
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
public static void CheckProperty4Condition(clsvViewpointEN objvViewpointEN)
{
 vViewpointDA.CheckProperty4Condition(objvViewpointEN);
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointBL没有刷新缓存机制(clsViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointTypeBL没有刷新缓存机制(clsViewpointTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointId");
//if (arrvViewpointObjLstCache == null)
//{
//arrvViewpointObjLstCache = vViewpointDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewpointId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointEN GetObjByViewpointIdCache(string strViewpointId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvViewpointEN._CurrTabName, strIdCurrEduCls);
List<clsvViewpointEN> arrvViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvViewpointEN> arrvViewpointObjLst_Sel =
arrvViewpointObjLstCache
.Where(x=> x.ViewpointId == strViewpointId 
);
if (arrvViewpointObjLst_Sel.Count() == 0)
{
   clsvViewpointEN obj = clsvViewpointBL.GetObjByViewpointId(strViewpointId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strViewpointId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvViewpointObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointEN> GetAllvViewpointObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvViewpointEN> arrvViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvViewpointObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvViewpointEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvViewpointEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvViewpointEN> arrvViewpointObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvViewpointObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvViewpointEN._CurrTabName, strIdCurrEduCls);
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
 /// 日期:2023-10-08
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strViewpointId, string strIdCurrEduCls)
{
if (strInFldName != convViewpoint.ViewpointId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convViewpoint.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convViewpoint.AttributeName));
throw new Exception(strMsg);
}
var objvViewpoint = clsvViewpointBL.GetObjByViewpointIdCache(strViewpointId, strIdCurrEduCls);
if (objvViewpoint == null) return "";
return objvViewpoint[strOutFldName].ToString();
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
int intRecCount = clsvViewpointDA.GetRecCount(strTabName);
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
int intRecCount = clsvViewpointDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvViewpointDA.GetRecCount();
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
int intRecCount = clsvViewpointDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvViewpointEN objvViewpointCond)
{
 string strIdCurrEduCls = objvViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvViewpointBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convViewpoint.AttributeName)
{
if (objvViewpointCond.IsUpdated(strFldName) == false) continue;
if (objvViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointCond[strFldName].ToString());
}
else
{
if (objvViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvViewpointCond[strFldName]));
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
 List<string> arrList = clsvViewpointDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vViewpointDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vViewpointDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}