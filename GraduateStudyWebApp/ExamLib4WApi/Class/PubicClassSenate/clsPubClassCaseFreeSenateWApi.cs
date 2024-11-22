
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseFreeSenateWApi
 表名:PubClassCaseFreeSenate(01120413)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:13
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
public static class clsPubClassCaseFreeSenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN Setid_PubClassCaseFreeSenate(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, long lngid_PubClassCaseFreeSenate, string strComparisonOp="")
	{
objPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate = lngid_PubClassCaseFreeSenate; //公开课案例自由评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.id_PubClassCaseFreeSenate) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.id_PubClassCaseFreeSenate, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.id_PubClassCaseFreeSenate] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN Setid_PubClassCase(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCase, conPubClassCaseFreeSenate.id_PubClassCase);
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, conPubClassCaseFreeSenate.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, conPubClassCaseFreeSenate.id_PubClassCase);
objPubClassCaseFreeSenateEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.id_PubClassCase) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.id_PubClassCase, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.id_PubClassCase] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetUserId(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conPubClassCaseFreeSenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, conPubClassCaseFreeSenate.UserId);
objPubClassCaseFreeSenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.UserId) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.UserId, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.UserId] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetAppraiseTheme(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strAppraiseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTheme, 200, conPubClassCaseFreeSenate.AppraiseTheme);
objPubClassCaseFreeSenateEN.AppraiseTheme = strAppraiseTheme; //评议主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.AppraiseTheme) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.AppraiseTheme, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.AppraiseTheme] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateTitle(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateTitle, 200, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle);
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle = strPubClassCaseFreeSenateTitle; //公开课案例自由评议标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateConten(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateConten, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateConten, 2000, conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten);
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten = strPubClassCaseFreeSenateConten; //公开课案例自由评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateDate(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateDate, 8, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseFreeSenateDate, 8, conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate);
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate = strPubClassCaseFreeSenateDate; //公开课案例自由评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetPubClassCaseFreeSenateTime(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strPubClassCaseFreeSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseFreeSenateTime, 6, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseFreeSenateTime, 6, conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime);
objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime = strPubClassCaseFreeSenateTime; //公开课案例自由评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetVideoStopTime(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strVideoStopTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoStopTime, 48, conPubClassCaseFreeSenate.VideoStopTime);
objPubClassCaseFreeSenateEN.VideoStopTime = strVideoStopTime; //公开课案例视频暂停时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.VideoStopTime) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.VideoStopTime, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.VideoStopTime] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetVideoStopImage(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, byte[] bytVideoStopImage, string strComparisonOp="")
	{
objPubClassCaseFreeSenateEN.VideoStopImage = bytVideoStopImage; //公开课案例视频暂停截图
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.VideoStopImage) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.VideoStopImage, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.VideoStopImage] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseFreeSenateEN SetBrowseCount(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, int intBrowseCount, string strComparisonOp="")
	{
objPubClassCaseFreeSenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseFreeSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseFreeSenate.BrowseCount) == false)
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp.Add(conPubClassCaseFreeSenate.BrowseCount, strComparisonOp);
}
else
{
objPubClassCaseFreeSenateEN.dicFldComparisonOp[conPubClassCaseFreeSenate.BrowseCount] = strComparisonOp;
}
}
return objPubClassCaseFreeSenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.id_PubClassCaseFreeSenate) == true)
{
string strComparisonOp_id_PubClassCaseFreeSenate = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.id_PubClassCaseFreeSenate];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseFreeSenate.id_PubClassCaseFreeSenate, objPubClassCaseFreeSenate_Cond.id_PubClassCaseFreeSenate, strComparisonOp_id_PubClassCaseFreeSenate);
}
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.id_PubClassCase, objPubClassCaseFreeSenate_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.UserId) == true)
{
string strComparisonOp_UserId = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.UserId, objPubClassCaseFreeSenate_Cond.UserId, strComparisonOp_UserId);
}
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.AppraiseTheme) == true)
{
string strComparisonOp_AppraiseTheme = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.AppraiseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.AppraiseTheme, objPubClassCaseFreeSenate_Cond.AppraiseTheme, strComparisonOp_AppraiseTheme);
}
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle) == true)
{
string strComparisonOp_PubClassCaseFreeSenateTitle = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, objPubClassCaseFreeSenate_Cond.PubClassCaseFreeSenateTitle, strComparisonOp_PubClassCaseFreeSenateTitle);
}
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten) == true)
{
string strComparisonOp_PubClassCaseFreeSenateConten = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, objPubClassCaseFreeSenate_Cond.PubClassCaseFreeSenateConten, strComparisonOp_PubClassCaseFreeSenateConten);
}
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate) == true)
{
string strComparisonOp_PubClassCaseFreeSenateDate = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, objPubClassCaseFreeSenate_Cond.PubClassCaseFreeSenateDate, strComparisonOp_PubClassCaseFreeSenateDate);
}
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime) == true)
{
string strComparisonOp_PubClassCaseFreeSenateTime = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, objPubClassCaseFreeSenate_Cond.PubClassCaseFreeSenateTime, strComparisonOp_PubClassCaseFreeSenateTime);
}
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.VideoStopTime) == true)
{
string strComparisonOp_VideoStopTime = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.VideoStopTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseFreeSenate.VideoStopTime, objPubClassCaseFreeSenate_Cond.VideoStopTime, strComparisonOp_VideoStopTime);
}
//数据类型byte[](image)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objPubClassCaseFreeSenate_Cond.IsUpdated(conPubClassCaseFreeSenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objPubClassCaseFreeSenate_Cond.dicFldComparisonOp[conPubClassCaseFreeSenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseFreeSenate.BrowseCount, objPubClassCaseFreeSenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
 if (objPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPubClassCaseFreeSenateEN.sf_UpdFldSetStr = objPubClassCaseFreeSenateEN.getsf_UpdFldSetStr();
clsPubClassCaseFreeSenateWApi.CheckPropertyNew(objPubClassCaseFreeSenateEN); 
bool bolResult = clsPubClassCaseFreeSenateWApi.UpdateRecord(objPubClassCaseFreeSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PubClassCaseFreeSenate(公开课案例自由评议), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_PubClassCase_UserId_AppraiseTheme(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPubClassCaseFreeSenateEN == null) return "";
if (objPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_PubClassCase = '{0}'", objPubClassCaseFreeSenateEN.id_PubClassCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPubClassCaseFreeSenateEN.UserId);
 sbCondition.AppendFormat(" and AppraiseTheme = '{0}'", objPubClassCaseFreeSenateEN.AppraiseTheme);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_PubClassCaseFreeSenate !=  {0}", objPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate);
 sbCondition.AppendFormat(" and id_PubClassCase = '{0}'", objPubClassCaseFreeSenateEN.id_PubClassCase);
 sbCondition.AppendFormat(" and UserId = '{0}'", objPubClassCaseFreeSenateEN.UserId);
 sbCondition.AppendFormat(" and AppraiseTheme = '{0}'", objPubClassCaseFreeSenateEN.AppraiseTheme);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
try
{
clsPubClassCaseFreeSenateWApi.CheckPropertyNew(objPubClassCaseFreeSenateEN); 
bool bolResult = clsPubClassCaseFreeSenateWApi.AddNewRecord(objPubClassCaseFreeSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strWhereCond)
{
try
{
clsPubClassCaseFreeSenateWApi.CheckPropertyNew(objPubClassCaseFreeSenateEN); 
bool bolResult = clsPubClassCaseFreeSenateWApi.UpdateWithCondition(objPubClassCaseFreeSenateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 公开课案例自由评议(PubClassCaseFreeSenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPubClassCaseFreeSenateWApi
{
private static readonly string mstrApiControllerName = "PubClassCaseFreeSenateApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsPubClassCaseFreeSenateWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
if (!Object.Equals(null, objPubClassCaseFreeSenateEN.id_PubClassCase) && GetStrLen(objPubClassCaseFreeSenateEN.id_PubClassCase) > 8)
{
 throw new Exception("字段[案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseFreeSenateEN.UserId) && GetStrLen(objPubClassCaseFreeSenateEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objPubClassCaseFreeSenateEN.AppraiseTheme) && GetStrLen(objPubClassCaseFreeSenateEN.AppraiseTheme) > 200)
{
 throw new Exception("字段[评议主题]的长度不能超过200!");
}
if (!Object.Equals(null, objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle) && GetStrLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTitle) > 200)
{
 throw new Exception("字段[公开课案例自由评议标题]的长度不能超过200!");
}
if (!Object.Equals(null, objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten) && GetStrLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateConten) > 2000)
{
 throw new Exception("字段[公开课案例自由评议内容]的长度不能超过2000!");
}
if (!Object.Equals(null, objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate) && GetStrLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateDate) > 8)
{
 throw new Exception("字段[公开课案例自由评议日期]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime) && GetStrLen(objPubClassCaseFreeSenateEN.PubClassCaseFreeSenateTime) > 6)
{
 throw new Exception("字段[公开课案例自由评议时间]的长度不能超过6!");
}
if (!Object.Equals(null, objPubClassCaseFreeSenateEN.VideoStopTime) && GetStrLen(objPubClassCaseFreeSenateEN.VideoStopTime) > 48)
{
 throw new Exception("字段[公开课案例视频暂停时间]的长度不能超过48!");
}
 objPubClassCaseFreeSenateEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_PubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseFreeSenateEN GetObjByid_PubClassCaseFreeSenate(long lngid_PubClassCaseFreeSenate)
{
string strAction = "GetObjByid_PubClassCaseFreeSenate";
string strErrMsg = string.Empty;
string strResult = "";
clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseFreeSenate"] = lngid_PubClassCaseFreeSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPubClassCaseFreeSenateEN = JsonConvert.DeserializeObject<clsPubClassCaseFreeSenateEN>((string)jobjReturn["ReturnObj"]);
return objPubClassCaseFreeSenateEN;
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
 /// <param name = "lngid_PubClassCaseFreeSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseFreeSenateEN GetObjByid_PubClassCaseFreeSenate_WA_Cache(long lngid_PubClassCaseFreeSenate)
{
string strAction = "GetObjByid_PubClassCaseFreeSenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseFreeSenate"] = lngid_PubClassCaseFreeSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPubClassCaseFreeSenateEN = JsonConvert.DeserializeObject<clsPubClassCaseFreeSenateEN>((string)jobjReturn["ReturnObj"]);
return objPubClassCaseFreeSenateEN;
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
public static clsPubClassCaseFreeSenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = null;
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
objPubClassCaseFreeSenateEN = JsonConvert.DeserializeObject<clsPubClassCaseFreeSenateEN>((string)jobjReturn["ReturnObj"]);
return objPubClassCaseFreeSenateEN;
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
 /// <param name = "lngid_PubClassCaseFreeSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseFreeSenateEN GetObjByid_PubClassCaseFreeSenate_Cache(long lngid_PubClassCaseFreeSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName_S);
List<clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLst_Sel =
from objPubClassCaseFreeSenateEN in arrPubClassCaseFreeSenateObjLst_Cache
where objPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate == lngid_PubClassCaseFreeSenate
select objPubClassCaseFreeSenateEN;
if (arrPubClassCaseFreeSenateObjLst_Sel.Count() == 0)
{
   clsPubClassCaseFreeSenateEN obj = clsPubClassCaseFreeSenateWApi.GetObjByid_PubClassCaseFreeSenate(lngid_PubClassCaseFreeSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPubClassCaseFreeSenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetObjLst(string strWhereCond)
{
 List<clsPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseFreeSenateEN> GetObjLstById_PubClassCaseFreeSenateLst(List<long> arrId_PubClassCaseFreeSenate)
{
 List<clsPubClassCaseFreeSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseFreeSenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseFreeSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_PubClassCaseFreeSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsPubClassCaseFreeSenateEN> GetObjLstById_PubClassCaseFreeSenateLst_Cache(List<long> arrId_PubClassCaseFreeSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName_S);
List<clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLst_Sel =
from objPubClassCaseFreeSenateEN in arrPubClassCaseFreeSenateObjLst_Cache
where arrId_PubClassCaseFreeSenate.Contains(objPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate)
select objPubClassCaseFreeSenateEN;
return arrPubClassCaseFreeSenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetObjLstById_PubClassCaseFreeSenateLst_WA_Cache(List<long> arrId_PubClassCaseFreeSenate)
{
 List<clsPubClassCaseFreeSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseFreeSenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseFreeSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseFreeSenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseFreeSenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseFreeSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseFreeSenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsPubClassCaseFreeSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseFreeSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngid_PubClassCaseFreeSenate)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN = clsPubClassCaseFreeSenateWApi.GetObjByid_PubClassCaseFreeSenate(lngid_PubClassCaseFreeSenate);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_PubClassCaseFreeSenate.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPubClassCaseFreeSenateWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelPubClassCaseFreeSenates(List<string> arrid_PubClassCaseFreeSenate)
{
string strAction = "DelPubClassCaseFreeSenates";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_PubClassCaseFreeSenate);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPubClassCaseFreeSenateWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelPubClassCaseFreeSenatesByCond(string strWhereCond)
{
string strAction = "DelPubClassCaseFreeSenatesByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseFreeSenateEN>(objPubClassCaseFreeSenateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseFreeSenateEN>(objPubClassCaseFreeSenateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateWApi.ReFreshCache();
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN)
{
if (string.IsNullOrEmpty(objPubClassCaseFreeSenateEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseFreeSenateEN>(objPubClassCaseFreeSenateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPubClassCaseFreeSenateEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubClassCaseFreeSenateEN.id_PubClassCaseFreeSenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseFreeSenateEN>(objPubClassCaseFreeSenateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(long lngid_PubClassCaseFreeSenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseFreeSenate"] = lngid_PubClassCaseFreeSenate.ToString()
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objPubClassCaseFreeSenateENS">源对象</param>
 /// <param name = "objPubClassCaseFreeSenateENT">目标对象</param>
 public static void CopyTo(clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENS, clsPubClassCaseFreeSenateEN objPubClassCaseFreeSenateENT)
{
try
{
objPubClassCaseFreeSenateENT.id_PubClassCaseFreeSenate = objPubClassCaseFreeSenateENS.id_PubClassCaseFreeSenate; //公开课案例自由评议流水号
objPubClassCaseFreeSenateENT.id_PubClassCase = objPubClassCaseFreeSenateENS.id_PubClassCase; //案例流水号
objPubClassCaseFreeSenateENT.UserId = objPubClassCaseFreeSenateENS.UserId; //用户ID
objPubClassCaseFreeSenateENT.AppraiseTheme = objPubClassCaseFreeSenateENS.AppraiseTheme; //评议主题
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTitle = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTitle; //公开课案例自由评议标题
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateConten = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateConten; //公开课案例自由评议内容
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateDate = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateDate; //公开课案例自由评议日期
objPubClassCaseFreeSenateENT.PubClassCaseFreeSenateTime = objPubClassCaseFreeSenateENS.PubClassCaseFreeSenateTime; //公开课案例自由评议时间
objPubClassCaseFreeSenateENT.VideoStopTime = objPubClassCaseFreeSenateENS.VideoStopTime; //公开课案例视频暂停时间
objPubClassCaseFreeSenateENT.VideoStopImage = objPubClassCaseFreeSenateENS.VideoStopImage; //公开课案例视频暂停截图
objPubClassCaseFreeSenateENT.BrowseCount = objPubClassCaseFreeSenateENS.BrowseCount; //浏览次数
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
public static DataTable ToDataTable(List<clsPubClassCaseFreeSenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPubClassCaseFreeSenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPubClassCaseFreeSenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPubClassCaseFreeSenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPubClassCaseFreeSenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPubClassCaseFreeSenateEN.AttributeName)
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
if (clsPubClassCaseFreeSenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseFreeSenateWApi没有刷新缓存机制(clsPubClassCaseFreeSenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubClassCaseFreeSenate");
//if (arrPubClassCaseFreeSenateObjLst_Cache == null)
//{
//arrPubClassCaseFreeSenateObjLst_Cache = await clsPubClassCaseFreeSenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsPubClassCaseFreeSenateWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsPubClassCaseFreeSenateWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseFreeSenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsPubClassCaseFreeSenateEN._CurrTabName_S);
List<clsPubClassCaseFreeSenateEN> arrPubClassCaseFreeSenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPubClassCaseFreeSenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPubClassCaseFreeSenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPubClassCaseFreeSenate.id_PubClassCaseFreeSenate, Type.GetType("System.Int64"));
objDT.Columns.Add(conPubClassCaseFreeSenate.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseFreeSenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseFreeSenate.AppraiseTheme, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseFreeSenate.VideoStopTime, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseFreeSenate.VideoStopImage, Type.GetType("System.Byte[]"));
objDT.Columns.Add(conPubClassCaseFreeSenate.BrowseCount, Type.GetType("System.Int32"));
foreach (clsPubClassCaseFreeSenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPubClassCaseFreeSenate.id_PubClassCaseFreeSenate] = objInFor[conPubClassCaseFreeSenate.id_PubClassCaseFreeSenate];
objDR[conPubClassCaseFreeSenate.id_PubClassCase] = objInFor[conPubClassCaseFreeSenate.id_PubClassCase];
objDR[conPubClassCaseFreeSenate.UserId] = objInFor[conPubClassCaseFreeSenate.UserId];
objDR[conPubClassCaseFreeSenate.AppraiseTheme] = objInFor[conPubClassCaseFreeSenate.AppraiseTheme];
objDR[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle] = objInFor[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTitle];
objDR[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten] = objInFor[conPubClassCaseFreeSenate.PubClassCaseFreeSenateConten];
objDR[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate] = objInFor[conPubClassCaseFreeSenate.PubClassCaseFreeSenateDate];
objDR[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime] = objInFor[conPubClassCaseFreeSenate.PubClassCaseFreeSenateTime];
objDR[conPubClassCaseFreeSenate.VideoStopTime] = objInFor[conPubClassCaseFreeSenate.VideoStopTime];
objDR[conPubClassCaseFreeSenate.VideoStopImage] = objInFor[conPubClassCaseFreeSenate.VideoStopImage];
objDR[conPubClassCaseFreeSenate.BrowseCount] = objInFor[conPubClassCaseFreeSenate.BrowseCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 公开课案例自由评议(PubClassCaseFreeSenate)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4PubClassCaseFreeSenate : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseFreeSenateWApi.ReFreshThisCache();
}
}

}