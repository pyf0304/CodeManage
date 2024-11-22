
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseRelaInfoBL
 表名:vCaseRelaInfo(01120390)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvCaseRelaInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseRelaInfoEN GetObj(this K_IdCaseRelaInfo_vCaseRelaInfo myKey)
{
clsvCaseRelaInfoEN objvCaseRelaInfoEN = clsvCaseRelaInfoBL.vCaseRelaInfoDA.GetObjByIdCaseRelaInfo(myKey.Value);
return objvCaseRelaInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetIdCaseRelaInfo(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, long lngIdCaseRelaInfo, string strComparisonOp="")
	{
objvCaseRelaInfoEN.IdCaseRelaInfo = lngIdCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.IdCaseRelaInfo) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.IdCaseRelaInfo, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.IdCaseRelaInfo] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetFuncModuleId1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strFuncModuleId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId1, convCaseRelaInfo.FuncModuleId1);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId1, 4, convCaseRelaInfo.FuncModuleId1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId1, 4, convCaseRelaInfo.FuncModuleId1);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetFuncModuleName1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strFuncModuleName1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName1, 30, convCaseRelaInfo.FuncModuleName1);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseId1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId1, convCaseRelaInfo.CaseId1);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId1, 8, convCaseRelaInfo.CaseId1);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId1, 8, convCaseRelaInfo.CaseId1);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseName1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseName1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName1, convCaseRelaInfo.CaseName1);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName1, 100, convCaseRelaInfo.CaseName1);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetOwnerId1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strOwnerId1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId1, convCaseRelaInfo.OwnerId1);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId1, 20, convCaseRelaInfo.OwnerId1);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetOwnerName1(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strOwnerName1, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName1, 30, convCaseRelaInfo.OwnerName1);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetFuncModuleId2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strFuncModuleId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId2, convCaseRelaInfo.FuncModuleId2);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId2, 4, convCaseRelaInfo.FuncModuleId2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId2, 4, convCaseRelaInfo.FuncModuleId2);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetFuncModuleName2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strFuncModuleName2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName2, 30, convCaseRelaInfo.FuncModuleName2);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseId2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId2, convCaseRelaInfo.CaseId2);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId2, 8, convCaseRelaInfo.CaseId2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId2, 8, convCaseRelaInfo.CaseId2);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseName2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName2, convCaseRelaInfo.CaseName2);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName2, 100, convCaseRelaInfo.CaseName2);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetOwnerId2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strOwnerId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId2, convCaseRelaInfo.OwnerId2);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId2, 20, convCaseRelaInfo.OwnerId2);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetOwnerName2(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strOwnerName2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName2, 30, convCaseRelaInfo.OwnerName2);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetIdCaseRelaInfoType(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strIdCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCaseRelaInfoType, convCaseRelaInfo.IdCaseRelaInfoType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseRelaInfoType, 4, convCaseRelaInfo.IdCaseRelaInfoType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseRelaInfoType, 4, convCaseRelaInfo.IdCaseRelaInfoType);
}
objvCaseRelaInfoEN.IdCaseRelaInfoType = strIdCaseRelaInfoType; //案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convCaseRelaInfo.IdCaseRelaInfoType) == false)
{
objvCaseRelaInfoEN.dicFldComparisonOp.Add(convCaseRelaInfo.IdCaseRelaInfoType, strComparisonOp);
}
else
{
objvCaseRelaInfoEN.dicFldComparisonOp[convCaseRelaInfo.IdCaseRelaInfoType] = strComparisonOp;
}
}
return objvCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetCaseRelaInfoTypeName(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseRelaInfoTypeName, convCaseRelaInfo.CaseRelaInfoTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseRelaInfoTypeName, 50, convCaseRelaInfo.CaseRelaInfoTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetBrowseCount(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetUpdUserId(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCaseRelaInfo.UpdUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetUpdDate(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseRelaInfo.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCaseRelaInfoEN SetMemo(this clsvCaseRelaInfoEN objvCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseRelaInfo.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(this clsvCaseRelaInfoEN objvCaseRelaInfoENS, clsvCaseRelaInfoEN objvCaseRelaInfoENT)
{
try
{
objvCaseRelaInfoENT.IdCaseRelaInfo = objvCaseRelaInfoENS.IdCaseRelaInfo; //案例相关信息流水号
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
objvCaseRelaInfoENT.IdCaseRelaInfoType = objvCaseRelaInfoENS.IdCaseRelaInfoType; //案例相关信息类型流水号
objvCaseRelaInfoENT.CaseRelaInfoTypeName = objvCaseRelaInfoENS.CaseRelaInfoTypeName; //案例相关信息类型名称
objvCaseRelaInfoENT.RelationsDegree = objvCaseRelaInfoENS.RelationsDegree; //关系度
objvCaseRelaInfoENT.BrowseCount = objvCaseRelaInfoENS.BrowseCount; //浏览次数
objvCaseRelaInfoENT.UpdUserId = objvCaseRelaInfoENS.UpdUserId; //修改用户Id
objvCaseRelaInfoENT.UpdDate = objvCaseRelaInfoENS.UpdDate; //修改日期
objvCaseRelaInfoENT.Memo = objvCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objvCaseRelaInfoENS">源对象</param>
 /// <returns>目标对象=>clsvCaseRelaInfoEN:objvCaseRelaInfoENT</returns>
 public static clsvCaseRelaInfoEN CopyTo(this clsvCaseRelaInfoEN objvCaseRelaInfoENS)
{
try
{
 clsvCaseRelaInfoEN objvCaseRelaInfoENT = new clsvCaseRelaInfoEN()
{
IdCaseRelaInfo = objvCaseRelaInfoENS.IdCaseRelaInfo, //案例相关信息流水号
FuncModuleId1 = objvCaseRelaInfoENS.FuncModuleId1, //功能模块Id1
FuncModuleName1 = objvCaseRelaInfoENS.FuncModuleName1, //功能模块名称1
CaseId1 = objvCaseRelaInfoENS.CaseId1, //案例Id1
CaseName1 = objvCaseRelaInfoENS.CaseName1, //案例名称1
OwnerId1 = objvCaseRelaInfoENS.OwnerId1, //拥有者Id1
OwnerName1 = objvCaseRelaInfoENS.OwnerName1, //拥有者姓名1
FuncModuleId2 = objvCaseRelaInfoENS.FuncModuleId2, //功能模块Id2
FuncModuleName2 = objvCaseRelaInfoENS.FuncModuleName2, //功能模块名称2
CaseId2 = objvCaseRelaInfoENS.CaseId2, //案例Id2
CaseName2 = objvCaseRelaInfoENS.CaseName2, //案例名称2
OwnerId2 = objvCaseRelaInfoENS.OwnerId2, //拥有者Id2
OwnerName2 = objvCaseRelaInfoENS.OwnerName2, //拥有者姓名2
IdCaseRelaInfoType = objvCaseRelaInfoENS.IdCaseRelaInfoType, //案例相关信息类型流水号
CaseRelaInfoTypeName = objvCaseRelaInfoENS.CaseRelaInfoTypeName, //案例相关信息类型名称
RelationsDegree = objvCaseRelaInfoENS.RelationsDegree, //关系度
BrowseCount = objvCaseRelaInfoENS.BrowseCount, //浏览次数
UpdUserId = objvCaseRelaInfoENS.UpdUserId, //修改用户Id
UpdDate = objvCaseRelaInfoENS.UpdDate, //修改日期
Memo = objvCaseRelaInfoENS.Memo, //备注
};
 return objvCaseRelaInfoENT;
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
public static void CheckProperty4Condition(this clsvCaseRelaInfoEN objvCaseRelaInfoEN)
{
 clsvCaseRelaInfoBL.vCaseRelaInfoDA.CheckProperty4Condition(objvCaseRelaInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseRelaInfoEN objvCaseRelaInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.IdCaseRelaInfo) == true)
{
string strComparisonOpIdCaseRelaInfo = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.IdCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseRelaInfo.IdCaseRelaInfo, objvCaseRelaInfoCond.IdCaseRelaInfo, strComparisonOpIdCaseRelaInfo);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.FuncModuleId1) == true)
{
string strComparisonOpFuncModuleId1 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.FuncModuleId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.FuncModuleId1, objvCaseRelaInfoCond.FuncModuleId1, strComparisonOpFuncModuleId1);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.FuncModuleName1) == true)
{
string strComparisonOpFuncModuleName1 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.FuncModuleName1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.FuncModuleName1, objvCaseRelaInfoCond.FuncModuleName1, strComparisonOpFuncModuleName1);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.CaseId1) == true)
{
string strComparisonOpCaseId1 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.CaseId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseId1, objvCaseRelaInfoCond.CaseId1, strComparisonOpCaseId1);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.CaseName1) == true)
{
string strComparisonOpCaseName1 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.CaseName1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseName1, objvCaseRelaInfoCond.CaseName1, strComparisonOpCaseName1);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.OwnerId1) == true)
{
string strComparisonOpOwnerId1 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.OwnerId1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.OwnerId1, objvCaseRelaInfoCond.OwnerId1, strComparisonOpOwnerId1);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.OwnerName1) == true)
{
string strComparisonOpOwnerName1 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.OwnerName1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.OwnerName1, objvCaseRelaInfoCond.OwnerName1, strComparisonOpOwnerName1);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.FuncModuleId2) == true)
{
string strComparisonOpFuncModuleId2 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.FuncModuleId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.FuncModuleId2, objvCaseRelaInfoCond.FuncModuleId2, strComparisonOpFuncModuleId2);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.FuncModuleName2) == true)
{
string strComparisonOpFuncModuleName2 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.FuncModuleName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.FuncModuleName2, objvCaseRelaInfoCond.FuncModuleName2, strComparisonOpFuncModuleName2);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.CaseId2) == true)
{
string strComparisonOpCaseId2 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.CaseId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseId2, objvCaseRelaInfoCond.CaseId2, strComparisonOpCaseId2);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.CaseName2) == true)
{
string strComparisonOpCaseName2 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.CaseName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseName2, objvCaseRelaInfoCond.CaseName2, strComparisonOpCaseName2);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.OwnerId2) == true)
{
string strComparisonOpOwnerId2 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.OwnerId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.OwnerId2, objvCaseRelaInfoCond.OwnerId2, strComparisonOpOwnerId2);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.OwnerName2) == true)
{
string strComparisonOpOwnerName2 = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.OwnerName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.OwnerName2, objvCaseRelaInfoCond.OwnerName2, strComparisonOpOwnerName2);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.IdCaseRelaInfoType) == true)
{
string strComparisonOpIdCaseRelaInfoType = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.IdCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.IdCaseRelaInfoType, objvCaseRelaInfoCond.IdCaseRelaInfoType, strComparisonOpIdCaseRelaInfoType);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.CaseRelaInfoTypeName) == true)
{
string strComparisonOpCaseRelaInfoTypeName = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.CaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.CaseRelaInfoTypeName, objvCaseRelaInfoCond.CaseRelaInfoTypeName, strComparisonOpCaseRelaInfoTypeName);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.RelationsDegree) == true)
{
string strComparisonOpRelationsDegree = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.RelationsDegree];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseRelaInfo.RelationsDegree, objvCaseRelaInfoCond.RelationsDegree, strComparisonOpRelationsDegree);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseRelaInfo.BrowseCount, objvCaseRelaInfoCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.UpdUserId, objvCaseRelaInfoCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.UpdDate, objvCaseRelaInfoCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCaseRelaInfoCond.IsUpdated(convCaseRelaInfo.Memo) == true)
{
string strComparisonOpMemo = objvCaseRelaInfoCond.dicFldComparisonOp[convCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseRelaInfo.Memo, objvCaseRelaInfoCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCaseRelaInfo
{
public virtual bool UpdRelaTabDate(long lngIdCaseRelaInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v案例相关信息(vCaseRelaInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCaseRelaInfoBL
{
public static RelatedActions_vCaseRelaInfo relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCaseRelaInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCaseRelaInfoDA vCaseRelaInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCaseRelaInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCaseRelaInfoBL()
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
if (string.IsNullOrEmpty(clsvCaseRelaInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseRelaInfoEN._ConnectString);
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
public static DataTable GetDataTable_vCaseRelaInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCaseRelaInfoDA.GetDataTable_vCaseRelaInfo(strWhereCond);
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
objDT = vCaseRelaInfoDA.GetDataTable(strWhereCond);
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
objDT = vCaseRelaInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCaseRelaInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCaseRelaInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vCaseRelaInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCaseRelaInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCaseRelaInfoEN> GetObjLstByIdCaseRelaInfoLst(List<long> arrIdCaseRelaInfoLst)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseRelaInfoLst);
 string strWhereCond = string.Format("IdCaseRelaInfo in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseRelaInfoLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCaseRelaInfoEN> GetObjLstByIdCaseRelaInfoLstCache(List<long> arrIdCaseRelaInfoLst)
{
string strKey = string.Format("{0}", clsvCaseRelaInfoEN._CurrTabName);
List<clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLst_Sel =
arrvCaseRelaInfoObjLstCache
.Where(x => arrIdCaseRelaInfoLst.Contains(x.IdCaseRelaInfo));
return arrvCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
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
public static List<clsvCaseRelaInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCaseRelaInfoEN> GetSubObjLstCache(clsvCaseRelaInfoEN objvCaseRelaInfoCond)
{
List<clsvCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseRelaInfo.AttributeName)
{
if (objvCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseRelaInfoCond[strFldName]));
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
public static List<clsvCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
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
public static List<clsvCaseRelaInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
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
List<clsvCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCaseRelaInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
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
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
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
public static List<clsvCaseRelaInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
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
public static List<clsvCaseRelaInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseRelaInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCaseRelaInfoEN.IdCaseRelaInfo, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCaseRelaInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCaseRelaInfo(ref clsvCaseRelaInfoEN objvCaseRelaInfoEN)
{
bool bolResult = vCaseRelaInfoDA.GetvCaseRelaInfo(ref objvCaseRelaInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseRelaInfoEN GetObjByIdCaseRelaInfo(long lngIdCaseRelaInfo)
{
clsvCaseRelaInfoEN objvCaseRelaInfoEN = vCaseRelaInfoDA.GetObjByIdCaseRelaInfo(lngIdCaseRelaInfo);
return objvCaseRelaInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCaseRelaInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCaseRelaInfoEN objvCaseRelaInfoEN = vCaseRelaInfoDA.GetFirstObj(strWhereCond);
 return objvCaseRelaInfoEN;
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
public static clsvCaseRelaInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCaseRelaInfoEN objvCaseRelaInfoEN = vCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvCaseRelaInfoEN;
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
public static clsvCaseRelaInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCaseRelaInfoEN objvCaseRelaInfoEN = vCaseRelaInfoDA.GetObjByDataRow(objRow);
 return objvCaseRelaInfoEN;
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
 /// <param name = "lngIdCaseRelaInfo">所给的关键字</param>
 /// <param name = "lstvCaseRelaInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseRelaInfoEN GetObjByIdCaseRelaInfoFromList(long lngIdCaseRelaInfo, List<clsvCaseRelaInfoEN> lstvCaseRelaInfoObjLst)
{
foreach (clsvCaseRelaInfoEN objvCaseRelaInfoEN in lstvCaseRelaInfoObjLst)
{
if (objvCaseRelaInfoEN.IdCaseRelaInfo == lngIdCaseRelaInfo)
{
return objvCaseRelaInfoEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdCaseRelaInfo;
 try
 {
 lngIdCaseRelaInfo = new clsvCaseRelaInfoDA().GetFirstID(strWhereCond);
 return lngIdCaseRelaInfo;
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
 arrList = vCaseRelaInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vCaseRelaInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdCaseRelaInfo)
{
//检测记录是否存在
bool bolIsExist = vCaseRelaInfoDA.IsExist(lngIdCaseRelaInfo);
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
 bolIsExist = clsvCaseRelaInfoDA.IsExistTable();
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
 bolIsExist = vCaseRelaInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvCaseRelaInfoEN objvCaseRelaInfoENS, clsvCaseRelaInfoEN objvCaseRelaInfoENT)
{
try
{
objvCaseRelaInfoENT.IdCaseRelaInfo = objvCaseRelaInfoENS.IdCaseRelaInfo; //案例相关信息流水号
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
objvCaseRelaInfoENT.IdCaseRelaInfoType = objvCaseRelaInfoENS.IdCaseRelaInfoType; //案例相关信息类型流水号
objvCaseRelaInfoENT.CaseRelaInfoTypeName = objvCaseRelaInfoENS.CaseRelaInfoTypeName; //案例相关信息类型名称
objvCaseRelaInfoENT.RelationsDegree = objvCaseRelaInfoENS.RelationsDegree; //关系度
objvCaseRelaInfoENT.BrowseCount = objvCaseRelaInfoENS.BrowseCount; //浏览次数
objvCaseRelaInfoENT.UpdUserId = objvCaseRelaInfoENS.UpdUserId; //修改用户Id
objvCaseRelaInfoENT.UpdDate = objvCaseRelaInfoENS.UpdDate; //修改日期
objvCaseRelaInfoENT.Memo = objvCaseRelaInfoENS.Memo; //备注
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
 /// <param name = "objvCaseRelaInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvCaseRelaInfoEN objvCaseRelaInfoEN)
{
try
{
objvCaseRelaInfoEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCaseRelaInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCaseRelaInfo.IdCaseRelaInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.IdCaseRelaInfo = objvCaseRelaInfoEN.IdCaseRelaInfo; //案例相关信息流水号
}
if (arrFldSet.Contains(convCaseRelaInfo.FuncModuleId1, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.FuncModuleId1 = objvCaseRelaInfoEN.FuncModuleId1; //功能模块Id1
}
if (arrFldSet.Contains(convCaseRelaInfo.FuncModuleName1, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.FuncModuleName1 = objvCaseRelaInfoEN.FuncModuleName1 == "[null]" ? null :  objvCaseRelaInfoEN.FuncModuleName1; //功能模块名称1
}
if (arrFldSet.Contains(convCaseRelaInfo.CaseId1, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.CaseId1 = objvCaseRelaInfoEN.CaseId1; //案例Id1
}
if (arrFldSet.Contains(convCaseRelaInfo.CaseName1, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.CaseName1 = objvCaseRelaInfoEN.CaseName1; //案例名称1
}
if (arrFldSet.Contains(convCaseRelaInfo.OwnerId1, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.OwnerId1 = objvCaseRelaInfoEN.OwnerId1; //拥有者Id1
}
if (arrFldSet.Contains(convCaseRelaInfo.OwnerName1, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.OwnerName1 = objvCaseRelaInfoEN.OwnerName1 == "[null]" ? null :  objvCaseRelaInfoEN.OwnerName1; //拥有者姓名1
}
if (arrFldSet.Contains(convCaseRelaInfo.FuncModuleId2, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.FuncModuleId2 = objvCaseRelaInfoEN.FuncModuleId2; //功能模块Id2
}
if (arrFldSet.Contains(convCaseRelaInfo.FuncModuleName2, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.FuncModuleName2 = objvCaseRelaInfoEN.FuncModuleName2 == "[null]" ? null :  objvCaseRelaInfoEN.FuncModuleName2; //功能模块名称2
}
if (arrFldSet.Contains(convCaseRelaInfo.CaseId2, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.CaseId2 = objvCaseRelaInfoEN.CaseId2; //案例Id2
}
if (arrFldSet.Contains(convCaseRelaInfo.CaseName2, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.CaseName2 = objvCaseRelaInfoEN.CaseName2; //案例名称2
}
if (arrFldSet.Contains(convCaseRelaInfo.OwnerId2, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.OwnerId2 = objvCaseRelaInfoEN.OwnerId2; //拥有者Id2
}
if (arrFldSet.Contains(convCaseRelaInfo.OwnerName2, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.OwnerName2 = objvCaseRelaInfoEN.OwnerName2 == "[null]" ? null :  objvCaseRelaInfoEN.OwnerName2; //拥有者姓名2
}
if (arrFldSet.Contains(convCaseRelaInfo.IdCaseRelaInfoType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.IdCaseRelaInfoType = objvCaseRelaInfoEN.IdCaseRelaInfoType; //案例相关信息类型流水号
}
if (arrFldSet.Contains(convCaseRelaInfo.CaseRelaInfoTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objvCaseRelaInfoEN.CaseRelaInfoTypeName; //案例相关信息类型名称
}
if (arrFldSet.Contains(convCaseRelaInfo.RelationsDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.RelationsDegree = objvCaseRelaInfoEN.RelationsDegree; //关系度
}
if (arrFldSet.Contains(convCaseRelaInfo.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.BrowseCount = objvCaseRelaInfoEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convCaseRelaInfo.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.UpdUserId = objvCaseRelaInfoEN.UpdUserId == "[null]" ? null :  objvCaseRelaInfoEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convCaseRelaInfo.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.UpdDate = objvCaseRelaInfoEN.UpdDate == "[null]" ? null :  objvCaseRelaInfoEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCaseRelaInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCaseRelaInfoEN.Memo = objvCaseRelaInfoEN.Memo == "[null]" ? null :  objvCaseRelaInfoEN.Memo; //备注
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
 /// <param name = "objvCaseRelaInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCaseRelaInfoEN objvCaseRelaInfoEN)
{
try
{
if (objvCaseRelaInfoEN.FuncModuleName1 == "[null]") objvCaseRelaInfoEN.FuncModuleName1 = null; //功能模块名称1
if (objvCaseRelaInfoEN.OwnerName1 == "[null]") objvCaseRelaInfoEN.OwnerName1 = null; //拥有者姓名1
if (objvCaseRelaInfoEN.FuncModuleName2 == "[null]") objvCaseRelaInfoEN.FuncModuleName2 = null; //功能模块名称2
if (objvCaseRelaInfoEN.OwnerName2 == "[null]") objvCaseRelaInfoEN.OwnerName2 = null; //拥有者姓名2
if (objvCaseRelaInfoEN.UpdUserId == "[null]") objvCaseRelaInfoEN.UpdUserId = null; //修改用户Id
if (objvCaseRelaInfoEN.UpdDate == "[null]") objvCaseRelaInfoEN.UpdDate = null; //修改日期
if (objvCaseRelaInfoEN.Memo == "[null]") objvCaseRelaInfoEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvCaseRelaInfoEN objvCaseRelaInfoEN)
{
 vCaseRelaInfoDA.CheckProperty4Condition(objvCaseRelaInfoEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseRelaInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseRelaInfoBL没有刷新缓存机制(clsCaseRelaInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseRelaInfoTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseRelaInfoTypeBL没有刷新缓存机制(clsCaseRelaInfoTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCaseRelaInfo");
//if (arrvCaseRelaInfoObjLstCache == null)
//{
//arrvCaseRelaInfoObjLstCache = vCaseRelaInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseRelaInfoEN GetObjByIdCaseRelaInfoCache(long lngIdCaseRelaInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCaseRelaInfoEN._CurrTabName);
List<clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLst_Sel =
arrvCaseRelaInfoObjLstCache
.Where(x=> x.IdCaseRelaInfo == lngIdCaseRelaInfo 
);
if (arrvCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvCaseRelaInfoEN obj = clsvCaseRelaInfoBL.GetObjByIdCaseRelaInfo(lngIdCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseRelaInfoEN> GetAllvCaseRelaInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLstCache = GetObjLstCache(); 
return arrvCaseRelaInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCaseRelaInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCaseRelaInfoEN._CurrTabName);
List<clsvCaseRelaInfoEN> arrvCaseRelaInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseRelaInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvCaseRelaInfoEN._CurrTabName);
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
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdCaseRelaInfo)
{
if (strInFldName != convCaseRelaInfo.IdCaseRelaInfo)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCaseRelaInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCaseRelaInfo.AttributeName));
throw new Exception(strMsg);
}
var objvCaseRelaInfo = clsvCaseRelaInfoBL.GetObjByIdCaseRelaInfoCache(lngIdCaseRelaInfo);
if (objvCaseRelaInfo == null) return "";
return objvCaseRelaInfo[strOutFldName].ToString();
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
int intRecCount = clsvCaseRelaInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvCaseRelaInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCaseRelaInfoDA.GetRecCount();
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
int intRecCount = clsvCaseRelaInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCaseRelaInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCaseRelaInfoEN objvCaseRelaInfoCond)
{
List<clsvCaseRelaInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCaseRelaInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCaseRelaInfo.AttributeName)
{
if (objvCaseRelaInfoCond.IsUpdated(strFldName) == false) continue;
if (objvCaseRelaInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseRelaInfoCond[strFldName].ToString());
}
else
{
if (objvCaseRelaInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCaseRelaInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCaseRelaInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCaseRelaInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCaseRelaInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCaseRelaInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCaseRelaInfoCond[strFldName]));
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
 List<string> arrList = clsvCaseRelaInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCaseRelaInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCaseRelaInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}