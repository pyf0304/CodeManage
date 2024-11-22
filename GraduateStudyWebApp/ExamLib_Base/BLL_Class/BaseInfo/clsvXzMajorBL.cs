
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorBL
 表名:vXzMajor(01120066)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:14
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
public static class  clsvXzMajorBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdXzMajor">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorEN GetObj(this K_IdXzMajor_vXzMajor myKey)
{
clsvXzMajorEN objvXzMajorEN = clsvXzMajorBL.vXzMajorDA.GetObjByIdXzMajor(myKey.Value);
return objvXzMajorEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetIdXzMajor(this clsvXzMajorEN objvXzMajorEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convXzMajor.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convXzMajor.IdXzMajor);
}
objvXzMajorEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IdXzMajor) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IdXzMajor, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IdXzMajor] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetMajorID(this clsvXzMajorEN objvXzMajorEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convXzMajor.MajorID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convXzMajor.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convXzMajor.MajorID);
}
objvXzMajorEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.MajorID) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.MajorID, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.MajorID] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetMajorName(this clsvXzMajorEN objvXzMajorEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convXzMajor.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convXzMajor.MajorName);
}
objvXzMajorEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.MajorName) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.MajorName, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.MajorName] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetMajorEnglishName(this clsvXzMajorEN objvXzMajorEN, string strMajorEnglishName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorEnglishName, 200, convXzMajor.MajorEnglishName);
}
objvXzMajorEN.MajorEnglishName = strMajorEnglishName; //专业英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.MajorEnglishName) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.MajorEnglishName, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.MajorEnglishName] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetMajorExplain(this clsvXzMajorEN objvXzMajorEN, string strMajorExplain, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorExplain, 2000, convXzMajor.MajorExplain);
}
objvXzMajorEN.MajorExplain = strMajorExplain; //专业说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.MajorExplain) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.MajorExplain, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.MajorExplain] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetMajorNationalID(this clsvXzMajorEN objvXzMajorEN, string strMajorNationalID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorNationalID, 10, convXzMajor.MajorNationalID);
}
objvXzMajorEN.MajorNationalID = strMajorNationalID; //专业国家代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.MajorNationalID) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.MajorNationalID, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.MajorNationalID] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetIdXzCollege(this clsvXzMajorEN objvXzMajorEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convXzMajor.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convXzMajor.IdXzCollege);
}
objvXzMajorEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IdXzCollege) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IdXzCollege, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IdXzCollege] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetCollegeId(this clsvXzMajorEN objvXzMajorEN, string strCollegeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeId, convXzMajor.CollegeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, convXzMajor.CollegeId);
}
objvXzMajorEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.CollegeId) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.CollegeId, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.CollegeId] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetCollegeName(this clsvXzMajorEN objvXzMajorEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convXzMajor.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convXzMajor.CollegeName);
}
objvXzMajorEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.CollegeName) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.CollegeName, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.CollegeName] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetCollegeNameA(this clsvXzMajorEN objvXzMajorEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convXzMajor.CollegeNameA);
}
objvXzMajorEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.CollegeNameA) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.CollegeNameA, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.CollegeNameA] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetIdMajorType(this clsvXzMajorEN objvXzMajorEN, string strIdMajorType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMajorType, 4, convXzMajor.IdMajorType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMajorType, 4, convXzMajor.IdMajorType);
}
objvXzMajorEN.IdMajorType = strIdMajorType; //专业类型(文理工)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IdMajorType) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IdMajorType, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IdMajorType] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetMajorTypeName(this clsvXzMajorEN objvXzMajorEN, string strMajorTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorTypeName, convXzMajor.MajorTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorTypeName, 50, convXzMajor.MajorTypeName);
}
objvXzMajorEN.MajorTypeName = strMajorTypeName; //专业类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.MajorTypeName) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.MajorTypeName, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.MajorTypeName] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetIdDegreeType(this clsvXzMajorEN objvXzMajorEN, string strIdDegreeType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDegreeType, 4, convXzMajor.IdDegreeType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDegreeType, 4, convXzMajor.IdDegreeType);
}
objvXzMajorEN.IdDegreeType = strIdDegreeType; //学位类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IdDegreeType) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IdDegreeType, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IdDegreeType] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetXwTypeDesc(this clsvXzMajorEN objvXzMajorEN, string strXwTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strXwTypeDesc, convXzMajor.XwTypeDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strXwTypeDesc, 60, convXzMajor.XwTypeDesc);
}
objvXzMajorEN.XwTypeDesc = strXwTypeDesc; //学位类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.XwTypeDesc) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.XwTypeDesc, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.XwTypeDesc] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetIsMainMajor(this clsvXzMajorEN objvXzMajorEN, bool bolIsMainMajor, string strComparisonOp="")
	{
objvXzMajorEN.IsMainMajor = bolIsMainMajor; //是否重要专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IsMainMajor) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IsMainMajor, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IsMainMajor] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetMajorDirection(this clsvXzMajorEN objvXzMajorEN, string strMajorDirection, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorDirection, 30, convXzMajor.MajorDirection);
}
objvXzMajorEN.MajorDirection = strMajorDirection; //专业方向
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.MajorDirection) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.MajorDirection, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.MajorDirection] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetIsVisible(this clsvXzMajorEN objvXzMajorEN, bool bolIsVisible, string strComparisonOp="")
	{
objvXzMajorEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IsVisible) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IsVisible, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IsVisible] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetIsNormal(this clsvXzMajorEN objvXzMajorEN, bool bolIsNormal, string strComparisonOp="")
	{
objvXzMajorEN.IsNormal = bolIsNormal; //IsNormal
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IsNormal) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IsNormal, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IsNormal] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetModifyDate(this clsvXzMajorEN objvXzMajorEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzMajor.ModifyDate);
}
objvXzMajorEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.ModifyDate) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.ModifyDate, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.ModifyDate] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetModifyUserId(this clsvXzMajorEN objvXzMajorEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convXzMajor.ModifyUserId);
}
objvXzMajorEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.ModifyUserId) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.ModifyUserId, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.ModifyUserId] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetMemo(this clsvXzMajorEN objvXzMajorEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzMajor.Memo);
}
objvXzMajorEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.Memo) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.Memo, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.Memo] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetIsVisible4XzClg(this clsvXzMajorEN objvXzMajorEN, bool bolIsVisible4XzClg, string strComparisonOp="")
	{
objvXzMajorEN.IsVisible4XzClg = bolIsVisible4XzClg; //IsVisible4XzClg
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IsVisible4XzClg) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IsVisible4XzClg, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IsVisible4XzClg] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetTypeName(this clsvXzMajorEN objvXzMajorEN, string strTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTypeName, 200, convXzMajor.TypeName);
}
objvXzMajorEN.TypeName = strTypeName; //类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.TypeName) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.TypeName, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.TypeName] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzMajorEN SetIdXzMajorShoolType(this clsvXzMajorEN objvXzMajorEN, string strIdXzMajorShoolType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajorShoolType, 4, convXzMajor.IdXzMajorShoolType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajorShoolType, 4, convXzMajor.IdXzMajorShoolType);
}
objvXzMajorEN.IdXzMajorShoolType = strIdXzMajorShoolType; //专业学校类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.IdXzMajorShoolType) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.IdXzMajorShoolType, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.IdXzMajorShoolType] = strComparisonOp;
}
}
return objvXzMajorEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzMajorENS">源对象</param>
 /// <param name = "objvXzMajorENT">目标对象</param>
 public static void CopyTo(this clsvXzMajorEN objvXzMajorENS, clsvXzMajorEN objvXzMajorENT)
{
try
{
objvXzMajorENT.IdXzMajor = objvXzMajorENS.IdXzMajor; //专业流水号
objvXzMajorENT.MajorID = objvXzMajorENS.MajorID; //专业ID
objvXzMajorENT.MajorName = objvXzMajorENS.MajorName; //专业名称
objvXzMajorENT.MajorEnglishName = objvXzMajorENS.MajorEnglishName; //专业英文名称
objvXzMajorENT.MajorExplain = objvXzMajorENS.MajorExplain; //专业说明
objvXzMajorENT.MajorNationalID = objvXzMajorENS.MajorNationalID; //专业国家代码
objvXzMajorENT.IdXzCollege = objvXzMajorENS.IdXzCollege; //学院流水号
objvXzMajorENT.CollegeId = objvXzMajorENS.CollegeId; //学院ID
objvXzMajorENT.CollegeName = objvXzMajorENS.CollegeName; //学院名称
objvXzMajorENT.CollegeNameA = objvXzMajorENS.CollegeNameA; //学院名称简写
objvXzMajorENT.IdMajorType = objvXzMajorENS.IdMajorType; //专业类型(文理工)流水号
objvXzMajorENT.MajorTypeName = objvXzMajorENS.MajorTypeName; //专业类型名称
objvXzMajorENT.IdDegreeType = objvXzMajorENS.IdDegreeType; //学位类型流水号
objvXzMajorENT.XwTypeDesc = objvXzMajorENS.XwTypeDesc; //学位类型名称
objvXzMajorENT.IsMainMajor = objvXzMajorENS.IsMainMajor; //是否重要专业
objvXzMajorENT.MajorDirection = objvXzMajorENS.MajorDirection; //专业方向
objvXzMajorENT.IsVisible = objvXzMajorENS.IsVisible; //是否显示
objvXzMajorENT.IsNormal = objvXzMajorENS.IsNormal; //IsNormal
objvXzMajorENT.ModifyDate = objvXzMajorENS.ModifyDate; //修改日期
objvXzMajorENT.ModifyUserId = objvXzMajorENS.ModifyUserId; //修改人
objvXzMajorENT.Memo = objvXzMajorENS.Memo; //备注
objvXzMajorENT.IsVisible4XzClg = objvXzMajorENS.IsVisible4XzClg; //IsVisible4XzClg
objvXzMajorENT.TypeName = objvXzMajorENS.TypeName; //类型名称
objvXzMajorENT.IdXzMajorShoolType = objvXzMajorENS.IdXzMajorShoolType; //专业学校类型流水号
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
 /// <param name = "objvXzMajorENS">源对象</param>
 /// <returns>目标对象=>clsvXzMajorEN:objvXzMajorENT</returns>
 public static clsvXzMajorEN CopyTo(this clsvXzMajorEN objvXzMajorENS)
{
try
{
 clsvXzMajorEN objvXzMajorENT = new clsvXzMajorEN()
{
IdXzMajor = objvXzMajorENS.IdXzMajor, //专业流水号
MajorID = objvXzMajorENS.MajorID, //专业ID
MajorName = objvXzMajorENS.MajorName, //专业名称
MajorEnglishName = objvXzMajorENS.MajorEnglishName, //专业英文名称
MajorExplain = objvXzMajorENS.MajorExplain, //专业说明
MajorNationalID = objvXzMajorENS.MajorNationalID, //专业国家代码
IdXzCollege = objvXzMajorENS.IdXzCollege, //学院流水号
CollegeId = objvXzMajorENS.CollegeId, //学院ID
CollegeName = objvXzMajorENS.CollegeName, //学院名称
CollegeNameA = objvXzMajorENS.CollegeNameA, //学院名称简写
IdMajorType = objvXzMajorENS.IdMajorType, //专业类型(文理工)流水号
MajorTypeName = objvXzMajorENS.MajorTypeName, //专业类型名称
IdDegreeType = objvXzMajorENS.IdDegreeType, //学位类型流水号
XwTypeDesc = objvXzMajorENS.XwTypeDesc, //学位类型名称
IsMainMajor = objvXzMajorENS.IsMainMajor, //是否重要专业
MajorDirection = objvXzMajorENS.MajorDirection, //专业方向
IsVisible = objvXzMajorENS.IsVisible, //是否显示
IsNormal = objvXzMajorENS.IsNormal, //IsNormal
ModifyDate = objvXzMajorENS.ModifyDate, //修改日期
ModifyUserId = objvXzMajorENS.ModifyUserId, //修改人
Memo = objvXzMajorENS.Memo, //备注
IsVisible4XzClg = objvXzMajorENS.IsVisible4XzClg, //IsVisible4XzClg
TypeName = objvXzMajorENS.TypeName, //类型名称
IdXzMajorShoolType = objvXzMajorENS.IdXzMajorShoolType, //专业学校类型流水号
};
 return objvXzMajorENT;
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
public static void CheckProperty4Condition(this clsvXzMajorEN objvXzMajorEN)
{
 clsvXzMajorBL.vXzMajorDA.CheckProperty4Condition(objvXzMajorEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzMajorEN objvXzMajorCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzMajorCond.IsUpdated(convXzMajor.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvXzMajorCond.dicFldComparisonOp[convXzMajor.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.IdXzMajor, objvXzMajorCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.MajorID) == true)
{
string strComparisonOpMajorID = objvXzMajorCond.dicFldComparisonOp[convXzMajor.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorID, objvXzMajorCond.MajorID, strComparisonOpMajorID);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.MajorName) == true)
{
string strComparisonOpMajorName = objvXzMajorCond.dicFldComparisonOp[convXzMajor.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorName, objvXzMajorCond.MajorName, strComparisonOpMajorName);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.MajorEnglishName) == true)
{
string strComparisonOpMajorEnglishName = objvXzMajorCond.dicFldComparisonOp[convXzMajor.MajorEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorEnglishName, objvXzMajorCond.MajorEnglishName, strComparisonOpMajorEnglishName);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.MajorExplain) == true)
{
string strComparisonOpMajorExplain = objvXzMajorCond.dicFldComparisonOp[convXzMajor.MajorExplain];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorExplain, objvXzMajorCond.MajorExplain, strComparisonOpMajorExplain);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.MajorNationalID) == true)
{
string strComparisonOpMajorNationalID = objvXzMajorCond.dicFldComparisonOp[convXzMajor.MajorNationalID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorNationalID, objvXzMajorCond.MajorNationalID, strComparisonOpMajorNationalID);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvXzMajorCond.dicFldComparisonOp[convXzMajor.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.IdXzCollege, objvXzMajorCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.CollegeId) == true)
{
string strComparisonOpCollegeId = objvXzMajorCond.dicFldComparisonOp[convXzMajor.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.CollegeId, objvXzMajorCond.CollegeId, strComparisonOpCollegeId);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.CollegeName) == true)
{
string strComparisonOpCollegeName = objvXzMajorCond.dicFldComparisonOp[convXzMajor.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.CollegeName, objvXzMajorCond.CollegeName, strComparisonOpCollegeName);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvXzMajorCond.dicFldComparisonOp[convXzMajor.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.CollegeNameA, objvXzMajorCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.IdMajorType) == true)
{
string strComparisonOpIdMajorType = objvXzMajorCond.dicFldComparisonOp[convXzMajor.IdMajorType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.IdMajorType, objvXzMajorCond.IdMajorType, strComparisonOpIdMajorType);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.MajorTypeName) == true)
{
string strComparisonOpMajorTypeName = objvXzMajorCond.dicFldComparisonOp[convXzMajor.MajorTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorTypeName, objvXzMajorCond.MajorTypeName, strComparisonOpMajorTypeName);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.IdDegreeType) == true)
{
string strComparisonOpIdDegreeType = objvXzMajorCond.dicFldComparisonOp[convXzMajor.IdDegreeType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.IdDegreeType, objvXzMajorCond.IdDegreeType, strComparisonOpIdDegreeType);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.XwTypeDesc) == true)
{
string strComparisonOpXwTypeDesc = objvXzMajorCond.dicFldComparisonOp[convXzMajor.XwTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.XwTypeDesc, objvXzMajorCond.XwTypeDesc, strComparisonOpXwTypeDesc);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.IsMainMajor) == true)
{
if (objvXzMajorCond.IsMainMajor == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.IsMainMajor);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.IsMainMajor);
}
}
if (objvXzMajorCond.IsUpdated(convXzMajor.MajorDirection) == true)
{
string strComparisonOpMajorDirection = objvXzMajorCond.dicFldComparisonOp[convXzMajor.MajorDirection];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorDirection, objvXzMajorCond.MajorDirection, strComparisonOpMajorDirection);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.IsVisible) == true)
{
if (objvXzMajorCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.IsVisible);
}
}
if (objvXzMajorCond.IsUpdated(convXzMajor.IsNormal) == true)
{
if (objvXzMajorCond.IsNormal == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.IsNormal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.IsNormal);
}
}
if (objvXzMajorCond.IsUpdated(convXzMajor.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvXzMajorCond.dicFldComparisonOp[convXzMajor.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.ModifyDate, objvXzMajorCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvXzMajorCond.dicFldComparisonOp[convXzMajor.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.ModifyUserId, objvXzMajorCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.Memo) == true)
{
string strComparisonOpMemo = objvXzMajorCond.dicFldComparisonOp[convXzMajor.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.Memo, objvXzMajorCond.Memo, strComparisonOpMemo);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.IsVisible4XzClg) == true)
{
if (objvXzMajorCond.IsVisible4XzClg == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.IsVisible4XzClg);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.IsVisible4XzClg);
}
}
if (objvXzMajorCond.IsUpdated(convXzMajor.TypeName) == true)
{
string strComparisonOpTypeName = objvXzMajorCond.dicFldComparisonOp[convXzMajor.TypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.TypeName, objvXzMajorCond.TypeName, strComparisonOpTypeName);
}
if (objvXzMajorCond.IsUpdated(convXzMajor.IdXzMajorShoolType) == true)
{
string strComparisonOpIdXzMajorShoolType = objvXzMajorCond.dicFldComparisonOp[convXzMajor.IdXzMajorShoolType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.IdXzMajorShoolType, objvXzMajorCond.IdXzMajorShoolType, strComparisonOpIdXzMajorShoolType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzMajor
{
public virtual bool UpdRelaTabDate(string strIdXzMajor, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v专业(vXzMajor)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzMajorBL
{
public static RelatedActions_vXzMajor relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzMajorDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzMajorDA vXzMajorDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzMajorDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzMajorBL()
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
if (string.IsNullOrEmpty(clsvXzMajorEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzMajorEN._ConnectString);
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
public static DataTable GetDataTable_vXzMajor(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzMajorDA.GetDataTable_vXzMajor(strWhereCond);
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
objDT = vXzMajorDA.GetDataTable(strWhereCond);
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
objDT = vXzMajorDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vXzMajorDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vXzMajorDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vXzMajorDA.GetDataTable_Top(objTopPara);
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
objDT = vXzMajorDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vXzMajorDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vXzMajorDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdXzMajorLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstByIdXzMajorLst(List<string> arrIdXzMajorLst)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdXzMajorLst, true);
 string strWhereCond = string.Format("IdXzMajor in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdXzMajorLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzMajorEN> GetObjLstByIdXzMajorLstCache(List<string> arrIdXzMajorLst)
{
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName);
List<clsvXzMajorEN> arrvXzMajorObjLstCache = GetObjLstCache();
IEnumerable <clsvXzMajorEN> arrvXzMajorObjLst_Sel =
arrvXzMajorObjLstCache
.Where(x => arrIdXzMajorLst.Contains(x.IdXzMajor));
return arrvXzMajorObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLst(string strWhereCond)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
public static List<clsvXzMajorEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvXzMajorCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzMajorEN> GetSubObjLstCache(clsvXzMajorEN objvXzMajorCond)
{
List<clsvXzMajorEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzMajorEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzMajor.AttributeName)
{
if (objvXzMajorCond.IsUpdated(strFldName) == false) continue;
if (objvXzMajorCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzMajorCond[strFldName].ToString());
}
else
{
if (objvXzMajorCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzMajorCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzMajorCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzMajorCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzMajorCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzMajorCond[strFldName]));
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
public static List<clsvXzMajorEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
public static List<clsvXzMajorEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
List<clsvXzMajorEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvXzMajorEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvXzMajorEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
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
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
public static List<clsvXzMajorEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvXzMajorEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
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
public static List<clsvXzMajorEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzMajorEN> arrObjLst = new List<clsvXzMajorEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN();
try
{
objvXzMajorEN.IdXzMajor = objRow[convXzMajor.IdXzMajor].ToString().Trim(); //专业流水号
objvXzMajorEN.MajorID = objRow[convXzMajor.MajorID].ToString().Trim(); //专业ID
objvXzMajorEN.MajorName = objRow[convXzMajor.MajorName].ToString().Trim(); //专业名称
objvXzMajorEN.MajorEnglishName = objRow[convXzMajor.MajorEnglishName] == DBNull.Value ? null : objRow[convXzMajor.MajorEnglishName].ToString().Trim(); //专业英文名称
objvXzMajorEN.MajorExplain = objRow[convXzMajor.MajorExplain] == DBNull.Value ? null : objRow[convXzMajor.MajorExplain].ToString().Trim(); //专业说明
objvXzMajorEN.MajorNationalID = objRow[convXzMajor.MajorNationalID] == DBNull.Value ? null : objRow[convXzMajor.MajorNationalID].ToString().Trim(); //专业国家代码
objvXzMajorEN.IdXzCollege = objRow[convXzMajor.IdXzCollege] == DBNull.Value ? null : objRow[convXzMajor.IdXzCollege].ToString().Trim(); //学院流水号
objvXzMajorEN.CollegeId = objRow[convXzMajor.CollegeId].ToString().Trim(); //学院ID
objvXzMajorEN.CollegeName = objRow[convXzMajor.CollegeName].ToString().Trim(); //学院名称
objvXzMajorEN.CollegeNameA = objRow[convXzMajor.CollegeNameA] == DBNull.Value ? null : objRow[convXzMajor.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzMajorEN.IdMajorType = objRow[convXzMajor.IdMajorType] == DBNull.Value ? null : objRow[convXzMajor.IdMajorType].ToString().Trim(); //专业类型(文理工)流水号
objvXzMajorEN.MajorTypeName = objRow[convXzMajor.MajorTypeName].ToString().Trim(); //专业类型名称
objvXzMajorEN.IdDegreeType = objRow[convXzMajor.IdDegreeType] == DBNull.Value ? null : objRow[convXzMajor.IdDegreeType].ToString().Trim(); //学位类型流水号
objvXzMajorEN.XwTypeDesc = objRow[convXzMajor.XwTypeDesc].ToString().Trim(); //学位类型名称
objvXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objvXzMajorEN.MajorDirection = objRow[convXzMajor.MajorDirection] == DBNull.Value ? null : objRow[convXzMajor.MajorDirection].ToString().Trim(); //专业方向
objvXzMajorEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible].ToString().Trim()); //是否显示
objvXzMajorEN.IsNormal = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsNormal].ToString().Trim()); //IsNormal
objvXzMajorEN.ModifyDate = objRow[convXzMajor.ModifyDate] == DBNull.Value ? null : objRow[convXzMajor.ModifyDate].ToString().Trim(); //修改日期
objvXzMajorEN.ModifyUserId = objRow[convXzMajor.ModifyUserId] == DBNull.Value ? null : objRow[convXzMajor.ModifyUserId].ToString().Trim(); //修改人
objvXzMajorEN.Memo = objRow[convXzMajor.Memo] == DBNull.Value ? null : objRow[convXzMajor.Memo].ToString().Trim(); //备注
objvXzMajorEN.IsVisible4XzClg = clsEntityBase2.TransNullToBool_S(objRow[convXzMajor.IsVisible4XzClg].ToString().Trim()); //IsVisible4XzClg
objvXzMajorEN.TypeName = objRow[convXzMajor.TypeName] == DBNull.Value ? null : objRow[convXzMajor.TypeName].ToString().Trim(); //类型名称
objvXzMajorEN.IdXzMajorShoolType = objRow[convXzMajor.IdXzMajorShoolType] == DBNull.Value ? null : objRow[convXzMajor.IdXzMajorShoolType].ToString().Trim(); //专业学校类型流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzMajorEN.IdXzMajor, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzMajorEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzMajorEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzMajor(ref clsvXzMajorEN objvXzMajorEN)
{
bool bolResult = vXzMajorDA.GetvXzMajor(ref objvXzMajorEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdXzMajor">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorEN GetObjByIdXzMajor(string strIdXzMajor)
{
if (strIdXzMajor.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdXzMajor]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdXzMajor) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdXzMajor]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvXzMajorEN objvXzMajorEN = vXzMajorDA.GetObjByIdXzMajor(strIdXzMajor);
return objvXzMajorEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzMajorEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzMajorEN objvXzMajorEN = vXzMajorDA.GetFirstObj(strWhereCond);
 return objvXzMajorEN;
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
public static clsvXzMajorEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzMajorEN objvXzMajorEN = vXzMajorDA.GetObjByDataRow(objRow);
 return objvXzMajorEN;
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
public static clsvXzMajorEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzMajorEN objvXzMajorEN = vXzMajorDA.GetObjByDataRow(objRow);
 return objvXzMajorEN;
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
 /// <param name = "strIdXzMajor">所给的关键字</param>
 /// <param name = "lstvXzMajorObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzMajorEN GetObjByIdXzMajorFromList(string strIdXzMajor, List<clsvXzMajorEN> lstvXzMajorObjLst)
{
foreach (clsvXzMajorEN objvXzMajorEN in lstvXzMajorObjLst)
{
if (objvXzMajorEN.IdXzMajor == strIdXzMajor)
{
return objvXzMajorEN;
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
 string strIdXzMajor;
 try
 {
 strIdXzMajor = new clsvXzMajorDA().GetFirstID(strWhereCond);
 return strIdXzMajor;
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
 arrList = vXzMajorDA.GetID(strWhereCond);
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
bool bolIsExist = vXzMajorDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdXzMajor">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdXzMajor)
{
if (string.IsNullOrEmpty(strIdXzMajor) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdXzMajor]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vXzMajorDA.IsExist(strIdXzMajor);
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
 bolIsExist = clsvXzMajorDA.IsExistTable();
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
 bolIsExist = vXzMajorDA.IsExistTable(strTabName);
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
 /// <param name = "objvXzMajorENS">源对象</param>
 /// <param name = "objvXzMajorENT">目标对象</param>
 public static void CopyTo(clsvXzMajorEN objvXzMajorENS, clsvXzMajorEN objvXzMajorENT)
{
try
{
objvXzMajorENT.IdXzMajor = objvXzMajorENS.IdXzMajor; //专业流水号
objvXzMajorENT.MajorID = objvXzMajorENS.MajorID; //专业ID
objvXzMajorENT.MajorName = objvXzMajorENS.MajorName; //专业名称
objvXzMajorENT.MajorEnglishName = objvXzMajorENS.MajorEnglishName; //专业英文名称
objvXzMajorENT.MajorExplain = objvXzMajorENS.MajorExplain; //专业说明
objvXzMajorENT.MajorNationalID = objvXzMajorENS.MajorNationalID; //专业国家代码
objvXzMajorENT.IdXzCollege = objvXzMajorENS.IdXzCollege; //学院流水号
objvXzMajorENT.CollegeId = objvXzMajorENS.CollegeId; //学院ID
objvXzMajorENT.CollegeName = objvXzMajorENS.CollegeName; //学院名称
objvXzMajorENT.CollegeNameA = objvXzMajorENS.CollegeNameA; //学院名称简写
objvXzMajorENT.IdMajorType = objvXzMajorENS.IdMajorType; //专业类型(文理工)流水号
objvXzMajorENT.MajorTypeName = objvXzMajorENS.MajorTypeName; //专业类型名称
objvXzMajorENT.IdDegreeType = objvXzMajorENS.IdDegreeType; //学位类型流水号
objvXzMajorENT.XwTypeDesc = objvXzMajorENS.XwTypeDesc; //学位类型名称
objvXzMajorENT.IsMainMajor = objvXzMajorENS.IsMainMajor; //是否重要专业
objvXzMajorENT.MajorDirection = objvXzMajorENS.MajorDirection; //专业方向
objvXzMajorENT.IsVisible = objvXzMajorENS.IsVisible; //是否显示
objvXzMajorENT.IsNormal = objvXzMajorENS.IsNormal; //IsNormal
objvXzMajorENT.ModifyDate = objvXzMajorENS.ModifyDate; //修改日期
objvXzMajorENT.ModifyUserId = objvXzMajorENS.ModifyUserId; //修改人
objvXzMajorENT.Memo = objvXzMajorENS.Memo; //备注
objvXzMajorENT.IsVisible4XzClg = objvXzMajorENS.IsVisible4XzClg; //IsVisible4XzClg
objvXzMajorENT.TypeName = objvXzMajorENS.TypeName; //类型名称
objvXzMajorENT.IdXzMajorShoolType = objvXzMajorENS.IdXzMajorShoolType; //专业学校类型流水号
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
 /// <param name = "objvXzMajorEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzMajorEN objvXzMajorEN)
{
try
{
objvXzMajorEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvXzMajorEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzMajor.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IdXzMajor = objvXzMajorEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convXzMajor.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.MajorID = objvXzMajorEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convXzMajor.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.MajorName = objvXzMajorEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convXzMajor.MajorEnglishName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.MajorEnglishName = objvXzMajorEN.MajorEnglishName == "[null]" ? null :  objvXzMajorEN.MajorEnglishName; //专业英文名称
}
if (arrFldSet.Contains(convXzMajor.MajorExplain, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.MajorExplain = objvXzMajorEN.MajorExplain == "[null]" ? null :  objvXzMajorEN.MajorExplain; //专业说明
}
if (arrFldSet.Contains(convXzMajor.MajorNationalID, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.MajorNationalID = objvXzMajorEN.MajorNationalID == "[null]" ? null :  objvXzMajorEN.MajorNationalID; //专业国家代码
}
if (arrFldSet.Contains(convXzMajor.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IdXzCollege = objvXzMajorEN.IdXzCollege == "[null]" ? null :  objvXzMajorEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convXzMajor.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.CollegeId = objvXzMajorEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(convXzMajor.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.CollegeName = objvXzMajorEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convXzMajor.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.CollegeNameA = objvXzMajorEN.CollegeNameA == "[null]" ? null :  objvXzMajorEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convXzMajor.IdMajorType, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IdMajorType = objvXzMajorEN.IdMajorType == "[null]" ? null :  objvXzMajorEN.IdMajorType; //专业类型(文理工)流水号
}
if (arrFldSet.Contains(convXzMajor.MajorTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.MajorTypeName = objvXzMajorEN.MajorTypeName; //专业类型名称
}
if (arrFldSet.Contains(convXzMajor.IdDegreeType, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IdDegreeType = objvXzMajorEN.IdDegreeType == "[null]" ? null :  objvXzMajorEN.IdDegreeType; //学位类型流水号
}
if (arrFldSet.Contains(convXzMajor.XwTypeDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.XwTypeDesc = objvXzMajorEN.XwTypeDesc; //学位类型名称
}
if (arrFldSet.Contains(convXzMajor.IsMainMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IsMainMajor = objvXzMajorEN.IsMainMajor; //是否重要专业
}
if (arrFldSet.Contains(convXzMajor.MajorDirection, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.MajorDirection = objvXzMajorEN.MajorDirection == "[null]" ? null :  objvXzMajorEN.MajorDirection; //专业方向
}
if (arrFldSet.Contains(convXzMajor.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IsVisible = objvXzMajorEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convXzMajor.IsNormal, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IsNormal = objvXzMajorEN.IsNormal; //IsNormal
}
if (arrFldSet.Contains(convXzMajor.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.ModifyDate = objvXzMajorEN.ModifyDate == "[null]" ? null :  objvXzMajorEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convXzMajor.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.ModifyUserId = objvXzMajorEN.ModifyUserId == "[null]" ? null :  objvXzMajorEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(convXzMajor.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.Memo = objvXzMajorEN.Memo == "[null]" ? null :  objvXzMajorEN.Memo; //备注
}
if (arrFldSet.Contains(convXzMajor.IsVisible4XzClg, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IsVisible4XzClg = objvXzMajorEN.IsVisible4XzClg; //IsVisible4XzClg
}
if (arrFldSet.Contains(convXzMajor.TypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.TypeName = objvXzMajorEN.TypeName == "[null]" ? null :  objvXzMajorEN.TypeName; //类型名称
}
if (arrFldSet.Contains(convXzMajor.IdXzMajorShoolType, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzMajorEN.IdXzMajorShoolType = objvXzMajorEN.IdXzMajorShoolType == "[null]" ? null :  objvXzMajorEN.IdXzMajorShoolType; //专业学校类型流水号
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
 /// <param name = "objvXzMajorEN">源简化对象</param>
 public static void AccessFldValueNull(clsvXzMajorEN objvXzMajorEN)
{
try
{
if (objvXzMajorEN.MajorEnglishName == "[null]") objvXzMajorEN.MajorEnglishName = null; //专业英文名称
if (objvXzMajorEN.MajorExplain == "[null]") objvXzMajorEN.MajorExplain = null; //专业说明
if (objvXzMajorEN.MajorNationalID == "[null]") objvXzMajorEN.MajorNationalID = null; //专业国家代码
if (objvXzMajorEN.IdXzCollege == "[null]") objvXzMajorEN.IdXzCollege = null; //学院流水号
if (objvXzMajorEN.CollegeNameA == "[null]") objvXzMajorEN.CollegeNameA = null; //学院名称简写
if (objvXzMajorEN.IdMajorType == "[null]") objvXzMajorEN.IdMajorType = null; //专业类型(文理工)流水号
if (objvXzMajorEN.IdDegreeType == "[null]") objvXzMajorEN.IdDegreeType = null; //学位类型流水号
if (objvXzMajorEN.MajorDirection == "[null]") objvXzMajorEN.MajorDirection = null; //专业方向
if (objvXzMajorEN.ModifyDate == "[null]") objvXzMajorEN.ModifyDate = null; //修改日期
if (objvXzMajorEN.ModifyUserId == "[null]") objvXzMajorEN.ModifyUserId = null; //修改人
if (objvXzMajorEN.Memo == "[null]") objvXzMajorEN.Memo = null; //备注
if (objvXzMajorEN.TypeName == "[null]") objvXzMajorEN.TypeName = null; //类型名称
if (objvXzMajorEN.IdXzMajorShoolType == "[null]") objvXzMajorEN.IdXzMajorShoolType = null; //专业学校类型流水号
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
public static void CheckProperty4Condition(clsvXzMajorEN objvXzMajorEN)
{
 vXzMajorDA.CheckProperty4Condition(objvXzMajorEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdXzMajor(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzMajor.IdXzMajor); 
List<clsvXzMajorEN> arrObjLst = clsvXzMajorBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN()
{
IdXzMajor = "0",
MajorName = "选[v专业]..."
};
arrObjLst.Insert(0, objvXzMajorEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzMajor.IdXzMajor;
objComboBox.DisplayMember = convXzMajor.MajorName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdXzMajor(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v专业]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convXzMajor.IdXzMajor); 
IEnumerable<clsvXzMajorEN> arrObjLst = clsvXzMajorBL.GetObjLst(strCondition);
objDDL.DataValueField = convXzMajor.IdXzMajor;
objDDL.DataTextField = convXzMajor.MajorName;
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
public static void BindDdl_IdXzMajorCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v专业]...","0");
List<clsvXzMajorEN> arrvXzMajorObjLst = GetAllvXzMajorObjLstCache(); 
objDDL.DataValueField = convXzMajor.IdXzMajor;
objDDL.DataTextField = convXzMajor.MajorName;
objDDL.DataSource = arrvXzMajorObjLst;
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
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeBL没有刷新缓存机制(clsXzDegreeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeBL没有刷新缓存机制(clsXzMajorTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeBL没有刷新缓存机制(clsXzMajorShoolTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdXzMajor");
//if (arrvXzMajorObjLstCache == null)
//{
//arrvXzMajorObjLstCache = vXzMajorDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdXzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzMajorEN GetObjByIdXzMajorCache(string strIdXzMajor)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName);
List<clsvXzMajorEN> arrvXzMajorObjLstCache = GetObjLstCache();
IEnumerable <clsvXzMajorEN> arrvXzMajorObjLst_Sel =
arrvXzMajorObjLstCache
.Where(x=> x.IdXzMajor == strIdXzMajor 
);
if (arrvXzMajorObjLst_Sel.Count() == 0)
{
   clsvXzMajorEN obj = clsvXzMajorBL.GetObjByIdXzMajor(strIdXzMajor);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvXzMajorObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdXzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMajorNameByIdXzMajorCache(string strIdXzMajor)
{
if (string.IsNullOrEmpty(strIdXzMajor) == true) return "";
//获取缓存中的对象列表
clsvXzMajorEN objvXzMajor = GetObjByIdXzMajorCache(strIdXzMajor);
if (objvXzMajor == null) return "";
return objvXzMajor.MajorName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdXzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdXzMajorCache(string strIdXzMajor)
{
if (string.IsNullOrEmpty(strIdXzMajor) == true) return "";
//获取缓存中的对象列表
clsvXzMajorEN objvXzMajor = GetObjByIdXzMajorCache(strIdXzMajor);
if (objvXzMajor == null) return "";
return objvXzMajor.MajorName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzMajorEN> GetAllvXzMajorObjLstCache()
{
//获取缓存中的对象列表
List<clsvXzMajorEN> arrvXzMajorObjLstCache = GetObjLstCache(); 
return arrvXzMajorObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName);
List<clsvXzMajorEN> arrvXzMajorObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzMajorObjLstCache;
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
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdXzMajor)
{
if (strInFldName != convXzMajor.IdXzMajor)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzMajor.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzMajor.AttributeName));
throw new Exception(strMsg);
}
var objvXzMajor = clsvXzMajorBL.GetObjByIdXzMajorCache(strIdXzMajor);
if (objvXzMajor == null) return "";
return objvXzMajor[strOutFldName].ToString();
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
int intRecCount = clsvXzMajorDA.GetRecCount(strTabName);
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
int intRecCount = clsvXzMajorDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzMajorDA.GetRecCount();
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
int intRecCount = clsvXzMajorDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvXzMajorCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvXzMajorEN objvXzMajorCond)
{
List<clsvXzMajorEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzMajorEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzMajor.AttributeName)
{
if (objvXzMajorCond.IsUpdated(strFldName) == false) continue;
if (objvXzMajorCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzMajorCond[strFldName].ToString());
}
else
{
if (objvXzMajorCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzMajorCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzMajorCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzMajorCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzMajorCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzMajorCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzMajorCond[strFldName]));
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
 List<string> arrList = clsvXzMajorDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vXzMajorDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vXzMajorDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}