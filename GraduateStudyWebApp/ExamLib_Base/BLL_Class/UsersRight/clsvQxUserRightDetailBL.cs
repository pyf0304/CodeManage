
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRightDetailBL
 表名:vQxUserRightDetail(01120179)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
public static class  clsvQxUserRightDetailBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRightDetailEN GetObj(this K_mId_vQxUserRightDetail myKey)
{
clsvQxUserRightDetailEN objvQxUserRightDetailEN = clsvQxUserRightDetailBL.vQxUserRightDetailDA.GetObjBymId(myKey.Value);
return objvQxUserRightDetailEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetmId(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, long lngmId, string strComparisonOp="")
	{
objvQxUserRightDetailEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.mId) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.mId, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.mId] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetUserId(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserRightDetail.UserId);
}
objvQxUserRightDetailEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.UserId) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.UserId, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.UserId] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetUserName(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserRightDetail.UserName);
}
objvQxUserRightDetailEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.UserName) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.UserName, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.UserName] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetIdXzCollege(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convQxUserRightDetail.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convQxUserRightDetail.IdXzCollege);
}
objvQxUserRightDetailEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.IdXzCollege) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.IdXzCollege, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.IdXzCollege] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetCollegeName(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convQxUserRightDetail.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convQxUserRightDetail.CollegeName);
}
objvQxUserRightDetailEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.CollegeName) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.CollegeName, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.CollegeName] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetCollegeNameA(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convQxUserRightDetail.CollegeNameA);
}
objvQxUserRightDetailEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.CollegeNameA) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.CollegeNameA, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.CollegeNameA] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetIdentityId(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, convQxUserRightDetail.IdentityId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUserRightDetail.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUserRightDetail.IdentityId);
}
objvQxUserRightDetailEN.IdentityId = strIdentityId; //身份Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.IdentityId) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.IdentityId, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.IdentityId] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetIdentityDesc(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convQxUserRightDetail.IdentityDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUserRightDetail.IdentityDesc);
}
objvQxUserRightDetailEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.IdentityDesc) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.IdentityDesc, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.IdentityDesc] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetStuIdTeacherId(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strStuIdTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convQxUserRightDetail.StuIdTeacherId);
}
objvQxUserRightDetailEN.StuIdTeacherId = strStuIdTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.StuIdTeacherId) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.StuIdTeacherId, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.StuIdTeacherId] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetRightId(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightId, convQxUserRightDetail.RightId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightId, 8, convQxUserRightDetail.RightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightId, 8, convQxUserRightDetail.RightId);
}
objvQxUserRightDetailEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.RightId) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.RightId, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.RightId] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetRightName(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strRightName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightName, convQxUserRightDetail.RightName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightName, 200, convQxUserRightDetail.RightName);
}
objvQxUserRightDetailEN.RightName = strRightName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.RightName) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.RightName, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.RightName] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetRightTypeId(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strRightTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightTypeId, convQxUserRightDetail.RightTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightTypeId, 4, convQxUserRightDetail.RightTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightTypeId, 4, convQxUserRightDetail.RightTypeId);
}
objvQxUserRightDetailEN.RightTypeId = strRightTypeId; //权限类型编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.RightTypeId) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.RightTypeId, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.RightTypeId] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetRightTypeName(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strRightTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightTypeName, convQxUserRightDetail.RightTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightTypeName, 50, convQxUserRightDetail.RightTypeName);
}
objvQxUserRightDetailEN.RightTypeName = strRightTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.RightTypeName) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.RightTypeName, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.RightTypeName] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetFuncModuleId(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxUserRightDetail.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxUserRightDetail.FuncModuleId);
}
objvQxUserRightDetailEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.FuncModuleId) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.FuncModuleId, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.FuncModuleId] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetFuncModuleName(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convQxUserRightDetail.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxUserRightDetail.FuncModuleName);
}
objvQxUserRightDetailEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.FuncModuleName) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.FuncModuleName, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.FuncModuleName] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetRightRangeLevelId(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strRightRangeLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightRangeLevelId, convQxUserRightDetail.RightRangeLevelId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightRangeLevelId, 2, convQxUserRightDetail.RightRangeLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightRangeLevelId, 2, convQxUserRightDetail.RightRangeLevelId);
}
objvQxUserRightDetailEN.RightRangeLevelId = strRightRangeLevelId; //权限范围等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.RightRangeLevelId) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.RightRangeLevelId, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.RightRangeLevelId] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetRightRangeLevelName(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strRightRangeLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightRangeLevelName, convQxUserRightDetail.RightRangeLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightRangeLevelName, 30, convQxUserRightDetail.RightRangeLevelName);
}
objvQxUserRightDetailEN.RightRangeLevelName = strRightRangeLevelName; //权限范围等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.RightRangeLevelName) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.RightRangeLevelName, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.RightRangeLevelName] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetAuthorizer(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strAuthorizer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAuthorizer, convQxUserRightDetail.Authorizer);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthorizer, 18, convQxUserRightDetail.Authorizer);
}
objvQxUserRightDetailEN.Authorizer = strAuthorizer; //授权人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.Authorizer) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.Authorizer, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.Authorizer] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetmKeyId(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strmKeyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmKeyId, 10, convQxUserRightDetail.mKeyId);
}
objvQxUserRightDetailEN.mKeyId = strmKeyId; //关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.mKeyId) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.mKeyId, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.mKeyId] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetUpdDate(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxUserRightDetail.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUserRightDetail.UpdDate);
}
objvQxUserRightDetailEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.UpdDate) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.UpdDate, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.UpdDate] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetUpdUser(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQxUserRightDetail.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxUserRightDetail.UpdUser);
}
objvQxUserRightDetailEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.UpdUser) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.UpdUser, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.UpdUser] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRightDetailEN SetMemo(this clsvQxUserRightDetailEN objvQxUserRightDetailEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRightDetail.Memo);
}
objvQxUserRightDetailEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRightDetailEN.dicFldComparisonOp.ContainsKey(convQxUserRightDetail.Memo) == false)
{
objvQxUserRightDetailEN.dicFldComparisonOp.Add(convQxUserRightDetail.Memo, strComparisonOp);
}
else
{
objvQxUserRightDetailEN.dicFldComparisonOp[convQxUserRightDetail.Memo] = strComparisonOp;
}
}
return objvQxUserRightDetailEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUserRightDetailENS">源对象</param>
 /// <param name = "objvQxUserRightDetailENT">目标对象</param>
 public static void CopyTo(this clsvQxUserRightDetailEN objvQxUserRightDetailENS, clsvQxUserRightDetailEN objvQxUserRightDetailENT)
{
try
{
objvQxUserRightDetailENT.mId = objvQxUserRightDetailENS.mId; //mId
objvQxUserRightDetailENT.UserId = objvQxUserRightDetailENS.UserId; //用户ID
objvQxUserRightDetailENT.UserName = objvQxUserRightDetailENS.UserName; //用户名
objvQxUserRightDetailENT.IdXzCollege = objvQxUserRightDetailENS.IdXzCollege; //学院流水号
objvQxUserRightDetailENT.CollegeName = objvQxUserRightDetailENS.CollegeName; //学院名称
objvQxUserRightDetailENT.CollegeNameA = objvQxUserRightDetailENS.CollegeNameA; //学院名称简写
objvQxUserRightDetailENT.IdentityId = objvQxUserRightDetailENS.IdentityId; //身份Id
objvQxUserRightDetailENT.IdentityDesc = objvQxUserRightDetailENS.IdentityDesc; //身份描述
objvQxUserRightDetailENT.StuIdTeacherId = objvQxUserRightDetailENS.StuIdTeacherId; //学工号
objvQxUserRightDetailENT.RightId = objvQxUserRightDetailENS.RightId; //权限编号
objvQxUserRightDetailENT.RightName = objvQxUserRightDetailENS.RightName; //权限名称
objvQxUserRightDetailENT.RightTypeId = objvQxUserRightDetailENS.RightTypeId; //权限类型编号
objvQxUserRightDetailENT.RightTypeName = objvQxUserRightDetailENS.RightTypeName; //权限类型名
objvQxUserRightDetailENT.FuncModuleId = objvQxUserRightDetailENS.FuncModuleId; //功能模块Id
objvQxUserRightDetailENT.FuncModuleName = objvQxUserRightDetailENS.FuncModuleName; //功能模块名称
objvQxUserRightDetailENT.RightRangeLevelId = objvQxUserRightDetailENS.RightRangeLevelId; //权限范围等级Id
objvQxUserRightDetailENT.RightRangeLevelName = objvQxUserRightDetailENS.RightRangeLevelName; //权限范围等级名称
objvQxUserRightDetailENT.Authorizer = objvQxUserRightDetailENS.Authorizer; //授权人
objvQxUserRightDetailENT.mKeyId = objvQxUserRightDetailENS.mKeyId; //关键字Id
objvQxUserRightDetailENT.UpdDate = objvQxUserRightDetailENS.UpdDate; //修改日期
objvQxUserRightDetailENT.UpdUser = objvQxUserRightDetailENS.UpdUser; //修改人
objvQxUserRightDetailENT.Memo = objvQxUserRightDetailENS.Memo; //备注
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
 /// <param name = "objvQxUserRightDetailENS">源对象</param>
 /// <returns>目标对象=>clsvQxUserRightDetailEN:objvQxUserRightDetailENT</returns>
 public static clsvQxUserRightDetailEN CopyTo(this clsvQxUserRightDetailEN objvQxUserRightDetailENS)
{
try
{
 clsvQxUserRightDetailEN objvQxUserRightDetailENT = new clsvQxUserRightDetailEN()
{
mId = objvQxUserRightDetailENS.mId, //mId
UserId = objvQxUserRightDetailENS.UserId, //用户ID
UserName = objvQxUserRightDetailENS.UserName, //用户名
IdXzCollege = objvQxUserRightDetailENS.IdXzCollege, //学院流水号
CollegeName = objvQxUserRightDetailENS.CollegeName, //学院名称
CollegeNameA = objvQxUserRightDetailENS.CollegeNameA, //学院名称简写
IdentityId = objvQxUserRightDetailENS.IdentityId, //身份Id
IdentityDesc = objvQxUserRightDetailENS.IdentityDesc, //身份描述
StuIdTeacherId = objvQxUserRightDetailENS.StuIdTeacherId, //学工号
RightId = objvQxUserRightDetailENS.RightId, //权限编号
RightName = objvQxUserRightDetailENS.RightName, //权限名称
RightTypeId = objvQxUserRightDetailENS.RightTypeId, //权限类型编号
RightTypeName = objvQxUserRightDetailENS.RightTypeName, //权限类型名
FuncModuleId = objvQxUserRightDetailENS.FuncModuleId, //功能模块Id
FuncModuleName = objvQxUserRightDetailENS.FuncModuleName, //功能模块名称
RightRangeLevelId = objvQxUserRightDetailENS.RightRangeLevelId, //权限范围等级Id
RightRangeLevelName = objvQxUserRightDetailENS.RightRangeLevelName, //权限范围等级名称
Authorizer = objvQxUserRightDetailENS.Authorizer, //授权人
mKeyId = objvQxUserRightDetailENS.mKeyId, //关键字Id
UpdDate = objvQxUserRightDetailENS.UpdDate, //修改日期
UpdUser = objvQxUserRightDetailENS.UpdUser, //修改人
Memo = objvQxUserRightDetailENS.Memo, //备注
};
 return objvQxUserRightDetailENT;
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
public static void CheckProperty4Condition(this clsvQxUserRightDetailEN objvQxUserRightDetailEN)
{
 clsvQxUserRightDetailBL.vQxUserRightDetailDA.CheckProperty4Condition(objvQxUserRightDetailEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserRightDetailEN objvQxUserRightDetailCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.mId) == true)
{
string strComparisonOpmId = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRightDetail.mId, objvQxUserRightDetailCond.mId, strComparisonOpmId);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.UserId) == true)
{
string strComparisonOpUserId = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.UserId, objvQxUserRightDetailCond.UserId, strComparisonOpUserId);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.UserName) == true)
{
string strComparisonOpUserName = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.UserName, objvQxUserRightDetailCond.UserName, strComparisonOpUserName);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.IdXzCollege, objvQxUserRightDetailCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.CollegeName) == true)
{
string strComparisonOpCollegeName = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.CollegeName, objvQxUserRightDetailCond.CollegeName, strComparisonOpCollegeName);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.CollegeNameA, objvQxUserRightDetailCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.IdentityId, objvQxUserRightDetailCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.IdentityDesc, objvQxUserRightDetailCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.StuIdTeacherId) == true)
{
string strComparisonOpStuIdTeacherId = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.StuIdTeacherId, objvQxUserRightDetailCond.StuIdTeacherId, strComparisonOpStuIdTeacherId);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.RightId) == true)
{
string strComparisonOpRightId = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.RightId, objvQxUserRightDetailCond.RightId, strComparisonOpRightId);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.RightName) == true)
{
string strComparisonOpRightName = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.RightName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.RightName, objvQxUserRightDetailCond.RightName, strComparisonOpRightName);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.RightTypeId) == true)
{
string strComparisonOpRightTypeId = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.RightTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.RightTypeId, objvQxUserRightDetailCond.RightTypeId, strComparisonOpRightTypeId);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.RightTypeName) == true)
{
string strComparisonOpRightTypeName = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.RightTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.RightTypeName, objvQxUserRightDetailCond.RightTypeName, strComparisonOpRightTypeName);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.FuncModuleId, objvQxUserRightDetailCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.FuncModuleName, objvQxUserRightDetailCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.RightRangeLevelId) == true)
{
string strComparisonOpRightRangeLevelId = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.RightRangeLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.RightRangeLevelId, objvQxUserRightDetailCond.RightRangeLevelId, strComparisonOpRightRangeLevelId);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.RightRangeLevelName) == true)
{
string strComparisonOpRightRangeLevelName = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.RightRangeLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.RightRangeLevelName, objvQxUserRightDetailCond.RightRangeLevelName, strComparisonOpRightRangeLevelName);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.Authorizer) == true)
{
string strComparisonOpAuthorizer = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.Authorizer];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.Authorizer, objvQxUserRightDetailCond.Authorizer, strComparisonOpAuthorizer);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.mKeyId) == true)
{
string strComparisonOpmKeyId = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.mKeyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.mKeyId, objvQxUserRightDetailCond.mKeyId, strComparisonOpmKeyId);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.UpdDate, objvQxUserRightDetailCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.UpdUser, objvQxUserRightDetailCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxUserRightDetailCond.IsUpdated(convQxUserRightDetail.Memo) == true)
{
string strComparisonOpMemo = objvQxUserRightDetailCond.dicFldComparisonOp[convQxUserRightDetail.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRightDetail.Memo, objvQxUserRightDetailCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUserRightDetail
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户权限详细关系(vQxUserRightDetail)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRightDetailBL
{
public static RelatedActions_vQxUserRightDetail relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUserRightDetailDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUserRightDetailDA vQxUserRightDetailDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUserRightDetailDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUserRightDetailBL()
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
if (string.IsNullOrEmpty(clsvQxUserRightDetailEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserRightDetailEN._ConnectString);
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
public static DataTable GetDataTable_vQxUserRightDetail(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUserRightDetailDA.GetDataTable_vQxUserRightDetail(strWhereCond);
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
objDT = vQxUserRightDetailDA.GetDataTable(strWhereCond);
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
objDT = vQxUserRightDetailDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUserRightDetailDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUserRightDetailDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUserRightDetailDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUserRightDetailDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUserRightDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUserRightDetailDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxUserRightDetailEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUserRightDetailEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxUserRightDetailEN._CurrTabName);
List<clsvQxUserRightDetailEN> arrvQxUserRightDetailObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRightDetailEN> arrvQxUserRightDetailObjLst_Sel =
arrvQxUserRightDetailObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxUserRightDetailObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRightDetailEN> GetObjLst(string strWhereCond)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
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
public static List<clsvQxUserRightDetailEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUserRightDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUserRightDetailEN> GetSubObjLstCache(clsvQxUserRightDetailEN objvQxUserRightDetailCond)
{
List<clsvQxUserRightDetailEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRightDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRightDetail.AttributeName)
{
if (objvQxUserRightDetailCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRightDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRightDetailCond[strFldName].ToString());
}
else
{
if (objvQxUserRightDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRightDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRightDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRightDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRightDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRightDetailCond[strFldName]));
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
public static List<clsvQxUserRightDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
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
public static List<clsvQxUserRightDetailEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
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
List<clsvQxUserRightDetailEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUserRightDetailEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRightDetailEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUserRightDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
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
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
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
public static List<clsvQxUserRightDetailEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUserRightDetailEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUserRightDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
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
public static List<clsvQxUserRightDetailEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRightDetailEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUserRightDetailEN> arrObjLst = new List<clsvQxUserRightDetailEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRightDetailEN objvQxUserRightDetailEN = new clsvQxUserRightDetailEN();
try
{
objvQxUserRightDetailEN.mId = Int32.Parse(objRow[convQxUserRightDetail.mId].ToString().Trim()); //mId
objvQxUserRightDetailEN.UserId = objRow[convQxUserRightDetail.UserId] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserId].ToString().Trim(); //用户ID
objvQxUserRightDetailEN.UserName = objRow[convQxUserRightDetail.UserName] == DBNull.Value ? null : objRow[convQxUserRightDetail.UserName].ToString().Trim(); //用户名
objvQxUserRightDetailEN.IdXzCollege = objRow[convQxUserRightDetail.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRightDetail.IdXzCollege].ToString().Trim(); //学院流水号
objvQxUserRightDetailEN.CollegeName = objRow[convQxUserRightDetail.CollegeName].ToString().Trim(); //学院名称
objvQxUserRightDetailEN.CollegeNameA = objRow[convQxUserRightDetail.CollegeNameA] == DBNull.Value ? null : objRow[convQxUserRightDetail.CollegeNameA].ToString().Trim(); //学院名称简写
objvQxUserRightDetailEN.IdentityId = objRow[convQxUserRightDetail.IdentityId].ToString().Trim(); //身份Id
objvQxUserRightDetailEN.IdentityDesc = objRow[convQxUserRightDetail.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRightDetailEN.StuIdTeacherId = objRow[convQxUserRightDetail.StuIdTeacherId] == DBNull.Value ? null : objRow[convQxUserRightDetail.StuIdTeacherId].ToString().Trim(); //学工号
objvQxUserRightDetailEN.RightId = objRow[convQxUserRightDetail.RightId].ToString().Trim(); //权限编号
objvQxUserRightDetailEN.RightName = objRow[convQxUserRightDetail.RightName].ToString().Trim(); //权限名称
objvQxUserRightDetailEN.RightTypeId = objRow[convQxUserRightDetail.RightTypeId].ToString().Trim(); //权限类型编号
objvQxUserRightDetailEN.RightTypeName = objRow[convQxUserRightDetail.RightTypeName].ToString().Trim(); //权限类型名
objvQxUserRightDetailEN.FuncModuleId = objRow[convQxUserRightDetail.FuncModuleId] == DBNull.Value ? null : objRow[convQxUserRightDetail.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxUserRightDetailEN.FuncModuleName = objRow[convQxUserRightDetail.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxUserRightDetailEN.RightRangeLevelId = objRow[convQxUserRightDetail.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxUserRightDetailEN.RightRangeLevelName = objRow[convQxUserRightDetail.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxUserRightDetailEN.Authorizer = objRow[convQxUserRightDetail.Authorizer].ToString().Trim(); //授权人
objvQxUserRightDetailEN.mKeyId = objRow[convQxUserRightDetail.mKeyId] == DBNull.Value ? null : objRow[convQxUserRightDetail.mKeyId].ToString().Trim(); //关键字Id
objvQxUserRightDetailEN.UpdDate = objRow[convQxUserRightDetail.UpdDate].ToString().Trim(); //修改日期
objvQxUserRightDetailEN.UpdUser = objRow[convQxUserRightDetail.UpdUser].ToString().Trim(); //修改人
objvQxUserRightDetailEN.Memo = objRow[convQxUserRightDetail.Memo] == DBNull.Value ? null : objRow[convQxUserRightDetail.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRightDetailEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRightDetailEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserRightDetailEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserRightDetail(ref clsvQxUserRightDetailEN objvQxUserRightDetailEN)
{
bool bolResult = vQxUserRightDetailDA.GetvQxUserRightDetail(ref objvQxUserRightDetailEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRightDetailEN GetObjBymId(long lngmId)
{
clsvQxUserRightDetailEN objvQxUserRightDetailEN = vQxUserRightDetailDA.GetObjBymId(lngmId);
return objvQxUserRightDetailEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUserRightDetailEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUserRightDetailEN objvQxUserRightDetailEN = vQxUserRightDetailDA.GetFirstObj(strWhereCond);
 return objvQxUserRightDetailEN;
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
public static clsvQxUserRightDetailEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUserRightDetailEN objvQxUserRightDetailEN = vQxUserRightDetailDA.GetObjByDataRow(objRow);
 return objvQxUserRightDetailEN;
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
public static clsvQxUserRightDetailEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUserRightDetailEN objvQxUserRightDetailEN = vQxUserRightDetailDA.GetObjByDataRow(objRow);
 return objvQxUserRightDetailEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvQxUserRightDetailObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRightDetailEN GetObjBymIdFromList(long lngmId, List<clsvQxUserRightDetailEN> lstvQxUserRightDetailObjLst)
{
foreach (clsvQxUserRightDetailEN objvQxUserRightDetailEN in lstvQxUserRightDetailObjLst)
{
if (objvQxUserRightDetailEN.mId == lngmId)
{
return objvQxUserRightDetailEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvQxUserRightDetailDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vQxUserRightDetailDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUserRightDetailDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vQxUserRightDetailDA.IsExist(lngmId);
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
 bolIsExist = clsvQxUserRightDetailDA.IsExistTable();
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
 bolIsExist = vQxUserRightDetailDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUserRightDetailENS">源对象</param>
 /// <param name = "objvQxUserRightDetailENT">目标对象</param>
 public static void CopyTo(clsvQxUserRightDetailEN objvQxUserRightDetailENS, clsvQxUserRightDetailEN objvQxUserRightDetailENT)
{
try
{
objvQxUserRightDetailENT.mId = objvQxUserRightDetailENS.mId; //mId
objvQxUserRightDetailENT.UserId = objvQxUserRightDetailENS.UserId; //用户ID
objvQxUserRightDetailENT.UserName = objvQxUserRightDetailENS.UserName; //用户名
objvQxUserRightDetailENT.IdXzCollege = objvQxUserRightDetailENS.IdXzCollege; //学院流水号
objvQxUserRightDetailENT.CollegeName = objvQxUserRightDetailENS.CollegeName; //学院名称
objvQxUserRightDetailENT.CollegeNameA = objvQxUserRightDetailENS.CollegeNameA; //学院名称简写
objvQxUserRightDetailENT.IdentityId = objvQxUserRightDetailENS.IdentityId; //身份Id
objvQxUserRightDetailENT.IdentityDesc = objvQxUserRightDetailENS.IdentityDesc; //身份描述
objvQxUserRightDetailENT.StuIdTeacherId = objvQxUserRightDetailENS.StuIdTeacherId; //学工号
objvQxUserRightDetailENT.RightId = objvQxUserRightDetailENS.RightId; //权限编号
objvQxUserRightDetailENT.RightName = objvQxUserRightDetailENS.RightName; //权限名称
objvQxUserRightDetailENT.RightTypeId = objvQxUserRightDetailENS.RightTypeId; //权限类型编号
objvQxUserRightDetailENT.RightTypeName = objvQxUserRightDetailENS.RightTypeName; //权限类型名
objvQxUserRightDetailENT.FuncModuleId = objvQxUserRightDetailENS.FuncModuleId; //功能模块Id
objvQxUserRightDetailENT.FuncModuleName = objvQxUserRightDetailENS.FuncModuleName; //功能模块名称
objvQxUserRightDetailENT.RightRangeLevelId = objvQxUserRightDetailENS.RightRangeLevelId; //权限范围等级Id
objvQxUserRightDetailENT.RightRangeLevelName = objvQxUserRightDetailENS.RightRangeLevelName; //权限范围等级名称
objvQxUserRightDetailENT.Authorizer = objvQxUserRightDetailENS.Authorizer; //授权人
objvQxUserRightDetailENT.mKeyId = objvQxUserRightDetailENS.mKeyId; //关键字Id
objvQxUserRightDetailENT.UpdDate = objvQxUserRightDetailENS.UpdDate; //修改日期
objvQxUserRightDetailENT.UpdUser = objvQxUserRightDetailENS.UpdUser; //修改人
objvQxUserRightDetailENT.Memo = objvQxUserRightDetailENS.Memo; //备注
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
 /// <param name = "objvQxUserRightDetailEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUserRightDetailEN objvQxUserRightDetailEN)
{
try
{
objvQxUserRightDetailEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUserRightDetailEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUserRightDetail.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.mId = objvQxUserRightDetailEN.mId; //mId
}
if (arrFldSet.Contains(convQxUserRightDetail.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.UserId = objvQxUserRightDetailEN.UserId == "[null]" ? null :  objvQxUserRightDetailEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUserRightDetail.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.UserName = objvQxUserRightDetailEN.UserName == "[null]" ? null :  objvQxUserRightDetailEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUserRightDetail.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.IdXzCollege = objvQxUserRightDetailEN.IdXzCollege == "[null]" ? null :  objvQxUserRightDetailEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convQxUserRightDetail.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.CollegeName = objvQxUserRightDetailEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convQxUserRightDetail.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.CollegeNameA = objvQxUserRightDetailEN.CollegeNameA == "[null]" ? null :  objvQxUserRightDetailEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convQxUserRightDetail.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.IdentityId = objvQxUserRightDetailEN.IdentityId; //身份Id
}
if (arrFldSet.Contains(convQxUserRightDetail.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.IdentityDesc = objvQxUserRightDetailEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxUserRightDetail.StuIdTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.StuIdTeacherId = objvQxUserRightDetailEN.StuIdTeacherId == "[null]" ? null :  objvQxUserRightDetailEN.StuIdTeacherId; //学工号
}
if (arrFldSet.Contains(convQxUserRightDetail.RightId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.RightId = objvQxUserRightDetailEN.RightId; //权限编号
}
if (arrFldSet.Contains(convQxUserRightDetail.RightName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.RightName = objvQxUserRightDetailEN.RightName; //权限名称
}
if (arrFldSet.Contains(convQxUserRightDetail.RightTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.RightTypeId = objvQxUserRightDetailEN.RightTypeId; //权限类型编号
}
if (arrFldSet.Contains(convQxUserRightDetail.RightTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.RightTypeName = objvQxUserRightDetailEN.RightTypeName; //权限类型名
}
if (arrFldSet.Contains(convQxUserRightDetail.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.FuncModuleId = objvQxUserRightDetailEN.FuncModuleId == "[null]" ? null :  objvQxUserRightDetailEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convQxUserRightDetail.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.FuncModuleName = objvQxUserRightDetailEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convQxUserRightDetail.RightRangeLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.RightRangeLevelId = objvQxUserRightDetailEN.RightRangeLevelId; //权限范围等级Id
}
if (arrFldSet.Contains(convQxUserRightDetail.RightRangeLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.RightRangeLevelName = objvQxUserRightDetailEN.RightRangeLevelName; //权限范围等级名称
}
if (arrFldSet.Contains(convQxUserRightDetail.Authorizer, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.Authorizer = objvQxUserRightDetailEN.Authorizer; //授权人
}
if (arrFldSet.Contains(convQxUserRightDetail.mKeyId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.mKeyId = objvQxUserRightDetailEN.mKeyId == "[null]" ? null :  objvQxUserRightDetailEN.mKeyId; //关键字Id
}
if (arrFldSet.Contains(convQxUserRightDetail.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.UpdDate = objvQxUserRightDetailEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxUserRightDetail.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.UpdUser = objvQxUserRightDetailEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQxUserRightDetail.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRightDetailEN.Memo = objvQxUserRightDetailEN.Memo == "[null]" ? null :  objvQxUserRightDetailEN.Memo; //备注
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
 /// <param name = "objvQxUserRightDetailEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUserRightDetailEN objvQxUserRightDetailEN)
{
try
{
if (objvQxUserRightDetailEN.UserId == "[null]") objvQxUserRightDetailEN.UserId = null; //用户ID
if (objvQxUserRightDetailEN.UserName == "[null]") objvQxUserRightDetailEN.UserName = null; //用户名
if (objvQxUserRightDetailEN.IdXzCollege == "[null]") objvQxUserRightDetailEN.IdXzCollege = null; //学院流水号
if (objvQxUserRightDetailEN.CollegeNameA == "[null]") objvQxUserRightDetailEN.CollegeNameA = null; //学院名称简写
if (objvQxUserRightDetailEN.StuIdTeacherId == "[null]") objvQxUserRightDetailEN.StuIdTeacherId = null; //学工号
if (objvQxUserRightDetailEN.FuncModuleId == "[null]") objvQxUserRightDetailEN.FuncModuleId = null; //功能模块Id
if (objvQxUserRightDetailEN.mKeyId == "[null]") objvQxUserRightDetailEN.mKeyId = null; //关键字Id
if (objvQxUserRightDetailEN.Memo == "[null]") objvQxUserRightDetailEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUserRightDetailEN objvQxUserRightDetailEN)
{
 vQxUserRightDetailDA.CheckProperty4Condition(objvQxUserRightDetailEN);
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
if (clsQxUserRightDetailBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRightDetailBL没有刷新缓存机制(clsQxUserRightDetailBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightBL没有刷新缓存机制(clsQxRightBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightRangeLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightRangeLevelBL没有刷新缓存机制(clsQxRightRangeLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightTypeBL没有刷新缓存机制(clsQxRightTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxUserRightDetailObjLstCache == null)
//{
//arrvQxUserRightDetailObjLstCache = vQxUserRightDetailDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRightDetailEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUserRightDetailEN._CurrTabName);
List<clsvQxUserRightDetailEN> arrvQxUserRightDetailObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRightDetailEN> arrvQxUserRightDetailObjLst_Sel =
arrvQxUserRightDetailObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxUserRightDetailObjLst_Sel.Count() == 0)
{
   clsvQxUserRightDetailEN obj = clsvQxUserRightDetailBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUserRightDetailObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRightDetailEN> GetAllvQxUserRightDetailObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUserRightDetailEN> arrvQxUserRightDetailObjLstCache = GetObjLstCache(); 
return arrvQxUserRightDetailObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRightDetailEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUserRightDetailEN._CurrTabName);
List<clsvQxUserRightDetailEN> arrvQxUserRightDetailObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUserRightDetailObjLstCache;
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
string strKey = string.Format("{0}", clsvQxUserRightDetailEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convQxUserRightDetail.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUserRightDetail.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUserRightDetail.AttributeName));
throw new Exception(strMsg);
}
var objvQxUserRightDetail = clsvQxUserRightDetailBL.GetObjBymIdCache(lngmId);
if (objvQxUserRightDetail == null) return "";
return objvQxUserRightDetail[strOutFldName].ToString();
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
int intRecCount = clsvQxUserRightDetailDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUserRightDetailDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUserRightDetailDA.GetRecCount();
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
int intRecCount = clsvQxUserRightDetailDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUserRightDetailCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUserRightDetailEN objvQxUserRightDetailCond)
{
List<clsvQxUserRightDetailEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRightDetailEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRightDetail.AttributeName)
{
if (objvQxUserRightDetailCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRightDetailCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRightDetailCond[strFldName].ToString());
}
else
{
if (objvQxUserRightDetailCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRightDetailCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRightDetailCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRightDetailCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRightDetailCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRightDetailCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRightDetailCond[strFldName]));
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
 List<string> arrList = clsvQxUserRightDetailDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRightDetailDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRightDetailDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}