
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseQuantitySenateBL
 表名:vPubClassCaseQuantitySenate(01120414)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsvPubClassCaseQuantitySenateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdpubClassCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseQuantitySenateEN GetObj(this K_IdpubClassCaseQuantitySenate_vPubClassCaseQuantitySenate myKey)
{
clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = clsvPubClassCaseQuantitySenateBL.vPubClassCaseQuantitySenateDA.GetObjByIdpubClassCaseQuantitySenate(myKey.Value);
return objvPubClassCaseQuantitySenateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetIdpubClassCaseQuantitySenate(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, long lngIdpubClassCaseQuantitySenate, string strComparisonOp="")
	{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = lngIdpubClassCaseQuantitySenate; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetIdPubClassCase(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strIdPubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCase, convPubClassCaseQuantitySenate.IdPubClassCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, convPubClassCaseQuantitySenate.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, convPubClassCaseQuantitySenate.IdPubClassCase);
}
objvPubClassCaseQuantitySenateEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.IdPubClassCase) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.IdPubClassCase, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdPubClassCase] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetPubClassCaseID(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strPubClassCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCaseQuantitySenate.PubClassCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCaseQuantitySenate.PubClassCaseID);
}
objvPubClassCaseQuantitySenateEN.PubClassCaseID = strPubClassCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.PubClassCaseID) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.PubClassCaseID, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseID] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetPubClassCaseName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strPubClassCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCaseQuantitySenate.PubClassCaseName);
}
objvPubClassCaseQuantitySenateEN.PubClassCaseName = strPubClassCaseName; //案例课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.PubClassCaseName) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.PubClassCaseName, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseName] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetIdsenateGauge(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strIdsenateGauge, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdsenateGauge, convPubClassCaseQuantitySenate.IdsenateGauge);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdsenateGauge, 4, convPubClassCaseQuantitySenate.IdsenateGauge);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdsenateGauge, 4, convPubClassCaseQuantitySenate.IdsenateGauge);
}
objvPubClassCaseQuantitySenateEN.IdsenateGauge = strIdsenateGauge; //评价量规流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.IdsenateGauge) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.IdsenateGauge, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdsenateGauge] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeID(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeID, 4, convPubClassCaseQuantitySenate.senateGaugeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeID, 4, convPubClassCaseQuantitySenate.senateGaugeID);
}
objvPubClassCaseQuantitySenateEN.senateGaugeID = strsenateGaugeID; //评价量规ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.senateGaugeID) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.senateGaugeID, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeID] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeName, 200, convPubClassCaseQuantitySenate.senateGaugeName);
}
objvPubClassCaseQuantitySenateEN.senateGaugeName = strsenateGaugeName; //评价量规名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.senateGaugeName) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.senateGaugeName, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeName] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetpubClassCaseQuantitySenateScore(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, int intpubClassCaseQuantitySenateScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intpubClassCaseQuantitySenateScore, convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore);
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = intpubClassCaseQuantitySenateScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetUserId(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convPubClassCaseQuantitySenate.UserId);
}
objvPubClassCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.UserId) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetUserName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convPubClassCaseQuantitySenate.UserName);
}
objvPubClassCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.UserName) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetOptDate(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strOptDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptDate, 20, convPubClassCaseQuantitySenate.OptDate);
}
objvPubClassCaseQuantitySenateEN.OptDate = strOptDate; //OptDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.OptDate) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.OptDate, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.OptDate] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetCollegeID(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convPubClassCaseQuantitySenate.CollegeID);
}
objvPubClassCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.CollegeID) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetCollegeName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convPubClassCaseQuantitySenate.CollegeName);
}
objvPubClassCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.CollegeName) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetIdXzCollege(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convPubClassCaseQuantitySenate.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convPubClassCaseQuantitySenate.IdXzCollege);
}
objvPubClassCaseQuantitySenateEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.IdXzCollege) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.IdXzCollege, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdXzCollege] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetIsLeaved(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvPubClassCaseQuantitySenateEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.IsLeaved) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.IsLeaved, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.IsLeaved] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convPubClassCaseQuantitySenate.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convPubClassCaseQuantitySenate.senateGaugeVersionID);
}
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convPubClassCaseQuantitySenate.senateGaugeVersionName);
}
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetStuIdTeacherId(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strStuIdTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convPubClassCaseQuantitySenate.StuIdTeacherId);
}
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = strStuIdTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.StuIdTeacherId) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.StuIdTeacherId, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.StuIdTeacherId] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetIdPubClassCaseSenateGaugeVersion(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strIdPubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCaseSenateGaugeVersion, 4, convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCaseSenateGaugeVersion, 4, convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion);
}
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeMemo(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeMemo, 1000, convPubClassCaseQuantitySenate.senateGaugeMemo);
}
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = strsenateGaugeMemo; //评价量规指标与说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.senateGaugeMemo) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.senateGaugeMemo, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeMemo] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetSenateGaugeWeight(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, float? fltSenateGaugeWeight, string strComparisonOp="")
	{
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = fltSenateGaugeWeight; //评价量规权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.SenateGaugeWeight) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.SenateGaugeWeight, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.SenateGaugeWeight] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetOrderNum(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, int? intOrderNum, string strComparisonOp="")
	{
objvPubClassCaseQuantitySenateEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.OrderNum) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.OrderNum, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.OrderNum] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeNameWithOrder(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeNameWithOrder, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeNameWithOrder, 204, convPubClassCaseQuantitySenate.senateGaugeNameWithOrder);
}
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = strsenateGaugeNameWithOrder; //senateGaugeNameWithOrder
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.senateGaugeNameWithOrder) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.senateGaugeNameWithOrder, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetPubClassCaseExecutor(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCaseQuantitySenate.PubClassCaseExecutor);
}
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = strPubClassCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.PubClassCaseExecutor) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.PubClassCaseExecutor, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseExecutor] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetPubClassCaseTeachDate(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubClassCaseQuantitySenate.PubClassCaseTeachDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubClassCaseQuantitySenate.PubClassCaseTeachDate);
}
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = strPubClassCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.PubClassCaseTeachDate) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.PubClassCaseTeachDate, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetUserNameWithUserId(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convPubClassCaseQuantitySenate.UserNameWithUserId);
}
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.UserNameWithUserId) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetCollegeNameA(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convPubClassCaseQuantitySenate.CollegeNameA);
}
objvPubClassCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.CollegeNameA) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvPubClassCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENS, clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENT)
{
try
{
objvPubClassCaseQuantitySenateENT.IdpubClassCaseQuantitySenate = objvPubClassCaseQuantitySenateENS.IdpubClassCaseQuantitySenate; //流水号
objvPubClassCaseQuantitySenateENT.IdPubClassCase = objvPubClassCaseQuantitySenateENS.IdPubClassCase; //案例流水号
objvPubClassCaseQuantitySenateENT.PubClassCaseID = objvPubClassCaseQuantitySenateENS.PubClassCaseID; //案例ID
objvPubClassCaseQuantitySenateENT.PubClassCaseName = objvPubClassCaseQuantitySenateENS.PubClassCaseName; //案例课题名称
objvPubClassCaseQuantitySenateENT.IdsenateGauge = objvPubClassCaseQuantitySenateENS.IdsenateGauge; //评价量规流水号
objvPubClassCaseQuantitySenateENT.senateGaugeID = objvPubClassCaseQuantitySenateENS.senateGaugeID; //评价量规ID
objvPubClassCaseQuantitySenateENT.senateGaugeName = objvPubClassCaseQuantitySenateENS.senateGaugeName; //评价量规名称
objvPubClassCaseQuantitySenateENT.pubClassCaseQuantitySenateScore = objvPubClassCaseQuantitySenateENS.pubClassCaseQuantitySenateScore; //评分
objvPubClassCaseQuantitySenateENT.UserId = objvPubClassCaseQuantitySenateENS.UserId; //用户ID
objvPubClassCaseQuantitySenateENT.UserName = objvPubClassCaseQuantitySenateENS.UserName; //用户名
objvPubClassCaseQuantitySenateENT.OptDate = objvPubClassCaseQuantitySenateENS.OptDate; //OptDate
objvPubClassCaseQuantitySenateENT.CollegeID = objvPubClassCaseQuantitySenateENS.CollegeID; //学院ID
objvPubClassCaseQuantitySenateENT.CollegeName = objvPubClassCaseQuantitySenateENS.CollegeName; //学院名称
objvPubClassCaseQuantitySenateENT.IdXzCollege = objvPubClassCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvPubClassCaseQuantitySenateENT.IsLeaved = objvPubClassCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvPubClassCaseQuantitySenateENT.senateGaugeVersionID = objvPubClassCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseQuantitySenateENT.senateGaugeVersionName = objvPubClassCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvPubClassCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseQuantitySenateENT.StuIdTeacherId = objvPubClassCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvPubClassCaseQuantitySenateENT.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseQuantitySenateENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseQuantitySenateENT.senateGaugeMemo = objvPubClassCaseQuantitySenateENS.senateGaugeMemo; //评价量规指标与说明
objvPubClassCaseQuantitySenateENT.SenateGaugeWeight = objvPubClassCaseQuantitySenateENS.SenateGaugeWeight; //评价量规权重
objvPubClassCaseQuantitySenateENT.OrderNum = objvPubClassCaseQuantitySenateENS.OrderNum; //序号
objvPubClassCaseQuantitySenateENT.senateGaugeNameWithOrder = objvPubClassCaseQuantitySenateENS.senateGaugeNameWithOrder; //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateENT.PubClassCaseExecutor = objvPubClassCaseQuantitySenateENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseQuantitySenateENT.PubClassCaseTeachDate = objvPubClassCaseQuantitySenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseQuantitySenateENT.UserNameWithUserId = objvPubClassCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvPubClassCaseQuantitySenateENT.CollegeNameA = objvPubClassCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvPubClassCaseQuantitySenateENS">源对象</param>
 /// <returns>目标对象=>clsvPubClassCaseQuantitySenateEN:objvPubClassCaseQuantitySenateENT</returns>
 public static clsvPubClassCaseQuantitySenateEN CopyTo(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENS)
{
try
{
 clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENT = new clsvPubClassCaseQuantitySenateEN()
{
IdpubClassCaseQuantitySenate = objvPubClassCaseQuantitySenateENS.IdpubClassCaseQuantitySenate, //流水号
IdPubClassCase = objvPubClassCaseQuantitySenateENS.IdPubClassCase, //案例流水号
PubClassCaseID = objvPubClassCaseQuantitySenateENS.PubClassCaseID, //案例ID
PubClassCaseName = objvPubClassCaseQuantitySenateENS.PubClassCaseName, //案例课题名称
IdsenateGauge = objvPubClassCaseQuantitySenateENS.IdsenateGauge, //评价量规流水号
senateGaugeID = objvPubClassCaseQuantitySenateENS.senateGaugeID, //评价量规ID
senateGaugeName = objvPubClassCaseQuantitySenateENS.senateGaugeName, //评价量规名称
pubClassCaseQuantitySenateScore = objvPubClassCaseQuantitySenateENS.pubClassCaseQuantitySenateScore, //评分
UserId = objvPubClassCaseQuantitySenateENS.UserId, //用户ID
UserName = objvPubClassCaseQuantitySenateENS.UserName, //用户名
OptDate = objvPubClassCaseQuantitySenateENS.OptDate, //OptDate
CollegeID = objvPubClassCaseQuantitySenateENS.CollegeID, //学院ID
CollegeName = objvPubClassCaseQuantitySenateENS.CollegeName, //学院名称
IdXzCollege = objvPubClassCaseQuantitySenateENS.IdXzCollege, //学院流水号
IsLeaved = objvPubClassCaseQuantitySenateENS.IsLeaved, //IsLeaved
senateGaugeVersionID = objvPubClassCaseQuantitySenateENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvPubClassCaseQuantitySenateENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvPubClassCaseQuantitySenateENS.senateGaugeVersionTtlScore, //评价量表版本总分
StuIdTeacherId = objvPubClassCaseQuantitySenateENS.StuIdTeacherId, //学工号
IdPubClassCaseSenateGaugeVersion = objvPubClassCaseQuantitySenateENS.IdPubClassCaseSenateGaugeVersion, //公开课量表版本流水号
senateGaugeMemo = objvPubClassCaseQuantitySenateENS.senateGaugeMemo, //评价量规指标与说明
SenateGaugeWeight = objvPubClassCaseQuantitySenateENS.SenateGaugeWeight, //评价量规权重
OrderNum = objvPubClassCaseQuantitySenateENS.OrderNum, //序号
senateGaugeNameWithOrder = objvPubClassCaseQuantitySenateENS.senateGaugeNameWithOrder, //senateGaugeNameWithOrder
PubClassCaseExecutor = objvPubClassCaseQuantitySenateENS.PubClassCaseExecutor, //案例执教者
PubClassCaseTeachDate = objvPubClassCaseQuantitySenateENS.PubClassCaseTeachDate, //案例授课日期
UserNameWithUserId = objvPubClassCaseQuantitySenateENS.UserNameWithUserId, //UserNameWithUserId
CollegeNameA = objvPubClassCaseQuantitySenateENS.CollegeNameA, //学院名称简写
};
 return objvPubClassCaseQuantitySenateENT;
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
public static void CheckProperty4Condition(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN)
{
 clsvPubClassCaseQuantitySenateBL.vPubClassCaseQuantitySenateDA.CheckProperty4Condition(objvPubClassCaseQuantitySenateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate) == true)
{
string strComparisonOpIdpubClassCaseQuantitySenate = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate, objvPubClassCaseQuantitySenateCond.IdpubClassCaseQuantitySenate, strComparisonOpIdpubClassCaseQuantitySenate);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.IdPubClassCase, objvPubClassCaseQuantitySenateCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.PubClassCaseID) == true)
{
string strComparisonOpPubClassCaseID = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.PubClassCaseID, objvPubClassCaseQuantitySenateCond.PubClassCaseID, strComparisonOpPubClassCaseID);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.PubClassCaseName) == true)
{
string strComparisonOpPubClassCaseName = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.PubClassCaseName, objvPubClassCaseQuantitySenateCond.PubClassCaseName, strComparisonOpPubClassCaseName);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.IdsenateGauge) == true)
{
string strComparisonOpIdsenateGauge = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdsenateGauge];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.IdsenateGauge, objvPubClassCaseQuantitySenateCond.IdsenateGauge, strComparisonOpIdsenateGauge);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeID) == true)
{
string strComparisonOpsenateGaugeID = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeID, objvPubClassCaseQuantitySenateCond.senateGaugeID, strComparisonOpsenateGaugeID);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeName) == true)
{
string strComparisonOpsenateGaugeName = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeName, objvPubClassCaseQuantitySenateCond.senateGaugeName, strComparisonOpsenateGaugeName);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore) == true)
{
string strComparisonOppubClassCaseQuantitySenateScore = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore, objvPubClassCaseQuantitySenateCond.pubClassCaseQuantitySenateScore, strComparisonOppubClassCaseQuantitySenateScore);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.UserId) == true)
{
string strComparisonOpUserId = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.UserId, objvPubClassCaseQuantitySenateCond.UserId, strComparisonOpUserId);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.UserName) == true)
{
string strComparisonOpUserName = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.UserName, objvPubClassCaseQuantitySenateCond.UserName, strComparisonOpUserName);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.OptDate) == true)
{
string strComparisonOpOptDate = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.OptDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.OptDate, objvPubClassCaseQuantitySenateCond.OptDate, strComparisonOpOptDate);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOpCollegeID = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.CollegeID, objvPubClassCaseQuantitySenateCond.CollegeID, strComparisonOpCollegeID);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOpCollegeName = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.CollegeName, objvPubClassCaseQuantitySenateCond.CollegeName, strComparisonOpCollegeName);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.IdXzCollege, objvPubClassCaseQuantitySenateCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.IsLeaved) == true)
{
if (objvPubClassCaseQuantitySenateCond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseQuantitySenate.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseQuantitySenate.IsLeaved);
}
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeVersionID, objvPubClassCaseQuantitySenateCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeVersionName, objvPubClassCaseQuantitySenateCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore, objvPubClassCaseQuantitySenateCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.StuIdTeacherId) == true)
{
string strComparisonOpStuIdTeacherId = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.StuIdTeacherId, objvPubClassCaseQuantitySenateCond.StuIdTeacherId, strComparisonOpStuIdTeacherId);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOpIdPubClassCaseSenateGaugeVersion = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion, objvPubClassCaseQuantitySenateCond.IdPubClassCaseSenateGaugeVersion, strComparisonOpIdPubClassCaseSenateGaugeVersion);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeMemo) == true)
{
string strComparisonOpsenateGaugeMemo = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeMemo, objvPubClassCaseQuantitySenateCond.senateGaugeMemo, strComparisonOpsenateGaugeMemo);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.SenateGaugeWeight) == true)
{
string strComparisonOpSenateGaugeWeight = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.SenateGaugeWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.SenateGaugeWeight, objvPubClassCaseQuantitySenateCond.SenateGaugeWeight, strComparisonOpSenateGaugeWeight);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.OrderNum) == true)
{
string strComparisonOpOrderNum = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.OrderNum, objvPubClassCaseQuantitySenateCond.OrderNum, strComparisonOpOrderNum);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeNameWithOrder) == true)
{
string strComparisonOpsenateGaugeNameWithOrder = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeNameWithOrder, objvPubClassCaseQuantitySenateCond.senateGaugeNameWithOrder, strComparisonOpsenateGaugeNameWithOrder);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.PubClassCaseExecutor) == true)
{
string strComparisonOpPubClassCaseExecutor = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.PubClassCaseExecutor, objvPubClassCaseQuantitySenateCond.PubClassCaseExecutor, strComparisonOpPubClassCaseExecutor);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.PubClassCaseTeachDate) == true)
{
string strComparisonOpPubClassCaseTeachDate = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.PubClassCaseTeachDate, objvPubClassCaseQuantitySenateCond.PubClassCaseTeachDate, strComparisonOpPubClassCaseTeachDate);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.UserNameWithUserId, objvPubClassCaseQuantitySenateCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
if (objvPubClassCaseQuantitySenateCond.IsUpdated(convPubClassCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[convPubClassCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.CollegeNameA, objvPubClassCaseQuantitySenateCond.CollegeNameA, strComparisonOpCollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPubClassCaseQuantitySenate
{
public virtual bool UpdRelaTabDate(long lngIdpubClassCaseQuantitySenate, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v公开课案例量化评价(vPubClassCaseQuantitySenate)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseQuantitySenateBL
{
public static RelatedActions_vPubClassCaseQuantitySenate relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPubClassCaseQuantitySenateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPubClassCaseQuantitySenateDA vPubClassCaseQuantitySenateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPubClassCaseQuantitySenateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPubClassCaseQuantitySenateBL()
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
if (string.IsNullOrEmpty(clsvPubClassCaseQuantitySenateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseQuantitySenateEN._ConnectString);
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
public static DataTable GetDataTable_vPubClassCaseQuantitySenate(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPubClassCaseQuantitySenateDA.GetDataTable_vPubClassCaseQuantitySenate(strWhereCond);
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
objDT = vPubClassCaseQuantitySenateDA.GetDataTable(strWhereCond);
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
objDT = vPubClassCaseQuantitySenateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPubClassCaseQuantitySenateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPubClassCaseQuantitySenateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPubClassCaseQuantitySenateDA.GetDataTable_Top(objTopPara);
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
objDT = vPubClassCaseQuantitySenateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPubClassCaseQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPubClassCaseQuantitySenateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdpubClassCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstByIdpubClassCaseQuantitySenateLst(List<long> arrIdpubClassCaseQuantitySenateLst)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdpubClassCaseQuantitySenateLst);
 string strWhereCond = string.Format("IdpubClassCaseQuantitySenate in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdpubClassCaseQuantitySenateLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPubClassCaseQuantitySenateEN> GetObjLstByIdpubClassCaseQuantitySenateLstCache(List<long> arrIdpubClassCaseQuantitySenateLst)
{
string strKey = string.Format("{0}", clsvPubClassCaseQuantitySenateEN._CurrTabName);
List<clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLst_Sel =
arrvPubClassCaseQuantitySenateObjLstCache
.Where(x => arrIdpubClassCaseQuantitySenateLst.Contains(x.IdpubClassCaseQuantitySenate));
return arrvPubClassCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
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
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPubClassCaseQuantitySenateEN> GetSubObjLstCache(clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateCond)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCaseQuantitySenate.AttributeName)
{
if (objvPubClassCaseQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseQuantitySenateCond[strFldName]));
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
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
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
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
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
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPubClassCaseQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
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
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
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
public static List<clsvPubClassCaseQuantitySenateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
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
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLst = new List<clsvPubClassCaseQuantitySenateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = new clsvPubClassCaseQuantitySenateEN();
try
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = Int32.Parse(objRow[convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate].ToString().Trim()); //流水号
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objRow[convPubClassCaseQuantitySenate.IdPubClassCase].ToString().Trim(); //案例流水号
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objRow[convPubClassCaseQuantitySenate.PubClassCaseID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseID].ToString().Trim(); //案例ID
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objRow[convPubClassCaseQuantitySenate.PubClassCaseName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objRow[convPubClassCaseQuantitySenate.IdsenateGauge].ToString().Trim(); //评价量规流水号
objvPubClassCaseQuantitySenateEN.senateGaugeID = objRow[convPubClassCaseQuantitySenate.senateGaugeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeID].ToString().Trim(); //评价量规ID
objvPubClassCaseQuantitySenateEN.senateGaugeName = objRow[convPubClassCaseQuantitySenate.senateGaugeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeName].ToString().Trim(); //评价量规名称
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = Int32.Parse(objRow[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore].ToString().Trim()); //评分
objvPubClassCaseQuantitySenateEN.UserId = objRow[convPubClassCaseQuantitySenate.UserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvPubClassCaseQuantitySenateEN.UserName = objRow[convPubClassCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvPubClassCaseQuantitySenateEN.OptDate = objRow[convPubClassCaseQuantitySenate.OptDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.OptDate].ToString().Trim(); //OptDate
objvPubClassCaseQuantitySenateEN.CollegeID = objRow[convPubClassCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvPubClassCaseQuantitySenateEN.CollegeName = objRow[convPubClassCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvPubClassCaseQuantitySenateEN.IdXzCollege = objRow[convPubClassCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvPubClassCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objRow[convPubClassCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objRow[convPubClassCaseQuantitySenate.senateGaugeMemo] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeMemo].ToString().Trim(); //评价量规指标与说明
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseQuantitySenate.SenateGaugeWeight].ToString().Trim()); //评价量规权重
objvPubClassCaseQuantitySenateEN.OrderNum = objRow[convPubClassCaseQuantitySenate.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseQuantitySenate.OrderNum].ToString().Trim()); //序号
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder].ToString().Trim(); //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objRow[convPubClassCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvPubClassCaseQuantitySenateEN.CollegeNameA = objRow[convPubClassCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convPubClassCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseQuantitySenateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPubClassCaseQuantitySenate(ref clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN)
{
bool bolResult = vPubClassCaseQuantitySenateDA.GetvPubClassCaseQuantitySenate(ref objvPubClassCaseQuantitySenateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdpubClassCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseQuantitySenateEN GetObjByIdpubClassCaseQuantitySenate(long lngIdpubClassCaseQuantitySenate)
{
clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = vPubClassCaseQuantitySenateDA.GetObjByIdpubClassCaseQuantitySenate(lngIdpubClassCaseQuantitySenate);
return objvPubClassCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPubClassCaseQuantitySenateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = vPubClassCaseQuantitySenateDA.GetFirstObj(strWhereCond);
 return objvPubClassCaseQuantitySenateEN;
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
public static clsvPubClassCaseQuantitySenateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = vPubClassCaseQuantitySenateDA.GetObjByDataRow(objRow);
 return objvPubClassCaseQuantitySenateEN;
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
public static clsvPubClassCaseQuantitySenateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = vPubClassCaseQuantitySenateDA.GetObjByDataRow(objRow);
 return objvPubClassCaseQuantitySenateEN;
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
 /// <param name = "lngIdpubClassCaseQuantitySenate">所给的关键字</param>
 /// <param name = "lstvPubClassCaseQuantitySenateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseQuantitySenateEN GetObjByIdpubClassCaseQuantitySenateFromList(long lngIdpubClassCaseQuantitySenate, List<clsvPubClassCaseQuantitySenateEN> lstvPubClassCaseQuantitySenateObjLst)
{
foreach (clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN in lstvPubClassCaseQuantitySenateObjLst)
{
if (objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate == lngIdpubClassCaseQuantitySenate)
{
return objvPubClassCaseQuantitySenateEN;
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
 long lngIdpubClassCaseQuantitySenate;
 try
 {
 lngIdpubClassCaseQuantitySenate = new clsvPubClassCaseQuantitySenateDA().GetFirstID(strWhereCond);
 return lngIdpubClassCaseQuantitySenate;
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
 arrList = vPubClassCaseQuantitySenateDA.GetID(strWhereCond);
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
bool bolIsExist = vPubClassCaseQuantitySenateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdpubClassCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdpubClassCaseQuantitySenate)
{
//检测记录是否存在
bool bolIsExist = vPubClassCaseQuantitySenateDA.IsExist(lngIdpubClassCaseQuantitySenate);
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
 bolIsExist = clsvPubClassCaseQuantitySenateDA.IsExistTable();
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
 bolIsExist = vPubClassCaseQuantitySenateDA.IsExistTable(strTabName);
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
 /// <param name = "objvPubClassCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvPubClassCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENS, clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENT)
{
try
{
objvPubClassCaseQuantitySenateENT.IdpubClassCaseQuantitySenate = objvPubClassCaseQuantitySenateENS.IdpubClassCaseQuantitySenate; //流水号
objvPubClassCaseQuantitySenateENT.IdPubClassCase = objvPubClassCaseQuantitySenateENS.IdPubClassCase; //案例流水号
objvPubClassCaseQuantitySenateENT.PubClassCaseID = objvPubClassCaseQuantitySenateENS.PubClassCaseID; //案例ID
objvPubClassCaseQuantitySenateENT.PubClassCaseName = objvPubClassCaseQuantitySenateENS.PubClassCaseName; //案例课题名称
objvPubClassCaseQuantitySenateENT.IdsenateGauge = objvPubClassCaseQuantitySenateENS.IdsenateGauge; //评价量规流水号
objvPubClassCaseQuantitySenateENT.senateGaugeID = objvPubClassCaseQuantitySenateENS.senateGaugeID; //评价量规ID
objvPubClassCaseQuantitySenateENT.senateGaugeName = objvPubClassCaseQuantitySenateENS.senateGaugeName; //评价量规名称
objvPubClassCaseQuantitySenateENT.pubClassCaseQuantitySenateScore = objvPubClassCaseQuantitySenateENS.pubClassCaseQuantitySenateScore; //评分
objvPubClassCaseQuantitySenateENT.UserId = objvPubClassCaseQuantitySenateENS.UserId; //用户ID
objvPubClassCaseQuantitySenateENT.UserName = objvPubClassCaseQuantitySenateENS.UserName; //用户名
objvPubClassCaseQuantitySenateENT.OptDate = objvPubClassCaseQuantitySenateENS.OptDate; //OptDate
objvPubClassCaseQuantitySenateENT.CollegeID = objvPubClassCaseQuantitySenateENS.CollegeID; //学院ID
objvPubClassCaseQuantitySenateENT.CollegeName = objvPubClassCaseQuantitySenateENS.CollegeName; //学院名称
objvPubClassCaseQuantitySenateENT.IdXzCollege = objvPubClassCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvPubClassCaseQuantitySenateENT.IsLeaved = objvPubClassCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvPubClassCaseQuantitySenateENT.senateGaugeVersionID = objvPubClassCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseQuantitySenateENT.senateGaugeVersionName = objvPubClassCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvPubClassCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseQuantitySenateENT.StuIdTeacherId = objvPubClassCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvPubClassCaseQuantitySenateENT.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseQuantitySenateENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseQuantitySenateENT.senateGaugeMemo = objvPubClassCaseQuantitySenateENS.senateGaugeMemo; //评价量规指标与说明
objvPubClassCaseQuantitySenateENT.SenateGaugeWeight = objvPubClassCaseQuantitySenateENS.SenateGaugeWeight; //评价量规权重
objvPubClassCaseQuantitySenateENT.OrderNum = objvPubClassCaseQuantitySenateENS.OrderNum; //序号
objvPubClassCaseQuantitySenateENT.senateGaugeNameWithOrder = objvPubClassCaseQuantitySenateENS.senateGaugeNameWithOrder; //senateGaugeNameWithOrder
objvPubClassCaseQuantitySenateENT.PubClassCaseExecutor = objvPubClassCaseQuantitySenateENS.PubClassCaseExecutor; //案例执教者
objvPubClassCaseQuantitySenateENT.PubClassCaseTeachDate = objvPubClassCaseQuantitySenateENS.PubClassCaseTeachDate; //案例授课日期
objvPubClassCaseQuantitySenateENT.UserNameWithUserId = objvPubClassCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvPubClassCaseQuantitySenateENT.CollegeNameA = objvPubClassCaseQuantitySenateENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvPubClassCaseQuantitySenateEN">源简化对象</param>
 public static void SetUpdFlag(clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN)
{
try
{
objvPubClassCaseQuantitySenateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPubClassCaseQuantitySenateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate = objvPubClassCaseQuantitySenateEN.IdpubClassCaseQuantitySenate; //流水号
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.IdPubClassCase = objvPubClassCaseQuantitySenateEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.PubClassCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.PubClassCaseID = objvPubClassCaseQuantitySenateEN.PubClassCaseID == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.PubClassCaseID; //案例ID
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.PubClassCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.PubClassCaseName = objvPubClassCaseQuantitySenateEN.PubClassCaseName == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.PubClassCaseName; //案例课题名称
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.IdsenateGauge, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.IdsenateGauge = objvPubClassCaseQuantitySenateEN.IdsenateGauge; //评价量规流水号
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.senateGaugeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.senateGaugeID = objvPubClassCaseQuantitySenateEN.senateGaugeID == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.senateGaugeID; //评价量规ID
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.senateGaugeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.senateGaugeName = objvPubClassCaseQuantitySenateEN.senateGaugeName == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.senateGaugeName; //评价量规名称
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore = objvPubClassCaseQuantitySenateEN.pubClassCaseQuantitySenateScore; //评分
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.UserId = objvPubClassCaseQuantitySenateEN.UserId == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.UserId; //用户ID
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.UserName = objvPubClassCaseQuantitySenateEN.UserName == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.UserName; //用户名
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.OptDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.OptDate = objvPubClassCaseQuantitySenateEN.OptDate == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.OptDate; //OptDate
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.CollegeID = objvPubClassCaseQuantitySenateEN.CollegeID == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.CollegeName = objvPubClassCaseQuantitySenateEN.CollegeName == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.IdXzCollege = objvPubClassCaseQuantitySenateEN.IdXzCollege == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.IsLeaved, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.IsLeaved = objvPubClassCaseQuantitySenateEN.IsLeaved; //IsLeaved
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = objvPubClassCaseQuantitySenateEN.senateGaugeVersionID == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = objvPubClassCaseQuantitySenateEN.senateGaugeVersionName == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore = objvPubClassCaseQuantitySenateEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.StuIdTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.StuIdTeacherId = objvPubClassCaseQuantitySenateEN.StuIdTeacherId == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.StuIdTeacherId; //学工号
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.IdPubClassCaseSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.senateGaugeMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.senateGaugeMemo = objvPubClassCaseQuantitySenateEN.senateGaugeMemo == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.senateGaugeMemo; //评价量规指标与说明
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.SenateGaugeWeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.SenateGaugeWeight = objvPubClassCaseQuantitySenateEN.SenateGaugeWeight; //评价量规权重
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.OrderNum = objvPubClassCaseQuantitySenateEN.OrderNum; //序号
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.senateGaugeNameWithOrder, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder; //senateGaugeNameWithOrder
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.PubClassCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.PubClassCaseTeachDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate; //案例授课日期
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.UserNameWithUserId = objvPubClassCaseQuantitySenateEN.UserNameWithUserId == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.UserNameWithUserId; //UserNameWithUserId
}
if (arrFldSet.Contains(convPubClassCaseQuantitySenate.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseQuantitySenateEN.CollegeNameA = objvPubClassCaseQuantitySenateEN.CollegeNameA == "[null]" ? null :  objvPubClassCaseQuantitySenateEN.CollegeNameA; //学院名称简写
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
 /// <param name = "objvPubClassCaseQuantitySenateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN)
{
try
{
if (objvPubClassCaseQuantitySenateEN.PubClassCaseID == "[null]") objvPubClassCaseQuantitySenateEN.PubClassCaseID = null; //案例ID
if (objvPubClassCaseQuantitySenateEN.PubClassCaseName == "[null]") objvPubClassCaseQuantitySenateEN.PubClassCaseName = null; //案例课题名称
if (objvPubClassCaseQuantitySenateEN.senateGaugeID == "[null]") objvPubClassCaseQuantitySenateEN.senateGaugeID = null; //评价量规ID
if (objvPubClassCaseQuantitySenateEN.senateGaugeName == "[null]") objvPubClassCaseQuantitySenateEN.senateGaugeName = null; //评价量规名称
if (objvPubClassCaseQuantitySenateEN.UserId == "[null]") objvPubClassCaseQuantitySenateEN.UserId = null; //用户ID
if (objvPubClassCaseQuantitySenateEN.UserName == "[null]") objvPubClassCaseQuantitySenateEN.UserName = null; //用户名
if (objvPubClassCaseQuantitySenateEN.OptDate == "[null]") objvPubClassCaseQuantitySenateEN.OptDate = null; //OptDate
if (objvPubClassCaseQuantitySenateEN.CollegeID == "[null]") objvPubClassCaseQuantitySenateEN.CollegeID = null; //学院ID
if (objvPubClassCaseQuantitySenateEN.CollegeName == "[null]") objvPubClassCaseQuantitySenateEN.CollegeName = null; //学院名称
if (objvPubClassCaseQuantitySenateEN.IdXzCollege == "[null]") objvPubClassCaseQuantitySenateEN.IdXzCollege = null; //学院流水号
if (objvPubClassCaseQuantitySenateEN.senateGaugeVersionID == "[null]") objvPubClassCaseQuantitySenateEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvPubClassCaseQuantitySenateEN.senateGaugeVersionName == "[null]") objvPubClassCaseQuantitySenateEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvPubClassCaseQuantitySenateEN.StuIdTeacherId == "[null]") objvPubClassCaseQuantitySenateEN.StuIdTeacherId = null; //学工号
if (objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion == "[null]") objvPubClassCaseQuantitySenateEN.IdPubClassCaseSenateGaugeVersion = null; //公开课量表版本流水号
if (objvPubClassCaseQuantitySenateEN.senateGaugeMemo == "[null]") objvPubClassCaseQuantitySenateEN.senateGaugeMemo = null; //评价量规指标与说明
if (objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder == "[null]") objvPubClassCaseQuantitySenateEN.senateGaugeNameWithOrder = null; //senateGaugeNameWithOrder
if (objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor == "[null]") objvPubClassCaseQuantitySenateEN.PubClassCaseExecutor = null; //案例执教者
if (objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate == "[null]") objvPubClassCaseQuantitySenateEN.PubClassCaseTeachDate = null; //案例授课日期
if (objvPubClassCaseQuantitySenateEN.UserNameWithUserId == "[null]") objvPubClassCaseQuantitySenateEN.UserNameWithUserId = null; //UserNameWithUserId
if (objvPubClassCaseQuantitySenateEN.CollegeNameA == "[null]") objvPubClassCaseQuantitySenateEN.CollegeNameA = null; //学院名称简写
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
public static void CheckProperty4Condition(clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN)
{
 vPubClassCaseQuantitySenateDA.CheckProperty4Condition(objvPubClassCaseQuantitySenateEN);
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
if (clsPubClassCaseQuantitySenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseQuantitySenateBL没有刷新缓存机制(clsPubClassCaseQuantitySenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseBL没有刷新缓存机制(clsPubClassCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanBL没有刷新缓存机制(clsTeachingPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionBL没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeBL没有刷新缓存机制(clsPubCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeBL没有刷新缓存机制(clsSenateGaugeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdpubClassCaseQuantitySenate");
//if (arrvPubClassCaseQuantitySenateObjLstCache == null)
//{
//arrvPubClassCaseQuantitySenateObjLstCache = vPubClassCaseQuantitySenateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdpubClassCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseQuantitySenateEN GetObjByIdpubClassCaseQuantitySenateCache(long lngIdpubClassCaseQuantitySenate)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPubClassCaseQuantitySenateEN._CurrTabName);
List<clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLst_Sel =
arrvPubClassCaseQuantitySenateObjLstCache
.Where(x=> x.IdpubClassCaseQuantitySenate == lngIdpubClassCaseQuantitySenate 
);
if (arrvPubClassCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseQuantitySenateEN obj = clsvPubClassCaseQuantitySenateBL.GetObjByIdpubClassCaseQuantitySenate(lngIdpubClassCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPubClassCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetAllvPubClassCaseQuantitySenateObjLstCache()
{
//获取缓存中的对象列表
List<clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLstCache = GetObjLstCache(); 
return arrvPubClassCaseQuantitySenateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseQuantitySenateEN._CurrTabName);
List<clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseQuantitySenateObjLstCache;
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
string strKey = string.Format("{0}", clsvPubClassCaseQuantitySenateEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdpubClassCaseQuantitySenate)
{
if (strInFldName != convPubClassCaseQuantitySenate.IdpubClassCaseQuantitySenate)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPubClassCaseQuantitySenate.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPubClassCaseQuantitySenate.AttributeName));
throw new Exception(strMsg);
}
var objvPubClassCaseQuantitySenate = clsvPubClassCaseQuantitySenateBL.GetObjByIdpubClassCaseQuantitySenateCache(lngIdpubClassCaseQuantitySenate);
if (objvPubClassCaseQuantitySenate == null) return "";
return objvPubClassCaseQuantitySenate[strOutFldName].ToString();
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
int intRecCount = clsvPubClassCaseQuantitySenateDA.GetRecCount(strTabName);
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
int intRecCount = clsvPubClassCaseQuantitySenateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPubClassCaseQuantitySenateDA.GetRecCount();
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
int intRecCount = clsvPubClassCaseQuantitySenateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateCond)
{
List<clsvPubClassCaseQuantitySenateEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseQuantitySenateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCaseQuantitySenate.AttributeName)
{
if (objvPubClassCaseQuantitySenateCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseQuantitySenateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseQuantitySenateCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseQuantitySenateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseQuantitySenateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseQuantitySenateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseQuantitySenateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseQuantitySenateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseQuantitySenateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseQuantitySenateCond[strFldName]));
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
 List<string> arrList = clsvPubClassCaseQuantitySenateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCaseQuantitySenateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCaseQuantitySenateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}