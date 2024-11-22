
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorWApi
 表名:XzMajor(01120065)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:28
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
public static class clsXzMajorWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN Setid_XzMajor(this clsXzMajorEN objXzMajorEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conXzMajor.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conXzMajor.id_XzMajor);
objXzMajorEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.id_XzMajor) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.id_XzMajor, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.id_XzMajor] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetMajorID(this clsXzMajorEN objXzMajorEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, conXzMajor.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, conXzMajor.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, conXzMajor.MajorID);
objXzMajorEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorID) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorID, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorID] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetMajorName(this clsXzMajorEN objXzMajorEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, conXzMajor.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, conXzMajor.MajorName);
objXzMajorEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorName) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorName, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorName] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetMajorEnglishName(this clsXzMajorEN objXzMajorEN, string strMajorEnglishName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorEnglishName, 200, conXzMajor.MajorEnglishName);
objXzMajorEN.MajorEnglishName = strMajorEnglishName; //专业英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorEnglishName) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorEnglishName, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorEnglishName] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetMajorExplain(this clsXzMajorEN objXzMajorEN, string strMajorExplain, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorExplain, 2000, conXzMajor.MajorExplain);
objXzMajorEN.MajorExplain = strMajorExplain; //专业说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorExplain) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorExplain, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorExplain] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetMajorNationalID(this clsXzMajorEN objXzMajorEN, string strMajorNationalID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorNationalID, 10, conXzMajor.MajorNationalID);
objXzMajorEN.MajorNationalID = strMajorNationalID; //专业国家代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorNationalID) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorNationalID, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorNationalID] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN Setid_XzCollege(this clsXzMajorEN objXzMajorEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzCollege, conXzMajor.id_XzCollege);
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, conXzMajor.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, conXzMajor.id_XzCollege);
objXzMajorEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.id_XzCollege) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.id_XzCollege, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.id_XzCollege] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN Setid_MajorType(this clsXzMajorEN objXzMajorEN, string strid_MajorType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MajorType, 4, conXzMajor.id_MajorType);
clsCheckSql.CheckFieldForeignKey(strid_MajorType, 4, conXzMajor.id_MajorType);
objXzMajorEN.id_MajorType = strid_MajorType; //专业类型(文理工)流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.id_MajorType) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.id_MajorType, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.id_MajorType] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN Setid_DegreeType(this clsXzMajorEN objXzMajorEN, string strid_DegreeType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_DegreeType, 4, conXzMajor.id_DegreeType);
clsCheckSql.CheckFieldForeignKey(strid_DegreeType, 4, conXzMajor.id_DegreeType);
objXzMajorEN.id_DegreeType = strid_DegreeType; //学位类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.id_DegreeType) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.id_DegreeType, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.id_DegreeType] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetIsMainMajor(this clsXzMajorEN objXzMajorEN, bool bolIsMainMajor, string strComparisonOp="")
	{
objXzMajorEN.IsMainMajor = bolIsMainMajor; //是否重要专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IsMainMajor) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IsMainMajor, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IsMainMajor] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetMajorDirection(this clsXzMajorEN objXzMajorEN, string strMajorDirection, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorDirection, 30, conXzMajor.MajorDirection);
objXzMajorEN.MajorDirection = strMajorDirection; //专业方向
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorDirection) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorDirection, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorDirection] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetIsVisible(this clsXzMajorEN objXzMajorEN, bool bolIsVisible, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsVisible, conXzMajor.IsVisible);
objXzMajorEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IsVisible) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IsVisible, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IsVisible] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetIsNormal(this clsXzMajorEN objXzMajorEN, bool bolIsNormal, string strComparisonOp="")
	{
objXzMajorEN.IsNormal = bolIsNormal; //IsNormal
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IsNormal) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IsNormal, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IsNormal] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetModifyDate(this clsXzMajorEN objXzMajorEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzMajor.ModifyDate);
objXzMajorEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.ModifyDate) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.ModifyDate, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.ModifyDate] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetModifyUserID(this clsXzMajorEN objXzMajorEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conXzMajor.ModifyUserID);
objXzMajorEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.ModifyUserID) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.ModifyUserID, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.ModifyUserID] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetMemo(this clsXzMajorEN objXzMajorEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzMajor.Memo);
objXzMajorEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.Memo) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.Memo, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.Memo] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN Setid_XzMajorShoolType(this clsXzMajorEN objXzMajorEN, string strid_XzMajorShoolType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajorShoolType, 4, conXzMajor.id_XzMajorShoolType);
clsCheckSql.CheckFieldForeignKey(strid_XzMajorShoolType, 4, conXzMajor.id_XzMajorShoolType);
objXzMajorEN.id_XzMajorShoolType = strid_XzMajorShoolType; //专业学校类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.id_XzMajorShoolType) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.id_XzMajorShoolType, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.id_XzMajorShoolType] = strComparisonOp;
}
}
return objXzMajorEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzMajorEN objXzMajor_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzMajor_Cond.IsUpdated(conXzMajor.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.id_XzMajor, objXzMajor_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.MajorID) == true)
{
string strComparisonOp_MajorID = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorID, objXzMajor_Cond.MajorID, strComparisonOp_MajorID);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.MajorName) == true)
{
string strComparisonOp_MajorName = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorName, objXzMajor_Cond.MajorName, strComparisonOp_MajorName);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.MajorEnglishName) == true)
{
string strComparisonOp_MajorEnglishName = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.MajorEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorEnglishName, objXzMajor_Cond.MajorEnglishName, strComparisonOp_MajorEnglishName);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.MajorExplain) == true)
{
string strComparisonOp_MajorExplain = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.MajorExplain];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorExplain, objXzMajor_Cond.MajorExplain, strComparisonOp_MajorExplain);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.MajorNationalID) == true)
{
string strComparisonOp_MajorNationalID = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.MajorNationalID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorNationalID, objXzMajor_Cond.MajorNationalID, strComparisonOp_MajorNationalID);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.id_XzCollege, objXzMajor_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.id_MajorType) == true)
{
string strComparisonOp_id_MajorType = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.id_MajorType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.id_MajorType, objXzMajor_Cond.id_MajorType, strComparisonOp_id_MajorType);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.id_DegreeType) == true)
{
string strComparisonOp_id_DegreeType = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.id_DegreeType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.id_DegreeType, objXzMajor_Cond.id_DegreeType, strComparisonOp_id_DegreeType);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.IsMainMajor) == true)
{
if (objXzMajor_Cond.IsMainMajor == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajor.IsMainMajor);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajor.IsMainMajor);
}
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.MajorDirection) == true)
{
string strComparisonOp_MajorDirection = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.MajorDirection];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorDirection, objXzMajor_Cond.MajorDirection, strComparisonOp_MajorDirection);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.IsVisible) == true)
{
if (objXzMajor_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajor.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajor.IsVisible);
}
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.IsNormal) == true)
{
if (objXzMajor_Cond.IsNormal == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajor.IsNormal);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajor.IsNormal);
}
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.ModifyDate, objXzMajor_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.ModifyUserID, objXzMajor_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.Memo) == true)
{
string strComparisonOp_Memo = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.Memo, objXzMajor_Cond.Memo, strComparisonOp_Memo);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.id_XzMajorShoolType) == true)
{
string strComparisonOp_id_XzMajorShoolType = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.id_XzMajorShoolType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.id_XzMajorShoolType, objXzMajor_Cond.id_XzMajorShoolType, strComparisonOp_id_XzMajorShoolType);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzMajorEN objXzMajorEN)
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_XzMajor) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objXzMajorEN.sf_UpdFldSetStr = objXzMajorEN.getsf_UpdFldSetStr();
clsXzMajorWApi.CheckPropertyNew(objXzMajorEN); 
bool bolResult = clsXzMajorWApi.UpdateRecord(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzMajor(专业), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objXzMajorEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_XzMajor(this clsXzMajorEN objXzMajorEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objXzMajorEN == null) return "";
if (objXzMajorEN.id_XzMajor == null || objXzMajorEN.id_XzMajor == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_XzMajor = '{0}'", objXzMajorEN.id_XzMajor);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_XzMajor !=  '{0}'", objXzMajorEN.id_XzMajor);
 sbCondition.AppendFormat(" and id_XzMajor = '{0}'", objXzMajorEN.id_XzMajor);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzMajorEN objXzMajorEN)
{
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_XzMajor) == true || clsXzMajorWApi.IsExist(objXzMajorEN.id_XzMajor) == true)
 {
     objXzMajorEN.id_XzMajor = clsXzMajorWApi.GetMaxStrId();
 }
clsXzMajorWApi.CheckPropertyNew(objXzMajorEN); 
bool bolResult = clsXzMajorWApi.AddNewRecord(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzMajorEN objXzMajorEN)
{
try
{
clsXzMajorWApi.CheckPropertyNew(objXzMajorEN); 
string strid_XzMajor = clsXzMajorWApi.AddNewRecordWithMaxId(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorWApi.ReFreshCache();
return strid_XzMajor;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objXzMajorEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzMajorEN objXzMajorEN, string strWhereCond)
{
try
{
clsXzMajorWApi.CheckPropertyNew(objXzMajorEN); 
bool bolResult = clsXzMajorWApi.UpdateWithCondition(objXzMajorEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 专业(XzMajor)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzMajorWApi
{
private static readonly string mstrApiControllerName = "XzMajorApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsXzMajorWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[专业]...","0");
List<clsXzMajorEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", conXzMajor.id_XzMajor); 
List<clsXzMajorEN> arrObjLst = clsXzMajorWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzMajorEN objXzMajorEN = new clsXzMajorEN()
{
id_XzMajor = "0",
MajorName = "选[专业]..."
};
arrObjLst.Insert(0, objXzMajorEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzMajor.id_XzMajor;
objComboBox.DisplayMember = conXzMajor.MajorName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsXzMajorEN objXzMajorEN)
{
if (!Object.Equals(null, objXzMajorEN.id_XzMajor) && GetStrLen(objXzMajorEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objXzMajorEN.MajorID) && GetStrLen(objXzMajorEN.MajorID) > 4)
{
 throw new Exception("字段[专业ID]的长度不能超过4!");
}
if (!Object.Equals(null, objXzMajorEN.MajorName) && GetStrLen(objXzMajorEN.MajorName) > 100)
{
 throw new Exception("字段[专业名称]的长度不能超过100!");
}
if (!Object.Equals(null, objXzMajorEN.MajorEnglishName) && GetStrLen(objXzMajorEN.MajorEnglishName) > 200)
{
 throw new Exception("字段[专业英文名称]的长度不能超过200!");
}
if (!Object.Equals(null, objXzMajorEN.MajorExplain) && GetStrLen(objXzMajorEN.MajorExplain) > 2000)
{
 throw new Exception("字段[专业说明]的长度不能超过2000!");
}
if (!Object.Equals(null, objXzMajorEN.MajorNationalID) && GetStrLen(objXzMajorEN.MajorNationalID) > 10)
{
 throw new Exception("字段[专业国家代码]的长度不能超过10!");
}
if (!Object.Equals(null, objXzMajorEN.id_XzCollege) && GetStrLen(objXzMajorEN.id_XzCollege) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzMajorEN.id_MajorType) && GetStrLen(objXzMajorEN.id_MajorType) > 4)
{
 throw new Exception("字段[专业类型(文理工)流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzMajorEN.id_DegreeType) && GetStrLen(objXzMajorEN.id_DegreeType) > 4)
{
 throw new Exception("字段[学位类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzMajorEN.MajorDirection) && GetStrLen(objXzMajorEN.MajorDirection) > 30)
{
 throw new Exception("字段[专业方向]的长度不能超过30!");
}
if (!Object.Equals(null, objXzMajorEN.ModifyDate) && GetStrLen(objXzMajorEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objXzMajorEN.ModifyUserID) && GetStrLen(objXzMajorEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objXzMajorEN.Memo) && GetStrLen(objXzMajorEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objXzMajorEN.id_XzMajorShoolType) && GetStrLen(objXzMajorEN.id_XzMajorShoolType) > 4)
{
 throw new Exception("字段[专业学校类型流水号]的长度不能超过4!");
}
 objXzMajorEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_XzMajor">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzMajorEN GetObjByid_XzMajor(string strid_XzMajor)
{
string strAction = "GetObjByid_XzMajor";
string strErrMsg = string.Empty;
string strResult = "";
clsXzMajorEN objXzMajorEN = null;
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
objXzMajorEN = JsonConvert.DeserializeObject<clsXzMajorEN>((string)jobjReturn["ReturnObj"]);
return objXzMajorEN;
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
public static clsXzMajorEN GetObjByid_XzMajor_WA_Cache(string strid_XzMajor)
{
string strAction = "GetObjByid_XzMajor_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsXzMajorEN objXzMajorEN = null;
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
objXzMajorEN = JsonConvert.DeserializeObject<clsXzMajorEN>((string)jobjReturn["ReturnObj"]);
return objXzMajorEN;
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
public static clsXzMajorEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsXzMajorEN objXzMajorEN = null;
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
objXzMajorEN = JsonConvert.DeserializeObject<clsXzMajorEN>((string)jobjReturn["ReturnObj"]);
return objXzMajorEN;
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
public static clsXzMajorEN GetObjByid_XzMajor_Cache(string strid_XzMajor)
{
if (string.IsNullOrEmpty(strid_XzMajor) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
List<clsXzMajorEN> arrXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorEN> arrXzMajorObjLst_Sel =
from objXzMajorEN in arrXzMajorObjLst_Cache
where objXzMajorEN.id_XzMajor == strid_XzMajor
select objXzMajorEN;
if (arrXzMajorObjLst_Sel.Count() == 0)
{
   clsXzMajorEN obj = clsXzMajorWApi.GetObjByid_XzMajor(strid_XzMajor);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrXzMajorObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
List<clsXzMajorEN> arrXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorEN> arrXzMajorObjLst_Sel1 =
from objXzMajorEN in arrXzMajorObjLst_Cache
where objXzMajorEN.id_XzMajor == strid_XzMajor
select objXzMajorEN;
List <clsXzMajorEN> arrXzMajorObjLst_Sel = new List<clsXzMajorEN>();
foreach (clsXzMajorEN obj in arrXzMajorObjLst_Sel1)
{
arrXzMajorObjLst_Sel.Add(obj);
}
if (arrXzMajorObjLst_Sel.Count > 0)
{
return arrXzMajorObjLst_Sel[0].MajorName;
}
string strErrMsgForGetObjById = string.Format("在XzMajor对象缓存列表中,找不到记录[id_XzMajor = {0}](函数:{1})", strid_XzMajor, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzMajorBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
List<clsXzMajorEN> arrXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorEN> arrXzMajorObjLst_Sel1 =
from objXzMajorEN in arrXzMajorObjLst_Cache
where objXzMajorEN.id_XzMajor == strid_XzMajor
select objXzMajorEN;
List <clsXzMajorEN> arrXzMajorObjLst_Sel = new List<clsXzMajorEN>();
foreach (clsXzMajorEN obj in arrXzMajorObjLst_Sel1)
{
arrXzMajorObjLst_Sel.Add(obj);
}
if (arrXzMajorObjLst_Sel.Count > 0)
{
return arrXzMajorObjLst_Sel[0].MajorName;
}
string strErrMsgForGetObjById = string.Format("在XzMajor对象缓存列表中,找不到记录的相关名称[id_XzMajor = {0}](函数:{1})", strid_XzMajor, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzMajorBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorEN> GetObjLst(string strWhereCond)
{
 List<clsXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorEN> GetObjLstById_XzMajorLst(List<string> arrId_XzMajor)
{
 List<clsXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsXzMajorEN> GetObjLstById_XzMajorLst_Cache(List<string> arrId_XzMajor)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
List<clsXzMajorEN> arrXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorEN> arrXzMajorObjLst_Sel =
from objXzMajorEN in arrXzMajorObjLst_Cache
where arrId_XzMajor.Contains(objXzMajorEN.id_XzMajor)
select objXzMajorEN;
return arrXzMajorObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorEN> GetObjLstById_XzMajorLst_WA_Cache(List<string> arrId_XzMajor)
{
 List<clsXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsXzMajorEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strid_XzMajor)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsXzMajorEN objXzMajorEN = clsXzMajorWApi.GetObjByid_XzMajor(strid_XzMajor);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_XzMajor.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzMajorWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelXzMajors(List<string> arrid_XzMajor)
{
string strAction = "DelXzMajors";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_XzMajor);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzMajorWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelXzMajorsByCond(string strWhereCond)
{
string strAction = "DelXzMajorsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsXzMajorEN objXzMajorEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzMajorEN>(objXzMajorEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsXzMajorEN objXzMajorEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzMajorEN>(objXzMajorEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorWApi.ReFreshCache();
var strid_XzMajor = (string)jobjReturn["ReturnStr"];
return strid_XzMajor;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsXzMajorEN objXzMajorEN)
{
if (string.IsNullOrEmpty(objXzMajorEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzMajorEN.id_XzMajor, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzMajorEN>(objXzMajorEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objXzMajorEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsXzMajorEN objXzMajorEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objXzMajorEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzMajorEN.id_XzMajor, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzMajorEN.id_XzMajor, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzMajorEN>(objXzMajorEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objXzMajorENS">源对象</param>
 /// <param name = "objXzMajorENT">目标对象</param>
 public static void CopyTo(clsXzMajorEN objXzMajorENS, clsXzMajorEN objXzMajorENT)
{
try
{
objXzMajorENT.id_XzMajor = objXzMajorENS.id_XzMajor; //专业流水号
objXzMajorENT.MajorID = objXzMajorENS.MajorID; //专业ID
objXzMajorENT.MajorName = objXzMajorENS.MajorName; //专业名称
objXzMajorENT.MajorEnglishName = objXzMajorENS.MajorEnglishName; //专业英文名称
objXzMajorENT.MajorExplain = objXzMajorENS.MajorExplain; //专业说明
objXzMajorENT.MajorNationalID = objXzMajorENS.MajorNationalID; //专业国家代码
objXzMajorENT.id_XzCollege = objXzMajorENS.id_XzCollege; //学院流水号
objXzMajorENT.id_MajorType = objXzMajorENS.id_MajorType; //专业类型(文理工)流水号
objXzMajorENT.id_DegreeType = objXzMajorENS.id_DegreeType; //学位类型流水号
objXzMajorENT.IsMainMajor = objXzMajorENS.IsMainMajor; //是否重要专业
objXzMajorENT.MajorDirection = objXzMajorENS.MajorDirection; //专业方向
objXzMajorENT.IsVisible = objXzMajorENS.IsVisible; //是否显示
objXzMajorENT.IsNormal = objXzMajorENS.IsNormal; //IsNormal
objXzMajorENT.ModifyDate = objXzMajorENS.ModifyDate; //修改日期
objXzMajorENT.ModifyUserID = objXzMajorENS.ModifyUserID; //修改人
objXzMajorENT.Memo = objXzMajorENS.Memo; //备注
objXzMajorENT.id_XzMajorShoolType = objXzMajorENS.id_XzMajorShoolType; //专业学校类型流水号
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
public static DataTable ToDataTable(List<clsXzMajorEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsXzMajorEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsXzMajorEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsXzMajorEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsXzMajorEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsXzMajorEN.AttributeName)
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
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_XzMajor");
//if (arrXzMajorObjLst_Cache == null)
//{
//arrXzMajorObjLst_Cache = await clsXzMajorWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsXzMajorWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsXzMajorWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzMajorEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
List<clsXzMajorEN> arrXzMajorObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzMajorObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsXzMajorEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conXzMajor.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.MajorEnglishName, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.MajorExplain, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.MajorNationalID, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.id_MajorType, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.id_DegreeType, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.IsMainMajor, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzMajor.MajorDirection, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzMajor.IsNormal, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzMajor.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajor.id_XzMajorShoolType, Type.GetType("System.String"));
foreach (clsXzMajorEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conXzMajor.id_XzMajor] = objInFor[conXzMajor.id_XzMajor];
objDR[conXzMajor.MajorID] = objInFor[conXzMajor.MajorID];
objDR[conXzMajor.MajorName] = objInFor[conXzMajor.MajorName];
objDR[conXzMajor.MajorEnglishName] = objInFor[conXzMajor.MajorEnglishName];
objDR[conXzMajor.MajorExplain] = objInFor[conXzMajor.MajorExplain];
objDR[conXzMajor.MajorNationalID] = objInFor[conXzMajor.MajorNationalID];
objDR[conXzMajor.id_XzCollege] = objInFor[conXzMajor.id_XzCollege];
objDR[conXzMajor.id_MajorType] = objInFor[conXzMajor.id_MajorType];
objDR[conXzMajor.id_DegreeType] = objInFor[conXzMajor.id_DegreeType];
objDR[conXzMajor.IsMainMajor] = objInFor[conXzMajor.IsMainMajor];
objDR[conXzMajor.MajorDirection] = objInFor[conXzMajor.MajorDirection];
objDR[conXzMajor.IsVisible] = objInFor[conXzMajor.IsVisible];
objDR[conXzMajor.IsNormal] = objInFor[conXzMajor.IsNormal];
objDR[conXzMajor.ModifyDate] = objInFor[conXzMajor.ModifyDate];
objDR[conXzMajor.ModifyUserID] = objInFor[conXzMajor.ModifyUserID];
objDR[conXzMajor.Memo] = objInFor[conXzMajor.Memo];
objDR[conXzMajor.id_XzMajorShoolType] = objInFor[conXzMajor.id_XzMajorShoolType];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 专业(XzMajor)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4XzMajor : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorWApi.ReFreshThisCache();
clsvXzMajorWApi.ReFreshThisCache();
}
}

}