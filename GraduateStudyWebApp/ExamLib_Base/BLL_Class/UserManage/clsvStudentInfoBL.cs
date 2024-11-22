
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvStudentInfoBL
 表名:vStudentInfo(01120132)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:53
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
public static class  clsvStudentInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvStudentInfoEN GetObj(this K_IdStudentInfo_vStudentInfo myKey)
{
clsvStudentInfoEN objvStudentInfoEN = clsvStudentInfoBL.vStudentInfoDA.GetObjByIdStudentInfo(myKey.Value);
return objvStudentInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdStudentInfo(this clsvStudentInfoEN objvStudentInfoEN, string strIdStudentInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convStudentInfo.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convStudentInfo.IdStudentInfo);
}
objvStudentInfoEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdStudentInfo) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdStudentInfo, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdStudentInfo] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetStuId(this clsvStudentInfoEN objvStudentInfoEN, string strStuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuId, convStudentInfo.StuId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, convStudentInfo.StuId);
}
objvStudentInfoEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.StuId) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.StuId, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.StuId] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetStuName(this clsvStudentInfoEN objvStudentInfoEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convStudentInfo.StuName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convStudentInfo.StuName);
}
objvStudentInfoEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.StuName) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.StuName, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.StuName] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdPolitics(this clsvStudentInfoEN objvStudentInfoEN, string strIdPolitics, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPolitics, convStudentInfo.IdPolitics);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPolitics, 4, convStudentInfo.IdPolitics);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPolitics, 4, convStudentInfo.IdPolitics);
}
objvStudentInfoEN.IdPolitics = strIdPolitics; //政治面貌流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdPolitics) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdPolitics, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdPolitics] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetPoliticsId(this clsvStudentInfoEN objvStudentInfoEN, string strPoliticsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPoliticsId, 4, convStudentInfo.PoliticsId);
}
objvStudentInfoEN.PoliticsId = strPoliticsId; //政治面貌Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.PoliticsId) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.PoliticsId, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.PoliticsId] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetPoliticsName(this clsvStudentInfoEN objvStudentInfoEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPoliticsName, convStudentInfo.PoliticsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convStudentInfo.PoliticsName);
}
objvStudentInfoEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.PoliticsName) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.PoliticsName, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.PoliticsName] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdSex(this clsvStudentInfoEN objvStudentInfoEN, string strIdSex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSex, convStudentInfo.IdSex);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSex, 4, convStudentInfo.IdSex);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSex, 4, convStudentInfo.IdSex);
}
objvStudentInfoEN.IdSex = strIdSex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdSex) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdSex, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdSex] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetSexDesc(this clsvStudentInfoEN objvStudentInfoEN, string strSexDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convStudentInfo.SexDesc);
}
objvStudentInfoEN.SexDesc = strSexDesc; //性别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.SexDesc) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.SexDesc, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.SexDesc] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdEthnic(this clsvStudentInfoEN objvStudentInfoEN, string strIdEthnic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdEthnic, convStudentInfo.IdEthnic);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdEthnic, 4, convStudentInfo.IdEthnic);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdEthnic, 4, convStudentInfo.IdEthnic);
}
objvStudentInfoEN.IdEthnic = strIdEthnic; //民族流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdEthnic) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdEthnic, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdEthnic] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetEthnicId(this clsvStudentInfoEN objvStudentInfoEN, string strEthnicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEthnicId, 4, convStudentInfo.EthnicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEthnicId, 4, convStudentInfo.EthnicId);
}
objvStudentInfoEN.EthnicId = strEthnicId; //民族Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.EthnicId) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.EthnicId, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.EthnicId] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetEthnicName(this clsvStudentInfoEN objvStudentInfoEN, string strEthnicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convStudentInfo.EthnicName);
}
objvStudentInfoEN.EthnicName = strEthnicName; //民族名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.EthnicName) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.EthnicName, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.EthnicName] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdUniZone(this clsvStudentInfoEN objvStudentInfoEN, string strIdUniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdUniZone, convStudentInfo.IdUniZone);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, convStudentInfo.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, convStudentInfo.IdUniZone);
}
objvStudentInfoEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdUniZone) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdUniZone, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdUniZone] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetUniZoneDesc(this clsvStudentInfoEN objvStudentInfoEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUniZoneDesc, convStudentInfo.UniZoneDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convStudentInfo.UniZoneDesc);
}
objvStudentInfoEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.UniZoneDesc) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.UniZoneDesc, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.UniZoneDesc] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdStuType(this clsvStudentInfoEN objvStudentInfoEN, string strIdStuType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStuType, 4, convStudentInfo.IdStuType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStuType, 4, convStudentInfo.IdStuType);
}
objvStudentInfoEN.IdStuType = strIdStuType; //学生类别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdStuType) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdStuType, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdStuType] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetStuTypeID(this clsvStudentInfoEN objvStudentInfoEN, string strStuTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeID, 4, convStudentInfo.StuTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStuTypeID, 4, convStudentInfo.StuTypeID);
}
objvStudentInfoEN.StuTypeID = strStuTypeID; //学生类别ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.StuTypeID) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.StuTypeID, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.StuTypeID] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetStuTypeDesc(this clsvStudentInfoEN objvStudentInfoEN, string strStuTypeDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convStudentInfo.StuTypeDesc);
}
objvStudentInfoEN.StuTypeDesc = strStuTypeDesc; //学生类别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.StuTypeDesc) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.StuTypeDesc, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.StuTypeDesc] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdXzCollege(this clsvStudentInfoEN objvStudentInfoEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convStudentInfo.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convStudentInfo.IdXzCollege);
}
objvStudentInfoEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdXzCollege) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdXzCollege, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdXzCollege] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetCollegeId(this clsvStudentInfoEN objvStudentInfoEN, string strCollegeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convStudentInfo.CollegeId);
}
objvStudentInfoEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.CollegeId) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.CollegeId, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.CollegeId] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetCollegeName(this clsvStudentInfoEN objvStudentInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convStudentInfo.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convStudentInfo.CollegeName);
}
objvStudentInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.CollegeName) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.CollegeName, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.CollegeName] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetCollegeIdInGP(this clsvStudentInfoEN objvStudentInfoEN, string strCollegeIdInGP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeIdInGP, 6, convStudentInfo.CollegeIdInGP);
}
objvStudentInfoEN.CollegeIdInGP = strCollegeIdInGP; //CollegeIdInGP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.CollegeIdInGP) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.CollegeIdInGP, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.CollegeIdInGP] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetCollegeNameA(this clsvStudentInfoEN objvStudentInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convStudentInfo.CollegeNameA);
}
objvStudentInfoEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.CollegeNameA) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.CollegeNameA, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.CollegeNameA] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdXzMajor(this clsvStudentInfoEN objvStudentInfoEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convStudentInfo.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convStudentInfo.IdXzMajor);
}
objvStudentInfoEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdXzMajor) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdXzMajor, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdXzMajor] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetMajorID(this clsvStudentInfoEN objvStudentInfoEN, string strMajorID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convStudentInfo.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convStudentInfo.MajorID);
}
objvStudentInfoEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.MajorID) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.MajorID, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.MajorID] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetMajorName(this clsvStudentInfoEN objvStudentInfoEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convStudentInfo.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convStudentInfo.MajorName);
}
objvStudentInfoEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.MajorName) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.MajorName, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.MajorName] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIsNormal(this clsvStudentInfoEN objvStudentInfoEN, bool bolIsNormal, string strComparisonOp="")
	{
objvStudentInfoEN.IsNormal = bolIsNormal; //IsNormal
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IsNormal) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IsNormal, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IsNormal] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdGradeBase(this clsvStudentInfoEN objvStudentInfoEN, string strIdGradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdGradeBase, convStudentInfo.IdGradeBase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convStudentInfo.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convStudentInfo.IdGradeBase);
}
objvStudentInfoEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdGradeBase) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdGradeBase, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdGradeBase] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetGradeBaseName(this clsvStudentInfoEN objvStudentInfoEN, string strGradeBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convStudentInfo.GradeBaseName);
}
objvStudentInfoEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.GradeBaseName) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.GradeBaseName, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.GradeBaseName] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdAdminCls(this clsvStudentInfoEN objvStudentInfoEN, string strIdAdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAdminCls, convStudentInfo.IdAdminCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, convStudentInfo.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, convStudentInfo.IdAdminCls);
}
objvStudentInfoEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdAdminCls) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdAdminCls, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdAdminCls] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetAdminClsName(this clsvStudentInfoEN objvStudentInfoEN, string strAdminClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convStudentInfo.AdminClsName);
}
objvStudentInfoEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.AdminClsName) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.AdminClsName, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.AdminClsName] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetAdminClsId(this clsvStudentInfoEN objvStudentInfoEN, string strAdminClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convStudentInfo.AdminClsId);
}
objvStudentInfoEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.AdminClsId) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.AdminClsId, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.AdminClsId] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdAdminClsType(this clsvStudentInfoEN objvStudentInfoEN, string strIdAdminClsType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminClsType, 4, convStudentInfo.IdAdminClsType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminClsType, 4, convStudentInfo.IdAdminClsType);
}
objvStudentInfoEN.IdAdminClsType = strIdAdminClsType; //行政班级类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdAdminClsType) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdAdminClsType, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdAdminClsType] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetAdminClsTypeName(this clsvStudentInfoEN objvStudentInfoEN, string strAdminClsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsTypeName, 30, convStudentInfo.AdminClsTypeName);
}
objvStudentInfoEN.AdminClsTypeName = strAdminClsTypeName; //行政班级类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.AdminClsTypeName) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.AdminClsTypeName, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.AdminClsTypeName] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetBirthday(this clsvStudentInfoEN objvStudentInfoEN, string strBirthday, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBirthday, 8, convStudentInfo.Birthday);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convStudentInfo.Birthday);
}
objvStudentInfoEN.Birthday = strBirthday; //出生日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.Birthday) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.Birthday, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.Birthday] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetNativePlace(this clsvStudentInfoEN objvStudentInfoEN, string strNativePlace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convStudentInfo.NativePlace);
}
objvStudentInfoEN.NativePlace = strNativePlace; //籍贯
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.NativePlace) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.NativePlace, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.NativePlace] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetDuty(this clsvStudentInfoEN objvStudentInfoEN, string strDuty, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDuty, 30, convStudentInfo.Duty);
}
objvStudentInfoEN.Duty = strDuty; //职位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.Duty) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.Duty, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.Duty] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdCardNo(this clsvStudentInfoEN objvStudentInfoEN, string strIdCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCardNo, 20, convStudentInfo.IdCardNo);
}
objvStudentInfoEN.IdCardNo = strIdCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdCardNo) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdCardNo, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdCardNo] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetStuCardNo(this clsvStudentInfoEN objvStudentInfoEN, string strStuCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convStudentInfo.StuCardNo);
}
objvStudentInfoEN.StuCardNo = strStuCardNo; //学生证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.StuCardNo) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.StuCardNo, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.StuCardNo] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetLiveAddress(this clsvStudentInfoEN objvStudentInfoEN, string strLiveAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convStudentInfo.LiveAddress);
}
objvStudentInfoEN.LiveAddress = strLiveAddress; //居住地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.LiveAddress) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.LiveAddress, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.LiveAddress] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetHomePhone(this clsvStudentInfoEN objvStudentInfoEN, string strHomePhone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convStudentInfo.HomePhone);
}
objvStudentInfoEN.HomePhone = strHomePhone; //住宅电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.HomePhone) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.HomePhone, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.HomePhone] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIdCardNo2(this clsvStudentInfoEN objvStudentInfoEN, string strIdCardNo2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCardNo2, 20, convStudentInfo.IdCardNo2);
}
objvStudentInfoEN.IdCardNo2 = strIdCardNo2; //内卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IdCardNo2) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IdCardNo2, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IdCardNo2] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetCardNo(this clsvStudentInfoEN objvStudentInfoEN, string strCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCardNo, 18, convStudentInfo.CardNo);
}
objvStudentInfoEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.CardNo) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.CardNo, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.CardNo] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIsAvconClassUser(this clsvStudentInfoEN objvStudentInfoEN, bool bolIsAvconClassUser, string strComparisonOp="")
	{
objvStudentInfoEN.IsAvconClassUser = bolIsAvconClassUser; //IsAvconClassUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IsAvconClassUser) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IsAvconClassUser, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IsAvconClassUser] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIsAvconUser(this clsvStudentInfoEN objvStudentInfoEN, bool bolIsAvconUser, string strComparisonOp="")
	{
objvStudentInfoEN.IsAvconUser = bolIsAvconUser; //IsAvconUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IsAvconUser) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IsAvconUser, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IsAvconUser] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIsGpUser(this clsvStudentInfoEN objvStudentInfoEN, bool bolIsGpUser, string strComparisonOp="")
	{
objvStudentInfoEN.IsGpUser = bolIsGpUser; //是否Gp用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IsGpUser) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IsGpUser, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IsGpUser] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIsLocalUser(this clsvStudentInfoEN objvStudentInfoEN, bool bolIsLocalUser, string strComparisonOp="")
	{
objvStudentInfoEN.IsLocalUser = bolIsLocalUser; //是否本地用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IsLocalUser) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IsLocalUser, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IsLocalUser] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIsLeaved(this clsvStudentInfoEN objvStudentInfoEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvStudentInfoEN.IsLeaved = bolIsLeaved; //是否离开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IsLeaved) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IsLeaved, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IsLeaved] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetUserId(this clsvStudentInfoEN objvStudentInfoEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convStudentInfo.UserId);
}
objvStudentInfoEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.UserId) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.UserId, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.UserId] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetUserId4Avcon(this clsvStudentInfoEN objvStudentInfoEN, string strUserId4Avcon, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId4Avcon, 20, convStudentInfo.UserId4Avcon);
}
objvStudentInfoEN.UserId4Avcon = strUserId4Avcon; //UserId4Avcon
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.UserId4Avcon) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.UserId4Avcon, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.UserId4Avcon] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetEnrollmentDate(this clsvStudentInfoEN objvStudentInfoEN, string strEnrollmentDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convStudentInfo.EnrollmentDate);
}
objvStudentInfoEN.EnrollmentDate = strEnrollmentDate; //入校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.EnrollmentDate) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.EnrollmentDate, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.EnrollmentDate] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetPostCode(this clsvStudentInfoEN objvStudentInfoEN, string strPostCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPostCode, 6, convStudentInfo.PostCode);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convStudentInfo.PostCode);
}
objvStudentInfoEN.PostCode = strPostCode; //邮编
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.PostCode) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.PostCode, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.PostCode] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetEmail(this clsvStudentInfoEN objvStudentInfoEN, string strEmail, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEmail, 100, convStudentInfo.Email);
}
objvStudentInfoEN.Email = strEmail; //电子邮箱
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.Email) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.Email, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.Email] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetIsMessage(this clsvStudentInfoEN objvStudentInfoEN, bool bolIsMessage, string strComparisonOp="")
	{
objvStudentInfoEN.IsMessage = bolIsMessage; //IsMessage
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IsMessage) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IsMessage, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IsMessage] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetMicroblog(this clsvStudentInfoEN objvStudentInfoEN, string strMicroblog, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroblog, 200, convStudentInfo.Microblog);
}
objvStudentInfoEN.Microblog = strMicroblog; //Microblog
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.Microblog) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.Microblog, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.Microblog] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetPhoneNumber(this clsvStudentInfoEN objvStudentInfoEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convStudentInfo.PhoneNumber);
}
objvStudentInfoEN.PhoneNumber = strPhoneNumber; //电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.PhoneNumber) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.PhoneNumber, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.PhoneNumber] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetQQ(this clsvStudentInfoEN objvStudentInfoEN, string strQQ, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQQ, 100, convStudentInfo.QQ);
}
objvStudentInfoEN.QQ = strQQ; //QQ
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.QQ) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.QQ, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.QQ] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetRegisterPassword(this clsvStudentInfoEN objvStudentInfoEN, string strRegisterPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, convStudentInfo.RegisterPassword);
}
objvStudentInfoEN.RegisterPassword = strRegisterPassword; //RegisterPassword
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.RegisterPassword) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.RegisterPassword, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.RegisterPassword] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetUpdDate(this clsvStudentInfoEN objvStudentInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convStudentInfo.UpdDate);
}
objvStudentInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.UpdDate) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.UpdDate, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.UpdDate] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetUpdUser(this clsvStudentInfoEN objvStudentInfoEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convStudentInfo.UpdUser);
}
objvStudentInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.UpdUser) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.UpdUser, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.UpdUser] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvStudentInfoEN SetMemo(this clsvStudentInfoEN objvStudentInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convStudentInfo.Memo);
}
objvStudentInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.Memo) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.Memo, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.Memo] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvStudentInfoENS">源对象</param>
 /// <param name = "objvStudentInfoENT">目标对象</param>
 public static void CopyTo(this clsvStudentInfoEN objvStudentInfoENS, clsvStudentInfoEN objvStudentInfoENT)
{
try
{
objvStudentInfoENT.IdStudentInfo = objvStudentInfoENS.IdStudentInfo; //学生流水号
objvStudentInfoENT.StuId = objvStudentInfoENS.StuId; //学号
objvStudentInfoENT.StuName = objvStudentInfoENS.StuName; //姓名
objvStudentInfoENT.IdPolitics = objvStudentInfoENS.IdPolitics; //政治面貌流水号
objvStudentInfoENT.PoliticsId = objvStudentInfoENS.PoliticsId; //政治面貌Id
objvStudentInfoENT.PoliticsName = objvStudentInfoENS.PoliticsName; //政治面貌
objvStudentInfoENT.IdSex = objvStudentInfoENS.IdSex; //性别流水号
objvStudentInfoENT.SexDesc = objvStudentInfoENS.SexDesc; //性别名称
objvStudentInfoENT.IdEthnic = objvStudentInfoENS.IdEthnic; //民族流水号
objvStudentInfoENT.EthnicId = objvStudentInfoENS.EthnicId; //民族Id
objvStudentInfoENT.EthnicName = objvStudentInfoENS.EthnicName; //民族名称
objvStudentInfoENT.IdUniZone = objvStudentInfoENS.IdUniZone; //校区流水号
objvStudentInfoENT.UniZoneDesc = objvStudentInfoENS.UniZoneDesc; //校区名称
objvStudentInfoENT.IdStuType = objvStudentInfoENS.IdStuType; //学生类别流水号
objvStudentInfoENT.StuTypeID = objvStudentInfoENS.StuTypeID; //学生类别ID
objvStudentInfoENT.StuTypeDesc = objvStudentInfoENS.StuTypeDesc; //学生类别名称
objvStudentInfoENT.IdXzCollege = objvStudentInfoENS.IdXzCollege; //学院流水号
objvStudentInfoENT.CollegeId = objvStudentInfoENS.CollegeId; //学院ID
objvStudentInfoENT.CollegeName = objvStudentInfoENS.CollegeName; //学院名称
objvStudentInfoENT.CollegeIdInGP = objvStudentInfoENS.CollegeIdInGP; //CollegeIdInGP
objvStudentInfoENT.CollegeNameA = objvStudentInfoENS.CollegeNameA; //学院名称简写
objvStudentInfoENT.IdXzMajor = objvStudentInfoENS.IdXzMajor; //专业流水号
objvStudentInfoENT.MajorID = objvStudentInfoENS.MajorID; //专业ID
objvStudentInfoENT.MajorName = objvStudentInfoENS.MajorName; //专业名称
objvStudentInfoENT.IsNormal = objvStudentInfoENS.IsNormal; //IsNormal
objvStudentInfoENT.IdGradeBase = objvStudentInfoENS.IdGradeBase; //年级流水号
objvStudentInfoENT.GradeBaseName = objvStudentInfoENS.GradeBaseName; //年级名称
objvStudentInfoENT.IdAdminCls = objvStudentInfoENS.IdAdminCls; //行政班流水号
objvStudentInfoENT.AdminClsName = objvStudentInfoENS.AdminClsName; //行政班名称
objvStudentInfoENT.AdminClsId = objvStudentInfoENS.AdminClsId; //行政班代号
objvStudentInfoENT.IdAdminClsType = objvStudentInfoENS.IdAdminClsType; //行政班级类型流水号
objvStudentInfoENT.AdminClsTypeName = objvStudentInfoENS.AdminClsTypeName; //行政班级类型名称
objvStudentInfoENT.Birthday = objvStudentInfoENS.Birthday; //出生日期
objvStudentInfoENT.NativePlace = objvStudentInfoENS.NativePlace; //籍贯
objvStudentInfoENT.Duty = objvStudentInfoENS.Duty; //职位
objvStudentInfoENT.IdCardNo = objvStudentInfoENS.IdCardNo; //身份证号
objvStudentInfoENT.StuCardNo = objvStudentInfoENS.StuCardNo; //学生证号
objvStudentInfoENT.LiveAddress = objvStudentInfoENS.LiveAddress; //居住地址
objvStudentInfoENT.HomePhone = objvStudentInfoENS.HomePhone; //住宅电话
objvStudentInfoENT.IdCardNo2 = objvStudentInfoENS.IdCardNo2; //内卡号
objvStudentInfoENT.CardNo = objvStudentInfoENS.CardNo; //卡号
objvStudentInfoENT.IsAvconClassUser = objvStudentInfoENS.IsAvconClassUser; //IsAvconClassUser
objvStudentInfoENT.IsAvconUser = objvStudentInfoENS.IsAvconUser; //IsAvconUser
objvStudentInfoENT.IsGpUser = objvStudentInfoENS.IsGpUser; //是否Gp用户
objvStudentInfoENT.IsLocalUser = objvStudentInfoENS.IsLocalUser; //是否本地用户
objvStudentInfoENT.IsLeaved = objvStudentInfoENS.IsLeaved; //是否离开
objvStudentInfoENT.UserId = objvStudentInfoENS.UserId; //用户ID
objvStudentInfoENT.UserId4Avcon = objvStudentInfoENS.UserId4Avcon; //UserId4Avcon
objvStudentInfoENT.EnrollmentDate = objvStudentInfoENS.EnrollmentDate; //入校日期
objvStudentInfoENT.PostCode = objvStudentInfoENS.PostCode; //邮编
objvStudentInfoENT.Email = objvStudentInfoENS.Email; //电子邮箱
objvStudentInfoENT.IsMessage = objvStudentInfoENS.IsMessage; //IsMessage
objvStudentInfoENT.Microblog = objvStudentInfoENS.Microblog; //Microblog
objvStudentInfoENT.PhoneNumber = objvStudentInfoENS.PhoneNumber; //电话
objvStudentInfoENT.QQ = objvStudentInfoENS.QQ; //QQ
objvStudentInfoENT.RegisterPassword = objvStudentInfoENS.RegisterPassword; //RegisterPassword
objvStudentInfoENT.UpdDate = objvStudentInfoENS.UpdDate; //修改日期
objvStudentInfoENT.UpdUser = objvStudentInfoENS.UpdUser; //修改人
objvStudentInfoENT.Memo = objvStudentInfoENS.Memo; //备注
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
 /// <param name = "objvStudentInfoENS">源对象</param>
 /// <returns>目标对象=>clsvStudentInfoEN:objvStudentInfoENT</returns>
 public static clsvStudentInfoEN CopyTo(this clsvStudentInfoEN objvStudentInfoENS)
{
try
{
 clsvStudentInfoEN objvStudentInfoENT = new clsvStudentInfoEN()
{
IdStudentInfo = objvStudentInfoENS.IdStudentInfo, //学生流水号
StuId = objvStudentInfoENS.StuId, //学号
StuName = objvStudentInfoENS.StuName, //姓名
IdPolitics = objvStudentInfoENS.IdPolitics, //政治面貌流水号
PoliticsId = objvStudentInfoENS.PoliticsId, //政治面貌Id
PoliticsName = objvStudentInfoENS.PoliticsName, //政治面貌
IdSex = objvStudentInfoENS.IdSex, //性别流水号
SexDesc = objvStudentInfoENS.SexDesc, //性别名称
IdEthnic = objvStudentInfoENS.IdEthnic, //民族流水号
EthnicId = objvStudentInfoENS.EthnicId, //民族Id
EthnicName = objvStudentInfoENS.EthnicName, //民族名称
IdUniZone = objvStudentInfoENS.IdUniZone, //校区流水号
UniZoneDesc = objvStudentInfoENS.UniZoneDesc, //校区名称
IdStuType = objvStudentInfoENS.IdStuType, //学生类别流水号
StuTypeID = objvStudentInfoENS.StuTypeID, //学生类别ID
StuTypeDesc = objvStudentInfoENS.StuTypeDesc, //学生类别名称
IdXzCollege = objvStudentInfoENS.IdXzCollege, //学院流水号
CollegeId = objvStudentInfoENS.CollegeId, //学院ID
CollegeName = objvStudentInfoENS.CollegeName, //学院名称
CollegeIdInGP = objvStudentInfoENS.CollegeIdInGP, //CollegeIdInGP
CollegeNameA = objvStudentInfoENS.CollegeNameA, //学院名称简写
IdXzMajor = objvStudentInfoENS.IdXzMajor, //专业流水号
MajorID = objvStudentInfoENS.MajorID, //专业ID
MajorName = objvStudentInfoENS.MajorName, //专业名称
IsNormal = objvStudentInfoENS.IsNormal, //IsNormal
IdGradeBase = objvStudentInfoENS.IdGradeBase, //年级流水号
GradeBaseName = objvStudentInfoENS.GradeBaseName, //年级名称
IdAdminCls = objvStudentInfoENS.IdAdminCls, //行政班流水号
AdminClsName = objvStudentInfoENS.AdminClsName, //行政班名称
AdminClsId = objvStudentInfoENS.AdminClsId, //行政班代号
IdAdminClsType = objvStudentInfoENS.IdAdminClsType, //行政班级类型流水号
AdminClsTypeName = objvStudentInfoENS.AdminClsTypeName, //行政班级类型名称
Birthday = objvStudentInfoENS.Birthday, //出生日期
NativePlace = objvStudentInfoENS.NativePlace, //籍贯
Duty = objvStudentInfoENS.Duty, //职位
IdCardNo = objvStudentInfoENS.IdCardNo, //身份证号
StuCardNo = objvStudentInfoENS.StuCardNo, //学生证号
LiveAddress = objvStudentInfoENS.LiveAddress, //居住地址
HomePhone = objvStudentInfoENS.HomePhone, //住宅电话
IdCardNo2 = objvStudentInfoENS.IdCardNo2, //内卡号
CardNo = objvStudentInfoENS.CardNo, //卡号
IsAvconClassUser = objvStudentInfoENS.IsAvconClassUser, //IsAvconClassUser
IsAvconUser = objvStudentInfoENS.IsAvconUser, //IsAvconUser
IsGpUser = objvStudentInfoENS.IsGpUser, //是否Gp用户
IsLocalUser = objvStudentInfoENS.IsLocalUser, //是否本地用户
IsLeaved = objvStudentInfoENS.IsLeaved, //是否离开
UserId = objvStudentInfoENS.UserId, //用户ID
UserId4Avcon = objvStudentInfoENS.UserId4Avcon, //UserId4Avcon
EnrollmentDate = objvStudentInfoENS.EnrollmentDate, //入校日期
PostCode = objvStudentInfoENS.PostCode, //邮编
Email = objvStudentInfoENS.Email, //电子邮箱
IsMessage = objvStudentInfoENS.IsMessage, //IsMessage
Microblog = objvStudentInfoENS.Microblog, //Microblog
PhoneNumber = objvStudentInfoENS.PhoneNumber, //电话
QQ = objvStudentInfoENS.QQ, //QQ
RegisterPassword = objvStudentInfoENS.RegisterPassword, //RegisterPassword
UpdDate = objvStudentInfoENS.UpdDate, //修改日期
UpdUser = objvStudentInfoENS.UpdUser, //修改人
Memo = objvStudentInfoENS.Memo, //备注
};
 return objvStudentInfoENT;
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
public static void CheckProperty4Condition(this clsvStudentInfoEN objvStudentInfoEN)
{
 clsvStudentInfoBL.vStudentInfoDA.CheckProperty4Condition(objvStudentInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvStudentInfoEN objvStudentInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdStudentInfo, objvStudentInfoCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.StuId) == true)
{
string strComparisonOpStuId = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuId, objvStudentInfoCond.StuId, strComparisonOpStuId);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.StuName) == true)
{
string strComparisonOpStuName = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuName, objvStudentInfoCond.StuName, strComparisonOpStuName);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdPolitics) == true)
{
string strComparisonOpIdPolitics = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdPolitics];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdPolitics, objvStudentInfoCond.IdPolitics, strComparisonOpIdPolitics);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.PoliticsId) == true)
{
string strComparisonOpPoliticsId = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.PoliticsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.PoliticsId, objvStudentInfoCond.PoliticsId, strComparisonOpPoliticsId);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.PoliticsName) == true)
{
string strComparisonOpPoliticsName = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.PoliticsName, objvStudentInfoCond.PoliticsName, strComparisonOpPoliticsName);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdSex) == true)
{
string strComparisonOpIdSex = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdSex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdSex, objvStudentInfoCond.IdSex, strComparisonOpIdSex);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.SexDesc) == true)
{
string strComparisonOpSexDesc = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.SexDesc, objvStudentInfoCond.SexDesc, strComparisonOpSexDesc);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdEthnic) == true)
{
string strComparisonOpIdEthnic = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdEthnic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdEthnic, objvStudentInfoCond.IdEthnic, strComparisonOpIdEthnic);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.EthnicId) == true)
{
string strComparisonOpEthnicId = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.EthnicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.EthnicId, objvStudentInfoCond.EthnicId, strComparisonOpEthnicId);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.EthnicName) == true)
{
string strComparisonOpEthnicName = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.EthnicName, objvStudentInfoCond.EthnicName, strComparisonOpEthnicName);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdUniZone, objvStudentInfoCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UniZoneDesc, objvStudentInfoCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdStuType) == true)
{
string strComparisonOpIdStuType = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdStuType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdStuType, objvStudentInfoCond.IdStuType, strComparisonOpIdStuType);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.StuTypeID) == true)
{
string strComparisonOpStuTypeID = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.StuTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuTypeID, objvStudentInfoCond.StuTypeID, strComparisonOpStuTypeID);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.StuTypeDesc) == true)
{
string strComparisonOpStuTypeDesc = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuTypeDesc, objvStudentInfoCond.StuTypeDesc, strComparisonOpStuTypeDesc);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdXzCollege, objvStudentInfoCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.CollegeId) == true)
{
string strComparisonOpCollegeId = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CollegeId, objvStudentInfoCond.CollegeId, strComparisonOpCollegeId);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.CollegeName) == true)
{
string strComparisonOpCollegeName = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CollegeName, objvStudentInfoCond.CollegeName, strComparisonOpCollegeName);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.CollegeIdInGP) == true)
{
string strComparisonOpCollegeIdInGP = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.CollegeIdInGP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CollegeIdInGP, objvStudentInfoCond.CollegeIdInGP, strComparisonOpCollegeIdInGP);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CollegeNameA, objvStudentInfoCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdXzMajor, objvStudentInfoCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.MajorID) == true)
{
string strComparisonOpMajorID = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.MajorID, objvStudentInfoCond.MajorID, strComparisonOpMajorID);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.MajorName) == true)
{
string strComparisonOpMajorName = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.MajorName, objvStudentInfoCond.MajorName, strComparisonOpMajorName);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IsNormal) == true)
{
if (objvStudentInfoCond.IsNormal == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsNormal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsNormal);
}
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdGradeBase, objvStudentInfoCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.GradeBaseName, objvStudentInfoCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdAdminCls, objvStudentInfoCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.AdminClsName) == true)
{
string strComparisonOpAdminClsName = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.AdminClsName, objvStudentInfoCond.AdminClsName, strComparisonOpAdminClsName);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.AdminClsId) == true)
{
string strComparisonOpAdminClsId = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.AdminClsId, objvStudentInfoCond.AdminClsId, strComparisonOpAdminClsId);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdAdminClsType) == true)
{
string strComparisonOpIdAdminClsType = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdAdminClsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdAdminClsType, objvStudentInfoCond.IdAdminClsType, strComparisonOpIdAdminClsType);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.AdminClsTypeName) == true)
{
string strComparisonOpAdminClsTypeName = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.AdminClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.AdminClsTypeName, objvStudentInfoCond.AdminClsTypeName, strComparisonOpAdminClsTypeName);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.Birthday) == true)
{
string strComparisonOpBirthday = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Birthday, objvStudentInfoCond.Birthday, strComparisonOpBirthday);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.NativePlace) == true)
{
string strComparisonOpNativePlace = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.NativePlace, objvStudentInfoCond.NativePlace, strComparisonOpNativePlace);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.Duty) == true)
{
string strComparisonOpDuty = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Duty, objvStudentInfoCond.Duty, strComparisonOpDuty);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdCardNo) == true)
{
string strComparisonOpIdCardNo = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdCardNo, objvStudentInfoCond.IdCardNo, strComparisonOpIdCardNo);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.StuCardNo) == true)
{
string strComparisonOpStuCardNo = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuCardNo, objvStudentInfoCond.StuCardNo, strComparisonOpStuCardNo);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.LiveAddress) == true)
{
string strComparisonOpLiveAddress = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.LiveAddress, objvStudentInfoCond.LiveAddress, strComparisonOpLiveAddress);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.HomePhone) == true)
{
string strComparisonOpHomePhone = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.HomePhone, objvStudentInfoCond.HomePhone, strComparisonOpHomePhone);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IdCardNo2) == true)
{
string strComparisonOpIdCardNo2 = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.IdCardNo2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IdCardNo2, objvStudentInfoCond.IdCardNo2, strComparisonOpIdCardNo2);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.CardNo) == true)
{
string strComparisonOpCardNo = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CardNo, objvStudentInfoCond.CardNo, strComparisonOpCardNo);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IsAvconClassUser) == true)
{
if (objvStudentInfoCond.IsAvconClassUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsAvconClassUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsAvconClassUser);
}
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IsAvconUser) == true)
{
if (objvStudentInfoCond.IsAvconUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsAvconUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsAvconUser);
}
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IsGpUser) == true)
{
if (objvStudentInfoCond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsGpUser);
}
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IsLocalUser) == true)
{
if (objvStudentInfoCond.IsLocalUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsLocalUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsLocalUser);
}
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IsLeaved) == true)
{
if (objvStudentInfoCond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsLeaved);
}
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.UserId) == true)
{
string strComparisonOpUserId = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UserId, objvStudentInfoCond.UserId, strComparisonOpUserId);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.UserId4Avcon) == true)
{
string strComparisonOpUserId4Avcon = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.UserId4Avcon];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UserId4Avcon, objvStudentInfoCond.UserId4Avcon, strComparisonOpUserId4Avcon);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.EnrollmentDate) == true)
{
string strComparisonOpEnrollmentDate = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.EnrollmentDate, objvStudentInfoCond.EnrollmentDate, strComparisonOpEnrollmentDate);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.PostCode) == true)
{
string strComparisonOpPostCode = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.PostCode, objvStudentInfoCond.PostCode, strComparisonOpPostCode);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.Email) == true)
{
string strComparisonOpEmail = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Email, objvStudentInfoCond.Email, strComparisonOpEmail);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.IsMessage) == true)
{
if (objvStudentInfoCond.IsMessage == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsMessage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsMessage);
}
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.Microblog) == true)
{
string strComparisonOpMicroblog = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.Microblog];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Microblog, objvStudentInfoCond.Microblog, strComparisonOpMicroblog);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.PhoneNumber, objvStudentInfoCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.QQ) == true)
{
string strComparisonOpQQ = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.QQ];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.QQ, objvStudentInfoCond.QQ, strComparisonOpQQ);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.RegisterPassword) == true)
{
string strComparisonOpRegisterPassword = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.RegisterPassword, objvStudentInfoCond.RegisterPassword, strComparisonOpRegisterPassword);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UpdDate, objvStudentInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.UpdUser) == true)
{
string strComparisonOpUpdUser = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UpdUser, objvStudentInfoCond.UpdUser, strComparisonOpUpdUser);
}
if (objvStudentInfoCond.IsUpdated(convStudentInfo.Memo) == true)
{
string strComparisonOpMemo = objvStudentInfoCond.dicFldComparisonOp[convStudentInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Memo, objvStudentInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vStudentInfo
{
public virtual bool UpdRelaTabDate(string strIdStudentInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v学生(vStudentInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvStudentInfoBL
{
public static RelatedActions_vStudentInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvStudentInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvStudentInfoDA vStudentInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvStudentInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvStudentInfoBL()
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
if (string.IsNullOrEmpty(clsvStudentInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvStudentInfoEN._ConnectString);
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
public static DataTable GetDataTable_vStudentInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vStudentInfoDA.GetDataTable_vStudentInfo(strWhereCond);
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
objDT = vStudentInfoDA.GetDataTable(strWhereCond);
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
objDT = vStudentInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vStudentInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vStudentInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vStudentInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vStudentInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vStudentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vStudentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdStudentInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvStudentInfoEN> GetObjLstByIdStudentInfoLst(List<string> arrIdStudentInfoLst)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdStudentInfoLst, true);
 string strWhereCond = string.Format("IdStudentInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdStudentInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvStudentInfoEN> GetObjLstByIdStudentInfoLstCache(List<string> arrIdStudentInfoLst)
{
string strKey = string.Format("{0}", clsvStudentInfoEN._CurrTabName);
List<clsvStudentInfoEN> arrvStudentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvStudentInfoEN> arrvStudentInfoObjLst_Sel =
arrvStudentInfoObjLstCache
.Where(x => arrIdStudentInfoLst.Contains(x.IdStudentInfo));
return arrvStudentInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfoEN> GetObjLst(string strWhereCond)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
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
public static List<clsvStudentInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvStudentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvStudentInfoEN> GetSubObjLstCache(clsvStudentInfoEN objvStudentInfoCond)
{
List<clsvStudentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvStudentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convStudentInfo.AttributeName)
{
if (objvStudentInfoCond.IsUpdated(strFldName) == false) continue;
if (objvStudentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvStudentInfoCond[strFldName].ToString());
}
else
{
if (objvStudentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvStudentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvStudentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvStudentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvStudentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvStudentInfoCond[strFldName]));
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
public static List<clsvStudentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
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
public static List<clsvStudentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
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
List<clsvStudentInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvStudentInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvStudentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
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
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
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
public static List<clsvStudentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvStudentInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvStudentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
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
public static List<clsvStudentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvStudentInfoEN> arrObjLst = new List<clsvStudentInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvStudentInfoEN objvStudentInfoEN = new clsvStudentInfoEN();
try
{
objvStudentInfoEN.IdStudentInfo = objRow[convStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objvStudentInfoEN.StuId = objRow[convStudentInfo.StuId].ToString().Trim(); //学号
objvStudentInfoEN.StuName = objRow[convStudentInfo.StuName].ToString().Trim(); //姓名
objvStudentInfoEN.IdPolitics = objRow[convStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvStudentInfoEN.PoliticsId = objRow[convStudentInfo.PoliticsId] == DBNull.Value ? null : objRow[convStudentInfo.PoliticsId].ToString().Trim(); //政治面貌Id
objvStudentInfoEN.PoliticsName = objRow[convStudentInfo.PoliticsName].ToString().Trim(); //政治面貌
objvStudentInfoEN.IdSex = objRow[convStudentInfo.IdSex].ToString().Trim(); //性别流水号
objvStudentInfoEN.SexDesc = objRow[convStudentInfo.SexDesc] == DBNull.Value ? null : objRow[convStudentInfo.SexDesc].ToString().Trim(); //性别名称
objvStudentInfoEN.IdEthnic = objRow[convStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objvStudentInfoEN.EthnicId = objRow[convStudentInfo.EthnicId] == DBNull.Value ? null : objRow[convStudentInfo.EthnicId].ToString().Trim(); //民族Id
objvStudentInfoEN.EthnicName = objRow[convStudentInfo.EthnicName] == DBNull.Value ? null : objRow[convStudentInfo.EthnicName].ToString().Trim(); //民族名称
objvStudentInfoEN.IdUniZone = objRow[convStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objvStudentInfoEN.UniZoneDesc = objRow[convStudentInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvStudentInfoEN.IdStuType = objRow[convStudentInfo.IdStuType] == DBNull.Value ? null : objRow[convStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objvStudentInfoEN.StuTypeID = objRow[convStudentInfo.StuTypeID] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeID].ToString().Trim(); //学生类别ID
objvStudentInfoEN.StuTypeDesc = objRow[convStudentInfo.StuTypeDesc] == DBNull.Value ? null : objRow[convStudentInfo.StuTypeDesc].ToString().Trim(); //学生类别名称
objvStudentInfoEN.IdXzCollege = objRow[convStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[convStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvStudentInfoEN.CollegeId = objRow[convStudentInfo.CollegeId] == DBNull.Value ? null : objRow[convStudentInfo.CollegeId].ToString().Trim(); //学院ID
objvStudentInfoEN.CollegeName = objRow[convStudentInfo.CollegeName].ToString().Trim(); //学院名称
objvStudentInfoEN.CollegeIdInGP = objRow[convStudentInfo.CollegeIdInGP] == DBNull.Value ? null : objRow[convStudentInfo.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objvStudentInfoEN.CollegeNameA = objRow[convStudentInfo.CollegeNameA] == DBNull.Value ? null : objRow[convStudentInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvStudentInfoEN.IdXzMajor = objRow[convStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[convStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvStudentInfoEN.MajorID = objRow[convStudentInfo.MajorID] == DBNull.Value ? null : objRow[convStudentInfo.MajorID].ToString().Trim(); //专业ID
objvStudentInfoEN.MajorName = objRow[convStudentInfo.MajorName].ToString().Trim(); //专业名称
objvStudentInfoEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsNormal].ToString().Trim()); //IsNormal
objvStudentInfoEN.IdGradeBase = objRow[convStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objvStudentInfoEN.GradeBaseName = objRow[convStudentInfo.GradeBaseName] == DBNull.Value ? null : objRow[convStudentInfo.GradeBaseName].ToString().Trim(); //年级名称
objvStudentInfoEN.IdAdminCls = objRow[convStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objvStudentInfoEN.AdminClsName = objRow[convStudentInfo.AdminClsName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsName].ToString().Trim(); //行政班名称
objvStudentInfoEN.AdminClsId = objRow[convStudentInfo.AdminClsId] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsId].ToString().Trim(); //行政班代号
objvStudentInfoEN.IdAdminClsType = objRow[convStudentInfo.IdAdminClsType] == DBNull.Value ? null : objRow[convStudentInfo.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvStudentInfoEN.AdminClsTypeName = objRow[convStudentInfo.AdminClsTypeName] == DBNull.Value ? null : objRow[convStudentInfo.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvStudentInfoEN.Birthday = objRow[convStudentInfo.Birthday] == DBNull.Value ? null : objRow[convStudentInfo.Birthday].ToString().Trim(); //出生日期
objvStudentInfoEN.NativePlace = objRow[convStudentInfo.NativePlace] == DBNull.Value ? null : objRow[convStudentInfo.NativePlace].ToString().Trim(); //籍贯
objvStudentInfoEN.Duty = objRow[convStudentInfo.Duty] == DBNull.Value ? null : objRow[convStudentInfo.Duty].ToString().Trim(); //职位
objvStudentInfoEN.IdCardNo = objRow[convStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objvStudentInfoEN.StuCardNo = objRow[convStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[convStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objvStudentInfoEN.LiveAddress = objRow[convStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[convStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objvStudentInfoEN.HomePhone = objRow[convStudentInfo.HomePhone] == DBNull.Value ? null : objRow[convStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objvStudentInfoEN.IdCardNo2 = objRow[convStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[convStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objvStudentInfoEN.CardNo = objRow[convStudentInfo.CardNo] == DBNull.Value ? null : objRow[convStudentInfo.CardNo].ToString().Trim(); //卡号
objvStudentInfoEN.IsAvconClassUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconClassUser].ToString().Trim()); //IsAvconClassUser
objvStudentInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objvStudentInfoEN.UserId = objRow[convStudentInfo.UserId] == DBNull.Value ? null : objRow[convStudentInfo.UserId].ToString().Trim(); //用户ID
objvStudentInfoEN.UserId4Avcon = objRow[convStudentInfo.UserId4Avcon] == DBNull.Value ? null : objRow[convStudentInfo.UserId4Avcon].ToString().Trim(); //UserId4Avcon
objvStudentInfoEN.EnrollmentDate = objRow[convStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[convStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objvStudentInfoEN.PostCode = objRow[convStudentInfo.PostCode] == DBNull.Value ? null : objRow[convStudentInfo.PostCode].ToString().Trim(); //邮编
objvStudentInfoEN.Email = objRow[convStudentInfo.Email] == DBNull.Value ? null : objRow[convStudentInfo.Email].ToString().Trim(); //电子邮箱
objvStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objvStudentInfoEN.Microblog = objRow[convStudentInfo.Microblog] == DBNull.Value ? null : objRow[convStudentInfo.Microblog].ToString().Trim(); //Microblog
objvStudentInfoEN.PhoneNumber = objRow[convStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[convStudentInfo.PhoneNumber].ToString().Trim(); //电话
objvStudentInfoEN.QQ = objRow[convStudentInfo.QQ] == DBNull.Value ? null : objRow[convStudentInfo.QQ].ToString().Trim(); //QQ
objvStudentInfoEN.RegisterPassword = objRow[convStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[convStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvStudentInfoEN.UpdDate = objRow[convStudentInfo.UpdDate] == DBNull.Value ? null : objRow[convStudentInfo.UpdDate].ToString().Trim(); //修改日期
objvStudentInfoEN.UpdUser = objRow[convStudentInfo.UpdUser] == DBNull.Value ? null : objRow[convStudentInfo.UpdUser].ToString().Trim(); //修改人
objvStudentInfoEN.Memo = objRow[convStudentInfo.Memo] == DBNull.Value ? null : objRow[convStudentInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvStudentInfoEN.IdStudentInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvStudentInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvStudentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvStudentInfo(ref clsvStudentInfoEN objvStudentInfoEN)
{
bool bolResult = vStudentInfoDA.GetvStudentInfo(ref objvStudentInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvStudentInfoEN GetObjByIdStudentInfo(string strIdStudentInfo)
{
if (strIdStudentInfo.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdStudentInfo]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdStudentInfo]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvStudentInfoEN objvStudentInfoEN = vStudentInfoDA.GetObjByIdStudentInfo(strIdStudentInfo);
return objvStudentInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvStudentInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvStudentInfoEN objvStudentInfoEN = vStudentInfoDA.GetFirstObj(strWhereCond);
 return objvStudentInfoEN;
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
public static clsvStudentInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvStudentInfoEN objvStudentInfoEN = vStudentInfoDA.GetObjByDataRow(objRow);
 return objvStudentInfoEN;
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
public static clsvStudentInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvStudentInfoEN objvStudentInfoEN = vStudentInfoDA.GetObjByDataRow(objRow);
 return objvStudentInfoEN;
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
 /// <param name = "strIdStudentInfo">所给的关键字</param>
 /// <param name = "lstvStudentInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvStudentInfoEN GetObjByIdStudentInfoFromList(string strIdStudentInfo, List<clsvStudentInfoEN> lstvStudentInfoObjLst)
{
foreach (clsvStudentInfoEN objvStudentInfoEN in lstvStudentInfoObjLst)
{
if (objvStudentInfoEN.IdStudentInfo == strIdStudentInfo)
{
return objvStudentInfoEN;
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
 string strIdStudentInfo;
 try
 {
 strIdStudentInfo = new clsvStudentInfoDA().GetFirstID(strWhereCond);
 return strIdStudentInfo;
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
 arrList = vStudentInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vStudentInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdStudentInfo)
{
if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdStudentInfo]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vStudentInfoDA.IsExist(strIdStudentInfo);
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
 bolIsExist = clsvStudentInfoDA.IsExistTable();
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
 bolIsExist = vStudentInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvStudentInfoENS">源对象</param>
 /// <param name = "objvStudentInfoENT">目标对象</param>
 public static void CopyTo(clsvStudentInfoEN objvStudentInfoENS, clsvStudentInfoEN objvStudentInfoENT)
{
try
{
objvStudentInfoENT.IdStudentInfo = objvStudentInfoENS.IdStudentInfo; //学生流水号
objvStudentInfoENT.StuId = objvStudentInfoENS.StuId; //学号
objvStudentInfoENT.StuName = objvStudentInfoENS.StuName; //姓名
objvStudentInfoENT.IdPolitics = objvStudentInfoENS.IdPolitics; //政治面貌流水号
objvStudentInfoENT.PoliticsId = objvStudentInfoENS.PoliticsId; //政治面貌Id
objvStudentInfoENT.PoliticsName = objvStudentInfoENS.PoliticsName; //政治面貌
objvStudentInfoENT.IdSex = objvStudentInfoENS.IdSex; //性别流水号
objvStudentInfoENT.SexDesc = objvStudentInfoENS.SexDesc; //性别名称
objvStudentInfoENT.IdEthnic = objvStudentInfoENS.IdEthnic; //民族流水号
objvStudentInfoENT.EthnicId = objvStudentInfoENS.EthnicId; //民族Id
objvStudentInfoENT.EthnicName = objvStudentInfoENS.EthnicName; //民族名称
objvStudentInfoENT.IdUniZone = objvStudentInfoENS.IdUniZone; //校区流水号
objvStudentInfoENT.UniZoneDesc = objvStudentInfoENS.UniZoneDesc; //校区名称
objvStudentInfoENT.IdStuType = objvStudentInfoENS.IdStuType; //学生类别流水号
objvStudentInfoENT.StuTypeID = objvStudentInfoENS.StuTypeID; //学生类别ID
objvStudentInfoENT.StuTypeDesc = objvStudentInfoENS.StuTypeDesc; //学生类别名称
objvStudentInfoENT.IdXzCollege = objvStudentInfoENS.IdXzCollege; //学院流水号
objvStudentInfoENT.CollegeId = objvStudentInfoENS.CollegeId; //学院ID
objvStudentInfoENT.CollegeName = objvStudentInfoENS.CollegeName; //学院名称
objvStudentInfoENT.CollegeIdInGP = objvStudentInfoENS.CollegeIdInGP; //CollegeIdInGP
objvStudentInfoENT.CollegeNameA = objvStudentInfoENS.CollegeNameA; //学院名称简写
objvStudentInfoENT.IdXzMajor = objvStudentInfoENS.IdXzMajor; //专业流水号
objvStudentInfoENT.MajorID = objvStudentInfoENS.MajorID; //专业ID
objvStudentInfoENT.MajorName = objvStudentInfoENS.MajorName; //专业名称
objvStudentInfoENT.IsNormal = objvStudentInfoENS.IsNormal; //IsNormal
objvStudentInfoENT.IdGradeBase = objvStudentInfoENS.IdGradeBase; //年级流水号
objvStudentInfoENT.GradeBaseName = objvStudentInfoENS.GradeBaseName; //年级名称
objvStudentInfoENT.IdAdminCls = objvStudentInfoENS.IdAdminCls; //行政班流水号
objvStudentInfoENT.AdminClsName = objvStudentInfoENS.AdminClsName; //行政班名称
objvStudentInfoENT.AdminClsId = objvStudentInfoENS.AdminClsId; //行政班代号
objvStudentInfoENT.IdAdminClsType = objvStudentInfoENS.IdAdminClsType; //行政班级类型流水号
objvStudentInfoENT.AdminClsTypeName = objvStudentInfoENS.AdminClsTypeName; //行政班级类型名称
objvStudentInfoENT.Birthday = objvStudentInfoENS.Birthday; //出生日期
objvStudentInfoENT.NativePlace = objvStudentInfoENS.NativePlace; //籍贯
objvStudentInfoENT.Duty = objvStudentInfoENS.Duty; //职位
objvStudentInfoENT.IdCardNo = objvStudentInfoENS.IdCardNo; //身份证号
objvStudentInfoENT.StuCardNo = objvStudentInfoENS.StuCardNo; //学生证号
objvStudentInfoENT.LiveAddress = objvStudentInfoENS.LiveAddress; //居住地址
objvStudentInfoENT.HomePhone = objvStudentInfoENS.HomePhone; //住宅电话
objvStudentInfoENT.IdCardNo2 = objvStudentInfoENS.IdCardNo2; //内卡号
objvStudentInfoENT.CardNo = objvStudentInfoENS.CardNo; //卡号
objvStudentInfoENT.IsAvconClassUser = objvStudentInfoENS.IsAvconClassUser; //IsAvconClassUser
objvStudentInfoENT.IsAvconUser = objvStudentInfoENS.IsAvconUser; //IsAvconUser
objvStudentInfoENT.IsGpUser = objvStudentInfoENS.IsGpUser; //是否Gp用户
objvStudentInfoENT.IsLocalUser = objvStudentInfoENS.IsLocalUser; //是否本地用户
objvStudentInfoENT.IsLeaved = objvStudentInfoENS.IsLeaved; //是否离开
objvStudentInfoENT.UserId = objvStudentInfoENS.UserId; //用户ID
objvStudentInfoENT.UserId4Avcon = objvStudentInfoENS.UserId4Avcon; //UserId4Avcon
objvStudentInfoENT.EnrollmentDate = objvStudentInfoENS.EnrollmentDate; //入校日期
objvStudentInfoENT.PostCode = objvStudentInfoENS.PostCode; //邮编
objvStudentInfoENT.Email = objvStudentInfoENS.Email; //电子邮箱
objvStudentInfoENT.IsMessage = objvStudentInfoENS.IsMessage; //IsMessage
objvStudentInfoENT.Microblog = objvStudentInfoENS.Microblog; //Microblog
objvStudentInfoENT.PhoneNumber = objvStudentInfoENS.PhoneNumber; //电话
objvStudentInfoENT.QQ = objvStudentInfoENS.QQ; //QQ
objvStudentInfoENT.RegisterPassword = objvStudentInfoENS.RegisterPassword; //RegisterPassword
objvStudentInfoENT.UpdDate = objvStudentInfoENS.UpdDate; //修改日期
objvStudentInfoENT.UpdUser = objvStudentInfoENS.UpdUser; //修改人
objvStudentInfoENT.Memo = objvStudentInfoENS.Memo; //备注
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
 /// <param name = "objvStudentInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvStudentInfoEN objvStudentInfoEN)
{
try
{
objvStudentInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvStudentInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convStudentInfo.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdStudentInfo = objvStudentInfoEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convStudentInfo.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.StuId = objvStudentInfoEN.StuId; //学号
}
if (arrFldSet.Contains(convStudentInfo.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.StuName = objvStudentInfoEN.StuName; //姓名
}
if (arrFldSet.Contains(convStudentInfo.IdPolitics, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdPolitics = objvStudentInfoEN.IdPolitics; //政治面貌流水号
}
if (arrFldSet.Contains(convStudentInfo.PoliticsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.PoliticsId = objvStudentInfoEN.PoliticsId == "[null]" ? null :  objvStudentInfoEN.PoliticsId; //政治面貌Id
}
if (arrFldSet.Contains(convStudentInfo.PoliticsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.PoliticsName = objvStudentInfoEN.PoliticsName; //政治面貌
}
if (arrFldSet.Contains(convStudentInfo.IdSex, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdSex = objvStudentInfoEN.IdSex; //性别流水号
}
if (arrFldSet.Contains(convStudentInfo.SexDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.SexDesc = objvStudentInfoEN.SexDesc == "[null]" ? null :  objvStudentInfoEN.SexDesc; //性别名称
}
if (arrFldSet.Contains(convStudentInfo.IdEthnic, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdEthnic = objvStudentInfoEN.IdEthnic; //民族流水号
}
if (arrFldSet.Contains(convStudentInfo.EthnicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.EthnicId = objvStudentInfoEN.EthnicId == "[null]" ? null :  objvStudentInfoEN.EthnicId; //民族Id
}
if (arrFldSet.Contains(convStudentInfo.EthnicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.EthnicName = objvStudentInfoEN.EthnicName == "[null]" ? null :  objvStudentInfoEN.EthnicName; //民族名称
}
if (arrFldSet.Contains(convStudentInfo.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdUniZone = objvStudentInfoEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(convStudentInfo.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.UniZoneDesc = objvStudentInfoEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(convStudentInfo.IdStuType, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdStuType = objvStudentInfoEN.IdStuType == "[null]" ? null :  objvStudentInfoEN.IdStuType; //学生类别流水号
}
if (arrFldSet.Contains(convStudentInfo.StuTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.StuTypeID = objvStudentInfoEN.StuTypeID == "[null]" ? null :  objvStudentInfoEN.StuTypeID; //学生类别ID
}
if (arrFldSet.Contains(convStudentInfo.StuTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.StuTypeDesc = objvStudentInfoEN.StuTypeDesc == "[null]" ? null :  objvStudentInfoEN.StuTypeDesc; //学生类别名称
}
if (arrFldSet.Contains(convStudentInfo.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdXzCollege = objvStudentInfoEN.IdXzCollege == "[null]" ? null :  objvStudentInfoEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convStudentInfo.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.CollegeId = objvStudentInfoEN.CollegeId == "[null]" ? null :  objvStudentInfoEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convStudentInfo.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.CollegeName = objvStudentInfoEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convStudentInfo.CollegeIdInGP, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.CollegeIdInGP = objvStudentInfoEN.CollegeIdInGP == "[null]" ? null :  objvStudentInfoEN.CollegeIdInGP; //CollegeIdInGP
}
if (arrFldSet.Contains(convStudentInfo.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.CollegeNameA = objvStudentInfoEN.CollegeNameA == "[null]" ? null :  objvStudentInfoEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convStudentInfo.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdXzMajor = objvStudentInfoEN.IdXzMajor == "[null]" ? null :  objvStudentInfoEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convStudentInfo.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.MajorID = objvStudentInfoEN.MajorID == "[null]" ? null :  objvStudentInfoEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convStudentInfo.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.MajorName = objvStudentInfoEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convStudentInfo.IsNormal, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IsNormal = objvStudentInfoEN.IsNormal; //IsNormal
}
if (arrFldSet.Contains(convStudentInfo.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdGradeBase = objvStudentInfoEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convStudentInfo.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.GradeBaseName = objvStudentInfoEN.GradeBaseName == "[null]" ? null :  objvStudentInfoEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convStudentInfo.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdAdminCls = objvStudentInfoEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(convStudentInfo.AdminClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.AdminClsName = objvStudentInfoEN.AdminClsName == "[null]" ? null :  objvStudentInfoEN.AdminClsName; //行政班名称
}
if (arrFldSet.Contains(convStudentInfo.AdminClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.AdminClsId = objvStudentInfoEN.AdminClsId == "[null]" ? null :  objvStudentInfoEN.AdminClsId; //行政班代号
}
if (arrFldSet.Contains(convStudentInfo.IdAdminClsType, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdAdminClsType = objvStudentInfoEN.IdAdminClsType == "[null]" ? null :  objvStudentInfoEN.IdAdminClsType; //行政班级类型流水号
}
if (arrFldSet.Contains(convStudentInfo.AdminClsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.AdminClsTypeName = objvStudentInfoEN.AdminClsTypeName == "[null]" ? null :  objvStudentInfoEN.AdminClsTypeName; //行政班级类型名称
}
if (arrFldSet.Contains(convStudentInfo.Birthday, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.Birthday = objvStudentInfoEN.Birthday == "[null]" ? null :  objvStudentInfoEN.Birthday; //出生日期
}
if (arrFldSet.Contains(convStudentInfo.NativePlace, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.NativePlace = objvStudentInfoEN.NativePlace == "[null]" ? null :  objvStudentInfoEN.NativePlace; //籍贯
}
if (arrFldSet.Contains(convStudentInfo.Duty, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.Duty = objvStudentInfoEN.Duty == "[null]" ? null :  objvStudentInfoEN.Duty; //职位
}
if (arrFldSet.Contains(convStudentInfo.IdCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdCardNo = objvStudentInfoEN.IdCardNo == "[null]" ? null :  objvStudentInfoEN.IdCardNo; //身份证号
}
if (arrFldSet.Contains(convStudentInfo.StuCardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.StuCardNo = objvStudentInfoEN.StuCardNo == "[null]" ? null :  objvStudentInfoEN.StuCardNo; //学生证号
}
if (arrFldSet.Contains(convStudentInfo.LiveAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.LiveAddress = objvStudentInfoEN.LiveAddress == "[null]" ? null :  objvStudentInfoEN.LiveAddress; //居住地址
}
if (arrFldSet.Contains(convStudentInfo.HomePhone, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.HomePhone = objvStudentInfoEN.HomePhone == "[null]" ? null :  objvStudentInfoEN.HomePhone; //住宅电话
}
if (arrFldSet.Contains(convStudentInfo.IdCardNo2, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IdCardNo2 = objvStudentInfoEN.IdCardNo2 == "[null]" ? null :  objvStudentInfoEN.IdCardNo2; //内卡号
}
if (arrFldSet.Contains(convStudentInfo.CardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.CardNo = objvStudentInfoEN.CardNo == "[null]" ? null :  objvStudentInfoEN.CardNo; //卡号
}
if (arrFldSet.Contains(convStudentInfo.IsAvconClassUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IsAvconClassUser = objvStudentInfoEN.IsAvconClassUser; //IsAvconClassUser
}
if (arrFldSet.Contains(convStudentInfo.IsAvconUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IsAvconUser = objvStudentInfoEN.IsAvconUser; //IsAvconUser
}
if (arrFldSet.Contains(convStudentInfo.IsGpUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IsGpUser = objvStudentInfoEN.IsGpUser; //是否Gp用户
}
if (arrFldSet.Contains(convStudentInfo.IsLocalUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IsLocalUser = objvStudentInfoEN.IsLocalUser; //是否本地用户
}
if (arrFldSet.Contains(convStudentInfo.IsLeaved, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IsLeaved = objvStudentInfoEN.IsLeaved; //是否离开
}
if (arrFldSet.Contains(convStudentInfo.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.UserId = objvStudentInfoEN.UserId == "[null]" ? null :  objvStudentInfoEN.UserId; //用户ID
}
if (arrFldSet.Contains(convStudentInfo.UserId4Avcon, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.UserId4Avcon = objvStudentInfoEN.UserId4Avcon == "[null]" ? null :  objvStudentInfoEN.UserId4Avcon; //UserId4Avcon
}
if (arrFldSet.Contains(convStudentInfo.EnrollmentDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.EnrollmentDate = objvStudentInfoEN.EnrollmentDate == "[null]" ? null :  objvStudentInfoEN.EnrollmentDate; //入校日期
}
if (arrFldSet.Contains(convStudentInfo.PostCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.PostCode = objvStudentInfoEN.PostCode == "[null]" ? null :  objvStudentInfoEN.PostCode; //邮编
}
if (arrFldSet.Contains(convStudentInfo.Email, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.Email = objvStudentInfoEN.Email == "[null]" ? null :  objvStudentInfoEN.Email; //电子邮箱
}
if (arrFldSet.Contains(convStudentInfo.IsMessage, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.IsMessage = objvStudentInfoEN.IsMessage; //IsMessage
}
if (arrFldSet.Contains(convStudentInfo.Microblog, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.Microblog = objvStudentInfoEN.Microblog == "[null]" ? null :  objvStudentInfoEN.Microblog; //Microblog
}
if (arrFldSet.Contains(convStudentInfo.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.PhoneNumber = objvStudentInfoEN.PhoneNumber == "[null]" ? null :  objvStudentInfoEN.PhoneNumber; //电话
}
if (arrFldSet.Contains(convStudentInfo.QQ, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.QQ = objvStudentInfoEN.QQ == "[null]" ? null :  objvStudentInfoEN.QQ; //QQ
}
if (arrFldSet.Contains(convStudentInfo.RegisterPassword, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.RegisterPassword = objvStudentInfoEN.RegisterPassword == "[null]" ? null :  objvStudentInfoEN.RegisterPassword; //RegisterPassword
}
if (arrFldSet.Contains(convStudentInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.UpdDate = objvStudentInfoEN.UpdDate == "[null]" ? null :  objvStudentInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convStudentInfo.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.UpdUser = objvStudentInfoEN.UpdUser == "[null]" ? null :  objvStudentInfoEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convStudentInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvStudentInfoEN.Memo = objvStudentInfoEN.Memo == "[null]" ? null :  objvStudentInfoEN.Memo; //备注
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
 /// <param name = "objvStudentInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvStudentInfoEN objvStudentInfoEN)
{
try
{
if (objvStudentInfoEN.PoliticsId == "[null]") objvStudentInfoEN.PoliticsId = null; //政治面貌Id
if (objvStudentInfoEN.SexDesc == "[null]") objvStudentInfoEN.SexDesc = null; //性别名称
if (objvStudentInfoEN.EthnicId == "[null]") objvStudentInfoEN.EthnicId = null; //民族Id
if (objvStudentInfoEN.EthnicName == "[null]") objvStudentInfoEN.EthnicName = null; //民族名称
if (objvStudentInfoEN.IdStuType == "[null]") objvStudentInfoEN.IdStuType = null; //学生类别流水号
if (objvStudentInfoEN.StuTypeID == "[null]") objvStudentInfoEN.StuTypeID = null; //学生类别ID
if (objvStudentInfoEN.StuTypeDesc == "[null]") objvStudentInfoEN.StuTypeDesc = null; //学生类别名称
if (objvStudentInfoEN.IdXzCollege == "[null]") objvStudentInfoEN.IdXzCollege = null; //学院流水号
if (objvStudentInfoEN.CollegeId == "[null]") objvStudentInfoEN.CollegeId = null; //学院ID
if (objvStudentInfoEN.CollegeIdInGP == "[null]") objvStudentInfoEN.CollegeIdInGP = null; //CollegeIdInGP
if (objvStudentInfoEN.CollegeNameA == "[null]") objvStudentInfoEN.CollegeNameA = null; //学院名称简写
if (objvStudentInfoEN.IdXzMajor == "[null]") objvStudentInfoEN.IdXzMajor = null; //专业流水号
if (objvStudentInfoEN.MajorID == "[null]") objvStudentInfoEN.MajorID = null; //专业ID
if (objvStudentInfoEN.GradeBaseName == "[null]") objvStudentInfoEN.GradeBaseName = null; //年级名称
if (objvStudentInfoEN.AdminClsName == "[null]") objvStudentInfoEN.AdminClsName = null; //行政班名称
if (objvStudentInfoEN.AdminClsId == "[null]") objvStudentInfoEN.AdminClsId = null; //行政班代号
if (objvStudentInfoEN.IdAdminClsType == "[null]") objvStudentInfoEN.IdAdminClsType = null; //行政班级类型流水号
if (objvStudentInfoEN.AdminClsTypeName == "[null]") objvStudentInfoEN.AdminClsTypeName = null; //行政班级类型名称
if (objvStudentInfoEN.Birthday == "[null]") objvStudentInfoEN.Birthday = null; //出生日期
if (objvStudentInfoEN.NativePlace == "[null]") objvStudentInfoEN.NativePlace = null; //籍贯
if (objvStudentInfoEN.Duty == "[null]") objvStudentInfoEN.Duty = null; //职位
if (objvStudentInfoEN.IdCardNo == "[null]") objvStudentInfoEN.IdCardNo = null; //身份证号
if (objvStudentInfoEN.StuCardNo == "[null]") objvStudentInfoEN.StuCardNo = null; //学生证号
if (objvStudentInfoEN.LiveAddress == "[null]") objvStudentInfoEN.LiveAddress = null; //居住地址
if (objvStudentInfoEN.HomePhone == "[null]") objvStudentInfoEN.HomePhone = null; //住宅电话
if (objvStudentInfoEN.IdCardNo2 == "[null]") objvStudentInfoEN.IdCardNo2 = null; //内卡号
if (objvStudentInfoEN.CardNo == "[null]") objvStudentInfoEN.CardNo = null; //卡号
if (objvStudentInfoEN.UserId == "[null]") objvStudentInfoEN.UserId = null; //用户ID
if (objvStudentInfoEN.UserId4Avcon == "[null]") objvStudentInfoEN.UserId4Avcon = null; //UserId4Avcon
if (objvStudentInfoEN.EnrollmentDate == "[null]") objvStudentInfoEN.EnrollmentDate = null; //入校日期
if (objvStudentInfoEN.PostCode == "[null]") objvStudentInfoEN.PostCode = null; //邮编
if (objvStudentInfoEN.Email == "[null]") objvStudentInfoEN.Email = null; //电子邮箱
if (objvStudentInfoEN.Microblog == "[null]") objvStudentInfoEN.Microblog = null; //Microblog
if (objvStudentInfoEN.PhoneNumber == "[null]") objvStudentInfoEN.PhoneNumber = null; //电话
if (objvStudentInfoEN.QQ == "[null]") objvStudentInfoEN.QQ = null; //QQ
if (objvStudentInfoEN.RegisterPassword == "[null]") objvStudentInfoEN.RegisterPassword = null; //RegisterPassword
if (objvStudentInfoEN.UpdDate == "[null]") objvStudentInfoEN.UpdDate = null; //修改日期
if (objvStudentInfoEN.UpdUser == "[null]") objvStudentInfoEN.UpdUser = null; //修改人
if (objvStudentInfoEN.Memo == "[null]") objvStudentInfoEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvStudentInfoEN objvStudentInfoEN)
{
 vStudentInfoDA.CheckProperty4Condition(objvStudentInfoEN);
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
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeBL没有刷新缓存机制(clsRsStuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeBL没有刷新缓存机制(clsXzAdminClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdStudentInfo");
//if (arrvStudentInfoObjLstCache == null)
//{
//arrvStudentInfoObjLstCache = vStudentInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdStudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvStudentInfoEN GetObjByIdStudentInfoCache(string strIdStudentInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvStudentInfoEN._CurrTabName);
List<clsvStudentInfoEN> arrvStudentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvStudentInfoEN> arrvStudentInfoObjLst_Sel =
arrvStudentInfoObjLstCache
.Where(x=> x.IdStudentInfo == strIdStudentInfo 
);
if (arrvStudentInfoObjLst_Sel.Count() == 0)
{
   clsvStudentInfoEN obj = clsvStudentInfoBL.GetObjByIdStudentInfo(strIdStudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvStudentInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvStudentInfoEN> GetAllvStudentInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvStudentInfoEN> arrvStudentInfoObjLstCache = GetObjLstCache(); 
return arrvStudentInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvStudentInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvStudentInfoEN._CurrTabName);
List<clsvStudentInfoEN> arrvStudentInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvStudentInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvStudentInfoEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdStudentInfo)
{
if (strInFldName != convStudentInfo.IdStudentInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convStudentInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convStudentInfo.AttributeName));
throw new Exception(strMsg);
}
var objvStudentInfo = clsvStudentInfoBL.GetObjByIdStudentInfoCache(strIdStudentInfo);
if (objvStudentInfo == null) return "";
return objvStudentInfo[strOutFldName].ToString();
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
int intRecCount = clsvStudentInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvStudentInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvStudentInfoDA.GetRecCount();
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
int intRecCount = clsvStudentInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvStudentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvStudentInfoEN objvStudentInfoCond)
{
List<clsvStudentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvStudentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convStudentInfo.AttributeName)
{
if (objvStudentInfoCond.IsUpdated(strFldName) == false) continue;
if (objvStudentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvStudentInfoCond[strFldName].ToString());
}
else
{
if (objvStudentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvStudentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvStudentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvStudentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvStudentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvStudentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvStudentInfoCond[strFldName]));
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
 List<string> arrList = clsvStudentInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vStudentInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vStudentInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}