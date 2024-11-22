
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseRelaInfoWApi
 表名:vCaseRelaInfo(01120390)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN Setid_CaseRelaInfo(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, long lngid_CaseRelaInfo, string strComparisonOp="")
	{
objvCaseRelaInfoEN.id_CaseRelaInfo = lngid_CaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.id_CaseRelaInfo) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.id_CaseRelaInfo, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.id_CaseRelaInfo] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetFuncModuleId1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strFuncModuleId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId1, convCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckFieldLen(strFuncModuleId1, 4, convCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId1, 4, convCaseRelaInfo.FuncModuleId1);
objvCaseRelaInfoEN.FuncModuleId1 = strFuncModuleId1; //功能模块Id1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.FuncModuleId1) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.FuncModuleId1, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.FuncModuleId1] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetFuncModuleName1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strFuncModuleName1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName1, 30, convCaseRelaInfo.FuncModuleName1);
objvCaseRelaInfoEN.FuncModuleName1 = strFuncModuleName1; //功能模块名称1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.FuncModuleName1) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.FuncModuleName1, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.FuncModuleName1] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseId1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId1, convCaseRelaInfo.CaseId1);
clsCheckSql.CheckFieldLen(strCaseId1, 8, convCaseRelaInfo.CaseId1);
clsCheckSql.CheckFieldForeignKey(strCaseId1, 8, convCaseRelaInfo.CaseId1);
objvCaseRelaInfoEN.CaseId1 = strCaseId1; //案例Id1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.CaseId1) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.CaseId1, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.CaseId1] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseName1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseName1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName1, convCaseRelaInfo.CaseName1);
clsCheckSql.CheckFieldLen(strCaseName1, 100, convCaseRelaInfo.CaseName1);
objvCaseRelaInfoEN.CaseName1 = strCaseName1; //案例名称1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.CaseName1) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.CaseName1, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.CaseName1] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetOwnerId1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strOwnerId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId1, convCaseRelaInfo.OwnerId1);
clsCheckSql.CheckFieldLen(strOwnerId1, 20, convCaseRelaInfo.OwnerId1);
objvCaseRelaInfoEN.OwnerId1 = strOwnerId1; //拥有者Id1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.OwnerId1) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.OwnerId1, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.OwnerId1] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetOwnerName1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strOwnerName1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName1, 30, convCaseRelaInfo.OwnerName1);
objvCaseRelaInfoEN.OwnerName1 = strOwnerName1; //拥有者姓名1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.OwnerName1) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.OwnerName1, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.OwnerName1] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetFuncModuleId2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strFuncModuleId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId2, convCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckFieldLen(strFuncModuleId2, 4, convCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId2, 4, convCaseRelaInfo.FuncModuleId2);
objvCaseRelaInfoEN.FuncModuleId2 = strFuncModuleId2; //功能模块Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.FuncModuleId2) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.FuncModuleId2, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.FuncModuleId2] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetFuncModuleName2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strFuncModuleName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName2, 30, convCaseRelaInfo.FuncModuleName2);
objvCaseRelaInfoEN.FuncModuleName2 = strFuncModuleName2; //功能模块名称2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.FuncModuleName2) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.FuncModuleName2, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.FuncModuleName2] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseId2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId2, convCaseRelaInfo.CaseId2);
clsCheckSql.CheckFieldLen(strCaseId2, 8, convCaseRelaInfo.CaseId2);
clsCheckSql.CheckFieldForeignKey(strCaseId2, 8, convCaseRelaInfo.CaseId2);
objvCaseRelaInfoEN.CaseId2 = strCaseId2; //案例Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.CaseId2) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.CaseId2, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.CaseId2] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseName2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName2, convCaseRelaInfo.CaseName2);
clsCheckSql.CheckFieldLen(strCaseName2, 100, convCaseRelaInfo.CaseName2);
objvCaseRelaInfoEN.CaseName2 = strCaseName2; //案例名称2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.CaseName2) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.CaseName2, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.CaseName2] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetOwnerId2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strOwnerId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId2, convCaseRelaInfo.OwnerId2);
clsCheckSql.CheckFieldLen(strOwnerId2, 20, convCaseRelaInfo.OwnerId2);
objvCaseRelaInfoEN.OwnerId2 = strOwnerId2; //拥有者Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.OwnerId2) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.OwnerId2, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.OwnerId2] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetOwnerName2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strOwnerName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName2, 30, convCaseRelaInfo.OwnerName2);
objvCaseRelaInfoEN.OwnerName2 = strOwnerName2; //拥有者姓名2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.OwnerName2) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.OwnerName2, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.OwnerName2] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN Setid_CaseRelaInfoType(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strid_CaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CaseRelaInfoType, convCaseRelaInfo.id_CaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_CaseRelaInfoType, 4, convCaseRelaInfo.id_CaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_CaseRelaInfoType, 4, convCaseRelaInfo.id_CaseRelaInfoType);
objvCaseRelaInfoEN.id_CaseRelaInfoType = strid_CaseRelaInfoType; //案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.id_CaseRelaInfoType) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.id_CaseRelaInfoType, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.id_CaseRelaInfoType] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseRelaInfoTypeName(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseRelaInfoTypeName, convCaseRelaInfo.CaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(strCaseRelaInfoTypeName, 50, convCaseRelaInfo.CaseRelaInfoTypeName);
objvCaseRelaInfoEN.CaseRelaInfoTypeName = strCaseRelaInfoTypeName; //案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.CaseRelaInfoTypeName) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.CaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.CaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetRelationsDegree(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, int intRelationsDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intRelationsDegree, convCaseRelaInfo.RelationsDegree);
objvCaseRelaInfoEN.RelationsDegree = intRelationsDegree; //关系度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.RelationsDegree) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.RelationsDegree, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.RelationsDegree] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetBrowseCount(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.BrowseCount) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetUpdUserId(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseRelaInfo.UpdUserId);
objvCaseRelaInfoEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.UpdUserId) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.UpdUserId, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.UpdUserId] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetUpdDate(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseRelaInfo.UpdDate);
objvCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.UpdDate) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseRelaInfoEN SetMemo(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseRelaInfo.Memo);
objvCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.Memo) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseRelaInfoEN objvCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.id_CaseRelaInfo) == true)
{
string strComparisonOp_id_CaseRelaInfo = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.id_CaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseRelaInfo.id_CaseRelaInfo, objvCaseRelaInfo_Cond.id_CaseRelaInfo, strComparisonOp_id_CaseRelaInfo);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.FuncModuleId1) == true)
{
string strComparisonOp_FuncModuleId1 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.FuncModuleId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.FuncModuleId1, objvCaseRelaInfo_Cond.FuncModuleId1, strComparisonOp_FuncModuleId1);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.FuncModuleName1) == true)
{
string strComparisonOp_FuncModuleName1 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.FuncModuleName1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.FuncModuleName1, objvCaseRelaInfo_Cond.FuncModuleName1, strComparisonOp_FuncModuleName1);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.CaseId1) == true)
{
string strComparisonOp_CaseId1 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.CaseId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseId1, objvCaseRelaInfo_Cond.CaseId1, strComparisonOp_CaseId1);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.CaseName1) == true)
{
string strComparisonOp_CaseName1 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.CaseName1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseName1, objvCaseRelaInfo_Cond.CaseName1, strComparisonOp_CaseName1);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.OwnerId1) == true)
{
string strComparisonOp_OwnerId1 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.OwnerId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.OwnerId1, objvCaseRelaInfo_Cond.OwnerId1, strComparisonOp_OwnerId1);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.OwnerName1) == true)
{
string strComparisonOp_OwnerName1 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.OwnerName1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.OwnerName1, objvCaseRelaInfo_Cond.OwnerName1, strComparisonOp_OwnerName1);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.FuncModuleId2) == true)
{
string strComparisonOp_FuncModuleId2 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.FuncModuleId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.FuncModuleId2, objvCaseRelaInfo_Cond.FuncModuleId2, strComparisonOp_FuncModuleId2);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.FuncModuleName2) == true)
{
string strComparisonOp_FuncModuleName2 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.FuncModuleName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.FuncModuleName2, objvCaseRelaInfo_Cond.FuncModuleName2, strComparisonOp_FuncModuleName2);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.CaseId2) == true)
{
string strComparisonOp_CaseId2 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.CaseId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseId2, objvCaseRelaInfo_Cond.CaseId2, strComparisonOp_CaseId2);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.CaseName2) == true)
{
string strComparisonOp_CaseName2 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.CaseName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseName2, objvCaseRelaInfo_Cond.CaseName2, strComparisonOp_CaseName2);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.OwnerId2) == true)
{
string strComparisonOp_OwnerId2 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.OwnerId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.OwnerId2, objvCaseRelaInfo_Cond.OwnerId2, strComparisonOp_OwnerId2);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.OwnerName2) == true)
{
string strComparisonOp_OwnerName2 = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.OwnerName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.OwnerName2, objvCaseRelaInfo_Cond.OwnerName2, strComparisonOp_OwnerName2);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.id_CaseRelaInfoType) == true)
{
string strComparisonOp_id_CaseRelaInfoType = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.id_CaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.id_CaseRelaInfoType, objvCaseRelaInfo_Cond.id_CaseRelaInfoType, strComparisonOp_id_CaseRelaInfoType);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.CaseRelaInfoTypeName) == true)
{
string strComparisonOp_CaseRelaInfoTypeName = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.CaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseRelaInfoTypeName, objvCaseRelaInfo_Cond.CaseRelaInfoTypeName, strComparisonOp_CaseRelaInfoTypeName);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.RelationsDegree) == true)
{
string strComparisonOp_RelationsDegree = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.RelationsDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseRelaInfo.RelationsDegree, objvCaseRelaInfo_Cond.RelationsDegree, strComparisonOp_RelationsDegree);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseRelaInfo.BrowseCount, objvCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.UpdUserId, objvCaseRelaInfo_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.UpdDate, objvCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCaseRelaInfo_Cond.IsUpdated(convCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvCaseRelaInfo_Cond.dicFldComparisonOp[convCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.Memo, objvCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例相关信息(vCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vCaseRelaInfoApi";

 public clsvCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_CaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseRelaInfoEN GetObjByid_CaseRelaInfo(long lngid_CaseRelaInfo)
{
string strAction = "GetObjByid_CaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseRelaInfoEN objvCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseRelaInfo"] = lngid_CaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCaseRelaInfoEN;
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
 /// <param name = "lngid_CaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseRelaInfoEN GetObjByid_CaseRelaInfo_WA_Cache(long lngid_CaseRelaInfo)
{
string strAction = "GetObjByid_CaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseRelaInfoEN objvCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseRelaInfo"] = lngid_CaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCaseRelaInfoEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseRelaInfoEN objvCaseRelaInfoEN = null;
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
objvCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvCaseRelaInfoEN;
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
 /// <param name = "lngid_CaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseRelaInfoEN GetObjByid_CaseRelaInfo_Cache(long lngid_CaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseRelaInfoEN._CurrTabName_S);
List<clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLst_Sel =
from objvCaseRelaInfoEN in arrvCaseRelaInfoObjLst_Cache
where objvCaseRelaInfoEN.id_CaseRelaInfo == lngid_CaseRelaInfo
select objvCaseRelaInfoEN;
if (arrvCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvCaseRelaInfoEN obj = clsvCaseRelaInfoWApi.GetObjByid_CaseRelaInfo(lngid_CaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseRelaInfoEN> GetObjLstById_CaseRelaInfoLst(List<long> arrId_CaseRelaInfo)
{
 List<clsvCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseRelaInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_CaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCaseRelaInfoEN> GetObjLstById_CaseRelaInfoLst_Cache(List<long> arrId_CaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseRelaInfoEN._CurrTabName_S);
List<clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLst_Sel =
from objvCaseRelaInfoEN in arrvCaseRelaInfoObjLst_Cache
where arrId_CaseRelaInfo.Contains(objvCaseRelaInfoEN.id_CaseRelaInfo)
select objvCaseRelaInfoEN;
return arrvCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseRelaInfoEN> GetObjLstById_CaseRelaInfoLst_WA_Cache(List<long> arrId_CaseRelaInfo)
{
 List<clsvCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseRelaInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_CaseRelaInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseRelaInfo"] = lngid_CaseRelaInfo.ToString()
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
 /// <param name = "objvCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvCaseRelaInfoEN objvCaseRelaInfoENS, clsvCaseRelaInfoEN objvCaseRelaInfoENT)
{
try
{
objvCaseRelaInfoENT.id_CaseRelaInfo = objvCaseRelaInfoENS.id_CaseRelaInfo; //案例相关信息流水号
objvCaseRelaInfoENT.FuncModuleId1 = objvCaseRelaInfoENS.FuncModuleId1; //功能模块Id1
objvCaseRelaInfoENT.FuncModuleName1 = objvCaseRelaInfoENS.FuncModuleName1; //功能模块名称1
objvCaseRelaInfoENT.CaseId1 = objvCaseRelaInfoENS.CaseId1; //案例Id1
objvCaseRelaInfoENT.CaseName1 = objvCaseRelaInfoENS.CaseName1; //案例名称1
objvCaseRelaInfoENT.OwnerId1 = objvCaseRelaInfoENS.OwnerId1; //拥有者Id1
objvCaseRelaInfoENT.OwnerName1 = objvCaseRelaInfoENS.OwnerName1; //拥有者姓名1
objvCaseRelaInfoENT.FuncModuleId2 = objvCaseRelaInfoENS.FuncModuleId2; //功能模块Id2
objvCaseRelaInfoENT.FuncModuleName2 = objvCaseRelaInfoENS.FuncModuleName2; //功能模块名称2
objvCaseRelaInfoENT.CaseId2 = objvCaseRelaInfoENS.CaseId2; //案例Id2
objvCaseRelaInfoENT.CaseName2 = objvCaseRelaInfoENS.CaseName2; //案例名称2
objvCaseRelaInfoENT.OwnerId2 = objvCaseRelaInfoENS.OwnerId2; //拥有者Id2
objvCaseRelaInfoENT.OwnerName2 = objvCaseRelaInfoENS.OwnerName2; //拥有者姓名2
objvCaseRelaInfoENT.id_CaseRelaInfoType = objvCaseRelaInfoENS.id_CaseRelaInfoType; //案例相关信息类型流水号
objvCaseRelaInfoENT.CaseRelaInfoTypeName = objvCaseRelaInfoENS.CaseRelaInfoTypeName; //案例相关信息类型名称
objvCaseRelaInfoENT.RelationsDegree = objvCaseRelaInfoENS.RelationsDegree; //关系度
objvCaseRelaInfoENT.BrowseCount = objvCaseRelaInfoENS.BrowseCount; //浏览次数
objvCaseRelaInfoENT.UpdUserId = objvCaseRelaInfoENS.UpdUserId; //修改用户Id
objvCaseRelaInfoENT.UpdDate = objvCaseRelaInfoENS.UpdDate; //修改日期
objvCaseRelaInfoENT.Memo = objvCaseRelaInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCaseRelaInfoEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseRelaInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseRelaInfoWApi没有刷新缓存机制(clsCaseRelaInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseRelaInfoTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseRelaInfoTypeWApi没有刷新缓存机制(clsCaseRelaInfoTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CaseRelaInfo");
//if (arrvCaseRelaInfoObjLst_Cache == null)
//{
//arrvCaseRelaInfoObjLst_Cache = await clsvCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCaseRelaInfoEN._CurrTabName_S);
List<clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCaseRelaInfo.id_CaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseRelaInfo.FuncModuleId1, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.FuncModuleName1, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.CaseId1, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.CaseName1, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.OwnerId1, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.OwnerName1, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.FuncModuleId2, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.FuncModuleName2, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.CaseId2, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.CaseName2, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.OwnerId2, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.OwnerName2, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.id_CaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.CaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.RelationsDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCaseRelaInfo.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCaseRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsvCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCaseRelaInfo.id_CaseRelaInfo] = objInFor[convCaseRelaInfo.id_CaseRelaInfo];
objDR[convCaseRelaInfo.FuncModuleId1] = objInFor[convCaseRelaInfo.FuncModuleId1];
objDR[convCaseRelaInfo.FuncModuleName1] = objInFor[convCaseRelaInfo.FuncModuleName1];
objDR[convCaseRelaInfo.CaseId1] = objInFor[convCaseRelaInfo.CaseId1];
objDR[convCaseRelaInfo.CaseName1] = objInFor[convCaseRelaInfo.CaseName1];
objDR[convCaseRelaInfo.OwnerId1] = objInFor[convCaseRelaInfo.OwnerId1];
objDR[convCaseRelaInfo.OwnerName1] = objInFor[convCaseRelaInfo.OwnerName1];
objDR[convCaseRelaInfo.FuncModuleId2] = objInFor[convCaseRelaInfo.FuncModuleId2];
objDR[convCaseRelaInfo.FuncModuleName2] = objInFor[convCaseRelaInfo.FuncModuleName2];
objDR[convCaseRelaInfo.CaseId2] = objInFor[convCaseRelaInfo.CaseId2];
objDR[convCaseRelaInfo.CaseName2] = objInFor[convCaseRelaInfo.CaseName2];
objDR[convCaseRelaInfo.OwnerId2] = objInFor[convCaseRelaInfo.OwnerId2];
objDR[convCaseRelaInfo.OwnerName2] = objInFor[convCaseRelaInfo.OwnerName2];
objDR[convCaseRelaInfo.id_CaseRelaInfoType] = objInFor[convCaseRelaInfo.id_CaseRelaInfoType];
objDR[convCaseRelaInfo.CaseRelaInfoTypeName] = objInFor[convCaseRelaInfo.CaseRelaInfoTypeName];
objDR[convCaseRelaInfo.RelationsDegree] = objInFor[convCaseRelaInfo.RelationsDegree];
objDR[convCaseRelaInfo.BrowseCount] = objInFor[convCaseRelaInfo.BrowseCount];
objDR[convCaseRelaInfo.UpdUserId] = objInFor[convCaseRelaInfo.UpdUserId];
objDR[convCaseRelaInfo.UpdDate] = objInFor[convCaseRelaInfo.UpdDate];
objDR[convCaseRelaInfo.Memo] = objInFor[convCaseRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}