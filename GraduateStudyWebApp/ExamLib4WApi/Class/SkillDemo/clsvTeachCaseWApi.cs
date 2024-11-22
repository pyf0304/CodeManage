
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCaseWApi
 表名:vTeachCase(01120384)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:56
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
public static class clsvTeachCaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN Setid_TeachCase(this clsvTeachCaseEN objvTeachCaseEN, string strid_TeachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachCase, 8, convTeachCase.id_TeachCase);
clsCheckSql.CheckFieldForeignKey(strid_TeachCase, 8, convTeachCase.id_TeachCase);
objvTeachCaseEN.id_TeachCase = strid_TeachCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.id_TeachCase) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.id_TeachCase, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.id_TeachCase] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseID(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseID, convTeachCase.TeachCaseID);
clsCheckSql.CheckFieldLen(strTeachCaseID, 8, convTeachCase.TeachCaseID);
clsCheckSql.CheckFieldForeignKey(strTeachCaseID, 8, convTeachCase.TeachCaseID);
objvTeachCaseEN.TeachCaseID = strTeachCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachCaseID) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachCaseID, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachCaseID] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseName(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseName, convTeachCase.TeachCaseName);
clsCheckSql.CheckFieldLen(strTeachCaseName, 200, convTeachCase.TeachCaseName);
objvTeachCaseEN.TeachCaseName = strTeachCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachCaseName) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachCaseName, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachCaseName] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseExecutor(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseExecutor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseExecutor, 50, convTeachCase.TeachCaseExecutor);
objvTeachCaseEN.TeachCaseExecutor = strTeachCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachCaseExecutor) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachCaseExecutor, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachCaseExecutor] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseTheme(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseTheme, 200, convTeachCase.TeachCaseTheme);
objvTeachCaseEN.TeachCaseTheme = strTeachCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachCaseTheme) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachCaseTheme, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachCaseTheme] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseBG(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseBG, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseBG, 8000, convTeachCase.TeachCaseBG);
objvTeachCaseEN.TeachCaseBG = strTeachCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachCaseBG) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachCaseBG, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachCaseBG] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN Setid_TeachSkill(this clsvTeachCaseEN objvTeachCaseEN, string strid_TeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachSkill, convTeachCase.id_TeachSkill);
clsCheckSql.CheckFieldLen(strid_TeachSkill, 8, convTeachCase.id_TeachSkill);
clsCheckSql.CheckFieldForeignKey(strid_TeachSkill, 8, convTeachCase.id_TeachSkill);
objvTeachCaseEN.id_TeachSkill = strid_TeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.id_TeachSkill) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.id_TeachSkill, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.id_TeachSkill] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachSkillID(this clsvTeachCaseEN objvTeachCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillID, convTeachCase.TeachSkillID);
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachCase.TeachSkillID);
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachCase.TeachSkillID);
objvTeachCaseEN.TeachSkillID = strTeachSkillID; //教学技能ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachSkillID) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachSkillID, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachSkillID] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetSkillTypeName(this clsvTeachCaseEN objvTeachCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachCase.SkillTypeName);
objvTeachCaseEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.SkillTypeName) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.SkillTypeName, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.SkillTypeName] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachSkillName(this clsvTeachCaseEN objvTeachCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillName, convTeachCase.TeachSkillName);
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachCase.TeachSkillName);
objvTeachCaseEN.TeachSkillName = strTeachSkillName; //教学技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachSkillName) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachSkillName, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachSkillName] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachSkillTheory(this clsvTeachCaseEN objvTeachCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachCase.TeachSkillTheory);
objvTeachCaseEN.TeachSkillTheory = strTeachSkillTheory; //教学技能理论阐述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachSkillTheory) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachSkillTheory, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachSkillTheory] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachSkillOperMethod(this clsvTeachCaseEN objvTeachCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachCase.TeachSkillOperMethod);
objvTeachCaseEN.TeachSkillOperMethod = strTeachSkillOperMethod; //教学技能实践操作方法
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachSkillOperMethod) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachSkillOperMethod, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachSkillOperMethod] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN Setid_SkillType(this clsvTeachCaseEN objvTeachCaseEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convTeachCase.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convTeachCase.id_SkillType);
objvTeachCaseEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.id_SkillType) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.id_SkillType, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.id_SkillType] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetSkillTypeID(this clsvTeachCaseEN objvTeachCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachCase.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachCase.SkillTypeID);
objvTeachCaseEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.SkillTypeID) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.SkillTypeID, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.SkillTypeID] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN Setid_Discipline(this clsvTeachCaseEN objvTeachCaseEN, string strid_Discipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Discipline, convTeachCase.id_Discipline);
clsCheckSql.CheckFieldLen(strid_Discipline, 4, convTeachCase.id_Discipline);
clsCheckSql.CheckFieldForeignKey(strid_Discipline, 4, convTeachCase.id_Discipline);
objvTeachCaseEN.id_Discipline = strid_Discipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.id_Discipline) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.id_Discipline, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.id_Discipline] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetDisciplineName(this clsvTeachCaseEN objvTeachCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convTeachCase.DisciplineName);
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachCase.DisciplineName);
objvTeachCaseEN.DisciplineName = strDisciplineName; //学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.DisciplineName) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.DisciplineName, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.DisciplineName] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN Setid_StudyLevel(this clsvTeachCaseEN objvTeachCaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudyLevel, convTeachCase.id_StudyLevel);
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convTeachCase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convTeachCase.id_StudyLevel);
objvTeachCaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.id_StudyLevel) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.id_StudyLevel, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.id_StudyLevel] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetStudyLevelName(this clsvTeachCaseEN objvTeachCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convTeachCase.StudyLevelName);
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachCase.StudyLevelName);
objvTeachCaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.StudyLevelName) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.StudyLevelName, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.StudyLevelName] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseDateIn(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseDateIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseDateIn, 8, convTeachCase.TeachCaseDateIn);
clsCheckSql.CheckFieldForeignKey(strTeachCaseDateIn, 8, convTeachCase.TeachCaseDateIn);
objvTeachCaseEN.TeachCaseDateIn = strTeachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachCaseDateIn) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachCaseDateIn, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachCaseDateIn] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN Setid_TeachingPlan(this clsvTeachCaseEN objvTeachCaseEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_TeachingPlan, convTeachCase.id_TeachingPlan);
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convTeachCase.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convTeachCase.id_TeachingPlan);
objvTeachCaseEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.id_TeachingPlan) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.id_TeachingPlan, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.id_TeachingPlan] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseTimeIn(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseTimeIn, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachCaseTimeIn, 6, convTeachCase.TeachCaseTimeIn);
clsCheckSql.CheckFieldForeignKey(strTeachCaseTimeIn, 6, convTeachCase.TeachCaseTimeIn);
objvTeachCaseEN.TeachCaseTimeIn = strTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.TeachCaseTimeIn) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.TeachCaseTimeIn, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.TeachCaseTimeIn] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetWorkUnit(this clsvTeachCaseEN objvTeachCaseEN, string strWorkUnit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convTeachCase.WorkUnit);
objvTeachCaseEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.WorkUnit) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.WorkUnit, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.WorkUnit] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetCD_ID(this clsvTeachCaseEN objvTeachCaseEN, string strCD_ID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCD_ID, 50, convTeachCase.CD_ID);
objvTeachCaseEN.CD_ID = strCD_ID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.CD_ID) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.CD_ID, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.CD_ID] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetIsVisible(this clsvTeachCaseEN objvTeachCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvTeachCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.IsVisible) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.IsVisible, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.IsVisible] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetIsDualVideo(this clsvTeachCaseEN objvTeachCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDualVideo, convTeachCase.IsDualVideo);
objvTeachCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.IsDualVideo) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.IsDualVideo, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.IsDualVideo] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN Setid_XzCollege(this clsvTeachCaseEN objvTeachCaseEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convTeachCase.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convTeachCase.id_XzCollege);
objvTeachCaseEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.id_XzCollege) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.id_XzCollege, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.id_XzCollege] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetCollegeID(this clsvTeachCaseEN objvTeachCaseEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachCase.CollegeID);
objvTeachCaseEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.CollegeID) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.CollegeID, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.CollegeID] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetCollegeName(this clsvTeachCaseEN objvTeachCaseEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachCase.CollegeName);
objvTeachCaseEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.CollegeName) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.CollegeName, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.CollegeName] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetCollegeNameA(this clsvTeachCaseEN objvTeachCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachCase.CollegeNameA);
objvTeachCaseEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.CollegeNameA) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.CollegeNameA, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.CollegeNameA] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetRecommendedDegreeId(this clsvTeachCaseEN objvTeachCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachCase.RecommendedDegreeId);
objvTeachCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.RecommendedDegreeId) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetRecommendedDegreeName(this clsvTeachCaseEN objvTeachCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachCase.RecommendedDegreeName);
objvTeachCaseEN.RecommendedDegreeName = strRecommendedDegreeName; //推荐度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.RecommendedDegreeName) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.RecommendedDegreeName, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.RecommendedDegreeName] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetftpFileType(this clsvTeachCaseEN objvTeachCaseEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachCase.ftpFileType);
objvTeachCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.ftpFileType) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.ftpFileType, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.ftpFileType] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetVideoUrl(this clsvTeachCaseEN objvTeachCaseEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convTeachCase.VideoUrl);
objvTeachCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.VideoUrl) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.VideoUrl, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.VideoUrl] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetVideoPath(this clsvTeachCaseEN objvTeachCaseEN, string strVideoPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convTeachCase.VideoPath);
objvTeachCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.VideoPath) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.VideoPath, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.VideoPath] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetResErrMsg(this clsvTeachCaseEN objvTeachCaseEN, string strResErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convTeachCase.ResErrMsg);
objvTeachCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.ResErrMsg) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.ResErrMsg, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.ResErrMsg] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetMemo(this clsvTeachCaseEN objvTeachCaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachCase.Memo);
objvTeachCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.Memo) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.Memo, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.Memo] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachCaseEN SetBrowseCount4Case(this clsvTeachCaseEN objvTeachCaseEN, int intBrowseCount4Case, string strComparisonOp="")
	{
objvTeachCaseEN.BrowseCount4Case = intBrowseCount4Case; //课例浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.BrowseCount4Case) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.BrowseCount4Case, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.BrowseCount4Case] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachCaseEN objvTeachCase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachCase_Cond.IsUpdated(convTeachCase.id_TeachCase) == true)
{
string strComparisonOp_id_TeachCase = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.id_TeachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.id_TeachCase, objvTeachCase_Cond.id_TeachCase, strComparisonOp_id_TeachCase);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachCaseID) == true)
{
string strComparisonOp_TeachCaseID = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseID, objvTeachCase_Cond.TeachCaseID, strComparisonOp_TeachCaseID);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachCaseName) == true)
{
string strComparisonOp_TeachCaseName = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseName, objvTeachCase_Cond.TeachCaseName, strComparisonOp_TeachCaseName);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachCaseExecutor) == true)
{
string strComparisonOp_TeachCaseExecutor = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseExecutor, objvTeachCase_Cond.TeachCaseExecutor, strComparisonOp_TeachCaseExecutor);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachCaseTheme) == true)
{
string strComparisonOp_TeachCaseTheme = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseTheme, objvTeachCase_Cond.TeachCaseTheme, strComparisonOp_TeachCaseTheme);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachCaseBG) == true)
{
string strComparisonOp_TeachCaseBG = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachCaseBG];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseBG, objvTeachCase_Cond.TeachCaseBG, strComparisonOp_TeachCaseBG);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.id_TeachSkill) == true)
{
string strComparisonOp_id_TeachSkill = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.id_TeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.id_TeachSkill, objvTeachCase_Cond.id_TeachSkill, strComparisonOp_id_TeachSkill);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachSkillID) == true)
{
string strComparisonOp_TeachSkillID = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachSkillID, objvTeachCase_Cond.TeachSkillID, strComparisonOp_TeachSkillID);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.SkillTypeName, objvTeachCase_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachSkillName) == true)
{
string strComparisonOp_TeachSkillName = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachSkillName, objvTeachCase_Cond.TeachSkillName, strComparisonOp_TeachSkillName);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachSkillTheory) == true)
{
string strComparisonOp_TeachSkillTheory = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachSkillTheory, objvTeachCase_Cond.TeachSkillTheory, strComparisonOp_TeachSkillTheory);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachSkillOperMethod) == true)
{
string strComparisonOp_TeachSkillOperMethod = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachSkillOperMethod, objvTeachCase_Cond.TeachSkillOperMethod, strComparisonOp_TeachSkillOperMethod);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.id_SkillType, objvTeachCase_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.SkillTypeID, objvTeachCase_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.id_Discipline) == true)
{
string strComparisonOp_id_Discipline = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.id_Discipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.id_Discipline, objvTeachCase_Cond.id_Discipline, strComparisonOp_id_Discipline);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.DisciplineName) == true)
{
string strComparisonOp_DisciplineName = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.DisciplineName, objvTeachCase_Cond.DisciplineName, strComparisonOp_DisciplineName);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.id_StudyLevel, objvTeachCase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.StudyLevelName, objvTeachCase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachCaseDateIn) == true)
{
string strComparisonOp_TeachCaseDateIn = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseDateIn, objvTeachCase_Cond.TeachCaseDateIn, strComparisonOp_TeachCaseDateIn);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.id_TeachingPlan, objvTeachCase_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.TeachCaseTimeIn) == true)
{
string strComparisonOp_TeachCaseTimeIn = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.TeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseTimeIn, objvTeachCase_Cond.TeachCaseTimeIn, strComparisonOp_TeachCaseTimeIn);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.WorkUnit) == true)
{
string strComparisonOp_WorkUnit = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.WorkUnit, objvTeachCase_Cond.WorkUnit, strComparisonOp_WorkUnit);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.CD_ID) == true)
{
string strComparisonOp_CD_ID = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.CD_ID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.CD_ID, objvTeachCase_Cond.CD_ID, strComparisonOp_CD_ID);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.IsVisible) == true)
{
if (objvTeachCase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase.IsVisible);
}
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.IsDualVideo) == true)
{
if (objvTeachCase_Cond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase.IsDualVideo);
}
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.id_XzCollege, objvTeachCase_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.CollegeID, objvTeachCase_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.CollegeName, objvTeachCase_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.CollegeNameA, objvTeachCase_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.RecommendedDegreeId) == true)
{
string strComparisonOp_RecommendedDegreeId = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.RecommendedDegreeId, objvTeachCase_Cond.RecommendedDegreeId, strComparisonOp_RecommendedDegreeId);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.RecommendedDegreeName) == true)
{
string strComparisonOp_RecommendedDegreeName = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.RecommendedDegreeName, objvTeachCase_Cond.RecommendedDegreeName, strComparisonOp_RecommendedDegreeName);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.ftpFileType, objvTeachCase_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.VideoUrl, objvTeachCase_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.VideoPath) == true)
{
string strComparisonOp_VideoPath = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.VideoPath, objvTeachCase_Cond.VideoPath, strComparisonOp_VideoPath);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.ResErrMsg) == true)
{
string strComparisonOp_ResErrMsg = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.ResErrMsg, objvTeachCase_Cond.ResErrMsg, strComparisonOp_ResErrMsg);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.Memo) == true)
{
string strComparisonOp_Memo = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.Memo, objvTeachCase_Cond.Memo, strComparisonOp_Memo);
}
if (objvTeachCase_Cond.IsUpdated(convTeachCase.BrowseCount4Case) == true)
{
string strComparisonOp_BrowseCount4Case = objvTeachCase_Cond.dicFldComparisonOp[convTeachCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase.BrowseCount4Case, objvTeachCase_Cond.BrowseCount4Case, strComparisonOp_BrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 技能案例视图(vTeachCase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachCaseWApi
{
private static readonly string mstrApiControllerName = "vTeachCaseApi";

 public clsvTeachCaseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_TeachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCaseEN GetObjByid_TeachCase(string strid_TeachCase)
{
string strAction = "GetObjByid_TeachCase";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachCaseEN objvTeachCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCase"] = strid_TeachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachCaseEN = JsonConvert.DeserializeObject<clsvTeachCaseEN>((string)jobjReturn["ReturnObj"]);
return objvTeachCaseEN;
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
 /// <param name = "strid_TeachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCaseEN GetObjByid_TeachCase_WA_Cache(string strid_TeachCase)
{
string strAction = "GetObjByid_TeachCase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachCaseEN objvTeachCaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCase"] = strid_TeachCase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachCaseEN = JsonConvert.DeserializeObject<clsvTeachCaseEN>((string)jobjReturn["ReturnObj"]);
return objvTeachCaseEN;
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
public static clsvTeachCaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachCaseEN objvTeachCaseEN = null;
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
objvTeachCaseEN = JsonConvert.DeserializeObject<clsvTeachCaseEN>((string)jobjReturn["ReturnObj"]);
return objvTeachCaseEN;
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
 /// <param name = "strid_TeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachCaseEN GetObjByid_TeachCase_Cache(string strid_TeachCase)
{
if (string.IsNullOrEmpty(strid_TeachCase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachCaseEN._CurrTabName_S);
List<clsvTeachCaseEN> arrvTeachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachCaseEN> arrvTeachCaseObjLst_Sel =
from objvTeachCaseEN in arrvTeachCaseObjLst_Cache
where objvTeachCaseEN.id_TeachCase == strid_TeachCase
select objvTeachCaseEN;
if (arrvTeachCaseObjLst_Sel.Count() == 0)
{
   clsvTeachCaseEN obj = clsvTeachCaseWApi.GetObjByid_TeachCase(strid_TeachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseEN> GetObjLstById_TeachCaseLst(List<string> arrId_TeachCase)
{
 List<clsvTeachCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachCaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_TeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachCaseEN> GetObjLstById_TeachCaseLst_Cache(List<string> arrId_TeachCase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachCaseEN._CurrTabName_S);
List<clsvTeachCaseEN> arrvTeachCaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachCaseEN> arrvTeachCaseObjLst_Sel =
from objvTeachCaseEN in arrvTeachCaseObjLst_Cache
where arrId_TeachCase.Contains(objvTeachCaseEN.id_TeachCase)
select objvTeachCaseEN;
return arrvTeachCaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseEN> GetObjLstById_TeachCaseLst_WA_Cache(List<string> arrId_TeachCase)
{
 List<clsvTeachCaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachCaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachCase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachCaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachCaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachCaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_TeachCase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachCase"] = strid_TeachCase
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
 /// <param name = "objvTeachCaseENS">源对象</param>
 /// <param name = "objvTeachCaseENT">目标对象</param>
 public static void CopyTo(clsvTeachCaseEN objvTeachCaseENS, clsvTeachCaseEN objvTeachCaseENT)
{
try
{
objvTeachCaseENT.id_TeachCase = objvTeachCaseENS.id_TeachCase; //案例流水号
objvTeachCaseENT.TeachCaseID = objvTeachCaseENS.TeachCaseID; //案例ID
objvTeachCaseENT.TeachCaseName = objvTeachCaseENS.TeachCaseName; //案例名称
objvTeachCaseENT.TeachCaseExecutor = objvTeachCaseENS.TeachCaseExecutor; //案例执教者
objvTeachCaseENT.TeachCaseTheme = objvTeachCaseENS.TeachCaseTheme; //案例主题词
objvTeachCaseENT.TeachCaseBG = objvTeachCaseENS.TeachCaseBG; //案例背景资料
objvTeachCaseENT.id_TeachSkill = objvTeachCaseENS.id_TeachSkill; //教学技能流水号
objvTeachCaseENT.TeachSkillID = objvTeachCaseENS.TeachSkillID; //教学技能ID
objvTeachCaseENT.SkillTypeName = objvTeachCaseENS.SkillTypeName; //技能类型名称
objvTeachCaseENT.TeachSkillName = objvTeachCaseENS.TeachSkillName; //教学技能名称
objvTeachCaseENT.TeachSkillTheory = objvTeachCaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachCaseENT.TeachSkillOperMethod = objvTeachCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachCaseENT.id_SkillType = objvTeachCaseENS.id_SkillType; //技能类型流水号
objvTeachCaseENT.SkillTypeID = objvTeachCaseENS.SkillTypeID; //技能类型ID
objvTeachCaseENT.id_Discipline = objvTeachCaseENS.id_Discipline; //学科流水号
objvTeachCaseENT.DisciplineName = objvTeachCaseENS.DisciplineName; //学科名称
objvTeachCaseENT.id_StudyLevel = objvTeachCaseENS.id_StudyLevel; //id_StudyLevel
objvTeachCaseENT.StudyLevelName = objvTeachCaseENS.StudyLevelName; //学段名称
objvTeachCaseENT.TeachCaseDateIn = objvTeachCaseENS.TeachCaseDateIn; //案例入库日期
objvTeachCaseENT.id_TeachingPlan = objvTeachCaseENS.id_TeachingPlan; //教案流水号
objvTeachCaseENT.TeachCaseTimeIn = objvTeachCaseENS.TeachCaseTimeIn; //案例入库时间
objvTeachCaseENT.WorkUnit = objvTeachCaseENS.WorkUnit; //工作单位
objvTeachCaseENT.CD_ID = objvTeachCaseENS.CD_ID; //光盘编号
objvTeachCaseENT.IsVisible = objvTeachCaseENS.IsVisible; //是否显示
objvTeachCaseENT.IsDualVideo = objvTeachCaseENS.IsDualVideo; //是否双视频
objvTeachCaseENT.id_XzCollege = objvTeachCaseENS.id_XzCollege; //学院流水号
objvTeachCaseENT.CollegeID = objvTeachCaseENS.CollegeID; //学院ID
objvTeachCaseENT.CollegeName = objvTeachCaseENS.CollegeName; //学院名称
objvTeachCaseENT.CollegeNameA = objvTeachCaseENS.CollegeNameA; //学院名称简写
objvTeachCaseENT.RecommendedDegreeId = objvTeachCaseENS.RecommendedDegreeId; //推荐度Id
objvTeachCaseENT.RecommendedDegreeName = objvTeachCaseENS.RecommendedDegreeName; //推荐度名称
objvTeachCaseENT.ftpFileType = objvTeachCaseENS.ftpFileType; //ftp文件类型
objvTeachCaseENT.VideoUrl = objvTeachCaseENS.VideoUrl; //视频Url
objvTeachCaseENT.VideoPath = objvTeachCaseENS.VideoPath; //视频目录
objvTeachCaseENT.ResErrMsg = objvTeachCaseENS.ResErrMsg; //资源错误信息
objvTeachCaseENT.Memo = objvTeachCaseENS.Memo; //备注
objvTeachCaseENT.BrowseCount4Case = objvTeachCaseENS.BrowseCount4Case; //课例浏览次数
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
public static DataTable ToDataTable(List<clsvTeachCaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachCaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachCaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachCaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachCaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachCaseEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by id_TeachCase");
//if (arrvTeachCaseObjLst_Cache == null)
//{
//arrvTeachCaseObjLst_Cache = await clsvTeachCaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachCaseEN._CurrTabName_S);
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
public static List<clsvTeachCaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachCaseEN._CurrTabName_S);
List<clsvTeachCaseEN> arrvTeachCaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachCaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachCaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachCase.id_TeachCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachCaseExecutor, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachCaseTheme, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachCaseBG, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.id_TeachSkill, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachSkillID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachSkillName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachSkillTheory, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachSkillOperMethod, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.id_Discipline, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.DisciplineName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachCaseDateIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.TeachCaseTimeIn, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.WorkUnit, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.CD_ID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachCase.IsDualVideo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachCase.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.RecommendedDegreeId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.RecommendedDegreeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.VideoPath, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.ResErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTeachCase.BrowseCount4Case, Type.GetType("System.Int32"));
foreach (clsvTeachCaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachCase.id_TeachCase] = objInFor[convTeachCase.id_TeachCase];
objDR[convTeachCase.TeachCaseID] = objInFor[convTeachCase.TeachCaseID];
objDR[convTeachCase.TeachCaseName] = objInFor[convTeachCase.TeachCaseName];
objDR[convTeachCase.TeachCaseExecutor] = objInFor[convTeachCase.TeachCaseExecutor];
objDR[convTeachCase.TeachCaseTheme] = objInFor[convTeachCase.TeachCaseTheme];
objDR[convTeachCase.TeachCaseBG] = objInFor[convTeachCase.TeachCaseBG];
objDR[convTeachCase.id_TeachSkill] = objInFor[convTeachCase.id_TeachSkill];
objDR[convTeachCase.TeachSkillID] = objInFor[convTeachCase.TeachSkillID];
objDR[convTeachCase.SkillTypeName] = objInFor[convTeachCase.SkillTypeName];
objDR[convTeachCase.TeachSkillName] = objInFor[convTeachCase.TeachSkillName];
objDR[convTeachCase.TeachSkillTheory] = objInFor[convTeachCase.TeachSkillTheory];
objDR[convTeachCase.TeachSkillOperMethod] = objInFor[convTeachCase.TeachSkillOperMethod];
objDR[convTeachCase.id_SkillType] = objInFor[convTeachCase.id_SkillType];
objDR[convTeachCase.SkillTypeID] = objInFor[convTeachCase.SkillTypeID];
objDR[convTeachCase.id_Discipline] = objInFor[convTeachCase.id_Discipline];
objDR[convTeachCase.DisciplineName] = objInFor[convTeachCase.DisciplineName];
objDR[convTeachCase.id_StudyLevel] = objInFor[convTeachCase.id_StudyLevel];
objDR[convTeachCase.StudyLevelName] = objInFor[convTeachCase.StudyLevelName];
objDR[convTeachCase.TeachCaseDateIn] = objInFor[convTeachCase.TeachCaseDateIn];
objDR[convTeachCase.id_TeachingPlan] = objInFor[convTeachCase.id_TeachingPlan];
objDR[convTeachCase.TeachCaseTimeIn] = objInFor[convTeachCase.TeachCaseTimeIn];
objDR[convTeachCase.WorkUnit] = objInFor[convTeachCase.WorkUnit];
objDR[convTeachCase.CD_ID] = objInFor[convTeachCase.CD_ID];
objDR[convTeachCase.IsVisible] = objInFor[convTeachCase.IsVisible];
objDR[convTeachCase.IsDualVideo] = objInFor[convTeachCase.IsDualVideo];
objDR[convTeachCase.id_XzCollege] = objInFor[convTeachCase.id_XzCollege];
objDR[convTeachCase.CollegeID] = objInFor[convTeachCase.CollegeID];
objDR[convTeachCase.CollegeName] = objInFor[convTeachCase.CollegeName];
objDR[convTeachCase.CollegeNameA] = objInFor[convTeachCase.CollegeNameA];
objDR[convTeachCase.RecommendedDegreeId] = objInFor[convTeachCase.RecommendedDegreeId];
objDR[convTeachCase.RecommendedDegreeName] = objInFor[convTeachCase.RecommendedDegreeName];
objDR[convTeachCase.ftpFileType] = objInFor[convTeachCase.ftpFileType];
objDR[convTeachCase.VideoUrl] = objInFor[convTeachCase.VideoUrl];
objDR[convTeachCase.VideoPath] = objInFor[convTeachCase.VideoPath];
objDR[convTeachCase.ResErrMsg] = objInFor[convTeachCase.ResErrMsg];
objDR[convTeachCase.Memo] = objInFor[convTeachCase.Memo];
objDR[convTeachCase.BrowseCount4Case] = objInFor[convTeachCase.BrowseCount4Case];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}