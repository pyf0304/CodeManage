
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysScoreSummaryBL
 表名:vSysScoreSummary(01120627)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:36
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
public static class  clsvSysScoreSummaryBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysScoreSummaryEN GetObj(this K_mId_vSysScoreSummary myKey)
{
clsvSysScoreSummaryEN objvSysScoreSummaryEN = clsvSysScoreSummaryBL.vSysScoreSummaryDA.GetObjBymId(myKey.Value);
return objvSysScoreSummaryEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetmId(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, long lngmId, string strComparisonOp="")
	{
objvSysScoreSummaryEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.mId) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.mId, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.mId] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetUserId(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convSysScoreSummary.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convSysScoreSummary.UserId);
}
objvSysScoreSummaryEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.UserId) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.UserId, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.UserId] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetSchoolYear(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convSysScoreSummary.SchoolYear);
}
objvSysScoreSummaryEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.SchoolYear) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.SchoolYear, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.SchoolYear] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetUpdDate(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSysScoreSummary.UpdDate);
}
objvSysScoreSummaryEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.UpdDate) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.UpdDate, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.UpdDate] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetMemo(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysScoreSummary.Memo);
}
objvSysScoreSummaryEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.Memo) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.Memo, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.Memo] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetUserName(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convSysScoreSummary.UserName);
}
objvSysScoreSummaryEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.UserName) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.UserName, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.UserName] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetIdXzCollege(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convSysScoreSummary.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convSysScoreSummary.IdXzCollege);
}
objvSysScoreSummaryEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.IdXzCollege) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.IdXzCollege, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.IdXzCollege] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetCollegeName(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convSysScoreSummary.CollegeName);
}
objvSysScoreSummaryEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.CollegeName) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.CollegeName, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.CollegeName] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetIdXzMajor(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convSysScoreSummary.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convSysScoreSummary.IdXzMajor);
}
objvSysScoreSummaryEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.IdXzMajor) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.IdXzMajor, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.IdXzMajor] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetMajorName(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convSysScoreSummary.MajorName);
}
objvSysScoreSummaryEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.MajorName) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.MajorName, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.MajorName] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetIdGradeBase(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convSysScoreSummary.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convSysScoreSummary.IdGradeBase);
}
objvSysScoreSummaryEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.IdGradeBase) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.IdGradeBase, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.IdGradeBase] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetGradeBaseName(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convSysScoreSummary.GradeBaseName);
}
objvSysScoreSummaryEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.GradeBaseName) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.GradeBaseName, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.GradeBaseName] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetOnlyId(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strOnlyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOnlyId, 20, convSysScoreSummary.OnlyId);
}
objvSysScoreSummaryEN.OnlyId = strOnlyId; //OnlyId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.OnlyId) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.OnlyId, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.OnlyId] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetScoreTypeId(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strScoreTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeId, 4, convSysScoreSummary.ScoreTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreTypeId, 4, convSysScoreSummary.ScoreTypeId);
}
objvSysScoreSummaryEN.ScoreTypeId = strScoreTypeId; //分数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.ScoreTypeId) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.ScoreTypeId, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.ScoreTypeId] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetScoreTypeName(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strScoreTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeName, 10, convSysScoreSummary.ScoreTypeName);
}
objvSysScoreSummaryEN.ScoreTypeName = strScoreTypeName; //分数类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.ScoreTypeName) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.ScoreTypeName, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.ScoreTypeName] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetUpdUser(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convSysScoreSummary.UpdUser);
}
objvSysScoreSummaryEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.UpdUser) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.UpdUser, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.UpdUser] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetScore(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, float? fltScore, string strComparisonOp="")
	{
objvSysScoreSummaryEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.Score) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.Score, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.Score] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetIdCurrEduCls(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convSysScoreSummary.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convSysScoreSummary.IdCurrEduCls);
}
objvSysScoreSummaryEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.IdCurrEduCls) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.IdCurrEduCls, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.IdCurrEduCls] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetEduClsName(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, string strEduClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convSysScoreSummary.EduClsName);
}
objvSysScoreSummaryEN.EduClsName = strEduClsName; //教学班名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.EduClsName) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.EduClsName, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.EduClsName] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysScoreSummaryEN SetIsSubmit(this clsvSysScoreSummaryEN objvSysScoreSummaryEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvSysScoreSummaryEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysScoreSummaryEN.dicFldComparisonOp.ContainsKey(convSysScoreSummary.IsSubmit) == false)
{
objvSysScoreSummaryEN.dicFldComparisonOp.Add(convSysScoreSummary.IsSubmit, strComparisonOp);
}
else
{
objvSysScoreSummaryEN.dicFldComparisonOp[convSysScoreSummary.IsSubmit] = strComparisonOp;
}
}
return objvSysScoreSummaryEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSysScoreSummaryENS">源对象</param>
 /// <param name = "objvSysScoreSummaryENT">目标对象</param>
 public static void CopyTo(this clsvSysScoreSummaryEN objvSysScoreSummaryENS, clsvSysScoreSummaryEN objvSysScoreSummaryENT)
{
try
{
objvSysScoreSummaryENT.mId = objvSysScoreSummaryENS.mId; //mId
objvSysScoreSummaryENT.UserId = objvSysScoreSummaryENS.UserId; //用户ID
objvSysScoreSummaryENT.SchoolYear = objvSysScoreSummaryENS.SchoolYear; //学年
objvSysScoreSummaryENT.UpdDate = objvSysScoreSummaryENS.UpdDate; //修改日期
objvSysScoreSummaryENT.Memo = objvSysScoreSummaryENS.Memo; //备注
objvSysScoreSummaryENT.UserName = objvSysScoreSummaryENS.UserName; //用户名
objvSysScoreSummaryENT.IdXzCollege = objvSysScoreSummaryENS.IdXzCollege; //学院流水号
objvSysScoreSummaryENT.CollegeName = objvSysScoreSummaryENS.CollegeName; //学院名称
objvSysScoreSummaryENT.IdXzMajor = objvSysScoreSummaryENS.IdXzMajor; //专业流水号
objvSysScoreSummaryENT.MajorName = objvSysScoreSummaryENS.MajorName; //专业名称
objvSysScoreSummaryENT.IdGradeBase = objvSysScoreSummaryENS.IdGradeBase; //年级流水号
objvSysScoreSummaryENT.GradeBaseName = objvSysScoreSummaryENS.GradeBaseName; //年级名称
objvSysScoreSummaryENT.OnlyId = objvSysScoreSummaryENS.OnlyId; //OnlyId
objvSysScoreSummaryENT.ScoreTypeId = objvSysScoreSummaryENS.ScoreTypeId; //分数类型Id
objvSysScoreSummaryENT.ScoreTypeName = objvSysScoreSummaryENS.ScoreTypeName; //分数类型名称
objvSysScoreSummaryENT.UpdUser = objvSysScoreSummaryENS.UpdUser; //修改人
objvSysScoreSummaryENT.Score = objvSysScoreSummaryENS.Score; //评分
objvSysScoreSummaryENT.IdCurrEduCls = objvSysScoreSummaryENS.IdCurrEduCls; //教学班流水号
objvSysScoreSummaryENT.EduClsName = objvSysScoreSummaryENS.EduClsName; //教学班名
objvSysScoreSummaryENT.IsSubmit = objvSysScoreSummaryENS.IsSubmit; //是否提交
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
 /// <param name = "objvSysScoreSummaryENS">源对象</param>
 /// <returns>目标对象=>clsvSysScoreSummaryEN:objvSysScoreSummaryENT</returns>
 public static clsvSysScoreSummaryEN CopyTo(this clsvSysScoreSummaryEN objvSysScoreSummaryENS)
{
try
{
 clsvSysScoreSummaryEN objvSysScoreSummaryENT = new clsvSysScoreSummaryEN()
{
mId = objvSysScoreSummaryENS.mId, //mId
UserId = objvSysScoreSummaryENS.UserId, //用户ID
SchoolYear = objvSysScoreSummaryENS.SchoolYear, //学年
UpdDate = objvSysScoreSummaryENS.UpdDate, //修改日期
Memo = objvSysScoreSummaryENS.Memo, //备注
UserName = objvSysScoreSummaryENS.UserName, //用户名
IdXzCollege = objvSysScoreSummaryENS.IdXzCollege, //学院流水号
CollegeName = objvSysScoreSummaryENS.CollegeName, //学院名称
IdXzMajor = objvSysScoreSummaryENS.IdXzMajor, //专业流水号
MajorName = objvSysScoreSummaryENS.MajorName, //专业名称
IdGradeBase = objvSysScoreSummaryENS.IdGradeBase, //年级流水号
GradeBaseName = objvSysScoreSummaryENS.GradeBaseName, //年级名称
OnlyId = objvSysScoreSummaryENS.OnlyId, //OnlyId
ScoreTypeId = objvSysScoreSummaryENS.ScoreTypeId, //分数类型Id
ScoreTypeName = objvSysScoreSummaryENS.ScoreTypeName, //分数类型名称
UpdUser = objvSysScoreSummaryENS.UpdUser, //修改人
Score = objvSysScoreSummaryENS.Score, //评分
IdCurrEduCls = objvSysScoreSummaryENS.IdCurrEduCls, //教学班流水号
EduClsName = objvSysScoreSummaryENS.EduClsName, //教学班名
IsSubmit = objvSysScoreSummaryENS.IsSubmit, //是否提交
};
 return objvSysScoreSummaryENT;
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
public static void CheckProperty4Condition(this clsvSysScoreSummaryEN objvSysScoreSummaryEN)
{
 clsvSysScoreSummaryBL.vSysScoreSummaryDA.CheckProperty4Condition(objvSysScoreSummaryEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysScoreSummaryEN objvSysScoreSummaryCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.mId) == true)
{
string strComparisonOpmId = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convSysScoreSummary.mId, objvSysScoreSummaryCond.mId, strComparisonOpmId);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.UserId) == true)
{
string strComparisonOpUserId = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.UserId, objvSysScoreSummaryCond.UserId, strComparisonOpUserId);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.SchoolYear, objvSysScoreSummaryCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.UpdDate, objvSysScoreSummaryCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.Memo) == true)
{
string strComparisonOpMemo = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.Memo, objvSysScoreSummaryCond.Memo, strComparisonOpMemo);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.UserName) == true)
{
string strComparisonOpUserName = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.UserName, objvSysScoreSummaryCond.UserName, strComparisonOpUserName);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.IdXzCollege, objvSysScoreSummaryCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.CollegeName) == true)
{
string strComparisonOpCollegeName = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.CollegeName, objvSysScoreSummaryCond.CollegeName, strComparisonOpCollegeName);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.IdXzMajor, objvSysScoreSummaryCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.MajorName) == true)
{
string strComparisonOpMajorName = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.MajorName, objvSysScoreSummaryCond.MajorName, strComparisonOpMajorName);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.IdGradeBase, objvSysScoreSummaryCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.GradeBaseName, objvSysScoreSummaryCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.OnlyId) == true)
{
string strComparisonOpOnlyId = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.OnlyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.OnlyId, objvSysScoreSummaryCond.OnlyId, strComparisonOpOnlyId);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.ScoreTypeId) == true)
{
string strComparisonOpScoreTypeId = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.ScoreTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.ScoreTypeId, objvSysScoreSummaryCond.ScoreTypeId, strComparisonOpScoreTypeId);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.ScoreTypeName) == true)
{
string strComparisonOpScoreTypeName = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.ScoreTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.ScoreTypeName, objvSysScoreSummaryCond.ScoreTypeName, strComparisonOpScoreTypeName);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.UpdUser) == true)
{
string strComparisonOpUpdUser = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.UpdUser, objvSysScoreSummaryCond.UpdUser, strComparisonOpUpdUser);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.Score) == true)
{
string strComparisonOpScore = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convSysScoreSummary.Score, objvSysScoreSummaryCond.Score, strComparisonOpScore);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.IdCurrEduCls, objvSysScoreSummaryCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.EduClsName) == true)
{
string strComparisonOpEduClsName = objvSysScoreSummaryCond.dicFldComparisonOp[convSysScoreSummary.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysScoreSummary.EduClsName, objvSysScoreSummaryCond.EduClsName, strComparisonOpEduClsName);
}
if (objvSysScoreSummaryCond.IsUpdated(convSysScoreSummary.IsSubmit) == true)
{
if (objvSysScoreSummaryCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSysScoreSummary.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSysScoreSummary.IsSubmit);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSysScoreSummary
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v分数汇总视图(vSysScoreSummary)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSysScoreSummaryBL
{
public static RelatedActions_vSysScoreSummary relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSysScoreSummaryDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSysScoreSummaryDA vSysScoreSummaryDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSysScoreSummaryDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSysScoreSummaryBL()
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
if (string.IsNullOrEmpty(clsvSysScoreSummaryEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysScoreSummaryEN._ConnectString);
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
public static DataTable GetDataTable_vSysScoreSummary(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSysScoreSummaryDA.GetDataTable_vSysScoreSummary(strWhereCond);
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
objDT = vSysScoreSummaryDA.GetDataTable(strWhereCond);
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
objDT = vSysScoreSummaryDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSysScoreSummaryDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSysScoreSummaryDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSysScoreSummaryDA.GetDataTable_Top(objTopPara);
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
objDT = vSysScoreSummaryDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSysScoreSummaryDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSysScoreSummaryDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvSysScoreSummaryEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
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
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSysScoreSummaryEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
List<clsvSysScoreSummaryEN> arrvSysScoreSummaryObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysScoreSummaryEN> arrvSysScoreSummaryObjLst_Sel =
arrvSysScoreSummaryObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvSysScoreSummaryObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysScoreSummaryEN> GetObjLst(string strWhereCond)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
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
public static List<clsvSysScoreSummaryEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSysScoreSummaryCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSysScoreSummaryEN> GetSubObjLstCache(clsvSysScoreSummaryEN objvSysScoreSummaryCond)
{
 string strIdCurrEduCls = objvSysScoreSummaryCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvSysScoreSummaryBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvSysScoreSummaryEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysScoreSummaryEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysScoreSummary.AttributeName)
{
if (objvSysScoreSummaryCond.IsUpdated(strFldName) == false) continue;
if (objvSysScoreSummaryCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysScoreSummaryCond[strFldName].ToString());
}
else
{
if (objvSysScoreSummaryCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysScoreSummaryCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysScoreSummaryCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysScoreSummaryCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysScoreSummaryCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysScoreSummaryCond[strFldName]));
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
public static List<clsvSysScoreSummaryEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
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
public static List<clsvSysScoreSummaryEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
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
List<clsvSysScoreSummaryEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSysScoreSummaryEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysScoreSummaryEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSysScoreSummaryEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
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
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
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
public static List<clsvSysScoreSummaryEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSysScoreSummaryEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSysScoreSummaryEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
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
public static List<clsvSysScoreSummaryEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysScoreSummaryEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysScoreSummaryEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysScoreSummaryEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSysScoreSummary(ref clsvSysScoreSummaryEN objvSysScoreSummaryEN)
{
bool bolResult = vSysScoreSummaryDA.GetvSysScoreSummary(ref objvSysScoreSummaryEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysScoreSummaryEN GetObjBymId(long lngmId)
{
clsvSysScoreSummaryEN objvSysScoreSummaryEN = vSysScoreSummaryDA.GetObjBymId(lngmId);
return objvSysScoreSummaryEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSysScoreSummaryEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSysScoreSummaryEN objvSysScoreSummaryEN = vSysScoreSummaryDA.GetFirstObj(strWhereCond);
 return objvSysScoreSummaryEN;
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
public static clsvSysScoreSummaryEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSysScoreSummaryEN objvSysScoreSummaryEN = vSysScoreSummaryDA.GetObjByDataRow(objRow);
 return objvSysScoreSummaryEN;
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
public static clsvSysScoreSummaryEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSysScoreSummaryEN objvSysScoreSummaryEN = vSysScoreSummaryDA.GetObjByDataRow(objRow);
 return objvSysScoreSummaryEN;
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
 /// <param name = "lstvSysScoreSummaryObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysScoreSummaryEN GetObjBymIdFromList(long lngmId, List<clsvSysScoreSummaryEN> lstvSysScoreSummaryObjLst)
{
foreach (clsvSysScoreSummaryEN objvSysScoreSummaryEN in lstvSysScoreSummaryObjLst)
{
if (objvSysScoreSummaryEN.mId == lngmId)
{
return objvSysScoreSummaryEN;
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
 lngmId = new clsvSysScoreSummaryDA().GetFirstID(strWhereCond);
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
 arrList = vSysScoreSummaryDA.GetID(strWhereCond);
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
bool bolIsExist = vSysScoreSummaryDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vSysScoreSummaryDA.IsExist(lngmId);
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
 bolIsExist = clsvSysScoreSummaryDA.IsExistTable();
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
 bolIsExist = vSysScoreSummaryDA.IsExistTable(strTabName);
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
 /// <param name = "objvSysScoreSummaryENS">源对象</param>
 /// <param name = "objvSysScoreSummaryENT">目标对象</param>
 public static void CopyTo(clsvSysScoreSummaryEN objvSysScoreSummaryENS, clsvSysScoreSummaryEN objvSysScoreSummaryENT)
{
try
{
objvSysScoreSummaryENT.mId = objvSysScoreSummaryENS.mId; //mId
objvSysScoreSummaryENT.UserId = objvSysScoreSummaryENS.UserId; //用户ID
objvSysScoreSummaryENT.SchoolYear = objvSysScoreSummaryENS.SchoolYear; //学年
objvSysScoreSummaryENT.UpdDate = objvSysScoreSummaryENS.UpdDate; //修改日期
objvSysScoreSummaryENT.Memo = objvSysScoreSummaryENS.Memo; //备注
objvSysScoreSummaryENT.UserName = objvSysScoreSummaryENS.UserName; //用户名
objvSysScoreSummaryENT.IdXzCollege = objvSysScoreSummaryENS.IdXzCollege; //学院流水号
objvSysScoreSummaryENT.CollegeName = objvSysScoreSummaryENS.CollegeName; //学院名称
objvSysScoreSummaryENT.IdXzMajor = objvSysScoreSummaryENS.IdXzMajor; //专业流水号
objvSysScoreSummaryENT.MajorName = objvSysScoreSummaryENS.MajorName; //专业名称
objvSysScoreSummaryENT.IdGradeBase = objvSysScoreSummaryENS.IdGradeBase; //年级流水号
objvSysScoreSummaryENT.GradeBaseName = objvSysScoreSummaryENS.GradeBaseName; //年级名称
objvSysScoreSummaryENT.OnlyId = objvSysScoreSummaryENS.OnlyId; //OnlyId
objvSysScoreSummaryENT.ScoreTypeId = objvSysScoreSummaryENS.ScoreTypeId; //分数类型Id
objvSysScoreSummaryENT.ScoreTypeName = objvSysScoreSummaryENS.ScoreTypeName; //分数类型名称
objvSysScoreSummaryENT.UpdUser = objvSysScoreSummaryENS.UpdUser; //修改人
objvSysScoreSummaryENT.Score = objvSysScoreSummaryENS.Score; //评分
objvSysScoreSummaryENT.IdCurrEduCls = objvSysScoreSummaryENS.IdCurrEduCls; //教学班流水号
objvSysScoreSummaryENT.EduClsName = objvSysScoreSummaryENS.EduClsName; //教学班名
objvSysScoreSummaryENT.IsSubmit = objvSysScoreSummaryENS.IsSubmit; //是否提交
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
 /// <param name = "objvSysScoreSummaryEN">源简化对象</param>
 public static void SetUpdFlag(clsvSysScoreSummaryEN objvSysScoreSummaryEN)
{
try
{
objvSysScoreSummaryEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSysScoreSummaryEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSysScoreSummary.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.mId = objvSysScoreSummaryEN.mId; //mId
}
if (arrFldSet.Contains(convSysScoreSummary.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.UserId = objvSysScoreSummaryEN.UserId; //用户ID
}
if (arrFldSet.Contains(convSysScoreSummary.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.SchoolYear = objvSysScoreSummaryEN.SchoolYear == "[null]" ? null :  objvSysScoreSummaryEN.SchoolYear; //学年
}
if (arrFldSet.Contains(convSysScoreSummary.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.UpdDate = objvSysScoreSummaryEN.UpdDate == "[null]" ? null :  objvSysScoreSummaryEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSysScoreSummary.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.Memo = objvSysScoreSummaryEN.Memo == "[null]" ? null :  objvSysScoreSummaryEN.Memo; //备注
}
if (arrFldSet.Contains(convSysScoreSummary.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.UserName = objvSysScoreSummaryEN.UserName == "[null]" ? null :  objvSysScoreSummaryEN.UserName; //用户名
}
if (arrFldSet.Contains(convSysScoreSummary.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.IdXzCollege = objvSysScoreSummaryEN.IdXzCollege == "[null]" ? null :  objvSysScoreSummaryEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convSysScoreSummary.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.CollegeName = objvSysScoreSummaryEN.CollegeName == "[null]" ? null :  objvSysScoreSummaryEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convSysScoreSummary.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.IdXzMajor = objvSysScoreSummaryEN.IdXzMajor == "[null]" ? null :  objvSysScoreSummaryEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convSysScoreSummary.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.MajorName = objvSysScoreSummaryEN.MajorName == "[null]" ? null :  objvSysScoreSummaryEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convSysScoreSummary.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.IdGradeBase = objvSysScoreSummaryEN.IdGradeBase == "[null]" ? null :  objvSysScoreSummaryEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convSysScoreSummary.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.GradeBaseName = objvSysScoreSummaryEN.GradeBaseName == "[null]" ? null :  objvSysScoreSummaryEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convSysScoreSummary.OnlyId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.OnlyId = objvSysScoreSummaryEN.OnlyId == "[null]" ? null :  objvSysScoreSummaryEN.OnlyId; //OnlyId
}
if (arrFldSet.Contains(convSysScoreSummary.ScoreTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.ScoreTypeId = objvSysScoreSummaryEN.ScoreTypeId == "[null]" ? null :  objvSysScoreSummaryEN.ScoreTypeId; //分数类型Id
}
if (arrFldSet.Contains(convSysScoreSummary.ScoreTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.ScoreTypeName = objvSysScoreSummaryEN.ScoreTypeName == "[null]" ? null :  objvSysScoreSummaryEN.ScoreTypeName; //分数类型名称
}
if (arrFldSet.Contains(convSysScoreSummary.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.UpdUser = objvSysScoreSummaryEN.UpdUser == "[null]" ? null :  objvSysScoreSummaryEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convSysScoreSummary.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.Score = objvSysScoreSummaryEN.Score; //评分
}
if (arrFldSet.Contains(convSysScoreSummary.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.IdCurrEduCls = objvSysScoreSummaryEN.IdCurrEduCls == "[null]" ? null :  objvSysScoreSummaryEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convSysScoreSummary.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.EduClsName = objvSysScoreSummaryEN.EduClsName == "[null]" ? null :  objvSysScoreSummaryEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convSysScoreSummary.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysScoreSummaryEN.IsSubmit = objvSysScoreSummaryEN.IsSubmit; //是否提交
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
 /// <param name = "objvSysScoreSummaryEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSysScoreSummaryEN objvSysScoreSummaryEN)
{
try
{
if (objvSysScoreSummaryEN.SchoolYear == "[null]") objvSysScoreSummaryEN.SchoolYear = null; //学年
if (objvSysScoreSummaryEN.UpdDate == "[null]") objvSysScoreSummaryEN.UpdDate = null; //修改日期
if (objvSysScoreSummaryEN.Memo == "[null]") objvSysScoreSummaryEN.Memo = null; //备注
if (objvSysScoreSummaryEN.UserName == "[null]") objvSysScoreSummaryEN.UserName = null; //用户名
if (objvSysScoreSummaryEN.IdXzCollege == "[null]") objvSysScoreSummaryEN.IdXzCollege = null; //学院流水号
if (objvSysScoreSummaryEN.CollegeName == "[null]") objvSysScoreSummaryEN.CollegeName = null; //学院名称
if (objvSysScoreSummaryEN.IdXzMajor == "[null]") objvSysScoreSummaryEN.IdXzMajor = null; //专业流水号
if (objvSysScoreSummaryEN.MajorName == "[null]") objvSysScoreSummaryEN.MajorName = null; //专业名称
if (objvSysScoreSummaryEN.IdGradeBase == "[null]") objvSysScoreSummaryEN.IdGradeBase = null; //年级流水号
if (objvSysScoreSummaryEN.GradeBaseName == "[null]") objvSysScoreSummaryEN.GradeBaseName = null; //年级名称
if (objvSysScoreSummaryEN.OnlyId == "[null]") objvSysScoreSummaryEN.OnlyId = null; //OnlyId
if (objvSysScoreSummaryEN.ScoreTypeId == "[null]") objvSysScoreSummaryEN.ScoreTypeId = null; //分数类型Id
if (objvSysScoreSummaryEN.ScoreTypeName == "[null]") objvSysScoreSummaryEN.ScoreTypeName = null; //分数类型名称
if (objvSysScoreSummaryEN.UpdUser == "[null]") objvSysScoreSummaryEN.UpdUser = null; //修改人
if (objvSysScoreSummaryEN.IdCurrEduCls == "[null]") objvSysScoreSummaryEN.IdCurrEduCls = null; //教学班流水号
if (objvSysScoreSummaryEN.EduClsName == "[null]") objvSysScoreSummaryEN.EduClsName = null; //教学班名
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
public static void CheckProperty4Condition(clsvSysScoreSummaryEN objvSysScoreSummaryEN)
{
 vSysScoreSummaryDA.CheckProperty4Condition(objvSysScoreSummaryEN);
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
if (clsSysScoreSummaryBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysScoreSummaryBL没有刷新缓存机制(clsSysScoreSummaryBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysScoreTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysScoreTypeBL没有刷新缓存机制(clsSysScoreTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvSysScoreSummaryObjLstCache == null)
//{
//arrvSysScoreSummaryObjLstCache = vSysScoreSummaryDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysScoreSummaryEN GetObjBymIdCache(long lngmId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
List<clsvSysScoreSummaryEN> arrvSysScoreSummaryObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysScoreSummaryEN> arrvSysScoreSummaryObjLst_Sel =
arrvSysScoreSummaryObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvSysScoreSummaryObjLst_Sel.Count() == 0)
{
   clsvSysScoreSummaryEN obj = clsvSysScoreSummaryBL.GetObjBymId(lngmId);
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
return arrvSysScoreSummaryObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysScoreSummaryEN> GetAllvSysScoreSummaryObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvSysScoreSummaryEN> arrvSysScoreSummaryObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvSysScoreSummaryObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysScoreSummaryEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvSysScoreSummaryEN> arrvSysScoreSummaryObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvSysScoreSummaryObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strIdCurrEduCls);
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
if (strInFldName != convSysScoreSummary.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSysScoreSummary.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSysScoreSummary.AttributeName));
throw new Exception(strMsg);
}
var objvSysScoreSummary = clsvSysScoreSummaryBL.GetObjBymIdCache(lngmId, strIdCurrEduCls);
if (objvSysScoreSummary == null) return "";
return objvSysScoreSummary[strOutFldName].ToString();
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
int intRecCount = clsvSysScoreSummaryDA.GetRecCount(strTabName);
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
int intRecCount = clsvSysScoreSummaryDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSysScoreSummaryDA.GetRecCount();
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
int intRecCount = clsvSysScoreSummaryDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSysScoreSummaryCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSysScoreSummaryEN objvSysScoreSummaryCond)
{
 string strIdCurrEduCls = objvSysScoreSummaryCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvSysScoreSummaryBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvSysScoreSummaryEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvSysScoreSummaryEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysScoreSummary.AttributeName)
{
if (objvSysScoreSummaryCond.IsUpdated(strFldName) == false) continue;
if (objvSysScoreSummaryCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysScoreSummaryCond[strFldName].ToString());
}
else
{
if (objvSysScoreSummaryCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysScoreSummaryCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysScoreSummaryCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysScoreSummaryCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysScoreSummaryCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysScoreSummaryCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysScoreSummaryCond[strFldName]));
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
 List<string> arrList = clsvSysScoreSummaryDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSysScoreSummaryDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSysScoreSummaryDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}