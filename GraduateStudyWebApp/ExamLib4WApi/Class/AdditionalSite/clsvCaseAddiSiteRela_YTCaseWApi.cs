
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseAddiSiteRela_YTCaseWApi
 表名:vCaseAddiSiteRela_YTCase(01120518)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:16
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:附加网站
 模块英文名:AdditionalSite
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
public static class clsvCaseAddiSiteRela_YTCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetmId(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, long lngmId, string strComparisonOp="")
	{
objvCaseAddiSiteRela_YTCaseEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.mId) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.mId, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.mId] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetId_DecompressionFile(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, long lngId_DecompressionFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngId_DecompressionFile, convCaseAddiSiteRela_YTCase.Id_DecompressionFile);
objvCaseAddiSiteRela_YTCaseEN.Id_DecompressionFile = lngId_DecompressionFile; //解压缩文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.Id_DecompressionFile) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.Id_DecompressionFile, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.Id_DecompressionFile] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetFileName(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convCaseAddiSiteRela_YTCase.FileName);
objvCaseAddiSiteRela_YTCaseEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.FileName) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.FileName, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.FileName] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetId_Case(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strId_Case, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_Case, convCaseAddiSiteRela_YTCase.Id_Case);
clsCheckSql.CheckFieldLen(strId_Case, 8, convCaseAddiSiteRela_YTCase.Id_Case);
clsCheckSql.CheckFieldForeignKey(strId_Case, 8, convCaseAddiSiteRela_YTCase.Id_Case);
objvCaseAddiSiteRela_YTCaseEN.Id_Case = strId_Case; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.Id_Case) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.Id_Case, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.Id_Case] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetTeacherID(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherID, 12, convCaseAddiSiteRela_YTCase.TeacherID);
objvCaseAddiSiteRela_YTCaseEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.TeacherID) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.TeacherID, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.TeacherID] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetTeacherName(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherName, 50, convCaseAddiSiteRela_YTCase.TeacherName);
objvCaseAddiSiteRela_YTCaseEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.TeacherName) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.TeacherName, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.TeacherName] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetCollegeName(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCaseAddiSiteRela_YTCase.CollegeName);
objvCaseAddiSiteRela_YTCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.CollegeName) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.CollegeName, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.CollegeName] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetCollegeNameA(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convCaseAddiSiteRela_YTCase.CollegeNameA);
objvCaseAddiSiteRela_YTCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.CollegeNameA) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.CollegeNameA, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.CollegeNameA] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetFuncModuleId(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseAddiSiteRela_YTCase.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseAddiSiteRela_YTCase.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseAddiSiteRela_YTCase.FuncModuleId);
objvCaseAddiSiteRela_YTCaseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.FuncModuleId) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.FuncModuleId, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.FuncModuleId] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetFuncModuleName(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseAddiSiteRela_YTCase.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseAddiSiteRela_YTCase.FuncModuleName);
objvCaseAddiSiteRela_YTCaseEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.FuncModuleName) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.FuncModuleName, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.FuncModuleName] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetUpdDate(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseAddiSiteRela_YTCase.UpdDate);
objvCaseAddiSiteRela_YTCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.UpdDate) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.UpdDate, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.UpdDate] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetUpdUser(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCaseAddiSiteRela_YTCase.UpdUser);
objvCaseAddiSiteRela_YTCaseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.UpdUser) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.UpdUser, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.UpdUser] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetMemo(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseAddiSiteRela_YTCase.Memo);
objvCaseAddiSiteRela_YTCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.Memo) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.Memo, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.Memo] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetCaseId(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseId, 8, convCaseAddiSiteRela_YTCase.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, convCaseAddiSiteRela_YTCase.CaseId);
objvCaseAddiSiteRela_YTCaseEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.CaseId) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.CaseId, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.CaseId] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRela_YTCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRela_YTCaseEN SetCaseName(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, convCaseAddiSiteRela_YTCase.CaseName);
objvCaseAddiSiteRela_YTCaseEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela_YTCase.CaseName) == false)
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp.Add(convCaseAddiSiteRela_YTCase.CaseName, strComparisonOp);
}
else
{
objvCaseAddiSiteRela_YTCaseEN.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.CaseName] = strComparisonOp;
}
}
return objvCaseAddiSiteRela_YTCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.mId) == true)
{
string strComparisonOp_mId = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseAddiSiteRela_YTCase.mId, objvCaseAddiSiteRela_YTCase_Cond.mId, strComparisonOp_mId);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.Id_DecompressionFile) == true)
{
string strComparisonOp_Id_DecompressionFile = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.Id_DecompressionFile];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseAddiSiteRela_YTCase.Id_DecompressionFile, objvCaseAddiSiteRela_YTCase_Cond.Id_DecompressionFile, strComparisonOp_Id_DecompressionFile);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.FileName) == true)
{
string strComparisonOp_FileName = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.FileName, objvCaseAddiSiteRela_YTCase_Cond.FileName, strComparisonOp_FileName);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.Id_Case) == true)
{
string strComparisonOp_Id_Case = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.Id_Case];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.Id_Case, objvCaseAddiSiteRela_YTCase_Cond.Id_Case, strComparisonOp_Id_Case);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.TeacherID, objvCaseAddiSiteRela_YTCase_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.TeacherName, objvCaseAddiSiteRela_YTCase_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.CollegeName, objvCaseAddiSiteRela_YTCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.CollegeNameA, objvCaseAddiSiteRela_YTCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.FuncModuleId, objvCaseAddiSiteRela_YTCase_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.FuncModuleName, objvCaseAddiSiteRela_YTCase_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.UpdDate, objvCaseAddiSiteRela_YTCase_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.UpdUser, objvCaseAddiSiteRela_YTCase_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.Memo) == true)
{
string strComparisonOp_Memo = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.Memo, objvCaseAddiSiteRela_YTCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.CaseId) == true)
{
string strComparisonOp_CaseId = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.CaseId, objvCaseAddiSiteRela_YTCase_Cond.CaseId, strComparisonOp_CaseId);
}
if (objvCaseAddiSiteRela_YTCase_Cond.IsUpdated(convCaseAddiSiteRela_YTCase.CaseName) == true)
{
string strComparisonOp_CaseName = objvCaseAddiSiteRela_YTCase_Cond.dicFldComparisonOp[convCaseAddiSiteRela_YTCase.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela_YTCase.CaseName, objvCaseAddiSiteRela_YTCase_Cond.CaseName, strComparisonOp_CaseName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例和附加网站关系_青教评优(vCaseAddiSiteRela_YTCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCaseAddiSiteRela_YTCaseWApi
{
private static readonly string mstrApiControllerName = "vCaseAddiSiteRela_YTCaseApi";

 public clsvCaseAddiSiteRela_YTCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseAddiSiteRela_YTCaseEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseAddiSiteRela_YTCaseEN = JsonConvert.DeserializeObject<clsvCaseAddiSiteRela_YTCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCaseAddiSiteRela_YTCaseEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseAddiSiteRela_YTCaseEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseAddiSiteRela_YTCaseEN = JsonConvert.DeserializeObject<clsvCaseAddiSiteRela_YTCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCaseAddiSiteRela_YTCaseEN;
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
public static clsvCaseAddiSiteRela_YTCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseEN = null;
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
objvCaseAddiSiteRela_YTCaseEN = JsonConvert.DeserializeObject<clsvCaseAddiSiteRela_YTCaseEN>((string)jobjReturn["ReturnObj"]);
return objvCaseAddiSiteRela_YTCaseEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseAddiSiteRela_YTCaseEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseAddiSiteRela_YTCaseEN._CurrTabName_S);
List<clsvCaseAddiSiteRela_YTCaseEN> arrvCaseAddiSiteRela_YTCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseAddiSiteRela_YTCaseEN> arrvCaseAddiSiteRela_YTCaseObjLst_Sel =
from objvCaseAddiSiteRela_YTCaseEN in arrvCaseAddiSiteRela_YTCaseObjLst_Cache
where objvCaseAddiSiteRela_YTCaseEN.mId == lngmId
select objvCaseAddiSiteRela_YTCaseEN;
if (arrvCaseAddiSiteRela_YTCaseObjLst_Sel.Count() == 0)
{
   clsvCaseAddiSiteRela_YTCaseEN obj = clsvCaseAddiSiteRela_YTCaseWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCaseAddiSiteRela_YTCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseAddiSiteRela_YTCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvCaseAddiSiteRela_YTCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRela_YTCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRela_YTCaseEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCaseAddiSiteRela_YTCaseEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRela_YTCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCaseAddiSiteRela_YTCaseEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseAddiSiteRela_YTCaseEN._CurrTabName_S);
List<clsvCaseAddiSiteRela_YTCaseEN> arrvCaseAddiSiteRela_YTCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseAddiSiteRela_YTCaseEN> arrvCaseAddiSiteRela_YTCaseObjLst_Sel =
from objvCaseAddiSiteRela_YTCaseEN in arrvCaseAddiSiteRela_YTCaseObjLst_Cache
where arrMId.Contains(objvCaseAddiSiteRela_YTCaseEN.mId)
select objvCaseAddiSiteRela_YTCaseEN;
return arrvCaseAddiSiteRela_YTCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseAddiSiteRela_YTCaseEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvCaseAddiSiteRela_YTCaseEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRela_YTCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRela_YTCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCaseAddiSiteRela_YTCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRela_YTCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRela_YTCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCaseAddiSiteRela_YTCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRela_YTCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRela_YTCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCaseAddiSiteRela_YTCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRela_YTCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRela_YTCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCaseAddiSiteRela_YTCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRela_YTCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvCaseAddiSiteRela_YTCaseENS">源对象</param>
 /// <param name = "objvCaseAddiSiteRela_YTCaseENT">目标对象</param>
 public static void CopyTo(clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseENS, clsvCaseAddiSiteRela_YTCaseEN objvCaseAddiSiteRela_YTCaseENT)
{
try
{
objvCaseAddiSiteRela_YTCaseENT.mId = objvCaseAddiSiteRela_YTCaseENS.mId; //mId
objvCaseAddiSiteRela_YTCaseENT.Id_DecompressionFile = objvCaseAddiSiteRela_YTCaseENS.Id_DecompressionFile; //解压缩文件流水号
objvCaseAddiSiteRela_YTCaseENT.FileName = objvCaseAddiSiteRela_YTCaseENS.FileName; //文件名称
objvCaseAddiSiteRela_YTCaseENT.Id_Case = objvCaseAddiSiteRela_YTCaseENS.Id_Case; //案例流水号
objvCaseAddiSiteRela_YTCaseENT.TeacherID = objvCaseAddiSiteRela_YTCaseENS.TeacherID; //教师工号
objvCaseAddiSiteRela_YTCaseENT.TeacherName = objvCaseAddiSiteRela_YTCaseENS.TeacherName; //教师姓名
objvCaseAddiSiteRela_YTCaseENT.CollegeName = objvCaseAddiSiteRela_YTCaseENS.CollegeName; //学院名称
objvCaseAddiSiteRela_YTCaseENT.CollegeNameA = objvCaseAddiSiteRela_YTCaseENS.CollegeNameA; //学院名称简写
objvCaseAddiSiteRela_YTCaseENT.FuncModuleId = objvCaseAddiSiteRela_YTCaseENS.FuncModuleId; //功能模块Id
objvCaseAddiSiteRela_YTCaseENT.FuncModuleName = objvCaseAddiSiteRela_YTCaseENS.FuncModuleName; //功能模块名称
objvCaseAddiSiteRela_YTCaseENT.UpdDate = objvCaseAddiSiteRela_YTCaseENS.UpdDate; //修改日期
objvCaseAddiSiteRela_YTCaseENT.UpdUser = objvCaseAddiSiteRela_YTCaseENS.UpdUser; //修改人
objvCaseAddiSiteRela_YTCaseENT.Memo = objvCaseAddiSiteRela_YTCaseENS.Memo; //备注
objvCaseAddiSiteRela_YTCaseENT.CaseId = objvCaseAddiSiteRela_YTCaseENS.CaseId; //案例Id
objvCaseAddiSiteRela_YTCaseENT.CaseName = objvCaseAddiSiteRela_YTCaseENS.CaseName; //案例名称
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
public static DataTable ToDataTable(List<clsvCaseAddiSiteRela_YTCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCaseAddiSiteRela_YTCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCaseAddiSiteRela_YTCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCaseAddiSiteRela_YTCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCaseAddiSiteRela_YTCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCaseAddiSiteRela_YTCaseEN.AttributeName)
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
if (clsCaseAddiSiteRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseAddiSiteRelaWApi没有刷新缓存机制(clsCaseAddiSiteRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDecompressionFileWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDecompressionFileWApi没有刷新缓存机制(clsDecompressionFileWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsYoungTAppraisedCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsYoungTAppraisedCaseWApi没有刷新缓存机制(clsYoungTAppraisedCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsYoungTAppraisedCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsYoungTAppraisedCaseTypeWApi没有刷新缓存机制(clsYoungTAppraisedCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCaseAddiSiteRela_YTCaseObjLst_Cache == null)
//{
//arrvCaseAddiSiteRela_YTCaseObjLst_Cache = await clsvCaseAddiSiteRela_YTCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCaseAddiSiteRela_YTCaseEN._CurrTabName_S);
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
public static List<clsvCaseAddiSiteRela_YTCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCaseAddiSiteRela_YTCaseEN._CurrTabName_S);
List<clsvCaseAddiSiteRela_YTCaseEN> arrvCaseAddiSiteRela_YTCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseAddiSiteRela_YTCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCaseAddiSiteRela_YTCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.Id_DecompressionFile, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.Id_Case, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela_YTCase.CaseName, Type.GetType("System.String"));
foreach (clsvCaseAddiSiteRela_YTCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCaseAddiSiteRela_YTCase.mId] = objInFor[convCaseAddiSiteRela_YTCase.mId];
objDR[convCaseAddiSiteRela_YTCase.Id_DecompressionFile] = objInFor[convCaseAddiSiteRela_YTCase.Id_DecompressionFile];
objDR[convCaseAddiSiteRela_YTCase.FileName] = objInFor[convCaseAddiSiteRela_YTCase.FileName];
objDR[convCaseAddiSiteRela_YTCase.Id_Case] = objInFor[convCaseAddiSiteRela_YTCase.Id_Case];
objDR[convCaseAddiSiteRela_YTCase.TeacherID] = objInFor[convCaseAddiSiteRela_YTCase.TeacherID];
objDR[convCaseAddiSiteRela_YTCase.TeacherName] = objInFor[convCaseAddiSiteRela_YTCase.TeacherName];
objDR[convCaseAddiSiteRela_YTCase.CollegeName] = objInFor[convCaseAddiSiteRela_YTCase.CollegeName];
objDR[convCaseAddiSiteRela_YTCase.CollegeNameA] = objInFor[convCaseAddiSiteRela_YTCase.CollegeNameA];
objDR[convCaseAddiSiteRela_YTCase.FuncModuleId] = objInFor[convCaseAddiSiteRela_YTCase.FuncModuleId];
objDR[convCaseAddiSiteRela_YTCase.FuncModuleName] = objInFor[convCaseAddiSiteRela_YTCase.FuncModuleName];
objDR[convCaseAddiSiteRela_YTCase.UpdDate] = objInFor[convCaseAddiSiteRela_YTCase.UpdDate];
objDR[convCaseAddiSiteRela_YTCase.UpdUser] = objInFor[convCaseAddiSiteRela_YTCase.UpdUser];
objDR[convCaseAddiSiteRela_YTCase.Memo] = objInFor[convCaseAddiSiteRela_YTCase.Memo];
objDR[convCaseAddiSiteRela_YTCase.CaseId] = objInFor[convCaseAddiSiteRela_YTCase.CaseId];
objDR[convCaseAddiSiteRela_YTCase.CaseName] = objInFor[convCaseAddiSiteRela_YTCase.CaseName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}