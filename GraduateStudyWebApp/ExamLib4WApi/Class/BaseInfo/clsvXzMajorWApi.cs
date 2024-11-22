
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzMajorWApi
 表名:vXzMajor(01120066)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:27
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护
 模块英文名:BaseInfo
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
public static class clsvXzMajorWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN Setid_XzMajor(this clsvXzMajorEN objvXzMajorEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convXzMajor.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convXzMajor.id_XzMajor);
objvXzMajorEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.id_XzMajor) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.id_XzMajor, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.id_XzMajor] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMajorID(this clsvXzMajorEN objvXzMajorEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convXzMajor.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, convXzMajor.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convXzMajor.MajorID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMajorName(this clsvXzMajorEN objvXzMajorEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convXzMajor.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convXzMajor.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMajorEnglishName(this clsvXzMajorEN objvXzMajorEN, string strMajorEnglishName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorEnglishName, 200, convXzMajor.MajorEnglishName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMajorExplain(this clsvXzMajorEN objvXzMajorEN, string strMajorExplain, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorExplain, 2000, convXzMajor.MajorExplain);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMajorNationalID(this clsvXzMajorEN objvXzMajorEN, string strMajorNationalID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorNationalID, 10, convXzMajor.MajorNationalID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN Setid_XzCollege(this clsvXzMajorEN objvXzMajorEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convXzMajor.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convXzMajor.id_XzCollege);
objvXzMajorEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.id_XzCollege) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.id_XzCollege, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.id_XzCollege] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetCollegeID(this clsvXzMajorEN objvXzMajorEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, convXzMajor.CollegeID);
clsCheckSql.CheckFieldLen(strCollegeID, 4, convXzMajor.CollegeID);
objvXzMajorEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.CollegeID) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.CollegeID, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.CollegeID] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetCollegeName(this clsvXzMajorEN objvXzMajorEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convXzMajor.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convXzMajor.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetCollegeNameA(this clsvXzMajorEN objvXzMajorEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convXzMajor.CollegeNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN Setid_MajorType(this clsvXzMajorEN objvXzMajorEN, string strid_MajorType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MajorType, 4, convXzMajor.id_MajorType);
clsCheckSql.CheckFieldForeignKey(strid_MajorType, 4, convXzMajor.id_MajorType);
objvXzMajorEN.id_MajorType = strid_MajorType; //专业类型(文理工)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.id_MajorType) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.id_MajorType, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.id_MajorType] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMajorTypeName(this clsvXzMajorEN objvXzMajorEN, string strMajorTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorTypeName, convXzMajor.MajorTypeName);
clsCheckSql.CheckFieldLen(strMajorTypeName, 50, convXzMajor.MajorTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN Setid_DegreeType(this clsvXzMajorEN objvXzMajorEN, string strid_DegreeType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_DegreeType, 4, convXzMajor.id_DegreeType);
clsCheckSql.CheckFieldForeignKey(strid_DegreeType, 4, convXzMajor.id_DegreeType);
objvXzMajorEN.id_DegreeType = strid_DegreeType; //学位类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.id_DegreeType) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.id_DegreeType, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.id_DegreeType] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetXwTypeDesc(this clsvXzMajorEN objvXzMajorEN, string strXwTypeDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strXwTypeDesc, convXzMajor.XwTypeDesc);
clsCheckSql.CheckFieldLen(strXwTypeDesc, 60, convXzMajor.XwTypeDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMajorDirection(this clsvXzMajorEN objvXzMajorEN, string strMajorDirection, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorDirection, 30, convXzMajor.MajorDirection);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetModifyDate(this clsvXzMajorEN objvXzMajorEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzMajor.ModifyDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetModifyUserID(this clsvXzMajorEN objvXzMajorEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convXzMajor.ModifyUserID);
objvXzMajorEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.ModifyUserID) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.ModifyUserID, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.ModifyUserID] = strComparisonOp;
}
}
return objvXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetMemo(this clsvXzMajorEN objvXzMajorEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzMajor.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN SetTypeName(this clsvXzMajorEN objvXzMajorEN, string strTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTypeName, 200, convXzMajor.TypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzMajorEN Setid_XzMajorShoolType(this clsvXzMajorEN objvXzMajorEN, string strid_XzMajorShoolType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajorShoolType, 4, convXzMajor.id_XzMajorShoolType);
clsCheckSql.CheckFieldForeignKey(strid_XzMajorShoolType, 4, convXzMajor.id_XzMajorShoolType);
objvXzMajorEN.id_XzMajorShoolType = strid_XzMajorShoolType; //专业学校类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzMajorEN.dicFldComparisonOp.ContainsKey(convXzMajor.id_XzMajorShoolType) == false)
{
objvXzMajorEN.dicFldComparisonOp.Add(convXzMajor.id_XzMajorShoolType, strComparisonOp);
}
else
{
objvXzMajorEN.dicFldComparisonOp[convXzMajor.id_XzMajorShoolType] = strComparisonOp;
}
}
return objvXzMajorEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzMajorEN objvXzMajor_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzMajor_Cond.IsUpdated(convXzMajor.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.id_XzMajor, objvXzMajor_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.MajorID) == true)
{
string strComparisonOp_MajorID = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorID, objvXzMajor_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.MajorName) == true)
{
string strComparisonOp_MajorName = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorName, objvXzMajor_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.MajorEnglishName) == true)
{
string strComparisonOp_MajorEnglishName = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.MajorEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorEnglishName, objvXzMajor_Cond.MajorEnglishName, strComparisonOp_MajorEnglishName);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.MajorExplain) == true)
{
string strComparisonOp_MajorExplain = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.MajorExplain];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorExplain, objvXzMajor_Cond.MajorExplain, strComparisonOp_MajorExplain);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.MajorNationalID) == true)
{
string strComparisonOp_MajorNationalID = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.MajorNationalID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorNationalID, objvXzMajor_Cond.MajorNationalID, strComparisonOp_MajorNationalID);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.id_XzCollege, objvXzMajor_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.CollegeID, objvXzMajor_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.CollegeName, objvXzMajor_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.CollegeNameA, objvXzMajor_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.id_MajorType) == true)
{
string strComparisonOp_id_MajorType = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.id_MajorType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.id_MajorType, objvXzMajor_Cond.id_MajorType, strComparisonOp_id_MajorType);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.MajorTypeName) == true)
{
string strComparisonOp_MajorTypeName = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.MajorTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorTypeName, objvXzMajor_Cond.MajorTypeName, strComparisonOp_MajorTypeName);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.id_DegreeType) == true)
{
string strComparisonOp_id_DegreeType = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.id_DegreeType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.id_DegreeType, objvXzMajor_Cond.id_DegreeType, strComparisonOp_id_DegreeType);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.XwTypeDesc) == true)
{
string strComparisonOp_XwTypeDesc = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.XwTypeDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.XwTypeDesc, objvXzMajor_Cond.XwTypeDesc, strComparisonOp_XwTypeDesc);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.IsMainMajor) == true)
{
if (objvXzMajor_Cond.IsMainMajor == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.IsMainMajor);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.IsMainMajor);
}
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.MajorDirection) == true)
{
string strComparisonOp_MajorDirection = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.MajorDirection];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.MajorDirection, objvXzMajor_Cond.MajorDirection, strComparisonOp_MajorDirection);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.IsVisible) == true)
{
if (objvXzMajor_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.IsVisible);
}
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.IsNormal) == true)
{
if (objvXzMajor_Cond.IsNormal == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.IsNormal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.IsNormal);
}
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.ModifyDate, objvXzMajor_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.ModifyUserID, objvXzMajor_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.Memo) == true)
{
string strComparisonOp_Memo = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.Memo, objvXzMajor_Cond.Memo, strComparisonOp_Memo);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.IsVisible4XzClg) == true)
{
if (objvXzMajor_Cond.IsVisible4XzClg == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzMajor.IsVisible4XzClg);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzMajor.IsVisible4XzClg);
}
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.TypeName) == true)
{
string strComparisonOp_TypeName = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.TypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.TypeName, objvXzMajor_Cond.TypeName, strComparisonOp_TypeName);
}
if (objvXzMajor_Cond.IsUpdated(convXzMajor.id_XzMajorShoolType) == true)
{
string strComparisonOp_id_XzMajorShoolType = objvXzMajor_Cond.dicFldComparisonOp[convXzMajor.id_XzMajorShoolType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzMajor.id_XzMajorShoolType, objvXzMajor_Cond.id_XzMajorShoolType, strComparisonOp_id_XzMajorShoolType);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v专业(vXzMajor)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzMajorWApi
{
private static readonly string mstrApiControllerName = "vXzMajorApi";

 public clsvXzMajorWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_XzMajor(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v专业]...","0");
List<clsvXzMajorEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_XzMajor";
objDDL.DataTextField="MajorName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_XzMajor(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzMajor.id_XzMajor); 
List<clsvXzMajorEN> arrObjLst = clsvXzMajorWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzMajorEN objvXzMajorEN = new clsvXzMajorEN()
{
id_XzMajor = "0",
MajorName = "选[v专业]..."
};
arrObjLst.Insert(0, objvXzMajorEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzMajor.id_XzMajor;
objComboBox.DisplayMember = convXzMajor.MajorName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_XzMajor">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorEN GetObjByid_XzMajor(string strid_XzMajor)
{
string strAction = "GetObjByid_XzMajor";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzMajorEN objvXzMajorEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_XzMajor"] = strid_XzMajor
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzMajorEN = JsonConvert.DeserializeObject<clsvXzMajorEN>((string)jobjReturn["ReturnObj"]);
return objvXzMajorEN;
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
 /// <param name = "strid_XzMajor">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzMajorEN GetObjByid_XzMajor_WA_Cache(string strid_XzMajor)
{
string strAction = "GetObjByid_XzMajor_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzMajorEN objvXzMajorEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_XzMajor"] = strid_XzMajor
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzMajorEN = JsonConvert.DeserializeObject<clsvXzMajorEN>((string)jobjReturn["ReturnObj"]);
return objvXzMajorEN;
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
public static clsvXzMajorEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzMajorEN objvXzMajorEN = null;
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
objvXzMajorEN = JsonConvert.DeserializeObject<clsvXzMajorEN>((string)jobjReturn["ReturnObj"]);
return objvXzMajorEN;
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
 /// <param name = "strid_XzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzMajorEN GetObjByid_XzMajor_Cache(string strid_XzMajor)
{
if (string.IsNullOrEmpty(strid_XzMajor) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorEN> arrvXzMajorObjLst_Sel =
from objvXzMajorEN in arrvXzMajorObjLst_Cache
where objvXzMajorEN.id_XzMajor == strid_XzMajor
select objvXzMajorEN;
if (arrvXzMajorObjLst_Sel.Count() == 0)
{
   clsvXzMajorEN obj = clsvXzMajorWApi.GetObjByid_XzMajor(strid_XzMajor);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzMajorObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_XzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMajorNameByid_XzMajor_Cache(string strid_XzMajor)
{
if (string.IsNullOrEmpty(strid_XzMajor) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorEN> arrvXzMajorObjLst_Sel1 =
from objvXzMajorEN in arrvXzMajorObjLst_Cache
where objvXzMajorEN.id_XzMajor == strid_XzMajor
select objvXzMajorEN;
List <clsvXzMajorEN> arrvXzMajorObjLst_Sel = new List<clsvXzMajorEN>();
foreach (clsvXzMajorEN obj in arrvXzMajorObjLst_Sel1)
{
arrvXzMajorObjLst_Sel.Add(obj);
}
if (arrvXzMajorObjLst_Sel.Count > 0)
{
return arrvXzMajorObjLst_Sel[0].MajorName;
}
string strErrMsgForGetObjById = string.Format("在vXzMajor对象缓存列表中,找不到记录[id_XzMajor = {0}](函数:{1})", strid_XzMajor, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzMajorBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_XzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_XzMajor_Cache(string strid_XzMajor)
{
if (string.IsNullOrEmpty(strid_XzMajor) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorEN> arrvXzMajorObjLst_Sel1 =
from objvXzMajorEN in arrvXzMajorObjLst_Cache
where objvXzMajorEN.id_XzMajor == strid_XzMajor
select objvXzMajorEN;
List <clsvXzMajorEN> arrvXzMajorObjLst_Sel = new List<clsvXzMajorEN>();
foreach (clsvXzMajorEN obj in arrvXzMajorObjLst_Sel1)
{
arrvXzMajorObjLst_Sel.Add(obj);
}
if (arrvXzMajorObjLst_Sel.Count > 0)
{
return arrvXzMajorObjLst_Sel[0].MajorName;
}
string strErrMsgForGetObjById = string.Format("在vXzMajor对象缓存列表中,找不到记录的相关名称[id_XzMajor = {0}](函数:{1})", strid_XzMajor, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzMajorBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLst(string strWhereCond)
{
 List<clsvXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorEN> GetObjLstById_XzMajorLst(List<string> arrId_XzMajor)
{
 List<clsvXzMajorEN> arrObjLst = null; 
string strAction = "GetObjLstById_XzMajorLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_XzMajor);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_XzMajor">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvXzMajorEN> GetObjLstById_XzMajorLst_Cache(List<string> arrId_XzMajor)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzMajorEN> arrvXzMajorObjLst_Sel =
from objvXzMajorEN in arrvXzMajorObjLst_Cache
where arrId_XzMajor.Contains(objvXzMajorEN.id_XzMajor)
select objvXzMajorEN;
return arrvXzMajorObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzMajorEN> GetObjLstById_XzMajorLst_WA_Cache(List<string> arrId_XzMajor)
{
 List<clsvXzMajorEN> arrObjLst = null; 
string strAction = "GetObjLstById_XzMajorLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_XzMajor);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzMajorEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_XzMajor)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_XzMajor"] = strid_XzMajor
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
 /// <param name = "objvXzMajorENS">源对象</param>
 /// <param name = "objvXzMajorENT">目标对象</param>
 public static void CopyTo(clsvXzMajorEN objvXzMajorENS, clsvXzMajorEN objvXzMajorENT)
{
try
{
objvXzMajorENT.id_XzMajor = objvXzMajorENS.id_XzMajor; //专业流水号
objvXzMajorENT.MajorID = objvXzMajorENS.MajorID; //专业ID
objvXzMajorENT.MajorName = objvXzMajorENS.MajorName; //专业名称
objvXzMajorENT.MajorEnglishName = objvXzMajorENS.MajorEnglishName; //专业英文名称
objvXzMajorENT.MajorExplain = objvXzMajorENS.MajorExplain; //专业说明
objvXzMajorENT.MajorNationalID = objvXzMajorENS.MajorNationalID; //专业国家代码
objvXzMajorENT.id_XzCollege = objvXzMajorENS.id_XzCollege; //学院流水号
objvXzMajorENT.CollegeID = objvXzMajorENS.CollegeID; //学院ID
objvXzMajorENT.CollegeName = objvXzMajorENS.CollegeName; //学院名称
objvXzMajorENT.CollegeNameA = objvXzMajorENS.CollegeNameA; //学院名称简写
objvXzMajorENT.id_MajorType = objvXzMajorENS.id_MajorType; //专业类型(文理工)流水号
objvXzMajorENT.MajorTypeName = objvXzMajorENS.MajorTypeName; //专业类型名称
objvXzMajorENT.id_DegreeType = objvXzMajorENS.id_DegreeType; //学位类型流水号
objvXzMajorENT.XwTypeDesc = objvXzMajorENS.XwTypeDesc; //学位类型名称
objvXzMajorENT.IsMainMajor = objvXzMajorENS.IsMainMajor; //是否重要专业
objvXzMajorENT.MajorDirection = objvXzMajorENS.MajorDirection; //专业方向
objvXzMajorENT.IsVisible = objvXzMajorENS.IsVisible; //是否显示
objvXzMajorENT.IsNormal = objvXzMajorENS.IsNormal; //IsNormal
objvXzMajorENT.ModifyDate = objvXzMajorENS.ModifyDate; //修改日期
objvXzMajorENT.ModifyUserID = objvXzMajorENS.ModifyUserID; //修改人
objvXzMajorENT.Memo = objvXzMajorENS.Memo; //备注
objvXzMajorENT.IsVisible4XzClg = objvXzMajorENS.IsVisible4XzClg; //IsVisible4XzClg
objvXzMajorENT.TypeName = objvXzMajorENS.TypeName; //类型名称
objvXzMajorENT.id_XzMajorShoolType = objvXzMajorENS.id_XzMajorShoolType; //专业学校类型流水号
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
public static DataTable ToDataTable(List<clsvXzMajorEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzMajorEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzMajorEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzMajorEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzMajorEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzMajorEN.AttributeName)
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
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_XzMajor");
//if (arrvXzMajorObjLst_Cache == null)
//{
//arrvXzMajorObjLst_Cache = await clsvXzMajorWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
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
public static List<clsvXzMajorEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzMajorEN._CurrTabName_S);
List<clsvXzMajorEN> arrvXzMajorObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzMajorObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzMajorEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzMajor.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.MajorEnglishName, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.MajorExplain, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.MajorNationalID, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.id_MajorType, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.MajorTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.id_DegreeType, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.XwTypeDesc, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.IsMainMajor, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzMajor.MajorDirection, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzMajor.IsNormal, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzMajor.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.IsVisible4XzClg, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzMajor.TypeName, Type.GetType("System.String"));
objDT.Columns.Add(convXzMajor.id_XzMajorShoolType, Type.GetType("System.String"));
foreach (clsvXzMajorEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzMajor.id_XzMajor] = objInFor[convXzMajor.id_XzMajor];
objDR[convXzMajor.MajorID] = objInFor[convXzMajor.MajorID];
objDR[convXzMajor.MajorName] = objInFor[convXzMajor.MajorName];
objDR[convXzMajor.MajorEnglishName] = objInFor[convXzMajor.MajorEnglishName];
objDR[convXzMajor.MajorExplain] = objInFor[convXzMajor.MajorExplain];
objDR[convXzMajor.MajorNationalID] = objInFor[convXzMajor.MajorNationalID];
objDR[convXzMajor.id_XzCollege] = objInFor[convXzMajor.id_XzCollege];
objDR[convXzMajor.CollegeID] = objInFor[convXzMajor.CollegeID];
objDR[convXzMajor.CollegeName] = objInFor[convXzMajor.CollegeName];
objDR[convXzMajor.CollegeNameA] = objInFor[convXzMajor.CollegeNameA];
objDR[convXzMajor.id_MajorType] = objInFor[convXzMajor.id_MajorType];
objDR[convXzMajor.MajorTypeName] = objInFor[convXzMajor.MajorTypeName];
objDR[convXzMajor.id_DegreeType] = objInFor[convXzMajor.id_DegreeType];
objDR[convXzMajor.XwTypeDesc] = objInFor[convXzMajor.XwTypeDesc];
objDR[convXzMajor.IsMainMajor] = objInFor[convXzMajor.IsMainMajor];
objDR[convXzMajor.MajorDirection] = objInFor[convXzMajor.MajorDirection];
objDR[convXzMajor.IsVisible] = objInFor[convXzMajor.IsVisible];
objDR[convXzMajor.IsNormal] = objInFor[convXzMajor.IsNormal];
objDR[convXzMajor.ModifyDate] = objInFor[convXzMajor.ModifyDate];
objDR[convXzMajor.ModifyUserID] = objInFor[convXzMajor.ModifyUserID];
objDR[convXzMajor.Memo] = objInFor[convXzMajor.Memo];
objDR[convXzMajor.IsVisible4XzClg] = objInFor[convXzMajor.IsVisible4XzClg];
objDR[convXzMajor.TypeName] = objInFor[convXzMajor.TypeName];
objDR[convXzMajor.id_XzMajorShoolType] = objInFor[convXzMajor.id_XzMajorShoolType];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}