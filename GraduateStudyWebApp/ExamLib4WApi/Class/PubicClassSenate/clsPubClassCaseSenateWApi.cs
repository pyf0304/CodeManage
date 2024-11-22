
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseSenateWApi
 表名:PubClassCaseSenate(01120411)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:47
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
public static class clsPubClassCaseSenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN Setid_PubClassCaseSenate(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, long lngid_PubClassCaseSenate, string strComparisonOp="")
	{
objPubClassCaseSenateEN.id_PubClassCaseSenate = lngid_PubClassCaseSenate; //公开课案例评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.id_PubClassCaseSenate) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.id_PubClassCaseSenate, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.id_PubClassCaseSenate] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN Setid_PubClassCase(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCase, conPubClassCaseSenate.id_PubClassCase);
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, conPubClassCaseSenate.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, conPubClassCaseSenate.id_PubClassCase);
objPubClassCaseSenateEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.id_PubClassCase) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.id_PubClassCase, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.id_PubClassCase] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN Setid_PubClassCaseSenateClass(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strid_PubClassCaseSenateClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCaseSenateClass, conPubClassCaseSenate.id_PubClassCaseSenateClass);
clsCheckSql.CheckFieldLen(strid_PubClassCaseSenateClass, 4, conPubClassCaseSenate.id_PubClassCaseSenateClass);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCaseSenateClass, 4, conPubClassCaseSenate.id_PubClassCaseSenateClass);
objPubClassCaseSenateEN.id_PubClassCaseSenateClass = strid_PubClassCaseSenateClass; //公开课案例评议类别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.id_PubClassCaseSenateClass) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.id_PubClassCaseSenateClass, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.id_PubClassCaseSenateClass] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenator(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenator, 50, conPubClassCaseSenate.PubClassCaseSenator);
objPubClassCaseSenateEN.PubClassCaseSenator = strPubClassCaseSenator; //公开课案例评议者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenator) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenator, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenator] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenateTitle(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenateTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateTitle, 200, conPubClassCaseSenate.PubClassCaseSenateTitle);
objPubClassCaseSenateEN.PubClassCaseSenateTitle = strPubClassCaseSenateTitle; //公开课案例评议标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenateTitle) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenateTitle, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateTitle] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenateContent(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateContent, 8000, conPubClassCaseSenate.PubClassCaseSenateContent);
objPubClassCaseSenateEN.PubClassCaseSenateContent = strPubClassCaseSenateContent; //公开课案例评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenateContent) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenateContent, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateContent] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenateDate(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateDate, 8, conPubClassCaseSenate.PubClassCaseSenateDate);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseSenateDate, 8, conPubClassCaseSenate.PubClassCaseSenateDate);
objPubClassCaseSenateEN.PubClassCaseSenateDate = strPubClassCaseSenateDate; //公开课案例评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenateDate) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenateDate, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateDate] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN SetPubClassCaseSenateTime(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strPubClassCaseSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubClassCaseSenateTime, 6, conPubClassCaseSenate.PubClassCaseSenateTime);
clsCheckSql.CheckFieldForeignKey(strPubClassCaseSenateTime, 6, conPubClassCaseSenate.PubClassCaseSenateTime);
objPubClassCaseSenateEN.PubClassCaseSenateTime = strPubClassCaseSenateTime; //公开课案例评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.PubClassCaseSenateTime) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.PubClassCaseSenateTime, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateTime] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN SetSenateReadCount(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, int intSenateReadCount, string strComparisonOp="")
	{
objPubClassCaseSenateEN.SenateReadCount = intSenateReadCount; //评议阅读次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.SenateReadCount) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.SenateReadCount, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.SenateReadCount] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN SetIsVisual(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, bool bolIsVisual, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsVisual, conPubClassCaseSenate.IsVisual);
objPubClassCaseSenateEN.IsVisual = bolIsVisual; //隐藏标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.IsVisual) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.IsVisual, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.IsVisual] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN SetIsElite(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, bool bolIsElite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsElite, conPubClassCaseSenate.IsElite);
objPubClassCaseSenateEN.IsElite = bolIsElite; //精华标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.IsElite) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.IsElite, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.IsElite] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN Setid_Resource(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, conPubClassCaseSenate.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, conPubClassCaseSenate.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, conPubClassCaseSenate.id_Resource);
objPubClassCaseSenateEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.id_Resource) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.id_Resource, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.id_Resource] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubClassCaseSenateEN Setid_MediaType(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strid_MediaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MediaType, 4, conPubClassCaseSenate.id_MediaType);
clsCheckSql.CheckFieldForeignKey(strid_MediaType, 4, conPubClassCaseSenate.id_MediaType);
objPubClassCaseSenateEN.id_MediaType = strid_MediaType; //媒体格式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenate.id_MediaType) == false)
{
objPubClassCaseSenateEN.dicFldComparisonOp.Add(conPubClassCaseSenate.id_MediaType, strComparisonOp);
}
else
{
objPubClassCaseSenateEN.dicFldComparisonOp[conPubClassCaseSenate.id_MediaType] = strComparisonOp;
}
}
return objPubClassCaseSenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPubClassCaseSenateEN objPubClassCaseSenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.id_PubClassCaseSenate) == true)
{
string strComparisonOp_id_PubClassCaseSenate = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.id_PubClassCaseSenate];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseSenate.id_PubClassCaseSenate, objPubClassCaseSenate_Cond.id_PubClassCaseSenate, strComparisonOp_id_PubClassCaseSenate);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.id_PubClassCase, objPubClassCaseSenate_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.id_PubClassCaseSenateClass) == true)
{
string strComparisonOp_id_PubClassCaseSenateClass = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.id_PubClassCaseSenateClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.id_PubClassCaseSenateClass, objPubClassCaseSenate_Cond.id_PubClassCaseSenateClass, strComparisonOp_id_PubClassCaseSenateClass);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenator) == true)
{
string strComparisonOp_PubClassCaseSenator = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenator];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenator, objPubClassCaseSenate_Cond.PubClassCaseSenator, strComparisonOp_PubClassCaseSenator);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTitle) == true)
{
string strComparisonOp_PubClassCaseSenateTitle = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenateTitle, objPubClassCaseSenate_Cond.PubClassCaseSenateTitle, strComparisonOp_PubClassCaseSenateTitle);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateContent) == true)
{
string strComparisonOp_PubClassCaseSenateContent = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenateContent, objPubClassCaseSenate_Cond.PubClassCaseSenateContent, strComparisonOp_PubClassCaseSenateContent);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateDate) == true)
{
string strComparisonOp_PubClassCaseSenateDate = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenateDate, objPubClassCaseSenate_Cond.PubClassCaseSenateDate, strComparisonOp_PubClassCaseSenateDate);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.PubClassCaseSenateTime) == true)
{
string strComparisonOp_PubClassCaseSenateTime = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.PubClassCaseSenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.PubClassCaseSenateTime, objPubClassCaseSenate_Cond.PubClassCaseSenateTime, strComparisonOp_PubClassCaseSenateTime);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.SenateReadCount) == true)
{
string strComparisonOp_SenateReadCount = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.SenateReadCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseSenate.SenateReadCount, objPubClassCaseSenate_Cond.SenateReadCount, strComparisonOp_SenateReadCount);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.IsVisual) == true)
{
if (objPubClassCaseSenate_Cond.IsVisual == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCaseSenate.IsVisual);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCaseSenate.IsVisual);
}
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.IsElite) == true)
{
if (objPubClassCaseSenate_Cond.IsElite == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCaseSenate.IsElite);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCaseSenate.IsElite);
}
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.id_Resource) == true)
{
string strComparisonOp_id_Resource = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.id_Resource, objPubClassCaseSenate_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objPubClassCaseSenate_Cond.IsUpdated(conPubClassCaseSenate.id_MediaType) == true)
{
string strComparisonOp_id_MediaType = objPubClassCaseSenate_Cond.dicFldComparisonOp[conPubClassCaseSenate.id_MediaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenate.id_MediaType, objPubClassCaseSenate_Cond.id_MediaType, strComparisonOp_id_MediaType);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
 if (objPubClassCaseSenateEN.id_PubClassCaseSenate == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPubClassCaseSenateEN.sf_UpdFldSetStr = objPubClassCaseSenateEN.getsf_UpdFldSetStr();
clsPubClassCaseSenateWApi.CheckPropertyNew(objPubClassCaseSenateEN); 
bool bolResult = clsPubClassCaseSenateWApi.UpdateRecord(objPubClassCaseSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--PubClassCaseSenate(公开课案例评议), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_PubClassCase_PubClassCaseSenator_id_Resource(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPubClassCaseSenateEN == null) return "";
if (objPubClassCaseSenateEN.id_PubClassCaseSenate == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_PubClassCase = '{0}'", objPubClassCaseSenateEN.id_PubClassCase);
 sbCondition.AppendFormat(" and PubClassCaseSenator = '{0}'", objPubClassCaseSenateEN.PubClassCaseSenator);
 sbCondition.AppendFormat(" and id_Resource = '{0}'", objPubClassCaseSenateEN.id_Resource);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_PubClassCaseSenate !=  {0}", objPubClassCaseSenateEN.id_PubClassCaseSenate);
 sbCondition.AppendFormat(" and id_PubClassCase = '{0}'", objPubClassCaseSenateEN.id_PubClassCase);
 sbCondition.AppendFormat(" and PubClassCaseSenator = '{0}'", objPubClassCaseSenateEN.PubClassCaseSenator);
 sbCondition.AppendFormat(" and id_Resource = '{0}'", objPubClassCaseSenateEN.id_Resource);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPubClassCaseSenateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
try
{
clsPubClassCaseSenateWApi.CheckPropertyNew(objPubClassCaseSenateEN); 
bool bolResult = clsPubClassCaseSenateWApi.AddNewRecord(objPubClassCaseSenateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateWApi.ReFreshCache();
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
 /// <param name = "objPubClassCaseSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strWhereCond)
{
try
{
clsPubClassCaseSenateWApi.CheckPropertyNew(objPubClassCaseSenateEN); 
bool bolResult = clsPubClassCaseSenateWApi.UpdateWithCondition(objPubClassCaseSenateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateWApi.ReFreshCache();
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
 /// 公开课案例评议(PubClassCaseSenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPubClassCaseSenateWApi
{
private static readonly string mstrApiControllerName = "PubClassCaseSenateApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsPubClassCaseSenateWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
if (!Object.Equals(null, objPubClassCaseSenateEN.id_PubClassCase) && GetStrLen(objPubClassCaseSenateEN.id_PubClassCase) > 8)
{
 throw new Exception("字段[案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseSenateEN.id_PubClassCaseSenateClass) && GetStrLen(objPubClassCaseSenateEN.id_PubClassCaseSenateClass) > 4)
{
 throw new Exception("字段[公开课案例评议类别流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objPubClassCaseSenateEN.PubClassCaseSenator) && GetStrLen(objPubClassCaseSenateEN.PubClassCaseSenator) > 50)
{
 throw new Exception("字段[公开课案例评议者]的长度不能超过50!");
}
if (!Object.Equals(null, objPubClassCaseSenateEN.PubClassCaseSenateTitle) && GetStrLen(objPubClassCaseSenateEN.PubClassCaseSenateTitle) > 200)
{
 throw new Exception("字段[公开课案例评议标题]的长度不能超过200!");
}
if (!Object.Equals(null, objPubClassCaseSenateEN.PubClassCaseSenateContent) && GetStrLen(objPubClassCaseSenateEN.PubClassCaseSenateContent) > 8000)
{
 throw new Exception("字段[公开课案例评议内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objPubClassCaseSenateEN.PubClassCaseSenateDate) && GetStrLen(objPubClassCaseSenateEN.PubClassCaseSenateDate) > 8)
{
 throw new Exception("字段[公开课案例评议日期]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseSenateEN.PubClassCaseSenateTime) && GetStrLen(objPubClassCaseSenateEN.PubClassCaseSenateTime) > 6)
{
 throw new Exception("字段[公开课案例评议时间]的长度不能超过6!");
}
if (!Object.Equals(null, objPubClassCaseSenateEN.id_Resource) && GetStrLen(objPubClassCaseSenateEN.id_Resource) > 8)
{
 throw new Exception("字段[资源流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objPubClassCaseSenateEN.id_MediaType) && GetStrLen(objPubClassCaseSenateEN.id_MediaType) > 4)
{
 throw new Exception("字段[媒体格式流水号]的长度不能超过4!");
}
 objPubClassCaseSenateEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_PubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseSenateEN GetObjByid_PubClassCaseSenate(long lngid_PubClassCaseSenate)
{
string strAction = "GetObjByid_PubClassCaseSenate";
string strErrMsg = string.Empty;
string strResult = "";
clsPubClassCaseSenateEN objPubClassCaseSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseSenate"] = lngid_PubClassCaseSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPubClassCaseSenateEN = JsonConvert.DeserializeObject<clsPubClassCaseSenateEN>((string)jobjReturn["ReturnObj"]);
return objPubClassCaseSenateEN;
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
 /// <param name = "lngid_PubClassCaseSenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseSenateEN GetObjByid_PubClassCaseSenate_WA_Cache(long lngid_PubClassCaseSenate)
{
string strAction = "GetObjByid_PubClassCaseSenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsPubClassCaseSenateEN objPubClassCaseSenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseSenate"] = lngid_PubClassCaseSenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPubClassCaseSenateEN = JsonConvert.DeserializeObject<clsPubClassCaseSenateEN>((string)jobjReturn["ReturnObj"]);
return objPubClassCaseSenateEN;
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
public static clsPubClassCaseSenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsPubClassCaseSenateEN objPubClassCaseSenateEN = null;
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
objPubClassCaseSenateEN = JsonConvert.DeserializeObject<clsPubClassCaseSenateEN>((string)jobjReturn["ReturnObj"]);
return objPubClassCaseSenateEN;
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
 /// <param name = "lngid_PubClassCaseSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseSenateEN GetObjByid_PubClassCaseSenate_Cache(long lngid_PubClassCaseSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName_S);
List<clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLst_Sel =
from objPubClassCaseSenateEN in arrPubClassCaseSenateObjLst_Cache
where objPubClassCaseSenateEN.id_PubClassCaseSenate == lngid_PubClassCaseSenate
select objPubClassCaseSenateEN;
if (arrPubClassCaseSenateObjLst_Sel.Count() == 0)
{
   clsPubClassCaseSenateEN obj = clsPubClassCaseSenateWApi.GetObjByid_PubClassCaseSenate(lngid_PubClassCaseSenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPubClassCaseSenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetObjLst(string strWhereCond)
{
 List<clsPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseSenateEN> GetObjLstById_PubClassCaseSenateLst(List<long> arrId_PubClassCaseSenate)
{
 List<clsPubClassCaseSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseSenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_PubClassCaseSenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsPubClassCaseSenateEN> GetObjLstById_PubClassCaseSenateLst_Cache(List<long> arrId_PubClassCaseSenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName_S);
List<clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLst_Sel =
from objPubClassCaseSenateEN in arrPubClassCaseSenateObjLst_Cache
where arrId_PubClassCaseSenate.Contains(objPubClassCaseSenateEN.id_PubClassCaseSenate)
select objPubClassCaseSenateEN;
return arrPubClassCaseSenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetObjLstById_PubClassCaseSenateLst_WA_Cache(List<long> arrId_PubClassCaseSenate)
{
 List<clsPubClassCaseSenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubClassCaseSenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubClassCaseSenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseSenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseSenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseSenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubClassCaseSenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsPubClassCaseSenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubClassCaseSenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_PubClassCaseSenate)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsPubClassCaseSenateEN objPubClassCaseSenateEN = clsPubClassCaseSenateWApi.GetObjByid_PubClassCaseSenate(lngid_PubClassCaseSenate);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_PubClassCaseSenate.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPubClassCaseSenateWApi.ReFreshCache();
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
public static int DelPubClassCaseSenates(List<string> arrid_PubClassCaseSenate)
{
string strAction = "DelPubClassCaseSenates";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_PubClassCaseSenate);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPubClassCaseSenateWApi.ReFreshCache();
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
public static int DelPubClassCaseSenatesByCond(string strWhereCond)
{
string strAction = "DelPubClassCaseSenatesByCond";
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
public static bool AddNewRecord(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseSenateEN>(objPubClassCaseSenateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateWApi.ReFreshCache();
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
 /// <param name = "objPubClassCaseSenateEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseSenateEN>(objPubClassCaseSenateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateWApi.ReFreshCache();
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
public static bool UpdateRecord(clsPubClassCaseSenateEN objPubClassCaseSenateEN)
{
if (string.IsNullOrEmpty(objPubClassCaseSenateEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubClassCaseSenateEN.id_PubClassCaseSenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseSenateEN>(objPubClassCaseSenateEN);
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
 /// <param name = "objPubClassCaseSenateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPubClassCaseSenateEN objPubClassCaseSenateEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPubClassCaseSenateEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubClassCaseSenateEN.id_PubClassCaseSenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubClassCaseSenateEN.id_PubClassCaseSenate, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubClassCaseSenateEN>(objPubClassCaseSenateEN);
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
public static bool IsExist(long lngid_PubClassCaseSenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubClassCaseSenate"] = lngid_PubClassCaseSenate.ToString()
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
 /// <param name = "objPubClassCaseSenateENS">源对象</param>
 /// <param name = "objPubClassCaseSenateENT">目标对象</param>
 public static void CopyTo(clsPubClassCaseSenateEN objPubClassCaseSenateENS, clsPubClassCaseSenateEN objPubClassCaseSenateENT)
{
try
{
objPubClassCaseSenateENT.id_PubClassCaseSenate = objPubClassCaseSenateENS.id_PubClassCaseSenate; //公开课案例评议流水号
objPubClassCaseSenateENT.id_PubClassCase = objPubClassCaseSenateENS.id_PubClassCase; //案例流水号
objPubClassCaseSenateENT.id_PubClassCaseSenateClass = objPubClassCaseSenateENS.id_PubClassCaseSenateClass; //公开课案例评议类别流水号
objPubClassCaseSenateENT.PubClassCaseSenator = objPubClassCaseSenateENS.PubClassCaseSenator; //公开课案例评议者
objPubClassCaseSenateENT.PubClassCaseSenateTitle = objPubClassCaseSenateENS.PubClassCaseSenateTitle; //公开课案例评议标题
objPubClassCaseSenateENT.PubClassCaseSenateContent = objPubClassCaseSenateENS.PubClassCaseSenateContent; //公开课案例评议内容
objPubClassCaseSenateENT.PubClassCaseSenateDate = objPubClassCaseSenateENS.PubClassCaseSenateDate; //公开课案例评议日期
objPubClassCaseSenateENT.PubClassCaseSenateTime = objPubClassCaseSenateENS.PubClassCaseSenateTime; //公开课案例评议时间
objPubClassCaseSenateENT.SenateReadCount = objPubClassCaseSenateENS.SenateReadCount; //评议阅读次数
objPubClassCaseSenateENT.IsVisual = objPubClassCaseSenateENS.IsVisual; //隐藏标志
objPubClassCaseSenateENT.IsElite = objPubClassCaseSenateENS.IsElite; //精华标志
objPubClassCaseSenateENT.id_Resource = objPubClassCaseSenateENS.id_Resource; //资源流水号
objPubClassCaseSenateENT.id_MediaType = objPubClassCaseSenateENS.id_MediaType; //媒体格式流水号
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
public static DataTable ToDataTable(List<clsPubClassCaseSenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPubClassCaseSenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPubClassCaseSenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPubClassCaseSenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPubClassCaseSenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPubClassCaseSenateEN.AttributeName)
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
if (clsPubClassCaseSenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateWApi没有刷新缓存机制(clsPubClassCaseSenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubClassCaseSenate");
//if (arrPubClassCaseSenateObjLst_Cache == null)
//{
//arrPubClassCaseSenateObjLst_Cache = await clsPubClassCaseSenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName_S);
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
if (clsPubClassCaseSenateWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsPubClassCaseSenateWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseSenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsPubClassCaseSenateEN._CurrTabName_S);
List<clsPubClassCaseSenateEN> arrPubClassCaseSenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPubClassCaseSenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPubClassCaseSenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPubClassCaseSenate.id_PubClassCaseSenate, Type.GetType("System.Int64"));
objDT.Columns.Add(conPubClassCaseSenate.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseSenate.id_PubClassCaseSenateClass, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseSenate.PubClassCaseSenator, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseSenate.PubClassCaseSenateTitle, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseSenate.PubClassCaseSenateContent, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseSenate.PubClassCaseSenateDate, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseSenate.PubClassCaseSenateTime, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseSenate.SenateReadCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conPubClassCaseSenate.IsVisual, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPubClassCaseSenate.IsElite, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPubClassCaseSenate.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(conPubClassCaseSenate.id_MediaType, Type.GetType("System.String"));
foreach (clsPubClassCaseSenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPubClassCaseSenate.id_PubClassCaseSenate] = objInFor[conPubClassCaseSenate.id_PubClassCaseSenate];
objDR[conPubClassCaseSenate.id_PubClassCase] = objInFor[conPubClassCaseSenate.id_PubClassCase];
objDR[conPubClassCaseSenate.id_PubClassCaseSenateClass] = objInFor[conPubClassCaseSenate.id_PubClassCaseSenateClass];
objDR[conPubClassCaseSenate.PubClassCaseSenator] = objInFor[conPubClassCaseSenate.PubClassCaseSenator];
objDR[conPubClassCaseSenate.PubClassCaseSenateTitle] = objInFor[conPubClassCaseSenate.PubClassCaseSenateTitle];
objDR[conPubClassCaseSenate.PubClassCaseSenateContent] = objInFor[conPubClassCaseSenate.PubClassCaseSenateContent];
objDR[conPubClassCaseSenate.PubClassCaseSenateDate] = objInFor[conPubClassCaseSenate.PubClassCaseSenateDate];
objDR[conPubClassCaseSenate.PubClassCaseSenateTime] = objInFor[conPubClassCaseSenate.PubClassCaseSenateTime];
objDR[conPubClassCaseSenate.SenateReadCount] = objInFor[conPubClassCaseSenate.SenateReadCount];
objDR[conPubClassCaseSenate.IsVisual] = objInFor[conPubClassCaseSenate.IsVisual];
objDR[conPubClassCaseSenate.IsElite] = objInFor[conPubClassCaseSenate.IsElite];
objDR[conPubClassCaseSenate.id_Resource] = objInFor[conPubClassCaseSenate.id_Resource];
objDR[conPubClassCaseSenate.id_MediaType] = objInFor[conPubClassCaseSenate.id_MediaType];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 公开课案例评议(PubClassCaseSenate)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4PubClassCaseSenate : clsCommFun4BL
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
clsPubClassCaseSenateWApi.ReFreshThisCache();
}
}

}