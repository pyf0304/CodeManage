
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCaseBL
 表名:vTeachCase(01120384)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:50
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
public static class  clsvTeachCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCaseEN GetObj(this K_IdTeachCase_vTeachCase myKey)
{
clsvTeachCaseEN objvTeachCaseEN = clsvTeachCaseBL.vTeachCaseDA.GetObjByIdTeachCase(myKey.Value);
return objvTeachCaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetIdTeachCase(this clsvTeachCaseEN objvTeachCaseEN, string strIdTeachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachCase, 8, convTeachCase.IdTeachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachCase, 8, convTeachCase.IdTeachCase);
}
objvTeachCaseEN.IdTeachCase = strIdTeachCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.IdTeachCase) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.IdTeachCase, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.IdTeachCase] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseID(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseID, convTeachCase.TeachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseID, 8, convTeachCase.TeachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseID, 8, convTeachCase.TeachCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseName(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseName, convTeachCase.TeachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseName, 200, convTeachCase.TeachCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseExecutor(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseExecutor, 50, convTeachCase.TeachCaseExecutor);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseTheme(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseTheme, 200, convTeachCase.TeachCaseTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseBG(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseBG, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseBG, 8000, convTeachCase.TeachCaseBG);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetIdTeachSkill(this clsvTeachCaseEN objvTeachCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, convTeachCase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, convTeachCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, convTeachCase.IdTeachSkill);
}
objvTeachCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.IdTeachSkill) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.IdTeachSkill, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.IdTeachSkill] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachSkillID(this clsvTeachCaseEN objvTeachCaseEN, string strTeachSkillID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillID, convTeachCase.TeachSkillID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillID, 8, convTeachCase.TeachSkillID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachSkillID, 8, convTeachCase.TeachSkillID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetSkillTypeName(this clsvTeachCaseEN objvTeachCaseEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convTeachCase.SkillTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachSkillName(this clsvTeachCaseEN objvTeachCaseEN, string strTeachSkillName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachSkillName, convTeachCase.TeachSkillName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillName, 50, convTeachCase.TeachSkillName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachSkillTheory(this clsvTeachCaseEN objvTeachCaseEN, string strTeachSkillTheory, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillTheory, 8000, convTeachCase.TeachSkillTheory);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachSkillOperMethod(this clsvTeachCaseEN objvTeachCaseEN, string strTeachSkillOperMethod, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachSkillOperMethod, 2000, convTeachCase.TeachSkillOperMethod);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetIdSkillType(this clsvTeachCaseEN objvTeachCaseEN, string strIdSkillType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convTeachCase.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convTeachCase.IdSkillType);
}
objvTeachCaseEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.IdSkillType) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.IdSkillType, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.IdSkillType] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetSkillTypeID(this clsvTeachCaseEN objvTeachCaseEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convTeachCase.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convTeachCase.SkillTypeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetIdDiscipline(this clsvTeachCaseEN objvTeachCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, convTeachCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, convTeachCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, convTeachCase.IdDiscipline);
}
objvTeachCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.IdDiscipline) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.IdDiscipline, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.IdDiscipline] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetDisciplineName(this clsvTeachCaseEN objvTeachCaseEN, string strDisciplineName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDisciplineName, convTeachCase.DisciplineName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDisciplineName, 50, convTeachCase.DisciplineName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetIdStudyLevel(this clsvTeachCaseEN objvTeachCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, convTeachCase.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convTeachCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convTeachCase.IdStudyLevel);
}
objvTeachCaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.IdStudyLevel) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.IdStudyLevel, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.IdStudyLevel] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetStudyLevelName(this clsvTeachCaseEN objvTeachCaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStudyLevelName, convTeachCase.StudyLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convTeachCase.StudyLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseDateIn(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseDateIn, 8, convTeachCase.TeachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseDateIn, 8, convTeachCase.TeachCaseDateIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetIdTeachingPlan(this clsvTeachCaseEN objvTeachCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachingPlan, convTeachCase.IdTeachingPlan);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, convTeachCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, convTeachCase.IdTeachingPlan);
}
objvTeachCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.IdTeachingPlan) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.IdTeachingPlan, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.IdTeachingPlan] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetTeachCaseTimeIn(this clsvTeachCaseEN objvTeachCaseEN, string strTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseTimeIn, 6, convTeachCase.TeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseTimeIn, 6, convTeachCase.TeachCaseTimeIn);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetWorkUnit(this clsvTeachCaseEN objvTeachCaseEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convTeachCase.WorkUnit);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetCDID(this clsvTeachCaseEN objvTeachCaseEN, string strCDID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCDID, 50, convTeachCase.CDID);
}
objvTeachCaseEN.CDID = strCDID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.CDID) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.CDID, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.CDID] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetIdXzCollege(this clsvTeachCaseEN objvTeachCaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convTeachCase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convTeachCase.IdXzCollege);
}
objvTeachCaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachCaseEN.dicFldComparisonOp.ContainsKey(convTeachCase.IdXzCollege) == false)
{
objvTeachCaseEN.dicFldComparisonOp.Add(convTeachCase.IdXzCollege, strComparisonOp);
}
else
{
objvTeachCaseEN.dicFldComparisonOp[convTeachCase.IdXzCollege] = strComparisonOp;
}
}
return objvTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetCollegeID(this clsvTeachCaseEN objvTeachCaseEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachCase.CollegeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetCollegeName(this clsvTeachCaseEN objvTeachCaseEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachCase.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetCollegeNameA(this clsvTeachCaseEN objvTeachCaseEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachCase.CollegeNameA);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetRecommendedDegreeId(this clsvTeachCaseEN objvTeachCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, convTeachCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, convTeachCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, convTeachCase.RecommendedDegreeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetRecommendedDegreeName(this clsvTeachCaseEN objvTeachCaseEN, string strRecommendedDegreeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeName, 30, convTeachCase.RecommendedDegreeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetftpFileType(this clsvTeachCaseEN objvTeachCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachCase.ftpFileType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetVideoUrl(this clsvTeachCaseEN objvTeachCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convTeachCase.VideoUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetVideoPath(this clsvTeachCaseEN objvTeachCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, convTeachCase.VideoPath);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetResErrMsg(this clsvTeachCaseEN objvTeachCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, convTeachCase.ResErrMsg);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetMemo(this clsvTeachCaseEN objvTeachCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachCase.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTeachCaseEN SetBrowseCount4Case(this clsvTeachCaseEN objvTeachCaseEN, int? intBrowseCount4Case, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTeachCaseENS">源对象</param>
 /// <param name = "objvTeachCaseENT">目标对象</param>
 public static void CopyTo(this clsvTeachCaseEN objvTeachCaseENS, clsvTeachCaseEN objvTeachCaseENT)
{
try
{
objvTeachCaseENT.IdTeachCase = objvTeachCaseENS.IdTeachCase; //案例流水号
objvTeachCaseENT.TeachCaseID = objvTeachCaseENS.TeachCaseID; //案例ID
objvTeachCaseENT.TeachCaseName = objvTeachCaseENS.TeachCaseName; //案例名称
objvTeachCaseENT.TeachCaseExecutor = objvTeachCaseENS.TeachCaseExecutor; //案例执教者
objvTeachCaseENT.TeachCaseTheme = objvTeachCaseENS.TeachCaseTheme; //案例主题词
objvTeachCaseENT.TeachCaseBG = objvTeachCaseENS.TeachCaseBG; //案例背景资料
objvTeachCaseENT.IdTeachSkill = objvTeachCaseENS.IdTeachSkill; //教学技能流水号
objvTeachCaseENT.TeachSkillID = objvTeachCaseENS.TeachSkillID; //教学技能ID
objvTeachCaseENT.SkillTypeName = objvTeachCaseENS.SkillTypeName; //技能类型名称
objvTeachCaseENT.TeachSkillName = objvTeachCaseENS.TeachSkillName; //教学技能名称
objvTeachCaseENT.TeachSkillTheory = objvTeachCaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachCaseENT.TeachSkillOperMethod = objvTeachCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachCaseENT.IdSkillType = objvTeachCaseENS.IdSkillType; //技能类型流水号
objvTeachCaseENT.SkillTypeID = objvTeachCaseENS.SkillTypeID; //技能类型ID
objvTeachCaseENT.IdDiscipline = objvTeachCaseENS.IdDiscipline; //学科流水号
objvTeachCaseENT.DisciplineName = objvTeachCaseENS.DisciplineName; //学科名称
objvTeachCaseENT.IdStudyLevel = objvTeachCaseENS.IdStudyLevel; //id_StudyLevel
objvTeachCaseENT.StudyLevelName = objvTeachCaseENS.StudyLevelName; //学段名称
objvTeachCaseENT.TeachCaseDateIn = objvTeachCaseENS.TeachCaseDateIn; //案例入库日期
objvTeachCaseENT.IdTeachingPlan = objvTeachCaseENS.IdTeachingPlan; //教案流水号
objvTeachCaseENT.TeachCaseTimeIn = objvTeachCaseENS.TeachCaseTimeIn; //案例入库时间
objvTeachCaseENT.WorkUnit = objvTeachCaseENS.WorkUnit; //工作单位
objvTeachCaseENT.CDID = objvTeachCaseENS.CDID; //光盘编号
objvTeachCaseENT.IsVisible = objvTeachCaseENS.IsVisible; //是否显示
objvTeachCaseENT.IsDualVideo = objvTeachCaseENS.IsDualVideo; //是否双视频
objvTeachCaseENT.IdXzCollege = objvTeachCaseENS.IdXzCollege; //学院流水号
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
 /// <param name = "objvTeachCaseENS">源对象</param>
 /// <returns>目标对象=>clsvTeachCaseEN:objvTeachCaseENT</returns>
 public static clsvTeachCaseEN CopyTo(this clsvTeachCaseEN objvTeachCaseENS)
{
try
{
 clsvTeachCaseEN objvTeachCaseENT = new clsvTeachCaseEN()
{
IdTeachCase = objvTeachCaseENS.IdTeachCase, //案例流水号
TeachCaseID = objvTeachCaseENS.TeachCaseID, //案例ID
TeachCaseName = objvTeachCaseENS.TeachCaseName, //案例名称
TeachCaseExecutor = objvTeachCaseENS.TeachCaseExecutor, //案例执教者
TeachCaseTheme = objvTeachCaseENS.TeachCaseTheme, //案例主题词
TeachCaseBG = objvTeachCaseENS.TeachCaseBG, //案例背景资料
IdTeachSkill = objvTeachCaseENS.IdTeachSkill, //教学技能流水号
TeachSkillID = objvTeachCaseENS.TeachSkillID, //教学技能ID
SkillTypeName = objvTeachCaseENS.SkillTypeName, //技能类型名称
TeachSkillName = objvTeachCaseENS.TeachSkillName, //教学技能名称
TeachSkillTheory = objvTeachCaseENS.TeachSkillTheory, //教学技能理论阐述
TeachSkillOperMethod = objvTeachCaseENS.TeachSkillOperMethod, //教学技能实践操作方法
IdSkillType = objvTeachCaseENS.IdSkillType, //技能类型流水号
SkillTypeID = objvTeachCaseENS.SkillTypeID, //技能类型ID
IdDiscipline = objvTeachCaseENS.IdDiscipline, //学科流水号
DisciplineName = objvTeachCaseENS.DisciplineName, //学科名称
IdStudyLevel = objvTeachCaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvTeachCaseENS.StudyLevelName, //学段名称
TeachCaseDateIn = objvTeachCaseENS.TeachCaseDateIn, //案例入库日期
IdTeachingPlan = objvTeachCaseENS.IdTeachingPlan, //教案流水号
TeachCaseTimeIn = objvTeachCaseENS.TeachCaseTimeIn, //案例入库时间
WorkUnit = objvTeachCaseENS.WorkUnit, //工作单位
CDID = objvTeachCaseENS.CDID, //光盘编号
IsVisible = objvTeachCaseENS.IsVisible, //是否显示
IsDualVideo = objvTeachCaseENS.IsDualVideo, //是否双视频
IdXzCollege = objvTeachCaseENS.IdXzCollege, //学院流水号
CollegeID = objvTeachCaseENS.CollegeID, //学院ID
CollegeName = objvTeachCaseENS.CollegeName, //学院名称
CollegeNameA = objvTeachCaseENS.CollegeNameA, //学院名称简写
RecommendedDegreeId = objvTeachCaseENS.RecommendedDegreeId, //推荐度Id
RecommendedDegreeName = objvTeachCaseENS.RecommendedDegreeName, //推荐度名称
ftpFileType = objvTeachCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objvTeachCaseENS.VideoUrl, //视频Url
VideoPath = objvTeachCaseENS.VideoPath, //视频目录
ResErrMsg = objvTeachCaseENS.ResErrMsg, //资源错误信息
Memo = objvTeachCaseENS.Memo, //备注
BrowseCount4Case = objvTeachCaseENS.BrowseCount4Case, //课例浏览次数
};
 return objvTeachCaseENT;
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
public static void CheckProperty4Condition(this clsvTeachCaseEN objvTeachCaseEN)
{
 clsvTeachCaseBL.vTeachCaseDA.CheckProperty4Condition(objvTeachCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachCaseEN objvTeachCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachCaseCond.IsUpdated(convTeachCase.IdTeachCase) == true)
{
string strComparisonOpIdTeachCase = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.IdTeachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.IdTeachCase, objvTeachCaseCond.IdTeachCase, strComparisonOpIdTeachCase);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachCaseID) == true)
{
string strComparisonOpTeachCaseID = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseID, objvTeachCaseCond.TeachCaseID, strComparisonOpTeachCaseID);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachCaseName) == true)
{
string strComparisonOpTeachCaseName = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseName, objvTeachCaseCond.TeachCaseName, strComparisonOpTeachCaseName);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachCaseExecutor) == true)
{
string strComparisonOpTeachCaseExecutor = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseExecutor, objvTeachCaseCond.TeachCaseExecutor, strComparisonOpTeachCaseExecutor);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachCaseTheme) == true)
{
string strComparisonOpTeachCaseTheme = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseTheme, objvTeachCaseCond.TeachCaseTheme, strComparisonOpTeachCaseTheme);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachCaseBG) == true)
{
string strComparisonOpTeachCaseBG = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachCaseBG];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseBG, objvTeachCaseCond.TeachCaseBG, strComparisonOpTeachCaseBG);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.IdTeachSkill, objvTeachCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachSkillID) == true)
{
string strComparisonOpTeachSkillID = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachSkillID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachSkillID, objvTeachCaseCond.TeachSkillID, strComparisonOpTeachSkillID);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.SkillTypeName, objvTeachCaseCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachSkillName) == true)
{
string strComparisonOpTeachSkillName = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachSkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachSkillName, objvTeachCaseCond.TeachSkillName, strComparisonOpTeachSkillName);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachSkillTheory) == true)
{
string strComparisonOpTeachSkillTheory = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachSkillTheory];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachSkillTheory, objvTeachCaseCond.TeachSkillTheory, strComparisonOpTeachSkillTheory);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachSkillOperMethod) == true)
{
string strComparisonOpTeachSkillOperMethod = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachSkillOperMethod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachSkillOperMethod, objvTeachCaseCond.TeachSkillOperMethod, strComparisonOpTeachSkillOperMethod);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.IdSkillType, objvTeachCaseCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.SkillTypeID, objvTeachCaseCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.IdDiscipline, objvTeachCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.DisciplineName) == true)
{
string strComparisonOpDisciplineName = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.DisciplineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.DisciplineName, objvTeachCaseCond.DisciplineName, strComparisonOpDisciplineName);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.IdStudyLevel, objvTeachCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.StudyLevelName, objvTeachCaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachCaseDateIn) == true)
{
string strComparisonOpTeachCaseDateIn = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseDateIn, objvTeachCaseCond.TeachCaseDateIn, strComparisonOpTeachCaseDateIn);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.IdTeachingPlan, objvTeachCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.TeachCaseTimeIn) == true)
{
string strComparisonOpTeachCaseTimeIn = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.TeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.TeachCaseTimeIn, objvTeachCaseCond.TeachCaseTimeIn, strComparisonOpTeachCaseTimeIn);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.WorkUnit, objvTeachCaseCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.CDID) == true)
{
string strComparisonOpCDID = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.CDID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.CDID, objvTeachCaseCond.CDID, strComparisonOpCDID);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.IsVisible) == true)
{
if (objvTeachCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase.IsVisible);
}
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.IsDualVideo) == true)
{
if (objvTeachCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachCase.IsDualVideo);
}
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.IdXzCollege, objvTeachCaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.CollegeID) == true)
{
string strComparisonOpCollegeID = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.CollegeID, objvTeachCaseCond.CollegeID, strComparisonOpCollegeID);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.CollegeName) == true)
{
string strComparisonOpCollegeName = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.CollegeName, objvTeachCaseCond.CollegeName, strComparisonOpCollegeName);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.CollegeNameA, objvTeachCaseCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.RecommendedDegreeId, objvTeachCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.RecommendedDegreeName) == true)
{
string strComparisonOpRecommendedDegreeName = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.RecommendedDegreeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.RecommendedDegreeName, objvTeachCaseCond.RecommendedDegreeName, strComparisonOpRecommendedDegreeName);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.ftpFileType, objvTeachCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.VideoUrl, objvTeachCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.VideoPath, objvTeachCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.ResErrMsg, objvTeachCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.Memo) == true)
{
string strComparisonOpMemo = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachCase.Memo, objvTeachCaseCond.Memo, strComparisonOpMemo);
}
if (objvTeachCaseCond.IsUpdated(convTeachCase.BrowseCount4Case) == true)
{
string strComparisonOpBrowseCount4Case = objvTeachCaseCond.dicFldComparisonOp[convTeachCase.BrowseCount4Case];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachCase.BrowseCount4Case, objvTeachCaseCond.BrowseCount4Case, strComparisonOpBrowseCount4Case);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTeachCase
{
public virtual bool UpdRelaTabDate(string strIdTeachCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 技能案例视图(vTeachCase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTeachCaseBL
{
public static RelatedActions_vTeachCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTeachCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTeachCaseDA vTeachCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTeachCaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTeachCaseBL()
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
if (string.IsNullOrEmpty(clsvTeachCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachCaseEN._ConnectString);
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
public static DataTable GetDataTable_vTeachCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTeachCaseDA.GetDataTable_vTeachCase(strWhereCond);
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
objDT = vTeachCaseDA.GetDataTable(strWhereCond);
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
objDT = vTeachCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTeachCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTeachCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTeachCaseDA.GetDataTable_Top(objTopPara);
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
objDT = vTeachCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTeachCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTeachCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTeachCaseEN> GetObjLstByIdTeachCaseLst(List<string> arrIdTeachCaseLst)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachCaseLst, true);
 string strWhereCond = string.Format("IdTeachCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTeachCaseEN> GetObjLstByIdTeachCaseLstCache(List<string> arrIdTeachCaseLst)
{
string strKey = string.Format("{0}", clsvTeachCaseEN._CurrTabName);
List<clsvTeachCaseEN> arrvTeachCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCaseEN> arrvTeachCaseObjLst_Sel =
arrvTeachCaseObjLstCache
.Where(x => arrIdTeachCaseLst.Contains(x.IdTeachCase));
return arrvTeachCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseEN> GetObjLst(string strWhereCond)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
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
public static List<clsvTeachCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTeachCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTeachCaseEN> GetSubObjLstCache(clsvTeachCaseEN objvTeachCaseCond)
{
List<clsvTeachCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachCase.AttributeName)
{
if (objvTeachCaseCond.IsUpdated(strFldName) == false) continue;
if (objvTeachCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCaseCond[strFldName].ToString());
}
else
{
if (objvTeachCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachCaseCond[strFldName]));
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
public static List<clsvTeachCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
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
public static List<clsvTeachCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
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
List<clsvTeachCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTeachCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTeachCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
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
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
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
public static List<clsvTeachCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTeachCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTeachCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
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
public static List<clsvTeachCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTeachCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTeachCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTeachCase(ref clsvTeachCaseEN objvTeachCaseEN)
{
bool bolResult = vTeachCaseDA.GetvTeachCase(ref objvTeachCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachCaseEN GetObjByIdTeachCase(string strIdTeachCase)
{
if (strIdTeachCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdTeachCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdTeachCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdTeachCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTeachCaseEN objvTeachCaseEN = vTeachCaseDA.GetObjByIdTeachCase(strIdTeachCase);
return objvTeachCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTeachCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTeachCaseEN objvTeachCaseEN = vTeachCaseDA.GetFirstObj(strWhereCond);
 return objvTeachCaseEN;
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
public static clsvTeachCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTeachCaseEN objvTeachCaseEN = vTeachCaseDA.GetObjByDataRow(objRow);
 return objvTeachCaseEN;
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
public static clsvTeachCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTeachCaseEN objvTeachCaseEN = vTeachCaseDA.GetObjByDataRow(objRow);
 return objvTeachCaseEN;
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
 /// <param name = "strIdTeachCase">所给的关键字</param>
 /// <param name = "lstvTeachCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachCaseEN GetObjByIdTeachCaseFromList(string strIdTeachCase, List<clsvTeachCaseEN> lstvTeachCaseObjLst)
{
foreach (clsvTeachCaseEN objvTeachCaseEN in lstvTeachCaseObjLst)
{
if (objvTeachCaseEN.IdTeachCase == strIdTeachCase)
{
return objvTeachCaseEN;
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
 string strIdTeachCase;
 try
 {
 strIdTeachCase = new clsvTeachCaseDA().GetFirstID(strWhereCond);
 return strIdTeachCase;
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
 arrList = vTeachCaseDA.GetID(strWhereCond);
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
bool bolIsExist = vTeachCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdTeachCase)
{
if (string.IsNullOrEmpty(strIdTeachCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdTeachCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTeachCaseDA.IsExist(strIdTeachCase);
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
 bolIsExist = clsvTeachCaseDA.IsExistTable();
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
 bolIsExist = vTeachCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvTeachCaseENS">源对象</param>
 /// <param name = "objvTeachCaseENT">目标对象</param>
 public static void CopyTo(clsvTeachCaseEN objvTeachCaseENS, clsvTeachCaseEN objvTeachCaseENT)
{
try
{
objvTeachCaseENT.IdTeachCase = objvTeachCaseENS.IdTeachCase; //案例流水号
objvTeachCaseENT.TeachCaseID = objvTeachCaseENS.TeachCaseID; //案例ID
objvTeachCaseENT.TeachCaseName = objvTeachCaseENS.TeachCaseName; //案例名称
objvTeachCaseENT.TeachCaseExecutor = objvTeachCaseENS.TeachCaseExecutor; //案例执教者
objvTeachCaseENT.TeachCaseTheme = objvTeachCaseENS.TeachCaseTheme; //案例主题词
objvTeachCaseENT.TeachCaseBG = objvTeachCaseENS.TeachCaseBG; //案例背景资料
objvTeachCaseENT.IdTeachSkill = objvTeachCaseENS.IdTeachSkill; //教学技能流水号
objvTeachCaseENT.TeachSkillID = objvTeachCaseENS.TeachSkillID; //教学技能ID
objvTeachCaseENT.SkillTypeName = objvTeachCaseENS.SkillTypeName; //技能类型名称
objvTeachCaseENT.TeachSkillName = objvTeachCaseENS.TeachSkillName; //教学技能名称
objvTeachCaseENT.TeachSkillTheory = objvTeachCaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachCaseENT.TeachSkillOperMethod = objvTeachCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachCaseENT.IdSkillType = objvTeachCaseENS.IdSkillType; //技能类型流水号
objvTeachCaseENT.SkillTypeID = objvTeachCaseENS.SkillTypeID; //技能类型ID
objvTeachCaseENT.IdDiscipline = objvTeachCaseENS.IdDiscipline; //学科流水号
objvTeachCaseENT.DisciplineName = objvTeachCaseENS.DisciplineName; //学科名称
objvTeachCaseENT.IdStudyLevel = objvTeachCaseENS.IdStudyLevel; //id_StudyLevel
objvTeachCaseENT.StudyLevelName = objvTeachCaseENS.StudyLevelName; //学段名称
objvTeachCaseENT.TeachCaseDateIn = objvTeachCaseENS.TeachCaseDateIn; //案例入库日期
objvTeachCaseENT.IdTeachingPlan = objvTeachCaseENS.IdTeachingPlan; //教案流水号
objvTeachCaseENT.TeachCaseTimeIn = objvTeachCaseENS.TeachCaseTimeIn; //案例入库时间
objvTeachCaseENT.WorkUnit = objvTeachCaseENS.WorkUnit; //工作单位
objvTeachCaseENT.CDID = objvTeachCaseENS.CDID; //光盘编号
objvTeachCaseENT.IsVisible = objvTeachCaseENS.IsVisible; //是否显示
objvTeachCaseENT.IsDualVideo = objvTeachCaseENS.IsDualVideo; //是否双视频
objvTeachCaseENT.IdXzCollege = objvTeachCaseENS.IdXzCollege; //学院流水号
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
 /// <param name = "objvTeachCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvTeachCaseEN objvTeachCaseEN)
{
try
{
objvTeachCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTeachCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTeachCase.IdTeachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.IdTeachCase = objvTeachCaseEN.IdTeachCase; //案例流水号
}
if (arrFldSet.Contains(convTeachCase.TeachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachCaseID = objvTeachCaseEN.TeachCaseID; //案例ID
}
if (arrFldSet.Contains(convTeachCase.TeachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachCaseName = objvTeachCaseEN.TeachCaseName; //案例名称
}
if (arrFldSet.Contains(convTeachCase.TeachCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachCaseExecutor = objvTeachCaseEN.TeachCaseExecutor == "[null]" ? null :  objvTeachCaseEN.TeachCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(convTeachCase.TeachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachCaseTheme = objvTeachCaseEN.TeachCaseTheme == "[null]" ? null :  objvTeachCaseEN.TeachCaseTheme; //案例主题词
}
if (arrFldSet.Contains(convTeachCase.TeachCaseBG, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachCaseBG = objvTeachCaseEN.TeachCaseBG == "[null]" ? null :  objvTeachCaseEN.TeachCaseBG; //案例背景资料
}
if (arrFldSet.Contains(convTeachCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.IdTeachSkill = objvTeachCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(convTeachCase.TeachSkillID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachSkillID = objvTeachCaseEN.TeachSkillID; //教学技能ID
}
if (arrFldSet.Contains(convTeachCase.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.SkillTypeName = objvTeachCaseEN.SkillTypeName == "[null]" ? null :  objvTeachCaseEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convTeachCase.TeachSkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachSkillName = objvTeachCaseEN.TeachSkillName; //教学技能名称
}
if (arrFldSet.Contains(convTeachCase.TeachSkillTheory, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachSkillTheory = objvTeachCaseEN.TeachSkillTheory == "[null]" ? null :  objvTeachCaseEN.TeachSkillTheory; //教学技能理论阐述
}
if (arrFldSet.Contains(convTeachCase.TeachSkillOperMethod, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachSkillOperMethod = objvTeachCaseEN.TeachSkillOperMethod == "[null]" ? null :  objvTeachCaseEN.TeachSkillOperMethod; //教学技能实践操作方法
}
if (arrFldSet.Contains(convTeachCase.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.IdSkillType = objvTeachCaseEN.IdSkillType == "[null]" ? null :  objvTeachCaseEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convTeachCase.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.SkillTypeID = objvTeachCaseEN.SkillTypeID == "[null]" ? null :  objvTeachCaseEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convTeachCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.IdDiscipline = objvTeachCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(convTeachCase.DisciplineName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.DisciplineName = objvTeachCaseEN.DisciplineName; //学科名称
}
if (arrFldSet.Contains(convTeachCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.IdStudyLevel = objvTeachCaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convTeachCase.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.StudyLevelName = objvTeachCaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convTeachCase.TeachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachCaseDateIn = objvTeachCaseEN.TeachCaseDateIn == "[null]" ? null :  objvTeachCaseEN.TeachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(convTeachCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.IdTeachingPlan = objvTeachCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(convTeachCase.TeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.TeachCaseTimeIn = objvTeachCaseEN.TeachCaseTimeIn == "[null]" ? null :  objvTeachCaseEN.TeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(convTeachCase.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.WorkUnit = objvTeachCaseEN.WorkUnit == "[null]" ? null :  objvTeachCaseEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(convTeachCase.CDID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.CDID = objvTeachCaseEN.CDID == "[null]" ? null :  objvTeachCaseEN.CDID; //光盘编号
}
if (arrFldSet.Contains(convTeachCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.IsVisible = objvTeachCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convTeachCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.IsDualVideo = objvTeachCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(convTeachCase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.IdXzCollege = objvTeachCaseEN.IdXzCollege == "[null]" ? null :  objvTeachCaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convTeachCase.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.CollegeID = objvTeachCaseEN.CollegeID == "[null]" ? null :  objvTeachCaseEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convTeachCase.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.CollegeName = objvTeachCaseEN.CollegeName == "[null]" ? null :  objvTeachCaseEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convTeachCase.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.CollegeNameA = objvTeachCaseEN.CollegeNameA == "[null]" ? null :  objvTeachCaseEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(convTeachCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.RecommendedDegreeId = objvTeachCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(convTeachCase.RecommendedDegreeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.RecommendedDegreeName = objvTeachCaseEN.RecommendedDegreeName == "[null]" ? null :  objvTeachCaseEN.RecommendedDegreeName; //推荐度名称
}
if (arrFldSet.Contains(convTeachCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.ftpFileType = objvTeachCaseEN.ftpFileType == "[null]" ? null :  objvTeachCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(convTeachCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.VideoUrl = objvTeachCaseEN.VideoUrl == "[null]" ? null :  objvTeachCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(convTeachCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.VideoPath = objvTeachCaseEN.VideoPath == "[null]" ? null :  objvTeachCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(convTeachCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.ResErrMsg = objvTeachCaseEN.ResErrMsg == "[null]" ? null :  objvTeachCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(convTeachCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.Memo = objvTeachCaseEN.Memo == "[null]" ? null :  objvTeachCaseEN.Memo; //备注
}
if (arrFldSet.Contains(convTeachCase.BrowseCount4Case, new clsStrCompareIgnoreCase())  ==  true)
{
objvTeachCaseEN.BrowseCount4Case = objvTeachCaseEN.BrowseCount4Case; //课例浏览次数
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
 /// <param name = "objvTeachCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTeachCaseEN objvTeachCaseEN)
{
try
{
if (objvTeachCaseEN.TeachCaseExecutor == "[null]") objvTeachCaseEN.TeachCaseExecutor = null; //案例执教者
if (objvTeachCaseEN.TeachCaseTheme == "[null]") objvTeachCaseEN.TeachCaseTheme = null; //案例主题词
if (objvTeachCaseEN.TeachCaseBG == "[null]") objvTeachCaseEN.TeachCaseBG = null; //案例背景资料
if (objvTeachCaseEN.SkillTypeName == "[null]") objvTeachCaseEN.SkillTypeName = null; //技能类型名称
if (objvTeachCaseEN.TeachSkillTheory == "[null]") objvTeachCaseEN.TeachSkillTheory = null; //教学技能理论阐述
if (objvTeachCaseEN.TeachSkillOperMethod == "[null]") objvTeachCaseEN.TeachSkillOperMethod = null; //教学技能实践操作方法
if (objvTeachCaseEN.IdSkillType == "[null]") objvTeachCaseEN.IdSkillType = null; //技能类型流水号
if (objvTeachCaseEN.SkillTypeID == "[null]") objvTeachCaseEN.SkillTypeID = null; //技能类型ID
if (objvTeachCaseEN.TeachCaseDateIn == "[null]") objvTeachCaseEN.TeachCaseDateIn = null; //案例入库日期
if (objvTeachCaseEN.TeachCaseTimeIn == "[null]") objvTeachCaseEN.TeachCaseTimeIn = null; //案例入库时间
if (objvTeachCaseEN.WorkUnit == "[null]") objvTeachCaseEN.WorkUnit = null; //工作单位
if (objvTeachCaseEN.CDID == "[null]") objvTeachCaseEN.CDID = null; //光盘编号
if (objvTeachCaseEN.IdXzCollege == "[null]") objvTeachCaseEN.IdXzCollege = null; //学院流水号
if (objvTeachCaseEN.CollegeID == "[null]") objvTeachCaseEN.CollegeID = null; //学院ID
if (objvTeachCaseEN.CollegeName == "[null]") objvTeachCaseEN.CollegeName = null; //学院名称
if (objvTeachCaseEN.CollegeNameA == "[null]") objvTeachCaseEN.CollegeNameA = null; //学院名称简写
if (objvTeachCaseEN.RecommendedDegreeName == "[null]") objvTeachCaseEN.RecommendedDegreeName = null; //推荐度名称
if (objvTeachCaseEN.ftpFileType == "[null]") objvTeachCaseEN.ftpFileType = null; //ftp文件类型
if (objvTeachCaseEN.VideoUrl == "[null]") objvTeachCaseEN.VideoUrl = null; //视频Url
if (objvTeachCaseEN.VideoPath == "[null]") objvTeachCaseEN.VideoPath = null; //视频目录
if (objvTeachCaseEN.ResErrMsg == "[null]") objvTeachCaseEN.ResErrMsg = null; //资源错误信息
if (objvTeachCaseEN.Memo == "[null]") objvTeachCaseEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvTeachCaseEN objvTeachCaseEN)
{
 vTeachCaseDA.CheckProperty4Condition(objvTeachCaseEN);
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
//string strWhereCond = string.Format("1 = 1 order by IdTeachCase");
//if (arrvTeachCaseObjLstCache == null)
//{
//arrvTeachCaseObjLstCache = vTeachCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachCaseEN GetObjByIdTeachCaseCache(string strIdTeachCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTeachCaseEN._CurrTabName);
List<clsvTeachCaseEN> arrvTeachCaseObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCaseEN> arrvTeachCaseObjLst_Sel =
arrvTeachCaseObjLstCache
.Where(x=> x.IdTeachCase == strIdTeachCase 
);
if (arrvTeachCaseObjLst_Sel.Count() == 0)
{
   clsvTeachCaseEN obj = clsvTeachCaseBL.GetObjByIdTeachCase(strIdTeachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTeachCaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachCaseEN> GetAllvTeachCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvTeachCaseEN> arrvTeachCaseObjLstCache = GetObjLstCache(); 
return arrvTeachCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTeachCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTeachCaseEN._CurrTabName);
List<clsvTeachCaseEN> arrvTeachCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachCaseObjLstCache;
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
string strKey = string.Format("{0}", clsvTeachCaseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdTeachCase)
{
if (strInFldName != convTeachCase.IdTeachCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTeachCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTeachCase.AttributeName));
throw new Exception(strMsg);
}
var objvTeachCase = clsvTeachCaseBL.GetObjByIdTeachCaseCache(strIdTeachCase);
if (objvTeachCase == null) return "";
return objvTeachCase[strOutFldName].ToString();
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
int intRecCount = clsvTeachCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvTeachCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTeachCaseDA.GetRecCount();
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
int intRecCount = clsvTeachCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTeachCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTeachCaseEN objvTeachCaseCond)
{
List<clsvTeachCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTeachCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTeachCase.AttributeName)
{
if (objvTeachCaseCond.IsUpdated(strFldName) == false) continue;
if (objvTeachCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCaseCond[strFldName].ToString());
}
else
{
if (objvTeachCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTeachCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTeachCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTeachCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTeachCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTeachCaseCond[strFldName]));
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
 List<string> arrList = clsvTeachCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTeachCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTeachCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}