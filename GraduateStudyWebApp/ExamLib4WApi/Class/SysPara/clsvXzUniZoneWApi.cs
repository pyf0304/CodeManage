
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzUniZoneWApi
 表名:vXzUniZone(01120332)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:21
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
public static class clsvXzUniZoneWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN Setid_UniZone(this clsvXzUniZoneEN objvXzUniZoneEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convXzUniZone.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convXzUniZone.id_UniZone);
objvXzUniZoneEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.id_UniZone) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.id_UniZone, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.id_UniZone] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN SetUniZoneID(this clsvXzUniZoneEN objvXzUniZoneEN, string strUniZoneID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUniZoneID, convXzUniZone.UniZoneID);
clsCheckSql.CheckFieldLen(strUniZoneID, 4, convXzUniZone.UniZoneID);
clsCheckSql.CheckFieldForeignKey(strUniZoneID, 4, convXzUniZone.UniZoneID);
objvXzUniZoneEN.UniZoneID = strUniZoneID; //校区编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.UniZoneID) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.UniZoneID, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.UniZoneID] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN SetUniZoneDesc(this clsvXzUniZoneEN objvXzUniZoneEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUniZoneDesc, convXzUniZone.UniZoneDesc);
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convXzUniZone.UniZoneDesc);
objvXzUniZoneEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.UniZoneDesc) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.UniZoneDesc, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.UniZoneDesc] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN SetUniZoneDescA(this clsvXzUniZoneEN objvXzUniZoneEN, string strUniZoneDescA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDescA, 20, convXzUniZone.UniZoneDescA);
objvXzUniZoneEN.UniZoneDescA = strUniZoneDescA; //UniZoneDescA
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.UniZoneDescA) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.UniZoneDescA, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.UniZoneDescA] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN Setid_School(this clsvXzUniZoneEN objvXzUniZoneEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convXzUniZone.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convXzUniZone.id_School);
objvXzUniZoneEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.id_School) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.id_School, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.id_School] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN SetSchoolId(this clsvXzUniZoneEN objvXzUniZoneEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convXzUniZone.SchoolId);
objvXzUniZoneEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.SchoolId) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.SchoolId, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.SchoolId] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN SetSchoolName(this clsvXzUniZoneEN objvXzUniZoneEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convXzUniZone.SchoolName);
objvXzUniZoneEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.SchoolName) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.SchoolName, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.SchoolName] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN SetSchoolNameA(this clsvXzUniZoneEN objvXzUniZoneEN, string strSchoolNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, convXzUniZone.SchoolNameA);
objvXzUniZoneEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.SchoolNameA) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.SchoolNameA, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.SchoolNameA] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN Setid_Uni(this clsvXzUniZoneEN objvXzUniZoneEN, string strid_Uni, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Uni, 4, convXzUniZone.id_Uni);
clsCheckSql.CheckFieldForeignKey(strid_Uni, 4, convXzUniZone.id_Uni);
objvXzUniZoneEN.id_Uni = strid_Uni; //id_Uni
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.id_Uni) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.id_Uni, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.id_Uni] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN SetModifyDate(this clsvXzUniZoneEN objvXzUniZoneEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzUniZone.ModifyDate);
objvXzUniZoneEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.ModifyDate) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.ModifyDate, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.ModifyDate] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN SetModifyUserID(this clsvXzUniZoneEN objvXzUniZoneEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convXzUniZone.ModifyUserID);
objvXzUniZoneEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.ModifyUserID) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.ModifyUserID, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.ModifyUserID] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzUniZoneEN SetMemo(this clsvXzUniZoneEN objvXzUniZoneEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzUniZone.Memo);
objvXzUniZoneEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzUniZoneEN.dicFldComparisonOp.ContainsKey(convXzUniZone.Memo) == false)
{
objvXzUniZoneEN.dicFldComparisonOp.Add(convXzUniZone.Memo, strComparisonOp);
}
else
{
objvXzUniZoneEN.dicFldComparisonOp[convXzUniZone.Memo] = strComparisonOp;
}
}
return objvXzUniZoneEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzUniZoneEN objvXzUniZone_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.id_UniZone, objvXzUniZone_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.UniZoneID) == true)
{
string strComparisonOp_UniZoneID = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.UniZoneID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.UniZoneID, objvXzUniZone_Cond.UniZoneID, strComparisonOp_UniZoneID);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.UniZoneDesc, objvXzUniZone_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.UniZoneDescA) == true)
{
string strComparisonOp_UniZoneDescA = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.UniZoneDescA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.UniZoneDescA, objvXzUniZone_Cond.UniZoneDescA, strComparisonOp_UniZoneDescA);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.id_School) == true)
{
string strComparisonOp_id_School = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.id_School, objvXzUniZone_Cond.id_School, strComparisonOp_id_School);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.SchoolId, objvXzUniZone_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.SchoolName, objvXzUniZone_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.SchoolNameA) == true)
{
string strComparisonOp_SchoolNameA = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.SchoolNameA, objvXzUniZone_Cond.SchoolNameA, strComparisonOp_SchoolNameA);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.id_Uni) == true)
{
string strComparisonOp_id_Uni = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.id_Uni];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.id_Uni, objvXzUniZone_Cond.id_Uni, strComparisonOp_id_Uni);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.ModifyDate, objvXzUniZone_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.ModifyUserID, objvXzUniZone_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvXzUniZone_Cond.IsUpdated(convXzUniZone.Memo) == true)
{
string strComparisonOp_Memo = objvXzUniZone_Cond.dicFldComparisonOp[convXzUniZone.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzUniZone.Memo, objvXzUniZone_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v校区(vXzUniZone)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzUniZoneWApi
{
private static readonly string mstrApiControllerName = "vXzUniZoneApi";

 public clsvXzUniZoneWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_UniZone(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v校区]...","0");
List<clsvXzUniZoneEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_UniZone";
objDDL.DataTextField="UniZoneDesc";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_UniZone(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzUniZone.id_UniZone); 
List<clsvXzUniZoneEN> arrObjLst = clsvXzUniZoneWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzUniZoneEN objvXzUniZoneEN = new clsvXzUniZoneEN()
{
id_UniZone = "0",
UniZoneDesc = "选[v校区]..."
};
arrObjLst.Insert(0, objvXzUniZoneEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzUniZone.id_UniZone;
objComboBox.DisplayMember = convXzUniZone.UniZoneDesc;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_UniZone">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzUniZoneEN GetObjByid_UniZone(string strid_UniZone)
{
string strAction = "GetObjByid_UniZone";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzUniZoneEN objvXzUniZoneEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_UniZone"] = strid_UniZone
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzUniZoneEN = JsonConvert.DeserializeObject<clsvXzUniZoneEN>((string)jobjReturn["ReturnObj"]);
return objvXzUniZoneEN;
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
 /// <param name = "strid_UniZone">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzUniZoneEN GetObjByid_UniZone_WA_Cache(string strid_UniZone)
{
string strAction = "GetObjByid_UniZone_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzUniZoneEN objvXzUniZoneEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_UniZone"] = strid_UniZone
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzUniZoneEN = JsonConvert.DeserializeObject<clsvXzUniZoneEN>((string)jobjReturn["ReturnObj"]);
return objvXzUniZoneEN;
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
public static clsvXzUniZoneEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzUniZoneEN objvXzUniZoneEN = null;
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
objvXzUniZoneEN = JsonConvert.DeserializeObject<clsvXzUniZoneEN>((string)jobjReturn["ReturnObj"]);
return objvXzUniZoneEN;
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
 /// <param name = "strid_UniZone">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzUniZoneEN GetObjByid_UniZone_Cache(string strid_UniZone)
{
if (string.IsNullOrEmpty(strid_UniZone) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName_S);
List<clsvXzUniZoneEN> arrvXzUniZoneObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzUniZoneEN> arrvXzUniZoneObjLst_Sel =
from objvXzUniZoneEN in arrvXzUniZoneObjLst_Cache
where objvXzUniZoneEN.id_UniZone == strid_UniZone
select objvXzUniZoneEN;
if (arrvXzUniZoneObjLst_Sel.Count() == 0)
{
   clsvXzUniZoneEN obj = clsvXzUniZoneWApi.GetObjByid_UniZone(strid_UniZone);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzUniZoneObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_UniZone">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUniZoneDescByid_UniZone_Cache(string strid_UniZone)
{
if (string.IsNullOrEmpty(strid_UniZone) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName_S);
List<clsvXzUniZoneEN> arrvXzUniZoneObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzUniZoneEN> arrvXzUniZoneObjLst_Sel1 =
from objvXzUniZoneEN in arrvXzUniZoneObjLst_Cache
where objvXzUniZoneEN.id_UniZone == strid_UniZone
select objvXzUniZoneEN;
List <clsvXzUniZoneEN> arrvXzUniZoneObjLst_Sel = new List<clsvXzUniZoneEN>();
foreach (clsvXzUniZoneEN obj in arrvXzUniZoneObjLst_Sel1)
{
arrvXzUniZoneObjLst_Sel.Add(obj);
}
if (arrvXzUniZoneObjLst_Sel.Count > 0)
{
return arrvXzUniZoneObjLst_Sel[0].UniZoneDesc;
}
string strErrMsgForGetObjById = string.Format("在vXzUniZone对象缓存列表中,找不到记录[id_UniZone = {0}](函数:{1})", strid_UniZone, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzUniZoneBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_UniZone">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_UniZone_Cache(string strid_UniZone)
{
if (string.IsNullOrEmpty(strid_UniZone) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName_S);
List<clsvXzUniZoneEN> arrvXzUniZoneObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzUniZoneEN> arrvXzUniZoneObjLst_Sel1 =
from objvXzUniZoneEN in arrvXzUniZoneObjLst_Cache
where objvXzUniZoneEN.id_UniZone == strid_UniZone
select objvXzUniZoneEN;
List <clsvXzUniZoneEN> arrvXzUniZoneObjLst_Sel = new List<clsvXzUniZoneEN>();
foreach (clsvXzUniZoneEN obj in arrvXzUniZoneObjLst_Sel1)
{
arrvXzUniZoneObjLst_Sel.Add(obj);
}
if (arrvXzUniZoneObjLst_Sel.Count > 0)
{
return arrvXzUniZoneObjLst_Sel[0].UniZoneDesc;
}
string strErrMsgForGetObjById = string.Format("在vXzUniZone对象缓存列表中,找不到记录的相关名称[id_UniZone = {0}](函数:{1})", strid_UniZone, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzUniZoneBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzUniZoneEN> GetObjLst(string strWhereCond)
{
 List<clsvXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzUniZoneEN> GetObjLstById_UniZoneLst(List<string> arrId_UniZone)
{
 List<clsvXzUniZoneEN> arrObjLst = null; 
string strAction = "GetObjLstById_UniZoneLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_UniZone);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_UniZone">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvXzUniZoneEN> GetObjLstById_UniZoneLst_Cache(List<string> arrId_UniZone)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName_S);
List<clsvXzUniZoneEN> arrvXzUniZoneObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzUniZoneEN> arrvXzUniZoneObjLst_Sel =
from objvXzUniZoneEN in arrvXzUniZoneObjLst_Cache
where arrId_UniZone.Contains(objvXzUniZoneEN.id_UniZone)
select objvXzUniZoneEN;
return arrvXzUniZoneObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzUniZoneEN> GetObjLstById_UniZoneLst_WA_Cache(List<string> arrId_UniZone)
{
 List<clsvXzUniZoneEN> arrObjLst = null; 
string strAction = "GetObjLstById_UniZoneLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_UniZone);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzUniZoneEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzUniZoneEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzUniZoneEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzUniZoneEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_UniZone)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_UniZone"] = strid_UniZone
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
 /// <param name = "objvXzUniZoneENS">源对象</param>
 /// <param name = "objvXzUniZoneENT">目标对象</param>
 public static void CopyTo(clsvXzUniZoneEN objvXzUniZoneENS, clsvXzUniZoneEN objvXzUniZoneENT)
{
try
{
objvXzUniZoneENT.id_UniZone = objvXzUniZoneENS.id_UniZone; //校区流水号
objvXzUniZoneENT.UniZoneID = objvXzUniZoneENS.UniZoneID; //校区编号
objvXzUniZoneENT.UniZoneDesc = objvXzUniZoneENS.UniZoneDesc; //校区名称
objvXzUniZoneENT.UniZoneDescA = objvXzUniZoneENS.UniZoneDescA; //UniZoneDescA
objvXzUniZoneENT.id_School = objvXzUniZoneENS.id_School; //学校流水号
objvXzUniZoneENT.SchoolId = objvXzUniZoneENS.SchoolId; //学校编号
objvXzUniZoneENT.SchoolName = objvXzUniZoneENS.SchoolName; //学校名称
objvXzUniZoneENT.SchoolNameA = objvXzUniZoneENS.SchoolNameA; //学校简称
objvXzUniZoneENT.id_Uni = objvXzUniZoneENS.id_Uni; //id_Uni
objvXzUniZoneENT.ModifyDate = objvXzUniZoneENS.ModifyDate; //修改日期
objvXzUniZoneENT.ModifyUserID = objvXzUniZoneENS.ModifyUserID; //修改人
objvXzUniZoneENT.Memo = objvXzUniZoneENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvXzUniZoneEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzUniZoneEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzUniZoneEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzUniZoneEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzUniZoneEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzUniZoneEN.AttributeName)
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
if (clsXzSchoolWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolWApi没有刷新缓存机制(clsXzSchoolWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_UniZone");
//if (arrvXzUniZoneObjLst_Cache == null)
//{
//arrvXzUniZoneObjLst_Cache = await clsvXzUniZoneWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName_S);
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
public static List<clsvXzUniZoneEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzUniZoneEN._CurrTabName_S);
List<clsvXzUniZoneEN> arrvXzUniZoneObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzUniZoneObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzUniZoneEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzUniZone.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.UniZoneID, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.UniZoneDescA, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.SchoolNameA, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.id_Uni, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convXzUniZone.Memo, Type.GetType("System.String"));
foreach (clsvXzUniZoneEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzUniZone.id_UniZone] = objInFor[convXzUniZone.id_UniZone];
objDR[convXzUniZone.UniZoneID] = objInFor[convXzUniZone.UniZoneID];
objDR[convXzUniZone.UniZoneDesc] = objInFor[convXzUniZone.UniZoneDesc];
objDR[convXzUniZone.UniZoneDescA] = objInFor[convXzUniZone.UniZoneDescA];
objDR[convXzUniZone.id_School] = objInFor[convXzUniZone.id_School];
objDR[convXzUniZone.SchoolId] = objInFor[convXzUniZone.SchoolId];
objDR[convXzUniZone.SchoolName] = objInFor[convXzUniZone.SchoolName];
objDR[convXzUniZone.SchoolNameA] = objInFor[convXzUniZone.SchoolNameA];
objDR[convXzUniZone.id_Uni] = objInFor[convXzUniZone.id_Uni];
objDR[convXzUniZone.ModifyDate] = objInFor[convXzUniZone.ModifyDate];
objDR[convXzUniZone.ModifyUserID] = objInFor[convXzUniZone.ModifyUserID];
objDR[convXzUniZone.Memo] = objInFor[convXzUniZone.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}