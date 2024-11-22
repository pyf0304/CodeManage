
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzGradeBaseBL
 表名:vXzGradeBase(01120130)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsvXzGradeBaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzGradeBaseEN GetObj(this K_IdGradeBase_vXzGradeBase myKey)
{
clsvXzGradeBaseEN objvXzGradeBaseEN = clsvXzGradeBaseBL.vXzGradeBaseDA.GetObjByIdGradeBase(myKey.Value);
return objvXzGradeBaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetIdGradeBase(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convXzGradeBase.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convXzGradeBase.IdGradeBase);
}
objvXzGradeBaseEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.IdGradeBase) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.IdGradeBase, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.IdGradeBase] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetGradeBaseId(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strGradeBaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseId, 4, convXzGradeBase.GradeBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeBaseId, 4, convXzGradeBase.GradeBaseId);
}
objvXzGradeBaseEN.GradeBaseId = strGradeBaseId; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.GradeBaseId) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.GradeBaseId, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.GradeBaseId] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetGradeBaseName(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convXzGradeBase.GradeBaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convXzGradeBase.GradeBaseName);
}
objvXzGradeBaseEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.GradeBaseName) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.GradeBaseName, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.GradeBaseName] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetGradeBaseNameA(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strGradeBaseNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseNameA, convXzGradeBase.GradeBaseNameA);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseNameA, 10, convXzGradeBase.GradeBaseNameA);
}
objvXzGradeBaseEN.GradeBaseNameA = strGradeBaseNameA; //年级名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.GradeBaseNameA) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.GradeBaseNameA, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.GradeBaseNameA] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetSchoolYear(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convXzGradeBase.SchoolYear);
}
objvXzGradeBaseEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.SchoolYear) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.SchoolYear, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.SchoolYear] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetSchoolTerm(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convXzGradeBase.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convXzGradeBase.SchoolTerm);
}
objvXzGradeBaseEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.SchoolTerm) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.SchoolTerm, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.SchoolTerm] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetEnterSchoolDate(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strEnterSchoolDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnterSchoolDate, 8, convXzGradeBase.EnterSchoolDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEnterSchoolDate, 8, convXzGradeBase.EnterSchoolDate);
}
objvXzGradeBaseEN.EnterSchoolDate = strEnterSchoolDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.EnterSchoolDate) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.EnterSchoolDate, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.EnterSchoolDate] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetCurrentTermSeq(this clsvXzGradeBaseEN objvXzGradeBaseEN, int intCurrentTermSeq, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intCurrentTermSeq, convXzGradeBase.CurrentTermSeq);
objvXzGradeBaseEN.CurrentTermSeq = intCurrentTermSeq; //当前学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.CurrentTermSeq) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.CurrentTermSeq, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.CurrentTermSeq] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetExecPlanTermIndex(this clsvXzGradeBaseEN objvXzGradeBaseEN, short? shtExecPlanTermIndex, string strComparisonOp="")
	{
objvXzGradeBaseEN.ExecPlanTermIndex = shtExecPlanTermIndex; //生成执行计划学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.ExecPlanTermIndex) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.ExecPlanTermIndex, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.ExecPlanTermIndex] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetSetEPTermIndexDate(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strSetEPTermIndexDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSetEPTermIndexDate, 8, convXzGradeBase.SetEPTermIndexDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSetEPTermIndexDate, 8, convXzGradeBase.SetEPTermIndexDate);
}
objvXzGradeBaseEN.SetEPTermIndexDate = strSetEPTermIndexDate; //设定执行计划学期日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.SetEPTermIndexDate) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.SetEPTermIndexDate, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.SetEPTermIndexDate] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetIsOffed(this clsvXzGradeBaseEN objvXzGradeBaseEN, bool bolIsOffed, string strComparisonOp="")
	{
objvXzGradeBaseEN.IsOffed = bolIsOffed; //是否毕业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.IsOffed) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.IsOffed, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.IsOffed] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetGradeIndex(this clsvXzGradeBaseEN objvXzGradeBaseEN, int? intGradeIndex, string strComparisonOp="")
	{
objvXzGradeBaseEN.GradeIndex = intGradeIndex; //年级序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.GradeIndex) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.GradeIndex, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.GradeIndex] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetBeginYearMonth(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strBeginYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, convXzGradeBase.BeginYearMonth);
}
objvXzGradeBaseEN.BeginYearMonth = strBeginYearMonth; //开始年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.BeginYearMonth) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.BeginYearMonth, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.BeginYearMonth] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetEndYearMonth(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strEndYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, convXzGradeBase.EndYearMonth);
}
objvXzGradeBaseEN.EndYearMonth = strEndYearMonth; //结束年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.EndYearMonth) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.EndYearMonth, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.EndYearMonth] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetAllowUpBaseInfo(this clsvXzGradeBaseEN objvXzGradeBaseEN, bool bolAllowUpBaseInfo, string strComparisonOp="")
	{
objvXzGradeBaseEN.AllowUpBaseInfo = bolAllowUpBaseInfo; //允许修改基本信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.AllowUpBaseInfo) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.AllowUpBaseInfo, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.AllowUpBaseInfo] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetPrefix(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strPrefix, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefix, 3, convXzGradeBase.Prefix);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrefix, 3, convXzGradeBase.Prefix);
}
objvXzGradeBaseEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.Prefix) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.Prefix, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.Prefix] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetPointCalcVersionId(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strPointCalcVersionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointCalcVersionId, convXzGradeBase.PointCalcVersionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointCalcVersionId, 2, convXzGradeBase.PointCalcVersionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPointCalcVersionId, 2, convXzGradeBase.PointCalcVersionId);
}
objvXzGradeBaseEN.PointCalcVersionId = strPointCalcVersionId; //绩点计算版本Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.PointCalcVersionId) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.PointCalcVersionId, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.PointCalcVersionId] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetModifyUserId(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, convXzGradeBase.ModifyUserId);
}
objvXzGradeBaseEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.ModifyUserId) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.ModifyUserId, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.ModifyUserId] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetModifyDate(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzGradeBase.ModifyDate);
}
objvXzGradeBaseEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.ModifyDate) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.ModifyDate, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.ModifyDate] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetIdStudyLevel(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, convXzGradeBase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, convXzGradeBase.IdStudyLevel);
}
objvXzGradeBaseEN.IdStudyLevel = strIdStudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.IdStudyLevel) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.IdStudyLevel, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.IdStudyLevel] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetStudyLevelName(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strStudyLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convXzGradeBase.StudyLevelName);
}
objvXzGradeBaseEN.StudyLevelName = strStudyLevelName; //学段名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.StudyLevelName) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.StudyLevelName, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.StudyLevelName] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetIsVisible(this clsvXzGradeBaseEN objvXzGradeBaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objvXzGradeBaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.IsVisible) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.IsVisible, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.IsVisible] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvXzGradeBaseEN SetMemo(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzGradeBase.Memo);
}
objvXzGradeBaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.Memo) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.Memo, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.Memo] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvXzGradeBaseENS">源对象</param>
 /// <param name = "objvXzGradeBaseENT">目标对象</param>
 public static void CopyTo(this clsvXzGradeBaseEN objvXzGradeBaseENS, clsvXzGradeBaseEN objvXzGradeBaseENT)
{
try
{
objvXzGradeBaseENT.IdGradeBase = objvXzGradeBaseENS.IdGradeBase; //年级流水号
objvXzGradeBaseENT.GradeBaseId = objvXzGradeBaseENS.GradeBaseId; //年级代号
objvXzGradeBaseENT.GradeBaseName = objvXzGradeBaseENS.GradeBaseName; //年级名称
objvXzGradeBaseENT.GradeBaseNameA = objvXzGradeBaseENS.GradeBaseNameA; //年级名称缩写
objvXzGradeBaseENT.SchoolYear = objvXzGradeBaseENS.SchoolYear; //学年
objvXzGradeBaseENT.SchoolTerm = objvXzGradeBaseENS.SchoolTerm; //学期
objvXzGradeBaseENT.EnterSchoolDate = objvXzGradeBaseENS.EnterSchoolDate; //进校日期
objvXzGradeBaseENT.CurrentTermSeq = objvXzGradeBaseENS.CurrentTermSeq; //当前学期
objvXzGradeBaseENT.ExecPlanTermIndex = objvXzGradeBaseENS.ExecPlanTermIndex; //生成执行计划学期
objvXzGradeBaseENT.SetEPTermIndexDate = objvXzGradeBaseENS.SetEPTermIndexDate; //设定执行计划学期日期
objvXzGradeBaseENT.IsOffed = objvXzGradeBaseENS.IsOffed; //是否毕业
objvXzGradeBaseENT.GradeIndex = objvXzGradeBaseENS.GradeIndex; //年级序号
objvXzGradeBaseENT.BeginYearMonth = objvXzGradeBaseENS.BeginYearMonth; //开始年月
objvXzGradeBaseENT.EndYearMonth = objvXzGradeBaseENS.EndYearMonth; //结束年月
objvXzGradeBaseENT.AllowUpBaseInfo = objvXzGradeBaseENS.AllowUpBaseInfo; //允许修改基本信息
objvXzGradeBaseENT.Prefix = objvXzGradeBaseENS.Prefix; //前缀
objvXzGradeBaseENT.PointCalcVersionId = objvXzGradeBaseENS.PointCalcVersionId; //绩点计算版本Id
objvXzGradeBaseENT.ModifyUserId = objvXzGradeBaseENS.ModifyUserId; //修改人
objvXzGradeBaseENT.ModifyDate = objvXzGradeBaseENS.ModifyDate; //修改日期
objvXzGradeBaseENT.IdStudyLevel = objvXzGradeBaseENS.IdStudyLevel; //id_StudyLevel
objvXzGradeBaseENT.StudyLevelName = objvXzGradeBaseENS.StudyLevelName; //学段名称
objvXzGradeBaseENT.IsVisible = objvXzGradeBaseENS.IsVisible; //是否显示
objvXzGradeBaseENT.Memo = objvXzGradeBaseENS.Memo; //备注
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
 /// <param name = "objvXzGradeBaseENS">源对象</param>
 /// <returns>目标对象=>clsvXzGradeBaseEN:objvXzGradeBaseENT</returns>
 public static clsvXzGradeBaseEN CopyTo(this clsvXzGradeBaseEN objvXzGradeBaseENS)
{
try
{
 clsvXzGradeBaseEN objvXzGradeBaseENT = new clsvXzGradeBaseEN()
{
IdGradeBase = objvXzGradeBaseENS.IdGradeBase, //年级流水号
GradeBaseId = objvXzGradeBaseENS.GradeBaseId, //年级代号
GradeBaseName = objvXzGradeBaseENS.GradeBaseName, //年级名称
GradeBaseNameA = objvXzGradeBaseENS.GradeBaseNameA, //年级名称缩写
SchoolYear = objvXzGradeBaseENS.SchoolYear, //学年
SchoolTerm = objvXzGradeBaseENS.SchoolTerm, //学期
EnterSchoolDate = objvXzGradeBaseENS.EnterSchoolDate, //进校日期
CurrentTermSeq = objvXzGradeBaseENS.CurrentTermSeq, //当前学期
ExecPlanTermIndex = objvXzGradeBaseENS.ExecPlanTermIndex, //生成执行计划学期
SetEPTermIndexDate = objvXzGradeBaseENS.SetEPTermIndexDate, //设定执行计划学期日期
IsOffed = objvXzGradeBaseENS.IsOffed, //是否毕业
GradeIndex = objvXzGradeBaseENS.GradeIndex, //年级序号
BeginYearMonth = objvXzGradeBaseENS.BeginYearMonth, //开始年月
EndYearMonth = objvXzGradeBaseENS.EndYearMonth, //结束年月
AllowUpBaseInfo = objvXzGradeBaseENS.AllowUpBaseInfo, //允许修改基本信息
Prefix = objvXzGradeBaseENS.Prefix, //前缀
PointCalcVersionId = objvXzGradeBaseENS.PointCalcVersionId, //绩点计算版本Id
ModifyUserId = objvXzGradeBaseENS.ModifyUserId, //修改人
ModifyDate = objvXzGradeBaseENS.ModifyDate, //修改日期
IdStudyLevel = objvXzGradeBaseENS.IdStudyLevel, //id_StudyLevel
StudyLevelName = objvXzGradeBaseENS.StudyLevelName, //学段名称
IsVisible = objvXzGradeBaseENS.IsVisible, //是否显示
Memo = objvXzGradeBaseENS.Memo, //备注
};
 return objvXzGradeBaseENT;
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
public static void CheckProperty4Condition(this clsvXzGradeBaseEN objvXzGradeBaseEN)
{
 clsvXzGradeBaseBL.vXzGradeBaseDA.CheckProperty4Condition(objvXzGradeBaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzGradeBaseEN objvXzGradeBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.IdGradeBase, objvXzGradeBaseCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.GradeBaseId) == true)
{
string strComparisonOpGradeBaseId = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.GradeBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.GradeBaseId, objvXzGradeBaseCond.GradeBaseId, strComparisonOpGradeBaseId);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.GradeBaseName, objvXzGradeBaseCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.GradeBaseNameA) == true)
{
string strComparisonOpGradeBaseNameA = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.GradeBaseNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.GradeBaseNameA, objvXzGradeBaseCond.GradeBaseNameA, strComparisonOpGradeBaseNameA);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.SchoolYear, objvXzGradeBaseCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.SchoolTerm, objvXzGradeBaseCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.EnterSchoolDate) == true)
{
string strComparisonOpEnterSchoolDate = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.EnterSchoolDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.EnterSchoolDate, objvXzGradeBaseCond.EnterSchoolDate, strComparisonOpEnterSchoolDate);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.CurrentTermSeq) == true)
{
string strComparisonOpCurrentTermSeq = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.CurrentTermSeq];
strWhereCond += string.Format(" And {0} {2} {1}", convXzGradeBase.CurrentTermSeq, objvXzGradeBaseCond.CurrentTermSeq, strComparisonOpCurrentTermSeq);
}
//数据类型short(smallint)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.SetEPTermIndexDate) == true)
{
string strComparisonOpSetEPTermIndexDate = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.SetEPTermIndexDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.SetEPTermIndexDate, objvXzGradeBaseCond.SetEPTermIndexDate, strComparisonOpSetEPTermIndexDate);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.IsOffed) == true)
{
if (objvXzGradeBaseCond.IsOffed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzGradeBase.IsOffed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzGradeBase.IsOffed);
}
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.GradeIndex) == true)
{
string strComparisonOpGradeIndex = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.GradeIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convXzGradeBase.GradeIndex, objvXzGradeBaseCond.GradeIndex, strComparisonOpGradeIndex);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.BeginYearMonth) == true)
{
string strComparisonOpBeginYearMonth = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.BeginYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.BeginYearMonth, objvXzGradeBaseCond.BeginYearMonth, strComparisonOpBeginYearMonth);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.EndYearMonth) == true)
{
string strComparisonOpEndYearMonth = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.EndYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.EndYearMonth, objvXzGradeBaseCond.EndYearMonth, strComparisonOpEndYearMonth);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.AllowUpBaseInfo) == true)
{
if (objvXzGradeBaseCond.AllowUpBaseInfo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzGradeBase.AllowUpBaseInfo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzGradeBase.AllowUpBaseInfo);
}
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.Prefix) == true)
{
string strComparisonOpPrefix = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.Prefix, objvXzGradeBaseCond.Prefix, strComparisonOpPrefix);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.PointCalcVersionId) == true)
{
string strComparisonOpPointCalcVersionId = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.PointCalcVersionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.PointCalcVersionId, objvXzGradeBaseCond.PointCalcVersionId, strComparisonOpPointCalcVersionId);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.ModifyUserId, objvXzGradeBaseCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.ModifyDate) == true)
{
string strComparisonOpModifyDate = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.ModifyDate, objvXzGradeBaseCond.ModifyDate, strComparisonOpModifyDate);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.IdStudyLevel, objvXzGradeBaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.StudyLevelName) == true)
{
string strComparisonOpStudyLevelName = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.StudyLevelName, objvXzGradeBaseCond.StudyLevelName, strComparisonOpStudyLevelName);
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.IsVisible) == true)
{
if (objvXzGradeBaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzGradeBase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzGradeBase.IsVisible);
}
}
if (objvXzGradeBaseCond.IsUpdated(convXzGradeBase.Memo) == true)
{
string strComparisonOpMemo = objvXzGradeBaseCond.dicFldComparisonOp[convXzGradeBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.Memo, objvXzGradeBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vXzGradeBase
{
public virtual bool UpdRelaTabDate(string strIdGradeBase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v年级(vXzGradeBase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvXzGradeBaseBL
{
public static RelatedActions_vXzGradeBase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvXzGradeBaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvXzGradeBaseDA vXzGradeBaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvXzGradeBaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvXzGradeBaseBL()
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
if (string.IsNullOrEmpty(clsvXzGradeBaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzGradeBaseEN._ConnectString);
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
public static DataTable GetDataTable_vXzGradeBase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vXzGradeBaseDA.GetDataTable_vXzGradeBase(strWhereCond);
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
objDT = vXzGradeBaseDA.GetDataTable(strWhereCond);
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
objDT = vXzGradeBaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vXzGradeBaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vXzGradeBaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vXzGradeBaseDA.GetDataTable_Top(objTopPara);
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
objDT = vXzGradeBaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vXzGradeBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vXzGradeBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdGradeBaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvXzGradeBaseEN> GetObjLstByIdGradeBaseLst(List<string> arrIdGradeBaseLst)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdGradeBaseLst, true);
 string strWhereCond = string.Format("IdGradeBase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdGradeBaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvXzGradeBaseEN> GetObjLstByIdGradeBaseLstCache(List<string> arrIdGradeBaseLst)
{
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName);
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLstCache = GetObjLstCache();
IEnumerable <clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Sel =
arrvXzGradeBaseObjLstCache
.Where(x => arrIdGradeBaseLst.Contains(x.IdGradeBase));
return arrvXzGradeBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGradeBaseEN> GetObjLst(string strWhereCond)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
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
public static List<clsvXzGradeBaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvXzGradeBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvXzGradeBaseEN> GetSubObjLstCache(clsvXzGradeBaseEN objvXzGradeBaseCond)
{
List<clsvXzGradeBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzGradeBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzGradeBase.AttributeName)
{
if (objvXzGradeBaseCond.IsUpdated(strFldName) == false) continue;
if (objvXzGradeBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzGradeBaseCond[strFldName].ToString());
}
else
{
if (objvXzGradeBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzGradeBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzGradeBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzGradeBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzGradeBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzGradeBaseCond[strFldName]));
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
public static List<clsvXzGradeBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
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
public static List<clsvXzGradeBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
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
List<clsvXzGradeBaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvXzGradeBaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGradeBaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvXzGradeBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
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
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
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
public static List<clsvXzGradeBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvXzGradeBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvXzGradeBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
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
public static List<clsvXzGradeBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGradeBaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvXzGradeBaseEN.IdGradeBase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvXzGradeBaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvXzGradeBase(ref clsvXzGradeBaseEN objvXzGradeBaseEN)
{
bool bolResult = vXzGradeBaseDA.GetvXzGradeBase(ref objvXzGradeBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzGradeBaseEN GetObjByIdGradeBase(string strIdGradeBase)
{
if (strIdGradeBase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdGradeBase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdGradeBase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdGradeBase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvXzGradeBaseEN objvXzGradeBaseEN = vXzGradeBaseDA.GetObjByIdGradeBase(strIdGradeBase);
return objvXzGradeBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvXzGradeBaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvXzGradeBaseEN objvXzGradeBaseEN = vXzGradeBaseDA.GetFirstObj(strWhereCond);
 return objvXzGradeBaseEN;
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
public static clsvXzGradeBaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvXzGradeBaseEN objvXzGradeBaseEN = vXzGradeBaseDA.GetObjByDataRow(objRow);
 return objvXzGradeBaseEN;
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
public static clsvXzGradeBaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvXzGradeBaseEN objvXzGradeBaseEN = vXzGradeBaseDA.GetObjByDataRow(objRow);
 return objvXzGradeBaseEN;
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
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <param name = "lstvXzGradeBaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzGradeBaseEN GetObjByIdGradeBaseFromList(string strIdGradeBase, List<clsvXzGradeBaseEN> lstvXzGradeBaseObjLst)
{
foreach (clsvXzGradeBaseEN objvXzGradeBaseEN in lstvXzGradeBaseObjLst)
{
if (objvXzGradeBaseEN.IdGradeBase == strIdGradeBase)
{
return objvXzGradeBaseEN;
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
 string strIdGradeBase;
 try
 {
 strIdGradeBase = new clsvXzGradeBaseDA().GetFirstID(strWhereCond);
 return strIdGradeBase;
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
 arrList = vXzGradeBaseDA.GetID(strWhereCond);
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
bool bolIsExist = vXzGradeBaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdGradeBase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vXzGradeBaseDA.IsExist(strIdGradeBase);
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
 bolIsExist = clsvXzGradeBaseDA.IsExistTable();
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
 bolIsExist = vXzGradeBaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvXzGradeBaseENS">源对象</param>
 /// <param name = "objvXzGradeBaseENT">目标对象</param>
 public static void CopyTo(clsvXzGradeBaseEN objvXzGradeBaseENS, clsvXzGradeBaseEN objvXzGradeBaseENT)
{
try
{
objvXzGradeBaseENT.IdGradeBase = objvXzGradeBaseENS.IdGradeBase; //年级流水号
objvXzGradeBaseENT.GradeBaseId = objvXzGradeBaseENS.GradeBaseId; //年级代号
objvXzGradeBaseENT.GradeBaseName = objvXzGradeBaseENS.GradeBaseName; //年级名称
objvXzGradeBaseENT.GradeBaseNameA = objvXzGradeBaseENS.GradeBaseNameA; //年级名称缩写
objvXzGradeBaseENT.SchoolYear = objvXzGradeBaseENS.SchoolYear; //学年
objvXzGradeBaseENT.SchoolTerm = objvXzGradeBaseENS.SchoolTerm; //学期
objvXzGradeBaseENT.EnterSchoolDate = objvXzGradeBaseENS.EnterSchoolDate; //进校日期
objvXzGradeBaseENT.CurrentTermSeq = objvXzGradeBaseENS.CurrentTermSeq; //当前学期
objvXzGradeBaseENT.ExecPlanTermIndex = objvXzGradeBaseENS.ExecPlanTermIndex; //生成执行计划学期
objvXzGradeBaseENT.SetEPTermIndexDate = objvXzGradeBaseENS.SetEPTermIndexDate; //设定执行计划学期日期
objvXzGradeBaseENT.IsOffed = objvXzGradeBaseENS.IsOffed; //是否毕业
objvXzGradeBaseENT.GradeIndex = objvXzGradeBaseENS.GradeIndex; //年级序号
objvXzGradeBaseENT.BeginYearMonth = objvXzGradeBaseENS.BeginYearMonth; //开始年月
objvXzGradeBaseENT.EndYearMonth = objvXzGradeBaseENS.EndYearMonth; //结束年月
objvXzGradeBaseENT.AllowUpBaseInfo = objvXzGradeBaseENS.AllowUpBaseInfo; //允许修改基本信息
objvXzGradeBaseENT.Prefix = objvXzGradeBaseENS.Prefix; //前缀
objvXzGradeBaseENT.PointCalcVersionId = objvXzGradeBaseENS.PointCalcVersionId; //绩点计算版本Id
objvXzGradeBaseENT.ModifyUserId = objvXzGradeBaseENS.ModifyUserId; //修改人
objvXzGradeBaseENT.ModifyDate = objvXzGradeBaseENS.ModifyDate; //修改日期
objvXzGradeBaseENT.IdStudyLevel = objvXzGradeBaseENS.IdStudyLevel; //id_StudyLevel
objvXzGradeBaseENT.StudyLevelName = objvXzGradeBaseENS.StudyLevelName; //学段名称
objvXzGradeBaseENT.IsVisible = objvXzGradeBaseENS.IsVisible; //是否显示
objvXzGradeBaseENT.Memo = objvXzGradeBaseENS.Memo; //备注
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
 /// <param name = "objvXzGradeBaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvXzGradeBaseEN objvXzGradeBaseEN)
{
try
{
objvXzGradeBaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvXzGradeBaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convXzGradeBase.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.IdGradeBase = objvXzGradeBaseEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convXzGradeBase.GradeBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.GradeBaseId = objvXzGradeBaseEN.GradeBaseId == "[null]" ? null :  objvXzGradeBaseEN.GradeBaseId; //年级代号
}
if (arrFldSet.Contains(convXzGradeBase.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.GradeBaseName = objvXzGradeBaseEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convXzGradeBase.GradeBaseNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.GradeBaseNameA = objvXzGradeBaseEN.GradeBaseNameA; //年级名称缩写
}
if (arrFldSet.Contains(convXzGradeBase.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.SchoolYear = objvXzGradeBaseEN.SchoolYear == "[null]" ? null :  objvXzGradeBaseEN.SchoolYear; //学年
}
if (arrFldSet.Contains(convXzGradeBase.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.SchoolTerm = objvXzGradeBaseEN.SchoolTerm == "[null]" ? null :  objvXzGradeBaseEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(convXzGradeBase.EnterSchoolDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.EnterSchoolDate = objvXzGradeBaseEN.EnterSchoolDate == "[null]" ? null :  objvXzGradeBaseEN.EnterSchoolDate; //进校日期
}
if (arrFldSet.Contains(convXzGradeBase.CurrentTermSeq, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.CurrentTermSeq = objvXzGradeBaseEN.CurrentTermSeq; //当前学期
}
if (arrFldSet.Contains(convXzGradeBase.ExecPlanTermIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.ExecPlanTermIndex = objvXzGradeBaseEN.ExecPlanTermIndex; //生成执行计划学期
}
if (arrFldSet.Contains(convXzGradeBase.SetEPTermIndexDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.SetEPTermIndexDate = objvXzGradeBaseEN.SetEPTermIndexDate == "[null]" ? null :  objvXzGradeBaseEN.SetEPTermIndexDate; //设定执行计划学期日期
}
if (arrFldSet.Contains(convXzGradeBase.IsOffed, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.IsOffed = objvXzGradeBaseEN.IsOffed; //是否毕业
}
if (arrFldSet.Contains(convXzGradeBase.GradeIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.GradeIndex = objvXzGradeBaseEN.GradeIndex; //年级序号
}
if (arrFldSet.Contains(convXzGradeBase.BeginYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.BeginYearMonth = objvXzGradeBaseEN.BeginYearMonth == "[null]" ? null :  objvXzGradeBaseEN.BeginYearMonth; //开始年月
}
if (arrFldSet.Contains(convXzGradeBase.EndYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.EndYearMonth = objvXzGradeBaseEN.EndYearMonth == "[null]" ? null :  objvXzGradeBaseEN.EndYearMonth; //结束年月
}
if (arrFldSet.Contains(convXzGradeBase.AllowUpBaseInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.AllowUpBaseInfo = objvXzGradeBaseEN.AllowUpBaseInfo; //允许修改基本信息
}
if (arrFldSet.Contains(convXzGradeBase.Prefix, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.Prefix = objvXzGradeBaseEN.Prefix == "[null]" ? null :  objvXzGradeBaseEN.Prefix; //前缀
}
if (arrFldSet.Contains(convXzGradeBase.PointCalcVersionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.PointCalcVersionId = objvXzGradeBaseEN.PointCalcVersionId; //绩点计算版本Id
}
if (arrFldSet.Contains(convXzGradeBase.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.ModifyUserId = objvXzGradeBaseEN.ModifyUserId == "[null]" ? null :  objvXzGradeBaseEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(convXzGradeBase.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.ModifyDate = objvXzGradeBaseEN.ModifyDate == "[null]" ? null :  objvXzGradeBaseEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(convXzGradeBase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.IdStudyLevel = objvXzGradeBaseEN.IdStudyLevel == "[null]" ? null :  objvXzGradeBaseEN.IdStudyLevel; //id_StudyLevel
}
if (arrFldSet.Contains(convXzGradeBase.StudyLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.StudyLevelName = objvXzGradeBaseEN.StudyLevelName == "[null]" ? null :  objvXzGradeBaseEN.StudyLevelName; //学段名称
}
if (arrFldSet.Contains(convXzGradeBase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.IsVisible = objvXzGradeBaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convXzGradeBase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvXzGradeBaseEN.Memo = objvXzGradeBaseEN.Memo == "[null]" ? null :  objvXzGradeBaseEN.Memo; //备注
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
 /// <param name = "objvXzGradeBaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvXzGradeBaseEN objvXzGradeBaseEN)
{
try
{
if (objvXzGradeBaseEN.GradeBaseId == "[null]") objvXzGradeBaseEN.GradeBaseId = null; //年级代号
if (objvXzGradeBaseEN.SchoolYear == "[null]") objvXzGradeBaseEN.SchoolYear = null; //学年
if (objvXzGradeBaseEN.SchoolTerm == "[null]") objvXzGradeBaseEN.SchoolTerm = null; //学期
if (objvXzGradeBaseEN.EnterSchoolDate == "[null]") objvXzGradeBaseEN.EnterSchoolDate = null; //进校日期
if (objvXzGradeBaseEN.SetEPTermIndexDate == "[null]") objvXzGradeBaseEN.SetEPTermIndexDate = null; //设定执行计划学期日期
if (objvXzGradeBaseEN.BeginYearMonth == "[null]") objvXzGradeBaseEN.BeginYearMonth = null; //开始年月
if (objvXzGradeBaseEN.EndYearMonth == "[null]") objvXzGradeBaseEN.EndYearMonth = null; //结束年月
if (objvXzGradeBaseEN.Prefix == "[null]") objvXzGradeBaseEN.Prefix = null; //前缀
if (objvXzGradeBaseEN.ModifyUserId == "[null]") objvXzGradeBaseEN.ModifyUserId = null; //修改人
if (objvXzGradeBaseEN.ModifyDate == "[null]") objvXzGradeBaseEN.ModifyDate = null; //修改日期
if (objvXzGradeBaseEN.IdStudyLevel == "[null]") objvXzGradeBaseEN.IdStudyLevel = null; //id_StudyLevel
if (objvXzGradeBaseEN.StudyLevelName == "[null]") objvXzGradeBaseEN.StudyLevelName = null; //学段名称
if (objvXzGradeBaseEN.Memo == "[null]") objvXzGradeBaseEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvXzGradeBaseEN objvXzGradeBaseEN)
{
 vXzGradeBaseDA.CheckProperty4Condition(objvXzGradeBaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdGradeBase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzGradeBase.IdGradeBase); 
List<clsvXzGradeBaseEN> arrObjLst = clsvXzGradeBaseBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN()
{
IdGradeBase = "0",
GradeBaseName = "选[v年级]..."
};
arrObjLst.Insert(0, objvXzGradeBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzGradeBase.IdGradeBase;
objComboBox.DisplayMember = convXzGradeBase.GradeBaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdGradeBase(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v年级]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convXzGradeBase.IdGradeBase); 
IEnumerable<clsvXzGradeBaseEN> arrObjLst = clsvXzGradeBaseBL.GetObjLst(strCondition);
objDDL.DataValueField = convXzGradeBase.IdGradeBase;
objDDL.DataTextField = convXzGradeBase.GradeBaseName;
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
public static void BindDdl_IdGradeBaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v年级]...","0");
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLst = GetAllvXzGradeBaseObjLstCache(); 
objDDL.DataValueField = convXzGradeBase.IdGradeBase;
objDDL.DataTextField = convXzGradeBase.GradeBaseName;
objDDL.DataSource = arrvXzGradeBaseObjLst;
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
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdGradeBase");
//if (arrvXzGradeBaseObjLstCache == null)
//{
//arrvXzGradeBaseObjLstCache = vXzGradeBaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzGradeBaseEN GetObjByIdGradeBaseCache(string strIdGradeBase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName);
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLstCache = GetObjLstCache();
IEnumerable <clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Sel =
arrvXzGradeBaseObjLstCache
.Where(x=> x.IdGradeBase == strIdGradeBase 
);
if (arrvXzGradeBaseObjLst_Sel.Count() == 0)
{
   clsvXzGradeBaseEN obj = clsvXzGradeBaseBL.GetObjByIdGradeBase(strIdGradeBase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvXzGradeBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGradeBaseNameByIdGradeBaseCache(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return "";
//获取缓存中的对象列表
clsvXzGradeBaseEN objvXzGradeBase = GetObjByIdGradeBaseCache(strIdGradeBase);
if (objvXzGradeBase == null) return "";
return objvXzGradeBase.GradeBaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdGradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdGradeBaseCache(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return "";
//获取缓存中的对象列表
clsvXzGradeBaseEN objvXzGradeBase = GetObjByIdGradeBaseCache(strIdGradeBase);
if (objvXzGradeBase == null) return "";
return objvXzGradeBase.GradeBaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzGradeBaseEN> GetAllvXzGradeBaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLstCache = GetObjLstCache(); 
return arrvXzGradeBaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvXzGradeBaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName);
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzGradeBaseObjLstCache;
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
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdGradeBase)
{
if (strInFldName != convXzGradeBase.IdGradeBase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convXzGradeBase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convXzGradeBase.AttributeName));
throw new Exception(strMsg);
}
var objvXzGradeBase = clsvXzGradeBaseBL.GetObjByIdGradeBaseCache(strIdGradeBase);
if (objvXzGradeBase == null) return "";
return objvXzGradeBase[strOutFldName].ToString();
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
int intRecCount = clsvXzGradeBaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvXzGradeBaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvXzGradeBaseDA.GetRecCount();
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
int intRecCount = clsvXzGradeBaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvXzGradeBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvXzGradeBaseEN objvXzGradeBaseCond)
{
List<clsvXzGradeBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvXzGradeBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convXzGradeBase.AttributeName)
{
if (objvXzGradeBaseCond.IsUpdated(strFldName) == false) continue;
if (objvXzGradeBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzGradeBaseCond[strFldName].ToString());
}
else
{
if (objvXzGradeBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvXzGradeBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvXzGradeBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvXzGradeBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvXzGradeBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvXzGradeBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvXzGradeBaseCond[strFldName]));
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
 List<string> arrList = clsvXzGradeBaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vXzGradeBaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vXzGradeBaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}