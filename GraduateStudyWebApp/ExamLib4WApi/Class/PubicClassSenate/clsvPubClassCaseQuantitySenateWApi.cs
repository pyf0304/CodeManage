
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseQuantitySenateWApi
 表名:vPubClassCaseQuantitySenate(01120414)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:35
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
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
public static class clsvPubClassCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN Setid_pubClassCaseQuantitySenate(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, long lngid_pubClassCaseQuantitySenate, string strComparisonOp="")
	{
objvPubClassCaseQuantitySenateEN.id_pubClassCaseQuantitySenate = lngid_pubClassCaseQuantitySenate; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.id_pubClassCaseQuantitySenate) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.id_pubClassCaseQuantitySenate, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_pubClassCaseQuantitySenate] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN Setid_PubClassCase(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCase, convPubClassCaseQuantitySenate.id_PubClassCase);
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, convPubClassCaseQuantitySenate.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, convPubClassCaseQuantitySenate.id_PubClassCase);
objvPubClassCaseQuantitySenateEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.id_PubClassCase) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.id_PubClassCase, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_PubClassCase] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetPubClassCaseID(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, convPubClassCaseQuantitySenate.PubClassCaseID);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, convPubClassCaseQuantitySenate.PubClassCaseID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetPubClassCaseName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, convPubClassCaseQuantitySenate.PubClassCaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN Setid_senateGauge(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strid_senateGauge, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_senateGauge, convPubClassCaseQuantitySenate.id_senateGauge);
clsCheckSql.CheckFieldLen(strid_senateGauge, 4, convPubClassCaseQuantitySenate.id_senateGauge);
clsCheckSql.CheckFieldForeignKey(strid_senateGauge, 4, convPubClassCaseQuantitySenate.id_senateGauge);
objvPubClassCaseQuantitySenateEN.id_senateGauge = strid_senateGauge; //评价量规流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.id_senateGauge) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.id_senateGauge, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_senateGauge] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeID(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeID, 4, convPubClassCaseQuantitySenate.senateGaugeID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeID, 4, convPubClassCaseQuantitySenate.senateGaugeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeName, 200, convPubClassCaseQuantitySenate.senateGaugeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetUserId(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convPubClassCaseQuantitySenate.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetUserName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convPubClassCaseQuantitySenate.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetOptDate(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strOptDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptDate, 20, convPubClassCaseQuantitySenate.OptDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetCollegeID(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convPubClassCaseQuantitySenate.CollegeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetCollegeName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convPubClassCaseQuantitySenate.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN Setid_XzCollege(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convPubClassCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convPubClassCaseQuantitySenate.id_XzCollege);
objvPubClassCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.id_XzCollege) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convPubClassCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convPubClassCaseQuantitySenate.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convPubClassCaseQuantitySenate.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetStuIdTeacherId(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strStuIdTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convPubClassCaseQuantitySenate.StuIdTeacherId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN Setid_PubClassCaseSenateGaugeVersion(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strid_PubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_PubClassCaseSenateGaugeVersion, 4, convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCaseSenateGaugeVersion, 4, convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion);
objvPubClassCaseQuantitySenateEN.id_PubClassCaseSenateGaugeVersion = strid_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion) == false)
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp.Add(convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objvPubClassCaseQuantitySenateEN.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objvPubClassCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeMemo(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeMemo, 1000, convPubClassCaseQuantitySenate.senateGaugeMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetSenateGaugeWeight(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, float fltSenateGaugeWeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetOrderNum(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetsenateGaugeNameWithOrder(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strsenateGaugeNameWithOrder, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeNameWithOrder, 204, convPubClassCaseQuantitySenate.senateGaugeNameWithOrder);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetPubClassCaseExecutor(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, convPubClassCaseQuantitySenate.PubClassCaseExecutor);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetPubClassCaseTeachDate(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, convPubClassCaseQuantitySenate.PubClassCaseTeachDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, convPubClassCaseQuantitySenate.PubClassCaseTeachDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetUserNameWithUserId(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convPubClassCaseQuantitySenate.UserNameWithUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPubClassCaseQuantitySenateEN SetCollegeNameA(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convPubClassCaseQuantitySenate.CollegeNameA);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.id_pubClassCaseQuantitySenate) == true)
{
string strComparisonOp_id_pubClassCaseQuantitySenate = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_pubClassCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.id_pubClassCaseQuantitySenate, objvPubClassCaseQuantitySenate_Cond.id_pubClassCaseQuantitySenate, strComparisonOp_id_pubClassCaseQuantitySenate);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.id_PubClassCase, objvPubClassCaseQuantitySenate_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.PubClassCaseID) == true)
{
string strComparisonOp_PubClassCaseID = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.PubClassCaseID, objvPubClassCaseQuantitySenate_Cond.PubClassCaseID, strComparisonOp_PubClassCaseID);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.PubClassCaseName) == true)
{
string strComparisonOp_PubClassCaseName = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.PubClassCaseName, objvPubClassCaseQuantitySenate_Cond.PubClassCaseName, strComparisonOp_PubClassCaseName);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.id_senateGauge) == true)
{
string strComparisonOp_id_senateGauge = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_senateGauge];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.id_senateGauge, objvPubClassCaseQuantitySenate_Cond.id_senateGauge, strComparisonOp_id_senateGauge);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeID) == true)
{
string strComparisonOp_senateGaugeID = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeID, objvPubClassCaseQuantitySenate_Cond.senateGaugeID, strComparisonOp_senateGaugeID);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeName) == true)
{
string strComparisonOp_senateGaugeName = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeName, objvPubClassCaseQuantitySenate_Cond.senateGaugeName, strComparisonOp_senateGaugeName);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore) == true)
{
string strComparisonOp_pubClassCaseQuantitySenateScore = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore, objvPubClassCaseQuantitySenate_Cond.pubClassCaseQuantitySenateScore, strComparisonOp_pubClassCaseQuantitySenateScore);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.UserId, objvPubClassCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.UserName, objvPubClassCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.OptDate) == true)
{
string strComparisonOp_OptDate = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.OptDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.OptDate, objvPubClassCaseQuantitySenate_Cond.OptDate, strComparisonOp_OptDate);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.CollegeID, objvPubClassCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.CollegeName, objvPubClassCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.id_XzCollege, objvPubClassCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.IsLeaved) == true)
{
if (objvPubClassCaseQuantitySenate_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseQuantitySenate.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseQuantitySenate.IsLeaved);
}
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeVersionID, objvPubClassCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeVersionName, objvPubClassCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore, objvPubClassCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.StuIdTeacherId) == true)
{
string strComparisonOp_StuIdTeacherId = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.StuIdTeacherId, objvPubClassCaseQuantitySenate_Cond.StuIdTeacherId, strComparisonOp_StuIdTeacherId);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOp_id_PubClassCaseSenateGaugeVersion = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion, objvPubClassCaseQuantitySenate_Cond.id_PubClassCaseSenateGaugeVersion, strComparisonOp_id_PubClassCaseSenateGaugeVersion);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeMemo) == true)
{
string strComparisonOp_senateGaugeMemo = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeMemo, objvPubClassCaseQuantitySenate_Cond.senateGaugeMemo, strComparisonOp_senateGaugeMemo);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.SenateGaugeWeight) == true)
{
string strComparisonOp_SenateGaugeWeight = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.SenateGaugeWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.SenateGaugeWeight, objvPubClassCaseQuantitySenate_Cond.SenateGaugeWeight, strComparisonOp_SenateGaugeWeight);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseQuantitySenate.OrderNum, objvPubClassCaseQuantitySenate_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.senateGaugeNameWithOrder) == true)
{
string strComparisonOp_senateGaugeNameWithOrder = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.senateGaugeNameWithOrder, objvPubClassCaseQuantitySenate_Cond.senateGaugeNameWithOrder, strComparisonOp_senateGaugeNameWithOrder);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.PubClassCaseExecutor) == true)
{
string strComparisonOp_PubClassCaseExecutor = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.PubClassCaseExecutor, objvPubClassCaseQuantitySenate_Cond.PubClassCaseExecutor, strComparisonOp_PubClassCaseExecutor);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.PubClassCaseTeachDate) == true)
{
string strComparisonOp_PubClassCaseTeachDate = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.PubClassCaseTeachDate, objvPubClassCaseQuantitySenate_Cond.PubClassCaseTeachDate, strComparisonOp_PubClassCaseTeachDate);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.UserNameWithUserId, objvPubClassCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvPubClassCaseQuantitySenate_Cond.IsUpdated(convPubClassCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvPubClassCaseQuantitySenate_Cond.dicFldComparisonOp[convPubClassCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseQuantitySenate.CollegeNameA, objvPubClassCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v公开课案例量化评价(vPubClassCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vPubClassCaseQuantitySenateApi";

 public clsvPubClassCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_pubClassCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseQuantitySenateEN GetObjByid_pubClassCaseQuantitySenate(long lngid_pubClassCaseQuantitySenate)
{
string strAction = "GetObjByid_pubClassCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_pubClassCaseQuantitySenate"] = lngid_pubClassCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvPubClassCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseQuantitySenateEN;
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
 /// <param name = "lngid_pubClassCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseQuantitySenateEN GetObjByid_pubClassCaseQuantitySenate_WA_Cache(long lngid_pubClassCaseQuantitySenate)
{
string strAction = "GetObjByid_pubClassCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_pubClassCaseQuantitySenate"] = lngid_pubClassCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPubClassCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvPubClassCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseQuantitySenateEN;
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
public static clsvPubClassCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateEN = null;
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
objvPubClassCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvPubClassCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvPubClassCaseQuantitySenateEN;
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
 /// <param name = "lngid_pubClassCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseQuantitySenateEN GetObjByid_pubClassCaseQuantitySenate_Cache(long lngid_pubClassCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseQuantitySenateEN._CurrTabName_S);
List<clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLst_Sel =
from objvPubClassCaseQuantitySenateEN in arrvPubClassCaseQuantitySenateObjLst_Cache
where objvPubClassCaseQuantitySenateEN.id_pubClassCaseQuantitySenate == lngid_pubClassCaseQuantitySenate
select objvPubClassCaseQuantitySenateEN;
if (arrvPubClassCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseQuantitySenateEN obj = clsvPubClassCaseQuantitySenateWApi.GetObjByid_pubClassCaseQuantitySenate(lngid_pubClassCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPubClassCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvPubClassCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstById_pubClassCaseQuantitySenateLst(List<long> arrId_pubClassCaseQuantitySenate)
{
 List<clsvPubClassCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_pubClassCaseQuantitySenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_pubClassCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_pubClassCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPubClassCaseQuantitySenateEN> GetObjLstById_pubClassCaseQuantitySenateLst_Cache(List<long> arrId_pubClassCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPubClassCaseQuantitySenateEN._CurrTabName_S);
List<clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLst_Sel =
from objvPubClassCaseQuantitySenateEN in arrvPubClassCaseQuantitySenateObjLst_Cache
where arrId_pubClassCaseQuantitySenate.Contains(objvPubClassCaseQuantitySenateEN.id_pubClassCaseQuantitySenate)
select objvPubClassCaseQuantitySenateEN;
return arrvPubClassCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstById_pubClassCaseQuantitySenateLst_WA_Cache(List<long> arrId_pubClassCaseQuantitySenate)
{
 List<clsvPubClassCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_pubClassCaseQuantitySenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_pubClassCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPubClassCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPubClassCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPubClassCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPubClassCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_pubClassCaseQuantitySenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_pubClassCaseQuantitySenate"] = lngid_pubClassCaseQuantitySenate.ToString()
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvPubClassCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvPubClassCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENS, clsvPubClassCaseQuantitySenateEN objvPubClassCaseQuantitySenateENT)
{
try
{
objvPubClassCaseQuantitySenateENT.id_pubClassCaseQuantitySenate = objvPubClassCaseQuantitySenateENS.id_pubClassCaseQuantitySenate; //流水号
objvPubClassCaseQuantitySenateENT.id_PubClassCase = objvPubClassCaseQuantitySenateENS.id_PubClassCase; //案例流水号
objvPubClassCaseQuantitySenateENT.PubClassCaseID = objvPubClassCaseQuantitySenateENS.PubClassCaseID; //案例ID
objvPubClassCaseQuantitySenateENT.PubClassCaseName = objvPubClassCaseQuantitySenateENS.PubClassCaseName; //案例课题名称
objvPubClassCaseQuantitySenateENT.id_senateGauge = objvPubClassCaseQuantitySenateENS.id_senateGauge; //评价量规流水号
objvPubClassCaseQuantitySenateENT.senateGaugeID = objvPubClassCaseQuantitySenateENS.senateGaugeID; //评价量规ID
objvPubClassCaseQuantitySenateENT.senateGaugeName = objvPubClassCaseQuantitySenateENS.senateGaugeName; //评价量规名称
objvPubClassCaseQuantitySenateENT.pubClassCaseQuantitySenateScore = objvPubClassCaseQuantitySenateENS.pubClassCaseQuantitySenateScore; //评分
objvPubClassCaseQuantitySenateENT.UserId = objvPubClassCaseQuantitySenateENS.UserId; //用户ID
objvPubClassCaseQuantitySenateENT.UserName = objvPubClassCaseQuantitySenateENS.UserName; //用户名
objvPubClassCaseQuantitySenateENT.OptDate = objvPubClassCaseQuantitySenateENS.OptDate; //OptDate
objvPubClassCaseQuantitySenateENT.CollegeID = objvPubClassCaseQuantitySenateENS.CollegeID; //学院ID
objvPubClassCaseQuantitySenateENT.CollegeName = objvPubClassCaseQuantitySenateENS.CollegeName; //学院名称
objvPubClassCaseQuantitySenateENT.id_XzCollege = objvPubClassCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvPubClassCaseQuantitySenateENT.IsLeaved = objvPubClassCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvPubClassCaseQuantitySenateENT.senateGaugeVersionID = objvPubClassCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseQuantitySenateENT.senateGaugeVersionName = objvPubClassCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvPubClassCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseQuantitySenateENT.StuIdTeacherId = objvPubClassCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvPubClassCaseQuantitySenateENT.id_PubClassCaseSenateGaugeVersion = objvPubClassCaseQuantitySenateENS.id_PubClassCaseSenateGaugeVersion; //公开课量表版本流水号
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
public static DataTable ToDataTable(List<clsvPubClassCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPubClassCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPubClassCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPubClassCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPubClassCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPubClassCaseQuantitySenateEN.AttributeName)
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
if (clsPubClassCaseQuantitySenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseQuantitySenateWApi没有刷新缓存机制(clsPubClassCaseQuantitySenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseWApi没有刷新缓存机制(clsPubClassCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingPlanWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanWApi没有刷新缓存机制(clsTeachingPlanWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionWApi没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPubCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubCaseTypeWApi没有刷新缓存机制(clsPubCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeWApi没有刷新缓存机制(clsSenateGaugeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_pubClassCaseQuantitySenate");
//if (arrvPubClassCaseQuantitySenateObjLst_Cache == null)
//{
//arrvPubClassCaseQuantitySenateObjLst_Cache = await clsvPubClassCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPubClassCaseQuantitySenateEN._CurrTabName_S);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseQuantitySenateEN._CurrTabName_S);
List<clsvPubClassCaseQuantitySenateEN> arrvPubClassCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPubClassCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPubClassCaseQuantitySenate.id_pubClassCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.PubClassCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.PubClassCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.id_senateGauge, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.senateGaugeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.senateGaugeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore, Type.GetType("System.Int32"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.OptDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.StuIdTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.senateGaugeMemo, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.SenateGaugeWeight, Type.GetType("System.Single"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.senateGaugeNameWithOrder, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.PubClassCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.PubClassCaseTeachDate, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convPubClassCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
foreach (clsvPubClassCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPubClassCaseQuantitySenate.id_pubClassCaseQuantitySenate] = objInFor[convPubClassCaseQuantitySenate.id_pubClassCaseQuantitySenate];
objDR[convPubClassCaseQuantitySenate.id_PubClassCase] = objInFor[convPubClassCaseQuantitySenate.id_PubClassCase];
objDR[convPubClassCaseQuantitySenate.PubClassCaseID] = objInFor[convPubClassCaseQuantitySenate.PubClassCaseID];
objDR[convPubClassCaseQuantitySenate.PubClassCaseName] = objInFor[convPubClassCaseQuantitySenate.PubClassCaseName];
objDR[convPubClassCaseQuantitySenate.id_senateGauge] = objInFor[convPubClassCaseQuantitySenate.id_senateGauge];
objDR[convPubClassCaseQuantitySenate.senateGaugeID] = objInFor[convPubClassCaseQuantitySenate.senateGaugeID];
objDR[convPubClassCaseQuantitySenate.senateGaugeName] = objInFor[convPubClassCaseQuantitySenate.senateGaugeName];
objDR[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore] = objInFor[convPubClassCaseQuantitySenate.pubClassCaseQuantitySenateScore];
objDR[convPubClassCaseQuantitySenate.UserId] = objInFor[convPubClassCaseQuantitySenate.UserId];
objDR[convPubClassCaseQuantitySenate.UserName] = objInFor[convPubClassCaseQuantitySenate.UserName];
objDR[convPubClassCaseQuantitySenate.OptDate] = objInFor[convPubClassCaseQuantitySenate.OptDate];
objDR[convPubClassCaseQuantitySenate.CollegeID] = objInFor[convPubClassCaseQuantitySenate.CollegeID];
objDR[convPubClassCaseQuantitySenate.CollegeName] = objInFor[convPubClassCaseQuantitySenate.CollegeName];
objDR[convPubClassCaseQuantitySenate.id_XzCollege] = objInFor[convPubClassCaseQuantitySenate.id_XzCollege];
objDR[convPubClassCaseQuantitySenate.IsLeaved] = objInFor[convPubClassCaseQuantitySenate.IsLeaved];
objDR[convPubClassCaseQuantitySenate.senateGaugeVersionID] = objInFor[convPubClassCaseQuantitySenate.senateGaugeVersionID];
objDR[convPubClassCaseQuantitySenate.senateGaugeVersionName] = objInFor[convPubClassCaseQuantitySenate.senateGaugeVersionName];
objDR[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convPubClassCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convPubClassCaseQuantitySenate.StuIdTeacherId] = objInFor[convPubClassCaseQuantitySenate.StuIdTeacherId];
objDR[convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion] = objInFor[convPubClassCaseQuantitySenate.id_PubClassCaseSenateGaugeVersion];
objDR[convPubClassCaseQuantitySenate.senateGaugeMemo] = objInFor[convPubClassCaseQuantitySenate.senateGaugeMemo];
objDR[convPubClassCaseQuantitySenate.SenateGaugeWeight] = objInFor[convPubClassCaseQuantitySenate.SenateGaugeWeight];
objDR[convPubClassCaseQuantitySenate.OrderNum] = objInFor[convPubClassCaseQuantitySenate.OrderNum];
objDR[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder] = objInFor[convPubClassCaseQuantitySenate.senateGaugeNameWithOrder];
objDR[convPubClassCaseQuantitySenate.PubClassCaseExecutor] = objInFor[convPubClassCaseQuantitySenate.PubClassCaseExecutor];
objDR[convPubClassCaseQuantitySenate.PubClassCaseTeachDate] = objInFor[convPubClassCaseQuantitySenate.PubClassCaseTeachDate];
objDR[convPubClassCaseQuantitySenate.UserNameWithUserId] = objInFor[convPubClassCaseQuantitySenate.UserNameWithUserId];
objDR[convPubClassCaseQuantitySenate.CollegeNameA] = objInFor[convPubClassCaseQuantitySenate.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}