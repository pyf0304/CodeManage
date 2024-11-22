
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzSchoolByCourseNumWApi
 表名:vXzSchoolByCourseNum(01120335)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:54
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理
 模块英文名:CourseManage
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
public static class clsvXzSchoolByCourseNumWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN Setid_School(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convXzSchoolByCourseNum.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convXzSchoolByCourseNum.id_School);
objvXzSchoolByCourseNumEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.id_School) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.id_School, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.id_School] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolId(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convXzSchoolByCourseNum.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convXzSchoolByCourseNum.SchoolId);
objvXzSchoolByCourseNumEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolId) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolId, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolId] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolName(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convXzSchoolByCourseNum.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convXzSchoolByCourseNum.SchoolName);
objvXzSchoolByCourseNumEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolName) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolName, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolName] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolNameA(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, convXzSchoolByCourseNum.SchoolNameA);
objvXzSchoolByCourseNumEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolNameA) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolNameA, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolNameA] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolTypeId(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTypeId, 2, convXzSchoolByCourseNum.SchoolTypeId);
clsCheckSql.CheckFieldForeignKey(strSchoolTypeId, 2, convXzSchoolByCourseNum.SchoolTypeId);
objvXzSchoolByCourseNumEN.SchoolTypeId = strSchoolTypeId; //学校类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolTypeId) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolTypeId, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolTypeId] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetSchoolTypeName(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strSchoolTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTypeName, 30, convXzSchoolByCourseNum.SchoolTypeName);
objvXzSchoolByCourseNumEN.SchoolTypeName = strSchoolTypeName; //学校类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.SchoolTypeName) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.SchoolTypeName, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolTypeName] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetIsCurrentUse(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCurrentUse, convXzSchoolByCourseNum.IsCurrentUse);
objvXzSchoolByCourseNumEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.IsCurrentUse) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.IsCurrentUse, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.IsCurrentUse] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetUpdDate(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convXzSchoolByCourseNum.UpdDate);
objvXzSchoolByCourseNumEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.UpdDate) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.UpdDate, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.UpdDate] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetUpdUserId(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convXzSchoolByCourseNum.UpdUserId);
objvXzSchoolByCourseNumEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.UpdUserId) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.UpdUserId, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.UpdUserId] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetMemo(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzSchoolByCourseNum.Memo);
objvXzSchoolByCourseNumEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.Memo) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.Memo, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.Memo] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzSchoolByCourseNumEN SetCourseNum(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN, int intCourseNum, string strComparisonOp="")
	{
objvXzSchoolByCourseNumEN.CourseNum = intCourseNum; //CourseNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzSchoolByCourseNumEN.dicFldComparisonOp.ContainsKey(convXzSchoolByCourseNum.CourseNum) == false)
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp.Add(convXzSchoolByCourseNum.CourseNum, strComparisonOp);
}
else
{
objvXzSchoolByCourseNumEN.dicFldComparisonOp[convXzSchoolByCourseNum.CourseNum] = strComparisonOp;
}
}
return objvXzSchoolByCourseNumEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNum_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.id_School) == true)
{
string strComparisonOp_id_School = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.id_School, objvXzSchoolByCourseNum_Cond.id_School, strComparisonOp_id_School);
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolId, objvXzSchoolByCourseNum_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolName, objvXzSchoolByCourseNum_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.SchoolNameA) == true)
{
string strComparisonOp_SchoolNameA = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolNameA, objvXzSchoolByCourseNum_Cond.SchoolNameA, strComparisonOp_SchoolNameA);
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.SchoolTypeId) == true)
{
string strComparisonOp_SchoolTypeId = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolTypeId, objvXzSchoolByCourseNum_Cond.SchoolTypeId, strComparisonOp_SchoolTypeId);
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.SchoolTypeName) == true)
{
string strComparisonOp_SchoolTypeName = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.SchoolTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.SchoolTypeName, objvXzSchoolByCourseNum_Cond.SchoolTypeName, strComparisonOp_SchoolTypeName);
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.IsCurrentUse) == true)
{
if (objvXzSchoolByCourseNum_Cond.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzSchoolByCourseNum.IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzSchoolByCourseNum.IsCurrentUse);
}
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.UpdDate, objvXzSchoolByCourseNum_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.UpdUserId, objvXzSchoolByCourseNum_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.Memo) == true)
{
string strComparisonOp_Memo = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzSchoolByCourseNum.Memo, objvXzSchoolByCourseNum_Cond.Memo, strComparisonOp_Memo);
}
if (objvXzSchoolByCourseNum_Cond.IsUpdated(convXzSchoolByCourseNum.CourseNum) == true)
{
string strComparisonOp_CourseNum = objvXzSchoolByCourseNum_Cond.dicFldComparisonOp[convXzSchoolByCourseNum.CourseNum];
strWhereCond += string.Format(" And {0} {2} {1}", convXzSchoolByCourseNum.CourseNum, objvXzSchoolByCourseNum_Cond.CourseNum, strComparisonOp_CourseNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vXzSchoolByCourseNum(vXzSchoolByCourseNum)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzSchoolByCourseNumWApi
{
private static readonly string mstrApiControllerName = "vXzSchoolByCourseNumApi";

 public clsvXzSchoolByCourseNumWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_School(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vXzSchoolByCourseNum]...","0");
List<clsvXzSchoolByCourseNumEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_School";
objDDL.DataTextField="SchoolName";
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
public static void BindCbo_id_School(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzSchoolByCourseNum.id_School); 
List<clsvXzSchoolByCourseNumEN> arrObjLst = clsvXzSchoolByCourseNumWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN()
{
id_School = "0",
SchoolName = "选[vXzSchoolByCourseNum]..."
};
arrObjLst.Insert(0, objvXzSchoolByCourseNumEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzSchoolByCourseNum.id_School;
objComboBox.DisplayMember = convXzSchoolByCourseNum.SchoolName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_School">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzSchoolByCourseNumEN GetObjByid_School(string strid_School)
{
string strAction = "GetObjByid_School";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_School"] = strid_School
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzSchoolByCourseNumEN = JsonConvert.DeserializeObject<clsvXzSchoolByCourseNumEN>((string)jobjReturn["ReturnObj"]);
return objvXzSchoolByCourseNumEN;
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
 /// <param name = "strid_School">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzSchoolByCourseNumEN GetObjByid_School_WA_Cache(string strid_School)
{
string strAction = "GetObjByid_School_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_School"] = strid_School
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzSchoolByCourseNumEN = JsonConvert.DeserializeObject<clsvXzSchoolByCourseNumEN>((string)jobjReturn["ReturnObj"]);
return objvXzSchoolByCourseNumEN;
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
public static clsvXzSchoolByCourseNumEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = null;
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
objvXzSchoolByCourseNumEN = JsonConvert.DeserializeObject<clsvXzSchoolByCourseNumEN>((string)jobjReturn["ReturnObj"]);
return objvXzSchoolByCourseNumEN;
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
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzSchoolByCourseNumEN GetObjByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName_S);
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Sel =
from objvXzSchoolByCourseNumEN in arrvXzSchoolByCourseNumObjLst_Cache
where objvXzSchoolByCourseNumEN.id_School == strid_School
select objvXzSchoolByCourseNumEN;
if (arrvXzSchoolByCourseNumObjLst_Sel.Count() == 0)
{
   clsvXzSchoolByCourseNumEN obj = clsvXzSchoolByCourseNumWApi.GetObjByid_School(strid_School);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzSchoolByCourseNumObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolNameByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName_S);
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Sel1 =
from objvXzSchoolByCourseNumEN in arrvXzSchoolByCourseNumObjLst_Cache
where objvXzSchoolByCourseNumEN.id_School == strid_School
select objvXzSchoolByCourseNumEN;
List <clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Sel = new List<clsvXzSchoolByCourseNumEN>();
foreach (clsvXzSchoolByCourseNumEN obj in arrvXzSchoolByCourseNumObjLst_Sel1)
{
arrvXzSchoolByCourseNumObjLst_Sel.Add(obj);
}
if (arrvXzSchoolByCourseNumObjLst_Sel.Count > 0)
{
return arrvXzSchoolByCourseNumObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在vXzSchoolByCourseNum对象缓存列表中,找不到记录[id_School = {0}](函数:{1})", strid_School, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzSchoolByCourseNumBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName_S);
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Sel1 =
from objvXzSchoolByCourseNumEN in arrvXzSchoolByCourseNumObjLst_Cache
where objvXzSchoolByCourseNumEN.id_School == strid_School
select objvXzSchoolByCourseNumEN;
List <clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Sel = new List<clsvXzSchoolByCourseNumEN>();
foreach (clsvXzSchoolByCourseNumEN obj in arrvXzSchoolByCourseNumObjLst_Sel1)
{
arrvXzSchoolByCourseNumObjLst_Sel.Add(obj);
}
if (arrvXzSchoolByCourseNumObjLst_Sel.Count > 0)
{
return arrvXzSchoolByCourseNumObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在vXzSchoolByCourseNum对象缓存列表中,找不到记录的相关名称[id_School = {0}](函数:{1})", strid_School, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzSchoolByCourseNumBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzSchoolByCourseNumEN> GetObjLst(string strWhereCond)
{
 List<clsvXzSchoolByCourseNumEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolByCourseNumEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLstById_SchoolLst(List<string> arrId_School)
{
 List<clsvXzSchoolByCourseNumEN> arrObjLst = null; 
string strAction = "GetObjLstById_SchoolLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_School);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolByCourseNumEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvXzSchoolByCourseNumEN> GetObjLstById_SchoolLst_Cache(List<string> arrId_School)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName_S);
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Sel =
from objvXzSchoolByCourseNumEN in arrvXzSchoolByCourseNumObjLst_Cache
where arrId_School.Contains(objvXzSchoolByCourseNumEN.id_School)
select objvXzSchoolByCourseNumEN;
return arrvXzSchoolByCourseNumObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzSchoolByCourseNumEN> GetObjLstById_SchoolLst_WA_Cache(List<string> arrId_School)
{
 List<clsvXzSchoolByCourseNumEN> arrObjLst = null; 
string strAction = "GetObjLstById_SchoolLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_School);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolByCourseNumEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolByCourseNumEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzSchoolByCourseNumEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolByCourseNumEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzSchoolByCourseNumEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolByCourseNumEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzSchoolByCourseNumEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolByCourseNumEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzSchoolByCourseNumEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzSchoolByCourseNumEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_School)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_School"] = strid_School
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
 /// <param name = "objvXzSchoolByCourseNumENS">源对象</param>
 /// <param name = "objvXzSchoolByCourseNumENT">目标对象</param>
 public static void CopyTo(clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENS, clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENT)
{
try
{
objvXzSchoolByCourseNumENT.id_School = objvXzSchoolByCourseNumENS.id_School; //学校流水号
objvXzSchoolByCourseNumENT.SchoolId = objvXzSchoolByCourseNumENS.SchoolId; //学校编号
objvXzSchoolByCourseNumENT.SchoolName = objvXzSchoolByCourseNumENS.SchoolName; //学校名称
objvXzSchoolByCourseNumENT.SchoolNameA = objvXzSchoolByCourseNumENS.SchoolNameA; //学校简称
objvXzSchoolByCourseNumENT.SchoolTypeId = objvXzSchoolByCourseNumENS.SchoolTypeId; //学校类型Id
objvXzSchoolByCourseNumENT.SchoolTypeName = objvXzSchoolByCourseNumENS.SchoolTypeName; //学校类型名
objvXzSchoolByCourseNumENT.IsCurrentUse = objvXzSchoolByCourseNumENS.IsCurrentUse; //是否当前使用
objvXzSchoolByCourseNumENT.UpdDate = objvXzSchoolByCourseNumENS.UpdDate; //修改日期
objvXzSchoolByCourseNumENT.UpdUserId = objvXzSchoolByCourseNumENS.UpdUserId; //修改用户Id
objvXzSchoolByCourseNumENT.Memo = objvXzSchoolByCourseNumENS.Memo; //备注
objvXzSchoolByCourseNumENT.CourseNum = objvXzSchoolByCourseNumENS.CourseNum; //CourseNum
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
public static DataTable ToDataTable(List<clsvXzSchoolByCourseNumEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzSchoolByCourseNumEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzSchoolByCourseNumEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzSchoolByCourseNumEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzSchoolByCourseNumEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzSchoolByCourseNumEN.AttributeName)
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
if (clsSchoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSchoolTypeWApi没有刷新缓存机制(clsSchoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_School");
//if (arrvXzSchoolByCourseNumObjLst_Cache == null)
//{
//arrvXzSchoolByCourseNumObjLst_Cache = await clsvXzSchoolByCourseNumWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName_S);
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
public static List<clsvXzSchoolByCourseNumEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzSchoolByCourseNumEN._CurrTabName_S);
List<clsvXzSchoolByCourseNumEN> arrvXzSchoolByCourseNumObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzSchoolByCourseNumObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzSchoolByCourseNumEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzSchoolByCourseNum.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchoolByCourseNum.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchoolByCourseNum.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchoolByCourseNum.SchoolNameA, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchoolByCourseNum.SchoolTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchoolByCourseNum.SchoolTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchoolByCourseNum.IsCurrentUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzSchoolByCourseNum.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchoolByCourseNum.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchoolByCourseNum.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convXzSchoolByCourseNum.CourseNum, Type.GetType("System.Int32"));
foreach (clsvXzSchoolByCourseNumEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzSchoolByCourseNum.id_School] = objInFor[convXzSchoolByCourseNum.id_School];
objDR[convXzSchoolByCourseNum.SchoolId] = objInFor[convXzSchoolByCourseNum.SchoolId];
objDR[convXzSchoolByCourseNum.SchoolName] = objInFor[convXzSchoolByCourseNum.SchoolName];
objDR[convXzSchoolByCourseNum.SchoolNameA] = objInFor[convXzSchoolByCourseNum.SchoolNameA];
objDR[convXzSchoolByCourseNum.SchoolTypeId] = objInFor[convXzSchoolByCourseNum.SchoolTypeId];
objDR[convXzSchoolByCourseNum.SchoolTypeName] = objInFor[convXzSchoolByCourseNum.SchoolTypeName];
objDR[convXzSchoolByCourseNum.IsCurrentUse] = objInFor[convXzSchoolByCourseNum.IsCurrentUse];
objDR[convXzSchoolByCourseNum.UpdDate] = objInFor[convXzSchoolByCourseNum.UpdDate];
objDR[convXzSchoolByCourseNum.UpdUserId] = objInFor[convXzSchoolByCourseNum.UpdUserId];
objDR[convXzSchoolByCourseNum.Memo] = objInFor[convXzSchoolByCourseNum.Memo];
objDR[convXzSchoolByCourseNum.CourseNum] = objInFor[convXzSchoolByCourseNum.CourseNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}