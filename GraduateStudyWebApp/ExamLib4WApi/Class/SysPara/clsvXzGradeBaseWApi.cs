
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzGradeBaseWApi
 表名:vXzGradeBase(01120130)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:13
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
public static class clsvXzGradeBaseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN Setid_GradeBase(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convXzGradeBase.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convXzGradeBase.id_GradeBase);
objvXzGradeBaseEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.id_GradeBase) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.id_GradeBase, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.id_GradeBase] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetGradeBaseID(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strGradeBaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseID, 4, convXzGradeBase.GradeBaseID);
clsCheckSql.CheckFieldForeignKey(strGradeBaseID, 4, convXzGradeBase.GradeBaseID);
objvXzGradeBaseEN.GradeBaseID = strGradeBaseID; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.GradeBaseID) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.GradeBaseID, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.GradeBaseID] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetGradeBaseName(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convXzGradeBase.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convXzGradeBase.GradeBaseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetGradeBaseNameA(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strGradeBaseNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseNameA, convXzGradeBase.GradeBaseNameA);
clsCheckSql.CheckFieldLen(strGradeBaseNameA, 10, convXzGradeBase.GradeBaseNameA);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetSchoolYear(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convXzGradeBase.SchoolYear);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetSchoolTerm(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convXzGradeBase.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convXzGradeBase.SchoolTerm);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetEnterSchoolDate(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strEnterSchoolDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnterSchoolDate, 8, convXzGradeBase.EnterSchoolDate);
clsCheckSql.CheckFieldForeignKey(strEnterSchoolDate, 8, convXzGradeBase.EnterSchoolDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetExecPlanTermIndex(this clsvXzGradeBaseEN objvXzGradeBaseEN, short shtExecPlanTermIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetSetEPTermIndexDate(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strSetEPTermIndexDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSetEPTermIndexDate, 8, convXzGradeBase.SetEPTermIndexDate);
clsCheckSql.CheckFieldForeignKey(strSetEPTermIndexDate, 8, convXzGradeBase.SetEPTermIndexDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetGradeIndex(this clsvXzGradeBaseEN objvXzGradeBaseEN, int intGradeIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetBeginYearMonth(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strBeginYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, convXzGradeBase.BeginYearMonth);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetEndYearMonth(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strEndYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, convXzGradeBase.EndYearMonth);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetPrefix(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strPrefix, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrefix, 3, convXzGradeBase.Prefix);
clsCheckSql.CheckFieldForeignKey(strPrefix, 3, convXzGradeBase.Prefix);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetPointCalcVersionId(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strPointCalcVersionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointCalcVersionId, convXzGradeBase.PointCalcVersionId);
clsCheckSql.CheckFieldLen(strPointCalcVersionId, 2, convXzGradeBase.PointCalcVersionId);
clsCheckSql.CheckFieldForeignKey(strPointCalcVersionId, 2, convXzGradeBase.PointCalcVersionId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetModifyUserID(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convXzGradeBase.ModifyUserID);
objvXzGradeBaseEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.ModifyUserID) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.ModifyUserID, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.ModifyUserID] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetModifyDate(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convXzGradeBase.ModifyDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN Setid_StudyLevel(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strid_StudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudyLevel, 4, convXzGradeBase.id_StudyLevel);
clsCheckSql.CheckFieldForeignKey(strid_StudyLevel, 4, convXzGradeBase.id_StudyLevel);
objvXzGradeBaseEN.id_StudyLevel = strid_StudyLevel; //id_StudyLevel
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvXzGradeBaseEN.dicFldComparisonOp.ContainsKey(convXzGradeBase.id_StudyLevel) == false)
{
objvXzGradeBaseEN.dicFldComparisonOp.Add(convXzGradeBase.id_StudyLevel, strComparisonOp);
}
else
{
objvXzGradeBaseEN.dicFldComparisonOp[convXzGradeBase.id_StudyLevel] = strComparisonOp;
}
}
return objvXzGradeBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetStudyLevelName(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strStudyLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStudyLevelName, 50, convXzGradeBase.StudyLevelName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvXzGradeBaseEN SetMemo(this clsvXzGradeBaseEN objvXzGradeBaseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convXzGradeBase.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvXzGradeBaseEN objvXzGradeBase_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.id_GradeBase, objvXzGradeBase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.GradeBaseID) == true)
{
string strComparisonOp_GradeBaseID = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.GradeBaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.GradeBaseID, objvXzGradeBase_Cond.GradeBaseID, strComparisonOp_GradeBaseID);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.GradeBaseName, objvXzGradeBase_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.GradeBaseNameA) == true)
{
string strComparisonOp_GradeBaseNameA = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.GradeBaseNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.GradeBaseNameA, objvXzGradeBase_Cond.GradeBaseNameA, strComparisonOp_GradeBaseNameA);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.SchoolYear, objvXzGradeBase_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.SchoolTerm, objvXzGradeBase_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.EnterSchoolDate) == true)
{
string strComparisonOp_EnterSchoolDate = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.EnterSchoolDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.EnterSchoolDate, objvXzGradeBase_Cond.EnterSchoolDate, strComparisonOp_EnterSchoolDate);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.CurrentTermSeq) == true)
{
string strComparisonOp_CurrentTermSeq = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.CurrentTermSeq];
strWhereCond += string.Format(" And {0} {2} {1}", convXzGradeBase.CurrentTermSeq, objvXzGradeBase_Cond.CurrentTermSeq, strComparisonOp_CurrentTermSeq);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.SetEPTermIndexDate) == true)
{
string strComparisonOp_SetEPTermIndexDate = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.SetEPTermIndexDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.SetEPTermIndexDate, objvXzGradeBase_Cond.SetEPTermIndexDate, strComparisonOp_SetEPTermIndexDate);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.IsOffed) == true)
{
if (objvXzGradeBase_Cond.IsOffed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzGradeBase.IsOffed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzGradeBase.IsOffed);
}
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.GradeIndex) == true)
{
string strComparisonOp_GradeIndex = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.GradeIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convXzGradeBase.GradeIndex, objvXzGradeBase_Cond.GradeIndex, strComparisonOp_GradeIndex);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.BeginYearMonth) == true)
{
string strComparisonOp_BeginYearMonth = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.BeginYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.BeginYearMonth, objvXzGradeBase_Cond.BeginYearMonth, strComparisonOp_BeginYearMonth);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.EndYearMonth) == true)
{
string strComparisonOp_EndYearMonth = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.EndYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.EndYearMonth, objvXzGradeBase_Cond.EndYearMonth, strComparisonOp_EndYearMonth);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.AllowUpBaseInfo) == true)
{
if (objvXzGradeBase_Cond.AllowUpBaseInfo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzGradeBase.AllowUpBaseInfo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzGradeBase.AllowUpBaseInfo);
}
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.Prefix) == true)
{
string strComparisonOp_Prefix = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.Prefix, objvXzGradeBase_Cond.Prefix, strComparisonOp_Prefix);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.PointCalcVersionId) == true)
{
string strComparisonOp_PointCalcVersionId = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.PointCalcVersionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.PointCalcVersionId, objvXzGradeBase_Cond.PointCalcVersionId, strComparisonOp_PointCalcVersionId);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.ModifyUserID, objvXzGradeBase_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.ModifyDate, objvXzGradeBase_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.id_StudyLevel) == true)
{
string strComparisonOp_id_StudyLevel = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.id_StudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.id_StudyLevel, objvXzGradeBase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.StudyLevelName) == true)
{
string strComparisonOp_StudyLevelName = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.StudyLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.StudyLevelName, objvXzGradeBase_Cond.StudyLevelName, strComparisonOp_StudyLevelName);
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.IsVisible) == true)
{
if (objvXzGradeBase_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convXzGradeBase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convXzGradeBase.IsVisible);
}
}
if (objvXzGradeBase_Cond.IsUpdated(convXzGradeBase.Memo) == true)
{
string strComparisonOp_Memo = objvXzGradeBase_Cond.dicFldComparisonOp[convXzGradeBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convXzGradeBase.Memo, objvXzGradeBase_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v年级(vXzGradeBase)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvXzGradeBaseWApi
{
private static readonly string mstrApiControllerName = "vXzGradeBaseApi";

 public clsvXzGradeBaseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_GradeBase(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v年级]...","0");
List<clsvXzGradeBaseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_GradeBase";
objDDL.DataTextField="GradeBaseName";
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
public static void BindCbo_id_GradeBase(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convXzGradeBase.id_GradeBase); 
List<clsvXzGradeBaseEN> arrObjLst = clsvXzGradeBaseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN()
{
id_GradeBase = "0",
GradeBaseName = "选[v年级]..."
};
arrObjLst.Insert(0, objvXzGradeBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convXzGradeBase.id_GradeBase;
objComboBox.DisplayMember = convXzGradeBase.GradeBaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_GradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzGradeBaseEN GetObjByid_GradeBase(string strid_GradeBase)
{
string strAction = "GetObjByid_GradeBase";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzGradeBaseEN objvXzGradeBaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_GradeBase"] = strid_GradeBase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzGradeBaseEN = JsonConvert.DeserializeObject<clsvXzGradeBaseEN>((string)jobjReturn["ReturnObj"]);
return objvXzGradeBaseEN;
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
 /// <param name = "strid_GradeBase">表关键字</param>
 /// <returns>表对象</returns>
public static clsvXzGradeBaseEN GetObjByid_GradeBase_WA_Cache(string strid_GradeBase)
{
string strAction = "GetObjByid_GradeBase_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzGradeBaseEN objvXzGradeBaseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_GradeBase"] = strid_GradeBase
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvXzGradeBaseEN = JsonConvert.DeserializeObject<clsvXzGradeBaseEN>((string)jobjReturn["ReturnObj"]);
return objvXzGradeBaseEN;
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
public static clsvXzGradeBaseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvXzGradeBaseEN objvXzGradeBaseEN = null;
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
objvXzGradeBaseEN = JsonConvert.DeserializeObject<clsvXzGradeBaseEN>((string)jobjReturn["ReturnObj"]);
return objvXzGradeBaseEN;
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
 /// <param name = "strid_GradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvXzGradeBaseEN GetObjByid_GradeBase_Cache(string strid_GradeBase)
{
if (string.IsNullOrEmpty(strid_GradeBase) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName_S);
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Sel =
from objvXzGradeBaseEN in arrvXzGradeBaseObjLst_Cache
where objvXzGradeBaseEN.id_GradeBase == strid_GradeBase
select objvXzGradeBaseEN;
if (arrvXzGradeBaseObjLst_Sel.Count() == 0)
{
   clsvXzGradeBaseEN obj = clsvXzGradeBaseWApi.GetObjByid_GradeBase(strid_GradeBase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvXzGradeBaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_GradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGradeBaseNameByid_GradeBase_Cache(string strid_GradeBase)
{
if (string.IsNullOrEmpty(strid_GradeBase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName_S);
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Sel1 =
from objvXzGradeBaseEN in arrvXzGradeBaseObjLst_Cache
where objvXzGradeBaseEN.id_GradeBase == strid_GradeBase
select objvXzGradeBaseEN;
List <clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Sel = new List<clsvXzGradeBaseEN>();
foreach (clsvXzGradeBaseEN obj in arrvXzGradeBaseObjLst_Sel1)
{
arrvXzGradeBaseObjLst_Sel.Add(obj);
}
if (arrvXzGradeBaseObjLst_Sel.Count > 0)
{
return arrvXzGradeBaseObjLst_Sel[0].GradeBaseName;
}
string strErrMsgForGetObjById = string.Format("在vXzGradeBase对象缓存列表中,找不到记录[id_GradeBase = {0}](函数:{1})", strid_GradeBase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzGradeBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_GradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_GradeBase_Cache(string strid_GradeBase)
{
if (string.IsNullOrEmpty(strid_GradeBase) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName_S);
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Sel1 =
from objvXzGradeBaseEN in arrvXzGradeBaseObjLst_Cache
where objvXzGradeBaseEN.id_GradeBase == strid_GradeBase
select objvXzGradeBaseEN;
List <clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Sel = new List<clsvXzGradeBaseEN>();
foreach (clsvXzGradeBaseEN obj in arrvXzGradeBaseObjLst_Sel1)
{
arrvXzGradeBaseObjLst_Sel.Add(obj);
}
if (arrvXzGradeBaseObjLst_Sel.Count > 0)
{
return arrvXzGradeBaseObjLst_Sel[0].GradeBaseName;
}
string strErrMsgForGetObjById = string.Format("在vXzGradeBase对象缓存列表中,找不到记录的相关名称[id_GradeBase = {0}](函数:{1})", strid_GradeBase, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvXzGradeBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGradeBaseEN> GetObjLst(string strWhereCond)
{
 List<clsvXzGradeBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGradeBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGradeBaseEN> GetObjLstById_GradeBaseLst(List<string> arrId_GradeBase)
{
 List<clsvXzGradeBaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_GradeBaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_GradeBase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGradeBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_GradeBase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvXzGradeBaseEN> GetObjLstById_GradeBaseLst_Cache(List<string> arrId_GradeBase)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName_S);
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Sel =
from objvXzGradeBaseEN in arrvXzGradeBaseObjLst_Cache
where arrId_GradeBase.Contains(objvXzGradeBaseEN.id_GradeBase)
select objvXzGradeBaseEN;
return arrvXzGradeBaseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvXzGradeBaseEN> GetObjLstById_GradeBaseLst_WA_Cache(List<string> arrId_GradeBase)
{
 List<clsvXzGradeBaseEN> arrObjLst = null; 
string strAction = "GetObjLstById_GradeBaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_GradeBase);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGradeBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGradeBaseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvXzGradeBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGradeBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGradeBaseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvXzGradeBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGradeBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGradeBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvXzGradeBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGradeBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvXzGradeBaseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvXzGradeBaseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvXzGradeBaseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_GradeBase)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_GradeBase"] = strid_GradeBase
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
 /// <param name = "objvXzGradeBaseENS">源对象</param>
 /// <param name = "objvXzGradeBaseENT">目标对象</param>
 public static void CopyTo(clsvXzGradeBaseEN objvXzGradeBaseENS, clsvXzGradeBaseEN objvXzGradeBaseENT)
{
try
{
objvXzGradeBaseENT.id_GradeBase = objvXzGradeBaseENS.id_GradeBase; //年级流水号
objvXzGradeBaseENT.GradeBaseID = objvXzGradeBaseENS.GradeBaseID; //年级代号
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
objvXzGradeBaseENT.ModifyUserID = objvXzGradeBaseENS.ModifyUserID; //修改人
objvXzGradeBaseENT.ModifyDate = objvXzGradeBaseENS.ModifyDate; //修改日期
objvXzGradeBaseENT.id_StudyLevel = objvXzGradeBaseENS.id_StudyLevel; //id_StudyLevel
objvXzGradeBaseENT.StudyLevelName = objvXzGradeBaseENS.StudyLevelName; //学段名称
objvXzGradeBaseENT.IsVisible = objvXzGradeBaseENS.IsVisible; //是否显示
objvXzGradeBaseENT.Memo = objvXzGradeBaseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvXzGradeBaseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvXzGradeBaseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvXzGradeBaseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvXzGradeBaseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvXzGradeBaseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvXzGradeBaseEN.AttributeName)
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
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_GradeBase");
//if (arrvXzGradeBaseObjLst_Cache == null)
//{
//arrvXzGradeBaseObjLst_Cache = await clsvXzGradeBaseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName_S);
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
public static List<clsvXzGradeBaseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvXzGradeBaseEN._CurrTabName_S);
List<clsvXzGradeBaseEN> arrvXzGradeBaseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvXzGradeBaseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvXzGradeBaseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convXzGradeBase.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.GradeBaseID, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.GradeBaseNameA, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.EnterSchoolDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.CurrentTermSeq, Type.GetType("System.Int32"));
objDT.Columns.Add(convXzGradeBase.ExecPlanTermIndex, Type.GetType("System.Int16"));
objDT.Columns.Add(convXzGradeBase.SetEPTermIndexDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.IsOffed, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzGradeBase.GradeIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convXzGradeBase.BeginYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.EndYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.AllowUpBaseInfo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzGradeBase.Prefix, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.PointCalcVersionId, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.id_StudyLevel, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.StudyLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convXzGradeBase.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convXzGradeBase.Memo, Type.GetType("System.String"));
foreach (clsvXzGradeBaseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convXzGradeBase.id_GradeBase] = objInFor[convXzGradeBase.id_GradeBase];
objDR[convXzGradeBase.GradeBaseID] = objInFor[convXzGradeBase.GradeBaseID];
objDR[convXzGradeBase.GradeBaseName] = objInFor[convXzGradeBase.GradeBaseName];
objDR[convXzGradeBase.GradeBaseNameA] = objInFor[convXzGradeBase.GradeBaseNameA];
objDR[convXzGradeBase.SchoolYear] = objInFor[convXzGradeBase.SchoolYear];
objDR[convXzGradeBase.SchoolTerm] = objInFor[convXzGradeBase.SchoolTerm];
objDR[convXzGradeBase.EnterSchoolDate] = objInFor[convXzGradeBase.EnterSchoolDate];
objDR[convXzGradeBase.CurrentTermSeq] = objInFor[convXzGradeBase.CurrentTermSeq];
objDR[convXzGradeBase.ExecPlanTermIndex] = objInFor[convXzGradeBase.ExecPlanTermIndex];
objDR[convXzGradeBase.SetEPTermIndexDate] = objInFor[convXzGradeBase.SetEPTermIndexDate];
objDR[convXzGradeBase.IsOffed] = objInFor[convXzGradeBase.IsOffed];
objDR[convXzGradeBase.GradeIndex] = objInFor[convXzGradeBase.GradeIndex];
objDR[convXzGradeBase.BeginYearMonth] = objInFor[convXzGradeBase.BeginYearMonth];
objDR[convXzGradeBase.EndYearMonth] = objInFor[convXzGradeBase.EndYearMonth];
objDR[convXzGradeBase.AllowUpBaseInfo] = objInFor[convXzGradeBase.AllowUpBaseInfo];
objDR[convXzGradeBase.Prefix] = objInFor[convXzGradeBase.Prefix];
objDR[convXzGradeBase.PointCalcVersionId] = objInFor[convXzGradeBase.PointCalcVersionId];
objDR[convXzGradeBase.ModifyUserID] = objInFor[convXzGradeBase.ModifyUserID];
objDR[convXzGradeBase.ModifyDate] = objInFor[convXzGradeBase.ModifyDate];
objDR[convXzGradeBase.id_StudyLevel] = objInFor[convXzGradeBase.id_StudyLevel];
objDR[convXzGradeBase.StudyLevelName] = objInFor[convXzGradeBase.StudyLevelName];
objDR[convXzGradeBase.IsVisible] = objInFor[convXzGradeBase.IsVisible];
objDR[convXzGradeBase.Memo] = objInFor[convXzGradeBase.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}