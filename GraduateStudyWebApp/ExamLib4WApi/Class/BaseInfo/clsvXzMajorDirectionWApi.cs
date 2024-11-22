﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorDirectionWApi
 表名:vXzMajorDirection(01120553)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:23
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护
 模块英文名:BaseInfo
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
public static class clsvXzMajorDirectionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorDirectionId(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorDirectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorDirectionId, 8, convXzMajorDirection.MajorDirectionId);
clsCheckSql.CheckFieldForeignKey(strMajorDirectionId, 8, convXzMajorDirection.MajorDirectionId);
objvXzMajorDirectionEN.MajorDirectionId = strMajorDirectionId; //研究方向Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorDirectionId) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorDirectionId, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorDirectionId] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN Setid_XzMajor(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convXzMajorDirection.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convXzMajorDirection.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convXzMajorDirection.id_XzMajor);
objvXzMajorDirectionEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.id_XzMajor) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.id_XzMajor, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.id_XzMajor] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorID(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convXzMajorDirection.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, convXzMajorDirection.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convXzMajorDirection.MajorID);
objvXzMajorDirectionEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorID) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorID, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorID] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorName(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convXzMajorDirection.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convXzMajorDirection.MajorName);
objvXzMajorDirectionEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorName) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorName, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorName] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorDirectionName(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorDirectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorDirectionName, convXzMajorDirection.MajorDirectionName);
clsCheckSql.CheckFieldLen(strMajorDirectionName, 100, convXzMajorDirection.MajorDirectionName);
objvXzMajorDirectionEN.MajorDirectionName = strMajorDirectionName; //研究方向名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorDirectionName) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorDirectionName, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorDirectionName] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorDirectionENName(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorDirectionENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorDirectionENName, 200, convXzMajorDirection.MajorDirectionENName);
objvXzMajorDirectionEN.MajorDirectionENName = strMajorDirectionENName; //研究方向英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorDirectionENName) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorDirectionENName, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorDirectionENName] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMajorDirectionExplain(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMajorDirectionExplain, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorDirectionExplain, 2000, convXzMajorDirection.MajorDirectionExplain);
objvXzMajorDirectionEN.MajorDirectionExplain = strMajorDirectionExplain; //专业方向说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.MajorDirectionExplain) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.MajorDirectionExplain, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.MajorDirectionExplain] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetIsVisible(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, bool bolIsVisible, string strComparisonOp="")
	{
objvXzMajorDirectionEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.IsVisible) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.IsVisible, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.IsVisible] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetUpdDate(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convXzMajorDirection.UpdDate);
objvXzMajorDirectionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.UpdDate) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.UpdDate, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.UpdDate] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetUpdUser(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convXzMajorDirection.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convXzMajorDirection.UpdUser);
objvXzMajorDirectionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.UpdUser) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.UpdUser, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.UpdUser] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorDirectionEN SetMemo(this clsvXzMajorDirectionEN objvXzMajorDirectionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzMajorDirection.Memo);
objvXzMajorDirectionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(convXzMajorDirection.Memo) == false)
{
objvXzMajorDirectionEN.dicFldComparisonOp.Add(convXzMajorDirection.Memo, strComparisonOp);
}
else
{
objvXzMajorDirectionEN.dicFldComparisonOp[convXzMajorDirection.Memo] = strComparisonOp;
}
}
return objvXzMajorDirectionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzMajorDirectionEN objvXzMajorDirection_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.MajorDirectionId) == true)
{
string strComparisonOp_MajorDirectionId = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.MajorDirectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorDirectionId, objvXzMajorDirection_Cond.MajorDirectionId, strComparisonOp_MajorDirectionId);
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.id_XzMajor, objvXzMajorDirection_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.MajorID) == true)
{
string strComparisonOp_MajorID = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorID, objvXzMajorDirection_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.MajorName) == true)
{
string strComparisonOp_MajorName = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorName, objvXzMajorDirection_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.MajorDirectionName) == true)
{
string strComparisonOp_MajorDirectionName = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.MajorDirectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorDirectionName, objvXzMajorDirection_Cond.MajorDirectionName, strComparisonOp_MajorDirectionName);
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.MajorDirectionENName) == true)
{
string strComparisonOp_MajorDirectionENName = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.MajorDirectionENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorDirectionENName, objvXzMajorDirection_Cond.MajorDirectionENName, strComparisonOp_MajorDirectionENName);
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.MajorDirectionExplain) == true)
{
string strComparisonOp_MajorDirectionExplain = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.MajorDirectionExplain];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.MajorDirectionExplain, objvXzMajorDirection_Cond.MajorDirectionExplain, strComparisonOp_MajorDirectionExplain);
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.IsVisible) == true)
{
if (objvXzMajorDirection_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajorDirection.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajorDirection.IsVisible);
}
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.UpdDate, objvXzMajorDirection_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.UpdUser, objvXzMajorDirection_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvXzMajorDirection_Cond.IsUpdated(convXzMajorDirection.Memo) == true)
{
string strComparisonOp_Memo = objvXzMajorDirection_Cond.dicFldComparisonOp[convXzMajorDirection.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajorDirection.Memo, objvXzMajorDirection_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v专业方向(vXzMajorDirection)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzMajorDirectionWApi
{
private static readonly string mstrApiControllerName = "vXzMajorDirectionApi";

 public clsvXzMajorDirectionWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorDirectionEN GetObjByMajorDirectionId(string strMajorDirectionId)
{
string strAction = "GetObjByMajorDirectionId";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzMajorDirectionEN objvXzMajorDirectionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MajorDirectionId"] = strMajorDirectionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzMajorDirectionEN = JsonConvert.DeserializeObject<clsvXzMajorDirectionEN>((string)jobjReturn["ReturnObj"]);
return objvXzMajorDirectionEN;
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
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorDirectionEN GetObjByMajorDirectionId_WA_Cache(string strMajorDirectionId)
{
string strAction = "GetObjByMajorDirectionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzMajorDirectionEN objvXzMajorDirectionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MajorDirectionId"] = strMajorDirectionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzMajorDirectionEN = JsonConvert.DeserializeObject<clsvXzMajorDirectionEN>((string)jobjReturn["ReturnObj"]);
return objvXzMajorDirectionEN;
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
public static string GetFirstID(string strWhereCond)
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvXzMajorDirectionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzMajorDirectionEN objvXzMajorDirectionEN = null;
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
objvXzMajorDirectionEN = JsonConvert.DeserializeObject<clsvXzMajorDirectionEN>((string)jobjReturn["ReturnObj"]);
return objvXzMajorDirectionEN;
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
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzMajorDirectionEN GetObjByMajorDirectionId_Cache(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzMajorDirectionEN._CurrTabName_S);
List<clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLst_Sel =
from objvXzMajorDirectionEN in arrvXzMajorDirectionObjLst_Cache
where objvXzMajorDirectionEN.MajorDirectionId == strMajorDirectionId
select objvXzMajorDirectionEN;
if (arrvXzMajorDirectionObjLst_Sel.Count() == 0)
{
   clsvXzMajorDirectionEN obj = clsvXzMajorDirectionWApi.GetObjByMajorDirectionId(strMajorDirectionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzMajorDirectionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorDirectionEN> GetObjLst(string strWhereCond)
{
 List<clsvXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorDirectionEN> GetObjLstByMajorDirectionIdLst(List<string> arrMajorDirectionId)
{
 List<clsvXzMajorDirectionEN> arrObjLst = null; 
string strAction = "GetObjLstByMajorDirectionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMajorDirectionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvXzMajorDirectionEN> GetObjLstByMajorDirectionIdLst_Cache(List<string> arrMajorDirectionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzMajorDirectionEN._CurrTabName_S);
List<clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLst_Sel =
from objvXzMajorDirectionEN in arrvXzMajorDirectionObjLst_Cache
where arrMajorDirectionId.Contains(objvXzMajorDirectionEN.MajorDirectionId)
select objvXzMajorDirectionEN;
return arrvXzMajorDirectionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorDirectionEN> GetObjLstByMajorDirectionIdLst_WA_Cache(List<string> arrMajorDirectionId)
{
 List<clsvXzMajorDirectionEN> arrObjLst = null; 
string strAction = "GetObjLstByMajorDirectionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMajorDirectionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorDirectionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorDirectionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorDirectionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorDirectionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strMajorDirectionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MajorDirectionId"] = strMajorDirectionId
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
 /// <param name = "objvXzMajorDirectionENS">源对象</param>
 /// <param name = "objvXzMajorDirectionENT">目标对象</param>
 public static void CopyTo(clsvXzMajorDirectionEN objvXzMajorDirectionENS, clsvXzMajorDirectionEN objvXzMajorDirectionENT)
{
try
{
objvXzMajorDirectionENT.MajorDirectionId = objvXzMajorDirectionENS.MajorDirectionId; //研究方向Id
objvXzMajorDirectionENT.id_XzMajor = objvXzMajorDirectionENS.id_XzMajor; //专业流水号
objvXzMajorDirectionENT.MajorID = objvXzMajorDirectionENS.MajorID; //专业ID
objvXzMajorDirectionENT.MajorName = objvXzMajorDirectionENS.MajorName; //专业名称
objvXzMajorDirectionENT.MajorDirectionName = objvXzMajorDirectionENS.MajorDirectionName; //研究方向名
objvXzMajorDirectionENT.MajorDirectionENName = objvXzMajorDirectionENS.MajorDirectionENName; //研究方向英文名
objvXzMajorDirectionENT.MajorDirectionExplain = objvXzMajorDirectionENS.MajorDirectionExplain; //专业方向说明
objvXzMajorDirectionENT.IsVisible = objvXzMajorDirectionENS.IsVisible; //是否显示
objvXzMajorDirectionENT.UpdDate = objvXzMajorDirectionENS.UpdDate; //修改日期
objvXzMajorDirectionENT.UpdUser = objvXzMajorDirectionENS.UpdUser; //修改人
objvXzMajorDirectionENT.Memo = objvXzMajorDirectionENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvXzMajorDirectionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzMajorDirectionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzMajorDirectionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzMajorDirectionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzMajorDirectionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzMajorDirectionEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorDirectionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorDirectionWApi没有刷新缓存机制(clsXzMajorDirectionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MajorDirectionId");
//if (arrvXzMajorDirectionObjLst_Cache == null)
//{
//arrvXzMajorDirectionObjLst_Cache = await clsvXzMajorDirectionWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzMajorDirectionEN._CurrTabName_S);
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
public static List<clsvXzMajorDirectionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzMajorDirectionEN._CurrTabName_S);
List<clsvXzMajorDirectionEN> arrvXzMajorDirectionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzMajorDirectionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzMajorDirectionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzMajorDirection.MajorDirectionId, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajorDirection.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajorDirection.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajorDirection.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajorDirection.MajorDirectionName, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajorDirection.MajorDirectionENName, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajorDirection.MajorDirectionExplain, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajorDirection.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzMajorDirection.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajorDirection.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajorDirection.Memo, Type.GetType("System.String"));
foreach (clsvXzMajorDirectionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzMajorDirection.MajorDirectionId] = objInFor[convXzMajorDirection.MajorDirectionId];
objDR[convXzMajorDirection.id_XzMajor] = objInFor[convXzMajorDirection.id_XzMajor];
objDR[convXzMajorDirection.MajorID] = objInFor[convXzMajorDirection.MajorID];
objDR[convXzMajorDirection.MajorName] = objInFor[convXzMajorDirection.MajorName];
objDR[convXzMajorDirection.MajorDirectionName] = objInFor[convXzMajorDirection.MajorDirectionName];
objDR[convXzMajorDirection.MajorDirectionENName] = objInFor[convXzMajorDirection.MajorDirectionENName];
objDR[convXzMajorDirection.MajorDirectionExplain] = objInFor[convXzMajorDirection.MajorDirectionExplain];
objDR[convXzMajorDirection.IsVisible] = objInFor[convXzMajorDirection.IsVisible];
objDR[convXzMajorDirection.UpdDate] = objInFor[convXzMajorDirection.UpdDate];
objDR[convXzMajorDirection.UpdUser] = objInFor[convXzMajorDirection.UpdUser];
objDR[convXzMajorDirection.Memo] = objInFor[convXzMajorDirection.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}