
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzClgBL
 表名:vXzClg(01120139)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/05 22:39:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvXzClgBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdXzCollege">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzClgEN GetObj(this K_IdXzCollege_vXzClg myKey)
{
clsvXzClgEN objvXzClgEN = clsvXzClgBL.vXzClgDA.GetObjByIdXzCollege(myKey.Value);
return objvXzClgEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetIdXzCollege(this clsvXzClgEN objvXzClgEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convXzClg.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convXzClg.IdXzCollege);
}
objvXzClgEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.IdXzCollege) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.IdXzCollege, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.IdXzCollege] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetCollegeId(this clsvXzClgEN objvXzClgEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convXzClg.CollegeId);
}
objvXzClgEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.CollegeId) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.CollegeId, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.CollegeId] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetCollegeName(this clsvXzClgEN objvXzClgEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convXzClg.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetCollegeIdInGP(this clsvXzClgEN objvXzClgEN, string strCollegeIdInGP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeIdInGP, 6, convXzClg.CollegeIdInGP);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetClgEnglishName(this clsvXzClgEN objvXzClgEN, string strClgEnglishName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClgEnglishName, 60, convXzClg.ClgEnglishName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetCollegeNameA(this clsvXzClgEN objvXzClgEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convXzClg.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetPhoneNumber(this clsvXzClgEN objvXzClgEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convXzClg.PhoneNumber);
}
objvXzClgEN.PhoneNumber = strPhoneNumber; //电话
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetWebSite(this clsvXzClgEN objvXzClgEN, string strWebSite, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSite, 60, convXzClg.WebSite);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetIdSchool(this clsvXzClgEN objvXzClgEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convXzClg.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convXzClg.IdSchool);
}
objvXzClgEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.IdSchool) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.IdSchool, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.IdSchool] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetSchoolId(this clsvXzClgEN objvXzClgEN, string strSchoolId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convXzClg.SchoolId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetSchoolName(this clsvXzClgEN objvXzClgEN, string strSchoolName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convXzClg.SchoolName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetSchoolNameA(this clsvXzClgEN objvXzClgEN, string strSchoolNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, convXzClg.SchoolNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetIdUni(this clsvXzClgEN objvXzClgEN, string strIdUni, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUni, 4, convXzClg.IdUni);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUni, 4, convXzClg.IdUni);
}
objvXzClgEN.IdUni = strIdUni; //id_Uni
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.IdUni) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.IdUni, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.IdUni] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetOrderNum(this clsvXzClgEN objvXzClgEN, int? intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetModifyDate(this clsvXzClgEN objvXzClgEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzClg.ModifyDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetModifyUserId(this clsvXzClgEN objvXzClgEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convXzClg.ModifyUserId);
}
objvXzClgEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzClgEN.dicFldComparisonOp.ContainsKey(convXzClg.ModifyUserId) == false)
{
objvXzClgEN.dicFldComparisonOp.Add(convXzClg.ModifyUserId, strComparisonOp);
}
else
{
objvXzClgEN.dicFldComparisonOp[convXzClg.ModifyUserId] = strComparisonOp;
}
}
return objvXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetMemo(this clsvXzClgEN objvXzClgEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzClg.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzClgEN SetMajorNum(this clsvXzClgEN objvXzClgEN, int? intMajorNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzClgENS">源对象</param>
 /// <param name = "objvXzClgENT">目标对象</param>
 public static void CopyTo(this clsvXzClgEN objvXzClgENS, clsvXzClgEN objvXzClgENT)
{
try
{
objvXzClgENT.IdXzCollege = objvXzClgENS.IdXzCollege; //学院流水号
objvXzClgENT.CollegeId = objvXzClgENS.CollegeId; //学院ID
objvXzClgENT.CollegeName = objvXzClgENS.CollegeName; //学院名称
objvXzClgENT.CollegeIdInGP = objvXzClgENS.CollegeIdInGP; //CollegeIdInGP
objvXzClgENT.ClgEnglishName = objvXzClgENS.ClgEnglishName; //ClgEnglishName
objvXzClgENT.CollegeNameA = objvXzClgENS.CollegeNameA; //学院名称简写
objvXzClgENT.PhoneNumber = objvXzClgENS.PhoneNumber; //电话
objvXzClgENT.WebSite = objvXzClgENS.WebSite; //个人主页
objvXzClgENT.IdSchool = objvXzClgENS.IdSchool; //学校流水号
objvXzClgENT.SchoolId = objvXzClgENS.SchoolId; //学校编号
objvXzClgENT.SchoolName = objvXzClgENS.SchoolName; //学校名称
objvXzClgENT.SchoolNameA = objvXzClgENS.SchoolNameA; //学校简称
objvXzClgENT.IdUni = objvXzClgENS.IdUni; //id_Uni
objvXzClgENT.IsVisible = objvXzClgENS.IsVisible; //是否显示
objvXzClgENT.OrderNum = objvXzClgENS.OrderNum; //序号
objvXzClgENT.ModifyDate = objvXzClgENS.ModifyDate; //修改日期
objvXzClgENT.ModifyUserId = objvXzClgENS.ModifyUserId; //修改人
objvXzClgENT.Memo = objvXzClgENS.Memo; //备注
objvXzClgENT.MajorNum = objvXzClgENS.MajorNum; //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvXzClgENS">源对象</param>
 /// <returns>目标对象=>clsvXzClgEN:objvXzClgENT</returns>
 public static clsvXzClgEN CopyTo(this clsvXzClgEN objvXzClgENS)
{
try
{
 clsvXzClgEN objvXzClgENT = new clsvXzClgEN()
{
IdXzCollege = objvXzClgENS.IdXzCollege, //学院流水号
CollegeId = objvXzClgENS.CollegeId, //学院ID
CollegeName = objvXzClgENS.CollegeName, //学院名称
CollegeIdInGP = objvXzClgENS.CollegeIdInGP, //CollegeIdInGP
ClgEnglishName = objvXzClgENS.ClgEnglishName, //ClgEnglishName
CollegeNameA = objvXzClgENS.CollegeNameA, //学院名称简写
PhoneNumber = objvXzClgENS.PhoneNumber, //电话
WebSite = objvXzClgENS.WebSite, //个人主页
IdSchool = objvXzClgENS.IdSchool, //学校流水号
SchoolId = objvXzClgENS.SchoolId, //学校编号
SchoolName = objvXzClgENS.SchoolName, //学校名称
SchoolNameA = objvXzClgENS.SchoolNameA, //学校简称
IdUni = objvXzClgENS.IdUni, //id_Uni
IsVisible = objvXzClgENS.IsVisible, //是否显示
OrderNum = objvXzClgENS.OrderNum, //序号
ModifyDate = objvXzClgENS.ModifyDate, //修改日期
ModifyUserId = objvXzClgENS.ModifyUserId, //修改人
Memo = objvXzClgENS.Memo, //备注
MajorNum = objvXzClgENS.MajorNum, //MajorNum
};
 return objvXzClgENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvXzClgEN objvXzClgEN)
{
 clsvXzClgBL.vXzClgDA.CheckProperty4Condition(objvXzClgEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzClgEN objvXzClgCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzClgCond.IsUpdated(convXzClg.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvXzClgCond.dicFldComparisonOp[convXzClg.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.IdXzCollege, objvXzClgCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvXzClgCond.IsUpdated(convXzClg.CollegeId) == true)
{
string strComparisonOpCollegeId = objvXzClgCond.dicFldComparisonOp[convXzClg.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.CollegeId, objvXzClgCond.CollegeId, strComparisonOpCollegeId);
}
if (objvXzClgCond.IsUpdated(convXzClg.CollegeName) == true)
{
string strComparisonOpCollegeName = objvXzClgCond.dicFldComparisonOp[convXzClg.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.CollegeName, objvXzClgCond.CollegeName, strComparisonOpCollegeName);
}
if (objvXzClgCond.IsUpdated(convXzClg.CollegeIdInGP) == true)
{
string strComparisonOpCollegeIdInGP = objvXzClgCond.dicFldComparisonOp[convXzClg.CollegeIdInGP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.CollegeIdInGP, objvXzClgCond.CollegeIdInGP, strComparisonOpCollegeIdInGP);
}
if (objvXzClgCond.IsUpdated(convXzClg.ClgEnglishName) == true)
{
string strComparisonOpClgEnglishName = objvXzClgCond.dicFldComparisonOp[convXzClg.ClgEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.ClgEnglishName, objvXzClgCond.ClgEnglishName, strComparisonOpClgEnglishName);
}
if (objvXzClgCond.IsUpdated(convXzClg.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvXzClgCond.dicFldComparisonOp[convXzClg.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.CollegeNameA, objvXzClgCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvXzClgCond.IsUpdated(convXzClg.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objvXzClgCond.dicFldComparisonOp[convXzClg.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.PhoneNumber, objvXzClgCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objvXzClgCond.IsUpdated(convXzClg.WebSite) == true)
{
string strComparisonOpWebSite = objvXzClgCond.dicFldComparisonOp[convXzClg.WebSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.WebSite, objvXzClgCond.WebSite, strComparisonOpWebSite);
}
if (objvXzClgCond.IsUpdated(convXzClg.IdSchool) == true)
{
string strComparisonOpIdSchool = objvXzClgCond.dicFldComparisonOp[convXzClg.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.IdSchool, objvXzClgCond.IdSchool, strComparisonOpIdSchool);
}
if (objvXzClgCond.IsUpdated(convXzClg.SchoolId) == true)
{
string strComparisonOpSchoolId = objvXzClgCond.dicFldComparisonOp[convXzClg.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.SchoolId, objvXzClgCond.SchoolId, strComparisonOpSchoolId);
}
if (objvXzClgCond.IsUpdated(convXzClg.SchoolName) == true)
{
string strComparisonOpSchoolName = objvXzClgCond.dicFldComparisonOp[convXzClg.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.SchoolName, objvXzClgCond.SchoolName, strComparisonOpSchoolName);
}
if (objvXzClgCond.IsUpdated(convXzClg.SchoolNameA) == true)
{
string strComparisonOpSchoolNameA = objvXzClgCond.dicFldComparisonOp[convXzClg.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.SchoolNameA, objvXzClgCond.SchoolNameA, strComparisonOpSchoolNameA);
}
if (objvXzClgCond.IsUpdated(convXzClg.IdUni) == true)
{
string strComparisonOpIdUni = objvXzClgCond.dicFldComparisonOp[convXzClg.IdUni];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.IdUni, objvXzClgCond.IdUni, strComparisonOpIdUni);
}
if (objvXzClgCond.IsUpdated(convXzClg.IsVisible) == true)
{
if (objvXzClgCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzClg.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzClg.IsVisible);
}
}
if (objvXzClgCond.IsUpdated(convXzClg.OrderNum) == true)
{
string strComparisonOpOrderNum = objvXzClgCond.dicFldComparisonOp[convXzClg.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convXzClg.OrderNum, objvXzClgCond.OrderNum, strComparisonOpOrderNum);
}
if (objvXzClgCond.IsUpdated(convXzClg.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvXzClgCond.dicFldComparisonOp[convXzClg.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.ModifyDate, objvXzClgCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvXzClgCond.IsUpdated(convXzClg.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvXzClgCond.dicFldComparisonOp[convXzClg.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.ModifyUserId, objvXzClgCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objvXzClgCond.IsUpdated(convXzClg.Memo) == true)
{
string strComparisonOpMemo = objvXzClgCond.dicFldComparisonOp[convXzClg.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzClg.Memo, objvXzClgCond.Memo, strComparisonOpMemo);
}
if (objvXzClgCond.IsUpdated(convXzClg.MajorNum) == true)
{
string strComparisonOpMajorNum = objvXzClgCond.dicFldComparisonOp[convXzClg.MajorNum];
strWhereCond += string.Format(" And {0} {2} {1}", convXzClg.MajorNum, objvXzClgCond.MajorNum, strComparisonOpMajorNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzClg
{
public virtual bool UpdRelaTabDate(string strIdXzCollege, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v学院(vXzClg)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzClgBL
{
public static RelatedActions_vXzClg relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzClgDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzClgDA vXzClgDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzClgDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzClgBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvXzClgEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzClgEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vXzClg(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzClgDA.GetDataTable_vXzClg(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzClgDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vXzClgDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vXzClgDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vXzClgDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vXzClgDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vXzClgDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vXzClgDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vXzClgDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrIdXzCollegeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvXzClgEN> GetObjLstByIdXzCollegeLst(List<string> arrIdXzCollegeLst)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdXzCollegeLst, true);
 string strWhereCond = string.Format("IdXzCollege in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdXzCollegeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzClgEN> GetObjLstByIdXzCollegeLstCache(List<string> arrIdXzCollegeLst)
{
string strKey = string.Format("{0}", clsvXzClgEN._CurrTabName);
List<clsvXzClgEN> arrvXzClgObjLstCache = GetObjLstCache();
IEnumerable <clsvXzClgEN> arrvXzClgObjLst_Sel =
arrvXzClgObjLstCache
.Where(x => arrIdXzCollegeLst.Contains(x.IdXzCollege));
return arrvXzClgObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetObjLst(string strWhereCond)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvXzClgCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzClgEN> GetSubObjLstCache(clsvXzClgEN objvXzClgCond)
{
List<clsvXzClgEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzClgEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzClg.AttributeName)
{
if (objvXzClgCond.IsUpdated(strFldName) == false) continue;
if (objvXzClgCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzClgCond[strFldName].ToString());
}
else
{
if (objvXzClgCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzClgCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzClgCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzClgCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzClgCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzClgCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvXzClgEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzClgEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzClgEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzClgEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzClgEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzClgEN> arrObjLst = new List<clsvXzClgEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzClgEN objvXzClgEN = new clsvXzClgEN();
try
{
objvXzClgEN.IdXzCollege = objRow[convXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objvXzClgEN.CollegeId = objRow[convXzClg.CollegeId] == DBNull.Value ? null : objRow[convXzClg.CollegeId].ToString().Trim(); //学院ID
objvXzClgEN.CollegeName = objRow[convXzClg.CollegeName] == DBNull.Value ? null : objRow[convXzClg.CollegeName].ToString().Trim(); //学院名称
objvXzClgEN.CollegeIdInGP = objRow[convXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[convXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvXzClgEN.ClgEnglishName = objRow[convXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[convXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objvXzClgEN.CollegeNameA = objRow[convXzClg.CollegeNameA] == DBNull.Value ? null : objRow[convXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzClgEN.PhoneNumber = objRow[convXzClg.PhoneNumber] == DBNull.Value ? null : objRow[convXzClg.PhoneNumber].ToString().Trim(); //电话
objvXzClgEN.WebSite = objRow[convXzClg.WebSite] == DBNull.Value ? null : objRow[convXzClg.WebSite].ToString().Trim(); //个人主页
objvXzClgEN.IdSchool = objRow[convXzClg.IdSchool] == DBNull.Value ? null : objRow[convXzClg.IdSchool].ToString().Trim(); //学校流水号
objvXzClgEN.SchoolId = objRow[convXzClg.SchoolId] == DBNull.Value ? null : objRow[convXzClg.SchoolId].ToString().Trim(); //学校编号
objvXzClgEN.SchoolName = objRow[convXzClg.SchoolName] == DBNull.Value ? null : objRow[convXzClg.SchoolName].ToString().Trim(); //学校名称
objvXzClgEN.SchoolNameA = objRow[convXzClg.SchoolNameA] == DBNull.Value ? null : objRow[convXzClg.SchoolNameA].ToString().Trim(); //学校简称
objvXzClgEN.IdUni = objRow[convXzClg.IdUni] == DBNull.Value ? null : objRow[convXzClg.IdUni].ToString().Trim(); //id_Uni
objvXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzClg.IsVisible].ToString().Trim()); //是否显示
objvXzClgEN.OrderNum = objRow[convXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.OrderNum].ToString().Trim()); //序号
objvXzClgEN.ModifyDate = objRow[convXzClg.ModifyDate] == DBNull.Value ? null : objRow[convXzClg.ModifyDate].ToString().Trim(); //修改日期
objvXzClgEN.ModifyUserId = objRow[convXzClg.ModifyUserId] == DBNull.Value ? null : objRow[convXzClg.ModifyUserId].ToString().Trim(); //修改人
objvXzClgEN.Memo = objRow[convXzClg.Memo] == DBNull.Value ? null : objRow[convXzClg.Memo].ToString().Trim(); //备注
objvXzClgEN.MajorNum = objRow[convXzClg.MajorNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzClg.MajorNum].ToString().Trim()); //MajorNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzClgEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzClgEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzClg(ref clsvXzClgEN objvXzClgEN)
{
bool bolResult = vXzClgDA.GetvXzClg(ref objvXzClgEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdXzCollege">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzClgEN GetObjByIdXzCollege(string strIdXzCollege)
{
if (strIdXzCollege.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdXzCollege]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdXzCollege) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdXzCollege]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvXzClgEN objvXzClgEN = vXzClgDA.GetObjByIdXzCollege(strIdXzCollege);
return objvXzClgEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzClgEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzClgEN objvXzClgEN = vXzClgDA.GetFirstObj(strWhereCond);
 return objvXzClgEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvXzClgEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzClgEN objvXzClgEN = vXzClgDA.GetObjByDataRow(objRow);
 return objvXzClgEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvXzClgEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzClgEN objvXzClgEN = vXzClgDA.GetObjByDataRow(objRow);
 return objvXzClgEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strIdXzCollege">所给的关键字</param>
 /// <param name = "lstvXzClgObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzClgEN GetObjByIdXzCollegeFromList(string strIdXzCollege, List<clsvXzClgEN> lstvXzClgObjLst)
{
foreach (clsvXzClgEN objvXzClgEN in lstvXzClgObjLst)
{
if (objvXzClgEN.IdXzCollege == strIdXzCollege)
{
return objvXzClgEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdXzCollege;
 try
 {
 strIdXzCollege = new clsvXzClgDA().GetFirstID(strWhereCond);
 return strIdXzCollege;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vXzClgDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vXzClgDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdXzCollege)
{
if (string.IsNullOrEmpty(strIdXzCollege) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdXzCollege]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vXzClgDA.IsExist(strIdXzCollege);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvXzClgDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vXzClgDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvXzClgENS">源对象</param>
 /// <param name = "objvXzClgENT">目标对象</param>
 public static void CopyTo(clsvXzClgEN objvXzClgENS, clsvXzClgEN objvXzClgENT)
{
try
{
objvXzClgENT.IdXzCollege = objvXzClgENS.IdXzCollege; //学院流水号
objvXzClgENT.CollegeId = objvXzClgENS.CollegeId; //学院ID
objvXzClgENT.CollegeName = objvXzClgENS.CollegeName; //学院名称
objvXzClgENT.CollegeIdInGP = objvXzClgENS.CollegeIdInGP; //CollegeIdInGP
objvXzClgENT.ClgEnglishName = objvXzClgENS.ClgEnglishName; //ClgEnglishName
objvXzClgENT.CollegeNameA = objvXzClgENS.CollegeNameA; //学院名称简写
objvXzClgENT.PhoneNumber = objvXzClgENS.PhoneNumber; //电话
objvXzClgENT.WebSite = objvXzClgENS.WebSite; //个人主页
objvXzClgENT.IdSchool = objvXzClgENS.IdSchool; //学校流水号
objvXzClgENT.SchoolId = objvXzClgENS.SchoolId; //学校编号
objvXzClgENT.SchoolName = objvXzClgENS.SchoolName; //学校名称
objvXzClgENT.SchoolNameA = objvXzClgENS.SchoolNameA; //学校简称
objvXzClgENT.IdUni = objvXzClgENS.IdUni; //id_Uni
objvXzClgENT.IsVisible = objvXzClgENS.IsVisible; //是否显示
objvXzClgENT.OrderNum = objvXzClgENS.OrderNum; //序号
objvXzClgENT.ModifyDate = objvXzClgENS.ModifyDate; //修改日期
objvXzClgENT.ModifyUserId = objvXzClgENS.ModifyUserId; //修改人
objvXzClgENT.Memo = objvXzClgENS.Memo; //备注
objvXzClgENT.MajorNum = objvXzClgENS.MajorNum; //MajorNum
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvXzClgEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzClgEN objvXzClgEN)
{
try
{
objvXzClgEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvXzClgEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzClg.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.IdXzCollege = objvXzClgEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convXzClg.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.CollegeId = objvXzClgEN.CollegeId == "[null]" ? null :  objvXzClgEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convXzClg.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.CollegeName = objvXzClgEN.CollegeName == "[null]" ? null :  objvXzClgEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convXzClg.CollegeIdInGP, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.CollegeIdInGP = objvXzClgEN.CollegeIdInGP == "[null]" ? null :  objvXzClgEN.CollegeIdInGP; //CollegeIdInGP
}
if (arrFldSet.Contains(convXzClg.ClgEnglishName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.ClgEnglishName = objvXzClgEN.ClgEnglishName == "[null]" ? null :  objvXzClgEN.ClgEnglishName; //ClgEnglishName
}
if (arrFldSet.Contains(convXzClg.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.CollegeNameA = objvXzClgEN.CollegeNameA == "[null]" ? null :  objvXzClgEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convXzClg.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.PhoneNumber = objvXzClgEN.PhoneNumber == "[null]" ? null :  objvXzClgEN.PhoneNumber; //电话
}
if (arrFldSet.Contains(convXzClg.WebSite, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.WebSite = objvXzClgEN.WebSite == "[null]" ? null :  objvXzClgEN.WebSite; //个人主页
}
if (arrFldSet.Contains(convXzClg.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.IdSchool = objvXzClgEN.IdSchool == "[null]" ? null :  objvXzClgEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convXzClg.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.SchoolId = objvXzClgEN.SchoolId == "[null]" ? null :  objvXzClgEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convXzClg.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.SchoolName = objvXzClgEN.SchoolName == "[null]" ? null :  objvXzClgEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convXzClg.SchoolNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.SchoolNameA = objvXzClgEN.SchoolNameA == "[null]" ? null :  objvXzClgEN.SchoolNameA; //学校简称
}
if (arrFldSet.Contains(convXzClg.IdUni, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.IdUni = objvXzClgEN.IdUni == "[null]" ? null :  objvXzClgEN.IdUni; //id_Uni
}
if (arrFldSet.Contains(convXzClg.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.IsVisible = objvXzClgEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convXzClg.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.OrderNum = objvXzClgEN.OrderNum; //序号
}
if (arrFldSet.Contains(convXzClg.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.ModifyDate = objvXzClgEN.ModifyDate == "[null]" ? null :  objvXzClgEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convXzClg.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.ModifyUserId = objvXzClgEN.ModifyUserId == "[null]" ? null :  objvXzClgEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(convXzClg.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.Memo = objvXzClgEN.Memo == "[null]" ? null :  objvXzClgEN.Memo; //备注
}
if (arrFldSet.Contains(convXzClg.MajorNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzClgEN.MajorNum = objvXzClgEN.MajorNum; //MajorNum
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvXzClgEN">源简化对象</param>
 public static void AccessFldValueNull(clsvXzClgEN objvXzClgEN)
{
try
{
if (objvXzClgEN.CollegeId == "[null]") objvXzClgEN.CollegeId = null; //学院ID
if (objvXzClgEN.CollegeName == "[null]") objvXzClgEN.CollegeName = null; //学院名称
if (objvXzClgEN.CollegeIdInGP == "[null]") objvXzClgEN.CollegeIdInGP = null; //CollegeIdInGP
if (objvXzClgEN.ClgEnglishName == "[null]") objvXzClgEN.ClgEnglishName = null; //ClgEnglishName
if (objvXzClgEN.CollegeNameA == "[null]") objvXzClgEN.CollegeNameA = null; //学院名称简写
if (objvXzClgEN.PhoneNumber == "[null]") objvXzClgEN.PhoneNumber = null; //电话
if (objvXzClgEN.WebSite == "[null]") objvXzClgEN.WebSite = null; //个人主页
if (objvXzClgEN.IdSchool == "[null]") objvXzClgEN.IdSchool = null; //学校流水号
if (objvXzClgEN.SchoolId == "[null]") objvXzClgEN.SchoolId = null; //学校编号
if (objvXzClgEN.SchoolName == "[null]") objvXzClgEN.SchoolName = null; //学校名称
if (objvXzClgEN.SchoolNameA == "[null]") objvXzClgEN.SchoolNameA = null; //学校简称
if (objvXzClgEN.IdUni == "[null]") objvXzClgEN.IdUni = null; //id_Uni
if (objvXzClgEN.ModifyDate == "[null]") objvXzClgEN.ModifyDate = null; //修改日期
if (objvXzClgEN.ModifyUserId == "[null]") objvXzClgEN.ModifyUserId = null; //修改人
if (objvXzClgEN.Memo == "[null]") objvXzClgEN.Memo = null; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvXzClgEN objvXzClgEN)
{
 vXzClgDA.CheckProperty4Condition(objvXzClgEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdXzCollege");
//if (arrvXzClgObjLstCache == null)
//{
//arrvXzClgObjLstCache = vXzClgDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdXzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzClgEN GetObjByIdXzCollegeCache(string strIdXzCollege)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzClgEN._CurrTabName);
List<clsvXzClgEN> arrvXzClgObjLstCache = GetObjLstCache();
IEnumerable <clsvXzClgEN> arrvXzClgObjLst_Sel =
arrvXzClgObjLstCache
.Where(x=> x.IdXzCollege == strIdXzCollege 
);
if (arrvXzClgObjLst_Sel.Count() == 0)
{
   clsvXzClgEN obj = clsvXzClgBL.GetObjByIdXzCollege(strIdXzCollege);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvXzClgObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzClgEN> GetAllvXzClgObjLstCache()
{
//获取缓存中的对象列表
List<clsvXzClgEN> arrvXzClgObjLstCache = GetObjLstCache(); 
return arrvXzClgObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzClgEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzClgEN._CurrTabName);
List<clsvXzClgEN> arrvXzClgObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzClgObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvXzClgEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-02-05
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdXzCollege)
{
if (strInFldName != convXzClg.IdXzCollege)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzClg.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzClg.AttributeName));
throw new Exception(strMsg);
}
var objvXzClg = clsvXzClgBL.GetObjByIdXzCollegeCache(strIdXzCollege);
if (objvXzClg == null) return "";
return objvXzClg[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvXzClgDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvXzClgDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzClgDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvXzClgDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvXzClgCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvXzClgEN objvXzClgCond)
{
List<clsvXzClgEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzClgEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzClg.AttributeName)
{
if (objvXzClgCond.IsUpdated(strFldName) == false) continue;
if (objvXzClgCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzClgCond[strFldName].ToString());
}
else
{
if (objvXzClgCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzClgCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzClgCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzClgCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzClgCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzClgCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvXzClgDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vXzClgDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vXzClgDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}