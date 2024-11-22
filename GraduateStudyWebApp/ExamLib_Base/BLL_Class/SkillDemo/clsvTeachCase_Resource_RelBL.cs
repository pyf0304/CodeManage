
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCase_Resource_RelBL
 表名:vTeachCase_Resource_Rel(01120426)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
public static class  clsvTeachCase_Resource_RelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCase_Resource_RelEN GetObj(this K_IdTeachCaseResourceRel_vTeachCase_Resource_Rel myKey)
{
clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = clsvTeachCase_Resource_RelBL.vTeachCase_Resource_RelDA.GetObjByIdTeachCaseResourceRel(myKey.Value);
return objvTeachCase_Resource_RelEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdTeachCaseResourceRel(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, long lngIdTeachCaseResourceRel, string strComparisonOp="")
	{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = lngIdTeachCaseResourceRel; //案例与资源表系表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdTeachCaseResourceRel) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdTeachCaseResourceRel, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdTeachCaseResourceRel] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdTeachCase(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdTeachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachCase, convTeachCase_Resource_Rel.IdTeachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachCase, 8, convTeachCase_Resource_Rel.IdTeachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachCase, 8, convTeachCase_Resource_Rel.IdTeachCase);
}
objvTeachCase_Resource_RelEN.IdTeachCase = strIdTeachCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdTeachCase) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdTeachCase, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdTeachCase] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseID, convTeachCase_Resource_Rel.TeachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseID, 8, convTeachCase_Resource_Rel.TeachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseID, 8, convTeachCase_Resource_Rel.TeachCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseName, convTeachCase_Resource_Rel.TeachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseName, 200, convTeachCase_Resource_Rel.TeachCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseExecutor(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseExecutor, 50, convTeachCase_Resource_Rel.TeachCaseExecutor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseTheme(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseTheme, 200, convTeachCase_Resource_Rel.TeachCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseBG(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseBG, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseBG, 8000, convTeachCase_Resource_Rel.TeachCaseBG);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdTeachSkill(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convTeachCase_Resource_Rel.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convTeachCase_Resource_Rel.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convTeachCase_Resource_Rel.IdTeachSkill);
}
objvTeachCase_Resource_RelEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdTeachSkill) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdTeachSkill, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdTeachSkill] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachSkillID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillID, convTeachCase_Resource_Rel.TeachSkillID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachCase_Resource_Rel.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachCase_Resource_Rel.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetSkillTypeName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeName, convTeachCase_Resource_Rel.SkillTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachCase_Resource_Rel.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachSkillName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillName, convTeachCase_Resource_Rel.TeachSkillName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachCase_Resource_Rel.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachSkillTheory(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachCase_Resource_Rel.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachSkillOperMethod(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachCase_Resource_Rel.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdSkillType(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdSkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSkillType, convTeachCase_Resource_Rel.IdSkillType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convTeachCase_Resource_Rel.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convTeachCase_Resource_Rel.IdSkillType);
}
objvTeachCase_Resource_RelEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdSkillType) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdSkillType, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdSkillType] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetSkillTypeID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillTypeID, convTeachCase_Resource_Rel.SkillTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachCase_Resource_Rel.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachCase_Resource_Rel.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdDiscipline(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convTeachCase_Resource_Rel.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convTeachCase_Resource_Rel.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convTeachCase_Resource_Rel.IdDiscipline);
}
objvTeachCase_Resource_RelEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdDiscipline) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdDiscipline, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdDiscipline] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetDisciplineName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convTeachCase_Resource_Rel.DisciplineName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachCase_Resource_Rel.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdStudyLevel(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convTeachCase_Resource_Rel.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convTeachCase_Resource_Rel.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convTeachCase_Resource_Rel.IdStudyLevel);
}
objvTeachCase_Resource_RelEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdStudyLevel) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdStudyLevel, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdStudyLevel] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetStudyLevelName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convTeachCase_Resource_Rel.StudyLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachCase_Resource_Rel.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseDateIn(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseDateIn, 8, convTeachCase_Resource_Rel.TeachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseDateIn, 8, convTeachCase_Resource_Rel.TeachCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdTeachingPlan(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convTeachCase_Resource_Rel.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convTeachCase_Resource_Rel.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convTeachCase_Resource_Rel.IdTeachingPlan);
}
objvTeachCase_Resource_RelEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdTeachingPlan) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdTeachingPlan, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdTeachingPlan] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetTeachCaseTimeIn(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseTimeIn, 6, convTeachCase_Resource_Rel.TeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseTimeIn, 6, convTeachCase_Resource_Rel.TeachCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetWorkUnit(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convTeachCase_Resource_Rel.WorkUnit);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetCDID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strCDID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCDID, 50, convTeachCase_Resource_Rel.CDID);
}
objvTeachCase_Resource_RelEN.CDID = strCDID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.CDID) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.CDID, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.CDID] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdXzCollege(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convTeachCase_Resource_Rel.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convTeachCase_Resource_Rel.IdXzCollege);
}
objvTeachCase_Resource_RelEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdXzCollege) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdXzCollege, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdXzCollege] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetCollegeID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachCase_Resource_Rel.CollegeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetCollegeName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachCase_Resource_Rel.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetRecommendedDegreeId(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachCase_Resource_Rel.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachCase_Resource_Rel.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetRecommendedDegreeName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachCase_Resource_Rel.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetBrowseCount4Case(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdResource(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResource, convTeachCase_Resource_Rel.IdResource);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResource, 8, convTeachCase_Resource_Rel.IdResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResource, 8, convTeachCase_Resource_Rel.IdResource);
}
objvTeachCase_Resource_RelEN.IdResource = strIdResource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdResource) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdResource, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdResource] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, convTeachCase_Resource_Rel.ResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceID, 8, convTeachCase_Resource_Rel.ResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convTeachCase_Resource_Rel.ResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceName, 100, convTeachCase_Resource_Rel.ResourceName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdFtpResource(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, convTeachCase_Resource_Rel.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, convTeachCase_Resource_Rel.IdFtpResource);
}
objvTeachCase_Resource_RelEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdFtpResource) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdFtpResource, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdFtpResource] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdFile(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFile, 8, convTeachCase_Resource_Rel.IdFile);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFile, 8, convTeachCase_Resource_Rel.IdFile);
}
objvTeachCase_Resource_RelEN.IdFile = strIdFile; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdFile) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdFile, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdFile] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 500, convTeachCase_Resource_Rel.FileName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileType(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, convTeachCase_Resource_Rel.FileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetSaveDate(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convTeachCase_Resource_Rel.SaveDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convTeachCase_Resource_Rel.SaveDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileSize(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileSize, 50, convTeachCase_Resource_Rel.FileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetSaveTime(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strSaveTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convTeachCase_Resource_Rel.SaveTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convTeachCase_Resource_Rel.SaveTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFtpResourceID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFtpResourceID, convTeachCase_Resource_Rel.FtpResourceID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convTeachCase_Resource_Rel.FtpResourceID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convTeachCase_Resource_Rel.FtpResourceID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileOriginalName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileOriginalName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convTeachCase_Resource_Rel.FileOriginalName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileDirName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileDirName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convTeachCase_Resource_Rel.FileDirName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileRename(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileRename, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileRename, 200, convTeachCase_Resource_Rel.FileRename);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileUpDate(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileUpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convTeachCase_Resource_Rel.FileUpDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convTeachCase_Resource_Rel.FileUpDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileUpTime(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convTeachCase_Resource_Rel.FileUpTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convTeachCase_Resource_Rel.FileUpTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIdResourceType(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strIdResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdResourceType, convTeachCase_Resource_Rel.IdResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, convTeachCase_Resource_Rel.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, convTeachCase_Resource_Rel.IdResourceType);
}
objvTeachCase_Resource_RelEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCase_Resource_RelEN.dicFldComparisonOp.ContainsKey(convTeachCase_Resource_Rel.IdResourceType) == false)
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp.Add(convTeachCase_Resource_Rel.IdResourceType, strComparisonOp);
}
else
{
objvTeachCase_Resource_RelEN.dicFldComparisonOp[convTeachCase_Resource_Rel.IdResourceType] = strComparisonOp;
}
}
return objvTeachCase_Resource_RelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceTypeID(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, convTeachCase_Resource_Rel.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convTeachCase_Resource_Rel.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convTeachCase_Resource_Rel.ResourceTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceTypeName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, convTeachCase_Resource_Rel.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convTeachCase_Resource_Rel.ResourceTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetResourceOwner(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceOwner, convTeachCase_Resource_Rel.ResourceOwner);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convTeachCase_Resource_Rel.ResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetftpFileType(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachCase_Resource_Rel.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetftpFileSize(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strftpFileSize, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convTeachCase_Resource_Rel.ftpFileSize);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetftpResourceOwner(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strftpResourceOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convTeachCase_Resource_Rel.ftpResourceOwner);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileOriginName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileOriginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convTeachCase_Resource_Rel.FileOriginName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileNewName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileNewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convTeachCase_Resource_Rel.FileNewName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetFileOldName(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strFileOldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convTeachCase_Resource_Rel.FileOldName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetMemo(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachCase_Resource_Rel.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetIndexNO(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, int? intIndexNO, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetBrowseCount(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, int? intBrowseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCase_Resource_RelEN SetCollegeNameA(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachCase_Resource_Rel.CollegeNameA);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelENS">源对象</param>
 /// <param name = "objvTeachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENS, clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENT)
{
try
{
objvTeachCase_Resource_RelENT.IdTeachCaseResourceRel = objvTeachCase_Resource_RelENS.IdTeachCaseResourceRel; //案例与资源表系表流水号
objvTeachCase_Resource_RelENT.IdTeachCase = objvTeachCase_Resource_RelENS.IdTeachCase; //案例流水号
objvTeachCase_Resource_RelENT.TeachCaseID = objvTeachCase_Resource_RelENS.TeachCaseID; //案例ID
objvTeachCase_Resource_RelENT.TeachCaseName = objvTeachCase_Resource_RelENS.TeachCaseName; //案例名称
objvTeachCase_Resource_RelENT.TeachCaseExecutor = objvTeachCase_Resource_RelENS.TeachCaseExecutor; //案例执教者
objvTeachCase_Resource_RelENT.TeachCaseTheme = objvTeachCase_Resource_RelENS.TeachCaseTheme; //案例主题词
objvTeachCase_Resource_RelENT.TeachCaseBG = objvTeachCase_Resource_RelENS.TeachCaseBG; //案例背景资料
objvTeachCase_Resource_RelENT.IdTeachSkill = objvTeachCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvTeachCase_Resource_RelENT.TeachSkillID = objvTeachCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvTeachCase_Resource_RelENT.SkillTypeName = objvTeachCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvTeachCase_Resource_RelENT.TeachSkillName = objvTeachCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvTeachCase_Resource_RelENT.TeachSkillTheory = objvTeachCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvTeachCase_Resource_RelENT.TeachSkillOperMethod = objvTeachCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachCase_Resource_RelENT.IdSkillType = objvTeachCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvTeachCase_Resource_RelENT.SkillTypeID = objvTeachCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvTeachCase_Resource_RelENT.IdDiscipline = objvTeachCase_Resource_RelENS.IdDiscipline; //学科流水号
objvTeachCase_Resource_RelENT.DisciplineName = objvTeachCase_Resource_RelENS.DisciplineName; //学科名称
objvTeachCase_Resource_RelENT.IdStudyLevel = objvTeachCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvTeachCase_Resource_RelENT.StudyLevelName = objvTeachCase_Resource_RelENS.StudyLevelName; //学段名称
objvTeachCase_Resource_RelENT.TeachCaseDateIn = objvTeachCase_Resource_RelENS.TeachCaseDateIn; //案例入库日期
objvTeachCase_Resource_RelENT.IdTeachingPlan = objvTeachCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvTeachCase_Resource_RelENT.TeachCaseTimeIn = objvTeachCase_Resource_RelENS.TeachCaseTimeIn; //案例入库时间
objvTeachCase_Resource_RelENT.WorkUnit = objvTeachCase_Resource_RelENS.WorkUnit; //工作单位
objvTeachCase_Resource_RelENT.CDID = objvTeachCase_Resource_RelENS.CDID; //光盘编号
objvTeachCase_Resource_RelENT.IsDualVideo = objvTeachCase_Resource_RelENS.IsDualVideo; //是否双视频
objvTeachCase_Resource_RelENT.IdXzCollege = objvTeachCase_Resource_RelENS.IdXzCollege; //学院流水号
objvTeachCase_Resource_RelENT.CollegeID = objvTeachCase_Resource_RelENS.CollegeID; //学院ID
objvTeachCase_Resource_RelENT.CollegeName = objvTeachCase_Resource_RelENS.CollegeName; //学院名称
objvTeachCase_Resource_RelENT.RecommendedDegreeId = objvTeachCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvTeachCase_Resource_RelENT.RecommendedDegreeName = objvTeachCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvTeachCase_Resource_RelENT.BrowseCount4Case = objvTeachCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvTeachCase_Resource_RelENT.IdResource = objvTeachCase_Resource_RelENS.IdResource; //资源流水号
objvTeachCase_Resource_RelENT.ResourceID = objvTeachCase_Resource_RelENS.ResourceID; //资源ID
objvTeachCase_Resource_RelENT.ResourceName = objvTeachCase_Resource_RelENS.ResourceName; //资源名称
objvTeachCase_Resource_RelENT.IdFtpResource = objvTeachCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvTeachCase_Resource_RelENT.IdFile = objvTeachCase_Resource_RelENS.IdFile; //文件流水号
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
objvTeachCase_Resource_RelENT.IdResourceType = objvTeachCase_Resource_RelENS.IdResourceType; //资源类型流水号
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
 /// <param name = "objvTeachCase_Resource_RelENS">源对象</param>
 /// <returns>目标对象=>clsvTeachCase_Resource_RelEN:objvTeachCase_Resource_RelENT</returns>
 public static clsvTeachCase_Resource_RelEN CopyTo(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENS)
{
try
{
 clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENT = new clsvTeachCase_Resource_RelEN()
{
IdTeachCaseResourceRel = objvTeachCase_Resource_RelENS.IdTeachCaseResourceRel, //案例与资源表系表流水号
IdTeachCase = objvTeachCase_Resource_RelENS.IdTeachCase, //案例流水号
TeachCaseID = objvTeachCase_Resource_RelENS.TeachCaseID, //案例ID
TeachCaseName = objvTeachCase_Resource_RelENS.TeachCaseName, //案例名称
TeachCaseExecutor = objvTeachCase_Resource_RelENS.TeachCaseExecutor, //案例执教者
TeachCaseTheme = objvTeachCase_Resource_RelENS.TeachCaseTheme, //案例主题词
TeachCaseBG = objvTeachCase_Resource_RelENS.TeachCaseBG, //案例背景资料
IdTeachSkill = objvTeachCase_Resource_RelENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvTeachCase_Resource_RelENS.TeachSkillID, //教学技能ID
SkillTypeName = objvTeachCase_Resource_RelENS.SkillTypeName, //技能类型名称
TeachSkillName = objvTeachCase_Resource_RelENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvTeachCase_Resource_RelENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvTeachCase_Resource_RelENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvTeachCase_Resource_RelENS.IdSkillType, //技能类型流水号
SkillTypeID = objvTeachCase_Resource_RelENS.SkillTypeID, //技能类型ID
IdDiscipline = objvTeachCase_Resource_RelENS.IdDiscipline, //学科流水号
DisciplineName = objvTeachCase_Resource_RelENS.DisciplineName, //学科名称
IdStudyLevel = objvTeachCase_Resource_RelENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvTeachCase_Resource_RelENS.StudyLevelName, //学段名称
TeachCaseDateIn = objvTeachCase_Resource_RelENS.TeachCaseDateIn, //案例入库日期
IdTeachingPlan = objvTeachCase_Resource_RelENS.IdTeachingPlan, //教案流水号
TeachCaseTimeIn = objvTeachCase_Resource_RelENS.TeachCaseTimeIn, //案例入库时间
WorkUnit = objvTeachCase_Resource_RelENS.WorkUnit, //工作单位
CDID = objvTeachCase_Resource_RelENS.CDID, //光盘编号
IsDualVideo = objvTeachCase_Resource_RelENS.IsDualVideo, //是否双视频
IdXzCollege = objvTeachCase_Resource_RelENS.IdXzCollege, //学院流水号
CollegeID = objvTeachCase_Resource_RelENS.CollegeID, //学院ID
CollegeName = objvTeachCase_Resource_RelENS.CollegeName, //学院名称
RecommendedDegreeId = objvTeachCase_Resource_RelENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvTeachCase_Resource_RelENS.RecommendedDegreeName, //推荐度名称
BrowseCount4Case = objvTeachCase_Resource_RelENS.BrowseCount4Case, //课例浏览次数
IdResource = objvTeachCase_Resource_RelENS.IdResource, //资源流水号
ResourceID = objvTeachCase_Resource_RelENS.ResourceID, //资源ID
ResourceName = objvTeachCase_Resource_RelENS.ResourceName, //资源名称
IdFtpResource = objvTeachCase_Resource_RelENS.IdFtpResource, //FTP资源流水号
IdFile = objvTeachCase_Resource_RelENS.IdFile, //文件流水号
FileName = objvTeachCase_Resource_RelENS.FileName, //文件名称
FileType = objvTeachCase_Resource_RelENS.FileType, //文件类型
SaveDate = objvTeachCase_Resource_RelENS.SaveDate, //创建日期
FileSize = objvTeachCase_Resource_RelENS.FileSize, //文件大小
SaveTime = objvTeachCase_Resource_RelENS.SaveTime, //创建时间
FtpResourceID = objvTeachCase_Resource_RelENS.FtpResourceID, //FTP资源ID
FileOriginalName = objvTeachCase_Resource_RelENS.FileOriginalName, //文件原名
FileDirName = objvTeachCase_Resource_RelENS.FileDirName, //文件目录名
FileRename = objvTeachCase_Resource_RelENS.FileRename, //文件新名
FileUpDate = objvTeachCase_Resource_RelENS.FileUpDate, //创建日期
FileUpTime = objvTeachCase_Resource_RelENS.FileUpTime, //创建时间
SaveMode = objvTeachCase_Resource_RelENS.SaveMode, //文件存放方式
IdResourceType = objvTeachCase_Resource_RelENS.IdResourceType, //资源类型流水号
ResourceTypeID = objvTeachCase_Resource_RelENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objvTeachCase_Resource_RelENS.ResourceTypeName, //资源类型名称
ResourceOwner = objvTeachCase_Resource_RelENS.ResourceOwner, //上传者
ftpFileType = objvTeachCase_Resource_RelENS.ftpFileType, //ftp文件类型
ftpFileSize = objvTeachCase_Resource_RelENS.ftpFileSize, //ftp文件大小
ftpResourceOwner = objvTeachCase_Resource_RelENS.ftpResourceOwner, //Ftp资源拥有者
FileOriginName = objvTeachCase_Resource_RelENS.FileOriginName, //原文件名
IsExistFile = objvTeachCase_Resource_RelENS.IsExistFile, //是否存在文件
FileNewName = objvTeachCase_Resource_RelENS.FileNewName, //新文件名
FileOldName = objvTeachCase_Resource_RelENS.FileOldName, //旧文件名
IsMain = objvTeachCase_Resource_RelENS.IsMain, //是否主资源
Memo = objvTeachCase_Resource_RelENS.Memo, //备注
IndexNO = objvTeachCase_Resource_RelENS.IndexNO, //序号
IsVisible = objvTeachCase_Resource_RelENS.IsVisible, //是否显示
BrowseCount = objvTeachCase_Resource_RelENS.BrowseCount, //浏览次数
CollegeNameA = objvTeachCase_Resource_RelENS.CollegeNameA, //学院名称简写
};
 return objvTeachCase_Resource_RelENT;
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
public static void CheckProperty4Condition(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN)
{
 clsvTeachCase_Resource_RelBL.vTeachCase_Resource_RelDA.CheckProperty4Condition(objvTeachCase_Resource_RelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdTeachCaseResourceRel) == true)
{
string strComparisonOpIdTeachCaseResourceRel = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdTeachCaseResourceRel];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase_Resource_Rel.IdTeachCaseResourceRel, objvTeachCase_Resource_RelCond.IdTeachCaseResourceRel, strComparisonOpIdTeachCaseResourceRel);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdTeachCase) == true)
{
string strComparisonOpIdTeachCase = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdTeachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdTeachCase, objvTeachCase_Resource_RelCond.IdTeachCase, strComparisonOpIdTeachCase);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseID) == true)
{
string strComparisonOpTeachCaseID = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseID, objvTeachCase_Resource_RelCond.TeachCaseID, strComparisonOpTeachCaseID);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseName) == true)
{
string strComparisonOpTeachCaseName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseName, objvTeachCase_Resource_RelCond.TeachCaseName, strComparisonOpTeachCaseName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseExecutor) == true)
{
string strComparisonOpTeachCaseExecutor = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseExecutor, objvTeachCase_Resource_RelCond.TeachCaseExecutor, strComparisonOpTeachCaseExecutor);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseTheme) == true)
{
string strComparisonOpTeachCaseTheme = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseTheme, objvTeachCase_Resource_RelCond.TeachCaseTheme, strComparisonOpTeachCaseTheme);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseBG) == true)
{
string strComparisonOpTeachCaseBG = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseBG];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseBG, objvTeachCase_Resource_RelCond.TeachCaseBG, strComparisonOpTeachCaseBG);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdTeachSkill, objvTeachCase_Resource_RelCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachSkillID, objvTeachCase_Resource_RelCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.SkillTypeName, objvTeachCase_Resource_RelCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachSkillName, objvTeachCase_Resource_RelCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachSkillTheory, objvTeachCase_Resource_RelCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachSkillOperMethod, objvTeachCase_Resource_RelCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdSkillType, objvTeachCase_Resource_RelCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.SkillTypeID, objvTeachCase_Resource_RelCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdDiscipline, objvTeachCase_Resource_RelCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.DisciplineName, objvTeachCase_Resource_RelCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdStudyLevel, objvTeachCase_Resource_RelCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.StudyLevelName, objvTeachCase_Resource_RelCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseDateIn) == true)
{
string strComparisonOpTeachCaseDateIn = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseDateIn, objvTeachCase_Resource_RelCond.TeachCaseDateIn, strComparisonOpTeachCaseDateIn);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdTeachingPlan, objvTeachCase_Resource_RelCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.TeachCaseTimeIn) == true)
{
string strComparisonOpTeachCaseTimeIn = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.TeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.TeachCaseTimeIn, objvTeachCase_Resource_RelCond.TeachCaseTimeIn, strComparisonOpTeachCaseTimeIn);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.WorkUnit, objvTeachCase_Resource_RelCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.CDID) == true)
{
string strComparisonOpCDID = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.CDID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.CDID, objvTeachCase_Resource_RelCond.CDID, strComparisonOpCDID);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IsDualVideo) == true)
{
if (objvTeachCase_Resource_RelCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.IsDualVideo);
}
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdXzCollege, objvTeachCase_Resource_RelCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.CollegeID) == true)
{
string strComparisonOpCollegeID = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.CollegeID, objvTeachCase_Resource_RelCond.CollegeID, strComparisonOpCollegeID);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.CollegeName) == true)
{
string strComparisonOpCollegeName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.CollegeName, objvTeachCase_Resource_RelCond.CollegeName, strComparisonOpCollegeName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.RecommendedDegreeId, objvTeachCase_Resource_RelCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.RecommendedDegreeName, objvTeachCase_Resource_RelCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase_Resource_Rel.BrowseCount4Case, objvTeachCase_Resource_RelCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdResource) == true)
{
string strComparisonOpIdResource = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdResource, objvTeachCase_Resource_RelCond.IdResource, strComparisonOpIdResource);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.ResourceID) == true)
{
string strComparisonOpResourceID = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceID, objvTeachCase_Resource_RelCond.ResourceID, strComparisonOpResourceID);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.ResourceName) == true)
{
string strComparisonOpResourceName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceName, objvTeachCase_Resource_RelCond.ResourceName, strComparisonOpResourceName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdFtpResource, objvTeachCase_Resource_RelCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdFile) == true)
{
string strComparisonOpIdFile = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdFile, objvTeachCase_Resource_RelCond.IdFile, strComparisonOpIdFile);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileName) == true)
{
string strComparisonOpFileName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileName, objvTeachCase_Resource_RelCond.FileName, strComparisonOpFileName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileType) == true)
{
string strComparisonOpFileType = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileType, objvTeachCase_Resource_RelCond.FileType, strComparisonOpFileType);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.SaveDate) == true)
{
string strComparisonOpSaveDate = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.SaveDate, objvTeachCase_Resource_RelCond.SaveDate, strComparisonOpSaveDate);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileSize) == true)
{
string strComparisonOpFileSize = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileSize, objvTeachCase_Resource_RelCond.FileSize, strComparisonOpFileSize);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.SaveTime) == true)
{
string strComparisonOpSaveTime = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.SaveTime, objvTeachCase_Resource_RelCond.SaveTime, strComparisonOpSaveTime);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FtpResourceID) == true)
{
string strComparisonOpFtpResourceID = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FtpResourceID, objvTeachCase_Resource_RelCond.FtpResourceID, strComparisonOpFtpResourceID);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileOriginalName) == true)
{
string strComparisonOpFileOriginalName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileOriginalName, objvTeachCase_Resource_RelCond.FileOriginalName, strComparisonOpFileOriginalName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileDirName) == true)
{
string strComparisonOpFileDirName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileDirName, objvTeachCase_Resource_RelCond.FileDirName, strComparisonOpFileDirName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileRename) == true)
{
string strComparisonOpFileRename = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileRename, objvTeachCase_Resource_RelCond.FileRename, strComparisonOpFileRename);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileUpDate) == true)
{
string strComparisonOpFileUpDate = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileUpDate, objvTeachCase_Resource_RelCond.FileUpDate, strComparisonOpFileUpDate);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileUpTime) == true)
{
string strComparisonOpFileUpTime = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileUpTime, objvTeachCase_Resource_RelCond.FileUpTime, strComparisonOpFileUpTime);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.SaveMode) == true)
{
if (objvTeachCase_Resource_RelCond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.SaveMode);
}
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.IdResourceType, objvTeachCase_Resource_RelCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceTypeID, objvTeachCase_Resource_RelCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceTypeName, objvTeachCase_Resource_RelCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.ResourceOwner) == true)
{
string strComparisonOpResourceOwner = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ResourceOwner, objvTeachCase_Resource_RelCond.ResourceOwner, strComparisonOpResourceOwner);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ftpFileType, objvTeachCase_Resource_RelCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.ftpFileSize) == true)
{
string strComparisonOpftpFileSize = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ftpFileSize, objvTeachCase_Resource_RelCond.ftpFileSize, strComparisonOpftpFileSize);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.ftpResourceOwner) == true)
{
string strComparisonOpftpResourceOwner = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.ftpResourceOwner, objvTeachCase_Resource_RelCond.ftpResourceOwner, strComparisonOpftpResourceOwner);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileOriginName) == true)
{
string strComparisonOpFileOriginName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileOriginName, objvTeachCase_Resource_RelCond.FileOriginName, strComparisonOpFileOriginName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IsExistFile) == true)
{
if (objvTeachCase_Resource_RelCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.IsExistFile);
}
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileNewName) == true)
{
string strComparisonOpFileNewName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileNewName, objvTeachCase_Resource_RelCond.FileNewName, strComparisonOpFileNewName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.FileOldName) == true)
{
string strComparisonOpFileOldName = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.FileOldName, objvTeachCase_Resource_RelCond.FileOldName, strComparisonOpFileOldName);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IsMain) == true)
{
if (objvTeachCase_Resource_RelCond.IsMain == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.IsMain);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.IsMain);
}
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.Memo) == true)
{
string strComparisonOpMemo = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.Memo, objvTeachCase_Resource_RelCond.Memo, strComparisonOpMemo);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IndexNO) == true)
{
string strComparisonOpIndexNO = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.IndexNO];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase_Resource_Rel.IndexNO, objvTeachCase_Resource_RelCond.IndexNO, strComparisonOpIndexNO);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.IsVisible) == true)
{
if (objvTeachCase_Resource_RelCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase_Resource_Rel.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase_Resource_Rel.IsVisible);
}
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase_Resource_Rel.BrowseCount, objvTeachCase_Resource_RelCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objvTeachCase_Resource_RelCond.IsUpdated(convTeachCase_Resource_Rel.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvTeachCase_Resource_RelCond.dicFldComparisonOp[convTeachCase_Resource_Rel.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase_Resource_Rel.CollegeNameA, objvTeachCase_Resource_RelCond.CollegeNameA, strComparisonOpCollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachCase_Resource_Rel
{
public virtual bool UpdRelaTabDate(long lngIdTeachCaseResourceRel, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例与资源关系表视图(vTeachCase_Resource_Rel)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachCase_Resource_RelBL
{
public static RelatedActions_vTeachCase_Resource_Rel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachCase_Resource_RelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachCase_Resource_RelDA vTeachCase_Resource_RelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachCase_Resource_RelDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachCase_Resource_RelBL()
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
if (string.IsNullOrEmpty(clsvTeachCase_Resource_RelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachCase_Resource_RelEN._ConnectString);
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
public static DataTable GetDataTable_vTeachCase_Resource_Rel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachCase_Resource_RelDA.GetDataTable_vTeachCase_Resource_Rel(strWhereCond);
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
objDT = vTeachCase_Resource_RelDA.GetDataTable(strWhereCond);
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
objDT = vTeachCase_Resource_RelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachCase_Resource_RelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachCase_Resource_RelDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachCase_Resource_RelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachCase_Resource_RelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTeachCase_Resource_RelEN> GetObjLstByIdTeachCaseResourceRelLst(List<long> arrIdTeachCaseResourceRelLst)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachCaseResourceRelLst);
 string strWhereCond = string.Format("IdTeachCaseResourceRel in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachCaseResourceRelLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachCase_Resource_RelEN> GetObjLstByIdTeachCaseResourceRelLstCache(List<long> arrIdTeachCaseResourceRelLst)
{
string strKey = string.Format("{0}", clsvTeachCase_Resource_RelEN._CurrTabName);
List<clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLst_Sel =
arrvTeachCase_Resource_RelObjLstCache
.Where(x => arrIdTeachCaseResourceRelLst.Contains(x.IdTeachCaseResourceRel));
return arrvTeachCase_Resource_RelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCase_Resource_RelEN> GetObjLst(string strWhereCond)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachCase_Resource_RelEN> GetSubObjLstCache(clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelCond)
{
List<clsvTeachCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachCase_Resource_Rel.AttributeName)
{
if (objvTeachCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvTeachCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvTeachCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachCase_Resource_RelCond[strFldName]));
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
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
List<clsvTeachCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachCase_Resource_RelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCase_Resource_RelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
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
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
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
public static List<clsvTeachCase_Resource_RelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachCase_Resource_RelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
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
public static List<clsvTeachCase_Resource_RelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCase_Resource_RelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachCase_Resource_Rel(ref clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN)
{
bool bolResult = vTeachCase_Resource_RelDA.GetvTeachCase_Resource_Rel(ref objvTeachCase_Resource_RelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCase_Resource_RelEN GetObjByIdTeachCaseResourceRel(long lngIdTeachCaseResourceRel)
{
clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = vTeachCase_Resource_RelDA.GetObjByIdTeachCaseResourceRel(lngIdTeachCaseResourceRel);
return objvTeachCase_Resource_RelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachCase_Resource_RelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = vTeachCase_Resource_RelDA.GetFirstObj(strWhereCond);
 return objvTeachCase_Resource_RelEN;
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
public static clsvTeachCase_Resource_RelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = vTeachCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvTeachCase_Resource_RelEN;
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
public static clsvTeachCase_Resource_RelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = vTeachCase_Resource_RelDA.GetObjByDataRow(objRow);
 return objvTeachCase_Resource_RelEN;
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
 /// <param name = "lngIdTeachCaseResourceRel">所给的关键字</param>
 /// <param name = "lstvTeachCase_Resource_RelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachCase_Resource_RelEN GetObjByIdTeachCaseResourceRelFromList(long lngIdTeachCaseResourceRel, List<clsvTeachCase_Resource_RelEN> lstvTeachCase_Resource_RelObjLst)
{
foreach (clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN in lstvTeachCase_Resource_RelObjLst)
{
if (objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel == lngIdTeachCaseResourceRel)
{
return objvTeachCase_Resource_RelEN;
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
 long lngIdTeachCaseResourceRel;
 try
 {
 lngIdTeachCaseResourceRel = new clsvTeachCase_Resource_RelDA().GetFirstID(strWhereCond);
 return lngIdTeachCaseResourceRel;
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
 arrList = vTeachCase_Resource_RelDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachCase_Resource_RelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdTeachCaseResourceRel)
{
//检测记录是否存在
bool bolIsExist = vTeachCase_Resource_RelDA.IsExist(lngIdTeachCaseResourceRel);
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
 bolIsExist = clsvTeachCase_Resource_RelDA.IsExistTable();
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
 bolIsExist = vTeachCase_Resource_RelDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachCase_Resource_RelENS">源对象</param>
 /// <param name = "objvTeachCase_Resource_RelENT">目标对象</param>
 public static void CopyTo(clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENS, clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENT)
{
try
{
objvTeachCase_Resource_RelENT.IdTeachCaseResourceRel = objvTeachCase_Resource_RelENS.IdTeachCaseResourceRel; //案例与资源表系表流水号
objvTeachCase_Resource_RelENT.IdTeachCase = objvTeachCase_Resource_RelENS.IdTeachCase; //案例流水号
objvTeachCase_Resource_RelENT.TeachCaseID = objvTeachCase_Resource_RelENS.TeachCaseID; //案例ID
objvTeachCase_Resource_RelENT.TeachCaseName = objvTeachCase_Resource_RelENS.TeachCaseName; //案例名称
objvTeachCase_Resource_RelENT.TeachCaseExecutor = objvTeachCase_Resource_RelENS.TeachCaseExecutor; //案例执教者
objvTeachCase_Resource_RelENT.TeachCaseTheme = objvTeachCase_Resource_RelENS.TeachCaseTheme; //案例主题词
objvTeachCase_Resource_RelENT.TeachCaseBG = objvTeachCase_Resource_RelENS.TeachCaseBG; //案例背景资料
objvTeachCase_Resource_RelENT.IdTeachSkill = objvTeachCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvTeachCase_Resource_RelENT.TeachSkillID = objvTeachCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvTeachCase_Resource_RelENT.SkillTypeName = objvTeachCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvTeachCase_Resource_RelENT.TeachSkillName = objvTeachCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvTeachCase_Resource_RelENT.TeachSkillTheory = objvTeachCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvTeachCase_Resource_RelENT.TeachSkillOperMethod = objvTeachCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachCase_Resource_RelENT.IdSkillType = objvTeachCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvTeachCase_Resource_RelENT.SkillTypeID = objvTeachCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvTeachCase_Resource_RelENT.IdDiscipline = objvTeachCase_Resource_RelENS.IdDiscipline; //学科流水号
objvTeachCase_Resource_RelENT.DisciplineName = objvTeachCase_Resource_RelENS.DisciplineName; //学科名称
objvTeachCase_Resource_RelENT.IdStudyLevel = objvTeachCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvTeachCase_Resource_RelENT.StudyLevelName = objvTeachCase_Resource_RelENS.StudyLevelName; //学段名称
objvTeachCase_Resource_RelENT.TeachCaseDateIn = objvTeachCase_Resource_RelENS.TeachCaseDateIn; //案例入库日期
objvTeachCase_Resource_RelENT.IdTeachingPlan = objvTeachCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvTeachCase_Resource_RelENT.TeachCaseTimeIn = objvTeachCase_Resource_RelENS.TeachCaseTimeIn; //案例入库时间
objvTeachCase_Resource_RelENT.WorkUnit = objvTeachCase_Resource_RelENS.WorkUnit; //工作单位
objvTeachCase_Resource_RelENT.CDID = objvTeachCase_Resource_RelENS.CDID; //光盘编号
objvTeachCase_Resource_RelENT.IsDualVideo = objvTeachCase_Resource_RelENS.IsDualVideo; //是否双视频
objvTeachCase_Resource_RelENT.IdXzCollege = objvTeachCase_Resource_RelENS.IdXzCollege; //学院流水号
objvTeachCase_Resource_RelENT.CollegeID = objvTeachCase_Resource_RelENS.CollegeID; //学院ID
objvTeachCase_Resource_RelENT.CollegeName = objvTeachCase_Resource_RelENS.CollegeName; //学院名称
objvTeachCase_Resource_RelENT.RecommendedDegreeId = objvTeachCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvTeachCase_Resource_RelENT.RecommendedDegreeName = objvTeachCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvTeachCase_Resource_RelENT.BrowseCount4Case = objvTeachCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvTeachCase_Resource_RelENT.IdResource = objvTeachCase_Resource_RelENS.IdResource; //资源流水号
objvTeachCase_Resource_RelENT.ResourceID = objvTeachCase_Resource_RelENS.ResourceID; //资源ID
objvTeachCase_Resource_RelENT.ResourceName = objvTeachCase_Resource_RelENS.ResourceName; //资源名称
objvTeachCase_Resource_RelENT.IdFtpResource = objvTeachCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvTeachCase_Resource_RelENT.IdFile = objvTeachCase_Resource_RelENS.IdFile; //文件流水号
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
objvTeachCase_Resource_RelENT.IdResourceType = objvTeachCase_Resource_RelENS.IdResourceType; //资源类型流水号
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
 /// <param name = "objvTeachCase_Resource_RelEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN)
{
try
{
objvTeachCase_Resource_RelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachCase_Resource_RelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdTeachCaseResourceRel, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel; //案例与资源表系表流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdTeachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdTeachCase = objvTeachCase_Resource_RelEN.IdTeachCase; //案例流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachCaseID = objvTeachCase_Resource_RelEN.TeachCaseID; //案例ID
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachCaseName = objvTeachCase_Resource_RelEN.TeachCaseName; //案例名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objvTeachCase_Resource_RelEN.TeachCaseExecutor == "[null]" ? null :  objvTeachCase_Resource_RelEN.TeachCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachCaseTheme = objvTeachCase_Resource_RelEN.TeachCaseTheme == "[null]" ? null :  objvTeachCase_Resource_RelEN.TeachCaseTheme; //案例主题词
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachCaseBG, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachCaseBG = objvTeachCase_Resource_RelEN.TeachCaseBG == "[null]" ? null :  objvTeachCase_Resource_RelEN.TeachCaseBG; //案例背景资料
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdTeachSkill = objvTeachCase_Resource_RelEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachSkillID = objvTeachCase_Resource_RelEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.SkillTypeName = objvTeachCase_Resource_RelEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachSkillName = objvTeachCase_Resource_RelEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachSkillTheory = objvTeachCase_Resource_RelEN.TeachSkillTheory == "[null]" ? null :  objvTeachCase_Resource_RelEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objvTeachCase_Resource_RelEN.TeachSkillOperMethod == "[null]" ? null :  objvTeachCase_Resource_RelEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdSkillType = objvTeachCase_Resource_RelEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.SkillTypeID = objvTeachCase_Resource_RelEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdDiscipline = objvTeachCase_Resource_RelEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.DisciplineName = objvTeachCase_Resource_RelEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdStudyLevel = objvTeachCase_Resource_RelEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.StudyLevelName = objvTeachCase_Resource_RelEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objvTeachCase_Resource_RelEN.TeachCaseDateIn == "[null]" ? null :  objvTeachCase_Resource_RelEN.TeachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdTeachingPlan = objvTeachCase_Resource_RelEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.TeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objvTeachCase_Resource_RelEN.TeachCaseTimeIn == "[null]" ? null :  objvTeachCase_Resource_RelEN.TeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.WorkUnit = objvTeachCase_Resource_RelEN.WorkUnit == "[null]" ? null :  objvTeachCase_Resource_RelEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.CDID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.CDID = objvTeachCase_Resource_RelEN.CDID == "[null]" ? null :  objvTeachCase_Resource_RelEN.CDID; //光盘编号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IsDualVideo = objvTeachCase_Resource_RelEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdXzCollege = objvTeachCase_Resource_RelEN.IdXzCollege == "[null]" ? null :  objvTeachCase_Resource_RelEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.CollegeID = objvTeachCase_Resource_RelEN.CollegeID == "[null]" ? null :  objvTeachCase_Resource_RelEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.CollegeName = objvTeachCase_Resource_RelEN.CollegeName == "[null]" ? null :  objvTeachCase_Resource_RelEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objvTeachCase_Resource_RelEN.RecommendedDegreeId == "[null]" ? null :  objvTeachCase_Resource_RelEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objvTeachCase_Resource_RelEN.RecommendedDegreeName == "[null]" ? null :  objvTeachCase_Resource_RelEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.BrowseCount4Case = objvTeachCase_Resource_RelEN.BrowseCount4Case; //课例浏览次数
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdResource = objvTeachCase_Resource_RelEN.IdResource; //资源流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.ResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.ResourceID = objvTeachCase_Resource_RelEN.ResourceID; //资源ID
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.ResourceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.ResourceName = objvTeachCase_Resource_RelEN.ResourceName == "[null]" ? null :  objvTeachCase_Resource_RelEN.ResourceName; //资源名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdFtpResource = objvTeachCase_Resource_RelEN.IdFtpResource == "[null]" ? null :  objvTeachCase_Resource_RelEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdFile = objvTeachCase_Resource_RelEN.IdFile == "[null]" ? null :  objvTeachCase_Resource_RelEN.IdFile; //文件流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileName = objvTeachCase_Resource_RelEN.FileName == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileName; //文件名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileType = objvTeachCase_Resource_RelEN.FileType == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileType; //文件类型
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.SaveDate = objvTeachCase_Resource_RelEN.SaveDate == "[null]" ? null :  objvTeachCase_Resource_RelEN.SaveDate; //创建日期
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileSize = objvTeachCase_Resource_RelEN.FileSize == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileSize; //文件大小
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.SaveTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.SaveTime = objvTeachCase_Resource_RelEN.SaveTime == "[null]" ? null :  objvTeachCase_Resource_RelEN.SaveTime; //创建时间
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FtpResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FtpResourceID = objvTeachCase_Resource_RelEN.FtpResourceID; //FTP资源ID
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileOriginalName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileOriginalName = objvTeachCase_Resource_RelEN.FileOriginalName == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileOriginalName; //文件原名
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileDirName = objvTeachCase_Resource_RelEN.FileDirName == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileRename, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileRename = objvTeachCase_Resource_RelEN.FileRename == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileRename; //文件新名
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileUpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileUpDate = objvTeachCase_Resource_RelEN.FileUpDate == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileUpDate; //创建日期
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileUpTime = objvTeachCase_Resource_RelEN.FileUpTime == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileUpTime; //创建时间
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.SaveMode = objvTeachCase_Resource_RelEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IdResourceType = objvTeachCase_Resource_RelEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.ResourceTypeID = objvTeachCase_Resource_RelEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.ResourceTypeName = objvTeachCase_Resource_RelEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.ResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.ResourceOwner = objvTeachCase_Resource_RelEN.ResourceOwner; //上传者
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.ftpFileType = objvTeachCase_Resource_RelEN.ftpFileType == "[null]" ? null :  objvTeachCase_Resource_RelEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.ftpFileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.ftpFileSize = objvTeachCase_Resource_RelEN.ftpFileSize == "[null]" ? null :  objvTeachCase_Resource_RelEN.ftpFileSize; //ftp文件大小
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.ftpResourceOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.ftpResourceOwner = objvTeachCase_Resource_RelEN.ftpResourceOwner == "[null]" ? null :  objvTeachCase_Resource_RelEN.ftpResourceOwner; //Ftp资源拥有者
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileOriginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileOriginName = objvTeachCase_Resource_RelEN.FileOriginName == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileOriginName; //原文件名
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IsExistFile = objvTeachCase_Resource_RelEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileNewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileNewName = objvTeachCase_Resource_RelEN.FileNewName == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileNewName; //新文件名
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.FileOldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.FileOldName = objvTeachCase_Resource_RelEN.FileOldName == "[null]" ? null :  objvTeachCase_Resource_RelEN.FileOldName; //旧文件名
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IsMain, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IsMain = objvTeachCase_Resource_RelEN.IsMain; //是否主资源
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.Memo = objvTeachCase_Resource_RelEN.Memo == "[null]" ? null :  objvTeachCase_Resource_RelEN.Memo; //备注
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IndexNO, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IndexNO = objvTeachCase_Resource_RelEN.IndexNO; //序号
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.IsVisible = objvTeachCase_Resource_RelEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.BrowseCount = objvTeachCase_Resource_RelEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(convTeachCase_Resource_Rel.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCase_Resource_RelEN.CollegeNameA = objvTeachCase_Resource_RelEN.CollegeNameA == "[null]" ? null :  objvTeachCase_Resource_RelEN.CollegeNameA; //学院名称简写
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
 /// <param name = "objvTeachCase_Resource_RelEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN)
{
try
{
if (objvTeachCase_Resource_RelEN.TeachCaseExecutor == "[null]") objvTeachCase_Resource_RelEN.TeachCaseExecutor = null; //案例执教者
if (objvTeachCase_Resource_RelEN.TeachCaseTheme == "[null]") objvTeachCase_Resource_RelEN.TeachCaseTheme = null; //案例主题词
if (objvTeachCase_Resource_RelEN.TeachCaseBG == "[null]") objvTeachCase_Resource_RelEN.TeachCaseBG = null; //案例背景资料
if (objvTeachCase_Resource_RelEN.TeachSkillTheory == "[null]") objvTeachCase_Resource_RelEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvTeachCase_Resource_RelEN.TeachSkillOperMethod == "[null]") objvTeachCase_Resource_RelEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvTeachCase_Resource_RelEN.TeachCaseDateIn == "[null]") objvTeachCase_Resource_RelEN.TeachCaseDateIn = null; //案例入库日期
if (objvTeachCase_Resource_RelEN.TeachCaseTimeIn == "[null]") objvTeachCase_Resource_RelEN.TeachCaseTimeIn = null; //案例入库时间
if (objvTeachCase_Resource_RelEN.WorkUnit == "[null]") objvTeachCase_Resource_RelEN.WorkUnit = null; //工作单位
if (objvTeachCase_Resource_RelEN.CDID == "[null]") objvTeachCase_Resource_RelEN.CDID = null; //光盘编号
if (objvTeachCase_Resource_RelEN.IdXzCollege == "[null]") objvTeachCase_Resource_RelEN.IdXzCollege = null; //学院流水号
if (objvTeachCase_Resource_RelEN.CollegeID == "[null]") objvTeachCase_Resource_RelEN.CollegeID = null; //学院ID
if (objvTeachCase_Resource_RelEN.CollegeName == "[null]") objvTeachCase_Resource_RelEN.CollegeName = null; //学院名称
if (objvTeachCase_Resource_RelEN.RecommendedDegreeId == "[null]") objvTeachCase_Resource_RelEN.RecommendedDegreeId = null; //推荐度Id
if (objvTeachCase_Resource_RelEN.RecommendedDegreeName == "[null]") objvTeachCase_Resource_RelEN.RecommendedDegreeName = null; //推荐度名称
if (objvTeachCase_Resource_RelEN.ResourceName == "[null]") objvTeachCase_Resource_RelEN.ResourceName = null; //资源名称
if (objvTeachCase_Resource_RelEN.IdFtpResource == "[null]") objvTeachCase_Resource_RelEN.IdFtpResource = null; //FTP资源流水号
if (objvTeachCase_Resource_RelEN.IdFile == "[null]") objvTeachCase_Resource_RelEN.IdFile = null; //文件流水号
if (objvTeachCase_Resource_RelEN.FileName == "[null]") objvTeachCase_Resource_RelEN.FileName = null; //文件名称
if (objvTeachCase_Resource_RelEN.FileType == "[null]") objvTeachCase_Resource_RelEN.FileType = null; //文件类型
if (objvTeachCase_Resource_RelEN.SaveDate == "[null]") objvTeachCase_Resource_RelEN.SaveDate = null; //创建日期
if (objvTeachCase_Resource_RelEN.FileSize == "[null]") objvTeachCase_Resource_RelEN.FileSize = null; //文件大小
if (objvTeachCase_Resource_RelEN.SaveTime == "[null]") objvTeachCase_Resource_RelEN.SaveTime = null; //创建时间
if (objvTeachCase_Resource_RelEN.FileOriginalName == "[null]") objvTeachCase_Resource_RelEN.FileOriginalName = null; //文件原名
if (objvTeachCase_Resource_RelEN.FileDirName == "[null]") objvTeachCase_Resource_RelEN.FileDirName = null; //文件目录名
if (objvTeachCase_Resource_RelEN.FileRename == "[null]") objvTeachCase_Resource_RelEN.FileRename = null; //文件新名
if (objvTeachCase_Resource_RelEN.FileUpDate == "[null]") objvTeachCase_Resource_RelEN.FileUpDate = null; //创建日期
if (objvTeachCase_Resource_RelEN.FileUpTime == "[null]") objvTeachCase_Resource_RelEN.FileUpTime = null; //创建时间
if (objvTeachCase_Resource_RelEN.ftpFileType == "[null]") objvTeachCase_Resource_RelEN.ftpFileType = null; //ftp文件类型
if (objvTeachCase_Resource_RelEN.ftpFileSize == "[null]") objvTeachCase_Resource_RelEN.ftpFileSize = null; //ftp文件大小
if (objvTeachCase_Resource_RelEN.ftpResourceOwner == "[null]") objvTeachCase_Resource_RelEN.ftpResourceOwner = null; //Ftp资源拥有者
if (objvTeachCase_Resource_RelEN.FileOriginName == "[null]") objvTeachCase_Resource_RelEN.FileOriginName = null; //原文件名
if (objvTeachCase_Resource_RelEN.FileNewName == "[null]") objvTeachCase_Resource_RelEN.FileNewName = null; //新文件名
if (objvTeachCase_Resource_RelEN.FileOldName == "[null]") objvTeachCase_Resource_RelEN.FileOldName = null; //旧文件名
if (objvTeachCase_Resource_RelEN.Memo == "[null]") objvTeachCase_Resource_RelEN.Memo = null; //备注
if (objvTeachCase_Resource_RelEN.CollegeNameA == "[null]") objvTeachCase_Resource_RelEN.CollegeNameA = null; //学院名称简写
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
public static void CheckProperty4Condition(clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN)
{
 vTeachCase_Resource_RelDA.CheckProperty4Condition(objvTeachCase_Resource_RelEN);
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
if (clsTeachCase_Resource_RelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCase_Resource_RelBL没有刷新缓存机制(clsTeachCase_Resource_RelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceBL没有刷新缓存机制(clsResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceBL没有刷新缓存机制(clsFtpResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseBL没有刷新缓存机制(clsTeachCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachCaseResourceRel");
//if (arrvTeachCase_Resource_RelObjLstCache == null)
//{
//arrvTeachCase_Resource_RelObjLstCache = vTeachCase_Resource_RelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachCase_Resource_RelEN GetObjByIdTeachCaseResourceRelCache(long lngIdTeachCaseResourceRel)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachCase_Resource_RelEN._CurrTabName);
List<clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLst_Sel =
arrvTeachCase_Resource_RelObjLstCache
.Where(x=> x.IdTeachCaseResourceRel == lngIdTeachCaseResourceRel 
);
if (arrvTeachCase_Resource_RelObjLst_Sel.Count() == 0)
{
   clsvTeachCase_Resource_RelEN obj = clsvTeachCase_Resource_RelBL.GetObjByIdTeachCaseResourceRel(lngIdTeachCaseResourceRel);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachCase_Resource_RelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachCase_Resource_RelEN> GetAllvTeachCase_Resource_RelObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLstCache = GetObjLstCache(); 
return arrvTeachCase_Resource_RelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachCase_Resource_RelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachCase_Resource_RelEN._CurrTabName);
List<clsvTeachCase_Resource_RelEN> arrvTeachCase_Resource_RelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachCase_Resource_RelObjLstCache;
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
string strKey = string.Format("{0}", clsvTeachCase_Resource_RelEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdTeachCaseResourceRel)
{
if (strInFldName != convTeachCase_Resource_Rel.IdTeachCaseResourceRel)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachCase_Resource_Rel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachCase_Resource_Rel.AttributeName));
throw new Exception(strMsg);
}
var objvTeachCase_Resource_Rel = clsvTeachCase_Resource_RelBL.GetObjByIdTeachCaseResourceRelCache(lngIdTeachCaseResourceRel);
if (objvTeachCase_Resource_Rel == null) return "";
return objvTeachCase_Resource_Rel[strOutFldName].ToString();
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
int intRecCount = clsvTeachCase_Resource_RelDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachCase_Resource_RelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachCase_Resource_RelDA.GetRecCount();
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
int intRecCount = clsvTeachCase_Resource_RelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelCond)
{
List<clsvTeachCase_Resource_RelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCase_Resource_RelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachCase_Resource_Rel.AttributeName)
{
if (objvTeachCase_Resource_RelCond.IsUpdated(strFldName) == false) continue;
if (objvTeachCase_Resource_RelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCase_Resource_RelCond[strFldName].ToString());
}
else
{
if (objvTeachCase_Resource_RelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachCase_Resource_RelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCase_Resource_RelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachCase_Resource_RelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachCase_Resource_RelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachCase_Resource_RelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachCase_Resource_RelCond[strFldName]));
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
 List<string> arrList = clsvTeachCase_Resource_RelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachCase_Resource_RelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachCase_Resource_RelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}