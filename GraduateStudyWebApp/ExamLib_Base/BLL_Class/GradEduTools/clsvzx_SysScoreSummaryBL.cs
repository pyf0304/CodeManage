
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SysScoreSummaryBL
 表名:vzx_SysScoreSummary(01120838)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:16
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
public static class  clsvzx_SysScoreSummaryBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SysScoreSummaryEN GetObj(this K_mId_vzx_SysScoreSummary myKey)
{
clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = clsvzx_SysScoreSummaryBL.vzx_SysScoreSummaryDA.GetObjBymId(myKey.Value);
return objvzx_SysScoreSummaryEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetScoreTypeName(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strScoreTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeName, 10, convzx_SysScoreSummary.ScoreTypeName);
}
objvzx_SysScoreSummaryEN.ScoreTypeName = strScoreTypeName; //分数类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.ScoreTypeName) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.ScoreTypeName, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.ScoreTypeName] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetOnlyId(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strOnlyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOnlyId, 20, convzx_SysScoreSummary.OnlyId);
}
objvzx_SysScoreSummaryEN.OnlyId = strOnlyId; //OnlyId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.OnlyId) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.OnlyId, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.OnlyId] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetEduClsName(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convzx_SysScoreSummary.EduClsName);
}
objvzx_SysScoreSummaryEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.EduClsName) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.EduClsName, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.EduClsName] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetmId(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, long lngmId, string strComparisonOp="")
	{
objvzx_SysScoreSummaryEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.mId) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.mId, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.mId] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetUserId(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convzx_SysScoreSummary.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convzx_SysScoreSummary.UserId);
}
objvzx_SysScoreSummaryEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.UserId) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.UserId, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.UserId] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetSchoolYear(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convzx_SysScoreSummary.SchoolYear);
}
objvzx_SysScoreSummaryEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.SchoolYear) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.SchoolYear, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.SchoolYear] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetUpdDate(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_SysScoreSummary.UpdDate);
}
objvzx_SysScoreSummaryEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.UpdDate) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.UpdDate, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.UpdDate] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetMemo(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_SysScoreSummary.Memo);
}
objvzx_SysScoreSummaryEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.Memo) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.Memo, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.Memo] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetzxScoreTypeId(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strzxScoreTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxScoreTypeId, 4, convzx_SysScoreSummary.zxScoreTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxScoreTypeId, 4, convzx_SysScoreSummary.zxScoreTypeId);
}
objvzx_SysScoreSummaryEN.zxScoreTypeId = strzxScoreTypeId; //分数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.zxScoreTypeId) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.zxScoreTypeId, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.zxScoreTypeId] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetUpdUser(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_SysScoreSummary.UpdUser);
}
objvzx_SysScoreSummaryEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.UpdUser) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.UpdUser, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.UpdUser] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetScore(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, float? fltScore, string strComparisonOp="")
	{
objvzx_SysScoreSummaryEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.Score) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.Score, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.Score] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetIdCurrEduCls(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_SysScoreSummary.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_SysScoreSummary.IdCurrEduCls);
}
objvzx_SysScoreSummaryEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.IdCurrEduCls) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetIsSubmit(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_SysScoreSummaryEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.IsSubmit) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.IsSubmit, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.IsSubmit] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetUserName(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convzx_SysScoreSummary.UserName);
}
objvzx_SysScoreSummaryEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.UserName) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.UserName, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.UserName] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetIdXzCollege(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convzx_SysScoreSummary.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convzx_SysScoreSummary.IdXzCollege);
}
objvzx_SysScoreSummaryEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.IdXzCollege) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.IdXzCollege, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.IdXzCollege] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetCollegeName(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convzx_SysScoreSummary.CollegeName);
}
objvzx_SysScoreSummaryEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.CollegeName) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.CollegeName, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.CollegeName] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetIdXzMajor(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convzx_SysScoreSummary.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convzx_SysScoreSummary.IdXzMajor);
}
objvzx_SysScoreSummaryEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.IdXzMajor) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.IdXzMajor, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.IdXzMajor] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetIdGradeBase(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convzx_SysScoreSummary.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convzx_SysScoreSummary.IdGradeBase);
}
objvzx_SysScoreSummaryEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.IdGradeBase) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.IdGradeBase, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.IdGradeBase] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetGradeBaseName(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convzx_SysScoreSummary.GradeBaseName);
}
objvzx_SysScoreSummaryEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.GradeBaseName) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.GradeBaseName, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.GradeBaseName] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SysScoreSummaryEN SetMajorName(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convzx_SysScoreSummary.MajorName);
}
objvzx_SysScoreSummaryEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convzx_SysScoreSummary.MajorName) == false)
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp.Add(convzx_SysScoreSummary.MajorName, strComparisonOp);
}
else
{
objvzx_SysScoreSummaryEN.dicFldComparisonOp[convzx_SysScoreSummary.MajorName] = strComparisonOp;
}
}
return objvzx_SysScoreSummaryEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryENS">源对象</param>
 /// <param name = "objvzx_SysScoreSummaryENT">目标对象</param>
 public static void CopyTo(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryENS, clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryENT)
{
try
{
objvzx_SysScoreSummaryENT.ScoreTypeName = objvzx_SysScoreSummaryENS.ScoreTypeName; //分数类型名称
objvzx_SysScoreSummaryENT.OnlyId = objvzx_SysScoreSummaryENS.OnlyId; //OnlyId
objvzx_SysScoreSummaryENT.EduClsName = objvzx_SysScoreSummaryENS.EduClsName; //教学班名
objvzx_SysScoreSummaryENT.mId = objvzx_SysScoreSummaryENS.mId; //mId
objvzx_SysScoreSummaryENT.UserId = objvzx_SysScoreSummaryENS.UserId; //用户ID
objvzx_SysScoreSummaryENT.SchoolYear = objvzx_SysScoreSummaryENS.SchoolYear; //学年
objvzx_SysScoreSummaryENT.UpdDate = objvzx_SysScoreSummaryENS.UpdDate; //修改日期
objvzx_SysScoreSummaryENT.Memo = objvzx_SysScoreSummaryENS.Memo; //备注
objvzx_SysScoreSummaryENT.zxScoreTypeId = objvzx_SysScoreSummaryENS.zxScoreTypeId; //分数类型Id
objvzx_SysScoreSummaryENT.UpdUser = objvzx_SysScoreSummaryENS.UpdUser; //修改人
objvzx_SysScoreSummaryENT.Score = objvzx_SysScoreSummaryENS.Score; //评分
objvzx_SysScoreSummaryENT.IdCurrEduCls = objvzx_SysScoreSummaryENS.IdCurrEduCls; //教学班流水号
objvzx_SysScoreSummaryENT.IsSubmit = objvzx_SysScoreSummaryENS.IsSubmit; //是否提交
objvzx_SysScoreSummaryENT.UserName = objvzx_SysScoreSummaryENS.UserName; //用户名
objvzx_SysScoreSummaryENT.IdXzCollege = objvzx_SysScoreSummaryENS.IdXzCollege; //学院流水号
objvzx_SysScoreSummaryENT.CollegeName = objvzx_SysScoreSummaryENS.CollegeName; //学院名称
objvzx_SysScoreSummaryENT.IdXzMajor = objvzx_SysScoreSummaryENS.IdXzMajor; //专业流水号
objvzx_SysScoreSummaryENT.IdGradeBase = objvzx_SysScoreSummaryENS.IdGradeBase; //年级流水号
objvzx_SysScoreSummaryENT.GradeBaseName = objvzx_SysScoreSummaryENS.GradeBaseName; //年级名称
objvzx_SysScoreSummaryENT.MajorName = objvzx_SysScoreSummaryENS.MajorName; //专业名称
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
 /// <param name = "objvzx_SysScoreSummaryENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SysScoreSummaryEN:objvzx_SysScoreSummaryENT</returns>
 public static clsvzx_SysScoreSummaryEN CopyTo(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryENS)
{
try
{
 clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryENT = new clsvzx_SysScoreSummaryEN()
{
ScoreTypeName = objvzx_SysScoreSummaryENS.ScoreTypeName, //分数类型名称
OnlyId = objvzx_SysScoreSummaryENS.OnlyId, //OnlyId
EduClsName = objvzx_SysScoreSummaryENS.EduClsName, //教学班名
mId = objvzx_SysScoreSummaryENS.mId, //mId
UserId = objvzx_SysScoreSummaryENS.UserId, //用户ID
SchoolYear = objvzx_SysScoreSummaryENS.SchoolYear, //学年
UpdDate = objvzx_SysScoreSummaryENS.UpdDate, //修改日期
Memo = objvzx_SysScoreSummaryENS.Memo, //备注
zxScoreTypeId = objvzx_SysScoreSummaryENS.zxScoreTypeId, //分数类型Id
UpdUser = objvzx_SysScoreSummaryENS.UpdUser, //修改人
Score = objvzx_SysScoreSummaryENS.Score, //评分
IdCurrEduCls = objvzx_SysScoreSummaryENS.IdCurrEduCls, //教学班流水号
IsSubmit = objvzx_SysScoreSummaryENS.IsSubmit, //是否提交
UserName = objvzx_SysScoreSummaryENS.UserName, //用户名
IdXzCollege = objvzx_SysScoreSummaryENS.IdXzCollege, //学院流水号
CollegeName = objvzx_SysScoreSummaryENS.CollegeName, //学院名称
IdXzMajor = objvzx_SysScoreSummaryENS.IdXzMajor, //专业流水号
IdGradeBase = objvzx_SysScoreSummaryENS.IdGradeBase, //年级流水号
GradeBaseName = objvzx_SysScoreSummaryENS.GradeBaseName, //年级名称
MajorName = objvzx_SysScoreSummaryENS.MajorName, //专业名称
};
 return objvzx_SysScoreSummaryENT;
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
public static void CheckProperty4Condition(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN)
{
 clsvzx_SysScoreSummaryBL.vzx_SysScoreSummaryDA.CheckProperty4Condition(objvzx_SysScoreSummaryEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.ScoreTypeName) == true)
{
string strComparisonOpScoreTypeName = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.ScoreTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.ScoreTypeName, objvzx_SysScoreSummaryCond.ScoreTypeName, strComparisonOpScoreTypeName);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.OnlyId) == true)
{
string strComparisonOpOnlyId = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.OnlyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.OnlyId, objvzx_SysScoreSummaryCond.OnlyId, strComparisonOpOnlyId);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.EduClsName) == true)
{
string strComparisonOpEduClsName = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.EduClsName, objvzx_SysScoreSummaryCond.EduClsName, strComparisonOpEduClsName);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.mId) == true)
{
string strComparisonOpmId = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysScoreSummary.mId, objvzx_SysScoreSummaryCond.mId, strComparisonOpmId);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.UserId) == true)
{
string strComparisonOpUserId = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.UserId, objvzx_SysScoreSummaryCond.UserId, strComparisonOpUserId);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.SchoolYear, objvzx_SysScoreSummaryCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.UpdDate, objvzx_SysScoreSummaryCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.Memo) == true)
{
string strComparisonOpMemo = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.Memo, objvzx_SysScoreSummaryCond.Memo, strComparisonOpMemo);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.zxScoreTypeId) == true)
{
string strComparisonOpzxScoreTypeId = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.zxScoreTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.zxScoreTypeId, objvzx_SysScoreSummaryCond.zxScoreTypeId, strComparisonOpzxScoreTypeId);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.UpdUser, objvzx_SysScoreSummaryCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.Score) == true)
{
string strComparisonOpScore = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_SysScoreSummary.Score, objvzx_SysScoreSummaryCond.Score, strComparisonOpScore);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.IdCurrEduCls, objvzx_SysScoreSummaryCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.IsSubmit) == true)
{
if (objvzx_SysScoreSummaryCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_SysScoreSummary.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_SysScoreSummary.IsSubmit);
}
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.UserName) == true)
{
string strComparisonOpUserName = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.UserName, objvzx_SysScoreSummaryCond.UserName, strComparisonOpUserName);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.IdXzCollege, objvzx_SysScoreSummaryCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.CollegeName) == true)
{
string strComparisonOpCollegeName = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.CollegeName, objvzx_SysScoreSummaryCond.CollegeName, strComparisonOpCollegeName);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.IdXzMajor, objvzx_SysScoreSummaryCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.IdGradeBase, objvzx_SysScoreSummaryCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.GradeBaseName, objvzx_SysScoreSummaryCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvzx_SysScoreSummaryCond.IsUpdated(convzx_SysScoreSummary.MajorName) == true)
{
string strComparisonOpMajorName = objvzx_SysScoreSummaryCond.dicFldComparisonOp[convzx_SysScoreSummary.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_SysScoreSummary.MajorName, objvzx_SysScoreSummaryCond.MajorName, strComparisonOpMajorName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_SysScoreSummary
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_SysScoreSummary(vzx_SysScoreSummary)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_SysScoreSummaryBL
{
public static RelatedActions_vzx_SysScoreSummary relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_SysScoreSummaryDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_SysScoreSummaryDA vzx_SysScoreSummaryDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_SysScoreSummaryDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_SysScoreSummaryBL()
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
if (string.IsNullOrEmpty(clsvzx_SysScoreSummaryEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SysScoreSummaryEN._ConnectString);
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
public static DataTable GetDataTable_vzx_SysScoreSummary(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_SysScoreSummaryDA.GetDataTable_vzx_SysScoreSummary(strWhereCond);
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
objDT = vzx_SysScoreSummaryDA.GetDataTable(strWhereCond);
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
objDT = vzx_SysScoreSummaryDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_SysScoreSummaryDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_SysScoreSummaryDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_SysScoreSummaryDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_SysScoreSummaryDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_SysScoreSummaryDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_SysScoreSummaryDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvzx_SysScoreSummaryEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
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
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_SysScoreSummaryEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_SysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_SysScoreSummaryEN> arrvzx_SysScoreSummaryObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SysScoreSummaryEN> arrvzx_SysScoreSummaryObjLst_Sel =
arrvzx_SysScoreSummaryObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvzx_SysScoreSummaryObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SysScoreSummaryEN> GetObjLst(string strWhereCond)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
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
public static List<clsvzx_SysScoreSummaryEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_SysScoreSummaryEN> GetSubObjLstCache(clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryCond)
{
 string strIdCurrEduCls = objvzx_SysScoreSummaryCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_SysScoreSummaryBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_SysScoreSummaryEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SysScoreSummaryEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_SysScoreSummary.AttributeName)
{
if (objvzx_SysScoreSummaryCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SysScoreSummaryCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysScoreSummaryCond[strFldName].ToString());
}
else
{
if (objvzx_SysScoreSummaryCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SysScoreSummaryCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysScoreSummaryCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SysScoreSummaryCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SysScoreSummaryCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SysScoreSummaryCond[strFldName]));
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
public static List<clsvzx_SysScoreSummaryEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
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
public static List<clsvzx_SysScoreSummaryEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
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
List<clsvzx_SysScoreSummaryEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_SysScoreSummaryEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SysScoreSummaryEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_SysScoreSummaryEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
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
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
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
public static List<clsvzx_SysScoreSummaryEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_SysScoreSummaryEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_SysScoreSummaryEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
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
public static List<clsvzx_SysScoreSummaryEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SysScoreSummaryEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_SysScoreSummaryEN> arrObjLst = new List<clsvzx_SysScoreSummaryEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = new clsvzx_SysScoreSummaryEN();
try
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objRow[convzx_SysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvzx_SysScoreSummaryEN.OnlyId = objRow[convzx_SysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvzx_SysScoreSummaryEN.EduClsName = objRow[convzx_SysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvzx_SysScoreSummaryEN.mId = Int32.Parse(objRow[convzx_SysScoreSummary.mId].ToString().Trim()); //mId
objvzx_SysScoreSummaryEN.UserId = objRow[convzx_SysScoreSummary.UserId].ToString().Trim(); //用户ID
objvzx_SysScoreSummaryEN.SchoolYear = objRow[convzx_SysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvzx_SysScoreSummaryEN.UpdDate = objRow[convzx_SysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvzx_SysScoreSummaryEN.Memo = objRow[convzx_SysScoreSummary.Memo] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.Memo].ToString().Trim(); //备注
objvzx_SysScoreSummaryEN.zxScoreTypeId = objRow[convzx_SysScoreSummary.zxScoreTypeId] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.zxScoreTypeId].ToString().Trim(); //分数类型Id
objvzx_SysScoreSummaryEN.UpdUser = objRow[convzx_SysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvzx_SysScoreSummaryEN.Score = objRow[convzx_SysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_SysScoreSummary.Score].ToString().Trim()); //评分
objvzx_SysScoreSummaryEN.IdCurrEduCls = objRow[convzx_SysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_SysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_SysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
objvzx_SysScoreSummaryEN.UserName = objRow[convzx_SysScoreSummary.UserName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.UserName].ToString().Trim(); //用户名
objvzx_SysScoreSummaryEN.IdXzCollege = objRow[convzx_SysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvzx_SysScoreSummaryEN.CollegeName = objRow[convzx_SysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvzx_SysScoreSummaryEN.IdXzMajor = objRow[convzx_SysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_SysScoreSummaryEN.IdGradeBase = objRow[convzx_SysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvzx_SysScoreSummaryEN.GradeBaseName = objRow[convzx_SysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvzx_SysScoreSummaryEN.MajorName = objRow[convzx_SysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convzx_SysScoreSummary.MajorName].ToString().Trim(); //专业名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SysScoreSummaryEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_SysScoreSummary(ref clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN)
{
bool bolResult = vzx_SysScoreSummaryDA.Getvzx_SysScoreSummary(ref objvzx_SysScoreSummaryEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SysScoreSummaryEN GetObjBymId(long lngmId)
{
clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = vzx_SysScoreSummaryDA.GetObjBymId(lngmId);
return objvzx_SysScoreSummaryEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_SysScoreSummaryEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = vzx_SysScoreSummaryDA.GetFirstObj(strWhereCond);
 return objvzx_SysScoreSummaryEN;
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
public static clsvzx_SysScoreSummaryEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = vzx_SysScoreSummaryDA.GetObjByDataRow(objRow);
 return objvzx_SysScoreSummaryEN;
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
public static clsvzx_SysScoreSummaryEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN = vzx_SysScoreSummaryDA.GetObjByDataRow(objRow);
 return objvzx_SysScoreSummaryEN;
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
 /// <param name = "lstvzx_SysScoreSummaryObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SysScoreSummaryEN GetObjBymIdFromList(long lngmId, List<clsvzx_SysScoreSummaryEN> lstvzx_SysScoreSummaryObjLst)
{
foreach (clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN in lstvzx_SysScoreSummaryObjLst)
{
if (objvzx_SysScoreSummaryEN.mId == lngmId)
{
return objvzx_SysScoreSummaryEN;
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
 lngmId = new clsvzx_SysScoreSummaryDA().GetFirstID(strWhereCond);
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
 arrList = vzx_SysScoreSummaryDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_SysScoreSummaryDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vzx_SysScoreSummaryDA.IsExist(lngmId);
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
 bolIsExist = clsvzx_SysScoreSummaryDA.IsExistTable();
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
 bolIsExist = vzx_SysScoreSummaryDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_SysScoreSummaryENS">源对象</param>
 /// <param name = "objvzx_SysScoreSummaryENT">目标对象</param>
 public static void CopyTo(clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryENS, clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryENT)
{
try
{
objvzx_SysScoreSummaryENT.ScoreTypeName = objvzx_SysScoreSummaryENS.ScoreTypeName; //分数类型名称
objvzx_SysScoreSummaryENT.OnlyId = objvzx_SysScoreSummaryENS.OnlyId; //OnlyId
objvzx_SysScoreSummaryENT.EduClsName = objvzx_SysScoreSummaryENS.EduClsName; //教学班名
objvzx_SysScoreSummaryENT.mId = objvzx_SysScoreSummaryENS.mId; //mId
objvzx_SysScoreSummaryENT.UserId = objvzx_SysScoreSummaryENS.UserId; //用户ID
objvzx_SysScoreSummaryENT.SchoolYear = objvzx_SysScoreSummaryENS.SchoolYear; //学年
objvzx_SysScoreSummaryENT.UpdDate = objvzx_SysScoreSummaryENS.UpdDate; //修改日期
objvzx_SysScoreSummaryENT.Memo = objvzx_SysScoreSummaryENS.Memo; //备注
objvzx_SysScoreSummaryENT.zxScoreTypeId = objvzx_SysScoreSummaryENS.zxScoreTypeId; //分数类型Id
objvzx_SysScoreSummaryENT.UpdUser = objvzx_SysScoreSummaryENS.UpdUser; //修改人
objvzx_SysScoreSummaryENT.Score = objvzx_SysScoreSummaryENS.Score; //评分
objvzx_SysScoreSummaryENT.IdCurrEduCls = objvzx_SysScoreSummaryENS.IdCurrEduCls; //教学班流水号
objvzx_SysScoreSummaryENT.IsSubmit = objvzx_SysScoreSummaryENS.IsSubmit; //是否提交
objvzx_SysScoreSummaryENT.UserName = objvzx_SysScoreSummaryENS.UserName; //用户名
objvzx_SysScoreSummaryENT.IdXzCollege = objvzx_SysScoreSummaryENS.IdXzCollege; //学院流水号
objvzx_SysScoreSummaryENT.CollegeName = objvzx_SysScoreSummaryENS.CollegeName; //学院名称
objvzx_SysScoreSummaryENT.IdXzMajor = objvzx_SysScoreSummaryENS.IdXzMajor; //专业流水号
objvzx_SysScoreSummaryENT.IdGradeBase = objvzx_SysScoreSummaryENS.IdGradeBase; //年级流水号
objvzx_SysScoreSummaryENT.GradeBaseName = objvzx_SysScoreSummaryENS.GradeBaseName; //年级名称
objvzx_SysScoreSummaryENT.MajorName = objvzx_SysScoreSummaryENS.MajorName; //专业名称
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
 /// <param name = "objvzx_SysScoreSummaryEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN)
{
try
{
objvzx_SysScoreSummaryEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_SysScoreSummaryEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_SysScoreSummary.ScoreTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.ScoreTypeName = objvzx_SysScoreSummaryEN.ScoreTypeName == "[null]" ? null :  objvzx_SysScoreSummaryEN.ScoreTypeName; //分数类型名称
}
if (arrFldSet.Contains(convzx_SysScoreSummary.OnlyId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.OnlyId = objvzx_SysScoreSummaryEN.OnlyId == "[null]" ? null :  objvzx_SysScoreSummaryEN.OnlyId; //OnlyId
}
if (arrFldSet.Contains(convzx_SysScoreSummary.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.EduClsName = objvzx_SysScoreSummaryEN.EduClsName == "[null]" ? null :  objvzx_SysScoreSummaryEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convzx_SysScoreSummary.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.mId = objvzx_SysScoreSummaryEN.mId; //mId
}
if (arrFldSet.Contains(convzx_SysScoreSummary.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.UserId = objvzx_SysScoreSummaryEN.UserId; //用户ID
}
if (arrFldSet.Contains(convzx_SysScoreSummary.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.SchoolYear = objvzx_SysScoreSummaryEN.SchoolYear == "[null]" ? null :  objvzx_SysScoreSummaryEN.SchoolYear; //学年
}
if (arrFldSet.Contains(convzx_SysScoreSummary.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.UpdDate = objvzx_SysScoreSummaryEN.UpdDate == "[null]" ? null :  objvzx_SysScoreSummaryEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_SysScoreSummary.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.Memo = objvzx_SysScoreSummaryEN.Memo == "[null]" ? null :  objvzx_SysScoreSummaryEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_SysScoreSummary.zxScoreTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.zxScoreTypeId = objvzx_SysScoreSummaryEN.zxScoreTypeId == "[null]" ? null :  objvzx_SysScoreSummaryEN.zxScoreTypeId; //分数类型Id
}
if (arrFldSet.Contains(convzx_SysScoreSummary.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.UpdUser = objvzx_SysScoreSummaryEN.UpdUser == "[null]" ? null :  objvzx_SysScoreSummaryEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_SysScoreSummary.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.Score = objvzx_SysScoreSummaryEN.Score; //评分
}
if (arrFldSet.Contains(convzx_SysScoreSummary.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.IdCurrEduCls = objvzx_SysScoreSummaryEN.IdCurrEduCls == "[null]" ? null :  objvzx_SysScoreSummaryEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_SysScoreSummary.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.IsSubmit = objvzx_SysScoreSummaryEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_SysScoreSummary.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.UserName = objvzx_SysScoreSummaryEN.UserName == "[null]" ? null :  objvzx_SysScoreSummaryEN.UserName; //用户名
}
if (arrFldSet.Contains(convzx_SysScoreSummary.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.IdXzCollege = objvzx_SysScoreSummaryEN.IdXzCollege == "[null]" ? null :  objvzx_SysScoreSummaryEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convzx_SysScoreSummary.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.CollegeName = objvzx_SysScoreSummaryEN.CollegeName == "[null]" ? null :  objvzx_SysScoreSummaryEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convzx_SysScoreSummary.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.IdXzMajor = objvzx_SysScoreSummaryEN.IdXzMajor == "[null]" ? null :  objvzx_SysScoreSummaryEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convzx_SysScoreSummary.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.IdGradeBase = objvzx_SysScoreSummaryEN.IdGradeBase == "[null]" ? null :  objvzx_SysScoreSummaryEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convzx_SysScoreSummary.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.GradeBaseName = objvzx_SysScoreSummaryEN.GradeBaseName == "[null]" ? null :  objvzx_SysScoreSummaryEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convzx_SysScoreSummary.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SysScoreSummaryEN.MajorName = objvzx_SysScoreSummaryEN.MajorName == "[null]" ? null :  objvzx_SysScoreSummaryEN.MajorName; //专业名称
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
 /// <param name = "objvzx_SysScoreSummaryEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN)
{
try
{
if (objvzx_SysScoreSummaryEN.ScoreTypeName == "[null]") objvzx_SysScoreSummaryEN.ScoreTypeName = null; //分数类型名称
if (objvzx_SysScoreSummaryEN.OnlyId == "[null]") objvzx_SysScoreSummaryEN.OnlyId = null; //OnlyId
if (objvzx_SysScoreSummaryEN.EduClsName == "[null]") objvzx_SysScoreSummaryEN.EduClsName = null; //教学班名
if (objvzx_SysScoreSummaryEN.SchoolYear == "[null]") objvzx_SysScoreSummaryEN.SchoolYear = null; //学年
if (objvzx_SysScoreSummaryEN.UpdDate == "[null]") objvzx_SysScoreSummaryEN.UpdDate = null; //修改日期
if (objvzx_SysScoreSummaryEN.Memo == "[null]") objvzx_SysScoreSummaryEN.Memo = null; //备注
if (objvzx_SysScoreSummaryEN.zxScoreTypeId == "[null]") objvzx_SysScoreSummaryEN.zxScoreTypeId = null; //分数类型Id
if (objvzx_SysScoreSummaryEN.UpdUser == "[null]") objvzx_SysScoreSummaryEN.UpdUser = null; //修改人
if (objvzx_SysScoreSummaryEN.IdCurrEduCls == "[null]") objvzx_SysScoreSummaryEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_SysScoreSummaryEN.UserName == "[null]") objvzx_SysScoreSummaryEN.UserName = null; //用户名
if (objvzx_SysScoreSummaryEN.IdXzCollege == "[null]") objvzx_SysScoreSummaryEN.IdXzCollege = null; //学院流水号
if (objvzx_SysScoreSummaryEN.CollegeName == "[null]") objvzx_SysScoreSummaryEN.CollegeName = null; //学院名称
if (objvzx_SysScoreSummaryEN.IdXzMajor == "[null]") objvzx_SysScoreSummaryEN.IdXzMajor = null; //专业流水号
if (objvzx_SysScoreSummaryEN.IdGradeBase == "[null]") objvzx_SysScoreSummaryEN.IdGradeBase = null; //年级流水号
if (objvzx_SysScoreSummaryEN.GradeBaseName == "[null]") objvzx_SysScoreSummaryEN.GradeBaseName = null; //年级名称
if (objvzx_SysScoreSummaryEN.MajorName == "[null]") objvzx_SysScoreSummaryEN.MajorName = null; //专业名称
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
public static void CheckProperty4Condition(clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryEN)
{
 vzx_SysScoreSummaryDA.CheckProperty4Condition(objvzx_SysScoreSummaryEN);
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
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_SysScoreSummaryBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysScoreSummaryBL没有刷新缓存机制(clszx_SysScoreSummaryBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_SysScoreTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysScoreTypeBL没有刷新缓存机制(clszx_SysScoreTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvzx_SysScoreSummaryObjLstCache == null)
//{
//arrvzx_SysScoreSummaryObjLstCache = vzx_SysScoreSummaryDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SysScoreSummaryEN GetObjBymIdCache(long lngmId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_SysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_SysScoreSummaryEN> arrvzx_SysScoreSummaryObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SysScoreSummaryEN> arrvzx_SysScoreSummaryObjLst_Sel =
arrvzx_SysScoreSummaryObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvzx_SysScoreSummaryObjLst_Sel.Count() == 0)
{
   clsvzx_SysScoreSummaryEN obj = clsvzx_SysScoreSummaryBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_SysScoreSummaryObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SysScoreSummaryEN> GetAllvzx_SysScoreSummaryObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_SysScoreSummaryEN> arrvzx_SysScoreSummaryObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_SysScoreSummaryObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SysScoreSummaryEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_SysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_SysScoreSummaryEN> arrvzx_SysScoreSummaryObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_SysScoreSummaryObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_SysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strIdCurrEduCls)
{
if (strInFldName != convzx_SysScoreSummary.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_SysScoreSummary.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_SysScoreSummary.AttributeName));
throw new Exception(strMsg);
}
var objvzx_SysScoreSummary = clsvzx_SysScoreSummaryBL.GetObjBymIdCache(lngmId, strIdCurrEduCls);
if (objvzx_SysScoreSummary == null) return "";
return objvzx_SysScoreSummary[strOutFldName].ToString();
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
int intRecCount = clsvzx_SysScoreSummaryDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_SysScoreSummaryDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_SysScoreSummaryDA.GetRecCount();
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
int intRecCount = clsvzx_SysScoreSummaryDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_SysScoreSummaryCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_SysScoreSummaryEN objvzx_SysScoreSummaryCond)
{
 string strIdCurrEduCls = objvzx_SysScoreSummaryCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_SysScoreSummaryBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_SysScoreSummaryEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_SysScoreSummaryEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_SysScoreSummary.AttributeName)
{
if (objvzx_SysScoreSummaryCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SysScoreSummaryCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysScoreSummaryCond[strFldName].ToString());
}
else
{
if (objvzx_SysScoreSummaryCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SysScoreSummaryCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SysScoreSummaryCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SysScoreSummaryCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SysScoreSummaryCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SysScoreSummaryCond[strFldName]));
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
 List<string> arrList = clsvzx_SysScoreSummaryDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_SysScoreSummaryDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_SysScoreSummaryDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}