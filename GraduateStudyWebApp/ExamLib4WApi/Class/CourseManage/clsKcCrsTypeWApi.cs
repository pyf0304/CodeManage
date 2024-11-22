
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKcCrsTypeWApi
 表名:KcCrsType(01120136)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:36
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
public static class clsKcCrsTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN Setid_CourseType(this clsKcCrsTypeEN objKcCrsTypeEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CourseType, 4, conKcCrsType.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, conKcCrsType.id_CourseType);
objKcCrsTypeEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.id_CourseType) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.id_CourseType, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.id_CourseType] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetCourseTypeID(this clsKcCrsTypeEN objKcCrsTypeEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeID, conKcCrsType.CourseTypeID);
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, conKcCrsType.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, conKcCrsType.CourseTypeID);
objKcCrsTypeEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.CourseTypeID) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.CourseTypeID, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.CourseTypeID] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetCourseTypeName(this clsKcCrsTypeEN objKcCrsTypeEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeName, conKcCrsType.CourseTypeName);
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, conKcCrsType.CourseTypeName);
objKcCrsTypeEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.CourseTypeName) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.CourseTypeName, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.CourseTypeName] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetIsMinor(this clsKcCrsTypeEN objKcCrsTypeEN, bool bolIsMinor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsMinor, conKcCrsType.IsMinor);
objKcCrsTypeEN.IsMinor = bolIsMinor; //是否副修
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.IsMinor) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.IsMinor, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.IsMinor] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetReqOrElect(this clsKcCrsTypeEN objKcCrsTypeEN, bool bolReqOrElect, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolReqOrElect, conKcCrsType.ReqOrElect);
objKcCrsTypeEN.ReqOrElect = bolReqOrElect; //是否必修
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.ReqOrElect) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.ReqOrElect, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.ReqOrElect] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetPointEnabled(this clsKcCrsTypeEN objKcCrsTypeEN, bool bolPointEnabled, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolPointEnabled, conKcCrsType.PointEnabled);
objKcCrsTypeEN.PointEnabled = bolPointEnabled; //是否计学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.PointEnabled) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.PointEnabled, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.PointEnabled] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN Setid_CrsTypeAdminType(this clsKcCrsTypeEN objKcCrsTypeEN, string strid_CrsTypeAdminType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CrsTypeAdminType, 4, conKcCrsType.id_CrsTypeAdminType);
clsCheckSql.CheckFieldForeignKey(strid_CrsTypeAdminType, 4, conKcCrsType.id_CrsTypeAdminType);
objKcCrsTypeEN.id_CrsTypeAdminType = strid_CrsTypeAdminType; //课程类型管理类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.id_CrsTypeAdminType) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.id_CrsTypeAdminType, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.id_CrsTypeAdminType] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetIsCrtlScorePropor(this clsKcCrsTypeEN objKcCrsTypeEN, bool bolIsCrtlScorePropor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCrtlScorePropor, conKcCrsType.IsCrtlScorePropor);
objKcCrsTypeEN.IsCrtlScorePropor = bolIsCrtlScorePropor; //是否控制成绩比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.IsCrtlScorePropor) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.IsCrtlScorePropor, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.IsCrtlScorePropor] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetIsCrtlEduclsMember(this clsKcCrsTypeEN objKcCrsTypeEN, bool bolIsCrtlEduclsMember, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCrtlEduclsMember, conKcCrsType.IsCrtlEduclsMember);
objKcCrsTypeEN.IsCrtlEduclsMember = bolIsCrtlEduclsMember; //是否控制教学班人数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.IsCrtlEduclsMember) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.IsCrtlEduclsMember, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.IsCrtlEduclsMember] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetIsElectiveType(this clsKcCrsTypeEN objKcCrsTypeEN, bool bolIsElectiveType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsElectiveType, conKcCrsType.IsElectiveType);
objKcCrsTypeEN.IsElectiveType = bolIsElectiveType; //是否可选类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.IsElectiveType) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.IsElectiveType, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.IsElectiveType] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetIsOccupyResources(this clsKcCrsTypeEN objKcCrsTypeEN, bool bolIsOccupyResources, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOccupyResources, conKcCrsType.IsOccupyResources);
objKcCrsTypeEN.IsOccupyResources = bolIsOccupyResources; //是否占用资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.IsOccupyResources) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.IsOccupyResources, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.IsOccupyResources] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetIsDistinguishDegree(this clsKcCrsTypeEN objKcCrsTypeEN, bool bolIsDistinguishDegree, string strComparisonOp="")
	{
objKcCrsTypeEN.IsDistinguishDegree = bolIsDistinguishDegree; //是否区分学位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.IsDistinguishDegree) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.IsDistinguishDegree, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.IsDistinguishDegree] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetModifyUserID(this clsKcCrsTypeEN objKcCrsTypeEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conKcCrsType.ModifyUserID);
objKcCrsTypeEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.ModifyUserID) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.ModifyUserID, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.ModifyUserID] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKcCrsTypeEN SetModifyDate(this clsKcCrsTypeEN objKcCrsTypeEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conKcCrsType.ModifyDate);
objKcCrsTypeEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKcCrsTypeEN.dicFldComparisonOp.ContainsKey(conKcCrsType.ModifyDate) == false)
{
objKcCrsTypeEN.dicFldComparisonOp.Add(conKcCrsType.ModifyDate, strComparisonOp);
}
else
{
objKcCrsTypeEN.dicFldComparisonOp[conKcCrsType.ModifyDate] = strComparisonOp;
}
}
return objKcCrsTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsKcCrsTypeEN objKcCrsType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objKcCrsType_Cond.dicFldComparisonOp[conKcCrsType.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKcCrsType.id_CourseType, objKcCrsType_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objKcCrsType_Cond.dicFldComparisonOp[conKcCrsType.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKcCrsType.CourseTypeID, objKcCrsType_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objKcCrsType_Cond.dicFldComparisonOp[conKcCrsType.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKcCrsType.CourseTypeName, objKcCrsType_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.IsMinor) == true)
{
if (objKcCrsType_Cond.IsMinor == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKcCrsType.IsMinor);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKcCrsType.IsMinor);
}
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.ReqOrElect) == true)
{
if (objKcCrsType_Cond.ReqOrElect == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKcCrsType.ReqOrElect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKcCrsType.ReqOrElect);
}
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.PointEnabled) == true)
{
if (objKcCrsType_Cond.PointEnabled == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKcCrsType.PointEnabled);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKcCrsType.PointEnabled);
}
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.id_CrsTypeAdminType) == true)
{
string strComparisonOp_id_CrsTypeAdminType = objKcCrsType_Cond.dicFldComparisonOp[conKcCrsType.id_CrsTypeAdminType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKcCrsType.id_CrsTypeAdminType, objKcCrsType_Cond.id_CrsTypeAdminType, strComparisonOp_id_CrsTypeAdminType);
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.IsCrtlScorePropor) == true)
{
if (objKcCrsType_Cond.IsCrtlScorePropor == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKcCrsType.IsCrtlScorePropor);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKcCrsType.IsCrtlScorePropor);
}
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.IsCrtlEduclsMember) == true)
{
if (objKcCrsType_Cond.IsCrtlEduclsMember == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKcCrsType.IsCrtlEduclsMember);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKcCrsType.IsCrtlEduclsMember);
}
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.IsElectiveType) == true)
{
if (objKcCrsType_Cond.IsElectiveType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKcCrsType.IsElectiveType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKcCrsType.IsElectiveType);
}
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.IsOccupyResources) == true)
{
if (objKcCrsType_Cond.IsOccupyResources == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKcCrsType.IsOccupyResources);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKcCrsType.IsOccupyResources);
}
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.IsDistinguishDegree) == true)
{
if (objKcCrsType_Cond.IsDistinguishDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", conKcCrsType.IsDistinguishDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conKcCrsType.IsDistinguishDegree);
}
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objKcCrsType_Cond.dicFldComparisonOp[conKcCrsType.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKcCrsType.ModifyUserID, objKcCrsType_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objKcCrsType_Cond.IsUpdated(conKcCrsType.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objKcCrsType_Cond.dicFldComparisonOp[conKcCrsType.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKcCrsType.ModifyDate, objKcCrsType_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsKcCrsTypeEN objKcCrsTypeEN)
{
 if (string.IsNullOrEmpty(objKcCrsTypeEN.id_CourseType) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objKcCrsTypeEN.sf_UpdFldSetStr = objKcCrsTypeEN.getsf_UpdFldSetStr();
clsKcCrsTypeWApi.CheckPropertyNew(objKcCrsTypeEN); 
bool bolResult = clsKcCrsTypeWApi.UpdateRecord(objKcCrsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKcCrsTypeWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsKcCrsTypeEN objKcCrsTypeEN)
{
 if (string.IsNullOrEmpty(objKcCrsTypeEN.id_CourseType) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsKcCrsTypeWApi.IsExist(objKcCrsTypeEN.id_CourseType) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objKcCrsTypeEN.id_CourseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsKcCrsTypeWApi.CheckPropertyNew(objKcCrsTypeEN); 
bool bolResult = clsKcCrsTypeWApi.AddNewRecord(objKcCrsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKcCrsTypeWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objKcCrsTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsKcCrsTypeEN objKcCrsTypeEN)
{
try
{
clsKcCrsTypeWApi.CheckPropertyNew(objKcCrsTypeEN); 
string strid_CourseType = clsKcCrsTypeWApi.AddNewRecordWithMaxId(objKcCrsTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKcCrsTypeWApi.ReFreshCache();
return strid_CourseType;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objKcCrsTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsKcCrsTypeEN objKcCrsTypeEN, string strWhereCond)
{
try
{
clsKcCrsTypeWApi.CheckPropertyNew(objKcCrsTypeEN); 
bool bolResult = clsKcCrsTypeWApi.UpdateWithCondition(objKcCrsTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKcCrsTypeWApi.ReFreshCache();
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
 /// 课程类型(KcCrsType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsKcCrsTypeWApi
{
private static readonly string mstrApiControllerName = "KcCrsTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsKcCrsTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_CourseType(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程类型]...","0");
List<clsKcCrsTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_CourseType";
objDDL.DataTextField="CourseTypeName";
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
public static void BindCbo_id_CourseType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conKcCrsType.id_CourseType); 
List<clsKcCrsTypeEN> arrObjLst = clsKcCrsTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsKcCrsTypeEN objKcCrsTypeEN = new clsKcCrsTypeEN()
{
id_CourseType = "0",
CourseTypeName = "选[课程类型]..."
};
arrObjLst.Insert(0, objKcCrsTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conKcCrsType.id_CourseType;
objComboBox.DisplayMember = conKcCrsType.CourseTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsKcCrsTypeEN objKcCrsTypeEN)
{
if (!Object.Equals(null, objKcCrsTypeEN.id_CourseType) && GetStrLen(objKcCrsTypeEN.id_CourseType) > 4)
{
 throw new Exception("字段[课程类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objKcCrsTypeEN.CourseTypeID) && GetStrLen(objKcCrsTypeEN.CourseTypeID) > 4)
{
 throw new Exception("字段[课程类型ID]的长度不能超过4!");
}
if (!Object.Equals(null, objKcCrsTypeEN.CourseTypeName) && GetStrLen(objKcCrsTypeEN.CourseTypeName) > 30)
{
 throw new Exception("字段[课程类型名称]的长度不能超过30!");
}
if (!Object.Equals(null, objKcCrsTypeEN.id_CrsTypeAdminType) && GetStrLen(objKcCrsTypeEN.id_CrsTypeAdminType) > 4)
{
 throw new Exception("字段[课程类型管理类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objKcCrsTypeEN.ModifyUserID) && GetStrLen(objKcCrsTypeEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objKcCrsTypeEN.ModifyDate) && GetStrLen(objKcCrsTypeEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
 objKcCrsTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_CourseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsKcCrsTypeEN GetObjByid_CourseType(string strid_CourseType)
{
string strAction = "GetObjByid_CourseType";
string strErrMsg = string.Empty;
string strResult = "";
clsKcCrsTypeEN objKcCrsTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CourseType"] = strid_CourseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objKcCrsTypeEN = JsonConvert.DeserializeObject<clsKcCrsTypeEN>((string)jobjReturn["ReturnObj"]);
return objKcCrsTypeEN;
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
 /// <param name = "strid_CourseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsKcCrsTypeEN GetObjByid_CourseType_WA_Cache(string strid_CourseType)
{
string strAction = "GetObjByid_CourseType_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsKcCrsTypeEN objKcCrsTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CourseType"] = strid_CourseType
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objKcCrsTypeEN = JsonConvert.DeserializeObject<clsKcCrsTypeEN>((string)jobjReturn["ReturnObj"]);
return objKcCrsTypeEN;
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
public static clsKcCrsTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsKcCrsTypeEN objKcCrsTypeEN = null;
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
objKcCrsTypeEN = JsonConvert.DeserializeObject<clsKcCrsTypeEN>((string)jobjReturn["ReturnObj"]);
return objKcCrsTypeEN;
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
 /// <param name = "strid_CourseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsKcCrsTypeEN GetObjByid_CourseType_Cache(string strid_CourseType)
{
if (string.IsNullOrEmpty(strid_CourseType) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsKcCrsTypeEN._CurrTabName_S);
List<clsKcCrsTypeEN> arrKcCrsTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKcCrsTypeEN> arrKcCrsTypeObjLst_Sel =
from objKcCrsTypeEN in arrKcCrsTypeObjLst_Cache
where objKcCrsTypeEN.id_CourseType == strid_CourseType
select objKcCrsTypeEN;
if (arrKcCrsTypeObjLst_Sel.Count() == 0)
{
   clsKcCrsTypeEN obj = clsKcCrsTypeWApi.GetObjByid_CourseType(strid_CourseType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrKcCrsTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CourseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseTypeNameByid_CourseType_Cache(string strid_CourseType)
{
if (string.IsNullOrEmpty(strid_CourseType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsKcCrsTypeEN._CurrTabName_S);
List<clsKcCrsTypeEN> arrKcCrsTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKcCrsTypeEN> arrKcCrsTypeObjLst_Sel1 =
from objKcCrsTypeEN in arrKcCrsTypeObjLst_Cache
where objKcCrsTypeEN.id_CourseType == strid_CourseType
select objKcCrsTypeEN;
List <clsKcCrsTypeEN> arrKcCrsTypeObjLst_Sel = new List<clsKcCrsTypeEN>();
foreach (clsKcCrsTypeEN obj in arrKcCrsTypeObjLst_Sel1)
{
arrKcCrsTypeObjLst_Sel.Add(obj);
}
if (arrKcCrsTypeObjLst_Sel.Count > 0)
{
return arrKcCrsTypeObjLst_Sel[0].CourseTypeName;
}
string strErrMsgForGetObjById = string.Format("在KcCrsType对象缓存列表中,找不到记录[id_CourseType = {0}](函数:{1})", strid_CourseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsKcCrsTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_CourseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_CourseType_Cache(string strid_CourseType)
{
if (string.IsNullOrEmpty(strid_CourseType) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsKcCrsTypeEN._CurrTabName_S);
List<clsKcCrsTypeEN> arrKcCrsTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKcCrsTypeEN> arrKcCrsTypeObjLst_Sel1 =
from objKcCrsTypeEN in arrKcCrsTypeObjLst_Cache
where objKcCrsTypeEN.id_CourseType == strid_CourseType
select objKcCrsTypeEN;
List <clsKcCrsTypeEN> arrKcCrsTypeObjLst_Sel = new List<clsKcCrsTypeEN>();
foreach (clsKcCrsTypeEN obj in arrKcCrsTypeObjLst_Sel1)
{
arrKcCrsTypeObjLst_Sel.Add(obj);
}
if (arrKcCrsTypeObjLst_Sel.Count > 0)
{
return arrKcCrsTypeObjLst_Sel[0].CourseTypeName;
}
string strErrMsgForGetObjById = string.Format("在KcCrsType对象缓存列表中,找不到记录的相关名称[id_CourseType = {0}](函数:{1})", strid_CourseType, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsKcCrsTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKcCrsTypeEN> GetObjLst(string strWhereCond)
{
 List<clsKcCrsTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKcCrsTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKcCrsTypeEN> GetObjLstById_CourseTypeLst(List<string> arrId_CourseType)
{
 List<clsKcCrsTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseTypeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsKcCrsTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_CourseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsKcCrsTypeEN> GetObjLstById_CourseTypeLst_Cache(List<string> arrId_CourseType)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsKcCrsTypeEN._CurrTabName_S);
List<clsKcCrsTypeEN> arrKcCrsTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKcCrsTypeEN> arrKcCrsTypeObjLst_Sel =
from objKcCrsTypeEN in arrKcCrsTypeObjLst_Cache
where arrId_CourseType.Contains(objKcCrsTypeEN.id_CourseType)
select objKcCrsTypeEN;
return arrKcCrsTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKcCrsTypeEN> GetObjLstById_CourseTypeLst_WA_Cache(List<string> arrId_CourseType)
{
 List<clsKcCrsTypeEN> arrObjLst = null; 
string strAction = "GetObjLstById_CourseTypeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CourseType);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsKcCrsTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKcCrsTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsKcCrsTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKcCrsTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKcCrsTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsKcCrsTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKcCrsTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKcCrsTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsKcCrsTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKcCrsTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKcCrsTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsKcCrsTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKcCrsTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_CourseType)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsKcCrsTypeEN objKcCrsTypeEN = clsKcCrsTypeWApi.GetObjByid_CourseType(strid_CourseType);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_CourseType.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsKcCrsTypeWApi.ReFreshCache();
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
public static int DelKcCrsTypes(List<string> arrid_CourseType)
{
string strAction = "DelKcCrsTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_CourseType);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsKcCrsTypeWApi.ReFreshCache();
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
public static int DelKcCrsTypesByCond(string strWhereCond)
{
string strAction = "DelKcCrsTypesByCond";
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
public static bool AddNewRecord(clsKcCrsTypeEN objKcCrsTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKcCrsTypeEN>(objKcCrsTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKcCrsTypeWApi.ReFreshCache();
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsKcCrsTypeEN objKcCrsTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKcCrsTypeEN>(objKcCrsTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKcCrsTypeWApi.ReFreshCache();
var strid_CourseType = (string)jobjReturn["ReturnStr"];
return strid_CourseType;
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
public static bool UpdateRecord(clsKcCrsTypeEN objKcCrsTypeEN)
{
if (string.IsNullOrEmpty(objKcCrsTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKcCrsTypeEN.id_CourseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKcCrsTypeEN>(objKcCrsTypeEN);
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
 /// <param name = "objKcCrsTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsKcCrsTypeEN objKcCrsTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objKcCrsTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKcCrsTypeEN.id_CourseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKcCrsTypeEN.id_CourseType, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKcCrsTypeEN>(objKcCrsTypeEN);
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
public static bool IsExist(string strid_CourseType)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CourseType"] = strid_CourseType
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objKcCrsTypeENS">源对象</param>
 /// <param name = "objKcCrsTypeENT">目标对象</param>
 public static void CopyTo(clsKcCrsTypeEN objKcCrsTypeENS, clsKcCrsTypeEN objKcCrsTypeENT)
{
try
{
objKcCrsTypeENT.id_CourseType = objKcCrsTypeENS.id_CourseType; //课程类型流水号
objKcCrsTypeENT.CourseTypeID = objKcCrsTypeENS.CourseTypeID; //课程类型ID
objKcCrsTypeENT.CourseTypeName = objKcCrsTypeENS.CourseTypeName; //课程类型名称
objKcCrsTypeENT.IsMinor = objKcCrsTypeENS.IsMinor; //是否副修
objKcCrsTypeENT.ReqOrElect = objKcCrsTypeENS.ReqOrElect; //是否必修
objKcCrsTypeENT.PointEnabled = objKcCrsTypeENS.PointEnabled; //是否计学分
objKcCrsTypeENT.id_CrsTypeAdminType = objKcCrsTypeENS.id_CrsTypeAdminType; //课程类型管理类型流水号
objKcCrsTypeENT.IsCrtlScorePropor = objKcCrsTypeENS.IsCrtlScorePropor; //是否控制成绩比例
objKcCrsTypeENT.IsCrtlEduclsMember = objKcCrsTypeENS.IsCrtlEduclsMember; //是否控制教学班人数
objKcCrsTypeENT.IsElectiveType = objKcCrsTypeENS.IsElectiveType; //是否可选类型
objKcCrsTypeENT.IsOccupyResources = objKcCrsTypeENS.IsOccupyResources; //是否占用资源
objKcCrsTypeENT.IsDistinguishDegree = objKcCrsTypeENS.IsDistinguishDegree; //是否区分学位
objKcCrsTypeENT.ModifyUserID = objKcCrsTypeENS.ModifyUserID; //修改人
objKcCrsTypeENT.ModifyDate = objKcCrsTypeENS.ModifyDate; //修改日期
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
public static DataTable ToDataTable(List<clsKcCrsTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsKcCrsTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsKcCrsTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsKcCrsTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsKcCrsTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsKcCrsTypeEN.AttributeName)
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
if (clsKcCrsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsKcCrsTypeWApi没有刷新缓存机制(clsKcCrsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CourseType");
//if (arrKcCrsTypeObjLst_Cache == null)
//{
//arrKcCrsTypeObjLst_Cache = await clsKcCrsTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsKcCrsTypeEN._CurrTabName_S);
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
if (clsKcCrsTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsKcCrsTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsKcCrsTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsKcCrsTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsKcCrsTypeEN._CurrTabName_S);
List<clsKcCrsTypeEN> arrKcCrsTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrKcCrsTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsKcCrsTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conKcCrsType.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(conKcCrsType.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(conKcCrsType.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conKcCrsType.IsMinor, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKcCrsType.ReqOrElect, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKcCrsType.PointEnabled, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKcCrsType.id_CrsTypeAdminType, Type.GetType("System.String"));
objDT.Columns.Add(conKcCrsType.IsCrtlScorePropor, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKcCrsType.IsCrtlEduclsMember, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKcCrsType.IsElectiveType, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKcCrsType.IsOccupyResources, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKcCrsType.IsDistinguishDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(conKcCrsType.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conKcCrsType.ModifyDate, Type.GetType("System.String"));
foreach (clsKcCrsTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conKcCrsType.id_CourseType] = objInFor[conKcCrsType.id_CourseType];
objDR[conKcCrsType.CourseTypeID] = objInFor[conKcCrsType.CourseTypeID];
objDR[conKcCrsType.CourseTypeName] = objInFor[conKcCrsType.CourseTypeName];
objDR[conKcCrsType.IsMinor] = objInFor[conKcCrsType.IsMinor];
objDR[conKcCrsType.ReqOrElect] = objInFor[conKcCrsType.ReqOrElect];
objDR[conKcCrsType.PointEnabled] = objInFor[conKcCrsType.PointEnabled];
objDR[conKcCrsType.id_CrsTypeAdminType] = objInFor[conKcCrsType.id_CrsTypeAdminType];
objDR[conKcCrsType.IsCrtlScorePropor] = objInFor[conKcCrsType.IsCrtlScorePropor];
objDR[conKcCrsType.IsCrtlEduclsMember] = objInFor[conKcCrsType.IsCrtlEduclsMember];
objDR[conKcCrsType.IsElectiveType] = objInFor[conKcCrsType.IsElectiveType];
objDR[conKcCrsType.IsOccupyResources] = objInFor[conKcCrsType.IsOccupyResources];
objDR[conKcCrsType.IsDistinguishDegree] = objInFor[conKcCrsType.IsDistinguishDegree];
objDR[conKcCrsType.ModifyUserID] = objInFor[conKcCrsType.ModifyUserID];
objDR[conKcCrsType.ModifyDate] = objInFor[conKcCrsType.ModifyDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 课程类型(KcCrsType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4KcCrsType : clsCommFun4BL
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
clsKcCrsTypeWApi.ReFreshThisCache();
}
}

}