
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCaseQuantitySenateItemsWApi
 表名:vVideoResCaseQuantitySenateItems(01120447)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:39
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频资源库
 模块英文名:VideoResLib
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
public static class clsvVideoResCaseQuantitySenateItemsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN Setid_microteachCaseQuantitySenateItem(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, long lngid_microteachCaseQuantitySenateItem, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem = lngid_microteachCaseQuantitySenateItem; //微格量化评价指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN Setid_microteachCaseQuantitySenate(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngid_microteachCaseQuantitySenate, convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate);
objvVideoResCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetVideoResCaseID(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strVideoResCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseID, 8, convVideoResCaseQuantitySenateItems.VideoResCaseID);
clsCheckSql.CheckFieldForeignKey(strVideoResCaseID, 8, convVideoResCaseQuantitySenateItems.VideoResCaseID);
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseID = strVideoResCaseID; //视频资源案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.VideoResCaseID) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.VideoResCaseID, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.VideoResCaseID] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetVideoResCaseName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strVideoResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoResCaseName, 100, convVideoResCaseQuantitySenateItems.VideoResCaseName);
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseName = strVideoResCaseName; //视频资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.VideoResCaseName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.VideoResCaseName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.VideoResCaseName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN Setid_AppraiseType(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convVideoResCaseQuantitySenateItems.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convVideoResCaseQuantitySenateItems.id_AppraiseType);
objvVideoResCaseQuantitySenateItemsEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.id_AppraiseType) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.id_AppraiseType, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_AppraiseType] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetAppraiseTypeName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convVideoResCaseQuantitySenateItems.AppraiseTypeName);
objvVideoResCaseQuantitySenateItemsEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.AppraiseTypeName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.AppraiseTypeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AppraiseTypeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetUserId(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convVideoResCaseQuantitySenateItems.UserId);
objvVideoResCaseQuantitySenateItemsEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.UserId) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.UserId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN Setid_MicroteachCase(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convVideoResCaseQuantitySenateItems.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convVideoResCaseQuantitySenateItems.id_MicroteachCase);
objvVideoResCaseQuantitySenateItemsEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.id_MicroteachCase) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.id_MicroteachCase, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_MicroteachCase] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetCollegeID(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoResCaseQuantitySenateItems.CollegeID);
objvVideoResCaseQuantitySenateItemsEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.CollegeID) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.CollegeID, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.CollegeID] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetCollegeName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoResCaseQuantitySenateItems.CollegeName);
objvVideoResCaseQuantitySenateItemsEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.CollegeName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.CollegeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.CollegeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetCourseId(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoResCaseQuantitySenateItems.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoResCaseQuantitySenateItems.CourseId);
objvVideoResCaseQuantitySenateItemsEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.CourseId) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.CourseId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.CourseId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetSenateTheme(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convVideoResCaseQuantitySenateItems.SenateTheme);
objvVideoResCaseQuantitySenateItemsEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.SenateTheme) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.SenateTheme, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateTheme] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetSenateContent(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convVideoResCaseQuantitySenateItems.SenateContent);
objvVideoResCaseQuantitySenateItemsEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.SenateContent) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.SenateContent, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateContent] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetSenateTotalScore(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, float fltSenateTotalScore, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.SenateTotalScore) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.SenateTotalScore, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateTotalScore] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetSenateDate(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convVideoResCaseQuantitySenateItems.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convVideoResCaseQuantitySenateItems.SenateDate);
objvVideoResCaseQuantitySenateItemsEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.SenateDate) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.SenateDate, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateDate] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetSenateTime(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convVideoResCaseQuantitySenateItems.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convVideoResCaseQuantitySenateItems.SenateTime);
objvVideoResCaseQuantitySenateItemsEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.SenateTime) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.SenateTime, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateTime] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN Setid_SenateGaugeVersion(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion);
objvVideoResCaseQuantitySenateItemsEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetFuncModuleName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoResCaseQuantitySenateItems.FuncModuleName);
objvVideoResCaseQuantitySenateItemsEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.FuncModuleName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.FuncModuleName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.FuncModuleName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetFuncModuleId(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoResCaseQuantitySenateItems.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoResCaseQuantitySenateItems.FuncModuleId);
objvVideoResCaseQuantitySenateItemsEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.FuncModuleId) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.FuncModuleId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.FuncModuleId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetSenateIp(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convVideoResCaseQuantitySenateItems.SenateIp);
objvVideoResCaseQuantitySenateItemsEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.SenateIp) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.SenateIp, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateIp] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetUserTypeName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convVideoResCaseQuantitySenateItems.UserTypeName);
objvVideoResCaseQuantitySenateItemsEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.UserTypeName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.UserTypeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserTypeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetUserName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convVideoResCaseQuantitySenateItems.UserName);
objvVideoResCaseQuantitySenateItemsEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.UserName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.UserName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetUserNameWithUserId(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convVideoResCaseQuantitySenateItems.UserNameWithUserId);
objvVideoResCaseQuantitySenateItemsEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.UserNameWithUserId) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.UserNameWithUserId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserNameWithUserId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetUserKindId(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convVideoResCaseQuantitySenateItems.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convVideoResCaseQuantitySenateItems.UserKindId);
objvVideoResCaseQuantitySenateItemsEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.UserKindId) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.UserKindId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserKindId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetUserKindName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convVideoResCaseQuantitySenateItems.UserKindName);
objvVideoResCaseQuantitySenateItemsEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.UserKindName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.UserKindName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserKindName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN Setid_XzCollege(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoResCaseQuantitySenateItems.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoResCaseQuantitySenateItems.id_XzCollege);
objvVideoResCaseQuantitySenateItemsEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.id_XzCollege) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.id_XzCollege, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_XzCollege] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN Setid_XzMajor(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convVideoResCaseQuantitySenateItems.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convVideoResCaseQuantitySenateItems.id_XzMajor);
objvVideoResCaseQuantitySenateItemsEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.id_XzMajor) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.id_XzMajor, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_XzMajor] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetCollegeNameA(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoResCaseQuantitySenateItems.CollegeNameA);
objvVideoResCaseQuantitySenateItemsEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.CollegeNameA) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.CollegeNameA, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.CollegeNameA] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetSenateScore(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, float fltSenateScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateScore, convVideoResCaseQuantitySenateItems.SenateScore);
objvVideoResCaseQuantitySenateItemsEN.SenateScore = fltSenateScore; //指标得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.SenateScore) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.SenateScore, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateScore] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN Setid_SenateGaugeItem(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strid_SenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeItem, convVideoResCaseQuantitySenateItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldLen(strid_SenateGaugeItem, 4, convVideoResCaseQuantitySenateItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeItem, 4, convVideoResCaseQuantitySenateItems.id_SenateGaugeItem);
objvVideoResCaseQuantitySenateItemsEN.id_SenateGaugeItem = strid_SenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.id_SenateGaugeItem) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.id_SenateGaugeItem, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_SenateGaugeItem] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeItemID(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemID, 4, convVideoResCaseQuantitySenateItems.senateGaugeItemID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeItemID, 4, convVideoResCaseQuantitySenateItems.senateGaugeItemID);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemID = strsenateGaugeItemID; //量表指标ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeItemID) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemID, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemID] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeItemName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convVideoResCaseQuantitySenateItems.senateGaugeItemName);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemName = strsenateGaugeItemName; //量表指标名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeItemName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeVersionName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoResCaseQuantitySenateItems.senateGaugeVersionName);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeVersionName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeItemDesc(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeItemDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemDesc, 2000, convVideoResCaseQuantitySenateItems.senateGaugeItemDesc);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemDesc = strsenateGaugeItemDesc; //量表指标说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeItemDesc) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemDesc, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeItemWeight(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, float fltsenateGaugeItemWeight, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemWeight = fltsenateGaugeItemWeight; //量表指标权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeItemWeight) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemWeight, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetAnswerModeId(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convVideoResCaseQuantitySenateItems.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convVideoResCaseQuantitySenateItems.AnswerModeId);
objvVideoResCaseQuantitySenateItemsEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.AnswerModeId) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.AnswerModeId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerModeId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetAnswerTypeId(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convVideoResCaseQuantitySenateItems.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convVideoResCaseQuantitySenateItems.AnswerTypeId);
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.AnswerTypeId) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.AnswerTypeId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerTypeId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetGridTitle(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convVideoResCaseQuantitySenateItems.GridTitle);
objvVideoResCaseQuantitySenateItemsEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.GridTitle) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.GridTitle, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.GridTitle] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetQuestionIndex(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, int intQuestionIndex, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.QuestionIndex) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.QuestionIndex, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.QuestionIndex] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeVersionID(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convVideoResCaseQuantitySenateItems.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convVideoResCaseQuantitySenateItems.senateGaugeVersionID);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeVersionID) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeVersionID, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeVersionID] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetQuestionNo(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convVideoResCaseQuantitySenateItems.QuestionNo);
objvVideoResCaseQuantitySenateItemsEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.QuestionNo) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.QuestionNo, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.QuestionNo] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetQuestionTypeId(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convVideoResCaseQuantitySenateItems.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convVideoResCaseQuantitySenateItems.QuestionTypeId);
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.QuestionTypeId) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.QuestionTypeId, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.QuestionTypeId] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeVersionTtlScore(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetAnswerTypeName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convVideoResCaseQuantitySenateItems.AnswerTypeName);
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.AnswerTypeName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.AnswerTypeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerTypeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetAnswerModeName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strAnswerModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convVideoResCaseQuantitySenateItems.AnswerModeName);
objvVideoResCaseQuantitySenateItemsEN.AnswerModeName = strAnswerModeName; //答案模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.AnswerModeName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.AnswerModeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerModeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeItemMemo(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemMemo, 1000, convVideoResCaseQuantitySenateItems.senateGaugeItemMemo);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemMemo = strsenateGaugeItemMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeItemMemo) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemMemo, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetQuestionTypeName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convVideoResCaseQuantitySenateItems.QuestionTypeName);
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.QuestionTypeName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.QuestionTypeName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.QuestionTypeName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetAnswerNum(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, int intAnswerNum, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.AnswerNum = intAnswerNum; //答案数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.AnswerNum) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.AnswerNum, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerNum] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeItemNameWithOrder(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeItemNameWithOrder, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemNameWithOrder, 204, convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = strsenateGaugeItemNameWithOrder; //量表指标名称WithOrder
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN Setid_SenateGaugeSubItem(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strid_SenateGaugeSubItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeSubItem, convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem);
clsCheckSql.CheckFieldLen(strid_SenateGaugeSubItem, 4, convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeSubItem, 4, convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem);
objvVideoResCaseQuantitySenateItemsEN.id_SenateGaugeSubItem = strid_SenateGaugeSubItem; //量表指标子项流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeSubItemID(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeSubItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemID, 4, convVideoResCaseQuantitySenateItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeSubItemID, 4, convVideoResCaseQuantitySenateItems.senateGaugeSubItemID);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemID = strsenateGaugeSubItemID; //量表指标子项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeSubItemID) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemID, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeSubItemName(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeSubItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemName, 200, convVideoResCaseQuantitySenateItems.senateGaugeSubItemName);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemName = strsenateGaugeSubItemName; //量表指标子项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeSubItemName) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemName, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeSubItemScore(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, float fltsenateGaugeSubItemScore, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemScore = fltsenateGaugeSubItemScore; //量表指标子项分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeSubItemDesc(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeSubItemDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemDesc, 2000, convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = strsenateGaugeSubItemDesc; //量表指标子项说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetAnswerTitle(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strAnswerTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTitle, 20, convVideoResCaseQuantitySenateItems.AnswerTitle);
objvVideoResCaseQuantitySenateItemsEN.AnswerTitle = strAnswerTitle; //答案标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.AnswerTitle) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.AnswerTitle, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerTitle] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetAnswerIndex(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, int intAnswerIndex, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.AnswerIndex) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.AnswerIndex, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerIndex] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetsenateGaugeSubItemMemo(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strsenateGaugeSubItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemMemo, 1000, convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo);
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = strsenateGaugeSubItemMemo; //量表指标子项备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetIsAccess(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, bool bolIsAccess, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.IsAccess = bolIsAccess; //IsAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.IsAccess) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.IsAccess, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.IsAccess] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetIsAccessC(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, bool bolIsAccessC, string strComparisonOp="")
	{
objvVideoResCaseQuantitySenateItemsEN.IsAccessC = bolIsAccessC; //IsAccessC
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.IsAccessC) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.IsAccessC, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.IsAccessC] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetUpdDate(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoResCaseQuantitySenateItems.UpdDate);
objvVideoResCaseQuantitySenateItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.UpdDate) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.UpdDate, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UpdDate] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoResCaseQuantitySenateItemsEN SetUpdUser(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoResCaseQuantitySenateItems.UpdUser);
objvVideoResCaseQuantitySenateItemsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convVideoResCaseQuantitySenateItems.UpdUser) == false)
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convVideoResCaseQuantitySenateItems.UpdUser, strComparisonOp);
}
else
{
objvVideoResCaseQuantitySenateItemsEN.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UpdUser] = strComparisonOp;
}
}
return objvVideoResCaseQuantitySenateItemsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItems_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenateItem = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem, objvVideoResCaseQuantitySenateItems_Cond.id_microteachCaseQuantitySenateItem, strComparisonOp_id_microteachCaseQuantitySenateItem);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate, objvVideoResCaseQuantitySenateItems_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.VideoResCaseID) == true)
{
string strComparisonOp_VideoResCaseID = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.VideoResCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.VideoResCaseID, objvVideoResCaseQuantitySenateItems_Cond.VideoResCaseID, strComparisonOp_VideoResCaseID);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.VideoResCaseName) == true)
{
string strComparisonOp_VideoResCaseName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.VideoResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.VideoResCaseName, objvVideoResCaseQuantitySenateItems_Cond.VideoResCaseName, strComparisonOp_VideoResCaseName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.id_AppraiseType, objvVideoResCaseQuantitySenateItems_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.AppraiseTypeName, objvVideoResCaseQuantitySenateItems_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.UserId) == true)
{
string strComparisonOp_UserId = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.UserId, objvVideoResCaseQuantitySenateItems_Cond.UserId, strComparisonOp_UserId);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.id_MicroteachCase, objvVideoResCaseQuantitySenateItems_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.CollegeID, objvVideoResCaseQuantitySenateItems_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.CollegeName, objvVideoResCaseQuantitySenateItems_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.CourseId, objvVideoResCaseQuantitySenateItems_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.SenateTheme, objvVideoResCaseQuantitySenateItems_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.SenateContent, objvVideoResCaseQuantitySenateItems_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.SenateTotalScore, objvVideoResCaseQuantitySenateItems_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.SenateDate, objvVideoResCaseQuantitySenateItems_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.SenateTime, objvVideoResCaseQuantitySenateItems_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion, objvVideoResCaseQuantitySenateItems_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.FuncModuleName, objvVideoResCaseQuantitySenateItems_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.FuncModuleId, objvVideoResCaseQuantitySenateItems_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.SenateIp, objvVideoResCaseQuantitySenateItems_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.UserTypeName, objvVideoResCaseQuantitySenateItems_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.UserName) == true)
{
string strComparisonOp_UserName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.UserName, objvVideoResCaseQuantitySenateItems_Cond.UserName, strComparisonOp_UserName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.UserNameWithUserId, objvVideoResCaseQuantitySenateItems_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.UserKindId, objvVideoResCaseQuantitySenateItems_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.UserKindName, objvVideoResCaseQuantitySenateItems_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.id_XzCollege, objvVideoResCaseQuantitySenateItems_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.id_XzMajor, objvVideoResCaseQuantitySenateItems_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.CollegeNameA, objvVideoResCaseQuantitySenateItems_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.SenateScore) == true)
{
string strComparisonOp_SenateScore = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.SenateScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.SenateScore, objvVideoResCaseQuantitySenateItems_Cond.SenateScore, strComparisonOp_SenateScore);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.id_SenateGaugeItem) == true)
{
string strComparisonOp_id_SenateGaugeItem = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_SenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.id_SenateGaugeItem, objvVideoResCaseQuantitySenateItems_Cond.id_SenateGaugeItem, strComparisonOp_id_SenateGaugeItem);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeItemID) == true)
{
string strComparisonOp_senateGaugeItemID = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeItemID, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeItemID, strComparisonOp_senateGaugeItemID);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeItemName) == true)
{
string strComparisonOp_senateGaugeItemName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeItemName, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeItemName, strComparisonOp_senateGaugeItemName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeVersionName, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeItemDesc) == true)
{
string strComparisonOp_senateGaugeItemDesc = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeItemDesc, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeItemDesc, strComparisonOp_senateGaugeItemDesc);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeItemWeight) == true)
{
string strComparisonOp_senateGaugeItemWeight = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.senateGaugeItemWeight, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeItemWeight, strComparisonOp_senateGaugeItemWeight);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.AnswerModeId, objvVideoResCaseQuantitySenateItems_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.AnswerTypeId, objvVideoResCaseQuantitySenateItems_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.GridTitle, objvVideoResCaseQuantitySenateItems_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.QuestionIndex, objvVideoResCaseQuantitySenateItems_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeVersionID, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.QuestionNo, objvVideoResCaseQuantitySenateItems_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.QuestionTypeId, objvVideoResCaseQuantitySenateItems_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.AnswerTypeName, objvVideoResCaseQuantitySenateItems_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.AnswerModeName) == true)
{
string strComparisonOp_AnswerModeName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.AnswerModeName, objvVideoResCaseQuantitySenateItems_Cond.AnswerModeName, strComparisonOp_AnswerModeName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeItemMemo) == true)
{
string strComparisonOp_senateGaugeItemMemo = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeItemMemo, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeItemMemo, strComparisonOp_senateGaugeItemMemo);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.QuestionTypeName, objvVideoResCaseQuantitySenateItems_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.AnswerNum) == true)
{
string strComparisonOp_AnswerNum = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.AnswerNum, objvVideoResCaseQuantitySenateItems_Cond.AnswerNum, strComparisonOp_AnswerNum);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder) == true)
{
string strComparisonOp_senateGaugeItemNameWithOrder = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeItemNameWithOrder, strComparisonOp_senateGaugeItemNameWithOrder);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem) == true)
{
string strComparisonOp_id_SenateGaugeSubItem = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem, objvVideoResCaseQuantitySenateItems_Cond.id_SenateGaugeSubItem, strComparisonOp_id_SenateGaugeSubItem);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeSubItemID) == true)
{
string strComparisonOp_senateGaugeSubItemID = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeSubItemID, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeSubItemID, strComparisonOp_senateGaugeSubItemID);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeSubItemName) == true)
{
string strComparisonOp_senateGaugeSubItemName = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeSubItemName, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeSubItemName, strComparisonOp_senateGaugeSubItemName);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore) == true)
{
string strComparisonOp_senateGaugeSubItemScore = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeSubItemScore, strComparisonOp_senateGaugeSubItemScore);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc) == true)
{
string strComparisonOp_senateGaugeSubItemDesc = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeSubItemDesc, strComparisonOp_senateGaugeSubItemDesc);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.AnswerTitle) == true)
{
string strComparisonOp_AnswerTitle = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.AnswerTitle, objvVideoResCaseQuantitySenateItems_Cond.AnswerTitle, strComparisonOp_AnswerTitle);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.AnswerIndex) == true)
{
string strComparisonOp_AnswerIndex = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoResCaseQuantitySenateItems.AnswerIndex, objvVideoResCaseQuantitySenateItems_Cond.AnswerIndex, strComparisonOp_AnswerIndex);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo) == true)
{
string strComparisonOp_senateGaugeSubItemMemo = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo, objvVideoResCaseQuantitySenateItems_Cond.senateGaugeSubItemMemo, strComparisonOp_senateGaugeSubItemMemo);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.IsAccess) == true)
{
if (objvVideoResCaseQuantitySenateItems_Cond.IsAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCaseQuantitySenateItems.IsAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCaseQuantitySenateItems.IsAccess);
}
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.IsAccessC) == true)
{
if (objvVideoResCaseQuantitySenateItems_Cond.IsAccessC == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoResCaseQuantitySenateItems.IsAccessC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoResCaseQuantitySenateItems.IsAccessC);
}
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.UpdDate, objvVideoResCaseQuantitySenateItems_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvVideoResCaseQuantitySenateItems_Cond.IsUpdated(convVideoResCaseQuantitySenateItems.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvVideoResCaseQuantitySenateItems_Cond.dicFldComparisonOp[convVideoResCaseQuantitySenateItems.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoResCaseQuantitySenateItems.UpdUser, objvVideoResCaseQuantitySenateItems_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频资源量化评价详细(vVideoResCaseQuantitySenateItems)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoResCaseQuantitySenateItemsWApi
{
private static readonly string mstrApiControllerName = "vVideoResCaseQuantitySenateItemsApi";

 public clsvVideoResCaseQuantitySenateItemsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoResCaseQuantitySenateItemsEN GetObjByid_microteachCaseQuantitySenateItem(long lngid_microteachCaseQuantitySenateItem)
{
string strAction = "GetObjByid_microteachCaseQuantitySenateItem";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenateItem"] = lngid_microteachCaseQuantitySenateItem.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoResCaseQuantitySenateItemsEN = JsonConvert.DeserializeObject<clsvVideoResCaseQuantitySenateItemsEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseQuantitySenateItemsEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoResCaseQuantitySenateItemsEN GetObjByid_microteachCaseQuantitySenateItem_WA_Cache(long lngid_microteachCaseQuantitySenateItem)
{
string strAction = "GetObjByid_microteachCaseQuantitySenateItem_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenateItem"] = lngid_microteachCaseQuantitySenateItem.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoResCaseQuantitySenateItemsEN = JsonConvert.DeserializeObject<clsvVideoResCaseQuantitySenateItemsEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseQuantitySenateItemsEN;
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
public static clsvVideoResCaseQuantitySenateItemsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN = null;
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
objvVideoResCaseQuantitySenateItemsEN = JsonConvert.DeserializeObject<clsvVideoResCaseQuantitySenateItemsEN>((string)jobjReturn["ReturnObj"]);
return objvVideoResCaseQuantitySenateItemsEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenateItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoResCaseQuantitySenateItemsEN GetObjByid_microteachCaseQuantitySenateItem_Cache(long lngid_microteachCaseQuantitySenateItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCaseQuantitySenateItemsEN._CurrTabName_S);
List<clsvVideoResCaseQuantitySenateItemsEN> arrvVideoResCaseQuantitySenateItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCaseQuantitySenateItemsEN> arrvVideoResCaseQuantitySenateItemsObjLst_Sel =
from objvVideoResCaseQuantitySenateItemsEN in arrvVideoResCaseQuantitySenateItemsObjLst_Cache
where objvVideoResCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem == lngid_microteachCaseQuantitySenateItem
select objvVideoResCaseQuantitySenateItemsEN;
if (arrvVideoResCaseQuantitySenateItemsObjLst_Sel.Count() == 0)
{
   clsvVideoResCaseQuantitySenateItemsEN obj = clsvVideoResCaseQuantitySenateItemsWApi.GetObjByid_microteachCaseQuantitySenateItem(lngid_microteachCaseQuantitySenateItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoResCaseQuantitySenateItemsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCaseQuantitySenateItemsEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateItemsEN> GetObjLstById_microteachCaseQuantitySenateItemLst(List<long> arrId_microteachCaseQuantitySenateItem)
{
 List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateItemLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenateItem);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_microteachCaseQuantitySenateItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvVideoResCaseQuantitySenateItemsEN> GetObjLstById_microteachCaseQuantitySenateItemLst_Cache(List<long> arrId_microteachCaseQuantitySenateItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoResCaseQuantitySenateItemsEN._CurrTabName_S);
List<clsvVideoResCaseQuantitySenateItemsEN> arrvVideoResCaseQuantitySenateItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoResCaseQuantitySenateItemsEN> arrvVideoResCaseQuantitySenateItemsObjLst_Sel =
from objvVideoResCaseQuantitySenateItemsEN in arrvVideoResCaseQuantitySenateItemsObjLst_Cache
where arrId_microteachCaseQuantitySenateItem.Contains(objvVideoResCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem)
select objvVideoResCaseQuantitySenateItemsEN;
return arrvVideoResCaseQuantitySenateItemsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoResCaseQuantitySenateItemsEN> GetObjLstById_microteachCaseQuantitySenateItemLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenateItem)
{
 List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateItemLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenateItem);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateItemsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateItemsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoResCaseQuantitySenateItemsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoResCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_microteachCaseQuantitySenateItem)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenateItem"] = lngid_microteachCaseQuantitySenateItem.ToString()
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
 /// <param name = "objvVideoResCaseQuantitySenateItemsENS">源对象</param>
 /// <param name = "objvVideoResCaseQuantitySenateItemsENT">目标对象</param>
 public static void CopyTo(clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsENS, clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsENT)
{
try
{
objvVideoResCaseQuantitySenateItemsENT.id_microteachCaseQuantitySenateItem = objvVideoResCaseQuantitySenateItemsENS.id_microteachCaseQuantitySenateItem; //微格量化评价指标流水号
objvVideoResCaseQuantitySenateItemsENT.id_microteachCaseQuantitySenate = objvVideoResCaseQuantitySenateItemsENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvVideoResCaseQuantitySenateItemsENT.VideoResCaseID = objvVideoResCaseQuantitySenateItemsENS.VideoResCaseID; //视频资源案例ID
objvVideoResCaseQuantitySenateItemsENT.VideoResCaseName = objvVideoResCaseQuantitySenateItemsENS.VideoResCaseName; //视频资源案例名称
objvVideoResCaseQuantitySenateItemsENT.id_AppraiseType = objvVideoResCaseQuantitySenateItemsENS.id_AppraiseType; //评议类型流水号
objvVideoResCaseQuantitySenateItemsENT.AppraiseTypeName = objvVideoResCaseQuantitySenateItemsENS.AppraiseTypeName; //评议类型名称
objvVideoResCaseQuantitySenateItemsENT.UserId = objvVideoResCaseQuantitySenateItemsENS.UserId; //用户ID
objvVideoResCaseQuantitySenateItemsENT.id_MicroteachCase = objvVideoResCaseQuantitySenateItemsENS.id_MicroteachCase; //微格教学案例流水号
objvVideoResCaseQuantitySenateItemsENT.CollegeID = objvVideoResCaseQuantitySenateItemsENS.CollegeID; //学院ID
objvVideoResCaseQuantitySenateItemsENT.CollegeName = objvVideoResCaseQuantitySenateItemsENS.CollegeName; //学院名称
objvVideoResCaseQuantitySenateItemsENT.CourseId = objvVideoResCaseQuantitySenateItemsENS.CourseId; //课程Id
objvVideoResCaseQuantitySenateItemsENT.SenateTheme = objvVideoResCaseQuantitySenateItemsENS.SenateTheme; //量化评价主题
objvVideoResCaseQuantitySenateItemsENT.SenateContent = objvVideoResCaseQuantitySenateItemsENS.SenateContent; //评价内容
objvVideoResCaseQuantitySenateItemsENT.SenateTotalScore = objvVideoResCaseQuantitySenateItemsENS.SenateTotalScore; //评价分数
objvVideoResCaseQuantitySenateItemsENT.SenateDate = objvVideoResCaseQuantitySenateItemsENS.SenateDate; //评价日期
objvVideoResCaseQuantitySenateItemsENT.SenateTime = objvVideoResCaseQuantitySenateItemsENS.SenateTime; //评价时间
objvVideoResCaseQuantitySenateItemsENT.id_SenateGaugeVersion = objvVideoResCaseQuantitySenateItemsENS.id_SenateGaugeVersion; //评价量表版本流水号
objvVideoResCaseQuantitySenateItemsENT.FuncModuleName = objvVideoResCaseQuantitySenateItemsENS.FuncModuleName; //功能模块名称
objvVideoResCaseQuantitySenateItemsENT.FuncModuleId = objvVideoResCaseQuantitySenateItemsENS.FuncModuleId; //功能模块Id
objvVideoResCaseQuantitySenateItemsENT.SenateIp = objvVideoResCaseQuantitySenateItemsENS.SenateIp; //评议Ip
objvVideoResCaseQuantitySenateItemsENT.UserTypeName = objvVideoResCaseQuantitySenateItemsENS.UserTypeName; //用户类型名称
objvVideoResCaseQuantitySenateItemsENT.UserName = objvVideoResCaseQuantitySenateItemsENS.UserName; //用户名
objvVideoResCaseQuantitySenateItemsENT.UserNameWithUserId = objvVideoResCaseQuantitySenateItemsENS.UserNameWithUserId; //UserNameWithUserId
objvVideoResCaseQuantitySenateItemsENT.UserKindId = objvVideoResCaseQuantitySenateItemsENS.UserKindId; //用户类别Id
objvVideoResCaseQuantitySenateItemsENT.UserKindName = objvVideoResCaseQuantitySenateItemsENS.UserKindName; //用户类别名
objvVideoResCaseQuantitySenateItemsENT.id_XzCollege = objvVideoResCaseQuantitySenateItemsENS.id_XzCollege; //学院流水号
objvVideoResCaseQuantitySenateItemsENT.id_XzMajor = objvVideoResCaseQuantitySenateItemsENS.id_XzMajor; //专业流水号
objvVideoResCaseQuantitySenateItemsENT.CollegeNameA = objvVideoResCaseQuantitySenateItemsENS.CollegeNameA; //学院名称简写
objvVideoResCaseQuantitySenateItemsENT.SenateScore = objvVideoResCaseQuantitySenateItemsENS.SenateScore; //指标得分
objvVideoResCaseQuantitySenateItemsENT.id_SenateGaugeItem = objvVideoResCaseQuantitySenateItemsENS.id_SenateGaugeItem; //量表指标流水号
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemID = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemID; //量表指标ID
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemName = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemName; //量表指标名称
objvVideoResCaseQuantitySenateItemsENT.senateGaugeVersionName = objvVideoResCaseQuantitySenateItemsENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemDesc = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemDesc; //量表指标说明
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemWeight = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemWeight; //量表指标权重
objvVideoResCaseQuantitySenateItemsENT.AnswerModeId = objvVideoResCaseQuantitySenateItemsENS.AnswerModeId; //答案模式Id
objvVideoResCaseQuantitySenateItemsENT.AnswerTypeId = objvVideoResCaseQuantitySenateItemsENS.AnswerTypeId; //答案类型ID
objvVideoResCaseQuantitySenateItemsENT.GridTitle = objvVideoResCaseQuantitySenateItemsENS.GridTitle; //表格标题
objvVideoResCaseQuantitySenateItemsENT.QuestionIndex = objvVideoResCaseQuantitySenateItemsENS.QuestionIndex; //题目序号
objvVideoResCaseQuantitySenateItemsENT.senateGaugeVersionID = objvVideoResCaseQuantitySenateItemsENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCaseQuantitySenateItemsENT.QuestionNo = objvVideoResCaseQuantitySenateItemsENS.QuestionNo; //题目编号
objvVideoResCaseQuantitySenateItemsENT.QuestionTypeId = objvVideoResCaseQuantitySenateItemsENS.QuestionTypeId; //题目类型Id
objvVideoResCaseQuantitySenateItemsENT.senateGaugeVersionTtlScore = objvVideoResCaseQuantitySenateItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCaseQuantitySenateItemsENT.AnswerTypeName = objvVideoResCaseQuantitySenateItemsENS.AnswerTypeName; //答案类型名
objvVideoResCaseQuantitySenateItemsENT.AnswerModeName = objvVideoResCaseQuantitySenateItemsENS.AnswerModeName; //答案模式名称
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemMemo = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemMemo; //备注
objvVideoResCaseQuantitySenateItemsENT.QuestionTypeName = objvVideoResCaseQuantitySenateItemsENS.QuestionTypeName; //题目类型名
objvVideoResCaseQuantitySenateItemsENT.AnswerNum = objvVideoResCaseQuantitySenateItemsENS.AnswerNum; //答案数
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemNameWithOrder = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvVideoResCaseQuantitySenateItemsENT.id_SenateGaugeSubItem = objvVideoResCaseQuantitySenateItemsENS.id_SenateGaugeSubItem; //量表指标子项流水号
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemID = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemID; //量表指标子项ID
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemName = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemName; //量表指标子项名称
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemScore = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemDesc = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objvVideoResCaseQuantitySenateItemsENT.AnswerTitle = objvVideoResCaseQuantitySenateItemsENS.AnswerTitle; //答案标题
objvVideoResCaseQuantitySenateItemsENT.AnswerIndex = objvVideoResCaseQuantitySenateItemsENS.AnswerIndex; //问答序号
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemMemo = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
objvVideoResCaseQuantitySenateItemsENT.IsAccess = objvVideoResCaseQuantitySenateItemsENS.IsAccess; //IsAccess
objvVideoResCaseQuantitySenateItemsENT.IsAccessC = objvVideoResCaseQuantitySenateItemsENS.IsAccessC; //IsAccessC
objvVideoResCaseQuantitySenateItemsENT.UpdDate = objvVideoResCaseQuantitySenateItemsENS.UpdDate; //修改日期
objvVideoResCaseQuantitySenateItemsENT.UpdUser = objvVideoResCaseQuantitySenateItemsENS.UpdUser; //修改人
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
public static DataTable ToDataTable(List<clsvVideoResCaseQuantitySenateItemsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoResCaseQuantitySenateItemsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoResCaseQuantitySenateItemsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoResCaseQuantitySenateItemsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoResCaseQuantitySenateItemsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoResCaseQuantitySenateItemsEN.AttributeName)
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
if (clsSenateGaugeSubItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeSubItemsWApi没有刷新缓存机制(clsSenateGaugeSubItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateItemsWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeItemsWApi没有刷新缓存机制(clsSenateGaugeItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoResCaseWApi没有刷新缓存机制(clsVideoResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoResCaseTypeWApi没有刷新缓存机制(clsVideoResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenateItem");
//if (arrvVideoResCaseQuantitySenateItemsObjLst_Cache == null)
//{
//arrvVideoResCaseQuantitySenateItemsObjLst_Cache = await clsvVideoResCaseQuantitySenateItemsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoResCaseQuantitySenateItemsEN._CurrTabName_S);
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
public static List<clsvVideoResCaseQuantitySenateItemsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoResCaseQuantitySenateItemsEN._CurrTabName_S);
List<clsvVideoResCaseQuantitySenateItemsEN> arrvVideoResCaseQuantitySenateItemsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoResCaseQuantitySenateItemsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.VideoResCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.VideoResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.SenateScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.id_SenateGaugeItem, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemDesc, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemWeight, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.AnswerModeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemMemo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.AnswerNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.AnswerTitle, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.AnswerIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.IsAccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.IsAccessC, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoResCaseQuantitySenateItems.UpdUser, Type.GetType("System.String"));
foreach (clsvVideoResCaseQuantitySenateItemsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem] = objInFor[convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem];
objDR[convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate] = objInFor[convVideoResCaseQuantitySenateItems.id_microteachCaseQuantitySenate];
objDR[convVideoResCaseQuantitySenateItems.VideoResCaseID] = objInFor[convVideoResCaseQuantitySenateItems.VideoResCaseID];
objDR[convVideoResCaseQuantitySenateItems.VideoResCaseName] = objInFor[convVideoResCaseQuantitySenateItems.VideoResCaseName];
objDR[convVideoResCaseQuantitySenateItems.id_AppraiseType] = objInFor[convVideoResCaseQuantitySenateItems.id_AppraiseType];
objDR[convVideoResCaseQuantitySenateItems.AppraiseTypeName] = objInFor[convVideoResCaseQuantitySenateItems.AppraiseTypeName];
objDR[convVideoResCaseQuantitySenateItems.UserId] = objInFor[convVideoResCaseQuantitySenateItems.UserId];
objDR[convVideoResCaseQuantitySenateItems.id_MicroteachCase] = objInFor[convVideoResCaseQuantitySenateItems.id_MicroteachCase];
objDR[convVideoResCaseQuantitySenateItems.CollegeID] = objInFor[convVideoResCaseQuantitySenateItems.CollegeID];
objDR[convVideoResCaseQuantitySenateItems.CollegeName] = objInFor[convVideoResCaseQuantitySenateItems.CollegeName];
objDR[convVideoResCaseQuantitySenateItems.CourseId] = objInFor[convVideoResCaseQuantitySenateItems.CourseId];
objDR[convVideoResCaseQuantitySenateItems.SenateTheme] = objInFor[convVideoResCaseQuantitySenateItems.SenateTheme];
objDR[convVideoResCaseQuantitySenateItems.SenateContent] = objInFor[convVideoResCaseQuantitySenateItems.SenateContent];
objDR[convVideoResCaseQuantitySenateItems.SenateTotalScore] = objInFor[convVideoResCaseQuantitySenateItems.SenateTotalScore];
objDR[convVideoResCaseQuantitySenateItems.SenateDate] = objInFor[convVideoResCaseQuantitySenateItems.SenateDate];
objDR[convVideoResCaseQuantitySenateItems.SenateTime] = objInFor[convVideoResCaseQuantitySenateItems.SenateTime];
objDR[convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion] = objInFor[convVideoResCaseQuantitySenateItems.id_SenateGaugeVersion];
objDR[convVideoResCaseQuantitySenateItems.FuncModuleName] = objInFor[convVideoResCaseQuantitySenateItems.FuncModuleName];
objDR[convVideoResCaseQuantitySenateItems.FuncModuleId] = objInFor[convVideoResCaseQuantitySenateItems.FuncModuleId];
objDR[convVideoResCaseQuantitySenateItems.SenateIp] = objInFor[convVideoResCaseQuantitySenateItems.SenateIp];
objDR[convVideoResCaseQuantitySenateItems.UserTypeName] = objInFor[convVideoResCaseQuantitySenateItems.UserTypeName];
objDR[convVideoResCaseQuantitySenateItems.UserName] = objInFor[convVideoResCaseQuantitySenateItems.UserName];
objDR[convVideoResCaseQuantitySenateItems.UserNameWithUserId] = objInFor[convVideoResCaseQuantitySenateItems.UserNameWithUserId];
objDR[convVideoResCaseQuantitySenateItems.UserKindId] = objInFor[convVideoResCaseQuantitySenateItems.UserKindId];
objDR[convVideoResCaseQuantitySenateItems.UserKindName] = objInFor[convVideoResCaseQuantitySenateItems.UserKindName];
objDR[convVideoResCaseQuantitySenateItems.id_XzCollege] = objInFor[convVideoResCaseQuantitySenateItems.id_XzCollege];
objDR[convVideoResCaseQuantitySenateItems.id_XzMajor] = objInFor[convVideoResCaseQuantitySenateItems.id_XzMajor];
objDR[convVideoResCaseQuantitySenateItems.CollegeNameA] = objInFor[convVideoResCaseQuantitySenateItems.CollegeNameA];
objDR[convVideoResCaseQuantitySenateItems.SenateScore] = objInFor[convVideoResCaseQuantitySenateItems.SenateScore];
objDR[convVideoResCaseQuantitySenateItems.id_SenateGaugeItem] = objInFor[convVideoResCaseQuantitySenateItems.id_SenateGaugeItem];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeItemID] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeItemID];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeItemName] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeItemName];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeVersionName] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeVersionName];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight];
objDR[convVideoResCaseQuantitySenateItems.AnswerModeId] = objInFor[convVideoResCaseQuantitySenateItems.AnswerModeId];
objDR[convVideoResCaseQuantitySenateItems.AnswerTypeId] = objInFor[convVideoResCaseQuantitySenateItems.AnswerTypeId];
objDR[convVideoResCaseQuantitySenateItems.GridTitle] = objInFor[convVideoResCaseQuantitySenateItems.GridTitle];
objDR[convVideoResCaseQuantitySenateItems.QuestionIndex] = objInFor[convVideoResCaseQuantitySenateItems.QuestionIndex];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeVersionID] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeVersionID];
objDR[convVideoResCaseQuantitySenateItems.QuestionNo] = objInFor[convVideoResCaseQuantitySenateItems.QuestionNo];
objDR[convVideoResCaseQuantitySenateItems.QuestionTypeId] = objInFor[convVideoResCaseQuantitySenateItems.QuestionTypeId];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore];
objDR[convVideoResCaseQuantitySenateItems.AnswerTypeName] = objInFor[convVideoResCaseQuantitySenateItems.AnswerTypeName];
objDR[convVideoResCaseQuantitySenateItems.AnswerModeName] = objInFor[convVideoResCaseQuantitySenateItems.AnswerModeName];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo];
objDR[convVideoResCaseQuantitySenateItems.QuestionTypeName] = objInFor[convVideoResCaseQuantitySenateItems.QuestionTypeName];
objDR[convVideoResCaseQuantitySenateItems.AnswerNum] = objInFor[convVideoResCaseQuantitySenateItems.AnswerNum];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder];
objDR[convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem] = objInFor[convVideoResCaseQuantitySenateItems.id_SenateGaugeSubItem];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc];
objDR[convVideoResCaseQuantitySenateItems.AnswerTitle] = objInFor[convVideoResCaseQuantitySenateItems.AnswerTitle];
objDR[convVideoResCaseQuantitySenateItems.AnswerIndex] = objInFor[convVideoResCaseQuantitySenateItems.AnswerIndex];
objDR[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo] = objInFor[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo];
objDR[convVideoResCaseQuantitySenateItems.IsAccess] = objInFor[convVideoResCaseQuantitySenateItems.IsAccess];
objDR[convVideoResCaseQuantitySenateItems.IsAccessC] = objInFor[convVideoResCaseQuantitySenateItems.IsAccessC];
objDR[convVideoResCaseQuantitySenateItems.UpdDate] = objInFor[convVideoResCaseQuantitySenateItems.UpdDate];
objDR[convVideoResCaseQuantitySenateItems.UpdUser] = objInFor[convVideoResCaseQuantitySenateItems.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}