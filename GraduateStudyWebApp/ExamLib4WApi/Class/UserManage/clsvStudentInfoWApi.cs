
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvStudentInfoWApi
 表名:vStudentInfo(01120132)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:59
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
public static class clsvStudentInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_StudentInfo(this clsvStudentInfoEN objvStudentInfoEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convStudentInfo.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convStudentInfo.id_StudentInfo);
objvStudentInfoEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_StudentInfo) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_StudentInfo, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_StudentInfo] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetStuID(this clsvStudentInfoEN objvStudentInfoEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuID, convStudentInfo.StuID);
clsCheckSql.CheckFieldLen(strStuID, 20, convStudentInfo.StuID);
objvStudentInfoEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.StuID) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.StuID, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.StuID] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetStuName(this clsvStudentInfoEN objvStudentInfoEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuName, convStudentInfo.StuName);
clsCheckSql.CheckFieldLen(strStuName, 50, convStudentInfo.StuName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_Politics(this clsvStudentInfoEN objvStudentInfoEN, string strid_Politics, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Politics, convStudentInfo.id_Politics);
clsCheckSql.CheckFieldLen(strid_Politics, 4, convStudentInfo.id_Politics);
clsCheckSql.CheckFieldForeignKey(strid_Politics, 4, convStudentInfo.id_Politics);
objvStudentInfoEN.id_Politics = strid_Politics; //政治面貌流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_Politics) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_Politics, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_Politics] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetPoliticsID(this clsvStudentInfoEN objvStudentInfoEN, string strPoliticsID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsID, 4, convStudentInfo.PoliticsID);
objvStudentInfoEN.PoliticsID = strPoliticsID; //政治面貌ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.PoliticsID) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.PoliticsID, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.PoliticsID] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetPoliticsName(this clsvStudentInfoEN objvStudentInfoEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPoliticsName, convStudentInfo.PoliticsName);
clsCheckSql.CheckFieldLen(strPoliticsName, 30, convStudentInfo.PoliticsName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_Sex(this clsvStudentInfoEN objvStudentInfoEN, string strid_Sex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Sex, convStudentInfo.id_Sex);
clsCheckSql.CheckFieldLen(strid_Sex, 4, convStudentInfo.id_Sex);
clsCheckSql.CheckFieldForeignKey(strid_Sex, 4, convStudentInfo.id_Sex);
objvStudentInfoEN.id_Sex = strid_Sex; //性别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_Sex) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_Sex, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_Sex] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetSexDesc(this clsvStudentInfoEN objvStudentInfoEN, string strSexDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSexDesc, 10, convStudentInfo.SexDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_Ethnic(this clsvStudentInfoEN objvStudentInfoEN, string strid_Ethnic, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Ethnic, convStudentInfo.id_Ethnic);
clsCheckSql.CheckFieldLen(strid_Ethnic, 4, convStudentInfo.id_Ethnic);
clsCheckSql.CheckFieldForeignKey(strid_Ethnic, 4, convStudentInfo.id_Ethnic);
objvStudentInfoEN.id_Ethnic = strid_Ethnic; //民族流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_Ethnic) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_Ethnic, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_Ethnic] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetEthnicID(this clsvStudentInfoEN objvStudentInfoEN, string strEthnicID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicID, 4, convStudentInfo.EthnicID);
clsCheckSql.CheckFieldForeignKey(strEthnicID, 4, convStudentInfo.EthnicID);
objvStudentInfoEN.EthnicID = strEthnicID; //民族ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.EthnicID) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.EthnicID, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.EthnicID] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetEthnicName(this clsvStudentInfoEN objvStudentInfoEN, string strEthnicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEthnicName, 30, convStudentInfo.EthnicName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_UniZone(this clsvStudentInfoEN objvStudentInfoEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_UniZone, convStudentInfo.id_UniZone);
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convStudentInfo.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convStudentInfo.id_UniZone);
objvStudentInfoEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_UniZone) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_UniZone, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_UniZone] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetUniZoneDesc(this clsvStudentInfoEN objvStudentInfoEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUniZoneDesc, convStudentInfo.UniZoneDesc);
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, convStudentInfo.UniZoneDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_StuType(this clsvStudentInfoEN objvStudentInfoEN, string strid_StuType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StuType, 4, convStudentInfo.id_StuType);
clsCheckSql.CheckFieldForeignKey(strid_StuType, 4, convStudentInfo.id_StuType);
objvStudentInfoEN.id_StuType = strid_StuType; //学生类别流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_StuType) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_StuType, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_StuType] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetStuTypeID(this clsvStudentInfoEN objvStudentInfoEN, string strStuTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeID, 4, convStudentInfo.StuTypeID);
clsCheckSql.CheckFieldForeignKey(strStuTypeID, 4, convStudentInfo.StuTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetStuTypeDesc(this clsvStudentInfoEN objvStudentInfoEN, string strStuTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTypeDesc, 50, convStudentInfo.StuTypeDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_XzCollege(this clsvStudentInfoEN objvStudentInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convStudentInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convStudentInfo.id_XzCollege);
objvStudentInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_XzCollege) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_XzCollege, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_XzCollege] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetCollegeID(this clsvStudentInfoEN objvStudentInfoEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convStudentInfo.CollegeID);
objvStudentInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.CollegeID) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.CollegeID, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.CollegeID] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetCollegeName(this clsvStudentInfoEN objvStudentInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convStudentInfo.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convStudentInfo.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetCollegeIdInGP(this clsvStudentInfoEN objvStudentInfoEN, string strCollegeIdInGP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeIdInGP, 6, convStudentInfo.CollegeIdInGP);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetCollegeNameA(this clsvStudentInfoEN objvStudentInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convStudentInfo.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_XzMajor(this clsvStudentInfoEN objvStudentInfoEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convStudentInfo.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convStudentInfo.id_XzMajor);
objvStudentInfoEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_XzMajor) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_XzMajor, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_XzMajor] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetMajorID(this clsvStudentInfoEN objvStudentInfoEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convStudentInfo.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convStudentInfo.MajorID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetMajorName(this clsvStudentInfoEN objvStudentInfoEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convStudentInfo.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convStudentInfo.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_GradeBase(this clsvStudentInfoEN objvStudentInfoEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_GradeBase, convStudentInfo.id_GradeBase);
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convStudentInfo.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convStudentInfo.id_GradeBase);
objvStudentInfoEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_GradeBase) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_GradeBase, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_GradeBase] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetGradeBaseName(this clsvStudentInfoEN objvStudentInfoEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convStudentInfo.GradeBaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_AdminCls(this clsvStudentInfoEN objvStudentInfoEN, string strid_AdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AdminCls, convStudentInfo.id_AdminCls);
clsCheckSql.CheckFieldLen(strid_AdminCls, 8, convStudentInfo.id_AdminCls);
clsCheckSql.CheckFieldForeignKey(strid_AdminCls, 8, convStudentInfo.id_AdminCls);
objvStudentInfoEN.id_AdminCls = strid_AdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_AdminCls) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_AdminCls, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_AdminCls] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetAdminClsName(this clsvStudentInfoEN objvStudentInfoEN, string strAdminClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, convStudentInfo.AdminClsName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetAdminClsId(this clsvStudentInfoEN objvStudentInfoEN, string strAdminClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, convStudentInfo.AdminClsId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN Setid_AdminClsType(this clsvStudentInfoEN objvStudentInfoEN, string strid_AdminClsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AdminClsType, 4, convStudentInfo.id_AdminClsType);
clsCheckSql.CheckFieldForeignKey(strid_AdminClsType, 4, convStudentInfo.id_AdminClsType);
objvStudentInfoEN.id_AdminClsType = strid_AdminClsType; //行政班级类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.id_AdminClsType) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.id_AdminClsType, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.id_AdminClsType] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetAdminClsTypeName(this clsvStudentInfoEN objvStudentInfoEN, string strAdminClsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAdminClsTypeName, 30, convStudentInfo.AdminClsTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetBirthday(this clsvStudentInfoEN objvStudentInfoEN, string strBirthday, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBirthday, 8, convStudentInfo.Birthday);
clsCheckSql.CheckFieldForeignKey(strBirthday, 8, convStudentInfo.Birthday);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetNativePlace(this clsvStudentInfoEN objvStudentInfoEN, string strNativePlace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNativePlace, 200, convStudentInfo.NativePlace);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetDuty(this clsvStudentInfoEN objvStudentInfoEN, string strDuty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDuty, 30, convStudentInfo.Duty);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetIDCardNo(this clsvStudentInfoEN objvStudentInfoEN, string strIDCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIDCardNo, 20, convStudentInfo.IDCardNo);
objvStudentInfoEN.IDCardNo = strIDCardNo; //身份证号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.IDCardNo) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.IDCardNo, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.IDCardNo] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetStuCardNo(this clsvStudentInfoEN objvStudentInfoEN, string strStuCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuCardNo, 20, convStudentInfo.StuCardNo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetLiveAddress(this clsvStudentInfoEN objvStudentInfoEN, string strLiveAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiveAddress, 200, convStudentInfo.LiveAddress);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetHomePhone(this clsvStudentInfoEN objvStudentInfoEN, string strHomePhone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomePhone, 20, convStudentInfo.HomePhone);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetId_CardNo(this clsvStudentInfoEN objvStudentInfoEN, string strId_CardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CardNo, 20, convStudentInfo.Id_CardNo);
objvStudentInfoEN.Id_CardNo = strId_CardNo; //内卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.Id_CardNo) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.Id_CardNo, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.Id_CardNo] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetCardNo(this clsvStudentInfoEN objvStudentInfoEN, string strCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCardNo, 18, convStudentInfo.CardNo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetIsLeaved(this clsvStudentInfoEN objvStudentInfoEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvStudentInfoEN.IsLeaved = bolIsLeaved; //IsLeaved
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetUserId(this clsvStudentInfoEN objvStudentInfoEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convStudentInfo.UserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetUserID4Avcon(this clsvStudentInfoEN objvStudentInfoEN, string strUserID4Avcon, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserID4Avcon, 20, convStudentInfo.UserID4Avcon);
objvStudentInfoEN.UserID4Avcon = strUserID4Avcon; //UserID4Avcon
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfoEN.dicFldComparisonOp.ContainsKey(convStudentInfo.UserID4Avcon) == false)
{
objvStudentInfoEN.dicFldComparisonOp.Add(convStudentInfo.UserID4Avcon, strComparisonOp);
}
else
{
objvStudentInfoEN.dicFldComparisonOp[convStudentInfo.UserID4Avcon] = strComparisonOp;
}
}
return objvStudentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetEnrollmentDate(this clsvStudentInfoEN objvStudentInfoEN, string strEnrollmentDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnrollmentDate, 8, convStudentInfo.EnrollmentDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetPostCode(this clsvStudentInfoEN objvStudentInfoEN, string strPostCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPostCode, 6, convStudentInfo.PostCode);
clsCheckSql.CheckFieldForeignKey(strPostCode, 6, convStudentInfo.PostCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetEmail(this clsvStudentInfoEN objvStudentInfoEN, string strEmail, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEmail, 100, convStudentInfo.Email);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetMicroblog(this clsvStudentInfoEN objvStudentInfoEN, string strMicroblog, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroblog, 200, convStudentInfo.Microblog);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetPhoneNumber(this clsvStudentInfoEN objvStudentInfoEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convStudentInfo.PhoneNumber);
objvStudentInfoEN.PhoneNumber = strPhoneNumber; //PhoneNumber
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetQQ(this clsvStudentInfoEN objvStudentInfoEN, string strQQ, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQQ, 100, convStudentInfo.QQ);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetRegisterPassword(this clsvStudentInfoEN objvStudentInfoEN, string strRegisterPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegisterPassword, 30, convStudentInfo.RegisterPassword);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetUpdDate(this clsvStudentInfoEN objvStudentInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convStudentInfo.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetUpdUser(this clsvStudentInfoEN objvStudentInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convStudentInfo.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfoEN SetMemo(this clsvStudentInfoEN objvStudentInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convStudentInfo.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvStudentInfoEN objvStudentInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_StudentInfo, objvStudentInfo_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.StuID) == true)
{
string strComparisonOp_StuID = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuID, objvStudentInfo_Cond.StuID, strComparisonOp_StuID);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.StuName) == true)
{
string strComparisonOp_StuName = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuName, objvStudentInfo_Cond.StuName, strComparisonOp_StuName);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_Politics) == true)
{
string strComparisonOp_id_Politics = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_Politics];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_Politics, objvStudentInfo_Cond.id_Politics, strComparisonOp_id_Politics);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.PoliticsID) == true)
{
string strComparisonOp_PoliticsID = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.PoliticsID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.PoliticsID, objvStudentInfo_Cond.PoliticsID, strComparisonOp_PoliticsID);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.PoliticsName, objvStudentInfo_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_Sex) == true)
{
string strComparisonOp_id_Sex = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_Sex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_Sex, objvStudentInfo_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.SexDesc) == true)
{
string strComparisonOp_SexDesc = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.SexDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.SexDesc, objvStudentInfo_Cond.SexDesc, strComparisonOp_SexDesc);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_Ethnic) == true)
{
string strComparisonOp_id_Ethnic = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_Ethnic];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_Ethnic, objvStudentInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.EthnicID) == true)
{
string strComparisonOp_EthnicID = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.EthnicID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.EthnicID, objvStudentInfo_Cond.EthnicID, strComparisonOp_EthnicID);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.EthnicName) == true)
{
string strComparisonOp_EthnicName = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.EthnicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.EthnicName, objvStudentInfo_Cond.EthnicName, strComparisonOp_EthnicName);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_UniZone, objvStudentInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UniZoneDesc, objvStudentInfo_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_StuType) == true)
{
string strComparisonOp_id_StuType = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_StuType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_StuType, objvStudentInfo_Cond.id_StuType, strComparisonOp_id_StuType);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.StuTypeID) == true)
{
string strComparisonOp_StuTypeID = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.StuTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuTypeID, objvStudentInfo_Cond.StuTypeID, strComparisonOp_StuTypeID);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.StuTypeDesc) == true)
{
string strComparisonOp_StuTypeDesc = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.StuTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuTypeDesc, objvStudentInfo_Cond.StuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_XzCollege, objvStudentInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CollegeID, objvStudentInfo_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CollegeName, objvStudentInfo_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.CollegeIdInGP) == true)
{
string strComparisonOp_CollegeIdInGP = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.CollegeIdInGP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CollegeIdInGP, objvStudentInfo_Cond.CollegeIdInGP, strComparisonOp_CollegeIdInGP);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CollegeNameA, objvStudentInfo_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_XzMajor, objvStudentInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.MajorID) == true)
{
string strComparisonOp_MajorID = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.MajorID, objvStudentInfo_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.MajorName) == true)
{
string strComparisonOp_MajorName = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.MajorName, objvStudentInfo_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.IsNormal) == true)
{
if (objvStudentInfo_Cond.IsNormal == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsNormal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsNormal);
}
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_GradeBase, objvStudentInfo_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.GradeBaseName, objvStudentInfo_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_AdminCls) == true)
{
string strComparisonOp_id_AdminCls = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_AdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_AdminCls, objvStudentInfo_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.AdminClsName) == true)
{
string strComparisonOp_AdminClsName = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.AdminClsName, objvStudentInfo_Cond.AdminClsName, strComparisonOp_AdminClsName);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.AdminClsId) == true)
{
string strComparisonOp_AdminClsId = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.AdminClsId, objvStudentInfo_Cond.AdminClsId, strComparisonOp_AdminClsId);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.id_AdminClsType) == true)
{
string strComparisonOp_id_AdminClsType = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.id_AdminClsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.id_AdminClsType, objvStudentInfo_Cond.id_AdminClsType, strComparisonOp_id_AdminClsType);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.AdminClsTypeName) == true)
{
string strComparisonOp_AdminClsTypeName = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.AdminClsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.AdminClsTypeName, objvStudentInfo_Cond.AdminClsTypeName, strComparisonOp_AdminClsTypeName);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.Birthday) == true)
{
string strComparisonOp_Birthday = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.Birthday];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Birthday, objvStudentInfo_Cond.Birthday, strComparisonOp_Birthday);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.NativePlace) == true)
{
string strComparisonOp_NativePlace = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.NativePlace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.NativePlace, objvStudentInfo_Cond.NativePlace, strComparisonOp_NativePlace);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.Duty) == true)
{
string strComparisonOp_Duty = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.Duty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Duty, objvStudentInfo_Cond.Duty, strComparisonOp_Duty);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.IDCardNo) == true)
{
string strComparisonOp_IDCardNo = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.IDCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.IDCardNo, objvStudentInfo_Cond.IDCardNo, strComparisonOp_IDCardNo);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.StuCardNo) == true)
{
string strComparisonOp_StuCardNo = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.StuCardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.StuCardNo, objvStudentInfo_Cond.StuCardNo, strComparisonOp_StuCardNo);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.LiveAddress) == true)
{
string strComparisonOp_LiveAddress = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.LiveAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.LiveAddress, objvStudentInfo_Cond.LiveAddress, strComparisonOp_LiveAddress);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.HomePhone) == true)
{
string strComparisonOp_HomePhone = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.HomePhone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.HomePhone, objvStudentInfo_Cond.HomePhone, strComparisonOp_HomePhone);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.Id_CardNo) == true)
{
string strComparisonOp_Id_CardNo = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.Id_CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Id_CardNo, objvStudentInfo_Cond.Id_CardNo, strComparisonOp_Id_CardNo);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.CardNo) == true)
{
string strComparisonOp_CardNo = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.CardNo, objvStudentInfo_Cond.CardNo, strComparisonOp_CardNo);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.IsAvconClassUser) == true)
{
if (objvStudentInfo_Cond.IsAvconClassUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsAvconClassUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsAvconClassUser);
}
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.IsAvconUser) == true)
{
if (objvStudentInfo_Cond.IsAvconUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsAvconUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsAvconUser);
}
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.IsGpUser) == true)
{
if (objvStudentInfo_Cond.IsGpUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsGpUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsGpUser);
}
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.IsLocalUser) == true)
{
if (objvStudentInfo_Cond.IsLocalUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsLocalUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsLocalUser);
}
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.IsLeaved) == true)
{
if (objvStudentInfo_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsLeaved);
}
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.UserId) == true)
{
string strComparisonOp_UserId = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UserId, objvStudentInfo_Cond.UserId, strComparisonOp_UserId);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.UserID4Avcon) == true)
{
string strComparisonOp_UserID4Avcon = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.UserID4Avcon];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UserID4Avcon, objvStudentInfo_Cond.UserID4Avcon, strComparisonOp_UserID4Avcon);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.EnrollmentDate) == true)
{
string strComparisonOp_EnrollmentDate = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.EnrollmentDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.EnrollmentDate, objvStudentInfo_Cond.EnrollmentDate, strComparisonOp_EnrollmentDate);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.PostCode) == true)
{
string strComparisonOp_PostCode = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.PostCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.PostCode, objvStudentInfo_Cond.PostCode, strComparisonOp_PostCode);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.Email) == true)
{
string strComparisonOp_Email = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.Email];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Email, objvStudentInfo_Cond.Email, strComparisonOp_Email);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.IsMessage) == true)
{
if (objvStudentInfo_Cond.IsMessage == true)
{
strWhereCond += string.Format(" And {0} = '1'", convStudentInfo.IsMessage);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convStudentInfo.IsMessage);
}
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.Microblog) == true)
{
string strComparisonOp_Microblog = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.Microblog];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Microblog, objvStudentInfo_Cond.Microblog, strComparisonOp_Microblog);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.PhoneNumber, objvStudentInfo_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.QQ) == true)
{
string strComparisonOp_QQ = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.QQ];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.QQ, objvStudentInfo_Cond.QQ, strComparisonOp_QQ);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.RegisterPassword) == true)
{
string strComparisonOp_RegisterPassword = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.RegisterPassword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.RegisterPassword, objvStudentInfo_Cond.RegisterPassword, strComparisonOp_RegisterPassword);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UpdDate, objvStudentInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.UpdUser, objvStudentInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvStudentInfo_Cond.IsUpdated(convStudentInfo.Memo) == true)
{
string strComparisonOp_Memo = objvStudentInfo_Cond.dicFldComparisonOp[convStudentInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo.Memo, objvStudentInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生(vStudentInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvStudentInfoWApi
{
private static readonly string mstrApiControllerName = "vStudentInfoApi";

 public clsvStudentInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvStudentInfoEN GetObjByid_StudentInfo(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvStudentInfoEN objvStudentInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvStudentInfoEN = JsonConvert.DeserializeObject<clsvStudentInfoEN>((string)jobjReturn["ReturnObj"]);
return objvStudentInfoEN;
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
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvStudentInfoEN GetObjByid_StudentInfo_WA_Cache(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvStudentInfoEN objvStudentInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvStudentInfoEN = JsonConvert.DeserializeObject<clsvStudentInfoEN>((string)jobjReturn["ReturnObj"]);
return objvStudentInfoEN;
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
public static clsvStudentInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvStudentInfoEN objvStudentInfoEN = null;
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
objvStudentInfoEN = JsonConvert.DeserializeObject<clsvStudentInfoEN>((string)jobjReturn["ReturnObj"]);
return objvStudentInfoEN;
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
 /// <param name = "strid_StudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvStudentInfoEN GetObjByid_StudentInfo_Cache(string strid_StudentInfo)
{
if (string.IsNullOrEmpty(strid_StudentInfo) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvStudentInfoEN._CurrTabName_S);
List<clsvStudentInfoEN> arrvStudentInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvStudentInfoEN> arrvStudentInfoObjLst_Sel =
from objvStudentInfoEN in arrvStudentInfoObjLst_Cache
where objvStudentInfoEN.id_StudentInfo == strid_StudentInfo
select objvStudentInfoEN;
if (arrvStudentInfoObjLst_Sel.Count() == 0)
{
   clsvStudentInfoEN obj = clsvStudentInfoWApi.GetObjByid_StudentInfo(strid_StudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvStudentInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfoEN> GetObjLstById_StudentInfoLst(List<string> arrId_StudentInfo)
{
 List<clsvStudentInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_StudentInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_StudentInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_StudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvStudentInfoEN> GetObjLstById_StudentInfoLst_Cache(List<string> arrId_StudentInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvStudentInfoEN._CurrTabName_S);
List<clsvStudentInfoEN> arrvStudentInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvStudentInfoEN> arrvStudentInfoObjLst_Sel =
from objvStudentInfoEN in arrvStudentInfoObjLst_Cache
where arrId_StudentInfo.Contains(objvStudentInfoEN.id_StudentInfo)
select objvStudentInfoEN;
return arrvStudentInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfoEN> GetObjLstById_StudentInfoLst_WA_Cache(List<string> arrId_StudentInfo)
{
 List<clsvStudentInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_StudentInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_StudentInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvStudentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_StudentInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
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
 /// <param name = "objvStudentInfoENS">源对象</param>
 /// <param name = "objvStudentInfoENT">目标对象</param>
 public static void CopyTo(clsvStudentInfoEN objvStudentInfoENS, clsvStudentInfoEN objvStudentInfoENT)
{
try
{
objvStudentInfoENT.id_StudentInfo = objvStudentInfoENS.id_StudentInfo; //学生流水号
objvStudentInfoENT.StuID = objvStudentInfoENS.StuID; //学号
objvStudentInfoENT.StuName = objvStudentInfoENS.StuName; //姓名
objvStudentInfoENT.id_Politics = objvStudentInfoENS.id_Politics; //政治面貌流水号
objvStudentInfoENT.PoliticsID = objvStudentInfoENS.PoliticsID; //政治面貌ID
objvStudentInfoENT.PoliticsName = objvStudentInfoENS.PoliticsName; //政治面貌
objvStudentInfoENT.id_Sex = objvStudentInfoENS.id_Sex; //性别流水号
objvStudentInfoENT.SexDesc = objvStudentInfoENS.SexDesc; //性别名称
objvStudentInfoENT.id_Ethnic = objvStudentInfoENS.id_Ethnic; //民族流水号
objvStudentInfoENT.EthnicID = objvStudentInfoENS.EthnicID; //民族ID
objvStudentInfoENT.EthnicName = objvStudentInfoENS.EthnicName; //民族名称
objvStudentInfoENT.id_UniZone = objvStudentInfoENS.id_UniZone; //校区流水号
objvStudentInfoENT.UniZoneDesc = objvStudentInfoENS.UniZoneDesc; //校区名称
objvStudentInfoENT.id_StuType = objvStudentInfoENS.id_StuType; //学生类别流水号
objvStudentInfoENT.StuTypeID = objvStudentInfoENS.StuTypeID; //学生类别ID
objvStudentInfoENT.StuTypeDesc = objvStudentInfoENS.StuTypeDesc; //学生类别名称
objvStudentInfoENT.id_XzCollege = objvStudentInfoENS.id_XzCollege; //学院流水号
objvStudentInfoENT.CollegeID = objvStudentInfoENS.CollegeID; //学院ID
objvStudentInfoENT.CollegeName = objvStudentInfoENS.CollegeName; //学院名称
objvStudentInfoENT.CollegeIdInGP = objvStudentInfoENS.CollegeIdInGP; //CollegeIdInGP
objvStudentInfoENT.CollegeNameA = objvStudentInfoENS.CollegeNameA; //学院名称简写
objvStudentInfoENT.id_XzMajor = objvStudentInfoENS.id_XzMajor; //专业流水号
objvStudentInfoENT.MajorID = objvStudentInfoENS.MajorID; //专业ID
objvStudentInfoENT.MajorName = objvStudentInfoENS.MajorName; //专业名称
objvStudentInfoENT.IsNormal = objvStudentInfoENS.IsNormal; //IsNormal
objvStudentInfoENT.id_GradeBase = objvStudentInfoENS.id_GradeBase; //年级流水号
objvStudentInfoENT.GradeBaseName = objvStudentInfoENS.GradeBaseName; //年级名称
objvStudentInfoENT.id_AdminCls = objvStudentInfoENS.id_AdminCls; //行政班流水号
objvStudentInfoENT.AdminClsName = objvStudentInfoENS.AdminClsName; //行政班名称
objvStudentInfoENT.AdminClsId = objvStudentInfoENS.AdminClsId; //行政班代号
objvStudentInfoENT.id_AdminClsType = objvStudentInfoENS.id_AdminClsType; //行政班级类型流水号
objvStudentInfoENT.AdminClsTypeName = objvStudentInfoENS.AdminClsTypeName; //行政班级类型名称
objvStudentInfoENT.Birthday = objvStudentInfoENS.Birthday; //出生日期
objvStudentInfoENT.NativePlace = objvStudentInfoENS.NativePlace; //籍贯
objvStudentInfoENT.Duty = objvStudentInfoENS.Duty; //职位
objvStudentInfoENT.IDCardNo = objvStudentInfoENS.IDCardNo; //身份证号
objvStudentInfoENT.StuCardNo = objvStudentInfoENS.StuCardNo; //学生证号
objvStudentInfoENT.LiveAddress = objvStudentInfoENS.LiveAddress; //居住地址
objvStudentInfoENT.HomePhone = objvStudentInfoENS.HomePhone; //住宅电话
objvStudentInfoENT.Id_CardNo = objvStudentInfoENS.Id_CardNo; //内卡号
objvStudentInfoENT.CardNo = objvStudentInfoENS.CardNo; //卡号
objvStudentInfoENT.IsAvconClassUser = objvStudentInfoENS.IsAvconClassUser; //IsAvconClassUser
objvStudentInfoENT.IsAvconUser = objvStudentInfoENS.IsAvconUser; //IsAvconUser
objvStudentInfoENT.IsGpUser = objvStudentInfoENS.IsGpUser; //是否Gp用户
objvStudentInfoENT.IsLocalUser = objvStudentInfoENS.IsLocalUser; //是否本地用户
objvStudentInfoENT.IsLeaved = objvStudentInfoENS.IsLeaved; //IsLeaved
objvStudentInfoENT.UserId = objvStudentInfoENS.UserId; //用户ID
objvStudentInfoENT.UserID4Avcon = objvStudentInfoENS.UserID4Avcon; //UserID4Avcon
objvStudentInfoENT.EnrollmentDate = objvStudentInfoENS.EnrollmentDate; //入校日期
objvStudentInfoENT.PostCode = objvStudentInfoENS.PostCode; //邮编
objvStudentInfoENT.Email = objvStudentInfoENS.Email; //电子邮箱
objvStudentInfoENT.IsMessage = objvStudentInfoENS.IsMessage; //IsMessage
objvStudentInfoENT.Microblog = objvStudentInfoENS.Microblog; //Microblog
objvStudentInfoENT.PhoneNumber = objvStudentInfoENS.PhoneNumber; //PhoneNumber
objvStudentInfoENT.QQ = objvStudentInfoENS.QQ; //QQ
objvStudentInfoENT.RegisterPassword = objvStudentInfoENS.RegisterPassword; //RegisterPassword
objvStudentInfoENT.UpdDate = objvStudentInfoENS.UpdDate; //修改日期
objvStudentInfoENT.UpdUser = objvStudentInfoENS.UpdUser; //修改人
objvStudentInfoENT.Memo = objvStudentInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvStudentInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvStudentInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvStudentInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvStudentInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvStudentInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvStudentInfoEN.AttributeName)
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
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_StudentInfo");
//if (arrvStudentInfoObjLst_Cache == null)
//{
//arrvStudentInfoObjLst_Cache = await clsvStudentInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvStudentInfoEN._CurrTabName_S);
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
public static List<clsvStudentInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvStudentInfoEN._CurrTabName_S);
List<clsvStudentInfoEN> arrvStudentInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvStudentInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvStudentInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convStudentInfo.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.id_Politics, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.PoliticsID, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.id_Sex, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.SexDesc, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.id_Ethnic, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.EthnicID, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.EthnicName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.id_StuType, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.StuTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.StuTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.CollegeIdInGP, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.IsNormal, Type.GetType("System.Boolean"));
objDT.Columns.Add(convStudentInfo.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.id_AdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.AdminClsName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.AdminClsId, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.id_AdminClsType, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.AdminClsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.Birthday, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.NativePlace, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.Duty, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.IDCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.StuCardNo, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.LiveAddress, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.HomePhone, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.Id_CardNo, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.CardNo, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.IsAvconClassUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convStudentInfo.IsAvconUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convStudentInfo.IsGpUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convStudentInfo.IsLocalUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convStudentInfo.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(convStudentInfo.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.UserID4Avcon, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.EnrollmentDate, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.PostCode, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.Email, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.IsMessage, Type.GetType("System.Boolean"));
objDT.Columns.Add(convStudentInfo.Microblog, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.QQ, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.RegisterPassword, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo.Memo, Type.GetType("System.String"));
foreach (clsvStudentInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convStudentInfo.id_StudentInfo] = objInFor[convStudentInfo.id_StudentInfo];
objDR[convStudentInfo.StuID] = objInFor[convStudentInfo.StuID];
objDR[convStudentInfo.StuName] = objInFor[convStudentInfo.StuName];
objDR[convStudentInfo.id_Politics] = objInFor[convStudentInfo.id_Politics];
objDR[convStudentInfo.PoliticsID] = objInFor[convStudentInfo.PoliticsID];
objDR[convStudentInfo.PoliticsName] = objInFor[convStudentInfo.PoliticsName];
objDR[convStudentInfo.id_Sex] = objInFor[convStudentInfo.id_Sex];
objDR[convStudentInfo.SexDesc] = objInFor[convStudentInfo.SexDesc];
objDR[convStudentInfo.id_Ethnic] = objInFor[convStudentInfo.id_Ethnic];
objDR[convStudentInfo.EthnicID] = objInFor[convStudentInfo.EthnicID];
objDR[convStudentInfo.EthnicName] = objInFor[convStudentInfo.EthnicName];
objDR[convStudentInfo.id_UniZone] = objInFor[convStudentInfo.id_UniZone];
objDR[convStudentInfo.UniZoneDesc] = objInFor[convStudentInfo.UniZoneDesc];
objDR[convStudentInfo.id_StuType] = objInFor[convStudentInfo.id_StuType];
objDR[convStudentInfo.StuTypeID] = objInFor[convStudentInfo.StuTypeID];
objDR[convStudentInfo.StuTypeDesc] = objInFor[convStudentInfo.StuTypeDesc];
objDR[convStudentInfo.id_XzCollege] = objInFor[convStudentInfo.id_XzCollege];
objDR[convStudentInfo.CollegeID] = objInFor[convStudentInfo.CollegeID];
objDR[convStudentInfo.CollegeName] = objInFor[convStudentInfo.CollegeName];
objDR[convStudentInfo.CollegeIdInGP] = objInFor[convStudentInfo.CollegeIdInGP];
objDR[convStudentInfo.CollegeNameA] = objInFor[convStudentInfo.CollegeNameA];
objDR[convStudentInfo.id_XzMajor] = objInFor[convStudentInfo.id_XzMajor];
objDR[convStudentInfo.MajorID] = objInFor[convStudentInfo.MajorID];
objDR[convStudentInfo.MajorName] = objInFor[convStudentInfo.MajorName];
objDR[convStudentInfo.IsNormal] = objInFor[convStudentInfo.IsNormal];
objDR[convStudentInfo.id_GradeBase] = objInFor[convStudentInfo.id_GradeBase];
objDR[convStudentInfo.GradeBaseName] = objInFor[convStudentInfo.GradeBaseName];
objDR[convStudentInfo.id_AdminCls] = objInFor[convStudentInfo.id_AdminCls];
objDR[convStudentInfo.AdminClsName] = objInFor[convStudentInfo.AdminClsName];
objDR[convStudentInfo.AdminClsId] = objInFor[convStudentInfo.AdminClsId];
objDR[convStudentInfo.id_AdminClsType] = objInFor[convStudentInfo.id_AdminClsType];
objDR[convStudentInfo.AdminClsTypeName] = objInFor[convStudentInfo.AdminClsTypeName];
objDR[convStudentInfo.Birthday] = objInFor[convStudentInfo.Birthday];
objDR[convStudentInfo.NativePlace] = objInFor[convStudentInfo.NativePlace];
objDR[convStudentInfo.Duty] = objInFor[convStudentInfo.Duty];
objDR[convStudentInfo.IDCardNo] = objInFor[convStudentInfo.IDCardNo];
objDR[convStudentInfo.StuCardNo] = objInFor[convStudentInfo.StuCardNo];
objDR[convStudentInfo.LiveAddress] = objInFor[convStudentInfo.LiveAddress];
objDR[convStudentInfo.HomePhone] = objInFor[convStudentInfo.HomePhone];
objDR[convStudentInfo.Id_CardNo] = objInFor[convStudentInfo.Id_CardNo];
objDR[convStudentInfo.CardNo] = objInFor[convStudentInfo.CardNo];
objDR[convStudentInfo.IsAvconClassUser] = objInFor[convStudentInfo.IsAvconClassUser];
objDR[convStudentInfo.IsAvconUser] = objInFor[convStudentInfo.IsAvconUser];
objDR[convStudentInfo.IsGpUser] = objInFor[convStudentInfo.IsGpUser];
objDR[convStudentInfo.IsLocalUser] = objInFor[convStudentInfo.IsLocalUser];
objDR[convStudentInfo.IsLeaved] = objInFor[convStudentInfo.IsLeaved];
objDR[convStudentInfo.UserId] = objInFor[convStudentInfo.UserId];
objDR[convStudentInfo.UserID4Avcon] = objInFor[convStudentInfo.UserID4Avcon];
objDR[convStudentInfo.EnrollmentDate] = objInFor[convStudentInfo.EnrollmentDate];
objDR[convStudentInfo.PostCode] = objInFor[convStudentInfo.PostCode];
objDR[convStudentInfo.Email] = objInFor[convStudentInfo.Email];
objDR[convStudentInfo.IsMessage] = objInFor[convStudentInfo.IsMessage];
objDR[convStudentInfo.Microblog] = objInFor[convStudentInfo.Microblog];
objDR[convStudentInfo.PhoneNumber] = objInFor[convStudentInfo.PhoneNumber];
objDR[convStudentInfo.QQ] = objInFor[convStudentInfo.QQ];
objDR[convStudentInfo.RegisterPassword] = objInFor[convStudentInfo.RegisterPassword];
objDR[convStudentInfo.UpdDate] = objInFor[convStudentInfo.UpdDate];
objDR[convStudentInfo.UpdUser] = objInFor[convStudentInfo.UpdUser];
objDR[convStudentInfo.Memo] = objInFor[convStudentInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}