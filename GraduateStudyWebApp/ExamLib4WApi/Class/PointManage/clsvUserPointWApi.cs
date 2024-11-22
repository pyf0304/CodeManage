
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPointWApi
 表名:vUserPoint(01120306)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:25
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:位置管理
 模块英文名:PointManage
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
public static class clsvUserPointWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetPointId(this clsvUserPointEN objvUserPointEN, string strPointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPointId, 10, convUserPoint.PointId);
clsCheckSql.CheckFieldForeignKey(strPointId, 10, convUserPoint.PointId);
objvUserPointEN.PointId = strPointId; //点位Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.PointId) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.PointId, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.PointId] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetUserId(this clsvUserPointEN objvUserPointEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convUserPoint.UserId);
objvUserPointEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.UserId) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.UserId, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.UserId] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetUserName(this clsvUserPointEN objvUserPointEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convUserPoint.UserName);
objvUserPointEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.UserName) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.UserName, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.UserName] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetUserStateId(this clsvUserPointEN objvUserPointEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convUserPoint.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convUserPoint.UserStateId);
objvUserPointEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.UserStateId) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.UserStateId, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.UserStateId] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetUserStateName(this clsvUserPointEN objvUserPointEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convUserPoint.UserStateName);
objvUserPointEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.UserStateName) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.UserStateName, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.UserStateName] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN Setid_XzCollege(this clsvUserPointEN objvUserPointEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convUserPoint.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convUserPoint.id_XzCollege);
objvUserPointEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.id_XzCollege) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.id_XzCollege, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.id_XzCollege] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetCollegeNameA(this clsvUserPointEN objvUserPointEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convUserPoint.CollegeNameA);
objvUserPointEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.CollegeNameA) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.CollegeNameA, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.CollegeNameA] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetIdentityID(this clsvUserPointEN objvUserPointEN, string strIdentityID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityID, convUserPoint.IdentityID);
clsCheckSql.CheckFieldLen(strIdentityID, 2, convUserPoint.IdentityID);
clsCheckSql.CheckFieldForeignKey(strIdentityID, 2, convUserPoint.IdentityID);
objvUserPointEN.IdentityID = strIdentityID; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.IdentityID) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.IdentityID, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.IdentityID] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetIdentityDesc(this clsvUserPointEN objvUserPointEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convUserPoint.IdentityDesc);
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convUserPoint.IdentityDesc);
objvUserPointEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.IdentityDesc) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.IdentityDesc, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.IdentityDesc] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetLongitude(this clsvUserPointEN objvUserPointEN, double dblLongitude, string strComparisonOp="")
	{
objvUserPointEN.Longitude = dblLongitude; //经度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.Longitude) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.Longitude, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.Longitude] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetLatitude(this clsvUserPointEN objvUserPointEN, double dblLatitude, string strComparisonOp="")
	{
objvUserPointEN.Latitude = dblLatitude; //纬度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.Latitude) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.Latitude, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.Latitude] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetAddress(this clsvUserPointEN objvUserPointEN, string strAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAddress, 200, convUserPoint.Address);
objvUserPointEN.Address = strAddress; //地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.Address) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.Address, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.Address] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetUpdDate(this clsvUserPointEN objvUserPointEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convUserPoint.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserPoint.UpdDate);
objvUserPointEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.UpdDate) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.UpdDate, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.UpdDate] = strComparisonOp;
}
}
return objvUserPointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserPointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserPointEN SetMemo(this clsvUserPointEN objvUserPointEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserPoint.Memo);
objvUserPointEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserPointEN.dicFldComparisonOp.ContainsKey(convUserPoint.Memo) == false)
{
objvUserPointEN.dicFldComparisonOp.Add(convUserPoint.Memo, strComparisonOp);
}
else
{
objvUserPointEN.dicFldComparisonOp[convUserPoint.Memo] = strComparisonOp;
}
}
return objvUserPointEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserPointEN objvUserPoint_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserPoint_Cond.IsUpdated(convUserPoint.PointId) == true)
{
string strComparisonOp_PointId = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.PointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.PointId, objvUserPoint_Cond.PointId, strComparisonOp_PointId);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.UserId) == true)
{
string strComparisonOp_UserId = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.UserId, objvUserPoint_Cond.UserId, strComparisonOp_UserId);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.UserName) == true)
{
string strComparisonOp_UserName = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.UserName, objvUserPoint_Cond.UserName, strComparisonOp_UserName);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.UserStateId) == true)
{
string strComparisonOp_UserStateId = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.UserStateId, objvUserPoint_Cond.UserStateId, strComparisonOp_UserStateId);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.UserStateName) == true)
{
string strComparisonOp_UserStateName = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.UserStateName, objvUserPoint_Cond.UserStateName, strComparisonOp_UserStateName);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.id_XzCollege, objvUserPoint_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.CollegeNameA, objvUserPoint_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.IdentityID) == true)
{
string strComparisonOp_IdentityID = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.IdentityID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.IdentityID, objvUserPoint_Cond.IdentityID, strComparisonOp_IdentityID);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.IdentityDesc) == true)
{
string strComparisonOp_IdentityDesc = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.IdentityDesc, objvUserPoint_Cond.IdentityDesc, strComparisonOp_IdentityDesc);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.Longitude) == true)
{
string strComparisonOp_Longitude = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.Longitude];
strWhereCond += string.Format(" And {0} {2} {1}", convUserPoint.Longitude, objvUserPoint_Cond.Longitude, strComparisonOp_Longitude);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.Latitude) == true)
{
string strComparisonOp_Latitude = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.Latitude];
strWhereCond += string.Format(" And {0} {2} {1}", convUserPoint.Latitude, objvUserPoint_Cond.Latitude, strComparisonOp_Latitude);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.Address) == true)
{
string strComparisonOp_Address = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.Address];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.Address, objvUserPoint_Cond.Address, strComparisonOp_Address);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.UpdDate, objvUserPoint_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvUserPoint_Cond.IsUpdated(convUserPoint.Memo) == true)
{
string strComparisonOp_Memo = objvUserPoint_Cond.dicFldComparisonOp[convUserPoint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserPoint.Memo, objvUserPoint_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户点位(vUserPoint)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUserPointWApi
{
private static readonly string mstrApiControllerName = "vUserPointApi";

 public clsvUserPointWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserPointEN GetObjByPointId(string strPointId)
{
string strAction = "GetObjByPointId";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserPointEN objvUserPointEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PointId"] = strPointId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvUserPointEN = JsonConvert.DeserializeObject<clsvUserPointEN>((string)jobjReturn["ReturnObj"]);
return objvUserPointEN;
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
 /// <param name = "strPointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserPointEN GetObjByPointId_WA_Cache(string strPointId)
{
string strAction = "GetObjByPointId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserPointEN objvUserPointEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PointId"] = strPointId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvUserPointEN = JsonConvert.DeserializeObject<clsvUserPointEN>((string)jobjReturn["ReturnObj"]);
return objvUserPointEN;
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
public static clsvUserPointEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserPointEN objvUserPointEN = null;
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
objvUserPointEN = JsonConvert.DeserializeObject<clsvUserPointEN>((string)jobjReturn["ReturnObj"]);
return objvUserPointEN;
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
 /// <param name = "strPointId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserPointEN GetObjByPointId_Cache(string strPointId)
{
if (string.IsNullOrEmpty(strPointId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvUserPointEN._CurrTabName_S);
List<clsvUserPointEN> arrvUserPointObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUserPointEN> arrvUserPointObjLst_Sel =
from objvUserPointEN in arrvUserPointObjLst_Cache
where objvUserPointEN.PointId == strPointId
select objvUserPointEN;
if (arrvUserPointObjLst_Sel.Count() == 0)
{
   clsvUserPointEN obj = clsvUserPointWApi.GetObjByPointId(strPointId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvUserPointObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserPointEN> GetObjLst(string strWhereCond)
{
 List<clsvUserPointEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPointEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserPointEN> GetObjLstByPointIdLst(List<string> arrPointId)
{
 List<clsvUserPointEN> arrObjLst = null; 
string strAction = "GetObjLstByPointIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPointId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPointEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strPointId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvUserPointEN> GetObjLstByPointIdLst_Cache(List<string> arrPointId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvUserPointEN._CurrTabName_S);
List<clsvUserPointEN> arrvUserPointObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvUserPointEN> arrvUserPointObjLst_Sel =
from objvUserPointEN in arrvUserPointObjLst_Cache
where arrPointId.Contains(objvUserPointEN.PointId)
select objvUserPointEN;
return arrvUserPointObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserPointEN> GetObjLstByPointIdLst_WA_Cache(List<string> arrPointId)
{
 List<clsvUserPointEN> arrObjLst = null; 
string strAction = "GetObjLstByPointIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPointId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPointEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserPointEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUserPointEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPointEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserPointEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUserPointEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPointEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserPointEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUserPointEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPointEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserPointEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvUserPointEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserPointEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strPointId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PointId"] = strPointId
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
 /// <param name = "objvUserPointENS">源对象</param>
 /// <param name = "objvUserPointENT">目标对象</param>
 public static void CopyTo(clsvUserPointEN objvUserPointENS, clsvUserPointEN objvUserPointENT)
{
try
{
objvUserPointENT.PointId = objvUserPointENS.PointId; //点位Id
objvUserPointENT.UserId = objvUserPointENS.UserId; //用户ID
objvUserPointENT.UserName = objvUserPointENS.UserName; //用户名
objvUserPointENT.UserStateId = objvUserPointENS.UserStateId; //用户状态Id
objvUserPointENT.UserStateName = objvUserPointENS.UserStateName; //用户状态名
objvUserPointENT.id_XzCollege = objvUserPointENS.id_XzCollege; //学院流水号
objvUserPointENT.CollegeNameA = objvUserPointENS.CollegeNameA; //学院名称简写
objvUserPointENT.IdentityID = objvUserPointENS.IdentityID; //身份编号
objvUserPointENT.IdentityDesc = objvUserPointENS.IdentityDesc; //身份描述
objvUserPointENT.Longitude = objvUserPointENS.Longitude; //经度
objvUserPointENT.Latitude = objvUserPointENS.Latitude; //纬度
objvUserPointENT.Address = objvUserPointENS.Address; //地址
objvUserPointENT.UpdDate = objvUserPointENS.UpdDate; //修改日期
objvUserPointENT.Memo = objvUserPointENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvUserPointEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUserPointEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUserPointEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUserPointEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUserPointEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUserPointEN.AttributeName)
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
if (clsUserPointWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserPointWApi没有刷新缓存机制(clsUserPointWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PointId");
//if (arrvUserPointObjLst_Cache == null)
//{
//arrvUserPointObjLst_Cache = await clsvUserPointWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvUserPointEN._CurrTabName_S);
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
public static List<clsvUserPointEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvUserPointEN._CurrTabName_S);
List<clsvUserPointEN> arrvUserPointObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUserPointObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvUserPointEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUserPoint.PointId, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.IdentityID, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.Longitude, Type.GetType("System.Decimal"));
objDT.Columns.Add(convUserPoint.Latitude, Type.GetType("System.Decimal"));
objDT.Columns.Add(convUserPoint.Address, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserPoint.Memo, Type.GetType("System.String"));
foreach (clsvUserPointEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUserPoint.PointId] = objInFor[convUserPoint.PointId];
objDR[convUserPoint.UserId] = objInFor[convUserPoint.UserId];
objDR[convUserPoint.UserName] = objInFor[convUserPoint.UserName];
objDR[convUserPoint.UserStateId] = objInFor[convUserPoint.UserStateId];
objDR[convUserPoint.UserStateName] = objInFor[convUserPoint.UserStateName];
objDR[convUserPoint.id_XzCollege] = objInFor[convUserPoint.id_XzCollege];
objDR[convUserPoint.CollegeNameA] = objInFor[convUserPoint.CollegeNameA];
objDR[convUserPoint.IdentityID] = objInFor[convUserPoint.IdentityID];
objDR[convUserPoint.IdentityDesc] = objInFor[convUserPoint.IdentityDesc];
objDR[convUserPoint.Longitude] = objInFor[convUserPoint.Longitude];
objDR[convUserPoint.Latitude] = objInFor[convUserPoint.Latitude];
objDR[convUserPoint.Address] = objInFor[convUserPoint.Address];
objDR[convUserPoint.UpdDate] = objInFor[convUserPoint.UpdDate];
objDR[convUserPoint.Memo] = objInFor[convUserPoint.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}