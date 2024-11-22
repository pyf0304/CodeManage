
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCase_Resource_RelWApi
 表名:vTeachCase_Resource_Rel(01120426)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:04
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范
 模块英文名:SkillDemo
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
public static class clsvTeachCase_Resource_RelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_TeachCase_Resource_Rel(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, long lngid_TeachCase_Resource_Rel, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.id_TeachCase_Resource_Rel = lngid_TeachCase_Resource_Rel; //案例与资源表系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_TeachCase_Resource_Rel) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_TeachCase_Resource_Rel, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_TeachCase_Resource_Rel] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_TeachCase(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_TeachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachCase, convTeachCase_Resource_Rel.id_TeachCase);
clsCheckSql.CheckFieldLen(strid_TeachCase, 8, convTeachCase_Resource_Rel.id_TeachCase);
clsCheckSql.CheckFieldForeignKey(strid_TeachCase, 8, convTeachCase_Resource_Rel.id_TeachCase);
objvTeachCase_Resource_RelEN.id_TeachCase = strid_TeachCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_TeachCase) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_TeachCase, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_TeachCase] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseID, convTeachCase_Resource_Rel.TeachCaseID);
clsCheckSql.CheckFieldLen(strTeachCaseID, 8, convTeachCase_Resource_Rel.TeachCaseID);
clsCheckSql.CheckFieldForeignKey(strTeachCaseID, 8, convTeachCase_Resource_Rel.TeachCaseID);
objvTeachCase_Resource_RelEN.TeachCaseID = strTeachCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachCaseID) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachCaseID, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseID] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseName, convTeachCase_Resource_Rel.TeachCaseName);
clsCheckSql.CheckFieldLen(strTeachCaseName, 200, convTeachCase_Resource_Rel.TeachCaseName);
objvTeachCase_Resource_RelEN.TeachCaseName = strTeachCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachCaseName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachCaseName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseExecutor(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseExecutor, 50, convTeachCase_Resource_Rel.TeachCaseExecutor);
objvTeachCase_Resource_RelEN.TeachCaseExecutor = strTeachCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachCaseExecutor) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachCaseExecutor, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseExecutor] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseTheme(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseTheme, 200, convTeachCase_Resource_Rel.TeachCaseTheme);
objvTeachCase_Resource_RelEN.TeachCaseTheme = strTeachCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachCaseTheme) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachCaseTheme, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseTheme] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseBG(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseBG, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseBG, 8000, convTeachCase_Resource_Rel.TeachCaseBG);
objvTeachCase_Resource_RelEN.TeachCaseBG = strTeachCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachCaseBG) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachCaseBG, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseBG] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_TeachSkill(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convTeachCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convTeachCase_Resource_Rel.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convTeachCase_Resource_Rel.id_TeachSkill);
objvTeachCase_Resource_RelEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_TeachSkill) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_TeachSkill, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_TeachSkill] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachSkillID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillID, convTeachCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachCase_Resource_Rel.TeachSkillID);
objvTeachCase_Resource_RelEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachSkillID) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachSkillID, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillID] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetSkillTypeName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeName, convTeachCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachCase_Resource_Rel.SkillTypeName);
objvTeachCase_Resource_RelEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.SkillTypeName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.SkillTypeName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.SkillTypeName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachSkillName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillName, convTeachCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachCase_Resource_Rel.TeachSkillName);
objvTeachCase_Resource_RelEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachSkillName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachSkillName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachSkillTheory(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachCase_Resource_Rel.TeachSkillTheory);
objvTeachCase_Resource_RelEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachSkillTheory) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachSkillTheory, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillTheory] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachSkillOperMethod(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachCase_Resource_Rel.TeachSkillOperMethod);
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachSkillOperMethod) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_SkillType(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SkillType, convTeachCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convTeachCase_Resource_Rel.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convTeachCase_Resource_Rel.id_SkillType);
objvTeachCase_Resource_RelEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_SkillType) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_SkillType, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_SkillType] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetSkillTypeID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeID, convTeachCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachCase_Resource_Rel.SkillTypeID);
objvTeachCase_Resource_RelEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.SkillTypeID) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.SkillTypeID, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.SkillTypeID] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_Discipline(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convTeachCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convTeachCase_Resource_Rel.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convTeachCase_Resource_Rel.id_Discipline);
objvTeachCase_Resource_RelEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_Discipline) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_Discipline, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_Discipline] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetDisciplineName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convTeachCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachCase_Resource_Rel.DisciplineName);
objvTeachCase_Resource_RelEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.DisciplineName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.DisciplineName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.DisciplineName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_StudyLevel(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convTeachCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convTeachCase_Resource_Rel.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convTeachCase_Resource_Rel.id_StudyLevel);
objvTeachCase_Resource_RelEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_StudyLevel) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_StudyLevel, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_StudyLevel] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetStudyLevelName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convTeachCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachCase_Resource_Rel.StudyLevelName);
objvTeachCase_Resource_RelEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.StudyLevelName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.StudyLevelName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.StudyLevelName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseDateIn(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseDateIn, 8, convTeachCase_Resource_Rel.TeachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strTeachCaseDateIn, 8, convTeachCase_Resource_Rel.TeachCaseDateIn);
objvTeachCase_Resource_RelEN.TeachCaseDateIn = strTeachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachCaseDateIn) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachCaseDateIn, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseDateIn] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_TeachingPlan(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convTeachCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convTeachCase_Resource_Rel.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convTeachCase_Resource_Rel.id_TeachingPlan);
objvTeachCase_Resource_RelEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_TeachingPlan) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_TeachingPlan, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_TeachingPlan] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseTimeIn(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseTimeIn, 6, convTeachCase_Resource_Rel.TeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strTeachCaseTimeIn, 6, convTeachCase_Resource_Rel.TeachCaseTimeIn);
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = strTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.TeachCaseTimeIn) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.TeachCaseTimeIn, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseTimeIn] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetWorkUnit(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strWorkUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convTeachCase_Resource_Rel.WorkUnit);
objvTeachCase_Resource_RelEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.WorkUnit) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.WorkUnit, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.WorkUnit] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetCD_ID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strCD_ID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCD_ID, 50, convTeachCase_Resource_Rel.CD_ID);
objvTeachCase_Resource_RelEN.CD_ID = strCD_ID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.CD_ID) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.CD_ID, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.CD_ID] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIsDualVideo(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IsDualVideo) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IsDualVideo, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IsDualVideo] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_XzCollege(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convTeachCase_Resource_Rel.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convTeachCase_Resource_Rel.id_XzCollege);
objvTeachCase_Resource_RelEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_XzCollege) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_XzCollege, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_XzCollege] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetCollegeID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachCase_Resource_Rel.CollegeID);
objvTeachCase_Resource_RelEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.CollegeID) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.CollegeID, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.CollegeID] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetCollegeName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachCase_Resource_Rel.CollegeName);
objvTeachCase_Resource_RelEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.CollegeName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.CollegeName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.CollegeName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetRecommendedDegreeId(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachCase_Resource_Rel.RecommendedDegreeId);
objvTeachCase_Resource_RelEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.RecommendedDegreeId) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.RecommendedDegreeId, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.RecommendedDegreeId] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetRecommendedDegreeName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachCase_Resource_Rel.RecommendedDegreeName);
objvTeachCase_Resource_RelEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.RecommendedDegreeName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.RecommendedDegreeName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.RecommendedDegreeName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetBrowseCount4Case(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.BrowseCount4Case) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.BrowseCount4Case, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.BrowseCount4Case] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_Resource(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convTeachCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convTeachCase_Resource_Rel.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convTeachCase_Resource_Rel.id_Resource);
objvTeachCase_Resource_RelEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_Resource) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_Resource, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_Resource] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convTeachCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, convTeachCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convTeachCase_Resource_Rel.ResourceID);
objvTeachCase_Resource_RelEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.ResourceID) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.ResourceID, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceID] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceName, 100, convTeachCase_Resource_Rel.ResourceName);
objvTeachCase_Resource_RelEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.ResourceName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.ResourceName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_FtpResource(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convTeachCase_Resource_Rel.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convTeachCase_Resource_Rel.id_FtpResource);
objvTeachCase_Resource_RelEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_FtpResource) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_FtpResource, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_FtpResource] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_File(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convTeachCase_Resource_Rel.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convTeachCase_Resource_Rel.id_File);
objvTeachCase_Resource_RelEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_File) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_File, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_File] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convTeachCase_Resource_Rel.FileName);
objvTeachCase_Resource_RelEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileType(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convTeachCase_Resource_Rel.FileType);
objvTeachCase_Resource_RelEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileType) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileType, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileType] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetSaveDate(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convTeachCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convTeachCase_Resource_Rel.SaveDate);
objvTeachCase_Resource_RelEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.SaveDate) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.SaveDate, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.SaveDate] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileSize(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convTeachCase_Resource_Rel.FileSize);
objvTeachCase_Resource_RelEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileSize) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileSize, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileSize] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetSaveTime(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convTeachCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convTeachCase_Resource_Rel.SaveTime);
objvTeachCase_Resource_RelEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.SaveTime) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.SaveTime, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.SaveTime] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFtpResourceID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convTeachCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convTeachCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convTeachCase_Resource_Rel.FtpResourceID);
objvTeachCase_Resource_RelEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FtpResourceID) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FtpResourceID, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FtpResourceID] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileOriginalName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convTeachCase_Resource_Rel.FileOriginalName);
objvTeachCase_Resource_RelEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileOriginalName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileOriginalName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileOriginalName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileDirName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convTeachCase_Resource_Rel.FileDirName);
objvTeachCase_Resource_RelEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileDirName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileDirName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileDirName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileRename(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convTeachCase_Resource_Rel.FileRename);
objvTeachCase_Resource_RelEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileRename) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileRename, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileRename] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileUpDate(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convTeachCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convTeachCase_Resource_Rel.FileUpDate);
objvTeachCase_Resource_RelEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileUpDate) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileUpDate, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileUpDate] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileUpTime(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convTeachCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convTeachCase_Resource_Rel.FileUpTime);
objvTeachCase_Resource_RelEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileUpTime) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileUpTime, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileUpTime] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetSaveMode(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, bool bolSaveMode, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.SaveMode) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.SaveMode, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.SaveMode] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN Setid_ResourceType(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, convTeachCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convTeachCase_Resource_Rel.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convTeachCase_Resource_Rel.id_ResourceType);
objvTeachCase_Resource_RelEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.id_ResourceType) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.id_ResourceType, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.id_ResourceType] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceTypeID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convTeachCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convTeachCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convTeachCase_Resource_Rel.ResourceTypeID);
objvTeachCase_Resource_RelEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.ResourceTypeID) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.ResourceTypeID, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceTypeID] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceTypeName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convTeachCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convTeachCase_Resource_Rel.ResourceTypeName);
objvTeachCase_Resource_RelEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.ResourceTypeName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.ResourceTypeName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceTypeName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceOwner(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convTeachCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convTeachCase_Resource_Rel.ResourceOwner);
objvTeachCase_Resource_RelEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.ResourceOwner) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.ResourceOwner, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceOwner] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetftpFileType(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachCase_Resource_Rel.ftpFileType);
objvTeachCase_Resource_RelEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.ftpFileType) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.ftpFileType, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.ftpFileType] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetftpFileSize(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convTeachCase_Resource_Rel.ftpFileSize);
objvTeachCase_Resource_RelEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.ftpFileSize) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.ftpFileSize, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.ftpFileSize] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetftpResourceOwner(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convTeachCase_Resource_Rel.ftpResourceOwner);
objvTeachCase_Resource_RelEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.ftpResourceOwner) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.ftpResourceOwner, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.ftpResourceOwner] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileOriginName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convTeachCase_Resource_Rel.FileOriginName);
objvTeachCase_Resource_RelEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileOriginName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileOriginName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileOriginName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIsExistFile(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IsExistFile) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IsExistFile, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IsExistFile] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileNewName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convTeachCase_Resource_Rel.FileNewName);
objvTeachCase_Resource_RelEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileNewName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileNewName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileNewName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileOldName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convTeachCase_Resource_Rel.FileOldName);
objvTeachCase_Resource_RelEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.FileOldName) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.FileOldName, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.FileOldName] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIsMain(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, bool bolIsMain, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.IsMain = bolIsMain; //是否主资源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IsMain) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IsMain, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IsMain] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetMemo(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachCase_Resource_Rel.Memo);
objvTeachCase_Resource_RelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.Memo) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.Memo, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.Memo] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIndexNO(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, int intIndexNO, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.IndexNO = intIndexNO; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IndexNO) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IndexNO, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IndexNO] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIsVisible(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, bool bolIsVisible, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IsVisible) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IsVisible, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IsVisible] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetBrowseCount(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, int intBrowseCount, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.BrowseCount) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.BrowseCount, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.BrowseCount] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetCollegeNameA(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachCase_Resource_Rel.CollegeNameA);
objvTeachCase_Resource_RelEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.CollegeNameA) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.CollegeNameA, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.CollegeNameA] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_Rel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_TeachCase_Resource_Rel) == true)
{
string strComparisonOp_id_TeachCase_Resource_Rel = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_TeachCase_Resource_Rel];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase_Resource_Rel.id_TeachCase_Resource_Rel, objvTeachCase_Resource_Rel_Cond.id_TeachCase_Resource_Rel, strComparisonOp_id_TeachCase_Resource_Rel);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_TeachCase) == true)
{
string strComparisonOp_id_TeachCase = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_TeachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_TeachCase, objvTeachCase_Resource_Rel_Cond.id_TeachCase, strComparisonOp_id_TeachCase);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseID) == true)
{
string strComparisonOp_TeachCaseID = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseID, objvTeachCase_Resource_Rel_Cond.TeachCaseID, strComparisonOp_TeachCaseID);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseName) == true)
{
string strComparisonOp_TeachCaseName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseName, objvTeachCase_Resource_Rel_Cond.TeachCaseName, strComparisonOp_TeachCaseName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseExecutor) == true)
{
string strComparisonOp_TeachCaseExecutor = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseExecutor, objvTeachCase_Resource_Rel_Cond.TeachCaseExecutor, strComparisonOp_TeachCaseExecutor);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseTheme) == true)
{
string strComparisonOp_TeachCaseTheme = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseTheme, objvTeachCase_Resource_Rel_Cond.TeachCaseTheme, strComparisonOp_TeachCaseTheme);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseBG) == true)
{
string strComparisonOp_TeachCaseBG = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseBG];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseBG, objvTeachCase_Resource_Rel_Cond.TeachCaseBG, strComparisonOp_TeachCaseBG);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_TeachSkill, objvTeachCase_Resource_Rel_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachSkillID, objvTeachCase_Resource_Rel_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.SkillTypeName, objvTeachCase_Resource_Rel_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachSkillName, objvTeachCase_Resource_Rel_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachSkillTheory, objvTeachCase_Resource_Rel_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachSkillOperMethod, objvTeachCase_Resource_Rel_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_SkillType, objvTeachCase_Resource_Rel_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.SkillTypeID, objvTeachCase_Resource_Rel_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_Discipline, objvTeachCase_Resource_Rel_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.DisciplineName, objvTeachCase_Resource_Rel_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_StudyLevel, objvTeachCase_Resource_Rel_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.StudyLevelName, objvTeachCase_Resource_Rel_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseDateIn) == true)
{
string strComparisonOp_TeachCaseDateIn = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseDateIn, objvTeachCase_Resource_Rel_Cond.TeachCaseDateIn, strComparisonOp_TeachCaseDateIn);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_TeachingPlan, objvTeachCase_Resource_Rel_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseTimeIn) == true)
{
string strComparisonOp_TeachCaseTimeIn = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseTimeIn, objvTeachCase_Resource_Rel_Cond.TeachCaseTimeIn, strComparisonOp_TeachCaseTimeIn);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.WorkUnit) == true)
{
string strComparisonOp_WorkUnit = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.WorkUnit, objvTeachCase_Resource_Rel_Cond.WorkUnit, strComparisonOp_WorkUnit);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.CD_ID) == true)
{
string strComparisonOp_CD_ID = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.CD_ID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.CD_ID, objvTeachCase_Resource_Rel_Cond.CD_ID, strComparisonOp_CD_ID);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.IsDualVideo) == true)
{
if (objvTeachCase_Resource_Rel_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.IsDualVideo);
}
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_XzCollege, objvTeachCase_Resource_Rel_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.CollegeID, objvTeachCase_Resource_Rel_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.CollegeName, objvTeachCase_Resource_Rel_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.RecommendedDegreeId, objvTeachCase_Resource_Rel_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.RecommendedDegreeName, objvTeachCase_Resource_Rel_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase_Resource_Rel.BrowseCount4Case, objvTeachCase_Resource_Rel_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_Resource, objvTeachCase_Resource_Rel_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceID, objvTeachCase_Resource_Rel_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOp_ResourceName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceName, objvTeachCase_Resource_Rel_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_FtpResource, objvTeachCase_Resource_Rel_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_File) == true)
{
string strComparisonOp_id_File = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_File, objvTeachCase_Resource_Rel_Cond.id_File, strComparisonOp_id_File);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileName) == true)
{
string strComparisonOp_FileName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileName, objvTeachCase_Resource_Rel_Cond.FileName, strComparisonOp_FileName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileType) == true)
{
string strComparisonOp_FileType = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileType, objvTeachCase_Resource_Rel_Cond.FileType, strComparisonOp_FileType);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.SaveDate, objvTeachCase_Resource_Rel_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileSize) == true)
{
string strComparisonOp_FileSize = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileSize, objvTeachCase_Resource_Rel_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.SaveTime, objvTeachCase_Resource_Rel_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FtpResourceID, objvTeachCase_Resource_Rel_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileOriginalName, objvTeachCase_Resource_Rel_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileDirName, objvTeachCase_Resource_Rel_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileRename) == true)
{
string strComparisonOp_FileRename = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileRename, objvTeachCase_Resource_Rel_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileUpDate, objvTeachCase_Resource_Rel_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileUpTime, objvTeachCase_Resource_Rel_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.SaveMode) == true)
{
if (objvTeachCase_Resource_Rel_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.SaveMode);
}
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.id_ResourceType, objvTeachCase_Resource_Rel_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceTypeID, objvTeachCase_Resource_Rel_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceTypeName, objvTeachCase_Resource_Rel_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceOwner, objvTeachCase_Resource_Rel_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ftpFileType, objvTeachCase_Resource_Rel_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ftpFileSize, objvTeachCase_Resource_Rel_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ftpResourceOwner, objvTeachCase_Resource_Rel_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileOriginName, objvTeachCase_Resource_Rel_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.IsExistFile) == true)
{
if (objvTeachCase_Resource_Rel_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.IsExistFile);
}
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileNewName, objvTeachCase_Resource_Rel_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileOldName, objvTeachCase_Resource_Rel_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.IsMain) == true)
{
if (objvTeachCase_Resource_Rel_Cond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.IsMain);
}
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.Memo) == true)
{
string strComparisonOp_Memo = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.Memo, objvTeachCase_Resource_Rel_Cond.Memo, strComparisonOp_Memo);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOp_IndexNO = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase_Resource_Rel.IndexNO, objvTeachCase_Resource_Rel_Cond.IndexNO, strComparisonOp_IndexNO);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.IsVisible) == true)
{
if (objvTeachCase_Resource_Rel_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.IsVisible);
}
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase_Resource_Rel.BrowseCount, objvTeachCase_Resource_Rel_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvTeachCase_Resource_Rel_Cond.IsUpdated(convTeachCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvTeachCase_Resource_Rel_Cond.dicFldComparisonOp[convTeachCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.CollegeNameA, objvTeachCase_Resource_Rel_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 案例与资源关系表视图(vTeachCase_Resource_Rel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachCase_Resource_RelWApi
{
private static readonly string mstrApiControllerName = "vTeachCase_Resource_RelApi";

 public clsvTeachCase_Resource_RelWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_TeachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCase_Resource_RelEN GetObjByid_TeachCase_Resource_Rel(long lngid_TeachCase_Resource_Rel)
{
string strAction = "GetObjByid_TeachCase_Resource_Rel";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCase_Resource_Rel"] = lngid_TeachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvTeachCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvTeachCase_Resource_RelEN;
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
 /// <param name = "lngid_TeachCase_Resource_Rel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCase_Resource_RelEN GetObjByid_TeachCase_Resource_Rel_WA_Cache(long lngid_TeachCase_Resource_Rel)
{
string strAction = "GetObjByid_TeachCase_Resource_Rel_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCase_Resource_Rel"] = lngid_TeachCase_Resource_Rel.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvTeachCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvTeachCase_Resource_RelEN;
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
public static clsvTeachCase_Resource_RelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = null;
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
objvTeachCase_Resource_RelEN = JsonConvert.DeserializeObject<clsvTeachCase_Resource_RelEN>((string)jobjReturn["ReturnObj"]);
return objvTeachCase_Resource_RelEN;
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
 /// <param name = "lngid_TeachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachCase_Resource_RelEN GetObjByid_TeachCase_Resource_Rel_Cache(long lngid_TeachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachCase_Resource_RelEN._CurrTabName_S);
List<clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLst_Sel =
from objvTeachCase_Resource_RelEN in arrvTeachCase_Resource_RelObjLst_Cache
where objvTeachCase_Resource_RelEN.id_TeachCase_Resource_Rel == lngid_TeachCase_Resource_Rel
select objvTeachCase_Resource_RelEN;
if (arrvTeachCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvTeachCase_Resource_RelEN obj = clsvTeachCase_Resource_RelWApi.GetObjByid_TeachCase_Resource_Rel(lngid_TeachCase_Resource_Rel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLstById_TeachCase_Resource_RelLst(List<long> arrId_TeachCase_Resource_Rel)
{
 List<clsvTeachCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachCase_Resource_RelLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_TeachCase_Resource_Rel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachCase_Resource_RelEN> GetObjLstById_TeachCase_Resource_RelLst_Cache(List<long> arrId_TeachCase_Resource_Rel)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachCase_Resource_RelEN._CurrTabName_S);
List<clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLst_Sel =
from objvTeachCase_Resource_RelEN in arrvTeachCase_Resource_RelObjLst_Cache
where arrId_TeachCase_Resource_Rel.Contains(objvTeachCase_Resource_RelEN.id_TeachCase_Resource_Rel)
select objvTeachCase_Resource_RelEN;
return arrvTeachCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCase_Resource_RelEN> GetObjLstById_TeachCase_Resource_RelLst_WA_Cache(List<long> arrId_TeachCase_Resource_Rel)
{
 List<clsvTeachCase_Resource_RelEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachCase_Resource_RelLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachCase_Resource_Rel);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachCase_Resource_RelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCase_Resource_RelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_TeachCase_Resource_Rel)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCase_Resource_Rel"] = lngid_TeachCase_Resource_Rel.ToString()
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
 /// <param name = "objvTeachCase_Resource_RelENS">源对象</param>
 /// <param name = "objvTeachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENS, clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENT)
{
try
{
objvTeachCase_Resource_RelENT.id_TeachCase_Resource_Rel = objvTeachCase_Resource_RelENS.id_TeachCase_Resource_Rel; //案例与资源表系表流水号
objvTeachCase_Resource_RelENT.id_TeachCase = objvTeachCase_Resource_RelENS.id_TeachCase; //案例流水号
objvTeachCase_Resource_RelENT.TeachCaseID = objvTeachCase_Resource_RelENS.TeachCaseID; //案例ID
objvTeachCase_Resource_RelENT.TeachCaseName = objvTeachCase_Resource_RelENS.TeachCaseName; //案例名称
objvTeachCase_Resource_RelENT.TeachCaseExecutor = objvTeachCase_Resource_RelENS.TeachCaseExecutor; //案例执教者
objvTeachCase_Resource_RelENT.TeachCaseTheme = objvTeachCase_Resource_RelENS.TeachCaseTheme; //案例主题词
objvTeachCase_Resource_RelENT.TeachCaseBG = objvTeachCase_Resource_RelENS.TeachCaseBG; //案例背景资料
objvTeachCase_Resource_RelENT.id_TeachSkill = objvTeachCase_Resource_RelENS.id_TeachSkill; //教学技能流水号
objvTeachCase_Resource_RelENT.TeachSkillID = objvTeachCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvTeachCase_Resource_RelENT.SkillTypeName = objvTeachCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvTeachCase_Resource_RelENT.TeachSkillName = objvTeachCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvTeachCase_Resource_RelENT.TeachSkillTheory = objvTeachCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvTeachCase_Resource_RelENT.TeachSkillOperMethod = objvTeachCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachCase_Resource_RelENT.id_SkillType = objvTeachCase_Resource_RelENS.id_SkillType; //技能类型流水号
objvTeachCase_Resource_RelENT.SkillTypeID = objvTeachCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvTeachCase_Resource_RelENT.id_Discipline = objvTeachCase_Resource_RelENS.id_Discipline; //学科流水号
objvTeachCase_Resource_RelENT.DisciplineName = objvTeachCase_Resource_RelENS.DisciplineName; //学科名称
objvTeachCase_Resource_RelENT.id_StudyLevel = objvTeachCase_Resource_RelENS.id_StudyLevel; //id_StudyLevel
objvTeachCase_Resource_RelENT.StudyLevelName = objvTeachCase_Resource_RelENS.StudyLevelName; //学段名称
objvTeachCase_Resource_RelENT.TeachCaseDateIn = objvTeachCase_Resource_RelENS.TeachCaseDateIn; //案例入库日期
objvTeachCase_Resource_RelENT.id_TeachingPlan = objvTeachCase_Resource_RelENS.id_TeachingPlan; //教案流水号
objvTeachCase_Resource_RelENT.TeachCaseTimeIn = objvTeachCase_Resource_RelENS.TeachCaseTimeIn; //案例入库时间
objvTeachCase_Resource_RelENT.WorkUnit = objvTeachCase_Resource_RelENS.WorkUnit; //工作单位
objvTeachCase_Resource_RelENT.CD_ID = objvTeachCase_Resource_RelENS.CD_ID; //光盘编号
objvTeachCase_Resource_RelENT.IsDualVideo = objvTeachCase_Resource_RelENS.IsDualVideo; //是否双视频
objvTeachCase_Resource_RelENT.id_XzCollege = objvTeachCase_Resource_RelENS.id_XzCollege; //学院流水号
objvTeachCase_Resource_RelENT.CollegeID = objvTeachCase_Resource_RelENS.CollegeID; //学院ID
objvTeachCase_Resource_RelENT.CollegeName = objvTeachCase_Resource_RelENS.CollegeName; //学院名称
objvTeachCase_Resource_RelENT.RecommendedDegreeId = objvTeachCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvTeachCase_Resource_RelENT.RecommendedDegreeName = objvTeachCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvTeachCase_Resource_RelENT.BrowseCount4Case = objvTeachCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvTeachCase_Resource_RelENT.id_Resource = objvTeachCase_Resource_RelENS.id_Resource; //资源流水号
objvTeachCase_Resource_RelENT.ResourceID = objvTeachCase_Resource_RelENS.ResourceID; //资源ID
objvTeachCase_Resource_RelENT.ResourceName = objvTeachCase_Resource_RelENS.ResourceName; //资源名称
objvTeachCase_Resource_RelENT.id_FtpResource = objvTeachCase_Resource_RelENS.id_FtpResource; //FTP资源流水号
objvTeachCase_Resource_RelENT.id_File = objvTeachCase_Resource_RelENS.id_File; //文件流水号
objvTeachCase_Resource_RelENT.FileName = objvTeachCase_Resource_RelENS.FileName; //文件名称
objvTeachCase_Resource_RelENT.FileType = objvTeachCase_Resource_RelENS.FileType; //文件类型
objvTeachCase_Resource_RelENT.SaveDate = objvTeachCase_Resource_RelENS.SaveDate; //创建日期
objvTeachCase_Resource_RelENT.FileSize = objvTeachCase_Resource_RelENS.FileSize; //文件大小
objvTeachCase_Resource_RelENT.SaveTime = objvTeachCase_Resource_RelENS.SaveTime; //创建时间
objvTeachCase_Resource_RelENT.FtpResourceID = objvTeachCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvTeachCase_Resource_RelENT.FileOriginalName = objvTeachCase_Resource_RelENS.FileOriginalName; //文件原名
objvTeachCase_Resource_RelENT.FileDirName = objvTeachCase_Resource_RelENS.FileDirName; //文件目录名
objvTeachCase_Resource_RelENT.FileRename = objvTeachCase_Resource_RelENS.FileRename; //文件新名
objvTeachCase_Resource_RelENT.FileUpDate = objvTeachCase_Resource_RelENS.FileUpDate; //创建日期
objvTeachCase_Resource_RelENT.FileUpTime = objvTeachCase_Resource_RelENS.FileUpTime; //创建时间
objvTeachCase_Resource_RelENT.SaveMode = objvTeachCase_Resource_RelENS.SaveMode; //文件存放方式
objvTeachCase_Resource_RelENT.id_ResourceType = objvTeachCase_Resource_RelENS.id_ResourceType; //资源类型流水号
objvTeachCase_Resource_RelENT.ResourceTypeID = objvTeachCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvTeachCase_Resource_RelENT.ResourceTypeName = objvTeachCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvTeachCase_Resource_RelENT.ResourceOwner = objvTeachCase_Resource_RelENS.ResourceOwner; //上传者
objvTeachCase_Resource_RelENT.ftpFileType = objvTeachCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvTeachCase_Resource_RelENT.ftpFileSize = objvTeachCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvTeachCase_Resource_RelENT.ftpResourceOwner = objvTeachCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachCase_Resource_RelENT.FileOriginName = objvTeachCase_Resource_RelENS.FileOriginName; //原文件名
objvTeachCase_Resource_RelENT.IsExistFile = objvTeachCase_Resource_RelENS.IsExistFile; //是否存在文件
objvTeachCase_Resource_RelENT.FileNewName = objvTeachCase_Resource_RelENS.FileNewName; //新文件名
objvTeachCase_Resource_RelENT.FileOldName = objvTeachCase_Resource_RelENS.FileOldName; //旧文件名
objvTeachCase_Resource_RelENT.IsMain = objvTeachCase_Resource_RelENS.IsMain; //是否主资源
objvTeachCase_Resource_RelENT.Memo = objvTeachCase_Resource_RelENS.Memo; //备注
objvTeachCase_Resource_RelENT.IndexNO = objvTeachCase_Resource_RelENS.IndexNO; //序号
objvTeachCase_Resource_RelENT.IsVisible = objvTeachCase_Resource_RelENS.IsVisible; //是否显示
objvTeachCase_Resource_RelENT.BrowseCount = objvTeachCase_Resource_RelENS.BrowseCount; //浏览次数
objvTeachCase_Resource_RelENT.CollegeNameA = objvTeachCase_Resource_RelENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvTeachCase_Resource_RelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachCase_Resource_RelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachCase_Resource_RelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachCase_Resource_RelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachCase_Resource_RelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachCase_Resource_RelEN.AttributeName)
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
if (clsTeachCase_Resource_RelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCase_Resource_RelWApi没有刷新缓存机制(clsTeachCase_Resource_RelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseWApi没有刷新缓存机制(clsTeachCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by id_TeachCase_Resource_Rel");
//if (arrvTeachCase_Resource_RelObjLst_Cache == null)
//{
//arrvTeachCase_Resource_RelObjLst_Cache = await clsvTeachCase_Resource_RelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachCase_Resource_RelEN._CurrTabName_S);
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachCase_Resource_RelEN._CurrTabName_S);
List<clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachCase_Resource_RelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachCase_Resource_RelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachCase_Resource_Rel.id_TeachCase_Resource_Rel, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_TeachCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachCaseBG, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.TeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.WorkUnit, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.CD_ID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.BrowseCount4Case, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachCase_Resource_Rel.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.IsMain, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachCase_Resource_Rel.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase_Resource_Rel.IndexNO, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachCase_Resource_Rel.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachCase_Resource_Rel.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachCase_Resource_Rel.CollegeNameA, Type.GetType("System.String"));
foreach (clsvTeachCase_Resource_RelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachCase_Resource_Rel.id_TeachCase_Resource_Rel] = objInFor[convTeachCase_Resource_Rel.id_TeachCase_Resource_Rel];
objDR[convTeachCase_Resource_Rel.id_TeachCase] = objInFor[convTeachCase_Resource_Rel.id_TeachCase];
objDR[convTeachCase_Resource_Rel.TeachCaseID] = objInFor[convTeachCase_Resource_Rel.TeachCaseID];
objDR[convTeachCase_Resource_Rel.TeachCaseName] = objInFor[convTeachCase_Resource_Rel.TeachCaseName];
objDR[convTeachCase_Resource_Rel.TeachCaseExecutor] = objInFor[convTeachCase_Resource_Rel.TeachCaseExecutor];
objDR[convTeachCase_Resource_Rel.TeachCaseTheme] = objInFor[convTeachCase_Resource_Rel.TeachCaseTheme];
objDR[convTeachCase_Resource_Rel.TeachCaseBG] = objInFor[convTeachCase_Resource_Rel.TeachCaseBG];
objDR[convTeachCase_Resource_Rel.id_TeachSkill] = objInFor[convTeachCase_Resource_Rel.id_TeachSkill];
objDR[convTeachCase_Resource_Rel.TeachSkillID] = objInFor[convTeachCase_Resource_Rel.TeachSkillID];
objDR[convTeachCase_Resource_Rel.SkillTypeName] = objInFor[convTeachCase_Resource_Rel.SkillTypeName];
objDR[convTeachCase_Resource_Rel.TeachSkillName] = objInFor[convTeachCase_Resource_Rel.TeachSkillName];
objDR[convTeachCase_Resource_Rel.TeachSkillTheory] = objInFor[convTeachCase_Resource_Rel.TeachSkillTheory];
objDR[convTeachCase_Resource_Rel.TeachSkillOperMethod] = objInFor[convTeachCase_Resource_Rel.TeachSkillOperMethod];
objDR[convTeachCase_Resource_Rel.id_SkillType] = objInFor[convTeachCase_Resource_Rel.id_SkillType];
objDR[convTeachCase_Resource_Rel.SkillTypeID] = objInFor[convTeachCase_Resource_Rel.SkillTypeID];
objDR[convTeachCase_Resource_Rel.id_Discipline] = objInFor[convTeachCase_Resource_Rel.id_Discipline];
objDR[convTeachCase_Resource_Rel.DisciplineName] = objInFor[convTeachCase_Resource_Rel.DisciplineName];
objDR[convTeachCase_Resource_Rel.id_StudyLevel] = objInFor[convTeachCase_Resource_Rel.id_StudyLevel];
objDR[convTeachCase_Resource_Rel.StudyLevelName] = objInFor[convTeachCase_Resource_Rel.StudyLevelName];
objDR[convTeachCase_Resource_Rel.TeachCaseDateIn] = objInFor[convTeachCase_Resource_Rel.TeachCaseDateIn];
objDR[convTeachCase_Resource_Rel.id_TeachingPlan] = objInFor[convTeachCase_Resource_Rel.id_TeachingPlan];
objDR[convTeachCase_Resource_Rel.TeachCaseTimeIn] = objInFor[convTeachCase_Resource_Rel.TeachCaseTimeIn];
objDR[convTeachCase_Resource_Rel.WorkUnit] = objInFor[convTeachCase_Resource_Rel.WorkUnit];
objDR[convTeachCase_Resource_Rel.CD_ID] = objInFor[convTeachCase_Resource_Rel.CD_ID];
objDR[convTeachCase_Resource_Rel.IsDualVideo] = objInFor[convTeachCase_Resource_Rel.IsDualVideo];
objDR[convTeachCase_Resource_Rel.id_XzCollege] = objInFor[convTeachCase_Resource_Rel.id_XzCollege];
objDR[convTeachCase_Resource_Rel.CollegeID] = objInFor[convTeachCase_Resource_Rel.CollegeID];
objDR[convTeachCase_Resource_Rel.CollegeName] = objInFor[convTeachCase_Resource_Rel.CollegeName];
objDR[convTeachCase_Resource_Rel.RecommendedDegreeId] = objInFor[convTeachCase_Resource_Rel.RecommendedDegreeId];
objDR[convTeachCase_Resource_Rel.RecommendedDegreeName] = objInFor[convTeachCase_Resource_Rel.RecommendedDegreeName];
objDR[convTeachCase_Resource_Rel.BrowseCount4Case] = objInFor[convTeachCase_Resource_Rel.BrowseCount4Case];
objDR[convTeachCase_Resource_Rel.id_Resource] = objInFor[convTeachCase_Resource_Rel.id_Resource];
objDR[convTeachCase_Resource_Rel.ResourceID] = objInFor[convTeachCase_Resource_Rel.ResourceID];
objDR[convTeachCase_Resource_Rel.ResourceName] = objInFor[convTeachCase_Resource_Rel.ResourceName];
objDR[convTeachCase_Resource_Rel.id_FtpResource] = objInFor[convTeachCase_Resource_Rel.id_FtpResource];
objDR[convTeachCase_Resource_Rel.id_File] = objInFor[convTeachCase_Resource_Rel.id_File];
objDR[convTeachCase_Resource_Rel.FileName] = objInFor[convTeachCase_Resource_Rel.FileName];
objDR[convTeachCase_Resource_Rel.FileType] = objInFor[convTeachCase_Resource_Rel.FileType];
objDR[convTeachCase_Resource_Rel.SaveDate] = objInFor[convTeachCase_Resource_Rel.SaveDate];
objDR[convTeachCase_Resource_Rel.FileSize] = objInFor[convTeachCase_Resource_Rel.FileSize];
objDR[convTeachCase_Resource_Rel.SaveTime] = objInFor[convTeachCase_Resource_Rel.SaveTime];
objDR[convTeachCase_Resource_Rel.FtpResourceID] = objInFor[convTeachCase_Resource_Rel.FtpResourceID];
objDR[convTeachCase_Resource_Rel.FileOriginalName] = objInFor[convTeachCase_Resource_Rel.FileOriginalName];
objDR[convTeachCase_Resource_Rel.FileDirName] = objInFor[convTeachCase_Resource_Rel.FileDirName];
objDR[convTeachCase_Resource_Rel.FileRename] = objInFor[convTeachCase_Resource_Rel.FileRename];
objDR[convTeachCase_Resource_Rel.FileUpDate] = objInFor[convTeachCase_Resource_Rel.FileUpDate];
objDR[convTeachCase_Resource_Rel.FileUpTime] = objInFor[convTeachCase_Resource_Rel.FileUpTime];
objDR[convTeachCase_Resource_Rel.SaveMode] = objInFor[convTeachCase_Resource_Rel.SaveMode];
objDR[convTeachCase_Resource_Rel.id_ResourceType] = objInFor[convTeachCase_Resource_Rel.id_ResourceType];
objDR[convTeachCase_Resource_Rel.ResourceTypeID] = objInFor[convTeachCase_Resource_Rel.ResourceTypeID];
objDR[convTeachCase_Resource_Rel.ResourceTypeName] = objInFor[convTeachCase_Resource_Rel.ResourceTypeName];
objDR[convTeachCase_Resource_Rel.ResourceOwner] = objInFor[convTeachCase_Resource_Rel.ResourceOwner];
objDR[convTeachCase_Resource_Rel.ftpFileType] = objInFor[convTeachCase_Resource_Rel.ftpFileType];
objDR[convTeachCase_Resource_Rel.ftpFileSize] = objInFor[convTeachCase_Resource_Rel.ftpFileSize];
objDR[convTeachCase_Resource_Rel.ftpResourceOwner] = objInFor[convTeachCase_Resource_Rel.ftpResourceOwner];
objDR[convTeachCase_Resource_Rel.FileOriginName] = objInFor[convTeachCase_Resource_Rel.FileOriginName];
objDR[convTeachCase_Resource_Rel.IsExistFile] = objInFor[convTeachCase_Resource_Rel.IsExistFile];
objDR[convTeachCase_Resource_Rel.FileNewName] = objInFor[convTeachCase_Resource_Rel.FileNewName];
objDR[convTeachCase_Resource_Rel.FileOldName] = objInFor[convTeachCase_Resource_Rel.FileOldName];
objDR[convTeachCase_Resource_Rel.IsMain] = objInFor[convTeachCase_Resource_Rel.IsMain];
objDR[convTeachCase_Resource_Rel.Memo] = objInFor[convTeachCase_Resource_Rel.Memo];
objDR[convTeachCase_Resource_Rel.IndexNO] = objInFor[convTeachCase_Resource_Rel.IndexNO];
objDR[convTeachCase_Resource_Rel.IsVisible] = objInFor[convTeachCase_Resource_Rel.IsVisible];
objDR[convTeachCase_Resource_Rel.BrowseCount] = objInFor[convTeachCase_Resource_Rel.BrowseCount];
objDR[convTeachCase_Resource_Rel.CollegeNameA] = objInFor[convTeachCase_Resource_Rel.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}