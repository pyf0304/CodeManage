
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_ViewpointBL
 表名:vzx_Viewpoint(01120856)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clsvzx_ViewpointBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_ViewpointEN GetObj(this K_zxViewpointId_vzx_Viewpoint myKey)
{
clsvzx_ViewpointEN objvzx_ViewpointEN = clsvzx_ViewpointBL.vzx_ViewpointDA.GetObjByzxViewpointId(myKey.Value);
return objvzx_ViewpointEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetViewpointTypeName(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strViewpointTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeName, 50, convzx_Viewpoint.ViewpointTypeName);
}
objvzx_ViewpointEN.ViewpointTypeName = strViewpointTypeName; //观点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.ViewpointTypeName) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.ViewpointTypeName, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.ViewpointTypeName] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetzxViewpointId(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strzxViewpointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxViewpointId, 8, convzx_Viewpoint.zxViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxViewpointId, 8, convzx_Viewpoint.zxViewpointId);
}
objvzx_ViewpointEN.zxViewpointId = strzxViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.zxViewpointId) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.zxViewpointId, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.zxViewpointId] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetViewpointName(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convzx_Viewpoint.ViewpointName);
}
objvzx_ViewpointEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.ViewpointName) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.ViewpointName, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.ViewpointName] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetViewpointContent(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strViewpointContent, string strComparisonOp="")
	{
objvzx_ViewpointEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.ViewpointContent) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.ViewpointContent, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.ViewpointContent] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetzxViewpointTypeId(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strzxViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxViewpointTypeId, 4, convzx_Viewpoint.zxViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxViewpointTypeId, 4, convzx_Viewpoint.zxViewpointTypeId);
}
objvzx_ViewpointEN.zxViewpointTypeId = strzxViewpointTypeId; //观点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.zxViewpointTypeId) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.zxViewpointTypeId, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.zxViewpointTypeId] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetReason(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strReason, string strComparisonOp="")
	{
objvzx_ViewpointEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.Reason) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.Reason, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.Reason] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetSource(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 500, convzx_Viewpoint.Source);
}
objvzx_ViewpointEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.Source) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.Source, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.Source] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetVPProposePeople(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strVPProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVPProposePeople, 50, convzx_Viewpoint.VPProposePeople);
}
objvzx_ViewpointEN.VPProposePeople = strVPProposePeople; //观点提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.VPProposePeople) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.VPProposePeople, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.VPProposePeople] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetIsSubmit(this clsvzx_ViewpointEN objvzx_ViewpointEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_ViewpointEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.IsSubmit) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.IsSubmit, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.IsSubmit] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetUserTypeId(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convzx_Viewpoint.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convzx_Viewpoint.UserTypeId);
}
objvzx_ViewpointEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.UserTypeId) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.UserTypeId, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.UserTypeId] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetTextId(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_Viewpoint.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_Viewpoint.TextId);
}
objvzx_ViewpointEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.TextId) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.TextId, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.TextId] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetVoteCount(this clsvzx_ViewpointEN objvzx_ViewpointEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_ViewpointEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.VoteCount) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.VoteCount, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.VoteCount] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetAppraiseCount(this clsvzx_ViewpointEN objvzx_ViewpointEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_ViewpointEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.AppraiseCount) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.AppraiseCount, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.AppraiseCount] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetScore(this clsvzx_ViewpointEN objvzx_ViewpointEN, float? fltScore, string strComparisonOp="")
	{
objvzx_ViewpointEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.Score) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.Score, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.Score] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetStuScore(this clsvzx_ViewpointEN objvzx_ViewpointEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_ViewpointEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.StuScore) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.StuScore, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.StuScore] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetTeaScore(this clsvzx_ViewpointEN objvzx_ViewpointEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_ViewpointEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.TeaScore) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.TeaScore, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.TeaScore] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetIdCurrEduCls(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_Viewpoint.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_Viewpoint.IdCurrEduCls);
}
objvzx_ViewpointEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.IdCurrEduCls) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetPdfContent(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convzx_Viewpoint.PdfContent);
}
objvzx_ViewpointEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.PdfContent) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.PdfContent, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.PdfContent] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetPdfPageNum(this clsvzx_ViewpointEN objvzx_ViewpointEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvzx_ViewpointEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.PdfPageNum) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.PdfPageNum, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.PdfPageNum] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetCitationCount(this clsvzx_ViewpointEN objvzx_ViewpointEN, int? intCitationCount, string strComparisonOp="")
	{
objvzx_ViewpointEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.CitationCount) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.CitationCount, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.CitationCount] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetVersionCount(this clsvzx_ViewpointEN objvzx_ViewpointEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_ViewpointEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.VersionCount) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.VersionCount, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.VersionCount] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetzxShareId(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_Viewpoint.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_Viewpoint.zxShareId);
}
objvzx_ViewpointEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.zxShareId) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.zxShareId, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.zxShareId] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetCreateDate(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_Viewpoint.CreateDate);
}
objvzx_ViewpointEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.CreateDate) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.CreateDate, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.CreateDate] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetUpdDate(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_Viewpoint.UpdDate);
}
objvzx_ViewpointEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.UpdDate) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.UpdDate, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.UpdDate] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetUpdUser(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_Viewpoint.UpdUser);
}
objvzx_ViewpointEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.UpdUser) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.UpdUser, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.UpdUser] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetMemo(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_Viewpoint.Memo);
}
objvzx_ViewpointEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.Memo) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.Memo, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.Memo] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetTeammenberId(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strTeammenberId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeammenberId, 8, convzx_Viewpoint.TeammenberId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeammenberId, 8, convzx_Viewpoint.TeammenberId);
}
objvzx_ViewpointEN.TeammenberId = strTeammenberId; //主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.TeammenberId) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.TeammenberId, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.TeammenberId] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetPdfDivLet(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convzx_Viewpoint.PdfDivLet);
}
objvzx_ViewpointEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.PdfDivLet) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.PdfDivLet, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.PdfDivLet] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetPdfDivTop(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convzx_Viewpoint.PdfDivTop);
}
objvzx_ViewpointEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.PdfDivTop) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.PdfDivTop, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.PdfDivTop] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetPdfPageNumIn(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convzx_Viewpoint.PdfPageNumIn);
}
objvzx_ViewpointEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.PdfPageNumIn) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.PdfPageNumIn, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.PdfPageNumIn] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetPdfPageTop(this clsvzx_ViewpointEN objvzx_ViewpointEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvzx_ViewpointEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.PdfPageTop) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.PdfPageTop, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.PdfPageTop] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetPdfZoom(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convzx_Viewpoint.PdfZoom);
}
objvzx_ViewpointEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.PdfZoom) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.PdfZoom, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.PdfZoom] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetGroupTextId(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_Viewpoint.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_Viewpoint.GroupTextId);
}
objvzx_ViewpointEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.GroupTextId) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.GroupTextId, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.GroupTextId] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetTextContent(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strTextContent, string strComparisonOp="")
	{
objvzx_ViewpointEN.TextContent = strTextContent; //TextContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.TextContent) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.TextContent, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.TextContent] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetAuthor(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_Viewpoint.Author);
}
objvzx_ViewpointEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.Author) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.Author, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.Author] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ViewpointEN SetKeyword(this clsvzx_ViewpointEN objvzx_ViewpointEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convzx_Viewpoint.Keyword);
}
objvzx_ViewpointEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ViewpointEN.dicFldComparisonOp.ContainsKey(convzx_Viewpoint.Keyword) == false)
{
objvzx_ViewpointEN.dicFldComparisonOp.Add(convzx_Viewpoint.Keyword, strComparisonOp);
}
else
{
objvzx_ViewpointEN.dicFldComparisonOp[convzx_Viewpoint.Keyword] = strComparisonOp;
}
}
return objvzx_ViewpointEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_ViewpointENS">源对象</param>
 /// <param name = "objvzx_ViewpointENT">目标对象</param>
 public static void CopyTo(this clsvzx_ViewpointEN objvzx_ViewpointENS, clsvzx_ViewpointEN objvzx_ViewpointENT)
{
try
{
objvzx_ViewpointENT.ViewpointTypeName = objvzx_ViewpointENS.ViewpointTypeName; //观点类型名
objvzx_ViewpointENT.zxViewpointId = objvzx_ViewpointENS.zxViewpointId; //观点Id
objvzx_ViewpointENT.ViewpointName = objvzx_ViewpointENS.ViewpointName; //观点名称
objvzx_ViewpointENT.ViewpointContent = objvzx_ViewpointENS.ViewpointContent; //观点内容
objvzx_ViewpointENT.zxViewpointTypeId = objvzx_ViewpointENS.zxViewpointTypeId; //观点类型Id
objvzx_ViewpointENT.Reason = objvzx_ViewpointENS.Reason; //理由
objvzx_ViewpointENT.Source = objvzx_ViewpointENS.Source; //来源
objvzx_ViewpointENT.VPProposePeople = objvzx_ViewpointENS.VPProposePeople; //观点提出人
objvzx_ViewpointENT.IsSubmit = objvzx_ViewpointENS.IsSubmit; //是否提交
objvzx_ViewpointENT.UserTypeId = objvzx_ViewpointENS.UserTypeId; //用户类型Id
objvzx_ViewpointENT.TextId = objvzx_ViewpointENS.TextId; //课件Id
objvzx_ViewpointENT.VoteCount = objvzx_ViewpointENS.VoteCount; //点赞计数
objvzx_ViewpointENT.AppraiseCount = objvzx_ViewpointENS.AppraiseCount; //评论数
objvzx_ViewpointENT.Score = objvzx_ViewpointENS.Score; //评分
objvzx_ViewpointENT.StuScore = objvzx_ViewpointENS.StuScore; //学生平均分
objvzx_ViewpointENT.TeaScore = objvzx_ViewpointENS.TeaScore; //教师评分
objvzx_ViewpointENT.IdCurrEduCls = objvzx_ViewpointENS.IdCurrEduCls; //教学班流水号
objvzx_ViewpointENT.PdfContent = objvzx_ViewpointENS.PdfContent; //Pdf内容
objvzx_ViewpointENT.PdfPageNum = objvzx_ViewpointENS.PdfPageNum; //Pdf页码
objvzx_ViewpointENT.CitationCount = objvzx_ViewpointENS.CitationCount; //引用统计
objvzx_ViewpointENT.VersionCount = objvzx_ViewpointENS.VersionCount; //版本统计
objvzx_ViewpointENT.zxShareId = objvzx_ViewpointENS.zxShareId; //分享Id
objvzx_ViewpointENT.CreateDate = objvzx_ViewpointENS.CreateDate; //建立日期
objvzx_ViewpointENT.UpdDate = objvzx_ViewpointENS.UpdDate; //修改日期
objvzx_ViewpointENT.UpdUser = objvzx_ViewpointENS.UpdUser; //修改人
objvzx_ViewpointENT.Memo = objvzx_ViewpointENS.Memo; //备注
objvzx_ViewpointENT.TeammenberId = objvzx_ViewpointENS.TeammenberId; //主键
objvzx_ViewpointENT.PdfDivLet = objvzx_ViewpointENS.PdfDivLet; //PdfDivLet
objvzx_ViewpointENT.PdfDivTop = objvzx_ViewpointENS.PdfDivTop; //PdfDivTop
objvzx_ViewpointENT.PdfPageNumIn = objvzx_ViewpointENS.PdfPageNumIn; //PdfPageNumIn
objvzx_ViewpointENT.PdfPageTop = objvzx_ViewpointENS.PdfPageTop; //pdf页面顶部位置
objvzx_ViewpointENT.PdfZoom = objvzx_ViewpointENS.PdfZoom; //PdfZoom
objvzx_ViewpointENT.GroupTextId = objvzx_ViewpointENS.GroupTextId; //小组Id
objvzx_ViewpointENT.TextContent = objvzx_ViewpointENS.TextContent; //TextContent
objvzx_ViewpointENT.Author = objvzx_ViewpointENS.Author; //作者
objvzx_ViewpointENT.Keyword = objvzx_ViewpointENS.Keyword; //关键字
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
 /// <param name = "objvzx_ViewpointENS">源对象</param>
 /// <returns>目标对象=>clsvzx_ViewpointEN:objvzx_ViewpointENT</returns>
 public static clsvzx_ViewpointEN CopyTo(this clsvzx_ViewpointEN objvzx_ViewpointENS)
{
try
{
 clsvzx_ViewpointEN objvzx_ViewpointENT = new clsvzx_ViewpointEN()
{
ViewpointTypeName = objvzx_ViewpointENS.ViewpointTypeName, //观点类型名
zxViewpointId = objvzx_ViewpointENS.zxViewpointId, //观点Id
ViewpointName = objvzx_ViewpointENS.ViewpointName, //观点名称
ViewpointContent = objvzx_ViewpointENS.ViewpointContent, //观点内容
zxViewpointTypeId = objvzx_ViewpointENS.zxViewpointTypeId, //观点类型Id
Reason = objvzx_ViewpointENS.Reason, //理由
Source = objvzx_ViewpointENS.Source, //来源
VPProposePeople = objvzx_ViewpointENS.VPProposePeople, //观点提出人
IsSubmit = objvzx_ViewpointENS.IsSubmit, //是否提交
UserTypeId = objvzx_ViewpointENS.UserTypeId, //用户类型Id
TextId = objvzx_ViewpointENS.TextId, //课件Id
VoteCount = objvzx_ViewpointENS.VoteCount, //点赞计数
AppraiseCount = objvzx_ViewpointENS.AppraiseCount, //评论数
Score = objvzx_ViewpointENS.Score, //评分
StuScore = objvzx_ViewpointENS.StuScore, //学生平均分
TeaScore = objvzx_ViewpointENS.TeaScore, //教师评分
IdCurrEduCls = objvzx_ViewpointENS.IdCurrEduCls, //教学班流水号
PdfContent = objvzx_ViewpointENS.PdfContent, //Pdf内容
PdfPageNum = objvzx_ViewpointENS.PdfPageNum, //Pdf页码
CitationCount = objvzx_ViewpointENS.CitationCount, //引用统计
VersionCount = objvzx_ViewpointENS.VersionCount, //版本统计
zxShareId = objvzx_ViewpointENS.zxShareId, //分享Id
CreateDate = objvzx_ViewpointENS.CreateDate, //建立日期
UpdDate = objvzx_ViewpointENS.UpdDate, //修改日期
UpdUser = objvzx_ViewpointENS.UpdUser, //修改人
Memo = objvzx_ViewpointENS.Memo, //备注
TeammenberId = objvzx_ViewpointENS.TeammenberId, //主键
PdfDivLet = objvzx_ViewpointENS.PdfDivLet, //PdfDivLet
PdfDivTop = objvzx_ViewpointENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objvzx_ViewpointENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objvzx_ViewpointENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objvzx_ViewpointENS.PdfZoom, //PdfZoom
GroupTextId = objvzx_ViewpointENS.GroupTextId, //小组Id
TextContent = objvzx_ViewpointENS.TextContent, //TextContent
Author = objvzx_ViewpointENS.Author, //作者
Keyword = objvzx_ViewpointENS.Keyword, //关键字
};
 return objvzx_ViewpointENT;
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
public static void CheckProperty4Condition(this clsvzx_ViewpointEN objvzx_ViewpointEN)
{
 clsvzx_ViewpointBL.vzx_ViewpointDA.CheckProperty4Condition(objvzx_ViewpointEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_ViewpointEN objvzx_ViewpointCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.ViewpointTypeName) == true)
{
string strComparisonOpViewpointTypeName = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.ViewpointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.ViewpointTypeName, objvzx_ViewpointCond.ViewpointTypeName, strComparisonOpViewpointTypeName);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.zxViewpointId) == true)
{
string strComparisonOpzxViewpointId = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.zxViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.zxViewpointId, objvzx_ViewpointCond.zxViewpointId, strComparisonOpzxViewpointId);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.ViewpointName) == true)
{
string strComparisonOpViewpointName = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.ViewpointName, objvzx_ViewpointCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.zxViewpointTypeId) == true)
{
string strComparisonOpzxViewpointTypeId = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.zxViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.zxViewpointTypeId, objvzx_ViewpointCond.zxViewpointTypeId, strComparisonOpzxViewpointTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.Source) == true)
{
string strComparisonOpSource = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.Source, objvzx_ViewpointCond.Source, strComparisonOpSource);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.VPProposePeople) == true)
{
string strComparisonOpVPProposePeople = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.VPProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.VPProposePeople, objvzx_ViewpointCond.VPProposePeople, strComparisonOpVPProposePeople);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.IsSubmit) == true)
{
if (objvzx_ViewpointCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Viewpoint.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Viewpoint.IsSubmit);
}
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.UserTypeId, objvzx_ViewpointCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.TextId) == true)
{
string strComparisonOpTextId = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.TextId, objvzx_ViewpointCond.TextId, strComparisonOpTextId);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Viewpoint.VoteCount, objvzx_ViewpointCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Viewpoint.AppraiseCount, objvzx_ViewpointCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.Score) == true)
{
string strComparisonOpScore = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Viewpoint.Score, objvzx_ViewpointCond.Score, strComparisonOpScore);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Viewpoint.StuScore, objvzx_ViewpointCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Viewpoint.TeaScore, objvzx_ViewpointCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.IdCurrEduCls, objvzx_ViewpointCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.PdfContent) == true)
{
string strComparisonOpPdfContent = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.PdfContent, objvzx_ViewpointCond.PdfContent, strComparisonOpPdfContent);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Viewpoint.PdfPageNum, objvzx_ViewpointCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.CitationCount) == true)
{
string strComparisonOpCitationCount = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Viewpoint.CitationCount, objvzx_ViewpointCond.CitationCount, strComparisonOpCitationCount);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Viewpoint.VersionCount, objvzx_ViewpointCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.zxShareId, objvzx_ViewpointCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.CreateDate, objvzx_ViewpointCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.UpdDate, objvzx_ViewpointCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.UpdUser, objvzx_ViewpointCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.Memo) == true)
{
string strComparisonOpMemo = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.Memo, objvzx_ViewpointCond.Memo, strComparisonOpMemo);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.TeammenberId) == true)
{
string strComparisonOpTeammenberId = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.TeammenberId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.TeammenberId, objvzx_ViewpointCond.TeammenberId, strComparisonOpTeammenberId);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.PdfDivLet, objvzx_ViewpointCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.PdfDivTop, objvzx_ViewpointCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.PdfPageNumIn, objvzx_ViewpointCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Viewpoint.PdfPageTop, objvzx_ViewpointCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.PdfZoom, objvzx_ViewpointCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.GroupTextId, objvzx_ViewpointCond.GroupTextId, strComparisonOpGroupTextId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.Author) == true)
{
string strComparisonOpAuthor = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.Author, objvzx_ViewpointCond.Author, strComparisonOpAuthor);
}
if (objvzx_ViewpointCond.IsUpdated(convzx_Viewpoint.Keyword) == true)
{
string strComparisonOpKeyword = objvzx_ViewpointCond.dicFldComparisonOp[convzx_Viewpoint.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Viewpoint.Keyword, objvzx_ViewpointCond.Keyword, strComparisonOpKeyword);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_Viewpoint
{
public virtual bool UpdRelaTabDate(string strzxViewpointId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_Viewpoint(vzx_Viewpoint)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_ViewpointBL
{
public static RelatedActions_vzx_Viewpoint relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_ViewpointDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_ViewpointDA vzx_ViewpointDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_ViewpointDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_ViewpointBL()
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
if (string.IsNullOrEmpty(clsvzx_ViewpointEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_ViewpointEN._ConnectString);
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
public static DataTable GetDataTable_vzx_Viewpoint(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_ViewpointDA.GetDataTable_vzx_Viewpoint(strWhereCond);
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
objDT = vzx_ViewpointDA.GetDataTable(strWhereCond);
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
objDT = vzx_ViewpointDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_ViewpointDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_ViewpointDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_ViewpointDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_ViewpointDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_ViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_ViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_ViewpointEN> GetObjLstByZxViewpointIdLst(List<string> arrZxViewpointIdLst)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxViewpointIdLst, true);
 string strWhereCond = string.Format("zxViewpointId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_ViewpointEN> GetObjLstByZxViewpointIdLstCache(List<string> arrZxViewpointIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_ViewpointEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_ViewpointEN> arrvzx_ViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_ViewpointEN> arrvzx_ViewpointObjLst_Sel =
arrvzx_ViewpointObjLstCache
.Where(x => arrZxViewpointIdLst.Contains(x.zxViewpointId));
return arrvzx_ViewpointObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ViewpointEN> GetObjLst(string strWhereCond)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
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
public static List<clsvzx_ViewpointEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_ViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_ViewpointEN> GetSubObjLstCache(clsvzx_ViewpointEN objvzx_ViewpointCond)
{
 string strIdCurrEduCls = objvzx_ViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_ViewpointBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_ViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_ViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Viewpoint.AttributeName)
{
if (objvzx_ViewpointCond.IsUpdated(strFldName) == false) continue;
if (objvzx_ViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ViewpointCond[strFldName].ToString());
}
else
{
if (objvzx_ViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_ViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_ViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_ViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_ViewpointCond[strFldName]));
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
public static List<clsvzx_ViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
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
public static List<clsvzx_ViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
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
List<clsvzx_ViewpointEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_ViewpointEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ViewpointEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_ViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
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
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
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
public static List<clsvzx_ViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_ViewpointEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_ViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
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
public static List<clsvzx_ViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ViewpointEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_ViewpointEN> arrObjLst = new List<clsvzx_ViewpointEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ViewpointEN objvzx_ViewpointEN = new clsvzx_ViewpointEN();
try
{
objvzx_ViewpointEN.ViewpointTypeName = objRow[convzx_Viewpoint.ViewpointTypeName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointTypeName].ToString().Trim(); //观点类型名
objvzx_ViewpointEN.zxViewpointId = objRow[convzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objvzx_ViewpointEN.ViewpointName = objRow[convzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objvzx_ViewpointEN.ViewpointContent = objRow[convzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objvzx_ViewpointEN.zxViewpointTypeId = objRow[convzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objvzx_ViewpointEN.Reason = objRow[convzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[convzx_Viewpoint.Reason].ToString().Trim(); //理由
objvzx_ViewpointEN.Source = objRow[convzx_Viewpoint.Source] == DBNull.Value ? null : objRow[convzx_Viewpoint.Source].ToString().Trim(); //来源
objvzx_ViewpointEN.VPProposePeople = objRow[convzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[convzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objvzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objvzx_ViewpointEN.UserTypeId = objRow[convzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[convzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objvzx_ViewpointEN.TextId = objRow[convzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objvzx_ViewpointEN.VoteCount = objRow[convzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objvzx_ViewpointEN.AppraiseCount = objRow[convzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objvzx_ViewpointEN.Score = objRow[convzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.Score].ToString().Trim()); //评分
objvzx_ViewpointEN.StuScore = objRow[convzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objvzx_ViewpointEN.TeaScore = objRow[convzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objvzx_ViewpointEN.IdCurrEduCls = objRow[convzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ViewpointEN.PdfContent = objRow[convzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ViewpointEN.PdfPageNum = objRow[convzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ViewpointEN.CitationCount = objRow[convzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objvzx_ViewpointEN.VersionCount = objRow[convzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objvzx_ViewpointEN.zxShareId = objRow[convzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[convzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objvzx_ViewpointEN.CreateDate = objRow[convzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objvzx_ViewpointEN.UpdDate = objRow[convzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objvzx_ViewpointEN.UpdUser = objRow[convzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[convzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objvzx_ViewpointEN.Memo = objRow[convzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[convzx_Viewpoint.Memo].ToString().Trim(); //备注
objvzx_ViewpointEN.TeammenberId = objRow[convzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[convzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objvzx_ViewpointEN.PdfDivLet = objRow[convzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ViewpointEN.PdfDivTop = objRow[convzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ViewpointEN.PdfPageNumIn = objRow[convzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ViewpointEN.PdfPageTop = objRow[convzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ViewpointEN.PdfZoom = objRow[convzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[convzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ViewpointEN.GroupTextId = objRow[convzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[convzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
objvzx_ViewpointEN.TextContent = objRow[convzx_Viewpoint.TextContent] == DBNull.Value ? null : objRow[convzx_Viewpoint.TextContent].ToString().Trim(); //TextContent
objvzx_ViewpointEN.Author = objRow[convzx_Viewpoint.Author] == DBNull.Value ? null : objRow[convzx_Viewpoint.Author].ToString().Trim(); //作者
objvzx_ViewpointEN.Keyword = objRow[convzx_Viewpoint.Keyword] == DBNull.Value ? null : objRow[convzx_Viewpoint.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ViewpointEN.zxViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ViewpointEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_ViewpointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_Viewpoint(ref clsvzx_ViewpointEN objvzx_ViewpointEN)
{
bool bolResult = vzx_ViewpointDA.Getvzx_Viewpoint(ref objvzx_ViewpointEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_ViewpointEN GetObjByzxViewpointId(string strzxViewpointId)
{
if (strzxViewpointId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxViewpointId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxViewpointId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxViewpointId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_ViewpointEN objvzx_ViewpointEN = vzx_ViewpointDA.GetObjByzxViewpointId(strzxViewpointId);
return objvzx_ViewpointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_ViewpointEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_ViewpointEN objvzx_ViewpointEN = vzx_ViewpointDA.GetFirstObj(strWhereCond);
 return objvzx_ViewpointEN;
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
public static clsvzx_ViewpointEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_ViewpointEN objvzx_ViewpointEN = vzx_ViewpointDA.GetObjByDataRow(objRow);
 return objvzx_ViewpointEN;
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
public static clsvzx_ViewpointEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_ViewpointEN objvzx_ViewpointEN = vzx_ViewpointDA.GetObjByDataRow(objRow);
 return objvzx_ViewpointEN;
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
 /// <param name = "strzxViewpointId">所给的关键字</param>
 /// <param name = "lstvzx_ViewpointObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_ViewpointEN GetObjByzxViewpointIdFromList(string strzxViewpointId, List<clsvzx_ViewpointEN> lstvzx_ViewpointObjLst)
{
foreach (clsvzx_ViewpointEN objvzx_ViewpointEN in lstvzx_ViewpointObjLst)
{
if (objvzx_ViewpointEN.zxViewpointId == strzxViewpointId)
{
return objvzx_ViewpointEN;
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
 string strMaxZxViewpointId;
 try
 {
 strMaxZxViewpointId = clsvzx_ViewpointDA.GetMaxStrId();
 return strMaxZxViewpointId;
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
 string strzxViewpointId;
 try
 {
 strzxViewpointId = new clsvzx_ViewpointDA().GetFirstID(strWhereCond);
 return strzxViewpointId;
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
 arrList = vzx_ViewpointDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_ViewpointDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxViewpointId)
{
if (string.IsNullOrEmpty(strzxViewpointId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxViewpointId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_ViewpointDA.IsExist(strzxViewpointId);
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
 bolIsExist = clsvzx_ViewpointDA.IsExistTable();
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
 bolIsExist = vzx_ViewpointDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_ViewpointENS">源对象</param>
 /// <param name = "objvzx_ViewpointENT">目标对象</param>
 public static void CopyTo(clsvzx_ViewpointEN objvzx_ViewpointENS, clsvzx_ViewpointEN objvzx_ViewpointENT)
{
try
{
objvzx_ViewpointENT.ViewpointTypeName = objvzx_ViewpointENS.ViewpointTypeName; //观点类型名
objvzx_ViewpointENT.zxViewpointId = objvzx_ViewpointENS.zxViewpointId; //观点Id
objvzx_ViewpointENT.ViewpointName = objvzx_ViewpointENS.ViewpointName; //观点名称
objvzx_ViewpointENT.ViewpointContent = objvzx_ViewpointENS.ViewpointContent; //观点内容
objvzx_ViewpointENT.zxViewpointTypeId = objvzx_ViewpointENS.zxViewpointTypeId; //观点类型Id
objvzx_ViewpointENT.Reason = objvzx_ViewpointENS.Reason; //理由
objvzx_ViewpointENT.Source = objvzx_ViewpointENS.Source; //来源
objvzx_ViewpointENT.VPProposePeople = objvzx_ViewpointENS.VPProposePeople; //观点提出人
objvzx_ViewpointENT.IsSubmit = objvzx_ViewpointENS.IsSubmit; //是否提交
objvzx_ViewpointENT.UserTypeId = objvzx_ViewpointENS.UserTypeId; //用户类型Id
objvzx_ViewpointENT.TextId = objvzx_ViewpointENS.TextId; //课件Id
objvzx_ViewpointENT.VoteCount = objvzx_ViewpointENS.VoteCount; //点赞计数
objvzx_ViewpointENT.AppraiseCount = objvzx_ViewpointENS.AppraiseCount; //评论数
objvzx_ViewpointENT.Score = objvzx_ViewpointENS.Score; //评分
objvzx_ViewpointENT.StuScore = objvzx_ViewpointENS.StuScore; //学生平均分
objvzx_ViewpointENT.TeaScore = objvzx_ViewpointENS.TeaScore; //教师评分
objvzx_ViewpointENT.IdCurrEduCls = objvzx_ViewpointENS.IdCurrEduCls; //教学班流水号
objvzx_ViewpointENT.PdfContent = objvzx_ViewpointENS.PdfContent; //Pdf内容
objvzx_ViewpointENT.PdfPageNum = objvzx_ViewpointENS.PdfPageNum; //Pdf页码
objvzx_ViewpointENT.CitationCount = objvzx_ViewpointENS.CitationCount; //引用统计
objvzx_ViewpointENT.VersionCount = objvzx_ViewpointENS.VersionCount; //版本统计
objvzx_ViewpointENT.zxShareId = objvzx_ViewpointENS.zxShareId; //分享Id
objvzx_ViewpointENT.CreateDate = objvzx_ViewpointENS.CreateDate; //建立日期
objvzx_ViewpointENT.UpdDate = objvzx_ViewpointENS.UpdDate; //修改日期
objvzx_ViewpointENT.UpdUser = objvzx_ViewpointENS.UpdUser; //修改人
objvzx_ViewpointENT.Memo = objvzx_ViewpointENS.Memo; //备注
objvzx_ViewpointENT.TeammenberId = objvzx_ViewpointENS.TeammenberId; //主键
objvzx_ViewpointENT.PdfDivLet = objvzx_ViewpointENS.PdfDivLet; //PdfDivLet
objvzx_ViewpointENT.PdfDivTop = objvzx_ViewpointENS.PdfDivTop; //PdfDivTop
objvzx_ViewpointENT.PdfPageNumIn = objvzx_ViewpointENS.PdfPageNumIn; //PdfPageNumIn
objvzx_ViewpointENT.PdfPageTop = objvzx_ViewpointENS.PdfPageTop; //pdf页面顶部位置
objvzx_ViewpointENT.PdfZoom = objvzx_ViewpointENS.PdfZoom; //PdfZoom
objvzx_ViewpointENT.GroupTextId = objvzx_ViewpointENS.GroupTextId; //小组Id
objvzx_ViewpointENT.TextContent = objvzx_ViewpointENS.TextContent; //TextContent
objvzx_ViewpointENT.Author = objvzx_ViewpointENS.Author; //作者
objvzx_ViewpointENT.Keyword = objvzx_ViewpointENS.Keyword; //关键字
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
 /// <param name = "objvzx_ViewpointEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_ViewpointEN objvzx_ViewpointEN)
{
try
{
objvzx_ViewpointEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_ViewpointEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_Viewpoint.ViewpointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.ViewpointTypeName = objvzx_ViewpointEN.ViewpointTypeName == "[null]" ? null :  objvzx_ViewpointEN.ViewpointTypeName; //观点类型名
}
if (arrFldSet.Contains(convzx_Viewpoint.zxViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.zxViewpointId = objvzx_ViewpointEN.zxViewpointId; //观点Id
}
if (arrFldSet.Contains(convzx_Viewpoint.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.ViewpointName = objvzx_ViewpointEN.ViewpointName == "[null]" ? null :  objvzx_ViewpointEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(convzx_Viewpoint.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.ViewpointContent = objvzx_ViewpointEN.ViewpointContent == "[null]" ? null :  objvzx_ViewpointEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(convzx_Viewpoint.zxViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.zxViewpointTypeId = objvzx_ViewpointEN.zxViewpointTypeId == "[null]" ? null :  objvzx_ViewpointEN.zxViewpointTypeId; //观点类型Id
}
if (arrFldSet.Contains(convzx_Viewpoint.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.Reason = objvzx_ViewpointEN.Reason == "[null]" ? null :  objvzx_ViewpointEN.Reason; //理由
}
if (arrFldSet.Contains(convzx_Viewpoint.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.Source = objvzx_ViewpointEN.Source == "[null]" ? null :  objvzx_ViewpointEN.Source; //来源
}
if (arrFldSet.Contains(convzx_Viewpoint.VPProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.VPProposePeople = objvzx_ViewpointEN.VPProposePeople == "[null]" ? null :  objvzx_ViewpointEN.VPProposePeople; //观点提出人
}
if (arrFldSet.Contains(convzx_Viewpoint.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.IsSubmit = objvzx_ViewpointEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_Viewpoint.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.UserTypeId = objvzx_ViewpointEN.UserTypeId == "[null]" ? null :  objvzx_ViewpointEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convzx_Viewpoint.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.TextId = objvzx_ViewpointEN.TextId == "[null]" ? null :  objvzx_ViewpointEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_Viewpoint.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.VoteCount = objvzx_ViewpointEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_Viewpoint.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.AppraiseCount = objvzx_ViewpointEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_Viewpoint.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.Score = objvzx_ViewpointEN.Score; //评分
}
if (arrFldSet.Contains(convzx_Viewpoint.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.StuScore = objvzx_ViewpointEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_Viewpoint.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.TeaScore = objvzx_ViewpointEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_Viewpoint.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.IdCurrEduCls = objvzx_ViewpointEN.IdCurrEduCls == "[null]" ? null :  objvzx_ViewpointEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_Viewpoint.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.PdfContent = objvzx_ViewpointEN.PdfContent == "[null]" ? null :  objvzx_ViewpointEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convzx_Viewpoint.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.PdfPageNum = objvzx_ViewpointEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convzx_Viewpoint.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.CitationCount = objvzx_ViewpointEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convzx_Viewpoint.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.VersionCount = objvzx_ViewpointEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_Viewpoint.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.zxShareId = objvzx_ViewpointEN.zxShareId == "[null]" ? null :  objvzx_ViewpointEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_Viewpoint.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.CreateDate = objvzx_ViewpointEN.CreateDate == "[null]" ? null :  objvzx_ViewpointEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_Viewpoint.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.UpdDate = objvzx_ViewpointEN.UpdDate == "[null]" ? null :  objvzx_ViewpointEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_Viewpoint.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.UpdUser = objvzx_ViewpointEN.UpdUser == "[null]" ? null :  objvzx_ViewpointEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_Viewpoint.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.Memo = objvzx_ViewpointEN.Memo == "[null]" ? null :  objvzx_ViewpointEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_Viewpoint.TeammenberId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.TeammenberId = objvzx_ViewpointEN.TeammenberId == "[null]" ? null :  objvzx_ViewpointEN.TeammenberId; //主键
}
if (arrFldSet.Contains(convzx_Viewpoint.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.PdfDivLet = objvzx_ViewpointEN.PdfDivLet == "[null]" ? null :  objvzx_ViewpointEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convzx_Viewpoint.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.PdfDivTop = objvzx_ViewpointEN.PdfDivTop == "[null]" ? null :  objvzx_ViewpointEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convzx_Viewpoint.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.PdfPageNumIn = objvzx_ViewpointEN.PdfPageNumIn == "[null]" ? null :  objvzx_ViewpointEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convzx_Viewpoint.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.PdfPageTop = objvzx_ViewpointEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convzx_Viewpoint.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.PdfZoom = objvzx_ViewpointEN.PdfZoom == "[null]" ? null :  objvzx_ViewpointEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convzx_Viewpoint.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.GroupTextId = objvzx_ViewpointEN.GroupTextId == "[null]" ? null :  objvzx_ViewpointEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_Viewpoint.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.TextContent = objvzx_ViewpointEN.TextContent == "[null]" ? null :  objvzx_ViewpointEN.TextContent; //TextContent
}
if (arrFldSet.Contains(convzx_Viewpoint.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.Author = objvzx_ViewpointEN.Author == "[null]" ? null :  objvzx_ViewpointEN.Author; //作者
}
if (arrFldSet.Contains(convzx_Viewpoint.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ViewpointEN.Keyword = objvzx_ViewpointEN.Keyword == "[null]" ? null :  objvzx_ViewpointEN.Keyword; //关键字
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
 /// <param name = "objvzx_ViewpointEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_ViewpointEN objvzx_ViewpointEN)
{
try
{
if (objvzx_ViewpointEN.ViewpointTypeName == "[null]") objvzx_ViewpointEN.ViewpointTypeName = null; //观点类型名
if (objvzx_ViewpointEN.ViewpointName == "[null]") objvzx_ViewpointEN.ViewpointName = null; //观点名称
if (objvzx_ViewpointEN.ViewpointContent == "[null]") objvzx_ViewpointEN.ViewpointContent = null; //观点内容
if (objvzx_ViewpointEN.zxViewpointTypeId == "[null]") objvzx_ViewpointEN.zxViewpointTypeId = null; //观点类型Id
if (objvzx_ViewpointEN.Reason == "[null]") objvzx_ViewpointEN.Reason = null; //理由
if (objvzx_ViewpointEN.Source == "[null]") objvzx_ViewpointEN.Source = null; //来源
if (objvzx_ViewpointEN.VPProposePeople == "[null]") objvzx_ViewpointEN.VPProposePeople = null; //观点提出人
if (objvzx_ViewpointEN.UserTypeId == "[null]") objvzx_ViewpointEN.UserTypeId = null; //用户类型Id
if (objvzx_ViewpointEN.TextId == "[null]") objvzx_ViewpointEN.TextId = null; //课件Id
if (objvzx_ViewpointEN.IdCurrEduCls == "[null]") objvzx_ViewpointEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_ViewpointEN.PdfContent == "[null]") objvzx_ViewpointEN.PdfContent = null; //Pdf内容
if (objvzx_ViewpointEN.zxShareId == "[null]") objvzx_ViewpointEN.zxShareId = null; //分享Id
if (objvzx_ViewpointEN.CreateDate == "[null]") objvzx_ViewpointEN.CreateDate = null; //建立日期
if (objvzx_ViewpointEN.UpdDate == "[null]") objvzx_ViewpointEN.UpdDate = null; //修改日期
if (objvzx_ViewpointEN.UpdUser == "[null]") objvzx_ViewpointEN.UpdUser = null; //修改人
if (objvzx_ViewpointEN.Memo == "[null]") objvzx_ViewpointEN.Memo = null; //备注
if (objvzx_ViewpointEN.TeammenberId == "[null]") objvzx_ViewpointEN.TeammenberId = null; //主键
if (objvzx_ViewpointEN.PdfDivLet == "[null]") objvzx_ViewpointEN.PdfDivLet = null; //PdfDivLet
if (objvzx_ViewpointEN.PdfDivTop == "[null]") objvzx_ViewpointEN.PdfDivTop = null; //PdfDivTop
if (objvzx_ViewpointEN.PdfPageNumIn == "[null]") objvzx_ViewpointEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvzx_ViewpointEN.PdfZoom == "[null]") objvzx_ViewpointEN.PdfZoom = null; //PdfZoom
if (objvzx_ViewpointEN.GroupTextId == "[null]") objvzx_ViewpointEN.GroupTextId = null; //小组Id
if (objvzx_ViewpointEN.TextContent == "[null]") objvzx_ViewpointEN.TextContent = null; //TextContent
if (objvzx_ViewpointEN.Author == "[null]") objvzx_ViewpointEN.Author = null; //作者
if (objvzx_ViewpointEN.Keyword == "[null]") objvzx_ViewpointEN.Keyword = null; //关键字
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
public static void CheckProperty4Condition(clsvzx_ViewpointEN objvzx_ViewpointEN)
{
 vzx_ViewpointDA.CheckProperty4Condition(objvzx_ViewpointEN);
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
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_ViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ViewpointBL没有刷新缓存机制(clszx_ViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_ViewpointTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ViewpointTypeBL没有刷新缓存机制(clszx_ViewpointTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxViewpointId");
//if (arrvzx_ViewpointObjLstCache == null)
//{
//arrvzx_ViewpointObjLstCache = vzx_ViewpointDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxViewpointId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_ViewpointEN GetObjByzxViewpointIdCache(string strzxViewpointId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_ViewpointEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_ViewpointEN> arrvzx_ViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_ViewpointEN> arrvzx_ViewpointObjLst_Sel =
arrvzx_ViewpointObjLstCache
.Where(x=> x.zxViewpointId == strzxViewpointId 
);
if (arrvzx_ViewpointObjLst_Sel.Count() == 0)
{
   clsvzx_ViewpointEN obj = clsvzx_ViewpointBL.GetObjByzxViewpointId(strzxViewpointId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxViewpointId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_ViewpointObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_ViewpointEN> GetAllvzx_ViewpointObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_ViewpointEN> arrvzx_ViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_ViewpointObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_ViewpointEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_ViewpointEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_ViewpointEN> arrvzx_ViewpointObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_ViewpointObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_ViewpointEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, string strzxViewpointId, string strIdCurrEduCls)
{
if (strInFldName != convzx_Viewpoint.zxViewpointId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_Viewpoint.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_Viewpoint.AttributeName));
throw new Exception(strMsg);
}
var objvzx_Viewpoint = clsvzx_ViewpointBL.GetObjByzxViewpointIdCache(strzxViewpointId, strIdCurrEduCls);
if (objvzx_Viewpoint == null) return "";
return objvzx_Viewpoint[strOutFldName].ToString();
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
int intRecCount = clsvzx_ViewpointDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_ViewpointDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_ViewpointDA.GetRecCount();
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
int intRecCount = clsvzx_ViewpointDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_ViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_ViewpointEN objvzx_ViewpointCond)
{
 string strIdCurrEduCls = objvzx_ViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_ViewpointBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_ViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_ViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Viewpoint.AttributeName)
{
if (objvzx_ViewpointCond.IsUpdated(strFldName) == false) continue;
if (objvzx_ViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ViewpointCond[strFldName].ToString());
}
else
{
if (objvzx_ViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_ViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_ViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_ViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_ViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_ViewpointCond[strFldName]));
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
 List<string> arrList = clsvzx_ViewpointDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_ViewpointDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_ViewpointDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}