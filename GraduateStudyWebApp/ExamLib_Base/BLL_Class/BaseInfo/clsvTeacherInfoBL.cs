
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeacherInfoBL
 表名:vTeacherInfo(01120094)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:19:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
public static class  clsvTeacherInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeacherInfoEN GetObj(this K_IdTeacher_vTeacherInfo myKey)
{
clsvTeacherInfoEN objvTeacherInfoEN = clsvTeacherInfoBL.vTeacherInfoDA.GetObjByIdTeacher(myKey.Value);
return objvTeacherInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdTeacher(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdTeacher, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeacher, 8, convTeacherInfo.IdTeacher);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeacher, 8, convTeacherInfo.IdTeacher);
}
objvTeacherInfoEN.IdTeacher = strIdTeacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdTeacher) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdTeacher, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdTeacher] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetTeacherId(this clsvTeacherInfoEN objvTeacherInfoEN, string strTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherId, convTeacherInfo.TeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherId, 12, convTeacherInfo.TeacherId);
}
objvTeacherInfoEN.TeacherId = strTeacherId; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.TeacherId) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.TeacherId, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.TeacherId] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetTeacherName(this clsvTeacherInfoEN objvTeacherInfoEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convTeacherInfo.TeacherName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convTeacherInfo.TeacherName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdSex(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdSex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSex, convTeacherInfo.IdSex);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSex, 4, convTeacherInfo.IdSex);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSex, 4, convTeacherInfo.IdSex);
}
objvTeacherInfoEN.IdSex = strIdSex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdSex) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdSex, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdSex] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetSexDesc(this clsvTeacherInfoEN objvTeacherInfoEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convTeacherInfo.SexDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdSchoolPs(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdSchoolPs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchoolPs, 4, convTeacherInfo.IdSchoolPs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchoolPs, 4, convTeacherInfo.IdSchoolPs);
}
objvTeacherInfoEN.IdSchoolPs = strIdSchoolPs; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdSchoolPs) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdSchoolPs, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdSchoolPs] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdDisciplinePs(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdDisciplinePs, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDisciplinePs, 4, convTeacherInfo.IdDisciplinePs);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDisciplinePs, 4, convTeacherInfo.IdDisciplinePs);
}
objvTeacherInfoEN.IdDisciplinePs = strIdDisciplinePs; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdDisciplinePs) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdDisciplinePs, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdDisciplinePs] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdUniZone(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdUniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdUniZone, convTeacherInfo.IdUniZone);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, convTeacherInfo.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, convTeacherInfo.IdUniZone);
}
objvTeacherInfoEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdUniZone) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdUniZone, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdUniZone] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetUniZoneDesc(this clsvTeacherInfoEN objvTeacherInfoEN, string strUniZoneDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convTeacherInfo.UniZoneDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdEthnic(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdEthnic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdEthnic, convTeacherInfo.IdEthnic);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEthnic, 4, convTeacherInfo.IdEthnic);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEthnic, 4, convTeacherInfo.IdEthnic);
}
objvTeacherInfoEN.IdEthnic = strIdEthnic; //民族流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdEthnic) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdEthnic, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdEthnic] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetEthnicName(this clsvTeacherInfoEN objvTeacherInfoEN, string strEthnicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convTeacherInfo.EthnicName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdPolitics(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdPolitics, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPolitics, convTeacherInfo.IdPolitics);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPolitics, 4, convTeacherInfo.IdPolitics);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPolitics, 4, convTeacherInfo.IdPolitics);
}
objvTeacherInfoEN.IdPolitics = strIdPolitics; //政治面貌流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdPolitics) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdPolitics, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdPolitics] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetPoliticsName(this clsvTeacherInfoEN objvTeacherInfoEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPoliticsName, convTeacherInfo.PoliticsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convTeacherInfo.PoliticsName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdAdminGrade(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdAdminGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAdminGrade, convTeacherInfo.IdAdminGrade);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminGrade, 4, convTeacherInfo.IdAdminGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminGrade, 4, convTeacherInfo.IdAdminGrade);
}
objvTeacherInfoEN.IdAdminGrade = strIdAdminGrade; //行政职务流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdAdminGrade) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdAdminGrade, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdAdminGrade] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetAdminGradeDesc(this clsvTeacherInfoEN objvTeacherInfoEN, string strAdminGradeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAdminGradeDesc, convTeacherInfo.AdminGradeDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminGradeDesc, 30, convTeacherInfo.AdminGradeDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdProfGrade(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdProfGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdProfGrade, convTeacherInfo.IdProfGrade);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdProfGrade, 4, convTeacherInfo.IdProfGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdProfGrade, 4, convTeacherInfo.IdProfGrade);
}
objvTeacherInfoEN.IdProfGrade = strIdProfGrade; //专业职称流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdProfGrade) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdProfGrade, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdProfGrade] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetProfenssionalGradeName(this clsvTeacherInfoEN objvTeacherInfoEN, string strProfenssionalGradeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProfenssionalGradeName, convTeacherInfo.ProfenssionalGradeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProfenssionalGradeName, 30, convTeacherInfo.ProfenssionalGradeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdQualif(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdQualif, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdQualif, convTeacherInfo.IdQualif);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdQualif, 4, convTeacherInfo.IdQualif);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdQualif, 4, convTeacherInfo.IdQualif);
}
objvTeacherInfoEN.IdQualif = strIdQualif; //学历流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdQualif) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdQualif, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdQualif] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetQualifDesc(this clsvTeacherInfoEN objvTeacherInfoEN, string strQualifDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQualifDesc, 30, convTeacherInfo.QualifDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdDegree(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDegree, convTeacherInfo.IdDegree);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDegree, 4, convTeacherInfo.IdDegree);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDegree, 4, convTeacherInfo.IdDegree);
}
objvTeacherInfoEN.IdDegree = strIdDegree; //学位流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdDegree) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdDegree, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdDegree] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetDegreeName(this clsvTeacherInfoEN objvTeacherInfoEN, string strDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDegreeName, convTeacherInfo.DegreeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDegreeName, 30, convTeacherInfo.DegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdStaffType(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdStaffType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStaffType, convTeacherInfo.IdStaffType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStaffType, 4, convTeacherInfo.IdStaffType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStaffType, 4, convTeacherInfo.IdStaffType);
}
objvTeacherInfoEN.IdStaffType = strIdStaffType; //职工类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdStaffType) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdStaffType, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdStaffType] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetStaffTypeName(this clsvTeacherInfoEN objvTeacherInfoEN, string strStaffTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStaffTypeName, 30, convTeacherInfo.StaffTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdProvince(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdProvince, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdProvince, convTeacherInfo.IdProvince);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdProvince, 4, convTeacherInfo.IdProvince);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdProvince, 4, convTeacherInfo.IdProvince);
}
objvTeacherInfoEN.IdProvince = strIdProvince; //省份流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdProvince) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdProvince, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdProvince] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetProvinceName(this clsvTeacherInfoEN objvTeacherInfoEN, string strProvinceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProvinceName, 30, convTeacherInfo.ProvinceName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetCitizenId(this clsvTeacherInfoEN objvTeacherInfoEN, string strCitizenId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitizenId, 25, convTeacherInfo.CitizenId);
}
objvTeacherInfoEN.CitizenId = strCitizenId; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.CitizenId) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.CitizenId, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.CitizenId] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetCardNo(this clsvTeacherInfoEN objvTeacherInfoEN, string strCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCardNo, 18, convTeacherInfo.CardNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetBirthday(this clsvTeacherInfoEN objvTeacherInfoEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convTeacherInfo.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convTeacherInfo.Birthday);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetGraduationMajor(this clsvTeacherInfoEN objvTeacherInfoEN, string strGraduationMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGraduationMajor, 40, convTeacherInfo.GraduationMajor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetTelNo(this clsvTeacherInfoEN objvTeacherInfoEN, string strTelNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTelNo, 50, convTeacherInfo.TelNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetEmail(this clsvTeacherInfoEN objvTeacherInfoEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, convTeacherInfo.Email);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetWebSite(this clsvTeacherInfoEN objvTeacherInfoEN, string strWebSite, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSite, 60, convTeacherInfo.WebSite);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetPersonBlog(this clsvTeacherInfoEN objvTeacherInfoEN, string strPersonBlog, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPersonBlog, 60, convTeacherInfo.PersonBlog);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetEntryDate(this clsvTeacherInfoEN objvTeacherInfoEN, string strEntryDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEntryDate, 8, convTeacherInfo.EntryDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEntryDate, 8, convTeacherInfo.EntryDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetFromUnit(this clsvTeacherInfoEN objvTeacherInfoEN, string strFromUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFromUnit, 100, convTeacherInfo.FromUnit);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetMemo(this clsvTeacherInfoEN objvTeacherInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeacherInfo.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdXzCollege(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convTeacherInfo.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convTeacherInfo.IdXzCollege);
}
objvTeacherInfoEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdXzCollege) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdXzCollege, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdXzCollege] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetCollegeId(this clsvTeacherInfoEN objvTeacherInfoEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convTeacherInfo.CollegeId);
}
objvTeacherInfoEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.CollegeId) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.CollegeId, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.CollegeId] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetCollegeName(this clsvTeacherInfoEN objvTeacherInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convTeacherInfo.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeacherInfo.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetCollegeNameA(this clsvTeacherInfoEN objvTeacherInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeacherInfo.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdXzMajor(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convTeacherInfo.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convTeacherInfo.IdXzMajor);
}
objvTeacherInfoEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdXzMajor) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdXzMajor, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdXzMajor] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetEntryDay(this clsvTeacherInfoEN objvTeacherInfoEN, string strEntryDay, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEntryDay, 8, convTeacherInfo.EntryDay);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEntryDay, 8, convTeacherInfo.EntryDay);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdPhoto(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdPhoto, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPhoto, 8, convTeacherInfo.IdPhoto);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPhoto, 8, convTeacherInfo.IdPhoto);
}
objvTeacherInfoEN.IdPhoto = strIdPhoto; //id_Photo
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdPhoto) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdPhoto, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdPhoto] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetIdReligion(this clsvTeacherInfoEN objvTeacherInfoEN, string strIdReligion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdReligion, 4, convTeacherInfo.IdReligion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdReligion, 4, convTeacherInfo.IdReligion);
}
objvTeacherInfoEN.IdReligion = strIdReligion; //id_Religion
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.IdReligion) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.IdReligion, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.IdReligion] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetReligionName(this clsvTeacherInfoEN objvTeacherInfoEN, string strReligionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReligionName, 30, convTeacherInfo.ReligionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetMicroblog(this clsvTeacherInfoEN objvTeacherInfoEN, string strMicroblog, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroblog, 200, convTeacherInfo.Microblog);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetModifyUserId(this clsvTeacherInfoEN objvTeacherInfoEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convTeacherInfo.ModifyUserId);
}
objvTeacherInfoEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.ModifyUserId) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.ModifyUserId, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.ModifyUserId] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetPhoneNumber(this clsvTeacherInfoEN objvTeacherInfoEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convTeacherInfo.PhoneNumber);
}
objvTeacherInfoEN.PhoneNumber = strPhoneNumber; //电话
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetQQ(this clsvTeacherInfoEN objvTeacherInfoEN, string strQQ, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQQ, 100, convTeacherInfo.QQ);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetTeachIdCollege(this clsvTeacherInfoEN objvTeacherInfoEN, string strTeachIdCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachIdCollege, 6, convTeacherInfo.TeachIdCollege);
}
objvTeacherInfoEN.TeachIdCollege = strTeachIdCollege; //Teach_id_College
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.TeachIdCollege) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.TeachIdCollege, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.TeachIdCollege] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetTeachIdMajor(this clsvTeacherInfoEN objvTeacherInfoEN, string strTeachIdMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachIdMajor, 8, convTeacherInfo.TeachIdMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachIdMajor, 8, convTeacherInfo.TeachIdMajor);
}
objvTeacherInfoEN.TeachIdMajor = strTeachIdMajor; //Teach_id_Major
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeacherInfoEN.dicFldComparisonOp.ContainsKey(convTeacherInfo.TeachIdMajor) == false)
{
objvTeacherInfoEN.dicFldComparisonOp.Add(convTeacherInfo.TeachIdMajor, strComparisonOp);
}
else
{
objvTeacherInfoEN.dicFldComparisonOp[convTeacherInfo.TeachIdMajor] = strComparisonOp;
}
}
return objvTeacherInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetTel(this clsvTeacherInfoEN objvTeacherInfoEN, string strTel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTel, 50, convTeacherInfo.Tel);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetModifyDate(this clsvTeacherInfoEN objvTeacherInfoEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convTeacherInfo.ModifyDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetRegisterPassword(this clsvTeacherInfoEN objvTeacherInfoEN, string strRegisterPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, convTeacherInfo.RegisterPassword);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeacherInfoEN SetEntryYear(this clsvTeacherInfoEN objvTeacherInfoEN, string strEntryYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEntryYear, 8, convTeacherInfo.EntryYear);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeacherInfoENS">源对象</param>
 /// <param name = "objvTeacherInfoENT">目标对象</param>
 public static void CopyTo(this clsvTeacherInfoEN objvTeacherInfoENS, clsvTeacherInfoEN objvTeacherInfoENT)
{
try
{
objvTeacherInfoENT.IdTeacher = objvTeacherInfoENS.IdTeacher; //教师流水号
objvTeacherInfoENT.TeacherId = objvTeacherInfoENS.TeacherId; //教师工号
objvTeacherInfoENT.TeacherName = objvTeacherInfoENS.TeacherName; //教师姓名
objvTeacherInfoENT.IdSex = objvTeacherInfoENS.IdSex; //性别流水号
objvTeacherInfoENT.SexDesc = objvTeacherInfoENS.SexDesc; //性别名称
objvTeacherInfoENT.IdSchoolPs = objvTeacherInfoENS.IdSchoolPs; //学校流水号
objvTeacherInfoENT.IdDisciplinePs = objvTeacherInfoENS.IdDisciplinePs; //学科流水号
objvTeacherInfoENT.IdUniZone = objvTeacherInfoENS.IdUniZone; //校区流水号
objvTeacherInfoENT.UniZoneDesc = objvTeacherInfoENS.UniZoneDesc; //校区名称
objvTeacherInfoENT.IdEthnic = objvTeacherInfoENS.IdEthnic; //民族流水号
objvTeacherInfoENT.EthnicName = objvTeacherInfoENS.EthnicName; //民族名称
objvTeacherInfoENT.IdPolitics = objvTeacherInfoENS.IdPolitics; //政治面貌流水号
objvTeacherInfoENT.PoliticsName = objvTeacherInfoENS.PoliticsName; //政治面貌
objvTeacherInfoENT.IdAdminGrade = objvTeacherInfoENS.IdAdminGrade; //行政职务流水号
objvTeacherInfoENT.AdminGradeDesc = objvTeacherInfoENS.AdminGradeDesc; //行政职务描述
objvTeacherInfoENT.IdProfGrade = objvTeacherInfoENS.IdProfGrade; //专业职称流水号
objvTeacherInfoENT.ProfenssionalGradeName = objvTeacherInfoENS.ProfenssionalGradeName; //专业职称
objvTeacherInfoENT.IdQualif = objvTeacherInfoENS.IdQualif; //学历流水号
objvTeacherInfoENT.QualifDesc = objvTeacherInfoENS.QualifDesc; //QualifDesc
objvTeacherInfoENT.IdDegree = objvTeacherInfoENS.IdDegree; //学位流水号
objvTeacherInfoENT.DegreeName = objvTeacherInfoENS.DegreeName; //学位名称
objvTeacherInfoENT.IdStaffType = objvTeacherInfoENS.IdStaffType; //职工类型流水号
objvTeacherInfoENT.StaffTypeName = objvTeacherInfoENS.StaffTypeName; //职工类型名称
objvTeacherInfoENT.IdProvince = objvTeacherInfoENS.IdProvince; //省份流水号
objvTeacherInfoENT.ProvinceName = objvTeacherInfoENS.ProvinceName; //ProvinceName
objvTeacherInfoENT.CitizenId = objvTeacherInfoENS.CitizenId; //身份证号
objvTeacherInfoENT.CardNo = objvTeacherInfoENS.CardNo; //卡号
objvTeacherInfoENT.Birthday = objvTeacherInfoENS.Birthday; //出生日期
objvTeacherInfoENT.GraduationMajor = objvTeacherInfoENS.GraduationMajor; //毕业专业
objvTeacherInfoENT.TelNo = objvTeacherInfoENS.TelNo; //电话
objvTeacherInfoENT.Email = objvTeacherInfoENS.Email; //电子邮箱
objvTeacherInfoENT.WebSite = objvTeacherInfoENS.WebSite; //个人主页
objvTeacherInfoENT.PersonBlog = objvTeacherInfoENS.PersonBlog; //个人博客
objvTeacherInfoENT.EntryDate = objvTeacherInfoENS.EntryDate; //进校日期
objvTeacherInfoENT.Offed = objvTeacherInfoENS.Offed; //是否离校
objvTeacherInfoENT.IsAvconUser = objvTeacherInfoENS.IsAvconUser; //IsAvconUser
objvTeacherInfoENT.IsGpUser = objvTeacherInfoENS.IsGpUser; //是否Gp用户
objvTeacherInfoENT.IsLocalUser = objvTeacherInfoENS.IsLocalUser; //是否本地用户
objvTeacherInfoENT.FromUnit = objvTeacherInfoENS.FromUnit; //来自单位
objvTeacherInfoENT.Memo = objvTeacherInfoENS.Memo; //备注
objvTeacherInfoENT.IdXzCollege = objvTeacherInfoENS.IdXzCollege; //学院流水号
objvTeacherInfoENT.CollegeId = objvTeacherInfoENS.CollegeId; //学院ID
objvTeacherInfoENT.CollegeName = objvTeacherInfoENS.CollegeName; //学院名称
objvTeacherInfoENT.CollegeNameA = objvTeacherInfoENS.CollegeNameA; //学院名称简写
objvTeacherInfoENT.IdXzMajor = objvTeacherInfoENS.IdXzMajor; //专业流水号
objvTeacherInfoENT.EntryDay = objvTeacherInfoENS.EntryDay; //EntryDay
objvTeacherInfoENT.IdPhoto = objvTeacherInfoENS.IdPhoto; //id_Photo
objvTeacherInfoENT.IdReligion = objvTeacherInfoENS.IdReligion; //id_Religion
objvTeacherInfoENT.ReligionName = objvTeacherInfoENS.ReligionName; //ReligionName
objvTeacherInfoENT.IsMessage = objvTeacherInfoENS.IsMessage; //IsMessage
objvTeacherInfoENT.Microblog = objvTeacherInfoENS.Microblog; //Microblog
objvTeacherInfoENT.ModifyUserId = objvTeacherInfoENS.ModifyUserId; //修改人
objvTeacherInfoENT.OffedBak = objvTeacherInfoENS.OffedBak; //OffedBak
objvTeacherInfoENT.PhoneNumber = objvTeacherInfoENS.PhoneNumber; //电话
objvTeacherInfoENT.QQ = objvTeacherInfoENS.QQ; //QQ
objvTeacherInfoENT.TeachIdCollege = objvTeacherInfoENS.TeachIdCollege; //Teach_id_College
objvTeacherInfoENT.TeachIdMajor = objvTeacherInfoENS.TeachIdMajor; //Teach_id_Major
objvTeacherInfoENT.Tel = objvTeacherInfoENS.Tel; //Tel
objvTeacherInfoENT.ModifyDate = objvTeacherInfoENS.ModifyDate; //修改日期
objvTeacherInfoENT.RegisterPassword = objvTeacherInfoENS.RegisterPassword; //RegisterPassword
objvTeacherInfoENT.EntryYear = objvTeacherInfoENS.EntryYear; //EntryYear
objvTeacherInfoENT.IdCardNo = objvTeacherInfoENS.IdCardNo; //身份证号
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
 /// <param name = "objvTeacherInfoENS">源对象</param>
 /// <returns>目标对象=>clsvTeacherInfoEN:objvTeacherInfoENT</returns>
 public static clsvTeacherInfoEN CopyTo(this clsvTeacherInfoEN objvTeacherInfoENS)
{
try
{
 clsvTeacherInfoEN objvTeacherInfoENT = new clsvTeacherInfoEN()
{
IdTeacher = objvTeacherInfoENS.IdTeacher, //教师流水号
TeacherId = objvTeacherInfoENS.TeacherId, //教师工号
TeacherName = objvTeacherInfoENS.TeacherName, //教师姓名
IdSex = objvTeacherInfoENS.IdSex, //性别流水号
SexDesc = objvTeacherInfoENS.SexDesc, //性别名称
IdSchoolPs = objvTeacherInfoENS.IdSchoolPs, //学校流水号
IdDisciplinePs = objvTeacherInfoENS.IdDisciplinePs, //学科流水号
IdUniZone = objvTeacherInfoENS.IdUniZone, //校区流水号
UniZoneDesc = objvTeacherInfoENS.UniZoneDesc, //校区名称
IdEthnic = objvTeacherInfoENS.IdEthnic, //民族流水号
EthnicName = objvTeacherInfoENS.EthnicName, //民族名称
IdPolitics = objvTeacherInfoENS.IdPolitics, //政治面貌流水号
PoliticsName = objvTeacherInfoENS.PoliticsName, //政治面貌
IdAdminGrade = objvTeacherInfoENS.IdAdminGrade, //行政职务流水号
AdminGradeDesc = objvTeacherInfoENS.AdminGradeDesc, //行政职务描述
IdProfGrade = objvTeacherInfoENS.IdProfGrade, //专业职称流水号
ProfenssionalGradeName = objvTeacherInfoENS.ProfenssionalGradeName, //专业职称
IdQualif = objvTeacherInfoENS.IdQualif, //学历流水号
QualifDesc = objvTeacherInfoENS.QualifDesc, //QualifDesc
IdDegree = objvTeacherInfoENS.IdDegree, //学位流水号
DegreeName = objvTeacherInfoENS.DegreeName, //学位名称
IdStaffType = objvTeacherInfoENS.IdStaffType, //职工类型流水号
StaffTypeName = objvTeacherInfoENS.StaffTypeName, //职工类型名称
IdProvince = objvTeacherInfoENS.IdProvince, //省份流水号
ProvinceName = objvTeacherInfoENS.ProvinceName, //ProvinceName
CitizenId = objvTeacherInfoENS.CitizenId, //身份证号
CardNo = objvTeacherInfoENS.CardNo, //卡号
Birthday = objvTeacherInfoENS.Birthday, //出生日期
GraduationMajor = objvTeacherInfoENS.GraduationMajor, //毕业专业
TelNo = objvTeacherInfoENS.TelNo, //电话
Email = objvTeacherInfoENS.Email, //电子邮箱
WebSite = objvTeacherInfoENS.WebSite, //个人主页
PersonBlog = objvTeacherInfoENS.PersonBlog, //个人博客
EntryDate = objvTeacherInfoENS.EntryDate, //进校日期
Offed = objvTeacherInfoENS.Offed, //是否离校
IsAvconUser = objvTeacherInfoENS.IsAvconUser, //IsAvconUser
IsGpUser = objvTeacherInfoENS.IsGpUser, //是否Gp用户
IsLocalUser = objvTeacherInfoENS.IsLocalUser, //是否本地用户
FromUnit = objvTeacherInfoENS.FromUnit, //来自单位
Memo = objvTeacherInfoENS.Memo, //备注
IdXzCollege = objvTeacherInfoENS.IdXzCollege, //学院流水号
CollegeId = objvTeacherInfoENS.CollegeId, //学院ID
CollegeName = objvTeacherInfoENS.CollegeName, //学院名称
CollegeNameA = objvTeacherInfoENS.CollegeNameA, //学院名称简写
IdXzMajor = objvTeacherInfoENS.IdXzMajor, //专业流水号
EntryDay = objvTeacherInfoENS.EntryDay, //EntryDay
IdPhoto = objvTeacherInfoENS.IdPhoto, //id_Photo
IdReligion = objvTeacherInfoENS.IdReligion, //id_Religion
ReligionName = objvTeacherInfoENS.ReligionName, //ReligionName
IsMessage = objvTeacherInfoENS.IsMessage, //IsMessage
Microblog = objvTeacherInfoENS.Microblog, //Microblog
ModifyUserId = objvTeacherInfoENS.ModifyUserId, //修改人
OffedBak = objvTeacherInfoENS.OffedBak, //OffedBak
PhoneNumber = objvTeacherInfoENS.PhoneNumber, //电话
QQ = objvTeacherInfoENS.QQ, //QQ
TeachIdCollege = objvTeacherInfoENS.TeachIdCollege, //Teach_id_College
TeachIdMajor = objvTeacherInfoENS.TeachIdMajor, //Teach_id_Major
Tel = objvTeacherInfoENS.Tel, //Tel
ModifyDate = objvTeacherInfoENS.ModifyDate, //修改日期
RegisterPassword = objvTeacherInfoENS.RegisterPassword, //RegisterPassword
EntryYear = objvTeacherInfoENS.EntryYear, //EntryYear
IdCardNo = objvTeacherInfoENS.IdCardNo, //身份证号
};
 return objvTeacherInfoENT;
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
public static void CheckProperty4Condition(this clsvTeacherInfoEN objvTeacherInfoEN)
{
 clsvTeacherInfoBL.vTeacherInfoDA.CheckProperty4Condition(objvTeacherInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeacherInfoEN objvTeacherInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdTeacher) == true)
{
string strComparisonOpIdTeacher = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdTeacher, objvTeacherInfoCond.IdTeacher, strComparisonOpIdTeacher);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.TeacherId) == true)
{
string strComparisonOpTeacherId = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.TeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.TeacherId, objvTeacherInfoCond.TeacherId, strComparisonOpTeacherId);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.TeacherName) == true)
{
string strComparisonOpTeacherName = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.TeacherName, objvTeacherInfoCond.TeacherName, strComparisonOpTeacherName);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdSex) == true)
{
string strComparisonOpIdSex = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdSex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdSex, objvTeacherInfoCond.IdSex, strComparisonOpIdSex);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.SexDesc) == true)
{
string strComparisonOpSexDesc = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.SexDesc, objvTeacherInfoCond.SexDesc, strComparisonOpSexDesc);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdSchoolPs) == true)
{
string strComparisonOpIdSchoolPs = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdSchoolPs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdSchoolPs, objvTeacherInfoCond.IdSchoolPs, strComparisonOpIdSchoolPs);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdDisciplinePs) == true)
{
string strComparisonOpIdDisciplinePs = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdDisciplinePs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdDisciplinePs, objvTeacherInfoCond.IdDisciplinePs, strComparisonOpIdDisciplinePs);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdUniZone, objvTeacherInfoCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.UniZoneDesc, objvTeacherInfoCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdEthnic) == true)
{
string strComparisonOpIdEthnic = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdEthnic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdEthnic, objvTeacherInfoCond.IdEthnic, strComparisonOpIdEthnic);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.EthnicName) == true)
{
string strComparisonOpEthnicName = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.EthnicName, objvTeacherInfoCond.EthnicName, strComparisonOpEthnicName);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdPolitics) == true)
{
string strComparisonOpIdPolitics = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdPolitics];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdPolitics, objvTeacherInfoCond.IdPolitics, strComparisonOpIdPolitics);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.PoliticsName) == true)
{
string strComparisonOpPoliticsName = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.PoliticsName, objvTeacherInfoCond.PoliticsName, strComparisonOpPoliticsName);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdAdminGrade) == true)
{
string strComparisonOpIdAdminGrade = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdAdminGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdAdminGrade, objvTeacherInfoCond.IdAdminGrade, strComparisonOpIdAdminGrade);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.AdminGradeDesc) == true)
{
string strComparisonOpAdminGradeDesc = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.AdminGradeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.AdminGradeDesc, objvTeacherInfoCond.AdminGradeDesc, strComparisonOpAdminGradeDesc);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdProfGrade) == true)
{
string strComparisonOpIdProfGrade = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdProfGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdProfGrade, objvTeacherInfoCond.IdProfGrade, strComparisonOpIdProfGrade);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.ProfenssionalGradeName) == true)
{
string strComparisonOpProfenssionalGradeName = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.ProfenssionalGradeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ProfenssionalGradeName, objvTeacherInfoCond.ProfenssionalGradeName, strComparisonOpProfenssionalGradeName);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdQualif) == true)
{
string strComparisonOpIdQualif = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdQualif];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdQualif, objvTeacherInfoCond.IdQualif, strComparisonOpIdQualif);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.QualifDesc) == true)
{
string strComparisonOpQualifDesc = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.QualifDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.QualifDesc, objvTeacherInfoCond.QualifDesc, strComparisonOpQualifDesc);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdDegree) == true)
{
string strComparisonOpIdDegree = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdDegree];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdDegree, objvTeacherInfoCond.IdDegree, strComparisonOpIdDegree);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.DegreeName) == true)
{
string strComparisonOpDegreeName = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.DegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.DegreeName, objvTeacherInfoCond.DegreeName, strComparisonOpDegreeName);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdStaffType) == true)
{
string strComparisonOpIdStaffType = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdStaffType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdStaffType, objvTeacherInfoCond.IdStaffType, strComparisonOpIdStaffType);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.StaffTypeName) == true)
{
string strComparisonOpStaffTypeName = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.StaffTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.StaffTypeName, objvTeacherInfoCond.StaffTypeName, strComparisonOpStaffTypeName);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdProvince) == true)
{
string strComparisonOpIdProvince = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdProvince];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdProvince, objvTeacherInfoCond.IdProvince, strComparisonOpIdProvince);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.ProvinceName) == true)
{
string strComparisonOpProvinceName = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.ProvinceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ProvinceName, objvTeacherInfoCond.ProvinceName, strComparisonOpProvinceName);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.CitizenId) == true)
{
string strComparisonOpCitizenId = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.CitizenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CitizenId, objvTeacherInfoCond.CitizenId, strComparisonOpCitizenId);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.CardNo) == true)
{
string strComparisonOpCardNo = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CardNo, objvTeacherInfoCond.CardNo, strComparisonOpCardNo);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.Birthday) == true)
{
string strComparisonOpBirthday = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Birthday, objvTeacherInfoCond.Birthday, strComparisonOpBirthday);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.GraduationMajor) == true)
{
string strComparisonOpGraduationMajor = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.GraduationMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.GraduationMajor, objvTeacherInfoCond.GraduationMajor, strComparisonOpGraduationMajor);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.TelNo) == true)
{
string strComparisonOpTelNo = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.TelNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.TelNo, objvTeacherInfoCond.TelNo, strComparisonOpTelNo);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.Email) == true)
{
string strComparisonOpEmail = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Email, objvTeacherInfoCond.Email, strComparisonOpEmail);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.WebSite) == true)
{
string strComparisonOpWebSite = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.WebSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.WebSite, objvTeacherInfoCond.WebSite, strComparisonOpWebSite);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.PersonBlog) == true)
{
string strComparisonOpPersonBlog = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.PersonBlog];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.PersonBlog, objvTeacherInfoCond.PersonBlog, strComparisonOpPersonBlog);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.EntryDate) == true)
{
string strComparisonOpEntryDate = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.EntryDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.EntryDate, objvTeacherInfoCond.EntryDate, strComparisonOpEntryDate);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.Offed) == true)
{
if (objvTeacherInfoCond.Offed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.Offed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.Offed);
}
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IsAvconUser) == true)
{
if (objvTeacherInfoCond.IsAvconUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.IsAvconUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.IsAvconUser);
}
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IsGpUser) == true)
{
if (objvTeacherInfoCond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.IsGpUser);
}
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IsLocalUser) == true)
{
if (objvTeacherInfoCond.IsLocalUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.IsLocalUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.IsLocalUser);
}
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.FromUnit) == true)
{
string strComparisonOpFromUnit = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.FromUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.FromUnit, objvTeacherInfoCond.FromUnit, strComparisonOpFromUnit);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.Memo) == true)
{
string strComparisonOpMemo = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Memo, objvTeacherInfoCond.Memo, strComparisonOpMemo);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdXzCollege, objvTeacherInfoCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.CollegeId) == true)
{
string strComparisonOpCollegeId = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CollegeId, objvTeacherInfoCond.CollegeId, strComparisonOpCollegeId);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.CollegeName) == true)
{
string strComparisonOpCollegeName = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CollegeName, objvTeacherInfoCond.CollegeName, strComparisonOpCollegeName);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.CollegeNameA, objvTeacherInfoCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdXzMajor, objvTeacherInfoCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.EntryDay) == true)
{
string strComparisonOpEntryDay = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.EntryDay];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.EntryDay, objvTeacherInfoCond.EntryDay, strComparisonOpEntryDay);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdPhoto) == true)
{
string strComparisonOpIdPhoto = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdPhoto];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdPhoto, objvTeacherInfoCond.IdPhoto, strComparisonOpIdPhoto);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdReligion) == true)
{
string strComparisonOpIdReligion = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdReligion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdReligion, objvTeacherInfoCond.IdReligion, strComparisonOpIdReligion);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.ReligionName) == true)
{
string strComparisonOpReligionName = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.ReligionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ReligionName, objvTeacherInfoCond.ReligionName, strComparisonOpReligionName);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IsMessage) == true)
{
if (objvTeacherInfoCond.IsMessage == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.IsMessage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.IsMessage);
}
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.Microblog) == true)
{
string strComparisonOpMicroblog = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.Microblog];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Microblog, objvTeacherInfoCond.Microblog, strComparisonOpMicroblog);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ModifyUserId, objvTeacherInfoCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.OffedBak) == true)
{
if (objvTeacherInfoCond.OffedBak == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeacherInfo.OffedBak);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeacherInfo.OffedBak);
}
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.PhoneNumber, objvTeacherInfoCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.QQ) == true)
{
string strComparisonOpQQ = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.QQ];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.QQ, objvTeacherInfoCond.QQ, strComparisonOpQQ);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.TeachIdCollege) == true)
{
string strComparisonOpTeachIdCollege = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.TeachIdCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.TeachIdCollege, objvTeacherInfoCond.TeachIdCollege, strComparisonOpTeachIdCollege);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.TeachIdMajor) == true)
{
string strComparisonOpTeachIdMajor = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.TeachIdMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.TeachIdMajor, objvTeacherInfoCond.TeachIdMajor, strComparisonOpTeachIdMajor);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.Tel) == true)
{
string strComparisonOpTel = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.Tel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.Tel, objvTeacherInfoCond.Tel, strComparisonOpTel);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.ModifyDate, objvTeacherInfoCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.RegisterPassword) == true)
{
string strComparisonOpRegisterPassword = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.RegisterPassword, objvTeacherInfoCond.RegisterPassword, strComparisonOpRegisterPassword);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.EntryYear) == true)
{
string strComparisonOpEntryYear = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.EntryYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.EntryYear, objvTeacherInfoCond.EntryYear, strComparisonOpEntryYear);
}
if (objvTeacherInfoCond.IsUpdated(convTeacherInfo.IdCardNo) == true)
{
string strComparisonOpIdCardNo = objvTeacherInfoCond.dicFldComparisonOp[convTeacherInfo.IdCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeacherInfo.IdCardNo, objvTeacherInfoCond.IdCardNo, strComparisonOpIdCardNo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeacherInfo
{
public virtual bool UpdRelaTabDate(string strIdTeacher, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v教师(vTeacherInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeacherInfoBL
{
public static RelatedActions_vTeacherInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeacherInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeacherInfoDA vTeacherInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeacherInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeacherInfoBL()
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
if (string.IsNullOrEmpty(clsvTeacherInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeacherInfoEN._ConnectString);
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
public static DataTable GetDataTable_vTeacherInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeacherInfoDA.GetDataTable_vTeacherInfo(strWhereCond);
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
objDT = vTeacherInfoDA.GetDataTable(strWhereCond);
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
objDT = vTeacherInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeacherInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeacherInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeacherInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vTeacherInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeacherInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeacherInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeacherLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTeacherInfoEN> GetObjLstByIdTeacherLst(List<string> arrIdTeacherLst)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeacherLst, true);
 string strWhereCond = string.Format("IdTeacher in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeacherLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeacherInfoEN> GetObjLstByIdTeacherLstCache(List<string> arrIdTeacherLst)
{
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName);
List<clsvTeacherInfoEN> arrvTeacherInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvTeacherInfoEN> arrvTeacherInfoObjLst_Sel =
arrvTeacherInfoObjLstCache
.Where(x => arrIdTeacherLst.Contains(x.IdTeacher));
return arrvTeacherInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeacherInfoEN> GetObjLst(string strWhereCond)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
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
public static List<clsvTeacherInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeacherInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeacherInfoEN> GetSubObjLstCache(clsvTeacherInfoEN objvTeacherInfoCond)
{
List<clsvTeacherInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeacherInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeacherInfo.AttributeName)
{
if (objvTeacherInfoCond.IsUpdated(strFldName) == false) continue;
if (objvTeacherInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeacherInfoCond[strFldName].ToString());
}
else
{
if (objvTeacherInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeacherInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeacherInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeacherInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeacherInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeacherInfoCond[strFldName]));
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
public static List<clsvTeacherInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
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
public static List<clsvTeacherInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
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
List<clsvTeacherInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeacherInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeacherInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeacherInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
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
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
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
public static List<clsvTeacherInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeacherInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeacherInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
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
public static List<clsvTeacherInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeacherInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeacherInfoEN.IdTeacher, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeacherInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeacherInfo(ref clsvTeacherInfoEN objvTeacherInfoEN)
{
bool bolResult = vTeacherInfoDA.GetvTeacherInfo(ref objvTeacherInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeacher">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeacherInfoEN GetObjByIdTeacher(string strIdTeacher)
{
if (strIdTeacher.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdTeacher]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdTeacher) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdTeacher]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTeacherInfoEN objvTeacherInfoEN = vTeacherInfoDA.GetObjByIdTeacher(strIdTeacher);
return objvTeacherInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeacherInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeacherInfoEN objvTeacherInfoEN = vTeacherInfoDA.GetFirstObj(strWhereCond);
 return objvTeacherInfoEN;
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
public static clsvTeacherInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeacherInfoEN objvTeacherInfoEN = vTeacherInfoDA.GetObjByDataRow(objRow);
 return objvTeacherInfoEN;
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
public static clsvTeacherInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeacherInfoEN objvTeacherInfoEN = vTeacherInfoDA.GetObjByDataRow(objRow);
 return objvTeacherInfoEN;
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
 /// <param name = "strIdTeacher">所给的关键字</param>
 /// <param name = "lstvTeacherInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeacherInfoEN GetObjByIdTeacherFromList(string strIdTeacher, List<clsvTeacherInfoEN> lstvTeacherInfoObjLst)
{
foreach (clsvTeacherInfoEN objvTeacherInfoEN in lstvTeacherInfoObjLst)
{
if (objvTeacherInfoEN.IdTeacher == strIdTeacher)
{
return objvTeacherInfoEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxIdTeacher;
 try
 {
 strMaxIdTeacher = clsvTeacherInfoDA.GetMaxStrId();
 return strMaxIdTeacher;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdTeacher;
 try
 {
 strIdTeacher = new clsvTeacherInfoDA().GetFirstID(strWhereCond);
 return strIdTeacher;
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
 arrList = vTeacherInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vTeacherInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdTeacher">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdTeacher)
{
if (string.IsNullOrEmpty(strIdTeacher) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdTeacher]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTeacherInfoDA.IsExist(strIdTeacher);
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
 bolIsExist = clsvTeacherInfoDA.IsExistTable();
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
 bolIsExist = vTeacherInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeacherInfoENS">源对象</param>
 /// <param name = "objvTeacherInfoENT">目标对象</param>
 public static void CopyTo(clsvTeacherInfoEN objvTeacherInfoENS, clsvTeacherInfoEN objvTeacherInfoENT)
{
try
{
objvTeacherInfoENT.IdTeacher = objvTeacherInfoENS.IdTeacher; //教师流水号
objvTeacherInfoENT.TeacherId = objvTeacherInfoENS.TeacherId; //教师工号
objvTeacherInfoENT.TeacherName = objvTeacherInfoENS.TeacherName; //教师姓名
objvTeacherInfoENT.IdSex = objvTeacherInfoENS.IdSex; //性别流水号
objvTeacherInfoENT.SexDesc = objvTeacherInfoENS.SexDesc; //性别名称
objvTeacherInfoENT.IdSchoolPs = objvTeacherInfoENS.IdSchoolPs; //学校流水号
objvTeacherInfoENT.IdDisciplinePs = objvTeacherInfoENS.IdDisciplinePs; //学科流水号
objvTeacherInfoENT.IdUniZone = objvTeacherInfoENS.IdUniZone; //校区流水号
objvTeacherInfoENT.UniZoneDesc = objvTeacherInfoENS.UniZoneDesc; //校区名称
objvTeacherInfoENT.IdEthnic = objvTeacherInfoENS.IdEthnic; //民族流水号
objvTeacherInfoENT.EthnicName = objvTeacherInfoENS.EthnicName; //民族名称
objvTeacherInfoENT.IdPolitics = objvTeacherInfoENS.IdPolitics; //政治面貌流水号
objvTeacherInfoENT.PoliticsName = objvTeacherInfoENS.PoliticsName; //政治面貌
objvTeacherInfoENT.IdAdminGrade = objvTeacherInfoENS.IdAdminGrade; //行政职务流水号
objvTeacherInfoENT.AdminGradeDesc = objvTeacherInfoENS.AdminGradeDesc; //行政职务描述
objvTeacherInfoENT.IdProfGrade = objvTeacherInfoENS.IdProfGrade; //专业职称流水号
objvTeacherInfoENT.ProfenssionalGradeName = objvTeacherInfoENS.ProfenssionalGradeName; //专业职称
objvTeacherInfoENT.IdQualif = objvTeacherInfoENS.IdQualif; //学历流水号
objvTeacherInfoENT.QualifDesc = objvTeacherInfoENS.QualifDesc; //QualifDesc
objvTeacherInfoENT.IdDegree = objvTeacherInfoENS.IdDegree; //学位流水号
objvTeacherInfoENT.DegreeName = objvTeacherInfoENS.DegreeName; //学位名称
objvTeacherInfoENT.IdStaffType = objvTeacherInfoENS.IdStaffType; //职工类型流水号
objvTeacherInfoENT.StaffTypeName = objvTeacherInfoENS.StaffTypeName; //职工类型名称
objvTeacherInfoENT.IdProvince = objvTeacherInfoENS.IdProvince; //省份流水号
objvTeacherInfoENT.ProvinceName = objvTeacherInfoENS.ProvinceName; //ProvinceName
objvTeacherInfoENT.CitizenId = objvTeacherInfoENS.CitizenId; //身份证号
objvTeacherInfoENT.CardNo = objvTeacherInfoENS.CardNo; //卡号
objvTeacherInfoENT.Birthday = objvTeacherInfoENS.Birthday; //出生日期
objvTeacherInfoENT.GraduationMajor = objvTeacherInfoENS.GraduationMajor; //毕业专业
objvTeacherInfoENT.TelNo = objvTeacherInfoENS.TelNo; //电话
objvTeacherInfoENT.Email = objvTeacherInfoENS.Email; //电子邮箱
objvTeacherInfoENT.WebSite = objvTeacherInfoENS.WebSite; //个人主页
objvTeacherInfoENT.PersonBlog = objvTeacherInfoENS.PersonBlog; //个人博客
objvTeacherInfoENT.EntryDate = objvTeacherInfoENS.EntryDate; //进校日期
objvTeacherInfoENT.Offed = objvTeacherInfoENS.Offed; //是否离校
objvTeacherInfoENT.IsAvconUser = objvTeacherInfoENS.IsAvconUser; //IsAvconUser
objvTeacherInfoENT.IsGpUser = objvTeacherInfoENS.IsGpUser; //是否Gp用户
objvTeacherInfoENT.IsLocalUser = objvTeacherInfoENS.IsLocalUser; //是否本地用户
objvTeacherInfoENT.FromUnit = objvTeacherInfoENS.FromUnit; //来自单位
objvTeacherInfoENT.Memo = objvTeacherInfoENS.Memo; //备注
objvTeacherInfoENT.IdXzCollege = objvTeacherInfoENS.IdXzCollege; //学院流水号
objvTeacherInfoENT.CollegeId = objvTeacherInfoENS.CollegeId; //学院ID
objvTeacherInfoENT.CollegeName = objvTeacherInfoENS.CollegeName; //学院名称
objvTeacherInfoENT.CollegeNameA = objvTeacherInfoENS.CollegeNameA; //学院名称简写
objvTeacherInfoENT.IdXzMajor = objvTeacherInfoENS.IdXzMajor; //专业流水号
objvTeacherInfoENT.EntryDay = objvTeacherInfoENS.EntryDay; //EntryDay
objvTeacherInfoENT.IdPhoto = objvTeacherInfoENS.IdPhoto; //id_Photo
objvTeacherInfoENT.IdReligion = objvTeacherInfoENS.IdReligion; //id_Religion
objvTeacherInfoENT.ReligionName = objvTeacherInfoENS.ReligionName; //ReligionName
objvTeacherInfoENT.IsMessage = objvTeacherInfoENS.IsMessage; //IsMessage
objvTeacherInfoENT.Microblog = objvTeacherInfoENS.Microblog; //Microblog
objvTeacherInfoENT.ModifyUserId = objvTeacherInfoENS.ModifyUserId; //修改人
objvTeacherInfoENT.OffedBak = objvTeacherInfoENS.OffedBak; //OffedBak
objvTeacherInfoENT.PhoneNumber = objvTeacherInfoENS.PhoneNumber; //电话
objvTeacherInfoENT.QQ = objvTeacherInfoENS.QQ; //QQ
objvTeacherInfoENT.TeachIdCollege = objvTeacherInfoENS.TeachIdCollege; //Teach_id_College
objvTeacherInfoENT.TeachIdMajor = objvTeacherInfoENS.TeachIdMajor; //Teach_id_Major
objvTeacherInfoENT.Tel = objvTeacherInfoENS.Tel; //Tel
objvTeacherInfoENT.ModifyDate = objvTeacherInfoENS.ModifyDate; //修改日期
objvTeacherInfoENT.RegisterPassword = objvTeacherInfoENS.RegisterPassword; //RegisterPassword
objvTeacherInfoENT.EntryYear = objvTeacherInfoENS.EntryYear; //EntryYear
objvTeacherInfoENT.IdCardNo = objvTeacherInfoENS.IdCardNo; //身份证号
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
 /// <param name = "objvTeacherInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeacherInfoEN objvTeacherInfoEN)
{
try
{
objvTeacherInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeacherInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeacherInfo.IdTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdTeacher = objvTeacherInfoEN.IdTeacher; //教师流水号
}
if (arrFldSet.Contains(convTeacherInfo.TeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.TeacherId = objvTeacherInfoEN.TeacherId; //教师工号
}
if (arrFldSet.Contains(convTeacherInfo.TeacherName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.TeacherName = objvTeacherInfoEN.TeacherName; //教师姓名
}
if (arrFldSet.Contains(convTeacherInfo.IdSex, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdSex = objvTeacherInfoEN.IdSex; //性别流水号
}
if (arrFldSet.Contains(convTeacherInfo.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.SexDesc = objvTeacherInfoEN.SexDesc == "[null]" ? null :  objvTeacherInfoEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convTeacherInfo.IdSchoolPs, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdSchoolPs = objvTeacherInfoEN.IdSchoolPs == "[null]" ? null :  objvTeacherInfoEN.IdSchoolPs; //学校流水号
}
if (arrFldSet.Contains(convTeacherInfo.IdDisciplinePs, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdDisciplinePs = objvTeacherInfoEN.IdDisciplinePs == "[null]" ? null :  objvTeacherInfoEN.IdDisciplinePs; //学科流水号
}
if (arrFldSet.Contains(convTeacherInfo.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdUniZone = objvTeacherInfoEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(convTeacherInfo.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.UniZoneDesc = objvTeacherInfoEN.UniZoneDesc == "[null]" ? null :  objvTeacherInfoEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convTeacherInfo.IdEthnic, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdEthnic = objvTeacherInfoEN.IdEthnic; //民族流水号
}
if (arrFldSet.Contains(convTeacherInfo.EthnicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.EthnicName = objvTeacherInfoEN.EthnicName == "[null]" ? null :  objvTeacherInfoEN.EthnicName; //民族名称
}
if (arrFldSet.Contains(convTeacherInfo.IdPolitics, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdPolitics = objvTeacherInfoEN.IdPolitics; //政治面貌流水号
}
if (arrFldSet.Contains(convTeacherInfo.PoliticsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.PoliticsName = objvTeacherInfoEN.PoliticsName; //政治面貌
}
if (arrFldSet.Contains(convTeacherInfo.IdAdminGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdAdminGrade = objvTeacherInfoEN.IdAdminGrade; //行政职务流水号
}
if (arrFldSet.Contains(convTeacherInfo.AdminGradeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.AdminGradeDesc = objvTeacherInfoEN.AdminGradeDesc; //行政职务描述
}
if (arrFldSet.Contains(convTeacherInfo.IdProfGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdProfGrade = objvTeacherInfoEN.IdProfGrade; //专业职称流水号
}
if (arrFldSet.Contains(convTeacherInfo.ProfenssionalGradeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.ProfenssionalGradeName = objvTeacherInfoEN.ProfenssionalGradeName; //专业职称
}
if (arrFldSet.Contains(convTeacherInfo.IdQualif, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdQualif = objvTeacherInfoEN.IdQualif; //学历流水号
}
if (arrFldSet.Contains(convTeacherInfo.QualifDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.QualifDesc = objvTeacherInfoEN.QualifDesc == "[null]" ? null :  objvTeacherInfoEN.QualifDesc; //QualifDesc
}
if (arrFldSet.Contains(convTeacherInfo.IdDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdDegree = objvTeacherInfoEN.IdDegree; //学位流水号
}
if (arrFldSet.Contains(convTeacherInfo.DegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.DegreeName = objvTeacherInfoEN.DegreeName; //学位名称
}
if (arrFldSet.Contains(convTeacherInfo.IdStaffType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdStaffType = objvTeacherInfoEN.IdStaffType; //职工类型流水号
}
if (arrFldSet.Contains(convTeacherInfo.StaffTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.StaffTypeName = objvTeacherInfoEN.StaffTypeName == "[null]" ? null :  objvTeacherInfoEN.StaffTypeName; //职工类型名称
}
if (arrFldSet.Contains(convTeacherInfo.IdProvince, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdProvince = objvTeacherInfoEN.IdProvince; //省份流水号
}
if (arrFldSet.Contains(convTeacherInfo.ProvinceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.ProvinceName = objvTeacherInfoEN.ProvinceName == "[null]" ? null :  objvTeacherInfoEN.ProvinceName; //ProvinceName
}
if (arrFldSet.Contains(convTeacherInfo.CitizenId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.CitizenId = objvTeacherInfoEN.CitizenId == "[null]" ? null :  objvTeacherInfoEN.CitizenId; //身份证号
}
if (arrFldSet.Contains(convTeacherInfo.CardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.CardNo = objvTeacherInfoEN.CardNo == "[null]" ? null :  objvTeacherInfoEN.CardNo; //卡号
}
if (arrFldSet.Contains(convTeacherInfo.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.Birthday = objvTeacherInfoEN.Birthday == "[null]" ? null :  objvTeacherInfoEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convTeacherInfo.GraduationMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.GraduationMajor = objvTeacherInfoEN.GraduationMajor == "[null]" ? null :  objvTeacherInfoEN.GraduationMajor; //毕业专业
}
if (arrFldSet.Contains(convTeacherInfo.TelNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.TelNo = objvTeacherInfoEN.TelNo == "[null]" ? null :  objvTeacherInfoEN.TelNo; //电话
}
if (arrFldSet.Contains(convTeacherInfo.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.Email = objvTeacherInfoEN.Email == "[null]" ? null :  objvTeacherInfoEN.Email; //电子邮箱
}
if (arrFldSet.Contains(convTeacherInfo.WebSite, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.WebSite = objvTeacherInfoEN.WebSite == "[null]" ? null :  objvTeacherInfoEN.WebSite; //个人主页
}
if (arrFldSet.Contains(convTeacherInfo.PersonBlog, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.PersonBlog = objvTeacherInfoEN.PersonBlog == "[null]" ? null :  objvTeacherInfoEN.PersonBlog; //个人博客
}
if (arrFldSet.Contains(convTeacherInfo.EntryDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.EntryDate = objvTeacherInfoEN.EntryDate == "[null]" ? null :  objvTeacherInfoEN.EntryDate; //进校日期
}
if (arrFldSet.Contains(convTeacherInfo.Offed, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.Offed = objvTeacherInfoEN.Offed; //是否离校
}
if (arrFldSet.Contains(convTeacherInfo.IsAvconUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IsAvconUser = objvTeacherInfoEN.IsAvconUser; //IsAvconUser
}
if (arrFldSet.Contains(convTeacherInfo.IsGpUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IsGpUser = objvTeacherInfoEN.IsGpUser; //是否Gp用户
}
if (arrFldSet.Contains(convTeacherInfo.IsLocalUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IsLocalUser = objvTeacherInfoEN.IsLocalUser; //是否本地用户
}
if (arrFldSet.Contains(convTeacherInfo.FromUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.FromUnit = objvTeacherInfoEN.FromUnit == "[null]" ? null :  objvTeacherInfoEN.FromUnit; //来自单位
}
if (arrFldSet.Contains(convTeacherInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.Memo = objvTeacherInfoEN.Memo == "[null]" ? null :  objvTeacherInfoEN.Memo; //备注
}
if (arrFldSet.Contains(convTeacherInfo.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdXzCollege = objvTeacherInfoEN.IdXzCollege == "[null]" ? null :  objvTeacherInfoEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convTeacherInfo.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.CollegeId = objvTeacherInfoEN.CollegeId == "[null]" ? null :  objvTeacherInfoEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convTeacherInfo.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.CollegeName = objvTeacherInfoEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convTeacherInfo.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.CollegeNameA = objvTeacherInfoEN.CollegeNameA == "[null]" ? null :  objvTeacherInfoEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convTeacherInfo.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdXzMajor = objvTeacherInfoEN.IdXzMajor == "[null]" ? null :  objvTeacherInfoEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convTeacherInfo.EntryDay, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.EntryDay = objvTeacherInfoEN.EntryDay == "[null]" ? null :  objvTeacherInfoEN.EntryDay; //EntryDay
}
if (arrFldSet.Contains(convTeacherInfo.IdPhoto, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdPhoto = objvTeacherInfoEN.IdPhoto == "[null]" ? null :  objvTeacherInfoEN.IdPhoto; //id_Photo
}
if (arrFldSet.Contains(convTeacherInfo.IdReligion, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdReligion = objvTeacherInfoEN.IdReligion == "[null]" ? null :  objvTeacherInfoEN.IdReligion; //id_Religion
}
if (arrFldSet.Contains(convTeacherInfo.ReligionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.ReligionName = objvTeacherInfoEN.ReligionName == "[null]" ? null :  objvTeacherInfoEN.ReligionName; //ReligionName
}
if (arrFldSet.Contains(convTeacherInfo.IsMessage, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IsMessage = objvTeacherInfoEN.IsMessage; //IsMessage
}
if (arrFldSet.Contains(convTeacherInfo.Microblog, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.Microblog = objvTeacherInfoEN.Microblog == "[null]" ? null :  objvTeacherInfoEN.Microblog; //Microblog
}
if (arrFldSet.Contains(convTeacherInfo.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.ModifyUserId = objvTeacherInfoEN.ModifyUserId == "[null]" ? null :  objvTeacherInfoEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(convTeacherInfo.OffedBak, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.OffedBak = objvTeacherInfoEN.OffedBak; //OffedBak
}
if (arrFldSet.Contains(convTeacherInfo.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.PhoneNumber = objvTeacherInfoEN.PhoneNumber == "[null]" ? null :  objvTeacherInfoEN.PhoneNumber; //电话
}
if (arrFldSet.Contains(convTeacherInfo.QQ, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.QQ = objvTeacherInfoEN.QQ == "[null]" ? null :  objvTeacherInfoEN.QQ; //QQ
}
if (arrFldSet.Contains(convTeacherInfo.TeachIdCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.TeachIdCollege = objvTeacherInfoEN.TeachIdCollege == "[null]" ? null :  objvTeacherInfoEN.TeachIdCollege; //Teach_id_College
}
if (arrFldSet.Contains(convTeacherInfo.TeachIdMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.TeachIdMajor = objvTeacherInfoEN.TeachIdMajor == "[null]" ? null :  objvTeacherInfoEN.TeachIdMajor; //Teach_id_Major
}
if (arrFldSet.Contains(convTeacherInfo.Tel, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.Tel = objvTeacherInfoEN.Tel == "[null]" ? null :  objvTeacherInfoEN.Tel; //Tel
}
if (arrFldSet.Contains(convTeacherInfo.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.ModifyDate = objvTeacherInfoEN.ModifyDate == "[null]" ? null :  objvTeacherInfoEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convTeacherInfo.RegisterPassword, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.RegisterPassword = objvTeacherInfoEN.RegisterPassword == "[null]" ? null :  objvTeacherInfoEN.RegisterPassword; //RegisterPassword
}
if (arrFldSet.Contains(convTeacherInfo.EntryYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.EntryYear = objvTeacherInfoEN.EntryYear == "[null]" ? null :  objvTeacherInfoEN.EntryYear; //EntryYear
}
if (arrFldSet.Contains(convTeacherInfo.IdCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeacherInfoEN.IdCardNo = objvTeacherInfoEN.IdCardNo == "[null]" ? null :  objvTeacherInfoEN.IdCardNo; //身份证号
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
 /// <param name = "objvTeacherInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeacherInfoEN objvTeacherInfoEN)
{
try
{
if (objvTeacherInfoEN.SexDesc == "[null]") objvTeacherInfoEN.SexDesc = null; //性别名称
if (objvTeacherInfoEN.IdSchoolPs == "[null]") objvTeacherInfoEN.IdSchoolPs = null; //学校流水号
if (objvTeacherInfoEN.IdDisciplinePs == "[null]") objvTeacherInfoEN.IdDisciplinePs = null; //学科流水号
if (objvTeacherInfoEN.UniZoneDesc == "[null]") objvTeacherInfoEN.UniZoneDesc = null; //校区名称
if (objvTeacherInfoEN.EthnicName == "[null]") objvTeacherInfoEN.EthnicName = null; //民族名称
if (objvTeacherInfoEN.QualifDesc == "[null]") objvTeacherInfoEN.QualifDesc = null; //QualifDesc
if (objvTeacherInfoEN.StaffTypeName == "[null]") objvTeacherInfoEN.StaffTypeName = null; //职工类型名称
if (objvTeacherInfoEN.ProvinceName == "[null]") objvTeacherInfoEN.ProvinceName = null; //ProvinceName
if (objvTeacherInfoEN.CitizenId == "[null]") objvTeacherInfoEN.CitizenId = null; //身份证号
if (objvTeacherInfoEN.CardNo == "[null]") objvTeacherInfoEN.CardNo = null; //卡号
if (objvTeacherInfoEN.Birthday == "[null]") objvTeacherInfoEN.Birthday = null; //出生日期
if (objvTeacherInfoEN.GraduationMajor == "[null]") objvTeacherInfoEN.GraduationMajor = null; //毕业专业
if (objvTeacherInfoEN.TelNo == "[null]") objvTeacherInfoEN.TelNo = null; //电话
if (objvTeacherInfoEN.Email == "[null]") objvTeacherInfoEN.Email = null; //电子邮箱
if (objvTeacherInfoEN.WebSite == "[null]") objvTeacherInfoEN.WebSite = null; //个人主页
if (objvTeacherInfoEN.PersonBlog == "[null]") objvTeacherInfoEN.PersonBlog = null; //个人博客
if (objvTeacherInfoEN.EntryDate == "[null]") objvTeacherInfoEN.EntryDate = null; //进校日期
if (objvTeacherInfoEN.FromUnit == "[null]") objvTeacherInfoEN.FromUnit = null; //来自单位
if (objvTeacherInfoEN.Memo == "[null]") objvTeacherInfoEN.Memo = null; //备注
if (objvTeacherInfoEN.IdXzCollege == "[null]") objvTeacherInfoEN.IdXzCollege = null; //学院流水号
if (objvTeacherInfoEN.CollegeId == "[null]") objvTeacherInfoEN.CollegeId = null; //学院ID
if (objvTeacherInfoEN.CollegeNameA == "[null]") objvTeacherInfoEN.CollegeNameA = null; //学院名称简写
if (objvTeacherInfoEN.IdXzMajor == "[null]") objvTeacherInfoEN.IdXzMajor = null; //专业流水号
if (objvTeacherInfoEN.EntryDay == "[null]") objvTeacherInfoEN.EntryDay = null; //EntryDay
if (objvTeacherInfoEN.IdPhoto == "[null]") objvTeacherInfoEN.IdPhoto = null; //id_Photo
if (objvTeacherInfoEN.IdReligion == "[null]") objvTeacherInfoEN.IdReligion = null; //id_Religion
if (objvTeacherInfoEN.ReligionName == "[null]") objvTeacherInfoEN.ReligionName = null; //ReligionName
if (objvTeacherInfoEN.Microblog == "[null]") objvTeacherInfoEN.Microblog = null; //Microblog
if (objvTeacherInfoEN.ModifyUserId == "[null]") objvTeacherInfoEN.ModifyUserId = null; //修改人
if (objvTeacherInfoEN.PhoneNumber == "[null]") objvTeacherInfoEN.PhoneNumber = null; //电话
if (objvTeacherInfoEN.QQ == "[null]") objvTeacherInfoEN.QQ = null; //QQ
if (objvTeacherInfoEN.TeachIdCollege == "[null]") objvTeacherInfoEN.TeachIdCollege = null; //Teach_id_College
if (objvTeacherInfoEN.TeachIdMajor == "[null]") objvTeacherInfoEN.TeachIdMajor = null; //Teach_id_Major
if (objvTeacherInfoEN.Tel == "[null]") objvTeacherInfoEN.Tel = null; //Tel
if (objvTeacherInfoEN.ModifyDate == "[null]") objvTeacherInfoEN.ModifyDate = null; //修改日期
if (objvTeacherInfoEN.RegisterPassword == "[null]") objvTeacherInfoEN.RegisterPassword = null; //RegisterPassword
if (objvTeacherInfoEN.EntryYear == "[null]") objvTeacherInfoEN.EntryYear = null; //EntryYear
if (objvTeacherInfoEN.IdCardNo == "[null]") objvTeacherInfoEN.IdCardNo = null; //身份证号
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
public static void CheckProperty4Condition(clsvTeacherInfoEN objvTeacherInfoEN)
{
 vTeacherInfoDA.CheckProperty4Condition(objvTeacherInfoEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdTeacher(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convTeacherInfo.IdTeacher); 
List<clsvTeacherInfoEN> arrObjLst = clsvTeacherInfoBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN()
{
IdTeacher = "0",
TeacherName = "选[v教师]..."
};
arrObjLst.Insert(0, objvTeacherInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convTeacherInfo.IdTeacher;
objComboBox.DisplayMember = convTeacherInfo.TeacherName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdTeacher(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教师]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convTeacherInfo.IdTeacher); 
IEnumerable<clsvTeacherInfoEN> arrObjLst = clsvTeacherInfoBL.GetObjLst(strCondition);
objDDL.DataValueField = convTeacherInfo.IdTeacher;
objDDL.DataTextField = convTeacherInfo.TeacherName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdTeacherCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教师]...","0");
List<clsvTeacherInfoEN> arrvTeacherInfoObjLst = GetAllvTeacherInfoObjLstCache(); 
objDDL.DataValueField = convTeacherInfo.IdTeacher;
objDDL.DataTextField = convTeacherInfo.TeacherName;
objDDL.DataSource = arrvTeacherInfoObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeBL没有刷新缓存机制(clsRsStaffTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeBL没有刷新缓存机制(clsRsProfGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeBL没有刷新缓存机制(clsRsDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceBL没有刷新缓存机制(clsRsProvinceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionBL没有刷新缓存机制(clsRsReligionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifBL没有刷新缓存机制(clsRsQualifBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeBL没有刷新缓存机制(clsRsAdminGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeacher");
//if (arrvTeacherInfoObjLstCache == null)
//{
//arrvTeacherInfoObjLstCache = vTeacherInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeacherInfoEN GetObjByIdTeacherCache(string strIdTeacher)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName);
List<clsvTeacherInfoEN> arrvTeacherInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvTeacherInfoEN> arrvTeacherInfoObjLst_Sel =
arrvTeacherInfoObjLstCache
.Where(x=> x.IdTeacher == strIdTeacher 
);
if (arrvTeacherInfoObjLst_Sel.Count() == 0)
{
   clsvTeacherInfoEN obj = clsvTeacherInfoBL.GetObjByIdTeacher(strIdTeacher);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeacherInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeacherNameByIdTeacherCache(string strIdTeacher)
{
if (string.IsNullOrEmpty(strIdTeacher) == true) return "";
//获取缓存中的对象列表
clsvTeacherInfoEN objvTeacherInfo = GetObjByIdTeacherCache(strIdTeacher);
if (objvTeacherInfo == null) return "";
return objvTeacherInfo.TeacherName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeacher">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdTeacherCache(string strIdTeacher)
{
if (string.IsNullOrEmpty(strIdTeacher) == true) return "";
//获取缓存中的对象列表
clsvTeacherInfoEN objvTeacherInfo = GetObjByIdTeacherCache(strIdTeacher);
if (objvTeacherInfo == null) return "";
return objvTeacherInfo.TeacherName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeacherInfoEN> GetAllvTeacherInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeacherInfoEN> arrvTeacherInfoObjLstCache = GetObjLstCache(); 
return arrvTeacherInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeacherInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName);
List<clsvTeacherInfoEN> arrvTeacherInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeacherInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvTeacherInfoEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdTeacher)
{
if (strInFldName != convTeacherInfo.IdTeacher)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeacherInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeacherInfo.AttributeName));
throw new Exception(strMsg);
}
var objvTeacherInfo = clsvTeacherInfoBL.GetObjByIdTeacherCache(strIdTeacher);
if (objvTeacherInfo == null) return "";
return objvTeacherInfo[strOutFldName].ToString();
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
int intRecCount = clsvTeacherInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeacherInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeacherInfoDA.GetRecCount();
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
int intRecCount = clsvTeacherInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeacherInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeacherInfoEN objvTeacherInfoCond)
{
List<clsvTeacherInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeacherInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeacherInfo.AttributeName)
{
if (objvTeacherInfoCond.IsUpdated(strFldName) == false) continue;
if (objvTeacherInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeacherInfoCond[strFldName].ToString());
}
else
{
if (objvTeacherInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeacherInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeacherInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeacherInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeacherInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeacherInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeacherInfoCond[strFldName]));
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
 List<string> arrList = clsvTeacherInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeacherInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeacherInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}