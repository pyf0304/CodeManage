
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeacherInfoWApi
 表名:vTeacherInfo(01120094)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:01
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理
 模块英文名:PeopleManage
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
public static class clsvTeacherInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Teacher(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Teacher, 8, convTeacherInfo.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, convTeacherInfo.id_Teacher);
objvTeacherInfoEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Teacher) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Teacher, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Teacher] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetTeacherID(this clsvTeacherInfoEN objvTeacherInfoEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convTeacherInfo.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convTeacherInfo.TeacherID);
objvTeacherInfoEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.TeacherID) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.TeacherID, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.TeacherID] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetTeacherName(this clsvTeacherInfoEN objvTeacherInfoEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convTeacherInfo.TeacherName);
clsCheckSql.CheckFieldLen(strTeacherName, 50, convTeacherInfo.TeacherName);
objvTeacherInfoEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.TeacherName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.TeacherName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.TeacherName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Sex(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Sex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Sex, convTeacherInfo.id_Sex);
clsCheckSql.CheckFieldLen(strid_Sex, 4, convTeacherInfo.id_Sex);
clsCheckSql.CheckFieldForeignKey(strid_Sex, 4, convTeacherInfo.id_Sex);
objvTeacherInfoEN.id_Sex = strid_Sex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Sex) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Sex, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Sex] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetSexDesc(this clsvTeacherInfoEN objvTeacherInfoEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convTeacherInfo.SexDesc);
objvTeacherInfoEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.SexDesc) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.SexDesc, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.SexDesc] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_School_Ps(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_School_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School_Ps, 4, convTeacherInfo.id_School_Ps);
clsCheckSql.CheckFieldForeignKey(strid_School_Ps, 4, convTeacherInfo.id_School_Ps);
objvTeacherInfoEN.id_School_Ps = strid_School_Ps; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_School_Ps) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_School_Ps, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_School_Ps] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetSchoolId(this clsvTeacherInfoEN objvTeacherInfoEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convTeacherInfo.SchoolId);
objvTeacherInfoEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.SchoolId) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.SchoolId, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.SchoolId] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetSchoolName(this clsvTeacherInfoEN objvTeacherInfoEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convTeacherInfo.SchoolName);
objvTeacherInfoEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.SchoolName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.SchoolName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.SchoolName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Discipline_Ps(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Discipline_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline_Ps, 4, convTeacherInfo.id_Discipline_Ps);
clsCheckSql.CheckFieldForeignKey(strid_Discipline_Ps, 4, convTeacherInfo.id_Discipline_Ps);
objvTeacherInfoEN.id_Discipline_Ps = strid_Discipline_Ps; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Discipline_Ps) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Discipline_Ps, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Discipline_Ps] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_UniZone(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_UniZone, convTeacherInfo.id_UniZone);
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convTeacherInfo.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convTeacherInfo.id_UniZone);
objvTeacherInfoEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_UniZone) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_UniZone, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_UniZone] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetUniZoneDesc(this clsvTeacherInfoEN objvTeacherInfoEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convTeacherInfo.UniZoneDesc);
objvTeacherInfoEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.UniZoneDesc) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.UniZoneDesc, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.UniZoneDesc] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Ethnic(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Ethnic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Ethnic, convTeacherInfo.id_Ethnic);
clsCheckSql.CheckFieldLen(strid_Ethnic, 4, convTeacherInfo.id_Ethnic);
clsCheckSql.CheckFieldForeignKey(strid_Ethnic, 4, convTeacherInfo.id_Ethnic);
objvTeacherInfoEN.id_Ethnic = strid_Ethnic; //民族流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Ethnic) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Ethnic, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Ethnic] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetEthnicName(this clsvTeacherInfoEN objvTeacherInfoEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convTeacherInfo.EthnicName);
objvTeacherInfoEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.EthnicName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.EthnicName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.EthnicName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Politics(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Politics, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Politics, convTeacherInfo.id_Politics);
clsCheckSql.CheckFieldLen(strid_Politics, 4, convTeacherInfo.id_Politics);
clsCheckSql.CheckFieldForeignKey(strid_Politics, 4, convTeacherInfo.id_Politics);
objvTeacherInfoEN.id_Politics = strid_Politics; //政治面貌流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Politics) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Politics, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Politics] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetPoliticsName(this clsvTeacherInfoEN objvTeacherInfoEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPoliticsName, convTeacherInfo.PoliticsName);
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convTeacherInfo.PoliticsName);
objvTeacherInfoEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.PoliticsName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.PoliticsName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.PoliticsName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_AdminGrade(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_AdminGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AdminGrade, convTeacherInfo.id_AdminGrade);
clsCheckSql.CheckFieldLen(strid_AdminGrade, 4, convTeacherInfo.id_AdminGrade);
clsCheckSql.CheckFieldForeignKey(strid_AdminGrade, 4, convTeacherInfo.id_AdminGrade);
objvTeacherInfoEN.id_AdminGrade = strid_AdminGrade; //行政职务流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_AdminGrade) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_AdminGrade, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_AdminGrade] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetAdminGradeDesc(this clsvTeacherInfoEN objvTeacherInfoEN, string strAdminGradeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAdminGradeDesc, convTeacherInfo.AdminGradeDesc);
clsCheckSql.CheckFieldLen(strAdminGradeDesc, 30, convTeacherInfo.AdminGradeDesc);
objvTeacherInfoEN.AdminGradeDesc = strAdminGradeDesc; //行政职务描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.AdminGradeDesc) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.AdminGradeDesc, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.AdminGradeDesc] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_ProfGrade(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_ProfGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ProfGrade, convTeacherInfo.id_ProfGrade);
clsCheckSql.CheckFieldLen(strid_ProfGrade, 4, convTeacherInfo.id_ProfGrade);
clsCheckSql.CheckFieldForeignKey(strid_ProfGrade, 4, convTeacherInfo.id_ProfGrade);
objvTeacherInfoEN.id_ProfGrade = strid_ProfGrade; //专业职称流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_ProfGrade) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_ProfGrade, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_ProfGrade] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetProfenssionalGradeName(this clsvTeacherInfoEN objvTeacherInfoEN, string strProfenssionalGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProfenssionalGradeName, convTeacherInfo.ProfenssionalGradeName);
clsCheckSql.CheckFieldLen(strProfenssionalGradeName, 30, convTeacherInfo.ProfenssionalGradeName);
objvTeacherInfoEN.ProfenssionalGradeName = strProfenssionalGradeName; //专业职称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.ProfenssionalGradeName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.ProfenssionalGradeName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.ProfenssionalGradeName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Qualif(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Qualif, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Qualif, convTeacherInfo.id_Qualif);
clsCheckSql.CheckFieldLen(strid_Qualif, 4, convTeacherInfo.id_Qualif);
clsCheckSql.CheckFieldForeignKey(strid_Qualif, 4, convTeacherInfo.id_Qualif);
objvTeacherInfoEN.id_Qualif = strid_Qualif; //学历流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Qualif) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Qualif, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Qualif] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetQualifDesc(this clsvTeacherInfoEN objvTeacherInfoEN, string strQualifDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQualifDesc, 30, convTeacherInfo.QualifDesc);
objvTeacherInfoEN.QualifDesc = strQualifDesc; //QualifDesc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.QualifDesc) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.QualifDesc, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.QualifDesc] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Degree(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Degree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Degree, convTeacherInfo.id_Degree);
clsCheckSql.CheckFieldLen(strid_Degree, 4, convTeacherInfo.id_Degree);
clsCheckSql.CheckFieldForeignKey(strid_Degree, 4, convTeacherInfo.id_Degree);
objvTeacherInfoEN.id_Degree = strid_Degree; //学位流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Degree) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Degree, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Degree] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetDegreeName(this clsvTeacherInfoEN objvTeacherInfoEN, string strDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDegreeName, convTeacherInfo.DegreeName);
clsCheckSql.CheckFieldLen(strDegreeName, 30, convTeacherInfo.DegreeName);
objvTeacherInfoEN.DegreeName = strDegreeName; //学位名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.DegreeName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.DegreeName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.DegreeName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_StaffType(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_StaffType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StaffType, convTeacherInfo.id_StaffType);
clsCheckSql.CheckFieldLen(strid_StaffType, 4, convTeacherInfo.id_StaffType);
clsCheckSql.CheckFieldForeignKey(strid_StaffType, 4, convTeacherInfo.id_StaffType);
objvTeacherInfoEN.id_StaffType = strid_StaffType; //职工类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_StaffType) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_StaffType, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_StaffType] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetStaffTypeName(this clsvTeacherInfoEN objvTeacherInfoEN, string strStaffTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStaffTypeName, 30, convTeacherInfo.StaffTypeName);
objvTeacherInfoEN.StaffTypeName = strStaffTypeName; //职工类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.StaffTypeName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.StaffTypeName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.StaffTypeName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Province(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Province, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Province, convTeacherInfo.id_Province);
clsCheckSql.CheckFieldLen(strid_Province, 4, convTeacherInfo.id_Province);
clsCheckSql.CheckFieldForeignKey(strid_Province, 4, convTeacherInfo.id_Province);
objvTeacherInfoEN.id_Province = strid_Province; //省份流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Province) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Province, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Province] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetProvinceName(this clsvTeacherInfoEN objvTeacherInfoEN, string strProvinceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProvinceName, 30, convTeacherInfo.ProvinceName);
objvTeacherInfoEN.ProvinceName = strProvinceName; //ProvinceName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.ProvinceName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.ProvinceName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.ProvinceName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetCitizenID(this clsvTeacherInfoEN objvTeacherInfoEN, string strCitizenID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCitizenID, 25, convTeacherInfo.CitizenID);
objvTeacherInfoEN.CitizenID = strCitizenID; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.CitizenID) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.CitizenID, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.CitizenID] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetCardNo(this clsvTeacherInfoEN objvTeacherInfoEN, string strCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCardNo, 18, convTeacherInfo.CardNo);
objvTeacherInfoEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.CardNo) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.CardNo, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.CardNo] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetBirthday(this clsvTeacherInfoEN objvTeacherInfoEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convTeacherInfo.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convTeacherInfo.Birthday);
objvTeacherInfoEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.Birthday) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.Birthday, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.Birthday] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetGraduationMajor(this clsvTeacherInfoEN objvTeacherInfoEN, string strGraduationMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGraduationMajor, 40, convTeacherInfo.GraduationMajor);
objvTeacherInfoEN.GraduationMajor = strGraduationMajor; //毕业专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.GraduationMajor) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.GraduationMajor, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.GraduationMajor] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetTelNo(this clsvTeacherInfoEN objvTeacherInfoEN, string strTelNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTelNo, 50, convTeacherInfo.TelNo);
objvTeacherInfoEN.TelNo = strTelNo; //电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.TelNo) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.TelNo, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.TelNo] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetEmail(this clsvTeacherInfoEN objvTeacherInfoEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, convTeacherInfo.Email);
objvTeacherInfoEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.Email) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.Email, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.Email] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetWebSite(this clsvTeacherInfoEN objvTeacherInfoEN, string strWebSite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSite, 60, convTeacherInfo.WebSite);
objvTeacherInfoEN.WebSite = strWebSite; //个人主页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.WebSite) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.WebSite, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.WebSite] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetPersonBlog(this clsvTeacherInfoEN objvTeacherInfoEN, string strPersonBlog, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPersonBlog, 60, convTeacherInfo.PersonBlog);
objvTeacherInfoEN.PersonBlog = strPersonBlog; //个人博客
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.PersonBlog) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.PersonBlog, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.PersonBlog] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetEntryDate(this clsvTeacherInfoEN objvTeacherInfoEN, string strEntryDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryDate, 8, convTeacherInfo.EntryDate);
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, convTeacherInfo.EntryDate);
objvTeacherInfoEN.EntryDate = strEntryDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.EntryDate) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.EntryDate, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.EntryDate] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetOffed(this clsvTeacherInfoEN objvTeacherInfoEN, bool bolOffed, string strComparisonOp="")
	{
objvTeacherInfoEN.Offed = bolOffed; //是否离校
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.Offed) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.Offed, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.Offed] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetId_CardNo(this clsvTeacherInfoEN objvTeacherInfoEN, string strId_CardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CardNo, 20, convTeacherInfo.Id_CardNo);
objvTeacherInfoEN.Id_CardNo = strId_CardNo; //内卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.Id_CardNo) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.Id_CardNo, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.Id_CardNo] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetIsAvconUser(this clsvTeacherInfoEN objvTeacherInfoEN, bool bolIsAvconUser, string strComparisonOp="")
	{
objvTeacherInfoEN.IsAvconUser = bolIsAvconUser; //IsAvconUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IsAvconUser) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IsAvconUser, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IsAvconUser] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetIsGpUser(this clsvTeacherInfoEN objvTeacherInfoEN, bool bolIsGpUser, string strComparisonOp="")
	{
objvTeacherInfoEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IsGpUser) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IsGpUser, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IsGpUser] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetIsLocalUser(this clsvTeacherInfoEN objvTeacherInfoEN, bool bolIsLocalUser, string strComparisonOp="")
	{
objvTeacherInfoEN.IsLocalUser = bolIsLocalUser; //是否本地用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IsLocalUser) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IsLocalUser, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IsLocalUser] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetFromUnit(this clsvTeacherInfoEN objvTeacherInfoEN, string strFromUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFromUnit, 100, convTeacherInfo.FromUnit);
objvTeacherInfoEN.FromUnit = strFromUnit; //来自单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.FromUnit) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.FromUnit, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.FromUnit] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetMemo(this clsvTeacherInfoEN objvTeacherInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeacherInfo.Memo);
objvTeacherInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.Memo) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.Memo, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.Memo] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_XzCollege(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convTeacherInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convTeacherInfo.id_XzCollege);
objvTeacherInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_XzCollege) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_XzCollege, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_XzCollege] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetCollegeID(this clsvTeacherInfoEN objvTeacherInfoEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeacherInfo.CollegeID);
objvTeacherInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.CollegeID) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.CollegeID, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.CollegeID] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetCollegeName(this clsvTeacherInfoEN objvTeacherInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convTeacherInfo.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeacherInfo.CollegeName);
objvTeacherInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.CollegeName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.CollegeName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.CollegeName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetCollegeNameA(this clsvTeacherInfoEN objvTeacherInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeacherInfo.CollegeNameA);
objvTeacherInfoEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.CollegeNameA) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.CollegeNameA, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.CollegeNameA] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_XzMajor(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convTeacherInfo.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convTeacherInfo.id_XzMajor);
objvTeacherInfoEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_XzMajor) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_XzMajor, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_XzMajor] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetEntryDay(this clsvTeacherInfoEN objvTeacherInfoEN, string strEntryDay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryDay, 8, convTeacherInfo.EntryDay);
clsCheckSql.CheckFieldForeignKey(strEntryDay, 8, convTeacherInfo.EntryDay);
objvTeacherInfoEN.EntryDay = strEntryDay; //EntryDay
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.EntryDay) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.EntryDay, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.EntryDay] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Photo(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Photo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Photo, 8, convTeacherInfo.id_Photo);
clsCheckSql.CheckFieldForeignKey(strid_Photo, 8, convTeacherInfo.id_Photo);
objvTeacherInfoEN.id_Photo = strid_Photo; //id_Photo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Photo) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Photo, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Photo] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN Setid_Religion(this clsvTeacherInfoEN objvTeacherInfoEN, string strid_Religion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Religion, 4, convTeacherInfo.id_Religion);
clsCheckSql.CheckFieldForeignKey(strid_Religion, 4, convTeacherInfo.id_Religion);
objvTeacherInfoEN.id_Religion = strid_Religion; //id_Religion
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.id_Religion) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.id_Religion, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.id_Religion] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetReligionName(this clsvTeacherInfoEN objvTeacherInfoEN, string strReligionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReligionName, 30, convTeacherInfo.ReligionName);
objvTeacherInfoEN.ReligionName = strReligionName; //ReligionName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.ReligionName) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.ReligionName, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.ReligionName] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetIsMessage(this clsvTeacherInfoEN objvTeacherInfoEN, bool bolIsMessage, string strComparisonOp="")
	{
objvTeacherInfoEN.IsMessage = bolIsMessage; //IsMessage
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IsMessage) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IsMessage, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IsMessage] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetMicroblog(this clsvTeacherInfoEN objvTeacherInfoEN, string strMicroblog, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroblog, 200, convTeacherInfo.Microblog);
objvTeacherInfoEN.Microblog = strMicroblog; //Microblog
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.Microblog) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.Microblog, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.Microblog] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetModifyUserID(this clsvTeacherInfoEN objvTeacherInfoEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convTeacherInfo.ModifyUserID);
objvTeacherInfoEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.ModifyUserID) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.ModifyUserID, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.ModifyUserID] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetOffedBak(this clsvTeacherInfoEN objvTeacherInfoEN, bool bolOffedBak, string strComparisonOp="")
	{
objvTeacherInfoEN.OffedBak = bolOffedBak; //OffedBak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.OffedBak) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.OffedBak, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.OffedBak] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetPhoneNumber(this clsvTeacherInfoEN objvTeacherInfoEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convTeacherInfo.PhoneNumber);
objvTeacherInfoEN.PhoneNumber = strPhoneNumber; //PhoneNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.PhoneNumber) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.PhoneNumber, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.PhoneNumber] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetQQ(this clsvTeacherInfoEN objvTeacherInfoEN, string strQQ, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQQ, 100, convTeacherInfo.QQ);
objvTeacherInfoEN.QQ = strQQ; //QQ
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.QQ) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.QQ, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.QQ] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetTeach_id_College(this clsvTeacherInfoEN objvTeacherInfoEN, string strTeach_id_College, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeach_id_College, 6, convTeacherInfo.Teach_id_College);
objvTeacherInfoEN.Teach_id_College = strTeach_id_College; //Teach_id_College
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.Teach_id_College) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.Teach_id_College, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.Teach_id_College] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetTeach_id_Major(this clsvTeacherInfoEN objvTeacherInfoEN, string strTeach_id_Major, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeach_id_Major, 8, convTeacherInfo.Teach_id_Major);
clsCheckSql.CheckFieldForeignKey(strTeach_id_Major, 8, convTeacherInfo.Teach_id_Major);
objvTeacherInfoEN.Teach_id_Major = strTeach_id_Major; //Teach_id_Major
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.Teach_id_Major) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.Teach_id_Major, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.Teach_id_Major] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetTel(this clsvTeacherInfoEN objvTeacherInfoEN, string strTel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTel, 50, convTeacherInfo.Tel);
objvTeacherInfoEN.Tel = strTel; //Tel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.Tel) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.Tel, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.Tel] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetModifyDate(this clsvTeacherInfoEN objvTeacherInfoEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convTeacherInfo.ModifyDate);
objvTeacherInfoEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.ModifyDate) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.ModifyDate, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.ModifyDate] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetRegisterPassword(this clsvTeacherInfoEN objvTeacherInfoEN, string strRegisterPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, convTeacherInfo.RegisterPassword);
objvTeacherInfoEN.RegisterPassword = strRegisterPassword; //RegisterPassword
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.RegisterPassword) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.RegisterPassword, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.RegisterPassword] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetEntryYear(this clsvTeacherInfoEN objvTeacherInfoEN, string strEntryYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryYear, 8, convTeacherInfo.EntryYear);
objvTeacherInfoEN.EntryYear = strEntryYear; //EntryYear
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.EntryYear) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.EntryYear, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.EntryYear] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeacherInfoEN SetDisciplineName_ps(this clsvTeacherInfoEN objvTeacherInfoEN, string strDisciplineName_ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisciplineName_ps, 50, convTeacherInfo.DisciplineName_ps);
objvTeacherInfoEN.DisciplineName_ps = strDisciplineName_ps; //学科
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.DisciplineName_ps) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.DisciplineName_ps, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.DisciplineName_ps] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeacherInfoEN objvTeacherInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Teacher, objvTeacherInfo_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.TeacherID, objvTeacherInfo_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.TeacherName, objvTeacherInfo_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Sex) == true)
{
string strComparisonOp_id_Sex = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Sex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Sex, objvTeacherInfo_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.SexDesc, objvTeacherInfo_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_School_Ps) == true)
{
string strComparisonOp_id_School_Ps = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_School_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_School_Ps, objvTeacherInfo_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.SchoolId, objvTeacherInfo_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.SchoolName, objvTeacherInfo_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Discipline_Ps) == true)
{
string strComparisonOp_id_Discipline_Ps = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Discipline_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Discipline_Ps, objvTeacherInfo_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_UniZone, objvTeacherInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.UniZoneDesc, objvTeacherInfo_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Ethnic) == true)
{
string strComparisonOp_id_Ethnic = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Ethnic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Ethnic, objvTeacherInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.EthnicName, objvTeacherInfo_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Politics) == true)
{
string strComparisonOp_id_Politics = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Politics];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Politics, objvTeacherInfo_Cond.id_Politics, strComparisonOp_id_Politics);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.PoliticsName, objvTeacherInfo_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_AdminGrade) == true)
{
string strComparisonOp_id_AdminGrade = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_AdminGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_AdminGrade, objvTeacherInfo_Cond.id_AdminGrade, strComparisonOp_id_AdminGrade);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.AdminGradeDesc) == true)
{
string strComparisonOp_AdminGradeDesc = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.AdminGradeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.AdminGradeDesc, objvTeacherInfo_Cond.AdminGradeDesc, strComparisonOp_AdminGradeDesc);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_ProfGrade) == true)
{
string strComparisonOp_id_ProfGrade = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_ProfGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_ProfGrade, objvTeacherInfo_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.ProfenssionalGradeName) == true)
{
string strComparisonOp_ProfenssionalGradeName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.ProfenssionalGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ProfenssionalGradeName, objvTeacherInfo_Cond.ProfenssionalGradeName, strComparisonOp_ProfenssionalGradeName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Qualif) == true)
{
string strComparisonOp_id_Qualif = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Qualif];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Qualif, objvTeacherInfo_Cond.id_Qualif, strComparisonOp_id_Qualif);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.QualifDesc) == true)
{
string strComparisonOp_QualifDesc = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.QualifDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.QualifDesc, objvTeacherInfo_Cond.QualifDesc, strComparisonOp_QualifDesc);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Degree) == true)
{
string strComparisonOp_id_Degree = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Degree];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Degree, objvTeacherInfo_Cond.id_Degree, strComparisonOp_id_Degree);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.DegreeName) == true)
{
string strComparisonOp_DegreeName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.DegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.DegreeName, objvTeacherInfo_Cond.DegreeName, strComparisonOp_DegreeName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_StaffType) == true)
{
string strComparisonOp_id_StaffType = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_StaffType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_StaffType, objvTeacherInfo_Cond.id_StaffType, strComparisonOp_id_StaffType);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.StaffTypeName) == true)
{
string strComparisonOp_StaffTypeName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.StaffTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.StaffTypeName, objvTeacherInfo_Cond.StaffTypeName, strComparisonOp_StaffTypeName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Province) == true)
{
string strComparisonOp_id_Province = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Province];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Province, objvTeacherInfo_Cond.id_Province, strComparisonOp_id_Province);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.ProvinceName) == true)
{
string strComparisonOp_ProvinceName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.ProvinceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ProvinceName, objvTeacherInfo_Cond.ProvinceName, strComparisonOp_ProvinceName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.CitizenID) == true)
{
string strComparisonOp_CitizenID = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.CitizenID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CitizenID, objvTeacherInfo_Cond.CitizenID, strComparisonOp_CitizenID);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.CardNo) == true)
{
string strComparisonOp_CardNo = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CardNo, objvTeacherInfo_Cond.CardNo, strComparisonOp_CardNo);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.Birthday) == true)
{
string strComparisonOp_Birthday = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Birthday, objvTeacherInfo_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.GraduationMajor) == true)
{
string strComparisonOp_GraduationMajor = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.GraduationMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.GraduationMajor, objvTeacherInfo_Cond.GraduationMajor, strComparisonOp_GraduationMajor);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.TelNo) == true)
{
string strComparisonOp_TelNo = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.TelNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.TelNo, objvTeacherInfo_Cond.TelNo, strComparisonOp_TelNo);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.Email) == true)
{
string strComparisonOp_Email = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Email, objvTeacherInfo_Cond.Email, strComparisonOp_Email);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.WebSite) == true)
{
string strComparisonOp_WebSite = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.WebSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.WebSite, objvTeacherInfo_Cond.WebSite, strComparisonOp_WebSite);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.PersonBlog) == true)
{
string strComparisonOp_PersonBlog = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.PersonBlog];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.PersonBlog, objvTeacherInfo_Cond.PersonBlog, strComparisonOp_PersonBlog);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.EntryDate) == true)
{
string strComparisonOp_EntryDate = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.EntryDate, objvTeacherInfo_Cond.EntryDate, strComparisonOp_EntryDate);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.Offed) == true)
{
if (objvTeacherInfo_Cond.Offed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.Offed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.Offed);
}
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.Id_CardNo) == true)
{
string strComparisonOp_Id_CardNo = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.Id_CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Id_CardNo, objvTeacherInfo_Cond.Id_CardNo, strComparisonOp_Id_CardNo);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.IsAvconUser) == true)
{
if (objvTeacherInfo_Cond.IsAvconUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.IsAvconUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.IsAvconUser);
}
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.IsGpUser) == true)
{
if (objvTeacherInfo_Cond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.IsGpUser);
}
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.IsLocalUser) == true)
{
if (objvTeacherInfo_Cond.IsLocalUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.IsLocalUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.IsLocalUser);
}
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.FromUnit) == true)
{
string strComparisonOp_FromUnit = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.FromUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.FromUnit, objvTeacherInfo_Cond.FromUnit, strComparisonOp_FromUnit);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.Memo) == true)
{
string strComparisonOp_Memo = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Memo, objvTeacherInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_XzCollege, objvTeacherInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CollegeID, objvTeacherInfo_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CollegeName, objvTeacherInfo_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CollegeNameA, objvTeacherInfo_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_XzMajor, objvTeacherInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.EntryDay) == true)
{
string strComparisonOp_EntryDay = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.EntryDay];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.EntryDay, objvTeacherInfo_Cond.EntryDay, strComparisonOp_EntryDay);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Photo) == true)
{
string strComparisonOp_id_Photo = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Photo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Photo, objvTeacherInfo_Cond.id_Photo, strComparisonOp_id_Photo);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.id_Religion) == true)
{
string strComparisonOp_id_Religion = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.id_Religion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.id_Religion, objvTeacherInfo_Cond.id_Religion, strComparisonOp_id_Religion);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.ReligionName) == true)
{
string strComparisonOp_ReligionName = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.ReligionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ReligionName, objvTeacherInfo_Cond.ReligionName, strComparisonOp_ReligionName);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.IsMessage) == true)
{
if (objvTeacherInfo_Cond.IsMessage == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.IsMessage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.IsMessage);
}
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.Microblog) == true)
{
string strComparisonOp_Microblog = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.Microblog];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Microblog, objvTeacherInfo_Cond.Microblog, strComparisonOp_Microblog);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ModifyUserID, objvTeacherInfo_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.OffedBak) == true)
{
if (objvTeacherInfo_Cond.OffedBak == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.OffedBak);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.OffedBak);
}
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.PhoneNumber, objvTeacherInfo_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.QQ) == true)
{
string strComparisonOp_QQ = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.QQ];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.QQ, objvTeacherInfo_Cond.QQ, strComparisonOp_QQ);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.Teach_id_College) == true)
{
string strComparisonOp_Teach_id_College = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.Teach_id_College];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Teach_id_College, objvTeacherInfo_Cond.Teach_id_College, strComparisonOp_Teach_id_College);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.Teach_id_Major) == true)
{
string strComparisonOp_Teach_id_Major = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.Teach_id_Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Teach_id_Major, objvTeacherInfo_Cond.Teach_id_Major, strComparisonOp_Teach_id_Major);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.Tel) == true)
{
string strComparisonOp_Tel = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.Tel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Tel, objvTeacherInfo_Cond.Tel, strComparisonOp_Tel);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ModifyDate, objvTeacherInfo_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.RegisterPassword) == true)
{
string strComparisonOp_RegisterPassword = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.RegisterPassword, objvTeacherInfo_Cond.RegisterPassword, strComparisonOp_RegisterPassword);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.EntryYear) == true)
{
string strComparisonOp_EntryYear = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.EntryYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.EntryYear, objvTeacherInfo_Cond.EntryYear, strComparisonOp_EntryYear);
}
if (objvTeacherInfo_Cond.IsUpdated(convTeacherInfo.DisciplineName_ps) == true)
{
string strComparisonOp_DisciplineName_ps = objvTeacherInfo_Cond.dicFldComparisonOp[convTeacherInfo.DisciplineName_ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.DisciplineName_ps, objvTeacherInfo_Cond.DisciplineName_ps, strComparisonOp_DisciplineName_ps);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教师(vTeacherInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeacherInfoWApi
{
private static readonly string mstrApiControllerName = "vTeacherInfoApi";

 public clsvTeacherInfoWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_Teacher(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教师]...","0");
List<clsvTeacherInfoEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_Teacher";
objDDL.DataTextField="TeacherName";
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
public static void BindCbo_id_Teacher(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convTeacherInfo.id_Teacher); 
List<clsvTeacherInfoEN> arrObjLst = clsvTeacherInfoWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN()
{
id_Teacher = "0",
TeacherName = "选[v教师]..."
};
arrObjLst.Insert(0, objvTeacherInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convTeacherInfo.id_Teacher;
objComboBox.DisplayMember = convTeacherInfo.TeacherName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_Teacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeacherInfoEN GetObjByid_Teacher(string strid_Teacher)
{
string strAction = "GetObjByid_Teacher";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeacherInfoEN objvTeacherInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Teacher"] = strid_Teacher
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeacherInfoEN = JsonConvert.DeserializeObject<clsvTeacherInfoEN>((string)jobjReturn["ReturnObj"]);
return objvTeacherInfoEN;
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
 /// <param name = "strid_Teacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeacherInfoEN GetObjByid_Teacher_WA_Cache(string strid_Teacher)
{
string strAction = "GetObjByid_Teacher_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeacherInfoEN objvTeacherInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Teacher"] = strid_Teacher
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeacherInfoEN = JsonConvert.DeserializeObject<clsvTeacherInfoEN>((string)jobjReturn["ReturnObj"]);
return objvTeacherInfoEN;
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
public static clsvTeacherInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeacherInfoEN objvTeacherInfoEN = null;
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
objvTeacherInfoEN = JsonConvert.DeserializeObject<clsvTeacherInfoEN>((string)jobjReturn["ReturnObj"]);
return objvTeacherInfoEN;
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
 /// <param name = "strid_Teacher">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeacherInfoEN GetObjByid_Teacher_Cache(string strid_Teacher)
{
if (string.IsNullOrEmpty(strid_Teacher) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName_S);
List<clsvTeacherInfoEN> arrvTeacherInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeacherInfoEN> arrvTeacherInfoObjLst_Sel =
from objvTeacherInfoEN in arrvTeacherInfoObjLst_Cache
where objvTeacherInfoEN.id_Teacher == strid_Teacher
select objvTeacherInfoEN;
if (arrvTeacherInfoObjLst_Sel.Count() == 0)
{
   clsvTeacherInfoEN obj = clsvTeacherInfoWApi.GetObjByid_Teacher(strid_Teacher);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeacherInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Teacher">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeacherNameByid_Teacher_Cache(string strid_Teacher)
{
if (string.IsNullOrEmpty(strid_Teacher) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName_S);
List<clsvTeacherInfoEN> arrvTeacherInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeacherInfoEN> arrvTeacherInfoObjLst_Sel1 =
from objvTeacherInfoEN in arrvTeacherInfoObjLst_Cache
where objvTeacherInfoEN.id_Teacher == strid_Teacher
select objvTeacherInfoEN;
List <clsvTeacherInfoEN> arrvTeacherInfoObjLst_Sel = new List<clsvTeacherInfoEN>();
foreach (clsvTeacherInfoEN obj in arrvTeacherInfoObjLst_Sel1)
{
arrvTeacherInfoObjLst_Sel.Add(obj);
}
if (arrvTeacherInfoObjLst_Sel.Count > 0)
{
return arrvTeacherInfoObjLst_Sel[0].TeacherName;
}
string strErrMsgForGetObjById = string.Format("在vTeacherInfo对象缓存列表中,找不到记录[id_Teacher = {0}](函数:{1})", strid_Teacher, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTeacherInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Teacher">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_Teacher_Cache(string strid_Teacher)
{
if (string.IsNullOrEmpty(strid_Teacher) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName_S);
List<clsvTeacherInfoEN> arrvTeacherInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeacherInfoEN> arrvTeacherInfoObjLst_Sel1 =
from objvTeacherInfoEN in arrvTeacherInfoObjLst_Cache
where objvTeacherInfoEN.id_Teacher == strid_Teacher
select objvTeacherInfoEN;
List <clsvTeacherInfoEN> arrvTeacherInfoObjLst_Sel = new List<clsvTeacherInfoEN>();
foreach (clsvTeacherInfoEN obj in arrvTeacherInfoObjLst_Sel1)
{
arrvTeacherInfoObjLst_Sel.Add(obj);
}
if (arrvTeacherInfoObjLst_Sel.Count > 0)
{
return arrvTeacherInfoObjLst_Sel[0].TeacherName;
}
string strErrMsgForGetObjById = string.Format("在vTeacherInfo对象缓存列表中,找不到记录的相关名称[id_Teacher = {0}](函数:{1})", strid_Teacher, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTeacherInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeacherInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeacherInfoEN> GetObjLstById_TeacherLst(List<string> arrId_Teacher)
{
 List<clsvTeacherInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeacherLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Teacher);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_Teacher">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeacherInfoEN> GetObjLstById_TeacherLst_Cache(List<string> arrId_Teacher)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName_S);
List<clsvTeacherInfoEN> arrvTeacherInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeacherInfoEN> arrvTeacherInfoObjLst_Sel =
from objvTeacherInfoEN in arrvTeacherInfoObjLst_Cache
where arrId_Teacher.Contains(objvTeacherInfoEN.id_Teacher)
select objvTeacherInfoEN;
return arrvTeacherInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeacherInfoEN> GetObjLstById_TeacherLst_WA_Cache(List<string> arrId_Teacher)
{
 List<clsvTeacherInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeacherLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Teacher);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeacherInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeacherInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeacherInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeacherInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_Teacher)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Teacher"] = strid_Teacher
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
 /// <param name = "objvTeacherInfoENS">源对象</param>
 /// <param name = "objvTeacherInfoENT">目标对象</param>
 public static void CopyTo(clsvTeacherInfoEN objvTeacherInfoENS, clsvTeacherInfoEN objvTeacherInfoENT)
{
try
{
objvTeacherInfoENT.id_Teacher = objvTeacherInfoENS.id_Teacher; //教师流水号
objvTeacherInfoENT.TeacherID = objvTeacherInfoENS.TeacherID; //教师工号
objvTeacherInfoENT.TeacherName = objvTeacherInfoENS.TeacherName; //教师姓名
objvTeacherInfoENT.id_Sex = objvTeacherInfoENS.id_Sex; //性别流水号
objvTeacherInfoENT.SexDesc = objvTeacherInfoENS.SexDesc; //性别名称
objvTeacherInfoENT.id_School_Ps = objvTeacherInfoENS.id_School_Ps; //学校流水号
objvTeacherInfoENT.SchoolId = objvTeacherInfoENS.SchoolId; //学校编号
objvTeacherInfoENT.SchoolName = objvTeacherInfoENS.SchoolName; //学校名称
objvTeacherInfoENT.id_Discipline_Ps = objvTeacherInfoENS.id_Discipline_Ps; //学科流水号
objvTeacherInfoENT.id_UniZone = objvTeacherInfoENS.id_UniZone; //校区流水号
objvTeacherInfoENT.UniZoneDesc = objvTeacherInfoENS.UniZoneDesc; //校区名称
objvTeacherInfoENT.id_Ethnic = objvTeacherInfoENS.id_Ethnic; //民族流水号
objvTeacherInfoENT.EthnicName = objvTeacherInfoENS.EthnicName; //民族名称
objvTeacherInfoENT.id_Politics = objvTeacherInfoENS.id_Politics; //政治面貌流水号
objvTeacherInfoENT.PoliticsName = objvTeacherInfoENS.PoliticsName; //政治面貌
objvTeacherInfoENT.id_AdminGrade = objvTeacherInfoENS.id_AdminGrade; //行政职务流水号
objvTeacherInfoENT.AdminGradeDesc = objvTeacherInfoENS.AdminGradeDesc; //行政职务描述
objvTeacherInfoENT.id_ProfGrade = objvTeacherInfoENS.id_ProfGrade; //专业职称流水号
objvTeacherInfoENT.ProfenssionalGradeName = objvTeacherInfoENS.ProfenssionalGradeName; //专业职称
objvTeacherInfoENT.id_Qualif = objvTeacherInfoENS.id_Qualif; //学历流水号
objvTeacherInfoENT.QualifDesc = objvTeacherInfoENS.QualifDesc; //QualifDesc
objvTeacherInfoENT.id_Degree = objvTeacherInfoENS.id_Degree; //学位流水号
objvTeacherInfoENT.DegreeName = objvTeacherInfoENS.DegreeName; //学位名称
objvTeacherInfoENT.id_StaffType = objvTeacherInfoENS.id_StaffType; //职工类型流水号
objvTeacherInfoENT.StaffTypeName = objvTeacherInfoENS.StaffTypeName; //职工类型名称
objvTeacherInfoENT.id_Province = objvTeacherInfoENS.id_Province; //省份流水号
objvTeacherInfoENT.ProvinceName = objvTeacherInfoENS.ProvinceName; //ProvinceName
objvTeacherInfoENT.CitizenID = objvTeacherInfoENS.CitizenID; //身份证号
objvTeacherInfoENT.CardNo = objvTeacherInfoENS.CardNo; //卡号
objvTeacherInfoENT.Birthday = objvTeacherInfoENS.Birthday; //出生日期
objvTeacherInfoENT.GraduationMajor = objvTeacherInfoENS.GraduationMajor; //毕业专业
objvTeacherInfoENT.TelNo = objvTeacherInfoENS.TelNo; //电话
objvTeacherInfoENT.Email = objvTeacherInfoENS.Email; //电子邮箱
objvTeacherInfoENT.WebSite = objvTeacherInfoENS.WebSite; //个人主页
objvTeacherInfoENT.PersonBlog = objvTeacherInfoENS.PersonBlog; //个人博客
objvTeacherInfoENT.EntryDate = objvTeacherInfoENS.EntryDate; //进校日期
objvTeacherInfoENT.Offed = objvTeacherInfoENS.Offed; //是否离校
objvTeacherInfoENT.Id_CardNo = objvTeacherInfoENS.Id_CardNo; //内卡号
objvTeacherInfoENT.IsAvconUser = objvTeacherInfoENS.IsAvconUser; //IsAvconUser
objvTeacherInfoENT.IsGpUser = objvTeacherInfoENS.IsGpUser; //是否Gp用户
objvTeacherInfoENT.IsLocalUser = objvTeacherInfoENS.IsLocalUser; //是否本地用户
objvTeacherInfoENT.FromUnit = objvTeacherInfoENS.FromUnit; //来自单位
objvTeacherInfoENT.Memo = objvTeacherInfoENS.Memo; //备注
objvTeacherInfoENT.id_XzCollege = objvTeacherInfoENS.id_XzCollege; //学院流水号
objvTeacherInfoENT.CollegeID = objvTeacherInfoENS.CollegeID; //学院ID
objvTeacherInfoENT.CollegeName = objvTeacherInfoENS.CollegeName; //学院名称
objvTeacherInfoENT.CollegeNameA = objvTeacherInfoENS.CollegeNameA; //学院名称简写
objvTeacherInfoENT.id_XzMajor = objvTeacherInfoENS.id_XzMajor; //专业流水号
objvTeacherInfoENT.EntryDay = objvTeacherInfoENS.EntryDay; //EntryDay
objvTeacherInfoENT.id_Photo = objvTeacherInfoENS.id_Photo; //id_Photo
objvTeacherInfoENT.id_Religion = objvTeacherInfoENS.id_Religion; //id_Religion
objvTeacherInfoENT.ReligionName = objvTeacherInfoENS.ReligionName; //ReligionName
objvTeacherInfoENT.IsMessage = objvTeacherInfoENS.IsMessage; //IsMessage
objvTeacherInfoENT.Microblog = objvTeacherInfoENS.Microblog; //Microblog
objvTeacherInfoENT.ModifyUserID = objvTeacherInfoENS.ModifyUserID; //修改人
objvTeacherInfoENT.OffedBak = objvTeacherInfoENS.OffedBak; //OffedBak
objvTeacherInfoENT.PhoneNumber = objvTeacherInfoENS.PhoneNumber; //PhoneNumber
objvTeacherInfoENT.QQ = objvTeacherInfoENS.QQ; //QQ
objvTeacherInfoENT.Teach_id_College = objvTeacherInfoENS.Teach_id_College; //Teach_id_College
objvTeacherInfoENT.Teach_id_Major = objvTeacherInfoENS.Teach_id_Major; //Teach_id_Major
objvTeacherInfoENT.Tel = objvTeacherInfoENS.Tel; //Tel
objvTeacherInfoENT.ModifyDate = objvTeacherInfoENS.ModifyDate; //修改日期
objvTeacherInfoENT.RegisterPassword = objvTeacherInfoENS.RegisterPassword; //RegisterPassword
objvTeacherInfoENT.EntryYear = objvTeacherInfoENS.EntryYear; //EntryYear
objvTeacherInfoENT.DisciplineName_ps = objvTeacherInfoENS.DisciplineName_ps; //学科
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
public static DataTable ToDataTable(List<clsvTeacherInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeacherInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeacherInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeacherInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeacherInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeacherInfoEN.AttributeName)
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeWApi没有刷新缓存机制(clsRsStaffTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeWApi没有刷新缓存机制(clsRsDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceWApi没有刷新缓存机制(clsRsProvinceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionWApi没有刷新缓存机制(clsRsReligionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifWApi没有刷新缓存机制(clsRsQualifWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_Teacher");
//if (arrvTeacherInfoObjLst_Cache == null)
//{
//arrvTeacherInfoObjLst_Cache = await clsvTeacherInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName_S);
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
public static List<clsvTeacherInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName_S);
List<clsvTeacherInfoEN> arrvTeacherInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeacherInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeacherInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeacherInfo.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_Sex, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_School_Ps, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_Discipline_Ps, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_Ethnic, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_Politics, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_AdminGrade, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.AdminGradeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_ProfGrade, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.ProfenssionalGradeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_Qualif, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.QualifDesc, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_Degree, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.DegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_StaffType, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.StaffTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_Province, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.ProvinceName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.CitizenID, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.CardNo, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.GraduationMajor, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.TelNo, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.Email, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.WebSite, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.PersonBlog, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.EntryDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.Offed, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeacherInfo.Id_CardNo, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.IsAvconUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeacherInfo.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeacherInfo.IsLocalUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeacherInfo.FromUnit, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.EntryDay, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_Photo, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.id_Religion, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.ReligionName, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.IsMessage, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeacherInfo.Microblog, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.OffedBak, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeacherInfo.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.QQ, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.Teach_id_College, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.Teach_id_Major, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.Tel, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.RegisterPassword, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.EntryYear, Type.GetType("System.String"));
objDT.Columns.Add(convTeacherInfo.DisciplineName_ps, Type.GetType("System.String"));
foreach (clsvTeacherInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeacherInfo.id_Teacher] = objInFor[convTeacherInfo.id_Teacher];
objDR[convTeacherInfo.TeacherID] = objInFor[convTeacherInfo.TeacherID];
objDR[convTeacherInfo.TeacherName] = objInFor[convTeacherInfo.TeacherName];
objDR[convTeacherInfo.id_Sex] = objInFor[convTeacherInfo.id_Sex];
objDR[convTeacherInfo.SexDesc] = objInFor[convTeacherInfo.SexDesc];
objDR[convTeacherInfo.id_School_Ps] = objInFor[convTeacherInfo.id_School_Ps];
objDR[convTeacherInfo.SchoolId] = objInFor[convTeacherInfo.SchoolId];
objDR[convTeacherInfo.SchoolName] = objInFor[convTeacherInfo.SchoolName];
objDR[convTeacherInfo.id_Discipline_Ps] = objInFor[convTeacherInfo.id_Discipline_Ps];
objDR[convTeacherInfo.id_UniZone] = objInFor[convTeacherInfo.id_UniZone];
objDR[convTeacherInfo.UniZoneDesc] = objInFor[convTeacherInfo.UniZoneDesc];
objDR[convTeacherInfo.id_Ethnic] = objInFor[convTeacherInfo.id_Ethnic];
objDR[convTeacherInfo.EthnicName] = objInFor[convTeacherInfo.EthnicName];
objDR[convTeacherInfo.id_Politics] = objInFor[convTeacherInfo.id_Politics];
objDR[convTeacherInfo.PoliticsName] = objInFor[convTeacherInfo.PoliticsName];
objDR[convTeacherInfo.id_AdminGrade] = objInFor[convTeacherInfo.id_AdminGrade];
objDR[convTeacherInfo.AdminGradeDesc] = objInFor[convTeacherInfo.AdminGradeDesc];
objDR[convTeacherInfo.id_ProfGrade] = objInFor[convTeacherInfo.id_ProfGrade];
objDR[convTeacherInfo.ProfenssionalGradeName] = objInFor[convTeacherInfo.ProfenssionalGradeName];
objDR[convTeacherInfo.id_Qualif] = objInFor[convTeacherInfo.id_Qualif];
objDR[convTeacherInfo.QualifDesc] = objInFor[convTeacherInfo.QualifDesc];
objDR[convTeacherInfo.id_Degree] = objInFor[convTeacherInfo.id_Degree];
objDR[convTeacherInfo.DegreeName] = objInFor[convTeacherInfo.DegreeName];
objDR[convTeacherInfo.id_StaffType] = objInFor[convTeacherInfo.id_StaffType];
objDR[convTeacherInfo.StaffTypeName] = objInFor[convTeacherInfo.StaffTypeName];
objDR[convTeacherInfo.id_Province] = objInFor[convTeacherInfo.id_Province];
objDR[convTeacherInfo.ProvinceName] = objInFor[convTeacherInfo.ProvinceName];
objDR[convTeacherInfo.CitizenID] = objInFor[convTeacherInfo.CitizenID];
objDR[convTeacherInfo.CardNo] = objInFor[convTeacherInfo.CardNo];
objDR[convTeacherInfo.Birthday] = objInFor[convTeacherInfo.Birthday];
objDR[convTeacherInfo.GraduationMajor] = objInFor[convTeacherInfo.GraduationMajor];
objDR[convTeacherInfo.TelNo] = objInFor[convTeacherInfo.TelNo];
objDR[convTeacherInfo.Email] = objInFor[convTeacherInfo.Email];
objDR[convTeacherInfo.WebSite] = objInFor[convTeacherInfo.WebSite];
objDR[convTeacherInfo.PersonBlog] = objInFor[convTeacherInfo.PersonBlog];
objDR[convTeacherInfo.EntryDate] = objInFor[convTeacherInfo.EntryDate];
objDR[convTeacherInfo.Offed] = objInFor[convTeacherInfo.Offed];
objDR[convTeacherInfo.Id_CardNo] = objInFor[convTeacherInfo.Id_CardNo];
objDR[convTeacherInfo.IsAvconUser] = objInFor[convTeacherInfo.IsAvconUser];
objDR[convTeacherInfo.IsGpUser] = objInFor[convTeacherInfo.IsGpUser];
objDR[convTeacherInfo.IsLocalUser] = objInFor[convTeacherInfo.IsLocalUser];
objDR[convTeacherInfo.FromUnit] = objInFor[convTeacherInfo.FromUnit];
objDR[convTeacherInfo.Memo] = objInFor[convTeacherInfo.Memo];
objDR[convTeacherInfo.id_XzCollege] = objInFor[convTeacherInfo.id_XzCollege];
objDR[convTeacherInfo.CollegeID] = objInFor[convTeacherInfo.CollegeID];
objDR[convTeacherInfo.CollegeName] = objInFor[convTeacherInfo.CollegeName];
objDR[convTeacherInfo.CollegeNameA] = objInFor[convTeacherInfo.CollegeNameA];
objDR[convTeacherInfo.id_XzMajor] = objInFor[convTeacherInfo.id_XzMajor];
objDR[convTeacherInfo.EntryDay] = objInFor[convTeacherInfo.EntryDay];
objDR[convTeacherInfo.id_Photo] = objInFor[convTeacherInfo.id_Photo];
objDR[convTeacherInfo.id_Religion] = objInFor[convTeacherInfo.id_Religion];
objDR[convTeacherInfo.ReligionName] = objInFor[convTeacherInfo.ReligionName];
objDR[convTeacherInfo.IsMessage] = objInFor[convTeacherInfo.IsMessage];
objDR[convTeacherInfo.Microblog] = objInFor[convTeacherInfo.Microblog];
objDR[convTeacherInfo.ModifyUserID] = objInFor[convTeacherInfo.ModifyUserID];
objDR[convTeacherInfo.OffedBak] = objInFor[convTeacherInfo.OffedBak];
objDR[convTeacherInfo.PhoneNumber] = objInFor[convTeacherInfo.PhoneNumber];
objDR[convTeacherInfo.QQ] = objInFor[convTeacherInfo.QQ];
objDR[convTeacherInfo.Teach_id_College] = objInFor[convTeacherInfo.Teach_id_College];
objDR[convTeacherInfo.Teach_id_Major] = objInFor[convTeacherInfo.Teach_id_Major];
objDR[convTeacherInfo.Tel] = objInFor[convTeacherInfo.Tel];
objDR[convTeacherInfo.ModifyDate] = objInFor[convTeacherInfo.ModifyDate];
objDR[convTeacherInfo.RegisterPassword] = objInFor[convTeacherInfo.RegisterPassword];
objDR[convTeacherInfo.EntryYear] = objInFor[convTeacherInfo.EntryYear];
objDR[convTeacherInfo.DisciplineName_ps] = objInFor[convTeacherInfo.DisciplineName_ps];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}