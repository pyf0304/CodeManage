
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzClgWApi
 表名:vXzClg(01120139)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:25
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
public static class clsvXzClgWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN Setid_XzCollege(this clsvXzClgEN objvXzClgEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convXzClg.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convXzClg.id_XzCollege);
objvXzClgEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.id_XzCollege) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.id_XzCollege, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.id_XzCollege] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetCollegeID(this clsvXzClgEN objvXzClgEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convXzClg.CollegeID);
objvXzClgEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.CollegeID) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.CollegeID, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.CollegeID] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetCollegeName(this clsvXzClgEN objvXzClgEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convXzClg.CollegeName);
objvXzClgEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.CollegeName) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.CollegeName, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.CollegeName] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetCollegeIdInGP(this clsvXzClgEN objvXzClgEN, string strCollegeIdInGP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeIdInGP, 6, convXzClg.CollegeIdInGP);
objvXzClgEN.CollegeIdInGP = strCollegeIdInGP; //CollegeIdInGP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.CollegeIdInGP) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.CollegeIdInGP, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.CollegeIdInGP] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetClgEnglishName(this clsvXzClgEN objvXzClgEN, string strClgEnglishName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClgEnglishName, 60, convXzClg.ClgEnglishName);
objvXzClgEN.ClgEnglishName = strClgEnglishName; //ClgEnglishName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.ClgEnglishName) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.ClgEnglishName, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.ClgEnglishName] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetCollegeNameA(this clsvXzClgEN objvXzClgEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convXzClg.CollegeNameA);
objvXzClgEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.CollegeNameA) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.CollegeNameA, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.CollegeNameA] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetPhoneNumber(this clsvXzClgEN objvXzClgEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convXzClg.PhoneNumber);
objvXzClgEN.PhoneNumber = strPhoneNumber; //PhoneNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.PhoneNumber) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.PhoneNumber, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.PhoneNumber] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetWebSite(this clsvXzClgEN objvXzClgEN, string strWebSite, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSite, 60, convXzClg.WebSite);
objvXzClgEN.WebSite = strWebSite; //个人主页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.WebSite) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.WebSite, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.WebSite] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN Setid_School(this clsvXzClgEN objvXzClgEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convXzClg.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convXzClg.id_School);
objvXzClgEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.id_School) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.id_School, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.id_School] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetSchoolId(this clsvXzClgEN objvXzClgEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convXzClg.SchoolId);
objvXzClgEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.SchoolId) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.SchoolId, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.SchoolId] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetSchoolName(this clsvXzClgEN objvXzClgEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convXzClg.SchoolName);
objvXzClgEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.SchoolName) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.SchoolName, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.SchoolName] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetSchoolNameA(this clsvXzClgEN objvXzClgEN, string strSchoolNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, convXzClg.SchoolNameA);
objvXzClgEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.SchoolNameA) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.SchoolNameA, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.SchoolNameA] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN Setid_Uni(this clsvXzClgEN objvXzClgEN, string strid_Uni, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Uni, 4, convXzClg.id_Uni);
clsCheckSql.CheckFieldForeignKey(strid_Uni, 4, convXzClg.id_Uni);
objvXzClgEN.id_Uni = strid_Uni; //id_Uni
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.id_Uni) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.id_Uni, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.id_Uni] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetIsVisible(this clsvXzClgEN objvXzClgEN, bool bolIsVisible, string strComparisonOp="")
	{
objvXzClgEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.IsVisible) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.IsVisible, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.IsVisible] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetOrderNum(this clsvXzClgEN objvXzClgEN, int intOrderNum, string strComparisonOp="")
	{
objvXzClgEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.OrderNum) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.OrderNum, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.OrderNum] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetModifyDate(this clsvXzClgEN objvXzClgEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzClg.ModifyDate);
objvXzClgEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.ModifyDate) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.ModifyDate, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.ModifyDate] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetModifyUserID(this clsvXzClgEN objvXzClgEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convXzClg.ModifyUserID);
objvXzClgEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.ModifyUserID) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.ModifyUserID, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.ModifyUserID] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetMemo(this clsvXzClgEN objvXzClgEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzClg.Memo);
objvXzClgEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.Memo) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.Memo, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.Memo] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzClgEN SetMajorNum(this clsvXzClgEN objvXzClgEN, int intMajorNum, string strComparisonOp="")
	{
objvXzClgEN.MajorNum = intMajorNum; //MajorNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.MajorNum) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.MajorNum, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.MajorNum] = strComparisonOp;
}
}
return objvXzClgEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzClgEN objvXzClg_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzClg_Cond.IsUpdated(convXzClg.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvXzClg_Cond.dicFldComparisonOp[convXzClg.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.id_XzCollege, objvXzClg_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvXzClg_Cond.dicFldComparisonOp[convXzClg.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.CollegeID, objvXzClg_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvXzClg_Cond.dicFldComparisonOp[convXzClg.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.CollegeName, objvXzClg_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.CollegeIdInGP) == true)
{
string strComparisonOp_CollegeIdInGP = objvXzClg_Cond.dicFldComparisonOp[convXzClg.CollegeIdInGP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.CollegeIdInGP, objvXzClg_Cond.CollegeIdInGP, strComparisonOp_CollegeIdInGP);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.ClgEnglishName) == true)
{
string strComparisonOp_ClgEnglishName = objvXzClg_Cond.dicFldComparisonOp[convXzClg.ClgEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.ClgEnglishName, objvXzClg_Cond.ClgEnglishName, strComparisonOp_ClgEnglishName);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvXzClg_Cond.dicFldComparisonOp[convXzClg.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.CollegeNameA, objvXzClg_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objvXzClg_Cond.dicFldComparisonOp[convXzClg.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.PhoneNumber, objvXzClg_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.WebSite) == true)
{
string strComparisonOp_WebSite = objvXzClg_Cond.dicFldComparisonOp[convXzClg.WebSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.WebSite, objvXzClg_Cond.WebSite, strComparisonOp_WebSite);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.id_School) == true)
{
string strComparisonOp_id_School = objvXzClg_Cond.dicFldComparisonOp[convXzClg.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.id_School, objvXzClg_Cond.id_School, strComparisonOp_id_School);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvXzClg_Cond.dicFldComparisonOp[convXzClg.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.SchoolId, objvXzClg_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvXzClg_Cond.dicFldComparisonOp[convXzClg.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.SchoolName, objvXzClg_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.SchoolNameA) == true)
{
string strComparisonOp_SchoolNameA = objvXzClg_Cond.dicFldComparisonOp[convXzClg.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.SchoolNameA, objvXzClg_Cond.SchoolNameA, strComparisonOp_SchoolNameA);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.id_Uni) == true)
{
string strComparisonOp_id_Uni = objvXzClg_Cond.dicFldComparisonOp[convXzClg.id_Uni];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.id_Uni, objvXzClg_Cond.id_Uni, strComparisonOp_id_Uni);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.IsVisible) == true)
{
if (objvXzClg_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzClg.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzClg.IsVisible);
}
}
if (objvXzClg_Cond.IsUpdated(convXzClg.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvXzClg_Cond.dicFldComparisonOp[convXzClg.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convXzClg.OrderNum, objvXzClg_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvXzClg_Cond.dicFldComparisonOp[convXzClg.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.ModifyDate, objvXzClg_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvXzClg_Cond.dicFldComparisonOp[convXzClg.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.ModifyUserID, objvXzClg_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.Memo) == true)
{
string strComparisonOp_Memo = objvXzClg_Cond.dicFldComparisonOp[convXzClg.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.Memo, objvXzClg_Cond.Memo, strComparisonOp_Memo);
}
if (objvXzClg_Cond.IsUpdated(convXzClg.MajorNum) == true)
{
string strComparisonOp_MajorNum = objvXzClg_Cond.dicFldComparisonOp[convXzClg.MajorNum];
strWhereCond += string.Format(" And {0} {2} {1}", convXzClg.MajorNum, objvXzClg_Cond.MajorNum, strComparisonOp_MajorNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学院(vXzClg)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzClgWApi
{
private static readonly string mstrApiControllerName = "vXzClgApi";

 public clsvXzClgWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_XzCollege">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzClgEN GetObjByid_XzCollege(string strid_XzCollege)
{
string strAction = "GetObjByid_XzCollege";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzClgEN objvXzClgEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_XzCollege"] = strid_XzCollege
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzClgEN = JsonConvert.DeserializeObject<clsvXzClgEN>((string)jobjReturn["ReturnObj"]);
return objvXzClgEN;
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
 /// <param name = "strid_XzCollege">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzClgEN GetObjByid_XzCollege_WA_Cache(string strid_XzCollege)
{
string strAction = "GetObjByid_XzCollege_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzClgEN objvXzClgEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_XzCollege"] = strid_XzCollege
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzClgEN = JsonConvert.DeserializeObject<clsvXzClgEN>((string)jobjReturn["ReturnObj"]);
return objvXzClgEN;
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
public static clsvXzClgEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzClgEN objvXzClgEN = null;
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
objvXzClgEN = JsonConvert.DeserializeObject<clsvXzClgEN>((string)jobjReturn["ReturnObj"]);
return objvXzClgEN;
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
 /// <param name = "strid_XzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzClgEN GetObjByid_XzCollege_Cache(string strid_XzCollege)
{
if (string.IsNullOrEmpty(strid_XzCollege) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzClgEN._CurrTabName_S);
List<clsvXzClgEN> arrvXzClgObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzClgEN> arrvXzClgObjLst_Sel =
from objvXzClgEN in arrvXzClgObjLst_Cache
where objvXzClgEN.id_XzCollege == strid_XzCollege
select objvXzClgEN;
if (arrvXzClgObjLst_Sel.Count() == 0)
{
   clsvXzClgEN obj = clsvXzClgWApi.GetObjByid_XzCollege(strid_XzCollege);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzClgObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetObjLst(string strWhereCond)
{
 List<clsvXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzClgEN> GetObjLstById_XzCollegeLst(List<string> arrId_XzCollege)
{
 List<clsvXzClgEN> arrObjLst = null; 
string strAction = "GetObjLstById_XzCollegeLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_XzCollege);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_XzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvXzClgEN> GetObjLstById_XzCollegeLst_Cache(List<string> arrId_XzCollege)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzClgEN._CurrTabName_S);
List<clsvXzClgEN> arrvXzClgObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzClgEN> arrvXzClgObjLst_Sel =
from objvXzClgEN in arrvXzClgObjLst_Cache
where arrId_XzCollege.Contains(objvXzClgEN.id_XzCollege)
select objvXzClgEN;
return arrvXzClgObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetObjLstById_XzCollegeLst_WA_Cache(List<string> arrId_XzCollege)
{
 List<clsvXzClgEN> arrObjLst = null; 
string strAction = "GetObjLstById_XzCollegeLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_XzCollege);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzClgEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzClgEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzClgEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzClgEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzClgEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzClgEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_XzCollege)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_XzCollege"] = strid_XzCollege
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
 /// <param name = "objvXzClgENS">源对象</param>
 /// <param name = "objvXzClgENT">目标对象</param>
 public static void CopyTo(clsvXzClgEN objvXzClgENS, clsvXzClgEN objvXzClgENT)
{
try
{
objvXzClgENT.id_XzCollege = objvXzClgENS.id_XzCollege; //学院流水号
objvXzClgENT.CollegeID = objvXzClgENS.CollegeID; //学院ID
objvXzClgENT.CollegeName = objvXzClgENS.CollegeName; //学院名称
objvXzClgENT.CollegeIdInGP = objvXzClgENS.CollegeIdInGP; //CollegeIdInGP
objvXzClgENT.ClgEnglishName = objvXzClgENS.ClgEnglishName; //ClgEnglishName
objvXzClgENT.CollegeNameA = objvXzClgENS.CollegeNameA; //学院名称简写
objvXzClgENT.PhoneNumber = objvXzClgENS.PhoneNumber; //PhoneNumber
objvXzClgENT.WebSite = objvXzClgENS.WebSite; //个人主页
objvXzClgENT.id_School = objvXzClgENS.id_School; //学校流水号
objvXzClgENT.SchoolId = objvXzClgENS.SchoolId; //学校编号
objvXzClgENT.SchoolName = objvXzClgENS.SchoolName; //学校名称
objvXzClgENT.SchoolNameA = objvXzClgENS.SchoolNameA; //学校简称
objvXzClgENT.id_Uni = objvXzClgENS.id_Uni; //id_Uni
objvXzClgENT.IsVisible = objvXzClgENS.IsVisible; //是否显示
objvXzClgENT.OrderNum = objvXzClgENS.OrderNum; //序号
objvXzClgENT.ModifyDate = objvXzClgENS.ModifyDate; //修改日期
objvXzClgENT.ModifyUserID = objvXzClgENS.ModifyUserID; //修改人
objvXzClgENT.Memo = objvXzClgENS.Memo; //备注
objvXzClgENT.MajorNum = objvXzClgENS.MajorNum; //MajorNum
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
public static DataTable ToDataTable(List<clsvXzClgEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzClgEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzClgEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzClgEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzClgEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzClgEN.AttributeName)
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_XzCollege");
//if (arrvXzClgObjLst_Cache == null)
//{
//arrvXzClgObjLst_Cache = await clsvXzClgWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzClgEN._CurrTabName_S);
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
public static List<clsvXzClgEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzClgEN._CurrTabName_S);
List<clsvXzClgEN> arrvXzClgObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzClgObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzClgEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzClg.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.CollegeIdInGP, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.ClgEnglishName, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.WebSite, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.SchoolNameA, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.id_Uni, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzClg.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convXzClg.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convXzClg.MajorNum, Type.GetType("System.Int32"));
foreach (clsvXzClgEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzClg.id_XzCollege] = objInFor[convXzClg.id_XzCollege];
objDR[convXzClg.CollegeID] = objInFor[convXzClg.CollegeID];
objDR[convXzClg.CollegeName] = objInFor[convXzClg.CollegeName];
objDR[convXzClg.CollegeIdInGP] = objInFor[convXzClg.CollegeIdInGP];
objDR[convXzClg.ClgEnglishName] = objInFor[convXzClg.ClgEnglishName];
objDR[convXzClg.CollegeNameA] = objInFor[convXzClg.CollegeNameA];
objDR[convXzClg.PhoneNumber] = objInFor[convXzClg.PhoneNumber];
objDR[convXzClg.WebSite] = objInFor[convXzClg.WebSite];
objDR[convXzClg.id_School] = objInFor[convXzClg.id_School];
objDR[convXzClg.SchoolId] = objInFor[convXzClg.SchoolId];
objDR[convXzClg.SchoolName] = objInFor[convXzClg.SchoolName];
objDR[convXzClg.SchoolNameA] = objInFor[convXzClg.SchoolNameA];
objDR[convXzClg.id_Uni] = objInFor[convXzClg.id_Uni];
objDR[convXzClg.IsVisible] = objInFor[convXzClg.IsVisible];
objDR[convXzClg.OrderNum] = objInFor[convXzClg.OrderNum];
objDR[convXzClg.ModifyDate] = objInFor[convXzClg.ModifyDate];
objDR[convXzClg.ModifyUserID] = objInFor[convXzClg.ModifyUserID];
objDR[convXzClg.Memo] = objInFor[convXzClg.Memo];
objDR[convXzClg.MajorNum] = objInFor[convXzClg.MajorNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}