
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeacherInfoWApi
 表名:TeacherInfo(01120093)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:24
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
public static class clsTeacherInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Teacher(this clsTeacherInfoEN objTeacherInfoEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Teacher, 8, conTeacherInfo.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, conTeacherInfo.id_Teacher);
objTeacherInfoEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Teacher) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Teacher, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Teacher] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetTeacherID(this clsTeacherInfoEN objTeacherInfoEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, conTeacherInfo.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, conTeacherInfo.TeacherID);
objTeacherInfoEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TeacherID) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TeacherID, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TeacherID] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetTeacherName(this clsTeacherInfoEN objTeacherInfoEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, conTeacherInfo.TeacherName);
clsCheckSql.CheckFieldLen(strTeacherName, 50, conTeacherInfo.TeacherName);
objTeacherInfoEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TeacherName) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TeacherName, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TeacherName] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Sex(this clsTeacherInfoEN objTeacherInfoEN, string strid_Sex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Sex, conTeacherInfo.id_Sex);
clsCheckSql.CheckFieldLen(strid_Sex, 4, conTeacherInfo.id_Sex);
clsCheckSql.CheckFieldForeignKey(strid_Sex, 4, conTeacherInfo.id_Sex);
objTeacherInfoEN.id_Sex = strid_Sex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Sex) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Sex, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Sex] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_School_Ps(this clsTeacherInfoEN objTeacherInfoEN, string strid_School_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School_Ps, 4, conTeacherInfo.id_School_Ps);
clsCheckSql.CheckFieldForeignKey(strid_School_Ps, 4, conTeacherInfo.id_School_Ps);
objTeacherInfoEN.id_School_Ps = strid_School_Ps; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_School_Ps) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_School_Ps, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_School_Ps] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Discipline_Ps(this clsTeacherInfoEN objTeacherInfoEN, string strid_Discipline_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Discipline_Ps, 4, conTeacherInfo.id_Discipline_Ps);
clsCheckSql.CheckFieldForeignKey(strid_Discipline_Ps, 4, conTeacherInfo.id_Discipline_Ps);
objTeacherInfoEN.id_Discipline_Ps = strid_Discipline_Ps; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Discipline_Ps) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Discipline_Ps, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Discipline_Ps] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_UniZone(this clsTeacherInfoEN objTeacherInfoEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, conTeacherInfo.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, conTeacherInfo.id_UniZone);
objTeacherInfoEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_UniZone) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_UniZone, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_UniZone] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Ethnic(this clsTeacherInfoEN objTeacherInfoEN, string strid_Ethnic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Ethnic, 4, conTeacherInfo.id_Ethnic);
clsCheckSql.CheckFieldForeignKey(strid_Ethnic, 4, conTeacherInfo.id_Ethnic);
objTeacherInfoEN.id_Ethnic = strid_Ethnic; //民族流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Ethnic) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Ethnic, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Ethnic] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Politics(this clsTeacherInfoEN objTeacherInfoEN, string strid_Politics, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Politics, 4, conTeacherInfo.id_Politics);
clsCheckSql.CheckFieldForeignKey(strid_Politics, 4, conTeacherInfo.id_Politics);
objTeacherInfoEN.id_Politics = strid_Politics; //政治面貌流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Politics) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Politics, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Politics] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_AdminGrade(this clsTeacherInfoEN objTeacherInfoEN, string strid_AdminGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminGrade, 4, conTeacherInfo.id_AdminGrade);
clsCheckSql.CheckFieldForeignKey(strid_AdminGrade, 4, conTeacherInfo.id_AdminGrade);
objTeacherInfoEN.id_AdminGrade = strid_AdminGrade; //行政职务流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_AdminGrade) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_AdminGrade, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_AdminGrade] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_ProfGrade(this clsTeacherInfoEN objTeacherInfoEN, string strid_ProfGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ProfGrade, 4, conTeacherInfo.id_ProfGrade);
clsCheckSql.CheckFieldForeignKey(strid_ProfGrade, 4, conTeacherInfo.id_ProfGrade);
objTeacherInfoEN.id_ProfGrade = strid_ProfGrade; //专业职称流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_ProfGrade) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_ProfGrade, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_ProfGrade] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Qualif(this clsTeacherInfoEN objTeacherInfoEN, string strid_Qualif, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Qualif, 4, conTeacherInfo.id_Qualif);
clsCheckSql.CheckFieldForeignKey(strid_Qualif, 4, conTeacherInfo.id_Qualif);
objTeacherInfoEN.id_Qualif = strid_Qualif; //学历流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Qualif) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Qualif, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Qualif] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Degree(this clsTeacherInfoEN objTeacherInfoEN, string strid_Degree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Degree, 4, conTeacherInfo.id_Degree);
clsCheckSql.CheckFieldForeignKey(strid_Degree, 4, conTeacherInfo.id_Degree);
objTeacherInfoEN.id_Degree = strid_Degree; //学位流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Degree) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Degree, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Degree] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_StaffType(this clsTeacherInfoEN objTeacherInfoEN, string strid_StaffType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StaffType, 4, conTeacherInfo.id_StaffType);
clsCheckSql.CheckFieldForeignKey(strid_StaffType, 4, conTeacherInfo.id_StaffType);
objTeacherInfoEN.id_StaffType = strid_StaffType; //职工类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_StaffType) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_StaffType, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_StaffType] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Province(this clsTeacherInfoEN objTeacherInfoEN, string strid_Province, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Province, 4, conTeacherInfo.id_Province);
clsCheckSql.CheckFieldForeignKey(strid_Province, 4, conTeacherInfo.id_Province);
objTeacherInfoEN.id_Province = strid_Province; //省份流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Province) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Province, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Province] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetCitizenID(this clsTeacherInfoEN objTeacherInfoEN, string strCitizenID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCitizenID, 25, conTeacherInfo.CitizenID);
objTeacherInfoEN.CitizenID = strCitizenID; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.CitizenID) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.CitizenID, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.CitizenID] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetCardNo(this clsTeacherInfoEN objTeacherInfoEN, string strCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCardNo, 18, conTeacherInfo.CardNo);
objTeacherInfoEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.CardNo) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.CardNo, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.CardNo] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetBirthday(this clsTeacherInfoEN objTeacherInfoEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, conTeacherInfo.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, conTeacherInfo.Birthday);
objTeacherInfoEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Birthday) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Birthday, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Birthday] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetGraduationMajor(this clsTeacherInfoEN objTeacherInfoEN, string strGraduationMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGraduationMajor, 40, conTeacherInfo.GraduationMajor);
objTeacherInfoEN.GraduationMajor = strGraduationMajor; //毕业专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.GraduationMajor) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.GraduationMajor, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.GraduationMajor] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetTelNo(this clsTeacherInfoEN objTeacherInfoEN, string strTelNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTelNo, 50, conTeacherInfo.TelNo);
objTeacherInfoEN.TelNo = strTelNo; //电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TelNo) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TelNo, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TelNo] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetEmail(this clsTeacherInfoEN objTeacherInfoEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, conTeacherInfo.Email);
objTeacherInfoEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Email) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Email, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Email] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetWebSite(this clsTeacherInfoEN objTeacherInfoEN, string strWebSite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSite, 60, conTeacherInfo.WebSite);
objTeacherInfoEN.WebSite = strWebSite; //个人主页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.WebSite) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.WebSite, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.WebSite] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetPersonBlog(this clsTeacherInfoEN objTeacherInfoEN, string strPersonBlog, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPersonBlog, 60, conTeacherInfo.PersonBlog);
objTeacherInfoEN.PersonBlog = strPersonBlog; //个人博客
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.PersonBlog) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.PersonBlog, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.PersonBlog] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetEntryDate(this clsTeacherInfoEN objTeacherInfoEN, string strEntryDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryDate, 8, conTeacherInfo.EntryDate);
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, conTeacherInfo.EntryDate);
objTeacherInfoEN.EntryDate = strEntryDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.EntryDate) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.EntryDate, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.EntryDate] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetOffed(this clsTeacherInfoEN objTeacherInfoEN, bool bolOffed, string strComparisonOp="")
	{
objTeacherInfoEN.Offed = bolOffed; //是否离校
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Offed) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Offed, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Offed] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetId_CardNo(this clsTeacherInfoEN objTeacherInfoEN, string strId_CardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CardNo, 20, conTeacherInfo.Id_CardNo);
objTeacherInfoEN.Id_CardNo = strId_CardNo; //内卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Id_CardNo) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Id_CardNo, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Id_CardNo] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetIsAvconUser(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsAvconUser, string strComparisonOp="")
	{
objTeacherInfoEN.IsAvconUser = bolIsAvconUser; //IsAvconUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IsAvconUser) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IsAvconUser, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IsAvconUser] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetIsGpUser(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsGpUser, string strComparisonOp="")
	{
objTeacherInfoEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IsGpUser) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IsGpUser, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IsGpUser] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetIsLocalUser(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsLocalUser, string strComparisonOp="")
	{
objTeacherInfoEN.IsLocalUser = bolIsLocalUser; //是否本地用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IsLocalUser) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IsLocalUser, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IsLocalUser] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetFromUnit(this clsTeacherInfoEN objTeacherInfoEN, string strFromUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFromUnit, 100, conTeacherInfo.FromUnit);
objTeacherInfoEN.FromUnit = strFromUnit; //来自单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.FromUnit) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.FromUnit, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.FromUnit] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetMemo(this clsTeacherInfoEN objTeacherInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeacherInfo.Memo);
objTeacherInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Memo) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Memo, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Memo] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_XzCollege(this clsTeacherInfoEN objTeacherInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conTeacherInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conTeacherInfo.id_XzCollege);
objTeacherInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_XzCollege) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_XzCollege, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_XzCollege] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_XzMajor(this clsTeacherInfoEN objTeacherInfoEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conTeacherInfo.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conTeacherInfo.id_XzMajor);
objTeacherInfoEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_XzMajor) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_XzMajor, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_XzMajor] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetEntryDay(this clsTeacherInfoEN objTeacherInfoEN, string strEntryDay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEntryDay, 8, conTeacherInfo.EntryDay);
clsCheckSql.CheckFieldForeignKey(strEntryDay, 8, conTeacherInfo.EntryDay);
objTeacherInfoEN.EntryDay = strEntryDay; //EntryDay
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.EntryDay) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.EntryDay, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.EntryDay] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Photo(this clsTeacherInfoEN objTeacherInfoEN, string strid_Photo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Photo, 8, conTeacherInfo.id_Photo);
clsCheckSql.CheckFieldForeignKey(strid_Photo, 8, conTeacherInfo.id_Photo);
objTeacherInfoEN.id_Photo = strid_Photo; //id_Photo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Photo) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Photo, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Photo] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN Setid_Religion(this clsTeacherInfoEN objTeacherInfoEN, string strid_Religion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Religion, 4, conTeacherInfo.id_Religion);
clsCheckSql.CheckFieldForeignKey(strid_Religion, 4, conTeacherInfo.id_Religion);
objTeacherInfoEN.id_Religion = strid_Religion; //id_Religion
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.id_Religion) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.id_Religion, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.id_Religion] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetIsMessage(this clsTeacherInfoEN objTeacherInfoEN, bool bolIsMessage, string strComparisonOp="")
	{
objTeacherInfoEN.IsMessage = bolIsMessage; //IsMessage
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.IsMessage) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.IsMessage, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.IsMessage] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetMicroblog(this clsTeacherInfoEN objTeacherInfoEN, string strMicroblog, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroblog, 200, conTeacherInfo.Microblog);
objTeacherInfoEN.Microblog = strMicroblog; //Microblog
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Microblog) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Microblog, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Microblog] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetModifyUserID(this clsTeacherInfoEN objTeacherInfoEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conTeacherInfo.ModifyUserID);
objTeacherInfoEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.ModifyUserID) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.ModifyUserID, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.ModifyUserID] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetOffedBak(this clsTeacherInfoEN objTeacherInfoEN, bool bolOffedBak, string strComparisonOp="")
	{
objTeacherInfoEN.OffedBak = bolOffedBak; //OffedBak
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.OffedBak) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.OffedBak, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.OffedBak] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetPhoneNumber(this clsTeacherInfoEN objTeacherInfoEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conTeacherInfo.PhoneNumber);
objTeacherInfoEN.PhoneNumber = strPhoneNumber; //PhoneNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.PhoneNumber) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.PhoneNumber, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.PhoneNumber] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetQQ(this clsTeacherInfoEN objTeacherInfoEN, string strQQ, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQQ, 100, conTeacherInfo.QQ);
objTeacherInfoEN.QQ = strQQ; //QQ
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.QQ) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.QQ, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.QQ] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetTeach_id_College(this clsTeacherInfoEN objTeacherInfoEN, string strTeach_id_College, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeach_id_College, 6, conTeacherInfo.Teach_id_College);
objTeacherInfoEN.Teach_id_College = strTeach_id_College; //Teach_id_College
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Teach_id_College) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Teach_id_College, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Teach_id_College] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetTeach_id_Major(this clsTeacherInfoEN objTeacherInfoEN, string strTeach_id_Major, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeach_id_Major, 8, conTeacherInfo.Teach_id_Major);
clsCheckSql.CheckFieldForeignKey(strTeach_id_Major, 8, conTeacherInfo.Teach_id_Major);
objTeacherInfoEN.Teach_id_Major = strTeach_id_Major; //Teach_id_Major
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Teach_id_Major) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Teach_id_Major, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Teach_id_Major] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetTel(this clsTeacherInfoEN objTeacherInfoEN, string strTel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTel, 50, conTeacherInfo.Tel);
objTeacherInfoEN.Tel = strTel; //Tel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Tel) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Tel, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Tel] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetHeadphoto(this clsTeacherInfoEN objTeacherInfoEN, string strHeadphoto, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHeadphoto, 500, conTeacherInfo.Headphoto);
objTeacherInfoEN.Headphoto = strHeadphoto; //Headphoto
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.Headphoto) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.Headphoto, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.Headphoto] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetModifyDate(this clsTeacherInfoEN objTeacherInfoEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conTeacherInfo.ModifyDate);
objTeacherInfoEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.ModifyDate) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.ModifyDate, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.ModifyDate] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetRegisterPassword(this clsTeacherInfoEN objTeacherInfoEN, string strRegisterPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, conTeacherInfo.RegisterPassword);
objTeacherInfoEN.RegisterPassword = strRegisterPassword; //RegisterPassword
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.RegisterPassword) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.RegisterPassword, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.RegisterPassword] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeacherInfoEN SetTeacherPhoto(this clsTeacherInfoEN objTeacherInfoEN, string strTeacherPhoto, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherPhoto, 500, conTeacherInfo.TeacherPhoto);
objTeacherInfoEN.TeacherPhoto = strTeacherPhoto; //TeacherPhoto
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeacherInfoEN.dicFldComparisonOp.ContainsKey(conTeacherInfo.TeacherPhoto) == false)
{
objTeacherInfoEN.dicFldComparisonOp.Add(conTeacherInfo.TeacherPhoto, strComparisonOp);
}
else
{
objTeacherInfoEN.dicFldComparisonOp[conTeacherInfo.TeacherPhoto] = strComparisonOp;
}
}
return objTeacherInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeacherInfoEN objTeacherInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Teacher, objTeacherInfo_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.TeacherID) == true)
{
string strComparisonOp_TeacherID = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TeacherID, objTeacherInfo_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.TeacherName) == true)
{
string strComparisonOp_TeacherName = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TeacherName, objTeacherInfo_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Sex) == true)
{
string strComparisonOp_id_Sex = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Sex];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Sex, objTeacherInfo_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_School_Ps) == true)
{
string strComparisonOp_id_School_Ps = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_School_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_School_Ps, objTeacherInfo_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Discipline_Ps) == true)
{
string strComparisonOp_id_Discipline_Ps = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Discipline_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Discipline_Ps, objTeacherInfo_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_UniZone, objTeacherInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Ethnic) == true)
{
string strComparisonOp_id_Ethnic = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Ethnic];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Ethnic, objTeacherInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Politics) == true)
{
string strComparisonOp_id_Politics = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Politics];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Politics, objTeacherInfo_Cond.id_Politics, strComparisonOp_id_Politics);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_AdminGrade) == true)
{
string strComparisonOp_id_AdminGrade = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_AdminGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_AdminGrade, objTeacherInfo_Cond.id_AdminGrade, strComparisonOp_id_AdminGrade);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_ProfGrade) == true)
{
string strComparisonOp_id_ProfGrade = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_ProfGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_ProfGrade, objTeacherInfo_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Qualif) == true)
{
string strComparisonOp_id_Qualif = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Qualif];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Qualif, objTeacherInfo_Cond.id_Qualif, strComparisonOp_id_Qualif);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Degree) == true)
{
string strComparisonOp_id_Degree = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Degree];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Degree, objTeacherInfo_Cond.id_Degree, strComparisonOp_id_Degree);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_StaffType) == true)
{
string strComparisonOp_id_StaffType = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_StaffType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_StaffType, objTeacherInfo_Cond.id_StaffType, strComparisonOp_id_StaffType);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Province) == true)
{
string strComparisonOp_id_Province = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Province];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Province, objTeacherInfo_Cond.id_Province, strComparisonOp_id_Province);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.CitizenID) == true)
{
string strComparisonOp_CitizenID = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.CitizenID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.CitizenID, objTeacherInfo_Cond.CitizenID, strComparisonOp_CitizenID);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.CardNo) == true)
{
string strComparisonOp_CardNo = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.CardNo, objTeacherInfo_Cond.CardNo, strComparisonOp_CardNo);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Birthday) == true)
{
string strComparisonOp_Birthday = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Birthday, objTeacherInfo_Cond.Birthday, strComparisonOp_Birthday);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.GraduationMajor) == true)
{
string strComparisonOp_GraduationMajor = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.GraduationMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.GraduationMajor, objTeacherInfo_Cond.GraduationMajor, strComparisonOp_GraduationMajor);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.TelNo) == true)
{
string strComparisonOp_TelNo = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.TelNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TelNo, objTeacherInfo_Cond.TelNo, strComparisonOp_TelNo);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Email) == true)
{
string strComparisonOp_Email = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Email, objTeacherInfo_Cond.Email, strComparisonOp_Email);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.WebSite) == true)
{
string strComparisonOp_WebSite = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.WebSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.WebSite, objTeacherInfo_Cond.WebSite, strComparisonOp_WebSite);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.PersonBlog) == true)
{
string strComparisonOp_PersonBlog = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.PersonBlog];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.PersonBlog, objTeacherInfo_Cond.PersonBlog, strComparisonOp_PersonBlog);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.EntryDate) == true)
{
string strComparisonOp_EntryDate = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.EntryDate, objTeacherInfo_Cond.EntryDate, strComparisonOp_EntryDate);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Offed) == true)
{
if (objTeacherInfo_Cond.Offed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.Offed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.Offed);
}
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Id_CardNo) == true)
{
string strComparisonOp_Id_CardNo = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.Id_CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Id_CardNo, objTeacherInfo_Cond.Id_CardNo, strComparisonOp_Id_CardNo);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.IsAvconUser) == true)
{
if (objTeacherInfo_Cond.IsAvconUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.IsAvconUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.IsAvconUser);
}
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.IsGpUser) == true)
{
if (objTeacherInfo_Cond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.IsGpUser);
}
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.IsLocalUser) == true)
{
if (objTeacherInfo_Cond.IsLocalUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.IsLocalUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.IsLocalUser);
}
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.FromUnit) == true)
{
string strComparisonOp_FromUnit = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.FromUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.FromUnit, objTeacherInfo_Cond.FromUnit, strComparisonOp_FromUnit);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Memo) == true)
{
string strComparisonOp_Memo = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Memo, objTeacherInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_XzCollege, objTeacherInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_XzMajor, objTeacherInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.EntryDay) == true)
{
string strComparisonOp_EntryDay = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.EntryDay];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.EntryDay, objTeacherInfo_Cond.EntryDay, strComparisonOp_EntryDay);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Photo) == true)
{
string strComparisonOp_id_Photo = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Photo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Photo, objTeacherInfo_Cond.id_Photo, strComparisonOp_id_Photo);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.id_Religion) == true)
{
string strComparisonOp_id_Religion = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.id_Religion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.id_Religion, objTeacherInfo_Cond.id_Religion, strComparisonOp_id_Religion);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.IsMessage) == true)
{
if (objTeacherInfo_Cond.IsMessage == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.IsMessage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.IsMessage);
}
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Microblog) == true)
{
string strComparisonOp_Microblog = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.Microblog];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Microblog, objTeacherInfo_Cond.Microblog, strComparisonOp_Microblog);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.ModifyUserID, objTeacherInfo_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.OffedBak) == true)
{
if (objTeacherInfo_Cond.OffedBak == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeacherInfo.OffedBak);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeacherInfo.OffedBak);
}
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.PhoneNumber, objTeacherInfo_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.QQ) == true)
{
string strComparisonOp_QQ = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.QQ];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.QQ, objTeacherInfo_Cond.QQ, strComparisonOp_QQ);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Teach_id_College) == true)
{
string strComparisonOp_Teach_id_College = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.Teach_id_College];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Teach_id_College, objTeacherInfo_Cond.Teach_id_College, strComparisonOp_Teach_id_College);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Teach_id_Major) == true)
{
string strComparisonOp_Teach_id_Major = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.Teach_id_Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Teach_id_Major, objTeacherInfo_Cond.Teach_id_Major, strComparisonOp_Teach_id_Major);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Tel) == true)
{
string strComparisonOp_Tel = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.Tel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Tel, objTeacherInfo_Cond.Tel, strComparisonOp_Tel);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.Headphoto) == true)
{
string strComparisonOp_Headphoto = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.Headphoto];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.Headphoto, objTeacherInfo_Cond.Headphoto, strComparisonOp_Headphoto);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.ModifyDate, objTeacherInfo_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.RegisterPassword) == true)
{
string strComparisonOp_RegisterPassword = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.RegisterPassword, objTeacherInfo_Cond.RegisterPassword, strComparisonOp_RegisterPassword);
}
if (objTeacherInfo_Cond.IsUpdated(conTeacherInfo.TeacherPhoto) == true)
{
string strComparisonOp_TeacherPhoto = objTeacherInfo_Cond.dicFldComparisonOp[conTeacherInfo.TeacherPhoto];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeacherInfo.TeacherPhoto, objTeacherInfo_Cond.TeacherPhoto, strComparisonOp_TeacherPhoto);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeacherInfoEN objTeacherInfoEN)
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.id_Teacher) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTeacherInfoEN.sf_UpdFldSetStr = objTeacherInfoEN.getsf_UpdFldSetStr();
clsTeacherInfoWApi.CheckPropertyNew(objTeacherInfoEN); 
bool bolResult = clsTeacherInfoWApi.UpdateRecord(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoWApi.ReFreshCache();
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeacherInfoEN objTeacherInfoEN)
{
 if (string.IsNullOrEmpty(objTeacherInfoEN.id_Teacher) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTeacherInfoWApi.IsExist(objTeacherInfoEN.id_Teacher) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objTeacherInfoEN.id_Teacher, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsTeacherInfoWApi.CheckPropertyNew(objTeacherInfoEN); 
bool bolResult = clsTeacherInfoWApi.AddNewRecord(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoWApi.ReFreshCache();
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTeacherInfoEN objTeacherInfoEN)
{
try
{
clsTeacherInfoWApi.CheckPropertyNew(objTeacherInfoEN); 
string strid_Teacher = clsTeacherInfoWApi.AddNewRecordWithMaxId(objTeacherInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoWApi.ReFreshCache();
return strid_Teacher;
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
 /// <param name = "objTeacherInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeacherInfoEN objTeacherInfoEN, string strWhereCond)
{
try
{
clsTeacherInfoWApi.CheckPropertyNew(objTeacherInfoEN); 
bool bolResult = clsTeacherInfoWApi.UpdateWithCondition(objTeacherInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoWApi.ReFreshCache();
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
 /// 教师(TeacherInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTeacherInfoWApi
{
private static readonly string mstrApiControllerName = "TeacherInfoApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsTeacherInfoWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[教师]...","0");
List<clsTeacherInfoEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", conTeacherInfo.id_Teacher); 
List<clsTeacherInfoEN> arrObjLst = clsTeacherInfoWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN()
{
id_Teacher = "0",
TeacherName = "选[教师]..."
};
arrObjLst.Insert(0, objTeacherInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conTeacherInfo.id_Teacher;
objComboBox.DisplayMember = conTeacherInfo.TeacherName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTeacherInfoEN objTeacherInfoEN)
{
if (!Object.Equals(null, objTeacherInfoEN.id_Teacher) && GetStrLen(objTeacherInfoEN.id_Teacher) > 8)
{
 throw new Exception("字段[教师流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeacherInfoEN.TeacherID) && GetStrLen(objTeacherInfoEN.TeacherID) > 12)
{
 throw new Exception("字段[教师工号]的长度不能超过12!");
}
if (!Object.Equals(null, objTeacherInfoEN.TeacherName) && GetStrLen(objTeacherInfoEN.TeacherName) > 50)
{
 throw new Exception("字段[教师姓名]的长度不能超过50!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_Sex) && GetStrLen(objTeacherInfoEN.id_Sex) > 4)
{
 throw new Exception("字段[性别流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_School_Ps) && GetStrLen(objTeacherInfoEN.id_School_Ps) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_Discipline_Ps) && GetStrLen(objTeacherInfoEN.id_Discipline_Ps) > 4)
{
 throw new Exception("字段[学科流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_UniZone) && GetStrLen(objTeacherInfoEN.id_UniZone) > 4)
{
 throw new Exception("字段[校区流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_Ethnic) && GetStrLen(objTeacherInfoEN.id_Ethnic) > 4)
{
 throw new Exception("字段[民族流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_Politics) && GetStrLen(objTeacherInfoEN.id_Politics) > 4)
{
 throw new Exception("字段[政治面貌流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_AdminGrade) && GetStrLen(objTeacherInfoEN.id_AdminGrade) > 4)
{
 throw new Exception("字段[行政职务流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_ProfGrade) && GetStrLen(objTeacherInfoEN.id_ProfGrade) > 4)
{
 throw new Exception("字段[专业职称流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_Qualif) && GetStrLen(objTeacherInfoEN.id_Qualif) > 4)
{
 throw new Exception("字段[学历流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_Degree) && GetStrLen(objTeacherInfoEN.id_Degree) > 4)
{
 throw new Exception("字段[学位流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_StaffType) && GetStrLen(objTeacherInfoEN.id_StaffType) > 4)
{
 throw new Exception("字段[职工类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_Province) && GetStrLen(objTeacherInfoEN.id_Province) > 4)
{
 throw new Exception("字段[省份流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.CitizenID) && GetStrLen(objTeacherInfoEN.CitizenID) > 25)
{
 throw new Exception("字段[身份证号]的长度不能超过25!");
}
if (!Object.Equals(null, objTeacherInfoEN.CardNo) && GetStrLen(objTeacherInfoEN.CardNo) > 18)
{
 throw new Exception("字段[卡号]的长度不能超过18!");
}
if (!Object.Equals(null, objTeacherInfoEN.Birthday) && GetStrLen(objTeacherInfoEN.Birthday) > 8)
{
 throw new Exception("字段[出生日期]的长度不能超过8!");
}
if (!Object.Equals(null, objTeacherInfoEN.GraduationMajor) && GetStrLen(objTeacherInfoEN.GraduationMajor) > 40)
{
 throw new Exception("字段[毕业专业]的长度不能超过40!");
}
if (!Object.Equals(null, objTeacherInfoEN.TelNo) && GetStrLen(objTeacherInfoEN.TelNo) > 50)
{
 throw new Exception("字段[电话]的长度不能超过50!");
}
if (!Object.Equals(null, objTeacherInfoEN.Email) && GetStrLen(objTeacherInfoEN.Email) > 100)
{
 throw new Exception("字段[电子邮箱]的长度不能超过100!");
}
if (!Object.Equals(null, objTeacherInfoEN.WebSite) && GetStrLen(objTeacherInfoEN.WebSite) > 60)
{
 throw new Exception("字段[个人主页]的长度不能超过60!");
}
if (!Object.Equals(null, objTeacherInfoEN.PersonBlog) && GetStrLen(objTeacherInfoEN.PersonBlog) > 60)
{
 throw new Exception("字段[个人博客]的长度不能超过60!");
}
if (!Object.Equals(null, objTeacherInfoEN.EntryDate) && GetStrLen(objTeacherInfoEN.EntryDate) > 8)
{
 throw new Exception("字段[进校日期]的长度不能超过8!");
}
if (!Object.Equals(null, objTeacherInfoEN.Id_CardNo) && GetStrLen(objTeacherInfoEN.Id_CardNo) > 20)
{
 throw new Exception("字段[内卡号]的长度不能超过20!");
}
if (!Object.Equals(null, objTeacherInfoEN.FromUnit) && GetStrLen(objTeacherInfoEN.FromUnit) > 100)
{
 throw new Exception("字段[来自单位]的长度不能超过100!");
}
if (!Object.Equals(null, objTeacherInfoEN.Memo) && GetStrLen(objTeacherInfoEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_XzCollege) && GetStrLen(objTeacherInfoEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_XzMajor) && GetStrLen(objTeacherInfoEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeacherInfoEN.EntryDay) && GetStrLen(objTeacherInfoEN.EntryDay) > 8)
{
 throw new Exception("字段[EntryDay]的长度不能超过8!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_Photo) && GetStrLen(objTeacherInfoEN.id_Photo) > 8)
{
 throw new Exception("字段[id_Photo]的长度不能超过8!");
}
if (!Object.Equals(null, objTeacherInfoEN.id_Religion) && GetStrLen(objTeacherInfoEN.id_Religion) > 4)
{
 throw new Exception("字段[id_Religion]的长度不能超过4!");
}
if (!Object.Equals(null, objTeacherInfoEN.Microblog) && GetStrLen(objTeacherInfoEN.Microblog) > 200)
{
 throw new Exception("字段[Microblog]的长度不能超过200!");
}
if (!Object.Equals(null, objTeacherInfoEN.ModifyUserID) && GetStrLen(objTeacherInfoEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objTeacherInfoEN.PhoneNumber) && GetStrLen(objTeacherInfoEN.PhoneNumber) > 15)
{
 throw new Exception("字段[PhoneNumber]的长度不能超过15!");
}
if (!Object.Equals(null, objTeacherInfoEN.QQ) && GetStrLen(objTeacherInfoEN.QQ) > 100)
{
 throw new Exception("字段[QQ]的长度不能超过100!");
}
if (!Object.Equals(null, objTeacherInfoEN.Teach_id_College) && GetStrLen(objTeacherInfoEN.Teach_id_College) > 6)
{
 throw new Exception("字段[Teach_id_College]的长度不能超过6!");
}
if (!Object.Equals(null, objTeacherInfoEN.Teach_id_Major) && GetStrLen(objTeacherInfoEN.Teach_id_Major) > 8)
{
 throw new Exception("字段[Teach_id_Major]的长度不能超过8!");
}
if (!Object.Equals(null, objTeacherInfoEN.Tel) && GetStrLen(objTeacherInfoEN.Tel) > 50)
{
 throw new Exception("字段[Tel]的长度不能超过50!");
}
if (!Object.Equals(null, objTeacherInfoEN.Headphoto) && GetStrLen(objTeacherInfoEN.Headphoto) > 500)
{
 throw new Exception("字段[Headphoto]的长度不能超过500!");
}
if (!Object.Equals(null, objTeacherInfoEN.ModifyDate) && GetStrLen(objTeacherInfoEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTeacherInfoEN.RegisterPassword) && GetStrLen(objTeacherInfoEN.RegisterPassword) > 30)
{
 throw new Exception("字段[RegisterPassword]的长度不能超过30!");
}
if (!Object.Equals(null, objTeacherInfoEN.TeacherPhoto) && GetStrLen(objTeacherInfoEN.TeacherPhoto) > 500)
{
 throw new Exception("字段[TeacherPhoto]的长度不能超过500!");
}
 objTeacherInfoEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_Teacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeacherInfoEN GetObjByid_Teacher(string strid_Teacher)
{
string strAction = "GetObjByid_Teacher";
string strErrMsg = string.Empty;
string strResult = "";
clsTeacherInfoEN objTeacherInfoEN = null;
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
objTeacherInfoEN = JsonConvert.DeserializeObject<clsTeacherInfoEN>((string)jobjReturn["ReturnObj"]);
return objTeacherInfoEN;
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
public static clsTeacherInfoEN GetObjByid_Teacher_WA_Cache(string strid_Teacher)
{
string strAction = "GetObjByid_Teacher_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsTeacherInfoEN objTeacherInfoEN = null;
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
objTeacherInfoEN = JsonConvert.DeserializeObject<clsTeacherInfoEN>((string)jobjReturn["ReturnObj"]);
return objTeacherInfoEN;
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
public static clsTeacherInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsTeacherInfoEN objTeacherInfoEN = null;
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
objTeacherInfoEN = JsonConvert.DeserializeObject<clsTeacherInfoEN>((string)jobjReturn["ReturnObj"]);
return objTeacherInfoEN;
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
public static clsTeacherInfoEN GetObjByid_Teacher_Cache(string strid_Teacher)
{
if (string.IsNullOrEmpty(strid_Teacher) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName_S);
List<clsTeacherInfoEN> arrTeacherInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeacherInfoEN> arrTeacherInfoObjLst_Sel =
from objTeacherInfoEN in arrTeacherInfoObjLst_Cache
where objTeacherInfoEN.id_Teacher == strid_Teacher
select objTeacherInfoEN;
if (arrTeacherInfoObjLst_Sel.Count() == 0)
{
   clsTeacherInfoEN obj = clsTeacherInfoWApi.GetObjByid_Teacher(strid_Teacher);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTeacherInfoObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName_S);
List<clsTeacherInfoEN> arrTeacherInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeacherInfoEN> arrTeacherInfoObjLst_Sel1 =
from objTeacherInfoEN in arrTeacherInfoObjLst_Cache
where objTeacherInfoEN.id_Teacher == strid_Teacher
select objTeacherInfoEN;
List <clsTeacherInfoEN> arrTeacherInfoObjLst_Sel = new List<clsTeacherInfoEN>();
foreach (clsTeacherInfoEN obj in arrTeacherInfoObjLst_Sel1)
{
arrTeacherInfoObjLst_Sel.Add(obj);
}
if (arrTeacherInfoObjLst_Sel.Count > 0)
{
return arrTeacherInfoObjLst_Sel[0].TeacherName;
}
string strErrMsgForGetObjById = string.Format("在TeacherInfo对象缓存列表中,找不到记录[id_Teacher = {0}](函数:{1})", strid_Teacher, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTeacherInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName_S);
List<clsTeacherInfoEN> arrTeacherInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeacherInfoEN> arrTeacherInfoObjLst_Sel1 =
from objTeacherInfoEN in arrTeacherInfoObjLst_Cache
where objTeacherInfoEN.id_Teacher == strid_Teacher
select objTeacherInfoEN;
List <clsTeacherInfoEN> arrTeacherInfoObjLst_Sel = new List<clsTeacherInfoEN>();
foreach (clsTeacherInfoEN obj in arrTeacherInfoObjLst_Sel1)
{
arrTeacherInfoObjLst_Sel.Add(obj);
}
if (arrTeacherInfoObjLst_Sel.Count > 0)
{
return arrTeacherInfoObjLst_Sel[0].TeacherName;
}
string strErrMsgForGetObjById = string.Format("在TeacherInfo对象缓存列表中,找不到记录的相关名称[id_Teacher = {0}](函数:{1})", strid_Teacher, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTeacherInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeacherInfoEN> GetObjLst(string strWhereCond)
{
 List<clsTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeacherInfoEN> GetObjLstById_TeacherLst(List<string> arrId_Teacher)
{
 List<clsTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsTeacherInfoEN> GetObjLstById_TeacherLst_Cache(List<string> arrId_Teacher)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName_S);
List<clsTeacherInfoEN> arrTeacherInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeacherInfoEN> arrTeacherInfoObjLst_Sel =
from objTeacherInfoEN in arrTeacherInfoObjLst_Cache
where arrId_Teacher.Contains(objTeacherInfoEN.id_Teacher)
select objTeacherInfoEN;
return arrTeacherInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeacherInfoEN> GetObjLstById_TeacherLst_WA_Cache(List<string> arrId_Teacher)
{
 List<clsTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeacherInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeacherInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeacherInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeacherInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsTeacherInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeacherInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_Teacher)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsTeacherInfoEN objTeacherInfoEN = clsTeacherInfoWApi.GetObjByid_Teacher(strid_Teacher);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_Teacher.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeacherInfoWApi.ReFreshCache();
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
public static int DelTeacherInfos(List<string> arrid_Teacher)
{
string strAction = "DelTeacherInfos";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_Teacher);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeacherInfoWApi.ReFreshCache();
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
public static int DelTeacherInfosByCond(string strWhereCond)
{
string strAction = "DelTeacherInfosByCond";
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
public static bool AddNewRecord(clsTeacherInfoEN objTeacherInfoEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeacherInfoEN>(objTeacherInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsTeacherInfoEN objTeacherInfoEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeacherInfoEN>(objTeacherInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeacherInfoWApi.ReFreshCache();
var strid_Teacher = (string)jobjReturn["ReturnStr"];
return strid_Teacher;
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
public static bool UpdateRecord(clsTeacherInfoEN objTeacherInfoEN)
{
if (string.IsNullOrEmpty(objTeacherInfoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeacherInfoEN.id_Teacher, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeacherInfoEN>(objTeacherInfoEN);
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
 /// <param name = "objTeacherInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTeacherInfoEN objTeacherInfoEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTeacherInfoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeacherInfoEN.id_Teacher, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeacherInfoEN.id_Teacher, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeacherInfoEN>(objTeacherInfoEN);
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
 /// <param name = "objTeacherInfoENS">源对象</param>
 /// <param name = "objTeacherInfoENT">目标对象</param>
 public static void CopyTo(clsTeacherInfoEN objTeacherInfoENS, clsTeacherInfoEN objTeacherInfoENT)
{
try
{
objTeacherInfoENT.id_Teacher = objTeacherInfoENS.id_Teacher; //教师流水号
objTeacherInfoENT.TeacherID = objTeacherInfoENS.TeacherID; //教师工号
objTeacherInfoENT.TeacherName = objTeacherInfoENS.TeacherName; //教师姓名
objTeacherInfoENT.id_Sex = objTeacherInfoENS.id_Sex; //性别流水号
objTeacherInfoENT.id_School_Ps = objTeacherInfoENS.id_School_Ps; //学校流水号
objTeacherInfoENT.id_Discipline_Ps = objTeacherInfoENS.id_Discipline_Ps; //学科流水号
objTeacherInfoENT.id_UniZone = objTeacherInfoENS.id_UniZone; //校区流水号
objTeacherInfoENT.id_Ethnic = objTeacherInfoENS.id_Ethnic; //民族流水号
objTeacherInfoENT.id_Politics = objTeacherInfoENS.id_Politics; //政治面貌流水号
objTeacherInfoENT.id_AdminGrade = objTeacherInfoENS.id_AdminGrade; //行政职务流水号
objTeacherInfoENT.id_ProfGrade = objTeacherInfoENS.id_ProfGrade; //专业职称流水号
objTeacherInfoENT.id_Qualif = objTeacherInfoENS.id_Qualif; //学历流水号
objTeacherInfoENT.id_Degree = objTeacherInfoENS.id_Degree; //学位流水号
objTeacherInfoENT.id_StaffType = objTeacherInfoENS.id_StaffType; //职工类型流水号
objTeacherInfoENT.id_Province = objTeacherInfoENS.id_Province; //省份流水号
objTeacherInfoENT.CitizenID = objTeacherInfoENS.CitizenID; //身份证号
objTeacherInfoENT.CardNo = objTeacherInfoENS.CardNo; //卡号
objTeacherInfoENT.Birthday = objTeacherInfoENS.Birthday; //出生日期
objTeacherInfoENT.GraduationMajor = objTeacherInfoENS.GraduationMajor; //毕业专业
objTeacherInfoENT.TelNo = objTeacherInfoENS.TelNo; //电话
objTeacherInfoENT.Email = objTeacherInfoENS.Email; //电子邮箱
objTeacherInfoENT.WebSite = objTeacherInfoENS.WebSite; //个人主页
objTeacherInfoENT.PersonBlog = objTeacherInfoENS.PersonBlog; //个人博客
objTeacherInfoENT.EntryDate = objTeacherInfoENS.EntryDate; //进校日期
objTeacherInfoENT.Offed = objTeacherInfoENS.Offed; //是否离校
objTeacherInfoENT.Id_CardNo = objTeacherInfoENS.Id_CardNo; //内卡号
objTeacherInfoENT.IsAvconUser = objTeacherInfoENS.IsAvconUser; //IsAvconUser
objTeacherInfoENT.IsGpUser = objTeacherInfoENS.IsGpUser; //是否Gp用户
objTeacherInfoENT.IsLocalUser = objTeacherInfoENS.IsLocalUser; //是否本地用户
objTeacherInfoENT.FromUnit = objTeacherInfoENS.FromUnit; //来自单位
objTeacherInfoENT.Memo = objTeacherInfoENS.Memo; //备注
objTeacherInfoENT.id_XzCollege = objTeacherInfoENS.id_XzCollege; //学院流水号
objTeacherInfoENT.id_XzMajor = objTeacherInfoENS.id_XzMajor; //专业流水号
objTeacherInfoENT.EntryDay = objTeacherInfoENS.EntryDay; //EntryDay
objTeacherInfoENT.id_Photo = objTeacherInfoENS.id_Photo; //id_Photo
objTeacherInfoENT.id_Religion = objTeacherInfoENS.id_Religion; //id_Religion
objTeacherInfoENT.IsMessage = objTeacherInfoENS.IsMessage; //IsMessage
objTeacherInfoENT.Microblog = objTeacherInfoENS.Microblog; //Microblog
objTeacherInfoENT.ModifyUserID = objTeacherInfoENS.ModifyUserID; //修改人
objTeacherInfoENT.OffedBak = objTeacherInfoENS.OffedBak; //OffedBak
objTeacherInfoENT.PhoneNumber = objTeacherInfoENS.PhoneNumber; //PhoneNumber
objTeacherInfoENT.QQ = objTeacherInfoENS.QQ; //QQ
objTeacherInfoENT.Teach_id_College = objTeacherInfoENS.Teach_id_College; //Teach_id_College
objTeacherInfoENT.Teach_id_Major = objTeacherInfoENS.Teach_id_Major; //Teach_id_Major
objTeacherInfoENT.Tel = objTeacherInfoENS.Tel; //Tel
objTeacherInfoENT.Headphoto = objTeacherInfoENS.Headphoto; //Headphoto
objTeacherInfoENT.ModifyDate = objTeacherInfoENS.ModifyDate; //修改日期
objTeacherInfoENT.RegisterPassword = objTeacherInfoENS.RegisterPassword; //RegisterPassword
objTeacherInfoENT.TeacherPhoto = objTeacherInfoENS.TeacherPhoto; //TeacherPhoto
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
public static DataTable ToDataTable(List<clsTeacherInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTeacherInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTeacherInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTeacherInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTeacherInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTeacherInfoEN.AttributeName)
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
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_Teacher");
//if (arrTeacherInfoObjLst_Cache == null)
//{
//arrTeacherInfoObjLst_Cache = await clsTeacherInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName_S);
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
if (clsTeacherInfoWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsTeacherInfoWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeacherInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsTeacherInfoEN._CurrTabName_S);
List<clsTeacherInfoEN> arrTeacherInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTeacherInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTeacherInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTeacherInfo.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_Sex, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_School_Ps, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_Discipline_Ps, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_Ethnic, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_Politics, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_AdminGrade, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_ProfGrade, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_Qualif, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_Degree, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_StaffType, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_Province, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.CitizenID, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.CardNo, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.GraduationMajor, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.TelNo, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.Email, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.WebSite, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.PersonBlog, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.EntryDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.Offed, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeacherInfo.Id_CardNo, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.IsAvconUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeacherInfo.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeacherInfo.IsLocalUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeacherInfo.FromUnit, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.EntryDay, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_Photo, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.id_Religion, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.IsMessage, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeacherInfo.Microblog, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.OffedBak, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTeacherInfo.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.QQ, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.Teach_id_College, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.Teach_id_Major, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.Tel, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.Headphoto, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.RegisterPassword, Type.GetType("System.String"));
objDT.Columns.Add(conTeacherInfo.TeacherPhoto, Type.GetType("System.String"));
foreach (clsTeacherInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTeacherInfo.id_Teacher] = objInFor[conTeacherInfo.id_Teacher];
objDR[conTeacherInfo.TeacherID] = objInFor[conTeacherInfo.TeacherID];
objDR[conTeacherInfo.TeacherName] = objInFor[conTeacherInfo.TeacherName];
objDR[conTeacherInfo.id_Sex] = objInFor[conTeacherInfo.id_Sex];
objDR[conTeacherInfo.id_School_Ps] = objInFor[conTeacherInfo.id_School_Ps];
objDR[conTeacherInfo.id_Discipline_Ps] = objInFor[conTeacherInfo.id_Discipline_Ps];
objDR[conTeacherInfo.id_UniZone] = objInFor[conTeacherInfo.id_UniZone];
objDR[conTeacherInfo.id_Ethnic] = objInFor[conTeacherInfo.id_Ethnic];
objDR[conTeacherInfo.id_Politics] = objInFor[conTeacherInfo.id_Politics];
objDR[conTeacherInfo.id_AdminGrade] = objInFor[conTeacherInfo.id_AdminGrade];
objDR[conTeacherInfo.id_ProfGrade] = objInFor[conTeacherInfo.id_ProfGrade];
objDR[conTeacherInfo.id_Qualif] = objInFor[conTeacherInfo.id_Qualif];
objDR[conTeacherInfo.id_Degree] = objInFor[conTeacherInfo.id_Degree];
objDR[conTeacherInfo.id_StaffType] = objInFor[conTeacherInfo.id_StaffType];
objDR[conTeacherInfo.id_Province] = objInFor[conTeacherInfo.id_Province];
objDR[conTeacherInfo.CitizenID] = objInFor[conTeacherInfo.CitizenID];
objDR[conTeacherInfo.CardNo] = objInFor[conTeacherInfo.CardNo];
objDR[conTeacherInfo.Birthday] = objInFor[conTeacherInfo.Birthday];
objDR[conTeacherInfo.GraduationMajor] = objInFor[conTeacherInfo.GraduationMajor];
objDR[conTeacherInfo.TelNo] = objInFor[conTeacherInfo.TelNo];
objDR[conTeacherInfo.Email] = objInFor[conTeacherInfo.Email];
objDR[conTeacherInfo.WebSite] = objInFor[conTeacherInfo.WebSite];
objDR[conTeacherInfo.PersonBlog] = objInFor[conTeacherInfo.PersonBlog];
objDR[conTeacherInfo.EntryDate] = objInFor[conTeacherInfo.EntryDate];
objDR[conTeacherInfo.Offed] = objInFor[conTeacherInfo.Offed];
objDR[conTeacherInfo.Id_CardNo] = objInFor[conTeacherInfo.Id_CardNo];
objDR[conTeacherInfo.IsAvconUser] = objInFor[conTeacherInfo.IsAvconUser];
objDR[conTeacherInfo.IsGpUser] = objInFor[conTeacherInfo.IsGpUser];
objDR[conTeacherInfo.IsLocalUser] = objInFor[conTeacherInfo.IsLocalUser];
objDR[conTeacherInfo.FromUnit] = objInFor[conTeacherInfo.FromUnit];
objDR[conTeacherInfo.Memo] = objInFor[conTeacherInfo.Memo];
objDR[conTeacherInfo.id_XzCollege] = objInFor[conTeacherInfo.id_XzCollege];
objDR[conTeacherInfo.id_XzMajor] = objInFor[conTeacherInfo.id_XzMajor];
objDR[conTeacherInfo.EntryDay] = objInFor[conTeacherInfo.EntryDay];
objDR[conTeacherInfo.id_Photo] = objInFor[conTeacherInfo.id_Photo];
objDR[conTeacherInfo.id_Religion] = objInFor[conTeacherInfo.id_Religion];
objDR[conTeacherInfo.IsMessage] = objInFor[conTeacherInfo.IsMessage];
objDR[conTeacherInfo.Microblog] = objInFor[conTeacherInfo.Microblog];
objDR[conTeacherInfo.ModifyUserID] = objInFor[conTeacherInfo.ModifyUserID];
objDR[conTeacherInfo.OffedBak] = objInFor[conTeacherInfo.OffedBak];
objDR[conTeacherInfo.PhoneNumber] = objInFor[conTeacherInfo.PhoneNumber];
objDR[conTeacherInfo.QQ] = objInFor[conTeacherInfo.QQ];
objDR[conTeacherInfo.Teach_id_College] = objInFor[conTeacherInfo.Teach_id_College];
objDR[conTeacherInfo.Teach_id_Major] = objInFor[conTeacherInfo.Teach_id_Major];
objDR[conTeacherInfo.Tel] = objInFor[conTeacherInfo.Tel];
objDR[conTeacherInfo.Headphoto] = objInFor[conTeacherInfo.Headphoto];
objDR[conTeacherInfo.ModifyDate] = objInFor[conTeacherInfo.ModifyDate];
objDR[conTeacherInfo.RegisterPassword] = objInFor[conTeacherInfo.RegisterPassword];
objDR[conTeacherInfo.TeacherPhoto] = objInFor[conTeacherInfo.TeacherPhoto];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教师(TeacherInfo)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4TeacherInfo : clsCommFun4BL
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
clsTeacherInfoWApi.ReFreshThisCache();
clsvTeacherInfoWApi.ReFreshThisCache();
}
}

}