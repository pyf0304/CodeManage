
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseRelaInfoWApi
 表名:vEduMSTRGiftedClsCaseRelaInfo(01120402)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:31
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评
 模块英文名:EduMSTRGiftedCls
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
public static class clsvEduMSTRGiftedClsCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetEduMSTRGiftedClsCaseID(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strEduMSTRGiftedClsCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID);
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseID = strEduMSTRGiftedClsCaseID; //教育硕士优课案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFuncModuleId(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId);
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFuncModuleName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName);
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN Setid_MicroteachCase(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase);
objvEduMSTRGiftedClsCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN Setid_EduMSTRGiftedClsCase(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strid_EduMSTRGiftedClsCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase);
objvEduMSTRGiftedClsCaseRelaInfoEN.id_EduMSTRGiftedClsCase = strid_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetEduMSTRGiftedClsCaseName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strEduMSTRGiftedClsCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName);
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseName = strEduMSTRGiftedClsCaseName; //教育硕士优课案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN Setid_XzCollege(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege);
objvEduMSTRGiftedClsCaseRelaInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetCollegeID(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convEduMSTRGiftedClsCaseRelaInfo.CollegeID);
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.CollegeID) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.CollegeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.CollegeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetCollegeName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convEduMSTRGiftedClsCaseRelaInfo.CollegeName);
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.CollegeName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.CollegeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.CollegeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetCollegeNameA(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA);
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetMajorName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convEduMSTRGiftedClsCaseRelaInfo.MajorName);
objvEduMSTRGiftedClsCaseRelaInfoEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.MajorName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.MajorName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.MajorName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN Setid_Resource(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convEduMSTRGiftedClsCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convEduMSTRGiftedClsCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convEduMSTRGiftedClsCaseRelaInfo.id_Resource);
objvEduMSTRGiftedClsCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.id_Resource) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetResourceID(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convEduMSTRGiftedClsCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convEduMSTRGiftedClsCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convEduMSTRGiftedClsCaseRelaInfo.ResourceID);
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.ResourceID) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetResourceName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convEduMSTRGiftedClsCaseRelaInfo.ResourceName);
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.ResourceName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN Setid_FtpResource(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource);
objvEduMSTRGiftedClsCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN Setid_File(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convEduMSTRGiftedClsCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convEduMSTRGiftedClsCaseRelaInfo.id_File);
objvEduMSTRGiftedClsCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.id_File) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convEduMSTRGiftedClsCaseRelaInfo.FileName);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileType(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convEduMSTRGiftedClsCaseRelaInfo.FileType);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileType) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetSaveDate(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convEduMSTRGiftedClsCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convEduMSTRGiftedClsCaseRelaInfo.SaveDate);
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.SaveDate) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileSize(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convEduMSTRGiftedClsCaseRelaInfo.FileSize);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileSize) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetSaveTime(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convEduMSTRGiftedClsCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convEduMSTRGiftedClsCaseRelaInfo.SaveTime);
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.SaveTime) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFtpResourceID(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID);
objvEduMSTRGiftedClsCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileOriginalName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileDirName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convEduMSTRGiftedClsCaseRelaInfo.FileDirName);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileDirName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileRename(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convEduMSTRGiftedClsCaseRelaInfo.FileRename);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileRename) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileUpDate(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convEduMSTRGiftedClsCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convEduMSTRGiftedClsCaseRelaInfo.FileUpDate);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileUpDate) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileUpTime(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convEduMSTRGiftedClsCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convEduMSTRGiftedClsCaseRelaInfo.FileUpTime);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileUpTime) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetSaveMode(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.SaveMode) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN Setid_ResourceType(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType);
objvEduMSTRGiftedClsCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetResourceTypeID(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID);
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetResourceTypeName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName);
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetResourceOwner(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner);
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetftpFileType(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convEduMSTRGiftedClsCaseRelaInfo.ftpFileType);
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.ftpFileType) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetftpFileSize(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize);
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetftpResourceOwner(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner);
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileOriginName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convEduMSTRGiftedClsCaseRelaInfo.FileOriginName);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileOriginName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetIsExistFile(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.IsExistFile) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileNewName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convEduMSTRGiftedClsCaseRelaInfo.FileNewName);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileNewName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFileOldName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convEduMSTRGiftedClsCaseRelaInfo.FileOldName);
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.FileOldName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroTeachCaseRelaInfoType, convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvEduMSTRGiftedClsCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroTeachCaseRelaInfoTypeName, convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvEduMSTRGiftedClsCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetIsVisible(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.IsVisible) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetBrowseCount(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.BrowseCount) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetFlag(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convEduMSTRGiftedClsCaseRelaInfo.Flag);
objvEduMSTRGiftedClsCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.Flag) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetUpdDate(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convEduMSTRGiftedClsCaseRelaInfo.UpdDate);
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.UpdDate) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetUpdUser(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convEduMSTRGiftedClsCaseRelaInfo.UpdUser);
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.UpdUser) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN SetMemo(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convEduMSTRGiftedClsCaseRelaInfo.Memo);
objvEduMSTRGiftedClsCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseRelaInfo.Memo) == false)
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseRelaInfoEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID, objvEduMSTRGiftedClsCaseRelaInfo_Cond.EduMSTRGiftedClsCaseID, strComparisonOp_EduMSTRGiftedClsCaseID);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvEduMSTRGiftedClsCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase, objvEduMSTRGiftedClsCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase, objvEduMSTRGiftedClsCaseRelaInfo_Cond.id_EduMSTRGiftedClsCase, strComparisonOp_id_EduMSTRGiftedClsCase);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.EduMSTRGiftedClsCaseName, strComparisonOp_EduMSTRGiftedClsCaseName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege, objvEduMSTRGiftedClsCaseRelaInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.CollegeID, objvEduMSTRGiftedClsCaseRelaInfo_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.CollegeName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA, objvEduMSTRGiftedClsCaseRelaInfo_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.MajorName) == true)
{
string strComparisonOp_MajorName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.MajorName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.id_Resource, objvEduMSTRGiftedClsCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.ResourceID, objvEduMSTRGiftedClsCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.ResourceName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource, objvEduMSTRGiftedClsCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.id_File, objvEduMSTRGiftedClsCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileType, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.SaveDate, objvEduMSTRGiftedClsCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileSize, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.SaveTime, objvEduMSTRGiftedClsCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileDirName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileRename, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileUpDate, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileUpTime, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.SaveMode) == true)
{
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCaseRelaInfo.SaveMode);
}
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType, objvEduMSTRGiftedClsCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID, objvEduMSTRGiftedClsCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner, objvEduMSTRGiftedClsCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.ftpFileType, objvEduMSTRGiftedClsCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize, objvEduMSTRGiftedClsCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner, objvEduMSTRGiftedClsCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileOriginName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.IsExistFile) == true)
{
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCaseRelaInfo.IsExistFile);
}
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileNewName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.FileOldName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvEduMSTRGiftedClsCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvEduMSTRGiftedClsCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.IsVisible) == true)
{
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCaseRelaInfo.IsVisible);
}
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCaseRelaInfo.BrowseCount, objvEduMSTRGiftedClsCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.Flag, objvEduMSTRGiftedClsCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.UpdDate, objvEduMSTRGiftedClsCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.UpdUser, objvEduMSTRGiftedClsCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvEduMSTRGiftedClsCaseRelaInfo_Cond.IsUpdated(convEduMSTRGiftedClsCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvEduMSTRGiftedClsCaseRelaInfo_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseRelaInfo.Memo, objvEduMSTRGiftedClsCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教育硕士优课案例相关信息(vEduMSTRGiftedClsCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvEduMSTRGiftedClsCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vEduMSTRGiftedClsCaseRelaInfoApi";

 public clsvEduMSTRGiftedClsCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroTeachCaseRelaInfo"] = lngid_MicroTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvEduMSTRGiftedClsCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCaseRelaInfoEN;
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
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroTeachCaseRelaInfo"] = lngid_MicroTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvEduMSTRGiftedClsCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCaseRelaInfoEN;
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
public static clsvEduMSTRGiftedClsCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN = null;
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
objvEduMSTRGiftedClsCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCaseRelaInfoEN;
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
 /// <param name = "lngid_MicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvEduMSTRGiftedClsCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseRelaInfoEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCaseRelaInfoEN> arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Sel =
from objvEduMSTRGiftedClsCaseRelaInfoEN in arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Cache
where objvEduMSTRGiftedClsCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvEduMSTRGiftedClsCaseRelaInfoEN;
if (arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvEduMSTRGiftedClsCaseRelaInfoEN obj = clsvEduMSTRGiftedClsCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroTeachCaseRelaInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseRelaInfoEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCaseRelaInfoEN> arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Sel =
from objvEduMSTRGiftedClsCaseRelaInfoEN in arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvEduMSTRGiftedClsCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvEduMSTRGiftedClsCaseRelaInfoEN;
return arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroTeachCaseRelaInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroTeachCaseRelaInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroTeachCaseRelaInfo"] = lngid_MicroTeachCaseRelaInfo.ToString()
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
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoENS, clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoENT)
{
try
{
objvEduMSTRGiftedClsCaseRelaInfoENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseRelaInfoENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvEduMSTRGiftedClsCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.FuncModuleId = objvEduMSTRGiftedClsCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvEduMSTRGiftedClsCaseRelaInfoENT.FuncModuleName = objvEduMSTRGiftedClsCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvEduMSTRGiftedClsCaseRelaInfoENT.id_MicroteachCase = objvEduMSTRGiftedClsCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseRelaInfoENS.id_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseRelaInfoENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseRelaInfoENT.id_XzCollege = objvEduMSTRGiftedClsCaseRelaInfoENS.id_XzCollege; //学院流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.CollegeID = objvEduMSTRGiftedClsCaseRelaInfoENS.CollegeID; //学院ID
objvEduMSTRGiftedClsCaseRelaInfoENT.CollegeName = objvEduMSTRGiftedClsCaseRelaInfoENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCaseRelaInfoENT.CollegeNameA = objvEduMSTRGiftedClsCaseRelaInfoENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCaseRelaInfoENT.MajorName = objvEduMSTRGiftedClsCaseRelaInfoENS.MajorName; //专业名称
objvEduMSTRGiftedClsCaseRelaInfoENT.id_Resource = objvEduMSTRGiftedClsCaseRelaInfoENS.id_Resource; //资源流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceID = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceID; //资源ID
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceName = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceName; //资源名称
objvEduMSTRGiftedClsCaseRelaInfoENT.id_FtpResource = objvEduMSTRGiftedClsCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.id_File = objvEduMSTRGiftedClsCaseRelaInfoENS.id_File; //文件流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.FileName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileName; //文件名称
objvEduMSTRGiftedClsCaseRelaInfoENT.FileType = objvEduMSTRGiftedClsCaseRelaInfoENS.FileType; //文件类型
objvEduMSTRGiftedClsCaseRelaInfoENT.SaveDate = objvEduMSTRGiftedClsCaseRelaInfoENS.SaveDate; //创建日期
objvEduMSTRGiftedClsCaseRelaInfoENT.FileSize = objvEduMSTRGiftedClsCaseRelaInfoENS.FileSize; //文件大小
objvEduMSTRGiftedClsCaseRelaInfoENT.SaveTime = objvEduMSTRGiftedClsCaseRelaInfoENS.SaveTime; //创建时间
objvEduMSTRGiftedClsCaseRelaInfoENT.FtpResourceID = objvEduMSTRGiftedClsCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvEduMSTRGiftedClsCaseRelaInfoENT.FileOriginalName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileOriginalName; //文件原名
objvEduMSTRGiftedClsCaseRelaInfoENT.FileDirName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileDirName; //文件目录名
objvEduMSTRGiftedClsCaseRelaInfoENT.FileRename = objvEduMSTRGiftedClsCaseRelaInfoENS.FileRename; //文件新名
objvEduMSTRGiftedClsCaseRelaInfoENT.FileUpDate = objvEduMSTRGiftedClsCaseRelaInfoENS.FileUpDate; //创建日期
objvEduMSTRGiftedClsCaseRelaInfoENT.FileUpTime = objvEduMSTRGiftedClsCaseRelaInfoENS.FileUpTime; //创建时间
objvEduMSTRGiftedClsCaseRelaInfoENT.SaveMode = objvEduMSTRGiftedClsCaseRelaInfoENS.SaveMode; //文件存放方式
objvEduMSTRGiftedClsCaseRelaInfoENT.id_ResourceType = objvEduMSTRGiftedClsCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceTypeID = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceTypeName = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceOwner = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceOwner; //上传者
objvEduMSTRGiftedClsCaseRelaInfoENT.ftpFileType = objvEduMSTRGiftedClsCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvEduMSTRGiftedClsCaseRelaInfoENT.ftpFileSize = objvEduMSTRGiftedClsCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvEduMSTRGiftedClsCaseRelaInfoENT.ftpResourceOwner = objvEduMSTRGiftedClsCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvEduMSTRGiftedClsCaseRelaInfoENT.FileOriginName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileOriginName; //原文件名
objvEduMSTRGiftedClsCaseRelaInfoENT.IsExistFile = objvEduMSTRGiftedClsCaseRelaInfoENS.IsExistFile; //是否存在文件
objvEduMSTRGiftedClsCaseRelaInfoENT.FileNewName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileNewName; //新文件名
objvEduMSTRGiftedClsCaseRelaInfoENT.FileOldName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileOldName; //旧文件名
objvEduMSTRGiftedClsCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvEduMSTRGiftedClsCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvEduMSTRGiftedClsCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvEduMSTRGiftedClsCaseRelaInfoENT.IsVisible = objvEduMSTRGiftedClsCaseRelaInfoENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCaseRelaInfoENT.BrowseCount = objvEduMSTRGiftedClsCaseRelaInfoENS.BrowseCount; //浏览次数
objvEduMSTRGiftedClsCaseRelaInfoENT.Flag = objvEduMSTRGiftedClsCaseRelaInfoENS.Flag; //标志
objvEduMSTRGiftedClsCaseRelaInfoENT.UpdDate = objvEduMSTRGiftedClsCaseRelaInfoENS.UpdDate; //修改日期
objvEduMSTRGiftedClsCaseRelaInfoENT.UpdUser = objvEduMSTRGiftedClsCaseRelaInfoENS.UpdUser; //修改人
objvEduMSTRGiftedClsCaseRelaInfoENT.Memo = objvEduMSTRGiftedClsCaseRelaInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvEduMSTRGiftedClsCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvEduMSTRGiftedClsCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvEduMSTRGiftedClsCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvEduMSTRGiftedClsCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvEduMSTRGiftedClsCaseRelaInfoEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroTeachCaseRelaInfoTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoTypeWApi没有刷新缓存机制(clsMicroTeachCaseRelaInfoTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroTeachCaseRelaInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoWApi没有刷新缓存机制(clsMicroTeachCaseRelaInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceWApi没有刷新缓存机制(clsResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerWApi没有刷新缓存机制(clsFileServerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsEduMSTRGiftedClsCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsEduMSTRGiftedClsCaseWApi没有刷新缓存机制(clsEduMSTRGiftedClsCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsEduMSTRGiftedClsCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsEduMSTRGiftedClsCaseTypeWApi没有刷新缓存机制(clsEduMSTRGiftedClsCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroTeachCaseRelaInfo");
//if (arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Cache == null)
//{
//arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Cache = await clsvEduMSTRGiftedClsCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseRelaInfoEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvEduMSTRGiftedClsCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsvEduMSTRGiftedClsCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID];
objDR[convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.id_MicroteachCase];
objDR[convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.id_EduMSTRGiftedClsCase];
objDR[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.id_XzCollege];
objDR[convEduMSTRGiftedClsCaseRelaInfo.CollegeID] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.CollegeID];
objDR[convEduMSTRGiftedClsCaseRelaInfo.CollegeName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.CollegeName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA];
objDR[convEduMSTRGiftedClsCaseRelaInfo.MajorName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.MajorName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.id_Resource] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.id_Resource];
objDR[convEduMSTRGiftedClsCaseRelaInfo.ResourceID] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.ResourceID];
objDR[convEduMSTRGiftedClsCaseRelaInfo.ResourceName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.ResourceName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.id_FtpResource];
objDR[convEduMSTRGiftedClsCaseRelaInfo.id_File] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.id_File];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileType] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileType];
objDR[convEduMSTRGiftedClsCaseRelaInfo.SaveDate] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.SaveDate];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileSize] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileSize];
objDR[convEduMSTRGiftedClsCaseRelaInfo.SaveTime] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.SaveTime];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileDirName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileDirName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileRename] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileRename];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime];
objDR[convEduMSTRGiftedClsCaseRelaInfo.SaveMode] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.SaveMode];
objDR[convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.id_ResourceType];
objDR[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID];
objDR[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner];
objDR[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType];
objDR[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize];
objDR[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.IsExistFile] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.IsExistFile];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileNewName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileNewName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.FileOldName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.FileOldName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convEduMSTRGiftedClsCaseRelaInfo.IsVisible] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.IsVisible];
objDR[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount];
objDR[convEduMSTRGiftedClsCaseRelaInfo.Flag] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.Flag];
objDR[convEduMSTRGiftedClsCaseRelaInfo.UpdDate] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.UpdDate];
objDR[convEduMSTRGiftedClsCaseRelaInfo.UpdUser] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.UpdUser];
objDR[convEduMSTRGiftedClsCaseRelaInfo.Memo] = objInFor[convEduMSTRGiftedClsCaseRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}